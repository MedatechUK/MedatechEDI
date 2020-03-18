Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: DOCUMENTS_D as List(Of rowDOCUMENTS_D)
''' Date: 21/01/2020
'''
''' </summary>
<oFormClass("rowDOCUMENTS_D", "TRANSORDER_D", "DOCPACK", "SHIPTO2")>
Public Class DOCUMENTS_D : Inherits oForm

    ''' <summary>
    ''' DOCUMENTS_D Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the DOCUMENTS_D form.
    ''' </summary>
    ''' <returns>rowDOCUMENTS_D</returns>
    Public Function AddRow() As rowDOCUMENTS_D
        With Me
            .Add(New rowDOCUMENTS_D(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the DOCUMENTS_D form.
''' </summary>
<oRowClass("DOCUMENTS_D", "serialDOCUMENTS_D")>
Public Class rowDOCUMENTS_D : Inherits oRow

    ''' <summary>
    ''' rowDOCUMENTS_D Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get/set the TRANSORDER_D subform.
    ''' </summary>
    ''' <returns>TRANSORDER_D</returns>
	Public Property TRANSORDER_D As TRANSORDER_D
        Get
            Return MyBase.SubForms("TRANSORDER_D")
        End Get
        Set(value As TRANSORDER_D)
            MyBase.SubForms("TRANSORDER_D") = value
        End Set
    End Property    
	''' <summary>
    ''' Get/set the DOCPACK subform.
    ''' </summary>
    ''' <returns>DOCPACK</returns>
	Public Property DOCPACK As DOCPACK
        Get
            Return MyBase.SubForms("DOCPACK")
        End Get
        Set(value As DOCPACK)
            MyBase.SubForms("DOCPACK") = value
        End Set
    End Property    
	''' <summary>
    ''' Get/set the SHIPTO2 subform.
    ''' </summary>
    ''' <returns>SHIPTO2</returns>
	Public Property SHIPTO2 As SHIPTO2
        Get
            Return MyBase.SubForms("SHIPTO2")
        End Get
        Set(value As SHIPTO2)
            MyBase.SubForms("SHIPTO2") = value
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer Number", mandatory:=True, length:=16)>
    Public Property CUSTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer Name" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer Name", length:=48)>
    Public Property CDES As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Contact" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Contact", length:=37)>
    Public Property NAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Date" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Date", mandatory:=True)>
    Public Property CURDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Document" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Document", ReadOnly:=True, Key:=True, length:=16)>
    Public Readonly Property DOCNO As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Sales Rep Doc. No." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Sales Rep Doc. No.", length:=16)>
    Public Property BOOKNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Status" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Status", mandatory:=True, length:=12)>
    Public Property STATDES As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Assigned to" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Assigned to", mandatory:=True, length:=20)>
    Public Property OWNERLOGIN As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Order" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Order", length:=16)>
    Public Property ORDNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "RMA for Order" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("RMA for Order", ReadOnly:=True, length:=16)>
    Public Readonly Property ORDRMADOCNUM As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Details (Order)" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Details (Order)", ReadOnly:=True, length:=24)>
    Public Readonly Property ORDDETAILS As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Customer's Purch Ord" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer's Purch Ord", length:=15)>
    Public Property REFERENCE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Project Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Project Number", length:=16)>
    Public Property PROJDOCNO As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Project Description" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Project Description", ReadOnly:=True, length:=32)>
    Public Readonly Property PROJDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "RMA Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("RMA Number", length:=16)>
    Public Property RMADOCNO As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Price List Code" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Price List Code", length:=6)>
    Public Property PLNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Previous Shipmt Doc." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Previous Shipmt Doc.", length:=16)>
    Public Property PDOCNO As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Shipping Warehouse" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipping Warehouse", mandatory:=True, length:=4)>
    Public Property WARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bin", mandatory:=True, length:=14)>
    Public Property LOCNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Warehouse Descrip." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Warehouse Descrip.", ReadOnly:=True, length:=32)>
    Public Readonly Property WARHSDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "To Consignmt Warehs" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("To Consignmt Warehs", length:=4)>
    Public Property TOWARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bin", length:=14)>
    Public Property TOLOCNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Warehouse Descrip." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Warehouse Descrip.", ReadOnly:=True, length:=32)>
    Public Readonly Property TOWARHSDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Parent's Serial No." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Parent's Serial No.", length:=20)>
    Public Property PARENTSERNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Parent Part Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Parent Part Number", length:=15)>
    Public Property PARTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Part Description" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Part Description", ReadOnly:=True, length:=48)>
    Public Readonly Property PARTDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Truck No." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Truck No.", length:=12)>
    Public Property LORRYNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Shipper/Driver No." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipper/Driver No.", length:=8)>
    Public Property SHIPPERNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Shipper/Driver Name" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipper/Driver Name", ReadOnly:=True, length:=32)>
    Public Readonly Property SHIPPERDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Delivery Date" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Delivery Date")>
    Public Property DISTRDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Shipping Pallet" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipping Pallet", length:=16)>
    Public Property BOXNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Tracking Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Tracking Number", length:=20)>
    Public Property AIRWAYBILL As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Site" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Site", length:=4)>
    Public Property DCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Site Description" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Site Description", ReadOnly:=True, length:=32)>
    Public Readonly Property CODEDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Branch Code" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Branch Code", length:=6)>
    Public Property BRANCHNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Branch Name" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Branch Name", ReadOnly:=True, length:=32)>
    Public Readonly Property BRANCHDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Shipment Code" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipment Code", length:=2)>
    Public Property STCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Shipping Method" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipping Method", ReadOnly:=True, length:=6)>
    Public Readonly Property STDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Billable?" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Billable?", length:=1)>
    Public Property FLAG As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Billed" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Billed", ReadOnly:=True, length:=1)>
    Public Readonly Property IVALL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Printed" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Printed", ReadOnly:=True, length:=1)>
    Public Readonly Property PRINTEDBOOL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Bill of Lading?" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bill of Lading?", ReadOnly:=True, length:=1)>
    Public Readonly Property PL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Crate Type Code" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Crate Type Code", length:=2)>
    Public Property PACKCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Crate Type Desc." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Crate Type Desc.", ReadOnly:=True, length:=8)>
    Public Readonly Property PACKNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Manual Gross Weight" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Manual Gross Weight")>
    Public Property MWEIGHT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Auto Gross Weight" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Auto Gross Weight", ReadOnly:=True)>
    Public Readonly Property WEIGHT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Difference" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Difference", ReadOnly:=True)>
    Public Readonly Property WEIGHTDIFF As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Auto Net Weight" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Auto Net Weight", ReadOnly:=True)>
    Public Readonly Property NWEIGHT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Volume" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Volume", ReadOnly:=True)>
    Public Readonly Property VOLUME As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Unit" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Unit", ReadOnly:=True, length:=3)>
    Public Readonly Property VUNITNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Adjust Prices?" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Adjust Prices?", ReadOnly:=True, length:=1)>
    Public Readonly Property ADJPRICEFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Delay Inv-Next Month" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Delay Inv-Next Month", length:=1)>
    Public Property POSTPONEIV As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Separate Invoice?" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Separate Invoice?", length:=1)>
    Public Property POSTPONEIV2 As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Price Bef. Disc." Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Price Bef. Disc.", ReadOnly:=True)>
    Public Readonly Property QPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "% Overall Discount" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("% Overall Discount")>
    Public Property PERCENT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Price After Discount" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Price After Discount", ReadOnly:=True)>
    Public Readonly Property DISPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Sales Tax" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Sales Tax", ReadOnly:=True)>
    Public Readonly Property VAT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Final Price" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Final Price", ReadOnly:=True)>
    Public Readonly Property TOTPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Curr" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Curr", mandatory:=True, length:=3)>
    Public Property CODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Tax Code" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Tax Code", mandatory:=True, length:=8)>
    Public Property TAXCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Details" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Details", length:=24)>
    Public Property DETAILS As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Attachments?" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Attachments?", ReadOnly:=True, length:=1)>
    Public Readonly Property EXTFILEFLAGB As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Signature" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Signature", ReadOnly:=True, length:=20)>
    Public Readonly Property USERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Time Stamp" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Time Stamp", ReadOnly:=True)>
    Public Readonly Property UDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Sales Rep Number" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Sales Rep Number", length:=16)>
    Public Property AGENTCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Sales Rep Name" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Sales Rep Name", ReadOnly:=True, length:=32)>
    Public Readonly Property AGENTNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Qty of Items" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Qty of Items", ReadOnly:=True)>
    Public Readonly Property TOTQUANT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Number of Crates" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Number of Crates", ReadOnly:=True)>
    Public Readonly Property PACKNUM As Integer
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Tax Ref. - Portugal" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Tax Ref. - Portugal", ReadOnly:=True, length:=16)>
    Public Readonly Property IDCODEPT As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Print Part Attachmts" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Print Part Attachmts", length:=1)>
    Public Property INCPARTEXT As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Type" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Type", Key:=True, length:=1)>
    Public Property TYPE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Document (ID)" Value of DOCUMENTS_D.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Document (ID)")>
    Public Property DOC As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowDOCUMENTS_D.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialDOCUMENTS_D 

    Public Property CUSTNAME As String
    Public Property CDES As String
    Public Property NAME As String
    Public Property CURDATE As Date?
    Public Property DOCNO As String
    Public Property BOOKNUM As String
    Public Property STATDES As String
    Public Property OWNERLOGIN As String
    Public Property ORDNAME As String
    Public Property ORDRMADOCNUM As String
    Public Property ORDDETAILS As String
    Public Property REFERENCE As String
    Public Property PROJDOCNO As String
    Public Property PROJDES As String
    Public Property RMADOCNO As String
    Public Property PLNAME As String
    Public Property PDOCNO As String
    Public Property WARHSNAME As String
    Public Property LOCNAME As String
    Public Property WARHSDES As String
    Public Property TOWARHSNAME As String
    Public Property TOLOCNAME As String
    Public Property TOWARHSDES As String
    Public Property PARENTSERNUM As String
    Public Property PARTNAME As String
    Public Property PARTDES As String
    Public Property LORRYNUM As String
    Public Property SHIPPERNAME As String
    Public Property SHIPPERDES As String
    Public Property DISTRDATE As Date?
    Public Property BOXNUM As String
    Public Property AIRWAYBILL As String
    Public Property DCODE As String
    Public Property CODEDES As String
    Public Property BRANCHNAME As String
    Public Property BRANCHDES As String
    Public Property STCODE As String
    Public Property STDES As String
    Public Property FLAG As String
    Public Property IVALL As String
    Public Property PRINTEDBOOL As String
    Public Property PL As String
    Public Property PACKCODE As String
    Public Property PACKNAME As String
    Public Property MWEIGHT As Decimal?
    Public Property WEIGHT As Decimal?
    Public Property WEIGHTDIFF As Decimal?
    Public Property NWEIGHT As Decimal?
    Public Property VOLUME As Decimal?
    Public Property VUNITNAME As String
    Public Property ADJPRICEFLAG As String
    Public Property POSTPONEIV As String
    Public Property POSTPONEIV2 As String
    Public Property QPRICE As Decimal?
    Public Property PERCENT As Decimal?
    Public Property DISPRICE As Decimal?
    Public Property VAT As Decimal?
    Public Property TOTPRICE As Decimal?
    Public Property CODE As String
    Public Property TAXCODE As String
    Public Property DETAILS As String
    Public Property EXTFILEFLAGB As String
    Public Property USERLOGIN As String
    Public Property UDATE As Date?
    Public Property AGENTCODE As String
    Public Property AGENTNAME As String
    Public Property TOTQUANT As Decimal?
    Public Property PACKNUM As Integer?
    Public Property IDCODEPT As String
    Public Property INCPARTEXT As String
    Public Property TYPE As String
    Public Property DOC As Integer?


End Class