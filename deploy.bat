@echo off
if %1.==. goto usage
call .\config.bat
@echo Create temp folder...
rmdir %TEMP%\UnityModTemplatesTemp /S /Q
mkdir %TEMP%\UnityModTemplatesTemp
@echo Unzipping to temp...
%zip% x %1 -o%TEMP%\UnityModTemplatesTemp >NUL
@echo Copying templates to VS docs folder...
xcopy %TEMP%\UnityModTemplatesTemp\Templates "%vsdocs%\Templates" /E /Y >NUL
@echo Delete temp folder
rem rmdir %TEMP%\UnityModTemplatesTemp /S /Q
@echo Refresh Visual Studio template cache...
"%DevEnvDir%\devenv" /installvstemplates
"%DevEnvDir%\devenv" /updateconfiguration
@echo Done!
goto done
:usage
@echo No ZIP file provided to deploy.
:done
