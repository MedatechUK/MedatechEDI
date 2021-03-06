# Medatech UK oData Load utility.
[si@medatechuk.com](si@medatechuk.com)

## Purpose

This utility deserialises object notation data from downloaded files. 
It uses the [Medatech oData Library](https://github.com/MedatechUK/MedatechEDI/tree/master/oData.net) to write that data to Priority.
The -config option can be used to generate an oData.config and make.config
(see references) in the working directory, which provides odata and email 
notification details.

This program can be run by an [ftp receive act](https://github.com/MedatechUK/MedatechEDI/blob/master/ediftp/default.config). 
[ediFTP.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediftp) will pass any downloadeded file as the {file} parameter to the program for loading.

## Posted data

Once data has been posted to the oData server, the {file} is moved.
If the loading reported no errors it is moved to:
> [CURDIR\sent](https://github.com/MedatechUK/MedatechEDI/tree/master/example/sent)\{year}-{month}\bubbleid.txt

If errors occured the file is moved to:
> [CURDIR\err](https://github.com/MedatechUK/MedatechEDI/tree/master/example/err)\{year}-{month}\bubbleid.txt

The bubbleid is a system.guid that is used to create a reference for loading.
This is recorded in the ODATATRANS form when pushing data to Priority ODAT_TRANS 
general load table.

## Syntax

  ediLoad.exe {file} | {-config} {-w} {-?}

	 {file}		The fully qualified filename of the file to be loaded.

	 -config	Create a blank config file in the working directory.

	 -w			(Optional) Wait for key press after execution.

	 -?			(Optional) This file.

## Reference

[See the load.config documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/default.config)

[See the odata.config documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Resources/odata.config)

[See the Ashridge documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/ashridge.md)