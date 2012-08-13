Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class frmCapturaCySC

   Dim totalCasos() As listaCasos
   Dim posCasoActual As Integer = 0
   Dim numeroSubcasos As Integer = 0
   Dim numero As Integer = 0
   Dim bandera As Boolean = True
  

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         txtDatosRecibidos.Text = ""
         az = SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
      txtDatosRecibidos.Text = msn
   End Sub

   Private Sub txtNoControlesPositivos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesPositivos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtNoControlesNegativos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesNegativos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesNegativos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtNoDeCasos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoDeCasos.TextChanged
      Try
         controlesValidosNumero(txtNoDeCasos, "En número de casos, ", 1, 96)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtNoSubcasos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoSubcasos.TextChanged
      Try
         controlesValidosNumero(txtNoSubcasos, "En número de subcasos, ", 1, 94)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeLetra_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra, " Desde Pozo x", "A", "H")
   End Sub

   Private Sub txtDesdeValor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor.TextChanged
      controlesValidosNumero(txtDesdeValor, " Desde Pozo y", 1, 12)
   End Sub

   Private Sub txtHastaLetra_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra, " Hasta Pozo x ", "A", "H")
   End Sub

   Private Sub txtHastaValor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor.TextChanged
      controlesValidosNumero(txtHastaValor, " Hasta Pozo y ", 1, 12)
   End Sub


   Private Sub btnAceptarEnfermedad_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarEnfermedad.Click
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      If controlesValidosNumero(txtNoDeCasos, " Valor en número de casos ", 1, 8) AndAlso _
         controlesValidosNumero(txtNoControlesPositivos, " Valor en número de controles ", 2, 3) AndAlso _
         controlesValidosNumero(txtNoControlesNegativos, " Valor en número de controles ", 2, 3) Then
         ckbControlesDefault.Enabled = True
         btnAceptarControles.Enabled = True
         btnDefinirControlesPN.Enabled = True
         Try
            cmbNombreEnfermedad.Enabled = False
            txtNoDeCasos.Enabled = False
            txtNoControlesPositivos.Enabled = False
            txtNoControlesNegativos.Enabled = False
            defineBotonesPositivos(nocp, lblCPNo1, lblCPNo2, lblCPNo3, txtCP1Letra1, txtCP1Valor1, _
                                   txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
            defineBotonesNegativos(nocn, lblCNNo1, lblCNNo2, lblCNNo3, txtCN1Letra1, txtCN1Valor1, _
                                   txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)
            dibujaTablaEnPantalla(dgvPlacaLeida)
            btnAceptarEnfermedad.Enabled = False
            Dim oConexion As MySqlConnection
            Dim aConsulta As String = ""
            Dim oDataReader As MySqlDataReader
            Dim oComando As New MySqlCommand
            oConexion = New MySqlConnection
            'Separa el texto del comboBox 
            Dim cadena As String
            Dim tabla() As String
            cadena = cmbNombreEnfermedad.Text
            tabla = Split(cadena, " | ")
            oConexion.ConnectionString = cadenaConexion
            aConsulta = "SELECT logSPS,logTit1,logTit2 FROM analisis a WHERE id_analysis='" & tabla(0) & "';"
            oComando.Connection = oConexion
            oComando.CommandText = aConsulta
            oConexion.Open()
            oDataReader = oComando.ExecuteReader()
            If oDataReader.HasRows Then
               While oDataReader.Read()
                  lblIdAnalisis.Text = tabla(0)
                  lblLogSPS.Text = oDataReader("logSPS").ToString()
                  lblLogTit1.Text = oDataReader("logTit1").ToString()
                  lblLogTit2.Text = oDataReader("logTit2").ToString()
               End While
               oDataReader.Close()
               lblMensajeCaso.Text = ""
               'btnInserta.Enabled = True
               txtNoSubcasos.Text = "1"
               'limpiaInformacionCaso()
               'statusDeCasoMostrados(True)
               'txtMensajeSobreGrafica.Enabled = True
               'txtMensajeSobreGrafica.ReadOnly = False
               'estatusDesdeHasta(False)
            Else
               mensajeRojo(lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
            End If
            oConexion.Close()
         Catch ex As MySqlException
            mensajeExceptionSQL(lblMensajeCaso, ex)
         Catch ex As DataException
            mensajeException(lblMensajeCaso, ex)
         Catch ex As Exception
            mensajeException(lblMensajeCaso, ex)
         End Try
      Else
         mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para no. de casos y no. de controles + y - no son válidos, trate nuevamente.")
         cmbNombreEnfermedad.Enabled = True
         txtNoDeCasos.Enabled = True
         txtNoControlesPositivos.Enabled = True
         txtNoControlesNegativos.Enabled = True
         btnAceptarEnfermedad.Enabled = True
      End If
   End Sub

   Private Sub btnDefinirControlesPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True
      btnAceptarEnfermedad.Enabled = False
      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
         'btnFormateaDatos.Enabled = False
         btnLeerDatosPlaca.Enabled = False
      Else
         btnAceptarControles.Enabled = True
      End If
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

                  If queSeanDistintos(lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then

                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnCapturaTerminada.Enabled = True

                     'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
                     habilitaBarrita(False)
                     btnInsertar.Enabled = True
                     btnEditar.Enabled = False
                     btnGuardar.Enabled = True
                  Else
                     mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True


                  End If
               Else
                  mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
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
                  If queSeanDistintos(lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)


                     mensajeVerde(lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False

                     'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
                     habilitaBarrita(False)
                     btnInsertar.Enabled = True
                     btnEditar.Enabled = False

                     btnCapturaTerminada.Enabled = True

                  Else
                     mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True


                  End If
               Else
                  mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
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
                  If queSeanDistintos(lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then


                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False

                      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
                     habilitaBarrita(False)
                     btnInsertar.Enabled = True
                     btnEditar.Enabled = False

                     btnCapturaTerminada.Enabled = True
                  Else
                     mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
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

                  If queSeanDistintos(lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CP3-CN3", txtCP3Letra3, txtCP3Valor3, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(lblMensajeCaso, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then


                     'Colocados aqui el 6-Ago-2012
                     coloreaControlesPositivos(nocp, dgvPlacaLeida, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
                     coloreaControlesNegativos(nocn, dgvPlacaLeida, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)

                     mensajeVerde(lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     btnCapturaTerminada.Enabled = True
                     'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
                     habilitaBarrita(False)
                     btnInsertar.Enabled = True
                     btnEditar.Enabled = False

                  Else
                     mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If
            End If
      End Select
   End Sub


   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         If btnLeerDatosPlaca.Text = "Obtener Datos" Then
            btnLeerDatosPlaca.Text = "Desconectar"
            Setup_Puerto_SerieParametros(SerialPort1, cmbComboPorts, lblMensajeCaso, lblNombreLector)
         Else
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
               mensajeVerde(lblMensajeCaso, "Mensaje: Cerrando el puerto COM del lector.")
               btnLeerDatosPlaca.Enabled = False
               'btnFormateaDatos.Enabled = True
               presentaDatosEnPantallaFormateados()
            End If
         End If
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub

   Private Sub presentaDatosEnPantallaFormateados()
      'Dim noCasos As Integer = CInt(txtNoDeCasos.Text)
      'Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      'Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      btnLeerDatosPlaca.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "ERROR: Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         formateaDatos(placaLector, dgvPlacaLeida)
         organizaEnTabla(dgvPlacaLeida, placaLector)
         btnGuardaDatos.Enabled = True

      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "ERROR: Se ha presentado un error al formatear datos.")
      End Try
   End Sub

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbControlesDefault.CheckedChanged
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      defineValoresDefaultPositivos(nocp, txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3)
      defineValoresDefaultNegativos(nocn, txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3)
      ckbControlesDefault.Enabled = False
      grbControlesPositivos.Enabled = False
      grbControlesNegativos.Enabled = False
      btnAceptarControles.Enabled = True
      ckbControlesDefault.Enabled = False
   End Sub

   Private Sub frmCapturaCySC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      GetSerialPortNamesParametros(cmbComboPorts, lblMensajeCaso)
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
      ToolTip1.SetToolTip(btnInicio, "Ir al 1er. análisis")
      ToolTip1.SetToolTip(btnHaciaAtras, "Ir al análisis anterior")
      ToolTip1.SetToolTip(btnHaciaAdelante, "Ir al análisis siguiente")
      ToolTip1.SetToolTip(btnFin, "Ir al último análisis")
      ToolTip1.SetToolTip(btnInsertar, "Insertar nuevo análisis")
      ToolTip1.SetToolTip(btnEditar, "Modificar un análisis")
      ToolTip1.SetToolTip(btnGuardar, "Guardar un análisis nuevo")
      ToolTip1.SetToolTip(btnBuscaCaso, "Buscar un No. de Caso")
   End Sub

   Private Sub btnBuscaCaso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.descripcion as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservaciones.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            'lblMensajeCaso.Text = ""
         Else
            mensajeRojo(lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso.Click
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%BRONQUITIS%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   '####################################################################################
   '#ESTA SECCION PERMITE DESPLAZARSE SOBRE LOS BOTONES BARRITA PARA BOTONES QUE AVANZAN
   '#ATRAS-ADELANTE, INICIO-FIN, Y MODIFICAR LOS DATOS DE UN CASO
   '####################################################################################

   Private Sub statusDeCasoMostrados(ByVal estado As Boolean)
      cmbNoCaso.Enabled = estado
      btnBuscaCaso.Enabled = estado
      txtAnalisisSolicitado.Enabled = estado
      txtNombreCliente.Enabled = estado
      txtMensajeSobreGrafica.Enabled = estado
      lblObservaciones.Enabled = estado
      txtDesdeLetra.Enabled = estado
      txtDesdeValor.Enabled = estado
      txtHastaLetra.Enabled = estado
      txtHastaValor.Enabled = estado
      chkSubCasos.Enabled = estado
   End Sub

   Private Sub estatusDesdeHasta(ByVal estado As Boolean)
      'Habilita o deshabilita la lectura sobre las cajas de texto
      txtDesdeLetra.ReadOnly = estado
      txtDesdeValor.ReadOnly = estado
      txtHastaLetra.ReadOnly = estado
      txtHastaValor.ReadOnly = estado
   End Sub

   Private Sub habilitaDesdeHasta(ByVal estado As Boolean)
      'Habilita o deshabilita la lectura sobre las cajas de texto
      txtDesdeLetra.Enabled = estado
      txtDesdeValor.Enabled = estado
      txtHastaLetra.Enabled = estado
      txtHastaValor.Enabled = estado
   End Sub

   Private Sub limpiaInformacionCaso()
      cmbNoCaso.Items.Clear()
      cmbNoCaso.Text = " "
      txtAnalisisSolicitado.Text = ""
      txtNombreCliente.Text = ""
      txtMensajeSobreGrafica.Text = ""
      lblObservaciones.Text = ""
      txtDesdeLetra.Text = "A"
      txtDesdeValor.Text = "1"
      txtHastaLetra.Text = "A"
      txtHastaValor.Text = "1"
      chkSubCasos.Checked = False
      'Habilita o deshabilita la lectura sobre las cajas de texto
      txtDesdeLetra.ReadOnly = False
      txtDesdeValor.ReadOnly = False
      txtHastaLetra.ReadOnly = False
      txtHastaValor.ReadOnly = False
   End Sub

   Private Sub cargarDatosCaso()
      Try
         statusDeCasoMostrados(False)
         txtMensajeSobreGrafica.ReadOnly = True
         cmbNoCaso.Text = totalCasos(posCasoActual).noCaso
         txtAnalisisSolicitado.Text = totalCasos(posCasoActual).analisis
         txtNombreCliente.Text = totalCasos(posCasoActual).cliente
         txtMensajeSobreGrafica.Text = totalCasos(posCasoActual).texto
         lblObservaciones.Text = totalCasos(posCasoActual).obs
         txtDesdeLetra.Text = obtenLetra(totalCasos(posCasoActual).desdeLetra)
         txtDesdeValor.Text = totalCasos(posCasoActual).desdeValor
         txtHastaLetra.Text = obtenLetra(totalCasos(posCasoActual).hastaLetra)
         txtHastaValor.Text = totalCasos(posCasoActual).hastaValor
         lblCasoDeCaso.Text = "Caso: " & posCasoActual + 1 & " de " & UBound(totalCasos)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub guardaCasoEnArreglo()
      'MessageBox.Show("Voy a guardar: " & cmbNoCaso.Text & vbTab & lblNoSubCaso.Text & vbTab _
      '                & txtAnalisisSolicitado.Text & vbTab & txtNombreCliente.Text & vbTab & txtMensajeSobreGrafica.Text _
      '                & vbTab & siValorEsLetra(txtDesdeLetra) & vbTab & txtDesdeValor.Text & vbTab & siValorEsLetra(txtHastaLetra) _
      '                & vbTab & txtHastaValor.Text)
      totalCasos(posCasoActual).noCaso = cmbNoCaso.Text
      totalCasos(posCasoActual).subCaso = CInt(lblNoSubCaso.Text)
      totalCasos(posCasoActual).analisis = txtAnalisisSolicitado.Text
      totalCasos(posCasoActual).cliente = txtNombreCliente.Text
      totalCasos(posCasoActual).texto = txtMensajeSobreGrafica.Text
      totalCasos(posCasoActual).obs = lblObservaciones.Text
      totalCasos(posCasoActual).desdeLetra = siValorEsLetra(txtDesdeLetra)
      totalCasos(posCasoActual).desdeValor = CInt(txtDesdeValor.Text)
      totalCasos(posCasoActual).hastaLetra = siValorEsLetra(txtHastaLetra)
      totalCasos(posCasoActual).hastaValor = CInt(txtHastaValor.Text)
      coloreaCasos(dgvPlacaLeida, Color.Yellow, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      lblCasoDeCaso.Text = "Caso: " & posCasoActual + 1 & " de " & UBound(totalCasos)
   End Sub

   Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
      posCasoActual = 0
      statusDeCasoMostrados(False)
      txtMensajeSobreGrafica.ReadOnly = True
      estatusDesdeHasta(True)
      cargarDatosCaso()
   End Sub


   Private Sub btnHaciaAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAtras.Click
      Try
         If posCasoActual = 0 Then
            mensajeRojo(lblMensajeCaso, "Mensaje: Usted se encuentra en el primer Caso.")
         Else
            'Disminuir el marcador del registro y actualizar en pantalla con los datos del registro actual
            posCasoActual -= 1
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            cargarDatosCaso()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnHaciaAdelante_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAdelante.Click
      Try
         If posCasoActual = (UBound(totalCasos) - 1) Then
            mensajeRojo(lblMensajeCaso, "Mensaje: Usted se encuentra en el último caso.")
         Else
            posCasoActual += 1
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            cargarDatosCaso()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnFin_Click(sender As System.Object, e As System.EventArgs) Handles btnFin.Click
      Try
         'Ira l ultimo registro colocando la variable al no. máximo de datos en la tabla menos 1 porque las posiciones comienzan en cero
         posCasoActual = (UBound(totalCasos) - 1)
         statusDeCasoMostrados(False)
         txtMensajeSobreGrafica.ReadOnly = True
         estatusDesdeHasta(True)
         cargarDatosCaso()
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
      statusDeCasoMostrados(True)
      txtMensajeSobreGrafica.ReadOnly = False
      estatusDesdeHasta(False)
      coloreaCasos(dgvPlacaLeida, Color.White, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      btnEditar.Enabled = False
      btnInsertar.Enabled = False
      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      btnGuardarEditado.Enabled = True
   End Sub

   Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
      Dim i As Integer = 0
      Dim largo As Integer = 0

      'Try
      btnGuardar.Enabled = False
      btnEditar.Enabled = False

      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      'Este if valida si el numero es cero, entonces no recorre el arreglo para revisar otros valores anteriores definidos
      'Para el caso.
      'En caso de que el numero de capturados es menor o igual que los solicitados por el usuario, valida los datos y guarda
      'Si el numero ya es exactamente igual a los casos solicitados, desactiva el boton de insertar y activa la barrita
      'De botones atras y adelante para que el usuario tenga la opcion de editar algun registro y modifarlo.
      If numero = 0 Then

         ReDim Preserve totalCasos(numero + 1)
         If siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
             controlesValidosLetra(txtDesdeLetra, "Caso " & (numero + 1), "A", "H") AndAlso _
             controlesValidosNumero(txtDesdeValor, "Caso " & (numero + 1), 1, 12) AndAlso _
             controlesValidosLetra(txtHastaLetra, "Caso " & (numero + 1), "A", "H") AndAlso _
             controlesValidosNumero(txtHastaValor, "Caso " & (numero + 1), 1, 12) AndAlso _
             desdeHastaValidos("Caso " & (numero + 1), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) AndAlso _
             revisaQueCasosNoSeanIguales(cmbNoCaso, totalCasos) AndAlso _
             validaTodosLosCPParaUnCaso(cmbNoCaso.Text, txtNoControlesPositivos.Text, _
                                    txtCP1Letra1, txtCP1Valor1, _
                                    txtCP2Letra2, txtCP2Valor2, _
                                    txtCP3Letra3, txtCP3Valor3, _
                                    txtDesdeLetra, txtDesdeValor, _
                                    txtHastaLetra, txtHastaValor) AndAlso _
             validaTodosLosCNParaUnCaso(cmbNoCaso.Text, txtNoControlesNegativos.Text, _
                                    txtCN1Letra1, txtCN1Valor1, _
                                    txtCN2Letra2, txtCN2Valor2, _
                                    txtCN3Letra3, txtCN3Valor3, _
                                    txtDesdeLetra, txtDesdeValor, _
                                    txtHastaLetra, txtHastaValor) Then
            'MessageBox.Show("Entre a la validacion numero=0 y los controles positivos no se encuentran dentro del caso")
            posCasoActual = numero
            guardaCasoEnArreglo()
            numero += 1
            btnInsertar.Enabled = True
            mensajeVerde(lblMensajeCaso, "Mensaje: Usted guardó el caso No." & numero & " de " & txtNoDeCasos.Text)
         Else
            mensajeRojo(lblMensajeCaso, "Los valores que se introdujeron se encuentran en el mismo rango que los controles positivos o negativos, Verifique.")
            btnInsertar.Enabled = False
            btnEditar.Enabled = False
            btnGuardar.Enabled = True
         End If
         'Verifica que no se han excedido el número de casos solicitados.
      ElseIf (numero <= CInt(txtNoDeCasos.Text)) Then

         largo = UBound(totalCasos)
         'Para todos los casos validar que no se encuentre en el rango de valores positivos y negativos
         'Validar desde - hasta definido en el caso
         'Validar desde-hasta con otros casos ya guardados.
         'Si se cumple la condicion, entonces Guardar en el arreglo
         If siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
             controlesValidosLetra(txtDesdeLetra, "Caso " & numero, "A", "H") AndAlso _
             controlesValidosNumero(txtDesdeValor, "Caso " & numero, 1, 12) AndAlso _
             controlesValidosLetra(txtHastaLetra, "Caso " & numero, "A", "H") AndAlso _
             controlesValidosNumero(txtHastaValor, "Caso " & numero, 1, 12) AndAlso _
             desdeHastaValidos("Caso " & numero, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) AndAlso _
             revisaQueCasosNoSeanIguales(cmbNoCaso, totalCasos) AndAlso _
             validaTodosLosCPParaUnCaso(cmbNoCaso.Text, txtNoControlesPositivos.Text, _
                                       txtCP1Letra1, txtCP1Valor1, _
                                       txtCP2Letra2, txtCP2Valor2, _
                                       txtCP3Letra3, txtCP3Valor3, _
                                       txtDesdeLetra, txtDesdeValor, _
                                       txtHastaLetra, txtHastaValor) AndAlso _
             validaTodosLosCNParaUnCaso(cmbNoCaso.Text, txtNoControlesNegativos.Text, _
                                       txtCN1Letra1, txtCN1Valor1, _
                                       txtCN2Letra2, txtCN2Valor2, _
                                       txtCN3Letra3, txtCN3Valor3, _
                                       txtDesdeLetra, txtDesdeValor, _
                                       txtHastaLetra, txtHastaValor) Then


            While (validaSiDosCasosEstanEnDistintoRangoArreglo("Caso capturado y " & numero, _
            txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor, _
            totalCasos(i).desdeLetra, totalCasos(i).desdeValor, _
            totalCasos(i).hastaLetra, totalCasos(i).hastaValor) And (i <= (largo - 1)))
               'MessageBox.Show("Valor de largo en while: " & largo & "y con i: " & i & "desdeletra " _
               '                & txtDesdeLetra.Text & "desdevalor " & txtDesdeValor.Text & "hastaletra " & txtHastaLetra.Text & " hastavalor " _
               '                & txtHastaValor.Text & " letrarango1 " & totalCasos(i).desdeLetra & " valorrango1 " & totalCasos(i).desdeValor _
               '                & " letrarango2" & totalCasos(i).hastaLetra & " valorrango2 " & totalCasos(i).hastaValor)
               i += 1
            End While

            If i = largo Then
               ReDim Preserve totalCasos(largo + 1)
               numero += 1
               posCasoActual = numero - 1
               guardaCasoEnArreglo()
               btnInsertar.Enabled = True
               mensajeVerde(lblMensajeCaso, "Mensaje: Usted guardó el caso No." & numero & " de " & txtNoDeCasos.Text)
            Else
               MessageBox.Show("Los valores que se introdujeron se encuentran en el mismo rango que los del caso" & totalCasos(i).noCaso & ", Verifique.")
               btnInsertar.Enabled = False
               btnEditar.Enabled = False
               btnGuardar.Enabled = True
            End If
         Else
            mensajeRojo(lblMensajeCaso, "Los valores que se introdujeron se encuentran en el mismo rango que los controles positivos o negativos, Verifique.")
            btnInsertar.Enabled = False
            btnEditar.Enabled = False
            btnGuardar.Enabled = True
         End If
         'En caso de que el número sea igual, manda el mensaje de que ya no se pueden capturar más casos")
         If (numero = CInt(txtNoDeCasos.Text)) Then
            mensajeRojo(lblMensajeCaso, "MENSAJE: Usted ha capturado el total de casos solicitados.")
            btnInsertar.Enabled = False
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.Enabled = False
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            habilitaDesdeHasta(False)
            btnEditar.Enabled = True
            'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
            habilitaBarrita(True)
         End If
      End If


         'Catch ex As Exception
         '   mensajeException(lblMensajeCaso, ex)
         'End Try
   End Sub

   Private Sub habilitaBarrita(ByVal estatus As Boolean)
      btnInicio.Enabled = estatus
      btnHaciaAdelante.Enabled = estatus
      btnHaciaAtras.Enabled = estatus
      btnFin.Enabled = estatus
   End Sub


   Private Sub chkSubCasos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSubCasos.CheckedChanged
      If (chkSubCasos.Checked = True) Then
         chkSubCasos.Enabled = False
         txtNoSubcasos.Visible = True
         txtNoSubcasos.Enabled = True
         txtNoSubcasos.Focus()
         'btnInserta.Enabled = False
         'btnInsertaSubcaso.Enabled = True
      Else
         'HACER ALGO QUE BORRE LOS CASOS DEL ARREGLO
      End If
   End Sub



   Private Sub btnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertar.Click
      'If numero = 0 Then
      '   mensajeVerde(lblMensajeCaso, "Mensaje: Usted captura el Análisis No." & numero + 1 & " de " & txtNoDeCasos.Text)
      'Else
      mensajeVerde(lblMensajeCaso, "Mensaje: Usted captura el Análisis No." & numero + 1 & " de " & txtNoDeCasos.Text)
      'End If
      limpiaInformacionCaso()
      statusDeCasoMostrados(True)
      txtMensajeSobreGrafica.Enabled = True
      txtMensajeSobreGrafica.ReadOnly = False
      estatusDesdeHasta(False)
      btnInsertar.Enabled = False
      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      btnEditar.Enabled = False
      btnGuardar.Enabled = True
   End Sub




   Private Sub btnGuardarEditado_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarEditado.Click
      bandera = True
      Dim i As Integer = 0
      Dim tamano As Integer = 0
      'validar que no se contengan los valores + ó -
      If siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
             controlesValidosLetra(txtDesdeLetra, "Caso " & numero, "A", "H") AndAlso _
             controlesValidosNumero(txtDesdeValor, "Caso " & numero, 1, 12) AndAlso _
             controlesValidosLetra(txtHastaLetra, "Caso " & numero, "A", "H") AndAlso _
             controlesValidosNumero(txtHastaValor, "Caso " & numero, 1, 12) AndAlso _
             desdeHastaValidos("Caso " & numero, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) AndAlso _
             validaTodosLosCPParaUnCaso(cmbNoCaso.Text, txtNoControlesPositivos.Text, _
                                      txtCP1Letra1, txtCP1Valor1, _
                                      txtCP2Letra2, txtCP2Valor2, _
                                      txtCP3Letra3, txtCP3Valor3, _
                                      txtDesdeLetra, txtDesdeValor, _
                                      txtHastaLetra, txtHastaValor) AndAlso _
             validaTodosLosCNParaUnCaso(cmbNoCaso.Text, txtNoControlesNegativos.Text, _
                                      txtCN1Letra1, txtCN1Valor1, _
                                      txtCN2Letra2, txtCN2Valor2, _
                                      txtCN3Letra3, txtCN3Valor3, _
                                      txtDesdeLetra, txtDesdeValor, _
                                      txtHastaLetra, txtHastaValor) Then

         'Recorrer el arreglo para validar que el caso modificado no tiene valores de rango de los que ya se encuentran capturados.
         tamano = UBound(totalCasos) - 1
         For i = 0 To tamano

            If (i <> posCasoActual) Then

               'MessageBox.Show("Voy en i: " & i & " con posicion: " & posCasoActual)

               If Not validaSiDosCasosEstanEnDistintoRangoArreglo("Caso capturado y caso" & (i + 1), _
                          txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor, _
                          totalCasos(i).desdeLetra, totalCasos(i).desdeValor, _
                          totalCasos(i).hastaLetra, totalCasos(i).hastaValor) Then
                  MessageBox.Show("Los valores que se introdujeron e encuentran en el mismo rango que los del caso " & totalCasos(i).noCaso & ", Verifique.")
                  bandera = False
                  Exit For
               End If
            End If
         Next


         If (bandera = True) Then
            'MessageBox.Show("llego al final del arreglo y los valores son validos")
            guardaCasoEnArreglo()
            habilitaBarrita(True)
            btnGuardarEditado.Enabled = False
            btnEditar.Enabled = True
            mensajeVerde(lblMensajeCaso, "Mensaje: Usted actualizó el caso No." & numero & " de " & txtNoDeCasos.Text)
         End If
      Else
         mensajeRojo(lblMensajeCaso, "Los valores que se introdujeron se encuentran en el mismo rango que los controles positivos o negativos, Verifique.")
         btnGuardarEditado.Enabled = True
      End If

   End Sub

End Class