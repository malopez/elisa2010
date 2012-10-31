Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class frmLecturaDePlaca

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub frmLecturaDePlaca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      dibujaTablaEnPantalla(dgvPlacaLeida)
      GetSerialPortNamesParametros(cmbComboPorts, etiquetaMensaje)
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
      ToolTip1.SetToolTip(btnCancelar, "Salir de la página.")
      ToolTip1.SetToolTip(ckbControlesDefault, "Marque para definir controles + y - default")
      ToolTip1.SetToolTip(txtNoControlesPositivos, "Indique el número de controles positivos.")
      ToolTip1.SetToolTip(txtNoControlesNegativos, "Indique el número de controles negativos.")
      ToolTip1.SetToolTip(btnDefinirControlesPN, "Indicar manualmente los controles + y -.")
      ToolTip1.SetToolTip(btnAceptarControles, "Aceptar los controles + y - mostrados.")
      ToolTip1.SetToolTip(btnPreverInfome, "Prever el archivo excel de valores capturados en la placa.")
   End Sub

   '#########################################################
   'PARA RECIBIR LOS DATOS DESDE EL PUERTO
   '#########################################################
   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         txtDatosRecibidos.Text = ""
         az = SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
      txtDatosRecibidos.Text = msn
   End Sub

   '#########################################################
   'CUADROS DE TEXTO PARA LOS CONTROLES POSITIVOS Y NEGATIVOS Y CHECKBOX PARA VALORES DEFAULT
   '#########################################################

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbControlesDefault.CheckedChanged
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)

      If (nocp >= 2) And (nocn >= 2) Then
         txtNoControlesPositivos.Enabled = False
         txtNoControlesNegativos.Enabled = False

         ckbControlesDefault.Enabled = False

         defineBotonesPositivos(nocp, lblCPNo1, lblCPNo2, lblCPNo3, txtCP1Letra1, txtCP1Valor1, _
                                txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
         defineBotonesNegativos(nocn, lblCNNo1, lblCNNo2, lblCNNo3, txtCN1Letra1, txtCN1Valor1, _
                                txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

         defineValoresDefaultPositivos(nocp, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
         defineValoresDefaultNegativos(nocn, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

         grbControlesPositivos.Enabled = True
         grbControlesNegativos.Enabled = True

         btnAceptarControles.Enabled = True
         btnDefinirControlesPN.Enabled = True

      Else
         mensajeRojo(etiquetaMensaje, "ERROR: Los valores definidos para controles positivos y/o negativos inválidos, trate nuevamente.")
      End If

   End Sub

   '#########################################################
   'CUADROS DE TEXTO PARA DEFINIR LOS CONTROLES POSITIVOS-NEGATIVOS 
   '#########################################################

   Private Sub txtNoControlesPositivos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesPositivos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub txtNoControlesNegativos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesNegativos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesNegativos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub txtCP1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP1Letra1.TextChanged
      controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtCP1Valor1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP1Valor1.TextChanged
      controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12)
   End Sub

   Private Sub txtCP2Letra2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP2Letra2.TextChanged
      controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H")
   End Sub

   Private Sub txtCP2Valor2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP2Valor2.TextChanged
      controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12)
   End Sub

   Private Sub txtCP3Letra3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP3Letra3.TextChanged
      controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "H")
   End Sub

   Private Sub txtCP3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP3Valor3.TextChanged
      controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12)
   End Sub

   Private Sub txtCN1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN1Letra1.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H")
   End Sub

   Private Sub txtCN1Valor1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN1Valor1.TextChanged
      controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12)
   End Sub

   Private Sub txtCN2Letra2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN2Letra2.TextChanged
      controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H")
   End Sub

   Private Sub txtCN2Valor2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN2Valor2.TextChanged
      controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12)
   End Sub

   Private Sub txtCN3Letra3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN3Letra3.TextChanged
      controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H")
   End Sub

   Private Sub txtCN3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN3Valor3.TextChanged
      controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12)
   End Sub

   '#########################################################
   'BOTON DE ACEPTAR EL NO. DE CASOS Y CONTROLES +/- UTILIZADOS EN LA PLACA
   '#########################################################

   Private Sub btnAceptarControles_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarControles.Click
      grbControlesNegativos.Enabled = False
      grbControlesPositivos.Enabled = False
      btnDefinirControlesPN.Enabled = False
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      Select Case nocp
         Case 2
            If (nocn = 2) Then
               '1. Valida que esten en rango de letras y numeros A-H y 1-12.
               '2. Verifica que ningun valor de control positivo o negativo se duplique.
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) Then

                  If queSeanDistintos(etiquetaMensaje, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then


                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(etiquetaMensaje, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnLeerDatosPlaca.Enabled = True
                  Else
                     mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If

            ElseIf (nocn = 3) Then
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) AndAlso
                  controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12) Then
                  If queSeanDistintos(etiquetaMensaje, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(etiquetaMensaje, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnLeerDatosPlaca.Enabled = True
                  Else
                     mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True

                  End If
               Else
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If
            End If
         Case 3
            If (nocn = 2) Then
               '1. Valida que esten en rango de letras y numeros A-H y 1-12.
               '2. Verifica que ningun valor de control positivo o negativo se duplique.
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) Then
                  If queSeanDistintos(etiquetaMensaje, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(etiquetaMensaje, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then


                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(etiquetaMensaje, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False

                     btnLeerDatosPlaca.Enabled = True
                  Else
                     mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If
            ElseIf (nocn = 3) Then
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) AndAlso
                  controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12) Then

                  If queSeanDistintos(etiquetaMensaje, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CP3-CN3", txtCP3Letra3, txtCP3Valor3, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(etiquetaMensaje, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(etiquetaMensaje, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False

                     btnLeerDatosPlaca.Enabled = True
                  Else
                     mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If
            End If
      End Select
   End Sub

   '#########################################################
   'PROCEDIMIENTOS NECESARIOS PARA LA FORMA
   '#########################################################

   Private Sub presentaDatosEnPantallaFormateados()
      btnLeerDatosPlaca.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         If msn <> "" Then
            formateaDatos(placaLector, dgvPlacaLeida)
            organizaEnTabla(dgvPlacaLeida, placaLector)
            txtNombrePlaca.Text = guardaDatosEnExcel()
            btnPreverInfome.Enabled = True
         Else
            mensajeRojo(etiquetaMensaje, "ERROR: No se han formateado datos debido a que no se han recibido desde el lector.")
         End If
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: Se ha presentado un error al formatear datos.")
      End Try
   End Sub

   Private Function guardaDatosEnExcel() As String
      'Obtiene el numero de caso para ese análisis
      Dim nocp As Integer = CInt(txtNoControlesPositivos.Text)
      Dim nocn As Integer = CInt(txtNoControlesNegativos.Text)
      Dim nombreArchivo As String = ""
      Dim cpx1 As Integer = siValorEsLetra(txtCP1Letra1)
      Dim cpx2 As Integer = siValorEsLetra(txtCP2Letra2)
      Dim cpy1 As Integer = CInt(txtCP1Valor1.Text) - 1
      Dim cpy2 As Integer = CInt(txtCP2Valor2.Text) - 1
      Dim cnx1 As Integer = siValorEsLetra(txtCN1Letra1)
      Dim cnx2 As Integer = siValorEsLetra(txtCN2Letra2)
      Dim cny1 As Integer = CInt(txtCN1Valor1.Text) - 1
      Dim cny2 As Integer = CInt(txtCN2Valor2.Text) - 1

      'Asigna valor default a la definición de cp y negativos, ya que al menos deben ser dos de cada uno de ellos.
      Dim cpx3 As Integer = 0
      Dim cnx3 As Integer = 0
      Dim cpy3 As Integer = 0
      Dim cny3 As Integer = 0

      'Verifica si  son tres controles positivos
      If (nocp = 3) Then
         cpx3 = siValorEsLetra(Me.txtCP3Letra3)
         cpy3 = CInt(Me.txtCP3Valor3.Text) - 1
      End If
      'Verifica si  son tres controles negativos
      If (nocn = 3) Then
         cnx3 = siValorEsLetra(Me.txtCN3Letra3)
         cny3 = CInt(Me.txtCN3Valor3.Text) - 1
      End If

      guardarDatosExcel(placaLector, nocp, nocn, "", 0, "", cpx1, cpx2, cpx3, cnx1, cnx2, cnx3, _
                        cpy1, cpy2, cpy3, cny1, cny2, cny3, 0, 0, 0, 0, etiquetaMensaje, nombreArchivo)
      Return nombreArchivo
   End Function

   Private Sub btnDefinirControlesPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)

      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True

      btnAceptarControles.Enabled = True
      ckbControlesDefault.Enabled = False

      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
         'Deshabilita los botones de captura de no. de controles positivos y negativos
         txtNoControlesPositivos.Enabled = False
         txtNoControlesNegativos.Enabled = False

         defineBotonesPositivos(nocp, lblCPNo1, lblCPNo2, lblCPNo3, txtCP1Letra1, txtCP1Valor1, _
                                txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
         defineBotonesNegativos(nocn, lblCNNo1, lblCNNo2, lblCNNo3, txtCN1Letra1, txtCN1Valor1, _
                                txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)
         'Habilita los group boxes de controles positivos y negativos.
         grbControlesPositivos.Enabled = True
         grbControlesNegativos.Enabled = True

      Else
         defineValoresDefaultPositivos(nocp, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
         defineValoresDefaultNegativos(nocn, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)
      End If

   End Sub

   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         If btnLeerDatosPlaca.Text = "Obtener datos desde el lector" Then
            btnLeerDatosPlaca.Text = "Desconectar Lector"
            Setup_Puerto_SerieParametros(SerialPort1, cmbComboPorts, etiquetaMensaje, lblNombreLector)
         ElseIf btnLeerDatosPlaca.Text = "Desconectar Lector" Then
            btnLeerDatosPlaca.Text = "Obtener datos desde el lector"
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
               mensajeVerde(etiquetaMensaje, "Mensaje: Cerrando el puerto COM del lector.")
               btnLeerDatosPlaca.Enabled = False
               presentaDatosEnPantallaFormateados()
            End If
         End If
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: Al recuperar datos desde el lector de Placa.")
      End Try
   End Sub

   Private Sub btnPreverInfome_Click(sender As System.Object, e As System.EventArgs) Handles btnPreverInfome.Click
      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook

      ' Comprobar la existencia del archivo.
      If verificarSiExisteArchivo(txtNombrePlaca.Text) Then
         excelApp.Visible = True
         'Este se coloca para que el usuario tenga el control del archivo de excel, cuando el lo cierra VB no tiene que liberarlo.
         excelApp.UserControl = True
         libroExcel = excelApp.Workbooks.Open(txtNombrePlaca.Text, True)
         releaseObject(excelApp)
      Else
         MessageBox.Show("No se encuentra el archivo buscado de la placa.", "ERROR: Mensaje del Sistema", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
         btnPreverInfome.Enabled = False
      End If

   End Sub
End Class