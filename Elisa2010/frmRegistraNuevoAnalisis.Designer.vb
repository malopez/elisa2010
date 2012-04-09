<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistraNuevoAnalisis
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistraNuevoAnalisis))
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.cbbNombreCliente = New System.Windows.Forms.ComboBox()
      Me.lblFechaRecepcion = New System.Windows.Forms.Label()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.cbbNombreAnalisis = New System.Windows.Forms.ComboBox()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.btnCambiarLector = New System.Windows.Forms.Button()
      Me.btnNuevoAnalisisCancelar = New System.Windows.Forms.Button()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
      Me.btnGuardarDatos = New System.Windows.Forms.Button()
      Me.sfdGuardarPlaca = New System.Windows.Forms.SaveFileDialog()
      Me.txtCP1Letra1 = New System.Windows.Forms.TextBox()
      Me.txtCP1Valor1 = New System.Windows.Forms.TextBox()
      Me.txtCP2Letra2 = New System.Windows.Forms.TextBox()
      Me.txtCP2Valor2 = New System.Windows.Forms.TextBox()
      Me.txtCP3Letra3 = New System.Windows.Forms.TextBox()
      Me.txtCP3Valor3 = New System.Windows.Forms.TextBox()
      Me.txtCN1Letra1 = New System.Windows.Forms.TextBox()
      Me.txtCN1Valor1 = New System.Windows.Forms.TextBox()
      Me.txtCN2Letra2 = New System.Windows.Forms.TextBox()
      Me.txtCN2Valor2 = New System.Windows.Forms.TextBox()
      Me.txtCN3Letra3 = New System.Windows.Forms.TextBox()
      Me.txtCN3Valor3 = New System.Windows.Forms.TextBox()
      Me.lblCPNo1 = New System.Windows.Forms.Label()
      Me.lblCPNo2 = New System.Windows.Forms.Label()
      Me.lblCPNo3 = New System.Windows.Forms.Label()
      Me.lblCNNo3 = New System.Windows.Forms.Label()
      Me.lblCNNo2 = New System.Windows.Forms.Label()
      Me.lblCNNo1 = New System.Windows.Forms.Label()
      Me.grbControlesPositivos = New System.Windows.Forms.GroupBox()
      Me.grbControlesNegativos = New System.Windows.Forms.GroupBox()
      Me.btnCalcularValores = New System.Windows.Forms.Button()
      Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
      Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
      Me.BvtselisaDataSet = New Elisa2010.bvtselisaDataSet()
      Me.TblregistroanalisisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TblregistroanalisisTableAdapter = New Elisa2010.bvtselisaDataSetTableAdapters.tblregistroanalisisTableAdapter()
      Me.TableAdapterManager = New Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager()
      Me.TblregistroanalisisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
      Me.TblregistroanalisisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.NoCasoTextBox = New System.Windows.Forms.TextBox()
      Me.FechaRecepcionDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.grbControlesPositivos.SuspendLayout()
      Me.grbControlesNegativos.SuspendLayout()
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblregistroanalisisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TblregistroanalisisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TblregistroanalisisBindingNavigator.SuspendLayout()
      Me.SuspendLayout()
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.Location = New System.Drawing.Point(19, 38)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(88, 13)
      Me.lblNoCaso.TabIndex = 1
      Me.lblNoCaso.Text = "Número de caso:"
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.Location = New System.Drawing.Point(19, 83)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(99, 13)
      Me.lblNombreCliente.TabIndex = 2
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'cbbNombreCliente
      '
      Me.cbbNombreCliente.FormattingEnabled = True
      Me.cbbNombreCliente.Location = New System.Drawing.Point(124, 80)
      Me.cbbNombreCliente.Name = "cbbNombreCliente"
      Me.cbbNombreCliente.Size = New System.Drawing.Size(466, 21)
      Me.cbbNombreCliente.TabIndex = 2
      '
      'lblFechaRecepcion
      '
      Me.lblFechaRecepcion.AutoSize = True
      Me.lblFechaRecepcion.Location = New System.Drawing.Point(279, 38)
      Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
      Me.lblFechaRecepcion.Size = New System.Drawing.Size(105, 13)
      Me.lblFechaRecepcion.TabIndex = 4
      Me.lblFechaRecepcion.Text = "Fecha de recepción:"
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(19, 134)
      Me.lblNombreAnalisis.Name = "lblNombreAnalisis"
      Me.lblNombreAnalisis.Size = New System.Drawing.Size(101, 13)
      Me.lblNombreAnalisis.TabIndex = 6
      Me.lblNombreAnalisis.Text = "Nombre del análisis:"
      '
      'cbbNombreAnalisis
      '
      Me.cbbNombreAnalisis.FormattingEnabled = True
      Me.cbbNombreAnalisis.Location = New System.Drawing.Point(123, 131)
      Me.cbbNombreAnalisis.Name = "cbbNombreAnalisis"
      Me.cbbNombreAnalisis.Size = New System.Drawing.Size(467, 21)
      Me.cbbNombreAnalisis.TabIndex = 3
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(324, 184)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(75, 23)
      Me.btnLeerDatosPlaca.TabIndex = 4
      Me.btnLeerDatosPlaca.Text = "Leer Datos"
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'btnCambiarLector
      '
      Me.btnCambiarLector.Enabled = False
      Me.btnCambiarLector.Location = New System.Drawing.Point(405, 184)
      Me.btnCambiarLector.Name = "btnCambiarLector"
      Me.btnCambiarLector.Size = New System.Drawing.Size(102, 23)
      Me.btnCambiarLector.TabIndex = 10
      Me.btnCambiarLector.Text = "Cambiar Lector"
      Me.btnCambiarLector.UseVisualStyleBackColor = True
      '
      'btnNuevoAnalisisCancelar
      '
      Me.btnNuevoAnalisisCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnNuevoAnalisisCancelar.Location = New System.Drawing.Point(513, 184)
      Me.btnNuevoAnalisisCancelar.Name = "btnNuevoAnalisisCancelar"
      Me.btnNuevoAnalisisCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnNuevoAnalisisCancelar.TabIndex = 5
      Me.btnNuevoAnalisisCancelar.Text = "Cancelar"
      Me.btnNuevoAnalisisCancelar.UseVisualStyleBackColor = True
      '
      'SerialPort1
      '
      Me.SerialPort1.PortName = "COM3"
      Me.SerialPort1.StopBits = System.IO.Ports.StopBits.Two
      '
      'cmbComboPorts
      '
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(197, 184)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(121, 21)
      Me.cmbComboPorts.TabIndex = 19
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(22, 213)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(575, 110)
      Me.txtDatosRecibidos.TabIndex = 20
      Me.txtDatosRecibidos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
      '
      'btnGuardarDatos
      '
      Me.btnGuardarDatos.Location = New System.Drawing.Point(484, 329)
      Me.btnGuardarDatos.Name = "btnGuardarDatos"
      Me.btnGuardarDatos.Size = New System.Drawing.Size(113, 23)
      Me.btnGuardarDatos.TabIndex = 6
      Me.btnGuardarDatos.Text = "Guardar Datos"
      Me.btnGuardarDatos.UseVisualStyleBackColor = True
      '
      'txtCP1Letra1
      '
      Me.txtCP1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCP1Letra1.Name = "txtCP1Letra1"
      Me.txtCP1Letra1.Size = New System.Drawing.Size(25, 20)
      Me.txtCP1Letra1.TabIndex = 7
      '
      'txtCP1Valor1
      '
      Me.txtCP1Valor1.Location = New System.Drawing.Point(73, 25)
      Me.txtCP1Valor1.Name = "txtCP1Valor1"
      Me.txtCP1Valor1.Size = New System.Drawing.Size(25, 20)
      Me.txtCP1Valor1.TabIndex = 8
      '
      'txtCP2Letra2
      '
      Me.txtCP2Letra2.Location = New System.Drawing.Point(46, 50)
      Me.txtCP2Letra2.Name = "txtCP2Letra2"
      Me.txtCP2Letra2.Size = New System.Drawing.Size(25, 20)
      Me.txtCP2Letra2.TabIndex = 9
      '
      'txtCP2Valor2
      '
      Me.txtCP2Valor2.Location = New System.Drawing.Point(73, 50)
      Me.txtCP2Valor2.Name = "txtCP2Valor2"
      Me.txtCP2Valor2.Size = New System.Drawing.Size(25, 20)
      Me.txtCP2Valor2.TabIndex = 10
      '
      'txtCP3Letra3
      '
      Me.txtCP3Letra3.Location = New System.Drawing.Point(46, 77)
      Me.txtCP3Letra3.Name = "txtCP3Letra3"
      Me.txtCP3Letra3.Size = New System.Drawing.Size(25, 20)
      Me.txtCP3Letra3.TabIndex = 11
      '
      'txtCP3Valor3
      '
      Me.txtCP3Valor3.Location = New System.Drawing.Point(73, 77)
      Me.txtCP3Valor3.Name = "txtCP3Valor3"
      Me.txtCP3Valor3.Size = New System.Drawing.Size(25, 20)
      Me.txtCP3Valor3.TabIndex = 12
      '
      'txtCN1Letra1
      '
      Me.txtCN1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCN1Letra1.Name = "txtCN1Letra1"
      Me.txtCN1Letra1.Size = New System.Drawing.Size(25, 20)
      Me.txtCN1Letra1.TabIndex = 13
      '
      'txtCN1Valor1
      '
      Me.txtCN1Valor1.Location = New System.Drawing.Point(74, 25)
      Me.txtCN1Valor1.Name = "txtCN1Valor1"
      Me.txtCN1Valor1.Size = New System.Drawing.Size(25, 20)
      Me.txtCN1Valor1.TabIndex = 14
      '
      'txtCN2Letra2
      '
      Me.txtCN2Letra2.Location = New System.Drawing.Point(45, 50)
      Me.txtCN2Letra2.Name = "txtCN2Letra2"
      Me.txtCN2Letra2.Size = New System.Drawing.Size(25, 20)
      Me.txtCN2Letra2.TabIndex = 15
      '
      'txtCN2Valor2
      '
      Me.txtCN2Valor2.Location = New System.Drawing.Point(74, 50)
      Me.txtCN2Valor2.Name = "txtCN2Valor2"
      Me.txtCN2Valor2.Size = New System.Drawing.Size(25, 20)
      Me.txtCN2Valor2.TabIndex = 16
      '
      'txtCN3Letra3
      '
      Me.txtCN3Letra3.Location = New System.Drawing.Point(44, 76)
      Me.txtCN3Letra3.Name = "txtCN3Letra3"
      Me.txtCN3Letra3.Size = New System.Drawing.Size(27, 20)
      Me.txtCN3Letra3.TabIndex = 17
      '
      'txtCN3Valor3
      '
      Me.txtCN3Valor3.Location = New System.Drawing.Point(74, 76)
      Me.txtCN3Valor3.Name = "txtCN3Valor3"
      Me.txtCN3Valor3.Size = New System.Drawing.Size(27, 20)
      Me.txtCN3Valor3.TabIndex = 18
      '
      'lblCPNo1
      '
      Me.lblCPNo1.AutoSize = True
      Me.lblCPNo1.ForeColor = System.Drawing.Color.Gray
      Me.lblCPNo1.Location = New System.Drawing.Point(5, 28)
      Me.lblCPNo1.Name = "lblCPNo1"
      Me.lblCPNo1.Size = New System.Drawing.Size(33, 13)
      Me.lblCPNo1.TabIndex = 22
      Me.lblCPNo1.Text = "No. 1"
      '
      'lblCPNo2
      '
      Me.lblCPNo2.AutoSize = True
      Me.lblCPNo2.ForeColor = System.Drawing.Color.Gray
      Me.lblCPNo2.Location = New System.Drawing.Point(4, 54)
      Me.lblCPNo2.Name = "lblCPNo2"
      Me.lblCPNo2.Size = New System.Drawing.Size(33, 13)
      Me.lblCPNo2.TabIndex = 23
      Me.lblCPNo2.Text = "No. 2"
      '
      'lblCPNo3
      '
      Me.lblCPNo3.AutoSize = True
      Me.lblCPNo3.ForeColor = System.Drawing.Color.Gray
      Me.lblCPNo3.Location = New System.Drawing.Point(5, 77)
      Me.lblCPNo3.Name = "lblCPNo3"
      Me.lblCPNo3.Size = New System.Drawing.Size(33, 13)
      Me.lblCPNo3.TabIndex = 24
      Me.lblCPNo3.Text = "No. 3"
      '
      'lblCNNo3
      '
      Me.lblCNNo3.AutoSize = True
      Me.lblCNNo3.ForeColor = System.Drawing.Color.Gray
      Me.lblCNNo3.Location = New System.Drawing.Point(6, 80)
      Me.lblCNNo3.Name = "lblCNNo3"
      Me.lblCNNo3.Size = New System.Drawing.Size(33, 13)
      Me.lblCNNo3.TabIndex = 27
      Me.lblCNNo3.Text = "No. 3"
      '
      'lblCNNo2
      '
      Me.lblCNNo2.AutoSize = True
      Me.lblCNNo2.ForeColor = System.Drawing.Color.Gray
      Me.lblCNNo2.Location = New System.Drawing.Point(6, 54)
      Me.lblCNNo2.Name = "lblCNNo2"
      Me.lblCNNo2.Size = New System.Drawing.Size(33, 13)
      Me.lblCNNo2.TabIndex = 26
      Me.lblCNNo2.Text = "No. 2"
      '
      'lblCNNo1
      '
      Me.lblCNNo1.AutoSize = True
      Me.lblCNNo1.ForeColor = System.Drawing.Color.Gray
      Me.lblCNNo1.Location = New System.Drawing.Point(6, 28)
      Me.lblCNNo1.Name = "lblCNNo1"
      Me.lblCNNo1.Size = New System.Drawing.Size(33, 13)
      Me.lblCNNo1.TabIndex = 25
      Me.lblCNNo1.Text = "No. 1"
      '
      'grbControlesPositivos
      '
      Me.grbControlesPositivos.Controls.Add(Me.txtCP1Letra1)
      Me.grbControlesPositivos.Controls.Add(Me.txtCP1Valor1)
      Me.grbControlesPositivos.Controls.Add(Me.txtCP2Letra2)
      Me.grbControlesPositivos.Controls.Add(Me.lblCPNo3)
      Me.grbControlesPositivos.Controls.Add(Me.txtCP2Valor2)
      Me.grbControlesPositivos.Controls.Add(Me.lblCPNo2)
      Me.grbControlesPositivos.Controls.Add(Me.txtCP3Letra3)
      Me.grbControlesPositivos.Controls.Add(Me.lblCPNo1)
      Me.grbControlesPositivos.Controls.Add(Me.txtCP3Valor3)
      Me.grbControlesPositivos.Location = New System.Drawing.Point(161, 379)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(129, 101)
      Me.grbControlesPositivos.TabIndex = 28
      Me.grbControlesPositivos.TabStop = False
      Me.grbControlesPositivos.Text = "Controles Positivos"
      '
      'grbControlesNegativos
      '
      Me.grbControlesNegativos.Controls.Add(Me.txtCN2Letra2)
      Me.grbControlesNegativos.Controls.Add(Me.txtCN1Letra1)
      Me.grbControlesNegativos.Controls.Add(Me.lblCNNo3)
      Me.grbControlesNegativos.Controls.Add(Me.txtCN1Valor1)
      Me.grbControlesNegativos.Controls.Add(Me.lblCNNo2)
      Me.grbControlesNegativos.Controls.Add(Me.txtCN2Valor2)
      Me.grbControlesNegativos.Controls.Add(Me.lblCNNo1)
      Me.grbControlesNegativos.Controls.Add(Me.txtCN3Letra3)
      Me.grbControlesNegativos.Controls.Add(Me.txtCN3Valor3)
      Me.grbControlesNegativos.Location = New System.Drawing.Point(296, 379)
      Me.grbControlesNegativos.Name = "grbControlesNegativos"
      Me.grbControlesNegativos.Size = New System.Drawing.Size(134, 101)
      Me.grbControlesNegativos.TabIndex = 25
      Me.grbControlesNegativos.TabStop = False
      Me.grbControlesNegativos.Text = "Controles Negativos"
      '
      'btnCalcularValores
      '
      Me.btnCalcularValores.Location = New System.Drawing.Point(484, 457)
      Me.btnCalcularValores.Name = "btnCalcularValores"
      Me.btnCalcularValores.Size = New System.Drawing.Size(113, 23)
      Me.btnCalcularValores.TabIndex = 29
      Me.btnCalcularValores.Text = "Obtener Resultados"
      Me.btnCalcularValores.UseVisualStyleBackColor = True
      '
      'ShapeContainer1
      '
      Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
      Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
      Me.ShapeContainer1.Name = "ShapeContainer1"
      Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
      Me.ShapeContainer1.Size = New System.Drawing.Size(986, 488)
      Me.ShapeContainer1.TabIndex = 30
      Me.ShapeContainer1.TabStop = False
      '
      'LineShape1
      '
      Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
      Me.LineShape1.Name = "LineShape1"
      Me.LineShape1.X1 = 28
      Me.LineShape1.X2 = 596
      Me.LineShape1.Y1 = 367
      Me.LineShape1.Y2 = 367
      '
      'BvtselisaDataSet
      '
      Me.BvtselisaDataSet.DataSetName = "bvtselisaDataSet"
      Me.BvtselisaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'TblregistroanalisisBindingSource
      '
      Me.TblregistroanalisisBindingSource.DataMember = "tblregistroanalisis"
      Me.TblregistroanalisisBindingSource.DataSource = Me.BvtselisaDataSet
      '
      'TblregistroanalisisTableAdapter
      '
      Me.TblregistroanalisisTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.tblanalisisTableAdapter = Nothing
      Me.TableAdapterManager.tblclienteTableAdapter = Nothing
      Me.TableAdapterManager.tbllectorplacasTableAdapter = Nothing
      Me.TableAdapterManager.tblplacaleidaTableAdapter = Nothing
      Me.TableAdapterManager.tblregistroanalisisTableAdapter = Me.TblregistroanalisisTableAdapter
      Me.TableAdapterManager.tblresultadosTableAdapter = Nothing
      Me.TableAdapterManager.UpdateOrder = Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'TblregistroanalisisBindingNavigator
      '
      Me.TblregistroanalisisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.TblregistroanalisisBindingNavigator.BindingSource = Me.TblregistroanalisisBindingSource
      Me.TblregistroanalisisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.TblregistroanalisisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.TblregistroanalisisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblregistroanalisisBindingNavigatorSaveItem})
      Me.TblregistroanalisisBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.TblregistroanalisisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.TblregistroanalisisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.TblregistroanalisisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.TblregistroanalisisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.TblregistroanalisisBindingNavigator.Name = "TblregistroanalisisBindingNavigator"
      Me.TblregistroanalisisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.TblregistroanalisisBindingNavigator.Size = New System.Drawing.Size(986, 25)
      Me.TblregistroanalisisBindingNavigator.TabIndex = 31
      Me.TblregistroanalisisBindingNavigator.Text = "BindingNavigator1"
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
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
      Me.BindingNavigatorMoveNextItem.Text = "Move next"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
      Me.BindingNavigatorMoveLastItem.Text = "Move last"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
      '
      'TblregistroanalisisBindingNavigatorSaveItem
      '
      Me.TblregistroanalisisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.TblregistroanalisisBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblregistroanalisisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.TblregistroanalisisBindingNavigatorSaveItem.Name = "TblregistroanalisisBindingNavigatorSaveItem"
      Me.TblregistroanalisisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
      Me.TblregistroanalisisBindingNavigatorSaveItem.Text = "Save Data"
      '
      'NoCasoTextBox
      '
      Me.NoCasoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblregistroanalisisBindingSource, "noCaso", True))
      Me.NoCasoTextBox.Location = New System.Drawing.Point(123, 34)
      Me.NoCasoTextBox.Name = "NoCasoTextBox"
      Me.NoCasoTextBox.Size = New System.Drawing.Size(149, 20)
      Me.NoCasoTextBox.TabIndex = 1
      '
      'FechaRecepcionDateTimePicker
      '
      Me.FechaRecepcionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblregistroanalisisBindingSource, "fechaRecepcion", True))
      Me.FechaRecepcionDateTimePicker.Location = New System.Drawing.Point(390, 34)
      Me.FechaRecepcionDateTimePicker.Name = "FechaRecepcionDateTimePicker"
      Me.FechaRecepcionDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.FechaRecepcionDateTimePicker.TabIndex = 1
      '
      'frmRegistraNuevoAnalisis
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(986, 488)
      Me.Controls.Add(Me.FechaRecepcionDateTimePicker)
      Me.Controls.Add(Me.NoCasoTextBox)
      Me.Controls.Add(Me.TblregistroanalisisBindingNavigator)
      Me.Controls.Add(Me.btnCalcularValores)
      Me.Controls.Add(Me.grbControlesNegativos)
      Me.Controls.Add(Me.grbControlesPositivos)
      Me.Controls.Add(Me.btnGuardarDatos)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnNuevoAnalisisCancelar)
      Me.Controls.Add(Me.btnCambiarLector)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.cbbNombreAnalisis)
      Me.Controls.Add(Me.lblNombreAnalisis)
      Me.Controls.Add(Me.lblFechaRecepcion)
      Me.Controls.Add(Me.cbbNombreCliente)
      Me.Controls.Add(Me.lblNombreCliente)
      Me.Controls.Add(Me.lblNoCaso)
      Me.Controls.Add(Me.ShapeContainer1)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmRegistraNuevoAnalisis"
      Me.Text = "Registra nuevo análisis"
      Me.grbControlesPositivos.ResumeLayout(False)
      Me.grbControlesPositivos.PerformLayout()
      Me.grbControlesNegativos.ResumeLayout(False)
      Me.grbControlesNegativos.PerformLayout()
      CType(Me.BvtselisaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblregistroanalisisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TblregistroanalisisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TblregistroanalisisBindingNavigator.ResumeLayout(False)
      Me.TblregistroanalisisBindingNavigator.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents cbbNombreCliente As System.Windows.Forms.ComboBox
   Friend WithEvents lblFechaRecepcion As System.Windows.Forms.Label
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents cbbNombreAnalisis As System.Windows.Forms.ComboBox
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents btnCambiarLector As System.Windows.Forms.Button
   Friend WithEvents btnNuevoAnalisisCancelar As System.Windows.Forms.Button
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
   Friend WithEvents btnGuardarDatos As System.Windows.Forms.Button
   Friend WithEvents sfdGuardarPlaca As System.Windows.Forms.SaveFileDialog
   Friend WithEvents txtCP1Letra1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP1Valor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP2Letra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP2Valor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP3Letra3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP3Valor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN1Letra1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN1Valor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN2Letra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN2Valor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN3Letra3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN3Valor3 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo1 As System.Windows.Forms.Label
   Friend WithEvents lblCPNo2 As System.Windows.Forms.Label
   Friend WithEvents lblCPNo3 As System.Windows.Forms.Label
   Friend WithEvents lblCNNo3 As System.Windows.Forms.Label
   Friend WithEvents lblCNNo2 As System.Windows.Forms.Label
   Friend WithEvents lblCNNo1 As System.Windows.Forms.Label
   Friend WithEvents grbControlesPositivos As System.Windows.Forms.GroupBox
   Friend WithEvents grbControlesNegativos As System.Windows.Forms.GroupBox
   Friend WithEvents btnCalcularValores As System.Windows.Forms.Button
   Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
   Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
   Friend WithEvents BvtselisaDataSet As Elisa2010.bvtselisaDataSet
   Friend WithEvents TblregistroanalisisBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents TblregistroanalisisTableAdapter As Elisa2010.bvtselisaDataSetTableAdapters.tblregistroanalisisTableAdapter
   Friend WithEvents TableAdapterManager As Elisa2010.bvtselisaDataSetTableAdapters.TableAdapterManager
   Friend WithEvents TblregistroanalisisBindingNavigator As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents TblregistroanalisisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
   Friend WithEvents NoCasoTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FechaRecepcionDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
