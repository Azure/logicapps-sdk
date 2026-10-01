param(
    [Parameter(Mandatory)][string]$ComparisonPath,
    [Parameter(Mandatory)][string]$OursCompileResults,
    [Parameter(Mandatory)][string]$ComparisonCompileResults,
    [Parameter(Mandatory)][string]$OutputPath
)
$ErrorActionPreference = 'Stop'
$comparison = Get-Content -Raw -LiteralPath $ComparisonPath | ConvertFrom-Json
$coverage = Get-Content -Raw (Join-Path $PSScriptRoot 'case-coverage.json') | ConvertFrom-Json
$oursDiagnostics = @(Get-Content -Raw -LiteralPath $OursCompileResults | ConvertFrom-Json)
$otherDiagnostics = @(Get-Content -Raw -LiteralPath $ComparisonCompileResults | ConvertFrom-Json)
$byId = @{}
foreach ($result in $comparison.results) { $byId[$result.id] = $result }
if (@($coverage.cases.failureId | Sort-Object -Unique).Count -ne $coverage.originalFailureCount) {
    throw 'Coverage IDs do not reconcile with the original failure count.'
}
function Cell($value) {
    if ($null -eq $value) { return '(none)' }
    return ([string]$value).Replace('|','&#124;').Replace("`r",'').Replace("`n",'<br>')
}
function Observation($result) {
    $status = if ($null -ne $result.httpStatus) { ", HTTP $($result.httpStatus)" } else { '' }
    $expected = if ($result.passed) { 'contract met' } else { 'contract NOT met' }
    return "$($result.outcome)$status; $expected"
}
$lines = [System.Collections.Generic.List[string]]::new()
$lines.Add('# Paired source-expression workflow regression')
$lines.Add('')
$evidenceTime = ([DateTimeOffset]$comparison.createdUtc).ToUniversalTime().ToString('o')
$lines.Add("Generated from actual-host evidence (UTC): $evidenceTime.")
$lines.Add('')
$lines.Add("- Repository workflows and runner: ``tests\SourceExpressionE2E``.")
$lines.Add("- Your result: ``$($comparison.oursEvidence)``.")
$lines.Add("- Comparison result: ``$($comparison.comparisonEvidence)``.")
$lines.Add("- Machine-readable paired evidence: ``$([IO.Path]::GetFullPath($ComparisonPath))``.")
$lines.Add('')
$lines.Add('## Scope and interpretation')
$lines.Add('')
$lines.Add('Both sides use matching workflow/harness source fingerprints and the same native-capable local runtime binaries. Compile-rejected factories retain isolated build evidence; their diagnostics were not suppressed. Neither SDK product implementation nor its emitted expressions was patched.')
$lines.Add('')
$lines.Add('The 195 original failures map to shared workflow scenarios, authoring-contract proofs, two negative compiler fixtures, and a UTC-clock property contract. This is not 195 independent executable workflows. Representative coverage does not prove every original input. Connector encoding/schema cases inspect definitions and execute only a local proof workflow: no live connector was called.')
$lines.Add('')
$lines.Add('A succeeded run can still return the wrong value. Both-failed/blocked cases are not equivalent outputs. Expected runtime failures require their specific persisted action error; clock conformance is not timestamp equality. Custom model/enum references that this native compiler cannot resolve remain blocked, not passed.')
$lines.Add('')
$lines.Add('## Scenario summary')
$lines.Add('')
$lines.Add('| Classification | Scenarios |')
$lines.Add('|---|---:|')
foreach ($property in $comparison.counts.PSObject.Properties) {
    $lines.Add("| $($property.Name) | $($property.Value) |")
}
$lines.Add('')
$lines.Add('| SDK | Expected contracts met | Successful workflow runs | Total scenarios |')
$lines.Add('|---|---:|---:|---:|')
foreach ($side in @('ours','comparison')) {
    $observations = @($comparison.results | ForEach-Object { $_.$side })
    $passed = @($observations | Where-Object passed).Count
    $succeeded = @($observations | Where-Object outcome -EQ RuntimeSucceeded).Count
    $lines.Add("| $side | $passed | $succeeded | $($observations.Count) |")
}
$authoringIds = @($coverage.cases | Where-Object coverage -EQ 'authoring-contract' |
    ForEach-Object workflowIds | Sort-Object -Unique)
