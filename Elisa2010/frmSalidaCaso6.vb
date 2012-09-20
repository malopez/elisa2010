Public Class frmSalidaCaso6

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      'Try
      guardaResultadosExcel(Me.txtNoCaso.Text, Me.lblConsecutivo.Text, Me.lblAnalisis.Text, txtFechaElaboracion.Text, _
                            Me.txtNombreCliente.Text, Me.txtNombreEnfermedad.Text, Me.lblObservaciones.Text, "Resultados", _
                            Me.lblMensajeSobreGrafica.Text, Me.lblNombreSobreGrafica.Text, _
                            txtTitulosObtenidos.Text, _
                            Convert.ToDouble(txtMediaAritmetica2.Text), _
                            Convert.ToDouble(txtMediaGeometrica.Text), _
                            Convert.ToInt32(txtTotalDatosCalculados.Text), _
                            Convert.ToDouble(txtDesvEstandar2.Text), _
                            Convert.ToDouble(txtCoefVariacion2.Text), _
                            Convert.ToDouble(txtVarianza2.Text))
      mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "El archivo de resultados para el caso se ha guardado exitosamente en excel.")
      'Catch ex As Exception
      '   mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      'End Try

   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub frmSalidaCaso6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

   End Sub
End Class