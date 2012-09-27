Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module mdlEstilos
   'Colorea en el grid view los casos cada uno con un color.
   Public Sub coloreaCasos(ByRef dgvPlacaLeida As DataGridView, ByVal nomcolor As System.Drawing.Color, ByVal txtDesdeLetra As TextBox, _
                            ByVal txtHastaLetra As TextBox, ByVal txtDesdeValor As TextBox, ByVal txtHastaValor As TextBox)
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra)
      Dim desdey As Integer = CInt(txtDesdeValor.Text) - 1
      Dim hastay As Integer = CInt(txtHastaValor.Text) - 1
      Dim renglones As Integer = 11
      For i = desdex To hastax
         If (i = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            coloreaTabla(dgvPlacaLeida, nomcolor, i, j + 1)
         Next
         desdey = 0
      Next
   End Sub

   'Colorea la tabla del grid view
   Public Sub coloreaTabla(ByRef placa As DataGridView, ByVal color As System.Drawing.Color, ByVal col As Integer, ByVal reng As Integer)
      placa.Rows(col).Cells(reng).Style.BackColor = color
   End Sub

   'Creados para casos con subcasos probando el valor del RGB
   Public Sub coloreaTablaDeCasos(ByRef placa As DataGridView, ByVal colorFondo As Color, ByVal col As Integer, ByVal reng As Integer)
      placa.Rows(col).Cells(reng).Style.BackColor = colorFondo
   End Sub

   Public Sub coloreaLosCasos(ByRef dgvPlacaLeida As DataGridView, ByVal colorFondo As Color, ByVal txtDesdeLetra As TextBox, _
                            ByVal txtHastaLetra As TextBox, ByVal txtDesdeValor As TextBox, ByVal txtHastaValor As TextBox)
      Dim desdex As Integer = siValorEsLetra(txtDesdeLetra)
      Dim hastax As Integer = siValorEsLetra(txtHastaLetra)
      Dim desdey As Integer = CInt(txtDesdeValor.Text) - 1
      Dim hastay As Integer = CInt(txtHastaValor.Text) - 1
      Dim renglones As Integer = 11
      For i = desdex To hastax
         If (i = hastax) Then
            renglones = hastay
         End If
         For j = desdey To renglones
            coloreaTablaDeCasos(dgvPlacaLeida, colorFondo, i, j + 1)
         Next
         desdey = 0
      Next
   End Sub

   'colorea de verde la posicion señalada para los controles positivos.
   Public Sub coloreaControlesPositivos(ByVal nocp As Integer, ByRef dgvPlacaLeida As DataGridView, _
                                        ByVal txtCP1Letra1 As TextBox, ByVal txtCP1Valor1 As TextBox, _
                                        ByVal txtCP2Letra2 As TextBox, ByVal txtCP2Valor2 As TextBox, _
                                        ByVal txtCP3Letra3 As TextBox, ByVal txtCP3Valor3 As TextBox)
      Select Case nocp
         Case 2
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), CInt(txtCP1Valor1.Text))
            coloreaTabla(dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), CInt(txtCP2Valor2.Text))
         Case 3
            'Rellena el fondo del datagridview de color verde para los controles positivos
            coloreaTabla(dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP1Letra1)), CInt(txtCP1Valor1.Text))
            coloreaTabla(dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP2Letra2)), CInt(txtCP2Valor2.Text))
            coloreaTabla(dgvPlacaLeida, Color.Green, Val(siValorEsLetra(txtCP3Letra3)), CInt(txtCP3Valor3.Text))
      End Select
   End Sub

   'Dibuja la tabla en pantalla, para presentar los datos utilizando un grid, este si es utilizado por la nueva version del programa
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

   'Dibuja la tabla de resultados en pantalla para anemia infecciosa.
   Public Sub tablaEnPantallaAnemia(ByRef dgvPlaca As DataGridView, ByRef cuentaNoDatos As Integer, ByVal calculaSPS(,) As Decimal, _
                                    ByVal logaritmoSPS(,) As Decimal)
      Dim i As Integer
      'Quita el indicador de fila del datagridview
      dgvPlaca.RowHeadersVisible = False
      dgvPlaca.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
      dgvPlaca.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

      dgvPlaca.Rows.Add(cuentaNoDatos)
      For i = 1 To cuentaNoDatos
         dgvPlaca.Columns.Add("pozo" & i, i)
         With dgvPlaca.Columns(i)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .SortMode = DataGridViewColumnSortMode.NotSortable
         End With
      Next

      'dgvPlaca.Columns(0).Frozen = True  Descomentar si se requiere la primer celda fija.
      For i = 0 To 7
         dgvPlaca.Rows(i).Cells(0).Value = obtenLetra(i)
      Next
   End Sub







   'Organizar en tabla los datos de la placa leida.
   Public Sub organizaEnTabla(ByRef placa As DataGridView, ByVal placaLector(,) As Decimal)
      Dim i As Integer
      For i = 0 To 7
         For j = 0 To 11
            placa.Rows(i).Cells(j + 1).Value = placaLector(i, j)
            placa.Rows(i).Cells(j + 1).Style.ForeColor = Color.Black
         Next
      Next
   End Sub

   ' Permite organizar en la tabla de pantalla obteniendo desde archivo los datos
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

   'colorea de verde la posicion señalada para los controles negativos.
   Public Sub coloreaControlesNegativos(ByVal nocn As Integer, ByRef dgvPlacaLeida As DataGridView, _
                                         ByVal txtCN1Letra1 As TextBox, ByVal txtCN1Valor1 As TextBox, _
                                         ByVal txtCN2Letra2 As TextBox, ByVal txtCN2Valor2 As TextBox, _
                                         ByVal txtCN3Letra3 As TextBox, ByVal txtCN3Valor3 As TextBox)
      Select Case nocn
         Case 2
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
         Case 3
            'Rellena el fondo del datagridview de color rojo para los controles negativos
            coloreaTabla(dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN1Letra1)), CInt(txtCN1Valor1.Text))
            coloreaTabla(dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN2Letra2)), CInt(txtCN2Valor2.Text))
            coloreaTabla(dgvPlacaLeida, Color.Red, Val(siValorEsLetra(txtCN3Letra3)), CInt(txtCN3Valor3.Text))
      End Select
   End Sub


   '######################################################################
   '# MENSAJES DEFAULT PARA ATRAPAR EXCEPCIONES, Y EN COLOR ROJO Y VERDE #
   '######################################################################

   Public Sub mensajeException(ByRef etiqueta As ToolStripLabel, ByRef ex As Exception)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeExceptionSQL(ByRef etiqueta As ToolStripLabel, ByRef ex As MySqlException)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeVerde(ByRef etiqueta As ToolStripLabel, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Green
      etiqueta.Text = mensaje
   End Sub

   Public Sub mensajeRojo(ByRef etiqueta As ToolStripLabel, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = mensaje
   End Sub

End Module
