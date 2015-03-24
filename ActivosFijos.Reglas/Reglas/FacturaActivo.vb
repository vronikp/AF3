'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5446
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos


#Region "FacturaActivo"
Public Class FacturaActivo

  Const _Procedimiento As String = "proc_FacturaActivo"

  Private mProveedor As Proveedor = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Factura_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Factura_Codigo = _Factura_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto FacturaActivo")
    End If
  End Sub

  'Proveedor
  Public Overridable Property Proveedor() As Proveedor
    Get
      If mProveedor Is Nothing AndAlso Entida_Proveedor > 0 Then
        Try
          mProveedor = New Proveedor(OperadorDatos, Entida_Proveedor)
        Catch ex As Exception
          mProveedor = Nothing
        End Try
      End If
      Return Me.mProveedor
    End Get
    Set(value As Proveedor)
      Me.mProveedor = value
      Entida_Proveedor = value.Entida_Codigo
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Proveedor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)>
  Public ReadOnly Property ProveedorString As String
    Get
      If Proveedor Is Nothing Then
        Return String.Empty
      Else
        Return Proveedor.NombreCompleto
      End If
    End Get
  End Property

  Public ReadOnly Property Descripcion As String
    Get
      Return String.Format("{0} {1}", ProveedorString, Factura_Numero)
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Factura", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 200, False)>
  Public ReadOnly Property FacturaNumero As String
    Get
      Return Factura_Numero
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Referencia", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 200, True)>
  Public ReadOnly Property FacturaRef As String
    Get
      Return String.Format("{0} {1}", Factura_Numero, IIf(String.IsNullOrWhiteSpace(Factura_Referencia), "", "Ref:" + Factura_Referencia))
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Factura_Codigo = CType(Fila("Factura_Codigo"), Integer)
    Entida_Proveedor = CType(Fila("Entida_Proveedor"), Integer)
    Factura_Numero = CType(Fila("Factura_Numero"), String)
    Factura_Referencia = CType(Fila("Factura_Referencia"), String)
    Factura_Fecha = CDate(Fila("Factura_Fecha"))
    Factura_ValorTotal = CDec(Fila("Factura_ValorTotal"))
    mProveedor = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.DataTable = New System.Data.DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Factura_Codigo", Factura_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Factura_Codigo", Factura_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Proveedor", Entida_Proveedor)
    OperadorDatos.AgregarParametro("@Factura_Numero", Factura_Numero)
    OperadorDatos.AgregarParametro("@Factura_Referencia", Factura_Referencia)
    OperadorDatos.AgregarParametro("@Factura_Fecha", Factura_Fecha)
    OperadorDatos.AgregarParametro("@Factura_ValorTotal", Factura_ValorTotal)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Factura_Codigo = Result
      End If
      If OperadorDatos.EstaenTransaccion Then
      Else
        Me.AceptarCambios()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
  End Sub

  Public Overridable Function Eliminar() As Boolean
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Factura_Codigo", Factura_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "FacturaActivoList"
Public Class FacturaActivoList
  Inherits System.ComponentModel.BindingList(Of FacturaActivo)

  Public Shared Function ObtenerLista(_Proveedor As Proveedor, Optional ByVal _filtro As String = "") As FacturaActivoList
    Dim oResult As New FacturaActivoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Proveedor.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Entida_Proveedor", _Proveedor.Entida_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_FacturaActivo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New FacturaActivo(_Proveedor.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
