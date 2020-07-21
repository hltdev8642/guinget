; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "guinget"
#define MyAppVersion "0.1.0.1"
#define MyAppPublisher "Drew Naylor"
#define MyAppURL "https://github.com/DrewNaylor/guinget"
#define MyAppUpdatesURL "https://github.com/DrewNaylor/guinget/releases/latest"
#define MyAppHelpURL "https://github.com/DrewNaylor/guinget/docs"
#define MyAppExeName "guinget.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{18980A21-0836-42CA-8200-5BC7273F7DE2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} version {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppHelpURL}
AppUpdatesURL={#MyAppUpdatesURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName=Drew Naylor
LicenseFile=C:\Users\drewn\My Applications\guinget\v0.1.0.1-alpha\LICENSE.txt
InfoBeforeFile=C:\Users\drewn\My Applications\guinget\v0.1.0.1-alpha\README for guinget.txt
InfoAfterFile=C:\Users\drewn\My Applications\guinget\v0.1.0.1-alpha\v0.1.0.1-alpha_changelog_from-v0.1-alpha.txt
OutputDir=C:\Users\drewn\My Applications\guinget\v0.1.0.1-alpha\
OutputBaseFilename=guinget_v0.1.0.1-alpha
Compression=lzma
SolidCompression=yes
AppCopyright=Copyright 2020 Drew Naylor. Licensed under Apache License 2.0.
ShowLanguageDialog=no
UninstallDisplayIcon={uninstallexe}
MinVersion=0,6.1
CreateUninstallRegKey=yes
EnableDirDoesntExistWarning=True
DirExistsWarning=no
VersionInfoVersion=0.1.0.1
AlwaysShowGroupOnReadyPage=True
AlwaysShowDirOnReadyPage=True
DisableStartupPrompt=False
DisableDirPage=auto
DisableProgramGroupPage=auto
WizardStyle=modern
WizardResizable=True

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\guinget.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\README for guinget.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\source-code.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\guinget.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\v0.1.0.1-alpha_changelog_from-v0.1-alpha.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\LICENSE-YamlDotNet.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\update-manifests.bat"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\YamlDotNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\libguinget.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\My Applications\guinget\v0.1.0.1-alpha\docs\*"; DestDir: "{app}\docs"; Flags: ignoreversion createallsubdirs recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Messages]
UninstalledAll=%1 was successfully removed from your computer. Configuration files may still be present in (username)\AppData\Roaming\guinget, where (username) is your user profile usually in C:\Users.

[Dirs]
Name: "{app}\docs"
