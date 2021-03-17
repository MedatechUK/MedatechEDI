Imports System.IO
Imports System.Xml.Serialization
Imports MedatechUK.CLI
Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging

Module Module1

    Public args As clArg
    Public curdir As New DirectoryInfo(Environment.CurrentDirectory)

    Public ReadOnly Property ConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(curdir.FullName, "ftp.config"))
        End Get
    End Property

    Sub Main(arg() As String)

        Dim mode As String = Nothing
        Dim send As Boolean = True
        Dim receive As Boolean = True
        Dim conf As ftpconfig = Nothing

        Try

#Region "Make Config File"

            If Not ConfigFile.Exists Then
                Using c As New ftpconfig("sandbox")
                    With c
                        With .server
                            .Add(New ftpconfigServer("ftp.hostname.com", "NewHostName"))

                        End With

                        With .mode
                            .Add(New ftpconfigMode("sandbox", c.server.Last))
                            With .Last
                                .Act.Add(New ftpconfigModeSend("OUT"))
                                .Act.Add(New ftpconfigModeReceive("IN"))

                            End With
                        End With

                    End With

                    toFile(c)

                End Using

            End If

#End Region

#Region "Command Line Arguments"

            args = New clArg(AddressOf Events.logHandler)
            For Each k As String In args.Keys
                Select Case k.ToLower
                    Case "?", "help"
                        args.syntax()
                        args.wait()
                        End

                    Case "config"
                        'args.Attempt(AddressOf UnpackConfig, New EventArgs, "Unpacking Config")
                        args.wait()
                        End

                    Case "mode", "m"
                        mode = args(k)

                    Case "dir", "d"
                        curdir = New DirectoryInfo(args(k))
                        If Not curdir.Exists Then _
                        Throw New Exception(String.Format("Invalid -d folder {0}.", args(k)))

                    Case "i", "in"
                        send = False

                    Case "o", "out"
                        receive = False

                End Select

            Next

#End Region

            Using ex As New AppExtension(AddressOf Events.logHandler)
                With ex.LexByAssemblyName(GetType(ftpconfig).FullName)
                    Using ftp As New ftpConnection(.Deserialise(New StreamReader(ConfigFile.FullName)), ex, mode)
                        ftp.connect(send, receive)

                    End Using
                End With
            End Using

        Catch ex As Exception
            Log(ex.Message)

        Finally
            args.wait()

        End Try

    End Sub

    Private Sub toFile(settings As ftpconfig)
        Dim writer As XmlSerializer
        Try
            writer = New XmlSerializer(GetType(ftpconfig))
        Catch : End Try
        Using f As New System.IO.StreamWriter(ConfigFile.FullName)
            writer.Serialize(f, settings)
        End Using

    End Sub

End Module
