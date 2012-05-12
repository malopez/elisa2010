Public Class frmMultipleCaso


   Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
      Me.Close()
   End Sub


   Private Sub txtNoDeCasos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoDeCasos.TextChanged
      If controlesValidosNumero(txtNoDeCasos, " Número primer control positivo ", 1, 8) Then

      End If
   End Sub

   Private Sub cmbNombreEnfermedad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNombreEnfermedad.SelectedIndexChanged

   End Sub

   Private Sub btnDefineCasos_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarControles.Click
      grbControlesNegativos.Enabled = False
      grbControlesPositivos.Enabled = False
      btnDefineCPN.Enabled = False
      If controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 0, 11) AndAlso _
         controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
         controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 0, 11) AndAlso _
         controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "Z") AndAlso _
         controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 0, 11) AndAlso _
         controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
         controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 0, 11) AndAlso _
         controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
         controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 0, 11) AndAlso
         controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") AndAlso _
         controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 0, 11) Then
         btnAceptarControles.Enabled = False
         btnDefineCPN.Enabled = False
         btnObtenerResultados.Enabled = True
      Else
         mensajeRojo(Me.lblMensajeCaso, "Los valores que ha introducido no son válidos, trate nuevamente.")
         btnDefineCPN.Enabled = True
         btnAceptarControles.Enabled = True
      End If
   End Sub

End Class