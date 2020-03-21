Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: REVISIONS as List(Of rowREVISIONS)
''' Date: 20/03/2020
'''
''' </summary>
<oFormClass("rowREVISIONS")>
Public Class REVISIONS : Inherits oForm

    ''' <summary>
    ''' REVISIONS Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the REVISIONS form.
    ''' </summary>
    ''' <returns>rowREVISIONS</returns>
    Public Function AddRow() As rowREVISIONS
        With Me
            .Add(New rowREVISIONS(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the REVISIONS form.
''' </summary>
<oRowClass("REVISIONS", "serialREVISIONS")>
Public Class rowREVISIONS : Inherits oRow

    ''' <summary>
    ''' rowREVISIONS Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get / Set the "BOM Revision Number" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("BOM Revision Number", Key:=True, length:=3)>
    Public Property REVNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Description" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Description", length:=32)>
    Public Property REVDES As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Effect Date" Value of REVISIONS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Effect Date")>
    Public Property FROMDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "End Date" Value of REVISIONS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("End Date", ReadOnly:=True)>
    Public Readonly Property TILLDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Next Signature" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Next Signature", ReadOnly:=True, length:=20)>
    Public Readonly Property USERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Authorized" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Authorized", length:=1)>
    Public Property CONFIRMED As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "ECO Number" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("ECO Number", length:=16)>
    Public Property ECONUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "ECO Authorized" Value of REVISIONS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("ECO Authorized", ReadOnly:=True, length:=1)>
    Public Readonly Property UFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Part Revision No." Value of REVISIONS.
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
    ''' Get / Set the "Revision (ID)" Value of REVISIONS.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Revision (ID)")>
    Public Property REV As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowREVISIONS.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialREVISIONS 

    Public Property REVNUM As String
    Public Property REVDES As String
    Public Property FROMDATE As Date?
    Public Property TILLDATE As Date?
    Public Property USERLOGIN As String
    Public Property CONFIRMED As String
    Public Property ECONUM As String
    Public Property UFLAG As String
    Public Property REVNAME As String
    Public Property REV As Integer?


End Class