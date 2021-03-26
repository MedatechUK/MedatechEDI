Imports System.IO
Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging
Imports WinSCP

Public Class ftpConnection
    Inherits Logable
    Implements IDisposable

    Private transferOptions As TransferOptions
    Private sessionOptions As SessionOptions

#Region "Public Properties"

    Private _configMode As ftpconfigMode
    Public ReadOnly Property configMode As ftpconfigMode
        Get
            Return _configMode
        End Get
    End Property

    Private _configServer As ftpconfigServer
    Public ReadOnly Property configServer As ftpconfigServer
        Get
            Return _configServer
        End Get
    End Property

#End Region

#Region "Ctor"

    Private _appEx As AppExtension
    Sub New(ByRef config As ftpconfig, ByRef appEx As AppExtension, Optional Mode As String = Nothing)

        _appEx = appEx
        Me.logHandler = appEx.logHandler
        Dim f As Boolean = False

        If Mode Is Nothing Then Mode = config.defaultmode
        For Each m As ftpconfigMode In config.mode
            If String.Compare(m.name, Mode, True) = 0 Then
                f = True
                _configMode = m
                Dim f1 As Boolean = False
                For Each sv As ftpconfigServer In config.server
                    If String.Compare(m.server, sv.name, True) = 0 Then
                        f1 = True
                        _configServer = sv
                    End If
                    Exit For
                Next
                If Not f1 Then
                    Throw New Exception(String.Format("Invalid server in mode {0}: [{1}]", Mode, m.server))
                End If
                Exit For
            End If
        Next
        If Not f Then
            Throw New Exception(String.Format("Mode not found: [{0}]", Mode))
        Else
            Console.WriteLine("Run Mode is [{0}].", _configMode.name)

        End If

        ' Validate binaries        
        With _configMode
            For Each a As ftpconfigModeAct In .Act
                If a.actType = eActType.receive Then
                    With TryCast(a, ftpconfigModeReceive)
                        If Not .bin Is Nothing Then

                            For Each l As Lazy(Of ILexor, ILexorProps) In appEx.Lexors
                                If String.Compare(l.Metadata.SerialType.FullName, .bin, True) = 0 Then
                                    .isLexor = True
                                    Exit For
                                End If
                            Next

                            If Not .isLexor Then
                                If Not New FileInfo(.bin).Exists Then
                                    Throw New Exception(String.Format("Executable not found: [{0}]", .bin))

                                End If
                            End If

                        End If
                    End With

                End If
            Next
        End With

    End Sub

#End Region

#Region "Methods"

    Public Sub connect(send As Boolean, receive As Boolean)

        transferOptions = New TransferOptions
        transferOptions.TransferMode = _configServer.TransferMode

        sessionOptions = New SessionOptions
        With sessionOptions
            Select Case _configServer.Protocol
                Case 5
                    .Protocol = Protocol.Ftp
                    .FtpSecure = FtpSecure.Explicit
                    .TlsHostCertificateFingerprint = _configServer.SshHostKeyFingerprint

                Case 1, 0
                    .Protocol = _configServer.Protocol
                    .SshHostKeyFingerprint = _configServer.SshHostKeyFingerprint

                Case Else
                    .Protocol = _configServer.Protocol
                    '.FtpMode = FtpMode.Active

            End Select

            .HostName = _configServer.HostName
            .UserName = _configServer.UserName
            .Password = _configServer.Password

            If Not _configServer.Port = -1 Then
                .PortNumber = _configServer.Port
            End If

        End With

        Using session As New Session
            Try
                args.line(
                    "Opening {0}://{1}:{2}",
                    sessionOptions.Protocol.ToString,
                    sessionOptions.HostName,
                    sessionOptions.PortNumber.ToString
                )

                ' Connect
                session.Open(sessionOptions)
                args.Colourise(ConsoleColor.Green, "OK")

            Catch ex As Exception
                args.Colourise(ConsoleColor.Red, "FAILED")
                Throw ex

            Finally
                Console.WriteLine()

            End Try

            Dim onSend As EventHandler = AddressOf hsend
            Dim onReceive As EventHandler = AddressOf hreceive

            For Each act As ftpconfigModeAct In _configMode.Act
                Select Case act.actType
                    Case eActType.send
                        If send Then _
                            onSend.Invoke(act, New ftpEventArgs(act, session))

                    Case Else
                        If receive Then _
                            onReceive.Invoke(act, New ftpEventArgs(act, session))

                End Select
            Next

        End Using

    End Sub

    Public Sub hsend(sender As ftpconfigModeSend, e As ftpEventArgs)

        Dim transferResult As TransferOperationResult

        ' Send outbound files                        
        If Not e.Dir.GetFiles(sender.filespec).Count > 0 Then
            Console.WriteLine("No files to upload.")

        Else
            args.line(
                "Sending {0} files",
                e.Dir.GetFiles(sender.filespec).Count.ToString
            )

            Try
                transferResult = e.session.PutFiles(
                    String.Format(
                        "{0}\{1}",
                        e.Dir.FullName,
                        sender.filespec
                    ),
                    sender.remotedir,
                    False,
                    transferOptions
                )

                ' Throw on any error
                transferResult.Check()
                args.Colourise(ConsoleColor.Green, "OK")

            Catch ex As Exception
                args.Colourise(ConsoleColor.Red, "FAILED")
                Throw ex

            Finally
                Console.WriteLine()

            End Try

            ' Move to save folder
            For Each transfer In transferResult.Transfers
                Dim tx As New FileInfo(transfer.FileName)

                Console.WriteLine(
                    String.Format(
                        " Uploaded file {0}.",
                        tx.Name
                    )
                )
                args.Log(
                    String.Format(
                        " Uploaded file {0}.",
                        tx.Name
                    )
                )
                File.Move(
                    transfer.FileName,
                    Path.Combine(
                        e.Save.FullName,
                        tx.Name
                    )
                )

            Next

        End If

    End Sub

    Public Sub hreceive(sender As ftpconfigModeReceive, e As ftpEventArgs)

