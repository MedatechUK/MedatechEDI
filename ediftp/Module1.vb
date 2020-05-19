Imports System.IO
Imports System.Net.Mail
Imports MedatechUK.CLI

Module Module1

    Public args As clArg
    Public curdir As New DirectoryInfo(Environment.CurrentDirectory)

    Sub Main(arg() As String)

        Dim mode As String = Nothing
        Dim configMode As Boolean = False
        Dim send As Boolean = True
        Dim receive As Boolean = True
        Dim errNotify As ftpconfigNotifyerror

        Try
            args = New clArg()
            For Each k As String In args.Keys
                Select Case k.ToLower
                    Case "?", "help"
                        args.syntax()
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

                    Case "config"
                        configMode = True

                End Select

            Next

            If Not configMode Then
                Using ftp As New ftpConnection(mode)
                    errNotify = ftp.errNotify
                    ftp.connect(send, receive)

                End Using

            Else
                args.line(
                    "Creating {0}",
                    Path.Combine(
                        curdir.FullName,
                        "ftp.config"
                    )
                )
                ' Write blank ftp.config to the curdir
                Dim cf As New FileInfo(Path.Combine(curdir.FullName, "ftp.config"))
                If Not cf.Exists Then
                    Using sw As New StreamWriter(cf.FullName)
                        sw.Write(My.Resources._default)

                    End Using
                    args.Colourise(ConsoleColor.Green, "OK")

                Else
                    args.Colourise(ConsoleColor.Green, "FAIL")
                    Throw New Exception(String.Format("The ftp.config file already exists in {0}.", curdir.FullName))

                End If

            End If

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
                    .Subject = "ediFtp runtime error."
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
