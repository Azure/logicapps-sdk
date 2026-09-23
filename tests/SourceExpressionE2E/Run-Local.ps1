param(
    [Parameter(Mandatory)][string]$FuncPath,
    [Parameter(Mandatory)][string]$HostDirectory,
    [Parameter(Mandatory)][string]$WorkerDirectory,
    [Parameter(Mandatory)][string]$ResultsDirectory,
    [int]$Port = 18571,
    [string[]]$CaseIds,
    [string]$CompileRejectionsPath,
    [switch]$RecordOnly
)
$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostDirectory).Path
$workerRoot = (Resolve-Path -LiteralPath $WorkerDirectory).Path
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
if ($hostRoot.Equals($repoRoot, [StringComparison]::OrdinalIgnoreCase) -or
    $hostRoot.StartsWith($repoRoot + [IO.Path]::DirectorySeparatorChar, [StringComparison]::OrdinalIgnoreCase)) {
    throw 'Private runtime hosts must be outside the repository.'
}
if (@(Get-NetTCPConnection -State Listen | Where-Object LocalPort -eq $Port).Count) {
    throw "Port $Port is occupied; no existing process will be stopped."
}
if (-not (Test-Path -LiteralPath (Join-Path $workerRoot 'SourceExpressionE2E.dll'))) {
    throw 'WorkerDirectory must contain the built SourceExpressionE2E worker.'
}
$settingsPath = Join-Path $hostRoot 'local.settings.json'
$originalSettings = Get-Content -Raw -LiteralPath $settingsPath
$settings = $originalSettings | ConvertFrom-Json -AsHashtable
$connection = $settings.Values.AzureWebJobsStorage
if ($connection -notmatch '(?:^|;)AccountName=devstoreaccount1(?:;|$)') {
    throw 'Only the local Azurite development storage account is allowed.'
}
foreach ($service in @('Blob','Queue','Table')) {
    $match = [regex]::Match($connection, "$($service)Endpoint=([^;]+)")
    if (-not $match.Success -or -not ([Uri]$match.Groups[1].Value).IsLoopback) {
        throw "Storage $service endpoint is not an explicit loopback address."
    }
}
$resultsRoot = [IO.Path]::GetFullPath($ResultsDirectory)
New-Item -ItemType Directory -Path $resultsRoot -Force | Out-Null
$definitions = Join-Path $resultsRoot 'definitions'
New-Item -ItemType Directory -Path $definitions -Force | Out-Null
$deployedWorker = Join-Path $hostRoot 'lib\codeful'
New-Item -ItemType Directory -Path $deployedWorker -Force | Out-Null
Get-ChildItem -LiteralPath $workerRoot | Copy-Item -Destination $deployedWorker -Recurse -Force
$settings.Values.APP_KIND = 'workflowapp'
$settings.Values.WORKFLOW_CODEFUL_ENABLED = 'true'
$settings.Values.FUNCTIONS_WORKER_RUNTIME = 'dotnet'
$settings.Values.FUNCTIONS_INPROC_NET8_ENABLED = '1'
$settings.Values.AzureWebJobsSecretStorageType = 'Files'
$settings.Values.E2E_RESULTS_DIRECTORY = $definitions
if ($CompileRejectionsPath) {
    $settings.Values.E2E_COMPILE_REJECTIONS = (Resolve-Path -LiteralPath $CompileRejectionsPath).Path
} else {
    $settings.Values.Remove('E2E_COMPILE_REJECTIONS')
}
$log = Join-Path $resultsRoot 'host.log'
$errorLog = Join-Path $resultsRoot 'host.stderr.log'
if (Test-Path -LiteralPath $log) { throw 'Choose a new ResultsDirectory; previous host evidence must not be overwritten.' }
$sourceFingerprints = @(
    Get-ChildItem -LiteralPath $PSScriptRoot -Recurse -File |
        Where-Object { $_.FullName -notmatch '[\\/](?:obj|bin)[\\/]' -and $_.Extension -in @('.cs','.csproj','.json','.ps1','.txt') } |
        ForEach-Object {
            @{ path = [IO.Path]::GetRelativePath($PSScriptRoot, $_.FullName); sha256 = (Get-FileHash -LiteralPath $_.FullName).Hash }
        }
)
$sourceFingerprints | ConvertTo-Json -Depth 5 | Set-Content (Join-Path $resultsRoot 'source-fingerprints.json')
$process = $null
$oldTelemetry = $env:FUNCTIONS_CORE_TOOLS_TELEMETRY_OPTOUT
$oldApplicationRoot = $env:WORKFLOW_APPLICATION_ROOT_DIRECTORY
try {
    $settings | ConvertTo-Json -Depth 10 | Set-Content -LiteralPath $settingsPath
    $env:FUNCTIONS_CORE_TOOLS_TELEMETRY_OPTOUT = '1'
    $env:WORKFLOW_APPLICATION_ROOT_DIRECTORY = $hostRoot
    $process = Start-Process -FilePath $FuncPath `
        -ArgumentList @('host','start','--address','127.0.0.1','--port',"$Port",'--no-build') `
        -WorkingDirectory $hostRoot -RedirectStandardOutput $log -RedirectStandardError $errorLog -PassThru
    & (Join-Path $PSScriptRoot 'Probe.ps1') -BaseUri "http://127.0.0.1:$Port" `
        -HostDirectory $hostRoot -DefinitionsDirectory $definitions `
        -OutputPath (Join-Path $resultsRoot 'results.json') -HostLogPath $log `
        -CaseIds $CaseIds -RecordOnly:$RecordOnly
} finally {
    if ($process -and -not $process.HasExited) {
        $snapshot = @(Get-CimInstance Win32_Process | Select-Object ProcessId,ParentProcessId)
        $owned = [System.Collections.Generic.List[int]]::new()
        $owned.Add($process.Id)
        for ($index=0; $index -lt $owned.Count; $index++) {
            foreach ($child in @($snapshot | Where-Object ParentProcessId -EQ $owned[$index])) {
                $owned.Add([int]$child.ProcessId)
            }
        }
        $ownedIds = $owned.ToArray()
        [Array]::Reverse($ownedIds)
        foreach ($ownedId in $ownedIds) {
            Stop-Process -Id $ownedId -Force -ErrorAction SilentlyContinue
        }
    }
    $originalSettings | Set-Content -LiteralPath $settingsPath
    $env:FUNCTIONS_CORE_TOOLS_TELEMETRY_OPTOUT = $oldTelemetry
    $env:WORKFLOW_APPLICATION_ROOT_DIRECTORY = $oldApplicationRoot
}
