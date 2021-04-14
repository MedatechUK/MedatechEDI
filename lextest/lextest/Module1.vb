Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging

Module Module1

    Sub Main()

        Dim args As New MedatechUK.CLI.clArg
        Dim lis As New Dictionary(Of Integer, String)
        lis.Add(0, "Cancel")

        Using ex As New AppExtension(AddressOf logHandler)
            For Each assm As String In ex.LoadedAssemblies
                lis.Add(lis.Count, assm)
            Next
            For Each l As Integer In lis.Keys
                Console.WriteLine("{0} ... {1}", l, lis(l))
            Next

            Dim x As ConsoleKeyInfo = Console.ReadKey
            Select Case x.KeyChar
                Case "0"
                    Console.WriteLine("Cancelling.")

                Case Else
                    With ex.LexByAssemblyName(lis(CInt(x.KeyChar.ToString)))
                        .Deserialise(New IO.StreamReader(Environment.GetCommandLineArgs(1)), "")

                    End With

            End Select

        End Using

        args.wait()

    End Sub

End Module
