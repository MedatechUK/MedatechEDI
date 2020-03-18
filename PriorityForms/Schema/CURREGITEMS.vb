Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: CURREGITEMS as List(Of rowCURREGITEMS)
''' Date: 21/01/2020
'''
''' </summary>
<oFormClass("rowCURREGITEMS")>
Public Class CURREGITEMS : Inherits oForm

    ''' <summary>
    ''' CURREGITEMS Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the CURREGITEMS form.
    ''' </summary>
    ''' <returns>rowCURREGITEMS</returns>
    Public Function AddRow() As rowCURREGITEMS
        With Me
            .Add(New rowCURREGITEMS(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the CURREGITEMS form.
''' </summary>
<oRowClass("CURREGITEMS", "serialCURREGITEMS")>
Public Class rowCURREGITEMS : Inherits oRow

    ''' <summary>
    ''' rowCURREGITEMS Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub

    ''' <summary>
    ''' Get the Read Only "Curr" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Curr", key:=True, length:=3)>
    Public Property CODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property

    ''' <summary>
    ''' Get the Read Only "Currency Name" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Currency Name", ReadOnly:=True, length:=20)>
    Public Readonly Property NAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Exchange Rate" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Exchange Rate", mandatory:=True)>
    Public Property EXCHANGE As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Cross Rate" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Cross Rate")>
    Public Property CROSSEXCH As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Multiple Of" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Multiple Of", ReadOnly:=True)>
    Public Readonly Property EXCHQUANT As Integer
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Current Rate" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Current Rate", ReadOnly:=True)>
    Public Readonly Property CEXCHANGE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Current Exch. Date" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Current Exch. Date", ReadOnly:=True)>
    Public Readonly Property EXCHDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Recorded by" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Recorded by", ReadOnly:=True, length:=20)>
    Public Readonly Property USERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Time Stamp" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Time Stamp", ReadOnly:=True)>
    Public Readonly Property SDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Currency (ID)" Value of CURREGITEMS.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Currency (ID)")>
    Public Property CURR2 As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowCURREGITEMS.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialCURREGITEMS 

    Public Property CODE As String
    Public Property NAME As String
    Public Property EXCHANGE As Decimal?
    Public Property CROSSEXCH As Decimal?
    Public Property EXCHQUANT As Integer?
    Public Property CEXCHANGE As Decimal?
    Public Property EXCHDATE As Date?
    Public Property USERLOGIN As String
    Public Property SDATE As Date?
    Public Property CURR2 As Integer?


End Class