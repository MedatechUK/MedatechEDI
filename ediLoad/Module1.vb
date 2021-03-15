Imports System.IO
Imports MedatechUK.oData
Imports MedatechUK.CLI

Module Module1

    Public args As clArg
    Public configMode As Boolean = False
    Public dot As New Date(1988, 1, 1)
    Public MoveTo As String = "sent"

#Region "File references"

    Private Fileparam As FileInfo

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

#End Region

    Sub Main(arg() As String)

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
                        args.Attempt(
                            AddressOf UnpackConfig,
                            New EventArgs(),
                            "Creating {0}",
                            ConfigFile.FullName
                        )

                        args.Attempt(
                            AddressOf UnpackoDataConfig,
                            New EventArgs(),
                            "Creating {0}",
                            oDataConfigFile.FullName
                        )

                        args.wait()
                        End

                End Select

            Next

            Try
                Fileparam = New FileInfo(arg(0))

            Catch ex As Exception
                args.syntax()
                args.wait()
                End

            End Try


#End Region

            Dim e As ashridge.Order = args.Deserial(Fileparam, GetType(ashridge.Order))

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

#Region "Create Order"

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

#End Region

        Catch ex As Exception
            args.Colourise(ConsoleColor.Red, ex.Message)
            Console.WriteLine()
            args.Log(ex.Message)
            MoveTo = "err"

            args.errNotify("EDI Load Failed.", ConfigFile, ex)

        Finally
            args.Attempt(AddressOf MoveFile, New EventArgs, "Moving {0} to {1}", Fileparam.Name, MoveTo)
            args.wait()
            End

        End Try

    End Sub

#Region "Handlers"

    ''' <summary>
    ''' Handles oData logging.
    ''' oData events are fired into this method by instantiating the loading with 
    ''' an event handler.
    ''' </summary>
    ''' <param name="sender">The calling object</param>
    ''' <param name="e">The log arguments</param>
    Private Sub logHandler(sender As Object, e As MedatechUK.)
        args.Log(e.Message)
        Console.WriteLine(e.Message)

    End Sub

    Private Sub UnpackConfig(sender As Object, e As EventArgs)
        If Not ConfigFile.Exists Then
            Using sw As New StreamWriter(ConfigFile.FullName)
                sw.Write(My.Resources._default)

            End Using

        Else
            Throw New Exception(
                String.Format(
                     "{0} already exists in {1}.",
                     ConfigFile.Name,
                     Path.GetDirectoryName(ConfigFile.FullName)
                )
            )

        End If

    End Sub

    Private Sub UnpackoDataConfig(sender As Object, e As EventArgs)
        If Not oDataConfigFile.Exists Then
            Using sw As New StreamWriter(ConfigFile.FullName)
                sw.Write(My.Resources._default)

            End Using

        Else
            Throw New Exception(
                String.Format(
                    "{0} already exists in {1}.",
                    oDataConfigFile.Name,
                    Path.GetDirectoryName(oDataConfigFile.FullName)
                )
            )

        End If

    End Sub

    Private Sub MoveFile(sender As Object, e As EventArgs)
        If Fileparam.Exists Then
            With args.DatedFolder(
                New DirectoryInfo(
                    Path.Combine(
                        Directory.GetCurrentDirectory,
                        MoveTo
                    )
                )
            )
                Fileparam.MoveTo(
                    New FileInfo(
                        Path.Combine(
                            .FullName,
                            String.Format(
                                "{0}.{1}",
                                Guid.NewGuid.ToString,
                                Fileparam.Extension
                            )
                        )
                    ).FullName
                )

            End With

        Else
            Throw New Exception(String.Format("File {0} not found.", Fileparam.Name))

        End If

    End Sub

#End Region

End Module
