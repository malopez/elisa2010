<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfLector
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
      Dim NomLectorLabel As System.Windows.Forms.Label
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfLector))
      Me.btnAceptar = New System.Windows.Forms.Button()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.grbDefineLector = New System.Windows.Forms.GroupBox()
      Me.NomLectorComboBox = New System.Windows.Forms.ComboBox()
      Me.TbllectorplacasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.BvtselisaDataSet = New Elisa2010.bvtselisaDataSet()
      Me.LectorDefaultCheckBox = New System.Windows.Forms.CheckBox()
      Me.TbllectorplacasTableAdapter = New Elisa2010.bvtselisaDataSetTableAdapters.tbllectorplacasTableAdapter()
      Me.TableAdapterManager = New Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager()
      Me.TbllectorplacasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.TbllectorplacasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.grbBaudiosPorSegundo = New System.Windows.Forms.GroupBox()
      Me.rbtBPS9600 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS4800 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS2400 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS1200 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS600 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS300 = New System.Windows.Forms.RadioButton()
      Me.rbtBPS110 = New System.Windows.Forms.RadioButton()
      Me.grbBitsDeDatos = New System.Windows.Forms.GroupBox()
      Me.rbtBitsDeDatos8 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos7 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos6 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos5 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos4 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos3 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos2 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeDatos1 = New System.Windows.Forms.RadioButton()
      Me.grbParidad = New System.Windows.Forms.GroupBox()
      Me.RadioButton1 = New System.Windows.Forms.RadioButton()
      Me.rbtParidad1 = New System.Windows.Forms.RadioButton()
      Me.grbBitsDeParada = New System.Windows.Forms.GroupBox()
      Me.rdbBitsDeParada3 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeParada2 = New System.Windows.Forms.RadioButton()
      Me.rbtBitsDeParada1 = New System.Windows.Forms.RadioButton()
      NomLectorLabel = New System.Windows.Forms.Label()
      Me.grbDefineLector.SuspendLayout()
      CType(Me.TbllectorplacasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbllectorplacasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TbllectorplacasBindingNavigator.SuspendLayout()
      Me.grbBaudiosPorSegundo.SuspendLayout()
      Me.grbBitsDeDatos.SuspendLayout()
      Me.grbParidad.SuspendLayout()
      Me.grbBitsDeParada.SuspendLayout()
      Me.SuspendLayout()
      '
      'NomLectorLabel
      '
      NomLectorLabel.AutoSize = True
      NomLectorLabel.Location = New System.Drawing.Point(6, 19)
      NomLectorLabel.Name = "NomLectorLabel"
      NomLectorLabel.Size = New System.Drawing.Size(97, 13)
      NomLectorLabel.TabIndex = 1
      NomLectorLabel.Text = "Nombre del Lector:"
      '
      'btnAceptar
      '
      Me.btnAceptar.Location = New System.Drawing.Point(365, 280)
      Me.btnAceptar.Name = "btnAceptar"
      Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
      Me.btnAceptar.TabIndex = 0
      Me.btnAceptar.Text = "Aceptar"
      Me.btnAceptar.UseVisualStyleBackColor = True
      '
      'btnCancelar
      '
      Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelar.Location = New System.Drawing.Point(446, 280)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnCancelar.TabIndex = 1
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'grbDefineLector
      '
      Me.grbDefineLector.Controls.Add(Me.NomLectorComboBox)
      Me.grbDefineLector.Controls.Add(Me.LectorDefaultCheckBox)
      Me.grbDefineLector.Controls.Add(NomLectorLabel)
      Me.grbDefineLector.Location = New System.Drawing.Point(12, 28)
      Me.grbDefineLector.Name = "grbDefineLector"
      Me.grbDefineLector.Size = New System.Drawing.Size(509, 44)
      Me.grbDefineLector.TabIndex = 2
      Me.grbDefineLector.TabStop = False
      '
      'NomLectorComboBox
      '
      Me.NomLectorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbllectorplacasBindingSource, "nomLector", True))
      Me.NomLectorComboBox.FormattingEnabled = True
      Me.NomLectorComboBox.Location = New System.Drawing.Point(127, 16)
      Me.NomLectorComboBox.Name = "NomLectorComboBox"
      Me.NomLectorComboBox.Size = New System.Drawing.Size(305, 21)
      Me.NomLectorComboBox.TabIndex = 4
      '
      'TbllectorplacasBindingSource
      '
      Me.TbllectorplacasBindingSource.DataMember = "tbllectorplacas"
      Me.TbllectorplacasBindingSource.DataSource = Me.BvtselisaDataSet
      '
      'BvtselisaDataSet
      '
      Me.BvtselisaDataSet.DataSetName = "bvtselisaDataSet"
      Me.BvtselisaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'LectorDefaultCheckBox
      '
      Me.LectorDefaultCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbllectorplacasBindingSource, "lectorDefault", True))
      Me.LectorDefaultCheckBox.Location = New System.Drawing.Point(438, 13)
      Me.LectorDefaultCheckBox.Name = "LectorDefaultCheckBox"
      Me.LectorDefaultCheckBox.Size = New System.Drawing.Size(63, 24)
      Me.LectorDefaultCheckBox.TabIndex = 3
      Me.LectorDefaultCheckBox.Text = "Default"
      Me.LectorDefaultCheckBox.UseVisualStyleBackColor = True
      '
      'TbllectorplacasTableAdapter
      '
      Me.TbllectorplacasTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.tblanalisisTableAdapter = Nothing
      Me.TableAdapterManager.tblclienteTableAdapter = Nothing
      Me.TableAdapterManager.tbllectorplacasTableAdapter = Me.TbllectorplacasTableAdapter
      Me.TableAdapterManager.tblplacaleidaTableAdapter = Nothing
      Me.TableAdapterManager.tblregistroanalisisTableAdapter = Nothing
      Me.TableAdapterManager.tblresultadosTableAdapter = Nothing
      Me.TableAdapterManager.UpdateOrder = Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'TbllectorplacasBindingNavigator
      '
      Me.TbllectorplacasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.TbllectorplacasBindingNavigator.BindingSource = Me.TbllectorplacasBindingSource
      Me.TbllectorplacasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.TbllectorplacasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.TbllectorplacasBindingNavigator.Enabled = False
      Me.TbllectorplacasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbllectorplacasBindingNavigatorSaveItem})
      Me.TbllectorplacasBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.TbllectorplacasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.TbllectorplacasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.TbllectorplacasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.TbllectorplacasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.TbllectorplacasBindingNavigator.Name = "TbllectorplacasBindingNavigator"
      Me.TbllectorplacasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.TbllectorplacasBindingNavigator.Size = New System.Drawing.Size(533, 25)
      Me.TbllectorplacasBindingNavigator.TabIndex = 3
      Me.TbllectorplacasBindingNavigator.Text = "BindingNavigator1"
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
      'TbllectorplacasBindingNavigatorSaveItem
      '
      Me.TbllectorplacasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.TbllectorplacasBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbllectorplacasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.TbllectorplacasBindingNavigatorSaveItem.Name = "TbllectorplacasBindingNavigatorSaveItem"
      Me.TbllectorplacasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.TbllectorplacasBindingNavigatorSaveItem.Text = "Save Data"
      '
      'grbBaudiosPorSegundo
      '
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS9600)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS4800)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS2400)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS1200)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS600)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS300)
      Me.grbBaudiosPorSegundo.Controls.Add(Me.rbtBPS110)
      Me.grbBaudiosPorSegundo.Location = New System.Drawing.Point(48, 88)
      Me.grbBaudiosPorSegundo.Name = "grbBaudiosPorSegundo"
      Me.grbBaudiosPorSegundo.Size = New System.Drawing.Size(103, 208)
      Me.grbBaudiosPorSegundo.TabIndex = 4
      Me.grbBaudiosPorSegundo.TabStop = False
      Me.grbBaudiosPorSegundo.Text = "Baudios por segundo"
      '
      'rbtBPS9600
      '
      Me.rbtBPS9600.Location = New System.Drawing.Point(6, 172)
      Me.rbtBPS9600.Name = "rbtBPS9600"
      Me.rbtBPS9600.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS9600.TabIndex = 6
      Me.rbtBPS9600.TabStop = True
      Me.rbtBPS9600.Text = "9600"
      Me.rbtBPS9600.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS9600.UseVisualStyleBackColor = True
      '
      'rbtBPS4800
      '
      Me.rbtBPS4800.Location = New System.Drawing.Point(6, 149)
      Me.rbtBPS4800.Name = "rbtBPS4800"
      Me.rbtBPS4800.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS4800.TabIndex = 5
      Me.rbtBPS4800.TabStop = True
      Me.rbtBPS4800.Text = "4800"
      Me.rbtBPS4800.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS4800.UseVisualStyleBackColor = True
      '
      'rbtBPS2400
      '
      Me.rbtBPS2400.Location = New System.Drawing.Point(6, 126)
      Me.rbtBPS2400.Name = "rbtBPS2400"
      Me.rbtBPS2400.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS2400.TabIndex = 4
      Me.rbtBPS2400.TabStop = True
      Me.rbtBPS2400.Text = "2400"
      Me.rbtBPS2400.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS2400.UseVisualStyleBackColor = True
      '
      'rbtBPS1200
      '
      Me.rbtBPS1200.Location = New System.Drawing.Point(6, 103)
      Me.rbtBPS1200.Name = "rbtBPS1200"
      Me.rbtBPS1200.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS1200.TabIndex = 3
      Me.rbtBPS1200.TabStop = True
      Me.rbtBPS1200.Text = "1200"
      Me.rbtBPS1200.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS1200.UseVisualStyleBackColor = True
      '
      'rbtBPS600
      '
      Me.rbtBPS600.Location = New System.Drawing.Point(6, 80)
      Me.rbtBPS600.Name = "rbtBPS600"
      Me.rbtBPS600.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS600.TabIndex = 2
      Me.rbtBPS600.TabStop = True
      Me.rbtBPS600.Text = "600"
      Me.rbtBPS600.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS600.UseVisualStyleBackColor = True
      '
      'rbtBPS300
      '
      Me.rbtBPS300.Location = New System.Drawing.Point(6, 57)
      Me.rbtBPS300.Name = "rbtBPS300"
      Me.rbtBPS300.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS300.TabIndex = 1
      Me.rbtBPS300.TabStop = True
      Me.rbtBPS300.Text = "300"
      Me.rbtBPS300.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS300.UseVisualStyleBackColor = True
      '
      'rbtBPS110
      '
      Me.rbtBPS110.Location = New System.Drawing.Point(6, 34)
      Me.rbtBPS110.Name = "rbtBPS110"
      Me.rbtBPS110.Size = New System.Drawing.Size(49, 17)
      Me.rbtBPS110.TabIndex = 0
      Me.rbtBPS110.TabStop = True
      Me.rbtBPS110.Text = "110"
      Me.rbtBPS110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtBPS110.UseVisualStyleBackColor = True
      '
      'grbBitsDeDatos
      '
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos8)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos7)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos6)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos5)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos4)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos3)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos2)
      Me.grbBitsDeDatos.Controls.Add(Me.rbtBitsDeDatos1)
      Me.grbBitsDeDatos.Location = New System.Drawing.Point(157, 88)
      Me.grbBitsDeDatos.Name = "grbBitsDeDatos"
      Me.grbBitsDeDatos.Size = New System.Drawing.Size(103, 219)
      Me.grbBitsDeDatos.TabIndex = 5
      Me.grbBitsDeDatos.TabStop = False
      Me.grbBitsDeDatos.Text = "Bits de datos"
      '
      'rbtBitsDeDatos8
      '
      Me.rbtBitsDeDatos8.Location = New System.Drawing.Point(6, 195)
      Me.rbtBitsDeDatos8.Name = "rbtBitsDeDatos8"
      Me.rbtBitsDeDatos8.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos8.TabIndex = 14
      Me.rbtBitsDeDatos8.TabStop = True
      Me.rbtBitsDeDatos8.Text = "8"
      Me.rbtBitsDeDatos8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos8.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos7
      '
      Me.rbtBitsDeDatos7.Location = New System.Drawing.Point(6, 172)
      Me.rbtBitsDeDatos7.Name = "rbtBitsDeDatos7"
      Me.rbtBitsDeDatos7.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos7.TabIndex = 13
      Me.rbtBitsDeDatos7.TabStop = True
      Me.rbtBitsDeDatos7.Text = "7"
      Me.rbtBitsDeDatos7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos7.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos6
      '
      Me.rbtBitsDeDatos6.Location = New System.Drawing.Point(6, 149)
      Me.rbtBitsDeDatos6.Name = "rbtBitsDeDatos6"
      Me.rbtBitsDeDatos6.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos6.TabIndex = 12
      Me.rbtBitsDeDatos6.TabStop = True
      Me.rbtBitsDeDatos6.Text = "6"
      Me.rbtBitsDeDatos6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos6.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos5
      '
      Me.rbtBitsDeDatos5.Location = New System.Drawing.Point(6, 126)
      Me.rbtBitsDeDatos5.Name = "rbtBitsDeDatos5"
      Me.rbtBitsDeDatos5.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos5.TabIndex = 11
      Me.rbtBitsDeDatos5.TabStop = True
      Me.rbtBitsDeDatos5.Text = "5"
      Me.rbtBitsDeDatos5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos5.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos4
      '
      Me.rbtBitsDeDatos4.Location = New System.Drawing.Point(6, 103)
      Me.rbtBitsDeDatos4.Name = "rbtBitsDeDatos4"
      Me.rbtBitsDeDatos4.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos4.TabIndex = 10
      Me.rbtBitsDeDatos4.TabStop = True
      Me.rbtBitsDeDatos4.Text = "4"
      Me.rbtBitsDeDatos4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos4.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos3
      '
      Me.rbtBitsDeDatos3.Location = New System.Drawing.Point(6, 80)
      Me.rbtBitsDeDatos3.Name = "rbtBitsDeDatos3"
      Me.rbtBitsDeDatos3.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos3.TabIndex = 9
      Me.rbtBitsDeDatos3.TabStop = True
      Me.rbtBitsDeDatos3.Text = "3"
      Me.rbtBitsDeDatos3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos3.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos2
      '
      Me.rbtBitsDeDatos2.Location = New System.Drawing.Point(6, 57)
      Me.rbtBitsDeDatos2.Name = "rbtBitsDeDatos2"
      Me.rbtBitsDeDatos2.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos2.TabIndex = 8
      Me.rbtBitsDeDatos2.TabStop = True
      Me.rbtBitsDeDatos2.Text = "2"
      Me.rbtBitsDeDatos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos2.UseVisualStyleBackColor = True
      '
      'rbtBitsDeDatos1
      '
      Me.rbtBitsDeDatos1.Location = New System.Drawing.Point(6, 34)
      Me.rbtBitsDeDatos1.Name = "rbtBitsDeDatos1"
      Me.rbtBitsDeDatos1.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeDatos1.TabIndex = 7
      Me.rbtBitsDeDatos1.TabStop = True
      Me.rbtBitsDeDatos1.Text = "1"
      Me.rbtBitsDeDatos1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeDatos1.UseVisualStyleBackColor = True
      '
      'grbParidad
      '
      Me.grbParidad.Controls.Add(Me.RadioButton1)
      Me.grbParidad.Controls.Add(Me.rbtParidad1)
      Me.grbParidad.Location = New System.Drawing.Point(266, 88)
      Me.grbParidad.Name = "grbParidad"
      Me.grbParidad.Size = New System.Drawing.Size(103, 106)
      Me.grbParidad.TabIndex = 6
      Me.grbParidad.TabStop = False
      Me.grbParidad.Text = "Paridad"
      '
      'RadioButton1
      '
      Me.RadioButton1.AutoSize = True
      Me.RadioButton1.Location = New System.Drawing.Point(6, 57)
      Me.RadioButton1.Name = "RadioButton1"
      Me.RadioButton1.Size = New System.Drawing.Size(83, 17)
      Me.RadioButton1.TabIndex = 8
      Me.RadioButton1.TabStop = True
      Me.RadioButton1.Text = "Con Paridad"
      Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.RadioButton1.UseVisualStyleBackColor = True
      '
      'rbtParidad1
      '
      Me.rbtParidad1.AutoSize = True
      Me.rbtParidad1.Location = New System.Drawing.Point(6, 34)
      Me.rbtParidad1.Name = "rbtParidad1"
      Me.rbtParidad1.Size = New System.Drawing.Size(79, 17)
      Me.rbtParidad1.TabIndex = 7
      Me.rbtParidad1.TabStop = True
      Me.rbtParidad1.Text = "Sin Paridad"
      Me.rbtParidad1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rbtParidad1.UseVisualStyleBackColor = True
      '
      'grbBitsDeParada
      '
      Me.grbBitsDeParada.Controls.Add(Me.rdbBitsDeParada3)
      Me.grbBitsDeParada.Controls.Add(Me.rbtBitsDeParada2)
      Me.grbBitsDeParada.Controls.Add(Me.rbtBitsDeParada1)
      Me.grbBitsDeParada.Location = New System.Drawing.Point(375, 88)
      Me.grbBitsDeParada.Name = "grbBitsDeParada"
      Me.grbBitsDeParada.Size = New System.Drawing.Size(103, 106)
      Me.grbBitsDeParada.TabIndex = 7
      Me.grbBitsDeParada.TabStop = False
      Me.grbBitsDeParada.Text = "Bits de parada"
      '
      'rdbBitsDeParada3
      '
      Me.rdbBitsDeParada3.Location = New System.Drawing.Point(6, 80)
      Me.rdbBitsDeParada3.Name = "rdbBitsDeParada3"
      Me.rdbBitsDeParada3.Size = New System.Drawing.Size(49, 17)
      Me.rdbBitsDeParada3.TabIndex = 12
      Me.rdbBitsDeParada3.TabStop = True
      Me.rdbBitsDeParada3.Text = "1.5"
      Me.rdbBitsDeParada3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rdbBitsDeParada3.UseVisualStyleBackColor = True
      '
      'rbtBitsDeParada2
      '
      Me.rbtBitsDeParada2.Location = New System.Drawing.Point(6, 57)
      Me.rbtBitsDeParada2.Name = "rbtBitsDeParada2"
      Me.rbtBitsDeParada2.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeParada2.TabIndex = 11
      Me.rbtBitsDeParada2.TabStop = True
      Me.rbtBitsDeParada2.Text = "2"
      Me.rbtBitsDeParada2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeParada2.UseVisualStyleBackColor = True
      '
      'rbtBitsDeParada1
      '
      Me.rbtBitsDeParada1.Location = New System.Drawing.Point(6, 34)
      Me.rbtBitsDeParada1.Name = "rbtBitsDeParada1"
      Me.rbtBitsDeParada1.Size = New System.Drawing.Size(49, 17)
      Me.rbtBitsDeParada1.TabIndex = 10
      Me.rbtBitsDeParada1.TabStop = True
      Me.rbtBitsDeParada1.Text = "1"
      Me.rbtBitsDeParada1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.rbtBitsDeParada1.UseVisualStyleBackColor = True
      '
      'frmConfLector
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(533, 321)
      Me.Controls.Add(Me.grbBitsDeParada)
      Me.Controls.Add(Me.grbParidad)
      Me.Controls.Add(Me.grbBitsDeDatos)
      Me.Controls.Add(Me.grbBaudiosPorSegundo)
      Me.Controls.Add(Me.TbllectorplacasBindingNavigator)
      Me.Controls.Add(Me.grbDefineLector)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.btnAceptar)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmConfLector"
      Me.Text = "Configuración del Lector "
      Me.grbDefineLector.ResumeLayout(False)
      Me.grbDefineLector.PerformLayout()
      CType(Me.TbllectorplacasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbllectorplacasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TbllectorplacasBindingNavigator.ResumeLayout(False)
      Me.TbllectorplacasBindingNavigator.PerformLayout()
      Me.grbBaudiosPorSegundo.ResumeLayout(False)
      Me.grbBitsDeDatos.ResumeLayout(False)
      Me.grbParidad.ResumeLayout(False)
      Me.grbParidad.PerformLayout()
      Me.grbBitsDeParada.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnAceptar As System.Windows.Forms.Button
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents grbDefineLector As System.Windows.Forms.GroupBox
   Friend WithEvents BvtselisaDataSet As Elisa2010.bvtselisaDataSet
   Friend WithEvents TbllectorplacasBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TbllectorplacasTableAdapter As Elisa2010.bvtselisaDataSetTableAdapters.tbllectorplacasTableAdapter
   Friend WithEvents TableAdapterManager As Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager
   Friend WithEvents TbllectorplacasBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents TbllectorplacasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents LectorDefaultCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents grbBaudiosPorSegundo As System.Windows.Forms.GroupBox
   Friend WithEvents rbtBPS2400 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBPS1200 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBPS600 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBPS300 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBPS110 As System.Windows.Forms.RadioButton
   Friend WithEvents grbBitsDeDatos As System.Windows.Forms.GroupBox
   Friend WithEvents grbParidad As System.Windows.Forms.GroupBox
   Friend WithEvents grbBitsDeParada As System.Windows.Forms.GroupBox
   Friend WithEvents rbtBPS9600 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBPS4800 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos8 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos7 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos6 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos5 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos4 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos3 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos2 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeDatos1 As System.Windows.Forms.RadioButton
   Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtParidad1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBitsDeParada3 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeParada2 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtBitsDeParada1 As System.Windows.Forms.RadioButton
   Friend WithEvents NomLectorComboBox As System.Windows.Forms.ComboBox
End Class
