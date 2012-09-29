Public Class frmInicioPrograma

   Dim contador As Integer = 4

   Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

      If barraDeProgreso.Value = 100 Then
         Me.Opacity -= 0.07
         If Me.Opacity = 0.0 Then
            Timer1.Enabled = False
            Timer1.Stop()
            Me.Hide()
            frmElisaBiovetsa.ShowDialog()
         End If
      Else
         barraDeProgreso.Value += 4
         If barraDeProgreso.Value = contador Then
            Label1.Text = "Iniciando..."
         Else
            If barraDeProgreso.Value = contador + 16 Then
               Label2.Text = barraDeProgreso.Value & " % cargado..."
               contador += 20
            End If
            If barraDeProgreso.Value = 28 Then
               Label1.Text = "Propiedad de Biotecnología Veterinaria de Puebla S.A. de C.V."
            End If
         End If
      End If
   End Sub








End Class