Imports System.ComponentModel.Composition
Imports MedatechUK.Deserialiser

<Export(GetType(ILexor))>
<ExportMetadata("LexName", "Seeburger.Orders")>
<ExportMetadata("LexVers", "1.0")>
<ExportMetadata("Parser", eParser.xml)>
<ExportMetadata("SerialType", GetType(Seeburger.Orders))>
<ExportMetadata("LoadType", "ORD")>
Public Class Order
    Inherits Lexor
    Implements ILexor

End Class

#Region "Date classes"

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
Partial Public Class dmy

    Private ddField As String

    Private mmField As String

    Private yyField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, DataType:="integer")>
    Public Property DD() As String
        Get
            Return Me.ddField
        End Get
        Set
            Me.ddField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, DataType:="integer")>
    Public Property MM() As String
        Get
            Return Me.mmField
        End Get
        Set
            Me.mmField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, DataType:="integer")>
    Public Property YY() As String
        Get
            Return Right(Left(DatePart(DateInterval.Year, Now()), 2) & Me.yyField, 4)
        End Get
        Set
            Me.yyField = Value
        End Set
    End Property

End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
Partial Public Class wky

    Private wwField As String

    Private yyField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, DataType:="integer")>
    Public Property WW() As String
        Get
            Return Me.wwField
        End Get
        Set
            Me.wwField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified, DataType:="integer")>
    Public Property YY() As String
        Get
            Return Right(Left(DatePart(DateInterval.Year, Now()), 2) & Me.yyField, 4)
        End Get
        Set
            Me.yyField = Value
        End Set
    End Property

End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
Partial Public Class due

    Private itemField As Object

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("dmy", GetType(dmy)),
System.Xml.Serialization.XmlElementAttribute("wky", GetType(wky))>
    Public Property Item() As Object
        Get
            Return Me.itemField
        End Get
        Set
            Me.itemField = Value
        End Set
    End Property

End Class

#End Region

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
<MedatechUK.Deserialiser.Class(EnumerateOnly:=True)>
Partial Public Class Orders

    Private orderField As New List(Of OrdersOrder)

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("Order")>
    Public Property Order As List(Of OrdersOrder)
        Get
            Return Me.orderField
        End Get
        Set
            Me.orderField = Value
        End Set
    End Property

End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class OrdersOrder

    Private itemField As New List(Of OrdersOrderItem)

    Private custField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute("item")>
    Public Property item As List(Of OrdersOrderItem)
        Get
            Return Me.itemField
        End Get
        Set
            Me.itemField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Cust() As String
        Get
            Return Me.custField
        End Get
        Set
            Me.custField = Value
        End Set
    End Property

End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
System.SerializableAttribute(),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code"),
System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class OrdersOrderItem

    Private LineField As Integer

    Private OperationField As String

    Private dueField As due

    Private partField As String

    Private qtyField As Integer

    Private siteField As String

    Private poField As String

    Private deptcodefield As String

    Private buycodefield As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Line() As Integer
        Get
            Return Me.LineField
        End Get
        Set
            Me.LineField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Operation() As String
        Get
            Return Me.OperationField
        End Get
        Set
            Me.OperationField = Value
        End Set
    End Property

    '''<remarks/>
    <MedatechUK.Deserialiser.Property(Ignore:=True)>
    Public Property due() As due
        Get
            Return Me.dueField
        End Get
        Set
            Me.dueField = Value
        End Set
    End Property

    Public ReadOnly Property DateInt As Integer
        Get
            Dim dot As New Date(1988, 1, 1)
            Dim this As Date
            If dueField.Item.GetType = GetType(dmy) Then
                With TryCast(dueField.Item, dmy)
                    this = New Date(.YY, .MM, .DD)

                End With

            Else
                With TryCast(dueField.Item, wky)
                    this = DateAdd(DateInterval.WeekOfYear, CInt(.WW) - 1, New Date(.YY, 1, 1))

                End With
            End If

            Return DateDiff(DateInterval.Minute, dot, this)

        End Get

    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Part() As String
        Get
            Return Me.partField
        End Get
        Set
            Me.partField = Value
        End Set
    End Property

    '''<remarks/>    
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Qty() As Integer
        Get
            Return Me.qtyField
        End Get
        Set
            Me.qtyField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property Site() As String
        Get
            Return Me.siteField
        End Get
        Set
            Me.siteField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property PO() As String
        Get
            Return Me.poField
        End Get
        Set
            Me.poField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property deptcode() As String
        Get
            Return Me.deptcodefield
        End Get
        Set
            Me.deptcodefield = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Qualified)>
    Public Property buycode() As String
        Get
            Return Me.buycodefield
        End Get
        Set
            Me.buycodefield = Value
        End Set
    End Property

End Class
