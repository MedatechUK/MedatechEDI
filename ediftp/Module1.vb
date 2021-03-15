Imports System.IO
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
                For Each l As Lazy(Of ILexor, ILexorProps) In ex.Lexors
                    If l.Metadata.SerialType Is GetType(ediftp.ftpconfig) Then
                        Using ftp As New ftpConnection(l.Value.Deserialise(New StreamReader(ConfigFile.FullName)), mode)
                            ftp.connect(send, receive)

                        End Using

                    End If
                Next
            End Using

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, ex.Message)
            Console.WriteLine()
            Log(ex.Message)
            'args.errNotify("ediFtp runtime error.", ConfigFile, ex)

        Finally
            args.wait()

        End Try

    End Sub

    Private Sub UnpackConfig(sender As Object, e As EventArgs)

        ' Write blank ftp.config to the curdir
        Dim cf As New FileInfo(
            Path.Combine(
                curdir.FullName, "ftp.config"
            )
        )

        If Not cf.Exists Then
            Using sw As New StreamWriter(cf.FullName)
                sw.Write(My.Resources._default)

            End Using

        Else
            Throw New Exception(
                String.Format(
                    "The ftp.config file already exists in {0}.",
                    curdir.FullName
                )
            )

        End If

    End Sub

End Module
