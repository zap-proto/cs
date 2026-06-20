$myDir = Split-Path -Parent $MyInvocation.MyCommand.Path
dotnet "$myDir\..\bin\zapc-csharp.dll"
