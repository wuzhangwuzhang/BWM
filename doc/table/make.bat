@echo off
pushd "%~dp0"
set tool=..\..\..\..\Tools\release

del /Q *.meta;*.pbt;*.proto;*.cs;*.json
%tool%\TableBuild .

popd
pause