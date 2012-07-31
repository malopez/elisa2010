Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmAbrirArchivoExistente

   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs)
      Try
         'abreArchivoExcel(placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
         abreArchivoExcel(Me, Me.ofdSelArchivo, Me.lblMensajeAAE, Me.btnLeerArchivoExistente, _
                          Me.btnObtenResultadosDA, placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "ERROR: al abrir el archivo Excel, abreArchivoExcel.")
      End Try
      Try
         organizaEnTabla(Me.dgvPlacaLeida, placaLector)
      Catch ex As Exception
         mensajeRojo(Me.lblMensajeAAE, "ERROR: al abrir organizar datos en el datagridview, organizaEnTabla.")
      End Try
      botonesEstatus(True)
      btnCapturaTerminada.Enabled = True
      btnObtenResultadosDA.Enabled = False
   End Sub

   Private Sub btnObtenResultadosDA_Click(sender As System.Object, e As System.EventArgs)
      Dim desdeArchivo As Integer = 1
      Dim cp1, cp2, cp3 As Decimal
      Dim cn1, cn2, cn3 As Decimal
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra1)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra2)
      Dim desdey As Integer = CInt(txtDesdeValor1.Text) - 1
      Dim hastay As Integer = CInt(txtHastaValor2.Text) - 1
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
      Dim nocp As Integer = 3
      Try
         cp1 = CDec(Me.txtCPDAValor1.Text)
         cp2 = CDec(Me.txtCPDAValor2.Text)
         cp3 = CDec(Me.txtCPDAValor3.Text)
         cn1 = CDec(Me.txtCNDAValor1.Text)
         cn2 = CDec(Me.txtCNDAValor2.Text)
         cn3 = CDec(Me.txtCNDAValor3.Text)
         btnCapturaTerminada.Enabled = False
         btnObtenResultadosDA.Enabled = False
         'Obtener el nombre del análisis para colocar la cabecera de la gráfica
         Dim cadena As String
         Dim tabla() As String
         cadena = txtAnalisisSolicitado.Text
         tabla = Split(cadena, "/")
         'Obtiene el numero de caso para ese análisis
         Dim cadena1 As String
         Dim tabla1() As String
         cadena1 = cmbNoCaso.Text
         tabla1 = Split(cadena1, " | ")
         Dim numcaso As String = tabla1(0)
         Dim idAnalisis As String = tabla1(1)
         Dim analisis As String = Replace(idAnalisis, "/", "")
         Dim nombre As String = tabla(1)
         Dim nombreCliente As String = txtNombreCliente.Text
         Dim observaciones As String = lblObservaciones.Text
         Dim valorFR As String = ""
         Dim cantidadFR As String = ""
         Dim nombreArchivoImagen As String = ""
         Try
            calculaValoresEnRango(placaLector, desdeArchivo, nocp, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
                                  Convert.ToDecimal(lblLogSPS.Text), Convert.ToDecimal(lblLogTit1.Text), _
                                  Convert.ToDecimal(lblLogTit2.Text), cp1, cp2, cp3, cn1, cn2, cn3, _
                                  desdex, hastax, desdey, hastay, promCP, promCN, difCPS, Me.lblMensajeAAE)
         Catch ex As Exception
            mensajeRojo(Me.lblMensajeAAE, "Error: Al calculor los valores, calculaValoresEnRango.")
         End Try

         cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)

         ReDim calculaL(cuentaNoDatos - 1)

         Try
            mediaGeometrica = calculaSumatoriaMediaGeometrica(calculoDeTitulos, calculaL, desdex, desdey, hastax, hastay, totalcalculaL)
         Catch ex As Exception
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular la sumatoria de la media geométrica.")
         End Try

         Try
            titulosObtenidos = titulosObtenidosEnCalculaL(calculaL, cuentaNoDatos)
         Catch ex As Exception
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al formatear los títulos en cadena, titulosObtenidosEnCalculaL.")
         End Try
         Try
            calculaMarcaDeClase(calculaL, rangoDatos, rangoTotal)
         Catch ex As Exception
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular la marca de clase, calculaMarcaDeClase.")
         End Try
         Try
            mediaGeometrica = calculaMediaGeometrica(mediaGeometrica, rangoTotal)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular la media geométrica, calculaMediaGeometrica.")
         End Try
         Try
            mediaAritmetica = calculaMediaAritmetica(totalcalculaL, cuentaNoDatos)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular la media aritmética, calculaMediaAritmetica.")
         End Try
         Try
            varianza = calculaVarianza(mediaAritmetica, calculaL, cuentaNoDatos)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: AL calcular la varianza, calculaVarianza.")
         End Try
         Try
            desvEst = calculaDesvEst(varianza)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular desviación estándar, calculaDesvEst.")
         End Try
         Try
            coefVar = calculaCoefVar(desvEst, mediaAritmetica)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular el coeficiente de variación, calculaCoefVar.")
         End Try
         Try
            placaoriginal = obtenPlacaLeida(placaLector)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al obtener el string de la placa original, obtenPlacaLeida.")
         End Try
         Try
            calculaFrecuenciaRelativa(frecuenciaRelativa, rangoDatos, rangoTotal)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular la frecuencia relativa, calculaFrecuenciaRelativa.")
         End Try
         Try
            valorFR = obtenValorFR(frecuenciaRelativa)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular el string de valor de la Frec. Rel., obtenValorFR.")
         End Try
         Try
            cantidadFR = obtenCantidadFR(rangoDatos)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al calcular el string de cantidad de la Frec. Rel., obtenCantidadFR.")
         End Try
         Try
            cargaResultadosBD(numcaso, idAnalisis, placaoriginal, titulosObtenidos, fecha.ToShortDateString(), promCP, promCN, difCPS, _
                              Convert.ToDouble(mediaAritmetica), Convert.ToDouble(mediaGeometrica), _
                              Convert.ToDouble(desvEst), Convert.ToDouble(coefVar), valorFR, cantidadFR, Me.lblMensajeAAE)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al cargar resultados a la BD, cargaResultadosBD.")
         End Try
         Try
            cargaFrecRelBD(frecuenciaRelativa, numcaso, rangoDatos, Me.lblMensajeAAE)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al guardar la frecuencia relativa en BD, cargaFrecRelBD.")
         End Try
         'Try
         nombreArchivoImagen = creaChartFrecRel(Me.lblMensajeAAE, frmSalidaDatos, frecuenciaRelativa, rangoDatos, _
                            nombre, titulox, tituloy, numcaso, analisis)
         'Catch
         '   mensajeRojo(Me.lblMensajeAAE, "ERROR: Al crear la gráfica en pantalla, creaChartFrecRel.")
         'End Try
         Try
            frmSalidaDatos.Show()
            mostrarResultadosEnPantalla(frmSalidaDatos.lblNombreSobreGrafica, frmSalidaDatos.lblMensajeSobreGrafica, _
                                        frmSalidaDatos.txtNombreEnfermedad, frmSalidaDatos.txtNombreCliente, frmSalidaDatos.txtNoCaso, _
                                        frmSalidaDatos.lblAnalisis, frmSalidaDatos.lblObservaciones, frmSalidaDatos.txtFechaElaboracion, _
                                        frmSalidaDatos.txtTitulosObtenidos, frmSalidaDatos.txtMediaAritmetica2, _
                                        frmSalidaDatos.txtMediaGeometrica, frmSalidaDatos.txtTotalDatosCalculados, _
                                        frmSalidaDatos.txtCoefVariacion2, frmSalidaDatos.txtDesvEstandar2, frmSalidaDatos.txtVarianza2, _
                                        nombreArchivoImagen, _
                                        Me.txtNombreSobreGrafica.Text, Me.txtMensajeSobreGrafica.Text, _
                                        nombre, nombreCliente, numcaso, analisis, observaciones, fecha.ToShortDateString(), titulosObtenidos, _
                                        mediaAritmetica, mediaGeometrica, cuentaNoDatos, coefVar, desvEst, varianza)
         Catch
            mensajeRojo(Me.lblMensajeAAE, "ERROR: Al mostrar resultados en pantalla, mostrarResultadosEnPantalla.")
         End Try
      Catch ex As Exception
         mensajeException(Me.lblMensajeAAE, ex)
         Me.btnLeerArchivoExistente.Enabled = True
         Me.btnObtenResultadosDA.Enabled = False
      End Try

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
         Dim oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and  a.analysis_desc like '%INMUNOENSAYO%' order by o.caso,a.id_analysis asc", oConexion)
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

         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.Observaciones as OBS, logSPS,logTit1,logTit2 FROM ordenes o,analisis a WHERE o.caso='" & tabla(0) & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados='" & tabla(1) & "' ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados").ToString()
               lblObservaciones.Text = oDataReader("OBS").ToString()
               lblLogSPS.Text = oDataReader("logSPS").ToString()
               lblLogTit1.Text = oDataReader("logTit1").ToString()
               lblLogTit2.Text = oDataReader("logTit2").ToString()
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


   Private Sub frmAbrirArchivoExistente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
         If desdeHastaValidos("", txtDesdeLetra1, txtHastaLetra2, txtDesdeValor1, txtHastaValor2) Then
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

 
   Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

   End Sub
   Private Sub lblMensajeAAE_Click(sender As System.Object, e As System.EventArgs)

   End Sub
   Private Sub lblObservaciones_Click(sender As System.Object, e As System.EventArgs)

   End Sub
   Private Sub pnlRegistraNuevoAnalisis_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

   End Sub
   Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

   End Sub
   Private Sub txtPlacaDesdeArchivo_TextChanged(sender As System.Object, e As System.EventArgs)

   End Sub
End Class