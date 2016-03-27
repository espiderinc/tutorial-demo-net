@echo off
SET DIR=%~d0%~p0%

SET sql.files.directory="%DIR%"
SET version.file="%DIR%_BuildInfo.xml"
SET connstring="data source=TUTORIAL\TUTORIAL;initial catalog=Northwind;integrated security=True"
SET repository.path="https://github.com/espiderinc/tutorial-demo-net.git"
 
"%DIR%..\..\packages\roundhouse.0.8.6\bin\rh.exe" /f=%sql.files.directory% /c=%connstring% /vf=%version.file% /r=%repository.path% /env=LOCAL /ni /drop
"%DIR%..\..\packages\roundhouse.0.8.6\bin\rh.exe" /f=%sql.files.directory% /c=%connstring% /vf=%version.file% /r=%repository.path% /env=LOCAL /ni /simple