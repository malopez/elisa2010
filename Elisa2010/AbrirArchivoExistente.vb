﻿Public Class frmAbrirArchivoExistente


   Private Sub btnLeerArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerArchivoExistente.Click
      abreArchivoExcel(placaLector)
   End Sub

   Private Sub btnObtenResultadosDA_Click(sender As System.Object, e As System.EventArgs) Handles btnObtenResultadosDA.Click
      Dim desdeArchivo As Integer = 1
      Dim cp1, cp2, cp3 As Decimal
      Dim cn1, cn2, cn3 As Decimal
      Me.btnLeerArchivoExistente.Enabled = False
      cp1 = CDec(Me.txtCPDAValor1.Text)
      cp2 = CDec(Me.txtCPDAValor2.Text)
      cp3 = CDec(Me.txtCPDAValor3.Text)
      cn1 = CDec(Me.txtCNDAValor1.Text)
      cn2 = CDec(Me.txtCNDAValor2.Text)
      cn3 = CDec(Me.txtCNDAValor3.Text)
      calculaValores("Laringotraqueitis Aviar", "Grupo de títulos", "%", desdeArchivo, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, CDec(0.15), CDec(1.45), CDec(3.726), cp1, cp2, cp3, cn1, cn2, cn3)
   End Sub
End Class