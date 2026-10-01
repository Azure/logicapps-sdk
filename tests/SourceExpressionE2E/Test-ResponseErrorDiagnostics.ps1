[CmdletBinding(DefaultParameterSetName = 'Evidence')]
param(
    [Parameter(Mandatory, ParameterSetName = 'Evidence')][string]$ResultsPath,
    [Parameter(Mandatory, ParameterSetName = 'Evidence')][string]$BaselineResultsPath,
    [Parameter(Mandatory, ParameterSetName = 'Evidence')][string]$ExpectedErrorCode,
    [Parameter(Mandatory, ParameterSetName = 'Evidence')][string]$ExpectedErrorMessage,
    [Parameter(ParameterSetName = 'Evidence')][int]$ExpectedHttpStatus = 502,
    [Parameter(Mandatory, ParameterSetName = 'SelfTest')][switch]$SelfTest
)
$ErrorActionPreference = 'Stop'

function Assert-ResponseDiagnostics($Current, $Baseline, [string]$Code, [string]$Message, [int]$HttpStatus) {
    if ([string]::IsNullOrWhiteSpace($Code) -or [string]::IsNullOrWhiteSpace($Message) -or
        $Code -in @('InternalServerError', 'NoResponse')) {
        throw 'A specific safe error code and exact message are required.'
    }
    $cases = @($Current.results)
    $baselineCases = @($Baseline.results)
    $ids = @($cases.id | Sort-Object)
    $baselineIds = @($baselineCases.id | Sort-Object)
    if ($ids.Count -ne @($ids | Select-Object -Unique).Count -or
        $baselineIds.Count -ne @($baselineIds | Select-Object -Unique).Count -or
        (Compare-Object $ids $baselineIds)) {
        throw 'Diagnostic verification requires identical, unique case selections.'
    }
    $actual = @($cases | Where-Object id -CEQ 'NativeUri')
    $previous = @($baselineCases | Where-Object id -CEQ 'NativeUri')
    if ($actual.Count -ne 1 -or $previous.Count -ne 1) {
        throw 'Exactly one unchanged NativeUri scenario is required.'
    }
    $actual = $actual[0]
    $previous = $previous[0]
    if (-not $actual.definitionSha256 -or $actual.definitionSha256 -cne $previous.definitionSha256) {
        throw 'The NativeUri workflow definition changed; this does not prove a diagnostic-only fix.'
    }
    if ($actual.httpStatus -ne $HttpStatus -or $actual.runStatus -cne 'Failed' -or
        $actual.outcome -cne 'RuntimeFailed') {
        throw 'NativeUri must remain an explicitly failed workflow with the expected HTTP status.'
    }
    $response = @($actual.actions | Where-Object name -CEQ 'Response')
    $priorResponse = @($previous.actions | Where-Object name -CEQ 'Response')
    if ($response.Count -ne 1 -or $response[0].status -cne 'Failed' -or
        $response[0].code -cne 'BadRequest' -or $response[0].error.code -cne $Code -or
        $response[0].error.message -cne $Message) {
        throw 'Response history does not contain the expected specific error.'
    }
    if ($priorResponse.Count -ne 1 -or $priorResponse[0].error.code -cne 'InternalServerError') {
        throw 'The baseline must reproduce the original opaque Response error.'
    }
    $httpBody = $actual.httpBody | ConvertFrom-Json
    if ($httpBody.error.code -cne $Code -or $httpBody.error.message -cne $Message) {
        throw 'The caller did not receive the exact safe diagnostic; action history alone is insufficient.'
    }
    $unexpectedFields = @($httpBody.PSObject.Properties.Name | Where-Object { $_ -cne 'error' }) +
        @($httpBody.error.PSObject.Properties.Name | Where-Object { $_ -cnotin @('code', 'message') })
    if ($unexpectedFields.Count) {
        throw 'The caller error contains unexpected fields; review them for sensitive exception details.'
    }
    foreach ($name in @('Source', 'Result')) {
        $action = @($actual.actions | Where-Object name -CEQ $name)
        $oldAction = @($previous.actions | Where-Object name -CEQ $name)
        if ($action.Count -ne 1 -or $oldAction.Count -ne 1 -or $action[0].status -cne 'Succeeded' -or
            -not $action[0].outputs.present -or -not $oldAction[0].outputs.present -or
            $action[0].outputs.raw -cne $oldAction[0].outputs.raw) {
            throw "The unchanged '$name' action no longer has its original successful result."
        }
    }
    $controls = @($cases | Where-Object id -CNE 'NativeUri')
    if (-not $controls.Count) { throw 'At least one supported-response control is required.' }
    foreach ($control in $controls) {
        $old = @($baselineCases | Where-Object id -CEQ $control.id)[0]
        if (-not $control.passed -or -not $old.passed -or
            -not $control.definitionSha256 -or $control.definitionSha256 -cne $old.definitionSha256 -or
            $control.httpStatus -ne $old.httpStatus -or $control.runStatus -cne $old.runStatus) {
            throw "Control '$($control.id)' regressed or changed its workflow definition."
        }
        if ($control.runStatus -ceq 'Succeeded' -and
            ($control.httpBody -cne $old.httpBody -or
             @($control.actions | Where-Object status -CNE 'Succeeded').Count)) {
            throw "Supported response '$($control.id)' changed its value or action outcomes."
        }
        if ($control.runStatus -ceq 'Failed' -and
            ($control.httpBody | ConvertFrom-Json).error.code -cne
            ($old.httpBody | ConvertFrom-Json).error.code) {
            throw "Unrelated failure '$($control.id)' changed its caller error code."
        }
    }
    if (-not @($controls | Where-Object runStatus -CEQ 'Succeeded').Count) {
        throw 'A successful supported-response control is required.'
    }
    [pscustomobject]@{
        diagnosticContractPassed = $true
        caseId = 'NativeUri'
        workflowStillFails = $true
        uriNormalizationVerified = $false
        callerHttpStatus = $actual.httpStatus
        errorCode = $Code
        errorMessage = $Message
        unchangedControls = $controls.Count
        definitionSha256 = $actual.definitionSha256
    }
}

