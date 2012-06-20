Module mdlEstilos

   Public Sub coloreaCasos(ByRef dgvPlacaLeida As DataGridView, ByVal nomcolor As Color, ByVal txtDesdeLetra As TextBox, _
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

   Public Sub coloreaTabla(ByRef placa As DataGridView, ByVal color As System.Drawing.Color, ByVal col As Integer, ByVal reng As Integer)
      placa.Rows(col).Cells(reng).Style.BackColor = color
   End Sub

End Module
