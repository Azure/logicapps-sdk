#requires -Version 7.0
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$ResultsDirectory,
    [string]$BaselineResultsDirectory,
    [Parameter(Mandatory)][string]$OutputDirectory,
    [string]$DeclarationManifestPath,
    [ValidateNotNullOrEmpty()][string[]]$CaseIds = @(
        'CustomToString', 'DecimalBodiesAtBoundary', 'DecimalBodiesBelowBoundary',
        'EnumClrToString', 'EnumComparisonFalse', 'EnumComparisonTrue', 'EnumNativeArgument',
        'EnumRuntimeConditional', 'EnumRuntimeConditionalFallback', 'EnumRuntimeMethod',
        'NativeConstructor', 'NullableEnumFailure', 'NullableEnumNumber', 'NullableEnumWire',
        'TypedBodyLinq', 'TypedBodyLinqEmpty', 'TypedBodyLinqInvalid', 'TypedDecimalBody',
        'UserDefinedOperator'
    )
)
$ErrorActionPreference = 'Stop'
$outputRoot = [IO.Path]::GetFullPath($OutputDirectory)
if (Test-Path -LiteralPath $outputRoot) { throw 'OutputDirectory must be fresh; nothing will be overwritten.' }
if (-not $CaseIds.Count -or @($CaseIds | Sort-Object -Unique).Count -ne $CaseIds.Count) {
    throw 'Select at least one case, with no duplicate IDs.'
}
foreach ($id in $CaseIds) {
    if ($id -cnotmatch '^[A-Za-z][A-Za-z0-9_-]*$' -or $id -match '^(CON|PRN|AUX|NUL|COM[0-9]|LPT[0-9])$') {
        throw "Unsafe case ID: $id"
    }
}

$utf8 = [Text.UTF8Encoding]::new($false)
$prettyOptions = [System.Text.Json.JsonSerializerOptions]::new()
$prettyOptions.WriteIndented = $true
$prettyOptions.Encoder = [System.Text.Encodings.Web.JavaScriptEncoder]::UnsafeRelaxedJsonEscaping
$documents = [System.Collections.Generic.List[System.Text.Json.JsonDocument]]::new()
$copies = [System.Collections.Generic.List[object]]::new()
$embeddedSources = [System.Collections.Generic.List[object]]::new()
$bundleDetails = [System.Collections.Generic.List[object]]::new()

