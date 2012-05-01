Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmAbrirArchivoExistente

   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerArchivoExistente.Click
      abreArchivoExcel(placaLector)
   End Sub

   Private Sub btnObtenResultadosDA_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenResultadosDA.Click
      Dim desdeArchivo As Integer = 1
      Dim cp1, cp2, cp3 As Decimal
      Dim cn1, cn2, cn3 As Decimal
      Try
         cp1 = CDec(Me.txtCPDAValor1.Text)
         cp2 = CDec(Me.txtCPDAValor2.Text)
         cp3 = CDec(Me.txtCPDAValor3.Text)
         cn1 = CDec(Me.txtCNDAValor1.Text)
         cn2 = CDec(Me.txtCNDAValor2.Text)
         cn3 = CDec(Me.txtCNDAValor3.Text)
         Me.btnObtenResultadosDA.Enabled = False
         calculaValores("Laringotraqueitis Aviar", "Grupo de títulos", "%", desdeArchivo, cmbNoCaso.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CDec(0.15), CDec(1.45), CDec(3.726), cp1, cp2, cp3, cn1, cn2, cn3)
         frmSalidaDatos.ShowDialog()
      Catch ex As Exception
         mensajeException(Me.lblMensajeAAE, ex)
         Me.btnLeerArchivoExistente.Enabled = True
         Me.btnObtenResultadosDA.Enabled = False
      End Try

   End Sub

   Private Sub btnCancelarDA_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarDA.Click
      Me.Close()
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso.Click
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim oDataAdapter = New MySqlDataAdapter("SELECT DISTINCT o.caso FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%'", oConexion)
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
         mensajeExceptionSQL(lblMensajeAAE, ex)
      Catch ex As DataException
         mensajeException(lblMensajeAAE, ex)
      Catch ex As Exception
         mensajeRojo(lblMensajeAAE, "Error al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
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
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, logSPS,logTit1,logTit2 FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados").ToString()
               lblLogSPS.Text = oDataReader("logSPS").ToString()
               lblLogTit1.Text = oDataReader("logTit1").ToString()
               lblLogTit2.Text = oDataReader("logTit2").ToString()
            End While
            oDataReader.Close()
            lblMensajeAAE.Text = ""
            btnLeerArchivoExistente.Enabled = True
         Else
            mensajeRojo(Me.lblMensajeAAE,"Mensaje: Seleccione un número de caso.")
         End If
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeAAE, ex)
      Catch ex As DataException
         mensajeException(lblMensajeAAE, ex)
      Catch ex As Exception
         mensajeException(lblMensajeAAE, ex)
      End Try
   End Sub
End Class