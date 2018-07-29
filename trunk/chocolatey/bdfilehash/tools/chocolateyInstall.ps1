
$url = 'https://github.com/brettski/bdfilehash/releases/download/v1.1.4/BDFileHashSetup.1.1.4.exe'
$SHA256='aec7742b6b402ed1ac31d75c8ea91cadc425333a9baed0ed7d244af2146b3209'
$chocoInstArgs = @{
    PackageName = 'bdfilehash'
    InstallerType = 'EXE' 
    silentArgs = '/S' 
    url = "$url" 
    validExitCodes = @(0) 
    checkSum = $SHA256 
    checksumType = "SHA256"
}
Install-ChocolateyPackage $chocoInstArgs