#Region "Download files"

        Dim transferResult As TransferOperationResult
        ' Get inbound files
        Try
            args.line("Getting [/{0}/{1}]",
                sender.remotedir,
                sender.filespec
            )

            transferResult = e.session.GetFiles(
                Replace(
                    String.Format(
                        "/{0}/{1}",
                        sender.remotedir,
                        sender.filespec
                    ),
                "//", "/"),
                String.Format(
                    "{0}\",
                    e.Dir.FullName
                ),
                sender.delete,
                transferOptions
            )

            ' Throw on any error
            transferResult.Check()
            args.Colourise(ConsoleColor.Green, "OK")
            Console.WriteLine()

            Console.WriteLine(
                String.Format(
                    " {0} file(s) downloaded.",
                    transferResult.Transfers.Count
                )
            )

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, "FAILURE")
            Throw ex

        Finally
            Console.WriteLine("")

        End Try

#End Region

        For Each transfer In transferResult.Transfers
            Dim FN As New FileInfo(
                Path.Combine(
                    e.Dir.FullName,
                    New FileInfo(transfer.FileName).Name
                )
            )

            args.Log(
                String.Format(
                    "Downloaded file {0}.",
                    FN.FullName
                )
            )

            Using arch As New ArchiveFile(FN)
                Try
                    If sender.bin Is Nothing Then Throw New Exception(String.Format("No bin set."))

                    Select Case sender.isLexor
                        Case True
                            With _appEx.LexByAssemblyName(sender.bin)
                                Try
                                    Console.WriteLine(
                                            "Deserialising with [{0}].",
                                            New FileInfo(sender.bin).Name
                                        )
                                    Using sr As New StreamReader(FN.FullName)
                                        .Deserialise(sr, sender.environment)
                                        args.Colourise(ConsoleColor.Green, "OK")

                                    End Using

                                Catch ex As Exception
                                    Throw ex

                                Finally
                                    Console.WriteLine()

                                End Try


                            End With

                        Case Else
                            Try
                                args.line(
                                        "Executing {0} {1}.",
                                        New FileInfo(sender.bin).Name,
                                        FN.FullName.Replace(Directory.GetCurrentDirectory, "")
                                    )

                                Using myProcess As System.Diagnostics.Process = New System.Diagnostics.Process()
                                    With myProcess
                                        With .StartInfo
                                            .FileName = sender.bin
                                            .Arguments = String.Format("{0} {1}", FN.FullName, sender.environment)
                                            .WorkingDirectory = curdir.FullName
                                            .UseShellExecute = False
                                            .WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                                            .CreateNoWindow = True
                                            .RedirectStandardOutput = True

                                        End With

                                        .Start()
                                        Console.WriteLine(.StandardOutput.ReadToEnd)
                                        .WaitForExit()

                                        args.Colourise(ConsoleColor.Green, "OK")

                                    End With

                                End Using

                            Catch ex As Exception
                                args.Colourise(ConsoleColor.Red, "FAILED")
                                Throw ex

                            Finally
                                Console.WriteLine()

                            End Try

                    End Select

                Catch ex As Exception
                    Log(ex)
                    arch.badmail = True

                End Try

            End Using

        Next

    End Sub

#End Region

#Region "IDisposable Support"

    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
