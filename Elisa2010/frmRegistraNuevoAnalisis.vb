Public Class frmRegistraNuevoAnalisis

   Private Sub btnCambiarLector_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarLector.Click
      frmConfLector.MdiParent = frmElisaBiovetsa
      frmConfLector.Show()
   End Sub

   Private Sub btnNuevoAnalisisCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAnalisisCancelar.Click
      Me.Close()
   End Sub
End Class