if ($SelfTest) {
    $code = 'InvalidResponseBody'
    $message = 'The response body has an unsupported value type.'
    $baseline = @{
        results = @(
            @{
                id = 'NativeUri'; definitionSha256 = 'same-uri-definition'
                actions = @(
                    @{ name = 'Source'; outputs = @{ present = $true; raw = '"https://example.com/api"' } },
                    @{ name = 'Result'; outputs = @{ present = $true; raw = '"https://example.com/api"' } },
                    @{ name = 'Response'; error = @{ code = 'InternalServerError' } }
                )
            },
            @{
                id = 'Uppercase'; definitionSha256 = 'same-control-definition'; passed = $true
                httpStatus = 200; runStatus = 'Succeeded'; httpBody = 'HELLO'
                actions = @(@{ name = 'Response'; status = 'Succeeded' })
            }
        )
    } | ConvertTo-Json -Depth 10 | ConvertFrom-Json
    $valid = $baseline | ConvertTo-Json -Depth 10 | ConvertFrom-Json -AsHashtable
    $uri = $valid.results[0]
    $uri.httpStatus = 502
    $uri.runStatus = 'Failed'
    $uri.outcome = 'RuntimeFailed'
    $uri.httpBody = @{ error = @{ code = $code; message = $message } } | ConvertTo-Json -Compress
    $uri.actions[0].status = 'Succeeded'
    $uri.actions[1].status = 'Succeeded'
    $uri.actions[2] = @{ name = 'Response'; status = 'Failed'; code = 'BadRequest'; error = @{ code = $code; message = $message } }
    $validJson = $valid | ConvertTo-Json -Depth 10
    $null = Assert-ResponseDiagnostics ($validJson | ConvertFrom-Json) $baseline $code $message 502
    $mutations = @(
        { param($r) $r.results[0].httpBody = '{"error":{"code":"NoResponse","message":"Generic"}}' },
        { param($r) $r.results[0].actions[2].error.code = 'InternalServerError' },
        { param($r) $r.results[0].actions[2].code = 'InternalServerError' },
        { param($r) $r.results[0].actions[2].error.message = 'Secret response body contents' },
        { param($r) $r.results[0].definitionSha256 = 'changed' },
        { param($r) $r.results[0].runStatus = 'Succeeded' },
        { param($r) $r.results[0].httpStatus = 200 },
        { param($r) $r.results[0].actions[1].status = 'Failed' },
        { param($r) $r.results[0].actions[1].outputs.raw = '"changed"' },
        { param($r) $r.results[1].passed = $false },
        { param($r) $r.results[1].httpBody = 'changed' },
        { param($r) $r.results[0].httpBody = '{"error":{"code":"InvalidResponseBody","message":"The response body has an unsupported value type.","stackTrace":"private"}}' },
        { param($r) $r.results += $r.results[0] },
        { param($r) $r.results = @($r.results[0]) }
    )
    foreach ($mutation in $mutations) {
        $candidate = $validJson | ConvertFrom-Json -AsHashtable
        & $mutation $candidate
        $rejected = $false
        try {
            $null = Assert-ResponseDiagnostics ($candidate | ConvertTo-Json -Depth 10 | ConvertFrom-Json) $baseline $code $message 502
        } catch {
            $rejected = $true
        }
        if (-not $rejected) { throw "Invalid diagnostic evidence accepted: $mutation" }
    }
    Write-Output "Response diagnostic verifier: $($mutations.Count + 1) self-tests passed."
} else {
    Assert-ResponseDiagnostics `
        (Get-Content -LiteralPath $ResultsPath -Raw | ConvertFrom-Json) `
        (Get-Content -LiteralPath $BaselineResultsPath -Raw | ConvertFrom-Json) `
        $ExpectedErrorCode $ExpectedErrorMessage $ExpectedHttpStatus
}
