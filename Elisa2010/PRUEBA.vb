Public Class frmAbrirDesdeArchivo

   Dim placaLector(7, 11) As Decimal

   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerArchivoExistente.Click
      abreArchivoExcel(placaLector, Me.txtCPDAValor1, Me.txtCPDAValor2, Me.txtCPDAValor3, txtCNDAValor1, txtCNDAValor2, txtCNDAValor3)
      organizaEnTabla(Me.dgvPlacaLeida, placaLector)
   End Sub

   Private Sub btnObtenResultadosDA_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenResultadosDA.Click
      Dim nocp As Integer = Val(txtNoControles.Text)
      Dim desdeArchivo As Integer = 1
      Dim cp1, cp2, cp3 As Decimal
      Dim cn1, cn2, cn3 As Decimal
      Dim desdex As Integer = 0
      Dim hastax As Integer = 3
      Dim desdey As Integer = 0
      Dim hastay As Integer = 11
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
      Try
         cp1 = CDec(Me.txtCPDAValor1.Text)
         cp2 = CDec(Me.txtCPDAValor2.Text)
         cp3 = CDec(Me.txtCPDAValor3.Text)
         cn1 = CDec(Me.txtCNDAValor1.Text)
         cn2 = CDec(Me.txtCNDAValor2.Text)
         cn3 = CDec(Me.txtCNDAValor3.Text)
         'Me.btnObtenResultadosDA.Enabled = False //DESCOMENTAR CUANDO SE PASE AL OTRO
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
         Dim nombre As String = tabla(1)
         Dim nombreCliente As String = txtNombreCliente.Text
         Dim observaciones As String = lblObservaciones.Text
         Dim fechaElaboracion As String = CStr(dtpFechaElaboracion.Value)
         Try
            calculaValoresEnRango(placaLector, desdeArchivo, nocp, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
                                  Convert.ToDecimal(lblLogSPS.Text), Convert.ToDecimal(lblLogTit1.Text), _
                                  Convert.ToDecimal(lblLogTit2.Text), cp1, cp2, cp3, cn1, cn2, cn3, _
                                  desdex, hastax, desdey, hastay, promCP, promCN, difCPS)
         Catch ex As Exception
            MessageBox.Show("ERROR AL CALCULAR VALORES")
         End Try
         cuentaNoDatos = calculaNoDatos(desdex, hastax, desdey, hastay)
         MessageBox.Show("Valor cuentaNoDatos: " & cuentaNoDatos)
         ReDim calculaL(cuentaNoDatos - 1)
         Try
            mediaGeometrica = calculaSumatoriaMediaGeometrica(calculoDeTitulos, calculaL, desdex, desdey, hastax, hastay, totalcalculaL)

         Catch ex As Exception
            MessageBox.Show("ERROR AL CALCULAR SUMATORIA DE MEDIA GEOMETRICA")
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
            cargaResultadosBD(numcaso, placaoriginal, titulosObtenidos, fechaElaboracion, promCP, promCN, difCPS, _
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
                                        nombre, nombreCliente, numcaso, observaciones, fechaElaboracion, titulosObtenidos, _
                                        mediaAritmetica, mediaGeometrica, cuentaNoDatos, coefVar, desvEst, varianza)
         Catch
            MessageBox.Show("ERROR MOSTRAR RESULTADOS EN PANTALLA.")
         End Try
      Catch ex As Exception
         'MessageBox.Show("ERROR")
         mensajeException(Me.lblMensajeAAE, ex)
         Me.btnLeerArchivoExistente.Enabled = True
         Me.btnObtenResultadosDA.Enabled = False
      End Try
   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub frmAbrirDesdeArchivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

   End Sub
End Class