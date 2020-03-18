Imports System.IO
Imports System.Reflection
Imports Newtonsoft.Json

Module Module1

    Public args As clArg
    Public configMode As Boolean = False

    Sub Main(arg() As String)

        Try
            args = New clArg(arg)
            For Each k As String In args.Keys
                Select Case k.ToLower
                    Case "?", "help"
                        args.syntax()
                        args.wait()

                    Case "config"
                        configMode = True

                End Select

            Next

            If Not New FileInfo(arg(0)).Exists Then _
                Throw New Exception(String.Format("File not found {0}.", args(1)))

            Dim e As ashridge.Order
            args.line("Deserialising {0}", arg(0))
            Using sr As New StreamReader(arg(0))
                Try
                    e = JsonConvert.DeserializeObject(sr.ReadToEnd, GetType(ashridge.Order))

                Catch ex As Exception
                    args.Colourise(ConsoleColor.Green, "FAIL")
                    Throw New Exception(String.Format("Invalid data in {0}.", arg(0)))

                End Try

            End Using


            Using F As New PriBase.PART(
                Assembly.Load(
                    "PriBase"
                )
            )
                With F
                    With .AddRow()
                        e.

                    End With

                    .Post()

                End With

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        Finally
            args.wait()

        End Try

    End Sub

End Module
