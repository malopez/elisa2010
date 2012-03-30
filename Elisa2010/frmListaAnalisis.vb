Public Class frmListaAnalisis

   Private Sub frmListaAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet1.tblanalisis' table. You can move, or remove it, as needed.
      Me.TblanalisisTableAdapter.Fill(Me.BvtselisaDataSet1.tblanalisis)

   End Sub

End Class