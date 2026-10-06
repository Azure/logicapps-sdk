#requires -Version 7.0
[CmdletBinding(DefaultParameterSetName = 'Create')]
param(
    [Parameter(Mandatory, ParameterSetName = 'Create')][string] $OutputDirectory,
    [Parameter(ParameterSetName = 'Create')][string] $BundlePath,
    [Parameter(ParameterSetName = 'Create')][string] $BundleReceiptPath,
    [Parameter(ParameterSetName = 'Create')][string] $BpmRepository,
    [Parameter(ParameterSetName = 'Create')][string] $BundleVersion,
    [Parameter(ParameterSetName = 'Create')][string] $SdkPackagePath,
    [Parameter(ParameterSetName = 'Create')][string] $SdkPackageVersion,
    [Parameter(ParameterSetName = 'Create')][string] $LogicAppsUxRepository,
    [Parameter(ParameterSetName = 'Create')][switch] $RunExtension,
    [Parameter(ParameterSetName = 'Create')][string[]] $ExtensionRunnerArguments = @(),
    [Parameter(Mandatory, ParameterSetName = 'Verify')][string] $VerifyManifest
)

$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$sdkId = 'Microsoft.Azure.Workflows.Sdk'
$bundleId = 'Microsoft.Azure.Functions.ExtensionBundle.Workflows'
$repository = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$requiredSdkEntries = @(
    'lib/netstandard2.0/Microsoft.Azure.Workflows.Sdk.dll',
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.props',
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.targets',
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.BuildTasks.targets',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.deps.json',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.runtimeconfig.json',
    'tools/workflow-build/Microsoft.CodeAnalysis.dll',
    'tools/workflow-build/Microsoft.CodeAnalysis.CSharp.dll'
)
$requiredBundleEntries = @(
    'bundle.json', 'extensions.csproj', 'LICENSE.txt', 'NOTICE.txt',
    'bin/extensions.json', 'bin/function.deps.json',
    'bin/Microsoft.Azure.Workflows.Templates.Languages.Edge.CSharp.dll'
)

function Read-ArchiveText($Entry) {
    $reader = [IO.StreamReader]::new($Entry.Open())
    try { return $reader.ReadToEnd() } finally { $reader.Dispose() }
}

