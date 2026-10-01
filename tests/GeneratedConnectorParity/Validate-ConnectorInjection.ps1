param([Parameter(Mandatory)][string]$OutputDirectory)
$ErrorActionPreference = 'Stop'
$PSNativeCommandUseErrorActionPreference = $false
$repository = (Resolve-Path (Join-Path $PSScriptRoot '..\..')).Path
$root = [IO.Path]::GetFullPath($OutputDirectory)
if (Test-Path -LiteralPath $root) { throw 'Use a new output directory for build-injection evidence.' }
New-Item -ItemType Directory -Path $root | Out-Null
$fixture = Join-Path $root 'fixture with spaces'
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'InjectionFixture') -Destination $fixture -Recurse
$project = Join-Path $fixture 'InjectionFixture.csproj'
$artifacts = Join-Path $root 'artifacts'
$properties = @("-p:InjectionRepositoryRoot=$repository\", "-p:ArtifactsPath=$artifacts")
$steps = [Collections.Generic.List[object]]::new()
function Run([string]$Name, [string[]]$Arguments, [bool]$ShouldFail = $false) {
    $log = Join-Path $root "$Name.log"
    & dotnet @Arguments *> $log
    $exit = $LASTEXITCODE
    $steps.Add(@{ name=$Name; exitCode=$exit; expectedFailure=$ShouldFail })
    if (($exit -eq 0) -eq $ShouldFail) { throw "Unexpected exit $exit for $Name. See $log." }
}
function Build([string]$Name) {
    Run $Name (@('build',$project,'--no-restore','-v:quiet') + $properties)
}
$generated = Join-Path $artifacts 'obj\InjectionFixture\debug\connector-validation'
$assembly = Join-Path $artifacts 'bin\InjectionFixture\debug\InjectionFixture.dll'
$source = Join-Path $fixture 'generated\managed\Fixture.cs'
$original = [IO.File]::ReadAllText($source)
Run 'restore' (@('restore',$project,'-v:quiet') + $properties)
Build 'clean-build'
Run 'reflection-caller' @($assembly)
$hash = (Get-FileHash $assembly).Hash
$time = (Get-Item $assembly).LastWriteTimeUtc
Build 'no-op-build'
if ((Get-FileHash $assembly).Hash -ne $hash -or (Get-Item $assembly).LastWriteTimeUtc -ne $time) {
    throw 'No-op build unnecessarily changed the fixture assembly.'
}
if ([IO.File]::ReadAllText($source) -cne $original) { throw 'Injection modified checked-in-style fixture source.' }
$injected = Get-Content (Join-Path $generated 'compiled-files.txt') | Where-Object { $_ -like '*_Fixture.cs' }
if (@($injected).Count -ne 1) { throw 'Fixture was not substituted exactly once.' }
Remove-Item -LiteralPath $injected
Build 'missing-output-repair'
if (!(Test-Path -LiteralPath $injected)) { throw 'Missing output was not recreated.' }

[IO.File]::WriteAllText($source, $original.Replace('Func<string> value)', 'Func<string> value = null)'))
Build 'changed-requiredness'
if ((Get-FileHash $assembly).Hash -eq $hash -or
    !([IO.File]::ReadAllText($injected).Contains('nameof(value), required: false'))) {
    throw 'Signature change did not invalidate injected output and compilation.'
}
[IO.File]::WriteAllText($source, $original)
$renamed = Join-Path $fixture 'generated\managed\Renamed.cs'
Move-Item -LiteralPath $source -Destination $renamed
Build 'source-rename'
if ((Get-Content (Join-Path $generated 'compiled-files.txt')) -contains $injected) {
    throw 'Renamed source retained its old compile input.'
}
$added = Join-Path $fixture 'generated\managed\Added.cs'
[IO.File]::WriteAllText($added, $original.Replace('FixtureActions','AddedActions').Replace('FixtureTriggers','AddedTriggers'))
Build 'source-add'
$summary = Get-Content (Join-Path $generated 'validation-summary.json') -Raw | ConvertFrom-Json
if ($summary.validationCount -ne 6) { throw 'Added connector was not injected.' }
Remove-Item -LiteralPath $added
Build 'source-delete'
$summary = Get-Content (Join-Path $generated 'validation-summary.json') -Raw | ConvertFrom-Json
if ($summary.validationCount -ne 3) { throw 'Deleted connector remains in the build.' }
Run 'reflection-after-edits' @($assembly)

[IO.File]::WriteAllText($renamed, $original.Replace('return "unchanged body";','return MissingName;'))
Run 'failed-analysis' (@('build',$project,'--no-restore','-v:quiet') + $properties) $true
if (Test-Path (Join-Path $generated 'compiled-files.txt')) { throw 'Failed analysis left a success-shaped input manifest.' }
[IO.File]::WriteAllText($renamed, $original)
Build 'recovery'
Run 'verify-pack-receipt' (@('msbuild',$project,'-t:VerifyConnectorValidationAssembly','-v:quiet') + $properties)
[IO.File]::AppendAllText((Join-Path $generated 'assembly.sha256'), 'invalid')
Run 'reject-stale-pack-receipt' (@('msbuild',$project,'-t:VerifyConnectorValidationAssembly','-v:quiet') + $properties) $true
if ((Get-Content (Join-Path $root 'reject-stale-pack-receipt.log') -Raw) -notmatch 'WFSDK1102') {
    throw 'Stale package validation failed without the required diagnostic.'
}
Build 'repair-pack-receipt'
Run 'release-build' (@('build',$project,'--no-restore','-c:Release','-v:quiet') + $properties)
if (!(Test-Path (Join-Path $artifacts 'obj\InjectionFixture\release\connector-validation\assembly.sha256'))) {
    throw 'Release did not write isolated validation output.'
}
Run 'design-time' (@('msbuild',$project,'-t:CoreCompile','-p:DesignTimeBuild=true','-p:SkipCompilerExecution=true','-v:minimal') + $properties)
if ((Get-Content (Join-Path $root 'design-time.log') -Raw) -notmatch 'WFSDK1104') {
    throw 'Design-time injection deferral was not explicit.'
}
Run 'missing-tool' (@('build',$project,'--no-restore','-c:MissingTool','-p:BuildProjectReferences=false','-v:quiet') + $properties) $true
if ((Get-Content (Join-Path $root 'missing-tool.log') -Raw) -notmatch 'WFSDK1101') {
    throw 'Missing tool failed without the required diagnostic.'
}
Run 'clean' (@('clean',$project,'-v:quiet') + $properties)
if (Test-Path (Join-Path $generated 'compiled-files.txt')) { throw 'Clean left owned compiler inputs behind.' }
Run 'rebuild' (@('build',$project,'--no-restore','-t:Rebuild','-v:quiet') + $properties)
Run 'reflection-after-rebuild' @($assembly)
Run 'direct-compile' (@('msbuild',$project,'-t:CoreCompile','-v:quiet') + $properties)
$inputs = @(Get-Content (Join-Path $generated 'compiled-files.txt'))
if (@($inputs | Where-Object { $_ -like '*_Renamed.cs' }).Count -ne 1) {
    throw 'Direct CoreCompile bypassed injection.'
}
$steps | ConvertTo-Json -Depth 4 | Set-Content (Join-Path $root 'results.json')
Write-Host "Connector build injection: $($steps.Count) checks passed."
