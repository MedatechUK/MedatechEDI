Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports MedatechUK.Deserialiser

<Export(GetType(ILexor))>
<ExportMetadata("LexName", "oData.config")>
<ExportMetadata("LexVers", "1.0")>
<ExportMetadata("Parser", eParser.xml)>
<ExportMetadata("SerialType", GetType(odataConfig))>
<ExportMetadata("LoadType", "ODT")>
Public Class oDataconfigLexor
    Inherits Lexor
    Implements ILexor

End Class

'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
 System.SerializableAttribute(),
 System.Diagnostics.DebuggerStepThroughAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class odataConfig
    Implements IDisposable

    Sub New()

    End Sub

    Sub New(oDataHost As String)
        oDataHostField = oDataHost
        tabulainigField = "tabula.ini"
        ouserField = "apiuser"
        opassField = "123456"
        environmentField = "demo"

    End Sub

    Private oDataHostField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    <DisplayName("oData Server"),
    Description("The Priority oData service URL to load received files e.g. https://priority.customer.url"),
    Category("oData Service")>
    Public Property oDataHost() As String
        Get
            Return Me.oDataHostField
        End Get
        Set
            Me.oDataHostField = Value
            changes = True
        End Set
    End Property

    Private tabulainigField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    <DisplayName("Tabula INI file"),
    Description("The Priority tabula.ini file to use for the oData session."),
    Category("oData Service")>
    Public Property tabulaini() As String
        Get
            Return Me.tabulainigField
        End Get
        Set
            Me.tabulainigField = Value
            changes = True
        End Set
    End Property

    Private ouserField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    <DisplayName("Priority API username"),
    Description("The priority user with assigned API access."),
    Category("oData Authentication")>
    Public Property ouser() As String
        Get
            Return Me.ouserField
        End Get
        Set
            Me.ouserField = Value
            changes = True
        End Set
    End Property

    Private opassField As String
    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    <DisplayName("Priority API password"),
    Description("The password for the Priority API user."),
    Category("oData Authentication"),
     PasswordPropertyText(True)>
    Public Property opass() As String
        Get
            Return Me.opassField
        End Get
        Set
            Me.opassField = Value
            changes = True
        End Set
    End Property

    Private environmentField As String
    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    <DisplayName("Default Priority Company"),
    Description("The default Priority environment for loadings."),
    Category("oData Service")>
    Public Property environment() As String
        Get
            Return Me.environmentField
        End Get
        Set
            Me.environmentField = Value
            changes = True
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
