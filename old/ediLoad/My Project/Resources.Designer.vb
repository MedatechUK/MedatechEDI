﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("oLoad.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        '''&lt;loadconfig&gt;
        '''
        '''  &lt;!-- The SMTP server details used to nofify admins of errors --&gt;
        '''  &lt;notifyerror smtp=&quot;mail.medatechuk.com&quot; from=&quot;noreply@medatechuk.com&quot;&gt;
        '''
        '''    &lt;!-- Multiple addresses can be configured --&gt;
        '''    &lt;notify address=&quot;support@medatechuk.com&quot;/&gt;
        '''    &lt;notify address=&quot;si@medatechuk.com&quot;/&gt;
        '''
        '''  &lt;/notifyerror&gt;
        '''
        '''&lt;/loadconfig&gt;
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property _default() As String
            Get
                Return ResourceManager.GetString("_default", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        '''&lt;!-- 
        '''The oData connection details: 
        '''  oDataHost:    The hostname for Priority
        '''  tabulaini:    The tabula ini file to use
        '''  environment:  The Priority company
        '''  ouser:        Username
        '''  opass:        Password.
        '''--&gt;
        '''&lt;odataConfig 
        '''  oDataHost=&quot;https://localhost&quot;
        '''  tabulaini=&quot;tabula.ini&quot;
        '''  environment=&quot;demo&quot;
        '''  ouser=&quot;&quot;
        '''  opass=&quot;&quot;
        '''/&gt;.
        '''</summary>
        Friend ReadOnly Property odata() As String
            Get
                Return ResourceManager.GetString("odata", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
