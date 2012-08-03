Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmBronquitisAviar

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub txtNoDeCasos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoDeCasos.TextChanged
      Try
         controlesValidosNumero(txtNoDeCasos, "En número de casos, ", 1, 8)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub habilitaTabsCorrectos(ByRef noCasos As String)
      Select Case noCasos
         Case 1
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = False
            tbcCaso3.Enabled = False
            tbcCaso4.Enabled = False
            tbcCaso5.Enabled = False
            tbcCaso6.Enabled = False
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso2.Parent = Nothing
            tbcCaso3.Parent = Nothing
            tbcCaso4.Parent = Nothing
            tbcCaso5.Parent = Nothing
            tbcCaso6.Parent = Nothing
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 2
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = False
            tbcCaso4.Enabled = False
            tbcCaso5.Enabled = False
            tbcCaso6.Enabled = False
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso3.Parent = Nothing
            tbcCaso4.Parent = Nothing
            tbcCaso5.Parent = Nothing
            tbcCaso6.Parent = Nothing
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 3
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = False
            tbcCaso5.Enabled = False
            tbcCaso6.Enabled = False
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso4.Parent = Nothing
            tbcCaso5.Parent = Nothing
            tbcCaso6.Parent = Nothing
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 4
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = True
            tbcCaso5.Enabled = False
            tbcCaso6.Enabled = False
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso5.Parent = Nothing
            tbcCaso6.Parent = Nothing
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 5
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = True
            tbcCaso5.Enabled = True
            tbcCaso6.Enabled = False
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso6.Parent = Nothing
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 6
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = True
            tbcCaso5.Enabled = True
            tbcCaso6.Enabled = True
            tbcCaso7.Enabled = False
            tbcCaso8.Enabled = False
            tbcCaso7.Parent = Nothing
            tbcCaso8.Parent = Nothing
         Case 7
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = True
            tbcCaso5.Enabled = True
            tbcCaso6.Enabled = True
            tbcCaso7.Enabled = True
            tbcCaso8.Enabled = False
            tbcCaso8.Parent = Nothing
         Case 8
            tbcCaso1.Enabled = True
            tbcCaso2.Enabled = True
            tbcCaso3.Enabled = True
            tbcCaso4.Enabled = True
            tbcCaso5.Enabled = True
            tbcCaso6.Enabled = True
            tbcCaso7.Enabled = True
            tbcCaso8.Enabled = True
      End Select
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

                  If queSeanDistintos(Me.lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then

                     mensajeVerde(Me.lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     tbcDatosDelCaso.Enabled = True
                     habilitaTabsCorrectos(txtNoDeCasos.Text)
                     btnCapturaTerminada.Enabled = True

                  Else
                     mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True


                  End If
               Else
                  mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
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
                  If queSeanDistintos(Me.lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     mensajeVerde(Me.lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     tbcDatosDelCaso.Enabled = True
                     habilitaTabsCorrectos(txtNoDeCasos.Text)
                     btnCapturaTerminada.Enabled = True

                  Else
                     mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True


                  End If
               Else
                  mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
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
                  If queSeanDistintos(Me.lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                     queSeanDistintos(Me.lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) Then

                     mensajeVerde(Me.lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     tbcDatosDelCaso.Enabled = True
                     habilitaTabsCorrectos(txtNoDeCasos.Text)
                     btnCapturaTerminada.Enabled = True
                  Else
                     mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
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

                  If queSeanDistintos(Me.lblMensajeCaso, "CP1-CP2", txtCP1Letra1, txtCP1Valor1, txtCP2Letra2, txtCP2Valor2) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP1-CP3", txtCP1Letra1, txtCP1Valor1, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP1-CN1", txtCP1Letra1, txtCP1Valor1, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP1-CN2", txtCP1Letra1, txtCP1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP1-CN3", txtCP1Letra1, txtCP1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP2-CP3", txtCP2Letra2, txtCP2Valor2, txtCP3Letra3, txtCP3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP2-CN1", txtCP2Letra2, txtCP2Valor2, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP2-CN2", txtCP2Letra2, txtCP2Valor2, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP2-CN3", txtCP2Letra2, txtCP2Valor2, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP3-CN1", txtCP3Letra3, txtCP3Valor3, txtCN1Letra1, txtCN1Valor1) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP3-CN2", txtCP3Letra3, txtCP3Valor3, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CP3-CN3", txtCP3Letra3, txtCP3Valor3, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CN1-CN2", txtCN1Letra1, txtCN1Valor1, txtCN2Letra2, txtCN2Valor2) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CN1-CN3", txtCN1Letra1, txtCN1Valor1, txtCN3Letra3, txtCN3Valor3) AndAlso _
                   queSeanDistintos(Me.lblMensajeCaso, "CN2-CN3", txtCN2Letra2, txtCN2Valor2, txtCN3Letra3, txtCN3Valor3) Then

                     mensajeVerde(Me.lblMensajeCaso, "Mensaje:")
                     btnAceptarControles.Enabled = False
                     btnDefinirControlesPN.Enabled = False
                     ckbControlesDefault.Enabled = False
                     tbcDatosDelCaso.Enabled = True
                     habilitaTabsCorrectos(txtNoDeCasos.Text)
                     btnCapturaTerminada.Enabled = True
                  Else
                     mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                     btnDefinirControlesPN.Enabled = True
                     btnAceptarControles.Enabled = True
                     grbControlesPositivos.Enabled = True
                     grbControlesNegativos.Enabled = True
                  End If
               Else
                  mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para controles + y - no son válidos, trate nuevamente.")
                  btnDefinirControlesPN.Enabled = True
                  btnAceptarControles.Enabled = True
                  grbControlesPositivos.Enabled = True
                  grbControlesNegativos.Enabled = True
               End If
            End If
      End Select
   End Sub

   'Private Sub cmbNombreEnfermedad_Click(sender As Object, e As System.EventArgs) Handles cmbNombreEnfermedad.Click
   '   Try
   '      cmbNombreEnfermedad.Items.Clear()
   '      Dim oConexion As MySqlConnection
   '      oConexion = New MySqlConnection
   '      oConexion.ConnectionString = cadenaConexion
   '      Dim oDataAdapter = New MySqlDataAdapter("SELECT  id_analysis as CLAVE, analysis_desc as ENFERMEDAD FROM analisis WHERE analysis_desc like '%INMUNOENSAYO%' AND nomEspecimen='AVES' order by analysis_desc asc", oConexion)
   '      Dim oDataSet As New DataSet()
   '      oConexion.Open()
   '      oDataAdapter.Fill(oDataSet, "analisis")
   '      oConexion.Close()
   '      Dim oTabla As DataTable
   '      oTabla = oDataSet.Tables("analisis")
   '      'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
   '      Dim oFila As DataRow
   '      For Each oFila In oTabla.Rows
   '         Dim cadena As String
   '         cadena = oFila.Item("ENFERMEDAD")
   '         cmbNombreEnfermedad.Items.Add(oFila.Item("CLAVE") & " | " & cadena.Remove(0, 24))
   '      Next
   '   Catch ex As MySqlException
   '      mensajeExceptionSQL(lblMensajeCaso, ex)
   '   Catch ex As DataException
   '      mensajeException(lblMensajeCaso, ex)
   '   Catch ex As Exception
   '      mensajeException(lblMensajeCaso, ex)
   '   End Try
   'End Sub

   Private Sub cmbNoCaso1_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso1.Click
      Try
         cmbNoCaso1.Items.Clear()
         txtNombreClienteC1.Text = ""
         txtAnalisisSolicitadoC1.Text = ""
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
            cmbNoCaso1.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub cmbNoCaso2_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso2.Click
      Try
         cmbNoCaso2.Items.Clear()
         txtNombreClienteC2.Text = ""
         txtAnalisisSolicitadoC2.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso2.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso3_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso3.Click
      Try
         cmbNoCaso3.Items.Clear()
         txtNombreClienteC3.Text = ""
         txtAnalisisSolicitadoC3.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso3.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso4_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso4.Click
      Try
         cmbNoCaso4.Items.Clear()
         txtNombreClienteC4.Text = ""
         txtAnalisisSolicitadoC4.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso4.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso5_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso5.Click
      Try
         cmbNoCaso5.Items.Clear()
         txtNombreClienteC5.Text = ""
         txtAnalisisSolicitadoC5.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso5.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso6_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso6.Click
      Try
         cmbNoCaso6.Items.Clear()
         txtNombreClienteC6.Text = ""
         txtAnalisisSolicitadoC6.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso6.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso7_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso7.Click
      Try
         cmbNoCaso7.Items.Clear()
         txtNombreClienteC7.Text = ""
         txtAnalisisSolicitadoC7.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")

         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion

         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso7.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub cmbNoCaso8_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso8.Click
      Try
         cmbNoCaso8.Items.Clear()
         txtNombreClienteC8.Text = ""
         txtAnalisisSolicitadoC8.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNombreEnfermedad.Text
         tabla = Split(cadena, " | ")
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' and id_analysis='" & tabla(0) & "' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso8.Items.Add(oFila.Item("caso"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
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
            defineBotonesPositivos(nocp, Me.lblCPNo1, Me.lblCPNo2, Me.lblCPNo3, Me.txtCP1Letra1, Me.txtCP1Valor1, _
                                   Me.txtCP2Letra2, Me.txtCP2Valor2, Me.txtCP3Letra3, Me.txtCP3Valor3)
            defineBotonesNegativos(nocn, Me.lblCNNo1, Me.lblCNNo2, Me.lblCNNo3, Me.txtCN1Letra1, Me.txtCN1Valor1, _
                                   Me.txtCN2Letra2, Me.txtCN2Valor2, Me.txtCN3Letra3, Me.txtCN3Valor3)
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
            Else
               mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
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
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido para no. de casos y no. de controles + y - no son válidos, trate nuevamente.")
         cmbNombreEnfermedad.Enabled = True
         txtNoDeCasos.Enabled = True
         txtNoControlesPositivos.Enabled = True
         txtNoControlesNegativos.Enabled = True
         btnAceptarEnfermedad.Enabled = True
      End If
   End Sub


   Private Sub habilitaBotonesDesdeHasta(ByVal estatus As Boolean, ByVal lectura As Boolean,
                                         ByVal txtDesdeLetra As TextBox, ByRef txtHastaLetra As TextBox, _
                                         ByVal txtDesdeValor As TextBox, ByRef txtHastaValor As TextBox)
      txtDesdeLetra.Enabled = estatus
      txtDesdeLetra.Focus()
      txtDesdeValor.Enabled = estatus
      txtHastaLetra.Enabled = estatus
      txtHastaValor.Enabled = estatus
      txtDesdeLetra.BackColor = Color.White
      txtDesdeValor.BackColor = Color.White
      txtHastaLetra.BackColor = Color.White
      txtHastaValor.BackColor = Color.White
      txtDesdeLetra.ReadOnly = lectura
      txtDesdeValor.ReadOnly = lectura
      txtHastaLetra.ReadOnly = lectura
      txtHastaValor.ReadOnly = lectura
   End Sub


   Private Sub btnBuscaCaso1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso1.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC1.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC1.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC1.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub


   Private Sub btnBuscaCaso2_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso2.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso2.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC2.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC2.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC2.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso3_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso3.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso3.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC3.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC3.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC3.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso4_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso4.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso4.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC4.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC4.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC4.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso5_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso5.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso5.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC5.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC5.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC5.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub


   Private Sub btnBuscaCaso6_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso6.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso6.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC6.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC6.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC6.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso7_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso7.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso7.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC7.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC7.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC2.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, txtHastaValor2C7)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso8_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso8.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso8.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreClienteC8.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitadoC8.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservacionesC8.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            lblMensajeCaso.Text = ""
         Else
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra1C8, txtHastaLetra2C8, txtDesdeValor1C8, txtHastaValor2C8)
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
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

   Private Sub txtCP1Letra1_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") Then
         txtCP1Valor1.Enabled = True
      End If
   End Sub

   Private Sub txtCP1Valor1_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 1, 12) Then
         txtCP2Letra2.Enabled = True
      End If
   End Sub

   Private Sub txtCP2Letra2_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") Then
         txtCP2Valor2.Enabled = True
      End If
   End Sub

   Private Sub txtCP2Valor2_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 1, 12) Then
         txtCP3Letra3.Enabled = True
      End If
   End Sub

   Private Sub txtCP3Letra3_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "H") Then
         txtCP3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCP3Valor3_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 1, 12) Then
         grbControlesNegativos.Enabled = True
         txtCN1Letra1.Enabled = True
         txtCN1Valor1.Enabled = False
         txtCN2Letra2.Enabled = False
         txtCN2Valor2.Enabled = False
         txtCN3Letra3.Enabled = False
         txtCN3Valor3.Enabled = False
      End If
   End Sub

   Private Sub txtCN1Letra1_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") Then
         txtCN1Valor1.Enabled = True
      End If
   End Sub

   Private Sub txtCN1Valor1_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 1, 12) Then
         txtCN2Letra2.Enabled = True
      End If
   End Sub

   Private Sub txtCN2Letra2_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") Then
         txtCN2Valor2.Enabled = True
      End If
   End Sub

   Private Sub txtCN2Valor2_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 1, 12) Then
         txtCN3Letra3.Enabled = True
      End If
   End Sub

   Private Sub txtCN3Letra3_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") Then
         txtCN3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCN3Valor3_TextChanged(sender As System.Object, e As System.EventArgs)
      If controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 1, 12) Then
         btnDefinirControlesPN.Enabled = True
      End If
   End Sub

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs)
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      defineValoresDefaultPositivos(nocp, Me.txtCP1Letra1, Me.txtCP1Valor1, Me.txtCP2Letra2, Me.txtCP2Valor2, Me.txtCP3Letra3, Me.txtCP3Valor3)
      defineValoresDefaultNegativos(nocn, Me.txtCN1Letra1, Me.txtCN1Valor1, Me.txtCN2Letra2, Me.txtCN2Valor2, Me.txtCN3Letra3, Me.txtCN3Valor3)
      ckbControlesDefault.Enabled = False
      grbControlesPositivos.Enabled = False
      grbControlesNegativos.Enabled = False
      btnAceptarControles.Enabled = True
      ckbControlesDefault.Enabled = False
   End Sub

   ' PARA VALIDAR EL Caso No. 1 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C1.TextChanged
      Try
         'Valor positivo uno, letra y numero
         controlesValidosLetra(txtDesdeLetra1C1, "1er. caso", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C1.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C1, "1er. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C1.TextChanged
      Try
         'Valor positivo uno, letra y numero
         controlesValidosLetra(txtHastaLetra2C1, "1er. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C1.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C1, " 1er. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No. 2 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C2.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C2, " 2o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C2.TextChanged
      controlesValidosNumero(txtDesdeValor1C2, " 2o. caso ", 1, 12)
   End Sub

   Private Sub txtHastaLetra2C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C2.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C2, " 2o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C2.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C2, " 2o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No. 3 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C3.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C3, " 3er. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C3.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C3, " 3er. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C3.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C3, " 3er. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C3.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C3, " 3er. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No.4 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C4.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C4, " 4o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C4.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C4, " 4o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C4.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C4, " 4o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C4.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C4, " 4o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No.5 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C5.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C5, " 5o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C5.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C5, " 5o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C5.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C5, " 5o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C5.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C5, " 5o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No.6 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C6.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C6, " 6o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C6.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C6, " 6o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C6.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C6, " 6o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C6.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C6, " 6o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No.7 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C7.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C7, " 7o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C7.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C7, " 7o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C7.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C7, " 7o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C7.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C7, " 7o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   ' PARA VALIDAR EL Caso No.8 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C8.TextChanged
      Try
         controlesValidosLetra(txtDesdeLetra1C8, " 8o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtDesdeValor1C8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C8.TextChanged
      Try
         controlesValidosNumero(txtDesdeValor1C6, " 8o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaLetra2C8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C8.TextChanged
      Try
         controlesValidosLetra(txtHastaLetra2C8, " 8o. caso ", "A", "H")
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub txtHastaValor2C8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C8.TextChanged
      Try
         controlesValidosNumero(txtHastaValor2C8, " 8o. caso ", 1, 12)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         If Me.btnLeerDatosPlaca.Text = "Obtener Datos" Then
            Me.btnLeerDatosPlaca.Text = "Desconectar"
            Setup_Puerto_SerieParametros(SerialPort1, cmbComboPorts, Me.lblMensajeCaso, Me.lblNombreLector)
         Else
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
               mensajeVerde(Me.lblMensajeCaso, "Mensaje: Cerrando el puerto COM del lector.")
               btnLeerDatosPlaca.Enabled = False
               'btnFormateaDatos.Enabled = True
               presentaDatosEnPantallaFormateados()
            End If
         End If
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub

   Private Sub presentaDatosEnPantallaFormateados()
      Dim noCasos As Integer = CInt(txtNoDeCasos.Text)
      Dim nocp As Integer = Val(txtNoControlesPositivos.Text)
      Dim nocn As Integer = Val(txtNoControlesNegativos.Text)
      btnLeerDatosPlaca.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         formateaDatos(placaLector, Me.dgvPlacaLeida)
         organizaEnTabla(Me.dgvPlacaLeida, placaLector)
         btnGuardaDatos.Enabled = True
         coloreaControlesPositivos(nocp, Me.dgvPlacaLeida, Me.txtCP1Letra1, Me.txtCP1Valor1,Me.txtCP2Letra2, Me.txtCP2Valor2, Me.txtCP3Letra3, Me.txtCP3Valor3)
         coloreaControlesPositivos(nocn, Me.dgvPlacaLeida, Me.txtCN1Letra1, Me.txtCN1Valor1, Me.txtCN2Letra2, Me.txtCN2Valor2, Me.txtCN3Letra3, Me.txtCN3Valor3)
         coloreaTablaCasos(noCasos)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Se ha presentado un error al formatear datos.")
      End Try
   End Sub

   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         txtDatosRecibidos.Text = ""
         az = Me.SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         mensajeException(Me.lblMensajeCaso, ex)
      End Try
      Me.txtDatosRecibidos.Text = msn
   End Sub

   Private Sub frmBronquitisAviar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      GetSerialPortNamesParametros(cmbComboPorts, Me.lblMensajeCaso)
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
   End Sub

   Private Sub botonesEstatus(ByVal estatus As Boolean)
      txtDesdeLetra1C1.Enabled = estatus
      txtDesdeValor1C1.Enabled = estatus
      txtHastaLetra2C1.Enabled = estatus
      txtHastaValor2C1.Enabled = estatus
   End Sub

   Private Sub obtenResultadosPorCaso(ByVal mensaje As String, ByRef control As Control, ByRef etiqueta As Label, ByVal cmbNombreEnfermedad As ComboBox, ByVal cmbNoCaso As ComboBox, _
                                      ByVal txtNombreCliente As TextBox, ByVal txtAnalisisSolicitado As TextBox, _
                                      ByVal lblObservaciones As Label, _
                                      ByVal txtDesdeLetra As TextBox, ByVal txtHastaLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                                      ByVal txtHastaValor As TextBox, ByVal promCP As Decimal, ByVal promCN As Decimal, ByVal difCPS As Decimal, _
                                      ByRef txtNombreEnfermedadSD As TextBox, ByRef txtNombreClienteSD As TextBox, ByRef txtNoCasoSD As TextBox, _
                                      ByRef lblAnalisisSD As Label, ByRef lblObservacionesSD As Label, ByRef txtFechaElaboracionSD As TextBox, _
                                      ByRef txtTitulosObtenidosSD As TextBox, ByRef txtMediaAritmetica2SD As TextBox, _
                                      ByRef txtMediaGeometricaSD As TextBox, ByRef txtTotalDatosCalculadosSD As TextBox, _
                                      ByRef txtCoefVariacion2SD As TextBox, ByRef txtDesvEstandar2SD As TextBox, ByRef txtVarianza2SD As TextBox)
      Dim calculaL() As Decimal
      Dim cuentaNoDatos As Decimal = 0
      Dim totalcalculaL As Decimal = 0
      Dim rangoTotal As Integer = 0
      Dim rangoDatos(14) As Integer
      Dim placaoriginal As String = ""
      Dim mediaGeometrica As Decimal
      Dim mediaAritmetica As Decimal = 0
      Dim varianza As Decimal = 0
      Dim desvEst As Decimal = 0
      Dim coefVar As Decimal = 0
      Dim titulosObtenidos As String = ""
      Dim titulox As String = "Grupo de títulos"
      Dim valorFR As String = ""
      Dim cantidadFR As String = ""
      Dim tituloy As String = "%"
      Dim fecha = DateTime.Now

      'Obtener valores desde-hasta para el caso
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra)
      Dim desdey As Integer = CInt(txtDesdeValor.Text) - 1
      Dim hastay As Integer = CInt(txtHastaValor.Text) - 1


      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      Dim cadena As String
      Dim tabla() As String
      cadena = cmbNombreEnfermedad.Text
      tabla = Split(cadena, " | ")
      'Obtiene el numero de caso para ese análisis
      Dim idAnalisis As String = tabla(0)
      Dim analisis As String = Replace(idAnalisis, "/", "")
      Dim numcaso As String = cmbNoCaso.Text
      'MessageBox.Show("Numero de caso que voy a trabajar: " & numcaso)
      Dim nombre As String = tabla(1)
      Dim nombreCliente As String = txtNombreCliente.Text
      Dim observaciones As String = lblObservaciones.Text

      cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)

      ReDim calculaL(cuentaNoDatos - 1)

      Try
         mediaGeometrica = calculaSumatoriaMediaGeometrica(calculoDeTitulos, calculaL, desdex, desdey, hastax, hastay, totalcalculaL)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular la sumatoria de la media geométrica.")
      End Try

      Try
         titulosObtenidos = titulosObtenidosEnCalculaL(calculaL, cuentaNoDatos)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al formatear los títulos en cadena, titulosObtenidosEnCalculaL.")
      End Try
      Try
         calculaMarcaDeClaseBI(calculaL, rangoDatos, rangoTotal)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular la marca de clase, calculaMarcaDeClase.")
      End Try
      Try
         mediaGeometrica = calculaMediaGeometrica(mediaGeometrica, rangoTotal)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular la media geométrica, calculaMediaGeometrica.")
      End Try
      Try
         mediaAritmetica = calculaMediaAritmetica(totalcalculaL, cuentaNoDatos)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular la media aritmética, calculaMediaAritmetica.")
      End Try
      Try
         varianza = calculaVarianza(mediaAritmetica, calculaL, cuentaNoDatos)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: AL calcular la varianza, calculaVarianza.")
      End Try
      Try
         desvEst = calculaDesvEst(varianza)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular desviación estándar, calculaDesvEst.")
      End Try
      Try
         coefVar = calculaCoefVar(desvEst, mediaAritmetica)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular el coeficiente de variación, calculaCoefVar.")
      End Try
      Try
         placaoriginal = obtenPlacaLeida(placaLector)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al obtener el string de la placa original, obtenPlacaLeida.")
      End Try
      Try
         calculaFrecuenciaRelativa(frecuenciaRelativa, rangoDatos, rangoTotal)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular la frecuencia relativa, calculaFrecuenciaRelativa.")
      End Try
      Try
         valorFR = obtenValorFR(frecuenciaRelativa)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular el string de valor de la Frec. Rel., obtenValorFR.")
      End Try
      Try
         cantidadFR = obtenCantidadFR(rangoDatos)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al calcular el string de cantidad de la Frec. Rel., obtenCantidadFR.")
      End Try
      Try
         'MessageBox.Show("Numero de caso que voy a guardar en la base de datos: " & numcaso)
         cargaResultadosBD(numcaso, idAnalisis, placaoriginal, titulosObtenidos, fecha.ToShortDateString(), promCP, promCN, difCPS, _
                           Convert.ToDouble(mediaAritmetica), Convert.ToDouble(mediaGeometrica), _
                           Convert.ToDouble(desvEst), Convert.ToDouble(coefVar), valorFR, cantidadFR, Me.lblMensajeCaso)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al cargar resultados a la BD, cargaResultadosBD.")
      End Try
      Try
         cargaFrecRelBD(frecuenciaRelativa, numcaso, rangoDatos, Me.lblMensajeCaso)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al guardar la frecuencia relativa en BD, cargaFrecRelBD.")
      End Try
      Try
         'creaChartFrecRel(etiqueta, control, nombre, titulox, tituloy, numcaso, analisis)
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Al crear la gráfica en pantalla, creaChartFrecRel.")
      End Try

   End Sub


   Private Sub btnObtenerResultados_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerResultados.Click
      btnAceptarControles.Enabled = False
      btnDefinirControlesPN.Enabled = False
      btnObtenerResultados.Enabled = False
      Dim desdeArchivo As Integer = 0
      Dim cp1 As Decimal = 0
      Dim cp2 As Decimal = 0
      Dim cp3 As Decimal = 0
      Dim cn1 As Decimal = 0
      Dim cn2 As Decimal = 0
      Dim cn3 As Decimal = 0

      Dim desdex As Integer = 0
      Dim hastax As Integer = 0
      Dim desdey As Integer = 0
      Dim hastay As Integer = 0
      Dim promCP As Decimal = 0
      Dim promCN As Decimal = 0
      Dim difCPS As Decimal = 0

      Dim cpx1 As Integer = 0
      Dim cpx2 As Integer = 0
      Dim cpx3 As Integer = 0
      Dim cnx1 As Integer = 0
      Dim cnx2 As Integer = 0
      Dim cnx3 As Integer = 0
      Dim cpy1 As Integer = 0
      Dim cpy2 As Integer = 0
      Dim cpy3 As Integer = 0
      Dim cny1 As Integer = 0
      Dim cny2 As Integer = 0
      Dim cny3 As Integer = 0

      Dim nocp As Integer = CInt(txtNoControlesPositivos.Text)
      Dim noCasos As Integer = CInt(txtNoDeCasos.Text)

      'Asigna los valores para controles positivos y negativos para cuando hay dos o tres controles desde el textbox
      cpx1 = siValorEsLetra(txtCP1Letra1)
      cpy1 = CInt(txtCP1Valor1.Text) - 1
      cpx2 = siValorEsLetra(txtCP2Letra2)
      cpy2 = CInt(txtCP2Valor2.Text) - 1
      cnx1 = siValorEsLetra(txtCN1Letra1)
      cny1 = CInt(txtCN1Valor1.Text) - 1
      cnx2 = siValorEsLetra(txtCN2Letra2)
      cny2 = CInt(txtCN2Valor2.Text) - 1
      'Verifica si sin tres controles + y -, entonces le da valor al tercer control usando desde eltextbox
      If (nocp = 3) Then
         cpx3 = siValorEsLetra(txtCP3Letra3)
         cpy3 = CInt(txtCP3Valor3.Text) - 1
         cnx3 = siValorEsLetra(txtCN3Letra3)
         cny3 = CInt(txtCN3Valor3.Text) - 1
      End If
      Try
         calculaValoresEnRango(placaLector, desdeArchivo, nocp, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, _
                               Convert.ToDecimal(lblLogSPS.Text), Convert.ToDecimal(lblLogTit1.Text), _
                               Convert.ToDecimal(lblLogTit2.Text), cp1, cp2, cp3, cn1, cn2, cn3, _
                               desdex, hastax, desdey, hastay, promCP, promCN, difCPS, Me.lblMensajeCaso)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "Error: Al calculor los valores, calculaValoresEnRango.")
      End Try
      Select Case noCasos
         Case 1
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
         Case 2
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                       frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                        frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()

         Case 3
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                        frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                        frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
         Case 4
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                        frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                        frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
            obtenResultadosPorCaso("Caso 4", frmSalidaCaso4, frmSalidaCaso4.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso4, txtNombreClienteC4, txtAnalisisSolicitadoC4, _
                                     lblObservacionesC4, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4, _
                                     promCP, promCN, difCPS, frmSalidaCaso4.txtNombreEnfermedad, frmSalidaCaso4.txtNombreCliente, frmSalidaCaso4.txtNoCaso, _
                                        frmSalidaCaso4.lblAnalisis, frmSalidaCaso4.lblObservaciones, frmSalidaCaso4.txtFechaElaboracion, _
                                        frmSalidaCaso4.txtTitulosObtenidos, frmSalidaCaso4.txtMediaAritmetica2, _
                                        frmSalidaCaso4.txtMediaGeometrica, frmSalidaCaso4.txtTotalDatosCalculados, _
                                       frmSalidaCaso4.txtCoefVariacion2, frmSalidaCaso4.txtDesvEstandar2, frmSalidaCaso4.txtVarianza2)
            frmSalidaCaso4.Show()
         Case 5
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                         frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                         frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
            obtenResultadosPorCaso("Caso 4", frmSalidaCaso4, frmSalidaCaso4.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso4, txtNombreClienteC4, txtAnalisisSolicitadoC4, _
                                     lblObservacionesC4, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4, _
                                     promCP, promCN, difCPS, frmSalidaCaso4.txtNombreEnfermedad, frmSalidaCaso4.txtNombreCliente, frmSalidaCaso4.txtNoCaso, _
                                        frmSalidaCaso4.lblAnalisis, frmSalidaCaso4.lblObservaciones, frmSalidaCaso4.txtFechaElaboracion, _
                                        frmSalidaCaso4.txtTitulosObtenidos, frmSalidaCaso4.txtMediaAritmetica2, _
                                        frmSalidaCaso4.txtMediaGeometrica, frmSalidaCaso4.txtTotalDatosCalculados, _
                                       frmSalidaCaso4.txtCoefVariacion2, frmSalidaCaso4.txtDesvEstandar2, frmSalidaCaso4.txtVarianza2)
            frmSalidaCaso4.Show()
            obtenResultadosPorCaso("Caso 5", frmSalidaCaso5, frmSalidaCaso5.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso5, txtNombreClienteC5, txtAnalisisSolicitadoC5, _
                                    lblObservacionesC5, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5, _
                                    promCP, promCN, difCPS, frmSalidaCaso5.txtNombreEnfermedad, frmSalidaCaso5.txtNombreCliente, frmSalidaCaso5.txtNoCaso, _
                                        frmSalidaCaso5.lblAnalisis, frmSalidaCaso5.lblObservaciones, frmSalidaCaso5.txtFechaElaboracion, _
                                       frmSalidaCaso5.txtTitulosObtenidos, frmSalidaCaso5.txtMediaAritmetica2, _
                                       frmSalidaCaso5.txtMediaGeometrica, frmSalidaCaso5.txtTotalDatosCalculados, _
                                      frmSalidaCaso5.txtCoefVariacion2, frmSalidaCaso5.txtDesvEstandar2, frmSalidaCaso5.txtVarianza2)
            frmSalidaCaso5.Show()
         Case 6
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                         frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                         frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
            obtenResultadosPorCaso("Caso 4", frmSalidaCaso4, frmSalidaCaso4.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso4, txtNombreClienteC4, txtAnalisisSolicitadoC4, _
                                     lblObservacionesC4, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4, _
                                     promCP, promCN, difCPS, frmSalidaCaso4.txtNombreEnfermedad, frmSalidaCaso4.txtNombreCliente, frmSalidaCaso4.txtNoCaso, _
                                        frmSalidaCaso4.lblAnalisis, frmSalidaCaso4.lblObservaciones, frmSalidaCaso4.txtFechaElaboracion, _
                                        frmSalidaCaso4.txtTitulosObtenidos, frmSalidaCaso4.txtMediaAritmetica2, _
                                        frmSalidaCaso4.txtMediaGeometrica, frmSalidaCaso4.txtTotalDatosCalculados, _
                                       frmSalidaCaso4.txtCoefVariacion2, frmSalidaCaso4.txtDesvEstandar2, frmSalidaCaso4.txtVarianza2)
            frmSalidaCaso4.Show()
            obtenResultadosPorCaso("Caso 5", frmSalidaCaso5, frmSalidaCaso5.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso5, txtNombreClienteC5, txtAnalisisSolicitadoC5, _
                                    lblObservacionesC5, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5, _
                                    promCP, promCN, difCPS, frmSalidaCaso5.txtNombreEnfermedad, frmSalidaCaso5.txtNombreCliente, frmSalidaCaso5.txtNoCaso, _
                                        frmSalidaCaso5.lblAnalisis, frmSalidaCaso5.lblObservaciones, frmSalidaCaso5.txtFechaElaboracion, _
                                       frmSalidaCaso5.txtTitulosObtenidos, frmSalidaCaso5.txtMediaAritmetica2, _
                                       frmSalidaCaso5.txtMediaGeometrica, frmSalidaCaso5.txtTotalDatosCalculados, _
                                      frmSalidaCaso5.txtCoefVariacion2, frmSalidaCaso5.txtDesvEstandar2, frmSalidaCaso5.txtVarianza2)
            frmSalidaCaso5.Show()
            obtenResultadosPorCaso("Caso 6", frmSalidaCaso6, frmSalidaCaso6.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso6, txtNombreClienteC6, txtAnalisisSolicitadoC6, _
                                    lblObservacionesC6, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6, _
                                    promCP, promCN, difCPS, frmSalidaCaso6.txtNombreEnfermedad, frmSalidaCaso6.txtNombreCliente, frmSalidaCaso6.txtNoCaso, _
                                       frmSalidaCaso6.lblAnalisis, frmSalidaCaso6.lblObservaciones, frmSalidaCaso6.txtFechaElaboracion, _
                                       frmSalidaCaso6.txtTitulosObtenidos, frmSalidaCaso6.txtMediaAritmetica2, _
                                       frmSalidaCaso6.txtMediaGeometrica, frmSalidaCaso6.txtTotalDatosCalculados, _
                                      frmSalidaCaso6.txtCoefVariacion2, frmSalidaCaso6.txtDesvEstandar2, frmSalidaCaso6.txtVarianza2)
            frmSalidaCaso6.Show()
         Case 7
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                         frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                         frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
            obtenResultadosPorCaso("Caso 4", frmSalidaCaso4, frmSalidaCaso4.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso4, txtNombreClienteC4, txtAnalisisSolicitadoC4, _
                                     lblObservacionesC4, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4, _
                                     promCP, promCN, difCPS, frmSalidaCaso4.txtNombreEnfermedad, frmSalidaCaso4.txtNombreCliente, frmSalidaCaso4.txtNoCaso, _
                                        frmSalidaCaso4.lblAnalisis, frmSalidaCaso4.lblObservaciones, frmSalidaCaso4.txtFechaElaboracion, _
                                        frmSalidaCaso4.txtTitulosObtenidos, frmSalidaCaso4.txtMediaAritmetica2, _
                                        frmSalidaCaso4.txtMediaGeometrica, frmSalidaCaso4.txtTotalDatosCalculados, _
                                       frmSalidaCaso4.txtCoefVariacion2, frmSalidaCaso4.txtDesvEstandar2, frmSalidaCaso4.txtVarianza2)
            frmSalidaCaso4.Show()
            obtenResultadosPorCaso("Caso 5", frmSalidaCaso5, frmSalidaCaso5.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso5, txtNombreClienteC5, txtAnalisisSolicitadoC5, _
                                    lblObservacionesC5, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5, _
                                    promCP, promCN, difCPS, frmSalidaCaso5.txtNombreEnfermedad, frmSalidaCaso5.txtNombreCliente, frmSalidaCaso5.txtNoCaso, _
                                        frmSalidaCaso5.lblAnalisis, frmSalidaCaso5.lblObservaciones, frmSalidaCaso5.txtFechaElaboracion, _
                                       frmSalidaCaso5.txtTitulosObtenidos, frmSalidaCaso5.txtMediaAritmetica2, _
                                       frmSalidaCaso5.txtMediaGeometrica, frmSalidaCaso5.txtTotalDatosCalculados, _
                                      frmSalidaCaso5.txtCoefVariacion2, frmSalidaCaso5.txtDesvEstandar2, frmSalidaCaso5.txtVarianza2)
            frmSalidaCaso5.Show()
            obtenResultadosPorCaso("Caso 6", frmSalidaCaso6, frmSalidaCaso6.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso6, txtNombreClienteC6, txtAnalisisSolicitadoC6, _
                                    lblObservacionesC6, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6, _
                                    promCP, promCN, difCPS, frmSalidaCaso6.txtNombreEnfermedad, frmSalidaCaso6.txtNombreCliente, frmSalidaCaso6.txtNoCaso, _
                                       frmSalidaCaso6.lblAnalisis, frmSalidaCaso6.lblObservaciones, frmSalidaCaso6.txtFechaElaboracion, _
                                       frmSalidaCaso6.txtTitulosObtenidos, frmSalidaCaso6.txtMediaAritmetica2, _
                                       frmSalidaCaso6.txtMediaGeometrica, frmSalidaCaso6.txtTotalDatosCalculados, _
                                      frmSalidaCaso6.txtCoefVariacion2, frmSalidaCaso6.txtDesvEstandar2, frmSalidaCaso6.txtVarianza2)
            frmSalidaCaso6.Show()
            obtenResultadosPorCaso("Caso 7", frmSalidaCaso7, frmSalidaCaso7.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso7, txtNombreClienteC7, txtAnalisisSolicitadoC7, _
                                    lblObservacionesC7, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, txtHastaValor2C7, _
                                    promCP, promCN, difCPS, frmSalidaCaso7.txtNombreEnfermedad, frmSalidaCaso7.txtNombreCliente, frmSalidaCaso7.txtNoCaso, _
                                      frmSalidaCaso7.lblAnalisis, frmSalidaCaso7.lblObservaciones, frmSalidaCaso7.txtFechaElaboracion, _
                                       frmSalidaCaso7.txtTitulosObtenidos, frmSalidaCaso7.txtMediaAritmetica2, _
                                       frmSalidaCaso7.txtMediaGeometrica, frmSalidaCaso7.txtTotalDatosCalculados, _
                                      frmSalidaCaso7.txtCoefVariacion2, frmSalidaCaso7.txtDesvEstandar2, frmSalidaCaso7.txtVarianza2)
            frmSalidaCaso7.Show()
         Case 8
            obtenResultadosPorCaso("Caso 1", frmSalidaDatos, frmSalidaDatos.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso1, txtNombreClienteC1, txtAnalisisSolicitadoC1, _
                                     lblObservacionesC1, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1, _
                                     promCP, promCN, difCPS, frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2)
            frmSalidaDatos.Show()
            obtenResultadosPorCaso("Caso 2", frmSalidaCaso2, frmSalidaCaso2.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso2, txtNombreClienteC2, txtAnalisisSolicitadoC2, _
                                     lblObservacionesC2, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2, _
                                     promCP, promCN, difCPS, frmSalidaCaso2.txtNombreEnfermedad, frmSalidaCaso2.txtNombreCliente, frmSalidaCaso2.txtNoCaso, _
                                         frmSalidaCaso2.lblAnalisis, frmSalidaCaso2.lblObservaciones, frmSalidaCaso2.txtFechaElaboracion, _
                                        frmSalidaCaso2.txtTitulosObtenidos, frmSalidaCaso2.txtMediaAritmetica2, _
                                        frmSalidaCaso2.txtMediaGeometrica, frmSalidaCaso2.txtTotalDatosCalculados, _
                                       frmSalidaCaso2.txtCoefVariacion2, frmSalidaCaso2.txtDesvEstandar2, frmSalidaCaso2.txtVarianza2)
            frmSalidaCaso2.Show()
            obtenResultadosPorCaso("Caso 3", frmSalidaCaso3, frmSalidaCaso3.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso3, txtNombreClienteC3, txtAnalisisSolicitadoC3, _
                                     lblObservacionesC3, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, txtHastaValor2C3, _
                                     promCP, promCN, difCPS, frmSalidaCaso3.txtNombreEnfermedad, frmSalidaCaso3.txtNombreCliente, frmSalidaCaso3.txtNoCaso, _
                                         frmSalidaCaso3.lblAnalisis, frmSalidaCaso3.lblObservaciones, frmSalidaCaso3.txtFechaElaboracion, _
                                        frmSalidaCaso3.txtTitulosObtenidos, frmSalidaCaso3.txtMediaAritmetica2, _
                                        frmSalidaCaso3.txtMediaGeometrica, frmSalidaCaso3.txtTotalDatosCalculados, _
                                       frmSalidaCaso3.txtCoefVariacion2, frmSalidaCaso3.txtDesvEstandar2, frmSalidaCaso3.txtVarianza2)
            frmSalidaCaso3.Show()
            obtenResultadosPorCaso("Caso 4", frmSalidaCaso4, frmSalidaCaso4.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso4, txtNombreClienteC4, txtAnalisisSolicitadoC4, _
                                     lblObservacionesC4, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4, _
                                     promCP, promCN, difCPS, frmSalidaCaso4.txtNombreEnfermedad, frmSalidaCaso4.txtNombreCliente, frmSalidaCaso4.txtNoCaso, _
                                        frmSalidaCaso4.lblAnalisis, frmSalidaCaso4.lblObservaciones, frmSalidaCaso4.txtFechaElaboracion, _
                                        frmSalidaCaso4.txtTitulosObtenidos, frmSalidaCaso4.txtMediaAritmetica2, _
                                        frmSalidaCaso4.txtMediaGeometrica, frmSalidaCaso4.txtTotalDatosCalculados, _
                                       frmSalidaCaso4.txtCoefVariacion2, frmSalidaCaso4.txtDesvEstandar2, frmSalidaCaso4.txtVarianza2)
            frmSalidaCaso4.Show()
            obtenResultadosPorCaso("Caso 5", frmSalidaCaso5, frmSalidaCaso5.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso5, txtNombreClienteC5, txtAnalisisSolicitadoC5, _
                                    lblObservacionesC5, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5, _
                                    promCP, promCN, difCPS, frmSalidaCaso5.txtNombreEnfermedad, frmSalidaCaso5.txtNombreCliente, frmSalidaCaso5.txtNoCaso, _
                                        frmSalidaCaso5.lblAnalisis, frmSalidaCaso5.lblObservaciones, frmSalidaCaso5.txtFechaElaboracion, _
                                       frmSalidaCaso5.txtTitulosObtenidos, frmSalidaCaso5.txtMediaAritmetica2, _
                                       frmSalidaCaso5.txtMediaGeometrica, frmSalidaCaso5.txtTotalDatosCalculados, _
                                      frmSalidaCaso5.txtCoefVariacion2, frmSalidaCaso5.txtDesvEstandar2, frmSalidaCaso5.txtVarianza2)
            frmSalidaCaso5.Show()
            obtenResultadosPorCaso("Caso 6", frmSalidaCaso6, frmSalidaCaso6.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso6, txtNombreClienteC6, txtAnalisisSolicitadoC6, _
                                    lblObservacionesC6, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6, _
                                    promCP, promCN, difCPS, frmSalidaCaso6.txtNombreEnfermedad, frmSalidaCaso6.txtNombreCliente, frmSalidaCaso6.txtNoCaso, _
                                       frmSalidaCaso6.lblAnalisis, frmSalidaCaso6.lblObservaciones, frmSalidaCaso6.txtFechaElaboracion, _
                                       frmSalidaCaso6.txtTitulosObtenidos, frmSalidaCaso6.txtMediaAritmetica2, _
                                       frmSalidaCaso6.txtMediaGeometrica, frmSalidaCaso6.txtTotalDatosCalculados, _
                                      frmSalidaCaso6.txtCoefVariacion2, frmSalidaCaso6.txtDesvEstandar2, frmSalidaCaso6.txtVarianza2)
            frmSalidaCaso6.Show()
            obtenResultadosPorCaso("Caso 7", frmSalidaCaso7, frmSalidaCaso7.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso7, txtNombreClienteC7, txtAnalisisSolicitadoC7, _
                                    lblObservacionesC7, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, txtHastaValor2C7, _
                                    promCP, promCN, difCPS, frmSalidaCaso7.txtNombreEnfermedad, frmSalidaCaso7.txtNombreCliente, frmSalidaCaso7.txtNoCaso, _
                                      frmSalidaCaso7.lblAnalisis, frmSalidaCaso7.lblObservaciones, frmSalidaCaso7.txtFechaElaboracion, _
                                       frmSalidaCaso7.txtTitulosObtenidos, frmSalidaCaso7.txtMediaAritmetica2, _
                                       frmSalidaCaso7.txtMediaGeometrica, frmSalidaCaso7.txtTotalDatosCalculados, _
                                      frmSalidaCaso7.txtCoefVariacion2, frmSalidaCaso7.txtDesvEstandar2, frmSalidaCaso7.txtVarianza2)
            frmSalidaCaso7.Show()
            obtenResultadosPorCaso("Caso 8", frmSalidaCaso8, frmSalidaCaso8.lblSalidaDatos, cmbNombreEnfermedad, cmbNoCaso8, txtNombreClienteC8, txtAnalisisSolicitadoC8, _
                                    lblObservacionesC8, txtDesdeLetra1C8, txtHastaLetra2C8, txtDesdeValor1C8, txtHastaValor2C8, _
                                    promCP, promCN, difCPS, frmSalidaCaso8.txtNombreEnfermedad, frmSalidaCaso8.txtNombreCliente, frmSalidaCaso8.txtNoCaso, _
                                      frmSalidaCaso8.lblAnalisis, frmSalidaCaso8.lblObservaciones, frmSalidaCaso8.txtFechaElaboracion, _
                                       frmSalidaCaso8.txtTitulosObtenidos, frmSalidaCaso8.txtMediaAritmetica2, _
                                       frmSalidaCaso8.txtMediaGeometrica, frmSalidaCaso8.txtTotalDatosCalculados, _
                                      frmSalidaCaso8.txtCoefVariacion2, frmSalidaCaso8.txtDesvEstandar2, frmSalidaCaso8.txtVarianza2)
            frmSalidaCaso8.Show()
      End Select

   End Sub

   Private Sub txtNoControlesPositivos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesPositivos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesPositivos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(Me.lblMensajeCaso, ex)
      End Try
   End Sub


   Private Sub txtNoControlesNegativos_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControlesNegativos.TextChanged
      Try
         controlesValidosNumero(txtNoControlesNegativos, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(Me.lblMensajeCaso, ex)
      End Try
   End Sub


   Private Sub coloreaTablaCasos(ByVal noCasos As Integer)
      Select Case noCasos
         Case 1
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
         Case 2
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
         Case 3
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
         Case 4
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.Linen, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
         Case 5
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.Linen, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
            coloreaCasos(Me.dgvPlacaLeida, Color.Khaki, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5)
         Case 6
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.Linen, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
            coloreaCasos(Me.dgvPlacaLeida, Color.Khaki, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5)
            coloreaCasos(Me.dgvPlacaLeida, Color.Beige, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6)
         Case 7
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.Linen, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
            coloreaCasos(Me.dgvPlacaLeida, Color.Khaki, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5)
            coloreaCasos(Me.dgvPlacaLeida, Color.Beige, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6)
            coloreaCasos(Me.dgvPlacaLeida, Color.PowderBlue, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, txtHastaValor2C7)
         Case 8
            coloreaCasos(Me.dgvPlacaLeida, Color.Gold, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, txtHastaValor2C1)
            coloreaCasos(Me.dgvPlacaLeida, Color.MistyRose, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.SandyBrown, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, txtHastaValor2C2)
            coloreaCasos(Me.dgvPlacaLeida, Color.Linen, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, txtHastaValor2C4)
            coloreaCasos(Me.dgvPlacaLeida, Color.Khaki, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, txtHastaValor2C5)
            coloreaCasos(Me.dgvPlacaLeida, Color.Beige, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, txtHastaValor2C6)
            coloreaCasos(Me.dgvPlacaLeida, Color.PowderBlue, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, txtHastaValor2C7)
            coloreaCasos(Me.dgvPlacaLeida, Color.Yellow, txtDesdeLetra1C8, txtHastaLetra2C8, txtDesdeValor1C8, txtHastaValor2C8)
      End Select
   End Sub


   Private Sub btnGuardaDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaDatos.Click
      Dim noCasos As Integer = CInt(txtNoDeCasos.Text)

      btnGuardaDatos.Enabled = False
      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      Dim cadena As String
      Dim tabla() As String
      cadena = cmbNombreEnfermedad.Text
      tabla = Split(cadena, " | ")
      'Obtiene el numero de caso para ese análisis
      Dim idAnalisis As String = tabla(0)
      Dim analisis As String = Replace(idAnalisis, "/", "")
      Try
         Select Case noCasos
            Case 1
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                             txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                             txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                             txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
            Case 2
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                          txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")

               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
            Case 3
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                          txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")

               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")

            Case 4
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                          txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")
               guardaCaso(cmbNoCaso4, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, _
                          txtHastaValor2C4, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 4")

            Case 5
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                          txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")
               guardaCaso(cmbNoCaso4, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, _
                          txtHastaValor2C4, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 4")
               guardaCaso(cmbNoCaso5, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, _
                          txtHastaValor2C5, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 5")
            Case 6
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                                      txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                                      txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                                      txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")
               guardaCaso(cmbNoCaso4, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, _
                          txtHastaValor2C4, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 4")
               guardaCaso(cmbNoCaso5, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, _
                          txtHastaValor2C5, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 5")
               guardaCaso(cmbNoCaso6, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, _
                          txtHastaValor2C6, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 6")
            Case 7
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                                      txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                                      txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                                      txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")
               guardaCaso(cmbNoCaso4, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, _
                          txtHastaValor2C4, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 4")
               guardaCaso(cmbNoCaso5, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, _
                          txtHastaValor2C5, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 5")
               guardaCaso(cmbNoCaso6, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, _
                          txtHastaValor2C6, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 6")
               guardaCaso(cmbNoCaso7, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, _
                          txtHastaValor2C7, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 7")

            Case 8
               guardaCaso(cmbNoCaso1, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C1, txtHastaLetra2C1, txtDesdeValor1C1, _
                                      txtHastaValor2C1, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                                      txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                                      txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 1")
               guardaCaso(cmbNoCaso2, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C2, txtHastaLetra2C2, txtDesdeValor1C2, _
                          txtHastaValor2C2, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 2")
               guardaCaso(cmbNoCaso3, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C3, txtHastaLetra2C3, txtDesdeValor1C3, _
                          txtHastaValor2C3, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 3")
               guardaCaso(cmbNoCaso4, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C4, txtHastaLetra2C4, txtDesdeValor1C4, _
                          txtHastaValor2C4, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 4")
               guardaCaso(cmbNoCaso5, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C5, txtHastaLetra2C5, txtDesdeValor1C5, _
                          txtHastaValor2C5, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 5")
               guardaCaso(cmbNoCaso6, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C6, txtHastaLetra2C6, txtDesdeValor1C6, _
                          txtHastaValor2C6, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 6")
               guardaCaso(cmbNoCaso7, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C7, txtHastaLetra2C7, txtDesdeValor1C7, _
                          txtHastaValor2C7, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                          txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                          txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 7")
               guardaCaso(cmbNoCaso8, analisis, txtNoControlesPositivos, txtNoControlesNegativos, txtDesdeLetra1C8, txtHastaLetra2C8, txtDesdeValor1C8, _
                         txtHastaValor2C8, txtCP1Letra1, txtCP2Letra2, txtCP3Letra3, txtCP1Valor1, _
                         txtCP2Valor2, txtCP3Valor3, txtCN1Letra1, _
                         txtCN2Letra2, txtCN3Letra3, txtCN1Valor1, txtCN2Valor2, txtCN3Valor3, lblMensajeCaso, "Caso 8")
         End Select
         btnObtenerResultados.Enabled = True
      Catch
         mensajeRojo(Me.lblMensajeCaso, "Error: Al guardar los datos de los casos en excel, btnGuardaDatos_Click.")
      End Try

   End Sub

   Private Function desdeHastaPorCaso(ByVal mensaje As String, ByRef tbcDatosDelCaso As TabControl, ByRef tbcCaso As TabPage, _
                                 ByRef txtDesdeLetra As TextBox, ByRef txtHastaLetra As TextBox, _
                                 ByRef txtDesdeValor As TextBox, ByRef txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean = True
      If Not (desdeHastaValidos(mensaje, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)) Then
         valido = False
         tbcDatosDelCaso.Enabled = True
         tbcCaso.Enabled = True
         habilitaBotonesDesdeHasta(True, False, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      End If
      Return valido
   End Function

   Private Function validaTodosLosCPNParaUnCaso(ByVal caso As String, ByVal nocp As Integer, ByVal txtDesdeLetra1 As TextBox, ByVal txtDesdeValor1 As TextBox, _
                                            ByVal txtHastaLetra2 As TextBox, ByVal txtHastaValor2 As TextBox) As Boolean
      Dim ok As Boolean
      If (nocp = 2) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CP 1", caso, txtCP1Letra1, txtCP1Valor1, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 2", caso, txtCP2Letra2, txtCP2Valor2, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 1", caso, txtCN1Letra1, txtCN1Valor1, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 2", caso, txtCN2Letra2, txtCN2Valor2, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2)
      ElseIf (nocp = 3) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CP 1", caso, txtCP1Letra1, txtCP1Valor1, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 2", caso, txtCP2Letra2, txtCP2Valor2, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 3", caso, txtCP3Letra3, txtCP3Valor3, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 1", caso, txtCN1Letra1, txtCN1Valor1, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 2", caso, txtCN2Letra2, txtCN2Valor2, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 3", caso, txtCN3Letra3, txtCN3Valor3, txtDesdeLetra1, txtDesdeValor1, txtHastaLetra2, txtHastaValor2)
      End If
      Return ok
   End Function

   Private Sub aceptaValoresEnCasos()
      tbcDatosDelCaso.Enabled = False
      btnCapturaTerminada.Enabled = False
      btnLeerDatosPlaca.Enabled = True
   End Sub

   Private Function verificaEstanTodosLosValores(ByVal nocp As Integer, ByVal caso As String, ByVal tbcCaso As TabPage, ByVal cmbNoCaso As ComboBox, _
                                                ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                                                ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Return siComboNoEsBlanco(cmbNoCaso, caso) AndAlso _
             controlesValidosLetra(txtDesdeLetra, caso, "A", "H") AndAlso _
             controlesValidosNumero(txtDesdeValor, caso, 1, 12) AndAlso _
             controlesValidosLetra(txtHastaLetra, caso, "A", "H") AndAlso _
             controlesValidosNumero(txtHastaValor, caso, 1, 12) AndAlso _
             validaTodosLosCPNParaUnCaso(caso, nocp, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
             desdeHastaPorCaso(caso, tbcDatosDelCaso, tbcCaso, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
   End Function

   Private Function comparaNoDeCasoElegido(ByVal caso As String, ByVal combo1 As ComboBox, ByVal combo2 As ComboBox) As Boolean
      If combo1.Text = combo2.Text Then
         MessageBox.Show("ERROR: " & caso & " tienen seleccionado el mismo No. de Caso, verifique e intente nuevamente.")
         Return False
      Else
         Return True
      End If
   End Function

   'Valida todas las entradas en el siguiente orden:
   '1. Revisa que  desde de cada caso no sean iguales que los controles positivos.
   '2. Revisa que  desde de cada caso no sean iguales que los controles negativos.
   '3. Revisa que  hasta de cada caso no sean iguales que los controles positivos.
   '4. Revisa que  hasta de cada caso no sean iguales que los controles negativos.
   Private Sub btnCapturaTerminada_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturaTerminada.Click
      Dim noCasos As Integer = CInt(txtNoDeCasos.Text)
      Dim nocp As Integer = CInt(txtNoControlesPositivos.Text)
      Try
         mensajeVerde(Me.lblMensajeCaso, "Mensaje:")
         Select Case noCasos
            Case 1
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) Then

                  aceptaValoresEnCasos()

               End If
            Case 2
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) Then

                  aceptaValoresEnCasos()

               End If
            Case 3
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) Then

                  aceptaValoresEnCasos()

               End If
            Case 4
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 4", cmbNoCaso1, cmbNoCaso4) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 1", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 4", cmbNoCaso2, cmbNoCaso4) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 2", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                  comparaNoDeCasoElegido("Caso 3 y Caso 4", cmbNoCaso3, cmbNoCaso4) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 3", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 4", tbcCaso4, cmbNoCaso4, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) Then

                  aceptaValoresEnCasos()

               End If
            Case 5
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 4", cmbNoCaso1, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 5", cmbNoCaso1, cmbNoCaso5) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 1", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 1", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 4", cmbNoCaso2, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 5", cmbNoCaso2, cmbNoCaso5) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 2", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 2", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                  comparaNoDeCasoElegido("Caso 3 y Caso 4", cmbNoCaso3, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 3 y Caso 5", cmbNoCaso3, cmbNoCaso5) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 3", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 3", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 4", tbcCaso4, cmbNoCaso4, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                  comparaNoDeCasoElegido("Caso 4 y Caso 5", cmbNoCaso4, cmbNoCaso5) AndAlso _
                  validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                  verificaEstanTodosLosValores(nocp, "Caso 5", tbcCaso5, cmbNoCaso5, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) Then

                  aceptaValoresEnCasos()

               End If
            Case 6
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 4", cmbNoCaso1, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 5", cmbNoCaso1, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 6", cmbNoCaso1, cmbNoCaso6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 1", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 1", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 1", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 4", cmbNoCaso2, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 5", cmbNoCaso2, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 6", cmbNoCaso2, cmbNoCaso6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 2", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 2", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 2", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 4", cmbNoCaso3, cmbNoCaso4) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 5", cmbNoCaso3, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 6", cmbNoCaso3, cmbNoCaso6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 3", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 3", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 3", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 4", tbcCaso4, cmbNoCaso4, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 5", cmbNoCaso4, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 6", cmbNoCaso4, cmbNoCaso6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 4", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 5", tbcCaso5, cmbNoCaso5, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 6", cmbNoCaso5, cmbNoCaso6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 5", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 6", tbcCaso6, cmbNoCaso6, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) Then

                  aceptaValoresEnCasos()

               End If
            Case 7
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 4", cmbNoCaso1, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 5", cmbNoCaso1, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 6", cmbNoCaso1, cmbNoCaso6) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 7", cmbNoCaso1, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 1", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 1", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 1", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 1", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 4", cmbNoCaso2, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 5", cmbNoCaso2, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 6", cmbNoCaso2, cmbNoCaso6) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 7", cmbNoCaso2, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 2", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 2", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 2", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 2", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 4", cmbNoCaso3, cmbNoCaso4) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 5", cmbNoCaso3, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 6", cmbNoCaso3, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 7", cmbNoCaso3, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 3", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 3", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 3", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 3", txtDesdeLetra1C7, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 4", tbcCaso4, cmbNoCaso4, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 5", cmbNoCaso4, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 6", cmbNoCaso4, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 7", cmbNoCaso4, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 4", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 4", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 5", tbcCaso5, cmbNoCaso5, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 6", cmbNoCaso5, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 7", cmbNoCaso5, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 5", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 5", txtDesdeLetra1C7, txtDesdeValor1C6, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 6", tbcCaso6, cmbNoCaso6, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) AndAlso _
                 comparaNoDeCasoElegido("Caso 6 y Caso 7", cmbNoCaso6, cmbNoCaso7) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 6", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 7", tbcCaso7, cmbNoCaso7, txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7) Then

                  aceptaValoresEnCasos()

               End If
            Case 8
               If verificaEstanTodosLosValores(nocp, "Caso 1", tbcCaso1, cmbNoCaso1, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 2", cmbNoCaso1, cmbNoCaso2) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 3", cmbNoCaso1, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 4", cmbNoCaso1, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 5", cmbNoCaso1, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 6", cmbNoCaso1, cmbNoCaso6) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 7", cmbNoCaso1, cmbNoCaso7) AndAlso _
                  comparaNoDeCasoElegido("Caso 1 y Caso 8", cmbNoCaso1, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 2 y Caso 1", txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 1", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 1", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 1", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 1", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 1", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 1", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C1, txtDesdeValor1C1, txtHastaLetra2C1, txtHastaValor2C1) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 2", tbcCaso2, cmbNoCaso2, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 comparaNoDeCasoElegido("Caso 2 y Caso 3", cmbNoCaso2, cmbNoCaso3) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 4", cmbNoCaso2, cmbNoCaso4) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 5", cmbNoCaso2, cmbNoCaso5) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 6", cmbNoCaso2, cmbNoCaso6) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 7", cmbNoCaso2, cmbNoCaso7) AndAlso _
                  comparaNoDeCasoElegido("Caso 2 y Caso 8", cmbNoCaso2, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 3 y Caso 2", txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 2", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 2", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 2", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 2", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 2", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C2, txtDesdeValor1C2, txtHastaLetra2C2, txtHastaValor2C2) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 3", tbcCaso3, cmbNoCaso3, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 4", cmbNoCaso3, cmbNoCaso4) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 5", cmbNoCaso3, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 6", cmbNoCaso3, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 7", cmbNoCaso3, cmbNoCaso7) AndAlso _
                 comparaNoDeCasoElegido("Caso 3 y Caso 8", cmbNoCaso3, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 4 y Caso 3", txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 3", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 3", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 3", txtDesdeLetra1C7, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 3", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C3, txtDesdeValor1C3, txtHastaLetra2C3, txtHastaValor2C3) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 4", tbcCaso4, cmbNoCaso4, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 5", cmbNoCaso4, cmbNoCaso5) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 6", cmbNoCaso4, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 7", cmbNoCaso4, cmbNoCaso7) AndAlso _
                 comparaNoDeCasoElegido("Caso 4 y Caso 8", cmbNoCaso4, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 4", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 4", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 4", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 5", tbcCaso5, cmbNoCaso5, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 6", cmbNoCaso5, cmbNoCaso6) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 7", cmbNoCaso5, cmbNoCaso7) AndAlso _
                 comparaNoDeCasoElegido("Caso 5 y Caso 8", cmbNoCaso5, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 5 y Caso 4", txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5, txtDesdeLetra1C4, txtDesdeValor1C4, txtHastaLetra2C4, txtHastaValor2C4) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 6 y Caso 5", txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 5", txtDesdeLetra1C7, txtDesdeValor1C6, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 5", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C5, txtDesdeValor1C5, txtHastaLetra2C5, txtHastaValor2C5) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 6", tbcCaso6, cmbNoCaso6, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) AndAlso _
                 comparaNoDeCasoElegido("Caso 6 y Caso 7", cmbNoCaso6, cmbNoCaso7) AndAlso _
                 comparaNoDeCasoElegido("Caso 6 y Caso 8", cmbNoCaso6, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 7 y Caso 6", txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 6", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C6, txtDesdeValor1C6, txtHastaLetra2C6, txtHastaValor2C6) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 7", tbcCaso7, cmbNoCaso7, txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7) AndAlso _
                 comparaNoDeCasoElegido("Caso 7 y Caso 8", cmbNoCaso7, cmbNoCaso8) AndAlso _
                 validaSiDosCasosEstanEnDistintoRango("Caso 8 y Caso 7", txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8, txtDesdeLetra1C7, txtDesdeValor1C7, txtHastaLetra2C7, txtHastaValor2C7) AndAlso _
                 verificaEstanTodosLosValores(nocp, "Caso 8", tbcCaso8, cmbNoCaso7, txtDesdeLetra1C8, txtDesdeValor1C8, txtHastaLetra2C8, txtHastaValor2C8) Then

                  aceptaValoresEnCasos()

               End If
         End Select
      Catch
         mensajeRojo(Me.lblMensajeCaso, "ERROR: Los valores que ha introducido son erróneos, trate nuevamente, btnCapturaTerminada_Click.")
         tbcDatosDelCaso.Enabled = True
         btnCapturaTerminada.Enabled = True
         btnLeerDatosPlaca.Enabled = False
      End Try

   End Sub

End Class