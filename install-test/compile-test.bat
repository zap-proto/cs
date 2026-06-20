@echo off
zap compile -ocsharp -I%cd% .\zap\schema.zap
if %ERRORLEVEL% neq 0 exit /b 1
if exist .\zap\schema.zap.cs (    
  del .\zap\schema.zap.cs
) else (
  exit /b 2
)
