@echo off
cd "%~dp0\..\ZapC.CSharp.Generator.Tests\No Resources"
for /f %%f in ('dir /b "*.zap"') do zap compile -o- %%f -I"..\..\include" > "..\Embedded Resources\%%f.bin"