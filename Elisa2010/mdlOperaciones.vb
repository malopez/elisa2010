Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

'IMPORTANTE: !!
'TODAS LAS EXTENSIONES SE CAMBIARON DE XLSX A XLS PARA QUE FUNCIONE EL PROGRAMA CON LA VERSION 2003 DE EXCEL.
'SE CONSERVA EL CÓDIGO PARA EJECUTARLO CON EXCEL 2010 COMENTADO ARRIBA DE DONDE SE UTILIZA LA INSTRUCCION PARA 2003.
Module mdlOperaciones
   Public etiquetaMensaje As ToolStripLabel = frmElisaBiovetsa.lblMensajeAplicacion
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
   Public Const rutaImagen As String = "C:\ELISA2012\Imagenes\"
   Public Const rutaPlacas As String = "C:\ELISA2012\Placas Originales\"
   Public Const rutaInformeFinal As String = "C:\ELISA2012\Informe Final\"
   Public Const rutaParaImprimir As String = "C:\ELISA2012\Para Imprimir\"
   Public Const rutaResutados As String = "C:\ELISA2012\Resultados\"
   Public Const rutaPlacasLeidas As String = "C:\ELISA2012\Placas Leidas\"

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

      msn = Replace(msn, " ", "")
      msn = Replace(msn, vbCrLf, "")
      msn = Replace(msn, vbCr, "")
      msn = Replace(msn, vbTab, "")
      msn = Replace(msn, vbNewLine, "")
      msn = Replace(msn, "_Quick", "")

      Console.WriteLine("Valor de msn: " & msn)

      'Copia en el Arreglo los valores de datos separados por comas
      a = Split(msn, ",")
      Console.WriteLine("Valor de ubound(a): " & UBound(a))

      If UBound(a) > 0 Then
         Dim temporal As Decimal
         Dim tmp As String = ""
         For i = 0 To 7
            For j = 0 To 11
               'La funcion val regresa el valor correcto de los datos cuando es numérico, si no es numérico, entonces coloca un 0.
               temporal = (Val(a(k)) / 1000)
               placaLector(i, j) = temporal
               k += 1
            Next
         Next
      else
         mensajeRojo(etiquetaMensaje, "ERROR: No se ha obtenido una cadena de valores desde el lector default.")
      End If
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
      'Presenta en pantalla los valores obtenidos desde el lector ya formateados MODIFICADO EL 19 DE SEPT 2012
      'frmRegistraNuevoAnalisis.txtDatosRecibidos.Text = resultado

      'organizaEnTabla(dgvPlacaLeida, placaLector)
      'Return (resultado)
   End Sub

   'Funcion que calcula el valor de los promedios positivos.Cuando solo se colocan dos promedios positivos, se obtiene el promedio de 
   'ellos y se suma a los dos originales, sacando asi un tercer valor que también se promedia con los dos originales
   'En caso de que sean tres valores positivos, se promedian normalmente
   Public Function calculaPromedioPositivos(ByVal nocp As Integer, ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer _
                                           , ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim promedioPositivos As Decimal
      Try
         If (nocp = 2) Then
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2)) / nocp))
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2) + promedioPositivos) / 3))
         ElseIf (nocp = 3) Then
            promedioPositivos = reduceDecimal(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2) + placaLector(cpx3, cpy3)) / 3))
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
                                           , ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim promedioNegativos As Decimal
      Try
         If (nocp = 2) Then
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2)) / nocp))
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2) + promedioNegativos) / 3))
         ElseIf (nocp = 3) Then
            promedioNegativos = reduceDecimal(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2) + placaLector(cnx3, cny3)) / 3))
         Else
         End If
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles negativos.")
      End Try
      Return (promedioNegativos)
   End Function

   'Funcion que calcula el valor de los promedios positivos leidos desde archivo
   Public Function calculaPromedioPositivosDA(ByVal cp1 As Decimal, ByVal cp2 As Decimal, ByVal cp3 As Decimal, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim promedioPositivos As Decimal
      Try
         promedioPositivos = reduceDecimal(((cp1 + cp2 + cp3) / 3))
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles positivos desde archivo.")
      End Try
      Return (promedioPositivos)
   End Function

   'Funcion que calcula el valor de los promedios negativos leidos desde archivo
   Public Function calculaPromedioNegativosDA(ByVal cn1 As Decimal, ByVal cn2 As Decimal, ByVal cn3 As Decimal, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim promedioNegativos As Decimal
      Try
         promedioNegativos = reduceDecimal(((cn1 + cn2 + cn3) / 3))
      Catch ex As Exception
         mensajeRojo(etiqueta, "ERROR: al calcular el promedio de controles negativos desde archivo.")
      End Try
      Return (promedioNegativos)
   End Function

   '###############################################################################################
   '# CALCULA EL VALOR DE CONTROL, EN ALGUNOS CASOS ES PROMP-PROMN, EN OTROS CASOS ES PROMP/PROMN #
   '###############################################################################################
   'Calcula la diferencia de controles positivos y negativos cuando es promedio positivo - promedio negativo
   Public Function calculaDiferenciaSPS(ByVal promCP As Decimal, ByVal promCN As Decimal, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim difCPS As Decimal
      Try
         difCPS = reduceDecimal(CDec(promCP - promCN))
      Catch
         mensajeRojo(etiqueta, "ERROR: al calcular el valor del la diferencia de controles.")
      End Try
      Return (difCPS)
   End Function

   'Calcula el valor de SPS cuando el cálculo se basa en promedio positivos dividido entre promedio negativos
   Public Function calculaDivisionSPS(ByVal promCP As Decimal, ByVal promCN As Decimal, ByRef etiqueta As ToolStripLabel) As Decimal
      Dim difCPS As Decimal
      Try
         difCPS = reduceDecimal(CDec(promCP / promCN))
      Catch
         mensajeRojo(etiqueta, "ERROR: al calcular el valor del la diferencia de controles.")
      End Try
      Return (difCPS)
   End Function
End Module
