#requires -Version 7.0
param(
    [Parameter(Mandatory)][string] $OutputDirectory,
    [switch] $TestExtensionCompanion
)
$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$root = [IO.Path]::GetFullPath($OutputDirectory)
if (Test-Path -LiteralPath $root) { throw 'Use a new test output directory.' }
New-Item -ItemType Directory -Path $root | Out-Null
$script = Join-Path $PSScriptRoot 'New-ExtensionCandidate.ps1'
$shell = (Get-Process -Id $PID).Path
$checks = [Collections.Generic.List[object]]::new()

function Write-Archive([string] $Path, [hashtable] $Files) {
    $archive = [IO.Compression.ZipFile]::Open($Path, [IO.Compression.ZipArchiveMode]::Create)
    try {
        foreach ($name in $Files.Keys) {
            $writer = [IO.StreamWriter]::new($archive.CreateEntry($name).Open())
            try { $writer.Write($Files[$name]) } finally { $writer.Dispose() }
        }
    } finally { $archive.Dispose() }
}
function Run([string] $Name, [string[]] $Arguments, [string] $ExpectedError = '') {
    $log = Join-Path $root "$Name.log"
    & $shell -NoProfile -File $script @Arguments *> $log
    $code = $LASTEXITCODE
    if (($ExpectedError -eq '' -and $code -ne 0) -or
        ($ExpectedError -ne '' -and ($code -eq 0 -or !(Select-String -LiteralPath $log -Pattern $ExpectedError -Quiet)))) {
        throw "Unexpected result for $Name (exit $code). See $log."
    }
    $checks.Add(@{ name = $Name; exitCode = $code; expectedError = $ExpectedError })
}

$sdkFiles = @{
    'Microsoft.Azure.Workflows.Sdk.nuspec' = '<package><metadata><id>Microsoft.Azure.Workflows.Sdk</id><version>1.0.0-e2e.fixture</version></metadata></package>'
    'lib/netstandard2.0/Microsoft.Azure.Workflows.Sdk.dll' = 'fixture only; not executable'
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.props' = '<Project />'
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.targets' = '<Project />'
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.BuildTasks.targets' = '<Project />'
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll' = 'fixture'
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.deps.json' = '{}'
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.runtimeconfig.json' = '{"runtimeOptions":{"tfm":"net9.0"}}'
    'tools/workflow-build/Microsoft.CodeAnalysis.dll' = 'fixture'
    'tools/workflow-build/Microsoft.CodeAnalysis.CSharp.dll' = 'fixture'
}
$bundleFiles = @{
    'bundle.json' = '{"id":"Microsoft.Azure.Functions.ExtensionBundle.Workflows","version":"1.999.1"}'
    'extensions.csproj' = '<Project />'
    'LICENSE.txt' = 'fixture'
    'NOTICE.txt' = 'fixture'
    'bin/extensions.json' = '{}'
    'bin/function.deps.json' = '{}'
    'bin/Microsoft.Azure.Workflows.Templates.Languages.Edge.CSharp.dll' = 'fixture'
    'JS/fixture' = 'fixture'
    'JAR/fixture' = 'fixture'
    'NetFxWorker/fixture' = 'fixture'
    'CustomCodeNetFxWorker/fixture' = 'fixture'
    'Powershell/fixture' = 'fixture'
}
$sdk = Join-Path $root 'sdk.nupkg'
$bundle = Join-Path $root 'bundle.zip'
Write-Archive $sdk $sdkFiles
Write-Archive $bundle $bundleFiles
$kit = Join-Path $root 'candidate with spaces'
Run 'create' @('-OutputDirectory', $kit, '-SdkPackagePath', $sdk, '-BundlePath', $bundle)
$manifestPath = Join-Path $kit 'candidate.json'
$manifest = Get-Content -LiteralPath $manifestPath -Raw | ConvertFrom-Json
if ($manifest.sdk.version -cne '1.0.0-e2e.fixture' -or
    $manifest.sdk.path -cne (Join-Path $kit 'artifacts\sdk.nupkg')) {
    throw 'Candidate did not retain package identity and isolated copied path.'
}
Run 'verify' @('-VerifyManifest', $manifestPath)
$fourPartFiles = $bundleFiles.Clone()
$fourPartFiles['bundle.json'] = '{"id":"Microsoft.Azure.Functions.ExtensionBundle.Workflows","version":"1.192.0.32"}'
$fourPartBundle = Join-Path $root 'four-part-version.zip'
Write-Archive $fourPartBundle $fourPartFiles
Run 'four-part-bundle-version' @('-OutputDirectory', (Join-Path $root 'four-part-version'), '-SdkPackagePath', $sdk,
    '-BundlePath', $fourPartBundle, '-BundleVersion', '1.192.0.32')
