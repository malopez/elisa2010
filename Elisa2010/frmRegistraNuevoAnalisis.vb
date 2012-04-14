Imports System.IO

Public Class frmRegistraNuevoAnalisis

   'Para realizar los calculos de titulos
   'ENFERMEDAD       LOGSPS     LOGTIT1   LOGTIT2
   'Laringo           0.15       1.45        3.726
   'Bronquitis        0.15       1.642       3.568
   'Encefalomielitis  0.15       1.642       3.726
   'IBF               0.18       1.172       3.614
   'NC                0.15       1.464       3.74
   'Reovirus          0.15       1.077       3.46
   Dim logsps As Decimal = 0
   Dim logtit1 As Decimal = 0
   Dim logtit2 As Decimal = 0


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
         'Me.txtDatosRecibidos.Text += msn(sib)
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
      Dim nombreArchivo As String
      nombreArchivo = formateaDatos(placaLector)
      'nombreArchivo = guardaDatos(nombreArchivo)
      guardaDatosExcel(placaLector)
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True
      btnCalcularValores.Enabled = True
   End Sub

   Private Sub btnCalcularValores_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcularValores.Click
      Dim cpx1, cpx2, cpx3, cnx1, cnx2, cnx3 As Integer
      Dim cpy1, cpy2, cpy3, cny1, cny2, cny3 As Integer
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP1Letra1, "Letra primer control positivo", "A", "Z") Then
         cpx1 = siValorEsLetra(txtCP1Letra1)
      End If
      If controlesValidosNumero(txtCP1Valor1, "Número primer control positivo", 0, 11) Then
         cpy1 = Convert.ToInt32(txtCP1Valor1.Text)
      End If
      'Valor positivo dos, letra y numero
      If controlesValidosLetra(txtCP2Letra2, "Letra segundo control positivo", "A", "Z") Then
         cpx2 = siValorEsLetra(txtCP2Letra2)
      End If
      If controlesValidosNumero(txtCP2Valor2, "Número segundo control positivo", 0, 11) Then
         cpy2 = Convert.ToInt32(txtCP2Valor2.Text)
      End If

      'Valor positivo tres, letra y numero
      If controlesValidosLetra(txtCP3Letra3, "Letra tercer control positivo", "A", "Z") Then
         cpx3 = siValorEsLetra(txtCP3Letra3)
      End If
      If controlesValidosNumero(txtCP3Valor3, "Número tercer control positivo", 0, 11) Then
         cpy3 = Convert.ToInt32(txtCP3Valor3.Text)
         txtCP3Valor3.Select()
      End If
      'Valor negativo uno, letra y numero
      If controlesValidosLetra(txtCN1Letra1, "Letra primer control negativo", "A", "Z") Then
         cnx1 = siValorEsLetra(txtCN1Letra1)
      End If
      If controlesValidosNumero(txtCP1Valor1, "Número primer control negativo", 0, 11) Then
         cny1 = Convert.ToInt32(txtCN1Valor1.Text)
      End If
      'Valor negativo dos, letra y numero
      If controlesValidosLetra(txtCN2Letra2, "Letra segundo control negativo", "A", "Z") Then
         cnx2 = siValorEsLetra(txtCN2Letra2)
      End If
      If controlesValidosNumero(txtCN2Valor2, "Número segundo control negativo", 0, 11) Then
         cny2 = Convert.ToInt32(txtCN2Valor2.Text)
      End If

      'Valor negativo tres, letra y numero
      If controlesValidosLetra(txtCN3Letra3, "Letra tercer control negativo", "A", "Z") Then
         cnx3 = siValorEsLetra(txtCN3Letra3)
      End If
      If controlesValidosNumero(txtCN3Valor3, "Número tecer control negativo", 0, 11) Then
         cny3 = Convert.ToInt32(txtCN3Valor3.Text)
      End If
      calculaValores("Laringotraqueitis Aviar", "Grupo de títulos", "%", cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, CDec(0.15), CDec(1.45), CDec(3.726))
      frmSalidaDatos.Show()
   End Sub

   
   Private Sub TblregistroanalisisBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblregistroanalisisBindingNavigatorSaveItem.Click
      Me.Validate()
      Me.TblregistroanalisisBindingSource.EndEdit()
      Me.TableAdapterManager.UpdateAll(Me.BvtselisaDataSet)

   End Sub

   Private Sub frmRegistraNuevoAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tblregistroanalisis' table. You can move, or remove it, as needed.
      Me.TblregistroanalisisTableAdapter.Fill(Me.BvtselisaDataSet.tblregistroanalisis)
   End Sub
End Class