set "PATH=c:\windows\microsoft.net\framework\v4.0.30319\"
del DotNetBindings.dll
csc /target:library /out:DotNetBindings.dll /platform:x86 *.cs Core\*.cs Engine\*.cs
pause