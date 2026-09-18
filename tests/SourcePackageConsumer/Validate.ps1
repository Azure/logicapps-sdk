param(
    [Parameter(Mandatory = $true)]
    [string] $PackagePath,
    [string] $Configuration = 'Release',
    [switch] $SkipExistingSamples
)

$ErrorActionPreference = 'Stop'
$root = $PSScriptRoot
$package = Get-Item -LiteralPath $PackagePath
Write-Host "PACKAGE $($package.FullName) SHA256=$((Get-FileHash -LiteralPath $package.FullName).Hash)"
$work = Join-Path $root 'obj\package-validation'
$feed = Join-Path $work 'feed'
$packages = Join-Path $work 'packages'
$publish = Join-Path $work 'publish'
if (Test-Path -LiteralPath $work) {
    Remove-Item -LiteralPath $work -Recurse -Force
}
foreach ($fixture in @('Consumer', 'Generator', 'WorkerConsumer', 'SamplesConsumer')) {
    foreach ($directory in @('bin', 'obj')) {
        $generated = Join-Path $root "$fixture\$directory"
        if (Test-Path -LiteralPath $generated) {
            Remove-Item -LiteralPath $generated -Recurse -Force
        }
    }
}
New-Item -ItemType Directory -Path $feed -Force | Out-Null
Copy-Item -LiteralPath $package.FullName -Destination $feed -Force

Add-Type -AssemblyName System.IO.Compression.FileSystem
$archive = [System.IO.Compression.ZipFile]::OpenRead($package.FullName)
try {
    $names = @($archive.Entries | ForEach-Object FullName)
    foreach ($required in @(
        'lib/netstandard2.0/Microsoft.Azure.Workflows.Sdk.dll',
        'buildTransitive/Microsoft.Azure.Workflows.Sdk.props',
        'buildTransitive/Microsoft.Azure.Workflows.Sdk.targets',
        'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll',
        'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.deps.json',
        'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.runtimeconfig.json',
        'tools/workflow-build/Microsoft.CodeAnalysis.dll',
        'tools/workflow-build/Microsoft.CodeAnalysis.CSharp.dll'
    )) {
        if ($required -notin $names) { throw "Package is missing $required" }
    }
    $nuspecEntry = $archive.Entries | Where-Object FullName -Like '*.nuspec' | Select-Object -First 1
    $reader = [System.IO.StreamReader]::new($nuspecEntry.Open())
    try { [xml] $nuspec = $reader.ReadToEnd() } finally { $reader.Dispose() }
    $version = $nuspec.package.metadata.version
    if ($nuspec.OuterXml -match '<dependency[^>]+id="Microsoft\.CodeAnalysis') {
        throw 'Roslyn must not be a runtime package dependency.'
    }
} finally {
    $archive.Dispose()
}

function Invoke-DotNet {
    param([string[]] $Arguments)
    Write-Host "COMMAND dotnet argv=$(ConvertTo-Json -InputObject $Arguments -Compress)"
    & dotnet @Arguments
    $exitCode = $LASTEXITCODE
    Write-Host "EXIT $exitCode"
    if ($exitCode -ne 0) { throw "dotnet failed ($exitCode): $($Arguments -join ' ')" }
}

