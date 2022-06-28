@echo off
setlocal enableextensions enabledelayedexpansion
set index=1
set municipio=9
set ambiente=9
set modulo=9

for /f "tokens=*" %%s in (APPNotions\config.cs) do (
if !index!==3 set "modulo=%%s"
if !index!==3 goto salir
if !index!==2 set "ambiente=%%s"
if !index!==2 set "index=3"
if !index!==1 set "municipio=%%s"
if !index!==1 set "index=2"
)
:salir
set ruta=Recursos\%ambiente:~8,25%\%municipio:~11,25%\%modulo:~8,25%
echo RUTA="!ruta!"
pause