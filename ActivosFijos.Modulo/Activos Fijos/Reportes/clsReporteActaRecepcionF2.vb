﻿Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class clsReporteActaRecepcionF2
    Public Shared Function RetornarReporteActaRecepcionDS(_Custodio As Empleado, _PeriodoInventario As WWTSParametroDet, _Ubicacion As WWTSParametroDet, _SoloInventariados As Boolean) As dsSriActaRecepcion
        Dim bReturn As Boolean
        Dim ds As New dsSriActaRecepcion
        With _Custodio.OperadorDatos
            .AgregarParametro("@accion", "racF2")
            .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
            .AgregarParametro("@Parame_PeriodoInventario", _PeriodoInventario.Parame_Codigo)
            .AgregarParametro("@Pardet_PeriodoInventario", _PeriodoInventario.Pardet_Secuencia)
            .AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
            .AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
            .AgregarParametro("@SoloInventariados", _SoloInventariados)
            .Comando.CommandText = "proc_Activo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_ActaConstacionF2")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_ActaConstacionF2")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function

    Public Shared Function RetornarReporteCambioCustodioDS(_Custodio As Empleado, _PeriodoInventario As WWTSParametroDet, _Ubicacion As WWTSParametroDet) As dsFichaCambioCustodio
        Dim bReturn As Boolean
        Dim ds As New dsFichaCambioCustodio
        With _Custodio.OperadorDatos
            .AgregarParametro("@accion", "ccuSRI")
            .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
            .AgregarParametro("@Parame_PeriodoInventario", _PeriodoInventario.Parame_Codigo)
            .AgregarParametro("@Pardet_PeriodoInventario", _PeriodoInventario.Pardet_Secuencia)
            .AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
            .AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
            .Comando.CommandText = "proc_Activo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_FichaCambioCustodio")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_FichaCambioCustodio")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function

End Class
