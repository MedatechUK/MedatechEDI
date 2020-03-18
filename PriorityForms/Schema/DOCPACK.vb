Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: DOCPACK as List(Of rowDOCPACK)
''' Date: 21/01/2020
'''
''' </summary>
<oFormClass("rowDOCPACK")>
Public Class DOCPACK : Inherits oForm

    ''' <summary>
    ''' DOCPACK Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the DOCPACK form.
    ''' </summary>
    ''' <returns>rowDOCPACK</returns>
    Public Function AddRow() As rowDOCPACK
        With Me
            .Add(New rowDOCPACK(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the DOCPACK form.
''' </summary>
<oRowClass("DOCPACK", "serialDOCPACK")>
Public Class rowDOCPACK : Inherits oRow

    ''' <summary>
    ''' rowDOCPACK Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get / Set the "Packing Slip Number" Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Packing Slip Number", length:=16)>
    Public Property DOCNO As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "External Slip No." Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("External Slip No.", length:=16)>
    Public Property BOOKNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Date" Value of DOCPACK.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Date", ReadOnly:=True)>
    Public Readonly Property CURDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Order" Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Order", ReadOnly:=True, length:=16)>
    Public Readonly Property ORDNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Customer's Purch Ord" Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer's Purch Ord", ReadOnly:=True, length:=15)>
    Public Readonly Property REFERENCE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Manual Gross Weight" Value of DOCPACK.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Manual Gross Weight", ReadOnly:=True)>
    Public Readonly Property MWEIGHT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Crate Type Code" Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Crate Type Code", ReadOnly:=True, length:=2)>
    Public Readonly Property PACKCODE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Crate Type Desc." Value of DOCPACK.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Crate Type Desc.", ReadOnly:=True, length:=8)>
    Public Readonly Property PACKNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Crate (ID)" Value of DOCPACK.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Crate (ID)", Key:=True)>
    Public Property PACK As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowDOCPACK.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialDOCPACK 

    Public Property DOCNO As String
    Public Property BOOKNUM As String
    Public Property CURDATE As Date?
    Public Property ORDNAME As String
    Public Property REFERENCE As String
    Public Property MWEIGHT As Decimal?
    Public Property PACKCODE As String
    Public Property PACKNAME As String
    Public Property PACK As Integer?


End Class