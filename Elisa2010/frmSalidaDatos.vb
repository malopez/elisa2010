Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSalidaDatos

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      guardaResultadosExcel(Me.lblNoCaso.Text, Me.lblNombreCliente.Text, Me.lblNombreEnfermedad.Text, Me.lblObservaciones.Text, "Resultados", _
                           calculoDeTitulos, _
                           Convert.ToDouble(txtMediaAritmetica2.Text), _
                           Convert.ToDouble(txtMediaGeometrica.Text), _
                           Convert.ToDouble(txtTotalDatosCalculados.Text), _
                           Convert.ToDouble(txtDesvEstandar2.Text), _
                           Convert.ToDouble(txtCoefVariacion2.Text), _
                           Convert.ToDouble(txtVarianza2.Text))
   End Sub

End Class