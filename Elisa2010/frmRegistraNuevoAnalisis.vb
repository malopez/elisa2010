Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


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

   Private Sub btnCambiarLector_Click(sender As System.Object, e As System.EventArgs)
      'frmConfLector.MdiParent = frmElisaBiovetsa
      ' frmConfLector.Show()
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
         MessageBox.Show("Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub


   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         az = Me.SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
      Me.txtDatosRecibidos.Text = msn
      btnDefinirControlesPN.Enabled = True
   End Sub

   Private Sub btnDefinirControlesPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      Dim nombreArchivo As String
      convierteCadena(msn)
      nombreArchivo = formateaDatos(placaLector)
      'nombreArchivo = guardaDatos(nombreArchivo)
      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
         btnAceptarControles.Enabled = True
      End If
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = False
      txtCP1Letra1.Enabled = True
      txtCP1Letra1.Clear()
      txtCP1Valor1.Enabled = False
      txtCP1Valor1.Clear()
      txtCP2Letra2.Enabled = False
      txtCP2Letra2.Clear()
      txtCP2Valor2.Enabled = False
      txtCP2Valor2.Clear()
      txtCP3Letra3.Enabled = False
      txtCP3Letra3.Clear()
      txtCP3Valor3.Enabled = False
      txtCP3Valor3.Clear()
      'grbControlesNegativos.Enabled = True
      'btnCalcularValores.Enabled = True
      'cambiado el 16-Abril-2012 para hacer pruebas de guardar los controles positivos y negativos  con los 
      'datos leidos desde puerto

   End Sub

   Private Sub btnObtenerResultados_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerResultados.Click
      Dim cpx1, cpx2, cpx3, cnx1, cnx2, cnx3 As Integer
      Dim cpy1, cpy2, cpy3, cny1, cny2, cny3 As Integer

      btnAceptarControles.Enabled = False
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
      guardaDatosExcel(placaLector, cpx1, cpx2, cpx3, cnx1, cnx2, cnx3, cpy1, cpy2, cpy3, cny1, cny2, cny3)
      calculaValores("Laringotraqueitis Aviar", "Grupo de títulos", "%", 0, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, CDec(0.15), CDec(1.45), CDec(3.726), 0, 0, 0, 0, 0, 0)
      frmSalidaDatos.Show()
   End Sub


   Private Sub frmRegistraNuevoAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tblregistroanalisis' table. You can move, or remove it, as needed.
      'Me.TblregistroanalisisTableAdapter.Fill(Me.BvtselisaDataSet.tblregistroanalisis)
      GetSerialPortNames()
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
   End Sub

   Private Sub txtCP1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP1Letra1.TextChanged
      'Valor positivo uno, letra y numero
      If controlesValidosLetra(txtCP1Letra1, " Letra primer control positivo ", "A", "Z") Then
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
      If controlesValidosLetra(txtCP2Letra2, " Letra segundo control positivo ", "A", "Z") Then
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
      If controlesValidosLetra(txtCP3Letra3, " Letra tercer control positivo ", "A", "Z") Then
         txtCP3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCP3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCP3Valor3.TextChanged
      If controlesValidosNumero(txtCP3Valor3, " Número terce control positivo ", 0, 11) Then
         grbControlesNegativos.Enabled = True
         txtCN1Valor1.Enabled = False
         txtCN2Letra2.Enabled = False
         txtCN2Valor2.Enabled = False
         txtCN3Letra3.Enabled = False
         txtCN3Valor3.Enabled = False
         txtCN1Letra1.Enabled = True
      End If
   End Sub

   Private Sub txtCN1Letra1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN1Letra1.TextChanged
      'Valor positivo uno, letra y numero
      grbControlesPositivos.Enabled = False
      If controlesValidosLetra(txtCN1Letra1, " Letra primer control negativo ", "A", "Z") Then
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
      If controlesValidosLetra(txtCN2Letra2, " Letra segundo control negativo ", "A", "Z") Then
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
      If controlesValidosLetra(txtCN3Letra3, " Letra tercer control negativo ", "A", "Z") Then
         txtCN3Valor3.Enabled = True
      End If
   End Sub

   Private Sub txtCN3Valor3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCN3Valor3.TextChanged
      If controlesValidosNumero(txtCN3Valor3, " Número tercer control negativo ", 0, 11) Then
         btnDefinirControlesPN.Enabled = True
      End If
   End Sub

   Private Sub btnAceptarControles_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarControles.Click
      grbControlesNegativos.Enabled = False
      btnDefinirControlesPN.Enabled = False
      btnObtenerResultados.Enabled = True
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso.Click
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = "server=biovetsa.dyndns.org;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"
         Dim oDataAdapter = New MySqlDataAdapter("SELECT DISTINCT caso FROM ordenes WHERE id_area=3 and id_status=1", oConexion)
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
      Catch ex As Exception
         lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         lblMensajeCaso.Text = "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis."
      End Try

   End Sub

   Private Sub btnBuscaCaso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = "server=biovetsa.dyndns.org;User Id=bvtselisa;;password=password;Persist Security Info=True;database=elisasandbox"
         'oConexion.ConnectionString = "server=biovetsa.dyndns.org;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
        
         oDataReader = oComando.ExecuteReader()
            If oDataReader.HasRows Then
               While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente")
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados")
               End While
               oDataReader.Close()
            lblMensajeCaso.Text = ""
            Else
            lblMensajeCaso.ForeColor = System.Drawing.Color.Red
            lblMensajeCaso.Text = "Mensaje: Seleccione un número de caso."
            End If
         oConexion.Close()
         Me.btnLeerDatosPlaca.Enabled = True
      Catch ex As MySqlException
         lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
      Catch ex As DataException
         lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      Catch ex As Exception
         lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      End Try
   End Sub
End Class