<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturaDePlaca
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturaDePlaca))
      Me.lblNombreLector = New System.Windows.Forms.Label()
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.Panel5 = New System.Windows.Forms.Panel()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.btnGuardaDatos = New System.Windows.Forms.Button()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.grbControlesNegativos = New System.Windows.Forms.GroupBox()
      Me.txtCN2Letra2 = New System.Windows.Forms.TextBox()
      Me.txtCN1Letra1 = New System.Windows.Forms.TextBox()
      Me.lblCNNo3 = New System.Windows.Forms.Label()
      Me.txtCN1Valor1 = New System.Windows.Forms.TextBox()
      Me.lblCNNo2 = New System.Windows.Forms.Label()
      Me.txtCN2Valor2 = New System.Windows.Forms.TextBox()
      Me.lblCNNo1 = New System.Windows.Forms.Label()
      Me.txtCN3Letra3 = New System.Windows.Forms.TextBox()
      Me.txtCN3Valor3 = New System.Windows.Forms.TextBox()
      Me.grbControlesPositivos = New System.Windows.Forms.GroupBox()
      Me.txtCP1Letra1 = New System.Windows.Forms.TextBox()
      Me.txtCP1Valor1 = New System.Windows.Forms.TextBox()
      Me.txtCP2Letra2 = New System.Windows.Forms.TextBox()
      Me.lblCPNo3 = New System.Windows.Forms.Label()
      Me.txtCP2Valor2 = New System.Windows.Forms.TextBox()
      Me.lblCPNo2 = New System.Windows.Forms.Label()
      Me.txtCP3Letra3 = New System.Windows.Forms.TextBox()
      Me.lblCPNo1 = New System.Windows.Forms.Label()
      Me.txtCP3Valor3 = New System.Windows.Forms.TextBox()
      Me.btnDefinirControlesPN = New System.Windows.Forms.Button()
      Me.btnAceptarControles = New System.Windows.Forms.Button()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.txtNoControlesNegativos = New System.Windows.Forms.TextBox()
      Me.txtNoControlesPositivos = New System.Windows.Forms.TextBox()
      Me.lbltNoControlesNegativos = New System.Windows.Forms.Label()
      Me.lblNoControlesPositivos = New System.Windows.Forms.Label()
      Me.btnAceptarCPN = New System.Windows.Forms.Button()
      Me.ckbControlesDefault = New System.Windows.Forms.CheckBox()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.Panel1.SuspendLayout()
      Me.Panel5.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel3.SuspendLayout()
      Me.grbControlesNegativos.SuspendLayout()
      Me.grbControlesPositivos.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.SuspendLayout()
      '
      'lblNombreLector
      '
      Me.lblNombreLector.AutoSize = True
      Me.lblNombreLector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreLector.ForeColor = System.Drawing.Color.Black
      Me.lblNombreLector.Location = New System.Drawing.Point(183, 16)
      Me.lblNombreLector.Name = "lblNombreLector"
      Me.lblNombreLector.Size = New System.Drawing.Size(117, 16)
      Me.lblNombreLector.TabIndex = 118
      Me.lblNombreLector.Text = "Nombre del Lector"
      '
      'cmbComboPorts
      '
      Me.cmbComboPorts.Enabled = False
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(6, 384)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(94, 21)
      Me.cmbComboPorts.TabIndex = 117
      Me.cmbComboPorts.TabStop = False
      Me.cmbComboPorts.Visible = False
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.Label1)
      Me.Panel1.Controls.Add(Me.lblNombreLector)
      Me.Panel1.Location = New System.Drawing.Point(6, 6)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(567, 51)
      Me.Panel1.TabIndex = 119
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
      Me.Label1.Location = New System.Drawing.Point(12, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(163, 16)
      Me.Label1.TabIndex = 119
      Me.Label1.Text = "Nombre del Lector Default:"
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(579, 6)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 133
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'Panel5
      '
      Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel5.Controls.Add(Me.dgvPlacaLeida)
      Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel5.Location = New System.Drawing.Point(6, 63)
      Me.Panel5.Name = "Panel5"
      Me.Panel5.Size = New System.Drawing.Size(709, 214)
      Me.Panel5.TabIndex = 120
      '
      'dgvPlacaLeida
      '
      Me.dgvPlacaLeida.AllowUserToAddRows = False
      Me.dgvPlacaLeida.AllowUserToDeleteRows = False
      Me.dgvPlacaLeida.AllowUserToResizeColumns = False
      Me.dgvPlacaLeida.AllowUserToResizeRows = False
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.dgvPlacaLeida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.dgvPlacaLeida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvPlacaLeida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.dgvPlacaLeida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvPlacaLeida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.dgvPlacaLeida.GridColor = System.Drawing.Color.Gray
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(3, 5)
      Me.dgvPlacaLeida.Name = "dgvPlacaLeida"
      Me.dgvPlacaLeida.ReadOnly = True
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.dgvPlacaLeida.RowsDefaultCellStyle = DataGridViewCellStyle4
      Me.dgvPlacaLeida.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.dgvPlacaLeida.Size = New System.Drawing.Size(698, 200)
      Me.dgvPlacaLeida.TabIndex = 101
      Me.dgvPlacaLeida.TabStop = False
      '
      'btnGuardaDatos
      '
      Me.btnGuardaDatos.Enabled = False
      Me.btnGuardaDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnGuardaDatos.Location = New System.Drawing.Point(457, 411)
      Me.btnGuardaDatos.Name = "btnGuardaDatos"
      Me.btnGuardaDatos.Size = New System.Drawing.Size(136, 23)
      Me.btnGuardaDatos.TabIndex = 122
      Me.btnGuardaDatos.Text = "Guardar Datos en Excel"
      Me.btnGuardaDatos.UseVisualStyleBackColor = True
      '
      'btnCancelar
      '
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(599, 411)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(109, 23)
      Me.btnCancelar.TabIndex = 123
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'SerialPort1
      '
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(114, 384)
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(130, 20)
      Me.txtDatosRecibidos.TabIndex = 125
      Me.txtDatosRecibidos.Visible = False
      '
      'Panel3
      '
      Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel3.Controls.Add(Me.grbControlesNegativos)
      Me.Panel3.Controls.Add(Me.grbControlesPositivos)
      Me.Panel3.Location = New System.Drawing.Point(405, 285)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(310, 120)
      Me.Panel3.TabIndex = 126
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
      Me.grbControlesNegativos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbControlesNegativos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbControlesNegativos.Location = New System.Drawing.Point(157, 3)
      Me.grbControlesNegativos.Name = "grbControlesNegativos"
      Me.grbControlesNegativos.Size = New System.Drawing.Size(140, 110)
      Me.grbControlesNegativos.TabIndex = 35
      Me.grbControlesNegativos.TabStop = False
      Me.grbControlesNegativos.Text = "Controles Negativos"
      '
      'txtCN2Letra2
      '
      Me.txtCN2Letra2.Location = New System.Drawing.Point(46, 50)
      Me.txtCN2Letra2.MaxLength = 1
      Me.txtCN2Letra2.Name = "txtCN2Letra2"
      Me.txtCN2Letra2.Size = New System.Drawing.Size(24, 22)
      Me.txtCN2Letra2.TabIndex = 13
      Me.txtCN2Letra2.Visible = False
      '
      'txtCN1Letra1
      '
      Me.txtCN1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCN1Letra1.MaxLength = 1
      Me.txtCN1Letra1.Name = "txtCN1Letra1"
      Me.txtCN1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Letra1.TabIndex = 11
      Me.txtCN1Letra1.Visible = False
      '
      'lblCNNo3
      '
      Me.lblCNNo3.AutoSize = True
      Me.lblCNNo3.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo3.Location = New System.Drawing.Point(6, 80)
      Me.lblCNNo3.Name = "lblCNNo3"
      Me.lblCNNo3.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo3.TabIndex = 27
      Me.lblCNNo3.Text = "No. 3"
      Me.lblCNNo3.Visible = False
      '
      'txtCN1Valor1
      '
      Me.txtCN1Valor1.Location = New System.Drawing.Point(79, 25)
      Me.txtCN1Valor1.MaxLength = 2
      Me.txtCN1Valor1.Name = "txtCN1Valor1"
      Me.txtCN1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Valor1.TabIndex = 12
      Me.txtCN1Valor1.Visible = False
      '
      'lblCNNo2
      '
      Me.lblCNNo2.AutoSize = True
      Me.lblCNNo2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo2.Location = New System.Drawing.Point(6, 54)
      Me.lblCNNo2.Name = "lblCNNo2"
      Me.lblCNNo2.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo2.TabIndex = 26
      Me.lblCNNo2.Text = "No. 2"
      Me.lblCNNo2.Visible = False
      '
      'txtCN2Valor2
      '
      Me.txtCN2Valor2.Location = New System.Drawing.Point(79, 50)
      Me.txtCN2Valor2.MaxLength = 2
      Me.txtCN2Valor2.Name = "txtCN2Valor2"
      Me.txtCN2Valor2.Size = New System.Drawing.Size(25, 22)
      Me.txtCN2Valor2.TabIndex = 14
      Me.txtCN2Valor2.Visible = False
      '
      'lblCNNo1
      '
      Me.lblCNNo1.AutoSize = True
      Me.lblCNNo1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo1.Location = New System.Drawing.Point(6, 28)
      Me.lblCNNo1.Name = "lblCNNo1"
      Me.lblCNNo1.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo1.TabIndex = 25
      Me.lblCNNo1.Text = "No. 1"
      Me.lblCNNo1.Visible = False
      '
      'txtCN3Letra3
      '
      Me.txtCN3Letra3.Location = New System.Drawing.Point(46, 76)
      Me.txtCN3Letra3.MaxLength = 1
      Me.txtCN3Letra3.Name = "txtCN3Letra3"
      Me.txtCN3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Letra3.TabIndex = 15
      Me.txtCN3Letra3.Visible = False
      '
      'txtCN3Valor3
      '
      Me.txtCN3Valor3.Location = New System.Drawing.Point(79, 76)
      Me.txtCN3Valor3.MaxLength = 2
      Me.txtCN3Valor3.Name = "txtCN3Valor3"
      Me.txtCN3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Valor3.TabIndex = 16
      Me.txtCN3Valor3.Visible = False
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
      Me.grbControlesPositivos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbControlesPositivos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbControlesPositivos.Location = New System.Drawing.Point(10, 3)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(140, 110)
      Me.grbControlesPositivos.TabIndex = 36
      Me.grbControlesPositivos.TabStop = False
      Me.grbControlesPositivos.Text = "Controles Positivos"
      '
      'txtCP1Letra1
      '
      Me.txtCP1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCP1Letra1.MaxLength = 1
      Me.txtCP1Letra1.Name = "txtCP1Letra1"
      Me.txtCP1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Letra1.TabIndex = 5
      Me.txtCP1Letra1.Visible = False
      '
      'txtCP1Valor1
      '
      Me.txtCP1Valor1.Location = New System.Drawing.Point(78, 25)
      Me.txtCP1Valor1.MaxLength = 2
      Me.txtCP1Valor1.Name = "txtCP1Valor1"
      Me.txtCP1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Valor1.TabIndex = 6
      Me.txtCP1Valor1.Visible = False
      '
      'txtCP2Letra2
      '
      Me.txtCP2Letra2.Location = New System.Drawing.Point(46, 50)
      Me.txtCP2Letra2.MaxLength = 1
      Me.txtCP2Letra2.Name = "txtCP2Letra2"
      Me.txtCP2Letra2.Size = New System.Drawing.Size(25, 22)
      Me.txtCP2Letra2.TabIndex = 7
      Me.txtCP2Letra2.Visible = False
      '
      'lblCPNo3
      '
      Me.lblCPNo3.AutoSize = True
      Me.lblCPNo3.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo3.Location = New System.Drawing.Point(5, 77)
      Me.lblCPNo3.Name = "lblCPNo3"
      Me.lblCPNo3.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo3.TabIndex = 24
      Me.lblCPNo3.Text = "No. 3"
      Me.lblCPNo3.Visible = False
      '
      'txtCP2Valor2
      '
      Me.txtCP2Valor2.Location = New System.Drawing.Point(79, 50)
      Me.txtCP2Valor2.MaxLength = 2
      Me.txtCP2Valor2.Name = "txtCP2Valor2"
      Me.txtCP2Valor2.Size = New System.Drawing.Size(24, 22)
      Me.txtCP2Valor2.TabIndex = 8
      Me.txtCP2Valor2.Visible = False
      '
      'lblCPNo2
      '
      Me.lblCPNo2.AutoSize = True
      Me.lblCPNo2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo2.Location = New System.Drawing.Point(4, 54)
      Me.lblCPNo2.Name = "lblCPNo2"
      Me.lblCPNo2.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo2.TabIndex = 23
      Me.lblCPNo2.Text = "No. 2"
      Me.lblCPNo2.Visible = False
      '
      'txtCP3Letra3
      '
      Me.txtCP3Letra3.Location = New System.Drawing.Point(46, 77)
      Me.txtCP3Letra3.MaxLength = 1
      Me.txtCP3Letra3.Name = "txtCP3Letra3"
      Me.txtCP3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Letra3.TabIndex = 9
      Me.txtCP3Letra3.Visible = False
      '
      'lblCPNo1
      '
      Me.lblCPNo1.AutoSize = True
      Me.lblCPNo1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo1.Location = New System.Drawing.Point(5, 28)
      Me.lblCPNo1.Name = "lblCPNo1"
      Me.lblCPNo1.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo1.TabIndex = 22
      Me.lblCPNo1.Text = "No. 1"
      Me.lblCPNo1.Visible = False
      '
      'txtCP3Valor3
      '
      Me.txtCP3Valor3.Location = New System.Drawing.Point(78, 77)
      Me.txtCP3Valor3.MaxLength = 2
      Me.txtCP3Valor3.Name = "txtCP3Valor3"
      Me.txtCP3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Valor3.TabIndex = 10
      Me.txtCP3Valor3.Visible = False
      '
      'btnDefinirControlesPN
      '
      Me.btnDefinirControlesPN.Enabled = False
      Me.btnDefinirControlesPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnDefinirControlesPN.Location = New System.Drawing.Point(264, 327)
      Me.btnDefinirControlesPN.Name = "btnDefinirControlesPN"
      Me.btnDefinirControlesPN.Size = New System.Drawing.Size(135, 23)
      Me.btnDefinirControlesPN.TabIndex = 130
      Me.btnDefinirControlesPN.Text = "Definir Controles"
      Me.btnDefinirControlesPN.UseVisualStyleBackColor = True
      '
      'btnAceptarControles
      '
      Me.btnAceptarControles.Enabled = False
      Me.btnAceptarControles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarControles.Location = New System.Drawing.Point(316, 411)
      Me.btnAceptarControles.Name = "btnAceptarControles"
      Me.btnAceptarControles.Size = New System.Drawing.Size(135, 23)
      Me.btnAceptarControles.TabIndex = 131
      Me.btnAceptarControles.Text = "Aceptar Controles"
      Me.btnAceptarControles.UseVisualStyleBackColor = True
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.txtNoControlesNegativos)
      Me.Panel2.Controls.Add(Me.txtNoControlesPositivos)
      Me.Panel2.Controls.Add(Me.lbltNoControlesNegativos)
      Me.Panel2.Controls.Add(Me.lblNoControlesPositivos)
      Me.Panel2.Controls.Add(Me.btnAceptarCPN)
      Me.Panel2.Location = New System.Drawing.Point(6, 285)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(252, 93)
      Me.Panel2.TabIndex = 132
      '
      'txtNoControlesNegativos
      '
      Me.txtNoControlesNegativos.Location = New System.Drawing.Point(3, 34)
      Me.txtNoControlesNegativos.MaxLength = 1
      Me.txtNoControlesNegativos.Name = "txtNoControlesNegativos"
      Me.txtNoControlesNegativos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesNegativos.TabIndex = 136
      '
      'txtNoControlesPositivos
      '
      Me.txtNoControlesPositivos.Location = New System.Drawing.Point(3, 8)
      Me.txtNoControlesPositivos.MaxLength = 1
      Me.txtNoControlesPositivos.Name = "txtNoControlesPositivos"
      Me.txtNoControlesPositivos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesPositivos.TabIndex = 130
      '
      'lbltNoControlesNegativos
      '
      Me.lbltNoControlesNegativos.AutoSize = True
      Me.lbltNoControlesNegativos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbltNoControlesNegativos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lbltNoControlesNegativos.Location = New System.Drawing.Point(35, 38)
      Me.lbltNoControlesNegativos.Name = "lbltNoControlesNegativos"
      Me.lbltNoControlesNegativos.Size = New System.Drawing.Size(154, 15)
      Me.lbltNoControlesNegativos.TabIndex = 137
      Me.lbltNoControlesNegativos.Text = "No. de Controles Negativos"
      '
      'lblNoControlesPositivos
      '
      Me.lblNoControlesPositivos.AutoSize = True
      Me.lblNoControlesPositivos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoControlesPositivos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoControlesPositivos.Location = New System.Drawing.Point(35, 12)
      Me.lblNoControlesPositivos.Name = "lblNoControlesPositivos"
      Me.lblNoControlesPositivos.Size = New System.Drawing.Size(146, 15)
      Me.lblNoControlesPositivos.TabIndex = 131
      Me.lblNoControlesPositivos.Text = "No. de Controles Positivos"
      '
      'btnAceptarCPN
      '
      Me.btnAceptarCPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarCPN.Location = New System.Drawing.Point(110, 63)
      Me.btnAceptarCPN.Name = "btnAceptarCPN"
      Me.btnAceptarCPN.Size = New System.Drawing.Size(135, 23)
      Me.btnAceptarCPN.TabIndex = 135
      Me.btnAceptarCPN.Text = "Aceptar"
      Me.btnAceptarCPN.UseVisualStyleBackColor = True
      '
      'ckbControlesDefault
      '
      Me.ckbControlesDefault.AutoSize = True
      Me.ckbControlesDefault.Enabled = False
      Me.ckbControlesDefault.ForeColor = System.Drawing.Color.DarkGreen
      Me.ckbControlesDefault.Location = New System.Drawing.Point(276, 295)
      Me.ckbControlesDefault.Name = "ckbControlesDefault"
      Me.ckbControlesDefault.Size = New System.Drawing.Size(114, 17)
      Me.ckbControlesDefault.TabIndex = 134
      Me.ckbControlesDefault.Text = "Valores por default"
      Me.ckbControlesDefault.UseVisualStyleBackColor = True
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(579, 34)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(136, 23)
      Me.btnLeerDatosPlaca.TabIndex = 134
      Me.btnLeerDatosPlaca.Text = "Obtener Datos"
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'frmLecturaDePlaca
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(720, 474)
      Me.Controls.Add(Me.dtpFechaElaboracion)
      Me.Controls.Add(Me.ckbControlesDefault)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnDefinirControlesPN)
      Me.Controls.Add(Me.btnAceptarControles)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.btnGuardaDatos)
      Me.Controls.Add(Me.Panel5)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel3)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmLecturaDePlaca"
      Me.Text = "Leer placa desde lector default"
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel5.ResumeLayout(False)
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel3.ResumeLayout(False)
      Me.grbControlesNegativos.ResumeLayout(False)
      Me.grbControlesNegativos.PerformLayout()
      Me.grbControlesPositivos.ResumeLayout(False)
      Me.grbControlesPositivos.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblNombreLector As System.Windows.Forms.Label
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel5 As System.Windows.Forms.Panel
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents btnGuardaDatos As System.Windows.Forms.Button
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents btnDefinirControlesPN As System.Windows.Forms.Button
   Friend WithEvents btnAceptarControles As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents grbControlesNegativos As System.Windows.Forms.GroupBox
   Friend WithEvents txtCN2Letra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN1Letra1 As System.Windows.Forms.TextBox
   Friend WithEvents lblCNNo3 As System.Windows.Forms.Label
   Friend WithEvents txtCN1Valor1 As System.Windows.Forms.TextBox
   Friend WithEvents lblCNNo2 As System.Windows.Forms.Label
   Friend WithEvents txtCN2Valor2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCNNo1 As System.Windows.Forms.Label
   Friend WithEvents txtCN3Letra3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCN3Valor3 As System.Windows.Forms.TextBox
   Friend WithEvents grbControlesPositivos As System.Windows.Forms.GroupBox
   Friend WithEvents txtCP1Letra1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP1Valor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP2Letra2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo3 As System.Windows.Forms.Label
   Friend WithEvents txtCP2Valor2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo2 As System.Windows.Forms.Label
   Friend WithEvents txtCP3Letra3 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo1 As System.Windows.Forms.Label
   Friend WithEvents txtCP3Valor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtNoControlesPositivos As System.Windows.Forms.TextBox
   Friend WithEvents lblNoControlesPositivos As System.Windows.Forms.Label
   Friend WithEvents btnAceptarCPN As System.Windows.Forms.Button
   Friend WithEvents ckbControlesDefault As System.Windows.Forms.CheckBox
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents txtNoControlesNegativos As System.Windows.Forms.TextBox
   Friend WithEvents lbltNoControlesNegativos As System.Windows.Forms.Label
End Class
