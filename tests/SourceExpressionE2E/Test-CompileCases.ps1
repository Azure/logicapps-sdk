param(
    [Parameter(Mandatory)][string]$OutputDirectory,
    [string]$ComparisonSdkAssembly,
    [string]$ComparisonGeneratorAssembly,
    [switch]$RecordOnly
)
$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$manifest = Get-Content -Raw (Join-Path $PSScriptRoot 'case-coverage.json') | ConvertFrom-Json
$cases = @($manifest.compileCases)
if (-not $cases.Count -or $null -eq $cases[0]) { throw 'The manifest contains no compile cases.' }
$output = [IO.Path]::GetFullPath($OutputDirectory)
New-Item -ItemType Directory -Path $output -Force | Out-Null
$fixtureRoot = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot 'CompileCases')) + [IO.Path]::DirectorySeparatorChar
$results = foreach ($case in $cases) {
    $fixture = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot $case.file))
    if (-not $fixture.StartsWith($fixtureRoot, [StringComparison]::OrdinalIgnoreCase) -or -not (Test-Path -LiteralPath $fixture)) {
        throw "Compile fixture is missing or outside CompileCases: $($case.id)"
    }
    if ($case.id -notmatch '^[A-Za-z0-9_-]+$' -or -not $case.expectedDiagnostic) {
        throw 'Compile case requires a safe ID and explicit expected diagnostic.'
    }
    $log = Join-Path $output "$($case.id).log"
    if (Test-Path -LiteralPath $log) { throw 'Use a fresh output directory; compile evidence must not be overwritten.' }
    $arguments = @('build', (Join-Path $PSScriptRoot 'SourceExpressionE2E.csproj'),
        '--no-restore', '--verbosity', 'quiet', '-p:BuildProjectReferences=false',
        '-p:GeneratePackageOnBuild=false', "-p:E2ECompileCase=$fixture")
    if ($ComparisonSdkAssembly) {
        if (-not $ComparisonGeneratorAssembly) { throw 'Comparison generator is required with its SDK.' }
        $arguments += "-p:ComparisonSdkAssembly=$ComparisonSdkAssembly"
        $arguments += "-p:ComparisonGeneratorAssembly=$ComparisonGeneratorAssembly"
    }
    & dotnet @arguments 2>&1 | Set-Content -LiteralPath $log
    $exitCode = $LASTEXITCODE
    $text = Get-Content -Raw -LiteralPath $log
    $matched = $exitCode -ne 0 -and $text.Contains([string]$case.expectedDiagnostic)
    [ordered]@{
        id = $case.id
        failureIds = @($case.failureIds)
        file = $case.file
        sha256 = (Get-FileHash -LiteralPath $fixture).Hash
        expectedDiagnostic = $case.expectedDiagnostic
        exitCode = $exitCode
        expectedRejectionObserved = $matched
        output = $text
    }
}
$results | ConvertTo-Json -Depth 10 | Set-Content (Join-Path $output 'compile-results.json')
$results | ForEach-Object {
    Write-Output "$($_.id): build exit $($_.exitCode), expected rejection observed=$($_.expectedRejectionObserved)"
}
if (@($results | Where-Object { -not $_.expectedRejectionObserved }).Count -and -not $RecordOnly) {
    throw "Compiler contract expectations failed; see $output."
}
