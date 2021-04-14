﻿Imports System.IO
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports MedatechUK.Deserialiser

Public Class RunBatSvc
    Inherits MedatechUK.ntService

    Private processing As New List(Of String)

    Sub New()

        MyBase.New(AddressOf MedatechUK.Logging.Events.logHandler)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private _appEx As AppExtension
    Private ReadOnly Property _config As runbatconfig
        Get
            With _appEx.LexByAssemblyName(GetType(runbatconfig).FullName)
                Return .Deserialise(New StreamReader(ConfigFile.FullName))
            End With
        End Get

    End Property

#Region "Config file"

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

#End Region

#Region "Override Service Methods"

    Overrides Sub svcStart(ByVal args As Dictionary(Of String, String))

        Try
            If _appEx Is Nothing Then _
                _appEx = New AppExtension(Me.logHandler)

            Log("Starting...")

#Region "Make config file"

            If Not ConfigFile.Exists Then
                Using c As New runbatconfig
                    With c
                        .loc.Add(New runbatconfigLoc("c:\out", "", "demo"))
                    End With
                    toFile(c)
                End Using
            End If

#End Region

            For Each loc As runbatconfigLoc In _config.loc
                If (loc.bin.Length > 0) And (loc.path.Length > 0) Then
                    With New DirectoryInfo(loc.path)
                        If Not .Exists Then
                            Log("Monitor folder [{0}] missing.", .FullName)

                        Else
                            ' Validate binaries                                
                            For Each l As Lazy(Of ILexor, ILexorProps) In _appEx.Lexors
                                If String.Compare(l.Metadata.SerialType.FullName, loc.bin, True) = 0 Then
                                    loc.isLexor = True
                                    Exit For
                                End If
                            Next

                            If loc.isLexor Or New FileInfo(loc.bin).Exists Then
                                Dim fsw As New FileSystemWatcher
                                With fsw
                                    AddHandler .Created, AddressOf fsw_Created
                                    .Path = loc.path
                                    .IncludeSubdirectories = False
                                    .EnableRaisingEvents = True
                                    If Not loc.filetype Is Nothing Then .Filter = loc.filetype

                                End With
                                Log("Monitoring folder [{0}].", .FullName)

                            Else
                                Log("Executable not found: [{0}]", loc.bin)

                            End If

                        End If
                    End With
                End If
            Next

        Catch ex As Exception
            Log(ex.Message)
            End

        End Try

    End Sub

#End Region

#Region "FileSystemWatcher Handler"

    Private Sub fsw_Created(ByVal sender As Object, ByVal e As FileSystemEventArgs)

        If Not processing.Contains(e.FullPath) Then
            processing.Add(e.FullPath)
            With New Thread(AddressOf hLoad)
                .Name = e.FullPath
                .Start(e)

            End With

        End If

    End Sub

#End Region

#Region "Threads"

    Private Sub hLoad(ByVal e As FileSystemEventArgs)

        Using Arch As New ArchiveFile(New FileInfo(e.FullPath))

            Try
                Threading.Thread.Sleep(1000)
                While IsFileInUse(e.FullPath)
                    Threading.Thread.Sleep(500)

                End While

                Dim dir As New DirectoryInfo(New FileInfo(e.FullPath).DirectoryName)
                For Each loc As runbatconfigLoc In _config.loc
                    Dim testdir As New DirectoryInfo(loc.path)
                    If Path.GetFullPath(testdir.FullName).Equals(Path.GetFullPath(dir.FullName)) Then
                        ' Validate binaries      
                        Dim f As Boolean = False
                        For Each l As Lazy(Of ILexor, ILexorProps) In _appEx.Lexors
                            If String.Compare(l.Metadata.SerialType.FullName, loc.bin, True) = 0 Then
                                With _appEx.LexByAssemblyName(loc.bin)
                                    Using sr As New StreamReader(e.FullPath)
                                        .Deserialise(sr, loc.environment)

                                    End Using
                                End With
                                f = True
                                Exit For
                            End If
                        Next

                        If Not f Then
                            With New Process
                                With .StartInfo
                                    .UseShellExecute = False
                                    .WorkingDirectory = New FileInfo(loc.bin).Directory.FullName
                                    .FileName = loc.bin
                                    .Arguments = Chr(34) & e.FullPath & Chr(34) & Chr(32) & loc.environment
                                    .RedirectStandardOutput = True
                                    .RedirectStandardError = True

                                End With

                                AddHandler .OutputDataReceived, AddressOf hLogShell
                                AddHandler .ErrorDataReceived, AddressOf hLogShell

                                .Start()
                                .BeginErrorReadLine()
                                .BeginOutputReadLine()

                                While Not .HasExited And .Responding
                                    Thread.Sleep(100)

                                End While

                            End With

                        End If
                        Exit For

                    End If
                Next

            Catch ex As Exception
                Log(ex.Message)
                Arch.badmail = True

            Finally
                processing.Remove(e.FullPath)

            End Try

        End Using

    End Sub

    Private Sub hLogShell(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If Not e.Data Is Nothing Then Log(e.Data)

    End Sub

    Private Function IsFileInUse(sFile As String) As Boolean
        Try
            If Not New FileInfo(sFile).Exists Then Return False
            Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            End Using

        Catch Ex As Exception
            Return True

        End Try
        Return False

    End Function

#End Region

End Class