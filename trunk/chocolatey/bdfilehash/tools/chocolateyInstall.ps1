$packageName = 'bdfilehash'
$installerType = 'EXE'
$url = 'http://bdfilehash.codeplex.com/downloads/get/250123'
$silentArgs = '/S' 
$validExitCodes = @(0) 
Install-ChocolateyPackage "$packageName" "$installerType" "$silentArgs" "$url" -validExitCodes $validExitCodes
