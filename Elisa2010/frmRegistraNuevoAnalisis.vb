Imports System.IO

Public Class frmRegistraNuevoAnalisis

   Private Sub btnCambiarLector_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarLector.Click
      frmConfLector.MdiParent = frmElisaBiovetsa
      frmConfLector.Show()
   End Sub

   Private Sub btnNuevoAnalisisCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoAnalisisCancelar.Click
      Me.Close()
   End Sub

   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         If Me.btnLeerDatosPlaca.Text = "Leer Datos" Then
            Me.btnLeerDatosPlaca.Text = "Desconectar"
            Setup_Puerto_Serie()
         Else
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
            End If
            Me.btnLeerDatosPlaca.Text = "Leer Datos"
         End If
      Catch ex As Exception
      End Try
   End Sub

   Private Sub PuertoCom_Load(sender As System.Object, e As System.EventArgs)
      GetSerialPortNames()
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
   End Sub

   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
      Try
         az = Me.SerialPort1.ReadExisting.Trim
         msn(sib) = az
         Me.txtDatosRecibidos.Text += msn(sib)
         sib += 1
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   '  Private Sub btnEnviardato_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviardato.Click
   '     sib = 0
   '    Try
   '      SerialPort1.Write(Me.txtDatosEnviados.Text)
   '     Me.txtDatosRecibidos.Clear()
   ' Catch ex As Exception
   '      MsgBox(ex.Message)
   '   End Try
   'End Sub

   Private Sub btnGuardarDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarDatos.Click
      guardaDatos()
   End Sub


End Class