Run 'no-overwrite' @('-OutputDirectory', $kit, '-SdkPackagePath', $sdk, '-BundlePath', $bundle) 'never overwritten'
Run 'version-mismatch' @('-OutputDirectory', (Join-Path $root 'wrong-version'), '-SdkPackagePath', $sdk,
    '-BundlePath', $bundle, '-SdkPackageVersion', '1.0.0-e2e.wrong') 'SDK version differs'
$invalid = $sdkFiles.Clone()
$invalid.Remove('tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll')
$missing = Join-Path $root 'missing-tool.nupkg'
Write-Archive $missing $invalid
Run 'missing-compiler' @('-OutputDirectory', (Join-Path $root 'missing'), '-SdkPackagePath', $missing, '-BundlePath', $bundle) 'missing required content'
$invalid = $bundleFiles.Clone()
$invalid['../escape'] = 'fixture'
$unsafe = Join-Path $root 'unsafe.zip'
Write-Archive $unsafe $invalid
Run 'unsafe-archive' @('-OutputDirectory', (Join-Path $root 'unsafe'), '-SdkPackagePath', $sdk, '-BundlePath', $unsafe) 'Unsafe archive entry'
$invalid = $bundleFiles.Clone()
$invalid.Remove('JAR/fixture')
$invalid['JAR/'] = ''
$emptyPayload = Join-Path $root 'empty-jar.zip'
Write-Archive $emptyPayload $invalid
Run 'empty-payload-directory' @('-OutputDirectory', (Join-Path $root 'empty-jar'), '-SdkPackagePath', $sdk,
    '-BundlePath', $emptyPayload) 'missing payload directory: JAR/'
$invalid = $sdkFiles.Clone()
$invalid['Microsoft.Azure.Workflows.Sdk.nuspec'] = '<package><metadata><id>Wrong.Package</id><version>1.0.0</version></metadata></package>'
$wrongId = Join-Path $root 'wrong-id.nupkg'
Write-Archive $wrongId $invalid
Run 'wrong-package-id' @('-OutputDirectory', (Join-Path $root 'wrong-id'), '-SdkPackagePath', $wrongId, '-BundlePath', $bundle) 'Unexpected SDK package ID'
$collisionDirectory = Join-Path $root 'collision-source'
New-Item -ItemType Directory -Path $collisionDirectory | Out-Null
$collision = Join-Path $collisionDirectory 'sdk.nupkg'
Copy-Item -LiteralPath $bundle -Destination $collision
Run 'archive-name-collision' @('-OutputDirectory', (Join-Path $root 'collision'), '-SdkPackagePath', $sdk,
    '-BundlePath', $collision) 'archive filenames collide'

# The stub verifies the companion interface, not a BPM source build.
$bpm = Join-Path $root 'stub-bpm'
$producerDirectory = Join-Path $bpm 'tools\devtools\be-functions-runtime\scripts'
New-Item -ItemType Directory -Path $producerDirectory -Force | Out-Null
Copy-Item -LiteralPath $bundle -Destination (Join-Path $producerDirectory 'fixture.zip')
@'
param([string] $OutputDirectory, [switch] $BuildFromSource, [string] $BundleVersion)
$ErrorActionPreference = 'Stop'
if (!$BuildFromSource -or $BundleVersion -cne '1.999.1') { throw 'Incorrect companion invocation.' }
if (Test-Path -LiteralPath $OutputDirectory) { throw 'Expected new BPM output directory.' }
New-Item -ItemType Directory -Path $OutputDirectory | Out-Null
$zip = Join-Path $OutputDirectory 'fixture.zip'
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'fixture.zip') -Destination $zip
$hash = (Get-FileHash -LiteralPath $zip).Hash
if (Test-Path -LiteralPath (Join-Path $PSScriptRoot 'bad-hash')) { $hash = '0' * 64 }
@{ schemaVersion = 1; bundle = @{path = $zip; version = $BundleVersion; sha256 = $hash} } |
    ConvertTo-Json -Depth 3 | Set-Content -LiteralPath (Join-Path $OutputDirectory 'bundle-receipt.json')
'@ | Set-Content -LiteralPath (Join-Path $producerDirectory 'Build-CandidateWorkflowBundle.ps1')
Run 'bpm-companion-interface' @('-OutputDirectory', (Join-Path $root 'bpm-handoff'), '-SdkPackagePath', $sdk,
    '-BpmRepository', $bpm, '-BundleVersion', '1.999.1')
