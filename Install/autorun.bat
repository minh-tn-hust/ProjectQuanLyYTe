echo off
color 0a
set local=%CD%
set assemblyPath="%CD%\LastModel\bin\Debug\LastModel.dll"
set projectPath="%CD%\LastModel\\"
set configPath="%CD%\LastModel\App.config"
set ef6Exe=%CD%\packages\EntityFramework.6.4.4\tools\net45\any
set databaseCommnad=ef6.exe database update --verbose --no-color --prefix-output --assembly %assemblyPath% --project-dir %projectPath% --language C# --root-namespace UpdateDatabase --config %configPath%
cd %ef6Exe%
%databaseCommnad%
cd %local%
QuanLyYTe.msi
exit