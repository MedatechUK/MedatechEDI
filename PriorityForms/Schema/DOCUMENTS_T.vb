Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: DOCUMENTS_T as List(Of rowDOCUMENTS_T)
''' Date: 21/01/2020
'''
''' </summary>
<oFormClass("rowDOCUMENTS_T", "TRANSORDER_T", "DOCPACK")>
Public Class DOCUMENTS_T : Inherits oForm

    ''' <summary>
    ''' DOCUMENTS_T Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the DOCUMENTS_T form.
    ''' </summary>
    ''' <returns>rowDOCUMENTS_T</returns>
    Public Function AddRow() As rowDOCUMENTS_T
        With Me
            .Add(New rowDOCUMENTS_T(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the DOCUMENTS_T form.
''' </summary>
<oRowClass("DOCUMENTS_T", "serialDOCUMENTS_T")>
Public Class rowDOCUMENTS_T : Inherits oRow

    ''' <summary>
    ''' rowDOCUMENTS_T Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get/set the TRANSORDER_T subform.
    ''' </summary>
    ''' <returns>TRANSORDER_T</returns>
	Public Property TRANSORDER_T As TRANSORDER_T
        Get
            Return MyBase.SubForms("TRANSORDER_T")
        End Get
        Set(value As TRANSORDER_T)
            MyBase.SubForms("TRANSORDER_T") = value
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
    ''' Get / Set the "Date" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Document" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Document", ReadOnly:=True, Key:=True, length:=16)>
    Public Readonly Property DOCNO As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Sending Warehouse" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Sending Warehouse", mandatory:=True, length:=4)>
    Public Property WARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Warehouse Descrip." Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Warehouse Descrip.", ReadOnly:=True, length:=32)>
    Public Readonly Property WARHSDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Receiving Warehouse" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Receiving Warehouse", mandatory:=True, length:=4)>
    Public Property TOWARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bin", mandatory:=True, length:=14)>
    Public Property TOLOCNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Warehouse Descrip." Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Warehouse Descrip.", ReadOnly:=True, length:=32)>
    Public Readonly Property TOWARHSDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Project Number" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Project Description" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Project Description", ReadOnly:=True, length:=32)>
    Public Readonly Property PROJDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "External Doc. Number" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("External Doc. Number", length:=16)>
    Public Property BOOKNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Printed" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Printed", ReadOnly:=True, length:=1)>
    Public Readonly Property PRINTEDBOOL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Status" Value of DOCUMENTS_T.
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
    ''' Get / Set the "Assigned to" Value of DOCUMENTS_T.
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
    ''' Get / Set the "Source Document" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Source Document", length:=16)>
    Public Property PDOCNO As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Source Document Code" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Source Document Code", length:=4)>
    Public Property PDOCCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Order" Value of DOCUMENTS_T.
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
    ''' Get / Set the "Details" Value of DOCUMENTS_T.
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
    ''' Get / Set the "Shipment Code" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Shipping Method" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipping Method", ReadOnly:=True, length:=20)>
    Public Readonly Property STDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Shipper/Driver No." Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Shipper/Driver Name" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Shipper/Driver Name", ReadOnly:=True, length:=32)>
    Public Readonly Property SHIPPERDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Truck No." Value of DOCUMENTS_T.
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
    ''' Get / Set the "Branch Code" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Branch Name" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Branch Name", ReadOnly:=True, length:=32)>
    Public Readonly Property BRANCHDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Signature" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Signature", ReadOnly:=True, length:=20)>
    Public Readonly Property USERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Time Stamp" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Time Stamp", ReadOnly:=True)>
    Public Readonly Property UDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "RMA Number" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Qty of Items" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Qty of Items", ReadOnly:=True)>
    Public Readonly Property TOTQUANT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Delivery Date" Value of DOCUMENTS_T.
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
    ''' Get the Read Only "Auto Gross Weight" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Auto Gross Weight", ReadOnly:=True)>
    Public Readonly Property WEIGHT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Auto Net Weight" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Auto Net Weight")>
    Public Property NWEIGHT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Volume" Value of DOCUMENTS_T.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Volume")>
    Public Property VOLUME As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Document (ID)" Value of DOCUMENTS_T.
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
    
	''' <summary>
    ''' Get / Set the "Type" Value of DOCUMENTS_T.
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


End Class

''' <summary>
''' A nullable version of rowDOCUMENTS_T.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialDOCUMENTS_T 

    Public Property CURDATE As Date?
    Public Property DOCNO As String
    Public Property WARHSNAME As String
    Public Property LOCNAME As String
    Public Property WARHSDES As String
    Public Property TOWARHSNAME As String
    Public Property TOLOCNAME As String
    Public Property TOWARHSDES As String
    Public Property PROJDOCNO As String
    Public Property PROJDES As String
    Public Property BOOKNUM As String
    Public Property PRINTEDBOOL As String
    Public Property STATDES As String
    Public Property OWNERLOGIN As String
    Public Property PDOCNO As String
    Public Property PDOCCODE As String
    Public Property ORDNAME As String
    Public Property DETAILS As String
    Public Property STCODE As String
    Public Property STDES As String
    Public Property SHIPPERNAME As String
    Public Property SHIPPERDES As String
    Public Property LORRYNUM As String
    Public Property BRANCHNAME As String
    Public Property BRANCHDES As String
    Public Property USERLOGIN As String
    Public Property UDATE As Date?
    Public Property RMADOCNO As String
    Public Property TOTQUANT As Decimal?
    Public Property DISTRDATE As Date?
    Public Property WEIGHT As Decimal?
    Public Property NWEIGHT As Decimal?
    Public Property VOLUME As Decimal?
    Public Property DOC As Integer?
    Public Property TYPE As String


End Class