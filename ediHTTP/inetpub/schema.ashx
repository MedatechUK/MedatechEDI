<%@ WebHandler Language="VB" Class="schema" %>

Imports System.Data.SqlClient
Imports System.Xml
Imports MedatechUK.Deserialiser

Public Class schema : Inherits MedatechUK.xmlfeed

    Public Overrides Sub response(ByRef cn As SqlConnection, ByRef w As XmlTextWriter)
        With w
            .WriteStartElement("schema")

            For Each env As String In Envs
                .WriteStartElement("env")
                .WriteAttributeString("name", env)

                Using command As New SqlCommand(
                    String.Format(
                        "use {0}; " &
                        "select SO.OBJECT_ID as [ObjectID], " &
                        "SO.name AS [ObjectName] " &
                        "From sys.objects AS SO " &
                        "INNER JOIN sys.parameters AS P " &
                        "On SO.OBJECT_ID = P.OBJECT_ID " &
                        "WHERE 0=0 " &
                        "And SO.TYPE IN ('FN') " &
                        "And (TYPE_NAME(P.user_type_id)='xml') " &
                        "And P.is_output=1 ",
                        env
                        ), cn
                    )


                    Using rs As SqlDataReader = command.ExecuteReader
                        If rs.HasRows Then
                            While rs.Read
                                .WriteStartElement("feed")
                                .WriteAttributeString("name", rs("ObjectName"))
                                '_ObjectID = rs("ObjectID")

                                Using command2 As New SqlCommand(
                                    String.Format(
                                        "use {0}; " &
                                        "SELECT	" &
                                        "	P.name AS [ParameterName],	" &
                                        "	TYPE_NAME(P.user_type_id) AS [ParameterDataType] " &
                                        "FROM sys.objects AS SO	" &
                                        "	INNER JOIN sys.parameters AS P 	" &
                                        "	ON SO.OBJECT_ID = P.OBJECT_ID	" &
                                        "WHERE 0=0	" &
                                        "	And SO.OBJECT_ID = {1}	" &
                                        "	And P.is_output=0" &
                                        "order by parameter_id",
                                        env,
                                        rs("ObjectID")
                                        ), cn
                                    )

                                    Using rs2 As SqlDataReader = command2.ExecuteReader
                                        If rs2.HasRows Then
                                            While rs2.Read
                                                .WriteStartElement("param")
                                                .WriteAttributeString("name", rs2("ParameterName").substring(1))
                                                .WriteAttributeString("type", rs2("ParameterDataType"))
                                                .WriteEndElement()
                                            End While

                                        End If

                                    End Using

                                End Using

                                .WriteEndElement()

                            End While

                        End If

                    End Using

                End Using


                .WriteEndElement()

            Next

            .WriteStartElement("lexor")
            Using app As New AppExtension(AddressOf MyBase.hLog)
                For Each a As String In app.LoadedAssemblies
                    .WriteStartElement("assembly")
                    .WriteAttributeString("name", a)
                    .WriteEndElement()
                Next
            End Using
            .WriteEndElement()

            .WriteEndElement()

        End With

    End Sub

End Class