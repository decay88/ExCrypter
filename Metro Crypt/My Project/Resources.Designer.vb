﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Этот класс создан автоматически классом StronglyTypedResourceBuilder
    'с помощью такого средства, как ResGen или Visual Studio.
    'Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    'с параметром /str или перестройте свой проект VS.
    '''<summary>
    '''  Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Metro_Crypt.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Перезаписывает свойство CurrentUICulture текущего потока для всех
        '''  обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        '''  Поиск локализованного ресурса типа System.Byte[].
        '''</summary>
        Friend ReadOnly Property Res() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Res", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Imports System.Windows.Forms
        '''Imports System.Reflection
        '''
        '''&lt;Assembly: AssemblyTitle(&quot;*Title*&quot;)&gt; 
        '''&lt;Assembly: AssemblyDescription(&quot;*Description*&quot;)&gt; 
        '''&lt;Assembly: AssemblyCompany(&quot;*Company*&quot;)&gt; 
        '''&lt;Assembly: AssemblyProduct(&quot;*Product*&quot;)&gt; 
        '''&lt;Assembly: AssemblyCopyright(&quot;*Copyright*&quot;)&gt; 
        '''&lt;Assembly: AssemblyTrademark(&quot;*Trademark*&quot;)&gt; 
        '''&lt;Assembly: AssemblyVersion(&quot;*version*&quot;)&gt; 
        '''&lt;Assembly: AssemblyFileVersion(&quot;*fversion*&quot;)&gt; 
        '''
        '''Module X
        '''    Sub Main()
        '''    	MessageBox.Show(&quot;&quot;, &quot;&quot;, MessageBoxButtons.OK, MessageBoxIco [остаток строки не уместился]&quot;;.
        '''</summary>
        Friend ReadOnly Property String1() As String
            Get
                Return ResourceManager.GetString("String1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Byte[].
        '''</summary>
        Friend ReadOnly Property stub() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("stub", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Поиск локализованного ресурса типа System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Снимок() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Снимок", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
