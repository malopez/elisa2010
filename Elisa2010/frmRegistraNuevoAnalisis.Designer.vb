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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.sfdGuardarPlaca = New System.Windows.Forms.SaveFileDialog()
      Me.btnDefinirControlesPN = New System.Windows.Forms.Button()
      Me.txtCP3Valor3 = New System.Windows.Forms.TextBox()
      Me.lblCPNo1 = New System.Windows.Forms.Label()
      Me.txtCP3Letra3 = New System.Windows.Forms.TextBox()
      Me.lblCPNo2 = New System.Windows.Forms.Label()
      Me.txtCP2Valor2 = New System.Windows.Forms.TextBox()
      Me.lblCPNo3 = New System.Windows.Forms.Label()
      Me.txtCP2Letra2 = New System.Windows.Forms.TextBox()
      Me.txtCP1Valor1 = New System.Windows.Forms.TextBox()
      Me.txtCP1Letra1 = New System.Windows.Forms.TextBox()
      Me.grbControlesPositivos = New System.Windows.Forms.GroupBox()
      Me.btnNuevoAnalisisCancelar = New System.Windows.Forms.Button()
      Me.btnObtenerResultados = New System.Windows.Forms.Button()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
      Me.btnAceptarControles = New System.Windows.Forms.Button()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.btnBuscaCaso = New System.Windows.Forms.Button()
      Me.lblMensajeCaso = New System.Windows.Forms.Label()
      Me.pnlRegistraNuevoAnalisis = New System.Windows.Forms.Panel()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.lblLogTit2 = New System.Windows.Forms.Label()
      Me.lblLogTit1 = New System.Windows.Forms.Label()
      Me.lblLogSPS = New System.Windows.Forms.Label()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.txtDesdeLetra1 = New System.Windows.Forms.TextBox()
      Me.txtDesdeValor1 = New System.Windows.Forms.TextBox()
      Me.txtHastaLetra2 = New System.Windows.Forms.TextBox()
      Me.txtHastaValor2 = New System.Windows.Forms.TextBox()
      Me.ckbControlesDefault = New System.Windows.Forms.CheckBox()
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
      Me.btnFormateaDatos = New System.Windows.Forms.Button()
      Me.btnGuardarDatosExcel = New System.Windows.Forms.Button()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.grbControlesPositivos.SuspendLayout()
      Me.pnlRegistraNuevoAnalisis.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.grbControlesNegativos.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNoCaso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCaso.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCaso.Location = New System.Drawing.Point(7, 23)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(109, 16)
      Me.lblNoCaso.TabIndex = 1
      Me.lblNoCaso.Text = "Número de caso:"
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreCliente.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreCliente.Location = New System.Drawing.Point(7, 60)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(125, 16)
      Me.lblNombreCliente.TabIndex = 2
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreAnalisis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreAnalisis.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(7, 96)
      Me.lblNombreAnalisis.Name = "lblNombreAnalisis"
      Me.lblNombreAnalisis.Size = New System.Drawing.Size(126, 16)
      Me.lblNombreAnalisis.TabIndex = 6
      Me.lblNombreAnalisis.Text = "Nombre del análisis:"
      '
      'SerialPort1
      '
      Me.SerialPort1.PortName = "COM3"
      Me.SerialPort1.StopBits = System.IO.Ports.StopBits.Two
      '
      'btnDefinirControlesPN
      '
      Me.btnDefinirControlesPN.BackColor = System.Drawing.SystemColors.Control
      Me.btnDefinirControlesPN.Enabled = False
      Me.btnDefinirControlesPN.Location = New System.Drawing.Point(400, 78)
      Me.btnDefinirControlesPN.Name = "btnDefinirControlesPN"
      Me.btnDefinirControlesPN.Size = New System.Drawing.Size(113, 23)
      Me.btnDefinirControlesPN.TabIndex = 5
      Me.btnDefinirControlesPN.Text = "Definir Controles"
      Me.btnDefinirControlesPN.UseVisualStyleBackColor = False
      '
      'txtCP3Valor3
      '
      Me.txtCP3Valor3.Location = New System.Drawing.Point(78, 77)
      Me.txtCP3Valor3.MaxLength = 2
      Me.txtCP3Valor3.Name = "txtCP3Valor3"
      Me.txtCP3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Valor3.TabIndex = 11
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
      '
      'txtCP3Letra3
      '
      Me.txtCP3Letra3.Location = New System.Drawing.Point(46, 77)
      Me.txtCP3Letra3.MaxLength = 1
      Me.txtCP3Letra3.Name = "txtCP3Letra3"
      Me.txtCP3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCP3Letra3.TabIndex = 10
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
      '
      'txtCP2Valor2
      '
      Me.txtCP2Valor2.Location = New System.Drawing.Point(79, 50)
      Me.txtCP2Valor2.MaxLength = 2
      Me.txtCP2Valor2.Name = "txtCP2Valor2"
      Me.txtCP2Valor2.Size = New System.Drawing.Size(24, 22)
      Me.txtCP2Valor2.TabIndex = 9
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
      '
      'txtCP2Letra2
      '
      Me.txtCP2Letra2.Location = New System.Drawing.Point(46, 50)
      Me.txtCP2Letra2.MaxLength = 1
      Me.txtCP2Letra2.Name = "txtCP2Letra2"
      Me.txtCP2Letra2.Size = New System.Drawing.Size(25, 22)
      Me.txtCP2Letra2.TabIndex = 8
      '
      'txtCP1Valor1
      '
      Me.txtCP1Valor1.Location = New System.Drawing.Point(78, 25)
      Me.txtCP1Valor1.MaxLength = 2
      Me.txtCP1Valor1.Name = "txtCP1Valor1"
      Me.txtCP1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Valor1.TabIndex = 7
      '
      'txtCP1Letra1
      '
      Me.txtCP1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCP1Letra1.MaxLength = 1
      Me.txtCP1Letra1.Name = "txtCP1Letra1"
      Me.txtCP1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCP1Letra1.TabIndex = 6
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
      Me.grbControlesPositivos.Location = New System.Drawing.Point(86, 8)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(140, 110)
      Me.grbControlesPositivos.TabIndex = 28
      Me.grbControlesPositivos.TabStop = False
      Me.grbControlesPositivos.Text = "Controles Positivos"
      '
      'btnNuevoAnalisisCancelar
      '
      Me.btnNuevoAnalisisCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnNuevoAnalisisCancelar.Location = New System.Drawing.Point(626, 521)
      Me.btnNuevoAnalisisCancelar.Name = "btnNuevoAnalisisCancelar"
      Me.btnNuevoAnalisisCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnNuevoAnalisisCancelar.TabIndex = 21
      Me.btnNuevoAnalisisCancelar.Text = "Cancelar"
      Me.btnNuevoAnalisisCancelar.UseVisualStyleBackColor = True
      '
      'btnObtenerResultados
      '
      Me.btnObtenerResultados.Enabled = False
      Me.btnObtenerResultados.Location = New System.Drawing.Point(508, 521)
      Me.btnObtenerResultados.Name = "btnObtenerResultados"
      Me.btnObtenerResultados.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenerResultados.TabIndex = 20
      Me.btnObtenerResultados.Text = "Obtener Resultados"
      Me.btnObtenerResultados.UseVisualStyleBackColor = True
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Enabled = False
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(422, 157)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerDatosPlaca.TabIndex = 2
      Me.btnLeerDatosPlaca.Text = "Leer Datos"
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'cmbComboPorts
      '
      Me.cmbComboPorts.Enabled = False
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(295, 157)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(121, 21)
      Me.cmbComboPorts.TabIndex = 19
      Me.cmbComboPorts.TabStop = False
      '
      'btnAceptarControles
      '
      Me.btnAceptarControles.BackColor = System.Drawing.SystemColors.Control
      Me.btnAceptarControles.Enabled = False
      Me.btnAceptarControles.Location = New System.Drawing.Point(243, 521)
      Me.btnAceptarControles.Name = "btnAceptarControles"
      Me.btnAceptarControles.Size = New System.Drawing.Size(113, 23)
      Me.btnAceptarControles.TabIndex = 18
      Me.btnAceptarControles.Text = "Aceptar Controles"
      Me.btnAceptarControles.UseVisualStyleBackColor = False
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Location = New System.Drawing.Point(136, 22)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(182, 21)
      Me.cmbNoCaso.TabIndex = 0
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.Location = New System.Drawing.Point(136, 59)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 2
      Me.txtNombreCliente.TabStop = False
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(136, 94)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 3
      Me.txtAnalisisSolicitado.TabStop = False
      '
      'btnBuscaCaso
      '
      Me.btnBuscaCaso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscaCaso.ForeColor = System.Drawing.Color.SteelBlue
      Me.btnBuscaCaso.Image = CType(resources.GetObject("btnBuscaCaso.Image"), System.Drawing.Image)
      Me.btnBuscaCaso.Location = New System.Drawing.Point(324, 21)
      Me.btnBuscaCaso.Name = "btnBuscaCaso"
      Me.btnBuscaCaso.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaCaso.TabIndex = 0
      Me.btnBuscaCaso.UseVisualStyleBackColor = True
      '
      'lblMensajeCaso
      '
      Me.lblMensajeCaso.AutoSize = True
      Me.lblMensajeCaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeCaso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.lblMensajeCaso.Location = New System.Drawing.Point(3, 7)
      Me.lblMensajeCaso.Name = "lblMensajeCaso"
      Me.lblMensajeCaso.Size = New System.Drawing.Size(58, 13)
      Me.lblMensajeCaso.TabIndex = 72
      Me.lblMensajeCaso.Text = "Mensaje:"
      '
      'pnlRegistraNuevoAnalisis
      '
      Me.pnlRegistraNuevoAnalisis.AutoSize = True
      Me.pnlRegistraNuevoAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.pnlRegistraNuevoAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.dtpFechaElaboracion)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtAnalisisSolicitado)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.btnBuscaCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.cmbNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreAnalisis)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Location = New System.Drawing.Point(4, 9)
      Me.pnlRegistraNuevoAnalisis.Name = "pnlRegistraNuevoAnalisis"
      Me.pnlRegistraNuevoAnalisis.Size = New System.Drawing.Size(698, 142)
      Me.pnlRegistraNuevoAnalisis.TabIndex = 73
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(480, 24)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 8
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(532, 53)
      Me.lblLogTit2.Name = "lblLogTit2"
      Me.lblLogTit2.Size = New System.Drawing.Size(53, 13)
      Me.lblLogTit2.TabIndex = 12
      Me.lblLogTit2.Text = "logsSPS: "
      Me.lblLogTit2.Visible = False
      '
      'lblLogTit1
      '
      Me.lblLogTit1.AutoSize = True
      Me.lblLogTit1.Location = New System.Drawing.Point(532, 36)
      Me.lblLogTit1.Name = "lblLogTit1"
      Me.lblLogTit1.Size = New System.Drawing.Size(45, 13)
      Me.lblLogTit1.TabIndex = 11
      Me.lblLogTit1.Text = "logTit1: "
      Me.lblLogTit1.Visible = False
      '
      'lblLogSPS
      '
      Me.lblLogSPS.AutoSize = True
      Me.lblLogSPS.Location = New System.Drawing.Point(532, 20)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(53, 13)
      Me.lblLogSPS.TabIndex = 10
      Me.lblLogSPS.Text = "logsSPS: "
      Me.lblLogSPS.Visible = False
      '
      'Panel1
      '
      Me.Panel1.AutoSize = True
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.lblMensajeCaso)
      Me.Panel1.Location = New System.Drawing.Point(4, 548)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(698, 30)
      Me.Panel1.TabIndex = 74
      '
      'Panel2
      '
      Me.Panel2.AutoSize = True
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.Label19)
      Me.Panel2.Controls.Add(Me.Label20)
      Me.Panel2.Controls.Add(Me.txtDesdeLetra1)
      Me.Panel2.Controls.Add(Me.txtDesdeValor1)
      Me.Panel2.Controls.Add(Me.txtHastaLetra2)
      Me.Panel2.Controls.Add(Me.txtHastaValor2)
      Me.Panel2.Controls.Add(Me.lblLogTit2)
      Me.Panel2.Controls.Add(Me.ckbControlesDefault)
      Me.Panel2.Controls.Add(Me.lblLogTit1)
      Me.Panel2.Controls.Add(Me.btnDefinirControlesPN)
      Me.Panel2.Controls.Add(Me.lblLogSPS)
      Me.Panel2.Controls.Add(Me.grbControlesPositivos)
      Me.Panel2.Controls.Add(Me.grbControlesNegativos)
      Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel2.Location = New System.Drawing.Point(4, 186)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(698, 128)
      Me.Panel2.TabIndex = 75
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label19.Location = New System.Drawing.Point(535, 102)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(43, 16)
      Me.Label19.TabIndex = 98
      Me.Label19.Text = "Hasta:"
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label20.Location = New System.Drawing.Point(535, 70)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(48, 16)
      Me.Label20.TabIndex = 97
      Me.Label20.Text = "Desde:"
      '
      'txtDesdeLetra1
      '
      Me.txtDesdeLetra1.BackColor = System.Drawing.SystemColors.Window
      Me.txtDesdeLetra1.Enabled = False
      Me.txtDesdeLetra1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeLetra1.Location = New System.Drawing.Point(589, 69)
      Me.txtDesdeLetra1.MaxLength = 1
      Me.txtDesdeLetra1.Name = "txtDesdeLetra1"
      Me.txtDesdeLetra1.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeLetra1.TabIndex = 93
      '
      'txtDesdeValor1
      '
      Me.txtDesdeValor1.BackColor = System.Drawing.SystemColors.Window
      Me.txtDesdeValor1.Enabled = False
      Me.txtDesdeValor1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeValor1.Location = New System.Drawing.Point(621, 69)
      Me.txtDesdeValor1.MaxLength = 2
      Me.txtDesdeValor1.Name = "txtDesdeValor1"
      Me.txtDesdeValor1.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeValor1.TabIndex = 94
      '
      'txtHastaLetra2
      '
      Me.txtHastaLetra2.BackColor = System.Drawing.SystemColors.Window
      Me.txtHastaLetra2.Enabled = False
      Me.txtHastaLetra2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaLetra2.Location = New System.Drawing.Point(589, 101)
      Me.txtHastaLetra2.MaxLength = 1
      Me.txtHastaLetra2.Name = "txtHastaLetra2"
      Me.txtHastaLetra2.Size = New System.Drawing.Size(25, 20)
      Me.txtHastaLetra2.TabIndex = 95
      '
      'txtHastaValor2
      '
      Me.txtHastaValor2.BackColor = System.Drawing.SystemColors.Window
      Me.txtHastaValor2.Enabled = False
      Me.txtHastaValor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaValor2.Location = New System.Drawing.Point(622, 101)
      Me.txtHastaValor2.MaxLength = 2
      Me.txtHastaValor2.Name = "txtHastaValor2"
      Me.txtHastaValor2.Size = New System.Drawing.Size(24, 20)
      Me.txtHastaValor2.TabIndex = 96
      '
      'ckbControlesDefault
      '
      Me.ckbControlesDefault.AutoSize = True
      Me.ckbControlesDefault.ForeColor = System.Drawing.Color.DarkGreen
      Me.ckbControlesDefault.Location = New System.Drawing.Point(400, 35)
      Me.ckbControlesDefault.Name = "ckbControlesDefault"
      Me.ckbControlesDefault.Size = New System.Drawing.Size(114, 17)
      Me.ckbControlesDefault.TabIndex = 4
      Me.ckbControlesDefault.Text = "Valores por default"
      Me.ckbControlesDefault.UseVisualStyleBackColor = True
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
      Me.grbControlesNegativos.Location = New System.Drawing.Point(232, 8)
      Me.grbControlesNegativos.Name = "grbControlesNegativos"
      Me.grbControlesNegativos.Size = New System.Drawing.Size(140, 110)
      Me.grbControlesNegativos.TabIndex = 25
      Me.grbControlesNegativos.TabStop = False
      Me.grbControlesNegativos.Text = "Controles Negativos"
      '
      'txtCN2Letra2
      '
      Me.txtCN2Letra2.Location = New System.Drawing.Point(46, 50)
      Me.txtCN2Letra2.MaxLength = 1
      Me.txtCN2Letra2.Name = "txtCN2Letra2"
      Me.txtCN2Letra2.Size = New System.Drawing.Size(24, 22)
      Me.txtCN2Letra2.TabIndex = 14
      '
      'txtCN1Letra1
      '
      Me.txtCN1Letra1.Location = New System.Drawing.Point(46, 25)
      Me.txtCN1Letra1.MaxLength = 1
      Me.txtCN1Letra1.Name = "txtCN1Letra1"
      Me.txtCN1Letra1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Letra1.TabIndex = 12
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
      '
      'txtCN1Valor1
      '
      Me.txtCN1Valor1.Location = New System.Drawing.Point(79, 25)
      Me.txtCN1Valor1.MaxLength = 2
      Me.txtCN1Valor1.Name = "txtCN1Valor1"
      Me.txtCN1Valor1.Size = New System.Drawing.Size(25, 22)
      Me.txtCN1Valor1.TabIndex = 13
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
      '
      'txtCN2Valor2
      '
      Me.txtCN2Valor2.Location = New System.Drawing.Point(79, 50)
      Me.txtCN2Valor2.MaxLength = 2
      Me.txtCN2Valor2.Name = "txtCN2Valor2"
      Me.txtCN2Valor2.Size = New System.Drawing.Size(25, 22)
      Me.txtCN2Valor2.TabIndex = 15
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
      '
      'txtCN3Letra3
      '
      Me.txtCN3Letra3.Location = New System.Drawing.Point(46, 76)
      Me.txtCN3Letra3.MaxLength = 1
      Me.txtCN3Letra3.Name = "txtCN3Letra3"
      Me.txtCN3Letra3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Letra3.TabIndex = 16
      '
      'txtCN3Valor3
      '
      Me.txtCN3Valor3.Location = New System.Drawing.Point(79, 76)
      Me.txtCN3Valor3.MaxLength = 2
      Me.txtCN3Valor3.Name = "txtCN3Valor3"
      Me.txtCN3Valor3.Size = New System.Drawing.Size(25, 22)
      Me.txtCN3Valor3.TabIndex = 17
      '
      'btnFormateaDatos
      '
      Me.btnFormateaDatos.Enabled = False
      Me.btnFormateaDatos.Location = New System.Drawing.Point(541, 157)
      Me.btnFormateaDatos.Name = "btnFormateaDatos"
      Me.btnFormateaDatos.Size = New System.Drawing.Size(113, 23)
      Me.btnFormateaDatos.TabIndex = 3
      Me.btnFormateaDatos.Text = "Formatear Datos"
      Me.btnFormateaDatos.UseVisualStyleBackColor = True
      '
      'btnGuardarDatosExcel
      '
      Me.btnGuardarDatosExcel.BackColor = System.Drawing.SystemColors.Control
      Me.btnGuardarDatosExcel.Enabled = False
      Me.btnGuardarDatosExcel.Location = New System.Drawing.Point(362, 521)
      Me.btnGuardarDatosExcel.Name = "btnGuardarDatosExcel"
      Me.btnGuardarDatosExcel.Size = New System.Drawing.Size(140, 23)
      Me.btnGuardarDatosExcel.TabIndex = 19
      Me.btnGuardarDatosExcel.Text = "Guardar Datos en Excel"
      Me.btnGuardarDatosExcel.UseVisualStyleBackColor = False
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Location = New System.Drawing.Point(110, 526)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
      Me.lblObservaciones.TabIndex = 78
      Me.lblObservaciones.Text = "Observaciones:"
      Me.lblObservaciones.Visible = False
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(4, 159)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.ReadOnly = True
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(693, 208)
      Me.txtDatosRecibidos.TabIndex = 80
      Me.txtDatosRecibidos.Visible = False
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
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(4, 317)
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
      Me.dgvPlacaLeida.TabIndex = 81
      Me.dgvPlacaLeida.TabStop = False
      '
      'frmRegistraNuevoAnalisis
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(709, 582)
      Me.Controls.Add(Me.dgvPlacaLeida)
      Me.Controls.Add(Me.lblObservaciones)
      Me.Controls.Add(Me.btnGuardarDatosExcel)
      Me.Controls.Add(Me.btnAceptarControles)
      Me.Controls.Add(Me.btnFormateaDatos)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.btnObtenerResultados)
      Me.Controls.Add(Me.btnNuevoAnalisisCancelar)
      Me.Controls.Add(Me.pnlRegistraNuevoAnalisis)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmRegistraNuevoAnalisis"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Registra nuevo análisis"
      Me.grbControlesPositivos.ResumeLayout(False)
      Me.grbControlesPositivos.PerformLayout()
      Me.pnlRegistraNuevoAnalisis.ResumeLayout(False)
      Me.pnlRegistraNuevoAnalisis.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.grbControlesNegativos.ResumeLayout(False)
      Me.grbControlesNegativos.PerformLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents sfdGuardarPlaca As System.Windows.Forms.SaveFileDialog
   Friend WithEvents btnDefinirControlesPN As System.Windows.Forms.Button
   Friend WithEvents txtCP3Valor3 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo1 As System.Windows.Forms.Label
   Friend WithEvents txtCP3Letra3 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo2 As System.Windows.Forms.Label
   Friend WithEvents txtCP2Valor2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCPNo3 As System.Windows.Forms.Label
   Friend WithEvents txtCP2Letra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP1Valor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCP1Letra1 As System.Windows.Forms.TextBox
   Friend WithEvents grbControlesPositivos As System.Windows.Forms.GroupBox
   Friend WithEvents btnNuevoAnalisisCancelar As System.Windows.Forms.Button
   Friend WithEvents btnObtenerResultados As System.Windows.Forms.Button
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
   Friend WithEvents btnAceptarControles As System.Windows.Forms.Button
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents btnBuscaCaso As System.Windows.Forms.Button
   Friend WithEvents lblMensajeCaso As System.Windows.Forms.Label
   Friend WithEvents pnlRegistraNuevoAnalisis As System.Windows.Forms.Panel
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
   Friend WithEvents btnFormateaDatos As System.Windows.Forms.Button
   Friend WithEvents ckbControlesDefault As System.Windows.Forms.CheckBox
   Friend WithEvents btnGuardarDatosExcel As System.Windows.Forms.Button
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtDesdeLetra1 As System.Windows.Forms.TextBox
   Friend WithEvents txtDesdeValor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaLetra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaValor2 As System.Windows.Forms.TextBox
End Class
