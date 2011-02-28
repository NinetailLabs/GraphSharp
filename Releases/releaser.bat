set PATH=%PATH%;c:\Windows\Microsoft.NET\Framework\v3.5\;
set PATH=%PATH%;"c:\Program Files\7-Zip\";

set Solution=GraphSharp
set RFolder=..\Releases
set RelativeFolder=..\%RFolder%

set ReleaseRootFolder=%date:~0,4%-%date:~5,2%-%date:~8,2%-v%1
set ReleaseFolder=%ReleaseRootFolder%\Release
set SampleFolder=%ReleaseRootFolder%\Sample
set SourceFolder=%ReleaseRootFolder%\Source

mkdir %ReleaseFolder%
mkdir %SampleFolder%
mkdir %SourceFolder%

cd ..\Source

rem Create The Release

rem --- Algorithms ---
MSBuild.exe .\Graph#\GraphSharp.csproj /p:Configuration=Release;TargetFrameworkVersion=v3.5;OutDir=%RelativeFolder%\%ReleaseFolder%\

rem --- Controls --- 
MSBuild.exe .\Graph#.Controls\GraphSharp.Controls.csproj /p:Configuration=Release;TargetFrameworkVersion=3.5;OutDir=%RelativeFolder%\%ReleaseFolder%\


rem Create The Sample

MSBuild.exe .\Graph#.Sample\GraphSharp.Sample.csproj /t:Rebuild /p:Configuration=Release;TargetFrameworkVersion=v3.5;OutDir=%RelativeFolder%\%SampleFolder%\


rem Copy The Source
cd %RFolder%\%SourceFolder%
"%CPCFOLDER%"\cpc.exe checkout %Solution%


cd ..\
7z a -r0 %Solution%-v%1-release.zip Release\*.*
7z a -r0 %Solution%-v%1-sample.zip Sample\*.*
7z a -r0 %Solution%-v%1-source.zip Source\*.*

rmdir /S /Q Release
rmdir /S /Q Sample
rmdir /S /Q Source
