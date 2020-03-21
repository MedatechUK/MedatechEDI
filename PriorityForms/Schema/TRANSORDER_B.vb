Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: TRANSORDER_B as List(Of rowTRANSORDER_B)
''' Date: 20/03/2020
'''
''' </summary>
<oFormClass("rowTRANSORDER_B")>
Public Class TRANSORDER_B : Inherits oForm

    ''' <summary>
    ''' TRANSORDER_B Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the TRANSORDER_B form.
    ''' </summary>
    ''' <returns>rowTRANSORDER_B</returns>
    Public Function AddRow() As rowTRANSORDER_B
        With Me
            .Add(New rowTRANSORDER_B(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the TRANSORDER_B form.
''' </summary>
<oRowClass("TRANSORDER_B", "serialTRANSORDER_B")>
Public Class rowTRANSORDER_B : Inherits oRow

    ''' <summary>
    ''' rowTRANSORDER_B Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get / Set the "From Work Order" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("From Work Order", length:=22)>
    Public Property SERIALNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "To Work Order" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("To Work Order", length:=22)>
    Public Property TOSERIALNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Part Number" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Part Number", length:=15)>
    Public Property PARTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Part Revision No." Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Part Revision No.", length:=10)>
    Public Property REVNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "BOM Revision Number" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("BOM Revision Number", length:=3)>
    Public Property REVNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "From Operation" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("From Operation", length:=16)>
    Public Property ACTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "To Operation" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("To Operation", length:=16)>
    Public Property TOACTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Status" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Status", length:=16)>
    Public Property CUSTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Quantity" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Quantity")>
    Public Property QUANT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Unit" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Unit", length:=3)>
    Public Property UNITNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "From Warehouse" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("From Warehouse", length:=4)>
    Public Property WARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bin", length:=14)>
    Public Property LOCNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "To Warehouse" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("To Warehouse", length:=4)>
    Public Property TOWARHSNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Bin" Value of TRANSORDER_B.
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
    ''' Get / Set the "Key Line" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Key Line", Key:=True)>
    Public Property KLINE As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Transaction (ID)" Value of TRANSORDER_B.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Transaction (ID)")>
    Public Property TRANS As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Type" Value of TRANSORDER_B.
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
''' A nullable version of rowTRANSORDER_B.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialTRANSORDER_B 

    Public Property SERIALNAME As String
    Public Property TOSERIALNAME As String
    Public Property PARTNAME As String
    Public Property REVNAME As String
    Public Property REVNUM As String
    Public Property ACTNAME As String
    Public Property TOACTNAME As String
    Public Property CUSTNAME As String
    Public Property QUANT As Decimal?
    Public Property UNITNAME As String
    Public Property WARHSNAME As String
    Public Property LOCNAME As String
    Public Property TOWARHSNAME As String
    Public Property TOLOCNAME As String
    Public Property KLINE As Integer?
    Public Property TRANS As Integer?
    Public Property TYPE As String


End Class