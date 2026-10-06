param(
    [Parameter(Mandatory = $true)][string] $PackageDirectory,
    [string] $Version = '1.0.0-preview.3-native-csharp.1',
    [string] $ExpressionOutputPath,
    [string] $DependencySource = 'https://packagefeedproxy.microsoft.io/nuget/v3/index.json'
)
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$consumer = Join-Path $root 'tests\PackageConsumer\PackageConsumer.csproj'
$cache = Join-Path $root ('out\package-consumer-' + [Guid]::NewGuid().ToString('N'))
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
