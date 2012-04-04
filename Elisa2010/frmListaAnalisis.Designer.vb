<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarListaAnalisis
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarListaAnalisis))
      Dim IdAnalisisLabel As System.Windows.Forms.Label
      Dim NombreAnalisisLabel As System.Windows.Forms.Label
      Me.BvtselisaDataSet = New Elisa2010.bvtselisaDataSet()
      Me.TblanalisisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TblanalisisTableAdapter = New Elisa2010.bvtselisaDataSetTableAdapters.tblanalisisTableAdapter()
      Me.TableAdapterManager = New Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager()
      Me.TblanalisisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.TblanalisisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.NombreAnalisisTextBox = New System.Windows.Forms.TextBox()
      Me.IdAnalisisTextBox = New System.Windows.Forms.TextBox()
      Me.TblclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TblclienteTableAdapter = New Elisa2010.bvtselisaDataSetTableAdapters.tblclienteTableAdapter()
      IdAnalisisLabel = New System.Windows.Forms.Label()
      NombreAnalisisLabel = New System.Windows.Forms.Label()
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblanalisisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblanalisisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TblanalisisBindingNavigator.SuspendLayout()
      CType(Me.TblclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'BvtselisaDataSet
      '
      Me.BvtselisaDataSet.DataSetName = "bvtselisaDataSet"
      Me.BvtselisaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'TblanalisisBindingSource
      '
      Me.TblanalisisBindingSource.DataMember = "tblanalisis"
      Me.TblanalisisBindingSource.DataSource = Me.BvtselisaDataSet
      '
      'TblanalisisTableAdapter
      '
      Me.TblanalisisTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.tblanalisisTableAdapter = Me.TblanalisisTableAdapter
      Me.TableAdapterManager.tblclienteTableAdapter = Me.TblclienteTableAdapter
      Me.TableAdapterManager.tbllectorplacasTableAdapter = Nothing
      Me.TableAdapterManager.tblplacaleidaTableAdapter = Nothing
      Me.TableAdapterManager.tblregistroanalisisTableAdapter = Nothing
      Me.TableAdapterManager.tblresultadosTableAdapter = Nothing
      Me.TableAdapterManager.UpdateOrder = Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'TblanalisisBindingNavigator
      '
      Me.TblanalisisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.TblanalisisBindingNavigator.BindingSource = Me.TblanalisisBindingSource
      Me.TblanalisisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.TblanalisisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.TblanalisisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblanalisisBindingNavigatorSaveItem})
      Me.TblanalisisBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.TblanalisisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.TblanalisisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.TblanalisisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.TblanalisisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.TblanalisisBindingNavigator.Name = "TblanalisisBindingNavigator"
      Me.TblanalisisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.TblanalisisBindingNavigator.Size = New System.Drawing.Size(567, 25)
      Me.TblanalisisBindingNavigator.TabIndex = 0
      Me.TblanalisisBindingNavigator.Text = "Permite realizar acciones sobre la tabla"
      '
      'BindingNavigatorMoveFirstItem
      '
      Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
      Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveFirstItem.Text = "Regresar al primero"
      '
      'BindingNavigatorMovePreviousItem
      '
      Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
      Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMovePreviousItem.Text = "Regresar al anterior"
      '
      'BindingNavigatorSeparator
      '
      Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorPositionItem
      '
      Me.BindingNavigatorPositionItem.AccessibleName = "Position"
      Me.BindingNavigatorPositionItem.AutoSize = False
      Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
      Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
      Me.BindingNavigatorPositionItem.Text = "0"
      Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveNextItem.Text = "Avanzar al siguiente"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveLastItem.Text = "Avanzar al último elemento"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorAddNewItem
      '
      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Agregar Análisis"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Eliminar Análisis"
      '
      'TblanalisisBindingNavigatorSaveItem
      '
      Me.TblanalisisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.TblanalisisBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblanalisisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.TblanalisisBindingNavigatorSaveItem.Name = "TblanalisisBindingNavigatorSaveItem"
      Me.TblanalisisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.TblanalisisBindingNavigatorSaveItem.Text = "Salvar Cambios"
      '
      'IdAnalisisLabel
      '
      IdAnalisisLabel.AutoSize = True
      IdAnalisisLabel.Location = New System.Drawing.Point(23, 55)
      IdAnalisisLabel.Name = "IdAnalisisLabel"
      IdAnalisisLabel.Size = New System.Drawing.Size(65, 13)
      IdAnalisisLabel.TabIndex = 1
      IdAnalisisLabel.Text = "No. Analisis:"
      '
      'NombreAnalisisLabel
      '
      NombreAnalisisLabel.AutoSize = True
      NombreAnalisisLabel.Location = New System.Drawing.Point(23, 96)
      NombreAnalisisLabel.Name = "NombreAnalisisLabel"
      NombreAnalisisLabel.Size = New System.Drawing.Size(102, 13)
      NombreAnalisisLabel.TabIndex = 3
      NombreAnalisisLabel.Text = "Nombre del Analisis:"
      '
      'NombreAnalisisTextBox
      '
      Me.NombreAnalisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblanalisisBindingSource, "nombreAnalisis", True))
      Me.NombreAnalisisTextBox.Location = New System.Drawing.Point(132, 93)
      Me.NombreAnalisisTextBox.Name = "NombreAnalisisTextBox"
      Me.NombreAnalisisTextBox.Size = New System.Drawing.Size(415, 20)
      Me.NombreAnalisisTextBox.TabIndex = 4
      '
      'IdAnalisisTextBox
      '
      Me.IdAnalisisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblanalisisBindingSource, "idAnalisis", True))
      Me.IdAnalisisTextBox.Location = New System.Drawing.Point(132, 52)
      Me.IdAnalisisTextBox.Name = "IdAnalisisTextBox"
      Me.IdAnalisisTextBox.Size = New System.Drawing.Size(137, 20)
      Me.IdAnalisisTextBox.TabIndex = 5
      '
      'TblclienteBindingSource
      '
      Me.TblclienteBindingSource.DataMember = "tblcliente"
      Me.TblclienteBindingSource.DataSource = Me.BvtselisaDataSet
      '
      'TblclienteTableAdapter
      '
      Me.TblclienteTableAdapter.ClearBeforeFill = True
      '
      'frmEditarListaAnalisis
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(567, 142)
      Me.Controls.Add(Me.IdAnalisisTextBox)
      Me.Controls.Add(NombreAnalisisLabel)
      Me.Controls.Add(Me.NombreAnalisisTextBox)
      Me.Controls.Add(IdAnalisisLabel)
      Me.Controls.Add(Me.TblanalisisBindingNavigator)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmEditarListaAnalisis"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Operaciones sobre Análisis Disponibles"
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblanalisisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblanalisisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TblanalisisBindingNavigator.ResumeLayout(False)
      Me.TblanalisisBindingNavigator.PerformLayout()
      CType(Me.TblclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents BvtselisaDataSet As Elisa2010.bvtselisaDataSet
   Friend WithEvents TblanalisisBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TblanalisisTableAdapter As Elisa2010.bvtselisaDataSetTableAdapters.tblanalisisTableAdapter
   Friend WithEvents TableAdapterManager As Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager
   Friend WithEvents TblanalisisBindingNavigator As System.Windows.Forms.BindingNavigator
   Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
   Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents TblanalisisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents NombreAnalisisTextBox As System.Windows.Forms.TextBox
   Friend WithEvents IdAnalisisTextBox As System.Windows.Forms.TextBox
   Friend WithEvents TblclienteTableAdapter As Elisa2010.bvtselisaDataSetTableAdapters.tblclienteTableAdapter
   Friend WithEvents TblclienteBindingSource As System.Windows.Forms.BindingSource
End Class
