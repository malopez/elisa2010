﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaAnalisis
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaAnalisis))
      Me.BvtselisaDataSet1 = New Elisa2010.bvtselisaDataSet1()
      Me.TblanalisisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TblanalisisTableAdapter = New Elisa2010.bvtselisaDataSet1TableAdapters.tblanalisisTableAdapter()
      Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.dgwListadoAnalisis = New System.Windows.Forms.DataGridView()
      Me.IdAnalisisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.NombreAnalisisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      CType(Me.BvtselisaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblanalisisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.BindingNavigator1.SuspendLayout()
      CType(Me.dgwListadoAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'BvtselisaDataSet1
      '
      Me.BvtselisaDataSet1.DataSetName = "bvtselisaDataSet1"
      Me.BvtselisaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'TblanalisisBindingSource
      '
      Me.TblanalisisBindingSource.DataMember = "tblanalisis"
      Me.TblanalisisBindingSource.DataSource = Me.BvtselisaDataSet1
      '
      'TblanalisisTableAdapter
      '
      Me.TblanalisisTableAdapter.ClearBeforeFill = True
      '
      'BindingNavigator1
      '
      Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.BindingNavigator1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.BindingNavigator1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
      Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
      Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
      Me.BindingNavigator1.Location = New System.Drawing.Point(18, 247)
      Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.BindingNavigator1.Name = "BindingNavigator1"
      Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
      Me.BindingNavigator1.Size = New System.Drawing.Size(255, 25)
      Me.BindingNavigator1.TabIndex = 3
      Me.BindingNavigator1.Text = "Acciones posibles sobre los datos"
      '
      'BindingNavigatorAddNewItem
      '
      Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
      Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorAddNewItem.Text = "Add new"
      '
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
      '
      'BindingNavigatorMoveFirstItem
      '
      Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
      Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveFirstItem.Text = "Move first"
      '
      'BindingNavigatorMovePreviousItem
      '
      Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
      Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
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
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveNextItem.Text = "Move next"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveLastItem.Text = "Move last"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'dgwListadoAnalisis
      '
      Me.dgwListadoAnalisis.AutoGenerateColumns = False
      Me.dgwListadoAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgwListadoAnalisis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAnalisisDataGridViewTextBoxColumn, Me.NombreAnalisisDataGridViewTextBoxColumn})
      Me.dgwListadoAnalisis.DataSource = Me.TblanalisisBindingSource
      Me.dgwListadoAnalisis.GridColor = System.Drawing.SystemColors.ControlLight
      Me.dgwListadoAnalisis.Location = New System.Drawing.Point(18, 72)
      Me.dgwListadoAnalisis.Name = "dgwListadoAnalisis"
      Me.dgwListadoAnalisis.Size = New System.Drawing.Size(857, 150)
      Me.dgwListadoAnalisis.TabIndex = 4
      '
      'IdAnalisisDataGridViewTextBoxColumn
      '
      Me.IdAnalisisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.IdAnalisisDataGridViewTextBoxColumn.DataPropertyName = "idAnalisis"
      Me.IdAnalisisDataGridViewTextBoxColumn.FillWeight = 40.60914!
      Me.IdAnalisisDataGridViewTextBoxColumn.HeaderText = "No. de Analisis"
      Me.IdAnalisisDataGridViewTextBoxColumn.Name = "IdAnalisisDataGridViewTextBoxColumn"
      '
      'NombreAnalisisDataGridViewTextBoxColumn
      '
      Me.NombreAnalisisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.NombreAnalisisDataGridViewTextBoxColumn.DataPropertyName = "nombreAnalisis"
      Me.NombreAnalisisDataGridViewTextBoxColumn.FillWeight = 159.3909!
      Me.NombreAnalisisDataGridViewTextBoxColumn.HeaderText = "Nombre del Análisis"
      Me.NombreAnalisisDataGridViewTextBoxColumn.Name = "NombreAnalisisDataGridViewTextBoxColumn"
      '
      'frmListaAnalisis
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoSize = True
      Me.ClientSize = New System.Drawing.Size(983, 281)
      Me.Controls.Add(Me.dgwListadoAnalisis)
      Me.Controls.Add(Me.BindingNavigator1)
      Me.Name = "frmListaAnalisis"
      Me.Text = "Listado de Análisis Disponibles"
      CType(Me.BvtselisaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblanalisisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.BindingNavigator1.ResumeLayout(False)
      Me.BindingNavigator1.PerformLayout()
      CType(Me.dgwListadoAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents BvtselisaDataSet1 As Elisa2010.bvtselisaDataSet1
   Friend WithEvents TblanalisisBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TblanalisisTableAdapter As Elisa2010.bvtselisaDataSet1TableAdapters.tblanalisisTableAdapter
   Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents dgwListadoAnalisis As System.Windows.Forms.DataGridView
   Friend WithEvents IdAnalisisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents NombreAnalisisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
