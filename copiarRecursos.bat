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
copy !ruta!\AndroidManifest.xml APPNotions.Android\Properties\AndroidManifest.xml
copy !ruta!\AssemblyInfo.cs APPNotions.Android\Properties\AssemblyInfo.cs
copy !ruta!\Info.plist APPNotions.iOS\Info.plist

xcopy !ruta!\mipmap-anydpi-v26\*.* APPNotions.Android\Resources\mipmap-anydpi-v26\ /Y
xcopy !ruta!\mipmap-hdpi\*.* APPNotions.Android\Resources\mipmap-hdpi\ /Y
xcopy !ruta!\mipmap-mdpi\*.* APPNotions.Android\Resources\mipmap-mdpi\ /Y
xcopy !ruta!\mipmap-xhdpi\*.* APPNotions.Android\Resources\mipmap-xhdpi\ /Y
xcopy !ruta!\mipmap-xxhdpi\*.* APPNotions.Android\Resources\mipmap-xxhdpi\ /Y
xcopy !ruta!\mipmap-xxxhdpi\*.* APPNotions.Android\Resources\mipmap-xxxhdpi\ /Y
xcopy !ruta!\AppIcon.appiconset\*.* APPNotions.iOS\Assets.xcassets\AppIcon.appiconset\ /Y
xcopy !ruta!\Resources\*.* APPNotions.iOS\Resources\ /Y

pause