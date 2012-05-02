Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSalidaDatos

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      guardaResultadosExcel(frecuenciaRelativa, calculoDeTitulos, "Resultados", _
                           Me.lblNombreEnfermedad.Text, _
                           Me.txtMediaAritmetica.Text, _
                           Me.txtMediaAritmetica2.Text, _
                           Me.txtMediaGeometrica.Text, _
                           Me.txtCoefVariacion.Text, _
                           Me.txtDesvEstandar.Text, _
                           Me.txtVarianza.Text, _
                           Me.txtTotalDatosCalculados.Text, _
                           Me.txtDesvEstandar2.Text, _
                           Me.txtCoefVariacion2.Text, _
                           Me.txtVarianza2.Text)
   End Sub

   Private Sub btnGeneraReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnGeneraReporte.Click
      Try
         Dim oConexion As MySqlConnection

         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         Dim aConsulta As String = ""
         Dim oDS As New DataSet
         Dim oDA As New MySqlDataAdapter
         oConexion.ConnectionString = cadenaConexion

         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, logSPS,logTit1,logTit2 FROM ordenes o,analisis a WHERE o.caso='110504-1817'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='E01/ELBI' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDA.SelectCommand = oComando
         oDA.Fill(oDS)
         oConexion.Close()
         oDS.WriteXml("C:\XML\casoejemplo.xml", XmlWriteMode.WriteSchema)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblSalidaDatos, ex)
      Catch ex As DataException
         mensajeException(lblSalidaDatos, ex)
      Catch ex As Exception
         mensajeException(lblSalidaDatos, ex)
      End Try
   End Sub
End Class