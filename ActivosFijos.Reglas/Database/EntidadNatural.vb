'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas



#Region "EntidadNatural"
Partial Public Class EntidadNatural
  Inherits _Database

  Private mEntida_Codigo As Integer = 0

  Private mEntnat_Nombres As String = ""

  Private mEntnat_Apellidopaterno As String = ""

  Private mEntnat_Apellidomaterno As String = ""

  Private mParame_Sexo As Integer = CInt(Enumerados.EnumParametros.Sexo)

  Private mPardet_Sexo As Integer = 0

  Private mParame_Estadocivil As Integer = CInt(Enumerados.EnumParametros.EstadoCivil)

  Private mPardet_Estadocivil As Integer = 0

  Private mEntnat_Fechanacimiento As Date = Now.Date

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Entida_Codigo() As Integer
    Get
      Return Me.mEntida_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entnat_Nombres() As String
    Get
      Return Me.mEntnat_Nombres
    End Get
    Set(ByVal value As String)
      Me.mEntnat_Nombres = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entnat_Apellidopaterno() As String
    Get
      Return Me.mEntnat_Apellidopaterno
    End Get
    Set(ByVal value As String)
      Me.mEntnat_Apellidopaterno = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entnat_Apellidomaterno() As String
    Get
      Return Me.mEntnat_Apellidomaterno
    End Get
    Set(ByVal value As String)
      Me.mEntnat_Apellidomaterno = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Sexo() As Integer
    Get
      Return Me.mParame_Sexo
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Sexo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Sexo() As Integer
    Get
      Return Me.mPardet_Sexo
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Sexo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Estadocivil() As Integer
    Get
      Return Me.mParame_Estadocivil
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Estadocivil = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Estadocivil() As Integer
    Get
      Return Me.mPardet_Estadocivil
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Estadocivil = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entnat_Fechanacimiento() As Date
    Get
      Return Me.mEntnat_Fechanacimiento
    End Get
    Set(ByVal value As Date)
      Me.mEntnat_Fechanacimiento = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region

