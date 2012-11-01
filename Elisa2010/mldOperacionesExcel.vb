Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module mldOperacionesExcel

   Public Sub coloreaDatosExcel(ByRef exelApp As Excel.Application, ByVal numcolor As Integer, ByVal desdex As Integer, ByVal desdey As Integer, ByVal hastax As Integer, ByVal hastay As Integer)
      'Llena el fondo de la celda de un color rojo para los datos utilizados en los  cálculos
      Dim renglones As Integer = 11
      For i = desdex To hastax
         If (i = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            exelApp.Range(obtenLetra(i) & (j + 1)).Interior.ColorIndex = numcolor
         Next
         desdey = 0
      Next
   End Sub


   'Procedimiento que sirve para generar el archivo de excel con la placa original.
   Public Sub guardarDatosExcel(ByVal placaLector(,) As Decimal, ByVal nocp As Integer, ByVal nocn As Integer, _
                               ByVal numCaso As String, ByVal consecutivo As Integer, ByVal analisis As String, _
                                ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                               ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                               ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                               ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, _
                               ByVal desdex As Integer, ByVal desdey As Integer, ByVal hastax As Integer, ByVal hastay As Integer, _
                               ByVal etiqueta As ToolStripLabel, ByRef nombreArchivo As String)

      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      'Sirve para controlar el ciclo for
      Dim i As Integer = 0
      Dim j As Integer = 0
      'Dim nombreArchivo As String
      Dim numcolor As Integer
      'Salva el archivo de placa original leida con el nombre del caso
      If numCaso = "" And analisis = "" Then
         nombreArchivo = rutaPlacas & "ELISA_LECTOR" & Format(DateTime.Now, "yyyyMMdd_hhmm") & ".xls"
         numcolor = 2 'Para no colocar color al fondo de la placa.
      Else
         nombreArchivo = rutaPlacas & numCaso & "-" & consecutivo & "-" & analisis & ".xls"
         numcolor = 6 'Coloca el color amarillo al caso
      End If
      'Mostrar Excel en pantalla y crea el workbook
      excelApp.Visible = False
      libroExcel = excelApp.Workbooks.Add()
      'Darle nombre la primer hoja activa del libro de trabajo
      excelApp.ActiveSheet.Name = "PlacaLeida"
      'Agregar datos a la hoja de Excel de la placa leida orignal desde el lector
      For i = 0 To 7
         For j = 0 To 11
            excelApp.Range(obtenLetra(i) & (j + 1)).Value2 = placaLector(i, j)
         Next
      Next
      excelApp.Range("B15").Value2 = "Controles Positivos"
      excelApp.Range("B15").Interior.ColorIndex = 4
      excelApp.Range("C15").Value2 = "Controles Negativos"
      excelApp.Range("C15").Interior.ColorIndex = 3

      'Analiza el numero de controles positivos
      If (nocp = 2) Then
         'Copia los valores positivos.
         excelApp.Range("B16").Value2 = placaLector(cpx1, cpy1)
         excelApp.Range("B17").Value2 = placaLector(cpx2, cpy2)
         Dim promp As Decimal = (placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2)) / 2
         excelApp.Range("B18").Value2 = promp
         'Para que el fondo de la celda sea color Verde=4
         excelApp.Range(obtenLetra(cpx1) & (cpy1 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx2) & (cpy2 + 1)).Interior.ColorIndex = 4
      ElseIf (nocp = 3) Then
         'Copia los valores positivos.
         excelApp.Range("B16").Value2 = placaLector(cpx1, cpy1)
         excelApp.Range("B17").Value2 = placaLector(cpx2, cpy2)
         excelApp.Range("B18").Value2 = placaLector(cpx3, cpy3)

         'Para que el fondo de la celda sea color Verde=4
         excelApp.Range(obtenLetra(cpx1) & (cpy1 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx2) & (cpy2 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx3) & (cpy3 + 1)).Interior.ColorIndex = 4
      End If

      'Analiza si el numero de controles negativos es dos o tres
      If (nocn = 2) Then
         excelApp.Range("C16").Value2 = placaLector(cnx1, cny1)
         excelApp.Range("C17").Value2 = placaLector(cnx2, cny2)
         Dim promn As Decimal = (placaLector(cnx1, cny1) + placaLector(cnx2, cny2)) / 2
         excelApp.Range("C18").Value2 = promn
         excelApp.Range(obtenLetra(cnx1) & (cny1 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx2) & (cny2 + 1)).Interior.ColorIndex = 3
      ElseIf (nocn = 3) Then
         excelApp.Range("C16").Value2 = placaLector(cnx1, cny1)
         excelApp.Range("C17").Value2 = placaLector(cnx2, cny2)
         excelApp.Range("C18").Value2 = placaLector(cnx3, cny3)
         excelApp.Range(obtenLetra(cnx1) & (cny1 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx2) & (cny2 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx3) & (cny3 + 1)).Interior.ColorIndex = 3
      End If

      If numcolor = 6 Then
         'Llena el fondo de la celda de un color rojo para los datos utilizados en los  cálculos
         Dim renglones As Integer = 11
         For i = desdex To hastax
            If (i = hastax) Then
               renglones = hastay
            End If
            For j = desdey To renglones
               excelApp.Range(obtenLetra(i) & (j + 1)).Interior.ColorIndex = numcolor
            Next
            desdey = 0
         Next
      End If

      'Salva el archivo de excel, lo cierra, quita la aplicaciín y la libera.
      With excelApp
         excelApp.DisplayAlerts = False
         excelApp.ActiveWorkbook.SaveAs(nombreArchivo)
         excelApp.DisplayAlerts = True
         .ActiveWorkbook.Close()
         .Quit()
      End With

      releaseObject(excelApp)
      mensajeVerde(etiqueta, "El Caso: " & numCaso & " se ha guardado en excel exitosamente.")
   End Sub

   'Procedimiento que guarda datos en excel, coloreando los distintos casos, utilizando las variables desde-hasta
   'Procedimiento que sirve para generar el archivo de excel con la placa original.
   Public Sub guardarDatosExcelcolor(ByVal placaLector(,) As Decimal, ByVal totalCasos() As listaCasos, _
                                     ByVal nocp As Integer, ByVal nocn As Integer, ByVal analisis As String, _
                                     ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                                     ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                                     ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                                     ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, _
                                     ByVal etiqueta As ToolStripLabel, ByRef nombreArchivo As String)

      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      'Sirve para controlar el ciclo for
      Dim i As Integer = 0
      Dim j As Integer = 0
      'Dim nombreArchivo As String
      Dim numcolor As Integer = 6

      nombreArchivo = rutaPlacas & "ELISA_" & analisis & "_" & Format(DateTime.Now, "yyyyMMdd_hhmm") & ".xls"

      'Mostrar Excel en pantalla y crea el workbook
      excelApp.Visible = False
      libroExcel = excelApp.Workbooks.Add()
      'Darle nombre la primer hoja activa del libro de trabajo
      excelApp.ActiveSheet.Name = "PlacaLeida"
      'Agregar datos a la hoja de Excel de la placa leida orignal desde el lector
      For i = 0 To 7
         For j = 0 To 11
            excelApp.Range(obtenLetra(i) & (j + 1)).Value2 = placaLector(i, j)
         Next
      Next
      excelApp.Range("B15").Value2 = "Controles Positivos"
      excelApp.Range("B15").Interior.ColorIndex = 4
      excelApp.Range("C15").Value2 = "Controles Negativos"
      excelApp.Range("C15").Interior.ColorIndex = 3

      'Analiza el numero de controles positivos
      If (nocp = 2) Then
         'Copia los valores positivos.
         excelApp.Range("B16").Value2 = placaLector(cpx1, cpy1)
         excelApp.Range("B17").Value2 = placaLector(cpx2, cpy2)
         Dim promp As Decimal = (placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2)) / 2
         excelApp.Range("B18").Value2 = promp
         'Para que el fondo de la celda sea color Verde=4
         excelApp.Range(obtenLetra(cpx1) & (cpy1 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx2) & (cpy2 + 1)).Interior.ColorIndex = 4
      ElseIf (nocp = 3) Then
         'Copia los valores positivos.
         excelApp.Range("B16").Value2 = placaLector(cpx1, cpy1)
         excelApp.Range("B17").Value2 = placaLector(cpx2, cpy2)
         excelApp.Range("B18").Value2 = placaLector(cpx3, cpy3)

         'Para que el fondo de la celda sea color Verde=4
         excelApp.Range(obtenLetra(cpx1) & (cpy1 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx2) & (cpy2 + 1)).Interior.ColorIndex = 4
         excelApp.Range(obtenLetra(cpx3) & (cpy3 + 1)).Interior.ColorIndex = 4
      End If

      'Analiza si el numero de controles negativos es dos o tres
      If (nocn = 2) Then
         excelApp.Range("C16").Value2 = placaLector(cnx1, cny1)
         excelApp.Range("C17").Value2 = placaLector(cnx2, cny2)
         Dim promn As Decimal = (placaLector(cnx1, cny1) + placaLector(cnx2, cny2)) / 2
         excelApp.Range("C18").Value2 = promn
         excelApp.Range(obtenLetra(cnx1) & (cny1 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx2) & (cny2 + 1)).Interior.ColorIndex = 3
      ElseIf (nocn = 3) Then
         excelApp.Range("C16").Value2 = placaLector(cnx1, cny1)
         excelApp.Range("C17").Value2 = placaLector(cnx2, cny2)
         excelApp.Range("C18").Value2 = placaLector(cnx3, cny3)
         excelApp.Range(obtenLetra(cnx1) & (cny1 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx2) & (cny2 + 1)).Interior.ColorIndex = 3
         excelApp.Range(obtenLetra(cnx3) & (cny3 + 1)).Interior.ColorIndex = 3
      End If

      'colorea el fondo de excel.
      Dim contador As Integer
      For contador = 0 To UBound(totalCasos) - 1
         coloreaDatosExcel(excelApp, (numcolor + contador), totalCasos(contador).desdeLetra, totalCasos(contador).desdeValor - 1, _
                           totalCasos(contador).hastaLetra, totalCasos(contador).hastaValor - 1)

      Next

      'Salva el archivo de excel, lo cierra, quita la aplicacion y la libera.
      With excelApp
         excelApp.DisplayAlerts = False
         excelApp.ActiveWorkbook.SaveAs(nombreArchivo)
         excelApp.DisplayAlerts = True
         .ActiveWorkbook.Close()
         .Quit()
      End With

      releaseObject(excelApp)
      mensajeVerde(etiqueta, "El archivo de la placa" & nombreArchivo & " se ha guardado en excel exitosamente.")
   End Sub


   '####################################################################################
   'EN ESTA SECCION SE ENCUENTRAN GUARDAR EN EXCEL LOS RESULTADOS CUANDO SE TIENEN
   'SUBCASOS EN LA PLACA LEIDA DESDE EL LECTOR.
   '####################################################################################

   'Predefinir márgenes para la hoja de excel, los valores se deben colocar en pulgadas, por lo que se divide el cms entre 2.54
   Public Sub defineMargenesExcel(excelApp As Excel.Application, ByVal nombrelibro As String)
      excelApp.ActiveSheet.Name = nombrelibro
      excelApp.ActiveSheet.Select()
      With excelApp.ActiveSheet.PageSetup
         .LeftMargin = .Application.InchesToPoints(0.27559055118110237)
         .RightMargin = .Application.InchesToPoints(0.27559055118110237)
         .TopMargin = .Application.InchesToPoints(1.1023622047244095)
         .BottomMargin = .Application.InchesToPoints(0.62992125984251968)
         '.HeaderMargin = .Application.InchesToPoints(0.196850393700787)
         '.FooterMargin = .Application.InchesToPoints(0.196850393700787)
      End With
   End Sub

   'Definir tipo y  tamaño de letra para las celdas.
   Public Sub defineTipoDeLetra(excelApp As Excel.Application, ByVal ubicacion As Integer)
      Dim a As String = "A"
      Dim b As String = "B"
      Dim d As String = ":D"
      Dim g As String = ":G"
      Dim i As String = ":I"
      With excelApp
         .Range(a & (2 + ubicacion)).Font.Bold = True
         .Range(a & (2 + ubicacion)).Font.Bold = True
         .Range(b & (2 + ubicacion) & g & (2 + ubicacion)).MergeCells = True
         .Range(a & (3 + ubicacion) & i & (3 + ubicacion)).MergeCells = True
         .Range(a & (1 + ubicacion) & i & (11 + ubicacion)).Font.Name = "Century Gothic"
         .Range(a & (1 + ubicacion) & i & (11 + ubicacion)).Font.Size = 10
         .Range(a & (12 + ubicacion)).Font.Name = "Arial"
         .Range(a & (12 + ubicacion)).Font.Size = 8
         .Range(b & (12 + ubicacion)).Font.Name = "Arial"
         .Range(b & (12 + ubicacion)).Font.Size = 9
         .Range(a & (13 + ubicacion) & d & (35 + ubicacion)).Font.Name = "Arial"
         .Range(a & (13 + ubicacion) & d & (35 + ubicacion)).Font.Size = 9
         .Range(a & (34 + ubicacion) & d & (35 + ubicacion)).Font.Name = "Arial"
         .Range(a & (34 + ubicacion) & d & (35 + ubicacion)).Font.Size = 9
         .Range(a & (39 + ubicacion)).Font.Name = "Arial"
         .Range(a & (39 + ubicacion)).Font.Size = 9
         .Range(b & (43 + ubicacion)).Font.Name = "Century Gothic"
         .Range(b & (43 + ubicacion)).Font.Size = 10
      End With

   End Sub

   'Colocar las cabeceras para los rangos de datos, tipo y tamaño de letra
   Public Sub defineTitulos(excelApp As Excel.Application, ByVal ubicacion As Integer)
      Dim a As String = "A"
      Dim b As String = "B"
      Dim f As String = "F"
      Dim h As String = "H"
      Dim i As String = "I"
      With excelApp
         .Range(f & (1 + ubicacion)).Value2 = "Resultados de Serología:"
         .Range(h & (1 + ubicacion)).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
         .Range(i & (1 + ubicacion)).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
         .Range(f & (7 + ubicacion)).Value2 = "Fecha del análisis:  "
         .Range(h & (2 + ubicacion)).Value2 = "No. Caso: "
         .Range(a & (2 + ubicacion)).Value2 = "Cliente:  "
         .Range(a & (5 + ubicacion)).Value2 = "ELISA: INMUNOENSAYO ENZIMÁTICO"
         .Range(a & (13 + ubicacion)).Value2 = "Sueros*"
         .Range(b & (13 + ubicacion)).Value2 = "Títulos"
      End With
   End Sub

   'Colocar las cabeceras para los rangos de datos, tipo y tamaño de letra
   Public Sub defineBordes(excelApp As Excel.Application, ByVal ubicacion As Integer)
      Dim a As String = "A"
      Dim h As String = "H"
      With excelApp
         'Colocar los bordes externos a las celdas para el reporte.
         .Range(a & (2 + ubicacion) & ":I" & (3 + ubicacion)).BorderAround(, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, )
         .Range(h & (2 + ubicacion) & ":I" & (3 + ubicacion)).BorderAround(, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, )
      End With
   End Sub

   'Colocar las cabeceras para los rangos de datos, tipo y tamaño de letra
   Public Sub colocaCabecera(excelApp As Excel.Application, ByVal ubicacion As Integer, _
                             ByVal numCaso As String, ByVal nombreCliente As String, _
                             ByVal observaciones As String, ByVal hojaActual As String, ByVal noHojas As Integer, _
                             ByVal nombreEnfermedad As String, ByVal fechaElaboracion As String, _
                             ByVal mensajeEspecial As String, enfermedadAbreviada As String)
      Dim a As String = "A"
      Dim b As String = "B"
      Dim f As String = "F"
      Dim h As String = "H"
      Dim i As String = "I"
      With excelApp
         .Range(b & (2 + ubicacion)).Value2 = nombreCliente
         .Range(i & (2 + ubicacion)).Value2 = numCaso
         .Range(a & (3 + ubicacion)).Value2 = LCase(observaciones)
         .Range(h & (1 + ubicacion)).NumberFormat = "@"
         .Range(h & (1 + ubicacion)).Value2 = hojaActual
         .Range(i & (1 + ubicacion)).Value2 = noHojas.ToString
         .Range(a & (7 + ubicacion)).Value2 = nombreEnfermedad
         .Range(f & (7 + ubicacion)).Value2 += Format(CDate(fechaElaboracion), "dd MMM yyyy")
         .Range(a & (12 + ubicacion)).Value2 = mensajeEspecial
         .Range(a & (12 + ubicacion)).Font.FontStyle = "Normal"
         .Range(a & (12 + ubicacion)).Font.Size = 8
         .Range(b & (12 + ubicacion)).Value2 = enfermedadAbreviada
         .Range(b & (12 + ubicacion)).Font.FontStyle = "Bold"
         .Range(b & (12 + ubicacion)).Font.Size = 9
      End With
   End Sub

   'Inserta en el archivo de excel el valor de los titulos resultantes
   Public Sub insertaValoresTitulos(ByVal excelApp As Excel.Application, ByVal titulosObtenidos As String, _
                                    ByRef cuentaNoDatos As Integer, ByVal ubicacion As Integer, ByRef siguienteRenglon As Integer)
      'La cadena recibida con todos los titulos los manipula separandolos por el retorno de carro entre ellos
      'Lo asigna a la cadena tabla
      Dim k As Integer = 1
      Dim sueros As String = "A"
      Dim titulos As String = "B"
      Dim temp As Integer = 1
      Dim l As Integer = 14 + ubicacion
      Dim cadena1 As String
      Dim tabla1() As String
      cadena1 = titulosObtenidos
      tabla1 = Split(cadena1, vbCrLf)

      'Si los valores son menores o iguales a 31 muestras hace dos culumnas, listando de 20 en 20 los títulos.
      If cuentaNoDatos <= 31 Then
         For i = 0 To cuentaNoDatos - 1
            excelApp.Range(sueros & l).Value2 = k
            excelApp.Range(sueros & l).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            excelApp.Range(titulos & l).Value2 = Math.Round(CDec(tabla1(i)))
            excelApp.Range(titulos & l).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            k += 1
            l += 1
            If (k = 21) Or (k = 41) Or (k = 61) Or (k = 81) Then
               l = 13 + ubicacion
               If (k = 21) Then
                  sueros = "C"
                  titulos = "D"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               If (k = 41) Then
                  sueros = "E"
                  titulos = "F"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               If (k = 61) Then
                  sueros = "G"
                  titulos = "H"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               If (k = 81) Then
                  sueros = "I"
                  titulos = "J"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               l = 14 + ubicacion
            End If
         Next
      Else
         'si las muestras son mas de 31 cambia de columna hasta 90 títulos.
         For i = 0 To cuentaNoDatos - 1
            excelApp.Range(sueros & l).Value2 = k
            excelApp.Range(sueros & l).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            excelApp.Range(titulos & l).Value2 = Math.Round(CDec(tabla1(i)))
            excelApp.Range(titulos & l).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            k += 1
            l += 1
            If (k = 32) Or (k = 63) Or (k = 92) Then
               l = 13 + ubicacion
               If (k = 32) Then
                  sueros = "C"
                  titulos = "D"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               If (k = 63) Then
                  sueros = "E"
                  titulos = "F"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               If (k = 92) Then
                  sueros = "G"
                  titulos = "H"
                  excelApp.Range(sueros & l).Value2 = "Sueros"
                  excelApp.Range(titulos & l).Value2 = "Títulos"
               End If
               l = 14 + ubicacion
            End If
         Next
      End If
      If cuentaNoDatos >= 21 Then
         siguienteRenglon = 14 + ubicacion + 20
         Console.WriteLine("valor de siguiente en IF renglon en calcula titulos: " & siguienteRenglon.ToString())
      Else
         siguienteRenglon = 14 + ubicacion + cuentaNoDatos
         Console.WriteLine("valor de siguiente renglon en ELSE en calcula titulos: " & siguienteRenglon.ToString())
      End If
   End Sub

   'Inserta la gráfica en el archivo Excel en el rango de E15 del archivo de excel.
   Public Sub insertaGrafica(ByVal excelApp As Excel.Application, ByVal nombreArchivoGrafica As String, _
                             ByVal celdas As String, ByVal nombre As String)
      Dim obj As Object
      With excelApp.Range(celdas)
         .Activate()
         .Select()
         'obj = excelApp.ActiveSheet.Pictures.Insert(nombreArchivoGrafica)
         obj = excelApp.ActiveSheet.Shapes.AddPicture(nombreArchivoGrafica, True, True, .Left, .Top, 200, 130)
         With obj
            '.Left = .Left
            .Name = nombre
            '.Top = .Top
            '.Width = 200
            '.Height = 130
         End With
      End With
   End Sub

   'Public Function insertaGrafica(excelApp As Excel.Application, ByVal nombreArchivoGrafica As String, ByVal celdas As Integer) As Object
   '   Dim obj As Object
   '   obj = excelApp.ActiveSheet.Shapes.AddPicture(nombreArchivoGrafica, False, True, 250, celdas, 220, 150)
   '   Return obj
   'End Function

   'Agrega un cuadrito sobre la grafica
   Public Sub agregaCuadrito(ByVal excelApp As Excel.Application, ByVal rango As String, ByVal valorFormula As String, _
                             ByVal tipo As String, ByVal tamano As Integer, ByVal nombreCuadro As String)
      'DEFINIDO PARA AGREGAR UN CUADRITO DE TEXTO INDICANDO EL NOMBRE DE LA ENFERMEDAD ABREVIADO
      Dim nomenf As Excel.Shape
      With excelApp.Range(rango)
         nomenf = excelApp.ActiveSheet.Shapes.AddTextbox( _
             Orientation:=Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, _
             Left:=.Left, Top:=.Top, _
             Width:=80, Height:=20)
      End With
      'Quita el borde del cuadro de texto y lo trae al frente de la gráfica.
      nomenf.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse
      nomenf.ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront)

      With nomenf.DrawingObject
         'Coloca el nombre del cuadrito, si cambia B12, cambia el titulo escrito dentro de él.
         .Formula = valorFormula
         .Name = nombreCuadro

         With .Font
            .Name = "Arial"
            .FontStyle = tipo
            .Size = tamano
            .Strikethrough = False
            .Superscript = False
            .Subscript = False
            .OutlineFont = False
            .Shadow = False
         End With
      End With
   End Sub

   Public Sub escribeValoresEstadistica(ByVal excelApp As Excel.Application, ByVal ubicacion As Integer, _
                                        ByRef cuentaNoDatos As Integer, ByRef mediaAritmetica As Double, _
                                        ByRef mediaGeometrica As Double, ByRef coeficienteDeVariacionDatosNoAgrupados As Double, _
                                        ByVal fechaElaboracion As String, ByVal siguienteRenglon As Integer)
      Dim postit As Integer = 0
      Dim posvalor As Integer = 0
      Dim posmensaje As Integer = 48
      Dim posfecha As Integer = 50
      Dim posubicacion As Integer = 0

      If cuentaNoDatos <= 31 Then
         postit = siguienteRenglon
         posvalor = siguienteRenglon + 1
         posubicacion = 0
      Else
         postit = 45
         posvalor = 46
         posubicacion = ubicacion
      End If

      Console.WriteLine("------------------------------------------------")
      Console.WriteLine("Valor de cuentanodatos: " & cuentaNoDatos.ToString())
      Console.WriteLine("Valor de ubicacion: " & ubicacion.ToString())
      Console.WriteLine("Valor de postit (sig renglon): " & siguienteRenglon.ToString() & " + ubicacion: " & CStr(postit + posubicacion))
      Console.WriteLine("Valor de posvalor (sig renglon): " & CStr(siguienteRenglon + 1) & " + ubicacion: " & CStr(posvalor + posubicacion))
      Console.WriteLine("------------------------------------------------")
      'coloca los valores de la estadística al finalizar el valor de los sueros.
      With excelApp
         .Range("A" & postit + posubicacion).Value2 = "No. Sueros"
         .Range("B" & postit + posubicacion).Value2 = "Med. Arit."
         .Range("C" & postit + posubicacion).Value2 = "Med. Geom."
         .Range("D" & postit + posubicacion).Value2 = "Coef.Var.%"
         .Range("A" & posvalor + posubicacion).Value2 = cuentaNoDatos
         .Range("A" & posvalor + posubicacion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
         .Range("B" & posvalor + posubicacion).Value2 = Math.Round(mediaAritmetica)
         .Range("B" & posvalor + posubicacion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
         .Range("C" & posvalor + posubicacion).Value2 = Math.Round(mediaGeometrica)
         .Range("C" & posvalor + posubicacion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
         .Range("D" & posvalor + posubicacion).Value2 = Math.Round(coeficienteDeVariacionDatosNoAgrupados)
         .Range("D" & posvalor + posubicacion).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
         posubicacion = ubicacion
         .Range("A" & (posmensaje + posubicacion)).Value2 = "* Numeración arbitraria"
         .Range("B" & (posfecha + posubicacion)).Value2 = Format(CDate(fechaElaboracion), "dd-MMM-yyyy")
         .Range("B" & (posfecha + posubicacion)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
      End With
   End Sub


   'Guarda los resultados de los casos en excel.
   Public Sub guardarResultadosExcel(ByVal numCaso As String, ByVal noSubcaso As Integer, _
                                     ByVal consecutivo As Integer, ByVal analisis As String, _
                                     ByVal fechaElaboracion As String, ByVal nombreCliente As String, _
                                     ByVal nombreEnfermedad As String, _
                                     ByVal observaciones As String, ByVal nombrelibro As String, _
                                     ByVal mensajeEspecial As String, enfermedadAbreviada As String, _
                                     ByVal titulosObtenidos As String, _
                                     ByRef mediaAritmetica As Double, ByRef mediaGeometrica As Double, _
                                     ByRef cuentaNoDatos As Integer, ByRef desviacionEstandarDatosNoAgrupados As Double, _
                                     ByRef coeficienteDeVariacionDatosNoAgrupados As Double, _
                                     ByRef calculaVarianzaDatosNoAgrupados As Double, _
                                     ByVal nombreArchivoGrafica As String)

      'PAra formatear la salida de datos en excel de resultados
      Dim k As Integer = 1
      Dim sueros As String = "A"
      Dim titulos As String = "B"
      Dim siguienteRenglon As Integer = 0
      Dim hojaActual As String = ""
      Dim noHojas As Integer = 0
      'Para buscar el archivo en el sistema
      Dim nombreArchivoResultado As String = ""
      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      'Sirve para controlar el ciclo for
      Dim i As Integer = 0
      Dim ubicacion As Integer = 0
      Dim celdas As String = ""
      Dim letra As String = "F"
      'Para colocar la imagen, DESCOMENTAR SI SE REQUIERE EN LA CELDA E O F. A GUSTO DEL USUARIO.
      'If cuentaNoDatos <= 31 Then
      '   letra = "E"
      'Else
      '   letra = "F"
      'End If
      If consecutivo <= 1 Then
         ubicacion = 0
         celdas = letra & "13"
      Else
         ubicacion = (consecutivo - 1) * 53
         celdas = letra & (13 + ((consecutivo - 1) * 53))
      End If

      Dim rangoCuadro1 As String = "G" & CStr(17 + ubicacion) & ":H" & CStr(17 + ubicacion)
      Dim rangoCuadro2 As String = "H" & (17 + ubicacion) & ":I" & (17 + ubicacion)
      Dim valorFormula1 As String = "=$B" & (12 + ubicacion)
      Dim valorFormula2 As String = "=$A" & (12 + ubicacion)
      nombreArchivoResultado = rutaResutados & numCaso & "-" & analisis & ".xls"

      'Valida si el consecutivo= 0, entonces es el único archivo que se va a generar de resultados
      'el nombre se botiene con No.Caso-Analisis.xls

      If verificarSiExisteArchivo(nombreArchivoResultado) Then
         excelApp.Visible = False
         excelApp.Workbooks.Open(nombreArchivoResultado, False)
         hojaActual = consecutivo.ToString() & "/"
         noHojas = noSubcaso.ToString()


         'Verifica que al reescribir el archivo se borren todas las imágenes y cuadros de texto existentes.
         Dim figura As Excel.Shape
         For Each figura In excelApp.ActiveSheet.Shapes
            If (figura.Name = "Imagen" & consecutivo.ToString()) Or (figura.Name = "Enfermedad" & consecutivo.ToString()) Or _
               (figura.Name = "Mensaje" & consecutivo.ToString()) Then
               Console.WriteLine("Eliminando figura: " & figura.Name)
               figura.Delete()
            End If
         Next

      Else
         If consecutivo <= 1 Then
            If consecutivo = 0 And noSubcaso = 0 Then
               hojaActual = "1 /"
               noHojas = 1
            Else
               hojaActual = consecutivo.ToString() & "/"
               noHojas = noSubcaso
            End If
            'No hace visible el excel en pantalla, crea el workbook y da nombre la primer hoja activa del libro de trabajo.
            excelApp.Visible = False
            libroExcel = excelApp.Workbooks.Add()
            excelApp.ActiveSheet.Name = nombrelibro
            'Define los márgenes de la hoja de excel
            defineMargenesExcel(excelApp, nombrelibro)
         End If

      End If
      'Define el tipo de letra que se utilizara para el reporte.
      defineTipoDeLetra(excelApp, ubicacion)

      'Define cabeceras y bordes de la hoja de excel.
      defineTitulos(excelApp, ubicacion)
      defineBordes(excelApp, ubicacion)

      'Colocar las cabeceras para los rangos de datos, tipo y tamaño de letra
      colocaCabecera(excelApp, ubicacion, numCaso, nombreCliente, observaciones, _
                     hojaActual, noHojas, nombreEnfermedad, fechaElaboracion, mensajeEspecial, enfermedadAbreviada)
      'Colocar los valores de los títulos o
      insertaValoresTitulos(excelApp, titulosObtenidos, cuentaNoDatos, ubicacion, siguienteRenglon)

      'Inserta la gráfica.
      insertaGrafica(excelApp, nombreArchivoGrafica, celdas, "Imagen" & consecutivo.ToString())

      'Agrega los cuadritos sobre la gráfica.

      agregaCuadrito(excelApp, rangoCuadro1, valorFormula1, "Bold", 9, "Enfermedad" & consecutivo.ToString())
      agregaCuadrito(excelApp, rangoCuadro2, valorFormula2, "Normal", 8, "Mensaje" & consecutivo.ToString())

      'Escribe los valores de la estadística en la hoja de acuerdo al número de datos existentes.
      escribeValoresEstadistica(excelApp, ubicacion, cuentaNoDatos, mediaAritmetica, mediaGeometrica, _
                                coeficienteDeVariacionDatosNoAgrupados, fechaElaboracion, siguienteRenglon)

      'Si el consecutivo es menor o igual que 1, entonces guarda el archivo con el nombre indicado. De solo lectura.
      If consecutivo <= 1 Then
         With excelApp
            excelApp.DisplayAlerts = False
            .ActiveWorkbook.SaveAs(nombreArchivoResultado, True)
            excelApp.DisplayAlerts = True
            .ActiveWorkbook.Close()
            .Quit()
         End With
      Else
         With excelApp
            .ActiveWorkbook.Save()
            .ActiveWorkbook.Close()
            .Quit()
         End With
      End If
      'releaseObject(objeto)
      releaseObject(excelApp)
   End Sub

   'PUEDE BORRARSE DESPUES DE LA PRUEBA DEL LECTOR. 01/OCT/2012
   ''Procedimiento que sirve para generar el archivo de excel con los resultados del análisis y su gráfica
   'Public Sub guardaResultadosExcel(ByVal numCaso As String, ByVal consecutivo As Integer, ByVal analisis As String, ByVal fechaElaboracion As String, ByVal nombreCliente As String, ByVal nombreEnfermedad As String, _
   '                                 ByVal observaciones As String, ByVal nombrelibro As String, _
   '                                 ByVal mensajeEspecial As String, enfermedadAbreviada As String, _
   '                                 ByVal titulosObtenidos As String, _
   '                                 ByRef mediaAritmetica As Double, ByRef mediaGeometrica As Double, _
   '                                 ByRef cuentaNoDatos As Integer, ByRef desviacionEstandarDatosNoAgrupados As Double, _
   '                                 ByRef coeficienteDeVariacionDatosNoAgrupados As Double, ByRef calculaVarianzaDatosNoAgrupados As Double)

   '   'PAra formatear la salida de datos en excel de resultados
   '   Dim k As Integer = 1
   '   Dim sueros As String = "A"
   '   Dim titulos As String = "B"
   '   Dim temp As Integer = 1
   '   Dim l As Integer = 14


   '   Dim excelApp As New Excel.Application
   '   Dim libroExcel As Excel.Workbook
   '   'Sirve para controlar el ciclo for
   '   Dim i As Integer = 0

   '   'Mostrar Excel en pantalla y crea el workbook
   '   excelApp.Visible = False
   '   libroExcel = excelApp.Workbooks.Add()

   '   'Darle nombre la primer hoja activa del libro de trabajo
   '   excelApp.ActiveSheet.Name = nombrelibro

   '   'Predefinir márgenes para la hoja de excel, los valores se deben colocar en pulgadas, por lo que se divide el cms entre 2.54
   '   With excelApp.ActiveSheet.PageSetup
   '      .LeftMargin = .Application.InchesToPoints(0.27559055118110237)
   '      .RightMargin = .Application.InchesToPoints(0.27559055118110237)
   '      .TopMargin = .Application.InchesToPoints(1.1023622047244095)
   '      .BottomMargin = .Application.InchesToPoints(0.62992125984251968)
   '      '.HeaderMargin = .Application.InchesToPoints(0.196850393700787)
   '      '.FooterMargin = .Application.InchesToPoints(0.196850393700787)
   '   End With


   '   'Colocar las cabeceras para los rangos de datos, tipo y tamaño de letra
   '   With excelApp
   '      .Range("A2").Font.Bold = True
   '      .Range("H2").Font.Bold = True
   '      .Range("B2:G2").MergeCells = True
   '      .Range("A3:I3").MergeCells = True
   '      .Range("A1:I11").Font.Name = "Century Gothic"
   '      .Range("A1:I11").Font.Size = 10
   '      .Range("A12").Font.Name = "Arial"
   '      .Range("A12").Font.Size = 8
   '      .Range("B12").Font.Name = "Arial"
   '      .Range("B12").Font.Size = 9
   '      .Range("A13:D35").Font.Name = "Arial"
   '      .Range("A13:D35").Font.Size = 9
   '      .Range("A34:D35").Font.Name = "Arial"
   '      .Range("A34:D35").Font.Size = 9
   '      .Range("A39").Font.Name = "Arial"
   '      .Range("A39").Font.Size = 9
   '      .Range("B43").Font.Name = "Century Gothic"
   '      .Range("B43").Font.Size = 10
   '      'Coloca los valores de los campos
   '      .Range("F1").Value2 = "Resultados de Serología"
   '      .Range("A2").Value2 = "Cliente:  "
   '      .Range("B2").Value2 = nombreCliente
   '      .Range("H2").Value2 = "No. Caso: "
   '      .Range("I2").Value2 = numCaso
   '      .Range("A3").Value2 = LCase(observaciones)

   '      'Colocar los bordes externos a las celdas para el reporte.
   '      .Range("A2:I3").BorderAround(, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, )
   '      .Range("H2:I3").BorderAround(, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, )
   '   End With
   '   'Colocar los datos relacionados a la fecha y el análisis realizado.
   '   With excelApp
   '      .Range("A5").Value2 = "ELISA: INMUNOENSAYO ENZIMÁTICO"
   '      .Range("A7").Value2 = nombreEnfermedad
   '      .Range("F7").Value2 = "Fecha del análisis:  " & Format(CDate(fechaElaboracion), "dd MMM yyyy")
   '      .Range("A12").Value2 = mensajeEspecial
   '      .Range("B12").Value2 = enfermedadAbreviada

   '      'Esta funcion se utiliza para mandar a impresión el reporte, no usada en ésta versión.
   '      'excelApp.ActiveSheet.PrintOut()

   '      'copia los valores de los títulos resultantes
   '      .Range("A13").Value2 = "Sueros*"
   '      .Range("B13").Value2 = "Títulos"
   '   End With
   '   'La cadena recibida con todos los titulos los manipula separandolos por el retorno de carro entre ellos
   '   'Lo asigna a la cadena tabla
   '   Dim cadena1 As String
   '   Dim tabla1() As String
   '   cadena1 = titulosObtenidos
   '   tabla1 = Split(cadena1, vbCrLf)

   '   For i = 0 To cuentaNoDatos - 1
   '      excelApp.Range(sueros & l).Value2 = k
   '      excelApp.Range(titulos & l).Value2 = Math.Round(CDec(tabla1(i)))
   '      k += 1
   '      l += 1
   '      If (k = 21) Or (k = 41) Or (k = 61) Or (k = 81) Then
   '         l = 13
   '         If (k = 21) Then
   '            sueros = "C"
   '            titulos = "D"
   '            excelApp.Range(sueros & l).Value2 = "Sueros"
   '            excelApp.Range(titulos & l).Value2 = "Títulos"
   '         End If
   '         If (k = 41) Then
   '            sueros = "E"
   '            titulos = "F"
   '            excelApp.Range(sueros & l).Value2 = "Sueros"
   '            excelApp.Range(titulos & l).Value2 = "Títulos"
   '         End If
   '         If (k = 61) Then
   '            sueros = "G"
   '            titulos = "H"
   '            excelApp.Range(sueros & l).Value2 = "Sueros"
   '            excelApp.Range(titulos & l).Value2 = "Títulos"
   '         End If
   '         If (k = 81) Then
   '            sueros = "I"
   '            titulos = "J"
   '            excelApp.Range(sueros & l).Value2 = "Sueros"
   '            excelApp.Range(titulos & l).Value2 = "Títulos"
   '         End If
   '         l = 14
   '      End If
   '      If (i = 0) Then
   '         temp = 0
   '      End If
   '   Next
   '   'Try
   '   'Inserta la gráfica en el archivo Excel en el rango de E15 del archivo de excel.
   '   Dim strCelda As String = "E15"
   '   Dim nombreArchivo = rutaImagen & numCaso & "-" & consecutivo & "-" & analisis & ".gif"
   '   excelApp.ActiveSheet.Shapes.AddPicture(nombreArchivo, False, True, 250, 200, 220, 150)
   '   'Catch ex As Exception
   '   '   mensajeException(frmSalidaDatos.lblSalidaDatos, ex)
   '   'End Try

   '   'DEFINIDO PARA AGREGAR UN CUADRITO DE TEXTO INDICANDO EL NOMBRE DE LA ENFERMEDAD ABREVIADO
   '   Dim nomenf As Excel.Shape
   '   With excelApp.Range("F17:G17")
   '      nomenf = excelApp.ActiveSheet.Shapes.AddTextbox( _
   '          Orientation:=Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, _
   '          Left:=.Left, Top:=.Top, _
   '          Width:=80, Height:=20)
   '   End With
   '   'Quita el borde del cuadro de texto y lo trae al frente de la gráfica.
   '   nomenf.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse
   '   nomenf.ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront)

   '   With nomenf.DrawingObject
   '      '.Characters.Text = excelApp.Range("B12").Value2
   '      'Coloca el nombre del cuadrito, si cambia B12, cambia el titulo escrito dentro de él.
   '      .Formula = "=$B12"
   '      With .Font
   '         .Name = "Arial"
   '         .FontStyle = "Bold"
   '         .Size = 9
   '         .Strikethrough = False
   '         .Superscript = False
   '         .Subscript = False
   '         .OutlineFont = False
   '         .Shadow = False
   '      End With
   '   End With


   '   'DEFINIDO PARA AGREGAR UN CUADRITO DE TEXTO SOBRE LA GRAFICA IMAGEN
   '   Dim tbox As Excel.Shape
   '   With excelApp.Range("G17:H17")
   '      tbox = excelApp.ActiveSheet.Shapes.AddTextbox( _
   '          Orientation:=Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal, _
   '          Left:=.Left, Top:=.Top, _
   '          Width:=80, Height:=20)
   '   End With

   '   'Quita el borde del cuadro de texto y lo trae al frente del la grafica.
   '   tbox.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse
   '   tbox.ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront)


   '   With tbox.DrawingObject
   '      '.Characters.Text = excelApp.Range("A12").Value2
   '      'Coloca el nombre del cuadrito, si cambia A12, cambia el titulo escrito dentro de él.
   '      .Formula = "=$A12"

   '      With .Font
   '         .Name = "Arial"
   '         .FontStyle = "Regular"
   '         .Size = 8
   '         .Strikethrough = False
   '         .Superscript = False
   '         .Subscript = False
   '         .OutlineFont = False
   '         .Shadow = False
   '      End With
   '   End With

   '   'coloca los valores de la estadística al finalizar el valor de los sueros.
   '   With excelApp
   '      .Range("A34").Value2 = "No. Sueros"
   '      .Range("B34").Value2 = "Media Arit."
   '      .Range("C34").Value2 = "Med. Geom."
   '      .Range("D34").Value2 = "Coef.Var."
   '      .Range("A35").Value2 = cuentaNoDatos
   '      .Range("B35").Value2 = Math.Round(mediaAritmetica)
   '      .Range("C35").Value2 = Math.Round(mediaGeometrica)
   '      .Range("D35").Value2 = Math.Round(coeficienteDeVariacionDatosNoAgrupados)
   '      .Range("A39").Value2 = "* Numeración arbitraria"
   '      .Range("B43").Value2 = Format(CDate(fechaElaboracion), "dd-MMM-yyyy")
   '   End With
   '   'Salva el archivo de placa original leida con el nombre del caso
   '   Dim nombreArchivoResultado As String = rutaResutados & numCaso & "-" & analisis & ".xls"
   '   With excelApp
   '      .ActiveWorkbook.SaveAs(nombreArchivoResultado)
   '      .ActiveWorkbook.Close()
   '      .Quit()
   '   End With
   '   releaseObject(excelApp)
   'End Sub

   '##################################################################
   '#SECCION PARA ABRIR DATOS EXISTENTES DESDE UN ARCHIVO DE EXCEL   #
   '##################################################################
   'Se utiliza abrir un archivo existente de excel donde se encuentran grabados datos 
   'de una placa leida previamente

   Public Sub abreArchivoExcel(ByRef dialogo As System.Windows.Forms.OpenFileDialog, _
                               ByRef etiqueta As ToolStripLabel, ByRef boton1 As System.Windows.Forms.Button, _
                               ByRef boton2 As System.Windows.Forms.Button, ByVal placaLector(,) As Decimal, _
                               ByRef txtCPDAValor1 As TextBox, ByRef txtCPDAValor2 As TextBox, _
                               ByRef txtCPDAValor3 As TextBox, ByRef txtCNDAValor1 As TextBox,
                               ByRef txtCNDAValor2 As TextBox, ByRef txtCNDAValor3 As TextBox)
      'Define variables para archivo de excel
      Dim excelApp As New Excel.Application
      'Dim libroExcel As Excel.Workbook
      Dim hojaExcel As Excel.Worksheet
      'Variables para nombre del archivo
      Dim rutaArchivo As String = ""
      Dim nombreArchivo As String = ""
      'Variables para manipular x,y y asignar los valores a la placa que se tomara como leida
      Dim i As Integer = 0
      Dim j As Integer = 0
      'Leer la columna donde se encuentra
      Dim columna As String = ""
      Dim resultado As String = ""
      Dim temporal As String = ""
      Try
         dialogo.Title = "Seleccione el archivo con datos de placa"
         ' Show the open file dialog box.
         If dialogo.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            'dialogo.InitialDirectory = Environment.GetFolderPath(rutaPlacas)
            ' Show the name of the file in the statusbar.
         End If
         rutaArchivo = dialogo.FileName
         nombreArchivo = Mid(rutaArchivo, InStrRev(rutaArchivo, "\"))

         excelApp.Workbooks.Open(rutaArchivo)
         hojaExcel = excelApp.Worksheets(1)
         excelApp.Visible = False
         Try
            For i = 0 To 7
               columna = obtenLetra(i)
               For j = 0 To 11
                  temporal = Replace(hojaExcel.Range(columna & (j + 1)).Value2, "\", "")
                  If (temporal <> "") Then
                     placaLector(i, j) = CDec(temporal)
                  Else
                     placaLector(i, j) = 0
                  End If
                  resultado &= CStr(placaLector(i, j)) & vbTab
               Next
               resultado &= vbCrLf
            Next

         Catch ex As Exception
            mensajeVerde(etiqueta, "ERROR:" & ex.Message & " " & ex.GetType.ToString)
            boton1.Enabled = True
            boton2.Enabled = False
         End Try
         mensajeVerde(etiqueta, "Nombre del archivo abierto: " & nombreArchivo)
         mensajeVerde(etiqueta, "Nombre del archivo abierto: " & rutaPlacas)
         'frmAbrirArchivoExistente.txtPlacaDesdeArchivo.Text = resultado
         txtCPDAValor1.Text = hojaExcel.Range("B16").Value2
         txtCPDAValor2.Text = hojaExcel.Range("B17").Value2
         txtCPDAValor3.Text = hojaExcel.Range("B18").Value2
         txtCNDAValor1.Text = hojaExcel.Range("C16").Value2
         txtCNDAValor2.Text = hojaExcel.Range("C17").Value2
         txtCNDAValor3.Text = hojaExcel.Range("C18").Value2
         'Esta instruccion es para Excel 2010, no borrar.
         'excelApp.ActiveWorkbook.Close()
         excelApp.ActiveWorkbook.Close(False)
         'Libera la aplicacion Excel
         releaseObject(excelApp)
         boton1.Enabled = False
         boton2.Enabled = True
      Catch ex As FormatException
         mensajeException(etiqueta, ex)
         boton1.Enabled = True
         boton2.Enabled = False
      Catch ex As Exception
         mensajeException(etiqueta, ex)
         boton1.Enabled = True
         boton2.Enabled = False
      End Try

   End Sub

   '#################################################
   '#CREA GRAFICA DE BARRAS UTILIZANDO EXCEL        #
   '#################################################
   'utiliza excel para crear la grafica de barras y la guarda  como imagen.
   'Public Function creaChartFrecRel(ByRef etiqueta As ToolStripLabel, ByRef control As Control, ByVal frecuenciaRelativa() As Decimal, ByVal rangoDatos() As Integer, _
   Public Function creaChartFrecRel(ByRef etiqueta As ToolStripLabel, ByVal frecuenciaRelativa() As Decimal, ByVal rangoDatos() As Integer, _
                                    ByVal titulox As String, ByVal tituloy As String, ByRef numCaso As String, ByVal consecutivo As Integer, ByVal analisis As String) As String
      'ByVal nombre As String, ByVal titulox As String, ByVal tituloy As String, ByRef numCaso As String, ByVal consecutivo As Integer, ByVal analisis As String) As String
      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      Dim chartFrecRel As Excel.Chart
      Dim graficaFR As Excel.ChartObject
      Dim rangoGrafica As Excel.Range
      Dim etiquetasDeX As Excel.Range
      Dim i As Integer = 0
      Dim j As Integer = 0

      'Mostrar Excel en pantalla
      excelApp.Visible = False
      'Crear el workbook
      libroExcel = excelApp.Workbooks.Add()
      'Darle nombre la primer hoja activa del libro de trabajo
      excelApp.ActiveSheet.Name = "Temporal"


      'Coloca los valores para etiquetas del eje x, valores de la frecuencia relativa y los valores de las 
      'etiquetas para la gráfca.

      For i = 0 To 14
         excelApp.Range("A" & (i + 1)).Value2 = i
         excelApp.Range("B" & (i + 1)).Value2 = frecuenciaRelativa(i)
         excelApp.Range("C" & (i + 1)).Value2 = rangoDatos(i)
      Next

      'Definir el rango de donde se toman las etiquetas del eje x
      etiquetasDeX = excelApp.Range("A1:A15")

      'Asignar ubicacion a la grafica y crear su objeto
      graficaFR = excelApp.ActiveSheet.ChartObjects.Add(200, 50, 300, 200)
      chartFrecRel = graficaFR.Chart

      'Establecer rango que utilizara la grafica con los valores de la frecuencia relativa
      rangoGrafica = excelApp.Range("B1:B15")

      'Asignarle los valores para la creación de la grafica y definicion que de barras
      chartFrecRel.SetSourceData(Source:=rangoGrafica)
      chartFrecRel.ChartType = Excel.XlChartType.xlColumnClustered


      'Le coloca en color rojo las barras de la gráfica, las etiquetas de cada barra de la gráfica con su valor respectivo
      'El tamaño de la etiqueta es de Arial 8 y deshabilitar la leyenda
      With chartFrecRel
         .HasTitle = False

         'Para que la grafica salga sin color al fondo y  borde , exclusivo de excel 2003
         .PlotArea.Interior.ColorIndex = 0
         .PlotArea.Border.Color = 0
         .PlotArea.Border.LineStyle = Excel.XlColorIndex.xlColorIndexNone
         .ChartArea.Border.LineStyle = Excel.XlColorIndex.xlColorIndexNone



         .SeriesCollection(1).Interior.Color = Color.Red
         'Coloca la etiqueta de la serie
         'Con este ciclo se colocan las etiquetas arriba de cada barra
         For i = 1 To 15
            .SeriesCollection(1).Points(i).HasDatalabel = True
            .SeriesCollection(1).Points(i).DataLabel.Font.Size = 8
            .SeriesCollection(1).Points(i).DataLabel.Text = excelApp.Range("C" & i).Value2
         Next

         'Deshabilita el cuadro de leyenda de la serie, se recomienda no tenerlo habilitado para que no aparezca
         'el cuadrito a la derecha de la grafica, el includeInLayout debe descomentarse para que funcione con excel 2010.
         With .Legend
            '.IncludeInLayout = True
            .Delete()
         End With
      End With

      'Cambia la escala de la gráfica por menor 20 y mayor valor 100
      With excelApp.Worksheets("Temporal").ChartObjects(1).Chart.Axes(Excel.XlAxisType.xlValue)
         .MinimumScale = 0
         .MajorUnit = 20
         .MaximumScale = 100
      End With


      'Cambiar el nombre del eje x
      Dim ejex As Excel.Axis = CType(chartFrecRel.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
      With ejex
         .HasTitle = True
         .AxisTitle.Orientation = Excel.XlOrientation.xlHorizontal
         .AxisTitle.Text = tituloy
         .AxisTitle.Font.Bold = True
         .AxisTitle.Font.FontStyle = "Arial"
         .AxisTitle.Font.Size = 9
         .HasMajorGridlines = False
         .CategoryNames = excelApp.Range("A1:A15")
      End With
      'Cambiar el nombre del eje y
      Dim ejey As Excel.Axis = CType(chartFrecRel.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
      With ejey
         .HasTitle = True
         .AxisTitle.Text = titulox
         .AxisTitle.Font.Bold = True
         .AxisTitle.Font.FontStyle = "Arial"
         .AxisTitle.Font.Size = 9
         .HasMajorGridlines = False
      End With

      'Guarda la grafica como archivo y cierra el excel sin salvar la informacion, ya que solamente 
      'requerimos de la imagen guardada en disco
      Dim nombreArchivo = rutaImagen & numCaso & "-" & consecutivo & "-" & analisis & ".gif"

      'Esta instruccion es para excel 2010 NO BORRAR.
      'excelApp.ActiveSheet.ChartObjects(1).chart.Export(FileName:=nombreArchivo, FilterName:="BMP")
      excelApp.ActiveSheet.ChartObjects(1).chart.Export(nombreArchivo, "gif", False)

      'excelApp.ActiveSheet.ChartObjects(1).Delete() para la prueba de liberar el objeto


      'Cierra el libro activo de Excel y Sale sin salvar la hoja de excel actual usando Excel 2010.
      'excelApp.ActiveWorkbook.Close(SaveChanges:=False)
      excelApp.ActiveWorkbook.Close(False)

      'Libera la aplicacion Excel y libera el objeto de la memoria
      excelApp.Quit()
      releaseObject(excelApp)
      Return nombreArchivo
   End Function

   'No borrar, ya que es el ejemplo para hacer la grafica utilizando VB solamente.
   'Public Sub creaChartFrecRel(ByRef etiqueta As Label, ByRef control As Control, ByVal nombre As String, ByVal titulox As String, _
   '                            ByVal tituloy As String, ByRef numCaso As String, ByVal analisis As String)
   '   Dim oConexion As MySqlConnection = New MySqlConnection()
   '   Try

   '      Dim aConsulta As String = ""
   '      Dim oComando As New MySqlCommand
   '      Dim oDataReader As MySqlDataReader
   '      oConexion = New MySqlConnection
   '      oConexion.ConnectionString = cadenaConexion
   '      Dim sqlfrecrel As String = "SELECT rango, valor, cantidad FROM tblfrecrelativa order by rango asc"
   '      oComando.Connection = oConexion
   '      oComando.CommandText = sqlfrecrel
   '      Dim da As New MySqlDataAdapter(sqlfrecrel, oConexion)
   '      Dim ds As New DataSet()
   '      da.Fill(ds, "tblfrecrelativa")
   '      oComando.CommandText = sqlfrecrel
   '      oConexion.Open()
   '      oDataReader = oComando.ExecuteReader()

   '      'Inicializa la informacion relacionada con la grafica para la serie, leyenda, el area del gráfico y el gráfico 
   '      'que se presentan a pantalla
   '      Dim ChartArea1 As ChartArea = New ChartArea()
   '      Dim Legend1 As Legend = New Legend()
   '      Dim Series1 As Series = New Series()
   '      Dim Chart1 = New Chart()

   '      'frmSalidaDatos.Controls.Add(Chart1)
   '      control.Controls.Add(Chart1)

   '      'Define la nueva colección, asigna el nombre del gráfico.
   '      ChartArea1.Name = "ChartArea1"
   '      Chart1.ChartAreas.Add(ChartArea1)
   '      'Chart1.Titles.Add(nombre)

   '      'Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

   '      'Elimina las lineas secundarias del gráfico
   '      With Chart1.ChartAreas("ChartArea1")
   '         .AxisX.MajorGrid.Enabled = False
   '         .AxisY.MajorGrid.Enabled = False
   '      End With

   '      'Descomentar lo relacionado a Legend si se desea que aparezca el cuadrito con el titulo de Series (No recomendado)
   '      'Legend1.Name = "Legend1"
   '      'Chart1.Legends.Add(Legend1)
   '      'Series1.Legend = "Legend1"

   '      'Ubicacion del grafico, tamaño, numero de indice dentro de la forma, su anclaje y agrega el numero de serie
   '      With Chart1
   '         .Name = "Chart1"
   '         .Location = New System.Drawing.Point(38, 110)
   '         .Size = New System.Drawing.Size(525, 245)
   '         .TabIndex = 21
   '         .Anchor = AnchorStyles.Right
   '         .Anchor = AnchorStyles.Top
   '         .Series.Add(Series1)
   '      End With

   '      'Dar nombre a la serie, definir el tipo de serie, en este caso tipo columna
   '      With Series1
   '         .ChartArea = "ChartArea1"
   '         .Name = "Series1"
   '         .ChartType = SeriesChartType.Column
   '         .Color = Color.Red
   '         .CustomProperties = "labelStyle:= Top , Font.Size:= 7"
   '      End With

   '      'Indica los valores de inicio de los ejes, ambos en 0,0, el intervalo de valores para x =15 y y=100, el valor de intervalo en 20
   '      'E indica los nombres de los títulos para x y y
   '      With Chart1.ChartAreas(0)
   '         '.AxisX.LabelStyle.Interval = 1
   '         '.AxisX.LabelAutoFitMaxFontSize = 8
   '         '.AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.VariableCount
   '         .AxisY.Minimum = 0
   '         .AxisY.Maximum = 100
   '         .AxisY.Interval = 20
   '         .AxisX.Title = titulox
   '         .AxisY.Title = tituloy
   '      End With

   '      'Indica que tienen etiquetas las barra, asigna los valores de las series para miembros que se trazan en X y Y y lee del
   '      'data reader los valores de rango, valor y etiqueta
   '      With Chart1.Series(0)
   '         .IsValueShownAsLabel = True
   '         .XValueMember = "rango"
   '         .YValueMembers = "valor"
   '         .CustomProperties = "labelStyle := Top , Font.Size := 7"
   '         .Points.DataBind(oDataReader, "rango", "valor", "Label=cantidad")
   '      End With

   '      'Cerrar la conexion a la base de datos 
   '      oDataReader.Close()
   '      oConexion.Close()
   '      oConexion.Dispose()
   '      'Salvar la imagen a disco, con el número de caso identificándole, con formato jpeg
   '      Try
   '         Dim nombreArchivo = rutaImagen & numCaso & "-" & analisis & ".jpeg"
   '         Chart1.SaveImage(nombreArchivo, System.Drawing.Imaging.ImageFormat.Jpeg)
   '      Catch ex As Exception
   '         mensajeException(etiqueta, ex)
   '      End Try
   '   Catch ex As Exception
   '      mensajeException(etiqueta, ex)
   '      ' MessageBox.Show("Error al intentar la conexion a al BD al momento de crear la grafica.")
   '   End Try
   'End Sub

   '###########################################################
   '#SECCION PARA LIBERAR OBJETOS DE MEMORIA TIPO PROGRAMA    #
   '###########################################################
   'Se utiliza para liberar el excel de la memoria utilizada por el programa
   Public Sub releaseObject(ByVal obj As Object)
      Try
         System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
         obj = Nothing
      Catch ex As Exception
         obj = Nothing
      Finally
         GC.Collect()
      End Try
   End Sub

End Module
