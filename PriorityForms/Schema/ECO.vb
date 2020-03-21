Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: ECO as List(Of rowECO)
''' Date: 20/03/2020
'''
''' </summary>
<oFormClass("rowECO", "ECOPART")>
Public Class ECO : Inherits oForm

    ''' <summary>
    ''' ECO Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the ECO form.
    ''' </summary>
    ''' <returns>rowECO</returns>
    Public Function AddRow() As rowECO
        With Me
            .Add(New rowECO(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the ECO form.
''' </summary>
<oRowClass("ECO", "serialECO")>
Public Class rowECO : Inherits oRow

    ''' <summary>
    ''' rowECO Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get/set the ECOPART subform.
    ''' </summary>
    ''' <returns>ECOPART</returns>
	Public Property ECOPART As ECOPART
        Get
            Return MyBase.SubForms("ECOPART")
        End Get
        Set(value As ECOPART)
            MyBase.SubForms("ECOPART") = value
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Date" Value of ECO.
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
    ''' Get / Set the "ECO Number" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("ECO Number", Key:=True, mandatory:=True, length:=16)>
    Public Property ECONUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Details" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Details", length:=32)>
    Public Property DETAILS As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Authorized?" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Authorized?", ReadOnly:=True, length:=1)>
    Public Readonly Property UFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Next Signature" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Next Signature", ReadOnly:=True, length:=20)>
    Public Readonly Property USERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Initiator of Change" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Initiator of Change", length:=20)>
    Public Property IUSERLOGIN As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Status" Value of ECO.
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
    ''' Get / Set the "Assigned to" Value of ECO.
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
    ''' Get / Set the "Reason Code" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Reason Code", length:=3)>
    Public Property ECOREASONCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Reason for ECO" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Reason for ECO", ReadOnly:=True, length:=32)>
    Public Readonly Property ECOREASONDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Attachments?" Value of ECO.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Attachments?", ReadOnly:=True, length:=1)>
    Public Readonly Property EXTFILEFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "ECO Number (ID)" Value of ECO.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("ECO Number (ID)")>
    Public Property ECO As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowECO.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialECO 

    Public Property CURDATE As Date?
    Public Property ECONUM As String
    Public Property DETAILS As String
    Public Property UFLAG As String
    Public Property USERLOGIN As String
    Public Property IUSERLOGIN As String
    Public Property STATDES As String
    Public Property OWNERLOGIN As String
    Public Property ECOREASONCODE As String
    Public Property ECOREASONDES As String
    Public Property EXTFILEFLAG As String
    Public Property ECO As Integer?


End Class