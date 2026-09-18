[CmdletBinding()]
param(
    [Parameter(Mandatory)][string] $PackagePath,
    [Parameter(Mandatory)][string] $LanguageServerPath,
    [string] $PackageCache = (Join-Path $PSScriptRoot 'obj\package-validation\packages'),
    [string] $EvidenceDirectory = (Join-Path $PSScriptRoot ("obj\language-service-" + (Get-Date -Format 'yyyyMMdd-HHmmss')))
)

$ErrorActionPreference = 'Stop'
$PackagePath = (Resolve-Path -LiteralPath $PackagePath).Path
$LanguageServerPath = (Resolve-Path -LiteralPath $LanguageServerPath).Path
$PackageCache = (Resolve-Path -LiteralPath $PackageCache).Path
$EvidenceDirectory = [IO.Path]::GetFullPath($EvidenceDirectory)
if (Test-Path -LiteralPath $EvidenceDirectory) {
    throw "Evidence directory already exists; preserve it and use a new directory: $EvidenceDirectory"
}
New-Item -ItemType Directory -Path $EvidenceDirectory | Out-Null
$workspace = Join-Path $EvidenceDirectory 'LanguageServiceFixture'
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'LanguageServiceFixture') -Destination $workspace -Recurse
$probe = Join-Path $EvidenceDirectory 'Probe-LanguageService.cjs'
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'Probe-LanguageService.cjs') -Destination $probe
Copy-Item -LiteralPath $PSCommandPath -Destination (Join-Path $EvidenceDirectory 'validator.ps1.txt')
$commands = [Collections.Generic.List[object]]::new()
$checks = [Collections.Generic.List[string]]::new()
$provenance = [ordered]@{
    evidenceKind = 'external-language-service-validation'
    scope = 'Installed production language server over LSP plus separate Windows CLI CB01. No IDE UI, other-platform, or backend certification.'
    packagePath = $PackagePath
    packageSha256 = (Get-FileHash -LiteralPath $PackagePath -Algorithm SHA256).Hash
    languageServerPath = $LanguageServerPath
    languageServerSha256 = (Get-FileHash -LiteralPath $LanguageServerPath -Algorithm SHA256).Hash
    validatorSha256 = (Get-FileHash -LiteralPath $PSCommandPath -Algorithm SHA256).Hash
    probeSha256 = (Get-FileHash -LiteralPath $probe -Algorithm SHA256).Hash
    commands = $commands
    checks = $checks
}
function Invoke-Recorded([string] $Executable, [string[]] $Arguments, [string] $Name) {
    $log = Join-Path $EvidenceDirectory "$Name.log"
    [IO.File]::WriteAllText($log, '')
    Write-Host "$Executable $($Arguments | ConvertTo-Json -Compress)"
    & $Executable @Arguments 2>&1 | Tee-Object -FilePath $log | Out-Host
    $code = $LASTEXITCODE
    $commands.Add([ordered]@{
        executable = $Executable; argv = $Arguments; exitCode = $code
        log = $log; logSha256 = (Get-FileHash -LiteralPath $log -Algorithm SHA256).Hash
    })
    if ($code -ne 0) { throw "$Name failed with exit code $code. See $log" }
}
$sentinel = Join-Path $EvidenceDirectory 'lsp\authoring-executed.txt'
$previousSentinel = $env:WORKFLOW_LSP_SENTINEL
try {
    $archive = [IO.Compression.ZipFile]::OpenRead($PackagePath)
    try {
        $entry = @($archive.Entries | Where-Object FullName -Like '*.nuspec')
        if ($entry.Count -ne 1) { throw 'Expected one package manifest.' }
        $reader = [IO.StreamReader]::new($entry[0].Open())
        try { [xml]$nuspec = $reader.ReadToEnd() } finally { $reader.Dispose() }
        $id = [string]$nuspec.package.metadata.id
        $version = [string]$nuspec.package.metadata.version
    } finally { $archive.Dispose() }
    if ($id -ne 'Microsoft.Azure.Workflows.Sdk') { throw "Unexpected package: $id" }
    $packageRoot = Join-Path (Join-Path $PackageCache $id.ToLowerInvariant()) $version.ToLowerInvariant()
    $cachedPackage = Join-Path $packageRoot "$($id.ToLowerInvariant()).$($version.ToLowerInvariant()).nupkg"
    if ((Get-FileHash -LiteralPath $cachedPackage -Algorithm SHA256).Hash -ne $provenance.packageSha256) {
        throw 'Cached package differs from the supplied package; run the main package validator first.'
    }
    $provenance.runtimeSha256 = (Get-FileHash (Join-Path $packageRoot 'lib\netstandard2.0\Microsoft.Azure.Workflows.Sdk.dll')).Hash
    $provenance.compilerSha256 = (Get-FileHash (Join-Path $packageRoot 'tools\workflow-build\Microsoft.Azure.Workflows.Sdk.Build.dll')).Hash
    $project = Join-Path $workspace 'LanguageServiceFixture.csproj'
    [xml]$projectXml = Get-Content -LiteralPath $project -Raw
    $projectXml.Project.PropertyGroup.SdkPackageVersion.InnerText = $version
    $projectXml.Save($project)
    $originalHash = (Get-FileHash (Join-Path $workspace 'Program.cs')).Hash
    Invoke-Recorded dotnet @('restore', $project, '--source', (Split-Path $PackagePath),
        '--packages', $PackageCache, "-p:SdkPackageVersion=$version", '--verbosity', 'quiet') 'restore'
    $assets = Get-Content (Join-Path $workspace 'obj\project.assets.json') -Raw | ConvertFrom-Json
    if ($null -eq $assets.libraries.PSObject.Properties["$id/$version"]) { throw 'Supplied package version not selected.' }
    $checks.Add('The exact supplied package SHA256/version is selected from the verified local cache.')
    Invoke-Recorded node @($probe, $LanguageServerPath, $workspace, (Join-Path $EvidenceDirectory 'lsp'),
        (Get-Command dotnet).Source) 'language-service'
    $lsp = Get-Content (Join-Path $EvidenceDirectory 'lsp\language-service-evidence.json') -Raw | ConvertFrom-Json
    if ($lsp.status -ne 'passed') { throw 'Language-service assertions did not pass.' }
    foreach ($check in $lsp.checks) { $checks.Add($check) }
    $env:WORKFLOW_LSP_SENTINEL = $sentinel
    Invoke-Recorded dotnet @('build', $project, '--no-restore', "-p:SdkPackageVersion=$version", '--verbosity', 'quiet') 'build'
    $assembly = Join-Path $workspace 'bin\Debug\net9.0\LanguageServiceFixture.dll'
    if ((Get-FileHash (Join-Path (Split-Path $assembly) 'Microsoft.Azure.Workflows.Sdk.dll')).Hash -ne $provenance.runtimeSha256) {
        throw 'The fixture output does not contain the verified packaged runtime.'
    }
    Invoke-Recorded dotnet @($assembly) 'cb01'
    if (Test-Path -LiteralPath $sentinel) { throw 'CB01 authoring or language-service processing executed the getter.' }
    $checks.Add('The same fixture builds/runs through the frozen package and emits exact CB01 without invoking the authoring getter.')
    $generatedLists = @(Get-ChildItem (Join-Path $workspace 'obj') -Filter compiled-files.txt -Recurse -File)
    if ($generatedLists.Count -eq 0) { throw 'Normal build produced no transformed compiler inputs.' }
    Invoke-Recorded node @($probe, $LanguageServerPath, $workspace, (Join-Path $EvidenceDirectory 'lsp-after-build'),
        (Get-Command dotnet).Source) 'language-service-after-build'
    $afterBuild = Get-Content (Join-Path $EvidenceDirectory 'lsp-after-build\language-service-evidence.json') -Raw | ConvertFrom-Json
    if ($afterBuild.status -ne 'passed') { throw 'Post-build language-service assertions did not pass.' }
    $checks.Add('With real transformed obj inputs present, a second installed-server session passes the same completions and nonduplicated original-source diagnostics.')
    Invoke-Recorded dotnet @($assembly, 'counter-control') 'counter-control'
    if ((Get-Content -LiteralPath $sentinel -Raw) -cne "read`n") { throw 'Counter positive control failed.' }
    $checks.Add('The getter positive control writes exactly one sentinel entry.')
    if ((Get-FileHash (Join-Path $workspace 'Program.cs')).Hash -ne $originalHash) { throw 'Original source changed.' }
    $provenance.status = 'passed'
} catch {
    $provenance.status = 'failed'
    $provenance.error = $_.ToString()
    throw
} finally {
    $env:WORKFLOW_LSP_SENTINEL = $previousSentinel
    $provenance.completedUtc = [DateTime]::UtcNow.ToString('o')
    $provenance.artifacts = @(Get-ChildItem -LiteralPath $EvidenceDirectory -File -Recurse |
        Where-Object { $_.FullName -notlike "$workspace\bin\*" -and $_.FullName -notlike "$workspace\obj\*" } |
        ForEach-Object { @{ path = $_.FullName; sha256 = (Get-FileHash -LiteralPath $_.FullName).Hash } })
    $provenance | ConvertTo-Json -Depth 12 | Set-Content (Join-Path $EvidenceDirectory 'provenance.json')
}
