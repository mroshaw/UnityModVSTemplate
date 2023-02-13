@echo off
rem
rem Do NOT include double quotes or trailing slash in paths
rem e.g. good example:
rem set vsdocs=C:\Users\myuser\OneDrive\Documents\Visual Studio 2022
rem
set zip=
set vsdocs=
set vsbin=
rem
if "%zip%"=="" goto configerror
if "%vsdocs%"=="" goto configerror
if "%vsbin%"=="" goto configerror
@echo Expecting 7-Zip at: "%zip%"
@echo Expecting Visual Studio Documents folder at: "%vsdocs%"
@echo Expecting Visual Studio Bin folder at: "%vsbin%"
set configstatus=OK
goto configdone
:configerror
@echo Please check config.bat and set configuration parameters
set configstatus=ERR
:configdone
