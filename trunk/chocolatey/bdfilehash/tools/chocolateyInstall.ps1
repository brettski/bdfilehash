$packageName = 'bdfilehash'
$installerType = 'EXE'
$url = 'https://bdfilehash.codeplex.com/downloads/get/977851'
$silentArgs = '/S' 
$validExitCodes = @(0) 
Install-ChocolateyPackage "$packageName" "$installerType" "$silentArgs" "$url" -validExitCodes $validExitCodes
