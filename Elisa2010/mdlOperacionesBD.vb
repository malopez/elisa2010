﻿Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module mdlOperacionesBD
   '#################################################
   '#      SECCION DE CARGA DE RESULTADOS EN BD     #
   '#################################################
   Public Sub cargaResultadosBD(ByRef numcaso As String, ByVal consecutivo As Integer, ByVal idAnalisis As String, ByVal placaLeida As String, ByRef resultadoTitulos As String, ByVal fechaElaboracion As String, ByVal promCP As Double, ByVal promCN As Double, _
                                 ByVal promCPS As Double, ByVal mediaAritmetica As Double, ByVal mediaGeometrica As Double, _
                                 ByVal desvEst As Double, ByVal coefVar As Double, ByVal valorFR As String, ByVal cantidadFR As String, _
                                 ByRef etiqueta As ToolStripLabel)
      Dim resultado As Integer
      Dim comando As New MySqlCommand
      Dim cadenafecha As String
      Dim tabla() As String

      cadenafecha = fechaElaboracion
      tabla = Split(cadenafecha, "/")
      fechaElaboracion = tabla(2) & "/" & tabla(1) & "/" & tabla(0)

      Try
         'Crear la conexion para establecer el acceso a la BD de MySQL
         Dim oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         'Abrir la conexion a la base de datos
         oConexion.Open()
         'Asigna la cadena de conexion
         comando.Connection = oConexion
         comando.CommandText = "INSERT INTO tblplacaleida (caso,consecutivo,id_analysis,fechaElaboracion,placaLeida,resultadoTitulos,promCP,promCN,promCPS,medArit,medGeom,desvEst,coefVar,valorFR,cantidadFR) VALUES " _
                                & "('" & numcaso & "'," & consecutivo & ",'" & idAnalisis & "'," & "STR_TO_DATE('" & fechaElaboracion & "','" & "%Y/%m/%d" & "'),'" _
                                & placaLeida & "','" & resultadoTitulos & "'," & promCP & "," & promCN & "," & promCPS & "," & mediaAritmetica & "," & mediaGeometrica & "," _
                                & desvEst & "," & coefVar & ",'" & valorFR & "','" & cantidadFR & "');"
         resultado = comando.ExecuteNonQuery()
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiqueta, ex)
      Catch ex As DataException
         mensajeException(etiqueta, ex)
      Catch ex As Exception
         mensajeException(etiqueta, ex)
      End Try
   End Sub

   'Carga la frecuencia Relativa en la tabla de paso de la BD.
   Public Sub cargaFrecRelBD(ByVal frecuenciaRelativa() As Decimal, ByRef numcaso As String, ByVal rangoDatos() As Integer, _
                             ByRef etiqueta As ToolStripLabel)
      Dim i As Integer
      Dim resultado As Integer
      Dim comando As New MySqlCommand
      Try
         'Crear la conexion para establecer el acceso a la BD de MySQL
         Dim oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         'Abrir la conexion a la base de datos
         oConexion.Open()
         'Asigna la cadena de conexion
         comando.Connection = oConexion
         comando.CommandText = "truncate table tblfrecrelativa;"
         resultado = comando.ExecuteNonQuery()
         'Guardar los datos de la frecuencia relativa en la BD

         For i = 0 To 14
            comando.CommandText = "INSERT INTO tblfrecrelativa (rango,valor,cantidad) values (" & i & "," & reduceDecimal(frecuenciaRelativa(i)) & "," & rangoDatos(i) & ");"
            resultado = comando.ExecuteNonQuery()
         Next

         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiqueta, ex)
      Catch ex As DataException
         mensajeException(etiqueta, ex)
      Catch ex As Exception
         mensajeException(etiqueta, ex)
      End Try
   End Sub

End Module
