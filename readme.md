# Medatech EDI Tools.

## Command line tools.

### Common Switches
	
	-config		This creates whatever .config file are needed to store
		program settings. Documentation about what should be 
		included in these files is included.
	
	-w			This option causes the program to wait for user keypress
		after execution, so you can see the output window.

	-?			Displays the help file for the program.

### The Working Directory.

The installer places the programs in your windows PATH, so that you can
call these programs from any working directory, by CDing in a command promt
to where your files live. You can also use the Working Directory of a
scheduled task to specify the working directory that will be used.

### Logging.

All programs log events to a file in the format 
> CURDIR\log\{year}{month}\day.txt

Additionally, any errors can be emailed using the mail settings in the
programs .config file.

### [ediFTP.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediftp).

This utility sends / receives files using ftp, sftp, debdav and S3.
The -config option can be used to generate an ftp.config in the working directory, 
which provides connection and ftp details.

### [ediLoad.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediLoad)

This utility deserialises object notation data from downloaded files. 
It uses the Medatech oData Library to write that data to Priority.
The -config option can be used to generate an oData.config and make.config
in the working directory, which provides odata and email notification details.

### [ediMake.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediMake)

This utility creates nested export data from a Priority SQL server.
The -config option can be used to generate an make.config in the working directory, 
which provides details of the SQL views / tabula functions to export.

## Library Files.

### [oDataCli.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/oData.net)

The oData library used by [ediLoad.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediLoad) to talk to the Priority oData service.

### [PriBase.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms)

A library of Priority form definitions inherited from [oDataCli.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms) 