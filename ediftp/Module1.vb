Imports System.IO
Imports System.Xml.Serialization
Imports MedatechUK.CLI
Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging

Module Module1

    Public config As ftpconfig
    Public oconfig As odataConfig
    Public lexors As List(Of String)
    Public args As New clArg(AddressOf MedatechUK.Logging.Events.logHandler)
    Public curdir As New DirectoryInfo(Environment.CurrentDirectory)

    Public ReadOnly Property ConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(curdir.FullName, "ftp.config"))

        End Get
    End Property

    Public ReadOnly Property oDataConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(curdir.FullName, "odata.config"))

        End Get
    End Property

    Sub Main(arg() As String)

        Dim mode As String = Nothing
        Dim send As Boolean = True
        Dim receive As Boolean = True
        Dim conf As ftpconfig = Nothing
        Dim isConfig As Boolean = False

        Try

#Region "Make Config Files"

            args.Log("Executing in [{0}].", curdir.FullName)
            If Not ConfigFile.Exists Then

                args.Log("Missing ftp.config. Creating.")
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

            If Not oDataConfigFile.Exists Then
                Using c As New odataConfig("https://localhost")
                    oDatatoFile(c)

                End Using
            End If

#End Region

#Region "Command Line Arguments"

            Using ex As New AppExtension(AddressOf Events.logHandler)

                args = New clArg(AddressOf Events.logHandler)
                For Each k As String In args.Keys
                    Select Case k.ToLower
                        Case "?", "help"
                            args.syntax()
                            args.wait()
                            End

                        Case "config"
                            isConfig = True
                            With ex
                                lexors = .LoadedAssemblies
                                With .LexByAssemblyName(GetType(ftpconfig).FullName)
                                    Using sr As New StreamReader(ConfigFile.FullName)
                                        Using c As ftpconfig = .Deserialise(sr)
                                            config = c
                                        End Using
                                    End Using
                                End With

                                With .LexByAssemblyName(GetType(odataConfig).FullName)
                                    Using sr As New StreamReader(oDataConfigFile.FullName)
                                        Using c As odataConfig = .Deserialise(sr)
                                            oconfig = c
                                        End Using
                                    End Using
                                End With

                                Using c As New frmConfig()
                                    c.ShowDialog()
                                End Using

                            End With

                            Try
                                args.line("Saving configuration")
                                toFile(config)
                                oDatatoFile(oconfig)
                                args.Colourise(ConsoleColor.Green, "OK")

                            Catch exp As Exception
                                args.Colourise(ConsoleColor.Red, "Fail")
                            Finally
                                Console.WriteLine()
                            End Try

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

                If Not isConfig Then
                    With ex.LexByAssemblyName(GetType(ftpconfig).FullName)
                        Using sr As New StreamReader(ConfigFile.FullName)
                            Using ftp As New ftpConnection(.Deserialise(sr), ex, mode)
                                ftp.connect(send, receive)

                            End Using
                        End Using
                    End With
                End If

            End Using

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, ex.Message)
            Log(ex.Message)

        Finally
            Console.WriteLine()
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

    Private Sub oDatatoFile(settings As odataConfig)
        Dim writer As XmlSerializer
        Try
            writer = New XmlSerializer(GetType(odataConfig))
        Catch : End Try
        Using f As New System.IO.StreamWriter(oDataConfigFile.FullName)
            writer.Serialize(f, settings)
        End Using

    End Sub

End Module
