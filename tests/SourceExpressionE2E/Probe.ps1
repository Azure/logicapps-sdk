param(
    [Parameter(Mandatory)][string]$BaseUri,
    [Parameter(Mandatory)][string]$HostDirectory,
    [Parameter(Mandatory)][string]$DefinitionsDirectory,
    [Parameter(Mandatory)][string]$OutputPath,
    [string]$HostLogPath,
    [string[]]$CaseIds,
    [switch]$IncludeServiceProviders,
    [switch]$RecordOnly
)
$ErrorActionPreference = 'Stop'
$base = $BaseUri.TrimEnd('/')
$origin = [Uri]$base
if (-not $origin.IsLoopback -or $origin.Scheme -ne 'http') {
    throw 'Only an isolated loopback HTTP host is allowed.'
}
$allowedContentPorts = @($origin.Port)
$hostSettings = Get-Content -Raw (Join-Path $HostDirectory 'local.settings.json') | ConvertFrom-Json
foreach ($endpoint in [regex]::Matches($hostSettings.Values.AzureWebJobsStorage, '(?i)(?:Blob|Queue|Table)Endpoint=([^;]+)')) {
    $storageUri = [Uri]$endpoint.Groups[1].Value
    if (-not $storageUri.IsLoopback -or $storageUri.Scheme -ne 'http') {
        throw 'Only loopback storage content is allowed.'
    }
    $allowedContentPorts += $storageUri.Port
}
$status = $null
for ($attempt = 0; $attempt -lt 60; $attempt++) {
    try {
        $candidate = Invoke-RestMethod "$base/admin/host/status" -TimeoutSec 3
        if ($candidate.state -eq 'Running') { $status = $candidate; break }
    } catch [System.Net.Http.HttpRequestException] {
        if ($attempt -eq 59) { throw }
    }
    Start-Sleep -Seconds 2
}
if (-not $status) { throw 'Host did not become Running.' }
if ($HostLogPath) {
    for ($attempt = 0; $attempt -lt 60; $attempt++) {
        if (Select-String -LiteralPath $HostLogPath -Pattern 'Host lock lease acquired' -Quiet) { break }
        Start-Sleep -Seconds 1
    }
    if ($attempt -eq 60) { throw 'Host did not acquire its startup lock.' }
}
$listeners = @(Get-NetTCPConnection -State Listen -LocalPort $origin.Port)
if (-not $listeners.Count) { throw 'No local host listener exists.' }

function Get-CallbackUri([string]$name) {
    $path = "/runtime/webhooks/workflow/api/management/workflows/$name/triggers/manual/listCallbackUrl?api-version=2018-11-01"
    $reply = Invoke-WebRequest -Method Post ($base + $path) -SkipHttpErrorCheck -TimeoutSec 30
    if ($reply.StatusCode -ne 200) {
        return @{ status = [int]$reply.StatusCode; error = $reply.Content }
    }
    $uri = [Uri](($reply.Content | ConvertFrom-Json).value)
    if (-not $uri.IsLoopback -or $uri.Port -ne $origin.Port -or $uri.Scheme -ne 'http') {
        throw 'Callback URI is outside the isolated host.'
    }
    return @{ status = 200; uri = $uri }
}

function Read-Content($link) {
    if (-not $link.uri) { return @{ present = $false } }
    $uri = [Uri]$link.uri
    if (-not $uri.IsLoopback -or $uri.Scheme -ne 'http' -or $uri.Port -notin $allowedContentPorts) {
        throw 'Run content is not served by a local service.'
    }
    $reply = Invoke-WebRequest $uri -SkipHttpErrorCheck -TimeoutSec 30
    if ($reply.StatusCode -eq 204) { return @{ present = $true; raw = $null; statusCode = 204; size = $link.contentSize } }
    if ($reply.StatusCode -ne 200) { throw "History content returned HTTP $($reply.StatusCode)." }
    $raw = if ($reply.Content -is [byte[]]) {
        [Text.Encoding]::UTF8.GetString($reply.Content)
    } else { [string]$reply.Content }
    return @{ present = $true; raw = $raw; size = $link.contentSize }
}

