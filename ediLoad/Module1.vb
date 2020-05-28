Imports System.IO
Imports System.Net.Mail
Imports System.Reflection
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports MedatechUK.oData
Imports MedatechUK.CLI

Module Module1

    Public args As clArg
    Public configMode As Boolean = False
    Public dot As New Date(1988, 1, 1)

#Region "File references"

    Public ReadOnly Property ConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(Environment.CurrentDirectory, "load.config"))
        End Get
    End Property

    Public ReadOnly Property oDataConfigFile As FileInfo
        Get
            Return New FileInfo(Path.Combine(Environment.CurrentDirectory, "odata.config"))
        End Get
    End Property

    Private _Fileparam As FileInfo
    Public ReadOnly Property Fileparam As FileInfo
        Get
            Return _Fileparam
        End Get
    End Property

    Private Function MoveFolder(mv As String) As DirectoryInfo
        Return New DirectoryInfo(
            IO.Path.Combine(
               Directory.GetCurrentDirectory,
                String.Format(
                    "{0}\{1}",
                    mv,
                    Now.ToString("yyyy-MM")
                )
            )
        )

    End Function

#End Region

#Region "Properties"

    Private ReadOnly Property Deserialise As ashridge.Order
        Get
            Dim ret As ashridge.Order
            args.line("Deserialising {0}", Fileparam.FullName)
            If Not Fileparam.Exists Then
                args.Colourise(ConsoleColor.Green, "FAIL")
                Throw New Exception(String.Format("Input file not found {0}.", Fileparam.FullName))
            End If
            Try
                Using sr As New StreamReader(Fileparam.FullName)
                    ret = JsonConvert.DeserializeObject(sr.ReadToEnd, GetType(ashridge.Order))

                End Using
                args.Colourise(ConsoleColor.Green, "OK")
                Return ret

            Catch ex As Exception
                args.Colourise(ConsoleColor.Red, "FAIL")
                Throw ex

            Finally
                Console.WriteLine()

            End Try
        End Get
    End Property

    Private ReadOnly Property Config As loadconfig
        Get
            Dim ret As loadconfig
            Dim s As New XmlSerializer(GetType(loadconfig))
            args.line("Opening config {0}", ConfigFile.FullName)
            If Not ConfigFile.Exists And oDataConfigFile.Exists Then
                args.Colourise(ConsoleColor.Green, "FAIL")
                Throw New Exception(String.Format("Config files not found. Please -config.", ""))

            End If
            Try
                Using sr As New StreamReader(ConfigFile.FullName)
                    ret = s.Deserialize(sr)
                    args.Colourise(ConsoleColor.Green, "OK")
                    Return ret

                End Using

            Catch ex As Exception
                args.Colourise(ConsoleColor.Red, "FAIL")
                Throw ex

            End Try
        End Get
    End Property

#End Region

    Sub Main(arg() As String)

        Dim errNotify As ftpconfigNotifyerror
        Dim MoveTo As String = "sent"
        Dim id As String = System.Guid.NewGuid.ToString

        Try

#Region "Command Line args"

            args = New clArg()
            For Each k As String In args.Keys
                Select Case k.ToLower
                    Case "?", "help"
                        args.syntax()
                        args.wait()
                        End

                    Case "config"
                        If Not ConfigFile.Exists Then
                            Try
                                args.line(
                            "Creating {0}",
                            ConfigFile.FullName
                        )
                                Using sw As New StreamWriter(ConfigFile.FullName)
                                    sw.Write(My.Resources._default)

                                End Using
                                args.Colourise(ConsoleColor.Green, "OK")

                            Catch ex As Exception
                                args.Colourise(ConsoleColor.Green, "FAIL")
                                Throw ex

                            End Try

                        Else
                            Console.WriteLine("{0} already exists in {1}.", ConfigFile.Name, Path.GetDirectoryName(ConfigFile.FullName))

                        End If

                        If Not oDataConfigFile.Exists Then
                            Try
                                args.line(
                                "Creating {0}",
                                oDataConfigFile.FullName
                            )
                                Using sw As New StreamWriter(oDataConfigFile.FullName)
                                    sw.Write(My.Resources.odata)

                                End Using
                                args.Colourise(ConsoleColor.Green, "OK")

                            Catch ex As Exception
                                args.Colourise(ConsoleColor.Green, "FAIL")
                                Throw ex

                            End Try

                        Else
                            Console.WriteLine("{0} already exists in {1}.", oDataConfigFile.Name, Path.GetDirectoryName(oDataConfigFile.FullName))

                        End If

                        args.wait()
                        End

                End Select

            Next

            Try
                _Fileparam = New FileInfo(arg(0))

            Catch ex As Exception
                args.syntax()
                args.wait()
                End

            End Try


#End Region

            errNotify = Config.notifyerror
            Dim e As ashridge.Order = Deserialise

