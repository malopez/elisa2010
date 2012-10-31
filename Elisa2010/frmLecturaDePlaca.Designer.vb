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
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturaDePlaca))
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.Label41 = New System.Windows.Forms.Label()
      Me.txtNoControlesNegativos = New System.Windows.Forms.TextBox()
      Me.txtNoControlesPositivos = New System.Windows.Forms.TextBox()
      Me.lblNoControles = New System.Windows.Forms.Label()
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
      Me.btnAceptarControles = New System.Windows.Forms.Button()
      Me.btnDefinirControlesPN = New System.Windows.Forms.Button()
      Me.ckbControlesDefault = New System.Windows.Forms.CheckBox()
      Me.Label43 = New System.Windows.Forms.Label()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.GroupBox3 = New System.Windows.Forms.GroupBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblNombreLector = New System.Windows.Forms.Label()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.btnPreverInfome = New System.Windows.Forms.Button()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.grpArchivoFinal = New System.Windows.Forms.GroupBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.txtNombrePlaca = New System.Windows.Forms.TextBox()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.GroupBox1.SuspendLayout()
      Me.grbControlesNegativos.SuspendLayout()
      Me.grbControlesPositivos.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox3.SuspendLayout()
      Me.grpArchivoFinal.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.Label41)
      Me.GroupBox1.Controls.Add(Me.txtNoControlesNegativos)
      Me.GroupBox1.Controls.Add(Me.txtNoControlesPositivos)
      Me.GroupBox1.Controls.Add(Me.lblNoControles)
      Me.GroupBox1.Controls.Add(Me.grbControlesNegativos)
      Me.GroupBox1.Controls.Add(Me.grbControlesPositivos)
      Me.GroupBox1.Controls.Add(Me.btnAceptarControles)
      Me.GroupBox1.Controls.Add(Me.btnDefinirControlesPN)
      Me.GroupBox1.Controls.Add(Me.ckbControlesDefault)
      Me.GroupBox1.Location = New System.Drawing.Point(293, 53)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(421, 154)
      Me.GroupBox1.TabIndex = 0
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Controles positivos y negativos"
      '
      'Label41
      '
      Me.Label41.AutoSize = True
      Me.Label41.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label41.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label41.Location = New System.Drawing.Point(163, 20)
      Me.Label41.Name = "Label41"
      Me.Label41.Size = New System.Drawing.Size(100, 15)
      Me.Label41.TabIndex = 177
      Me.Label41.Text = "No. de Negativos"
      '
      'txtNoControlesNegativos
      '
      Me.txtNoControlesNegativos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesNegativos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesNegativos.Location = New System.Drawing.Point(269, 17)
      Me.txtNoControlesNegativos.MaxLength = 1
      Me.txtNoControlesNegativos.Name = "txtNoControlesNegativos"
      Me.txtNoControlesNegativos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesNegativos.TabIndex = 175
      Me.txtNoControlesNegativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'txtNoControlesPositivos
      '
      Me.txtNoControlesPositivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesPositivos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesPositivos.Location = New System.Drawing.Point(113, 17)
      Me.txtNoControlesPositivos.MaxLength = 1
      Me.txtNoControlesPositivos.Name = "txtNoControlesPositivos"
      Me.txtNoControlesPositivos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesPositivos.TabIndex = 174
      Me.txtNoControlesPositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblNoControles
      '
      Me.lblNoControles.AutoSize = True
      Me.lblNoControles.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoControles.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoControles.Location = New System.Drawing.Point(15, 19)
      Me.lblNoControles.Name = "lblNoControles"
      Me.lblNoControles.Size = New System.Drawing.Size(92, 15)
      Me.lblNoControles.TabIndex = 176
      Me.lblNoControles.Text = "No. de Positivos"
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
      Me.grbControlesNegativos.Enabled = False
      Me.grbControlesNegativos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbControlesNegativos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbControlesNegativos.Location = New System.Drawing.Point(161, 40)
      Me.grbControlesNegativos.Name = "grbControlesNegativos"
      Me.grbControlesNegativos.Size = New System.Drawing.Size(140, 108)
      Me.grbControlesNegativos.TabIndex = 172
      Me.grbControlesNegativos.TabStop = False
      Me.grbControlesNegativos.Text = "Controles Negativos"
      '
      'txtCN2Letra2
      '
      Me.txtCN2Letra2.Location = New System.Drawing.Point(60, 50)
      Me.txtCN2Letra2.MaxLength = 1
      Me.txtCN2Letra2.Name = "txtCN2Letra2"
      Me.txtCN2Letra2.Size = New System.Drawing.Size(24, 22)
      Me.txtCN2Letra2.TabIndex = 14
      Me.txtCN2Letra2.Visible = False
      '
      'txtCN1Letra1
      '
      Me.txtCN1Letra1.Location = New System.Drawing.Point(60, 25)
      Me.txtCN1Letra1.MaxLength = 1
      Me.txtCN1Letra1.Name = "txtCN1Letra1"
      Me.txtCN1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Letra1.TabIndex = 12
      Me.txtCN1Letra1.Visible = False
      '
      'lblCNNo3
      '
      Me.lblCNNo3.AutoSize = True
      Me.lblCNNo3.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo3.Location = New System.Drawing.Point(20, 80)
      Me.lblCNNo3.Name = "lblCNNo3"
      Me.lblCNNo3.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo3.TabIndex = 27
      Me.lblCNNo3.Text = "No. 3"
      Me.lblCNNo3.Visible = False
      '
      'txtCN1Valor1
      '
      Me.txtCN1Valor1.Location = New System.Drawing.Point(93, 25)
      Me.txtCN1Valor1.MaxLength = 2
      Me.txtCN1Valor1.Name = "txtCN1Valor1"
      Me.txtCN1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Valor1.TabIndex = 13
      Me.txtCN1Valor1.Visible = False
      '
      'lblCNNo2
      '
      Me.lblCNNo2.AutoSize = True
      Me.lblCNNo2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo2.Location = New System.Drawing.Point(20, 54)
      Me.lblCNNo2.Name = "lblCNNo2"
      Me.lblCNNo2.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo2.TabIndex = 26
      Me.lblCNNo2.Text = "No. 2"
      Me.lblCNNo2.Visible = False
      '
      'txtCN2Valor2
      '
      Me.txtCN2Valor2.Location = New System.Drawing.Point(93, 50)
      Me.txtCN2Valor2.MaxLength = 2
      Me.txtCN2Valor2.Name = "txtCN2Valor2"
      Me.txtCN2Valor2.Size = New System.Drawing.Size(25, 22)
      Me.txtCN2Valor2.TabIndex = 15
      Me.txtCN2Valor2.Visible = False
      '
      'lblCNNo1
      '
      Me.lblCNNo1.AutoSize = True
      Me.lblCNNo1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCNNo1.Location = New System.Drawing.Point(20, 28)
      Me.lblCNNo1.Name = "lblCNNo1"
      Me.lblCNNo1.Size = New System.Drawing.Size(38, 16)
      Me.lblCNNo1.TabIndex = 25
      Me.lblCNNo1.Text = "No. 1"
      Me.lblCNNo1.Visible = False
      '
      'txtCN3Letra3
      '
      Me.txtCN3Letra3.Location = New System.Drawing.Point(60, 76)
      Me.txtCN3Letra3.MaxLength = 1
      Me.txtCN3Letra3.Name = "txtCN3Letra3"
      Me.txtCN3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Letra3.TabIndex = 16
      Me.txtCN3Letra3.Visible = False
      '
      'txtCN3Valor3
      '
      Me.txtCN3Valor3.Location = New System.Drawing.Point(93, 76)
      Me.txtCN3Valor3.MaxLength = 2
      Me.txtCN3Valor3.Name = "txtCN3Valor3"
      Me.txtCN3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Valor3.TabIndex = 17
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
      Me.grbControlesPositivos.Enabled = False
      Me.grbControlesPositivos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbControlesPositivos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbControlesPositivos.Location = New System.Drawing.Point(6, 40)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(141, 108)
      Me.grbControlesPositivos.TabIndex = 173
      Me.grbControlesPositivos.TabStop = False
      Me.grbControlesPositivos.Text = "Controles Positivos"
      '
      'txtCP1Letra1
      '
      Me.txtCP1Letra1.Location = New System.Drawing.Point(62, 25)
      Me.txtCP1Letra1.MaxLength = 1
      Me.txtCP1Letra1.Name = "txtCP1Letra1"
      Me.txtCP1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Letra1.TabIndex = 6
      Me.txtCP1Letra1.Visible = False
      '
      'txtCP1Valor1
      '
      Me.txtCP1Valor1.Location = New System.Drawing.Point(94, 25)
      Me.txtCP1Valor1.MaxLength = 2
      Me.txtCP1Valor1.Name = "txtCP1Valor1"
      Me.txtCP1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Valor1.TabIndex = 7
      Me.txtCP1Valor1.Visible = False
      '
      'txtCP2Letra2
      '
      Me.txtCP2Letra2.Location = New System.Drawing.Point(62, 50)
      Me.txtCP2Letra2.MaxLength = 1
      Me.txtCP2Letra2.Name = "txtCP2Letra2"
      Me.txtCP2Letra2.Size = New System.Drawing.Size(25, 22)
      Me.txtCP2Letra2.TabIndex = 8
      Me.txtCP2Letra2.Visible = False
      '
      'lblCPNo3
      '
      Me.lblCPNo3.AutoSize = True
      Me.lblCPNo3.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo3.Location = New System.Drawing.Point(21, 77)
      Me.lblCPNo3.Name = "lblCPNo3"
      Me.lblCPNo3.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo3.TabIndex = 24
      Me.lblCPNo3.Text = "No. 3"
      Me.lblCPNo3.Visible = False
      '
      'txtCP2Valor2
      '
      Me.txtCP2Valor2.Location = New System.Drawing.Point(95, 50)
      Me.txtCP2Valor2.MaxLength = 2
      Me.txtCP2Valor2.Name = "txtCP2Valor2"
      Me.txtCP2Valor2.Size = New System.Drawing.Size(24, 22)
      Me.txtCP2Valor2.TabIndex = 9
      Me.txtCP2Valor2.Visible = False
      '
      'lblCPNo2
      '
      Me.lblCPNo2.AutoSize = True
      Me.lblCPNo2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo2.Location = New System.Drawing.Point(20, 54)
      Me.lblCPNo2.Name = "lblCPNo2"
      Me.lblCPNo2.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo2.TabIndex = 23
      Me.lblCPNo2.Text = "No. 2"
      Me.lblCPNo2.Visible = False
      '
      'txtCP3Letra3
      '
      Me.txtCP3Letra3.Location = New System.Drawing.Point(62, 77)
      Me.txtCP3Letra3.MaxLength = 1
      Me.txtCP3Letra3.Name = "txtCP3Letra3"
      Me.txtCP3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Letra3.TabIndex = 10
      Me.txtCP3Letra3.Visible = False
      '
      'lblCPNo1
      '
      Me.lblCPNo1.AutoSize = True
      Me.lblCPNo1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblCPNo1.Location = New System.Drawing.Point(21, 28)
      Me.lblCPNo1.Name = "lblCPNo1"
      Me.lblCPNo1.Size = New System.Drawing.Size(38, 16)
      Me.lblCPNo1.TabIndex = 22
      Me.lblCPNo1.Text = "No. 1"
      Me.lblCPNo1.Visible = False
      '
      'txtCP3Valor3
      '
      Me.txtCP3Valor3.Location = New System.Drawing.Point(94, 77)
      Me.txtCP3Valor3.MaxLength = 2
      Me.txtCP3Valor3.Name = "txtCP3Valor3"
      Me.txtCP3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Valor3.TabIndex = 11
      Me.txtCP3Valor3.Visible = False
      '
      'btnAceptarControles
      '
      Me.btnAceptarControles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarControles.Location = New System.Drawing.Point(307, 102)
      Me.btnAceptarControles.Name = "btnAceptarControles"
      Me.btnAceptarControles.Size = New System.Drawing.Size(105, 23)
      Me.btnAceptarControles.TabIndex = 170
      Me.btnAceptarControles.Text = "Aceptar Controles"
      Me.btnAceptarControles.UseVisualStyleBackColor = True
      '
      'btnDefinirControlesPN
      '
      Me.btnDefinirControlesPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnDefinirControlesPN.Location = New System.Drawing.Point(307, 73)
      Me.btnDefinirControlesPN.Name = "btnDefinirControlesPN"
      Me.btnDefinirControlesPN.Size = New System.Drawing.Size(105, 23)
      Me.btnDefinirControlesPN.TabIndex = 171
      Me.btnDefinirControlesPN.Text = "Definir Controles"
      Me.btnDefinirControlesPN.UseVisualStyleBackColor = True
      '
      'ckbControlesDefault
      '
      Me.ckbControlesDefault.AutoSize = True
      Me.ckbControlesDefault.ForeColor = System.Drawing.Color.DarkGreen
      Me.ckbControlesDefault.Location = New System.Drawing.Point(302, 20)
      Me.ckbControlesDefault.Name = "ckbControlesDefault"
      Me.ckbControlesDefault.Size = New System.Drawing.Size(114, 17)
      Me.ckbControlesDefault.TabIndex = 169
      Me.ckbControlesDefault.Text = "Valores por default"
      Me.ckbControlesDefault.UseVisualStyleBackColor = True
      '
      'Label43
      '
      Me.Label43.AutoSize = True
      Me.Label43.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label43.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label43.Location = New System.Drawing.Point(550, 18)
      Me.Label43.Name = "Label43"
      Me.Label43.Size = New System.Drawing.Size(44, 15)
      Me.Label43.TabIndex = 112
      Me.Label43.Text = "Fecha:"
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(600, 16)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 111
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.dgvPlacaLeida)
      Me.GroupBox2.Location = New System.Drawing.Point(3, 237)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(711, 222)
      Me.GroupBox2.TabIndex = 178
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Datos obtenidos desde el lector"
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
      Me.dgvPlacaLeida.BackgroundColor = System.Drawing.Color.White
      Me.dgvPlacaLeida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.dgvPlacaLeida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.dgvPlacaLeida.DefaultCellStyle = DataGridViewCellStyle3
      Me.dgvPlacaLeida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.dgvPlacaLeida.GridColor = System.Drawing.Color.Gray
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(7, 15)
      Me.dgvPlacaLeida.Name = "dgvPlacaLeida"
      Me.dgvPlacaLeida.ReadOnly = True
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.dgvPlacaLeida.RowsDefaultCellStyle = DataGridViewCellStyle5
      Me.dgvPlacaLeida.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.dgvPlacaLeida.Size = New System.Drawing.Size(698, 200)
      Me.dgvPlacaLeida.TabIndex = 142
      Me.dgvPlacaLeida.TabStop = False
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.Label1)
      Me.GroupBox3.Controls.Add(Me.lblNombreLector)
      Me.GroupBox3.Controls.Add(Me.Label43)
      Me.GroupBox3.Controls.Add(Me.dtpFechaElaboracion)
      Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(711, 45)
      Me.GroupBox3.TabIndex = 179
      Me.GroupBox3.TabStop = False
      Me.GroupBox3.Text = "Nombre del lector default"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.Maroon
      Me.Label1.Location = New System.Drawing.Point(7, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(159, 16)
      Me.Label1.TabIndex = 148
      Me.Label1.Text = "Nombre del Lecto default:"
      '
      'lblNombreLector
      '
      Me.lblNombreLector.AutoSize = True
      Me.lblNombreLector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreLector.ForeColor = System.Drawing.Color.Black
      Me.lblNombreLector.Location = New System.Drawing.Point(168, 20)
      Me.lblNombreLector.Name = "lblNombreLector"
      Me.lblNombreLector.Size = New System.Drawing.Size(250, 16)
      Me.lblNombreLector.TabIndex = 147
      Me.lblNombreLector.Text = "Nombre del Lector utilizado como default"
      '
      'SerialPort1
      '
      Me.SerialPort1.PortName = "COM3"
      '
      'btnPreverInfome
      '
      Me.btnPreverInfome.Enabled = False
      Me.btnPreverInfome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnPreverInfome.Image = CType(resources.GetObject("btnPreverInfome.Image"), System.Drawing.Image)
      Me.btnPreverInfome.Location = New System.Drawing.Point(646, 19)
      Me.btnPreverInfome.Name = "btnPreverInfome"
      Me.btnPreverInfome.Size = New System.Drawing.Size(44, 30)
      Me.btnPreverInfome.TabIndex = 12
      Me.ToolTip1.SetToolTip(Me.btnPreverInfome, "Visualizar el archivo de resultados.")
      Me.btnPreverInfome.UseVisualStyleBackColor = True
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Enabled = False
      Me.btnLeerDatosPlaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(514, 213)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(200, 23)
      Me.btnLeerDatosPlaca.TabIndex = 182
      Me.btnLeerDatosPlaca.Text = "Obtener datos desde el lector"
      Me.ToolTip1.SetToolTip(Me.btnLeerDatosPlaca, "Obtener información desde Lector")
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'grpArchivoFinal
      '
      Me.grpArchivoFinal.Controls.Add(Me.Label2)
      Me.grpArchivoFinal.Controls.Add(Me.PictureBox1)
      Me.grpArchivoFinal.Controls.Add(Me.btnPreverInfome)
      Me.grpArchivoFinal.Controls.Add(Me.txtNombrePlaca)
      Me.grpArchivoFinal.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpArchivoFinal.Location = New System.Drawing.Point(3, 460)
      Me.grpArchivoFinal.Name = "grpArchivoFinal"
      Me.grpArchivoFinal.Size = New System.Drawing.Size(711, 61)
      Me.grpArchivoFinal.TabIndex = 180
      Me.grpArchivoFinal.TabStop = False
      Me.grpArchivoFinal.Text = "Informe Final de Resultados"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Label2.Location = New System.Drawing.Point(76, 28)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(103, 13)
      Me.Label2.TabIndex = 183
      Me.Label2.Text = "Nombre del Archivo:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(12, 17)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 182
      Me.PictureBox1.TabStop = False
      '
      'txtNombrePlaca
      '
      Me.txtNombrePlaca.BackColor = System.Drawing.Color.White
      Me.txtNombrePlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNombrePlaca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
      Me.txtNombrePlaca.Location = New System.Drawing.Point(182, 25)
      Me.txtNombrePlaca.Name = "txtNombrePlaca"
      Me.txtNombrePlaca.ReadOnly = True
      Me.txtNombrePlaca.Size = New System.Drawing.Size(446, 20)
      Me.txtNombrePlaca.TabIndex = 5
      '
      'btnCancelar
      '
      Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(597, 527)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(117, 23)
      Me.btnCancelar.TabIndex = 181
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.BackColor = System.Drawing.Color.White
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(299, 213)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.ReadOnly = True
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(105, 21)
      Me.txtDatosRecibidos.TabIndex = 183
      Me.txtDatosRecibidos.TabStop = False
      Me.txtDatosRecibidos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
      Me.txtDatosRecibidos.Visible = False
      '
      'cmbComboPorts
      '
      Me.cmbComboPorts.Enabled = False
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(406, 213)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(100, 21)
      Me.cmbComboPorts.TabIndex = 182
      Me.cmbComboPorts.TabStop = False
      Me.cmbComboPorts.Visible = False
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
      Me.PictureBox2.Location = New System.Drawing.Point(10, 53)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(277, 178)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox2.TabIndex = 184
      Me.PictureBox2.TabStop = False
      '
      'frmLecturaDePlaca
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(720, 551)
      Me.Controls.Add(Me.PictureBox2)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.grpArchivoFinal)
      Me.Controls.Add(Me.GroupBox3)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GroupBox1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmLecturaDePlaca"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Leer datos de placa y guardar en archivo excel"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.grbControlesNegativos.ResumeLayout(False)
      Me.grbControlesNegativos.PerformLayout()
      Me.grbControlesPositivos.ResumeLayout(False)
      Me.grbControlesPositivos.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.grpArchivoFinal.ResumeLayout(False)
      Me.grpArchivoFinal.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
   Friend WithEvents btnAceptarControles As System.Windows.Forms.Button
   Friend WithEvents btnDefinirControlesPN As System.Windows.Forms.Button
   Friend WithEvents ckbControlesDefault As System.Windows.Forms.CheckBox
   Friend WithEvents Label41 As System.Windows.Forms.Label
   Friend WithEvents txtNoControlesNegativos As System.Windows.Forms.TextBox
   Friend WithEvents txtNoControlesPositivos As System.Windows.Forms.TextBox
   Friend WithEvents lblNoControles As System.Windows.Forms.Label
   Friend WithEvents Label43 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblNombreLector As System.Windows.Forms.Label
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents grpArchivoFinal As System.Windows.Forms.GroupBox
   Friend WithEvents btnPreverInfome As System.Windows.Forms.Button
   Friend WithEvents txtNombrePlaca As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
