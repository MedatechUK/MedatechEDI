#Medatech EDI Tools.

##Command line tools.

###[ediFTP.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediftp).

This utility sends / receives files using ftp, sftp, debdav and S3.
The -config option can be used to generate an ftp.config in the working directory, 
which provides connection and ftp details.

###[ediLoad.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediLoad)

This utility deserialises object notation data from downloaded files. 
It uses the Medatech oData Library to write that data to Priority.

###[ediMake.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediMake)

This utility creates nested export data from a Priority SQL server.
The -config option can be used to generate an make.config in the working directory, 
which provides details of the SQL views / tabula functions to export.

##Library Files.

###[oDataCli.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms)

The oData library used by [ediLoad.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediLoad) to talk to the Priority oData service.

###[PriBase.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms)

A library of Priority form definitions inherited from [oDataCli.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms) 