function Read-Json([string]$path) {
    $document = [System.Text.Json.JsonDocument]::Parse([IO.File]::ReadAllText($path))
    $documents.Add($document)
    return $document.RootElement
}
function Pretty-Json([System.Text.Json.JsonElement]$element) {
    return [System.Text.Json.JsonSerializer]::Serialize($element, $prettyOptions)
}
function Hash([string]$path) { return (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash }
function Hash-Bytes([byte[]]$bytes) {
    $algorithm = [Security.Cryptography.SHA256]::Create()
    try { return [BitConverter]::ToString($algorithm.ComputeHash($bytes)).Replace('-', '') }
    finally { $algorithm.Dispose() }
}
function Json-String([System.Text.Json.JsonElement]$element) {
    if ($element.ValueKind -ne [System.Text.Json.JsonValueKind]::String) { throw 'Expected a declaration JSON string.' }
    return $element.GetString()
}
function Assert-UnambiguousJson([System.Text.Json.JsonElement]$element) {
    if ($element.ValueKind -eq [System.Text.Json.JsonValueKind]::Object) {
        $names = [Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
        foreach ($property in $element.EnumerateObject()) {
            if (-not $names.Add($property.Name)) { throw "Duplicate declaration JSON property: $($property.Name)" }
            Assert-UnambiguousJson $property.Value
        }
    } elseif ($element.ValueKind -eq [System.Text.Json.JsonValueKind]::Array) {
        foreach ($item in $element.EnumerateArray()) { Assert-UnambiguousJson $item }
    }
}
function Write-StringArray($writer, [string]$name, [System.Text.Json.JsonElement]$array) {
    if ($array.ValueKind -ne [System.Text.Json.JsonValueKind]::Array) { throw "Expected declaration array: $name" }
    $writer.WriteStartArray($name)
    foreach ($value in $array.EnumerateArray()) { $writer.WriteStringValue([string](Json-String $value)) }
    $writer.WriteEndArray()
}
function Bundle-Id([System.Text.Json.JsonElement]$bundle) {
    # Preserve the removed WorkflowDeclarationBundle.ComputeId's historical format.
    # Mirror its property order and default STJ
    # escaping, not the manifest's whitespace, property order, or display encoder.
    $stream = [IO.MemoryStream]::new()
    $writer = [System.Text.Json.Utf8JsonWriter]::new($stream, [System.Text.Json.JsonWriterOptions]::new())
    try {
        $writer.WriteStartObject()
        $writer.WriteNumber('version', $bundle.GetProperty('version').GetInt32())
        foreach ($name in @('assemblyIdentity', 'languageVersion', 'nullableContextOptions')) {
            $writer.WriteString($name, [string](Json-String $bundle.GetProperty($name)))
        }
        foreach ($name in @('checkOverflow', 'allowUnsafe')) { $writer.WriteBoolean($name, $bundle.GetProperty($name).GetBoolean()) }
        Write-StringArray $writer 'defines' $bundle.GetProperty('defines')
        $writer.WriteStartArray('sources')
        foreach ($source in $bundle.GetProperty('sources').EnumerateArray()) {
            $writer.WriteStartObject()
            foreach ($name in @('path', 'content', 'sha256')) {
                $writer.WriteString($name, [string](Json-String $source.GetProperty($name)))
            }
            $writer.WriteEndObject()
        }
        $writer.WriteEndArray()
        Write-StringArray $writer 'types' $bundle.GetProperty('types')
        $writer.WriteStartArray('references')
        foreach ($reference in $bundle.GetProperty('references').EnumerateArray()) {
            $writer.WriteStartObject()
            $writer.WriteString('assemblyIdentity', [string](Json-String $reference.GetProperty('assemblyIdentity')))
            Write-StringArray $writer 'aliases' $reference.GetProperty('aliases')
            $writer.WriteBoolean('embedInteropTypes', $reference.GetProperty('embedInteropTypes').GetBoolean())
            $writer.WriteEndObject()
        }
        $writer.WriteEndArray()
        $writer.WriteEndObject()
        $writer.Flush()
        return Hash-Bytes $stream.ToArray()
    } finally {
        $writer.Dispose()
        $stream.Dispose()
    }
}
function Assert-SourceFilename([string]$name) {
    if ($name.Length -gt 255 -or $name -cnotmatch '^[A-Za-z0-9_][A-Za-z0-9_.,=+-]*\.cs$' -or
        $name -match '^(CON|PRN|AUX|NUL|COM[0-9]|LPT[0-9])(?:\.|$)') {
        throw "Unsafe declaration source filename: $name. Only simple .cs filenames are accepted."
    }
}
function Queue-Copy([string]$source, [string]$destination, [string]$recordedHash) {
    $actual = Hash $source
    if ($recordedHash -and ($recordedHash -notmatch '^[a-fA-F0-9]{64}$' -or $actual -ne $recordedHash)) {
        throw "SHA256 mismatch: $source (recorded $recordedHash, current $actual). Use the exact evidence/source snapshot; do not regenerate it."
    }
    $copies.Add([pscustomobject]@{ source = $source; path = $destination; sha256 = $actual; recordedSha256 = $recordedHash })
}
function Write-Text([string]$relative, [string]$text) {
    $path = Join-Path $outputRoot $relative
    [IO.Directory]::CreateDirectory([IO.Path]::GetDirectoryName($path)) | Out-Null
    [IO.File]::WriteAllText($path, $text, $utf8)
}
function Cell($value) {
    if ($null -eq $value) { return '(not recorded)' }
    return [System.Net.WebUtility]::HtmlEncode([string]$value).Replace('|', '&#124;').Replace("`r", '').Replace("`n", '<br>')
}
function Link([string]$path) {
    return (($path -split '[\\/]' | ForEach-Object { [Uri]::EscapeDataString($_) }) -join '/')
}
function Add-Block($lines, [string]$language, [string]$text) {
    # A variable fence also works for raw bodies containing Markdown code fences.
    $length = 3
    foreach ($match in [regex]::Matches($text, '`+')) { $length = [Math]::Max($length, $match.Length + 1) }
    $fence = '`' * $length
    $lines.Add($fence + $language)
    $lines.Add($text)
    $lines.Add($fence)
    $lines.Add('')
}

try {
    # An explicit allowlist excludes host settings, logs, build outputs, and private binaries.
    $sourcePaths = @(
        'CaseCatalog.cs', 'ComparisonReport.cs', 'Program.cs', 'WorkflowCaseAttribute.cs',
        'SourceExpressionE2E.csproj', 'case-coverage.json', 'Probe.ps1', 'Run-Local.ps1',
        'Test-CompileCases.ps1', 'Test-IsolatedCases.ps1', 'Write-Report.ps1'
        Get-ChildItem -LiteralPath (Join-Path $PSScriptRoot 'Workflows') -Filter '*.cs' -File |
            ForEach-Object { "Workflows\$($_.Name)" }
        Get-ChildItem -LiteralPath (Join-Path $PSScriptRoot 'CompileCases') -Filter '*.cs.txt' -File |
            ForEach-Object { "CompileCases\$($_.Name)" }
    )
    $sourceForCase = @{}
    foreach ($id in $CaseIds) {
        # Locate the attribute only, never cut a C# method out with a brace/regex heuristic.
        $pattern = '\[\s*WorkflowCase(?:Attribute)?\s*\(\s*"' + [regex]::Escape($id) + '"\s*,'
        $matches = @($sourcePaths | Where-Object {
            $_ -like 'Workflows\*.cs' -and [regex]::IsMatch([IO.File]::ReadAllText((Join-Path $PSScriptRoot $_)), $pattern)
        })
        if ($matches.Count -ne 1) { throw "Expected one original WorkflowCase source file for $id; found $($matches.Count)." }
        $sourceForCase[$id] = $matches[0]
    }

    $runs = [ordered]@{ current = $ResultsDirectory }
    if ($BaselineResultsDirectory) { $runs.baseline = $BaselineResultsDirectory }
    $evidence = [ordered]@{}
    foreach ($side in $runs.Keys) {
        $root = (Resolve-Path -LiteralPath $runs[$side]).Path
        $resultPath = Join-Path $root 'results.json'
        $resultJson = Read-Json $resultPath
        $result = $resultJson.GetRawText() | ConvertFrom-Json -AsHashtable
        if ($result.evidenceKind -ne 'actual-local-codeful-workflow-regression' -or -not $result.assemblies.Count) {
            throw "Not actual-host evidence with assembly provenance: $resultPath"
        }
        Queue-Copy $resultPath "$side\results.json"
        $fingerprintPath = Join-Path $root 'source-fingerprints.json'
        $fingerprintJson = Read-Json $fingerprintPath
        $fingerprints = @{}
        foreach ($entry in ($fingerprintJson.GetRawText() | ConvertFrom-Json -AsHashtable)) {
            $key = $entry.path.Replace('/', '\')
            if ($fingerprints.ContainsKey($key)) { throw "Duplicate source fingerprint: $key" }
            $fingerprints[$key] = $entry.sha256
        }
        Queue-Copy $fingerprintPath "$side\source-fingerprints.json"
        foreach ($relative in $sourcePaths) {
            if (-not $fingerprints[$relative]) { throw "Missing $side source fingerprint for $relative." }
            $source = Join-Path $PSScriptRoot $relative
            if ((Hash $source) -ne $fingerprints[$relative]) {
                throw "$side source SHA256 mismatch for $relative. Restore the recorded source snapshot before exporting."
            }
            if ($side -eq 'current') { Queue-Copy $source "sources\$relative" $fingerprints[$relative] }
        }

        $byId = @{}
        foreach ($element in $resultJson.GetProperty('results').EnumerateArray()) {
            $id = $element.GetProperty('id').GetString()
            if ($byId.ContainsKey($id)) { throw "Duplicate $side result ID: $id" }
            $byId[$id] = $element
        }
        $generation = @{}
        $generationPath = Join-Path $root 'definitions\generation-results.json'
        if (Test-Path -LiteralPath $generationPath) {
            $generationJson = Read-Json $generationPath
            foreach ($entry in $generationJson.EnumerateArray()) {
                $id = $entry.GetProperty('case').GetProperty('id').GetString()
                if ($generation.ContainsKey($id)) { throw "Duplicate generation ID: $id" }
                $generation[$id] = $entry
            }
        }
        $selected = [System.Collections.Generic.List[object]]::new()
        foreach ($id in $CaseIds) {
            if (-not $byId.ContainsKey($id)) { throw "Missing $side result: $id" }
            $element = $byId[$id]
            $observation = $element.GetRawText() | ConvertFrom-Json -AsHashtable
            $definition = $null
            if ($observation.generationStatus -eq 'Generated' -or $observation.definitionSha256) {
                if (-not $observation.definitionSha256) { throw "Missing recorded $side definition SHA256: $id" }
                $definitionPath = Join-Path $root "definitions\$id\workflow.json"
                Queue-Copy $definitionPath "$side\cases\$id\workflow.json" $observation.definitionSha256
                $definition = Read-Json $definitionPath
            }
            $selected.Add([pscustomobject]@{
                id = $id; raw = $element; observation = $observation; definition = $definition
                generation = $generation[$id]
            })
        }
        $prototype = $null
        $prototypePath = Join-Path $root 'prototype-provenance.json'
        if (Test-Path -LiteralPath $prototypePath) {
            Queue-Copy $prototypePath "$side\prototype-provenance.json"
            $prototype = Read-Json $prototypePath
        }
        $implementation = $null
        $implementationPath = Join-Path $root 'implementation-provenance.json'
        if (Test-Path -LiteralPath $implementationPath) {
            $implementation = Read-Json $implementationPath
            Assert-UnambiguousJson $implementation
            $implementationHash = Json-String $implementation.GetProperty('manifestSha256')
            if ($implementationHash -notmatch '^[a-fA-F0-9]{64}$') { throw "Invalid implementation manifest SHA256: $implementationPath" }
            Queue-Copy $implementationPath "$side\implementation-provenance.json"
        }
        $profile = $null
        $profilePath = Join-Path $root 'host-profile.json'
        if (Test-Path -LiteralPath $profilePath) {
            $profile = Read-Json $profilePath
            if ($profile.ValueKind -ne [System.Text.Json.JsonValueKind]::Object) { throw "Host profile must be a JSON object: $profilePath" }
            Assert-UnambiguousJson $profile
            Queue-Copy $profilePath "$side\host-profile.json"
        }
        $evidence[$side] = [pscustomobject]@{
            root = $root; raw = $resultJson; cases = $selected
            prototype = $prototype; implementation = $implementation; profile = $profile
        }
    }

    $declarationJson = $null
    $declarationKind = 'none'
    $declarationManifestHash = $null
    $declarationManifestBoundToCurrentImplementation = $false
    $declarationBinding = 'No declaration manifest supplied; bundle dependencies are not independently verified.'
    if ($DeclarationManifestPath) {
        $manifestPath = (Resolve-Path -LiteralPath $DeclarationManifestPath).Path
        $declarationJson = Read-Json $manifestPath
        if ($declarationJson.ValueKind -ne [System.Text.Json.JsonValueKind]::Object) { throw 'Declaration manifest must be a JSON object.' }
        Assert-UnambiguousJson $declarationJson
        $manifest = $declarationJson.GetRawText() | ConvertFrom-Json -AsHashtable
        $recordedManifestHash = $null
        $bundles = [System.Text.Json.JsonElement]::new()
        $hasBundles = $declarationJson.TryGetProperty('declarationBundles', [ref]$bundles)
        if ($hasBundles -or $manifest.version -eq 2) {
            if ($declarationJson.GetProperty('version').GetInt32() -ne 2 -or -not $hasBundles -or
                $bundles.ValueKind -ne [System.Text.Json.JsonValueKind]::Array -or $bundles.GetArrayLength() -eq 0) {
                throw 'SDK v2 manifests require a nonempty declarationBundles array.'
            }
            $declarationKind = 'sdk-v2'
            $seenBundles = @{}
            foreach ($bundle in $bundles.EnumerateArray()) {
                $id = Json-String $bundle.GetProperty('id')
                if ($bundle.GetProperty('version').GetInt32() -ne 1 -or $id -notmatch '^[a-fA-F0-9]{64}$') {
                    throw 'Unsupported declaration bundle version or invalid bundle ID.'
                }
                if ($seenBundles.ContainsKey($id)) { throw "Duplicate declaration bundle ID: $id" }
                $seenBundles[$id] = $true
                $sources = $bundle.GetProperty('sources')
                if ($sources.ValueKind -ne [System.Text.Json.JsonValueKind]::Array -or $sources.GetArrayLength() -eq 0) {
                    throw "Declaration bundle $id requires a nonempty sources array."
                }
                $seenSources = @{}
                foreach ($source in $sources.EnumerateArray()) {
                    $name = Json-String $source.GetProperty('path')
                    Assert-SourceFilename $name
                    if ($seenSources.ContainsKey($name)) { throw "Duplicate declaration source filename: $name" }
                    $seenSources[$name] = $true
                    $content = Json-String $source.GetProperty('content')
                    $recorded = Json-String $source.GetProperty('sha256')
                    $actual = Hash-Bytes $utf8.GetBytes($content)
                    if ($recorded -notmatch '^[a-fA-F0-9]{64}$' -or $actual -ne $recorded) {
                        throw "Embedded declaration source SHA256 mismatch: $id/$name"
                    }
                    $embeddedSources.Add([pscustomobject]@{
                        bundleId = $id; path = "declarations\$id\$name"; content = $content
                        sha256 = $actual; recordedSha256 = $recorded
                    })
                }
                $computedId = Bundle-Id $bundle
                if ($id -ne $computedId) { throw "Declaration bundle ID mismatch: recorded $id, computed $computedId." }
                $data = $bundle.GetRawText() | ConvertFrom-Json -AsHashtable
                $bundleDetails.Add([pscustomobject]@{
                    id = $id; computedId = $computedId; idVerified = $true
                    compilerSettings = [ordered]@{
                        version = $data.version; assemblyIdentity = $data.assemblyIdentity
                        languageVersion = $data.languageVersion; nullableContextOptions = $data.nullableContextOptions
                        checkOverflow = $data.checkOverflow; allowUnsafe = $data.allowUnsafe; defines = $data.defines
                    }
                    types = $data.types; references = $data.references
                })
            }
            $declarationBinding = 'SDK v2 bundle IDs and embedded source hashes are verified. The manifest is supplemental to the selected run evidence, not proof that its bundles were approved or used by that host. Historical prototype manifest hashes do not authenticate this SDK manifest.'
            if ($null -ne $evidence.current.implementation) {
                $recordedManifestHash = $evidence.current.implementation.GetProperty('manifestSha256').GetString()
                $declarationManifestBoundToCurrentImplementation = $true
                $declarationBinding = 'The exact SDK v2 manifest SHA256 matches manifestSha256 in the current run implementation-provenance.json. Bundle IDs and embedded source hashes are also verified. This binds the supplied manifest to that recorded implementation evidence, not to baseline or historical prototype provenance; it is not independent production/cloud certification.'
            }
        } elseif ($manifest.Sources) {
            $declarationKind = 'historical-prototype'
            if ($null -ne $evidence.current.prototype) {
                $prototype = $evidence.current.prototype.GetRawText() | ConvertFrom-Json -AsHashtable
                $recordedManifestHash = $prototype.bundleManifestSha256
            }
            $seenSources = @{}
            foreach ($entry in $manifest.Sources) {
                if (-not $entry.File -or -not $entry.Sha256) { throw 'A prototype declaration source requires File and Sha256.' }
                Assert-SourceFilename $entry.File
                if ($seenSources.ContainsKey($entry.File)) { throw "Duplicate declaration source filename: $($entry.File)" }
                $seenSources[$entry.File] = $true
                Queue-Copy (Join-Path ([IO.Path]::GetDirectoryName($manifestPath)) $entry.File) "declarations\sources\$($entry.File)" $entry.Sha256
            }
            $declarationBinding = if ($recordedManifestHash) {
                'Historical prototype manifest SHA256 matches the current run prototype provenance. This is not the SDK v2 declaration manifest.'
            } else {
                'Historical prototype metadata is supplemental: the run does not record its manifest hash.'
            }
        } else {
            $declarationKind = 'metadata-only'
            $declarationBinding = 'Unrecognized declaration manifest: retained as supplemental metadata only; no bundle IDs or embedded sources verified.'
        }
        Queue-Copy $manifestPath 'declarations\manifest.json' $recordedManifestHash
        $declarationManifestHash = $copies[$copies.Count - 1].sha256
    }

    # Validate everything before creating the fresh destination. Recheck each byte copy,
    # so a concurrently changed input cannot silently become the claimed evidence.
    New-Item -ItemType Directory -Path $outputRoot -ErrorAction Stop | Out-Null
    foreach ($copy in $copies) {
        $destination = Join-Path $outputRoot $copy.path
        [IO.Directory]::CreateDirectory([IO.Path]::GetDirectoryName($destination)) | Out-Null
        [IO.File]::Copy($copy.source, $destination, $false)
        if ((Hash $destination) -ne $copy.sha256) { throw "Input changed while packaging: $($copy.source). Discard this incomplete package." }
    }
    foreach ($source in $embeddedSources) {
        Write-Text $source.path $source.content
        if ((Hash (Join-Path $outputRoot $source.path)) -ne $source.sha256) { throw "Extracted declaration SHA256 mismatch: $($source.path)" }
    }

    $lines = [System.Collections.Generic.List[string]]::new()
    $lines.Add('# Custom-type workflow review package')
    $lines.Add('')
    $lines.Add("Selected scenarios: $($CaseIds.Count). This exports recorded evidence; it does not build, regenerate definitions, run a host, or reclassify contracts.")
    $lines.Add('')
    $lines.Add('**Historical declaration support:** custom-type bundle generation and runtime provisioning have been removed. Optional declaration manifests are archival evidence only; this reader does not restore that capability.')
    $lines.Add('')
    $lines.Add('**Contract met is not the same as a succeeded run.** NullableEnumFailure and TypedBodyLinqInvalid intentionally expect failed runs and persisted action errors. The recorded `passed` flag is reported, not recomputed by this exporter.')
    $lines.Add('')
    $lines.Add('All copied harness/workflow sources match each supplied run''s source fingerprints. Full files include neighboring, unselected scenarios; no method excerpts have been reconstructed. This is a review collection, not a standalone build: SDK/project dependencies and private runtime binaries are intentionally absent. The project file records dependency declarations; result metadata records the assemblies actually used.')
    $lines.Add('')
    $lines.Add('Original workflow.json files and results.json are byte copies. Per-case result.json is the complete original JSON object, extracted without reserialization. Pretty JSON below is display-only. Action *.txt files preserve decoded raw text in UTF-8 without an added newline; null and absent content stay distinct in result.json. Raw JSON escaping remains available in the original results.')
    $lines.Add('')
    $lines.Add('Only allowlisted source/evidence and explicitly supplied declaration materials are copied. Credential-free host-profile.json, if present, is supplemental metadata only. No host.json/local.settings.json, declaration-binding.json with local file paths, private-runtime-backup directories, logs, credentials, or binaries are collected; no profile or binding paths are followed. Review recorded content before sharing; this exporter does not redact or sanitize it.')
    $lines.Add('')
    $lines.Add('## Summary')
    $lines.Add('')
    $lines.Add('| Evidence | Recorded contracts met | Succeeded runs | Failed runs | Other/no run | Selected |')
    $lines.Add('|---|---:|---:|---:|---:|---:|')
    $summaries = [ordered]@{}
    foreach ($side in $evidence.Keys) {
        $observations = @($evidence[$side].cases | ForEach-Object observation)
        $met = @($observations | Where-Object { $_.passed -eq $true }).Count
        $succeeded = @($observations | Where-Object { $_.runStatus -eq 'Succeeded' }).Count
        $failed = @($observations | Where-Object { $_.runStatus -eq 'Failed' }).Count
        $other = $observations.Count - $succeeded - $failed
        $summaries[$side] = @{ contractsMet = $met; succeededRuns = $succeeded; failedRuns = $failed; otherOrNoRun = $other; selected = $observations.Count }
        $lines.Add("| $side | $met | $succeeded | $failed | $other | $($observations.Count) |")
    }
    $lines.Add('')
    $lines.Add('| Scenario | Evidence | Expected run / HTTP | Actual run / HTTP | Recorded contract | Files |')
    $lines.Add('|---|---|---|---|---|---|')
    foreach ($id in $CaseIds) {
        foreach ($side in $evidence.Keys) {
            $case = $evidence[$side].cases | Where-Object id -EQ $id
            $o = $case.observation
            $contract = if ($o.passed -eq $true) { 'met' } else { 'NOT met' }
            $prefix = "$side/cases/$id"
            $files = "[source]($(Link "sources\$($sourceForCase[$id])")); [result]($prefix/result.json)"
            if ($null -ne $case.definition) { $files += "; [definition]($prefix/workflow.json)" }
            $lines.Add("| [$id](#case-$($id.ToLowerInvariant())) | $side | $(Cell $o.expectedRunStatus) / $(Cell $o.expectedHttpStatus) | $(Cell $o.runStatus) / $(Cell $o.httpStatus) | $contract | $files |")
        }
    }
    $lines.Add('')
    $lines.Add('## Recorded provenance')
    $lines.Add('')
    $lines.Add('The baseline, when supplied, is independent evidence, not an equivalence claim. SDK/runtime hashes may differ; both sets are shown without replacing one with the other. Only the copied workflow/harness inputs require matching source fingerprints: exporter, README, and SDK-product changes are not source mismatches.')
    $lines.Add('')
    foreach ($side in $evidence.Keys) {
        $run = $evidence[$side]
        $lines.Add("### $side")
        $lines.Add('')
        $lines.Add("[Original results]($side/results.json) | [Original source fingerprints]($side/source-fingerprints.json)")
        $lines.Add('')
        foreach ($property in $run.raw.EnumerateObject()) {
            if ($property.Name -eq 'results') { continue }
            $lines.Add("**$(Cell $property.Name)**")
            Add-Block $lines 'json' (Pretty-Json $property.Value)
        }
        if ($null -ne $run.prototype) {
            $lines.Add("[Prototype provenance]($side/prototype-provenance.json) — experimental evidence is not production certification.")
            Add-Block $lines 'json' (Pretty-Json $run.prototype)
        }
        if ($null -ne $run.implementation) {
            $lines.Add("[Implementation provenance]($side/implementation-provenance.json) — exact recorded implementation kind, manifest hash, private-reflection hooks, and original/implemented runtime fingerprints.")
            $lines.Add('')
            $lines.Add('Runtime fingerprints and startup-binding claims are reported as recorded, not independently attested. Private binaries are neither collected nor re-hashed.')
            Add-Block $lines 'json' (Pretty-Json $run.implementation)
        }
        if ($null -ne $run.profile) {
            $lines.Add("[Host profile]($side/host-profile.json) — supplemental experimental configuration, not independent proof that a capability or dependency was used. Local-path declaration-binding.json is intentionally excluded.")
            Add-Block $lines 'json' (Pretty-Json $run.profile)
        }
    }
    $lines.Add('## Declarations and dependencies')
    $lines.Add('')
    $lines.Add($declarationBinding)
    $lines.Add('')
    $lines.Add('[Original custom declarations](sources/Workflows/CaseSupport.cs) | [Project/dependency declarations](sources/SourceExpressionE2E.csproj) | [Harness classification](sources/ComparisonReport.cs) | [Seed safety checks](sources/CaseCatalog.cs)')
    $lines.Add('')
    if ($null -ne $declarationJson) {
        $lines.Add('[Supplied declaration manifest](declarations/manifest.json). References are metadata only; dependency binaries are not copied.')
        $lines.Add('')
        $lines.Add("Manifest format: **$declarationKind**. Exact outer file SHA256: ``$declarationManifestHash``.")
        $lines.Add('')
        foreach ($bundle in $bundleDetails) {
            $lines.Add("### SDK declaration bundle ``$($bundle.id)``")
            $lines.Add('')
            $lines.Add('Bundle ID verified using WorkflowDeclarationBundle.ComputeId canonical field order and default System.Text.Json escaping. Source hashes cover UTF-8 content without adding a BOM. Integrity verification is not compiler, host, or deployment approval; references have not been resolved or loaded.')
            $lines.Add('')
            $lines.Add('**Compiler settings**')
            Add-Block $lines 'json' ($bundle.compilerSettings | ConvertTo-Json -Depth 10)
            $lines.Add('**Declared types**')
            Add-Block $lines 'json' (ConvertTo-Json -InputObject $bundle.types -Depth 10)
            $lines.Add('**Reference identities, aliases, and embedded-interop flags**')
            Add-Block $lines 'json' (ConvertTo-Json -InputObject $bundle.references -Depth 10)
            foreach ($source in $embeddedSources | Where-Object bundleId -EQ $bundle.id) {
                $lines.Add("[$($source.path)]($(Link $source.path)) — verified SHA256 ``$($source.sha256)``")
                Add-Block $lines 'csharp' ([IO.File]::ReadAllText((Join-Path $outputRoot $source.path)))
            }
        }
        $lines.Add('### Complete supplied manifest')
        $lines.Add('')
        Add-Block $lines 'json' (Pretty-Json $declarationJson)
        foreach ($copy in $copies | Where-Object { $_.path -like 'declarations\sources\*' }) {
            $lines.Add("[$($copy.path)]($(Link $copy.path)) — verified SHA256 ``$($copy.sha256)``")
            Add-Block $lines 'csharp' ([IO.File]::ReadAllText((Join-Path $outputRoot $copy.path)))
        }
    }
    Add-Block $lines 'csharp' ([IO.File]::ReadAllText((Join-Path $outputRoot 'sources\Workflows\CaseSupport.cs')))
    $lines.Add('### All original source and harness files')
    $lines.Add('')
    foreach ($relative in $sourcePaths) { $lines.Add("- [$relative]($(Link "sources\$relative"))") }
    $lines.Add('')

    foreach ($id in $CaseIds) {
        $lines.Add("<a id=""case-$($id.ToLowerInvariant())""></a>")
        $lines.Add("## $id")
        $lines.Add('')
        $source = "sources\$($sourceForCase[$id])"
        $lines.Add("### Complete original source — [$($sourceForCase[$id])]($(Link $source))")
        $lines.Add('')
        $lines.Add('The WorkflowCase attribute identifies this scenario; the full file retains helpers and seed callbacks unchanged. Shared types and methods are in CaseSupport.cs above.')
        Add-Block $lines 'csharp' ([IO.File]::ReadAllText((Join-Path $outputRoot $source)))
        foreach ($side in $evidence.Keys) {
            $case = $evidence[$side].cases | Where-Object id -EQ $id
            $o = $case.observation
            $prefix = "$side\cases\$id"
            Write-Text "$prefix\result.json" $case.raw.GetRawText()
            $lines.Add("### $side — expected and actual observation")
            $lines.Add('')
            $lines.Add("[Full per-case result]($(Link "$prefix\result.json")). Includes expected body/status/error, actual body/status/error, run ID/times, and every persisted action.")
            Add-Block $lines 'json' (Pretty-Json $case.raw)
            if ($null -ne $case.generation) {
                Write-Text "$prefix\generation.json" $case.generation.GetRawText()
                $lines.Add("[Recorded generation entry and original factory method]($(Link "$prefix\generation.json"))")
                Add-Block $lines 'json' (Pretty-Json $case.generation)
            }
            if ($null -ne $case.definition) {
                $lines.Add("#### Exact recorded [workflow.json]($(Link "$prefix\workflow.json"))")
                $lines.Add('')
                $lines.Add("Verified recorded SHA256: ``$($o.definitionSha256)``. The following pretty rendering does not replace that file.")
                Add-Block $lines 'json' (Pretty-Json $case.definition)
            } else {
                $lines.Add('No generated definition was recorded; this is not a successful workflow execution.')
                $lines.Add('')
            }
            $actionIndex = 0
            foreach ($action in $o.actions) {
                $actionIndex++
                $lines.Add("#### Action $actionIndex — $(Cell $action.name) — $(Cell $action.status)")
                $lines.Add('')
                foreach ($direction in @('inputs', 'outputs')) {
                    $content = $action[$direction]
                    if ($content.present -eq $true -and $null -ne $content.raw) {
                        if ($content.raw -isnot [string]) { throw "Non-text raw action $direction for $side/$id." }
                        $textPath = "$prefix\actions\$('{0:D3}' -f $actionIndex).$direction.txt"
                        Write-Text $textPath $content.raw
                        $lines.Add("**$direction** — [exact raw text]($(Link $textPath))")
                        Add-Block $lines 'text' $content.raw
                    } else {
                        $state = if ($content.present -eq $true) { 'present, raw null (see recorded status)' } else { 'not present' }
                        $lines.Add("**$direction**: $state.")
                        $lines.Add('')
                    }
                }
            }
        }
    }
    $lines.Add('## Package integrity')
    $lines.Add('')
    $lines.Add('[package-manifest.json](package-manifest.json) records SHA256 for every package file except itself, with recorded hashes for original source/definition copies. No ZIP is created.')
    Write-Text 'report.md' ($lines -join "`n")
    $inventory = @(Get-ChildItem -LiteralPath $outputRoot -Recurse -File | Sort-Object FullName | ForEach-Object {
        [ordered]@{ path = [IO.Path]::GetRelativePath($outputRoot, $_.FullName); sha256 = Hash $_.FullName; bytes = $_.Length }
    })
    $package = [ordered]@{
        formatVersion = 1
        createdUtc = [DateTimeOffset]::UtcNow.ToString('o')
        exporterSha256 = Hash $PSCommandPath
        selectedCaseIds = $CaseIds
        summary = $summaries
        declarationBinding = $declarationBinding
        declarationManifestKind = $declarationKind
        declarationManifestSha256 = $declarationManifestHash
        declarationManifestBoundToCurrentImplementation = $declarationManifestBoundToCurrentImplementation
        declarationBundles = @($bundleDetails.ToArray())
        extractedDeclarationSources = @($embeddedSources | Select-Object bundleId,path,sha256,recordedSha256)
        originalCopies = @($copies | Select-Object path,sha256,recordedSha256)
        files = $inventory
    }
    Write-Text 'package-manifest.json' ($package | ConvertTo-Json -Depth 20)
    Write-Output "Exported $($CaseIds.Count) scenarios to $outputRoot\report.md. Recorded contract results are distinct from successful runs."
} finally {
    foreach ($document in $documents) { $document.Dispose() }
}