function Save-Results {
    $assemblies = foreach ($relative in @(
        'bin\Microsoft.Azure.Workflows.Templates.dll',
        'bin\Microsoft.Azure.Workflows.Templates.Languages.Edge.CSharp.dll',
        'lib\codeful\Microsoft.Azure.Workflows.Sdk.dll',
        'lib\codeful\SourceExpressionE2E.dll'
    )) {
        $file = Join-Path $HostDirectory $relative
        if (-not (Test-Path -LiteralPath $file)) { throw "Required host evidence missing: $relative" }
        @{
            path = $relative
            sha256 = (Get-FileHash -LiteralPath $file).Hash
            version = [Diagnostics.FileVersionInfo]::GetVersionInfo($file).FileVersion
        }
    }
    [ordered]@{
        evidenceKind = 'actual-local-codeful-workflow-regression'
        completedUtc = [DateTimeOffset]::UtcNow.ToString('o')
        runtimeVersion = $status.version
        assemblies = @($assemblies)
        results = @($results.ToArray())
        limitations = @('Local host only; not cloud/designer certification.', 'Failures are recorded, never treated as successful runtime execution.')
    } | ConvertTo-Json -Depth 30 | Set-Content -LiteralPath $OutputPath -Encoding utf8
}

$ready = Get-CallbackUri 'E2EReady'
if ($ready.status -ne 200) { throw "Readiness workflow was not registered: $($ready.error)" }
$warmup = Invoke-WebRequest -Method Post $ready.uri -ContentType application/json -Body '{}' -SkipHttpErrorCheck -TimeoutSec 60
if ($warmup.StatusCode -ne 200 -or $warmup.Content -cne 'ready') {
    throw 'Real readiness workflow failed; do not interpret this host as a valid comparison environment.'
}
$allCases = @(Get-Content -Raw (Join-Path $DefinitionsDirectory 'generation-results.json') | ConvertFrom-Json)
if (-not $IncludeServiceProviders) {
    $allCases = @($allCases | Where-Object { $_.case.id -notlike 'ServiceProvider*' })
}
$cases = if ($CaseIds) { @($allCases | Where-Object { $_.case.id -in $CaseIds }) } else { $allCases }
if (-not $cases.Count) { throw 'No cases selected.' }
if ($CaseIds -and @($CaseIds | Where-Object { $_ -notin $cases.case.id }).Count) {
    throw 'A requested case ID was not exported.'
}
$results = [System.Collections.Generic.List[object]]::new()
foreach ($entry in $cases) {
    $case = $entry.case
    $observation = [ordered]@{
        id = $case.id; failureIds = @($case.failureIds)
        expectedBody = $case.expectedResponseBody
        expectedHttpStatus = $case.expectedHttpStatus
        expectedRunStatus = $case.expectedRunStatus
        responseContract = $case.responseContract
        expectedActionError = $case.expectedActionError
        expectedFailedAction = $case.expectedFailedAction
        expectedActionErrorCode = $case.expectedActionErrorCode
        inputJson = $case.inputJson
        generationStatus = $entry.generationStatus
        generationError = $entry.error
        generationExpectationMet = $entry.generationExpectationMet
        outcome = $null; passed = $false
        httpStatus = $null; httpBody = $null; requestElapsedMs = $null
        invokedUtc = $null
        runId = $null; runStatus = $null; runStartTime = $null; runEndTime = $null
        actions = @()
    }
    if ($entry.generationStatus -ne 'Generated') {
        $observation.outcome = if ($entry.generationStatus -eq 'CompileRejected') { 'CompileRejected' } else { 'GenerationRejected' }
        $observation.passed = [bool]$entry.generationExpectationMet
    } else {
        $definitionPath = Join-Path $DefinitionsDirectory "$($case.id)\workflow.json"
        $observation.definitionSha256 = (Get-FileHash -LiteralPath $definitionPath).Hash
        $api = "$base/runtime/webhooks/workflow/api/management/workflows/$($case.id)"
        $runsUri = "${api}/runs?api-version=2018-11-01"
        $initial = Invoke-WebRequest $runsUri -SkipHttpErrorCheck -TimeoutSec 30
        if ($initial.StatusCode -ne 200) {
            $observation.outcome = 'RegistrationRejected'
            $observation.httpStatus = [int]$initial.StatusCode
            $observation.httpBody = $initial.Content
        } else {
            $previousIds = @(($initial.Content | ConvertFrom-Json).value.name)
            $callback = Get-CallbackUri $case.id
            if ($callback.status -ne 200) {
                $observation.outcome = 'CallbackRejected'
                $observation.httpStatus = $callback.status
                $observation.httpBody = $callback.error
            } else {
                $clock = [Diagnostics.Stopwatch]::StartNew()
                $observation.invokedUtc = [DateTimeOffset]::UtcNow.ToString('o')
                $reply = $null
                try {
                    $reply = Invoke-WebRequest -Method Post $callback.uri -ContentType application/json `
                        -Body $case.inputJson -SkipHttpErrorCheck -TimeoutSec 45
                    $observation.httpStatus = [int]$reply.StatusCode
                    $observation.httpBody = [string]$reply.Content
                } catch [System.Threading.Tasks.TaskCanceledException] {
                    $observation.outcome = 'RequestTimedOut'
                    Write-Warning "[$($case.id)] HTTP request timed out; inspecting persisted run history."
                } finally {
                    $clock.Stop()
                    $observation.requestElapsedMs = $clock.Elapsed.TotalMilliseconds
                }
                $run = $null
                for ($attempt = 0; $attempt -lt 20; $attempt++) {
                    $newRuns = @((Invoke-RestMethod $runsUri -TimeoutSec 30).value | Where-Object name -NotIn $previousIds)
                    if ($newRuns.Count -gt 1) { throw "Concurrent runs make case $($case.id) ambiguous." }
                    if ($newRuns.Count -eq 1) {
                        $run = $newRuns[0]
                        if ($run.properties.status -notin @('Running','Waiting')) { break }
                    }
                    if ($reply -and $reply.StatusCode -ge 400 -and -not $newRuns.Count) { break }
                    Start-Sleep -Milliseconds 500
                }
                if ($run) {
                    $observation.runId = $run.name
                    $observation.runStatus = $run.properties.status
                    $observation.runStartTime = $run.properties.startTime
                    $observation.runEndTime = $run.properties.endTime
                    $actions = @((Invoke-RestMethod "${api}/runs/$($run.name)/actions?api-version=2018-11-01").value)
                    $observation.actions = @($actions | ForEach-Object {
                        @{
                            name = $_.name; status = $_.properties.status
                            code = $_.properties.code; error = $_.properties.error
                            startTime = $_.properties.startTime; endTime = $_.properties.endTime
                            inputs = Read-Content $_.properties.inputsLink
                            outputs = Read-Content $_.properties.outputsLink
                        }
                    })
                    $observation.outcome = if ($run.properties.status -eq 'Succeeded') { 'RuntimeSucceeded' } else { 'RuntimeFailed' }
                } elseif (-not $observation.outcome) {
                    $observation.outcome = 'RejectedBeforeRun'
                }
                $observation.passed = [bool]$entry.generationExpectationMet `
                    -and $observation.httpStatus -eq $case.expectedHttpStatus `
                    -and $observation.runStatus -eq $case.expectedRunStatus `
                    -and $observation.httpBody -ceq $case.expectedResponseBody
                if ($observation.passed -and $case.expectedRunStatus -eq 'Succeeded') {
                    $observation.passed = @($observation.actions | Where-Object status -NE Succeeded).Count -eq 0
                }
            }
        }
    }
    $results.Add($observation)
    Save-Results
    Write-Output "$($case.id): $($observation.outcome), HTTP $($observation.httpStatus)"
}
& dotnet (Join-Path $HostDirectory 'lib\codeful\SourceExpressionE2E.dll') --validate-results $OutputPath
$validationExit = $LASTEXITCODE
if ($validationExit -notin @(0,1)) { throw "Result validator failed unexpectedly with exit $validationExit." }
if ($validationExit -ne 0 -and -not $RecordOnly) {
    throw "Workflow regression expectations failed; complete evidence is in $OutputPath."
}
