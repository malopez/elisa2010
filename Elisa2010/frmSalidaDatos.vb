Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSalidaDatos

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      guardaResultadosExcel(frecuenciaRelativa, calculoDeTitulos, "Resultados", _
                           Me.lblNombreEnfermedad.Text, _
                           Convert.ToDouble(txtMediaAritmetica.Text), _
                           Convert.ToDouble(txtMediaAritmetica2.Text), _
                           Convert.ToDouble(txtMediaGeometrica.Text), _
                           Convert.ToDouble(txtCoefVariacion.Text), _
                           Convert.ToDouble(txtDesvEstandar.Text), _
                           Convert.ToDouble(txtVarianza.Text), _
                           Convert.ToDouble(txtTotalDatosCalculados.Text), _
                           Convert.ToDouble(txtDesvEstandar2.Text), _
                           Convert.ToDouble(txtCoefVariacion2.Text), _
                           Convert.ToDouble(txtVarianza2.Text))
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

         aConsulta = "SELECT * FROM tblplacaleida WHERE caso='110504-1817';"
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