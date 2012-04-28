Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmSalidaDatos

   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      guardaResultadosExcel(frecuenciaRelativa, calculoDeTitulos, "Laringo", _
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
End Class