Medatech UK oData Load utility.
si@medatechuk.com

This utility deserialises object notation data from downloaded files. 
It uses the Medatech oData Library to write that data to Priority.
The -config option can be used to generate an oData.config and make.config
in the working directory, which provides odata and email notification details.

  ediLoad.exe {file} | {-config} {-w} {-?}

	 {file}		The fully qualified filename of the file to be loaded.

	 -config	Create a blank config file in the working directory.

	 -w			(Optional) Wait for key press after execution.

	 -?			(Optional) This file.

[See the load.config documentation] (https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/default.config)

[See the odata.config documentation] (https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Resources/odata.config)