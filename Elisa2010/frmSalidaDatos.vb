Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSalidaDatos
   'MODIFICAR LOS TITULOS OBTENIDOS POR UN ARRAY DE DECIMALES
   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      guardaResultadosExcel(Me.txtNoCaso.Text, txtFechaElaboracion.Text, Me.txtNombreCliente.Text, Me.txtNombreEnfermedad.Text, Me.lblObservaciones.Text, "Resultados", _
                           txtTitulosObtenidos.Text, _
                           Convert.ToDouble(txtMediaAritmetica2.Text), _
                           Convert.ToDouble(txtMediaGeometrica.Text), _
                           Convert.ToInt32(txtTotalDatosCalculados.Text), _
                           Convert.ToDouble(txtDesvEstandar2.Text), _
                           Convert.ToDouble(txtCoefVariacion2.Text), _
                           Convert.ToDouble(txtVarianza2.Text))
   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub
End Class