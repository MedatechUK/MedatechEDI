# oData.dll

This oData library is used by [ediLoad.exe](https://github.com/MedatechUK/MedatechEDI/tree/master/ediLoad) to talk to the Priority oData service.

Connection details for this library are specified in the [odata.config](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Resources/odata.config).

It provides the underlying inheritance structure for [PriBase.dll](https://github.com/MedatechUK/MedatechEDI/tree/master/PriorityForms), which defines the specific columns and subforms in the customers Priority.

This is a sligtly modified version of the oData library as used by the [API](https://github.com/SimonBarnett/api), which uses [odata.config](https://github.com/MedatechUK/MedatechEDI/blob/master/ediLoad/Resources/odata.config) to provide connection details, rather than the web.config of the website.