function Read-CandidateArchive([string] $Path, [ValidateSet('Sdk', 'Bundle')][string] $Kind) {
    $file = Get-Item -LiteralPath $Path
    if ($file.PSIsContainer) { throw "Expected an archive file: $Path" }
    $archive = [IO.Compression.ZipFile]::OpenRead($file.FullName)
    try {
        $entries = [Collections.Generic.Dictionary[string, object]]::new([StringComparer]::OrdinalIgnoreCase)
        foreach ($entry in $archive.Entries) {
            $name = $entry.FullName.Replace('\', '/')
            if ($name.StartsWith('/') -or $name.Contains(':') -or
                @($name.Split('/') | Where-Object { $_ -in @('..', '.') }).Count) {
                throw "Unsafe archive entry: $name"
            }
            if (!$entries.TryAdd($name, $entry)) { throw "Duplicate archive entry: $name" }
        }
        $required = if ($Kind -eq 'Sdk') { $requiredSdkEntries } else { $requiredBundleEntries }
        foreach ($name in $required) {
            if (!$entries.ContainsKey($name) -or $entries[$name].Length -eq 0) {
                throw "$Kind archive is missing required content: $name"
            }
        }
        if ($Kind -eq 'Sdk') {
            $specs = @($archive.Entries | Where-Object { $_.FullName -match '^[^/\\]+\.nuspec$' })
            if ($specs.Count -ne 1) { throw 'SDK archive must contain exactly one root nuspec.' }
            $xmlSettings = [Xml.XmlReaderSettings]::new()
            $xmlSettings.DtdProcessing = [Xml.DtdProcessing]::Prohibit
            $xmlSettings.XmlResolver = $null
            $text = [IO.StringReader]::new((Read-ArchiveText $specs[0]))
            $reader = [Xml.XmlReader]::Create($text, $xmlSettings)
            try {
                $xml = [Xml.XmlDocument]::new()
                $xml.XmlResolver = $null
                $xml.Load($reader)
            } finally { $reader.Dispose(); $text.Dispose() }
            $id = [string]$xml.package.metadata.id
            $version = [string]$xml.package.metadata.version
            if ($id -cne $sdkId) { throw "Unexpected SDK package ID: $id" }
            $toolConfig = Read-ArchiveText $entries['tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.runtimeconfig.json'] | ConvertFrom-Json
            if (!$toolConfig.runtimeOptions.tfm) { throw 'SDK compiler runtime configuration has no target framework.' }
        } else {
            $metadata = Read-ArchiveText $entries['bundle.json'] | ConvertFrom-Json
            $id = [string]$metadata.id
            $version = [string]$metadata.version
            if ($id -cne $bundleId) { throw "Unexpected workflow bundle ID: $id" }
            foreach ($directory in @('JS/', 'JAR/', 'NetFxWorker/', 'CustomCodeNetFxWorker/', 'Powershell/')) {
                if (!@($entries.Keys | Where-Object {
                    $_.StartsWith($directory, [StringComparison]::OrdinalIgnoreCase) -and
                    !($_.EndsWith('/')) -and $entries[$_].Length -gt 0
                }).Count) {
                    throw "Bundle is missing payload directory: $directory"
                }
            }
            foreach ($json in @('bin/extensions.json', 'bin/function.deps.json')) {
                $null = Read-ArchiveText $entries[$json] | ConvertFrom-Json
            }
        }
        if ([string]::IsNullOrWhiteSpace($version) -or $version -notmatch '^[0-9A-Za-z][0-9A-Za-z.+-]*$') {
            throw "Invalid $Kind archive version: $version"
        }
        return [pscustomobject]@{
            path = $file.FullName
            packageId = $id
            version = $version
            sha256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash
        }
    } finally { $archive.Dispose() }
}

function Confirm-Manifest([string] $Path) {
    $manifest = Get-Content -LiteralPath $Path -Raw | ConvertFrom-Json
    if ($manifest.schemaVersion -ne 1) { throw 'Unsupported candidate manifest schemaVersion.' }
    foreach ($kind in @('sdk', 'bundle')) {
        $expected = $manifest.$kind
        if (!$expected -or !$expected.path -or ![IO.Path]::IsPathFullyQualified($expected.path) -or
            $expected.sha256 -notmatch '^[a-fA-F0-9]{64}$') {
            throw "Invalid $kind candidate descriptor."
        }
        $actual = Read-CandidateArchive $expected.path $kind
        if ($actual.sha256 -ine $expected.sha256 -or $actual.version -cne $expected.version) {
            throw "$kind candidate hash/version differs from its manifest."
        }
        if ($kind -eq 'sdk' -and $actual.packageId -cne $expected.packageId) {
            throw 'SDK package ID differs from its manifest.'
        }
    }
    if ($manifest.provenance.bpmReceipt) {
        $receiptPath = $manifest.provenance.bpmReceipt
        if (![IO.Path]::IsPathFullyQualified($receiptPath) -or
            $manifest.provenance.bpmReceiptSha256 -notmatch '^[a-fA-F0-9]{64}$' -or
            (Get-FileHash -LiteralPath $receiptPath).Hash -ine $manifest.provenance.bpmReceiptSha256) {
            throw 'BPM provenance receipt differs from its manifest.'
        }
        $receipt = Get-Content -LiteralPath $receiptPath -Raw | ConvertFrom-Json
        if ($receipt.schemaVersion -ne 1 -or $receipt.bundle.sha256 -ine $manifest.bundle.sha256 -or
            $receipt.bundle.version -cne $manifest.bundle.version) {
            throw 'BPM provenance receipt does not describe the candidate bundle.'
        }
    }
    return $manifest
}

function Read-BundleReceipt([string] $Path) {
    $receipt = Get-Content -LiteralPath $Path -Raw | ConvertFrom-Json
    if ($receipt.schemaVersion -ne 1 -or !$receipt.bundle.path -or
        ![IO.Path]::IsPathFullyQualified($receipt.bundle.path) -or
        $receipt.bundle.sha256 -notmatch '^[a-fA-F0-9]{64}$') {
        throw 'Invalid BPM bundle build receipt.'
    }
    $bundle = Read-CandidateArchive $receipt.bundle.path Bundle
    if ($bundle.sha256 -ine $receipt.bundle.sha256 -or $bundle.version -cne $receipt.bundle.version) {
        throw 'BPM output differs from its build receipt.'
    }
    return $bundle
}

if ($PSCmdlet.ParameterSetName -eq 'Verify') {
    $null = Confirm-Manifest $VerifyManifest
    Write-Host "Verified candidate archive identities and hashes: $VerifyManifest"
    return
}

if (@(@($BundlePath, $BundleReceiptPath, $BpmRepository) | Where-Object { $_ }).Count -ne 1) {
    throw 'Specify exactly one of -BundlePath, -BundleReceiptPath, or -BpmRepository.'
}
if ($RunExtension -and !$LogicAppsUxRepository) { throw '-RunExtension requires -LogicAppsUxRepository.' }
if ($ExtensionRunnerArguments.Count -and !$RunExtension) { throw '-ExtensionRunnerArguments requires -RunExtension.' }
if (@($ExtensionRunnerArguments | Where-Object { $_ -match '^--(manifest|root)(=|$)' }).Count) {
    throw 'Extension runner manifest/root arguments are owned by this script.'
}
$root = [IO.Path]::GetFullPath($OutputDirectory)
if (Test-Path -LiteralPath $root) { throw 'Use a new output directory; existing candidates are never overwritten.' }
$bpmScript = if ($BpmRepository) {
    (Get-Item -LiteralPath (Join-Path $BpmRepository 'tools\devtools\be-functions-runtime\scripts\Build-CandidateWorkflowBundle.ps1')).FullName
}
$uxScript = if ($RunExtension) {
    (Get-Item -LiteralPath (Join-Path $LogicAppsUxRepository 'apps\vs-code-designer\scripts\run-candidate-e2e.js')).FullName
}
New-Item -ItemType Directory -Path $root | Out-Null
$commands = [Collections.Generic.List[object]]::new()
function Invoke-Recorded([string] $Name, [string] $Executable, [string[]] $Arguments) {
    $log = Join-Path $root "$Name.log"
    & $Executable @Arguments *> $log
    $code = $LASTEXITCODE
    $commands.Add(@{ name = $Name; executable = $Executable; arguments = $Arguments; exitCode = $code; log = $log })
    return $code
}

try {
    if ($bpmScript) {
        $args = @('-NoProfile', '-File', $bpmScript, '-OutputDirectory', (Join-Path $root 'bpm'), '-BuildFromSource')
        if ($BundleVersion) { $args += @('-BundleVersion', $BundleVersion) }
        if ((Invoke-Recorded 'bpm-build' (Get-Process -Id $PID).Path $args) -ne 0) {
            throw "BPM candidate build failed. See $(Join-Path $root 'bpm-build.log')."
        }
        $BundleReceiptPath = Join-Path $root 'bpm\bundle-receipt.json'
    }
    if ($BundleReceiptPath) {
        $bundle = Read-BundleReceipt $BundleReceiptPath
    } else {
        $bundle = Read-CandidateArchive $BundlePath Bundle
    }
    if ($BundleVersion -and $bundle.version -cne $BundleVersion) { throw 'Bundle version differs from the requested version.' }

    if (!$SdkPackagePath) {
        if (!$SdkPackageVersion) { $SdkPackageVersion = '1.0.0-e2e.' + [DateTime]::UtcNow.ToString('yyyyMMddHHmmss') }
        if ($SdkPackageVersion -notmatch '^\d+\.\d+\.\d+-[0-9A-Za-z][0-9A-Za-z.-]*$') {
            throw 'Use an explicit prerelease SDK package version for a local candidate.'
        }
        $feed = Join-Path $root 'sdk-feed'
        $project = Join-Path $repository 'src\Microsoft.Azure.Workflows.Sdk.csproj'
        $properties = @("-p:ArtifactsPath=$(Join-Path $root 'sdk-build')", "-p:PackageVersion=$SdkPackageVersion", "-p:PackageOutputPath=$feed")
        $build = @('build', $project, '--no-restore', '-c', 'Release', '-v:quiet') + $properties
        $code = Invoke-Recorded 'sdk-build' 'dotnet' $build
        if ($code -ne 0) {
            if (!(Select-String -LiteralPath (Join-Path $root 'sdk-build.log') -Pattern 'NETSDK1004' -Quiet)) {
                throw 'SDK build failed. See sdk-build.log.'
            }
            if ((Invoke-Recorded 'sdk-restore' 'dotnet' (@('restore', $project, '-v:quiet') + $properties)) -ne 0) {
                throw 'SDK restore failed. See sdk-restore.log.'
            }
            if ((Invoke-Recorded 'sdk-build-restored' 'dotnet' $build) -ne 0) { throw 'SDK build failed. See sdk-build-restored.log.' }
        }
        $SdkPackagePath = Join-Path $feed "$sdkId.$SdkPackageVersion.nupkg"
    }
    $sdk = Read-CandidateArchive $SdkPackagePath Sdk
    if ($SdkPackageVersion -and $sdk.version -cne $SdkPackageVersion) { throw 'SDK version differs from the requested version.' }
    $archives = Join-Path $root 'artifacts'
    New-Item -ItemType Directory -Path $archives | Out-Null
    foreach ($artifact in @($sdk, $bundle)) {
        $destination = Join-Path $archives ([IO.Path]::GetFileName($artifact.path))
        if (Test-Path -LiteralPath $destination) { throw "Candidate archive filenames collide: $destination" }
        Copy-Item -LiteralPath $artifact.path -Destination $destination
        if ((Get-FileHash -LiteralPath $destination).Hash -ine $artifact.sha256) { throw "Copy verification failed: $destination" }
        $artifact.path = $destination
    }
    $head = & git -C $repository rev-parse HEAD
    if ($LASTEXITCODE -ne 0) { throw 'Cannot record SDK source revision.' }
    $status = @(& git -C $repository status --porcelain --untracked-files=normal)
    if ($LASTEXITCODE -ne 0) { throw 'Cannot record SDK source status.' }
    $copiedReceipt = $null
    if ($BundleReceiptPath) {
        $copiedReceipt = Join-Path $root 'bundle-receipt.json'
        Copy-Item -LiteralPath $BundleReceiptPath -Destination $copiedReceipt
        if ((Get-FileHash -LiteralPath $BundleReceiptPath).Hash -ine (Get-FileHash -LiteralPath $copiedReceipt).Hash) {
            throw 'BPM receipt copy verification failed.'
        }
    }
    $manifest = [ordered]@{
        schemaVersion = 1
        createdUtc = [DateTime]::UtcNow.ToString('o')
        bundle = @{ path = $bundle.path; version = $bundle.version; sha256 = $bundle.sha256 }
        sdk = @{ path = $sdk.path; packageId = $sdk.packageId; version = $sdk.version; sha256 = $sdk.sha256 }
        provenance = @{
            sdkRepository = $repository
            sdkHeadAtPreparation = "$head"
            sdkWorkingTreeStatus = $status
            sdkBuiltByThisInvocation = [bool]($commands | Where-Object name -Like 'sdk-build*')
            bpmReceipt = $copiedReceipt
            bpmReceiptSha256 = if ($copiedReceipt) { (Get-FileHash -LiteralPath $copiedReceipt).Hash } else { $null }
            note = 'Archive preparation is not extension pickup or runtime execution evidence. Imported package source provenance must be supplied by its producer.'
        }
    }
    $manifestPath = Join-Path $root 'candidate.json'
    $manifest | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath $manifestPath -Encoding utf8
    $null = Confirm-Manifest $manifestPath
    Write-Host "Candidate manifest: $manifestPath"
    if ($RunExtension) {
        $runnerArguments = @($uxScript, '--manifest', $manifestPath, '--root', (Join-Path $root 'extension-run')) + $ExtensionRunnerArguments
        if ((Invoke-Recorded 'extension-e2e' 'node' $runnerArguments) -ne 0) {
            throw 'Extension candidate run failed. Preserve extension-e2e.log and extension-run evidence.'
        }
        Write-Host "Extension runner completed. Review its receipt in $(Join-Path $root 'extension-run') for the verified scope."
    }
} finally {
    ConvertTo-Json -InputObject @($commands) -Depth 6 | Set-Content -LiteralPath (Join-Path $root 'commands.json') -Encoding utf8
}
