﻿Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Module mdlOperaciones
   '################################
   '# SECCION DE VARIABLES GLOBALES#
   '################################
   'utilizada para almacenar los datos que se reciben por el puerto
   Public az As String
   ' sera utilizada como contador
   Public sib As Integer = 0
   'Arreglo que servira de buffer para los datos que van llegando al puerto
   Public msn() As String = {"0142", "0220", "0200", "0230", "0128", "0134", "0119", "0349", "0364", "0812", "0057", "0743",
"0436", "0424", "0427", "0386", "0306", "0145", "0110", "0303", "0147", "0281", "0229", "0232",
"0152", "0422", "0186", "0173", "0381", "0232", "0219", "0241", "0339", "0193", "0226", "0186",
"0430", "0188", "0424", "0158", "0493", "0227", "0285", "0249", "0098", "0222", "0122", "0158",
"0332", "0139", "0379", "0375", "0282", "0395", "0549", "0181", "0765", "0346", "0236", "0322",
"0242", "0165", "0279", "0735", "0326", "0165", "0205", "0175", "0155", "0176", "0212", "0268",
"0129", "0227", "0211", "0252", "0351", "0101", "0172", "0268", "0199", "0297", "0394", "0318",
"0389", "0338", "0158", "0302", "0214", "0262", "0570", "0083", "0144", "0058", "0726", "0062"}
   Public placaLector(7, 11) As Decimal
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
      excelApp.Range("B15").Value2 = "Controles Positivos"
      excelApp.Range("B16").Value2 = placaLector(cpx1, cpy1)
      excelApp.Range("B17").Value2 = placaLector(cpx2, cpy2)
      excelApp.Range("B18").Value2 = placaLector(cpx3, cpy3)
      excelApp.Range("C15").Value2 = "Controles Negativos"
      excelApp.Range("C16").Value2 = placaLector(cnx1, cny1)
      excelApp.Range("C17").Value2 = placaLector(cnx2, cny2)
      excelApp.Range("C18").Value2 = placaLector(cnx3, cny3)
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
      Dim temp As Integer = 3
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
         excelApp.Range("B" & i).Value2 = Math.Round(frecuenciaRelativa(i - 2))
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
      'xlApp.ActiveWorkbook.SaveAs() 'aqui meter el procedimiento de guardar archivo con un nombre
      'Cierra el libro activo de Excel


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
      excelApp.Visible = True

      For i = 0 To 7
         columna = obtenLetra(i)
         For j = 0 To 11
            placaLector(i, j) = CDec(hojaExcel.Range(columna & (j + 1)).Value2)
            MessageBox.Show("Valor de placa leida: " & placaLector(i, j))
         Next
      Next

      excelApp.ActiveWorkbook.Close()
      'Libera la aplicacion Excel
      releaseObject(excelApp)
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
         oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
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
         oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
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
   '# SECCION VALIDACION DE FORMATOS PARA textBoxes  #
   '##################################################
   Public Function siNoEsBlanco(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener un valor.", " ERROR de datos")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsLargoUno(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener una letra solamente entre A y H.", " ERROR de datos")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siNoEsBlancoMenorRango(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or (textBox.Text.Length >= 3) Then
         MessageBox.Show(nombre & "El control debe tener un valor numerico entre 0 y 11.", " ERROR de datos")
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
         MessageBox.Show(nombre & "El valor debe ser un numero entero .", " ERROR de datos")
         textBox.Select()
         textBox.SelectAll()
         Return False
      End Try
   End Function

   Public Function siEstaEnRango(ByVal textbox As TextBox, ByVal nombre As String, ByVal min As Integer, ByVal max As Integer) As Boolean
      Dim numero As Integer = CInt(textbox.Text)
      If numero < min OrElse numero > max Then
         MessageBox.Show(" El valor " & nombre & "debe ser un numero entre 0 y 11.", " ERROR de datos")
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
         MessageBox.Show(" El valor " & nombre & "debe ser una letra entre A y H.", " ERROR de datos")
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
            MessageBox.Show(" El valor debe ser una letra entre A y H.", " ERROR de datos")
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
   'configura el puerto serial
   Public Sub Setup_Puerto_Serie()
      Try
         With frmRegistraNuevoAnalisis.SerialPort1
            'Valida si el puerto se encuentra abierto, lo cierra antes de comenzar a capturar datos
            If .IsOpen Then
               .Close()
            End If
            .PortName = frmRegistraNuevoAnalisis.cmbComboPorts.Text
            .BaudRate = 9600 '// 19200 baud rate
            .DataBits = 8 '// 8 data bits
            .StopBits = IO.Ports.StopBits.Two '// 1 Stop bit
            .Parity = IO.Ports.Parity.None 'No utiliza paridad
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
         MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)
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
      'MessageBox.Show("nombre del archivo" & nombreArchivo)
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
      Dim temporal(11) As String
      'Permite guardar los datos ya organizados y formateados como matriz, que después se enviaran al archivo de texto
      Dim resultado As String = ""
      For i = 0 To 7
         'Los valores invertidos son los pares, es decir las lineas pares A, C, E y G, si el numero es divisible entre dos,
         ' quiere decir que la i es par entonces se mueve en el indice de msn hasta limite superior y va regresando 11 valores
         If ((i Mod 2) = 0) Then
            limInferior = i * 12
            limSuperior = limInferior + 12
            For k = limSuperior - 1 To limInferior Step -1
               temporal(contador) = msn(k)
               contador += 1
               contador1 += 1
            Next
            'Reinicia el contador del arreglo temporal a 0 para que cuando i sea nuevamente par comienze a organizar en temporal(0)
            contador = 0
            'Lee todos los datos del temporal ahora organizados y se los pasa a la placa leida ya en orden correcto
            For j = 0 To 11
               placaLector(i, j) = CDec(temporal(j)) / 1000
            Next
         Else
            'si i no es par, entonces le asigna los valores del arreglo leido desde el puerto
            For j = 0 To 11
               placaLector(i, j) = CDec(msn(contador1)) / 1000
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
   Public Function calculaPromedioPositvos(ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer _
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

   'Funcion que calcula los resultados del analisis
   'cpx y cny son los valores de A..H,  es decir, el valor de la placa por columna   usada para control positivo-negativo
   'cpy y cny son los valores de 1..12, es decir, el valor de la placa por renglones usada para control positivo-negativo
   'logsps, logtit1 y logtit2 son valores utilizados para definir valores especiales que varian de acuerdo a la enfermedad 
   'seleccionada
   Public Sub calculaValores(ByVal nombre As String, ByVal titulox As String, ByVal tituloy As String, _
                             ByVal cpx1 As Integer, ByVal cpx2 As Integer, ByVal cpx3 As Integer, _
                             ByVal cpy1 As Integer, ByVal cpy2 As Integer, ByVal cpy3 As Integer, _
                             ByVal cnx1 As Integer, ByVal cnx2 As Integer, ByVal cnx3 As Integer, _
                             ByVal cny1 As Integer, ByVal cny2 As Integer, ByVal cny3 As Integer, _
                             ByVal logsps As Decimal, ByVal logtit1 As Decimal, ByVal logtit2 As Decimal)
      'Para controlar el ciclo for, y posteriormente para calcular los valores de la "L, DESDE" y los valores de la matriz 15x96
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim k As Integer = 0
      'Para presentar el resultado del análisis campo texto de la forma
      Dim resultado As String = ""
      Dim resultado1 As String = ""
      Dim resultado2 As String = ""
      Dim resultado3 As String = ""
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

      numDeColumnas = placaLector.GetLength(0)
      numDeRegistros = placaLector.GetLength(1)

      'Valida que se ejecute el calculo de promedio positivo, si no, despliega un mensaje de error relacionado con la función
      Try
         promCP = calculaPromedioPositvos(cpx1, cpx2, cpx3, cpy1, cpy2, cpy3)
      Catch ex As Exception
         MessageBox.Show("Se ha encontrado error al calcular el promedio positivo, verifique los valores de control.")
      End Try
      'Valida que se ejecute el calculo de promedio negativo, si no, despliega un mensaje de error relacionado con la función
      Try
         promCN = calculaPromedioNegativos(cnx1, cnx2, cnx3, cny1, cny2, cny3)
      Catch ex As Exception
         MessageBox.Show("Se ha encontrado error al calcular el promedio negativo, verifique los valores de control.")
      End Try

      'Calcula la diferencia de controles positivos y negativos
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
            If (calculaSPS(i, j) > logsps) Then
               logaritmoSPS(i, j) = CDec((Microsoft.VisualBasic.Left(CStr(Math.Log10(calculaSPS(i, j))), 14)))
            Else
               logaritmoSPS(i, j) = -4
            End If
         Next
      Next

      'Calcula los Titulos de la tabla de logaritmos SPS
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            logaritmoTitulos(i, j) = CDec(Microsoft.VisualBasic.Left(CStr((logtit1 * logaritmoSPS(i, j)) + logtit2), 14))
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
      k = 1
      For i = 0 To numDeColumnas - 1
         For j = 0 To numDeRegistros - 1
            resultado &= CStr(k) & vbTab & CStr(calculoDeTitulos(i, j)) & vbCrLf
            k += 1
            If (k >= 24) Then
               resultado1 &= CStr(k) & " " & CStr(calculoDeTitulos(i, j)) & vbCrLf
            End If
            If (k >= 48) Then
               resultado2 &= CStr(k) & " " & CStr(calculoDeTitulos(i, j)) & vbCrLf
            End If
            If (k >= 72) Then
               resultado3 &= CStr(k) & " " & CStr(calculoDeTitulos(i, j)) & vbCrLf
            End If
         Next
      Next
      frmSalidaDatos.txtResultadoTitulosA.Text = resultado
      frmSalidaDatos.txtResultadoTitulosB.Text = resultado1
      frmSalidaDatos.txtResultadoTitulosC.Text = resultado2
      'frmSalidaDatos.txtResultadoTitulosD.Text = resultado3
      guardaResultadosExcel(frecuenciaRelativa, calculoDeTitulos, "Laringo", nombre, calculaMedia, mediaAritmetica, mediaGeometrica, _
                            coeficienteDeVariacion, desviacionEstandar, calculaVarianza, cuentaNoDatos, _
                            desviacionEstandarDatosNoAgrupados, coeficienteDeVariacionDatosNoAgrupados, calculaVarianzaDatosNoAgrupados)
   End Sub
End Module
