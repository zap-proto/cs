$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$rootDir = "$scriptDir\.."
$resultsDir = "$rootDir\TestResults"
$coverageFile = "$resultsDir\*\*.xml"
$testResultsDir = "$rootDir\TestResults"
$coverageReportDir = "$rootDir\coverage"
$generatorTests = "$rootDir\ZapC.CSharp.Generator.Tests\ZapC.CSharp.Generator.Tests.csproj"
$runtimeTests = "$rootDir\Zap.Net.Runtime.Tests\Zap.Net.Runtime.Tests.csproj"

If(test-path $testResultsDir) {
  Remove-Item -Recurse -Force $testResultsDir
}

If(!(test-path $coverageReportDir)) {
  New-Item -ItemType Directory -Force -Path $coverageReportDir
}

& dotnet test $generatorTests `
  --filter TestCategory=Coverage `
  --logger console `
  --configuration Release `
  --framework netcoreapp3.1 `
  --collect:"XPlat code coverage" `
  --results-directory $resultsDir `
  --settings "$rootDir\coverlet.runsettings"

& dotnet test $runtimeTests `
  --filter TestCategory=Coverage `
  --logger console `
  --configuration Release `
  --framework netcoreapp3.1 `
  --collect:"XPlat code coverage" `
  --results-directory $resultsDir `
  --settings "$rootDir\coverlet.runsettings"

  ReportGenerator.exe -reports:"$coverageFile" -targetdir:"$coverageReportDir" -reportTypes:"Html;lcov"
