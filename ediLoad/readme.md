# Medatech UK oData Load utility.
[si@medatechuk.com](si@medatechuk.com)

## Purpose

This utility deserialises object notation data from downloaded files. 
It uses the [Medatech oData Library](https://github.com/MedatechUK/MedatechEDI/tree/master/oData.net) to write that data to Priority.
The -config option can be used to generate an oData.config and make.config
(see references)in the working directory, which provides odata and email 
notification details.

This program can be run by an [ftp receive act](https://github.com/MedatechUK/MedatechEDI/blob/master/ediftp/default.config). 
[ediFTP.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediftp) will pass any downloadeded file as the {file} parameter to the program for loading.

## Syntax

  ediLoad.exe {file} | {-config} {-w} {-?}

	 {file}		The fully qualified filename of the file to be loaded.

	 -config	Create a blank config file in the working directory.

	 -w			(Optional) Wait for key press after execution.

	 -?			(Optional) This file.

## Reference

[See the load.config documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/default.config)

[See the odata.config documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Resources/odata.config)