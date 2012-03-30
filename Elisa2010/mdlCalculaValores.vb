Module mdlCalculaValores
   Dim placaLector(7, 11) As Decimal

   'Permite la lectura del archivo que contiene los datos de la placa
   Public Sub leePlaca(ByVal placaLector(,) As Decimal)
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim temporal As String
      Dim mensaje As String = ""
      Dim cadena As String = "\"
      Try
         Dim objFile As New System.IO.StreamReader("C:\Users\alopez\Documents\Progelis\Placa.txt")
         For j = 0 To 11
            For i = 0 To 7
               temporal = objFile.ReadLine()
               If temporal.Contains(cadena) Then
                  placaLector(i, j) = 0
                  mensaje &= CStr(placaLector(i, j)) & " "
               Else
                  placaLector(i, j) = CDec(temporal)
                  mensaje &= CStr(placaLector(i, j)) & " "
               End If
            Next
         Next
         objFile.Close()
         objFile.Dispose()
      Catch ex As Exception
         Beep()
         MessageBox.Show("No se pudo abrir el archivo con los datos leidos de la placa")
      End Try
      'MessageBox.Show("valores son: " & mensaje)
   End Sub


   Public Sub calculaLarin()
      'Para controlar el ciclo for, y posteriormente para calcular los valores de la "L, DESDE" y los valores de la matriz 15x96
      Dim i As Integer = 0
      Dim j As Integer = 0

      'Para calcular el numero de datos seleccionados de los pozos para realizar el analisis
      Dim cuentaNoDatos As Integer = 0

      'Para identificar los rangos de los datos introducidos 
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
      Dim rangoTotal As Integer = 0

      'Para calcular las sumatorias de los valores en "L HASTA"
      Dim desdeX As Integer = 0
      Dim hastaX As Integer = 0
      Dim desdeY As Integer = 0
      Dim hastaY As Integer = 0

      'Resultado debe ser para el ejemplo 12
      Dim numDeRegistros As Integer = 0

      'Resultado debe ser para el ejemplo 8
      Dim numDeColumnas As Integer = 0

      'Matriz para calculo de SPS
      Dim calculaSPS(7, 11) As Decimal

      'Matriz para calculo de Logaritmo de SPS
      Dim logaritmoSPS(7, 11) As Decimal

      'Matriz para calculo de Logaritmo de Titulos
      Dim logaritmoTitulos(7, 11) As Decimal

      'Matriz para calculo de Logaritmo de Titulos
      Dim calculoDeTitulos(7, 11) As Decimal

      'Matriz para calculo de Logaritmo de Titulos
      Dim calculaL(7, 11) As Decimal

      'Arreglo para definir la marca de clase
      Dim marcaDeClase() = {1, 175, 925, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000, 12500}

      'Se utiliza para colocar el fi por cada una de las marcas de clase
      Dim rangoDatos() As Integer

      'Arreglo para la guardar la frecuencia relativa
      Dim frecuenciaRelativa(14) As Decimal

      'Controles positivos
      Dim promCP As Decimal

      'Calcula controles negativos
      Dim promCN As Decimal

      'Calcula el CPS
      Dim difCPS As Decimal

      'Utilizado para guardar las sumatorias de las columnas de la matriz de calculaSumatoria
      Dim temp As Decimal = 0
      Dim totalcalculaL As Decimal = 0
      Dim mediaAritmetica As Decimal = 0
      Dim calculaMedia As Decimal = 0
      Dim calculaVarianza As Decimal = 0
      Dim desviacionEstandar As Decimal = 0
      Dim coeficienteDeVariacion As Decimal = 0
      Dim mediaGeometrica As Decimal = 0
      Dim calculaSumatoriaMG As Decimal = 0
      Dim desviacionEstandarDatosNoAgrupados As Decimal = 0
      Dim coeficienteDeVariacionDatosNoAgrupados As Decimal = 0
      Dim calculaVarianzaDatosNoAgrupados As Decimal = 0

      'La placa es de A1 a H12, primer columna del arreglo es de A1 a A12, 
      'segunda de B1 a B12, octava de H1 a H12, esto sera sustituido por la lectura de la placa desde archivo

      'Dim placaLector(,) As Decimal = {{CDec(0.743), CDec(0.057), CDec(0.812), CDec(0.364), CDec(0.349), CDec(0.119), CDec(0.134), CDec(0.128), CDec(0.23), CDec(0.2), CDec(0.22), CDec(0.142)},
      '{CDec(0.436), CDec(0.424), CDec(0.427), CDec(0.386), CDec(0.306), CDec(0.145), CDec(0.11), CDec(0.303), CDec(0.147), CDec(0.281), CDec(0.229), CDec(0.232)},
      '{CDec(0.186), CDec(0.226), CDec(0.193), CDec(0.339), CDec(0.241), CDec(0.219), CDec(0.232), CDec(0.381), CDec(0.173), CDec(0.186), CDec(0.422), CDec(0.152)},
      '{CDec(0.43), CDec(0.188), CDec(0.424), CDec(0.158), CDec(0.493), CDec(0.227), CDec(0.285), CDec(0.249), CDec(0.098), CDec(0.222), CDec(0.122), CDec(0.158)},
      '{CDec(0.322), CDec(0.236), CDec(0.346), CDec(0.765), CDec(0.181), CDec(0.549), CDec(0.395), CDec(0.282), CDec(0.375), CDec(0.379), CDec(0.139), CDec(0.332)},
      '{CDec(0.242), CDec(0.165), CDec(0.279), CDec(0.735), CDec(0.326), CDec(0.165), CDec(0.205), CDec(0.175), CDec(0.155), CDec(0.176), CDec(0.212), CDec(0.268)},
      '{CDec(0.318), CDec(0.394), CDec(0.297), CDec(0.199), CDec(0.268), CDec(0.172), CDec(0.101), CDec(0.351), CDec(0.252), CDec(0.211), CDec(0.227), CDec(0.129)},
      '{CDec(0.389), CDec(0.338), CDec(0.158), CDec(0.302), CDec(0.214), CDec(0.262), CDec(0.57), CDec(0.083), CDec(0.144), CDec(0.058), CDec(0.726), CDec(0.062)}}

      leePlaca(placaLector)

      numDeColumnas = placaLector.GetLength(0)

      numDeRegistros = placaLector.GetLength(1)

      promCP = CDec(Microsoft.VisualBasic.Left(CStr(CDec((placaLector(0, 0) + placaLector(0, 2) + placaLector(7, 10)) / 3)), 14))

      promCN = CDec(Microsoft.VisualBasic.Left(CStr(CDec((placaLector(0, 1) + placaLector(7, 9) + placaLector(7, 11)) / 3)), 14))

      difCPS = CDec(Microsoft.VisualBasic.Left(CStr(CDec(promCP - promCN)), 14))

      'Calcula la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If IsNumeric(placaLector(i, j)) Then
               calculaSPS(i, j) = CDec(Microsoft.VisualBasic.Left(CStr((placaLector(i, j) - promCN) / difCPS), 14))
            Else
               calculaSPS(i, j) = 0
            End If
         Next
      Next

      'Calcula los logaritmos de la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If (calculaSPS(i, j) > 0.15) Then
               logaritmoSPS(i, j) = CDec((Microsoft.VisualBasic.Left(CStr(Math.Log10(calculaSPS(i, j))), 14)))
            Else
               logaritmoSPS(i, j) = -4
            End If
         Next
      Next

      'Calcula los Titulos de la tabla de logaritmos SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            logaritmoTitulos(i, j) = CDec(Microsoft.VisualBasic.Left(CStr((1.45 * logaritmoSPS(i, j)) + 3.726), 14))
         Next
      Next

      'Calcula el titulo mendiante la exponenciacion 10 ^ A1..H1, en la hoja de excel corresponde a la columna K, y que tambien 
      'se utilizan en la columna AE para tomar los titulos de los sueros en resultados finales
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If (logaritmoTitulos(i, j) > 0) Then
               calculoDeTitulos(i, j) = CDec(Microsoft.VisualBasic.Left(CStr(CDec((10 ^ logaritmoTitulos(i, j)))), 14))
            Else
               calculoDeTitulos(i, j) = 0
            End If
         Next
      Next

      'Inicializa la columna L a ceros para evitar validaciones posteriores
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            calculaL(i, j) = 0
         Next
      Next

      'Obtiene los valores desde Ax hasta Hx que se utilizaron de una placa para hacer el analisis
      desdeX = 0
      hastaX = 8
      desdeY = 0
      hastaY = 12

      'Calcula el valor de la matriz para llenar la columna L
      For i = desdeX To numDeColumnas - 1
         For j = desdeY To numDeRegistros - 1
            calculaL(i, j) = CDec(calculoDeTitulos(i, j))
            'Calcula la sumatoria de los datos que se guardan en columna L

            totalcalculaL += CDec(calculaL(i, j))
            'Sirve para calcular el numero de datos (pozos utilizados para el caso)
            cuentaNoDatos += 1

            'Calcula el logaritmo  base 10 del la columna L, que se utilizara para la calcular ma media geometrica
            If (calculaL(i, j) > 0) Or (calculaL(i, j) < 0) Then
               calculaSumatoriaMG += CDec(Microsoft.VisualBasic.Left(CStr(CDec(Math.Log10(calculaL(i, j)))), 14))
            End If

            Select Case calculaL(i, j)
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
         'desdeY = hastaY
      Next

      '--------------------------------------------------
      'OBTIENE LOS VALORES DE PARA LOS DATOS NO AGRUPADOS
      '--------------------------------------------------

      'Obtengo el promedio de los valores de la columna L o Media aritmetica
      mediaAritmetica = CDec(totalcalculaL / cuentaNoDatos)

      'calcula la varianza para datos no agrupados

      For i = desdeX To numDeColumnas - 1
         For j = desdeY To numDeRegistros - 1
            temp = CDec(Microsoft.VisualBasic.Left(CStr((calculaL(i, j) - mediaAritmetica) ^ 2), 14))
            calculaVarianzaDatosNoAgrupados += temp
         Next
      Next

      'Calcula varianza para datos no agrupados
      calculaVarianzaDatosNoAgrupados = CDec(calculaVarianzaDatosNoAgrupados / (cuentaNoDatos - 1))

      'Calcula la desviacion estandar no considerando los datos agrupados
      desviacionEstandarDatosNoAgrupados = CDec(Math.Sqrt(calculaVarianzaDatosNoAgrupados))

      'Calcula el coeficiente de variacion para datos no agrupados
      coeficienteDeVariacionDatosNoAgrupados = CDec(desviacionEstandarDatosNoAgrupados / mediaAritmetica * 100)

      '-----------------------------------------
      'CALCULA LOS VALORES PARA DATOS AGRUPADOS
      '-----------------------------------------

      'Calculo la sumatoria de la frecuencia de clase fi
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + rangoDoce + rangoTrece + rangoCatorce + rangoQuince

      'Asigno al arreglo los datos que son frecuencia de clase
      rangoDatos = {rangoUno, rangoDos, rangoTres, rangoCuatro, rangoCinco, rangoSeis, rangoSiete, rangoOcho, rangoNueve, rangoDiez, rangoOnce, rangoDoce, rangoTrece, rangoCatorce, rangoQuince}


      'Calculo de la sumatoria de la fecuencia de los datos por la marca de clase (xi*fi)
      For i = 0 To 14
         calculaMedia += CDec(rangoDatos(i) * marcaDeClase(i))
      Next

      'Obtiene el valor de la Media 
      calculaMedia = CDec(calculaMedia / rangoTotal)

      temp = 0
      'Calculo Varianza que se obtiene por sumatoria (xi - Media)^2 * fi / n-1 para las marca de datos (15)
      For i = 0 To 14
         temp += CDec(Microsoft.VisualBasic.Left(CStr(((marcaDeClase(i) - calculaMedia) ^ 2)), 14)) * rangoDatos(i)
         calculaVarianza = CDec(temp / (rangoTotal - 1))
         'Calcula la frecuencia relativa de los valores, que se utilizará después para graficar los datos
         frecuenciaRelativa(i) = CDec((rangoDatos(i) / rangoTotal) * 100)
      Next

      'Calcula la desviación estándar = raíz cuadrada de la varianza
      desviacionEstandar = CDec(Math.Sqrt(calculaVarianza))

      'Calcula el coeficiente de variacion
      coeficienteDeVariacion = CDec(desviacionEstandar / calculaMedia) * 100

      'Calcula la sumatoria del logaritmo de cada valor utilizado en L que se utilizara para obtener la media geometrica
      calculaSumatoriaMG = CDec(calculaSumatoriaMG / rangoTotal)

      'calcula la Media Geometrica
      mediaGeometrica = CDec(10 ^ CDec(calculaSumatoriaMG))

      'Presenta datos
      frmSalidaDatos.txtMediaAritmetica.Text = CStr(calculaMedia)
      frmSalidaDatos.txtMediaAritmetica2.Text = CStr(mediaAritmetica)
      frmSalidaDatos.txtMediaGeometrica.Text = CStr(mediaGeometrica)
      frmSalidaDatos.txtCoefVariacion.Text = CStr(coeficienteDeVariacion)
      frmSalidaDatos.txtDesvEstandar.Text = CStr(desviacionEstandar)
      frmSalidaDatos.txtVarianza.Text = CStr(calculaVarianza)
      frmSalidaDatos.txtTotalDatosCalculados.Text = CStr(cuentaNoDatos)
      frmSalidaDatos.txtCoefVariacion2.Text = CStr(coeficienteDeVariacionDatosNoAgrupados)
      frmSalidaDatos.txtDesvEstandar2.Text = CStr(desviacionEstandarDatosNoAgrupados)
      frmSalidaDatos.txtVarianza2.Text = CStr(calculaVarianzaDatosNoAgrupados)
   End Sub
End Module
