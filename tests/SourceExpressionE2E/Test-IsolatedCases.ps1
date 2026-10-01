param(
    [Parameter(Mandatory)][string]$OutputDirectory,
    [Parameter(Mandatory)][string]$BaselineGenerationManifest,
    [Parameter(Mandatory)][string]$ComparisonSdkAssembly,
    [Parameter(Mandatory)][string]$ComparisonGeneratorAssembly
)
$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$manifest = Get-Content -Raw (Join-Path $PSScriptRoot 'case-coverage.json') | ConvertFrom-Json
$cases = @($manifest.isolatedCompileCases)
if (-not $cases.Count -or $null -eq $cases[0]) { throw 'No isolated compiler cases were declared.' }
$baseline = @(Get-Content -Raw -LiteralPath $BaselineGenerationManifest | ConvertFrom-Json)
$output = [IO.Path]::GetFullPath($OutputDirectory)
New-Item -ItemType Directory -Path $output -Force | Out-Null
$root = [IO.Path]::GetFullPath($PSScriptRoot) + [IO.Path]::DirectorySeparatorChar
$rejections = foreach ($case in $cases) {
    $source = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot $case.file))
    if (-not $source.StartsWith($root, [StringComparison]::OrdinalIgnoreCase) -or
        -not (Test-Path -LiteralPath $source) -or $case.id -notmatch '^[A-Za-z0-9_-]+$') {
        throw "Invalid isolated case: $($case.id)"
    }
    $entry = @($baseline | Where-Object { $_.case.id -eq $case.id })
    if ($entry.Count -ne 1 -or $entry[0].generationStatus -ne 'Generated') {
        throw "Baseline must contain exactly one generated workflow for $($case.id)."
    }
    $excluded = (@($cases | Where-Object id -NE $case.id).file) -join '%3B'
    $log = Join-Path $output "$($case.id).log"
    if (Test-Path -LiteralPath $log) { throw 'Choose a fresh output directory.' }
    & dotnet build (Join-Path $PSScriptRoot 'SourceExpressionE2E.csproj') --no-restore --verbosity quiet `
        -p:BuildProjectReferences=false -p:GeneratePackageOnBuild=false `
        "-p:ComparisonSdkAssembly=$ComparisonSdkAssembly" "-p:ComparisonGeneratorAssembly=$ComparisonGeneratorAssembly" `
        "-p:E2EExcludedSources=$excluded" 2>&1 | Set-Content -LiteralPath $log
    $exitCode = $LASTEXITCODE
    $text = Get-Content -Raw -LiteralPath $log
    $diagnosticPattern = [regex]::Escape($source) + '\(\d+,\d+\): error ' + [regex]::Escape($case.expectedDiagnostic) + ':'
    if ($exitCode -eq 0 -or $text -notmatch $diagnosticPattern) {
        throw "Expected source-specific compiler rejection was not reproduced for $($case.id); inspect $log."
    }
    foreach ($other in @($cases | Where-Object id -NE $case.id)) {
        if ($text -match ([regex]::Escape([IO.Path]::GetFileName($other.file)) + '\(\d+,\d+\): error ')) {
            throw "Isolation failed: another fixture produced a compiler error while testing $($case.id)."
        }
    }
    [ordered]@{
        case = $entry[0].case
        method = $entry[0].method
        generationStatus = 'CompileRejected'
        generationExpectationMet = $false
        errorType = $case.expectedDiagnostic
        error = $text
        compileSourceSha256 = (Get-FileHash -LiteralPath $source).Hash
        compileBuildLog = $log
    }
}
ConvertTo-Json -InputObject @($rejections) -Depth 20 |
    Set-Content (Join-Path $output 'compile-rejections.json')
Write-Output "Recorded $($rejections.Count) isolated compiler rejections; no diagnostics were suppressed."
Write-Output "Runtime build exclusion property: -p:E2EExcludedSources=$($cases.file -join '%3B')"
