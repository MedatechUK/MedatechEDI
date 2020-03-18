Medatech UK EDI Data Export utility.
si@medatechuk.com

This utility creates nested export data from a Priority SQL server.
The -config option can be used to generate an make.config in the working directory, 
which provides details of the SQL views / tabula functions to export.

  ediMake.exe {-config} {-w} {-?}

	 -config (Optional) Create an example make.config in the current working 
	                    directory. Edit this to point to your database.

						If a valid config file already exists the config
						option checks the colums in the specified SQL objects
						and prompts the user to update the columns specified in
						the make.config file.

	 -w      (Optional) Wait for key press after execution.

	 -?      (Optional) This file.

[See the make.config documentation](https://github.com/MedatechUK/ediMake/blob/master/default.config).