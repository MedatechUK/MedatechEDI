Medatech UK FTP utility.
si@medatechuk.com

This utility sends / receives files using ftp, sftp, webdav and S3.
The -config option can be used to generate an ftp.config in the working directory, 
which provides connection and ftp details.

  ediFTP.exe {{-d DirectoryName} {-m ModeName} {-i|-o}} | {-config} {-w} {-?}

	 -d      (Optional) If specified, the ftp directory. 
	                    The current working directory will be used if ommited.

	 -m      (Optional) If specified, the mode that will be used. 
	                    If ommited the default mode specified in the ftp.config.

	 -i|-o   (Optional) If specified, Limit the procedure to ONLY send (o) or receive (i). 
	                    If ommited, both are performed.

	 -config (Optional) Create an example ftp.config in the selected -d folder, 
	                    or current working directory. 

	 -w      (Optional) Wait for key press after execution.

	 -?      (Optional) This file.

[See the ftp.config documentation](https://github.com/MedatechUK/MedatechEDI/blob/master/ediftp/default.config).