$project = Join-Path $root 'Consumer\Consumer.csproj'
$source = Join-Path $root 'Consumer\Program.cs'
$hash = (Get-FileHash -LiteralPath $source).Hash
$properties = @("-p:SdkPackageVersion=$version", "-p:RestorePackagesPath=$packages")
Invoke-DotNet (@('restore', $project, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $properties)
$restoredPackage = Join-Path $packages "microsoft.azure.workflows.sdk\$version\microsoft.azure.workflows.sdk.$version.nupkg"
if ((Get-FileHash -LiteralPath $restoredPackage).Hash -ne (Get-FileHash -LiteralPath $package.FullName).Hash) {
    throw 'Restore did not select the supplied SDK package.'
}
Invoke-DotNet (@('build', $project, '--no-restore', '-c', $Configuration, '-v:q') + $properties)
$first = Invoke-DotNet (@('run', '--project', $project, '--no-build', '--no-restore', '-c', $Configuration) + $properties)
$compilerRoot = Join-Path $root "Consumer\obj\$Configuration\net9.0\workflow-source\$Configuration\net9.0"
$compiledList = Join-Path $compilerRoot 'compiled-files.txt'
$compilerInputs = @(Get-Content -LiteralPath $compiledList)
$inputHashes = @{}
foreach ($inputPath in $compilerInputs) {
    if ($inputHashes.ContainsKey($inputPath)) { throw "Duplicate transformed input: $inputPath" }
    $inputHashes[$inputPath] = (Get-FileHash -LiteralPath $inputPath).Hash
}
$transformedText = ($compilerInputs | ForEach-Object { Get-Content -LiteralPath $_ -Raw }) -join "`n"
foreach ($requiredApi in @('nativeSegments:', 'typeWitness:', 'SourceExpression.TypeName', 'SourceExpression.Token')) {
    if (!$transformedText.Contains($requiredApi)) {
        throw "The packaged compiler is stale: transformed fixture did not emit $requiredApi"
    }
}
Invoke-DotNet (@('build', $project, '--no-restore', '-c', $Configuration, '-v:q') + $properties)
$second = Invoke-DotNet (@('run', '--project', $project, '--no-build', '--no-restore', '-c', $Configuration) + $properties)
if ("$first" -cne "$second") { throw 'Repeated build changed workflow output.' }
if (Compare-Object $compilerInputs @(Get-Content -LiteralPath $compiledList)) {
    throw 'Repeated build changed transformed compiler inputs.'
}
foreach ($inputPath in $compilerInputs) {
    if ((Get-FileHash -LiteralPath $inputPath).Hash -ne $inputHashes[$inputPath]) {
        throw "Repeated build changed transformed content: $inputPath"
    }
}
if ((Get-FileHash -LiteralPath $source).Hash -ne $hash) { throw 'Transformation modified original source.' }
if (!(Test-Path -LiteralPath (Join-Path $compilerRoot 'build-manifest.json'))) {
    throw 'Package build did not generate a workflow manifest under obj.'
}
Write-Host "CHECK package-only-build-original-source-unchanged PASS sourceSHA256=$hash manifest=$compilerRoot\build-manifest.json"
Write-Host "CHECK consumer-definition-and-final-abi PASS output=$first"
Write-Host "CHECK repeated-build-identical-inputs-content-and-json PASS inputCount=$($compilerInputs.Count)"
Invoke-DotNet (@('publish', $project, '--no-restore', '-c', $Configuration, '-o', $publish, '-v:q') + $properties)
$leaked = @(Get-ChildItem $publish -Recurse -File | Where-Object { $_.Name -like 'Microsoft.CodeAnalysis*' -or $_.Name -like 'Microsoft.Azure.Workflows.Sdk.Build*' })
if ($leaked.Count -ne 0) { throw "Build dependencies leaked into publish: $($leaked.FullName -join ', ')" }
$published = Invoke-DotNet -Arguments @((Join-Path $publish 'Consumer.dll'))
if ("$first" -cne "$published") { throw 'Published workflow differs from build output.' }
Write-Host 'CHECK published-definition-parity-and-no-compiler-leakage PASS'
$analyzerProperties = $properties + '-p:IncludeAnalyzerOnlyPackage=true'
Invoke-DotNet (@('restore', $project, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $analyzerProperties)
Invoke-DotNet (@('build', $project, '--no-restore', '-c', $Configuration, '-v:q') + $analyzerProperties)
Write-Host 'CHECK analyzer-only-package-accepted PASS'
$generatorProperties = $properties + '-p:IncludeWorkflowGenerator=true'
Invoke-DotNet (@('restore', $project, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $generatorProperties)
$generatorArguments = @('build', $project, '--no-restore', '-c', $Configuration, '-v:q') + $generatorProperties
Write-Host "COMMAND dotnet argv=$($generatorArguments | ConvertTo-Json -Compress)"
$generatorResult = & dotnet @generatorArguments 2>&1
$generatorExitCode = $LASTEXITCODE
Write-Host ($generatorResult -join [Environment]::NewLine)
Write-Host "EXIT $generatorExitCode (expected nonzero)"
if ($generatorExitCode -eq 0 -or "$generatorResult" -notmatch 'WFSDK1002: Unsupported source-generator metadata' -or "$generatorResult" -notmatch 'Generator.dll') {
    throw "PK12 expected explicit rejection of the fixture workflow generator: $generatorResult"
}
Write-Host 'CHECK arbitrary-workflow-generator-explicit-rejection PASS; generated-source positive support NOT VERIFIED'
Invoke-DotNet (@('restore', $project, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $properties)
$workerProject = Join-Path $root 'WorkerConsumer\WorkerConsumer.csproj'
Invoke-DotNet (@('restore', $workerProject, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $properties)
Invoke-DotNet (@('build', $workerProject, '--no-restore', '-c', $Configuration, '-v:q') + $properties)
Invoke-DotNet (@('run', '--project', $workerProject, '--no-build', '--no-restore', '-c', $Configuration) + $properties)
$workerSources = @(Get-ChildItem (Join-Path $root "WorkerConsumer\obj\worker-generated\$Configuration") -Filter '*.cs' -Recurse)
foreach ($generatedName in @('GeneratedFunctionMetadataProvider.g.cs', 'GeneratedFunctionExecutor.g.cs')) {
    if (@($workerSources | Where-Object Name -EQ $generatedName).Count -ne 1) {
        throw "Expected exactly one Worker generator output named $generatedName"
    }
}
$generatedText = ($workerSources | ForEach-Object { Get-Content -LiteralPath $_.FullName -Raw }) -join "`n"
if (!$generatedText.Contains('WorkflowProbe.Run') -or $generatedText -match 'WorkflowActions|SourceExpression\.Create') {
    throw 'Worker generated output must dispatch to the original function without generating workflow lambdas.'
}
$workerManifest = Get-Content (Join-Path $root "WorkerConsumer\obj\$Configuration\net8.0\workflow-source\$Configuration\net8.0\build-manifest.json") -Raw | ConvertFrom-Json
if (@($workerManifest.sources | Where-Object { $_ -match 'worker-generated' }).Count -ne 0) {
    throw 'Worker source generators unexpectedly ran before workflow transformation.'
}
$workerMetadata = Join-Path $root "WorkerConsumer\bin\$Configuration\net8.0\functions.metadata"
if (!(Get-Content -LiteralPath $workerMetadata -Raw).Contains('WorkflowProbe')) {
    throw 'Worker build did not produce metadata for the transformed function.'
}
Write-Host 'CHECK pinned-worker-generators-metadata-dispatch-and-ordering PASS'
& (Join-Path $PSScriptRoot 'Validate-Matrix.ps1') -PackagePath $package.FullName -SdkPackageVersion $version `
    -PackagesPath $packages -FeedPath $feed -Configuration $Configuration
if ($SkipExistingSamples) {
    Write-Host 'SCOPE existing sample definition generation NOT RUN (SkipExistingSamples requested).'
    Write-Host 'Package and Worker checks passed. See per-PK evidence for exact coverage.'
    return
}
$sampleHashes = @{}
Get-ChildItem (Join-Path $root '..\Microsoft.Azure.Workflows.Sdk.UnitTests\Workflows') -Filter '*.cs' |
    ForEach-Object { $sampleHashes[$_.FullName] = (Get-FileHash -LiteralPath $_.FullName).Hash }
$samplesProject = Join-Path $root 'SamplesConsumer\SamplesConsumer.csproj'
Invoke-DotNet (@('restore', $samplesProject, '--force', "-p:RestoreAdditionalProjectSources=$feed") + $properties)
Invoke-DotNet (@('build', $samplesProject, '--no-restore', '-c', $Configuration, '-v:q') + $properties)
try {
    Invoke-DotNet -Arguments @((Join-Path $root "SamplesConsumer\bin\$Configuration\net9.0\SamplesConsumer.dll"), (Join-Path $work 'existing-sample-definitions.json'))
} finally {
    foreach ($samplePath in $sampleHashes.Keys) {
        if ((Get-FileHash -LiteralPath $samplePath).Hash -ne $sampleHashes[$samplePath]) {
            throw "Existing sample source was modified: $samplePath"
        }
    }
}
Write-Host 'Package, Worker, and existing sample definition checks passed. See per-PK evidence for exact coverage.'
