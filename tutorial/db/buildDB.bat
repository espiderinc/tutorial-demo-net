@echo off
SET DIR=%~d0%~p0%

SET connstring="data source=TUTORIAL\TUTORIAL;initial catalog=Northwind;integrated security=True"
SET repository.path="https://github.com/espiderinc/tutorial-demo-net.git"
 
"%DIR%..\..\packages\roundhouse.0.8.6\bin\rh.exe" /c=%connstring% /vf=../bin/tutorial.dll /r=%repository.path% /env=LOCAL /ni /simple