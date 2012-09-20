﻿Public Class frmLecturaDePlaca

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         txtDatosRecibidos.Text = ""
         az = Me.SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
      Me.txtDatosRecibidos.Text = msn
   End Sub

   Private Sub frmLecturaDePlaca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      GetSerialPortNamesParametros(cmbComboPorts, frmElisaBiovetsa.lblMensajeAplicacion)
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
   End Sub

   Private Sub defineValoresNegativos(ByVal nocn As Integer)
      Select Case nocn
         Case 2
            'Hace visible las etiquetas para dos controles negativos
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = False
            'Hace visible controles negativos para dos controles
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = False
            txtCN3Valor3.Visible = False
         Case 3
            'Hace visible las etiquetas para ontrolesnegativos
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = True
            'Hace visible controles negativos 
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = True
            txtCN3Valor3.Visible = True
      End Select
   End Sub


   Private Sub defineValoresPositivos(ByVal nocp As Integer)
      Select Case nocp
         Case 2
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = False
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = False
            txtCP3Valor3.Visible = False
         Case 3
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = True
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = True
            txtCP3Valor3.Visible = True
      End Select
   End Sub

   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
         Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
         If Me.btnLeerDatosPlaca.Text = "Obtener Datos" Then
            Me.btnLeerDatosPlaca.Text = "Desconectar"
            Setup_Puerto_SerieParametros(SerialPort1, cmbComboPorts, frmElisaBiovetsa.lblMensajeAplicacion, Me.lblNombreLector)
         Else
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
               mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Cerrando el puerto COM del lector.")
               btnLeerDatosPlaca.Enabled = False
               formatearDatos()
               coloreaControlesPositivos(nocp)
               coloreaControlesNegativos(nocn)
               Me.btnLeerDatosPlaca.Enabled = False
               txtNoControlesPositivos.Enabled = True
               txtNoControlesPositivos.Focus()
               btnAceptarCPN.Enabled = True
            End If
         End If
      Catch ex As Exception
         mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub


   Private Sub coloreaControlesNegativos(ByVal nocn As Integer)
      Select Case nocn
         Case 2
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
         Case 3
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN3Letra3)), CInt(txtCN3Valor3.Text))
      End Select
   End Sub

   Private Sub coloreaControlesPositivos(ByVal nocp As Integer)
      Select Case nocp
         Case 2
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), CInt(txtCP1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), CInt(txtCP2Valor2.Text))
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
         Case 3
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), CInt(txtCP1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), CInt(txtCP2Valor2.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP3Letra3)), CInt(txtCP3Valor3.Text))
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN3Letra3)), CInt(txtCN3Valor3.Text))
      End Select
   End Sub

   Private Sub txtNoControlesPositivos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesPositivos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub txtNoControlesNegativos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesNegativos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesNegativos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub defineValoresDefaultPositivos(ByVal nocp As Integer)
      If (nocp = 3) Then
         txtCP1Letra1.Text = "A"
         txtCP1Valor1.Text = "1"
         txtCP2Letra2.Text = "A"
         txtCP2Valor2.Text = "3"
         txtCP3Letra3.Text = "H"
         txtCP3Valor3.Text = "11"
      ElseIf (nocp = 2) Then
         txtCP1Letra1.Text = "A"
         txtCP1Valor1.Text = "1"
         txtCP2Letra2.Text = "A"
         txtCP2Valor2.Text = "3"
      End If
   End Sub

   Private Sub defineValoresDefaultNegativos(ByVal nocn As Integer)
      If (nocn = 3) Then
         txtCN1Letra1.Text = "A"
         txtCN1Valor1.Text = "2"
         txtCN2Letra2.Text = "H"
         txtCN2Valor2.Text = "10"
         txtCN3Letra3.Text = "H"
         txtCN3Valor3.Text = "12"
      ElseIf (nocn = 2) Then
         txtCN1Letra1.Text = "A"
         txtCN1Valor1.Text = "2"
         txtCN2Letra2.Text = "H"
         txtCN2Valor2.Text = "10"
      End If
   End Sub



   Private Sub formatearDatos()
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      btnLeerDatosPlaca.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, " Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         formateaDatos(placaLector, Me.dgvPlacaLeida)
         organizaEnTabla(Me.dgvPlacaLeida, placaLector)
         'btnGuardaDatos.Enabled = True
         coloreaControlesPositivos(nocp)
         coloreaControlesNegativos(nocn)
      Catch ex As Exception
         mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, " Se ha presentado un error al formatear datos.")
      End Try
   End Sub


   Private Sub btnGuardaDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaDatos.Click
      Try
         btnDefinirControlesPN.Enabled = False
         btnAceptarControles.Enabled = False
         Dim nocp As Integer = CInt(txtNoControlesPositivos.Text)
         Dim nocn As Integer = CInt(txtNoControlesNegativos.Text)
         Dim cpx1 As Integer = siValorEsLetra(Me.txtCP1Letra1)
         Dim cpx2 As Integer = siValorEsLetra(Me.txtCP2Letra2)
         Dim cpy1 As Integer = CInt(Me.txtCP1Valor1.Text) - 1
         Dim cpy2 As Integer = CInt(Me.txtCP2Valor2.Text) - 1
         Dim cnx1 As Integer = siValorEsLetra(Me.txtCN1Letra1)
         Dim cnx2 As Integer = siValorEsLetra(Me.txtCN2Letra2)
         Dim cny1 As Integer = CInt(Me.txtCN1Valor1.Text) - 1
         Dim cny2 As Integer = CInt(Me.txtCN2Valor2.Text) - 1
         Dim desdex As Integer = 0
         Dim hastax As Integer = 7
         Dim desdey As Integer = 3
         Dim hastay As Integer = 9

         'Asigna valor default a la definición de cp para x y y.
         Dim cpx3 As Integer = 0
         Dim cnx3 As Integer = 0
         Dim cpy3 As Integer = 0
         Dim cny3 As Integer = 0
         Dim consecutivo As Integer = 0
         'Verifica si  son tres controles positivos
         If (nocp = 3) Then
            cpx3 = siValorEsLetra(Me.txtCP3Letra3)
            cpy3 = CInt(Me.txtCP3Valor3.Text) - 1
            desdex = 0
            hastax = 7
            desdey = 3
            hastay = 8
         End If
         'Verifica si  son tres controles negativos
         If (nocn = 3) Then
            cnx3 = siValorEsLetra(Me.txtCN3Letra3)
            cny3 = CInt(Me.txtCN3Valor3.Text) - 1
            desdex = 0
            hastax = 7
            desdey = 3
            hastay = 8
         End If
         guardarDatosExcel(placaLector, nocp, nocn, "", "", consecutivo, cpx1, cpx2, cpx3, cnx1, cnx2, cnx3, cpy1, _
                          cpy2, cpy3, cny1, cny2, cny3, desdex, desdey, hastax, hastay, frmElisaBiovetsa.lblMensajeAplicacion)
         mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Los datos de la placa original se guardaron exitosamente.")
         btnGuardaDatos.Enabled = False
      Catch ex As Exception
         mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Al guardar los datos de la placa original en excel, btnGuardaDatos_Click.")
      End Try
   End Sub


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
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) Then

                  If queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then

                     mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnGuardaDatos.Enabled = True

                  Else
                     mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                     btnAceptarControles.Enabled = True
                  End If
               Else
                  mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
               End If

            ElseIf (nocn = 3) Then
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) AndAlso
                  controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12) Then
                  If queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnGuardaDatos.Enabled = True

                  Else
                     mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                     btnAceptarControles.Enabled = True
                  End If
               Else
                  mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
                  btnAceptarControles.Enabled = True
               End If
            End If
         Case 3
            If (nocn = 2) Then
               '1. Valida que esten en rango de letras y numeros A-H y 1-12.
               '2. Verifica que ningun valor de control positivo o negativo se duplique.
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
                 controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                 controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                 controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) Then
                  If queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then

                     mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnGuardaDatos.Enabled = True

                  Else
                     mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                     btnAceptarControles.Enabled = True
                  End If
               Else
                  mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
               End If
            ElseIf (nocn = 3) Then
               If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
                  controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) AndAlso _
                  controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) AndAlso
                  controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") AndAlso _
                  controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12) Then

                  If queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CP3-CN3", txtCP3Letra3, txtCP3Valor3, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(frmElisaBiovetsa.lblMensajeAplicacion, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnGuardaDatos.Enabled = True

                  Else
                     mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                     btnAceptarControles.Enabled = True
                  End If
               Else
                  mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
               End If
            End If
      End Select
   End Sub

   Private Sub btnDefinirControlesPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True

      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
      Else
         btnAceptarControles.Enabled = True
      End If
   End Sub

   Private Sub txtNoControles_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesPositivos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnAceptarCPN_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarCPN.Click
      If controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3) AndAlso _
         controlesValidosNumero(txtNoControlesNegativos, " En número de controles + y - ", 2, 3) Then
         Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
         Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
         txtNoControlesPositivos.Enabled = False
         txtNoControlesNegativos.Enabled = False
         btnAceptarCPN.Enabled = False
         ckbControlesDefault.Enabled = True
         btnAceptarControles.Enabled = True
         btnDefinirControlesPN.Enabled = True
         defineValoresPositivos(nocp)
         defineValoresNegativos(nocn)
      Else
         MessageBox.Show("ERROR: Los valores que ha introducido para no. de controles + y - no son válidos, trate nuevamente.")
         txtNoControlesPositivos.Enabled = True
         btnAceptarCPN.Enabled = True
      End If

   End Sub

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbControlesDefault.CheckedChanged
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      defineValoresDefaultPositivos(nocp)
      defineValoresDefaultNegativos(nocn)
      ckbControlesDefault.Enabled = False
      grbControlesPositivos.Enabled = False
      grbControlesNegativos.Enabled = False
      btnAceptarControles.Enabled = True
   End Sub
End Class