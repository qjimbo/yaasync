[Setup]
#define AppVersion GetDateTimeString('yyyy','','') + "." + GetDateTimeString('mm','','') + "." + GetDateTimeString('dd','','') + "." + GetDateTimeString('hhmm','','')
AppName=Yaasync
AppVersion={#AppVersion}
VersionInfoVersion={#AppVersion} 
DefaultDirName={sd}\Yaasync
DefaultGroupName=Yaasync
UninstallDisplayIcon={app}\Yaasync.exe
Compression=lzma2
SolidCompression=yes
OutputDir=.\
OutputBaseFilename=yaasync_setup
PrivilegesRequired=lowest

SourceDir=bin/Debug

[Code]
procedure StoreVersion();
begin
SaveStringToFile( ExpandConstant('{app}\version.txt'), ExpandConstant('{#AppVersion}') , False);
end;

[Files]
Source: "*.exe"; DestDir: "{app}"; Excludes: "yaasync_setup.exe,*.vshost.exe"; Flags: ignoreversion; AfterInstall: StoreVersion
Source: "*.dll"; DestDir: "{app}"; Flags: ignoreversion;
Source: "*.ttf"; DestDir: "{app}"; Flags: ignoreversion;
Source: "api.php"; DestDir: "{app}\API PHP Example"; Flags: ignoreversion;

[Run]
Filename: "{app}\Yaasync.exe"; Description: "Start Yaasync"; Flags: postinstall

[Icons]
Name: "{group}\Yaasync"; Filename: "{app}\Yaasync.exe"
Name: "{commondesktop}\Yaasync"; Filename: "{app}\Yaasync.exe"