param(
    [Parameter(Mandatory = $true)][string] $PackageDirectory,
    [string] $Version,
    [string] $ExpressionOutputPath,
    [string] $DependencySource = 'https://packagefeedproxy.microsoft.io/nuget/v3/index.json'
)
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$consumer = Join-Path $root 'tests\PackageConsumer\PackageConsumer.csproj'
$cache = Join-Path $root ('out\package-consumer-' + [Guid]::NewGuid().ToString('N'))
if (-not $Version) {
    $versionPropsPath = Join-Path $root 'src\Directory.Version.props'
    $versionProps = [xml](Get-Content -LiteralPath $versionPropsPath -Raw)
    $prefix = [string]$versionProps.Project.PropertyGroup.VersionPrefix
    $suffix = [string]$versionProps.Project.PropertyGroup.VersionSuffix
    if (-not $prefix) { throw "VersionPrefix is missing from '$versionPropsPath'." }
    $Version = if ($suffix) { "$prefix-$suffix" } else { $prefix }
}
$packagePath = Join-Path $PackageDirectory "Microsoft.Azure.Workflows.Sdk.$Version.nupkg"
if (-not (Test-Path -LiteralPath $packagePath)) {
    throw "The SDK package '$packagePath' does not exist."
}
$requiredEntries = @(
    'buildTransitive/Microsoft.Azure.Workflows.Sdk.targets',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.dll',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.deps.json',
    'tools/workflow-build/Microsoft.Azure.Workflows.Sdk.Build.runtimeconfig.json',
    'tools/workflow-build/Microsoft.CodeAnalysis.dll',
    'tools/workflow-build/Microsoft.CodeAnalysis.CSharp.dll'
)
$archive = [System.IO.Compression.ZipFile]::OpenRead((Resolve-Path -LiteralPath $packagePath).Path)
try {
    $entries = @($archive.Entries | ForEach-Object { $_.FullName.Replace('\', '/') })
    $missingEntries = @($requiredEntries | Where-Object { $entries -notcontains $_ })
    if ($missingEntries.Count -ne 0) {
        throw "The SDK package is missing required build assets: $($missingEntries -join ', ')."
    }
}
finally {
    $archive.Dispose()
}
try {
    New-Item -ItemType Directory -Path $cache -Force | Out-Null
    $config = [xml]'<configuration><packageSources><clear/><add key="sdk" value=""/><add key="dependencies" value=""/></packageSources><disabledPackageSources><clear/></disabledPackageSources><packageSourceMapping><clear/><packageSource key="sdk"><package pattern="Microsoft.Azure.Workflows.Sdk"/></packageSource><packageSource key="dependencies"><package pattern="*"/></packageSource></packageSourceMapping></configuration>'
    $config.configuration.packageSources.add[0].SetAttribute('value', (Resolve-Path $PackageDirectory).Path)
    $config.configuration.packageSources.add[1].SetAttribute('value', $DependencySource)
    $configPath = Join-Path $cache 'NuGet.config'
    $config.Save($configPath)
    dotnet restore $consumer --packages $cache --configfile $configPath "-p:WorkflowSdkVersion=$Version" --nologo
    if ($LASTEXITCODE -ne 0) { throw 'Package consumer restore failed.' }
    $arguments = @()
    if ($ExpressionOutputPath) { $arguments += $ExpressionOutputPath }
    dotnet run --project $consumer --no-restore "-p:WorkflowSdkVersion=$Version" -- @arguments
    if ($LASTEXITCODE -ne 0) { throw 'Package consumer failed.' }
}
finally {
    if (Test-Path -LiteralPath $cache) { Remove-Item -LiteralPath $cache -Recurse -Force }
}
