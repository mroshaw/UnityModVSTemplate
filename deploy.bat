@echo off
if %1.==. goto deployusage
call .\config.bat
if %configstatus%==ERR goto deployerror
@echo Create temp folder...
rmdir %TEMP%\UnityModTemplatesTemp /S /Q
mkdir %TEMP%\UnityModTemplatesTemp
@echo Unzipping to temp...
"%zip%" x %1 -o%TEMP%\UnityModTemplatesTemp >NUL
@echo Copying templates to VS docs folder...
xcopy %TEMP%\UnityModTemplatesTemp\Templates "%vsdocs%\Templates" /E /Y >NUL
@echo Delete temp folder
rem rmdir %TEMP%\UnityModTemplatesTemp /S /Q
@echo Refresh Visual Studio template cache...
"%vsbin%\devenv.exe" /installvstemplates
"%vsbin%\devenv.exe" /updateconfiguration
@echo Done!
goto deploydone
:deployusage
@echo No ZIP file provided to deploy.
goto deploydone
:deployerror
Deploy failed. Check for errors above.
:deploydone
