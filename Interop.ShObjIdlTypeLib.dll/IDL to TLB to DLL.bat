@echo off

REM Mike Chambers
REM Batch file to convert an IDL to a TLB.

REM Set the assembly and file version. I tinkered with the idea of setting the ver with the ver of Windows that it was from...
set ver=1.0.0.0

REM Remove any previous output files
IF EXIST ShObjIdl_core.tlb del /F ShObjIdl_core.tlb
IF EXIST Interop.ShObjIdlCoreTypeLib.dll del /F Interop.ShObjIdlCoreTypeLib.dll

REM Load VS environment
call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\vcvarsall.bat"

REM Convert the IDL file to TLB
REM Using Windows 10 SDK to get IDL (C:\Program Files\Windows Kits\10\Include\10.0.17763.0\um\ShObjIdl_core.idl)
REM NOTE: To get MIDL to generate only the TLB file, send all of the other output files to the NUL file.
REM NOTE: Was getting MIDL error 2455. Workaround is to specify NT60 target (https://developercommunity.visualstudio.com/content/problem/138174/midl-error-2455-in-c-atl-inproc-server-project.html).
midl /proxy nul /header nul /iid nul /dlldata nul /target NT60  /win32 ShObjIdl_core.idl /tlb ShObjIdl_core.tlb

REM Convert the TLB to a DLL (machine, sysarray, and transform added because VS does it)
tlbimp ShObjIdl_core.tlb /namespace:ShObjIdlCoreTypeLib /productversion:%ver% /machine:X86 /out:Interop.ShObjIdlCoreTypeLib.dll /sysarray /transform:DispRet