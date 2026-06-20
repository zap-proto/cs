$ErrorActionPreference = 'Stop'

$toolsDir   = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"

Install-ChocolateyPowershellCommand -PackageName 'zapc-csharp' -PsFileFullPath "$toolsDir\zapc-csharp.ps1"
