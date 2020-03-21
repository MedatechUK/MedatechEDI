Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: ODAT_TRANS as List(Of rowODAT_TRANS)
''' Date: 20/03/2020
'''
''' </summary>
<oFormClass("rowODAT_TRANS", "ODAT_LOAD")>
Public Class ODAT_TRANS : Inherits oForm

    ''' <summary>
    ''' ODAT_TRANS Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(ByRef Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the ODAT_TRANS form.
    ''' </summary>
    ''' <returns>rowODAT_TRANS</returns>
    Public Function AddRow() As rowODAT_TRANS
        With Me
            .Add(New rowODAT_TRANS(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the ODAT_TRANS form.
''' </summary>
<oRowClass("ODAT_TRANS", "serialODAT_TRANS")>
Public Class rowODAT_TRANS : Inherits oRow

    ''' <summary>
    ''' rowODAT_TRANS Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub

    ''' <summary>
    ''' Get/set the ODAT_LOAD subform.
    ''' </summary>
    ''' <returns>ODAT_LOAD</returns>
    Public Property ODAT_LOAD As ODAT_LOAD
        Get
            Return MyBase.SubForms("ODAT_LOAD")
        End Get
        Set(value As ODAT_LOAD)
            MyBase.SubForms("ODAT_LOAD") = value
        End Set
    End Property

    ''' <summary>
    ''' Get / Set the "Type" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Type", length:=3)>
    Public Property TYPENAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Reference" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Reference", Key:=True, length:=50)>
    Public Property BUBBLEID As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Create Date" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Create Date", ReadOnly:=True)>
    Public Readonly Property CREATEDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Finished sending?" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Finished sending?", length:=1)>
    Public Property COMPLETE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Complete Date" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Complete Date", ReadOnly:=True)>
    Public Readonly Property COMPLETEDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Loaded?" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Loaded?", ReadOnly:=True, length:=1)>
    Public Readonly Property LOADED As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Load Date" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Load Date", ReadOnly:=True)>
    Public Readonly Property LOADDATE As Date
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Type (ID)" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Type (ID)", Key:=True)>
    Public Property LOADTYPE As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Ln" Value of ODAT_TRANS.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Ln")>
    Public Property LINE As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowODAT_TRANS.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialODAT_TRANS 

    Public Property TYPENAME As String
    Public Property BUBBLEID As String
    Public Property CREATEDATE As Date?
    Public Property COMPLETE As String
    Public Property COMPLETEDATE As Date?
    Public Property LOADED As String
    Public Property LOADDATE As Date?
    Public Property LOADTYPE As Integer?
    Public Property LINE As Integer?


End Class