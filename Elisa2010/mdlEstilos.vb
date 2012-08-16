Module mdlEstilos


   ''############################ DESDE AQUI
   'Se pueden borrar estos dos procedimientos desde aqui hasta aqui porque se sustituyen por los dos de abajo
   'Gracias al cambio se tienen los colores en RGB aleatorio.

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

   '############################HASTA AQUI

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

End Module
