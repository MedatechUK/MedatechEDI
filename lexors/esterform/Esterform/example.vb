Imports MedatechUK.Deserialiser
Imports System.ComponentModel.Composition

<Export(GetType(ILexor))>
<ExportMetadata("LexName", "Esterform.Shotscope")>
<ExportMetadata("LexVers", "1.0")>
<ExportMetadata("Parser", eParser.xml)>
<ExportMetadata("SerialType", GetType(Shotscope.request))>
<ExportMetadata("LoadType", "SHT")>
Public Class AshridgeLexor
    Inherits Lexor
    Implements ILexor

End Class

Namespace Shotscope

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class request

        Private scanField As List(Of requestScan)

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("scan")>
        Public Property scan As List(Of requestScan)
            Get
                Return Me.scanField
            End Get
            Set
                Me.scanField = Value
            End Set
        End Property

    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class requestScan

        Private sERIALNAMEField As String

        Private tOPALLETNAMEField As String

        Private oPERATIONField As String

        Private sTARTDATEField As String

        Private sTARTTIMEField As String

        Private eNDTIMEField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property SERIALNAME() As String
            Get
                Return Me.sERIALNAMEField
            End Get
            Set
                Me.sERIALNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property TOPALLETNAME() As String
            Get
                Return Me.tOPALLETNAMEField
            End Get
            Set
                Me.tOPALLETNAMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property OPERATION() As String
            Get
                Return Me.oPERATIONField
            End Get
            Set
                Me.oPERATIONField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property STARTDATE() As String
            Get
                Return Me.sTARTDATEField
            End Get
            Set
                Me.sTARTDATEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property STARTTIME() As String
            Get
                Return Me.sTARTTIMEField
            End Get
            Set
                Me.sTARTTIMEField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property ENDTIME() As String
            Get
                Return Me.eNDTIMEField
            End Get
            Set
                Me.eNDTIMEField = Value
            End Set
        End Property

    End Class

End Namespace