#Region "Create Customer record"

            Using F As New MedatechUK.oData.Loading("CST", AddressOf logHandler)
                With F
                    With .AddRow(1)

                        .RECORDTYPE = "1"
                        .TEXT1 = String.Format("C-{0}", Replace(e.billingaddress.company.ToUpper, " ", "").Substring(0, 5))
                        .TEXT2 = e.billingaddress.company
                        .TEXT5 = e.billingaddress.telephone
                        .TEXT6 = e.billingaddress.street1
                        .TEXT7 = e.billingaddress.street2
                        .TEXT8 = e.billingaddress.city
                        .TEXT9 = e.billingaddress.state
                        .TEXT10 = e.billingaddress.country
                        .TEXT11 = e.billingaddress.postCode
                        .TEXT12 = e.customer.email
                        .TEXT30 = e.payment_method.card_token

                    End With

                    With .AddRow(2)
                        .RECORDTYPE = "2"
                        .TEXT1 = e.customer.id
                        .TEXT2 = e.customer.group_id
                        .TEXT3 = e.customer.prefix
                        .TEXT4 = e.customer.firstName
                        .TEXT5 = e.customer.lastName
                        .TEXT6 = e.customer.email

                    End With

                    .Post()

                End With

            End Using

#End Region

            ' Create Order
            Using F As New MedatechUK.oData.Loading("ORD", AddressOf logHandler)
                With F
                    With .AddRow(1)

                        .TEXT1 = String.Format("C-{0}", Replace(e.billingaddress.company.ToUpper, " ", "").Substring(0, 5))
                        .TEXT2 = String.Format("{0} {1}", e.customer.lastName, e.customer.firstName)

                        .TEXT3 = e.order_id
                        .TEXT4 = e.reference_number
                        .TEXT5 = e.state
                        .TEXT6 = e.status
                        .TEXT7 = e.ashridge_ship_method
                        .TEXT8 = e.currency
                        .TEXT9 = e.discount_code

                        .TEXT28 = e.instruction_for_courier
                        .TEXT29 = e.message_for_ashridge
                        .TEXT30 = e.warehouse_special_note

                        .REAL1 = e.discount_amount
                        .REAL2 = e.shipping_amount
                        .REAL3 = e.subtotal
                        .REAL4 = e.grandtotal
                        .REAL5 = e.total_paid
                        .REAL6 = e.total_due
                        .REAL7 = e.total_refunded

                        .INT1 = DateDiff(DateInterval.Minute, dot, DateTime.Parse(e.created_at))

                    End With

                    With .AddRow(2)
                        .TEXT1 = e.shippingaddress.company
                        .TEXT2 = e.shippingaddress.prefix
                        .TEXT3 = String.Format("{0} {1}", e.shippingaddress.lastName, e.shippingaddress.firstName)
                        .TEXT5 = e.shippingaddress.telephone
                        .TEXT6 = e.shippingaddress.street1
                        .TEXT7 = e.shippingaddress.street2
                        .TEXT8 = e.shippingaddress.city
                        .TEXT9 = e.shippingaddress.state
                        .TEXT10 = e.shippingaddress.country
                        .TEXT11 = e.shippingaddress.postCode

                        .TEXT12 = e.shipping_method.title
                        .TEXT13 = e.shipping_method.currency
                        .REAL1 = e.shipping_method.amount

                    End With

                    For Each i As ashridge.orderitem In e.orderitems
                        With .AddRow(3)
                            .RECORDTYPE = "3"
                            .TEXT1 = i.name
                            .TEXT2 = i.sku
                            .TEXT3 = i.size
                            .REAL1 = i.discount
                            .REAL2 = i.discount_percent
                            .REAL3 = i.price
                            .INT1 = i.qty
                            .INT2 = DateDiff(DateInterval.Minute, dot, DateTime.Parse(e.delivery_at))
                            .REAL4 = i.subtotal
                            .REAL5 = i.tax
                            .REAL6 = i.tax_percent
                            .REAL7 = i.row_total

                        End With

                    Next

                    .Post()

                End With

            End Using

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, ex.Message)
            args.Log(ex.Message)
            MoveTo = "err"
            If Not errNotify Is Nothing Then
                Dim erMail = New MailMessage(errNotify.from, errNotify.notify(0).address)
                With erMail
                    With .CC
                        For i As Integer = 1 To errNotify.notify.Count - 1
                            .Add(errNotify.notify(i).address)
                        Next
                    End With
                    .Subject = "ediLoad runtime error."
                    .Body = ex.Message

                    Using c As New SmtpClient(errNotify.smtp)
                        c.Send(erMail)

                    End Using
                End With

            End If

        Finally
            With MoveFolder(MoveTo)
                If Not .Exists Then .Create()
                Fileparam.MoveTo(New FileInfo(Path.Combine(.FullName, String.Format("{0}.{1}", id, Fileparam.Extension))).FullName)

            End With
            args.wait()
            End

        End Try

    End Sub

    Private Sub ErCheck(f As oForm)
        For Each row As oRow In f
            If row.Exception Is Nothing Then
                For Each sf As oForm In row.SubForms.Values
                    ErCheck(sf)

                Next
            Else
                Throw row.Exception

            End If

        Next
    End Sub

    ''' <summary>
    ''' Handles oData logging.
    ''' oData events are fired into this method by instantiating the loading with 
    ''' an event handler.
    ''' </summary>
    ''' <param name="sender">The calling object</param>
    ''' <param name="e">The log arguments</param>
    Private Sub logHandler(sender As Object, e As LogArgs)
        args.Log(e.Message)

    End Sub

End Module
