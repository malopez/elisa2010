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
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.sfdGuardarPlaca = New System.Windows.Forms.SaveFileDialog()
      Me.btnDefinirControlesPN = New System.Windows.Forms.Button()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
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
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Panel2 = New System.Windows.Forms.Panel()
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
      Me.grbControlesPositivos.SuspendLayout()
      Me.pnlRegistraNuevoAnalisis.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.grbControlesNegativos.SuspendLayout()
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
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.BackColor = System.Drawing.Color.White
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(4, 189)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.ReadOnly = True
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(596, 117)
      Me.txtDatosRecibidos.TabIndex = 20
      Me.txtDatosRecibidos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
      Me.grbControlesPositivos.Location = New System.Drawing.Point(73, 8)
      Me.grbControlesPositivos.Name = "grbControlesPositivos"
      Me.grbControlesPositivos.Size = New System.Drawing.Size(140, 110)
      Me.grbControlesPositivos.TabIndex = 28
      Me.grbControlesPositivos.TabStop = False
      Me.grbControlesPositivos.Text = "Controles Positivos"
      '
      'btnNuevoAnalisisCancelar
      '
      Me.btnNuevoAnalisisCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnNuevoAnalisisCancelar.Location = New System.Drawing.Point(525, 448)
      Me.btnNuevoAnalisisCancelar.Name = "btnNuevoAnalisisCancelar"
      Me.btnNuevoAnalisisCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnNuevoAnalisisCancelar.TabIndex = 20
      Me.btnNuevoAnalisisCancelar.Text = "Cancelar"
      Me.btnNuevoAnalisisCancelar.UseVisualStyleBackColor = True
      '
      'btnObtenerResultados
      '
      Me.btnObtenerResultados.Enabled = False
      Me.btnObtenerResultados.Location = New System.Drawing.Point(407, 448)
      Me.btnObtenerResultados.Name = "btnObtenerResultados"
      Me.btnObtenerResultados.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenerResultados.TabIndex = 19
      Me.btnObtenerResultados.Text = "Obtener Resultados"
      Me.btnObtenerResultados.UseVisualStyleBackColor = True
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Enabled = False
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(368, 157)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerDatosPlaca.TabIndex = 4
      Me.btnLeerDatosPlaca.Text = "Leer Datos"
      Me.btnLeerDatosPlaca.UseVisualStyleBackColor = True
      '
      'cmbComboPorts
      '
      Me.cmbComboPorts.Enabled = False
      Me.cmbComboPorts.FormattingEnabled = True
      Me.cmbComboPorts.Location = New System.Drawing.Point(241, 157)
      Me.cmbComboPorts.Name = "cmbComboPorts"
      Me.cmbComboPorts.Size = New System.Drawing.Size(121, 21)
      Me.cmbComboPorts.TabIndex = 19
      '
      'btnAceptarControles
      '
      Me.btnAceptarControles.BackColor = System.Drawing.SystemColors.Control
      Me.btnAceptarControles.Enabled = False
      Me.btnAceptarControles.Location = New System.Drawing.Point(288, 448)
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
      Me.cmbNoCaso.TabIndex = 1
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.Location = New System.Drawing.Point(136, 59)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 2
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(136, 94)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 3
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
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtAnalisisSolicitado)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.btnBuscaCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.cmbNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreAnalisis)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Location = New System.Drawing.Point(4, 9)
      Me.pnlRegistraNuevoAnalisis.Name = "pnlRegistraNuevoAnalisis"
      Me.pnlRegistraNuevoAnalisis.Size = New System.Drawing.Size(596, 142)
      Me.pnlRegistraNuevoAnalisis.TabIndex = 73
      '
      'Panel1
      '
      Me.Panel1.AutoSize = True
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.lblMensajeCaso)
      Me.Panel1.Location = New System.Drawing.Point(4, 477)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(596, 30)
      Me.Panel1.TabIndex = 74
      '
      'Panel2
      '
      Me.Panel2.AutoSize = True
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.ckbControlesDefault)
      Me.Panel2.Controls.Add(Me.btnDefinirControlesPN)
      Me.Panel2.Controls.Add(Me.grbControlesPositivos)
      Me.Panel2.Controls.Add(Me.grbControlesNegativos)
      Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel2.Location = New System.Drawing.Point(4, 317)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(596, 125)
      Me.Panel2.TabIndex = 75
      '
      'ckbControlesDefault
      '
      Me.ckbControlesDefault.AutoSize = True
      Me.ckbControlesDefault.ForeColor = System.Drawing.Color.DarkGreen
      Me.ckbControlesDefault.Location = New System.Drawing.Point(400, 35)
      Me.ckbControlesDefault.Name = "ckbControlesDefault"
      Me.ckbControlesDefault.Size = New System.Drawing.Size(114, 17)
      Me.ckbControlesDefault.TabIndex = 29
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
      Me.btnFormateaDatos.Location = New System.Drawing.Point(487, 157)
      Me.btnFormateaDatos.Name = "btnFormateaDatos"
      Me.btnFormateaDatos.Size = New System.Drawing.Size(113, 23)
      Me.btnFormateaDatos.TabIndex = 76
      Me.btnFormateaDatos.Text = "Formatear Datos"
      Me.btnFormateaDatos.UseVisualStyleBackColor = True
      '
      'btnGuardarDatosExcel
      '
      Me.btnGuardarDatosExcel.BackColor = System.Drawing.SystemColors.Control
      Me.btnGuardarDatosExcel.Enabled = False
      Me.btnGuardarDatosExcel.Location = New System.Drawing.Point(142, 448)
      Me.btnGuardarDatosExcel.Name = "btnGuardarDatosExcel"
      Me.btnGuardarDatosExcel.Size = New System.Drawing.Size(140, 23)
      Me.btnGuardarDatosExcel.TabIndex = 77
      Me.btnGuardarDatosExcel.Text = "Guardar Datos en Excel"
      Me.btnGuardarDatosExcel.UseVisualStyleBackColor = False
      '
      'frmRegistraNuevoAnalisis
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(605, 510)
      Me.Controls.Add(Me.btnGuardarDatosExcel)
      Me.Controls.Add(Me.btnAceptarControles)
      Me.Controls.Add(Me.btnFormateaDatos)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.btnObtenerResultados)
      Me.Controls.Add(Me.btnNuevoAnalisisCancelar)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.Controls.Add(Me.pnlRegistraNuevoAnalisis)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel1)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmRegistraNuevoAnalisis"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents sfdGuardarPlaca As System.Windows.Forms.SaveFileDialog
   Friend WithEvents btnDefinirControlesPN As System.Windows.Forms.Button
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
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
End Class
