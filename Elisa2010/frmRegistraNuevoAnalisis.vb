Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmRegistraNuevoAnalisis
   Private Const cadenaConexion = "server=biovetsa.dyndns.org;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"
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
               lblMensajeCaso.ForeColor = System.Drawing.Color.Green
               lblMensajeCaso.Text = "Mensaje: Cerrando el puerto COM del lector."
               btnLeerDatosPlaca.Enabled = False
               btnFormateaDatos.Enabled = True
            End If
         End If
      Catch ex As Exception
         MessageBox.Show("Error al recuperar datos desde el lector de Placa.")
      End Try
   End Sub


   Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
      Try
         txtDatosRecibidos.Text = ""
         az = Me.SerialPort1.ReadExisting.Trim
         msn += az
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
      Me.txtDatosRecibidos.Text = msn
      'btnFormateaDatos.Enabled = True
   End Sub

   Private Sub btnDefinirControlesPN_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinirControlesPN.Click
      grbControlesPositivos.Enabled = True
      grbControlesNegativos.Enabled = True
      If btnDefinirControlesPN.Text = "Definir Controles" Then
         btnDefinirControlesPN.Text = "Cambiar Controles"
         btnFormateaDatos.Enabled = False
         btnLeerDatosPlaca.Enabled = False

      Else
         defineValoresDefault()
      End If
   End Sub

   'Define valores default para controles positivos y negativos

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

   Private Sub btnObtenerResultados_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerResultados.Click
      Dim cpx1, cpx2, cpx3, cnx1, cnx2, cnx3 As Integer
      Dim cpy1, cpy2, cpy3, cny1, cny2, cny3 As Integer
      Try
         btnAceptarControles.Enabled = False
         btnDefinirControlesPN.Enabled = False
         Try
            cpx1 = siValorEsLetra(txtCP1Letra1)
            cpy1 = Convert.ToInt32(txtCP1Valor1.Text)
            cpx2 = siValorEsLetra(txtCP2Letra2)
            cpy2 = Convert.ToInt32(txtCP2Valor2.Text)
            cpx3 = siValorEsLetra(txtCP3Letra3)
            cpy3 = Convert.ToInt32(txtCP3Valor3.Text)
            cnx1 = siValorEsLetra(txtCN1Letra1)
            cny1 = Convert.ToInt32(txtCN1Valor1.Text)
            cnx2 = siValorEsLetra(txtCN2Letra2)
            cny2 = Convert.ToInt32(txtCN2Valor2.Text)
            cnx3 = siValorEsLetra(txtCN3Letra3)
            cny3 = Convert.ToInt32(txtCN3Valor3.Text)
         Catch ex As Exception
            MessageBox.Show("Los datos no son válidos, cambie los controles e intente nuevamente.")
            btnObtenerResultados.Enabled = False
            btnDefinirControlesPN.Enabled = True
         End Try
         btnObtenerResultados.Enabled = False
         calculaValores("Laringotraqueitis Aviar", "Grupo de títulos", "%", 0, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, CDec(0.15), CDec(1.45), CDec(3.726), 0, 0, 0, 0, 0, 0)
         frmSalidaDatos.Show()
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      End Try

   End Sub


   Private Sub frmRegistraNuevoAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tblregistroanalisis' table. You can move, or remove it, as needed.
      'Me.TblregistroanalisisTableAdapter.Fill(Me.BvtselisaDataSet.tblregistroanalisis)
      GetSerialPortNames()
      CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
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

   Private Sub btnAceptarControles_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarControles.Click
      grbControlesNegativos.Enabled = False
      grbControlesPositivos.Enabled = False
      btnDefinirControlesPN.Enabled = False
      btnGuardarDatosExcel.Enabled = False
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
         ckbControlesDefault.Enabled = False
         btnAceptarControles.Enabled = False
         btnDefinirControlesPN.Enabled = False
         btnObtenerResultados.Enabled = True
      Else
         MessageBox.Show("Los valores que ha introducido no son válidos, trate nuevamente.")
         btnDefinirControlesPN.Enabled = True
         btnAceptarControles.Enabled = True
      End If
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso.Click
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
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
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try


   End Sub

   Private Sub btnBuscaCaso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
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
         mensajeExceptionSQL(lblMensajeCaso, ex)
      Catch ex As DataException
         mensajeException(lblMensajeCaso, ex)
      Catch ex As Exception
         mensajeException(lblMensajeCaso, ex)
      End Try
   End Sub

   Private Sub btnFormateaDatos_Click(sender As System.Object, e As System.EventArgs) Handles btnFormateaDatos.Click
      btnLeerDatosPlaca.Enabled = False
      btnFormateaDatos.Enabled = False
      Try
         convierteCadena(msn)
      Catch ex As Exception
         MessageBox.Show(" Se ha presentado un error al convertir la cadena en valores.")
      End Try
      Try
         Dim nombreArchivo As String
         nombreArchivo = formateaDatos(placaLector)
         btnDefinirControlesPN.Enabled = True
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "Se ha presentado un error al formatear datos.")
      End Try

   End Sub

   Private Sub ckbControlesDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbControlesDefault.CheckedChanged
      defineValoresDefault()
      ckbControlesDefault.Enabled = False
      btnAceptarControles.Enabled = True
   End Sub


   Private Sub btnGuardarDatosExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarDatosExcel.Click
      guardaDatosExcel(placaLector, Me.txtCP1Letra1.Text, Me.txtCP2Letra2.Text, Me.txtCP3Letra3.Text, Me.txtCN1Letra1.Text, _
                       Me.txtCN2Letra2.Text, Me.txtCN3Letra3.Text, Me.txtCP1Valor1.Text, Me.txtCP2Valor2.Text, Me.txtCP3Valor3.Text, _
                       Me.txtCN1Valor1.Text, Me.txtCN2Valor2.Text, Me.txtCN3Valor3.Text)
      btnAceptarControles.Enabled = True
   End Sub
End Class