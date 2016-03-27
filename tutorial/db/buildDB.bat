@echo off
SET DIR=%~d0%~p0%

SET connstring="data source=TUTORIAL\TUTORIAL;initial catalog=Northwind;integrated security=True"
SET repository.path="https://github.com/Spider-Tutorials/TeamCity_DotNet.git"
 
"%DIR%..\..\packages\roundhouse.0.8.6\bin\rh.exe" /c=%connstring% /r=%repository.path% /env=LOCAL /ni /drop
"%DIR%..\..\packages\roundhouse.0.8.6\bin\rh.exe" /c=%connstring% /r=%repository.path% /env=LOCAL /ni /simple