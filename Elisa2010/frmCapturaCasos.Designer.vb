<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturaCasos
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapturaCasos))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Label43 = New System.Windows.Forms.Label()
      Me.Label42 = New System.Windows.Forms.Label()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.cmbNombreEnfermedad = New System.Windows.Forms.ComboBox()
      Me.btnObtenerResultados = New System.Windows.Forms.Button()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.btnCapturaTerminada = New System.Windows.Forms.Button()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.tbcDatosDelCaso = New System.Windows.Forms.TabControl()
      Me.tbpDatosDelCaso = New System.Windows.Forms.TabPage()
      Me.btnAceptarEnfermedad = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
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
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
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
      Me.lblLogTit1 = New System.Windows.Forms.Label()
      Me.lblIdAnalisis = New System.Windows.Forms.Label()
      Me.lblLogTit2 = New System.Windows.Forms.Label()
      Me.ckbControlesDefault = New System.Windows.Forms.CheckBox()
      Me.lblLogSPS = New System.Windows.Forms.Label()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtNombreSobreGrafica = New System.Windows.Forms.TextBox()
      Me.Label41 = New System.Windows.Forms.Label()
      Me.txtNoControlesNegativos = New System.Windows.Forms.TextBox()
      Me.txtNoControlesPositivos = New System.Windows.Forms.TextBox()
      Me.lblNoCasos = New System.Windows.Forms.Label()
      Me.lblNoControles = New System.Windows.Forms.Label()
      Me.txtNoDeCasos = New System.Windows.Forms.TextBox()
      Me.tbpInformacionCaso = New System.Windows.Forms.TabPage()
      Me.txtObservaciones = New System.Windows.Forms.TextBox()
      Me.btnAceptaSubCasos = New System.Windows.Forms.Button()
      Me.lblNoSubCaso = New System.Windows.Forms.Label()
      Me.txtNoSubcasos = New System.Windows.Forms.TextBox()
      Me.chkSubCasos = New System.Windows.Forms.CheckBox()
      Me.txtMensajeSobreGrafica = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.txtDesdeLetra = New System.Windows.Forms.TextBox()
      Me.txtDesdeValor = New System.Windows.Forms.TextBox()
      Me.txtHastaLetra = New System.Windows.Forms.TextBox()
      Me.txtHastaValor = New System.Windows.Forms.TextBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.Label33 = New System.Windows.Forms.Label()
      Me.btnBuscaCaso = New System.Windows.Forms.Button()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.Label34 = New System.Windows.Forms.Label()
      Me.Label35 = New System.Windows.Forms.Label()
      Me.Panel5 = New System.Windows.Forms.Panel()
      Me.btnGuardarSubcaso = New System.Windows.Forms.Button()
      Me.btnNuevoSubcaso = New System.Windows.Forms.Button()
      Me.btnGuardarEditado = New System.Windows.Forms.Button()
      Me.btnInsertar = New System.Windows.Forms.Button()
      Me.btnGuardar = New System.Windows.Forms.Button()
      Me.btnEditar = New System.Windows.Forms.Button()
      Me.btnFin = New System.Windows.Forms.Button()
      Me.btnInicio = New System.Windows.Forms.Button()
      Me.btnHaciaAdelante = New System.Windows.Forms.Button()
      Me.btnHaciaAtras = New System.Windows.Forms.Button()
      Me.lblCasoDeCaso = New System.Windows.Forms.Label()
      Me.lblNombreLector = New System.Windows.Forms.Label()
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.txtNombrePlaca = New System.Windows.Forms.TextBox()
      Me.Panel1.SuspendLayout()
      Me.tbcDatosDelCaso.SuspendLayout()
      Me.tbpDatosDelCaso.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbControlesNegativos.SuspendLayout()
      Me.grbControlesPositivos.SuspendLayout()
      Me.tbpInformacionCaso.SuspendLayout()
      Me.Panel5.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.Label43)
      Me.Panel1.Controls.Add(Me.Label42)
      Me.Panel1.Controls.Add(Me.dtpFechaElaboracion)
      Me.Panel1.Controls.Add(Me.cmbNombreEnfermedad)
      Me.Panel1.Location = New System.Drawing.Point(6, 5)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(694, 32)
      Me.Panel1.TabIndex = 130
      '
      'Label43
      '
      Me.Label43.AutoSize = True
      Me.Label43.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label43.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label43.Location = New System.Drawing.Point(522, 5)
      Me.Label43.Name = "Label43"
      Me.Label43.Size = New System.Drawing.Size(44, 15)
      Me.Label43.TabIndex = 110
      Me.Label43.Text = "Fecha:"
      '
      'Label42
      '
      Me.Label42.AutoSize = True
      Me.Label42.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label42.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label42.Location = New System.Drawing.Point(7, 6)
      Me.Label42.Name = "Label42"
      Me.Label42.Size = New System.Drawing.Size(192, 15)
      Me.Label42.TabIndex = 109
      Me.Label42.Text = "Nombre y clave de la Enfermedad:"
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(572, 3)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 104
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'cmbNombreEnfermedad
      '
      Me.cmbNombreEnfermedad.Enabled = False
      Me.cmbNombreEnfermedad.FormattingEnabled = True
      Me.cmbNombreEnfermedad.Location = New System.Drawing.Point(205, 4)
      Me.cmbNombreEnfermedad.Name = "cmbNombreEnfermedad"
      Me.cmbNombreEnfermedad.Size = New System.Drawing.Size(221, 21)
      Me.cmbNombreEnfermedad.TabIndex = 103
      Me.cmbNombreEnfermedad.TabStop = False
      '
      'btnObtenerResultados
      '
      Me.btnObtenerResultados.Enabled = False
      Me.btnObtenerResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnObtenerResultados.Location = New System.Drawing.Point(442, 562)
      Me.btnObtenerResultados.Name = "btnObtenerResultados"
      Me.btnObtenerResultados.Size = New System.Drawing.Size(151, 23)
      Me.btnObtenerResultados.TabIndex = 33
      Me.btnObtenerResultados.Text = "Previsualizar Resultados"
      Me.btnObtenerResultados.UseVisualStyleBackColor = True
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Enabled = False
      Me.btnLeerDatosPlaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(280, 562)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(156, 23)
      Me.btnLeerDatosPlaca.TabIndex = 31
      Me.btnLeerDatosPlaca.Text = "Obtener datos desde el lector"
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'btnCancelar
      '
      Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(599, 562)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(105, 23)
      Me.btnCancelar.TabIndex = 34
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'btnCapturaTerminada
      '
      Me.btnCapturaTerminada.Enabled = False
      Me.btnCapturaTerminada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCapturaTerminada.Location = New System.Drawing.Point(542, 327)
      Me.btnCapturaTerminada.Name = "btnCapturaTerminada"
      Me.btnCapturaTerminada.Size = New System.Drawing.Size(162, 23)
      Me.btnCapturaTerminada.TabIndex = 30
      Me.btnCapturaTerminada.Text = "Aceptar datos capturados"
      Me.btnCapturaTerminada.UseVisualStyleBackColor = True
      '
      'SerialPort1
      '
      Me.SerialPort1.PortName = "COM3"
      '
      'tbcDatosDelCaso
      '
      Me.tbcDatosDelCaso.Controls.Add(Me.tbpDatosDelCaso)
      Me.tbcDatosDelCaso.Controls.Add(Me.tbpInformacionCaso)
      Me.tbcDatosDelCaso.Location = New System.Drawing.Point(7, 40)
      Me.tbcDatosDelCaso.Name = "tbcDatosDelCaso"
      Me.tbcDatosDelCaso.SelectedIndex = 0
      Me.tbcDatosDelCaso.Size = New System.Drawing.Size(698, 285)
      Me.tbcDatosDelCaso.TabIndex = 140
      '
      'tbpDatosDelCaso
      '
      Me.tbpDatosDelCaso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.tbpDatosDelCaso.Controls.Add(Me.btnAceptarEnfermedad)
      Me.tbpDatosDelCaso.Controls.Add(Me.PictureBox1)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtDatosRecibidos)
      Me.tbpDatosDelCaso.Controls.Add(Me.grbControlesNegativos)
      Me.tbpDatosDelCaso.Controls.Add(Me.cmbComboPorts)
      Me.tbpDatosDelCaso.Controls.Add(Me.grbControlesPositivos)
      Me.tbpDatosDelCaso.Controls.Add(Me.btnAceptarControles)
      Me.tbpDatosDelCaso.Controls.Add(Me.btnDefinirControlesPN)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogTit1)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblIdAnalisis)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogTit2)
      Me.tbpDatosDelCaso.Controls.Add(Me.ckbControlesDefault)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogSPS)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label8)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNombreSobreGrafica)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label41)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoControlesNegativos)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoControlesPositivos)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblNoCasos)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblNoControles)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoDeCasos)
      Me.tbpDatosDelCaso.Location = New System.Drawing.Point(4, 22)
      Me.tbpDatosDelCaso.Name = "tbpDatosDelCaso"
      Me.tbpDatosDelCaso.Padding = New System.Windows.Forms.Padding(3)
      Me.tbpDatosDelCaso.Size = New System.Drawing.Size(690, 259)
      Me.tbpDatosDelCaso.TabIndex = 0
      Me.tbpDatosDelCaso.Text = "Datos del caso y controles"
      '
      'btnAceptarEnfermedad
      '
      Me.btnAceptarEnfermedad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarEnfermedad.Location = New System.Drawing.Point(549, 91)
      Me.btnAceptarEnfermedad.Name = "btnAceptarEnfermedad"
      Me.btnAceptarEnfermedad.Size = New System.Drawing.Size(105, 23)
      Me.btnAceptarEnfermedad.TabIndex = 4
      Me.btnAceptarEnfermedad.Text = "Aceptar Casos"
      Me.btnAceptarEnfermedad.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.InitialImage = Nothing
      Me.PictureBox1.Location = New System.Drawing.Point(22, 11)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(151, 236)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 170
      Me.PictureBox1.TabStop = False
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.BackColor = System.Drawing.Color.White
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(50, 158)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.ReadOnly = True
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(105, 21)
      Me.txtDatosRecibidos.TabIndex = 169
      Me.txtDatosRecibidos.TabStop = False
      Me.txtDatosRecibidos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
      Me.txtDatosRecibidos.Visible = False
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
      Me.grbControlesNegativos.Location = New System.Drawing.Point(379, 135)
      Me.grbControlesNegativos.Name = "grbControlesNegativos"
      Me.grbControlesNegativos.Size = New System.Drawing.Size(140, 108)
      Me.grbControlesNegativos.TabIndex = 166
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
      'cmbComboPorts
      '
      Me.cmbComboPorts.Enabled = False
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(50, 186)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(100, 21)
      Me.cmbComboPorts.TabIndex = 168
      Me.cmbComboPorts.TabStop = False
      Me.cmbComboPorts.Visible = False
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
      Me.grbControlesPositivos.Location = New System.Drawing.Point(202, 135)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(141, 108)
      Me.grbControlesPositivos.TabIndex = 167
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
      Me.btnAceptarControles.Enabled = False
      Me.btnAceptarControles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarControles.Location = New System.Drawing.Point(549, 220)
      Me.btnAceptarControles.Name = "btnAceptarControles"
      Me.btnAceptarControles.Size = New System.Drawing.Size(105, 23)
      Me.btnAceptarControles.TabIndex = 6
      Me.btnAceptarControles.Text = "Aceptar Controles"
      Me.btnAceptarControles.UseVisualStyleBackColor = True
      '
      'btnDefinirControlesPN
      '
      Me.btnDefinirControlesPN.Enabled = False
      Me.btnDefinirControlesPN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnDefinirControlesPN.Location = New System.Drawing.Point(549, 185)
      Me.btnDefinirControlesPN.Name = "btnDefinirControlesPN"
      Me.btnDefinirControlesPN.Size = New System.Drawing.Size(105, 23)
      Me.btnDefinirControlesPN.TabIndex = 7
      Me.btnDefinirControlesPN.Text = "Definir Controles"
      Me.btnDefinirControlesPN.UseVisualStyleBackColor = True
      '
      'lblLogTit1
      '
      Me.lblLogTit1.AutoSize = True
      Me.lblLogTit1.Location = New System.Drawing.Point(105, 234)
      Me.lblLogTit1.Name = "lblLogTit1"
      Me.lblLogTit1.Size = New System.Drawing.Size(45, 13)
      Me.lblLogTit1.TabIndex = 163
      Me.lblLogTit1.Text = "logTit1: "
      Me.lblLogTit1.Visible = False
      '
      'lblIdAnalisis
      '
      Me.lblIdAnalisis.AutoSize = True
      Me.lblIdAnalisis.Location = New System.Drawing.Point(47, 234)
      Me.lblIdAnalisis.Name = "lblIdAnalisis"
      Me.lblIdAnalisis.Size = New System.Drawing.Size(55, 13)
      Me.lblIdAnalisis.TabIndex = 165
      Me.lblIdAnalisis.Text = "id_analisis"
      Me.lblIdAnalisis.Visible = False
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(106, 218)
      Me.lblLogTit2.Name = "lblLogTit2"
      Me.lblLogTit2.Size = New System.Drawing.Size(42, 13)
      Me.lblLogTit2.TabIndex = 164
      Me.lblLogTit2.Text = "logTit2:"
      Me.lblLogTit2.Visible = False
      '
      'ckbControlesDefault
      '
      Me.ckbControlesDefault.AutoSize = True
      Me.ckbControlesDefault.Enabled = False
      Me.ckbControlesDefault.ForeColor = System.Drawing.Color.DarkGreen
      Me.ckbControlesDefault.Location = New System.Drawing.Point(549, 151)
      Me.ckbControlesDefault.Name = "ckbControlesDefault"
      Me.ckbControlesDefault.Size = New System.Drawing.Size(114, 17)
      Me.ckbControlesDefault.TabIndex = 5
      Me.ckbControlesDefault.Text = "Valores por default"
      Me.ToolTip1.SetToolTip(Me.ckbControlesDefault, "Marque para valores default")
      Me.ckbControlesDefault.UseVisualStyleBackColor = True
      '
      'lblLogSPS
      '
      Me.lblLogSPS.AutoSize = True
      Me.lblLogSPS.Location = New System.Drawing.Point(47, 215)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(53, 13)
      Me.lblLogSPS.TabIndex = 162
      Me.lblLogSPS.Text = "logsSPS: "
      Me.lblLogSPS.Visible = False
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label8.Location = New System.Drawing.Point(199, 17)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(257, 16)
      Me.Label8.TabIndex = 158
      Me.Label8.Text = "Abreviatura del nombre de la enfermedad"
      '
      'txtNombreSobreGrafica
      '
      Me.txtNombreSobreGrafica.Location = New System.Drawing.Point(459, 16)
      Me.txtNombreSobreGrafica.Name = "txtNombreSobreGrafica"
      Me.txtNombreSobreGrafica.Size = New System.Drawing.Size(191, 20)
      Me.txtNombreSobreGrafica.TabIndex = 0
      Me.ToolTip1.SetToolTip(Me.txtNombreSobreGrafica, "Abreviatura de la enfermedad")
      '
      'Label41
      '
      Me.Label41.AutoSize = True
      Me.Label41.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label41.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label41.Location = New System.Drawing.Point(351, 91)
      Me.Label41.Name = "Label41"
      Me.Label41.Size = New System.Drawing.Size(100, 15)
      Me.Label41.TabIndex = 156
      Me.Label41.Text = "No. de Negativos"
      '
      'txtNoControlesNegativos
      '
      Me.txtNoControlesNegativos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesNegativos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesNegativos.Location = New System.Drawing.Point(457, 88)
      Me.txtNoControlesNegativos.MaxLength = 1
      Me.txtNoControlesNegativos.Name = "txtNoControlesNegativos"
      Me.txtNoControlesNegativos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesNegativos.TabIndex = 3
      Me.txtNoControlesNegativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.ToolTip1.SetToolTip(Me.txtNoControlesNegativos, "No. controles negativos")
      '
      'txtNoControlesPositivos
      '
      Me.txtNoControlesPositivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesPositivos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesPositivos.Location = New System.Drawing.Point(297, 89)
      Me.txtNoControlesPositivos.MaxLength = 1
      Me.txtNoControlesPositivos.Name = "txtNoControlesPositivos"
      Me.txtNoControlesPositivos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesPositivos.TabIndex = 2
      Me.txtNoControlesPositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.ToolTip1.SetToolTip(Me.txtNoControlesPositivos, "No. controles positivos")
      '
      'lblNoCasos
      '
      Me.lblNoCasos.AutoSize = True
      Me.lblNoCasos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCasos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCasos.Location = New System.Drawing.Point(199, 55)
      Me.lblNoCasos.Name = "lblNoCasos"
      Me.lblNoCasos.Size = New System.Drawing.Size(80, 15)
      Me.lblNoCasos.TabIndex = 154
      Me.lblNoCasos.Text = "No. de casos "
      '
      'lblNoControles
      '
      Me.lblNoControles.AutoSize = True
      Me.lblNoControles.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoControles.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoControles.Location = New System.Drawing.Point(199, 91)
      Me.lblNoControles.Name = "lblNoControles"
      Me.lblNoControles.Size = New System.Drawing.Size(92, 15)
      Me.lblNoControles.TabIndex = 155
      Me.lblNoControles.Text = "No. de Positivos"
      '
      'txtNoDeCasos
      '
      Me.txtNoDeCasos.Location = New System.Drawing.Point(297, 53)
      Me.txtNoDeCasos.MaxLength = 2
      Me.txtNoDeCasos.Name = "txtNoDeCasos"
      Me.txtNoDeCasos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoDeCasos.TabIndex = 1
      Me.ToolTip1.SetToolTip(Me.txtNoDeCasos, "No. casos en la placa")
      '
      'tbpInformacionCaso
      '
      Me.tbpInformacionCaso.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.tbpInformacionCaso.Controls.Add(Me.txtObservaciones)
      Me.tbpInformacionCaso.Controls.Add(Me.btnAceptaSubCasos)
      Me.tbpInformacionCaso.Controls.Add(Me.lblNoSubCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.txtNoSubcasos)
      Me.tbpInformacionCaso.Controls.Add(Me.chkSubCasos)
      Me.tbpInformacionCaso.Controls.Add(Me.txtMensajeSobreGrafica)
      Me.tbpInformacionCaso.Controls.Add(Me.Label7)
      Me.tbpInformacionCaso.Controls.Add(Me.Label1)
      Me.tbpInformacionCaso.Controls.Add(Me.Label19)
      Me.tbpInformacionCaso.Controls.Add(Me.Label20)
      Me.tbpInformacionCaso.Controls.Add(Me.txtDesdeLetra)
      Me.tbpInformacionCaso.Controls.Add(Me.txtDesdeValor)
      Me.tbpInformacionCaso.Controls.Add(Me.txtHastaLetra)
      Me.tbpInformacionCaso.Controls.Add(Me.txtHastaValor)
      Me.tbpInformacionCaso.Controls.Add(Me.txtNombreCliente)
      Me.tbpInformacionCaso.Controls.Add(Me.txtAnalisisSolicitado)
      Me.tbpInformacionCaso.Controls.Add(Me.Label33)
      Me.tbpInformacionCaso.Controls.Add(Me.btnBuscaCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.cmbNoCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.Label34)
      Me.tbpInformacionCaso.Controls.Add(Me.Label35)
      Me.tbpInformacionCaso.Controls.Add(Me.Panel5)
      Me.tbpInformacionCaso.Location = New System.Drawing.Point(4, 22)
      Me.tbpInformacionCaso.Name = "tbpInformacionCaso"
      Me.tbpInformacionCaso.Padding = New System.Windows.Forms.Padding(3)
      Me.tbpInformacionCaso.Size = New System.Drawing.Size(690, 259)
      Me.tbpInformacionCaso.TabIndex = 1
      Me.tbpInformacionCaso.Text = "Información específica de los casos"
      '
      'txtObservaciones
      '
      Me.txtObservaciones.BackColor = System.Drawing.Color.White
      Me.txtObservaciones.Enabled = False
      Me.txtObservaciones.Location = New System.Drawing.Point(181, 99)
      Me.txtObservaciones.Name = "txtObservaciones"
      Me.txtObservaciones.ReadOnly = True
      Me.txtObservaciones.Size = New System.Drawing.Size(449, 20)
      Me.txtObservaciones.TabIndex = 185
      '
      'btnAceptaSubCasos
      '
      Me.btnAceptaSubCasos.Enabled = False
      Me.btnAceptaSubCasos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAceptaSubCasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptaSubCasos.Location = New System.Drawing.Point(582, 11)
      Me.btnAceptaSubCasos.Name = "btnAceptaSubCasos"
      Me.btnAceptaSubCasos.Size = New System.Drawing.Size(48, 23)
      Me.btnAceptaSubCasos.TabIndex = 169
      Me.btnAceptaSubCasos.Text = "OK"
      Me.btnAceptaSubCasos.UseVisualStyleBackColor = True
      '
      'lblNoSubCaso
      '
      Me.lblNoSubCaso.AutoSize = True
      Me.lblNoSubCaso.Location = New System.Drawing.Point(659, 14)
      Me.lblNoSubCaso.Name = "lblNoSubCaso"
      Me.lblNoSubCaso.Size = New System.Drawing.Size(13, 13)
      Me.lblNoSubCaso.TabIndex = 175
      Me.lblNoSubCaso.Text = "1"
      Me.lblNoSubCaso.Visible = False
      '
      'txtNoSubcasos
      '
      Me.txtNoSubcasos.BackColor = System.Drawing.Color.White
      Me.txtNoSubcasos.Enabled = False
      Me.txtNoSubcasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNoSubcasos.Location = New System.Drawing.Point(552, 12)
      Me.txtNoSubcasos.MaxLength = 2
      Me.txtNoSubcasos.Name = "txtNoSubcasos"
      Me.txtNoSubcasos.Size = New System.Drawing.Size(24, 20)
      Me.txtNoSubcasos.TabIndex = 168
      Me.txtNoSubcasos.Text = "2"
      Me.txtNoSubcasos.Visible = False
      '
      'chkSubCasos
      '
      Me.chkSubCasos.AutoSize = True
      Me.chkSubCasos.Enabled = False
      Me.chkSubCasos.ForeColor = System.Drawing.Color.DarkGreen
      Me.chkSubCasos.Location = New System.Drawing.Point(473, 15)
      Me.chkSubCasos.Name = "chkSubCasos"
      Me.chkSubCasos.Size = New System.Drawing.Size(73, 17)
      Me.chkSubCasos.TabIndex = 167
      Me.chkSubCasos.Text = "Subcasos"
      Me.ToolTip1.SetToolTip(Me.chkSubCasos, "Marque si existen subcasos")
      Me.chkSubCasos.UseVisualStyleBackColor = True
      '
      'txtMensajeSobreGrafica
      '
      Me.txtMensajeSobreGrafica.BackColor = System.Drawing.Color.White
      Me.txtMensajeSobreGrafica.Enabled = False
      Me.txtMensajeSobreGrafica.Location = New System.Drawing.Point(181, 131)
      Me.txtMensajeSobreGrafica.Name = "txtMensajeSobreGrafica"
      Me.txtMensajeSobreGrafica.Size = New System.Drawing.Size(449, 20)
      Me.txtMensajeSobreGrafica.TabIndex = 170
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label7.Location = New System.Drawing.Point(52, 134)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(38, 15)
      Me.Label7.TabIndex = 184
      Me.Label7.Text = "Texto:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label1.Location = New System.Drawing.Point(52, 104)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 16)
      Me.Label1.TabIndex = 183
      Me.Label1.Text = "Observaciones:"
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label19.Location = New System.Drawing.Point(52, 190)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(43, 16)
      Me.Label19.TabIndex = 182
      Me.Label19.Text = "Hasta:"
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label20.Location = New System.Drawing.Point(52, 162)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(48, 16)
      Me.Label20.TabIndex = 181
      Me.Label20.Text = "Desde:"
      '
      'txtDesdeLetra
      '
      Me.txtDesdeLetra.BackColor = System.Drawing.Color.White
      Me.txtDesdeLetra.Enabled = False
      Me.txtDesdeLetra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeLetra.Location = New System.Drawing.Point(181, 158)
      Me.txtDesdeLetra.MaxLength = 1
      Me.txtDesdeLetra.Name = "txtDesdeLetra"
      Me.txtDesdeLetra.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeLetra.TabIndex = 171
      '
      'txtDesdeValor
      '
      Me.txtDesdeValor.BackColor = System.Drawing.Color.White
      Me.txtDesdeValor.Enabled = False
      Me.txtDesdeValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeValor.Location = New System.Drawing.Point(212, 158)
      Me.txtDesdeValor.MaxLength = 2
      Me.txtDesdeValor.Name = "txtDesdeValor"
      Me.txtDesdeValor.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeValor.TabIndex = 172
      '
      'txtHastaLetra
      '
      Me.txtHastaLetra.BackColor = System.Drawing.Color.White
      Me.txtHastaLetra.Enabled = False
      Me.txtHastaLetra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaLetra.Location = New System.Drawing.Point(181, 185)
      Me.txtHastaLetra.MaxLength = 1
      Me.txtHastaLetra.Name = "txtHastaLetra"
      Me.txtHastaLetra.Size = New System.Drawing.Size(25, 20)
      Me.txtHastaLetra.TabIndex = 173
      '
      'txtHastaValor
      '
      Me.txtHastaValor.BackColor = System.Drawing.Color.White
      Me.txtHastaValor.Enabled = False
      Me.txtHastaValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaValor.Location = New System.Drawing.Point(212, 185)
      Me.txtHastaValor.MaxLength = 2
      Me.txtHastaValor.Name = "txtHastaValor"
      Me.txtHastaValor.Size = New System.Drawing.Size(24, 20)
      Me.txtHastaValor.TabIndex = 174
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.BackColor = System.Drawing.Color.White
      Me.txtNombreCliente.Enabled = False
      Me.txtNombreCliente.Location = New System.Drawing.Point(181, 39)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 178
      Me.txtNombreCliente.TabStop = False
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.BackColor = System.Drawing.Color.White
      Me.txtAnalisisSolicitado.Enabled = False
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(181, 69)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 179
      Me.txtAnalisisSolicitado.TabStop = False
      '
      'Label33
      '
      Me.Label33.AutoSize = True
      Me.Label33.BackColor = System.Drawing.Color.Transparent
      Me.Label33.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label33.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label33.Location = New System.Drawing.Point(52, 12)
      Me.Label33.Name = "Label33"
      Me.Label33.Size = New System.Drawing.Size(109, 16)
      Me.Label33.TabIndex = 176
      Me.Label33.Text = "Número de caso:"
      '
      'btnBuscaCaso
      '
      Me.btnBuscaCaso.Enabled = False
      Me.btnBuscaCaso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscaCaso.ForeColor = System.Drawing.Color.SteelBlue
      Me.btnBuscaCaso.Image = CType(resources.GetObject("btnBuscaCaso.Image"), System.Drawing.Image)
      Me.btnBuscaCaso.Location = New System.Drawing.Point(369, 10)
      Me.btnBuscaCaso.Name = "btnBuscaCaso"
      Me.btnBuscaCaso.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaCaso.TabIndex = 10
      Me.ToolTip1.SetToolTip(Me.btnBuscaCaso, "Buscar el caso desplegado en combo.")
      Me.btnBuscaCaso.UseVisualStyleBackColor = True
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.BackColor = System.Drawing.Color.White
      Me.cmbNoCaso.Enabled = False
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Location = New System.Drawing.Point(181, 11)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(182, 21)
      Me.cmbNoCaso.TabIndex = 9
      '
      'Label34
      '
      Me.Label34.AutoSize = True
      Me.Label34.BackColor = System.Drawing.Color.Transparent
      Me.Label34.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label34.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label34.Location = New System.Drawing.Point(52, 72)
      Me.Label34.Name = "Label34"
      Me.Label34.Size = New System.Drawing.Size(126, 16)
      Me.Label34.TabIndex = 180
      Me.Label34.Text = "Nombre del análisis:"
      '
      'Label35
      '
      Me.Label35.AutoSize = True
      Me.Label35.BackColor = System.Drawing.Color.Transparent
      Me.Label35.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label35.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label35.Location = New System.Drawing.Point(52, 42)
      Me.Label35.Name = "Label35"
      Me.Label35.Size = New System.Drawing.Size(125, 16)
      Me.Label35.TabIndex = 177
      Me.Label35.Text = "Nombre del Cliente:"
      '
      'Panel5
      '
      Me.Panel5.BackColor = System.Drawing.SystemColors.Control
      Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel5.Controls.Add(Me.btnGuardarSubcaso)
      Me.Panel5.Controls.Add(Me.btnNuevoSubcaso)
      Me.Panel5.Controls.Add(Me.btnGuardarEditado)
      Me.Panel5.Controls.Add(Me.btnInsertar)
      Me.Panel5.Controls.Add(Me.btnGuardar)
      Me.Panel5.Controls.Add(Me.btnEditar)
      Me.Panel5.Controls.Add(Me.btnFin)
      Me.Panel5.Controls.Add(Me.btnInicio)
      Me.Panel5.Controls.Add(Me.btnHaciaAdelante)
      Me.Panel5.Controls.Add(Me.btnHaciaAtras)
      Me.Panel5.Controls.Add(Me.lblCasoDeCaso)
      Me.Panel5.Location = New System.Drawing.Point(12, 219)
      Me.Panel5.Name = "Panel5"
      Me.Panel5.Size = New System.Drawing.Size(665, 34)
      Me.Panel5.TabIndex = 143
      '
      'btnGuardarSubcaso
      '
      Me.btnGuardarSubcaso.Enabled = False
      Me.btnGuardarSubcaso.Image = CType(resources.GetObject("btnGuardarSubcaso.Image"), System.Drawing.Image)
      Me.btnGuardarSubcaso.Location = New System.Drawing.Point(601, 4)
      Me.btnGuardarSubcaso.Name = "btnGuardarSubcaso"
      Me.btnGuardarSubcaso.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardarSubcaso.TabIndex = 140
      Me.btnGuardarSubcaso.UseVisualStyleBackColor = True
      Me.btnGuardarSubcaso.Visible = False
      '
      'btnNuevoSubcaso
      '
      Me.btnNuevoSubcaso.Enabled = False
      Me.btnNuevoSubcaso.Image = CType(resources.GetObject("btnNuevoSubcaso.Image"), System.Drawing.Image)
      Me.btnNuevoSubcaso.Location = New System.Drawing.Point(557, 4)
      Me.btnNuevoSubcaso.Name = "btnNuevoSubcaso"
      Me.btnNuevoSubcaso.Size = New System.Drawing.Size(38, 23)
      Me.btnNuevoSubcaso.TabIndex = 139
      Me.btnNuevoSubcaso.UseVisualStyleBackColor = True
      Me.btnNuevoSubcaso.Visible = False
      '
      'btnGuardarEditado
      '
      Me.btnGuardarEditado.Enabled = False
      Me.btnGuardarEditado.Image = CType(resources.GetObject("btnGuardarEditado.Image"), System.Drawing.Image)
      Me.btnGuardarEditado.Location = New System.Drawing.Point(513, 4)
      Me.btnGuardarEditado.Name = "btnGuardarEditado"
      Me.btnGuardarEditado.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardarEditado.TabIndex = 138
      Me.btnGuardarEditado.UseVisualStyleBackColor = True
      '
      'btnInsertar
      '
      Me.btnInsertar.Enabled = False
      Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
      Me.btnInsertar.Location = New System.Drawing.Point(382, 4)
      Me.btnInsertar.Name = "btnInsertar"
      Me.btnInsertar.Size = New System.Drawing.Size(37, 23)
      Me.btnInsertar.TabIndex = 8
      Me.btnInsertar.Tag = ""
      Me.btnInsertar.UseVisualStyleBackColor = True
      '
      'btnGuardar
      '
      Me.btnGuardar.Enabled = False
      Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
      Me.btnGuardar.Location = New System.Drawing.Point(425, 4)
      Me.btnGuardar.Name = "btnGuardar"
      Me.btnGuardar.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardar.TabIndex = 136
      Me.btnGuardar.UseVisualStyleBackColor = True
      '
      'btnEditar
      '
      Me.btnEditar.Enabled = False
      Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
      Me.btnEditar.Location = New System.Drawing.Point(469, 4)
      Me.btnEditar.Name = "btnEditar"
      Me.btnEditar.Size = New System.Drawing.Size(38, 23)
      Me.btnEditar.TabIndex = 76
      Me.btnEditar.UseVisualStyleBackColor = True
      '
      'btnFin
      '
      Me.btnFin.Enabled = False
      Me.btnFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnFin.Location = New System.Drawing.Point(339, 4)
      Me.btnFin.Name = "btnFin"
      Me.btnFin.Size = New System.Drawing.Size(37, 23)
      Me.btnFin.TabIndex = 74
      Me.btnFin.Text = ">>"
      Me.btnFin.UseVisualStyleBackColor = True
      '
      'btnInicio
      '
      Me.btnInicio.Enabled = False
      Me.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnInicio.Location = New System.Drawing.Point(117, 4)
      Me.btnInicio.Name = "btnInicio"
      Me.btnInicio.Size = New System.Drawing.Size(37, 23)
      Me.btnInicio.TabIndex = 71
      Me.btnInicio.Text = "<<"
      Me.btnInicio.UseVisualStyleBackColor = True
      '
      'btnHaciaAdelante
      '
      Me.btnHaciaAdelante.Enabled = False
      Me.btnHaciaAdelante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAdelante.Location = New System.Drawing.Point(296, 4)
      Me.btnHaciaAdelante.Name = "btnHaciaAdelante"
      Me.btnHaciaAdelante.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAdelante.TabIndex = 73
      Me.btnHaciaAdelante.Text = ">"
      Me.btnHaciaAdelante.UseVisualStyleBackColor = True
      '
      'btnHaciaAtras
      '
      Me.btnHaciaAtras.Enabled = False
      Me.btnHaciaAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAtras.Location = New System.Drawing.Point(160, 4)
      Me.btnHaciaAtras.Name = "btnHaciaAtras"
      Me.btnHaciaAtras.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAtras.TabIndex = 72
      Me.btnHaciaAtras.Text = "<"
      Me.btnHaciaAtras.UseVisualStyleBackColor = True
      '
      'lblCasoDeCaso
      '
      Me.lblCasoDeCaso.AutoSize = True
      Me.lblCasoDeCaso.Enabled = False
      Me.lblCasoDeCaso.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCasoDeCaso.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.lblCasoDeCaso.Location = New System.Drawing.Point(202, 8)
      Me.lblCasoDeCaso.Name = "lblCasoDeCaso"
      Me.lblCasoDeCaso.Size = New System.Drawing.Size(49, 15)
      Me.lblCasoDeCaso.TabIndex = 80
      Me.lblCasoDeCaso.Text = "Caso No."
      '
      'lblNombreLector
      '
      Me.lblNombreLector.AutoSize = True
      Me.lblNombreLector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreLector.ForeColor = System.Drawing.Color.Maroon
      Me.lblNombreLector.Location = New System.Drawing.Point(8, 330)
      Me.lblNombreLector.Name = "lblNombreLector"
      Me.lblNombreLector.Size = New System.Drawing.Size(253, 16)
      Me.lblNombreLector.TabIndex = 146
      Me.lblNombreLector.Text = "Nombre del Lector utilizado como default:"
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
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(7, 356)
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
      Me.dgvPlacaLeida.TabIndex = 141
      Me.dgvPlacaLeida.TabStop = False
      '
      'txtNombrePlaca
      '
      Me.txtNombrePlaca.BackColor = System.Drawing.Color.White
      Me.txtNombrePlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNombrePlaca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
      Me.txtNombrePlaca.Location = New System.Drawing.Point(308, 331)
      Me.txtNombrePlaca.Name = "txtNombrePlaca"
      Me.txtNombrePlaca.ReadOnly = True
      Me.txtNombrePlaca.Size = New System.Drawing.Size(94, 20)
      Me.txtNombrePlaca.TabIndex = 147
      Me.txtNombrePlaca.Visible = False
      '
      'frmCapturaCasos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(708, 590)
      Me.Controls.Add(Me.txtNombrePlaca)
      Me.Controls.Add(Me.dgvPlacaLeida)
      Me.Controls.Add(Me.tbcDatosDelCaso)
      Me.Controls.Add(Me.lblNombreLector)
      Me.Controls.Add(Me.btnCapturaTerminada)
      Me.Controls.Add(Me.btnObtenerResultados)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.Panel1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmCapturaCasos"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Captura casos y subcasos"
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.tbcDatosDelCaso.ResumeLayout(False)
      Me.tbpDatosDelCaso.ResumeLayout(False)
      Me.tbpDatosDelCaso.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbControlesNegativos.ResumeLayout(False)
      Me.grbControlesNegativos.PerformLayout()
      Me.grbControlesPositivos.ResumeLayout(False)
      Me.grbControlesPositivos.PerformLayout()
      Me.tbpInformacionCaso.ResumeLayout(False)
      Me.tbpInformacionCaso.PerformLayout()
      Me.Panel5.ResumeLayout(False)
      Me.Panel5.PerformLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label43 As System.Windows.Forms.Label
   Friend WithEvents Label42 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents cmbNombreEnfermedad As System.Windows.Forms.ComboBox
   Friend WithEvents btnObtenerResultados As System.Windows.Forms.Button
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents btnCapturaTerminada As System.Windows.Forms.Button
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents tbcDatosDelCaso As System.Windows.Forms.TabControl
   Friend WithEvents tbpDatosDelCaso As System.Windows.Forms.TabPage
   Friend WithEvents lblNombreLector As System.Windows.Forms.Label
   Friend WithEvents tbpInformacionCaso As System.Windows.Forms.TabPage
   Friend WithEvents Panel5 As System.Windows.Forms.Panel
   Friend WithEvents btnInsertar As System.Windows.Forms.Button
   Friend WithEvents btnGuardar As System.Windows.Forms.Button
   Friend WithEvents btnEditar As System.Windows.Forms.Button
   Friend WithEvents btnFin As System.Windows.Forms.Button
   Friend WithEvents btnInicio As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAdelante As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAtras As System.Windows.Forms.Button
   Friend WithEvents lblCasoDeCaso As System.Windows.Forms.Label
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents btnGuardarEditado As System.Windows.Forms.Button
   Friend WithEvents btnGuardarSubcaso As System.Windows.Forms.Button
   Friend WithEvents btnNuevoSubcaso As System.Windows.Forms.Button
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtNombreSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents Label41 As System.Windows.Forms.Label
   Friend WithEvents txtNoControlesNegativos As System.Windows.Forms.TextBox
   Friend WithEvents txtNoControlesPositivos As System.Windows.Forms.TextBox
   Friend WithEvents lblNoCasos As System.Windows.Forms.Label
   Friend WithEvents lblNoControles As System.Windows.Forms.Label
   Friend WithEvents txtNoDeCasos As System.Windows.Forms.TextBox
   Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
   Friend WithEvents btnAceptaSubCasos As System.Windows.Forms.Button
   Friend WithEvents lblNoSubCaso As System.Windows.Forms.Label
   Friend WithEvents txtNoSubcasos As System.Windows.Forms.TextBox
   Friend WithEvents chkSubCasos As System.Windows.Forms.CheckBox
   Friend WithEvents txtMensajeSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtDesdeLetra As System.Windows.Forms.TextBox
   Friend WithEvents txtDesdeValor As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaLetra As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaValor As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents Label33 As System.Windows.Forms.Label
   Friend WithEvents btnBuscaCaso As System.Windows.Forms.Button
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents Label34 As System.Windows.Forms.Label
   Friend WithEvents Label35 As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
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
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
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
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
   Friend WithEvents lblIdAnalisis As System.Windows.Forms.Label
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents ckbControlesDefault As System.Windows.Forms.CheckBox
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
   Friend WithEvents btnAceptarEnfermedad As System.Windows.Forms.Button
   Friend WithEvents txtNombrePlaca As System.Windows.Forms.TextBox
End Class
