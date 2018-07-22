$packageName = 'bdfilehash'
$installerType = 'EXE'
$url = 'https://github.com/brettski/bdfilehash/releases/download/v1.1.4/BDFileHashSetup.1.1.4.exe'
$silentArgs = '/S' 
$validExitCodes = @(0) 
Install-ChocolateyPackage "$packageName" "$installerType" "$silentArgs" "$url" -validExitCodes $validExitCodes
