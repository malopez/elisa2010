Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmMultipleCaso

   Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
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

   Private Sub coloreaControles(ByVal nocp As Integer)
      Select Case nocp
         Case 2
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), Val(txtCP1Valor1.Text + 1))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), Val(txtCP2Valor2.Text + 1))
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), Val(txtCN1Valor1.Text) + 1)
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), Val(txtCN2Valor2.Text) + 1)
         Case 3
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), Val(txtCP1Valor1.Text + 1))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), Val(txtCP2Valor2.Text + 1))
            coloreaTabla(Me.dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP3Letra3)), Val(txtCP3Valor3.Text + 1))
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), Val(txtCN1Valor1.Text) + 1)
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), Val(txtCN2Valor2.Text) + 1)
            coloreaTabla(Me.dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN3Letra3)), Val(txtCN3Valor3.Text) + 1)
      End Select
   End Sub

   Private Sub btnAceptarControles_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarControles.Click
      grbControlesNegativos.Enabled = False
      grbControlesPositivos.Enabled = False
      btnDefinirControlesPN.Enabled = False
      Dim nocp As Integer = Val(txtNoControles.Text)
      Select Case nocp
         Case 2
            MessageBox.Show("ENTRE AL CASE 2")
            If controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 0, 11) AndAlso _
              controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") AndAlso _
              controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 0, 11) AndAlso _
              controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") AndAlso _
              controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 0, 11) AndAlso _
              controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") AndAlso _
              controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 0, 11) Then
               btnAceptarControles.Enabled = False
               btnDefinirControlesPN.Enabled = False
               ckbControlesDefault.Enabled = False
               tbcDatosDelCaso.Enabled = True
               habilitaTabsCorrectos(txtNoDeCasos.Text)
            Else
               mensajeRojo(Me.lblMensajeCaso, "Los valores que ha introducido no son válidos, trate nuevamente.")
               btnDefinirControlesPN.Enabled = True
               btnAceptarControles.Enabled = True
            End If
         Case 3
            MessageBox.Show("ENTRE AL CASE 3")
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
               btnDefinirControlesPN.Enabled = False
               ckbControlesDefault.Enabled = False
               tbcDatosDelCaso.Enabled = True
               habilitaTabsCorrectos(txtNoDeCasos.Text)
            Else
               mensajeRojo(Me.lblMensajeCaso, "Los valores que ha introducido no son válidos, trate nuevamente.")
               btnDefinirControlesPN.Enabled = True
               btnAceptarControles.Enabled = True
            End If
      End Select
   End Sub

   Private Sub cmbNombreEnfermedad_Click(sender As Object, e As System.EventArgs) Handles cmbNombreEnfermedad.Click
      Try
         cmbNombreEnfermedad.Items.Clear()
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim oDataAdapter = New MySqlDataAdapter("SELECT  id_analysis as CLAVE, analysis_desc as ENFERMEDAD FROM analisis WHERE analysis_desc like '%INMUNOENSAYO%' order by analysis_desc asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "analisis")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("analisis")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            Dim cadena As String
            cadena = oFila.Item("ENFERMEDAD")
            cmbNombreEnfermedad.Items.Add(oFila.Item("CLAVE") & " | " & cadena.Remove(0, 24))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub defineValoresPN(ByVal nocp As Integer)
      Select Case nocp
         Case 2
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = False
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = False
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = False
            txtCP3Valor3.Visible = False
            'Hace visible controles negativos para dos controles
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = False
            txtCN3Valor3.Visible = False
         Case 3
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = True
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = True
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = True
            txtCP3Valor3.Visible = True
            'Hace visible controles negativos para dos controles
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = True
            txtCN3Valor3.Visible = True
      End Select
   End Sub



   Private Sub btnAceptarEnfermedad_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarEnfermedad.Click
      Dim nocp As Integer = Val(txtNoControles.Text)
      Try
         cmbNombreEnfermedad.Enabled = False
         txtNoDeCasos.Enabled = False
         defineValoresPN(nocp)
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C1.Enabled = True
         txtDesdeValor1C1.Enabled = True
         txtHastaLetra2C1.Enabled = True
         txtHastaValor2C1.Enabled = True
         txtDesdeLetra1C1.BackColor = Color.White
         txtDesdeValor1C1.BackColor = Color.White
         txtHastaLetra2C1.BackColor = Color.White
         txtHastaValor2C1.BackColor = Color.White
         txtDesdeLetra1C1.ReadOnly = False
         txtDesdeValor1C1.ReadOnly = False
         txtHastaLetra2C1.ReadOnly = False
         txtHastaValor2C1.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C2.Enabled = True
         txtDesdeValor1C2.Enabled = True
         txtHastaLetra2C2.Enabled = True
         txtHastaValor2C2.Enabled = True
         txtDesdeLetra1C2.BackColor = Color.White
         txtDesdeValor1C2.BackColor = Color.White
         txtHastaLetra2C2.BackColor = Color.White
         txtHastaValor2C2.BackColor = Color.White
         txtDesdeLetra1C2.ReadOnly = False
         txtDesdeValor1C2.ReadOnly = False
         txtHastaLetra2C2.ReadOnly = False
         txtHastaValor2C2.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C3.Enabled = True
         txtDesdeValor1C3.Enabled = True
         txtHastaLetra2C3.Enabled = True
         txtHastaValor2C3.Enabled = True
         txtDesdeLetra1C3.BackColor = Color.White
         txtDesdeValor1C3.BackColor = Color.White
         txtHastaLetra2C3.BackColor = Color.White
         txtHastaValor2C3.BackColor = Color.White
         txtDesdeLetra1C3.ReadOnly = False
         txtDesdeValor1C3.ReadOnly = False
         txtHastaLetra2C3.ReadOnly = False
         txtHastaValor2C3.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C4.Enabled = True
         txtDesdeValor1C4.Enabled = True
         txtHastaLetra2C4.Enabled = True
         txtHastaValor2C4.Enabled = True
         txtDesdeLetra1C4.BackColor = Color.White
         txtDesdeValor1C4.BackColor = Color.White
         txtHastaLetra2C4.BackColor = Color.White
         txtHastaValor2C4.BackColor = Color.White
         txtDesdeLetra1C4.ReadOnly = False
         txtDesdeValor1C4.ReadOnly = False
         txtHastaLetra2C4.ReadOnly = False
         txtHastaValor2C4.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C5.Enabled = True
         txtDesdeValor1C5.Enabled = True
         txtHastaLetra2C5.Enabled = True
         txtHastaValor2C5.Enabled = True
         txtDesdeLetra1C5.BackColor = Color.White
         txtDesdeValor1C5.BackColor = Color.White
         txtHastaLetra2C5.BackColor = Color.White
         txtHastaValor2C5.BackColor = Color.White
         txtDesdeLetra1C5.ReadOnly = False
         txtDesdeValor1C5.ReadOnly = False
         txtHastaLetra2C5.ReadOnly = False
         txtHastaValor2C5.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C6.Enabled = True
         txtDesdeValor1C6.Enabled = True
         txtHastaLetra2C6.Enabled = True
         txtHastaValor2C6.Enabled = True
         txtDesdeLetra1C6.BackColor = Color.White
         txtDesdeValor1C6.BackColor = Color.White
         txtHastaLetra2C6.BackColor = Color.White
         txtHastaValor2C6.BackColor = Color.White
         txtDesdeLetra1C6.ReadOnly = False
         txtDesdeValor1C6.ReadOnly = False
         txtHastaLetra2C6.ReadOnly = False
         txtHastaValor2C6.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C7.Enabled = True
         txtDesdeValor1C7.Enabled = True
         txtHastaLetra2C7.Enabled = True
         txtHastaValor2C7.Enabled = True
         txtDesdeLetra1C7.BackColor = Color.White
         txtDesdeValor1C7.BackColor = Color.White
         txtHastaLetra2C7.BackColor = Color.White
         txtHastaValor2C7.BackColor = Color.White
         txtDesdeLetra1C7.ReadOnly = False
         txtDesdeValor1C7.ReadOnly = False
         txtHastaLetra2C7.ReadOnly = False
         txtHastaValor2C7.ReadOnly = False
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados,o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso1.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & lblIdAnalisis.Text & "' ;"
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
            mensajeRojo(Me.lblMensajeCaso, "Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
         txtDesdeLetra1C8.Enabled = True
         txtDesdeValor1C8.Enabled = True
         txtHastaLetra2C8.Enabled = True
         txtHastaValor2C8.Enabled = True
         txtDesdeLetra1C8.BackColor = Color.White
         txtDesdeValor1C8.BackColor = Color.White
         txtHastaLetra2C8.BackColor = Color.White
         txtHastaValor2C8.BackColor = Color.White
         txtDesdeLetra1C8.ReadOnly = False
         txtDesdeValor1C8.ReadOnly = False
         txtHastaLetra2C8.ReadOnly = False
         txtHastaValor2C8.ReadOnly = False
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub


   Private Sub btnDefineCPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True
      btnAceptarEnfermedad.Enabled = False
      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
         btnFormateaDatos.Enabled = False
         btnLeerDatosPlaca.Enabled = False
      Else
         btnAceptarControles.Enabled = True
      End If
   End Sub

   Private Sub txtCP1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP1Letra1.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "H") Then
         txtCP1Valor1.Enabled = True
      End If
   End Sub

   Private Sub txtCP1Valor1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP1Valor1.TextChanged
      If controlesValidosNumero(txtCP1Valor1, " Número primer control positivo ", 0, 11) Then
         txtCP2Letra2.Enabled = True
      End If
   End Sub

   Private Sub txtCP2Letra2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP2Letra2.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "H") Then
         txtCP2Valor2.Enabled = True
      End If
   End Sub

   Private Sub txtCP2Valor2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP2Valor2.TextChanged
      If controlesValidosNumero(txtCP2Valor2, " Número segundo control positivo ", 0, 11) Then
         txtCP3Letra3.Enabled = True
      End If
   End Sub

   Private Sub txtCP3Letra3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP3Letra3.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "H") Then
         txtCP3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCP3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP3Valor3.TextChanged
      If controlesValidosNumero(txtCP3Valor3, " Número tercer control positivo ", 0, 11) Then
         grbControlesNegativos.Enabled = True
         txtCN1Letra1.Enabled = True
         txtCN1Valor1.Enabled = False
         txtCN2Letra2.Enabled = False
         txtCN2Valor2.Enabled = False
         txtCN3Letra3.Enabled = False
         txtCN3Valor3.Enabled = False
      End If
   End Sub

   Private Sub txtCN1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN1Letra1.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "H") Then
         txtCN1Valor1.Enabled = True
      End If
   End Sub

   Private Sub txtCN1Valor1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN1Valor1.TextChanged
      If controlesValidosNumero(txtCN1Valor1, " Número primer control negativo ", 0, 11) Then
         txtCN2Letra2.Enabled = True
      End If
   End Sub

   Private Sub txtCN2Letra2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN2Letra2.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "H") Then
         txtCN2Valor2.Enabled = True
      End If
   End Sub

   Private Sub txtCN2Valor2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN2Valor2.TextChanged
      If controlesValidosNumero(txtCN2Valor2, " Número segundo control negativo ", 0, 11) Then
         txtCN3Letra3.Enabled = True
      End If
   End Sub

   Private Sub txtCN3Letra3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN3Letra3.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "H") Then
         txtCN3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCN3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN3Valor3.TextChanged
      If controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 0, 11) Then
         btnDefinirControlesPN.Enabled = True
      End If
   End Sub

   Private Sub defineValoresDefault()
      txtCP1Letra1.Text = "A"
      txtCP2Letra2.Text = "A"
      txtCP3Letra3.Text = "H"
      txtCP1Valor1.Text = "0"
      txtCP2Valor2.Text = "2"
      txtCP3Valor3.Text = "10"
      txtCN1Letra1.Text = "A"
      txtCN2Letra2.Text = "H"
      txtCN3Letra3.Text = "H"
      txtCN1Valor1.Text = "1"
      txtCN2Valor2.Text = "9"
      txtCN3Valor3.Text = "11"
   End Sub

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbControlesDefault.CheckedChanged
      defineValoresDefault()
      ckbControlesDefault.Enabled = False
      grbControlesPositivos.Enabled = False
      grbControlesNegativos.Enabled = False
      btnAceptarControles.Enabled = True
   End Sub

   ' PARA VALIDAR EL CASO No. 1 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C1.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra1C1, "1er. caso", "A", "H")
   End Sub

   Private Sub txtDesdeValor1C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C1.TextChanged
      controlesValidosNumero(txtDesdeValor1C1, "1er. caso ", 0, 11)
   End Sub

   Private Sub txtHastaLetra2C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C1.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra2C1, "1er. caso ", "A", "H")
   End Sub

   Private Sub txtHastaValor2C1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C1.TextChanged
      controlesValidosNumero(txtHastaValor2C1, " Número primer control negativo ", 0, 11)
   End Sub

   ' PARA VALIDAR EL CASO No. 2 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C2.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra1C2, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtDesdeValor1C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C2.TextChanged
      controlesValidosNumero(txtDesdeValor1C2, " Número primer control negativo ", 0, 11)
   End Sub

   Private Sub txtHastaLetra2C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C2.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra2C2, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtHastaValor2C2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C2.TextChanged
      controlesValidosNumero(txtHastaValor2C2, " Número primer control negativo ", 0, 11)
   End Sub

   ' PARA VALIDAR EL CASO No. 3 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C3.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra1C3, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtDesdeValor1C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C3.TextChanged
      controlesValidosNumero(txtDesdeValor1C3, " Número primer control negativo ", 0, 11)
   End Sub

   Private Sub txtHastaLetra2C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C3.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra2C3, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtHastaValor2C3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C3.TextChanged
      controlesValidosNumero(txtHastaValor2C3, " Número primer control negativo ", 0, 11)
   End Sub

   ' PARA VALIDAR EL CASO No.4 EL CUADRITO DE TEXTO DESDE-HASTA
   Private Sub txtDesdeLetra1C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeLetra1C4.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra1C4, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtDesdeValor1C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesdeValor1C4.TextChanged
      controlesValidosNumero(txtDesdeValor1C4, " Número primer control negativo ", 0, 11)
   End Sub

   Private Sub txtHastaLetra2C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaLetra2C4.TextChanged
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra2C4, " Letra primer control positivo ", "A", "H")
   End Sub

   Private Sub txtHastaValor2C4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHastaValor2C4.TextChanged
      controlesValidosNumero(txtHastaValor2C4, " Número primer control negativo ", 0, 11)
   End Sub

   Private Sub btnLeerDatosPlaca_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerDatosPlaca.Click
      Try
         If Me.btnLeerDatosPlaca.Text = "Leer Datos" Then
            Me.btnLeerDatosPlaca.Text = "Desconectar"
            Setup_Puerto_SerieParametros(SerialPort1, cmbComboPorts, Me.lblMensajeCaso, Me.lblNombreLector)
         Else
            If SerialPort1.IsOpen Then
               SerialPort1.Close()
               mensajeVerde(Me.lblMensajeCaso, "Mensaje: Cerrando el puerto COM del lector.")
               btnLeerDatosPlaca.Enabled = False
               btnFormateaDatos.Enabled = True
            End If
         End If
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub

   Private Sub btnFormateaDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnFormateaDatos.Click
      Dim nocp As Integer = Val(txtNoControles.Text)
      btnLeerDatosPlaca.Enabled = False
      btnFormateaDatos.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, " Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         formateaDatos(placaLector, Me.dgvPlacaLeida)
         btnDefinirControlesPN.Enabled = True
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, " Se ha presentado un error al formatear datos.")
      End Try
      coloreaControles(nocp)
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

   Private Sub frmMultipleCaso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      GetSerialPortNamesParametros(cmbComboPorts, Me.lblMensajeCaso)
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
   End Sub


   Private Sub botonesEstatus(ByVal estatus As Boolean)
      txtDesdeLetra1C1.Enabled = estatus
      txtDesdeValor1C1.Enabled = estatus
      txtHastaLetra2C1.Enabled = estatus
      txtHastaValor2C1.Enabled = estatus
   End Sub

   Private Sub btnObtenerResultados_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerResultados.Click
      Dim cpx1, cpx2, cpx3, cnx1, cnx2, cnx3 As Integer
      Dim cpy1, cpy2, cpy3, cny1, cny2, cny3 As Integer
      btnAceptarControles.Enabled = False
      btnDefinirControlesPN.Enabled = False
      Dim nocp As Integer = Val(txtNoControles.Text)
      Try
         cpx1 = siValorEsLetra(txtCP1Letra1)
         cpy1 = Val(txtCP1Valor1.Text)
         cpx2 = siValorEsLetra(txtCP2Letra2)
         cpy2 = Val(txtCP2Valor2.Text)
         cpx3 = siValorEsLetra(txtCP3Letra3)
         cpy3 = Val(txtCP3Valor3.Text)
         cnx1 = siValorEsLetra(txtCN1Letra1)
         cny1 = Val(txtCN1Valor1.Text)
         cnx2 = siValorEsLetra(txtCN2Letra2)
         cny2 = Val(txtCN2Valor2.Text)
         cnx3 = siValorEsLetra(txtCN3Letra3)
         cny3 = Val(txtCN3Valor3.Text)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeCaso, "Los datos no son válidos, cambie los controles e intente nuevamente.")
         btnObtenerResultados.Enabled = False
         btnDefinirControlesPN.Enabled = True
      End Try
      Dim desdeArchivo As Integer = 0
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra1C1)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra2C1)
      Dim desdey As Integer = CInt(txtDesdeValor1C1.Text)
      Dim hastay As Integer = CInt(txtHastaValor2C1.Text)
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
      Dim tituloy As String = "%"
      Dim promCP As Decimal = 0
      Dim promCN As Decimal = 0
      Dim difCPS As Decimal = 0
      Dim fecha = DateTime.Now

      Try
         botonesEstatus(False)
         Me.btnObtenerResultados.Enabled = False
         'Obtener el nombre del análisis para colocar la cabecera de la gráfica
         Dim cadena As String
         Dim tabla() As String
         cadena = txtAnalisisSolicitadoC1.Text
         tabla = Split(cadena, "/")
         'Obtiene el numero de caso para ese análisis
         Dim cadena1 As String
         Dim tabla1() As String
         cadena1 = cmbNoCaso1.Text
         tabla1 = Split(cadena1, " | ")
         Dim numcaso As String = tabla1(0)
         Dim nombre As String = tabla(1)
         Dim nombreCliente As String = txtNombreClienteC1.Text

         Try
            calculaValoresEnRango(placaLector, desdeArchivo, nocp, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, _
                                  Convert.ToDecimal(lblLogSPS.Text), Convert.ToDecimal(lblLogTit1.Text), _
                                  Convert.ToDecimal(lblLogTit2.Text), 0, 0, 0, 0, 0, 0, _
                                  desdex, hastax, desdey, hastay, promCP, promCN, difCPS)
         Catch ex As Exception
            MessageBox.Show("ERROR AL CALCULAR VALORES")
         End Try

         cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)

         ReDim calculaL(cuentaNoDatos - 1)

         Try
            mediaGeometrica = calculaSumatoriaMediaGeometrica(calculoDeTitulos, calculaL, desdex, desdey, hastax, hastay, totalcalculaL)
         Catch ex As Exception
            MessageBox.Show("ERROR AL CALCULAR SUMATORIA DE MEDIA GEOMETRICA")
         End Try

         Try
            titulosObtenidos = titulosObtenidosEnCalculaL(calculaL, cuentaNoDatos)
         Catch ex As Exception
            MessageBox.Show("ERROR AL FORMATEAR LOS TITULOS EN CADENA DE TITULOS OBTENIDOS")
         End Try
         Try
            calculaMarcaDeClase(calculaL, rangoDatos, rangoTotal)
         Catch ex As Exception
            MessageBox.Show("ERROR AL CALCULAR MARCA DE CLASE")
         End Try
         Try
            mediaGeometrica = calculaMediaGeometrica(mediaGeometrica, rangoTotal)
         Catch
            MessageBox.Show("ERROR AL CALCULAR MEDIA GEOMETRICA")
         End Try
         Try
            mediaAritmetica = calculaMediaAritmetica(totalcalculaL, cuentaNoDatos)
         Catch
            MessageBox.Show("ERROR AL CALCULAR MEDIA ARITMETICA")
         End Try
         Try
            varianza = calculaVarianza(mediaAritmetica, calculaL, cuentaNoDatos)
         Catch
            MessageBox.Show("ERROR AL CALCULAR VARIANZA")
         End Try
         Try
            desvEst = calculaDesvEst(varianza)
         Catch
            MessageBox.Show("ERROR AL CALCULAR DESVIACION ESTANDAR")
         End Try
         Try
            coefVar = calculaCoefVar(desvEst, mediaAritmetica)
         Catch
            MessageBox.Show("ERROR AL CALCULAR COEF VAR")
         End Try
         Try
            cargaResultadosBD(numcaso, placaoriginal, titulosObtenidos, fecha.ToShortDateString(), promCP, promCN, difCPS, _
                              Convert.ToDouble(mediaAritmetica), Convert.ToDouble(mediaGeometrica), _
                              Convert.ToDouble(desvEst), Convert.ToDouble(coefVar))
         Catch
            MessageBox.Show("ERROR AL CARGAR RESULTADOS A LA BD.")
         End Try
         Try
            'CARGAR LA TABLA DE FREC REL
            calculaFrecuenciaRelativa(frecuenciaRelativa, rangoDatos, rangoTotal)
         Catch
            MessageBox.Show("ERROR AL CARGAR FRECUENCIA RELATIVA.")
         End Try
         Try
            cargaFrecRelBD(frecuenciaRelativa, numcaso, rangoDatos)
         Catch
            MessageBox.Show("ERROR AL CARGAR FRECUENCIA RELATIVA A LA BD.")
         End Try
         Try
            creaChartFrecRel(nombre, titulox, tituloy, numcaso)
         Catch
            MessageBox.Show("ERROR CREAR GRAFICA EN PANTALLA.")
         End Try
         Try
            frmSalidaDatos.Show()
            mostrarResultadosEnPantalla(frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2, _
                                        nombre, nombreCliente, numcaso, lblObservacionesC1.Text, fecha.ToShortDateString(), titulosObtenidos, _
                                        mediaAritmetica, mediaGeometrica, cuentaNoDatos, coefVar, desvEst, varianza)
         Catch
            MessageBox.Show("ERROR AL MOSTRAR RESULTADOS EN PANTALLA.")
         End Try
      Catch ex As Exception
         mensajeException(Me.lblMensajeCaso, ex)
         Me.btnObtenerResultados.Enabled = False
      End Try

   End Sub

   Private Sub txtNoControles_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNoControles.TextChanged
      Try
         controlesValidosNumero(txtNoControles, " En número de controles + y - ", 2, 3)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

End Class