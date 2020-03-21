Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: TINVOICES as List(Of rowTINVOICES)
''' Date: 20/03/2020
'''
''' </summary>
<oFormClass("rowTINVOICES", "TPAYMENT2")>
Public Class TINVOICES : Inherits oForm

    ''' <summary>
    ''' TINVOICES Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the TINVOICES form.
    ''' </summary>
    ''' <returns>rowTINVOICES</returns>
    Public Function AddRow() As rowTINVOICES
        With Me
            .Add(New rowTINVOICES(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the TINVOICES form.
''' </summary>
<oRowClass("TINVOICES", "serialTINVOICES")>
Public Class rowTINVOICES : Inherits oRow

    ''' <summary>
    ''' rowTINVOICES Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get/set the TPAYMENT2 subform.
    ''' </summary>
    ''' <returns>TPAYMENT2</returns>
	Public Property TPAYMENT2 As TPAYMENT2
        Get
            Return MyBase.SubForms("TPAYMENT2")
        End Get
        Set(value As TPAYMENT2)
            MyBase.SubForms("TPAYMENT2") = value
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer's Account" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer's Account", mandatory:=True, length:=16)>
    Public Property ACCNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer/Acct Name" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer/Acct Name", length:=48)>
    Public Property CDES As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Contact" Value of TINVOICES.
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
    ''' Get / Set the "Cashier" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Cashier", mandatory:=True, length:=20)>
    Public Property CASHNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Date" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Date", mandatory:=True)>
    Public Property IVDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Receipt Number" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Receipt Number", ReadOnly:=True, Key:=True, length:=16)>
    Public Readonly Property IVNUM As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Final" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Final", ReadOnly:=True, length:=1)>
    Public Readonly Property FINAL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Status" Value of TINVOICES.
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
    ''' Get / Set the "Assigned to" Value of TINVOICES.
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
    ''' Get the Read Only "Invoice Sum" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Invoice Sum", ReadOnly:=True)>
    Public Readonly Property QPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Early Payment Disc." Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Early Payment Disc.", ReadOnly:=True)>
    Public Readonly Property DISCOUNT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Payment Amount" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Payment Amount", ReadOnly:=True)>
    Public Readonly Property DISPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Receipt Total" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Receipt Total", ReadOnly:=True)>
    Public Readonly Property TOTPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Difference" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Difference", ReadOnly:=True)>
    Public Readonly Property DIFF As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Sales Rep Doc. No." Value of TINVOICES.
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
    ''' Get / Set the "For Order" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("For Order", length:=16)>
    Public Property ORDNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer's Purch Ord" Value of TINVOICES.
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
    ''' Get the Read Only "Type of Sale (Code)" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Type of Sale (Code)", ReadOnly:=True, length:=3)>
    Public Readonly Property TYPECODE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Type of Sale-Descrip" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Type of Sale-Descrip", ReadOnly:=True, length:=12)>
    Public Readonly Property TYPEDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Project Number" Value of TINVOICES.
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
    ''' Get the Read Only "Project Description" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Project Description", ReadOnly:=True, length:=32)>
    Public Readonly Property PROJDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Cash Receipts" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Cash Receipts")>
    Public Property CASHPAYMENT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Copy to J. Entry?" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Copy to J. Entry?", length:=1)>
    Public Property FNCITEMSFLAG As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Pay Pro Forma Debt?" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Pay Pro Forma Debt?", length:=1)>
    Public Property PROFORMAFLAG As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Total Receipts" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Total Receipts", ReadOnly:=True)>
    Public Readonly Property AFTERWTAX As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Taxes Withheld" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Taxes Withheld", ReadOnly:=True)>
    Public Readonly Property WTAX As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "% Tax" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("% Tax", ReadOnly:=True)>
    Public Readonly Property WTAXPERCENT As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Curr" Value of TINVOICES.
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
    ''' Get / Set the "Details" Value of TINVOICES.
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
    ''' Get the Read Only "Printed" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Printed", ReadOnly:=True, length:=1)>
    Public Readonly Property PRINTEDBOOL As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Payment Date (Avg)" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Payment Date (Avg)")>
    Public Property PAYDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Invoice Date (Avg)" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Invoice Date (Avg)", ReadOnly:=True, length:=8)>
    Public Readonly Property AVRGDATE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Link to Invoice Date" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Link to Invoice Date", length:=1)>
    Public Property ADJPRICEFLAG As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Sales Rep Number" Value of TINVOICES.
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
    ''' Get the Read Only "Sales Rep Name" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Sales Rep Name", ReadOnly:=True, length:=32)>
    Public Readonly Property AGENTNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Entry Code" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Entry Code", mandatory:=True, length:=5)>
    Public Property FNCPATNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Journal Entry No." Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Journal Entry No.", ReadOnly:=True, length:=8)>
    Public Readonly Property FNCNUM As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Canceled?" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Canceled?", ReadOnly:=True, length:=1)>
    Public Readonly Property STORNOFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Branch Code" Value of TINVOICES.
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
    ''' Get / Set the "Customer Number" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer Number", length:=16)>
    Public Property CUSTNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Cust. Group Code" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Cust. Group Code", ReadOnly:=True, length:=2)>
    Public Readonly Property CTYPECODE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Group Description" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Group Description", ReadOnly:=True, length:=24)>
    Public Readonly Property CTYPENAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Attachments?" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Attachments?", ReadOnly:=True, length:=1)>
    Public Readonly Property EXTFILEFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get the Read Only "Billing Follow-up By" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Billing Follow-up By", ReadOnly:=True, length:=20)>
    Public Readonly Property BILLINGUSERLOGIN As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Add'l Class Code" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Add'l Class Code", length:=8)>
    Public Property IVCODENAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Add'l Classification" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Add'l Classification", ReadOnly:=True, length:=32)>
    Public Readonly Property IVCODEDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Debit/Credit" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Debit/Credit", Key:=True, length:=1)>
    Public Property DEBIT As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Invoice (ID)" Value of TINVOICES.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Invoice (ID)")>
    Public Property FOLLOWUPIV As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Type" Value of TINVOICES.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Type", Key:=True, length:=1)>
    Public Property IVTYPE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowTINVOICES.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialTINVOICES 

    Public Property ACCNAME As String
    Public Property CDES As String
    Public Property NAME As String
    Public Property CASHNAME As String
    Public Property IVDATE As Date?
    Public Property IVNUM As String
    Public Property FINAL As String
    Public Property STATDES As String
    Public Property OWNERLOGIN As String
    Public Property QPRICE As Decimal?
    Public Property DISCOUNT As Decimal?
    Public Property DISPRICE As Decimal?
    Public Property TOTPRICE As Decimal?
    Public Property DIFF As Decimal?
    Public Property BOOKNUM As String
    Public Property ORDNAME As String
    Public Property REFERENCE As String
    Public Property TYPECODE As String
    Public Property TYPEDES As String
    Public Property PROJDOCNO As String
    Public Property PROJDES As String
    Public Property CASHPAYMENT As Decimal?
    Public Property FNCITEMSFLAG As String
    Public Property PROFORMAFLAG As String
    Public Property AFTERWTAX As Decimal?
    Public Property WTAX As Decimal?
    Public Property WTAXPERCENT As Decimal?
    Public Property CODE As String
    Public Property DETAILS As String
    Public Property PRINTEDBOOL As String
    Public Property PAYDATE As Date?
    Public Property AVRGDATE As String
    Public Property ADJPRICEFLAG As String
    Public Property AGENTCODE As String
    Public Property AGENTNAME As String
    Public Property FNCPATNAME As String
    Public Property FNCNUM As String
    Public Property STORNOFLAG As String
    Public Property BRANCHNAME As String
    Public Property CUSTNAME As String
    Public Property CTYPECODE As String
    Public Property CTYPENAME As String
    Public Property EXTFILEFLAG As String
    Public Property BILLINGUSERLOGIN As String
    Public Property IVCODENAME As String
    Public Property IVCODEDES As String
    Public Property DEBIT As String
    Public Property FOLLOWUPIV As Integer?
    Public Property IVTYPE As String


End Class