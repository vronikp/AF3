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


#Region "Restriccion"
Public Class Restriccion
    
    Const _Procedimiento As String = "proc_Restriccion"
    
    Private mParametrodet As Parametrodet = Nothing
    
    Private mUsuario As Usuario = Nothing
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New
        OperadorDatos = _OperadorDatos
        EsNuevo = _EsNuevo
    End Sub
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Usuari_Codigo As String, ByVal _Parame_Opciones As Integer, ByVal _Pardet_Opciones As Integer)
        Me.New(_OperadorDatos, false)
        Usuari_Codigo = _Usuari_Codigo
        Parame_Opciones = _Parame_Opciones
        Pardet_Opciones = _Pardet_Opciones
        If Me.Recargar Then
        Else
            Throw New System.Exception("No se puede cargar objeto Restriccion")
        End If
    End Sub
    
    'Parametrodet
    Public Overridable Property Parametrodet() As Parametrodet
        Get
            Return Me.mParametrodet
        End Get
        Set
            Me.mParametrodet = value
        End Set
    End Property
    
    'Usuario
    Public Overridable Property Usuario() As Usuario
        Get
            Return Me.mUsuario
        End Get
        Set
            Me.mUsuario = value
        End Set
    End Property
    
    Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
        Usuari_Codigo = CType(Fila("Usuari_Codigo"),String)
        Parame_Opciones = CType(Fila("Parame_Opciones"),Integer)
        Pardet_Opciones = CType(Fila("Pardet_Opciones"),Integer)
        Restri_Lectura = CType(Fila("Restri_Lectura"),Boolean)
        Restri_Ingreso = CType(Fila("Restri_Ingreso"),Boolean)
        Restri_Modificacion = CType(Fila("Restri_Modificacion"),Boolean)
        Restri_Eliminacion = CType(Fila("Restri_Eliminacion"),Boolean)
        Restri_Impresion = CType(Fila("Restri_Impresion"),Boolean)
        Restri_VerConfidencial = CType(Fila("Restri_VerConfidencial"),Boolean)
        Restri_Favorito = CType(Fila("Restri_Favorito"),Boolean)
        mParametrodet = Nothing
        mUsuario = Nothing
    End Sub
    
    Public Overridable Function Recargar() As Boolean
        Dim Result As System.Data.DataTable = New System.Data.DataTable
        Dim bReturn As Boolean = true
        OperadorDatos.AgregarParametro("@accion", "C")
        OperadorDatos.AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
        OperadorDatos.AgregarParametro("@Parame_Opciones", Parame_Opciones)
        OperadorDatos.AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar(Result)
        OperadorDatos.LimpiarParametros
        Try 
            Me.MapearDataRowaObjeto(Result.Tables.Rows(0))
            EsNuevo = false
            EsModificado = false
        Catch ex As System.Exception
            bReturn = false
        End Try
        Return bReturn
    End Function
    
    Public Overridable Function Guardar() As Boolean
        Dim Result As Integer = 0
        Dim bReturn As Boolean = true
        Dim sAccion As String = "M"
        If esNuevo Then
            sAccion = "I"
        End If
        OperadorDatos.AgregarParametro("@accion", sAccion)
        OperadorDatos.AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
        OperadorDatos.AgregarParametro("@Parame_Opciones", Parame_Opciones)
        OperadorDatos.AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
        OperadorDatos.AgregarParametro("@Restri_Lectura", Restri_Lectura)
        OperadorDatos.AgregarParametro("@Restri_Ingreso", Restri_Ingreso)
        OperadorDatos.AgregarParametro("@Restri_Modificacion", Restri_Modificacion)
        OperadorDatos.AgregarParametro("@Restri_Eliminacion", Restri_Eliminacion)
        OperadorDatos.AgregarParametro("@Restri_Impresion", Restri_Impresion)
        OperadorDatos.AgregarParametro("@Restri_VerConfidencial", Restri_VerConfidencial)
        OperadorDatos.AgregarParametro("@Restri_Favorito", Restri_Favorito)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar(Result)
        OperadorDatos.LimpiarParametros
        If bReturn Then
            If OperadorDatos.EstaenTransaccion Then
            Else
                Me.AceptarCambios
            End If
        End If
        Return bReturn
    End Function
    
    Public Overridable Sub AceptarCambios()
        EsNuevo = false
        EsModificado = false
    End Sub
    
    Public Overridable Function Eliminar() As Boolean
        Dim bReturn As Boolean = true
        OperadorDatos.AgregarParametro("@accion", "E")
        OperadorDatos.AgregarParametro("@Usuari_Codigo", Usuari_Codigo)
        OperadorDatos.AgregarParametro("@Parame_Opciones", Parame_Opciones)
        OperadorDatos.AgregarParametro("@Pardet_Opciones", Pardet_Opciones)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar
        OperadorDatos.LimpiarParametros
        Return bReturn
    End Function
End Class
#End Region

#Region "RestriccionList"
Public Class RestriccionList
    Inherits System.ComponentModel.BindingList(Of )
End Class
#End Region
