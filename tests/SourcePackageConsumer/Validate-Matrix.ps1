param(
    [Parameter(Mandatory = $true)][string] $PackagePath,
    [Parameter(Mandatory = $true)][string] $SdkPackageVersion,
    [Parameter(Mandatory = $true)][string] $PackagesPath,
    [Parameter(Mandatory = $true)][string] $FeedPath,
    [string] $Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$template = Join-Path $PSScriptRoot 'MatrixFixtures'
$work = Join-Path $PSScriptRoot 'obj\package-validation\matrix workspace'
$evidencePath = Join-Path $PSScriptRoot 'obj\package-validation\expanded-pk-evidence.json'
if (Test-Path -LiteralPath $work) { Remove-Item -LiteralPath $work -Recurse -Force }
New-Item -ItemType Directory -Path $work | Out-Null
foreach ($item in Get-ChildItem -LiteralPath $template) {
    Copy-Item -LiteralPath $item.FullName -Destination $work -Recurse
}
foreach ($name in @('Directory.Build.props', 'Directory.Build.targets')) {
    Copy-Item -LiteralPath (Join-Path $PSScriptRoot $name) -Destination (Join-Path $work $name)
}
$logs = Join-Path $work 'logs'
New-Item -ItemType Directory -Path $logs | Out-Null
$matrix = Join-Path $work 'Matrix\Matrix.csproj'
$linked = Join-Path $work 'LinkedConsumer\LinkedConsumer.csproj'
$workflow = Join-Path $work 'Shared\Workflow.cs'
$common = @("-p:SdkPackageVersion=$SdkPackageVersion", "-p:RestorePackagesPath=$PackagesPath")
$records = [System.Collections.Generic.List[object]]::new()
$commands = [System.Collections.Generic.List[object]]::new()
$diagnosticFailures = [System.Collections.Generic.List[object]]::new()
$fixtureHashes = [ordered]@{}
foreach ($file in Get-ChildItem -LiteralPath $template -Recurse -File) {
    $fixtureHashes[$file.FullName] = (Get-FileHash -LiteralPath $file.FullName).Hash
}
$fixtureHashes[(Join-Path $PSScriptRoot 'Consumer\Program.cs')] =
    (Get-FileHash -LiteralPath (Join-Path $PSScriptRoot 'Consumer\Program.cs')).Hash
$evidence = [ordered]@{
    evidenceKind = 'external-package-validation'
    catalogSection = '14.6'
    startedUtc = [DateTime]::UtcNow.ToString('o')
    packageSha256 = (Get-FileHash -LiteralPath $PackagePath).Hash
    validatorSha256 = (Get-FileHash -LiteralPath $PSCommandPath).Hash
    hostPlatform = [Environment]::OSVersion.ToString()
    dotnetSdk = (& dotnet --version)
    scope = 'Local package mutation, compiler-context, and MSBuild design-time fixtures; no actual IDE or other-platform certification.'
    fixtureSha256 = $fixtureHashes
    unverifiedContracts = @('PK13 actual IDE certification', 'PK17 other platforms/IDE hosts', 'EmbedInteropTypes real COM interop execution (metadata plumbing is independently checked)')
}
$archive = [System.IO.Compression.ZipFile]::OpenRead((Resolve-Path -LiteralPath $PackagePath))
try {
    foreach ($entry in @{
        runtimeSha256 = 'lib/netstandard2.0/Microsoft.Azure.Workflows.Sdk.dll'
        compilerSha256 = 'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll'
    }.GetEnumerator()) {
        $stream = $archive.GetEntry($entry.Value).Open()
        try { $evidence[$entry.Key] = [Convert]::ToHexString([System.Security.Cryptography.SHA256]::HashData($stream)) }
        finally { $stream.Dispose() }
    }
} finally { $archive.Dispose() }

function Save-Evidence {
    $evidence['cases'] = $records.ToArray()
    $evidence['commands'] = $commands.ToArray()
    $evidence['failedChecks'] = $diagnosticFailures.ToArray()
    $evidence | ConvertTo-Json -Depth 16 | Set-Content -LiteralPath $evidencePath
}

function Invoke-Fixture {
    param([string[]] $Arguments, [switch] $ExpectFailure)
    $log = Join-Path $logs ('{0:D3}.log' -f ($commands.Count + 1))
    Write-Host "MATRIX COMMAND dotnet argv=$(ConvertTo-Json -InputObject $Arguments -Compress)"
    $output = & dotnet @Arguments 2>&1
    $exitCode = $LASTEXITCODE
    $text = ($output | ForEach-Object { "$_" }) -join [Environment]::NewLine
    $text | Set-Content -LiteralPath $log
    $record = [ordered]@{
        command = 'dotnet'; argv = $Arguments; exitCode = $exitCode
        log = $log; logSha256 = (Get-FileHash -LiteralPath $log).Hash
    }
    $commands.Add($record)
    Save-Evidence
    Write-Host "MATRIX EXIT $exitCode log=$log"
    if (($ExpectFailure -and $exitCode -eq 0) -or (!$ExpectFailure -and $exitCode -ne 0)) {
        throw "Unexpected exit $exitCode from dotnet $($Arguments -join ' '):`n$text"
    }
    return [pscustomobject]@{ Text = $text; ExitCode = $exitCode; Log = $log }
}

function Assert-True {
    param([bool] $Condition, [string] $Message)
    if (!$Condition) { throw $Message }
}

function Complete-Case {
    param([string] $Id, [string[]] $Checks, [object] $Details = $null, [string] $Status = 'passed')
    $last = $commands[$commands.Count - 1]
    $record = [ordered]@{
        id = $Id; status = $Status; checks = $Checks; details = $Details
        command = 'dotnet ' + (ConvertTo-Json -InputObject $last.argv -Compress)
        exitCode = $last.exitCode; log = $last.log; commandCount = $commands.Count
    }
    if ($Status -eq 'partial') { $record['unverified'] = $Details.unverified }
    $records.Add($record)
    Save-Evidence
    Write-Host "CHECK $Id $Status $($Checks -join '; ')"
}

function Set-Variant {
    param([string] $Name)
    Copy-Item -LiteralPath (Join-Path $work "Variants\$Name.cs.txt") -Destination $workflow -Force
}

function Restore-Fixture {
    param([string] $Project = $matrix, [string[]] $Properties = @())
    $null = Invoke-Fixture (@('restore', $Project, '--force', "-p:RestoreAdditionalProjectSources=$FeedPath") + $common + $Properties)
}

function Build-Fixture {
    param([string] $Project = $matrix, [string] $Framework = 'net9.0',
        [string] $Config = $Configuration, [string[]] $Properties = @(), [switch] $ExpectFailure)
    $arguments = @('build', $Project, '--no-restore', '-c', $Config, '-v:q') + $common + $Properties
    if ($Framework) { $arguments += "-p:TargetFramework=$Framework" }
    return Invoke-Fixture -Arguments $arguments -ExpectFailure:$ExpectFailure
}

function Run-Fixture {
    param([string] $Project = $matrix, [string] $Framework = 'net9.0', [string] $Config = $Configuration,
        [string] $AssemblyName = [System.IO.Path]::GetFileNameWithoutExtension($Project))
    $assembly = $AssemblyName + '.dll'
    $path = Join-Path (Split-Path $Project) "bin\$Config\$Framework\$assembly"
    $projectName = [System.IO.Path]::GetFileNameWithoutExtension($Project)
    $arguments = @($path)
    if ($AssemblyName -ne $projectName) {
        $directory = Split-Path $path
        $arguments = @('exec', '--runtimeconfig', (Join-Path $directory "$projectName.runtimeconfig.json"),
            '--depsfile', (Join-Path $directory "$projectName.deps.json"), $path)
    }
    $run = Invoke-Fixture -Arguments $arguments
    return $run.Text | ConvertFrom-Json
}

function Get-Manifest {
    param([string] $Project = $matrix, [string] $Framework = 'net9.0', [string] $Config = $Configuration)
    $path = Join-Path (Split-Path $Project) "obj\$Config\$Framework\workflow-source\$Config\$Framework\build-manifest.json"
    return Get-Content -LiteralPath $path -Raw | ConvertFrom-Json
}

function Get-Transformed {
    param([string] $Project = $matrix, [string] $Framework = 'net9.0', [string] $Config = $Configuration)
    $list = Join-Path (Split-Path $Project) "obj\$Config\$Framework\workflow-source\$Config\$Framework\compiled-files.txt"
    return @(Get-Content -LiteralPath $list)
}

function Assert-Diagnostic {
    param([object] $Build, [string] $Code, [string] $Needle)
    $lines = @(Get-Content -LiteralPath $workflow)
    $matchingLines = @(for ($i = 0; $i -lt $lines.Count; $i++) { if ($lines[$i].Contains($Needle)) { $i + 1 } })
    Assert-True ($matchingLines.Count -eq 1) "Diagnostic sentinel '$Needle' must have one original source line."
    $location = [regex]::Escape($workflow) + '\(' + $matchingLines[0] + ',\d+\)'
    Assert-True ($Build.Text -match ($location + '.*' + $Code)) "Expected $Code at original $workflow line $($matchingLines[0]): $($Build.Text)"
}

Save-Evidence
try {
    $restoredPackage = Join-Path $PackagesPath "microsoft.azure.workflows.sdk\$SdkPackageVersion\microsoft.azure.workflows.sdk.$SdkPackageVersion.nupkg"
    Assert-True ((Get-FileHash -LiteralPath $restoredPackage).Hash -eq $evidence.packageSha256) 'Matrix restore cache does not contain the requested package.'
    # Compile the instrumented consumer, rather than trusting a binary from an earlier run.
    $null = Build-Fixture -Project (Join-Path $PSScriptRoot 'Consumer\Consumer.csproj')
    $consumer = Join-Path $PSScriptRoot "Consumer\bin\$Configuration\net9.0\Consumer.dll"
    $run = Invoke-Fixture -Arguments @($consumer)
    $definitions = @($run.Text | ConvertFrom-Json)
    $cb01 = '@csharp{outputs("Source").ToObject<string>().ToUpperInvariant() + "!"}'
    Assert-True ($definitions[0].Inputs -ceq $cb01) 'PK02 exact CB01 output mismatch.'
    Complete-Case 'PK02' @('Exact CB01 output', 'Zero reads at the first expression-body operation through serialization', 'Positive counter control observes one read') @{
        consumerSourceSha256 = (Get-FileHash -LiteralPath (Join-Path $PSScriptRoot 'Consumer\Program.cs')).Hash
        log = $run.Log; exitCode = $run.ExitCode
    }

    Restore-Fixture
    $null = Build-Fixture
    Assert-True ((Run-Fixture).result.input -ceq $cb01) 'PK05 baseline mismatch.'
    $baseline = Get-Content -LiteralPath $workflow -Raw
    Assert-True ($baseline.Contains('var suffix = "!";')) 'Missing PK05 mutation anchor.'
    $baseline.Replace('var suffix = "!";', 'var suffix = "?";') | Set-Content -LiteralPath $workflow
    $null = Build-Fixture
    Assert-True ((Run-Fixture).result.input -ceq $cb01.Replace('"!"', '"?"')) 'PK05 stale captured initializer.'
    Complete-Case 'PK05' @('Changed suffix initializer ! to ?', 'Rebuilt unchanged project/intermediate path', 'Observed exact updated CB01')

    $renamed = Join-Path $work 'Shared\RenamedWorkflow.cs'
    Move-Item -LiteralPath $workflow -Destination $renamed
    $null = Build-Fixture -Properties @("-p:WorkflowFile=$renamed")
    Assert-True ((Run-Fixture).result.input -ceq $cb01.Replace('"!"', '"?"')) 'Renaming changed behavior.'
    $paths = Get-Transformed
    Assert-True (@($paths | Where-Object { $_ -match '_Workflow\.cs$' }).Count -eq 0) 'Old transformed file survived rename.'
    Copy-Item -LiteralPath (Join-Path $work 'Variants\Removed.cs.txt') -Destination $renamed -Force
    $null = Build-Fixture -Properties @("-p:WorkflowFile=$renamed")
    Assert-True ((Run-Fixture).result.input -ceq 'removed') 'Deleted call site retained an action.'
    $text = ((Get-Transformed | ForEach-Object { Get-Content -LiteralPath $_ -Raw }) -join "`n")
    Assert-True (!$text.Contains('SourceExpression.Create') -and !$text.Contains('SourceExpression.Literal')) 'Deleted call-site metadata survived rebuild.'
    Move-Item -LiteralPath $renamed -Destination $workflow
    Complete-Case 'PK06' @('Renamed original source and removed call sites', 'No stale transformed original file or descriptors', 'No duplicate action result')

    Set-Variant 'Defines'
    foreach ($label in @('A', 'B')) {
        $null = Build-Fixture -Config "Label$label" -Properties @("-p:DefineConstants=LABEL_$label")
        Assert-True ((Run-Fixture -Config "Label$label").result.input -ceq $label) "Wrong LABEL_$label output."
        $manifest = Get-Manifest -Config "Label$label"
        Assert-True ($manifest.defines -contains "LABEL_$label") 'Define missing from compiler manifest.'
        $other = if ($label -eq 'A') { 'B' } else { 'A' }
        Assert-True ($manifest.defines -notcontains "LABEL_$other") 'Other configuration leaked its define.'
    }
    Complete-Case 'PK07' @('Independent LABEL_A/LABEL_B configurations', 'Exact A/B definitions and manifest symbols')

    Set-Variant 'Framework'
    $null = Build-Fixture -Framework ''
    $allInputs = @()
    foreach ($tfm in @('net8.0', 'net9.0')) {
        $result = Run-Fixture -Framework $tfm
        Assert-True ($result.result.input -ceq $tfm) "Wrong $tfm definition."
        $manifest = Get-Manifest -Framework $tfm
        $referenceMarker = [regex]::Escape("\ref\$tfm\")
        Assert-True (@($manifest.references | Where-Object { $_ -match $referenceMarker }).Count -gt 0) "No $tfm reference pack in manifest."
        Assert-True ($manifest.languageVersion -eq $(if ($tfm -eq 'net8.0') { '12' } else { '13' })) "Wrong $tfm parse options."
        $allInputs += @(Get-Transformed -Framework $tfm)
    }
    Assert-True (@($allInputs | Select-Object -Unique).Count -eq $allInputs.Count) 'Cross-target compiler inputs collided.'
    Complete-Case 'PK08' @('One multi-target project: net8.0 and net9.0', 'Distinct intermediate paths, framework-specific definitions/reference packs/language settings')

    Copy-Item -LiteralPath (Join-Path $template 'Shared\Workflow.cs') -Destination $workflow -Force
    Restore-Fixture -Project $linked
    $null = Build-Fixture
    $null = Build-Fixture -Project $linked
    Assert-True ((Run-Fixture).result.input -ceq $cb01 -and (Run-Fixture -Project $linked).result.input -ceq $cb01) 'Linked consumers differ.'
    $firstInputs = Get-Transformed
    $secondInputs = Get-Transformed -Project $linked
    Assert-True (@($firstInputs | Where-Object { $_ -in $secondInputs }).Count -eq 0) 'Linked consumers share generated inputs.'
    Assert-True ((Get-Manifest).sources -contains $workflow -and (Get-Manifest -Project $linked).sources -contains $workflow) 'Projects did not compile the same physical linked source.'
    Complete-Case 'PK09' @('Same physical Workflow.cs linked into two consumer projects', 'Independent generated inputs and identical CB01 definitions')

    Set-Variant 'SameLine'
    $null = Build-Fixture
    $result = (Run-Fixture).result
    Assert-True ($result.first -ceq 'A' -and $result.second -ceq 'B') 'Same-line actions collided.'
    Complete-Case 'PK10' @('Two real Compose calls on one source line', 'Distinct exact A and B inputs')

    Set-Variant 'Diagnostic'
    $failure = Build-Fixture -ExpectFailure
    Assert-Diagnostic $failure 'CS0103' 'missingName'
    Assert-True ($failure.Text.Contains('missingName')) 'Diagnostic lost identifier.'
    Complete-Case 'PK14' @('Missing identifier produces nonzero build exit', 'CS0103 names missingName at original Workflow.cs line/column') @{ log = $failure.Log; exitCode = $failure.ExitCode }

    $helper = Join-Path $work 'HelperLibrary\HelperLibrary.csproj'
    $transitive = Join-Path $work 'TransitiveLibrary\TransitiveLibrary.csproj'
    $libraryConsumer = Join-Path $work 'LibraryConsumer\LibraryConsumer.csproj'
    foreach ($library in @($helper, $transitive)) {
        Restore-Fixture -Project $library
        $null = Invoke-Fixture (@('pack', $library, '--no-restore', '-c', $Configuration, '-o', $FeedPath, '-v:q') + $common)
    }
    foreach ($entry in @{
        'Workflow.PackageFixture.Helpers.1.0.0.nupkg' = 'HelperLibrary'
        'Workflow.PackageFixture.Transitive.1.0.0.nupkg' = 'TransitiveLibrary'
    }.GetEnumerator()) {
        $libraryPackage = [System.IO.Compression.ZipFile]::OpenRead((Join-Path $FeedPath $entry.Key))
        try {
            Assert-True ($null -ne $libraryPackage.GetEntry("lib/net8.0/$($entry.Value).workflow-expressions.json")) 'Library NuGet package omitted its assembly-specific requirements.'
        } finally { $libraryPackage.Dispose() }
    }
    $transformed = (Get-Transformed -Project $transitive -Framework 'net8.0' | ForEach-Object { Get-Content -LiteralPath $_ -Raw }) -join "`n"
    Assert-True ($transformed.Contains('SourceExpression.')) 'Indirect package library was not transformed.'
    foreach ($file in @('HelperLibrary\WorkflowHelper.cs', 'TransitiveLibrary\TransitiveWorkflow.cs')) {
        $path = Join-Path $work $file
        Move-Item -LiteralPath $path -Destination "$path.unavailable"
    }
    Restore-Fixture -Project $libraryConsumer
    $null = Build-Fixture -Project $libraryConsumer
    $result = Run-Fixture -Project $libraryConsumer
    Assert-True ($result.helper -ceq '@csharp{outputs("Source").ToObject<string>() + "!"}') 'Packaged CB08 helper output mismatch.'
    Assert-True ($result.transitive -ceq 'indirect package reference') 'Indirect library output mismatch.'
    $sources = (Get-Manifest -Project $libraryConsumer).sources
    Assert-True (@($sources | Where-Object { $_ -match 'WorkflowHelper\.cs|TransitiveWorkflow\.cs' }).Count -eq 0) 'Consumer requires helper source.'
    Complete-Case 'PK11' @('CB08 helper built and packed separately', 'Consumer references package, not project/source', 'Helper source unavailable during consumer compile/run', 'Exact CB08 output')
    Complete-Case 'PK18' @('Library references only Helpers package, SDK is indirect', 'buildTransitive automatically transforms that library', 'Application consumes both packaged libraries without direct SDK reference')
    foreach ($assemblyName in @('LibraryConsumer', 'HelperLibrary', 'TransitiveLibrary')) {
        Assert-True (Test-Path -LiteralPath (Join-Path $work "LibraryConsumer\bin\$Configuration\net9.0\$assemblyName.workflow-expressions.json")) "Transitive $assemblyName requirements were not copied beside the consumer."
    }
    Complete-Case 'DEP-NuGetSidecars' @('TFM-specific, assembly-specific requirements in both library packages', 'Direct and transitive library manifests copied beside consumer DLLs')

    Set-Variant 'Reference'
    $referenceProperties = @('-p:UseReferenceHelper=true')
    Restore-Fixture -Properties $referenceProperties
    $null = Build-Fixture -Properties $referenceProperties
    Assert-True ((Run-Fixture).result.input.Contains('ReferencedHelper.Convert')) 'Referenced helper absent from native source.'
    $reference = @((Get-Manifest).references | Where-Object { [IO.Path]::GetFileName($_) -eq 'ReferenceHelper.dll' })
    Assert-True ($reference.Count -eq 1) 'Expected one resolved helper reference.'
    $oldReferenceHash = (Get-FileHash -LiteralPath $reference[0]).Hash
    $helperSource = Join-Path $work 'ReferenceHelper\ReferencedHelper.cs'
    $helperText = Get-Content -LiteralPath $helperSource -Raw
    $helperText.Replace('Convert(string value) => value', 'Convert(int value) => value.ToString()') | Set-Content -LiteralPath $helperSource
    $failure = Build-Fixture -Properties $referenceProperties -ExpectFailure
    Assert-Diagnostic $failure 'CS1503' 'ReferencedHelper.Convert'
    Assert-True ((Get-FileHash -LiteralPath $reference[0]).Hash -ne $oldReferenceHash) 'Reference signature mutation did not update referenced binary.'
    (Get-Content -LiteralPath $workflow -Raw).Replace('Convert(source.Output)', 'Convert(source.Output.Length)') | Set-Content -LiteralPath $workflow
    $null = Build-Fixture -Properties $referenceProperties
    Assert-True ((Run-Fixture).result.input.Contains('.Length')) 'Corrected helper call was not rebound.'
    Complete-Case 'PK19' @('Changed referenced helper signature string to int', 'Reference assembly hash changed', 'Original call now fails CS1503, corrected call rebuilds successfully')

    Set-Variant 'Arguments'
    $null = Build-Fixture
    $result = (Run-Fixture).result
    Assert-True ($result.input -ceq 'typed' -and $result.resultType -ceq 'System.String' -and ($result.order -join ',') -ceq 'last,name,first') 'Generic call changed type or ordinary argument evaluation order/count.'
    Complete-Case 'PK20' @('Explicit Compose<string> inside named ordinary argument evaluation', 'WithName and surrounding arguments each evaluated once in lexical C# order', 'Typed string action and exact literal result preserved')

    Set-Variant 'Schema'
    $schemaFile = Join-Path $work 'Schemas\operations.json'
    $schemaProperties = @("-p:WorkflowSchemaFile=$schemaFile")
    $schemaBefore = (Get-FileHash -LiteralPath $schemaFile).Hash
    $null = Build-Fixture -Properties $schemaProperties
    $schemaResult = (Run-Fixture).result
    Assert-True ($schemaResult.input -ceq 'schema-value' -and $schemaResult.label -ceq 'first' -and
        $schemaResult.apiMetadata -and $schemaResult.modelMetadata) 'Production CLI did not generate usable API/model metadata before transformation.'
    $schemaManifest = Get-Manifest
    Assert-True ($schemaManifest.schemaFiles.Count -eq 1 -and $schemaManifest.schemaFiles[0] -eq $schemaFile) 'Schema manifest paths do not match declared items.'
    $schemaInputs = Get-Transformed
    Assert-True ($schemaInputs.Count -eq $schemaManifest.sources.Count + 2) 'Expected original inputs plus one model and one generated API.'
    Assert-True ((Get-FileHash -LiteralPath $schemaFile).Hash -eq $schemaBefore) 'Generator modified the schema input.'
    $schemaGenerated = @($schemaInputs | Select-Object -Skip $schemaManifest.sources.Count)
    $schemaInputHashes = @($schemaInputs | ForEach-Object { (Get-FileHash -LiteralPath $_).Hash })
    $null = Build-Fixture -Properties $schemaProperties
    Assert-True (!(Compare-Object $schemaInputs (Get-Transformed))) 'Repeated schema build changed compile input identity.'
    Assert-True (!(Compare-Object $schemaInputHashes @((Get-Transformed) | ForEach-Object { (Get-FileHash -LiteralPath $_).Hash }))) 'Repeated schema build changed generated code.'

    $schema = Get-Content -LiteralPath $schemaFile -Raw | ConvertFrom-Json -AsHashtable
    $schema.models[0].schema.properties.label.default = 'second'
    $schema | ConvertTo-Json -Depth 20 | Set-Content -LiteralPath $schemaFile
    $null = Build-Fixture -Properties $schemaProperties
    Assert-True ((Run-Fixture).result.label -ceq 'second') 'Schema-only content edit did not invalidate generated model defaults.'
    $schema.className = 'ChangedActions'
    $schema | ConvertTo-Json -Depth 20 | Set-Content -LiteralPath $schemaFile
    (Get-Content -LiteralPath $workflow -Raw).Replace('GeneratedActions', 'ChangedActions') | Set-Content -LiteralPath $workflow
    $null = Build-Fixture -Properties $schemaProperties
    Assert-True ((Run-Fixture).result.apiMetadata) 'Renamed schema API was not compiled.'
    Assert-True (@((Get-Transformed) | Where-Object { $_ -match 'GeneratedActions\.g\.cs$' }).Count -eq 0) 'Renamed schema API left a stale generated input.'
    foreach ($oldGenerated in $schemaGenerated | Where-Object { $_ -match 'GeneratedActions\.g\.cs$' }) {
        Assert-True (!(Test-Path -LiteralPath $oldGenerated)) 'Old generated API file survived regeneration.'
    }
    Move-Item -LiteralPath $schemaFile -Destination "$schemaFile.unavailable"
    try {
        $failure = Build-Fixture -Properties $schemaProperties -ExpectFailure
        Assert-True ($failure.Text.Contains('WFSDK1014')) 'A missing declared schema did not fail explicitly.'
    } finally { Move-Item -LiteralPath "$schemaFile.unavailable" -Destination $schemaFile }
    $failure = Build-Fixture -ExpectFailure
    Assert-Diagnostic $failure 'CS0246' 'using PackageSchema'
    Set-Variant 'Removed'
    $null = Build-Fixture
    Assert-True ((Get-Transformed).Count -eq (Get-Manifest).sources.Count) 'Removed schema items left generated compile inputs.'
    Complete-Case 'GEN-SchemaPackage' @('WorkflowExpressionSchema uses the production packaged CLI before semantic analysis',
        'Consumer authors no workflow attributes; generated API/model metadata is reflected',
        'Deterministic repeat, schema-content edit, API rename, missing file and item removal are exercised',
        'Generated inputs cannot accumulate after schema removal') @{ schema = $schemaFile }

    Copy-Item -LiteralPath (Join-Path $template 'Shared\Workflow.cs') -Destination $workflow -Force
    $designProperties = @('-p:DesignTimeBuild=true', '-p:SkipCompilerExecution=true', '-p:ProvideCommandLineArgs=true',
        '-p:TargetFramework=net9.0', '-p:Configuration=DesignTime', "-p:WorkflowBuildToolPath=$(Join-Path $work 'absent-compiler.dll')")
    $design = Invoke-Fixture (@('msbuild', $matrix, '-t:Compile', '-v:minimal') + $common + $designProperties)
    Assert-True ($design.Text.Contains('WFSDK1004')) 'Design-time skip was not diagnosed.'
    $designItems = @(Get-Content -LiteralPath (Join-Path $work 'Matrix\obj\DesignTime\net9.0\design-time-inputs.txt'))
    Assert-True (@($designItems | Where-Object { $_ -eq $workflow }).Count -eq 1) 'Design time lost/duplicated original workflow source.'
    Assert-True (@($designItems | Select-Object -Unique).Count -eq $designItems.Count) 'Design-time duplicate Compile items.'
    Assert-True (@($designItems | Where-Object { $_ -match '[\\/]workflow-source[\\/]' }).Count -eq 0) 'Design-time uses transformed sources.'
    Assert-True (!(Test-Path -LiteralPath (Join-Path $work 'Matrix\obj\DesignTime\net9.0\workflow-source'))) 'Design-time invoked compiler.'
    Complete-Case 'PK13' @('Executable MSBuild design-time skip with missing compiler', 'WFSDK1004 emitted', 'Original Compile items retained without duplicates') @{
        unverified = 'Actual IDE IntelliSense/diagnostic certification is not established by an MSBuild command.'
    } 'partial'

    foreach ($nullable in @('enable', 'disable')) {
        Set-Variant 'Nullable'
        $nullableProperties = @("-p:Nullable=$nullable", '-p:TreatWarningsAsErrors=true')
        if ($nullable -eq 'enable') {
            $failure = Build-Fixture -Properties $nullableProperties -ExpectFailure
            Assert-Diagnostic $failure 'CS8600' 'string value = null'
        } else {
            $null = Build-Fixture -Properties $nullableProperties
            Assert-True ((Run-Fixture).result.isNull) 'Nullable-disabled fixture did not execute.'
        }
        Assert-True ((Get-Manifest).nullable -eq $nullable) 'Nullable option lost in manifest.'
    }
    Complete-Case 'CTX-Nullable' @('Same source fails original-line CS8600 with nullable enabled/warnings-as-errors', 'Nullable disabled compiles/runs', 'Manifest matches caller')

    Set-Variant 'Unsafe'
    $failure = Build-Fixture -Properties @('-p:AllowUnsafeBlocks=false') -ExpectFailure
    Assert-Diagnostic $failure 'CS0227' 'unsafe object'
    $null = Build-Fixture -Properties @('-p:AllowUnsafeBlocks=true')
    Assert-True ((Run-Fixture).result.input -eq '7' -and (Get-Manifest).allowUnsafe) 'Unsafe compilation context mismatch.'
    Complete-Case 'CTX-Unsafe' @('Unsafe disabled fails CS0227 at original source', 'Enabled builds/runs and is in manifest')

    Set-Variant 'Language'
    $failure = Build-Fixture -Properties @('-p:LangVersion=11') -ExpectFailure
    Assert-Diagnostic $failure 'CS9058' 'int[] values'
    $null = Build-Fixture -Properties @('-p:LangVersion=12')
    Assert-True ((Run-Fixture).result.input -eq '2' -and (Get-Manifest).languageVersion -eq '12') 'Language version not preserved.'
    Complete-Case 'CTX-Language' @('C#12 collection-expression source fails under C#11', 'C#12 builds/runs using requested parse options')

    Set-Variant 'Checked'
    foreach ($check in @('true', 'false')) {
        $null = Build-Fixture -Properties @("-p:CheckForOverflowUnderflow=$check")
        $result = (Run-Fixture).result
        Assert-True ($result.overflow -eq ($check -eq 'true')) 'Actual Csc arithmetic context mismatch.'
        Assert-True ((Get-Manifest).checkOverflow -eq ($check -eq 'true')) 'Checked context lost in manifest.'
        if ($check -eq 'true') { Assert-True ($result.input -match '\bchecked\s*\(') 'Native expression lost project checked context.' }
    }
    Complete-Case 'CTX-Checked' @('Checked and unchecked rebuilds execute distinct overflow behavior', 'Manifest and native checked expression preserve context')

    Set-Variant 'Alias'
    Get-Content -LiteralPath (Join-Path $template 'ReferenceHelper\ReferencedHelper.cs') -Raw |
        Set-Content -LiteralPath $helperSource
    $aliasProperties = @('-p:UseReferenceHelper=true', '-p:FixtureReferenceAliases=fixtureAlias')
    Restore-Fixture -Properties $aliasProperties
    $null = Build-Fixture -Properties $aliasProperties
    Assert-True ((Run-Fixture).result.input.Contains('ReferencedHelper.Convert')) 'Aliased helper native output missing.'
    $aliases = (Get-Manifest).referenceAliases.PSObject.Properties.Value
    Assert-True (@($aliases | ForEach-Object { $_ } | Where-Object { $_ -eq 'fixtureAlias' }).Count -eq 1) 'Resolved reference alias absent from manifest.'
    Complete-Case 'CTX-ReferenceAliases' @('Real extern-alias-only ProjectReference compiles', 'Resolved alias metadata reaches analysis and actual Csc')

    Copy-Item -LiteralPath (Join-Path $template 'Shared\Workflow.cs') -Destination $workflow -Force
    $keyFile = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..\..\eng\res\key.snk'))
    $contextProperties = @('-p:SignAssembly=true', '-p:DelaySign=true', "-p:AssemblyOriginatorKeyFile=$keyFile",
        '-p:PlatformTarget=x64', '-p:OutputType=WinExe', '-p:StartupObject=FixtureEntry')
    $null = Build-Fixture -Properties $contextProperties
    $result = Run-Fixture
    $manifest = Get-Manifest
    Assert-True ($result.signed -and $result.result.input -ceq $cb01) 'Signed startup/output fixture failed.'
    Assert-True ($manifest.signAssembly -and $manifest.delaySign -and $manifest.keyFile -eq $keyFile -and
        $manifest.platform -eq 'x64' -and $manifest.outputKind -eq 'WinExe' -and $manifest.startupObject -eq 'FixtureEntry') 'Compilation/signing fields do not match caller.'
    Complete-Case 'CTX-SigningPlatformStartup' @('Delay-signed x64 WinExe executes selected Main despite second Main', 'Public-key identity present', 'Manifest key path/platform/output kind/startup object preserved')

    $sdkAssembly = Join-Path $PackagesPath "microsoft.azure.workflows.sdk\$SdkPackageVersion\lib\netstandard2.0\Microsoft.Azure.Workflows.Sdk.dll"
    $publicKey = [Reflection.AssemblyName]::GetAssemblyName($sdkAssembly).GetPublicKey()
    Assert-True ($publicKey.Length -gt 0) 'Signed-friend fixture requires the SDK public key.'
    (Get-Content -LiteralPath (Join-Path $work 'Variants\FriendAssembly.cs.txt') -Raw).
        Replace('__PUBLIC_KEY__', [Convert]::ToHexString($publicKey)) |
        Set-Content -LiteralPath (Join-Path $work 'ReferenceHelper\FriendAssembly.cs')
    Set-Variant 'Friend'
    $friendProperties = @('-p:UseReferenceHelper=true', '-p:SignAssembly=true',
        '-p:DelaySign=true', "-p:AssemblyOriginatorKeyFile=$keyFile")
    Restore-Fixture -Properties $friendProperties
    $null = Build-Fixture -Properties $friendProperties
    Assert-True ((Run-Fixture).result.input -eq 'signed friend') 'Signed friend access was not preserved through analysis and actual Csc.'
    Complete-Case 'CTX-SignedFriend' @('Signed helper grants Matrix access via the SDK public key', 'Caller analysis and actual compiler accept internal access', 'No stripping of IVT or signing')
    Remove-Item -LiteralPath (Join-Path $work 'ReferenceHelper\FriendAssembly.cs')
    Copy-Item -LiteralPath (Join-Path $template 'Shared\Workflow.cs') -Destination $workflow -Force

    $null = Build-Fixture -Properties @('-p:SignAssembly=true', '-p:PublicSign=true',
        '-p:DelaySign=false', "-p:AssemblyOriginatorKeyFile=$keyFile")
    Assert-True ((Run-Fixture).signed -and (Get-Manifest).publicSign -and !(Get-Manifest).delaySign) 'Public signing context not preserved.'
    Complete-Case 'CTX-PublicSign' @('Public-signed executable builds/runs', 'Manifest distinguishes public sign from delay sign')

    $null = Build-Fixture -Properties @('-p:OutputType=Library', '-p:StartupObject=')
    Assert-True ((Get-Manifest).outputKind -eq 'Library' -and $null -eq (Get-Manifest).startupObject) 'Library output context not preserved.'
    Complete-Case 'CTX-Library' @('Library output builds without an entry point', 'Library output kind and null startup object reach semantic compilation')

    $null = Build-Fixture -Properties @('-p:TargetName=RenamedMatrix')
    Assert-True ((Run-Fixture -AssemblyName 'RenamedMatrix').assemblyName -eq 'RenamedMatrix' -and
        (Get-Manifest).assemblyName -eq 'RenamedMatrix') 'Semantic compilation identity differs from actual renamed Csc output.'
    Complete-Case 'CTX-TargetName' @('Custom TargetName matches actual managed assembly identity and analysis manifest')

    Set-Variant 'Reference'
    Restore-Fixture -Properties $referenceProperties
    $null = Build-Fixture -Properties $referenceProperties
    $artifact = Join-Path $work 'published-workflow.json'
    $publishRoot = Join-Path $work 'deployments'
    New-Item -ItemType Directory -Path $publishRoot | Out-Null
    $sentinel = Join-Path $work 'authoring-executed.txt'
    $oldSentinel = $env:WORKFLOW_FIXTURE_EXECUTION_SENTINEL
    $env:WORKFLOW_FIXTURE_EXECUTION_SENTINEL = $sentinel
    try {
        '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"codeless"}}}}' | Set-Content -LiteralPath $artifact
        $codelessPublish = Join-Path $publishRoot 'codeless'
        $publishArguments = @('publish', $matrix, '--no-build', '--no-restore', '-c', $Configuration,
            '-p:TargetFramework=net9.0', "-p:WorkflowFixtureFile=$artifact", '-p:UseReferenceHelper=true', '-v:minimal') + $common
        $published = Invoke-Fixture ($publishArguments + @('-o', $codelessPublish))
        Assert-True ($published.Text.Contains('WFSDK1013')) 'Publish did not confirm completion of the artifact validator.'
        Assert-True (Test-Path -LiteralPath (Join-Path $codelessPublish 'Matrix.workflow-expressions.json')) 'Publish omitted current assembly requirements.'
        Assert-True (Test-Path -LiteralPath (Join-Path $codelessPublish 'Probe\workflow.json')) 'Publish fixture did not supply a workflow artifact.'
        Assert-True (!(Test-Path -LiteralPath $sentinel)) 'Publish executed the authoring application.'
        Complete-Case 'DEP-PublishCodeless' @('Actual workflow.json triggers post-publish validator', 'Codeless artifact passes without a host profile', 'Current requirements copied; authoring application not executed') @{
            log = $published.Log; exitCode = $published.ExitCode
        }

        $tool = Join-Path $PackagesPath "microsoft.azure.workflows.sdk\$SdkPackageVersion\tools\workflow-build\Microsoft.Azure.Workflows.Sdk.Build.dll"
        $deployedHelper = Join-Path $codelessPublish 'ReferenceHelper.dll'
        $helperHash = (Get-FileHash -LiteralPath $deployedHelper).Hash
        $profile = [ordered]@{
            version = 1; host = 'local-validator-contract-fixture'; evidence = 'Metadata gate test only; not execution-host certification.'
            literalMarkerEscapingVerified = $false; nativeExpressionsVerified = $false
            nativeConditionsVerified = $false; languageVersion = '12'
            namespaceImports = @()
            approvedDependencies = @(@{ assembly = 'ReferenceHelper'; sha256 = $helperHash })
        }
        $profilePath = Join-Path $work 'host-profile.json'
        $profile | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $profilePath
        $profiled = Invoke-Fixture ($publishArguments + @('-o', $codelessPublish, "-p:WorkflowExpressionHostProfile=$profilePath"))
        Assert-True ($profiled.Text.Contains('WFSDK1013')) 'Codeless publication with a valid profile did not complete validation.'
        Complete-Case 'DEP-ProfileForwarding' @('Documented version1 profile passed through the publish target', 'Codeless artifacts validated; no native capability certification claimed')
        $badSidecar = Join-Path $codelessPublish 'Bad.workflow-expressions.json'
        '{"version":99,"assemblyName":"Bad","dependencies":[]}' | Set-Content -LiteralPath $badSidecar
        try {
            $failure = Invoke-Fixture @($tool, 'validate-deployment', $codelessPublish, $codelessPublish) -ExpectFailure
            if ($failure.Text.Contains('WFDEP001')) {
                Complete-Case 'DEP-Aggregation' @('Directory input reads every assembly-specific sidecar', 'Invalid additional sidecar fails closed with WFDEP001')
            } else {
                # Preserve the failure while continuing independent deployment probes.
                $diagnosticFailures.Add(@{
                    id = 'DEP-Aggregation'; expected = 'WFDEP001'; exitCode = $failure.ExitCode
                    log = $failure.Log; actual = $failure.Text
                })
                Save-Evidence
                Write-Host "CHECK DEP-Aggregation FAILED: expected WFDEP001, exit $($failure.ExitCode); $($failure.Log)"
            }
        } finally { Remove-Item -LiteralPath $badSidecar }
        '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@csharp{global::ReferencedHelper.Convert(\"x\")}"}}}}' |
            Set-Content -LiteralPath $artifact
        $unapproved = Invoke-Fixture ($publishArguments + @('-o', (Join-Path $publishRoot 'unapproved'))) -ExpectFailure
        Assert-True ($unapproved.Text.Contains('WFDEP002')) 'Publish did not reject a used, unapproved custom dependency.'
        Complete-Case 'DEP-Unapproved' @('Mandatory publish validation rejects a used custom dependency without approval', 'WFDEP002 propagates as a nonzero publish exit')

        Copy-Item -LiteralPath $artifact -Destination (Join-Path $codelessPublish 'Probe\workflow.json') -Force
        $hiddenHelper = "$deployedHelper.unavailable"
        Move-Item -LiteralPath $deployedHelper -Destination $hiddenHelper
        try {
            $failure = Invoke-Fixture @($tool, 'validate-deployment', $codelessPublish, $codelessPublish, $profilePath) -ExpectFailure
            Assert-True ($failure.Text.Contains('WFDEP003')) 'Approved but absent helper assembly was accepted.'
        } finally { Move-Item -LiteralPath $hiddenHelper -Destination $deployedHelper }
        $profile.approvedDependencies[0].sha256 = '0' * 64
        $profile | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $profilePath
        $failure = Invoke-Fixture @($tool, 'validate-deployment', $codelessPublish, $codelessPublish, $profilePath) -ExpectFailure
        Assert-True ($failure.Text.Contains('WFDEP003')) 'Mismatched helper SHA256 was accepted.'
        Complete-Case 'DEP-MissingOrHash' @('Directory aggregation reads actual compiler reports', 'Used approved helper requires a present matching managed DLL', 'Missing DLL and wrong SHA both fail WFDEP003')

        foreach ($case in @(
            @{ Name = 'native'; Code = 'WFDEP009'; Json = '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@csharp{1+2}"}}}}' },
            @{ Name = 'marker'; Code = 'WFDEP004'; Json = '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@@csharp{1+2}"}}}}' },
            @{ Name = 'condition'; Code = 'WFDEP005'; Json = '{"definition":{"actions":{"Probe":{"type":"If","expression":"@csharp{true}","actions":{}}}}}' },
            @{ Name = 'syntax'; Code = 'WFDEP006'; Json = '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@csharp{1 +}"}}}}' }
        )) {
            $case.Json | Set-Content -LiteralPath $artifact
            $failure = Invoke-Fixture ($publishArguments + @('-o', (Join-Path $publishRoot $case.Name))) -ExpectFailure
            Assert-True ($failure.Text.Contains($case.Code)) "Missing mandatory $($case.Code) deployment diagnostic."
            Complete-Case "DEP-$($case.Code)" @("Real publish artifact rejected with $($case.Code)", 'No capability silently enabled')
        }
        '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@csharp{1+2}"}}}}' | Set-Content -LiteralPath $artifact
        $failure = Invoke-Fixture ($publishArguments + @('-o', (Join-Path $publishRoot 'native-profile-denied'),
            "-p:WorkflowExpressionHostProfile=$profilePath")) -ExpectFailure
        Assert-True ($failure.Text.Contains('WFDEP009')) 'An explicit unverified-native profile did not block ordinary native expressions.'
        Complete-Case 'DEP-NativeProfileDenied' @('Ordinary native Compose is blocked independently of Condition/custom dependencies', 'Explicit nativeExpressionsVerified=false produces WFDEP009')

        Set-Variant 'Extension'
        $null = Build-Fixture -Properties $referenceProperties
        '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"@csharp{\"x\".Wrap()}"}}}}' | Set-Content -LiteralPath $artifact
        $failure = Invoke-Fixture ($publishArguments + @('-o', (Join-Path $publishRoot 'extension-import'))) -ExpectFailure
        Assert-True ($failure.Text.Contains('WFDEP008')) 'Preserved extension syntax without an approved namespace import was accepted.'
        Complete-Case 'DEP-ExtensionImport' @('Actual compiled extension dependency requirement', 'Instance-style extension syntax requires namespaceImports', 'Missing import fails WFDEP008; native host remains unapproved')

        $profile.version = 99
        $profile | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $profilePath
        '{"definition":{"actions":{"Probe":{"type":"Compose","inputs":"codeless"}}}}' | Set-Content -LiteralPath $artifact
        $failure = Invoke-Fixture ($publishArguments + @('-o', (Join-Path $publishRoot 'invalid-profile'), "-p:WorkflowExpressionHostProfile=$profilePath")) -ExpectFailure
        Assert-True ($failure.Text.Contains('WFDEP001')) 'Invalid host profile was not passed to and rejected by the validator.'
        Complete-Case 'DEP-InvalidProfile' @('WorkflowExpressionHostProfile is forwarded to the CLI', 'Invalid version fails WFDEP001')

        $libraryPublish = Join-Path $publishRoot 'library'
        $noWorkflows = Invoke-Fixture (@('publish', $transitive, '--no-build', '--no-restore',
            '-c', $Configuration, '-o', $libraryPublish, '-v:minimal') + $common)
        Assert-True ($noWorkflows.Text.Contains('WFSDK1008')) 'Library-only publish did not explicitly report validation was not performed.'
        $failure = Invoke-Fixture @($tool, 'validate-deployment', $libraryPublish, $libraryPublish) -ExpectFailure
        Assert-True ($failure.Text.Contains('WFDEP007')) 'Direct validator with no workflows did not fail explicitly.'
        Complete-Case 'DEP-NoWorkflows' @('Library publication explicitly skips deployment validation', 'Direct CLI does not misreport an empty deployment as verified')
        Assert-True (!(Test-Path -LiteralPath $sentinel)) 'A build/publish/validation target ran the authoring application.'
        $null = Run-Fixture
        Assert-True (Test-Path -LiteralPath $sentinel) 'Authoring execution sentinel positive control failed.'
        Complete-Case 'DEP-NoAuthoringExecution' @('No app execution in publish or validation', 'Explicit test-only app invocation activates the sentinel positive control')
    } finally {
        $env:WORKFLOW_FIXTURE_EXECUTION_SENTINEL = $oldSentinel
        if (Test-Path -LiteralPath $sentinel) { Remove-Item -LiteralPath $sentinel }
    }

    foreach ($file in $fixtureHashes.Keys) {
        Assert-True ((Get-FileHash -LiteralPath $file).Hash -eq $fixtureHashes[$file]) "Original fixture source was changed: $file"
    }
    if ($diagnosticFailures.Count -ne 0) {
        throw "Deployment diagnostic contracts failed: $($diagnosticFailures.id -join ', '). See failedChecks and command logs."
    }
    $evidence['completedUtc'] = [DateTime]::UtcNow.ToString('o')
    $evidence['outcome'] = 'passed'
    Save-Evidence
} catch {
    $evidence['completedUtc'] = [DateTime]::UtcNow.ToString('o')
    $evidence['outcome'] = 'failed'
    $evidence['failure'] = $_.ToString()
    Save-Evidence
    throw
}
