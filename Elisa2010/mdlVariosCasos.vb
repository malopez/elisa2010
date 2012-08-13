﻿Module mdlVariosCasos

   


   Public Function mediaGenerico(ByVal calculaL() As Decimal, ByVal nodatos As Integer) As Decimal
      Dim media As Decimal = 0
      Dim i As Integer
      For i = 0 To nodatos - 1
         media += calculaL(i)
      Next
      media = media / nodatos
      Return media
   End Function


   Public Function desviacionEstandarGenerico(ByRef calculaL() As Decimal, ByVal cuentaNoDatos As Integer, _
                                     ByVal desdex As Integer, ByVal desdey As Integer, _
                                     ByVal hastax As Integer, ByVal hastay As Integer) As Decimal
      Dim i, j As Integer
      Dim contador As Integer = 0
      Dim renglones As Integer = 11
      Dim desvest As Decimal = 0
      Dim sumatoriaMG As Decimal = 0
      Dim media As Decimal
      Dim varianza As Decimal = 0
      Dim totalCalculaL As Decimal = 0
      'Pasa los datos de la placa a calculaL en base a desde-hasta
      For i = desdex To hastax
         If (i = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            calculaL(contador) = CDec(placaLector(i, j))
            totalCalculaL += CDec(calculaL(contador))
            'Calcula el logaritmo  base 10 del la columna L, que se utilizara para la calcular ma media geometrica
            contador += 1
         Next
         desdey = 0
      Next

      media = calculaMediaAritmetica(totalCalculaL, cuentaNoDatos)
      varianza = calculaVarianza(media, calculaL, cuentaNoDatos)
      desvest = calculaDesvEst(varianza)
      Return desvest
   End Function

   Public Function calculaSumatoriaMediaGeometrica(ByVal calculoDeTitulos(,) As Decimal, ByRef calculaL() As Decimal, _
                                     ByVal desdex As Integer, ByVal desdey As Integer, _
                                     ByVal hastax As Integer, ByVal hastay As Integer, ByRef totalcalculaL As Decimal) As Decimal

      Dim contador As Integer = 0
      Dim renglones As Integer = 11
      Dim calculaSumatoriaMG As Decimal = 0
      Dim sumatoriaMG As Decimal = 0
      'Calcula el valor de la matriz para llenar la columna L
      For i = desdex To hastax
         If (i = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            calculaL(contador) = CDec(calculoDeTitulos(i, j))
            'Calcula la sumatoria de los datos que se guardan en columna L
            totalcalculaL += CDec(calculaL(contador))
            'Calcula el logaritmo  base 10 del la columna L, que se utilizara para la calcular ma media geometrica
            If (calculaL(contador) <> 0) Then
               sumatoriaMG += reduceDecimal(CDec(Math.Log10(calculaL(contador))))
            End If
            contador += 1
         Next
         desdey = 0
      Next
      Return (sumatoriaMG)
   End Function

   Public Function calculaMediaGeometrica(ByVal sumatoriaMG As Decimal, ByVal rangoTotal As Integer) As Decimal
      Dim sMG As Decimal = 0
      Dim MG As Decimal
      sMG = CDec(sumatoriaMG / rangoTotal)
      MG = CDec(10 ^ CDec(sMG))
      Return (MG)
   End Function


   Public Sub calculaMarcaDeClaseBI(ByVal calculaL() As Decimal, ByRef rangoDatos() As Integer, ByRef rangoTotal As Integer)
      Dim i As Integer = 0
      Dim rangoUno As Integer = 0
      Dim rangoDos As Integer = 0
      Dim rangoTres As Integer = 0
      Dim rangoCuatro As Integer = 0
      Dim rangoCinco As Integer = 0
      Dim rangoSeis As Integer = 0
      Dim rangoSiete As Integer = 0
      Dim rangoOcho As Integer = 0
      Dim rangoNueve As Integer = 0
      Dim rangoDiez As Integer = 0
      Dim rangoOnce As Integer = 0
      Dim rangoDoce As Integer = 0
      Dim rangoTrece As Integer = 0
      Dim rangoCatorce As Integer = 0
      Dim rangoQuince As Integer = 0
      Dim rangoDSeis As Integer = 0
      Dim contador As Integer = 0
      For i = 0 To UBound(calculaL)
         Select Case calculaL(i)
            Case Is < 1
               rangoUno += 1
            Case 1 To 350
               rangoDos += 1
            Case 351 To 3000
               rangoTres += 1
            Case 3001 To 5000
               rangoCuatro += 1
            Case 5001 To 7000
               rangoCinco += 1
            Case 7001 To 9000
               rangoSeis += 1
            Case 9001 To 11000
               rangoSiete += 1
            Case 11001 To 13000
               rangoOcho += 1
            Case 13001 To 15000
               rangoNueve += 1
            Case 15001 To 17000
               rangoDiez += 1
            Case 17001 To 19000
               rangoOnce += 1
            Case 19001 To 21000
               rangoDoce += 1
            Case 21001 To 23000
               rangoTrece += 1
            Case 23001 To 25000
               rangoCatorce += 1
            Case Is > 25000
               rangoQuince += 1
         End Select
      Next

      'Calculo la sumatoria de la frecuencia de clase fi
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + rangoOnce + rangoDoce + rangoTrece + rangoCatorce + rangoQuince
      'Asigno al arreglo los datos que son frecuencia de clase
      rangoDatos = {rangoUno, rangoDos, rangoTres, rangoCuatro, rangoCinco, rangoSeis, rangoSiete, rangoOcho, rangoNueve, rangoDiez, rangoOnce, rangoDoce, rangoTrece, rangoCatorce, rangoQuince}

   End Sub


   Public Sub calculaMarcaDeClaseEA(ByVal calculaL() As Decimal, ByRef rangoDatos() As Integer, ByRef rangoTotal As Integer)
      Dim i As Integer = 0
      Dim rangoUno As Integer = 0
      Dim rangoDos As Integer = 0
      Dim rangoTres As Integer = 0
      Dim rangoCuatro As Integer = 0
      Dim rangoCinco As Integer = 0
      Dim rangoSeis As Integer = 0
      Dim rangoSiete As Integer = 0
      Dim rangoOcho As Integer = 0
      Dim rangoNueve As Integer = 0
      Dim rangoDiez As Integer = 0
      Dim rangoOnce As Integer = 0
      Dim rangoDoce As Integer = 0
      Dim rangoTrece As Integer = 0
      Dim rangoCatorce As Integer = 0
      Dim rangoQuince As Integer = 0
      Dim rangoDSeis As Integer = 0
      Dim contador As Integer = 0
      For i = 0 To UBound(calculaL)
         Select Case calculaL(i)
            Case Is < 350
               rangoUno += 1
            Case 351 To 1500
               rangoDos += 1
            Case 1501 To 2500
               rangoTres += 1
            Case 2501 To 3500
               rangoCuatro += 1
            Case 3501 To 4500
               rangoCinco += 1
            Case 4501 To 5500
               rangoSeis += 1
            Case 5501 To 6500
               rangoSiete += 1
            Case 6501 To 7500
               rangoOcho += 1
            Case 7501 To 8500
               rangoNueve += 1
            Case 8501 To 9500
               rangoDiez += 1
            Case 9501 To 10500
               rangoOnce += 1
            Case 15001 To 11500
               rangoDoce += 1
            Case 11501 To 12500
               rangoTrece += 1
            Case 12501 To 13500
               rangoCatorce += 1
            Case Is > 13500
               rangoQuince += 1
         End Select
      Next

      'Calculo la sumatoria de la frecuencia de clase fi
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + rangoOnce + rangoDoce + rangoTrece + rangoCatorce + rangoQuince
      'Asigno al arreglo los datos que son frecuencia de clase
      rangoDatos = {rangoUno, rangoDos, rangoTres, rangoCuatro, rangoCinco, rangoSeis, rangoSiete, rangoOcho, rangoNueve, rangoDiez, rangoOnce, rangoDoce, rangoTrece, rangoCatorce, rangoQuince}

   End Sub


   Public Sub calculaMarcaDeClase(ByVal calculaL() As Decimal, ByRef rangoDatos() As Integer, ByRef rangoTotal As Integer)
      Dim i As Integer = 0
      Dim rangoUno As Integer = 0
      Dim rangoDos As Integer = 0
      Dim rangoTres As Integer = 0
      Dim rangoCuatro As Integer = 0
      Dim rangoCinco As Integer = 0
      Dim rangoSeis As Integer = 0
      Dim rangoSiete As Integer = 0
      Dim rangoOcho As Integer = 0
      Dim rangoNueve As Integer = 0
      Dim rangoDiez As Integer = 0
      Dim rangoOnce As Integer = 0
      Dim rangoDoce As Integer = 0
      Dim rangoTrece As Integer = 0
      Dim rangoCatorce As Integer = 0
      Dim rangoQuince As Integer = 0
      Dim contador As Integer = 0
      For i = 0 To UBound(calculaL)
         Select Case calculaL(i)
            Case Is < 1
               rangoUno += 1
            Case 1 To 350
               rangoDos += 1
            Case 351 To 1500
               rangoTres += 1
            Case 1501 To 2500
               rangoCuatro += 1
            Case 2501 To 3500
               rangoCinco += 1
            Case 3501 To 4500
               rangoSeis += 1
            Case 4501 To 5500
               rangoSiete += 1
            Case 5501 To 6500
               rangoOcho += 1
            Case 6501 To 7500
               rangoNueve += 1
            Case 7501 To 8500
               rangoDiez += 1
            Case 8501 To 9500
               rangoOnce += 1
            Case 9501 To 10500
               rangoDoce += 1
            Case 10501 To 11500
               rangoTrece += 1
            Case 11501 To 12500
               rangoCatorce += 1
            Case Is > 12501
               rangoQuince += 1
         End Select
      Next

      'Calculo la sumatoria de la frecuencia de clase fi
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + rangoOnce + rangoDoce + rangoTrece + rangoCatorce + rangoQuince
      'Asigno al arreglo los datos que son frecuencia de clase
      rangoDatos = {rangoUno, rangoDos, rangoTres, rangoCuatro, rangoCinco, rangoSeis, rangoSiete, rangoOcho, rangoNueve, rangoDiez, rangoOnce, rangoDoce, rangoTrece, rangoCatorce, rangoQuince}

   End Sub

   Public Sub calculaMarcaDeClaseNC(ByVal calculaL() As Decimal, ByRef rangoDatos() As Integer, ByRef rangoTotal As Integer)
      Dim i As Integer = 0
      Dim rangoUno As Integer = 0
      Dim rangoDos As Integer = 0
      Dim rangoTres As Integer = 0
      Dim rangoCuatro As Integer = 0
      Dim rangoCinco As Integer = 0
      Dim rangoSeis As Integer = 0
      Dim rangoSiete As Integer = 0
      Dim rangoOcho As Integer = 0
      Dim rangoNueve As Integer = 0
      Dim rangoDiez As Integer = 0
      Dim rangoOnce As Integer = 0
      Dim rangoDoce As Integer = 0
      Dim rangoTrece As Integer = 0
      Dim rangoCatorce As Integer = 0
      Dim rangoQuince As Integer = 0
      Dim contador As Integer = 0
      For i = 0 To UBound(calculaL)
         Select Case calculaL(i)
            Case Is < 1
               rangoUno += 1
            Case 1 To 350
               rangoDos += 1
            Case 351 To 750
               rangoTres += 1
            Case 751 To 1500
               rangoCuatro += 1
            Case 1501 To 2000
               rangoCinco += 1
            Case 2001 To 2500
               rangoSeis += 1
            Case 2501 To 3000
               rangoSiete += 1
            Case 3001 To 3500
               rangoOcho += 1
            Case 3501 To 4000
               rangoNueve += 1
            Case 4001 To 4500
               rangoDiez += 1
            Case 4501 To 5000
               rangoOnce += 1
            Case 5001 To 5500
               rangoDoce += 1
            Case 5501 To 6000
               rangoTrece += 1
            Case 6001 To 6500
               rangoCatorce += 1
            Case Is > 6501
               rangoQuince += 1
         End Select
      Next

      'Calculo la sumatoria de la frecuencia de clase fi
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + rangoOnce + rangoDoce + rangoTrece + rangoCatorce + rangoQuince
      'Asigno al arreglo los datos que son frecuencia de clase
      rangoDatos = {rangoUno, rangoDos, rangoTres, rangoCuatro, rangoCinco, rangoSeis, rangoSiete, rangoOcho, rangoNueve, rangoDiez, rangoOnce, rangoDoce, rangoTrece, rangoCatorce, rangoQuince}

   End Sub


   'Calcula la tabla SPS
   Public Sub calculaSPSs(ByRef placaoriginal As String, ByRef placaLector(,) As Decimal, ByRef calculaSPS(,) As Decimal, ByVal promCN As Decimal, ByVal difCPS As Decimal)
      Try
         For i = 0 To 7
            For j = 0 To 11

               If (placaLector(i, j) > 0) Then
                  calculaSPS(i, j) = reduceDecimal(((placaLector(i, j) - promCN) / difCPS))
               Else
                  calculaSPS(i, j) = 0
               End If
               placaoriginal += placaLector(i, j) & vbTab
            Next
         Next
      Catch ex As Exception
         MessageBox.Show("ERROR CALCULASPS: " & ex.Message & " " & ex.GetType.ToString)
      End Try
   End Sub

   'Calcula los logaritmos de la tabla SPS
   Public Sub calculaLogaritmoSPS(ByRef logaritmoSPS(,) As Decimal, ByVal calculaSPS(,) As Decimal, ByVal logsps As Decimal)
      Try
         For i = 0 To 7
            For j = 0 To 11
               If (calculaSPS(i, j) > logsps) Then
                  logaritmoSPS(i, j) = reduceDecimal(Math.Log10(calculaSPS(i, j)))
               Else
                  logaritmoSPS(i, j) = -4
               End If
            Next
         Next
      Catch ex As Exception
         MessageBox.Show("ERROR LOGARITMO SPS: " & ex.Message & " " & ex.GetType.ToString)
      End Try
   End Sub


   Public Sub calculaLogaritmoTitulos(ByVal logaritmoSPS(,) As Decimal, ByRef logaritmoTitulos(,) As Decimal, ByVal logtit1 As Decimal, _
                                      ByVal logtit2 As Decimal)
      Dim i As Integer = 0
      Dim j As Integer = 0
      'Calcula los Titulos de la tabla de logaritmos SPS
      Try
         For i = 0 To 7
            For j = 0 To 11
               logaritmoTitulos(i, j) = reduceDecimal(((logtit1 * logaritmoSPS(i, j)) + logtit2))
            Next

         Next
      Catch ex As Exception
         MessageBox.Show("ERROR LOGARITMO TITULOS: " & ex.Message & " " & ex.GetType.ToString)
      End Try
   End Sub

   Public Sub calculoDeTitulo(ByVal logaritmoTitulos(,) As Decimal, ByRef calculoDeTitulos(,) As Decimal)
      'Calcula el titulo mendiante la exponenciacion 10 ^ A1..H1, en la hoja de excel corresponde a la columna K, y que tambien 
      'se utilizan en la columna AE para tomar los titulos de los sueros en resultados finales
      Try
         For i = 0 To 7
            For j = 0 To 11
               If (logaritmoTitulos(i, j) > 0) Then
                  calculoDeTitulos(i, j) = reduceDecimal(CDec((10 ^ logaritmoTitulos(i, j))))
               Else
                  calculoDeTitulos(i, j) = 0
               End If
            Next
         Next
      Catch ex As Exception
         MessageBox.Show("ERROR CALCULA TITULOS: " & ex.Message & " " & ex.GetType.ToString)
      End Try
   End Sub

   Public Function titulosObtenidosEnCalculaL(ByVal calculaL() As Decimal, ByVal cuentaNoDatos As Integer) As String
      Dim i As Integer = 0
      Dim j As Integer = cuentaNoDatos - 1
      'Dim presenta As String = "Sueros  Títulos" & vbCrLf & " " & vbCrLf
      Dim presenta As String = ""
      For i = 0 To j
         If (i <> j) Then
            presenta += CStr(reduceDecimal(calculaL(i))) & vbCrLf
         Else
            presenta += CStr(reduceDecimal(calculaL(i)))
         End If
      Next
      Return (presenta)
   End Function

   Public Function obtenPlacaLeida(ByVal placaLector(,) As Decimal) As String
      Dim placaoriginal As String = ""
      Dim i As Integer
      Dim j As Integer
      For i = 0 To 7
         For j = 0 To 11
            If (i <= 7) And (j < 11) Then
               placaoriginal += placaLector(i, j).ToString & vbCrLf
            ElseIf (i = 7) And (j = 11) Then
               placaoriginal += placaLector(i, j).ToString
            End If
         Next
      Next
      Return (placaoriginal)
   End Function


   'calcula la varianza para datos no agrupados
   Public Function calculaVarianza(ByVal mediaAritmetica As Decimal, ByVal calculaL() As Decimal, ByVal cuentaNoDatos As Integer) As Decimal
      Dim i As Integer = 0
      Dim temp As Decimal
      Dim calculaVar As Decimal = 0
      Try
         For i = 0 To cuentaNoDatos - 1
            temp = reduceDecimal(((calculaL(i) - mediaAritmetica) ^ 2))
            calculaVar += temp
         Next
      Catch ex As Exception
         MessageBox.Show("ERROR CALCULA VARIANZA: " & ex.Message & " " & ex.GetType.ToString)
      End Try
      Return CDec(calculaVar / (cuentaNoDatos - 1))
   End Function

   'Obtengo el promedio de los valores de la columna L o Media aritmetica
   Public Function calculaMediaAritmetica(ByVal totalcalculaL As Decimal, ByVal cuentaNoDatos As Integer) As Decimal
      Dim mediaAritmetica As Decimal = 0
      mediaAritmetica = CDec(totalcalculaL / cuentaNoDatos)
      Return (mediaAritmetica)
   End Function

   'Calcula la desviacion estandar no considerando los datos agrupados
   Public Function calculaDesvEst(ByVal varianza As Decimal) As Decimal
      Dim desviacionEstandar As Decimal = 0
      desviacionEstandar = CDec(Math.Sqrt(varianza))
      Return (desviacionEstandar)
   End Function

   'Sirve para calcular el numero de datos (pozos utilizados para el caso) 
   Public Function calculaNoDatos(ByVal desdex As Integer, ByVal hastax As Integer, _
                                ByVal desdey As Integer, ByVal hastay As Integer) As Integer
      Dim cuentaNoDatos As Integer
      cuentaNoDatos = (((hastax - desdex) - 1) * 12) + ((12 - desdey) + (hastay + 1))
      Return (cuentaNoDatos)
   End Function

   'Calcula el coeficiente de variacion 
   Public Function calculaCoefVar(ByVal desvEst As Decimal, ByVal mediaAritmetica As Decimal) As Decimal
      Dim coefVar As Decimal
      coefVar = CDec(desvEst / mediaAritmetica * 100)
      Return (coefVar)
   End Function


   Public Sub calculaFrecuenciaRelativa(ByRef frecuenciaRelativa() As Decimal, ByVal rangoDatos() As Integer, ByVal rangoTotal As Integer)
      Dim i As Integer = 0
      For i = 0 To 14
         frecuenciaRelativa(i) = CDec((rangoDatos(i) / rangoTotal) * 100)
      Next
   End Sub

   'Obtiene el valor de la recuencia relativa
   Public Function obtenValorFR(ByVal frecuenciaRelativa() As Decimal) As String
      Dim i As Integer = 0
      Dim valores As String = ""
      For i = 0 To 14
         If (i < 14) Then
            valores += CStr(reduceDecimal(frecuenciaRelativa(i))) & vbCrLf
         Else
            valores += CStr(reduceDecimal(frecuenciaRelativa(i)))
         End If
      Next
      Return (valores)
   End Function

   'Obtiene la cantidad de los titulos que se repiten dentro de un rango
   Public Function obtenCantidadFR(ByVal rangoDatos() As Integer) As String
      Dim i As Integer = 0
      Dim cantidad As String = ""
      For i = 0 To 14
         If (i < 14) Then
            cantidad += rangoDatos(i).ToString() & vbCrLf
         Else
            cantidad += rangoDatos(i).ToString()
         End If
      Next
      Return (cantidad)
   End Function

   'Presenta datos para formatear la salida de los datos
   Public Sub mostrarResultadosEnPantalla(ByRef lblNombreSobreGrafica As Label, ByRef lblMensajeSobreGrafica As Label, _
                                     ByRef txtNombreEnfermedad As TextBox, ByRef txtNombreCliente As TextBox, ByRef txtNoCaso As TextBox, _
                                     ByRef lblAnalisis As Label, ByRef lblObservaciones As Label, ByRef txtFechaElaboracion As TextBox, _
                                     ByRef txtTitulosObtenidos As TextBox, ByRef txtMediaAritmetica2 As TextBox, _
                                     ByRef txtMediaGeometrica As TextBox, ByRef txtTotalDatosCalculados As TextBox, _
                                     ByRef txtCoefVariacion2 As TextBox, ByRef txtDesvEstandar2 As TextBox, ByRef txtVarianza2 As TextBox, _
                                     ByVal nombreArchivo As String, _
                                     ByVal nombreSobreGrafica As String, ByVal mensajeSobreGrafica As String, _
                                     ByVal nombre As String, ByVal nombreCliente As String, ByVal numcaso As String, ByVal analisis As String, _
                                     ByVal observaciones As String, ByVal fechaElaboracion As String, _
                                     ByVal presenta1 As String, ByVal mediaAritmetica As Decimal, _
                                     ByVal mediaGeometrica As Decimal, ByVal cuentaNoDatos As Integer, _
                                     ByVal coefVar As Decimal, ByVal desvEst As Decimal, ByVal varianza As Decimal)
      lblNombreSobreGrafica.Text = nombreSobreGrafica.ToString()
      lblMensajeSobreGrafica.Text = mensajeSobreGrafica.ToString()
      txtNombreEnfermedad.Text = nombre.ToString()
      txtNombreCliente.Text = nombreCliente.ToString()
      txtNoCaso.Text = numcaso.ToString()
      lblAnalisis.Text = analisis.ToString()
      frmSalidaDatos.imagenGrafica.Image = Image.FromFile(nombreArchivo)
      lblObservaciones.Text = observaciones.ToString()
      txtFechaElaboracion.Text = fechaElaboracion.ToString()
      txtTitulosObtenidos.Text = presenta1.ToString()
      txtMediaAritmetica2.Text = CStr(Math.Round(CDec(mediaAritmetica)))
      txtMediaGeometrica.Text = CStr(Math.Round(CDec(mediaGeometrica)))
      txtTotalDatosCalculados.Text = cuentaNoDatos.ToString()
      txtCoefVariacion2.Text = CStr(Math.Round(CDec(coefVar)))
      txtDesvEstandar2.Text = desvEst.ToString()
      txtVarianza2.Text = varianza.ToString()
   End Sub


   'Procedimiento que calcula los resultados del analisis, recibe el nombre del analisis,el titulo de eje x-y, desdeArchivo =1 indica lectura desde archivo
   'cpx y cny son los valores de A..H,  es decir, el valor de la placa por columna   usada para control positivo-negativo
   'cpy y cny son los valores de 1..12, es decir, el valor de la placa por renglones usada para control positivo-negativo
   'logsps, logtit1 y logtit2 son valores utilizados para definir valores especiales que varian de acuerdo a la enfermedad 
   'seleccionada. El parametro nombre es el nombre del análisis/Enfermedad que se ha evaluado
   Public Sub calculaValoresEnRango(ByRef placaLector(,) As Decimal, ByRef desdeArchivo As Integer, ByVal nocp As Integer, _
                             ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                             ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                             ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                             ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, _
                             ByVal logsps As Decimal, ByVal logtit1 As Decimal, ByVal logtit2 As Decimal, _
                             ByVal cp1 As Decimal, ByVal cp2 As Decimal, ByVal cp3 As Decimal, _
                             ByVal cn1 As Decimal, ByVal cn2 As Decimal, ByVal cn3 As Decimal, _
                             ByVal desdex As Integer, ByVal hastax As Integer, ByVal desdey As Integer, _
                             ByVal hastay As Integer, ByRef promCP As Decimal, ByRef promCN As Decimal, ByRef difCPS As Decimal,
                             ByRef etiqueta As Label)
      'Para controlar el ciclo for
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim k As Integer = 0
      Dim placaOriginal As String = ""
      'Para calcular el numero de datos seleccionados de los pozos para realizar el analisis
      Dim cuentaNoDatos As Integer = 0
      'Matriz para calculo de SPS
      Dim calculaSPS(7, 11) As Decimal
      'Matriz para calculo de Logaritmo de SPS
      Dim logaritmoSPS(7, 11) As Decimal
      'Matriz para calculo de Logaritmo de Titulos
      Dim logaritmoTitulos(7, 11) As Decimal
      'Para los valores del calculo estadistico
      Dim temp As Decimal = 0
      'Si no es desde archivo la lectura de la placa, entonces calcula los valores en base a los valores x,y introducidos
      If (desdeArchivo <> 1) Then
         'Valida que se ejecute el calculo de promedio positivo, si no, despliega un mensaje de error relacionado con la función
         promCP = calculaPromedioPositivos(nocp, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, etiqueta)
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         promCN = calculaPromedioNegativos(nocp, cnx1, cnx2, cnx3, cny1, cny2, cny3, etiqueta)
      Else
         'si es desde archivo la lectura, toma los valores obtenidos de leer el archivo excel
         promCP = calculaPromedioPositivosDA(cp1, cp2, cp3, etiqueta)
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         promCN = calculaPromedioNegativosDA(cn1, cn2, cn3, etiqueta)
      End If
      difCPS = calculaDiferenciaSPS(promCP, promCN, etiqueta)
      calculaSPSs(placaOriginal, placaLector, calculaSPS, promCN, difCPS)
      calculaLogaritmoSPS(logaritmoSPS, calculaSPS, logsps)
      calculaLogaritmoTitulos(logaritmoSPS, logaritmoTitulos, logtit1, logtit2)
      calculoDeTitulo(logaritmoTitulos, calculoDeTitulos)
   End Sub

   'Permite guardar los casos cuando son n casos con n subcasos. Agregado el 07/Ago/2012
   Public Sub guardaCasos(ByVal cmbCaso As ComboBox, ByVal analisis As String, ByVal noControlesPositivos As TextBox, _
                         ByVal noControlesNegativos As TextBox, ByVal txtDesdeLetra As TextBox, _
                          ByVal txtHastaLetra As TextBox, ByVal txtDesdeValor As TextBox, ByVal txtHastaValor As TextBox, _
                          ByVal txtCP1Letra1 As TextBox, ByVal txtCP2Letra2 As TextBox, ByVal txtCP3Letra3 As TextBox, _
                          ByVal txtCP1Valor1 As TextBox, ByVal txtCP2Valor2 As TextBox, ByVal txtCP3Valor3 As TextBox, _
                          ByVal txtCN1Letra1 As TextBox, ByVal txtCN2Letra2 As TextBox, ByVal txtCN3Letra3 As TextBox, _
                          ByVal txtCN1Valor1 As TextBox, ByVal txtCN2Valor2 As TextBox, ByVal txtCN3Valor3 As TextBox, _
                          ByVal lblMensajeCaso As Label, ByVal mensaje As String)
      Dim cadena As String
      Dim tabla() As String
      Dim numCaso As String = ""
      cadena = cmbCaso.Text
      tabla = Split(cadena, " | ")
      numCaso = tabla(0)
      Dim nocp As Integer = CInt(noControlesPositivos.Text)
      Dim nocn As Integer = CInt(noControlesNegativos.Text)
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra)
      Dim desdey As Integer = Convert.ToInt32(txtDesdeValor.Text) - 1
      Dim hastay As Integer = Convert.ToInt32(txtHastaValor.Text) - 1
      Dim cpx1 As Integer = siValorEsLetra(txtCP1Letra1)
      Dim cpx2 As Integer = siValorEsLetra(txtCP2Letra2)
      Dim cpy1 As Integer = CInt(txtCP1Valor1.Text) - 1
      Dim cpy2 As Integer = CInt(txtCP2Valor2.Text) - 1
      Dim cnx1 As Integer = siValorEsLetra(txtCN1Letra1)
      Dim cnx2 As Integer = siValorEsLetra(txtCN2Letra2)
      Dim cny1 As Integer = CInt(txtCN1Valor1.Text) - 1
      Dim cny2 As Integer = CInt(txtCN2Valor2.Text) - 1

      'Asigna valor default a la definición de cp para x y y.

      Dim cpx3 As Integer = 0
      Dim cnx3 As Integer = 0
      Dim cpy3 As Integer = 0
      Dim cny3 As Integer = 0
      'Verifica si  son tres controles positivos
      If (nocp = 3) Then
         cpx3 = siValorEsLetra(txtCP3Letra3)
         cnx3 = siValorEsLetra(txtCN3Letra3)
         cpy3 = CInt(txtCP3Valor3.Text) - 1
         cny3 = CInt(txtCN3Valor3.Text) - 1
      End If
      Try
         guardaDatosExcel(placaLector, nocp, nocn, numCaso, analisis, cpx1, cpx2, cpx3, cnx1, cnx2, cnx3, cpy1, _
                          cpy2, cpy3, cny1, cny2, cny3, desdex, desdey, hastax, hastay)
         mensajeVerde(lblMensajeCaso, "Mensaje: Los datos del: " & mensaje & " de la placa original se guardaron exitosamente.")
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "ERROR: Al guardar los datos del: " & mensaje & " de la placa original en excel, guardaCaso.")
      End Try
   End Sub


   Public Sub guardaCaso(ByVal cmbCaso As ComboBox, ByVal analisis As String, ByVal noControlesPositivos As TextBox, _
                        ByVal noControlesNegativos As TextBox, ByVal txtDesdeLetra As TextBox, _
                         ByVal txtHastaLetra As TextBox, ByVal txtDesdeValor As TextBox, ByVal txtHastaValor As TextBox, _
                         ByVal txtCP1Letra1 As TextBox, ByVal txtCP2Letra2 As TextBox, ByVal txtCP3Letra3 As TextBox, _
                         ByVal txtCP1Valor1 As TextBox, ByVal txtCP2Valor2 As TextBox, ByVal txtCP3Valor3 As TextBox, _
                         ByVal txtCN1Letra1 As TextBox, ByVal txtCN2Letra2 As TextBox, ByVal txtCN3Letra3 As TextBox, _
                         ByVal txtCN1Valor1 As TextBox, ByVal txtCN2Valor2 As TextBox, ByVal txtCN3Valor3 As TextBox, _
                         ByVal lblMensajeCaso As Label, ByVal mensaje As String)
      Dim cadena As String
      Dim tabla() As String
      Dim numCaso As String = ""
      cadena = cmbCaso.Text
      tabla = Split(cadena, " | ")
      numCaso = tabla(0)
      Dim nocp As Integer = CInt(noControlesPositivos.Text)
      Dim nocn As Integer = CInt(noControlesNegativos.Text)
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra)
      Dim desdey As Integer = Convert.ToInt32(txtDesdeValor.Text) - 1
      Dim hastay As Integer = Convert.ToInt32(txtHastaValor.Text) - 1
      Dim cpx1 As Integer = siValorEsLetra(txtCP1Letra1)
      Dim cpx2 As Integer = siValorEsLetra(txtCP2Letra2)
      Dim cpy1 As Integer = CInt(txtCP1Valor1.Text) - 1
      Dim cpy2 As Integer = CInt(txtCP2Valor2.Text) - 1
      Dim cnx1 As Integer = siValorEsLetra(txtCN1Letra1)
      Dim cnx2 As Integer = siValorEsLetra(txtCN2Letra2)
      Dim cny1 As Integer = CInt(txtCN1Valor1.Text) - 1
      Dim cny2 As Integer = CInt(txtCN2Valor2.Text) - 1

      'Asigna valor default a la definición de cp para x y y.

      Dim cpx3 As Integer = 0
      Dim cnx3 As Integer = 0
      Dim cpy3 As Integer = 0
      Dim cny3 As Integer = 0
      'Verifica si  son tres controles positivos
      If (nocp = 3) Then
         cpx3 = siValorEsLetra(txtCP3Letra3)
         cnx3 = siValorEsLetra(txtCN3Letra3)
         cpy3 = CInt(txtCP3Valor3.Text) - 1
         cny3 = CInt(txtCN3Valor3.Text) - 1
      End If
      Try
         guardaDatosExcel(placaLector, nocp, nocn, numCaso, analisis, cpx1, cpx2, cpx3, cnx1, cnx2, cnx3, cpy1, _
                          cpy2, cpy3, cny1, cny2, cny3, desdex, desdey, hastax, hastay)
         mensajeVerde(lblMensajeCaso, "Mensaje: Los datos del: " & mensaje & " de la placa original se guardaron exitosamente.")
      Catch ex As Exception
         mensajeRojo(lblMensajeCaso, "ERROR: Al guardar los datos del: " & mensaje & " de la placa original en excel, guardaCaso.")
      End Try
   End Sub



End Module
