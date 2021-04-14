Imports MedatechUK.Logging
Imports MedatechUK.Deserialiser
Imports System.IO
Imports System.Xml.Serialization

Module Module1

    Private _appEx As AppExtension

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

    Private Sub toFile(settings As runbatconfig)
        Dim writer As XmlSerializer
        Try
            writer = New XmlSerializer(GetType(runbatconfig))
        Catch : End Try
        Using f As New System.IO.StreamWriter(ConfigFile.FullName)
            writer.Serialize(f, settings)
        End Using

    End Sub

    Private ReadOnly Property _config As runbatconfig
        Get
            With _appEx.LexByAssemblyName(GetType(runbatconfig).FullName)
                Return .Deserialise(New StreamReader(ConfigFile.FullName))
            End With
        End Get

    End Property

    Sub main()

        Try
            _appEx = New MedatechUK.Deserialiser.AppExtension(AddressOf MedatechUK.Logging.Events.logHandler)

            Log("Starting...")

#Region "Make config file"

            If Not ConfigFile.Exists Then
                Using c As New runbatconfig
                    With c
                        .loc.Add(New runbatconfigLoc("c:\out", "runbatconfig", "demo"))
                    End With
                    toFile(c)
                End Using
            End If

#End Region

            For Each loc As runbatconfigLoc In _config.loc
                With New DirectoryInfo(loc.path)
                    If Not .Exists Then
                        Log("Monitor folder [{0}] missing.", .FullName)

                    Else
                        ' Validate binaries                                
                        For Each l As Lazy(Of ILexor, ILexorProps) In _appEx.Lexors
                            If String.Compare(l.Metadata.LexName, loc.bin, True) = 0 Then
                                loc.isLexor = True
                                Exit For
                            End If
                        Next

                        If Not loc.isLexor Then
                            If Not New FileInfo(loc.bin).Exists Then
                                Throw New Exception(String.Format("Executable not found: [{0}]", loc.bin))

                            End If
                        End If

                        Log("Monitoring folder [{0}].", .FullName)

                    End If

                End With

            Next

        Catch ex As Exception
            Log(ex.Message)
            End

        End Try
    End Sub

End Module
