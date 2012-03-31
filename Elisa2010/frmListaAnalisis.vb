Public Class frmEditarListaAnalisis

   Private Sub TblanalisisBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblanalisisBindingNavigatorSaveItem.Click
      Me.Validate()
      Me.TblanalisisBindingSource.EndEdit()
      Me.TableAdapterManager.UpdateAll(Me.BvtselisaDataSet)

   End Sub

   Private Sub frmListaAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tblcliente' table. You can move, or remove it, as needed.
      Me.TblclienteTableAdapter.Fill(Me.BvtselisaDataSet.tblcliente)
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tblanalisis' table. You can move, or remove it, as needed.
      Me.TblanalisisTableAdapter.Fill(Me.BvtselisaDataSet.tblanalisis)

   End Sub
End Class