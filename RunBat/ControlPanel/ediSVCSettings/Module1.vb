Imports System.IO
Imports System.Xml.Serialization
Imports MedatechUK.CLI
Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging

Module Module1

    Public config As runbatconfig
    Public oconfig As odataConfig
    Public lexors As List(Of String)
    Public args As New clArg(AddressOf MedatechUK.Logging.Events.logHandler)
    Public changes As Boolean = False

    Sub Main(arg() As String)

        Dim mode As String = Nothing
        Dim send As Boolean = True
        Dim receive As Boolean = True
        Dim conf As runbatconfig = Nothing
        Dim isConfig As Boolean = False

        Try

#Region "Make Config Files"

            If Not ConfigFile.Exists Then

                If Not ConfigFile.Exists Then
                    Using c As New runbatconfig
                        With c
                            .loc.Add(New runbatconfigLoc("c:\out", "runbatconfig", "demo"))
                        End With
                        toFile(c)
                    End Using
                End If

            End If

            If Not oDataConfigFile.Exists Then
                Using c As New odataConfig("https://localhost")
                    oDatatoFile(c)

                End Using
            End If

#End Region

#Region "Command Line Arguments"

            Using ex As New AppExtension(AddressOf Events.logHandler)
                With ex
                    lexors = .LoadedAssemblies
                    With .LexByAssemblyName(GetType(runbatconfig).FullName)
                        Using sr As New StreamReader(ConfigFile.FullName)
                            Using c As runbatconfig = .Deserialise(sr)
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
                        changes = False
                        c.ShowDialog()

                    End Using

                End With

            End Using

#End Region

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, "")
            Log(ex)

        Finally
            Console.WriteLine()
            args.wait()

        End Try

    End Sub

#Region "Config Files"

    Private ReadOnly Property ConfigFile As FileInfo
        Get
            Return New FileInfo(
                Path.Combine(
                    New FileInfo(Reflection.Assembly.GetExecutingAssembly.Location).Directory.FullName,
                    "runbat.config"
                )
            )
        End Get
    End Property

    Public ReadOnly Property oDataConfigFile As FileInfo
        Get
            Return New FileInfo(
                Path.Combine(
                    New FileInfo(Reflection.Assembly.GetExecutingAssembly.Location).Directory.FullName,
                    "odata.config"
                )
            )
        End Get
    End Property

    Friend Sub toFile(settings As runbatconfig)
        Dim writer As XmlSerializer
        Try
            writer = New XmlSerializer(GetType(runbatconfig))
        Catch : End Try
        Using f As New System.IO.StreamWriter(ConfigFile.FullName)
            writer.Serialize(f, settings)
        End Using

    End Sub

    Friend Sub oDatatoFile(settings As odataConfig)
        Dim writer As XmlSerializer
        Try
            writer = New XmlSerializer(GetType(odataConfig))
        Catch : End Try
        Using f As New System.IO.StreamWriter(oDataConfigFile.FullName)
            writer.Serialize(f, settings)
        End Using

    End Sub

#End Region

End Module
