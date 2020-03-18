Imports PriPROC6.Interface.oData
Imports System.Reflection

''' <summary>
'''
''' This code was generated by the Schema Utility.
'''
''' Form: TPAYMENT2 as List(Of rowTPAYMENT2)
''' Date: 21/01/2020
'''
''' </summary>
<oFormClass("rowTPAYMENT2")>
Public Class TPAYMENT2 : Inherits oForm

    ''' <summary>
    ''' TPAYMENT2 Constructor method.
    ''' </summary>
	''' <param name="Sender">The Assembly.GetExecutingAssembly of your project</param>
    ''' <param name="Parent">Optional: Parent oRow of this form</param>
    Sub New(byref Sender As Assembly, Optional Parent As oRow = Nothing)
        MyBase.New(Sender, Parent)

    End Sub

    ''' <summary>
    ''' Add a new row to the TPAYMENT2 form.
    ''' </summary>
    ''' <returns>rowTPAYMENT2</returns>
    Public Function AddRow() As rowTPAYMENT2
        With Me
            .Add(New rowTPAYMENT2(Me))
            Return .Last

        End With

    End Function

End Class

''' <summary>
''' Defines rows in the TPAYMENT2 form.
''' </summary>
<oRowClass("TPAYMENT2", "serialTPAYMENT2")>
Public Class rowTPAYMENT2 : Inherits oRow

    ''' <summary>
    ''' rowTPAYMENT2 Constructor method.
    ''' </summary>
    ''' <param name="Parent">Parent oForm of this row</param>
    Sub New(Parent As oForm)
        MyBase.New(Parent)

    End Sub
    
	''' <summary>
    ''' Get / Set the "Payment Code" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Payment Code", mandatory:=True, length:=3)>
    Public Property PAYMENTCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Means of Payment" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Means of Payment", ReadOnly:=True, length:=40)>
    Public Readonly Property PAYMENTNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "BkAcct/Credit Cd No." Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("BkAcct/Credit Cd No.", length:=34)>
    Public Property PAYACCOUNT As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Card's Expir. Date" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Card's Expir. Date", length:=5)>
    Public Property VALIDMONTH As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Payment Amount" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Payment Amount")>
    Public Property QPRICE As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Curr" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Curr", ReadOnly:=True, length:=3)>
    Public Readonly Property CODE As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Payment Terms Code" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Payment Terms Code", length:=3)>
    Public Property PAYCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Payment Terms" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Payment Terms", ReadOnly:=True, length:=24)>
    Public Readonly Property PAYDES As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "First Installment" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("First Installment")>
    Public Property FIRSTPAY As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Amt Each Add'l Paymt" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Amt Each Add'l Paymt", ReadOnly:=True)>
    Public Readonly Property OTHERPAYMENTS As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Star/Point Discount" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Star/Point Discount")>
    Public Property STARDISCOUNT As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Payment Linkage" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Payment Linkage", length:=2)>
    Public Property LINKCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Credit Card Slip" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Credit Card Slip", length:=16)>
    Public Property CARDNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Token ID" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Token ID", length:=40)>
    Public Property CCUID As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Details" Value of TPAYMENT2.
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
    ''' Get / Set the "Withheld Tax" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Withheld Tax")>
    Public Property WTAX As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Withheld Tax 2" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Withheld Tax 2")>
    Public Property WTAX2 As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Withheld Tax 3" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Withheld Tax 3")>
    Public Property WTAX3 As Decimal
        Get
            Return getProperty()
        End Get
        Set(value As Decimal)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Total" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Decimal</returns>	
    <oDataColumn("Total", ReadOnly:=True)>
    Public Readonly Property TOTPRICE As Decimal
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Installation Code" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Installation Code", length:=3)>
    Public Property SHVA_TERMINALNAME As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Credit Cd Confirm No" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Credit Cd Confirm No", length:=7)>
    Public Property CONFNUM As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Approved" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Approved", ReadOnly:=True, length:=1)>
    Public Readonly Property SHVAFLAG As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Cash Flow Code" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Cash Flow Code", length:=3)>
    Public Property CASHFLOWCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Payment Date" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Date</returns>	
    <oDataColumn("Payment Date", mandatory:=True)>
    Public Property PAYDATE As Date
        Get
            Return getProperty()
        End Get
        Set(value As Date)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Cust's Bank Code" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Cust's Bank Code", length:=8)>
    Public Property BANKCODE As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get the Read Only "Bank Name" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Bank Name", ReadOnly:=True, length:=56)>
    Public Readonly Property BANKNAME As String
        Get
            Return getProperty()
        End Get

    End Property
    
	''' <summary>
    ''' Get / Set the "Cust's Routing No." Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Cust's Routing No.", length:=20)>
    Public Property BRANCH As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Customer's BIC" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("Customer's BIC", length:=12)>
    Public Property BIC As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "EEA" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>String</returns>	
    <oDataColumn("EEA", length:=1)>
    Public Property EEAFLAG As String
        Get
            Return getProperty()
        End Get
        Set(value As String)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "SDD Mandate Number" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("SDD Mandate Number")>
    Public Property SEPADIRDEBNUM As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property
    
	''' <summary>
    ''' Get / Set the "Key Line" Value of TPAYMENT2.
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
    ''' Get / Set the "Payment (ID)" Value of TPAYMENT2.
    ''' </summary>
    ''' <returns>Integer</returns>	
    <oDataColumn("Payment (ID)")>
    Public Property PAYMENT As Integer
        Get
            Return getProperty()
        End Get
        Set(value As Integer)
            setProperty(value)
        End Set
    End Property


End Class

''' <summary>
''' A nullable version of rowTPAYMENT2.
'''
''' This is used to deserialise JSON data
''' and should not be instantiated directly.
''' </summary>
Public Class serialTPAYMENT2 

    Public Property PAYMENTCODE As String
    Public Property PAYMENTNAME As String
    Public Property PAYACCOUNT As String
    Public Property VALIDMONTH As String
    Public Property QPRICE As Decimal?
    Public Property CODE As String
    Public Property PAYCODE As String
    Public Property PAYDES As String
    Public Property FIRSTPAY As Decimal?
    Public Property OTHERPAYMENTS As Decimal?
    Public Property STARDISCOUNT As Decimal?
    Public Property LINKCODE As String
    Public Property CARDNUM As String
    Public Property CCUID As String
    Public Property DETAILS As String
    Public Property WTAX As Decimal?
    Public Property WTAX2 As Decimal?
    Public Property WTAX3 As Decimal?
    Public Property TOTPRICE As Decimal?
    Public Property SHVA_TERMINALNAME As String
    Public Property CONFNUM As String
    Public Property SHVAFLAG As String
    Public Property CASHFLOWCODE As String
    Public Property PAYDATE As Date?
    Public Property BANKCODE As String
    Public Property BANKNAME As String
    Public Property BRANCH As String
    Public Property BIC As String
    Public Property EEAFLAG As String
    Public Property SEPADIRDEBNUM As Integer?
    Public Property KLINE As Integer?
    Public Property PAYMENT As Integer?


End Class