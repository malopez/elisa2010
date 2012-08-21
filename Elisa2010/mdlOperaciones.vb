Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices


'IMPORTANTE: !!
'TODAS LAS EXTENSIONES SE CAMBIARON DE XLSX A XLS PARA QUE FUNCIONE EL PROGRAMA CON LA VERSION 2003 DE EXCEL.
'SE CONSERVA EL CÓDIGO PARA EJECUTARLO CON EXCEL 2010 COMENTADO ARRIBA DE DONDE SE UTILIZA LA INSTRUCCION PARA 2003.
Module mdlOperaciones
   Public Const cadenaConexion = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
   '################################
   '# SECCION DE VARIABLES GLOBALES#
   '################################
   'utilizada para almacenar los datos que se reciben por el puerto
   Public az As String
   'Arreglo que servira de buffer para los datos que van llegando al puerto
   Public msn As String = ""
   'Guarda la placa leida desde el lector debidamente formateada
   Public placaLector(7, 11) As Decimal
   'Guarda los valores de la frecuencia Relativa
   Public frecuenciaRelativa(14) As Decimal
   'Matriz para calculo de Logaritmo de Titulos
   Public calculoDeTitulos(7, 11) As Decimal
   'Ruta donde se guardaran los archivos
   Public rutaImagen As String = "C:\ELISA2012\Imagenes\"
   Public rutaPlacas As String = "C:\ELISA2012\Placas Originales\"
   Public rutaResutados As String = "C:\ELISA2012\Resultados\"

   'Procedimiento utilizado para convertir la cadena de entrada desde el puerto en un arreglo, quitando los blancos
   'Los <Enter>, <retorno de carro>, <Tabs>, <Nuevas líneas> y el <_Quick> que coloca el lector al final de lo que lee
   'Como los valores vienen separados por comas, los elimina y obtiene mediante la funcion <val> el valor real de cada
   'cadena, es una funcion estandar de visual basic.
   Public Sub convierteCadena(ByVal msn As String)
       'Arreglo de cadenas temporal para eliminar las comas
      Dim a() As String
      'control del ciclo de recorrido
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim k As Integer = 1
      'MessageBox.Show("Valor de msn antes:" & msn)
      msn = Replace(msn, " ", "")
      msn = Replace(msn, vbCrLf, "")
      msn = Replace(msn, vbCr, "")
      msn = Replace(msn, vbTab, "")
      msn = Replace(msn, vbNewLine, "")
      msn = Replace(msn, "_Quick", "")
      'Copia en el Arreglo los valores de datos separados por comas
      a = Split(msn, ",")
      'MessageBox.Show("Valor de msn despues:" & msn)
      'MessageBox.Show("Llegue al split valor de msn es " & msn & "valor de largo de a: " & a.Length)
      Dim temporal As Decimal
      Dim tmp As String = ""
      For i = 0 To 7
         For j = 0 To 11
            'La funcion val regresa el valor correcto de los datos cuando es numérico, si no es nuérico, entonces coloca un 0.
            temporal = (Val(a(k)) / 1000)
            ' If (temporal > 1) Then
            'placaLector(i, j) = 0
            'Else
            placaLector(i, j) = temporal
            'End If
            'MessageBox.Show("Valor de placaLector en " & i & " , " & j & ": " & placaLector(i, j) & "Valor de a(k): " & a(k) & "max val:" & UBound(a))
            k += 1
         Next
      Next
   End Sub

   Public Sub dibujaTablaEnPantalla(ByRef placa As DataGridView)
      Dim i As Integer
      'Quita el indicador de fila del datagridview
      placa.RowHeadersVisible = False
      placa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
      placa.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      placa.Columns.Add("pozo0", "")
      placa.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
      placa.Columns(0).AutoSizeMode = False

      For i = 1 To 12
         placa.Columns.Add("pozo" & i, i)
         With placa.Columns(i)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .SortMode = DataGridViewColumnSortMode.NotSortable
         End With
      Next
      placa.Rows.Add(8)
      'dgvPlaca.Columns(0).Frozen = True  Descomentar si se requiere la primer celda fija.
      For i = 0 To 7
         placa.Rows(i).Cells(0).Value = obtenLetra(i)
         placa.Rows(i).Cells(0).Style.ForeColor = Color.MidnightBlue
         placa.Rows(i).Cells(0).Style.BackColor = Color.LightSteelBlue
      Next

   End Sub


   Public Sub organizaEnTabla(ByRef placa As DataGridView, ByVal placaLector(,) As Decimal)
      Dim i As Integer
      ''Quita el indicador de fila del datagridview
      'placa.RowHeadersVisible = False
      'placa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
      'placa.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      'placa.Columns.Add("pozo0", "")
      'placa.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
      'placa.Columns(0).AutoSizeMode = False

      'For i = 1 To 12
      '   placa.Columns.Add("pozo" & i, i)
      '   With placa.Columns(i)
      '      .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
      '      .SortMode = DataGridViewColumnSortMode.NotSortable
      '   End With
      'Next
      'placa.Rows.Add(8)
      ''dgvPlaca.Columns(0).Frozen = True  Descomentar si se requiere la primer celda fija.
      'For i = 0 To 7
      '   placa.Rows(i).Cells(0).Value = obtenLetra(i)
      '   placa.Rows(i).Cells(0).Style.ForeColor = Color.MidnightBlue
      '   placa.Rows(i).Cells(0).Style.BackColor = Color.LightSteelBlue
      'Next

      For i = 0 To 7
         For j = 0 To 11
            placa.Rows(i).Cells(j + 1).Value = placaLector(i, j)
            placa.Rows(i).Cells(j + 1).Style.ForeColor = Color.Black
         Next
      Next
   End Sub




   Public Sub organizaEnTablaDA(ByRef placa As DataGridView, ByVal placaLector(,) As Decimal)
      Dim i As Integer
      'Quita el indicador de fila del datagridview
      placa.RowHeadersVisible = False
      placa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
      placa.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      placa.Columns.Add("pozo0", "")
      placa.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
      placa.Columns(0).AutoSizeMode = False

      For i = 1 To 12
         placa.Columns.Add("pozo" & i, i)
         With placa.Columns(i)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .SortMode = DataGridViewColumnSortMode.NotSortable
         End With
      Next
      placa.Rows.Add(8)
      'dgvPlaca.Columns(0).Frozen = True  Descomentar si se requiere la primer celda fija.
      For i = 0 To 7
         placa.Rows(i).Cells(0).Value = obtenLetra(i)
         placa.Rows(i).Cells(0).Style.ForeColor = Color.MidnightBlue
         placa.Rows(i).Cells(0).Style.BackColor = Color.LightSteelBlue
      Next

      For i = 0 To 7
         For j = 0 To 11
            placa.Rows(i).Cells(j + 1).Value = placaLector(i, j)
         Next
      Next
   End Sub

   '#################################################
   '#      SECCION DE CARGA DE RESULTADOS EN BD     #
   '#################################################

   Public Sub cargaResultadosBD(ByRef numcaso As String, ByVal idAnalisis As String, ByVal placaLeida As String, ByRef resultadoTitulos As String, ByVal fechaElaboracion As String, ByVal promCP As Double, ByVal promCN As Double, _
                                 ByVal promCPS As Double, ByVal mediaAritmetica As Double, ByVal mediaGeometrica As Double, _
                                 ByVal desvEst As Double, ByVal coefVar As Double, ByVal valorFR As String, ByVal cantidadFR As String, _
                                 ByRef etiqueta As Label)
      Dim resultado As Integer
      Dim comando As New MySqlCommand
      Dim cadenafecha As String
      Dim tabla() As String
      cadenafecha = fechaElaboracion
      tabla = Split(cadenafecha, "/")
      fechaElaboracion = tabla(2) & "/" & tabla(1) & "/" & tabla(0)
      Try
         'Crear la conexion para establecer el acceso a la BD de MySQL
         Dim oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         'Abrir la conexion a la base de datos
         oConexion.Open()
         'Asigna la cadena de conexion
         comando.Connection = oConexion
         comando.CommandText = "INSERT INTO tblplacaleida (caso,id_analysis,fechaElaboracion,placaLeida,resultadoTitulos,promCP,promCN,promCPS,medArit,medGeom,desvEst,coefVar,valorFR,cantidadFR) VALUES " _
                                & "('" & numcaso & "','" & idAnalisis & "'," & "STR_TO_DATE('" & fechaElaboracion & "','" & "%Y/%m/%d" & "'),'" _
                                & placaLeida & "','" & resultadoTitulos & "'," & promCP & "," & promCN & "," & promCPS & "," & mediaAritmetica & "," & mediaGeometrica & "," _
                                & desvEst & "," & coefVar & ",'" & valorFR & "','" & cantidadFR & "');"
         'MessageBox.Show("valor de la consulta:" & comando.CommandText)
         resultado = comando.ExecuteNonQuery()
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiqueta, ex)
      Catch ex As DataException
         mensajeException(etiqueta, ex)
      Catch ex As Exception
         mensajeException(etiqueta, ex)
      End Try
   End Sub

   Public Sub cargaFrecRelBD(ByVal frecuenciaRelativa() As Decimal, ByRef numcaso As String, ByVal rangoDatos() As Integer, _
                             ByRef etiqueta As Label)

      Dim i As Integer
      Dim resultado As Integer
      Dim comando As New MySqlCommand
      Try
         'Crear la conexion para establecer el acceso a la BD de MySQL
         Dim oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         'Abrir la conexion a la base de datos
         oConexion.Open()
         'Asigna la cadena de conexion
         comando.Connection = oConexion
         comando.CommandText = "truncate table tblfrecrelativa;"
         resultado = comando.ExecuteNonQuery()
         'Guardar los datos de la frecuencia relativa en la BD

         For i = 0 To 14
            'comando.CommandText = "UPDATE tblplacaleida set rango" & i + 1 & "=" & reduceDecimal(frecuenciaRelativa(i)) & " WHERE caso='" & numcaso & "'"
            'resultado = comando.ExecuteNonQuery()
            comando.CommandText = "INSERT INTO tblfrecrelativa (rango,valor,cantidad) values (" & i & "," & reduceDecimal(frecuenciaRelativa(i)) & "," & rangoDatos(i) & ");"
            resultado = comando.ExecuteNonQuery()
         Next
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiqueta, ex)
      Catch ex As DataException
         mensajeException(etiqueta, ex)
      Catch ex As Exception
         mensajeException(etiqueta, ex)
      End Try
   End Sub

   

   '#####################################
   '# SECCION ORGANIZACION DE DATOS     #
   '#####################################
   'Esta funcion recibe el arreglo donde se guardaran los datos de la placa y retorna el valor de los datos organizados
   'por columna en una cadena llamada "resultado"
   Public Sub formateaDatos(ByVal placaLector(,) As Decimal, ByRef dgvPlacaLeida As DataGridView)
      Dim limInferior As Integer = 0 'utilizado para marcar 0,12,24,36,48,60,72 y 84
      Dim limSuperior As Integer = 0 'utilizado para marcar 11,23,35,47,59,71,83,95
      'para controlar los ciclos for
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim k As Integer = 0
      'recorrer el indice del arreglo temporal que se utiliza para ordenar los datos porque el lector lee en forma de "S"
      Dim contador As Integer = 0
      'recorrer el indice de el arreglo recibido desde el puerto serie
      Dim contador1 As Integer = 0
      'Arreglo temporal para alojar los valores que se encuentran en inversa
      Dim temporal(11) As Decimal
      'Permite guardar los datos ya organizados y formateados como matriz, que después se enviaran al archivo de texto
      Dim resultado As String = ""
      Dim copia(95) As Decimal
      k = 0
      For i = 0 To 7
         For j = 0 To 11
            copia(k) = placaLector(i, j)
            k += 1
         Next
      Next
      For i = 0 To 7
         'Los valores invertidos son los pares, es decir las lineas pares A, C, E y G, si el numero es divisible entre dos,
         ' quiere decir que la i es par entonces se mueve en el indice de msn hasta limite superior y va regresando 11 valores
         If ((i Mod 2) = 0) Then
            limInferior = i * 12
            limSuperior = limInferior + 12
            For k = limSuperior - 1 To limInferior Step -1
               temporal(contador) = copia(k)
               contador += 1
               contador1 += 1
            Next
            'Reinicia el contador del arreglo temporal a 0 para que cuando i sea nuevamente par comienze a organizar en temporal(0)
            contador = 0
            'Lee todos los datos del temporal ahora organizados y se los pasa a la placa leida ya en orden correcto
            For j = 0 To 11
               placaLector(i, j) = temporal(j)
            Next
         Else
            'si i no es par, entonces le asigna los valores del arreglo leido desde el puerto
            For j = 0 To 11
               placaLector(i, j) = copia(contador1)
               contador1 += 1
            Next
         End If
      Next
      'Lee todos lo valores de la placa y se los va concatenando al resultado, variable que luego será guardada dentro 
      'del archivo de texto
      For i = 0 To 7
         For j = 0 To 11
            resultado &= CStr(placaLector(i, j)) & vbTab
         Next
         resultado &= vbCrLf
      Next
      'Presenta en pantalla los valores obtenidos desde el lector ya formateados
      frmRegistraNuevoAnalisis.txtDatosRecibidos.Text = resultado
      'organizaEnTabla(dgvPlacaLeida, placaLector)
      'Return (resultado)
   End Sub

   'Funcion que calcula el valor de los promedios positivos.Cuando solo se colocan dos promedios positivos, se obtiene el promedio de 
   'ellos y se suma a los dos originales, sacando asi un tercer valor que también se promedia con los dos originales
   'En caso de que sean tres valores positivos, se promedian normalmente
   Public Function calculaPromedioPositivos(ByVal nocp As Integer, ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer _
                                           , ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, ByRef etiqueta As Label) As Decimal
      Dim promedioPositivos As Decimal
      Try
         If (nocp = 3) Then
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2) + placaLector(cpx3, cpy3)) / 3))
         ElseIf (nocp = 2) Then
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2)) / nocp))
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2) + promedioPositivos) / 3))
         End If
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles positivos.")
      End Try
      Return (promedioPositivos)
   End Function

   'Funcion que calcula el valor de los promedios negativos. Cuando solo se colocan dos promedios negativos, se obtiene el promedio de 
   'ellos y se suma a los dos originales, sacando asi un tercer valor que también se promedia con los dos originales
   'En caso de que sean tres valores negativos, se promedian normalmente
   Public Function calculaPromedioNegativos(ByVal nocp As Integer, ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer _
                                           , ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, ByRef etiqueta As Label) As Decimal
      Dim promedioNegativos As Decimal
      Try
         If (nocp = 3) Then
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2) + placaLector(cnx3, cny3)) / 3))
         ElseIf (nocp = 2) Then
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2)) / nocp))
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2) + promedioNegativos) / 3))
         End If
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles negativos.")
      End Try
      Return (promedioNegativos)
   End Function

   'Funcion que calcula el valor de los promedios positivos leidos desde archivo
   Public Function calculaPromedioPositivosDA(ByVal cp1 As Decimal, ByVal cp2 As Decimal, ByVal cp3 As Decimal, ByRef etiqueta As Label) As Decimal
      Dim promedioPositivos As Decimal
      Try
         promedioPositivos = reduceDecimal(((cp1 + cp2 + cp3) / 3))
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles positivos desde archivo.")
      End Try
      Return (promedioPositivos)
   End Function

   'Funcion que calcula el valor de los promedios negativos leidos desde archivo
   Public Function calculaPromedioNegativosDA(ByVal cn1 As Decimal, ByVal cn2 As Decimal, ByVal cn3 As Decimal, ByRef etiqueta As Label) As Decimal
      Dim promedioNegativos As Decimal
      Try
         promedioNegativos = reduceDecimal(((cn1 + cn2 + cn3) / 3))

      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles negativos desde archivo.")
      End Try
      Return (promedioNegativos)
   End Function

   'Calcula la diferencia de controles positivos y negativos
   Public Function calculaDiferenciaSPS(ByVal promCP As Decimal, ByVal promCN As Decimal, ByRef etiqueta As Label) As Decimal
      Dim difCPS As Decimal
      Try
         difCPS = reduceDecimal(CDec(promCP - promCN))
      Catch
         mensajeRojo(etiqueta, "ERROR: al calcular el valor del la diferencia de controles.")
      End Try
      Return (difCPS)
   End Function

   'Funcion que calcula los resultados del analisis, recibe el nombre del analisis,el titulo de eje x-y, desdeArchivo =1 indica lectura desde archivo
   'cpx y cny son los valores de A..H,  es decir, el valor de la placa por columna   usada para control positivo-negativo
   'cpy y cny son los valores de 1..12, es decir, el valor de la placa por renglones usada para control positivo-negativo
   'logsps, logtit1 y logtit2 son valores utilizados para definir valores especiales que varian de acuerdo a la enfermedad 
   'seleccionada. El parametro nombre es el nombre del análisis/Enfermedad que se ha evaluado
   Public Sub calculaValores(ByVal nombre As String, ByVal nombreCliente As String, ByVal observaciones As String, _
                             ByVal titulox As String, ByVal tituloy As String, ByRef desdeArchivo As Integer,
                             ByRef numcaso As String, ByVal fechaElaboracion As String, _
                             ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                             ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                             ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                             ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, _
                             ByVal logsps As Decimal, ByVal logtit1 As Decimal, ByVal logtit2 As Decimal, _
                             ByVal cp1 As Decimal, ByVal cp2 As Decimal, ByVal cp3 As Decimal, _
                             ByVal cn1 As Decimal, ByVal cn2 As Decimal, ByVal cn3 As Decimal)
      'Para controlar el ciclo for, y posteriormente para calcular los valores de la "L, DESDE" y los valores de la matriz 15x96
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim k As Integer = 0
      'Para presentar el resultado del análisis campo texto de la forma
      'Dim resultado As String = "" COMENTADO EL 03-MAYO-2012
      Dim resultadoTitulos As String = ""
      Dim placaoriginal As String = ""
      'Para calcular el numero de datos seleccionados de los pozos para realizar el analisis
      Dim cuentaNoDatos As Integer = 0
      'Para identificar los rangos de los datos introducidos 
      Dim totalCeros As Integer = 0
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
      Dim calculaL(7, 11) As Decimal

      'Arreglo para definir la marca de clase
      Dim marcaDeClase() = {1, 175, 925, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000, 12500}

      'Se utiliza para colocar el fi por cada una de las marcas de clase
      Dim rangoDatos() As Integer

      'Arreglo para la guardar la frecuencia relativa


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
      Dim nocp As Integer = 3
      numDeColumnas = placaLector.GetLength(0)
      numDeRegistros = placaLector.GetLength(1)
      Dim valorFR As String = ""
      Dim cantidadFR As String = ""
      Dim idAnalisis As String = "TEMPORAL"
      'Si no es desde archivo la lectura de la placa, entonces calcula los valores en base a los valores x,y introducidos
      If (desdeArchivo <> 1) Then
         'Valida que se ejecute el calculo de promedio positivo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCP = calculaPromedioPositivos(nocp, cpx1, cpx2, cpx3, cpy1, cpy2, cpy3, frmRegistraNuevoAnalisis.lblMensajeCaso)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio positivo, verifique los valores de control.")
         End Try
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCN = calculaPromedioNegativos(nocp, cnx1, cnx2, cnx3, cny1, cny2, cny3, frmRegistraNuevoAnalisis.lblMensajeCaso)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio negativo, verifique los valores de control.")
         End Try
      Else
         'si es desde archivo la lectura, toma los valores obtenidos de leer el archivo excel
         Try
            promCP = calculaPromedioPositivosDA(cp1, cp2, cp3, frmRegistraNuevoAnalisis.lblMensajeCaso)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio positivo, verifique los valores de control.")
         End Try
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCN = calculaPromedioNegativosDA(cn1, cn2, cn3, frmRegistraNuevoAnalisis.lblMensajeCaso)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio negativo, verifique los valores de control.")
         End Try
      End If
      'Calcula la diferencia de controles positivos y negativos
      difCPS = reduceDecimal(CDec(promCP - promCN))

      'Calcula la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            'If IsNumeric(placaLector(i, j)) Then MODIFICADO 18-Abril-2012
            If (placaLector(i, j) > 0) Then
               calculaSPS(i, j) = reduceDecimal(((placaLector(i, j) - promCN) / difCPS))
               'Sirve para calcular el numero de datos (pozos utilizados para el caso) AGREGADO 30-Abril-2012
               cuentaNoDatos += 1
            Else
               calculaSPS(i, j) = 0
            End If
            placaoriginal += placaLector(i, j) & vbTab
         Next
         'placaoriginal += vbCrLf MODIFICADO EL 04 MAYO 2012
      Next

      'Calcula los logaritmos de la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If (calculaSPS(i, j) > logsps) Then
               logaritmoSPS(i, j) = reduceDecimal(Math.Log10(calculaSPS(i, j)))
            Else
               logaritmoSPS(i, j) = -4
            End If
         Next
      Next

      'Calcula los Titulos de la tabla de logaritmos SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            logaritmoTitulos(i, j) = reduceDecimal(((logtit1 * logaritmoSPS(i, j)) + logtit2))
         Next
      Next
      Dim n As Integer = 0
      Dim presenta1 As String = "Sueros  Títulos" & vbCrLf & " " & vbCrLf
      'Calcula el titulo mendiante la exponenciacion 10 ^ A1..H1, en la hoja de excel corresponde a la columna K, y que tambien 
      'se utilizan en la columna AE para tomar los titulos de los sueros en resultados finales
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If (logaritmoTitulos(i, j) > 0) Then
               calculoDeTitulos(i, j) = reduceDecimal(CDec((10 ^ logaritmoTitulos(i, j))))
            Else
               calculoDeTitulos(i, j) = 0
            End If
            resultadoTitulos += calculoDeTitulos(i, j) & vbTab
            n += 1
            If (n <= 96) Then
               presenta1 += n & "       " & reduceDecimal(calculoDeTitulos(i, j)) & vbCrLf
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
      hastaX = 7
      desdeY = 0
      hastaY = 12

      'Calcula el valor de la matriz para llenar la columna L
      For i = desdeX To hastaX 'numDeColumnas - 1 COMENTADO EL 30 DE ABRIL
         For j = desdeY To numDeRegistros - 1
            calculaL(i, j) = CDec(calculoDeTitulos(i, j))
            'Calcula la sumatoria de los datos que se guardan en columna L
            totalcalculaL += CDec(calculaL(i, j))
            'Calcula el logaritmo  base 10 del la columna L, que se utilizara para la calcular ma media geometrica
            If (calculaL(i, j) > 0) Or (calculaL(i, j) < 0) Then
               calculaSumatoriaMG += reduceDecimal(CDec(Math.Log10(calculaL(i, j))))
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
         ' desdeY = hastaY
      Next

      '--------------------------------------------------
      'OBTIENE LOS VALORES DE PARA LOS DATOS NO AGRUPADOS
      '--------------------------------------------------

      'Obtengo el promedio de los valores de la columna L o Media aritmetica
      mediaAritmetica = CDec(totalcalculaL / cuentaNoDatos)

      'calcula la varianza para datos no agrupados

      For i = desdeX To hastaX 'numDeColumnas - 1 COMENTADO EL 30 de ABRIL!!
         For j = desdeY To numDeRegistros - 1
            temp = reduceDecimal(((calculaL(i, j) - mediaAritmetica) ^ 2))
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
      rangoTotal = rangoUno + rangoDos + rangoTres + rangoCuatro + rangoCinco + rangoSeis + rangoSiete + rangoOcho + rangoNueve + rangoDiez + +rangoOnce + rangoDoce + rangoTrece + rangoCatorce + rangoQuince

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
         temp += reduceDecimal(((marcaDeClase(i) - calculaMedia) ^ 2)) * rangoDatos(i)
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

      'Carga los datos para la frecuencia relativa y crea la gráfica
      cargaResultadosBD(numcaso, idAnalisis, placaoriginal, resultadoTitulos, fechaElaboracion, promCP, promCN, difCPS, _
                        Convert.ToDouble(mediaAritmetica), Convert.ToDouble(mediaGeometrica), _
                        Convert.ToDouble(desviacionEstandarDatosNoAgrupados), Convert.ToDouble(coeficienteDeVariacionDatosNoAgrupados), _
                        valorFR, cantidadFR, frmSalidaDatos.lblObservaciones)
      'CARGAR LA TABLA DE FREC REL
      cargaFrecRelBD(frecuenciaRelativa, numcaso, rangoDatos, frmSalidaDatos.lblObservaciones)
      'creaChartFrecRel(frmSalidaDatos.lblSalidaDatos, frmSalidaDatos, nombre, titulox, tituloy, numcaso, idAnalisis)

      'Presenta datos MODIFICADO EL 03-MAYO-2012 para formatear la salida de los datos

      frmSalidaDatos.txtNombreEnfermedad.Text = nombre
      frmSalidaDatos.txtNombreCliente.Text = nombreCliente
      frmSalidaDatos.txtNoCaso.Text = numcaso
      frmSalidaDatos.lblObservaciones.Text = observaciones
      frmSalidaDatos.txtFechaElaboracion.Text = fechaElaboracion
      frmSalidaDatos.txtTitulosObtenidos.Text = presenta1

      frmSalidaDatos.txtMediaAritmetica2.Text = CStr(Convert.ToDouble(mediaAritmetica))
      frmSalidaDatos.txtMediaGeometrica.Text = CStr(Convert.ToDouble(mediaGeometrica))
      frmSalidaDatos.txtTotalDatosCalculados.Text = CStr(cuentaNoDatos)
      frmSalidaDatos.txtCoefVariacion2.Text = CStr(Convert.ToDouble(coeficienteDeVariacionDatosNoAgrupados))
      frmSalidaDatos.txtDesvEstandar2.Text = CStr(Convert.ToDouble(desviacionEstandarDatosNoAgrupados))
      frmSalidaDatos.txtVarianza2.Text = CStr(calculaVarianzaDatosNoAgrupados)
      ' frmSalidaDatos.txtMediaAritmetica.Text = CStr(calculaMedia)
      'frmSalidaDatos.txtCoefVariacion.Text = CStr(coeficienteDeVariacion)
      'frmSalidaDatos.txtDesvEstandar.Text = CStr(desviacionEstandar)
      'frmSalidaDatos.txtVarianza.Text = CStr(calculaVarianza)
   End Sub
End Module
