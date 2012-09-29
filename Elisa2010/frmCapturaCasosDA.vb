Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmCapturaCasosDA

   Dim totalCasos() As listaCasos
   Dim posCasoActual As Integer = 0
   Dim numero As Integer = 0
   Dim bandera As Boolean = True
   Dim largo As Integer = 0
   Dim arreglo As String = ""
   Dim chkcontrol As Boolean = True
   Dim cadenaDeCasos As String = "''"
   'Para realizar los calculos de titulos
   'ENFERMEDAD       LOGSPS     LOGTIT1   LOGTIT2
   'Laringo           0.15       1.45        3.726
   'Bronquitis        0.15       1.642       3.568
   'Encefalomielitis  0.15       1.642       3.726
   'IBF               0.18       1.172       3.614
   'NC                0.15       1.464       3.74
   'Reovirus          0.15       1.077       3.46

   '###############################
   '#SECCION DE PROPIEDADES
   '###############################
   'Propiedad donde se recibe el nombre de la enfermedad.
   Private pasaEnfermedad As String
   Public Property Enfermedad() As String
      Get
         Return pasaEnfermedad
      End Get
      Set(ByVal value As String)
         pasaEnfermedad = value
      End Set
   End Property

   '####################################################################################
   '#BARRITA PARA BOTONES QUE AVANZAN ATRAS-ADELANTE, INICIO-FIN.
   '####################################################################################

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
            mensajeRojo(etiquetaMensaje, "Mensaje: Usted se encuentra en el primer Caso.")
         Else
            'Disminuir el marcador del registro y actualizar en pantalla con los datos del registro actual
            posCasoActual -= 1
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            cargarDatosCaso()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnHaciaAdelante_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAdelante.Click
      Try
         If posCasoActual = (UBound(totalCasos) - 1) Then
            mensajeRojo(etiquetaMensaje, "Mensaje: Usted se encuentra en el último caso.")
         Else
            posCasoActual += 1
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            cargarDatosCaso()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
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
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   '####################################################################################
   '#SECCION DE PROCEDIMIENTOS VARIOS QUE SIRVEN DE APOYO PARA MOSTRAR, HABILITAR O DESHABILITAR
   'EL COMBO Y LOS DISTINTOS BOTONES QUE APARECEN EN LA FORMA
   '####################################################################################

   Private Sub botonesEstatus(ByVal estatus As Boolean)
      txtDesdeLetra.Enabled = estatus
      txtDesdeLetra.Focus()
      txtDesdeValor.Enabled = estatus
      txtHastaLetra.Enabled = estatus
      txtHastaValor.Enabled = estatus
   End Sub

   Private Sub statusDeCasoMostrados(ByVal estado As Boolean)
      cmbNoCaso.Enabled = estado
      btnBuscaCaso.Enabled = estado
      txtAnalisisSolicitado.Enabled = estado
      txtNombreCliente.Enabled = estado
      txtMensajeSobreGrafica.Enabled = estado
      txtObservaciones.Enabled = estado
      txtDesdeLetra.Enabled = estado
      txtDesdeValor.Enabled = estado
      txtHastaLetra.Enabled = estado
      txtHastaValor.Enabled = estado
   End Sub

   Private Sub statusDeSubCasoMostrados(ByVal estado As Boolean)
      cmbNoCaso.Enabled = estado
      btnBuscaCaso.Enabled = estado
      txtAnalisisSolicitado.Enabled = estado
      txtNombreCliente.Enabled = estado
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
      txtObservaciones.Text = ""
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
         txtObservaciones.Text = totalCasos(posCasoActual).obs
         txtDesdeLetra.Text = obtenLetra(totalCasos(posCasoActual).desdeLetra)
         txtDesdeValor.Text = totalCasos(posCasoActual).desdeValor
         txtHastaLetra.Text = obtenLetra(totalCasos(posCasoActual).hastaLetra)
         txtHastaValor.Text = totalCasos(posCasoActual).hastaValor
         lblCasoDeCaso.Text = "Caso: " & posCasoActual + 1 & " de " & UBound(totalCasos)
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub guardaCasoEnArreglo(ByVal posicion As Integer)
      'MessageBox.Show("valor de posicion en guardaCasoEnArreglo:" & posicion)
      Dim colorFondo As miRGB
      totalCasos(posicion).noCaso = cmbNoCaso.Text
      totalCasos(posicion).noSubcasos = 0
      totalCasos(posicion).subCaso = 0
      totalCasos(posicion).analisis = txtAnalisisSolicitado.Text
      totalCasos(posicion).cliente = txtNombreCliente.Text
      totalCasos(posicion).texto = txtMensajeSobreGrafica.Text
      totalCasos(posicion).obs = txtObservaciones.Text
      totalCasos(posicion).desdeLetra = siValorEsLetra(txtDesdeLetra)
      totalCasos(posicion).desdeValor = CInt(txtDesdeValor.Text)
      totalCasos(posicion).hastaLetra = siValorEsLetra(txtHastaLetra)
      totalCasos(posicion).hastaValor = CInt(txtHastaValor.Text)
      'Se utiliza para colorar los casos del color aleatorio obtenido de Rnd
      Randomize()
      colorFondo.R = CInt(Rnd() * 255)
      colorFondo.G = CInt(Rnd() * 255)
      colorFondo.B = CInt(Rnd() * 255)
      coloreaLosCasos(dgvPlacaLeida, Color.FromArgb(colorFondo.R, colorFondo.G, colorFondo.B), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      lblCasoDeCaso.Text = "Caso: " & posCasoActual + 1 & " de " & UBound(totalCasos)

   End Sub

   Private Sub guardaSubCasoEnArreglo(ByVal posicion As Integer)
      Dim colorFondo As miRGB
      totalCasos(posicion).noCaso = cmbNoCaso.Text
      totalCasos(posicion).noSubcasos = CInt(txtNoSubcasos.Text)
      totalCasos(posicion).subCaso = CInt(lblNoSubCaso.Text)
      totalCasos(posicion).analisis = txtAnalisisSolicitado.Text
      totalCasos(posicion).cliente = txtNombreCliente.Text
      totalCasos(posicion).texto = txtMensajeSobreGrafica.Text
      totalCasos(posicion).obs = txtObservaciones.Text
      totalCasos(posicion).desdeLetra = siValorEsLetra(txtDesdeLetra)
      totalCasos(posicion).desdeValor = CInt(txtDesdeValor.Text)
      totalCasos(posicion).hastaLetra = siValorEsLetra(txtHastaLetra)
      totalCasos(posicion).hastaValor = CInt(txtHastaValor.Text)
      'Se utiliza para colorar los casos del color aleatorio obtenido de Rnd
      Randomize()
      colorFondo.R = CInt(Rnd() * 255)
      colorFondo.G = CInt(Rnd() * 255)
      colorFondo.B = CInt(Rnd() * 255)
      coloreaLosCasos(dgvPlacaLeida, Color.FromArgb(colorFondo.R, colorFondo.G, colorFondo.B), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      lblCasoDeCaso.Text = "Subcaso: " & lblNoSubCaso.Text + 1 & " de " & txtNoSubcasos.Text
   End Sub

   Private Sub guardaSubCasoEnArregloEditado(ByVal posicion As Integer)
      Dim colorFondo As miRGB
      totalCasos(posicion).texto = txtMensajeSobreGrafica.Text
      totalCasos(posicion).obs = txtObservaciones.Text
      totalCasos(posicion).desdeLetra = siValorEsLetra(txtDesdeLetra)
      totalCasos(posicion).desdeValor = CInt(txtDesdeValor.Text)
      totalCasos(posicion).hastaLetra = siValorEsLetra(txtHastaLetra)
      totalCasos(posicion).hastaValor = CInt(txtHastaValor.Text)
      'Se utiliza para colorar los casos del color aleatorio obtenido de Rnd
      Randomize()
      colorFondo.R = CInt(Rnd() * 255)
      colorFondo.G = CInt(Rnd() * 255)
      colorFondo.B = CInt(Rnd() * 255)
      coloreaLosCasos(dgvPlacaLeida, Color.FromArgb(colorFondo.R, colorFondo.G, colorFondo.B), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      lblCasoDeCaso.Text = "Subcaso: " & lblNoSubCaso.Text + 1 & " de " & txtNoSubcasos.Text
   End Sub

   Private Sub habilitaBarrita(ByVal estatus As Boolean)
      btnInicio.Enabled = estatus
      btnHaciaAdelante.Enabled = estatus
      btnHaciaAtras.Enabled = estatus
      btnFin.Enabled = estatus
   End Sub

   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerArchivoExistente.Click
      Try
         abreArchivoExcel(Me.ofdSelArchivo, etiquetaMensaje, Me.btnLeerArchivoExistente, _
                          Me.btnLeerArchivoExistente, placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: al abrir el archivo Excel, abreArchivoExcel.")
      End Try
      Try
         organizaEnTabla(Me.dgvPlacaLeida, placaLector)
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: al abrir organizar datos en el datagridview, organizaEnTabla.")
      End Try
      habilitaBarrita(False)
      btnLeerArchivoExistente.Enabled = False
   End Sub

   Private Sub btnAceptarNoCasos_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarNoCasos.Click
      Dim nocp As Integer = 3
      Dim nocn As Integer = 3
      If controlesValidosNumero(txtNoDeCasos, " Valor en número de casos ", 1, 94) Then
         Try
            txtNoDeCasos.Enabled = False
            txtNoControlesPositivos.Enabled = False
            txtNoControlesNegativos.Enabled = False
            btnInsertar.Enabled = True
            'dibujaTablaEnPantalla(dgvPlacaLeida)
            btnAceptarNoCasos.Enabled = False
            Dim oConexion As MySqlConnection
            Dim aConsulta As String = ""
            Dim oDataReader As MySqlDataReader
            Dim oComando As New MySqlCommand
            oConexion = New MySqlConnection
            'Separa el texto del comboBox 
            Dim cadena As String
            Dim tabla() As String
            'cmbNombreEnfermedad.Text = pasaEnfermedad
            cadena = pasaEnfermedad
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
               etiquetaMensaje.Text = ""
               txtNoSubcasos.Text = "2"
            Else
               mensajeRojo(etiquetaMensaje, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
            End If
            oConexion.Close()
         Catch ex As MySqlException
            mensajeExceptionSQL(etiquetaMensaje, ex)
         Catch ex As DataException
            mensajeException(etiquetaMensaje, ex)
         Catch ex As Exception
            mensajeException(etiquetaMensaje, ex)
         End Try
      Else
         mensajeRojo(etiquetaMensaje, "ERROR: Los valores que ha introducido para no. de casos y no. de controles + y - no son válidos, trate nuevamente.")
         txtNoDeCasos.Enabled = True
         btnAceptarNoCasos.Enabled = True
      End If
   End Sub

   '####################################################################################
   'PROCEDIMIENTO QUE OBTIENE LOS RESULTADOS POR CASO PASANDO COMO PARAMETRO EL DESDE HASTA 
   'DE CADA UNO DE LOS CASOS
   '####################################################################################
   Private Sub obtenResultadosPorCaso(ByVal mensaje As String, ByRef forma As frmResultadosPrelim, ByRef etiqueta As ToolStripLabel, _
                                      ByVal posicion As Integer, _
                                      ByVal promCP As Decimal, ByVal promCN As Decimal, ByVal difCPS As Decimal, _
                                      ByVal DAnoCaso As String, ByVal DAnoSubcasos As Integer, ByVal consecutivo As Integer, _
                                      ByVal DAanalisisSolicitado As String, ByVal DAobs As String, _
                                      ByVal DADesdeLetra As Integer, ByVal DAhastaLetra As Integer, _
                                      ByVal DAdesdeValor As Integer, ByVal DAhastaValor As Integer, ByRef titulosObtenidos As String)
      Dim calculaL() As Decimal
      Dim cuentaNoDatos As Integer = 0
      Dim totalcalculaL As Decimal = 0
      Dim rangoTotal As Integer = 0
      Dim rangoDatos(14) As Integer
      Dim placaoriginal As String = ""
      Dim mediaGeometrica As Decimal
      Dim mediaAritmetica As Decimal = 0
      Dim varianza As Decimal = 0
      Dim desvEst As Decimal = 0
      Dim coefVar As Decimal = 0
      'Dim titulosObtenidos As String = ""
      Dim titulox As String = "Grupo de títulos"
      Dim valorFR As String = ""
      Dim cantidadFR As String = ""
      Dim tituloy As String = "%"
      Dim fecha = DateTime.Now

      'Obtener valores desde-hasta para el caso
      Dim desdex As Integer = DADesdeLetra
      Dim hastax As Integer = DAhastaLetra
      Dim desdey As Integer = DAdesdeValor - 1
      Dim hastay As Integer = DAhastaValor - 1

      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      Dim cadena As String
      Dim tabla() As String
      cadena = pasaEnfermedad
      tabla = Split(cadena, " | ")
      'Obtiene el numero de caso para ese análisis
      Dim idAnalisis As String = tabla(0)
      Dim analisis As String = Replace(idAnalisis, "/", "")
      Dim nom As String = tabla(1)
      Dim numcaso As String = DAnoCaso
      Dim observaciones As String = DAobs
      Dim nombreArchivoImagen As String = ""

      cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)
      totalCasos(posicion).sueros = cuentaNoDatos

      ReDim calculaL(cuentaNoDatos - 1)

      'Si el numero de datos es 1, entonces el cálculo de la estadística es 0, excepto para la media aritmética.
      If cuentaNoDatos > 1 Then
         Try
            mediaGeometrica = calculaSumatoriaMediaGeometrica(calculoDeTitulos, calculaL, desdex, desdey, hastax, hastay, totalcalculaL)
         Catch ex As Exception
            mensajeRojo(etiquetaMensaje, "ERROR: Al calcular la sumatoria de la media geométrica.")
         End Try
      End If

      Try
         titulosObtenidos = titulosObtenidosEnCalculaL(calculaL, cuentaNoDatos)
         totalCasos(posicion).titulosObtenidos = titulosObtenidos
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: Al formatear los títulos en cadena, titulosObtenidosEnCalculaL.")
      End Try
      Try
         seleccionaMarcaDeClase(analisis, calculaL, rangoDatos, rangoTotal)
      Catch ex As Exception
         mensajeRojo(etiquetaMensaje, "ERROR: Al calcular la marca de clase, calculaMarcaDeClase.")
      End Try

      If cuentaNoDatos > 1 Then
         Try
            mediaGeometrica = calculaMediaGeometrica(mediaGeometrica, rangoTotal)
            totalCasos(posicion).medGeom = mediaGeometrica
         Catch
            mensajeRojo(etiquetaMensaje, "ERROR: Al calcular la media geométrica, calculaMediaGeometrica.")
         End Try
      End If

      Try
         mediaAritmetica = calculaMediaAritmetica(totalcalculaL, cuentaNoDatos)
         totalCasos(posicion).medArit = mediaAritmetica
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al calcular la media aritmética, calculaMediaAritmetica.")
      End Try

      If cuentaNoDatos > 1 Then
         Try
            varianza = calculaVarianza(mediaAritmetica, calculaL, cuentaNoDatos)
            totalCasos(posicion).varianza = varianza
         Catch
            mensajeRojo(etiquetaMensaje, "ERROR: AL calcular la varianza, calculaVarianza.")
         End Try
      End If
      If cuentaNoDatos > 1 Then
         Try
            desvEst = calculaDesvEst(varianza)
            totalCasos(posicion).desvEst = desvEst
         Catch
            mensajeRojo(etiquetaMensaje, "ERROR: Al calcular desviación estándar, calculaDesvEst.")
         End Try
      End If
      If cuentaNoDatos > 1 Then
         Try
            coefVar = calculaCoefVar(desvEst, mediaAritmetica)
            totalCasos(posicion).coefVar = coefVar
         Catch
            mensajeRojo(etiquetaMensaje, "ERROR: Al calcular el coeficiente de variación, calculaCoefVar.")
         End Try
      End If
      Try
         placaoriginal = obtenPlacaLeida(placaLector)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al obtener el string de la placa original, obtenPlacaLeida.")
      End Try
      Try
         calculaFrecuenciaRelativa(frecuenciaRelativa, rangoDatos, rangoTotal)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al calcular la frecuencia relativa, calculaFrecuenciaRelativa.")
      End Try
      Try
         valorFR = obtenValorFR(frecuenciaRelativa)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al calcular el string de valor de la Frec. Rel., obtenValorFR.")
      End Try
      Try
         cantidadFR = obtenCantidadFR(rangoDatos)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al calcular el string de cantidad de la Frec. Rel., obtenCantidadFR.")
      End Try
      Try
         cargaResultadosBD(numcaso, consecutivo, idAnalisis, placaoriginal, titulosObtenidos, fecha.ToShortDateString(), promCP, promCN, difCPS, _
                           totalCasos(posicion).medArit, totalCasos(posicion).medGeom, _
                           totalCasos(posicion).desvEst, totalCasos(posicion).coefVar, valorFR, cantidadFR, etiquetaMensaje)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al cargar resultados a la BD, cargaResultadosBD.")
      End Try
      Try
         cargaFrecRelBD(frecuenciaRelativa, numcaso, rangoDatos, etiquetaMensaje)
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al guardar la frecuencia relativa en BD, cargaFrecRelBD.")
      End Try
      Try
         nombreArchivoImagen = creaChartFrecRel(etiquetaMensaje, frecuenciaRelativa, rangoDatos, _
                           titulox, tituloy, numcaso, consecutivo, analisis)
         totalCasos(posicion).nombreArchivoImagen = nombreArchivoImagen
      Catch
         mensajeRojo(etiquetaMensaje, "ERROR: Al crear la gráfica en pantalla, creaChartFrecRel.")
      End Try
   End Sub

   Private Sub btnObtenerResultados_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenerResultados.Click
      Dim desdeArchivo As Integer = 1
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
      Dim nocp As Integer = 3
      Dim nocn As Integer = 3
      cp1 = CDec(Me.txtCPDAValor1.Text)
      cp2 = CDec(Me.txtCPDAValor2.Text)
      cp3 = CDec(Me.txtCPDAValor3.Text)
      cn1 = CDec(Me.txtCNDAValor1.Text)
      cn2 = CDec(Me.txtCNDAValor2.Text)
      cn3 = CDec(Me.txtCNDAValor3.Text)
      Dim i As Integer = 0
      Dim fecha = DateTime.Now
      Dim titulosObtenidos As String = ""
      Dim nombreSobreGrafica As String = txtNombreSobreGrafica.Text
      Dim mensajeSobreGrafica As String = txtMensajeSobreGrafica.Text
      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      Dim cadena As String
      Dim tabla() As String
      cadena = pasaEnfermedad
      tabla = Split(cadena, " | ")
      'Obtiene el numero de caso para ese análisis
      Dim idAnalisis As String = tabla(0)
      Dim analisis As String = Replace(idAnalisis, "/", "")
      'Realiza el cálculo de los títulos seleccionando un procedimiento de acuerdo a la enfermedad.
      calculaValoresEnRango(placaLector, desdeArchivo, nocp, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, cnx1, cnx2, cnx3, cny1, cny2, cny3, _
                                     Convert.ToDecimal(lblLogSPS.Text), Convert.ToDecimal(lblLogTit1.Text), _
                                     Convert.ToDecimal(lblLogTit2.Text), cp1, cp2, cp3, cn1, cn2, cn3, _
                                     desdex, hastax, desdey, hastay, promCP, promCN, difCPS, etiquetaMensaje)
      Dim forma As frmResultadosPrelim
      forma = New frmResultadosPrelim
      forma.Nombre = tabla(1)
      forma.NombreAnalisis = analisis
      forma.ArregloCasos = totalCasos
      forma.Fecha = fecha.ToShortDateString()
      forma.NombreGrafica = nombreSobreGrafica
      Console.WriteLine(nombreSobreGrafica)
      forma.MdiParent = frmElisaBiovetsa
      forma.Show()
      For i = 0 To largo - 1
         obtenResultadosPorCaso("Caso No." & i + 1, forma, etiquetaMensaje, i, promCP, promCN, difCPS, _
                               totalCasos(i).noCaso, totalCasos(i).noSubcasos, totalCasos(i).subCaso, _
                               totalCasos(i).analisis, totalCasos(i).obs, _
                               totalCasos(i).desdeLetra, totalCasos(i).hastaLetra, _
                               totalCasos(i).desdeValor, totalCasos(i).hastaValor, titulosObtenidos)
         forma.cmbCasosResPrel.Items.Insert(i, totalCasos(i).noCaso & " Subcaso: " & totalCasos(i).subCaso)
      Next

      'Se coloca el índice del combobox en 0, y se presentan los primeros resultados en pantalla por default.
      forma.cmbCasosResPrel.SelectedIndex = 0
      presentaResultadosEnPantalla(forma.lblAnalisis, analisis, _
                                   forma.txtFechaElaboracion, fecha.ToShortDateString(), _
                                   forma.txtNombreEnfermedad, tabla(1), _
                                   forma.txtNombreCliente, totalCasos(0).cliente, _
                                   forma.txtObservaciones, totalCasos(0).obs, _
                                   forma.txtVarianza2, totalCasos(0).varianza, _
                                   forma.txtTotalDatosCalculados, totalCasos(0).sueros, _
                                   forma.txtMediaAritmetica2, totalCasos(0).medArit, _
                                   forma.txtMediaGeometrica, totalCasos(0).medGeom, _
                                   forma.txtCoefVariacion2, totalCasos(0).coefVar, _
                                   forma.txtDesvEstandar2, totalCasos(0).desvEst, _
                                   forma.lblNosubcasos, totalCasos(0).noSubcasos, _
                                   forma.lblConsecutivo, totalCasos(0).subCaso, _
                                   forma.txtTitulosObtenidos, totalCasos(0).titulosObtenidos, _
                                   forma.lblNombreSobreGrafica, nombreSobreGrafica, _
                                   forma.lblMensajeSobreGrafica, totalCasos(0).texto, _
                                   forma.imagenGrafica, totalCasos(0).nombreArchivoImagen, _
                                   forma.lblNombreArchivo)
   End Sub

   Private Sub btnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertar.Click
      mensajeVerde(etiquetaMensaje, "Mensaje: Usted captura el Análisis No." & numero + 1 & " de " & txtNoDeCasos.Text)
      limpiaInformacionCaso()
      statusDeCasoMostrados(True)
      cmbNoCaso.Focus()
      txtMensajeSobreGrafica.Enabled = True
      txtMensajeSobreGrafica.ReadOnly = False
      estatusDesdeHasta(False)
      tbcDatosDelCaso.SelectTab(1)
      btnInsertar.Enabled = False
      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      btnEditar.Enabled = False
      btnGuardar.Enabled = True
   End Sub

   Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
      Dim i As Integer = 0
      Try
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
            ReDim Preserve totalCasos(largo + 1)
            If siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
                controlesValidosLetra(txtDesdeLetra, "Caso " & (largo + 1), "A", "H") AndAlso _
                controlesValidosNumero(txtDesdeValor, "Caso " & (largo + 1), 1, 12) AndAlso _
                controlesValidosLetra(txtHastaLetra, "Caso " & (largo + 1), "A", "H") AndAlso _
                controlesValidosNumero(txtHastaValor, "Caso " & (largo + 1), 1, 12) AndAlso _
                desdeHastaValidos("Caso " & (largo + 1), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) Then
               Try
                  guardaCasoEnArreglo(largo)
                  cadenaDeCasos += ",'" & totalCasos(posCasoActual).noCaso & "'"
                  numero += 1
                  largo += 1
                  btnInsertar.Enabled = True
                  mensajeVerde(etiquetaMensaje, "Mensaje: Usted guardó el caso No." & numero & " de " & txtNoDeCasos.Text & " exitosamente.")
                  If (numero = CInt(txtNoDeCasos.Text)) Then
                     btnCapturaTerminada.Enabled = True
                     mensajeVerde(etiquetaMensaje, "MENSAJE: Usted ha capturado el total de casos solicitados.")
                     btnInsertar.Enabled = False
                     statusDeCasoMostrados(False)
                     txtMensajeSobreGrafica.Enabled = False
                     txtMensajeSobreGrafica.ReadOnly = True
                     estatusDesdeHasta(True)
                     habilitaDesdeHasta(False)
                     chkSubCasos.Enabled = False
                     btnEditar.Enabled = True
                     'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
                     habilitaBarrita(True)
                     btnCapturaTerminada.Enabled = True
                  Else 'Agregado el 25-Ago-2012
                     statusDeCasoMostrados(False)
                     txtMensajeSobreGrafica.Enabled = False
                     txtMensajeSobreGrafica.ReadOnly = True
                     estatusDesdeHasta(True)
                     habilitaDesdeHasta(False)
                  End If
               Catch
                  MessageBox.Show("ERROR: No se ha podido guardar correctamente el caso en el arreglo.")
                  btnInsertar.Enabled = False
                  btnEditar.Enabled = False
                  btnGuardar.Enabled = True
                  mensajeRojo(etiquetaMensaje, "Los valores que se introdujeron tienen el mismo rango, caso o desde-hasta que otro caso anterior, Verifique.")
               End Try
            Else
               btnInsertar.Enabled = False
               btnEditar.Enabled = False
               btnGuardar.Enabled = True
               mensajeRojo(etiquetaMensaje, "Los valores que se introdujeron tienen el mismo rango, caso o desde-hasta que otro caso anterior, Verifique.")
            End If
            'Verifica que no se han excedido el número de casos solicitados.
         ElseIf (numero <= CInt(txtNoDeCasos.Text)) Then
            'Para todos los casos validar que no se encuentre en el rango de valores positivos y negativos
            'Validar desde - hasta definido en el caso
            'Validar desde-hasta con otros casos ya guardados.
            'Si se cumple la condicion, entonces Guardar en el arreglo
            If siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
                controlesValidosLetra(txtDesdeLetra, "Caso " & numero, "A", "H") AndAlso _
                controlesValidosNumero(txtDesdeValor, "Caso " & numero, 1, 12) AndAlso _
                controlesValidosLetra(txtHastaLetra, "Caso " & numero, "A", "H") AndAlso _
                controlesValidosNumero(txtHastaValor, "Caso " & numero, 1, 12) AndAlso _
                desdeHastaValidos("Caso " & numero, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) Then
               'Este ciclo  permite revisar que el caso de pantalla y los existentes en el arreglo sean distintos.
               While (validaSiDosCasosEstanEnDistintoRangoArreglo("Caso capturado y " & numero, _
               txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor, _
               totalCasos(i).desdeLetra, totalCasos(i).desdeValor, _
               totalCasos(i).hastaLetra, totalCasos(i).hastaValor) And (i <= (largo - 1)))
                  i += 1
               End While
               'Si i=largo indica que no hay rangos repetidos, entonces crece el arreglo y guarda los nuevos datos.
               'En caso de que los rangos sean iguales, no guarda nada, solo habilita botones de guardar.
               If i = largo Then
                  largo += 1
                  ReDim Preserve totalCasos(largo)
                  numero += 1
                  posCasoActual = largo - 1
                  guardaCasoEnArreglo(posCasoActual)
                  btnInsertar.Enabled = True
                  mensajeVerde(etiquetaMensaje, "Mensaje: Usted guardó el caso No." & numero & " de " & txtNoDeCasos.Text)
                  cadenaDeCasos += ",'" & totalCasos(posCasoActual).noCaso & "'"
                  statusDeCasoMostrados(False)
                  txtMensajeSobreGrafica.Enabled = False
                  txtMensajeSobreGrafica.ReadOnly = True
                  estatusDesdeHasta(True)
                  habilitaDesdeHasta(False)
               Else
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que se introdujeron se encuentran en el mismo rango que los del caso: " & totalCasos(i).noCaso & ", Verifique.")
                  btnInsertar.Enabled = False
                  btnEditar.Enabled = False
                  btnGuardar.Enabled = True
               End If
            Else
               mensajeRojo(etiquetaMensaje, "ERROR: Los valores que se introdujeron tienen el mismo rango, caso o desde-hasta que otro caso anterior, Verifique.")
               btnInsertar.Enabled = False
               btnEditar.Enabled = False
               btnGuardar.Enabled = True
            End If
            'En caso de que el número sea igual, manda el mensaje de que ya no se pueden capturar más casos")
            If (numero = CInt(txtNoDeCasos.Text)) Then
               mensajeVerde(etiquetaMensaje, "MENSAJE: Usted ha capturado el total de casos solicitados.")
               btnInsertar.Enabled = False
               statusDeCasoMostrados(False)
               txtMensajeSobreGrafica.Enabled = False
               txtMensajeSobreGrafica.ReadOnly = True
               estatusDesdeHasta(True)
               habilitaDesdeHasta(False)
               chkSubCasos.Enabled = False
               btnEditar.Enabled = True
               'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
               habilitaBarrita(True)
               btnCapturaTerminada.Enabled = True
            End If
         End If
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
      statusDeCasoMostrados(True)
      cmbNoCaso.Enabled = False
      btnBuscaCaso.Enabled = False
      chkSubCasos.Enabled = False
      txtMensajeSobreGrafica.ReadOnly = False
      estatusDesdeHasta(False)
      coloreaCasos(dgvPlacaLeida, Color.White, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor)
      btnEditar.Enabled = False
      btnInsertar.Enabled = False
      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      btnGuardarEditado.Enabled = True
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
             desdeHastaValidos("Caso " & numero, txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) Then
         'Recorrer el arreglo para validar que el caso modificado no tiene valores de rango de los que ya se encuentran capturados.
         tamano = UBound(totalCasos) - 1
         For i = 0 To tamano
            If (i <> posCasoActual) Then
               If Not validaSiDosCasosEstanEnDistintoRangoArreglo("Caso capturado y caso" & (i + 1), _
                          txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor, _
                          totalCasos(i).desdeLetra, totalCasos(i).desdeValor, _
                          totalCasos(i).hastaLetra, totalCasos(i).hastaValor) Then
                  mensajeRojo(etiquetaMensaje, "ERROR: Los valores que se introdujeron e encuentran en el mismo rango que los del caso " & totalCasos(i).noCaso & ", Verifique.")
                  bandera = False
                  Exit For
               End If
            End If
         Next
         If (bandera = True) Then
            If totalCasos(posCasoActual).noSubcasos = 0 Then
               guardaCasoEnArreglo(posCasoActual)
            Else
               guardaSubCasoEnArregloEditado(posCasoActual)
            End If
            habilitaBarrita(True)
            btnGuardarEditado.Enabled = False
            btnEditar.Enabled = True
            statusDeCasoMostrados(False)
            txtMensajeSobreGrafica.Enabled = False
            txtMensajeSobreGrafica.ReadOnly = True
            estatusDesdeHasta(True)
            habilitaDesdeHasta(False)
            mensajeVerde(etiquetaMensaje, "Mensaje: Usted actualizó el caso No." & (posCasoActual + 1) & " de " & UBound(totalCasos))
         End If
      Else
         mensajeRojo(etiquetaMensaje, "ERROR: Los valores que se introdujeron se encuentran en el mismo rango que los controles positivos o negativos, Verifique.")
         btnGuardarEditado.Enabled = True
      End If
   End Sub

   Private Sub btnNuevoSubcaso_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoSubcaso.Click
      btnNuevoSubcaso.Enabled = False
      txtNoSubcasos.Enabled = False
      txtNoSubcasos.ReadOnly = True
      btnGuardarSubcaso.Enabled = True
      btnGuardarSubcaso.Visible = True
      mensajeVerde(etiquetaMensaje, "Mensaje: Usted captura el Subcaso No." & lblNoSubCaso.Text & " de " & txtNoSubcasos.Text)
      'No cambia el caso, ni el cliente, ni enfermedad y limpia el desde hasta del caso para que se coloque el numero de subcaso
      statusDeSubCasoMostrados(False)
      txtMensajeSobreGrafica.Enabled = True
      txtMensajeSobreGrafica.ReadOnly = False
      txtMensajeSobreGrafica.Focus()
      habilitaDesdeHasta(True)
      estatusDesdeHasta(False)
      txtDesdeLetra.Text = "A"
      txtDesdeValor.Text = "1"
      txtHastaLetra.Text = "A"
      txtHastaValor.Text = "1"
      'Habilita la barrita para desplazarse sobre los análisis de caso capturados.
      habilitaBarrita(False)
      btnEditar.Enabled = False
   End Sub

   Private Sub btnGuardarSubcaso_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarSubcaso.Click
      Dim i As Integer = 0
      'Agregado el  17-09-2012
      txtMensajeSobreGrafica.Enabled = False
      txtMensajeSobreGrafica.ReadOnly = True
      'Se requiere que tenga al menos dos subcasos
      'modificarlo porque en subcasos no aplica esta validacion de combo con casos iguales.
      If controlesValidosNumero(txtNoSubcasos, "En número de subcasos, ", 2, 94) AndAlso _
         siComboNoEsBlanco(cmbNoCaso, cmbNoCaso.Text) AndAlso _
         controlesValidosLetra(txtDesdeLetra, "Caso " & (largo + 1), "A", "H") AndAlso _
         controlesValidosNumero(txtDesdeValor, "Caso " & (largo + 1), 1, 12) AndAlso _
         controlesValidosLetra(txtHastaLetra, "Caso " & (largo + 1), "A", "H") AndAlso _
         controlesValidosNumero(txtHastaValor, "Caso " & (largo + 1), 1, 12) AndAlso _
         desdeHastaValidos("Caso " & (largo + 1), txtDesdeLetra, txtHastaLetra, txtDesdeValor, txtHastaValor) Then
         If CInt(lblNoSubCaso.Text) <= CInt(txtNoSubcasos.Text) Then
            'Revisa todos los registros del arreglo para verificar que no se encuentran en el mismo rango 
            'cuando exista al menos 1 registro en el arreglo
            If (largo >= 1) Then
               If chkcontrol Then
                  While (validaSiDosCasosEstanEnDistintoRangoArreglo("Caso capturado y " & numero, _
               txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor, _
               totalCasos(i).desdeLetra, totalCasos(i).desdeValor, _
               totalCasos(i).hastaLetra, totalCasos(i).hastaValor) And (i <= (largo - 1)))
                     i += 1
                  End While
               End If
            End If
            'Cuando i = largo indica que se revisó todo el arreglo y no hay caso con rangos repetidos.
            If i = largo Then
               If largo = 0 Then
                  largo += 1
                  ReDim Preserve totalCasos(largo)
               Else
                  largo = UBound(totalCasos) + 1
                  ReDim Preserve totalCasos(largo)
               End If
               posCasoActual = largo - 1
               guardaSubCasoEnArreglo(posCasoActual)
               cadenaDeCasos += ",'" & totalCasos(posCasoActual).noCaso & "'"
               'Agregado el if el 17-Sep-2012
               If CInt(lblNoSubCaso.Text) < CInt(txtNoSubcasos.Text) Then
                  'Limpia los valores desde hasta para el siguiente subcaso.
                  txtMensajeSobreGrafica.Text = ""
                  txtDesdeLetra.Enabled = False
                  txtDesdeLetra.Text = "A"
                  txtDesdeValor.Enabled = False
                  txtDesdeValor.Text = "1"
                  txtHastaLetra.Enabled = False
                  txtHastaLetra.Text = "A"
                  txtHastaValor.Enabled = False
                  txtHastaValor.Text = "1"
               End If
               btnNuevoSubcaso.Enabled = True
               btnGuardarSubcaso.Enabled = False
               lblNoSubCaso.Text = CInt(lblNoSubCaso.Text) + 1
               chkSubCasos.Enabled = False
            Else
               btnGuardarSubcaso.Enabled = True
               txtDesdeLetra.Text = "A"
               txtDesdeLetra.Focus()
               txtDesdeValor.Text = "1"
               txtHastaLetra.Text = "A"
               txtHastaValor.Text = "1"
               mensajeRojo(etiquetaMensaje, "ERROR: Los valores que se introdujeron se encuentran en el mismo rango que los del caso: " & totalCasos(i).noCaso & ", Verifique.")
            End If
            If (CInt(lblNoSubCaso.Text) > CInt(txtNoSubcasos.Text)) Then
               btnNuevoSubcaso.Enabled = False
               btnGuardarSubcaso.Enabled = False
               btnNuevoSubcaso.Visible = False
               btnGuardarSubcaso.Visible = False
               numero += 1
               'Verifica que no los casos no se hayan terminado de capturar y habilita el boton, en caso de que ya 
               'Se tenga la captura de todos los casos, deshabilita el boton y habilita la barrita de <<, <, >, >> atras y adelante.
               If numero <= CInt(txtNoDeCasos.Text) Then
                  If CInt(lblNoSubCaso.Text) < CInt(txtNoSubcasos.Text) Then
                     btnNuevoSubcaso.Enabled = True
                     btnNuevoSubcaso.Visible = True
                  Else
                     btnInsertar.Enabled = True
                     habilitaDesdeHasta(False)
                     txtMensajeSobreGrafica.Enabled = False
                     txtMensajeSobreGrafica.ReadOnly = True
                     cmbNoCaso.Focus()
                     lblNoSubCaso.Text = "1"
                  End If
                  If numero = CInt(txtNoDeCasos.Text) Then
                     btnInsertar.Enabled = False
                     habilitaBarrita(True)
                     btnEditar.Enabled = True
                     chkSubCasos.Enabled = False
                     btnCapturaTerminada.Enabled = True
                  End If
               Else
                  habilitaBarrita(True)
                  btnEditar.Enabled = True
                  chkSubCasos.Enabled = False
               End If
            End If
         Else 'De la validacion de subcasos >=2
            'Enviar mensaje de que al menos debe haber dos subcasos.
            mensajeRojo(etiquetaMensaje, "ERROR: Debe escribir un número entre 2 y 94 para la cantidad de subcasos, Verifique.")
            btnNuevoSubcaso.Enabled = True
            btnGuardarSubcaso.Enabled = False
         End If 'De la validacion de subcasos >=2
      Else
         btnNuevoSubcaso.Enabled = False
         btnGuardarSubcaso.Enabled = True
         mensajeRojo(etiquetaMensaje, "Los valores que se introdujeron tienen el mismo rango, o desde-hasta que otro caso anterior, Verifique.")
      End If
   End Sub

   Private Sub btnCapturaTerminada_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturaTerminada.Click
      'habilitaBarrita(False)
      btnEditar.Enabled = False
      btnCapturaTerminada.Enabled = False
      tbcDatosDelCaso.SelectTab(0)
      btnLeerArchivoExistente.Enabled = True
   End Sub

   Private Sub cmbNoCaso_Click(sender As Object, e As System.EventArgs) Handles cmbNoCaso.Click
      Try
         cmbNoCaso.Items.Clear()
         txtNombreCliente.Text = ""
         txtAnalisisSolicitado.Text = ""
         'Separa el texto del comboBox 
         Dim cadena As String
         Dim tabla() As String
         cadena = pasaEnfermedad
         tabla = Split(cadena, " | ")
         Dim an As String = "'" & tabla(0) & "'"
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim oDataAdapter As MySqlDataAdapter
         'SI NUMERO ES 0 indica que es el primer caso que se registra.
         If numero = 0 Then
            oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and id_analysis in (" & an & ") order by o.caso,a.id_analysis asc", oConexion)
         Else
            oDataAdapter = New MySqlDataAdapter("SELECT  o.caso,a.id_analysis as IDAN FROM ordenes o,analisis a WHERE o.id_area=3 and o.id_status=1 and o.AnalisisSolicitados=a.id_analysis and id_analysis in (" & an & ") and o.caso not in (" & cadenaDeCasos & ") order by o.caso,a.id_analysis asc", oConexion)
         End If
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
         cmbNoCaso.SelectedIndex = 0
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnBuscaCaso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaCaso.Click
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oDataReader As MySqlDataReader
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         Dim an As String = "'" & lblIdAnalisis.Text & "'"
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT o.NombreCliente as NombreCliente,a.analysis_desc as AnalisisSolicitados, o.descripcion as OBS FROM ordenes o,analisis a WHERE o.caso='" & cmbNoCaso.Text & "'" & " and o.AnalisisSolicitados=a.id_analysis and o.AnalisisSolicitados in (" & an & ") ;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               txtNombreCliente.Text = oDataReader("NombreCliente").ToString()
               txtAnalisisSolicitado.Text = oDataReader("AnalisisSolicitados").ToString()
               txtObservaciones.Text = oDataReader("OBS").ToString()
            End While
            oDataReader.Close()
            chkSubCasos.Enabled = True
         Else
            mensajeRojo(etiquetaMensaje, "Mensaje: Seleccione un número de caso de los listados en el comboBox.")
         End If
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub chkSubCasos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSubCasos.CheckedChanged
      If (chkSubCasos.Checked = True) Then
         txtNoSubcasos.Visible = True
         txtNoSubcasos.Enabled = True
         txtNoSubcasos.ReadOnly = False
         btnGuardar.Enabled = False
         btnGuardarEditado.Enabled = False
         btnAceptaSubCasos.Enabled = True
         txtMensajeSobreGrafica.Enabled = False
         txtMensajeSobreGrafica.ReadOnly = True
         estatusDesdeHasta(False)
         habilitaDesdeHasta(False)
      Else
         txtNoSubcasos.Visible = False
         txtNoSubcasos.Enabled = False
         btnGuardar.Enabled = True
         btnGuardarEditado.Enabled = False
         btnAceptaSubCasos.Enabled = False
         txtMensajeSobreGrafica.Enabled = True
         txtMensajeSobreGrafica.ReadOnly = False
         txtMensajeSobreGrafica.Focus()
         estatusDesdeHasta(False)
         habilitaDesdeHasta(True)
      End If
   End Sub

   Private Sub btnAceptaSubCasos_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptaSubCasos.Click
      If (MessageBox.Show("¿Es correcto el número de subcasos?", "Confirme el número de subcasos ingresados", _
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
           Windows.Forms.DialogResult.Yes) Then
         If controlesValidosNumero(txtNoSubcasos, "En número de subcasos, ", 2, 94) Then
            chkSubCasos.Enabled = False
            btnNuevoSubcaso.Enabled = True
            btnNuevoSubcaso.Visible = True
            btnNuevoSubcaso.Focus()
            btnAceptaSubCasos.Enabled = False
         Else
            MessageBox.Show("ERROR: Los valores introducidos para el No. de Subcasos no es válido, Verifique.")
         End If
      Else
         txtNoSubcasos.Visible = True
         txtNoSubcasos.Enabled = True
         btnAceptaSubCasos.Enabled = True
         txtNoSubcasos.Text = "2"
         txtNoSubcasos.Focus()
      End If
   End Sub

   Private Sub frmCapturaCasosDA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      dibujaTablaEnPantalla(dgvPlacaLeida)
   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub
End Class