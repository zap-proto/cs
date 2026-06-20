$ErrorActionPreference = 'Stop'

$binDir   = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)\..\bin"

Install-Binfile -Name zapc-csharp -Path "$binDir\zapc-csharp.exe"
