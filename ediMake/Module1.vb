Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports MedatechUK.CLI

Module Module1

    Public args As clArg
    Public configMode As Boolean = False
    Dim errNotify As ftpconfigNotifyerror

    Public ReadOnly Property ConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(Environment.CurrentDirectory, "make.config"))
        End Get
    End Property

    Sub Main(arg() As String)

        Dim s As New XmlSerializer(GetType(makeconfig))
        Dim config As makeconfig

        Try
            args = New clArg()
            For Each k As String In args.Keys
                Select Case k.ToLower
                    Case "?", "help"
                        args.syntax()
                        args.wait()

                    Case "config"
                        configMode = True

                End Select

            Next

            args.line("Opening {0}", ConfigFile.FullName)
            If Not ConfigFile.Exists Then ' Create the config file
                args.Colourise(ConsoleColor.Red, "FAIL")

                If Not configMode Then
                    Throw New Exception(String.Format("Missing {0} in {1}.", ConfigFile.Name, Path.GetDirectoryName(ConfigFile.FullName)))

                Else
                    Try
                        args.line(
                            "Creating {0}",
                            ConfigFile.FullName
                        )
                        Using sw As New StreamWriter(ConfigFile.FullName)
                            sw.Write(My.Resources._default)

                        End Using

                        args.Colourise(ConsoleColor.Green, "OK")
                        args.wait()

                    Catch ex As Exception
                        args.Colourise(ConsoleColor.Green, "FAIL")
                        Throw ex

                    End Try

                End If

            Else
                args.Colourise(ConsoleColor.Green, "OK")

            End If

            args.line("Deserialising {0}", ConfigFile.Name)
            Using sr As New StreamReader(ConfigFile.FullName)
                Try
                    config = s.Deserialize(sr)
                    errNotify = config.notifyerror
                    args.Colourise(ConsoleColor.Green, "OK")

                Catch ex As Exception
                    args.Colourise(ConsoleColor.Green, "FAIL")
                    Throw New Exception(String.Format("Invalid {0} in {1}.", ConfigFile.Name, Path.GetDirectoryName(ConfigFile.FullName)))

                End Try

                With config
                    For Each o As makeconfigOutput In .output
                        Using outf As New OutFile(o, config)
                            If Not configMode Then outf.Write()

                        End Using

                    Next

                End With

            End Using

            Dim xrset As New XmlWriterSettings
            With xrset
                .Indent = True
                .IndentChars = vbTab
                .OmitXmlDeclaration = True
            End With

            ' Save the config
            args.line("Saving {0}", ConfigFile.Name)
            Try
                Using xr As XmlWriter = XmlWriter.Create(ConfigFile.FullName, xrset)
                    s.Serialize(xr, config)
                    args.Colourise(ConsoleColor.Green, "OK")
                End Using

            Catch ex As Exception
                args.Colourise(ConsoleColor.Green, "FAIL")
                Throw ex

            End Try

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, ex.Message)
            args.Log(ex.Message)

            If Not errNotify Is Nothing Then
                Dim erMail = New MailMessage(errNotify.from, errNotify.notify(0).address)
                With erMail
                    With .CC
                        For i As Integer = 1 To errNotify.notify.Count - 1
                            .Add(errNotify.notify(i).address)
                        Next
                    End With
                    .Subject = "ediMake runtime error."
                    .Body = ex.Message

                    Using c As New SmtpClient(errNotify.smtp)
                        c.Send(erMail)

                    End Using
                End With

            End If

        Finally
            args.wait()

        End Try

    End Sub

End Module
