# BD File Hash
_Moved from [CodePlex](https://bdfilehash.codeplex.com/) on 9/17/2017_

## Project Description
BD File Hash is a convenient file hashing and hash compare tool for Windows which currently works with MD5, SHA-1, SHA-256, and SHA-512 algorithms.  


The goal behind BD File Hash is to have a super simple to use hashing tool which doesn't force you to copy/paste hash strings between documents and applications to match them.  

Tell us (Only 1 question): how often do you verify file hashes? [http://www.surveymonkey.com/s/S98MKHS](http://www.surveymonkey.com/s/S98MKHS)

+Please comment or rate this application to help it grow and develop into a more useful tool.+

## Functionality List
* Create hashes using MD5, SHA-1, SHA-256, and SHA-512
	* +Please suggest any others you may need+
* Right click a file and "Send To" BD File Hash
* Parses the hash string from a text file (no copy/pasting from a text editor)
* When you hash a file, a similar named text file will be scanned for a hash value and written to compare hash field
* Compare two files with just a few clicks
* Save a default hash type
* Hash any string of text by pasting it into a text field
* _New_ Send current hash value to [Virustotal](http://www.virustotal.com) to check the file against their virus reports
* Other user options see [Screen Shots](Screen-Shots)

## Screen Shots
[Screen Shots](Screen-Shots)

## Requirements
* .NET 3.5 SP1

## Install Using Chocolatey!
_[http://chocolatey.org](http://chocolatey.org)_    

{code:powershell}
PS C:\> choco install bdfilehash
{code:powershell}

## Other Information
[FAQs](FAQs)
BD File Hash has been tested and found 100% clean by [Softpedia](http://www.softpedia.com/get/System/File-Management/BD-File-Hash.shtml)


## +Looking for your help!+
There have been inquiries on adding a batch mode to BD File Hash.  I certainly understand the usefulness of such a feature, I am just not positive on the most useful way to implement it.  A few thoughts:
* What types of outputs, CSV, Excel, tab delimited, MS Access, other db file?
* Hash a whole directory of files to a text file?
* Compare a directory of files with a file of hashes?
* compare two directories?
Suggestions and comments will be helpful to create this new feature.  If you have any ideas or suggestions please add them to work item, [workitem:29247](workitem_29247), which is being used to manage this task or discuss the options in discussion [discussion:261356](discussion_261356).  
Thank you for your help in improving this application!

.
