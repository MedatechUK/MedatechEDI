# RUNBAT service.

This service listens for the file creation event in windows and uses the filename as the parameter of a batch file.

The list of monitored locations is stored in the {installfolder}\paths.xml

By default this path is *C:\Program Files\MedatechUK\MedatechEDI\paths.xml*

<?xml version="1.0"?>

## The paths.xml config file

The paths.xml file lists the locations to be monitored in the *name* attribute of the *<loc>* element.
*loc/name* may be a UNC path (in the \\server\share format).

For each location monitored you must specify a batch file (.bat) or binary (.exe) that will be executed when the file is created.
The path and filename of the created file is then presented to the *loc/bat* as a paramenter.
To refer to this in a batch file, use %1 as the placeholder for your filename.

## path.xml example.

```<paths>
```	<loc bat="SolidWorks1.exe" name="\\SVR2012\shared 2\Design Documentation\Priority BOM Exports"/>
```	<loc bat="SolidWorks2.exe" name="\\SVR2012\shared 2\Design Documentation\Priority Electric Exports"/>
```</paths>