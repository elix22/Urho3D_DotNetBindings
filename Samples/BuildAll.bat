set "PATH=c:\windows\microsoft.net\framework\v4.0.30319\"

call Clear.bat

csc /target:exe /out:01_HelloWorld.exe /reference:DotNetBindings.dll /platform:x64 01_HelloWorld\*.cs *.cs
csc /target:exe /out:04_StaticScene.exe /reference:DotNetBindings.dll /platform:x64 04_StaticScene\*.cs *.cs
csc /target:exe /out:34_DynamicGeometry.exe /reference:DotNetBindings.dll /platform:x64 34_DynamicGeometry\*.cs *.cs

pause
