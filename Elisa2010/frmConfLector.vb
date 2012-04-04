Imports System.Data.SqlClient

Public Class frmConfLector

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      Me.Close()
   End Sub

   Private Sub TbllectorplacasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TbllectorplacasBindingNavigatorSaveItem.Click
      Me.Validate()
      Try
         Me.TbllectorplacasBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.BvtselisaDataSet)
      Catch ex As DBConcurrencyException
         MessageBox.Show("Ha ocurrido un error de concurrencia y el registro " & ex.GetType.ToString & "no se ha actualizado.")
      Catch ex As DataException
         MessageBox.Show(ex.Message, ex.GetType.ToString)
         Me.TbllectorplacasBindingSource.CancelEdit()
      Catch ex As SqlException
         MessageBox.Show("SQL Server Error #" & ex.Number & ": " & ex.GetType.ToString, ex.GetType.ToString)
      End Try
   End Sub

   Private Sub frmConfLector_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BvtselisaDataSet.tbllectorplacas' table. You can move, or remove it, as needed.
      Me.TbllectorplacasTableAdapter.Fill(Me.BvtselisaDataSet.tbllectorplacas)

   End Sub

   Private Sub LectorDefaultCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles LectorDefaultCheckBox.CheckedChanged

   End Sub

   Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

   End Sub

   Private Sub TbllectorplacasBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles TbllectorplacasBindingNavigator.RefreshItems

   End Sub
End Class