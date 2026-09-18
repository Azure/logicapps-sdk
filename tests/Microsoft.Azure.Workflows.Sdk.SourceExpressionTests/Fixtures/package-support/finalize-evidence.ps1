$ErrorActionPreference = 'Stop'
$root = $PSScriptRoot
$repo = (Get-Location).Path
$pack = Get-Content (Join-Path $root 'pack-provenance.json') -Raw | ConvertFrom-Json
$validation = Get-Content (Join-Path $root 'validation-attempt1.json') -Raw | ConvertFrom-Json
$matrixPath = Join-Path $root 'expanded\expanded-pk-evidence.json'
$matrix = Get-Content $matrixPath -Raw | ConvertFrom-Json
$idePath = Join-Path $root 'actual-ide\provenance.json'
$ide = Get-Content $idePath -Raw | ConvertFrom-Json
$ideResultPath = Join-Path $root 'actual-ide\actual-ide-evidence.json'
$ideResult = Get-Content $ideResultPath -Raw | ConvertFrom-Json
$worker = Get-Content (Join-Path $root 'repository-worker.json') -Raw | ConvertFrom-Json
$assets = Get-Content (Join-Path $root 'build-assets.json') -Raw | ConvertFrom-Json
if ($pack.exitCode -ne 0 -or $validation.exitCode -ne 0 -or $worker.exitCode -ne 0 -or $assets.exitCode -ne 0 -or
    $ide.status -ne 'passed' -or $ideResult.status -ne 'passed' -or $matrix.commands.Count -ne 97 -or
    $matrix.cases.Count -ne 39 -or $matrix.failedChecks.Count -ne 0 -or $matrix.outcome -ne 'passed') {
    throw 'A required gate did not complete successfully.'
}
foreach ($record in @($matrix, $ide)) {
    foreach ($name in @('packageSha256', 'runtimeSha256', 'compilerSha256')) {
        if ($record.$name -ne $pack.$name) { throw "Gate identity mismatch: $name" }
    }
}
if ((Get-FileHash $pack.package).Hash -ne $pack.packageSha256) { throw 'Package changed.' }
if ((Get-FileHash (Join-Path $repo 'out\bin\src\Microsoft.Azure.Workflows.Sdk\debug\Microsoft.Azure.Workflows.Sdk.dll')).Hash -ne $pack.runtimeSha256 -or
    (Get-FileHash (Join-Path $repo 'out\bin\src\Microsoft.Azure.Workflows.Sdk.Build\debug\Microsoft.Azure.Workflows.Sdk.Build.dll')).Hash -ne $pack.compilerSha256) {
    throw 'Shared output identity changed after the authorized freeze.'
}
foreach ($artifact in $ide.artifacts) {
    if ((Get-FileHash $artifact.path).Hash -ne $artifact.sha256) { throw "IDE evidence mismatch: $($artifact.path)" }
}
foreach ($command in $matrix.commands) {
    $snapshot = Join-Path (Join-Path $root 'expanded\logs') (Split-Path $command.log -Leaf)
    if ((Get-FileHash $snapshot).Hash -ne $command.logSha256) { throw "Matrix log mismatch: $snapshot" }
}
foreach ($fixture in $matrix.fixtureSha256.PSObject.Properties) {
    $marker = '\MatrixFixtures\'
    $index = $fixture.Name.IndexOf($marker, [StringComparison]::OrdinalIgnoreCase)
    $snapshot = if ($index -ge 0) {
        Join-Path (Join-Path $root 'expanded\MatrixFixtures') $fixture.Name.Substring($index + $marker.Length)
    } elseif ($fixture.Name.EndsWith('\Consumer\Program.cs', [StringComparison]::OrdinalIgnoreCase)) {
        Join-Path $root 'expanded\Consumer.Program.cs.txt'
    } else {
        throw "Unknown fixture snapshot mapping: $($fixture.Name)"
    }
    if ((Get-FileHash $snapshot).Hash -ne $fixture.Value) { throw "Fixture snapshot mismatch: $snapshot" }
}
$catalog = Join-Path $repo 'tests\Microsoft.Azure.Workflows.Sdk.SourceExpressionTests\Fixtures\approved-catalog.md'
Copy-Item $catalog (Join-Path $root 'approved-catalog.md.txt')
Copy-Item (Join-Path $repo 'tests\SourcePackageConsumer\README.md') (Join-Path $root 'validation-readme.md.txt')
$records = @{}
foreach ($line in Get-Content $catalog) {
    if ($line -match '^\| (PK\d{2}) \| (.*?) \| (.*?) \|$') {
        $records[$Matches[1]] = @{ original = $line; input = $Matches[2]; expected = $Matches[3] }
    }
}
if ($records.Count -ne 20) { throw 'Expected exactly twenty authoritative PK records.' }
$baseCommands = [Collections.Generic.List[object]]::new()
$logLines = @(Get-Content $validation.log)
$activeCommand = $null
for ($i = 0; $i -lt $logLines.Count; $i++) {
    if ($logLines[$i] -match '^COMMAND dotnet argv=(.+)$') {
        $activeCommand = [ordered]@{ executable = 'dotnet'; argv = ConvertFrom-Json $Matches[1]; logLine = $i + 1 }
    } elseif ($activeCommand -and $logLines[$i] -match '^EXIT (-?\d+)') {
        $activeCommand.exitCode = [int]$Matches[1]
        $activeCommand.exitLogLine = $i + 1
        $baseCommands.Add($activeCommand)
        $activeCommand = $null
    }
}
$cases = [Collections.Generic.List[object]]::new()
$markers = @{
    PK01 = 'CHECK package-only-build-original-source-unchanged PASS'
    PK03 = 'CHECK published-definition-parity-and-no-compiler-leakage PASS'
    PK04 = 'CHECK repeated-build-identical-inputs-content-and-json PASS'
    PK12 = 'CHECK arbitrary-workflow-generator-explicit-rejection PASS'
}
foreach ($id in $records.Keys | Sort-Object) {
    $case = [ordered]@{
        id = $id; original = $records[$id].original; input = $records[$id].input
        expected = $records[$id].expected; heading = '### 14.6 Build, packaging, and tooling tests'
        tests = @()
    }
    $expanded = $matrix.cases | Where-Object id -eq $id
    if ($id -eq 'PK13') {
        $case.status = 'passed'
        $case.command = $ide.launch
        $case.exitCode = 0
        $case.log = $ideResultPath
        $case.logLines = @((Select-String -Path $ideResultPath -Pattern 'beforeBuild:|afterBuild:|Actual VS Code integrated|Built application emits').LineNumber)
        $case.checks = $ideResult.checks
        $case.provenance = $idePath
        $case.limit = 'Actual Windows VS Code 1.137.0 / C# 2.160.4; not Visual Studio or all editor configurations.'
    } elseif ($expanded) {
        foreach ($key in @('status', 'command', 'exitCode', 'checks', 'details', 'commandCount')) { $case[$key] = $expanded.$key }
        $case.commandLog = Join-Path (Join-Path $root 'expanded\logs') (Split-Path $expanded.log -Leaf)
        $case.commandLogSha256 = (Get-FileHash $case.commandLog).Hash
        $case.log = $validation.log
        $case.logLines = @((Select-String -Path $validation.log -Pattern "^CHECK $id ").LineNumber)
        $case.provenance = $matrixPath
    } elseif ($markers.ContainsKey($id)) {
        $hits = @(Select-String -Path $validation.log -SimpleMatch -Pattern $markers[$id])
        if ($hits.Count -ne 1) { throw "Missing or duplicated completed assertion for $id" }
        $case.status = if ($id -eq 'PK12') { 'negative-case-passed' } else { 'passed' }
        $case.command = @($baseCommands | Where-Object { $_.exitLogLine -lt $hits[0].LineNumber } | Select-Object -Last 1)
        $case.exitCode = $case.command[0].exitCode
        $case.log = $validation.log
        $case.logLines = @($hits[0].LineNumber)
        $case.checks = @($hits[0].Line)
        if ($id -eq 'PK12') { $case.limit = 'Unsupported generated workflow explicitly rejected with WFSDK1002; arbitrary generator ordering/support is not claimed.' }
    } elseif ($id -eq 'PK17') {
        $case.status = 'partial'
        $case.command = @($ide.restore) + @($ideResult.commands)
        $case.exitCode = 0
        $case.log = $ideResultPath
        $case.checks = @('Windows .NET SDK 9.0.318 package restore/build and actual VS Code integrated build passed; exact CB01 output.')
        $case.unverified = 'Other CLI/IDE platforms remain unverified: Docker engine unavailable following context-metadata access denial; WSL only has stopped docker-desktop. No Linux/macOS build ran.'
    } else {
        $case.status = 'unverified'
        $case.checks = @()
        $case.unverified = 'This compiler/runtime diagnostic contract is covered by separate source-suite evidence, not this external package run. No xUnit result is invented here.'
    }
    $cases.Add($case)
}
$provenancePath = Join-Path $root 'final-validation-provenance.json'
$provenance = [ordered]@{
    evidenceKind = 'external-package-validation'
    completedUtc = [DateTime]::UtcNow.ToString('o')
    package = $pack.package; packageSha256 = $pack.packageSha256
    runtimeSha256 = $pack.runtimeSha256; compilerSha256 = $pack.compilerSha256
    catalogSha256 = (Get-FileHash $catalog).Hash
    validatorSha256 = $validation.validatorSha256
    matrixValidatorSha256 = $validation.matrixValidatorSha256
    finalizeScriptSha256 = (Get-FileHash $PSCommandPath).Hash
    pack = $pack; validation = $validation; commands = $baseCommands
    expandedEvidence = $matrixPath; expandedEvidenceSha256 = (Get-FileHash $matrixPath).Hash
    expandedCommandCount = $matrix.commands.Count; expandedCaseCount = $matrix.cases.Count
    failedChecks = $matrix.failedChecks; actualIde = $idePath
    actualIdeSha256 = (Get-FileHash $idePath).Hash
    repositoryWorker = $worker; buildAssets = $assets
    scope = 'Authorized no-build package refresh, base consumer/Worker, full expanded matrix, independent build assets, original Worker and actual Windows VS Code.'
    excludedStages = @('Unrelated existing-sample generation, explicitly SkipExistingSamples', 'Linux/macOS and other IDE configurations', 'Execution-backend certification')
    sharedOutputsUnchanged = $true
    artifacts = @(@(Get-ChildItem $root -File | Where-Object Name -notin @('final-validation-provenance.json', 'final-pk-evidence.json')) +
        @(Get-ChildItem (Join-Path $root 'expanded') -File -Recurse) |
        ForEach-Object { @{ path = $_.FullName; sha256 = (Get-FileHash $_.FullName).Hash } })
}
$provenance | ConvertTo-Json -Depth 20 | Set-Content $provenancePath
$evidence = [ordered]@{
    schemaVersion = 1; evidenceKind = 'external-package-validation'
    catalog = $catalog; catalogSection = '14.6'; catalogSha256 = (Get-FileHash $catalog).Hash
    completedUtc = $provenance.completedUtc
    packageSha256 = $pack.packageSha256; runtimeSha256 = $pack.runtimeSha256; compilerSha256 = $pack.compilerSha256
    provenance = $provenancePath; provenanceSha256 = (Get-FileHash $provenancePath).Hash
    log = $validation.log; logSha256 = $validation.logSha256
    cases = $cases
    additionalChecks = @($matrix.cases | Where-Object id -notmatch '^PK\d+$')
    remainingGaps = @('PK15/PK16 require their separate source-suite evidence', 'PK17 other CLI/IDE platforms', 'No execution-backend certification from package/IDE probes')
}
$evidence | ConvertTo-Json -Depth 24 | Set-Content (Join-Path $root 'final-pk-evidence.json')
$cases | ForEach-Object { [pscustomobject]$_ } | Group-Object status | Select-Object Name, Count