$runtimeScenarios = @($comparison.results | Where-Object { $_.id -notin $authoringIds })
$lines.Add('')
$lines.Add("Of these scenarios, $($authoringIds.Count) are authoring-contract proofs and $($runtimeScenarios.Count) test runtime expressions. The two negative compiler fixtures are additional, not part of the 140 scenario count.")
$lines.Add('')
$lines.Add('| Runtime-expression classification (excluding authoring proofs) | Scenarios |')
$lines.Add('|---|---:|')
foreach ($group in @($runtimeScenarios | Group-Object classification | Sort-Object Name)) {
    $lines.Add("| $($group.Name) | $($group.Count) |")
}
$lines.Add('')
$lines.Add('## Different responses despite successful runs on both SDKs')
$lines.Add('')
$lines.Add('| Scenario | Original IDs | Expected | Yours | Comparison |')
$lines.Add('|---|---|---|---|---|')
foreach ($result in @($comparison.results | Where-Object classification -EQ DifferentResponse)) {
    $lines.Add("| $(Cell $result.id) | $($result.failureIds -join ', ') | $(Cell $result.ours.expectedBody) | $(Cell $result.ours.httpBody) | $(Cell $result.comparison.httpBody) |")
}
$lines.Add('')
$lines.Add('## All original failure IDs')
$lines.Add('')
$lines.Add('| Original ID | Coverage | Tested scenario/outcome | Qualification |')
$lines.Add('|---|---|---|---|')
foreach ($mapping in $coverage.cases) {
    $outcomes = [System.Collections.Generic.List[string]]::new()
    foreach ($id in $mapping.workflowIds) {
        if (-not $byId.ContainsKey($id)) { throw "No paired evidence for $id ($($mapping.failureId))." }
        $result = $byId[$id]
        $outcomes.Add("$id : $($result.classification)")
    }
    if ($mapping.coverage -eq 'compile-diagnostic') {
        $a = @($oursDiagnostics | Where-Object { $_.failureIds -contains $mapping.failureId })
        $b = @($otherDiagnostics | Where-Object { $_.failureIds -contains $mapping.failureId })
        if ($a.Count -ne 1 -or $b.Count -ne 1 -or $a[0].sha256 -ne $b[0].sha256) {
            throw "Missing or mismatched compiler evidence for $($mapping.failureId)."
        }
        $outcomes.Add("Compiler exit: yours=$($a[0].exitCode), comparison=$($b[0].exitCode); expected diagnostic=$($a[0].expectedDiagnostic), observed yours=$($a[0].expectedRejectionObserved), comparison=$($b[0].expectedRejectionObserved)")
    }
    if (-not $outcomes.Count) { throw "No evidence mapped for $($mapping.failureId)." }
    $lines.Add("| $($mapping.failureId) | $($mapping.coverage) | $(Cell ($outcomes -join '; ')) | $(Cell $mapping.reason) |")
}
$lines.Add('')
$lines.Add('## Per-scenario evidence')
foreach ($result in $comparison.results) {
    $lines.Add('')
    $lines.Add("### $($result.id)")
    $lines.Add('')
    $lines.Add("- Original IDs: $($result.failureIds -join ', ').")
    $lines.Add("- Classification: **$($result.classification)**.")
    $lines.Add("- Yours: $(Observation $result.ours).")
    $lines.Add("- Comparison: $(Observation $result.comparison).")
    $lines.Add('')
    foreach ($side in @('ours','comparison')) {
        $observation = $result.$side
        $lines.Add("**$side**")
        $lines.Add('')
        $lines.Add('```json')
        $detail = [ordered]@{
            inputJson = $observation.inputJson
            expectedBody = $observation.expectedBody
            expectedActionError = $observation.expectedActionError
            responseContract = $observation.responseContract
            actualHttpBody = $observation.httpBody
            generationError = $observation.generationError
            actions = @($observation.actions | Select-Object name,status,error,inputs,outputs)
        }
        $lines.Add(($detail | ConvertTo-Json -Depth 20))
        $lines.Add('```')
    }
}
$lines | Set-Content -LiteralPath $OutputPath -Encoding utf8
Write-Output "Wrote $($coverage.cases.Count) failure mappings and $($comparison.results.Count) paired scenarios to $OutputPath."
