Imports System.Text
Imports MedatechUK.Deserialiser
Imports MedatechUK.Logging

Module Module1

    Sub Main()

        Dim args As New MedatechUK.CLI.clArg
        Dim dstr As String = String.Format(
            "{0}{1}{2}",
            Right(DatePart(DateInterval.Year, Now), 2),
            DatePart(DateInterval.Month, Now),
            DatePart(DateInterval.Day, Now)
        )

        Using ex As New AppExtension(AddressOf logHandler)
            If Not String.Compare(New IO.FileInfo(Environment.GetCommandLineArgs(1)).Extension.ToLower, ".config") = 0 Then

                Dim lis As New Dictionary(Of Integer, String)
                lis.Add(0, "Cancel")
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

            Else

                With ex.LexByAssemblyName("MedatechUK.Deserialiser.lexdef")
                    Using l As moddef = New moddef(.Deserialise(New IO.StreamReader(Environment.GetCommandLineArgs(1))))

                        Console.Write(":RT = '' ;{0}:LN = :NL = :PARENT = :ATTEMPT = 0 ;{0}/* */{0}", vbCrLf)
                        Console.Write("LINK ZODAT_LINK TO :$.PAR ;{0}", vbCrLf)
                        Console.Write("GOTO {1}9999 WHERE :RETVAL = 0 ;{0}", vbCrLf, dstr)
                        Console.Write("/* */{0}SELECT PARENT{0}INTO :PARENT{0}FROM ZODAT_LINK{0}WHERE RECORDTYPE = '1'{0};{0}", vbCrLf)
                        Console.Write("SELECT MAX(ATTEMPT) + 1{0}INTO :ATTEMPT{0}FROM ZODAT_TRANS{0}WHERE LINE = :PARENT{0};{0}", vbCrLf)

                        Console.Write("SELECT SQL.TMPFILE{0}INTO :GEN FROM DUMMY;{0}LINK GENERALLOAD TO :GEN;{0}", vbCrLf)
                        Console.Write("GOTO {1}9999 WHERE :RETVAL = 0 {0};{0}", vbCrLf, dstr)

                        Console.Write("DECLARE E CURSOR FOR {0}SELECT LINE , RECORDTYPE {0}FROM ZODAT_LINK{0}WHERE 0=0{0}AND LINE > 0{0}AND LOADED = '' {0};{0}", vbCrLf)
                        Console.Write("OPEN E ;{0}GOTO {1}9 WHERE :RETVAL = 0 ;{0}LABEL {1}1;{0}", vbCrLf, dstr)
                        Console.Write("FETCH E INTO :LN , :RT ;{0}", vbCrLf)
                        Console.Write("GOTO {1}8 WHERE :RETVAL = 0 ;{0}", vbCrLf, dstr)

                        For Each r As Integer In l.RecordTypes.Keys
                            Console.Write(
                                "/* **{2}   {3} {2}*/{2}GOSUB {0}{1}00 WHERE :RT = '{1}' ;{2}",
                                dstr,
                                r.ToString,
                                vbCrLf,
                                l.RecordTypes(r)
                            )

                            Console.Write(
                                "GOTO {0}0{1}0 WHERE :RT <> '{1}' ;{2}",
                                dstr,
                                r.ToString,
                                vbCrLf)

                            Console.Write("SELECT 1 + MAX(LINE) INTO :NL FROM GENERALLOAD ;{0}", vbCrLf)
                            Console.Write("INSERT INTO GENERALLOAD {0}( RECORDTYPE , LINE ){0}VALUES ( '{1}' , :NL ){0};{0}", vbCrLf, r.ToString)
                            Console.Write("UPDATE GENERALLOAD SET {0}", vbCrLf)

                            For Each p As modrt In l.Props(r)
                                Console.Write(
                                    "{0} = {1}",
                                    p.DestName,
                                    p.VarName
                                )
                                Select Case String.Compare(p.VarName, l.Props(r).Last.VarName)
                                    Case 0
                                        Console.Write("{0}", vbCrLf)
                                    Case Else
                                        Console.Write(" , {0}", vbCrLf)
                                End Select
                            Next
                            Console.Write("WHERE LINE = :NL ;{0}", vbCrLf)

                            Console.Write(
                                "LABEL {0}0{1}0 ;{2}",
                                dstr,
                                r.ToString,
                                vbCrLf
                            )

                        Next

                        Console.Write("LOOP {1}1 ;{0}LABEL {1}8 ;{0}CLOSE E ;{0}LABEL {1}9 ;{0}", vbCrLf, dstr)
                        Console.Write("/* *** */{0}EXECUTE INTERFACE '[INTERFACE_NAME]', SQL.TMPFILE, '-L', :GEN{0};{0}", vbCrLf)
                        Console.Write("INSERT INTO ZODAT_ERR{0}(ATTEMPT , LOGTIME , LINE , PARENT , MESSAGE){0}SELECT :ATTEMPT , SQL.DATE, :LN, :PARENT, MESSAGE{0}FROM ERRMSGS{0}WHERE 0=0{0}AND TYPE ='i'{0}AND USER = SQL.USER {0};{0}", vbCrLf)
                        Console.Write("LABEL {1}9999 ;{0}END ; {0}", vbCrLf, dstr)


                        Console.Write("/* */{0}/* Subs */{0}/* */{0}", vbCrLf)
                        For Each r As Integer In l.RecordTypes.Keys
                            Console.WriteLine(
                                "/* **{3}   TYPE [{1}] - {2} {3}*/{3}SUB {0}{1}00 ; ",
                                dstr,
                                r.ToString,
                                l.RecordTypes(r),
                                vbCrLf
                            )

                            If l.Props(r, ptype.i).Count > 0 Then
                                For Each m As modrt In l.Props(r, ptype.i)
                                    Console.Write("{0} ={1}", m.VarName, vbCrLf)
                                Next
                                Console.Write("0 ;{0}", vbCrLf)
                            End If

                            If l.Props(r, ptype.r).Count > 0 Then
                                For Each m As modrt In l.Props(r, ptype.r)
                                    Console.Write("{0} ={1}", m.VarName, vbCrLf)
                                Next
                                Console.Write("0.0 ;{0}", vbCrLf)
                            End If

                            If l.Props(r, ptype.t).Count > 0 Then
                                For Each m As modrt In l.Props(r, ptype.t)
                                    Console.Write("{0} ={1}", m.VarName, vbCrLf)
                                Next
                                Console.Write("'' ;{0}", vbCrLf)
                            End If

                            Dim def_sql As New StringBuilder
                            def_sql.AppendFormat("SELECT{0}", vbCrLf)
                            For Each p In l.Props(r, ptype.all)
                                If Not String.Compare(p.Name, l.Props(r).Last.Name) = 0 Then
                                    def_sql.AppendFormat("  {0} , {1}", p.DestName, vbCrLf)
                                Else
                                    def_sql.AppendFormat("  {0} {1}", p.DestName, vbCrLf)
                                End If
                            Next

                            def_sql.AppendFormat("INTO {0}", vbCrLf)
                            For Each p In l.Props(r, ptype.all)
                                If Not String.Compare(p.Name, l.Props(r).Last.Name) = 0 Then
                                    def_sql.AppendFormat("  {0} , {1}", p.VarName, vbCrLf)
                                Else
                                    def_sql.AppendFormat("  {0} {1}", p.VarName, vbCrLf)
                                End If
                            Next

                            def_sql.AppendFormat("FROM ZODAT_LINK", vbCrLf)
                            def_sql.AppendFormat("{0}WHERE LINE = :LN ; {0}", vbCrLf)
                            Console.Write(def_sql.ToString)
                            Console.Write("RETURN ;{0}", vbCrLf)

                        Next

                    End Using
                End With

            End If

        End Using

        args.wait()

    End Sub

End Module
