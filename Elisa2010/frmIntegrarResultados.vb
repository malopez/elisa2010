Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.Security

Public Class frmIntegrarResultados
   'Este debe recibir el parámetro desde un combobox con los nombres de número de caso.
   Dim rutaResultados As String = "C:\ELISA2012\Resultados\"

   Private Sub listaArchivosDeUnCaso(ByVal nocaso As String, ByRef chbLista As CheckedListBox)

      'Asigna a la ruta donde buscará la de los resultados de los análisis.
      Dim directorioResultados As New System.IO.DirectoryInfo(rutaResultados)
      'Genera un arreglo con la informacion de los archivos, para que coloque su nombre
      Dim misArchivos() As System.IO.FileInfo
      Dim totalArchivos As Integer = 0
      Dim archivo As String = ""
      Dim i As Integer = 0
      Dim j As Integer = 0
      Dim cadena As String = ""
      Dim tabla() As String

      'Carga el array de archivos del directorio que cumplen con el nombre del caso quitándoles la extensión del nombre.
      misArchivos = directorioResultados.GetFiles(nocaso & "*.xls")
      totalArchivos = misArchivos.Length - 1
      Dim punto As Integer = 0

      If totalArchivos >= 0 Then
         For i = 0 To totalArchivos
            cadena = misArchivos(i).Name()
            tabla = Split(cadena, "-")
            punto = InStrRev(tabla(2), ".")
            'Encuentra el punto para después quitar la extensión, cuando la tiene, es decir punto = 0
            If punto > 0 Then
               chbLista.Items.Add(Microsoft.VisualBasic.Left(tabla(2), punto - 1))
               chkMarcarTodo.Enabled = True
            Else
               chbLista.Items.Add(tabla(2))
            End If
            'chbListaDeArchivos.Items.Add(misArchivos(i).Name())
         Next
         btnIntegrarArchivos.Enabled = True
      End If
   End Sub

   'Este debe recibir el parámetro desde un combobox con los nombres de número de caso.
   Private Sub listaCasosEnDirectorio(ByRef cmbCasos As ComboBox)
      'Asigna a la ruta donde buscará la de los resultados de los análisis.
      Dim directorioResultados As New System.IO.DirectoryInfo(rutaResultados)
      'Genera un arreglo con la informacion de los archivos, para que coloque su nombre
      Dim misArchivos() As System.IO.FileInfo

      Dim totalArchivos As Integer = 0
      Dim archivo As String = ""
      Dim i As Integer = 0
      Dim j As Integer = 0

      Dim cadena As String = ""
      Dim tabla() As String
      Dim temporal() As String

      'Carga el array de archivos del directorio que cumplen con el nombre del caso quitándoles la extensión del nombre.
      Try
         misArchivos = directorioResultados.GetFiles("*.xls")
         totalArchivos = misArchivos.Length - 1
      Catch ex As ArgumentException
         MessageBox.Show("La Ruta de origen o destino para leer o escribir el archivo contiene caracteres inválidos.", "ERROR: Mensaje del Sistema", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
      Catch ex As DirectoryNotFoundException
         MessageBox.Show("La Ruta de origen o destino para leer o escribir el archivo de resultados no existe.", "ERROR: Mensaje del Sistema", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
      Catch ex As SecurityException
         MessageBox.Show("El usuario no tiene permisos de lectura-escritura en la ruta destino.", "ERROR: Mensaje del Sistema", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

      Try
         'Pasa todos los nombres de archivos al arreglo temporal
         For i = 0 To totalArchivos
            'Crece el arreglo conservando lo que tiene de datos 
            ReDim Preserve temporal(i)
            cadena = misArchivos(i).Name().ToString
            tabla = Split(cadena, "-")

            'Encuentra el punto para después quitar la extensión, cuando la tiene, es decir punto=0
            If UBound(tabla) = 1 Then
               Dim punto As Integer = InStrRev(tabla(1), ".")
               'Encuentra el punto para después quitar la extensión, cuando la tiene, es decir punto=0
               If punto > 0 Then
                  'Arma el nombre del archivo eliminando espacios en blanco
                  temporal(i) = tabla(0) & "-" & Microsoft.VisualBasic.Left(tabla(1), punto - 1)
                  chkMarcarTodo.Enabled = True
               End If
            Else
               temporal(i) = tabla(0) & "-" & tabla(1)
               'chbListaDeArchivos.Items.Add(misArchivos(i).Name())
            End If

         Next
         'Ordena el listado de nombres de archivo
         Array.Sort(temporal)

         For i = 0 To totalArchivos
            If (temporal(i) <> temporal(j)) Then
               j += 1
               temporal(j) = temporal(i)
            End If
            Console.WriteLine(temporal(i))
         Next
         If j >= 0 Then
            For i = 0 To j
               cmbCasos.Items.Add(temporal(i))
            Next
         Else
            MessageBox.Show("Existe solamente un archivo para el No. de Caso: que ya es un resultado final.")
         End If
      Catch
         MessageBox.Show("No existen archivos de casos con un formato válido.", "PRECAUCIÓN: Mensaje del Sistema", _
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End Try
   End Sub

   'Verifica si existe un archivo. Regresa TRUE o FALSE según sea el caso.
   Private Function verificarSiExisteArchivo(ByVal nombreArchivo As String) As Boolean
      Dim fso As New System.Object
      fso = CreateObject("Scripting.FileSystemObject")
      If fso.FileExists(nombreArchivo) Then
         Return True
      Else
         Return False
      End If
      releaseObject(fso)
   End Function

   'Se utiliza para revisar cuales archivos desean integrarse en los de resultados
   Private Sub btnIntegrarArchivos_Click(sender As System.Object, e As System.EventArgs) Handles btnIntegrarArchivos.Click

      'Para el nuevo archivo de informe final de resultados.
      Dim excelApp As New Excel.Application
      Dim libroExcelDestino As Excel.Workbook
      Dim libroExcelOrigen As Excel.Workbook
      Dim filas As Integer = 53
      Dim numeroHojas As Integer = 0
      Dim totalNumeroHojas As Integer = 0
      Dim rangoA As Integer = 1

      'Hace invisible el excel al usuario, no interactivo y sin desplegar alertas.
      excelApp.Visible = False
      excelApp.Interactive = False
      excelApp.DisplayAlerts = False


      Dim i As Integer = 0
      Dim informeFinal As String = rutaInformeFinal & "InformeFinal-" & cmbCasos.Text & ".xls"
      Dim analisisMarcados As String = ""
      Dim listaTotal As Integer = chbAnalisis.Items.Count - 1

      cmbCasos.Enabled = False



      'Valida si esta marcado al menos un archivo en el checkboxlist

      If (listaTotal >= 0) And verificaSiExistenArchivosMarcados() Then
         chkMarcarTodo.Enabled = False

         'Valida si existe el archivo final de resultados, si no, crea uno  nuevo con el margen adecuado
         If verificarSiExisteArchivo(informeFinal) Then
            libroExcelDestino = excelApp.Workbooks.Open(informeFinal)
            excelApp.ActiveSheet.Name = "Inf Final"
         Else
            libroExcelDestino = excelApp.Workbooks.Add()
            With libroExcelDestino.ActiveSheet.PageSetup
               .LeftMargin = .Application.InchesToPoints(0.27559055118110237)
               .RightMargin = .Application.InchesToPoints(0.27559055118110237)
               .TopMargin = .Application.InchesToPoints(1.1023622047244095)
               .BottomMargin = .Application.InchesToPoints(0.62992125984251968)
            End With
         End If

         'Para los archivos en lista que se encuentren, busca los marcados.
         For i = 0 To listaTotal
            'si esta marcado, trata de integrarlo a un solo excel de resultados que se llama InformeFinal-no.caso.xls
            If (chbAnalisis.GetItemChecked(i) = True) Then
               'Integro el nombre el archivo seleccionado.
               analisisMarcados = rutaResultados & cmbCasos.Text & "-" & chbAnalisis.Items(i).ToString & ".xls"

               'Abre el archivo excel origen validando si existe, obtiene el número de hojas que tiene el reporte.
               If verificarSiExisteArchivo(analisisMarcados) Then

                  libroExcelOrigen = excelApp.Workbooks.Open(analisisMarcados)
                  numeroHojas = libroExcelOrigen.Sheets(1).Range("I1").value
                  'Va sumando el número de hojas que tiene cada archivo de resultados.
                  totalNumeroHojas += numeroHojas

                  'Copia las celdas del archivo de resultados.
                  libroExcelOrigen.Sheets(1).Range("A1:I" & (filas * numeroHojas)).Copy()

                  'Seleccionar el archivo de informe final pega los datos.
                  libroExcelDestino.Activate()
                  excelApp.ActiveSheet.Paste(Destination:=libroExcelDestino.Sheets(1).Range("A" & rangoA))

                  rangoA = (totalNumeroHojas * filas) + 1

                  'Cierra el archivo de resultados abierto.
                  libroExcelOrigen.Close()

               Else
                  MessageBox.Show("No se puede abrir el archivo excel, " & chbAnalisis.Items(i).ToString & ".xls", _
                                  "ERROR: Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
               End If

            End If

         Next

         'Paginar las hojas del informe final de resultados.

         For i = 0 To totalNumeroHojas - 1
            libroExcelDestino.Activate()
            libroExcelDestino.Sheets(1).Range("H" & ((i * 53) + 1)).Value = (i + 1) & " /"
            libroExcelDestino.Sheets(1).Range("I" & ((i * 53) + 1)).Value = totalNumeroHojas
         Next

         'Colocar el nombre del archivo final de resultados
         txtInformeFinal.Text = informeFinal.ToString()

         'Cerrar el nuevo archivo de informe final salvándolo y liberando el objeto.
         With excelApp
            excelApp.ActiveWorkbook.SaveAs(informeFinal)
            .ActiveWorkbook.Close()
            .Quit()
         End With
         releaseObject(excelApp)

         'habilitar estos dos botones si se ha generado el archivo de forma correcta.
         btnPreverInfome.Enabled = True
         btnCopiarInforme.Enabled = True
         chbAnalisis.Enabled = False
         btnIntegrarArchivos.Enabled = False

      Else
         MessageBox.Show("No existen análisis señalados para integrar un Informe Final de resultados.", "ERROR: Mensaje del Sistema", _
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
   End Sub

   Private Function verificaSiExistenArchivosMarcados() As Boolean
      Dim listaTotal As Integer = chbAnalisis.Items.Count - 1
      Dim verifica As Boolean = False
      For i = 0 To listaTotal
         If (chbAnalisis.GetItemChecked(i) = True) Then
            verifica = True Or verifica
         End If
      Next
      Return verifica
   End Function

   Private Sub cmbCasos_Click(sender As Object, e As System.EventArgs) Handles cmbCasos.Click
      cmbCasos.Items.Clear()
      listaCasosEnDirectorio(cmbCasos)
      mnuPreverAnalisis.Enabled = False
      tsmPreverArchivo.Enabled = False
   End Sub

   Private Sub cmbCasos_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbCasos.SelectedIndexChanged
      Dim nocaso As String = cmbCasos.Text
      chbAnalisis.Items.Clear()
      chkMarcarTodo.Checked = False
      listaArchivosDeUnCaso(nocaso, chbAnalisis)
      txtInformeFinal.Text = ""
   End Sub

   Private Sub chkMarcarTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMarcarTodo.CheckedChanged
      Dim i As Integer = 0
      Dim listaTotal As Integer = chbAnalisis.Items.Count - 1
      If (chkMarcarTodo.Checked = True) Then
         For i = 0 To listaTotal
            chbAnalisis.SetItemChecked(i, True)
            mnuPreverAnalisis.Enabled = True
            tsmPreverArchivo.Enabled = True
         Next
      Else
         For i = 0 To listaTotal
            chbAnalisis.SetItemChecked(i, False)
            mnuPreverAnalisis.Enabled = False
            tsmPreverArchivo.Enabled = False
         Next
      End If
   End Sub

   Private Sub preverExcelDeResultados(ByVal nombreArchivoResultado As String)
      Dim excelApp As New Excel.Application
      Dim libroExcel As Excel.Workbook
      Dim fso As Object
      'Instanciar el objeto FSO para poder usar las funciones FileExists y FolderExists
      fso = CreateObject("Scripting.FileSystemObject")
      ' Comprobar archivo
      If fso.FileExists(nombreArchivoResultado) Then
         excelApp.Visible = True
         'Este se coloca para que el usuario tenga el control del archivo de excel, cuando el lo cierra VB no tiene que liberarlo.
         excelApp.UserControl = True
         libroExcel = excelApp.Workbooks.Open(nombreArchivoResultado, True)
         releaseObject(excelApp)
      Else
         MessageBox.Show("ERROR: NO SE ENCUENTRA EL ARCHIVO BUSCADO.")
      End If
      fso = Nothing
   End Sub

   'Procedimiento que sirve para liberar el objeto  Aplicacion Excel
   Private Sub releaseObject(ByVal obj As Object)
      Try
         System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
         obj = Nothing
      Catch ex As Exception
         obj = Nothing
      Finally
         GC.Collect()
      End Try
   End Sub

   Private Sub tsmPreverArchivo_Click(sender As System.Object, e As System.EventArgs) Handles tsmPreverArchivo.Click
      Dim checado = chbAnalisis.SelectedIndex
      Dim nombreArchivoResultado As String = rutaResultados & cmbCasos.Text & "-" & chbAnalisis.Items(checado).ToString & ".xls"
      preverExcelDeResultados(nombreArchivoResultado)
   End Sub

   Private Sub chbAnalisis_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles chbAnalisis.ItemCheck
      Dim checado = chbAnalisis.SelectedIndex
      If checado < 0 Then
         checado = 0
      End If
      If (chbAnalisis.GetItemChecked(checado) = False) Then
         mnuPreverAnalisis.Enabled = True
         tsmPreverArchivo.Enabled = True
      Else
         mnuPreverAnalisis.Enabled = False
         tsmPreverArchivo.Enabled = False
      End If
   End Sub

   Private Sub btnPreverInfome_Click(sender As System.Object, e As System.EventArgs) Handles btnPreverInfome.Click
      Dim nombreArchivoResultado As String = txtInformeFinal.Text
      preverExcelDeResultados(nombreArchivoResultado)
   End Sub

   Private Sub btnCopiarInforme_Click(sender As System.Object, e As System.EventArgs) Handles btnCopiarInforme.Click
      Dim nombreArchivoResultado As String = txtInformeFinal.Text
      lblMensajeCopia.Text = ""
      'si desea moverlo en lugar de copiar el archivo, cambie el comando comentado.
      'My.Computer.FileSystem.MoveFile(nombreArchivoResultado, rutaParaImprimir & "ArchivoFinal" & cmbCasos.Text & ".xls", _
      '                                 FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
      'Verifica la existencia del archivo y lo copia o lo mueve respaldándolo primero con la hora del dia en formato hh_mm_ss
      If verificarSiExisteArchivo(nombreArchivoResultado) Then
         Try
            My.Computer.FileSystem.CopyFile(nombreArchivoResultado, rutaParaImprimir & "ArchivoFinal-" & cmbCasos.Text & ".xls")
            lblMensajeCopia.Text = "Copia en <<Para Imprimir>> Existosa."
         Catch ex As IOException
            If MessageBox.Show("El archivo final de resultados ya existe, ¿Desea guardar una copia?.", "ERROR: Mensaje del Sistema", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
               My.Computer.FileSystem.MoveFile(rutaParaImprimir & "ArchivoFinal-" & cmbCasos.Text & ".xls", rutaParaImprimir & "ArchivoFinal-" & cmbCasos.Text & "_" & Format(Now(), "hh_mm_ss") & ".xls")
               lblMensajeCopia.Text = "Respaldo realizado."
               My.Computer.FileSystem.CopyFile(nombreArchivoResultado, rutaParaImprimir & "ArchivoFinal-" & cmbCasos.Text & ".xls")
               lblMensajeCopia.Text = "Copia en <<Para Imprimir>> Existosa."

            End If
         End Try
      Else
         MessageBox.Show("El archivo final de resultados NO se encuentra en la ruta esperada, consulte a su administrador.", _
                         "ERROR: Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If

   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

End Class