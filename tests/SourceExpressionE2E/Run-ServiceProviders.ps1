param(
    [Parameter(Mandatory)][string]$FuncPath,
    [Parameter(Mandatory)][string]$AzuritePath,
    [Parameter(Mandatory)][string]$HostDirectory,
    [Parameter(Mandatory)][string]$WorkerDirectory,
    [Parameter(Mandatory)][string]$ResultsDirectory,
    [ValidateRange(1024,65535)][int]$Port = 18571,
    [ValidateRange(1024,65535)][int]$BlobPort = 18581,
    [ValidateRange(1024,65535)][int]$QueuePort = 18582,
    [ValidateRange(1024,65535)][int]$TablePort = 18583,
    [string[]]$AdditionalCaseIds,
    [switch]$RecordOnly
)
$ErrorActionPreference = 'Stop'
$hostRoot = (Resolve-Path -LiteralPath $HostDirectory).Path
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$resultsRoot = [IO.Path]::GetFullPath($ResultsDirectory)
foreach ($path in @($hostRoot, $resultsRoot)) {
    if ($path.Equals($repoRoot, [StringComparison]::OrdinalIgnoreCase) -or
        $path.StartsWith($repoRoot + '\', [StringComparison]::OrdinalIgnoreCase)) {
        throw 'Host and run data must be outside the repository.'
    }
}
if (Test-Path -LiteralPath $resultsRoot) { throw 'Choose a new, nonexistent ResultsDirectory.' }
$ports = @($Port, $BlobPort, $QueuePort, $TablePort)
if (@($ports | Select-Object -Unique).Count -ne 4) { throw 'Host and storage ports must be distinct.' }
if (@(Get-NetTCPConnection -State Listen | Where-Object LocalPort -In $ports).Count) {
    throw 'A requested port is occupied; existing processes will not be stopped.'
}
foreach ($file in @($FuncPath, $AzuritePath, (Join-Path $WorkerDirectory 'SourceExpressionE2E.dll'))) {
    if (-not (Test-Path -LiteralPath $file -PathType Leaf)) { throw "Required tool/worker missing: $file" }
}
$settingsPath = Join-Path $hostRoot 'local.settings.json'
$connectionsPath = Join-Path $hostRoot 'connections.json'
$originalSettings = [IO.File]::ReadAllBytes($settingsPath)
$hadConnections = Test-Path -LiteralPath $connectionsPath
$originalConnections = if ($hadConnections) { [IO.File]::ReadAllBytes($connectionsPath) } else { $null }
$settings = Get-Content -Raw -LiteralPath $settingsPath | ConvertFrom-Json -AsHashtable
$storage = [System.Data.Common.DbConnectionStringBuilder]::new()
$storage.set_ConnectionString($settings.Values.AzureWebJobsStorage)
if ($storage['AccountName'] -cne 'devstoreaccount1' -or -not $storage.ContainsKey('AccountKey')) {
    throw 'The prepared host must use the Azurite development storage account.'
}
$key = [Convert]::FromBase64String($storage['AccountKey'])
$storage['DefaultEndpointsProtocol'] = 'http'
$storage['BlobEndpoint'] = "http://127.0.0.1:$BlobPort/devstoreaccount1"
$storage['QueueEndpoint'] = "http://127.0.0.1:$QueuePort/devstoreaccount1"
$storage['TableEndpoint'] = "http://127.0.0.1:$TablePort/devstoreaccount1"
$settings.Values.AzureWebJobsStorage = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;" +
    "AccountKey=$($storage['AccountKey']);BlobEndpoint=$($storage['BlobEndpoint']);" +
    "QueueEndpoint=$($storage['QueueEndpoint']);TableEndpoint=$($storage['TableEndpoint']);"
$prefix = 'sdke2e-' + [Guid]::NewGuid().ToString('N').Substring(0,12)
$cases = @('ServiceProviderBlobLiteral','ServiceProviderBlobTemplate','ServiceProviderBlobNative',
    'ServiceProviderQueueLiteral','ServiceProviderQueueTemplate','ServiceProviderQueueNative')
$containers = @($cases | Where-Object { $_ -like 'ServiceProviderBlob*' } |
    ForEach-Object { "$prefix-$($_.Substring('ServiceProvider'.Length).ToLowerInvariant())" })
$queues = @($cases | Where-Object { $_ -like 'ServiceProviderQueue*' } |
    ForEach-Object { "$prefix-$($_.Substring('ServiceProvider'.Length).ToLowerInvariant())" })

function Invoke-Storage([string]$Method, [int]$StoragePort, [string]$Resource, [bool]$Container) {
    if ($StoragePort -notin @($BlobPort,$QueuePort) -or $Resource -notin @($containers + $queues)) {
        throw 'Storage request is outside this run.'
    }
    $date = [DateTime]::UtcNow.ToString('R', [Globalization.CultureInfo]::InvariantCulture)
    $headers = @{ 'x-ms-date' = $date; 'x-ms-version' = '2021-12-02' }
    $canonical = "/devstoreaccount1/devstoreaccount1/$Resource"
    $uri = "http://127.0.0.1:$StoragePort/devstoreaccount1/$Resource"
    if ($Container) { $canonical += "`nrestype:container"; $uri += '?restype=container' }
    elseif ($Method -eq 'GET') { $canonical += "`ncomp:metadata"; $uri += '?comp=metadata' }
    $sign = $Method + ("`n" * 12) + "x-ms-date:$date`nx-ms-version:2021-12-02`n$canonical"
    $hmac = [Security.Cryptography.HMACSHA256]::new($key)
    try { $signature = [Convert]::ToBase64String($hmac.ComputeHash([Text.Encoding]::UTF8.GetBytes($sign))) }
    finally { $hmac.Dispose() }
    $headers.Authorization = "SharedKey devstoreaccount1:$signature"
    $reply = Invoke-WebRequest -Uri $uri -Method $Method -Headers $headers -SkipHttpErrorCheck -MaximumRedirection 0 -TimeoutSec 15
    $expected = switch ($Method) { 'PUT' { @(201) } 'GET' { @(200) } 'DELETE' { @(202,204,404) } }
    if ($reply.StatusCode -notin $expected) {
        throw "Local storage $Method $Resource failed with HTTP $($reply.StatusCode)."
    }
    if ($Method -eq 'GET') {
        $count = $reply.Headers['x-ms-approximate-messages-count']
        if ($null -eq $count) { throw 'Queue metadata did not contain a message count.' }
        return [int]($count | Select-Object -First 1)
    }
    return [int]$reply.StatusCode
}

$emulator = $null
$ready = $false
$cleanup = [Collections.Generic.List[object]]::new()
$cleanupErrors = [Collections.Generic.List[string]]::new()
$oldAccounts = $env:AZURITE_ACCOUNTS
New-Item -ItemType Directory -Path $resultsRoot | Out-Null
try {
    # Never inherit credentials for nondevelopment accounts into the isolated emulator.
    $env:AZURITE_ACCOUNTS = "devstoreaccount1:$($storage['AccountKey'])"
    $emulator = Start-Process -FilePath (Get-Command node -ErrorAction Stop).Source -ArgumentList @(
        "`"$((Resolve-Path -LiteralPath $AzuritePath).Path)`"", '--silent', '--location', "`"$(Join-Path $resultsRoot 'azurite')`"",
        '--blobHost','127.0.0.1','--blobPort',"$BlobPort",
        '--queueHost','127.0.0.1','--queuePort',"$QueuePort",
        '--tableHost','127.0.0.1','--tablePort',"$TablePort"
    ) -RedirectStandardOutput (Join-Path $resultsRoot 'azurite.log') `
      -RedirectStandardError (Join-Path $resultsRoot 'azurite.stderr.log') -PassThru
    for ($attempt = 0; $attempt -lt 30; $attempt++) {
        if ($emulator.HasExited) { throw 'Azurite exited before becoming ready; inspect azurite.stderr.log.' }
        $listeners = @(Get-NetTCPConnection -State Listen | Where-Object {
            $_.LocalPort -in @($BlobPort,$QueuePort,$TablePort) -and $_.OwningProcess -eq $emulator.Id
        })
        if ($listeners.Count -eq 3) { $ready = $true; break }
        Start-Sleep -Seconds 1
    }
    if (-not $ready) { throw 'Owned Azurite endpoints did not become ready.' }
    foreach ($container in $containers) { Invoke-Storage 'PUT' $BlobPort $container $true | Out-Null }
    $connections = @{ serviceProviderConnections = @{} }
    foreach ($entry in @(@('e2eAzureBlob','/serviceProviders/AzureBlob'), @('e2eAzureQueues','/serviceProviders/azurequeues'))) {
        $connections.serviceProviderConnections[$entry[0]] = @{
            displayName = $entry[0]
            serviceProvider = @{ id = $entry[1] }
            parameterValues = @{ connectionString = "@appsetting('AzureWebJobsStorage')" }
        }
    }
    $settings | ConvertTo-Json -Depth 20 | Set-Content -LiteralPath $settingsPath
    $connections | ConvertTo-Json -Depth 10 | Set-Content -LiteralPath $connectionsPath
    & (Join-Path $PSScriptRoot 'Run-Local.ps1') -FuncPath $FuncPath -HostDirectory $hostRoot `
        -WorkerDirectory $WorkerDirectory -ResultsDirectory $resultsRoot -Port $Port `
        -CaseIds @($cases + $AdditionalCaseIds | Select-Object -Unique) -ServiceProviderPrefix $prefix -RecordOnly:$RecordOnly
    $queueCounts = @($queues | ForEach-Object {
        @{ resource = $_; messageCount = (Invoke-Storage 'GET' $QueuePort $_ $false) }
    })
    $queueCounts | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath (Join-Path $resultsRoot 'queue-counts.json')
    if (@($queueCounts | Where-Object messageCount -NE 0).Count) {
        throw 'Provider queue messages remain, including invisible messages; inspect queue-counts.json.'
    }
} finally {
    try {
        if ($ready -and $emulator -and -not $emulator.HasExited) {
            foreach ($resource in @($containers + $queues)) {
                $isContainer = $resource -in $containers
                $storagePort = if ($isContainer) { $BlobPort } else { $QueuePort }
                try {
                    $cleanup.Add(@{ resource = $resource; status = (Invoke-Storage 'DELETE' $storagePort $resource $isContainer) })
                } catch {
                    $cleanupErrors.Add($_.Exception.Message)
                    $cleanup.Add(@{ resource = $resource; error = $_.Exception.Message })
                }
            }
        }
    } finally {
        if ($emulator -and -not $emulator.HasExited) { Stop-Process -Id $emulator.Id -Force }
        [IO.File]::WriteAllBytes($settingsPath, $originalSettings)
        if ($hadConnections) { [IO.File]::WriteAllBytes($connectionsPath, [byte[]]$originalConnections) }
        elseif (Test-Path -LiteralPath $connectionsPath) { Remove-Item -LiteralPath $connectionsPath }
        $env:AZURITE_ACCOUNTS = $oldAccounts
        @{ prefix = $prefix; resources = @($cleanup.ToArray()) } |
            ConvertTo-Json -Depth 5 | Set-Content -LiteralPath (Join-Path $resultsRoot 'resource-cleanup.json')
    }
    if ($cleanupErrors.Count) { throw ($cleanupErrors -join [Environment]::NewLine) }
}
