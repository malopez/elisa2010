Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmPasteuHaemDA

   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs)
      Try
         'abreArchivoExcel(placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
         abreArchivoExcel(Me, Me.ofdSelArchivo, Me.lblMensajeAAE, Me.btnLeerArchivoExistente, _
                          Me.btnObtenResultadosDA, placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "ERROR: al abrir el archivo Excel, abreArchivoExcel.")
      End Try
      Try
         organizaEnTablaDA(Me.dgvPlacaLeida, placaLector)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "ERROR: al abrir organizar datos en el datagridview, organizaEnTabla.")
      End Try
      botonesEstatus(True)
      btnLeerArchivoExistente.Enabled = False
      btnCapturaTerminada.Enabled = True
      btnObtenResultadosDA.Enabled = False
   End Sub

   Private Sub btnObtenResultadosDA_Click(sender As System.Object, e As System.EventArgs)
      Dim desdeArchivo As Integer = 1
      Dim cp1, cp2, cp3 As Decimal
      Dim cn1, cn2, cn3 As Decimal
      Dim promedioPositivos As Decimal
      Dim promedioNegativos As Decimal
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra1)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra2)
      Dim desdey As Integer = CInt(txtDesdeValor1.Text) - 1
      Dim hastay As Integer = CInt(txtHastaValor2.Text) - 1
      Dim calculaL() As Decimal
      Dim cuentaNoDatos As Decimal = 0
      Dim totalcalculaL As Decimal = 0
      Dim desvEst As Decimal = 0
      Dim valor3DE As Decimal = 0
      Dim valorComparacion As Decimal = 0
      Dim resultadoObtenido(1) As String
      Dim titulox As String = "Grupo de títulos"
      Dim tituloy As String = "%"
      Dim promCP As Decimal = 0
      Dim promCN As Decimal = 0
      Dim difCPS As Decimal = 0
      Dim fecha = DateTime.Now
      Dim nocp As Integer = 3
      'Try
      cp1 = CDec(Me.txtCPDAValor1.Text)
      cp2 = CDec(Me.txtCPDAValor2.Text)
      cp3 = CDec(Me.txtCPDAValor3.Text)
      cn1 = CDec(Me.txtCNDAValor1.Text)
      cn2 = CDec(Me.txtCNDAValor2.Text)
      cn3 = CDec(Me.txtCNDAValor3.Text)
      btnCapturaTerminada.Enabled = False
      btnObtenResultadosDA.Enabled = False
      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      'Dim cadena As String
      'Dim tabla() As String
      'cadena = txtAnalisisSolicitado.Text
      'tabla = Split(cadena, "/")
      ''Obtiene el numero de caso para ese análisis
      Dim cadena1 As String
      Dim tabla1() As String
      cadena1 = cmbNoCaso.Text
      tabla1 = Split(cadena1, " | ")
      Dim numcaso As String = tabla1(0)
      Dim idAnalisis As String = tabla1(1)
      'Dim nombre As String = tabla(1)
      Dim nombreCliente As String = txtNombreCliente.Text
      Dim observaciones As String = lblObservaciones.Text
      Dim valorFR As String = ""
      Dim cantidadFR As String = ""

      Try
         promedioPositivos = calculaPromedioPositivosDA(cp1, cp2, cp3, Me.lblMensajeAAE)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "Error: Al calcular el promedio de controles positivos, calculaPromedioPositivosDA.")
      End Try
      Try
         promedioNegativos = calculaPromedioNegativosDA(cn1, cn2, cn3, Me.lblMensajeAAE)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "Error: Al calcular el promedio de controles negativos, calculaPromedioNegativosDA.")
      End Try

      cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)

      ReDim calculaL(cuentaNoDatos - 1)
      Dim renglones = 11
      Dim contador = 0
      Dim k As Integer
      For k = desdex To hastax
         If (k = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            calculaL(contador) = CDec(placaLector(k, j))
            contador += 1
         Next
         desdey = 0
      Next



      'desvEst = Math.Sqrt((CDec(Math.Pow(reduceDecimal(cn1 - promedioNegativos), 2)) + CDec(Math.Pow(reduceDecimal(cn2 - promedioNegativos), 2)) + CDec(Math.Pow(reduceDecimal(cn3 - promedioNegativos), 2))) / cuentaNoDatos - 1)

      desvEst = Math.Sqrt((CDec((cn1 - promedioNegativos) ^ 2) + CDec((cn2 - promedioNegativos) ^ 2) + CDec((cn3 - promedioNegativos) ^ 2)) / 3)

      valor3DE = promedioNegativos + (desvEst * 3)

      'MessageBox.Show("Valor de desvEst: " & desvEst & " Valor de promNeg:" & promedioNegativos & " valor 3DE" & valor3DE)

      If (valor3DE >= 0.2) Then
         valorComparacion = desvEst

      Else
         valorComparacion = 0.2
      End If
      MessageBox.Show("Valor de comparacíon: " & valorComparacion)
      ReDim resultadoObtenido(cuentaNoDatos - 1)

      Dim resultado As String = ""

      For k = 0 To cuentaNoDatos - 1
         If (calculaL(k) > valorComparacion) Then
            resultadoObtenido(k) = "Positivo"

         Else
            resultadoObtenido(k) = "Negativo"
         End If
         MessageBox.Show("ValorCOmp: " & valorComparacion & "calcula(i): " & calculaL(k) & " , " & resultadoObtenido(k))
         resultado += resultadoObtenido(k) & vbCrLf
      Next
      MessageBox.Show(resultado)
      'Catch ex As Exception
      '   mensajeException(Me.lblMensajeAAE, ex)
      '   Me.btnLeerArchivoExistente.Enabled = True
      '   Me.btnObtenResultadosDA.Enabled = False
      'End Try

   End Sub

   Private Sub btnCancelarDA_Click(sender As System.Object, e As System.EventArgs)
      Me.Close()
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs)
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.id_analysis = 'E22/ELPASH' order by o.caso,a.id_analysis asc", oConexion)
         Dim oDataSet As New DataSet()
         oConexion.Open()
         oDataAdapter.Fill(oDataSet, "ordenes")
         oConexion.Close()
         Dim oTabla As DataTable
         oTabla = oDataSet.Tables("ordenes")
         'Llena  el comboBox con los datos de la tabla y los registros que coinciden con la búsqueda.
         Dim oFila As DataRow
         For Each oFila In oTabla.Rows
            cmbNoCaso.Items.Add(oFila.Item("caso") & " | " & oFila.Item("IDAN"))
         Next
      Catch ex As MySqlException
         mensajeExceptionSQL(lblMensajeAAE, ex)
      Catch ex As DataException
         mensajeException(lblMensajeAAE, ex)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "ERROR: Al buscar información en el comboBox de casos en pantalla de Nuevo Análisis.")
      End Try
   End Sub

   Private Sub btnBuscaCaso_Click(sender As System.Object, e As System.EventArgs)
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = cmbNoCaso.Text
         tabla = Split(cadena, " | ")

         oConexion.ConnectionString = cadenaConexion

         'aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS, logSPS,logTit1,logTit2 FROM ordenes o,analisis a WHERE o.caso='" & tabla(0) & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & tabla(1) & "' ;"
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS FROM ordenes o,analisis a WHERE o.caso='" & tabla(0) & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & tabla(1) & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservaciones.Text = oDataReader("OBS").ToString()
               'lblLogSPS.Text = oDataReader("logSPS").ToString()
               'lblLogTit1.Text = oDataReader("logTit1").ToString()
               'lblLogTit2.Text = oDataReader("logTit2").ToString()
            End While
            oDataReader.Close()
            lblMensajeAAE.Text = ""
            Me.btnLeerArchivoExistente.Enabled = True
            txtDesdeLetra1.Focus()
         Else
            mensajeRojo(Me.lblMensajeAAE, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
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

   Private Sub botonesEstatus(ByVal estatus As Boolean)
      txtDesdeLetra1.Enabled = estatus
      txtDesdeLetra1.Focus()
      txtDesdeValor1.Enabled = estatus
      txtHastaLetra2.Enabled = estatus
      txtHastaValor2.Enabled = estatus
   End Sub


   Private Sub frmPasteuHaemDesdeArchivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Me.cmbNoCaso.Focus()
   End Sub

   Private Sub txtDesdeLetra1_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtDesdeLetra1, " Desde Pozo x", "A", "H")
   End Sub

   Private Sub txtDesdeValor1_TextChanged(sender As System.Object, e As System.EventArgs)
      controlesValidosNumero(txtDesdeValor1, " Desde Pozo y", 1, 12)
   End Sub

   Private Sub txtHastaLetra2_TextChanged(sender As System.Object, e As System.EventArgs)
      'Valor positivo uno, letra y numero
      controlesValidosLetra(txtHastaLetra2, " Hasta Pozo x ", "A", "H")
   End Sub

   Private Sub txtHastaValor2_TextChanged(sender As System.Object, e As System.EventArgs)
      controlesValidosNumero(txtHastaValor2, " Hasta Pozo y ", 1, 12)
   End Sub

   Private Sub btnCapturaTerminada_Click(sender As System.Object, e As System.EventArgs)
      Try
         botonesEstatus(False)
         btnLeerArchivoExistente.Enabled = False
         coloreaCasos(Me.dgvPlacaLeida, Color.Yellow, txtDesdeLetra1, txtHastaLetra2, txtDesdeValor1, txtHastaValor2)
         If controlesValidosLetra(txtDesdeLetra1, "desde letra", "A", "H") AndAlso _
              controlesValidosNumero(txtDesdeValor1, "desde número", 1, 12) AndAlso _
              controlesValidosLetra(txtHastaLetra2, "hasta letra", "A", "H") AndAlso _
              controlesValidosNumero(txtHastaValor2, "hasta número", 1, 12) AndAlso _
             desdeHastaValidos("", txtDesdeLetra1, txtHastaLetra2, txtDesdeValor1, txtHastaValor2) Then
            btnCapturaTerminada.Enabled = False
            btnObtenResultadosDA.Enabled = True
         Else
            btnCapturaTerminada.Enabled = True
            btnObtenResultadosDA.Enabled = False
            botonesEstatus(True)
         End If
      Catch
         mensajeRojo(Me.lblMensajeAAE, "ERROR: Los valores introducidos Desde pozo - Hasta pozo inválidos.")
         btnCapturaTerminada.Enabled = True
         btnObtenResultadosDA.Enabled = False
         botonesEstatus(True)
      End Try
   End Sub
End Class