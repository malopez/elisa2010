Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Module mdlOperaciones
   Private Const cadenaConexion = "server=biovetsa.dyndns.org;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"
   '################################
   '# SECCION DE VARIABLES GLOBALES#
   '################################
   'utilizada para almacenar los datos que se reciben por el puerto
   Public az As String
   ' sera utilizada como contador
   'Public sib As Integer = 0 modificado 18-Abril-2012
   'Arreglo que servira de buffer para los datos que van llegando al puerto
   Public msn As String = ""
   'Guarda la placa leida desde el lector debidamente formateada
   Public placaLector(7, 11) As Decimal
   'Guarda los valores de la frecuencia Relativa
   Public frecuenciaRelativa(14) As Decimal
   'Matriz para calculo de Logaritmo de Titulos
   Public calculoDeTitulos(7, 11) As Decimal

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
      'Copia en el Arreglo los valores de datos separados por comas
      a = Split(msn, ",")
      'MessageBox.Show("Llegue al split valor de msn es " & msn & "valor de largo de a: " & a.Length)
      Dim temporal As Decimal
      Dim tmp As String = ""
      For i = 0 To 7
         For j = 0 To 11
            'La funcion val regresa el valor correcto de los datos cuando es numérico, si no es nuérico, entonces coloca un 0.
            temporal = (Val(a(k)) / 1000)
            'MessageBox.Show("Valor del temporal" & temporal)
            If (temporal > 1) Then
               placaLector(i, j) = 0
            Else
               placaLector(i, j) = temporal
            End If
            'MessageBox.Show("Valor de placaLector en " & i & "," & j & ": " & placaLector(i, j))
            k += 1
         Next
      Next
   End Sub

   'Se utiliza para regresar la letra que corresponde a una columna de excel donde se guardaran los datos de la placa original
   Public Function obtenLetra(ByVal i As Integer) As String
      Dim letra As String = ""
      Select Case i
         Case 0
            letra = "A"
         Case 1
            letra = "B"
         Case 2
            letra = "C"
         Case 3
            letra = "D"
         Case 4
            letra = "E"
         Case 5
            letra = "F"
         Case 6
            letra = "G"
         Case 7
            letra = "H"
      End Select
      Return letra
   End Function

   'Procedimiento que sirve para generar el archivo de excel con los resultados del análisis y su gráfica
   Public Sub guardaDatosExcel(ByVal placaLector(,) As Decimal, _
                               ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                               ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                               ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                               ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer)
      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      'Sirve para controlar el ciclo for
      Dim i As Integer = 0
      Dim j As Integer = 0
      'Mostrar Excel en pantalla y crea el workbook
      excelApp.Visible = True
      libroExcel = excelApp.Workbooks.Add()

      'Darle nombre la primer hoja activa del libro de trabajo
      excelApp.ActiveSheet.Name = "PlacaLeida"

      'Agregar datos a la hoja de Excel de la frecuencia relativa
      For i = 0 To 7
         For j = 0 To 11
            'MessageBox.Show("valor de placa lector " & placaLector(i, j))
            excelApp.Range(obtenLetra(i) & (j + 1)).Value2 = placaLector(i, j)
         Next
      Next
      excelApp.Range("A14").Value2 = "Controles Positivos"
      excelApp.Range("A15").Value2 = placaLector(cpx1, cpy1)
      excelApp.Range("A16").Value2 = placaLector(cpx2, cpy2)
      excelApp.Range("A17").Value2 = placaLector(cpx3, cpy3)
      excelApp.Range("B14").Value2 = "Controles Negativos"
      excelApp.Range("B15").Value2 = placaLector(cnx1, cny1)
      excelApp.Range("B16").Value2 = placaLector(cnx2, cny2)
      excelApp.Range("B17").Value2 = placaLector(cnx3, cny3)
      'Cierra el libro activo de Excel
      excelApp.ActiveWorkbook.Close()
      'Libera la aplicacion Excel
      releaseObject(excelApp)
   End Sub

   'Procedimiento que sirve para generar el archivo de excel con los resultados del análisis y su gráfica
   Public Sub guardaResultadosExcel(ByVal frecuenciaRelativa() As Decimal, ByVal calculoDeTitulos(,) As Decimal, ByVal nombrelibro As String, ByVal nombre As String, _
                                    ByRef calculaMedia As Decimal, ByRef mediaAritmetica As Decimal, ByRef mediaGeometrica As Decimal, _
                                    ByRef coeficienteDeVariacion As Decimal, ByRef desviacionEstandar As Decimal, ByRef calculaVarianza As Decimal, _
                                    ByRef cuentaNoDatos As Decimal, ByRef desviacionEstandarDatosNoAgrupados As Decimal, _
                                    ByRef coeficienteDeVariacionDatosNoAgrupados As Decimal, ByRef calculaVarianzaDatosNoAgrupados As Decimal)

      'PAra formatear la salida de datos en excel de resultados
      Dim k As Integer = 1
      Dim sueros As String = "A"
      Dim titulos As String = "B"
      Dim temp As Integer = 1
      Dim l As Integer = 18

      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      'Sirve para controlar el ciclo for
      Dim i As Integer = 0
      'Mostrar Excel en pantalla y crea el workbook
      excelApp.Visible = True
      libroExcel = excelApp.Workbooks.Add()

      'Darle nombre la primer hoja activa del libro de trabajo
      excelApp.ActiveSheet.Name = nombrelibro
      'Agregar datos a la hoja de Excel de la frecuencia relativa
      For i = 2 To 16
         excelApp.Range("A" & i).Value2 = i - 1
         excelApp.Range("B" & i).Value2 = Math.Round(frecuenciaRelativa(i - 2), 2)
      Next

      'Colocar las cabeceras para los rangos de datos
      excelApp.Range("A1").Value2 = "Grupo de Títulos"
      excelApp.Range("B1").Value2 = "Porcentaje"
      excelApp.Range("C1").Value2 = "Media"
      excelApp.Range("C2").Value2 = mediaAritmetica
      excelApp.Range("D1").Value2 = "Media Geométrica"
      excelApp.Range("D2").Value2 = mediaGeometrica
      excelApp.Range("E1").Value2 = "Desv. Estándar"
      excelApp.Range("E2").Value2 = desviacionEstandarDatosNoAgrupados
      excelApp.Range("F1").Value2 = "Coef. Variación"
      excelApp.Range("F2").Value2 = coeficienteDeVariacionDatosNoAgrupados

      'Crear grafica para la frecuencia relativa
      Dim chartFrecRel As Excel.Chart
      Dim graficaFR As Excel.ChartObject
      Dim rangoGrafica As Excel.Range
      Dim j As Integer = 1
      'Asignar ubicacion a la grafica
      graficaFR = excelApp.ActiveSheet.ChartObjects.Add(400, 50, 500, 150)
      chartFrecRel = graficaFR.Chart
      'Establecer rango que utilizara la frafica
      rangoGrafica = excelApp.Range("B1", "B16")
      chartFrecRel.SetSourceData(Source:=rangoGrafica)
      'Tipo de gráfica: barras
      chartFrecRel.ChartType = Excel.XlChartType.xlColumnClustered
      'Cambia el titulo a la grafica
      With chartFrecRel
         .HasTitle = True
         .ChartTitle.Text = nombre
         'Coloca la etiqueta de la serie
         i = 1
         For j = 1 To 15
            .SeriesCollection(i).Points(j).HasDatalabel = True
         Next
         'Deshabilita el cuadro de leyenda de la serie
         With .Legend
            .IncludeInLayout = True
            .Delete()
         End With
      End With

      'Cambiar el nombre del eje x
      Dim ejex As Excel.Axis = CType(chartFrecRel.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
      ejex.HasTitle = True
      ejex.AxisTitle.Text = "Porcentaje"
      ejex.AxisTitle.Font.Bold = True
      ejex.AxisTitle.Font.Size = 8
      'Cambiar el nombre del eje y
      Dim ejey As Excel.Axis = CType(chartFrecRel.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary), Excel.Axis)
      ejey.HasTitle = True
      ejey.AxisTitle.Text = "Grupo de Títulos"
      ejey.AxisTitle.Font.Bold = True
      ejey.AxisTitle.Font.Size = 8

      'copia los valores de los títulos resultantes
      excelApp.Range("A17").Value2 = "Sueros"
      excelApp.Range("B17").Value2 = "Títulos"

      For i = 0 To 7
         For j = temp To 11
            excelApp.Range(sueros & l).Value2 = k
            excelApp.Range(titulos & l).Value2 = Math.Round(calculoDeTitulos(i, j))
            k += 1
            l += 1
            If (k = 21) Or (k = 41) Or (k = 61) Or (k = 81) Then
               l = 17
               If (k = 21) Then
                  sueros = "C"
                  titulos = "D"
               End If
               If (k = 41) Then
                  sueros = "E"
                  titulos = "F"
               End If
               If (k = 61) Then
                  sueros = "G"
                  titulos = "H"
               End If
               If (k = 81) Then
                  sueros = "I"
                  titulos = "J"
               End If
               excelApp.Range(sueros & l).Value2 = "Sueros"
               excelApp.Range(titulos & l).Value2 = "Títulos"
               l = 18
            End If
            If (i = 0) Then
               temp = 0
            End If
         Next
      Next
      excelApp.ActiveWorkbook.Close()
      'Libera la aplicacion Excel
      releaseObject(excelApp)
   End Sub

   '##################################################################
   '#SECCION PARA ABRIR DATOS EXISTENTES DESDE UN ARCHIVO DE EXCEL   #
   '##################################################################
   'Se utiliza abrir un archivo existente de excel donde se encuentran grabados datos 
   'de una placa leida previamente
   Public Sub abreArchivoExcel(ByVal placaLector(,) As Decimal)
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
         frmAbrirArchivoExistente.ofdSelArchivo.Title = "Seleccione el archivo de datos"
         ' Show the open file dialog box.
         If frmAbrirArchivoExistente.ofdSelArchivo.ShowDialog = DialogResult.OK Then
            ' Load the picture into the picture box.
            frmAbrirArchivoExistente.ofdSelArchivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            ' Show the name of the file in the statusbar.
         End If
         rutaArchivo = frmAbrirArchivoExistente.ofdSelArchivo.FileName
         nombreArchivo = Mid(rutaArchivo, InStrRev(rutaArchivo, "\"))

         excelApp.Workbooks.Open(rutaArchivo)
         hojaExcel = excelApp.Worksheets(1)
         'excelApp.Visible = True
         Try
            For i = 0 To 7
               columna = obtenLetra(i)
               For j = 0 To 11
                  temporal = hojaExcel.Range(columna & (j + 1)).Value2
                  If (temporal <> "") Then
                     placaLector(i, j) = CDec(temporal)
                     'MessageBox.Show("Valor de placa leida: " & placaLector(i, j))
                  Else
                     placaLector(i, j) = 0
                  End If
                  resultado &= CStr(placaLector(i, j)) & vbTab
               Next
               resultado &= vbCrLf
            Next
         Catch ex As Exception
            frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.ForeColor = System.Drawing.Color.Red
            frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.Text = "ERROR:" & ex.Message & " " & ex.GetType.ToString
            frmAbrirArchivoExistente.btnLeerArchivoExistente.Enabled = True
            frmAbrirArchivoExistente.btnObtenResultadosDA.Enabled = False
         End Try
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.ForeColor = System.Drawing.Color.Green
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.Text = "Nombre del archivo abierto: " & nombreArchivo
         frmAbrirArchivoExistente.txtPlacaDesdeArchivo.Text = resultado
         frmAbrirArchivoExistente.txtCPDAValor1.Text = hojaExcel.Range("A15").Value2
         frmAbrirArchivoExistente.txtCPDAValor2.Text = hojaExcel.Range("A16").Value2
         frmAbrirArchivoExistente.txtCPDAValor3.Text = hojaExcel.Range("A17").Value2
         frmAbrirArchivoExistente.txtCNDAValor1.Text = hojaExcel.Range("B15").Value2
         frmAbrirArchivoExistente.txtCNDAValor2.Text = hojaExcel.Range("B16").Value2
         frmAbrirArchivoExistente.txtCNDAValor3.Text = hojaExcel.Range("B17").Value2
         excelApp.ActiveWorkbook.Close()
         'Libera la aplicacion Excel
         releaseObject(excelApp)
         frmAbrirArchivoExistente.btnLeerArchivoExistente.Enabled = False
         frmAbrirArchivoExistente.btnObtenResultadosDA.Enabled = True
      Catch ex As FormatException
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.ForeColor = System.Drawing.Color.Red
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
         frmAbrirArchivoExistente.btnLeerArchivoExistente.Enabled = True
         frmAbrirArchivoExistente.btnObtenResultadosDA.Enabled = False
      Catch ex As Exception
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.ForeColor = System.Drawing.Color.Red
         frmAbrirArchivoExistente.lblNombrePlacaDesdeArchivo.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
         frmAbrirArchivoExistente.btnLeerArchivoExistente.Enabled = True
         frmAbrirArchivoExistente.btnObtenResultadosDA.Enabled = False

      End Try
   End Sub

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

   '#################################################
   '#   SECCION DE CREACION DE TABLA TEMPORAL EN BD #
   '#################################################
   '#Crea la tabla temporal donde se aloja la frecuencia relativa
   Private Sub cargaTablaFrecRel(ByVal frecuenciaRelativa() As Decimal)

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
         'Trunca la tabla utilizada temporalmente para guardar los datos
         comando.CommandText = "truncate table tblfrecrelativa"
         resultado = comando.ExecuteNonQuery()
         'Guardar los datos de la frecuencia relativa en la BD
         For i = 0 To 14
            comando.CommandText = "INSERT INTO tblfrecrelativa (rango,valor) VALUES ('" & i + 1 & "','" & frecuenciaRelativa(i) & "')"
            resultado = comando.ExecuteNonQuery()
         Next
         oConexion.Close()
      Catch ex As Exception
         MessageBox.Show("Error al tratar de insertar datos de la frecuencia relativa en la base de datos.")
      End Try
   End Sub


   '#################################################
   '#CREA GRAFICA DE BARRAS EN LA PANTALLA          #
   '#################################################
   Public Sub creaChartFrecRel(ByVal nombre As String, ByVal titulox As String, ByVal tituloy As String)
      Dim oConexion As MySqlConnection = New MySqlConnection()
      Try
         oConexion.ConnectionString = cadenaConexion
         oConexion.Open()
         Dim sqlfrecrel As String = "Select * from tblfrecrelativa"
         Dim da As New MySqlDataAdapter(sqlfrecrel, oConexion)
         Dim ds As New DataSet()
         da.Fill(ds, "tblfrecrelativa")

         'Inicializa la informacion relacionada con la grafica para la serie, leyenda, el area del gráfico y el gráfico
         Dim ChartArea1 As ChartArea = New ChartArea()
         Dim Legend1 As Legend = New Legend()
         Dim Series1 As Series = New Series()
         Dim Chart1 = New Chart()

         frmSalidaDatos.Controls.Add(Chart1)

         'Define la nueva colección, asigna el nombre del gráfico.
         ChartArea1.Name = "ChartArea1"
         Chart1.ChartAreas.Add(ChartArea1)
         Chart1.Titles.Add(nombre)

         'Coloca los nombres de las etiquetas del gráfico para X y Y, habilita el 3d para las barras.
         Chart1.ChartAreas("ChartArea1").AxisX.Title = titulox
         Chart1.ChartAreas("ChartArea1").AxisY.Title = tituloy
         Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
         'Descomentar lo relacionado a Legend si se desea que aparezca el cuadrito con el titulo de Series (No recomendado)
         'Legend1.Name = "Legend1"
         'Chart1.Legends.Add(Legend1)
         'Series1.Legend = "Legend1"
         Chart1.Name = "Chart1"
         Series1.ChartArea = "ChartArea1"
         Series1.Name = "Series1"
         Series1.ChartType = SeriesChartType.Column
         Chart1.Series.Add(Series1)
         'coloca el valor de la serie sobre la barra para que indique el valor de la frecuencia relativa
         Chart1.Series("Series1").IsValueShownAsLabel = True
         'Ubicacion del grafico
         Chart1.Location = New System.Drawing.Point(600, 50)
         Chart1.Size = New System.Drawing.Size(400, 400)
         Chart1.TabIndex = 21
         Chart1.Anchor = AnchorStyles.Right
         Chart1.Anchor = AnchorStyles.Top
         'Asigna los valores de las series para miembros que se trazan en X y Y
         Chart1.Series("Series1").XValueMember = "rango"
         Chart1.Series("Series1").YValueMembers = "valor"
         Chart1.DataSource = ds.Tables("tblfrecrelativa").Select("rango>0")
         'Cerrar la conexion a la base de datos 
         oConexion.Close()
         oConexion.Dispose()
      Catch ex As Exception
         MessageBox.Show("Error al intentar la conexion a al BD al momento de crear la grafica.")
      End Try
   End Sub

   '##################################################
   '#    MENSAJES DEFAULT EN COLOR ROJO Y VERDE      #
   '##################################################

   Public Sub mensajeException(ByRef etiqueta As Label, ByRef ex As Exception)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeExceptionSQL(ByRef etiqueta As Label, ByRef ex As MySqlException)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeVerde(ByRef etiqueta As Label, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Green
      etiqueta.Text = mensaje
   End Sub

   Public Sub mensajeRojo(ByRef etiqueta As Label, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = mensaje
   End Sub

   '##################################################
   '# SECCION VALIDACION DE FORMATOS PARA textBoxes  #
   '##################################################
   Public Function siNoEsBlanco(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener un valor distinto a blanco.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsLargoUno(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener una letra solamente.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siNoEsBlancoMenorRango(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or (textBox.Text.Length >= 3) Then
         MessageBox.Show(nombre & "El control debe tener un valor numérico entre 0 y 11.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsEntero(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      Try
         Convert.ToInt32(textBox.Text)
         Return True
      Catch ex As Exception
         MessageBox.Show(nombre & "El valor debe ser un numero entero entre 0 y 11.")
         textBox.Select()
         textBox.SelectAll()
         Return False
      End Try
   End Function

   Public Function siEstaEnRango(ByVal textbox As TextBox, ByVal nombre As String, ByVal min As Integer, ByVal max As Integer) As Boolean
      Dim numero As Integer = CInt(textbox.Text)
      If numero < min OrElse numero > max Then
         MessageBox.Show(" El valor " & nombre & "debe ser un número entre 0 y 11.")
         textbox.Select()
         textbox.SelectAll()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siLetraEstaEnRango(ByVal textbox As TextBox, ByVal nombre As String, ByVal min As String, ByVal max As String) As Boolean
      Dim letra As String = textbox.Text.ToUpper
      If letra < min OrElse letra > max Then
         MessageBox.Show(" El valor " & nombre & "debe ser una letra entre A y H.")
         textbox.Select()
         textbox.SelectAll()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siValorEsLetra(ByVal textbox As TextBox) As Integer
      Dim letra As String = textbox.Text.ToUpper
      Dim retorno As Integer
      Select Case letra
         Case "A"
            retorno = 0
         Case "B"
            retorno = 1
         Case "C"
            retorno = 2
         Case "D"
            retorno = 3
         Case "E"
            retorno = 4
         Case "F"
            retorno = 5
         Case "G"
            retorno = 6
         Case "H"
            retorno = 7
         Case Else
            MessageBox.Show(" El valor debe ser una letra entre A y H.")
            textbox.Select()
            textbox.SelectAll()
      End Select
      Return CInt(retorno)
   End Function

   Public Function controlesValidosLetra(ByVal textbox As TextBox, ByVal nombre As String, _
                                         ByVal min1 As String, ByVal max1 As String) As Boolean
      Return _
         siNoEsBlanco(textbox, nombre) AndAlso
         siEsLargoUno(textbox, nombre) AndAlso
         siLetraEstaEnRango(textbox, nombre, min1, max1)
   End Function

   Public Function controlesValidosNumero(ByVal textbox As TextBox, ByVal nombre As String, _
                                      ByVal min As Integer, ByVal max As Integer) As Boolean
      Return _
         siNoEsBlancoMenorRango(textbox, nombre) AndAlso
         siEsEntero(textbox, nombre) AndAlso
         siEstaEnRango(textbox, nombre, min, max)
   End Function

   '#####################################
   '# SECCION CONTROLES DEL PUERTO SERIE#
   '#####################################
   'Obtiene de la BD los datos del lector que se utilizarán para el puerto serie
   Public Sub datosLector(ByRef nomLector As String, ByRef bpsLector As Integer, ByRef paridadLector As Integer, _
                          ByRef bitsLector As Integer, ByRef stopBitsLector As Integer)
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim oDataReader As MySqlDataReader
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT * FROM tbllector WHERE lectorDefault=1;"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         oDataReader = oComando.ExecuteReader()
         If oDataReader.HasRows Then
            While oDataReader.Read()
               nomLector = oDataReader("nomLector")
               bpsLector = oDataReader("bpsLector")
               paridadLector = oDataReader("paridadLector")
               bitsLector = oDataReader("bitsLector")
               stopBitsLector = oDataReader("stopBitsLector")
            End While
            oDataReader.Close()
            frmRegistraNuevoAnalisis.lblMensajeCaso.Text = ""
         Else
            frmRegistraNuevoAnalisis.lblMensajeCaso.ForeColor = System.Drawing.Color.Red
            frmRegistraNuevoAnalisis.lblMensajeCaso.Text = "Mensaje: No se ha encontrado un lector default."
         End If
         oConexion.Close()
      Catch ex As MySqlException
         frmRegistraNuevoAnalisis.lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         frmRegistraNuevoAnalisis.lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
      Catch ex As DataException
         frmRegistraNuevoAnalisis.lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         frmRegistraNuevoAnalisis.lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      Catch ex As Exception
         frmRegistraNuevoAnalisis.lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         frmRegistraNuevoAnalisis.lblMensajeCaso.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      End Try

   End Sub

   'configura el puerto serial
   Public Sub Setup_Puerto_Serie()
      Dim nomLector As String = ""
      Dim bpsLector As Integer
      Dim paridadLector As Integer
      Dim bitsLector As Integer
      Dim stopBitsLector As Integer
      Try
         datosLector(nomLector, bpsLector, paridadLector, bitsLector, stopBitsLector)
         With frmRegistraNuevoAnalisis.SerialPort1
            'Valida si el puerto se encuentra abierto, lo cierra antes de comenzar a capturar datos
            If .IsOpen Then
               .Close()
            End If
            .PortName = frmRegistraNuevoAnalisis.cmbComboPorts.Text
            .BaudRate = bpsLector
            .DataBits = bitsLector
            .StopBits = stopBitsLector
            .Parity = paridadLector
            .DtrEnable = False
            .Handshake = IO.Ports.Handshake.None
            .ReadBufferSize = 2048
            .WriteBufferSize = 1024
            '.ReceivedBytesThreshold = 1
            .WriteTimeout = 500
            .Encoding = System.Text.Encoding.Default
            .Open() ' ABRE EL PUERTO SERIE
         End With
      Catch ex As Exception
         frmRegistraNuevoAnalisis.lblMensajeCaso.ForeColor = System.Drawing.Color.Red
         frmRegistraNuevoAnalisis.lblMensajeCaso.Text = "ERROR: Al abrir el puerto serial con los datos configurados." & ex.Message
      End Try
   End Sub

   'Obtiene los puertos seriales disponibles
   Public Sub GetSerialPortNames()
      ' muestra COM ports disponibles.
      Dim l As Integer
      Dim ncom As String
      Try
         frmRegistraNuevoAnalisis.cmbComboPorts.Items.Clear()
         For Each sp As String In My.Computer.Ports.SerialPortNames
            l = sp.Length
            If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
               frmRegistraNuevoAnalisis.cmbComboPorts.Items.Add(sp)
            Else
               ncom = sp.Substring(0, l - 1)
               frmRegistraNuevoAnalisis.cmbComboPorts.Items.Add(ncom)
            End If
         Next
         If frmRegistraNuevoAnalisis.cmbComboPorts.Items.Count >= 1 Then
            frmRegistraNuevoAnalisis.cmbComboPorts.Text = CStr(frmRegistraNuevoAnalisis.cmbComboPorts.Items(0))
         Else
            frmRegistraNuevoAnalisis.cmbComboPorts.Text = ""
         End If
      Catch ex As Exception
      End Try
   End Sub

   '##########################################################
   '# SECCION GUARDAR ARCHIVO Y CONTENIDO DE LOS DATOS LEIDOS#
   '##########################################################
   'Sirve para guardar los datos en archivo formateados separados por tabs cada valor
   Public Function guardaDatos(ByRef resultado As String) As String
      Dim myStream As Stream
      Dim sfdGuardarPlaca As New SaveFileDialog()
      Dim nombreArchivo As String = ""
      sfdGuardarPlaca.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
      sfdGuardarPlaca.FilterIndex = 2
      sfdGuardarPlaca.RestoreDirectory = True
      Try
         'Abre el dialogo para guardar archivo
         If sfdGuardarPlaca.ShowDialog() = DialogResult.OK Then
            myStream = sfdGuardarPlaca.OpenFile()
            If (myStream IsNot Nothing) Then
               myStream.Close()
               Try
                  'Solicita el nombre del archivo y su lugar de ubicación donde se guardará
                  Dim objFile As New System.IO.StreamWriter(sfdGuardarPlaca.OpenFile())
                  'En nombre archivo se asigna el valor del nombre seleccionado
                  nombreArchivo = sfdGuardarPlaca.FileName
                  'Se llama el formateo de datos y se guarda el resultado en el archivo
                  objFile.Write(resultado)
                  'Se cierra el archivo con los datos ya guardados
                  objFile.Close()
                  'Ahora se lee la placa desde el archivo con los datos guardados
                  'leePlacaDesdeArchivo(nombreArchivo)
               Catch ex As Exception
                  Beep()
                  MessageBox.Show("Errores guardar los datos de la placa en el archivo.")
               End Try
            End If
         End If
      Catch ex As Exception
         Beep()
         MessageBox.Show("Errores al guardar el archivo solicitado.")
      End Try

      Return nombreArchivo
   End Function

   Public Sub leePlacaDesdeArchivo(ByRef nombreArchivo As String)
      Dim resultado As String = ""
      Try
         Dim leeLineaArchivo As New Microsoft.VisualBasic.FileIO.TextFieldParser(nombreArchivo)
         leeLineaArchivo.TextFieldType = FileIO.FieldType.Delimited
         leeLineaArchivo.SetDelimiters(vbTab)
         Dim renglonActual As String()
         Dim i As Integer = 0
         Dim j As Integer = 0
         While Not leeLineaArchivo.EndOfData
            Try
               renglonActual = leeLineaArchivo.ReadFields()
               Dim currentField As String
               For Each currentField In renglonActual
                  If currentField <> vbCrLf And currentField <> "" Then
                     placaLector(i, j) = CDec(currentField)
                  Else
                     MsgBox("Encontre retorno de carro.")
                  End If
                  j += 1
               Next
            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
               MsgBox("Línea malformada" & ex.Message & "no es válida y será saltada.")
            End Try
            i += 1
            j = 0
         End While
      Catch ex As Exception
         MsgBox("El archivo que desea abrir " & nombreArchivo & " no existe." & ex.Message)
      End Try
   End Sub

   '#####################################
   '# SECCION ORGANIZACION DE DATOS     #
   '#####################################
   'Esta funcion recibe el arreglo donde se guardaran los datos de la placa y retorna el valor de los datos organizados
   'por columna en una cadena llamada "resultado"
   Public Function formateaDatos(ByVal placaLector(,) As Decimal) As String
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
      Return (resultado)
   End Function


   'Funcion que calcula el valor de los promedios positivos
   Public Function calculaPromedioPositivos(ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer _
                                           , ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer) As Decimal
      Dim promedioPositivos As Decimal
      promedioPositivos = CDec(Microsoft.VisualBasic.Left(CStr(CDec((placaLector(cpx1, cpy1) + placaLector(cpx2, cpy2) + placaLector(cpx3, cpy3)) / 3)), 14))
      Return promedioPositivos
   End Function

   'Funcion que calcula el valor de los promedios negativos
   Public Function calculaPromedioNegativos(ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer _
                                           , ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer) As Decimal
      Dim promedioNegativos As Decimal
      promedioNegativos = CDec(Microsoft.VisualBasic.Left(CStr(CDec((placaLector(cnx1, cny1) + placaLector(cnx2, cny2) + placaLector(cnx3, cny3)) / 3)), 14))
      Return promedioNegativos
   End Function

   'Funcion que calcula el valor de los promedios positivos leidos desde archivo
   Public Function calculaPromedioPositivosDA(ByVal cp1 As Decimal, ByVal cp2 As Decimal, ByVal cp3 As Decimal) As Decimal
      Dim promedioPositivos As Decimal
      promedioPositivos = CDec(Microsoft.VisualBasic.Left(CStr((cp1 + cp2 + cp3) / 3), 14))
      Return promedioPositivos
   End Function

   'Funcion que calcula el valor de los promedios negativos leidos desde archivo
   Public Function calculaPromedioNegativosDA(ByVal cn1 As Decimal, ByVal cn2 As Decimal, ByVal cn3 As Decimal) As Decimal
      Dim promedioNegativos As Decimal
      promedioNegativos = CDec(Microsoft.VisualBasic.Left(CStr((cn1 + cn2 + cn3) / 3), 14))
      Return promedioNegativos
   End Function

   'Funcion que calcula los resultados del analisis, recibe el nombre del analisis,el titulo de eje x-y, desdeArchivo =1 indica lectura desde archivo
   'cpx y cny son los valores de A..H,  es decir, el valor de la placa por columna   usada para control positivo-negativo
   'cpy y cny son los valores de 1..12, es decir, el valor de la placa por renglones usada para control positivo-negativo
   'logsps, logtit1 y logtit2 son valores utilizados para definir valores especiales que varian de acuerdo a la enfermedad 
   'seleccionada.
   Public Sub calculaValores(ByVal nombre As String, ByVal titulox As String, ByVal tituloy As String, ByRef desdeArchivo As Integer, _
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
      Dim resultado As String = ""
      Dim resultado1 As String = ""
      Dim resultado2 As String = ""
      Dim resultado3 As String = ""
      Dim resultado4 As String = ""
      Dim resultado5 As String = ""
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

      numDeColumnas = placaLector.GetLength(0)
      numDeRegistros = placaLector.GetLength(1)

      'Si no es desde archivo la lectura de la placa, entonces calcula los valores en base a los valores x,y introducidos
      If (desdeArchivo <> 1) Then
         'Valida que se ejecute el calculo de promedio positivo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCP = calculaPromedioPositivos(cpx1, cpx2, cpx3, cpy1, cpy2, cpy3)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio positivo, verifique los valores de control.")
         End Try
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCN = calculaPromedioNegativos(cnx1, cnx2, cnx3, cny1, cny2, cny3)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio negativo, verifique los valores de control.")
         End Try
      Else
         'si es desde archivo la lectura, toma los valores obtenidos de leer el archivo excel
         Try
            promCP = calculaPromedioPositivosDA(cp1, cp2, cp3)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio positivo, verifique los valores de control.")
         End Try
         'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
         Try
            promCN = calculaPromedioNegativosDA(cn1, cn2, cn3)
         Catch ex As Exception
            MessageBox.Show("Se ha encontrado error al calcular el promedio negativo, verifique los valores de control.")
         End Try
      End If
      'Calcula la diferencia de controles positivos y negativos
      difCPS = CDec(Microsoft.VisualBasic.Left(CStr(CDec(promCP - promCN)), 14))

      'Calcula la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            'If IsNumeric(placaLector(i, j)) Then MODIFICADO 18-Abril-2012
            If (placaLector(i, j) > 0) Then
               calculaSPS(i, j) = CDec(Microsoft.VisualBasic.Left(CStr((placaLector(i, j) - promCN) / difCPS), 14))
            Else
               calculaSPS(i, j) = 0
            End If
            resultado1 += placaLector(i, j) & vbTab
            resultado2 += calculaSPS(i, j) & vbTab
         Next
         resultado1 += vbCrLf
         resultado2 += vbCrLf
      Next

      'Calcula los logaritmos de la tabla SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            If (calculaSPS(i, j) > logsps) Then
               logaritmoSPS(i, j) = CDec((Microsoft.VisualBasic.Left(CStr(Math.Log10(calculaSPS(i, j))), 14)))
            Else
               logaritmoSPS(i, j) = -4
            End If
            resultado3 += logaritmoSPS(i, j) & vbTab
         Next
         resultado3 += vbCrLf
      Next

      'Calcula los Titulos de la tabla de logaritmos SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            logaritmoTitulos(i, j) = CDec(Microsoft.VisualBasic.Left(CStr((logtit1 * logaritmoSPS(i, j)) + logtit2), 14))
            resultado4 += logaritmoTitulos(i, j) & vbTab
         Next
         resultado4 += vbCrLf
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
            resultado5 += calculoDeTitulos(i, j) & vbTab
         Next
         resultado5 += vbCrLf
      Next

      'Inicializa la columna L a ceros para evitar validaciones posteriores
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            calculaL(i, j) = 0
         Next
      Next

      'Obtiene los valores desde Ax hasta Hx que se utilizaron de una placa para hacer el analisis
      desdeX = 0
      hastaX = 3
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

      'Crea la tabla temporal para la frecuencia relativa y posterior creación de la gráfica
      cargaTablaFrecRel(frecuenciaRelativa)
      creaChartFrecRel(nombre, titulox, tituloy)

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
      frmSalidaDatos.lblNombreEnfermedad.Text = nombre
      'guardaResultadosExcel(frecuenciaRelativa, calculoDeTitulos, "Laringo", nombre, calculaMedia, mediaAritmetica, mediaGeometrica, _
      '                     coeficienteDeVariacion, desviacionEstandar, calculaVarianza, cuentaNoDatos, _
      '                     desviacionEstandarDatosNoAgrupados, coeficienteDeVariacionDatosNoAgrupados, calculaVarianzaDatosNoAgrupados)
   End Sub
End Module
