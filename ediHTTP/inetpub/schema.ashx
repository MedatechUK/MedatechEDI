<%@ WebHandler Language="VB" Class="schema" %>

Imports System.Data.SqlClient
Imports System.Xml

Public Class schema : Inherits MedatechUK.xmlfeed

    Public Overrides Sub response(ByRef cn As SqlConnection, ByRef w As XmlTextWriter)
        With w
            .WriteStartElement("test")
            .WriteAttributeString("test", "test")
            .WriteEndElement()

        End With

    End Sub

End Class