$bpmReceipt = Join-Path $root 'bpm-handoff\bpm\bundle-receipt.json'
$receiptImport = Join-Path $root 'receipt-import'
Run 'import-bpm-receipt' @('-OutputDirectory', $receiptImport, '-SdkPackagePath', $sdk,
    '-BundleReceiptPath', $bpmReceipt)
$imported = Get-Content -LiteralPath (Join-Path $receiptImport 'candidate.json') -Raw | ConvertFrom-Json
if ($imported.provenance.bpmReceipt -cne (Join-Path $receiptImport 'bundle-receipt.json') -or
    (Get-FileHash -LiteralPath $imported.provenance.bpmReceipt).Hash -ine (Get-FileHash -LiteralPath $bpmReceipt).Hash) {
    throw 'Imported BPM source receipt was not preserved.'
}
[IO.File]::AppendAllText($imported.provenance.bpmReceipt, ' ')
Run 'bpm-provenance-tampering' @('-VerifyManifest', (Join-Path $receiptImport 'candidate.json')) 'BPM provenance receipt differs'
Set-Content -LiteralPath (Join-Path $producerDirectory 'bad-hash') -Value 'fixture'
Run 'bpm-receipt-mismatch' @('-OutputDirectory', (Join-Path $root 'bpm-mismatch'), '-SdkPackagePath', $sdk,
    '-BpmRepository', $bpm, '-BundleVersion', '1.999.1') 'BPM output differs from its build receipt'
if ($TestExtensionCompanion) {
    $null = Get-Command node -ErrorAction Stop
    $ux = Join-Path $root 'stub-ux'
    $runnerDirectory = Join-Path $ux 'apps\vs-code-designer\scripts'
    New-Item -ItemType Directory -Path $runnerDirectory -Force | Out-Null
    @'
const fs = require('node:fs');
const path = require('node:path');
const args = process.argv.slice(2);
if (args.length !== 6 || args[0] !== '--manifest' || args[2] !== '--root' ||
    args[4] !== '--code' || args[5] !== 'fixture code with spaces.exe') {
  throw new Error('Incorrect runner invocation: ' + JSON.stringify(args));
}
const manifest = JSON.parse(fs.readFileSync(args[1], 'utf8').replace(/^\uFEFF/, ''));
if (manifest.schemaVersion !== 1) throw new Error('Missing prepared manifest');
fs.mkdirSync(args[3]);
fs.writeFileSync(path.join(args[3], 'stub-arguments.json'), JSON.stringify(args));
'@ | Set-Content -LiteralPath (Join-Path $runnerDirectory 'run-candidate-e2e.js')
    # Invoke in-process to preserve PowerShell's string-array parameter binding.
    $extensionKit = Join-Path $root 'extension-handoff'
    & $script -OutputDirectory $extensionKit -SdkPackagePath $sdk -BundlePath $bundle `
        -LogicAppsUxRepository $ux -RunExtension -ExtensionRunnerArguments @('--code', 'fixture code with spaces.exe')
    $recorded = Get-Content -LiteralPath (Join-Path $extensionKit 'commands.json') -Raw | ConvertFrom-Json
    if (@($recorded).Count -ne 1 -or $recorded[0].exitCode -ne 0 -or
        !(Test-Path -LiteralPath (Join-Path $extensionKit 'extension-run\stub-arguments.json'))) {
        throw 'Extension companion did not record a successful invocation.'
    }
    $checks.Add(@{ name = 'extension-companion-interface'; exitCode = 0; expectedError = '' })
    Run 'extension-root-override' @('-OutputDirectory', (Join-Path $root 'override'), '-SdkPackagePath', $sdk,
        '-BundlePath', $bundle, '-LogicAppsUxRepository', $ux, '-RunExtension', '-ExtensionRunnerArguments', '--root=elsewhere') 'manifest/root arguments are owned'
}
$original = [IO.File]::ReadAllBytes($manifest.sdk.path)
[IO.File]::AppendAllText($manifest.sdk.path, 'tampered')
Run 'hash-tampering' @('-VerifyManifest', $manifestPath) 'hash/version differs'
[IO.File]::WriteAllBytes($manifest.sdk.path, $original)
$manifest.schemaVersion = 2
$manifest | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath $manifestPath
Run 'unknown-schema' @('-VerifyManifest', $manifestPath) 'Unsupported candidate manifest'
$checks | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath (Join-Path $root 'results.json')
Write-Host "$($checks.Count) candidate-kit checks passed. Synthetic archives validate packaging guards, not binary execution."
