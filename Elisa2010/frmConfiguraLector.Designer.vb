<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguraLector
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguraLector))
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.txtNombreLector = New System.Windows.Forms.TextBox()
      Me.lblNombreLector = New System.Windows.Forms.Label()
      Me.chkLectorDefault = New System.Windows.Forms.CheckBox()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.gpbSB = New System.Windows.Forms.GroupBox()
      Me.rdbStopB2 = New System.Windows.Forms.RadioButton()
      Me.rdbStopB15 = New System.Windows.Forms.RadioButton()
      Me.rdbStopB1 = New System.Windows.Forms.RadioButton()
      Me.gpbBDD = New System.Windows.Forms.GroupBox()
      Me.rdbBDD8 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD7 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD6 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD5 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD4 = New System.Windows.Forms.RadioButton()
      Me.gpbParidad = New System.Windows.Forms.GroupBox()
      Me.rdbParidadSpace = New System.Windows.Forms.RadioButton()
      Me.rdbParidadOdd = New System.Windows.Forms.RadioButton()
      Me.rdbParidadNone = New System.Windows.Forms.RadioButton()
      Me.rdbParidadMark = New System.Windows.Forms.RadioButton()
      Me.rdbParidadEven = New System.Windows.Forms.RadioButton()
      Me.gpbBPS = New System.Windows.Forms.GroupBox()
      Me.rdbBPS19200 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS9600 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS4800 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS2400 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS1200 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS600 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS300 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS110 = New System.Windows.Forms.RadioButton()
      Me.btnAceptarCL = New System.Windows.Forms.Button()
      Me.btnCancelaCL = New System.Windows.Forms.Button()
      Me.btnInsertar = New System.Windows.Forms.Button()
      Me.btnActualizar = New System.Windows.Forms.Button()
      Me.btnGuardar = New System.Windows.Forms.Button()
      Me.btnInicio = New System.Windows.Forms.Button()
      Me.btnHaciaAtras = New System.Windows.Forms.Button()
      Me.lblNRLector = New System.Windows.Forms.Label()
      Me.btnHaciaAdelante = New System.Windows.Forms.Button()
      Me.btnFin = New System.Windows.Forms.Button()
      Me.btnEditar = New System.Windows.Forms.Button()
      Me.btnBorrar = New System.Windows.Forms.Button()
      Me.Panel4 = New System.Windows.Forms.Panel()
      Me.lblMensajeAnalisis = New System.Windows.Forms.Label()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.gpbSB.SuspendLayout()
      Me.gpbBDD.SuspendLayout()
      Me.gpbParidad.SuspendLayout()
      Me.gpbBPS.SuspendLayout()
      Me.Panel4.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.txtNombreLector)
      Me.Panel1.Controls.Add(Me.lblNombreLector)
      Me.Panel1.Controls.Add(Me.chkLectorDefault)
      Me.Panel1.Location = New System.Drawing.Point(8, 7)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(616, 53)
      Me.Panel1.TabIndex = 0
      '
      'txtNombreLector
      '
      Me.txtNombreLector.Location = New System.Drawing.Point(145, 12)
      Me.txtNombreLector.Name = "txtNombreLector"
      Me.txtNombreLector.ReadOnly = True
      Me.txtNombreLector.Size = New System.Drawing.Size(309, 20)
      Me.txtNombreLector.TabIndex = 3
      '
      'lblNombreLector
      '
      Me.lblNombreLector.AutoSize = True
      Me.lblNombreLector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreLector.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreLector.Location = New System.Drawing.Point(16, 13)
      Me.lblNombreLector.Name = "lblNombreLector"
      Me.lblNombreLector.Size = New System.Drawing.Size(123, 16)
      Me.lblNombreLector.TabIndex = 1
      Me.lblNombreLector.Text = "Nombre del Lector: "
      '
      'chkLectorDefault
      '
      Me.chkLectorDefault.AutoSize = True
      Me.chkLectorDefault.Enabled = False
      Me.chkLectorDefault.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkLectorDefault.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.chkLectorDefault.Location = New System.Drawing.Point(464, 13)
      Me.chkLectorDefault.Name = "chkLectorDefault"
      Me.chkLectorDefault.Size = New System.Drawing.Size(67, 20)
      Me.chkLectorDefault.TabIndex = 0
      Me.chkLectorDefault.Text = "Default"
      Me.chkLectorDefault.UseVisualStyleBackColor = True
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.gpbSB)
      Me.Panel2.Controls.Add(Me.gpbBDD)
      Me.Panel2.Controls.Add(Me.gpbParidad)
      Me.Panel2.Controls.Add(Me.gpbBPS)
      Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel2.Location = New System.Drawing.Point(8, 111)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(616, 200)
      Me.Panel2.TabIndex = 1
      '
      'gpbSB
      '
      Me.gpbSB.BackColor = System.Drawing.Color.Transparent
      Me.gpbSB.Controls.Add(Me.rdbStopB2)
      Me.gpbSB.Controls.Add(Me.rdbStopB15)
      Me.gpbSB.Controls.Add(Me.rdbStopB1)
      Me.gpbSB.Enabled = False
      Me.gpbSB.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gpbSB.ForeColor = System.Drawing.Color.MidnightBlue
      Me.gpbSB.Location = New System.Drawing.Point(425, 12)
      Me.gpbSB.Name = "gpbSB"
      Me.gpbSB.Size = New System.Drawing.Size(117, 115)
      Me.gpbSB.TabIndex = 3
      Me.gpbSB.TabStop = False
      Me.gpbSB.Text = "Bits de Parada"
      '
      'rdbStopB2
      '
      Me.rdbStopB2.Checked = True
      Me.rdbStopB2.Location = New System.Drawing.Point(18, 94)
      Me.rdbStopB2.Name = "rdbStopB2"
      Me.rdbStopB2.Size = New System.Drawing.Size(56, 17)
      Me.rdbStopB2.TabIndex = 24
      Me.rdbStopB2.TabStop = True
      Me.rdbStopB2.Text = "2"
      Me.rdbStopB2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbStopB2.UseVisualStyleBackColor = True
      '
      'rdbStopB15
      '
      Me.rdbStopB15.Enabled = False
      Me.rdbStopB15.Location = New System.Drawing.Point(18, 63)
      Me.rdbStopB15.Name = "rdbStopB15"
      Me.rdbStopB15.Size = New System.Drawing.Size(56, 17)
      Me.rdbStopB15.TabIndex = 23
      Me.rdbStopB15.Text = "1.5"
      Me.rdbStopB15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbStopB15.UseVisualStyleBackColor = True
      '
      'rdbStopB1
      '
      Me.rdbStopB1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.rdbStopB1.Location = New System.Drawing.Point(18, 33)
      Me.rdbStopB1.Name = "rdbStopB1"
      Me.rdbStopB1.Size = New System.Drawing.Size(56, 17)
      Me.rdbStopB1.TabIndex = 22
      Me.rdbStopB1.Text = "1"
      Me.rdbStopB1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbStopB1.UseVisualStyleBackColor = True
      '
      'gpbBDD
      '
      Me.gpbBDD.BackColor = System.Drawing.Color.Transparent
      Me.gpbBDD.Controls.Add(Me.rdbBDD8)
      Me.gpbBDD.Controls.Add(Me.rdbBDD7)
      Me.gpbBDD.Controls.Add(Me.rdbBDD6)
      Me.gpbBDD.Controls.Add(Me.rdbBDD5)
      Me.gpbBDD.Controls.Add(Me.rdbBDD4)
      Me.gpbBDD.Enabled = False
      Me.gpbBDD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gpbBDD.ForeColor = System.Drawing.Color.MidnightBlue
      Me.gpbBDD.Location = New System.Drawing.Point(223, 12)
      Me.gpbBDD.Name = "gpbBDD"
      Me.gpbBDD.Size = New System.Drawing.Size(99, 181)
      Me.gpbBDD.TabIndex = 2
      Me.gpbBDD.TabStop = False
      Me.gpbBDD.Text = "Bits de Datos"
      '
      'rdbBDD8
      '
      Me.rdbBDD8.Checked = True
      Me.rdbBDD8.Location = New System.Drawing.Point(18, 151)
      Me.rdbBDD8.Name = "rdbBDD8"
      Me.rdbBDD8.Size = New System.Drawing.Size(40, 24)
      Me.rdbBDD8.TabIndex = 16
      Me.rdbBDD8.TabStop = True
      Me.rdbBDD8.Text = "8"
      Me.rdbBDD8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD8.UseVisualStyleBackColor = True
      '
      'rdbBDD7
      '
      Me.rdbBDD7.Location = New System.Drawing.Point(18, 121)
      Me.rdbBDD7.Name = "rdbBDD7"
      Me.rdbBDD7.Size = New System.Drawing.Size(40, 24)
      Me.rdbBDD7.TabIndex = 15
      Me.rdbBDD7.Text = "7"
      Me.rdbBDD7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD7.UseVisualStyleBackColor = True
      '
      'rdbBDD6
      '
      Me.rdbBDD6.Location = New System.Drawing.Point(18, 91)
      Me.rdbBDD6.Name = "rdbBDD6"
      Me.rdbBDD6.Size = New System.Drawing.Size(40, 24)
      Me.rdbBDD6.TabIndex = 14
      Me.rdbBDD6.Text = "6"
      Me.rdbBDD6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD6.UseVisualStyleBackColor = True
      '
      'rdbBDD5
      '
      Me.rdbBDD5.Location = New System.Drawing.Point(18, 59)
      Me.rdbBDD5.Name = "rdbBDD5"
      Me.rdbBDD5.Size = New System.Drawing.Size(40, 24)
      Me.rdbBDD5.TabIndex = 13
      Me.rdbBDD5.Text = "5"
      Me.rdbBDD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD5.UseVisualStyleBackColor = True
      '
      'rdbBDD4
      '
      Me.rdbBDD4.Location = New System.Drawing.Point(18, 29)
      Me.rdbBDD4.Name = "rdbBDD4"
      Me.rdbBDD4.Size = New System.Drawing.Size(40, 24)
      Me.rdbBDD4.TabIndex = 12
      Me.rdbBDD4.Text = "4"
      Me.rdbBDD4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD4.UseVisualStyleBackColor = True
      '
      'gpbParidad
      '
      Me.gpbParidad.BackColor = System.Drawing.Color.Transparent
      Me.gpbParidad.Controls.Add(Me.rdbParidadSpace)
      Me.gpbParidad.Controls.Add(Me.rdbParidadOdd)
      Me.gpbParidad.Controls.Add(Me.rdbParidadNone)
      Me.gpbParidad.Controls.Add(Me.rdbParidadMark)
      Me.gpbParidad.Controls.Add(Me.rdbParidadEven)
      Me.gpbParidad.Enabled = False
      Me.gpbParidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gpbParidad.ForeColor = System.Drawing.Color.MidnightBlue
      Me.gpbParidad.Location = New System.Drawing.Point(328, 12)
      Me.gpbParidad.Name = "gpbParidad"
      Me.gpbParidad.Size = New System.Drawing.Size(91, 181)
      Me.gpbParidad.TabIndex = 1
      Me.gpbParidad.TabStop = False
      Me.gpbParidad.Text = "Paridad"
      '
      'rdbParidadSpace
      '
      Me.rdbParidadSpace.Enabled = False
      Me.rdbParidadSpace.Location = New System.Drawing.Point(6, 151)
      Me.rdbParidadSpace.Name = "rdbParidadSpace"
      Me.rdbParidadSpace.Size = New System.Drawing.Size(71, 24)
      Me.rdbParidadSpace.TabIndex = 21
      Me.rdbParidadSpace.Text = "Space"
      Me.rdbParidadSpace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidadSpace.UseVisualStyleBackColor = True
      '
      'rdbParidadOdd
      '
      Me.rdbParidadOdd.Enabled = False
      Me.rdbParidadOdd.Location = New System.Drawing.Point(6, 125)
      Me.rdbParidadOdd.Name = "rdbParidadOdd"
      Me.rdbParidadOdd.Size = New System.Drawing.Size(71, 17)
      Me.rdbParidadOdd.TabIndex = 20
      Me.rdbParidadOdd.Text = "Odd"
      Me.rdbParidadOdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidadOdd.UseVisualStyleBackColor = True
      '
      'rdbParidadNone
      '
      Me.rdbParidadNone.Checked = True
      Me.rdbParidadNone.Location = New System.Drawing.Point(6, 94)
      Me.rdbParidadNone.Name = "rdbParidadNone"
      Me.rdbParidadNone.Size = New System.Drawing.Size(71, 17)
      Me.rdbParidadNone.TabIndex = 19
      Me.rdbParidadNone.TabStop = True
      Me.rdbParidadNone.Text = "None"
      Me.rdbParidadNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidadNone.UseVisualStyleBackColor = True
      '
      'rdbParidadMark
      '
      Me.rdbParidadMark.Enabled = False
      Me.rdbParidadMark.Location = New System.Drawing.Point(6, 63)
      Me.rdbParidadMark.Name = "rdbParidadMark"
      Me.rdbParidadMark.Size = New System.Drawing.Size(71, 17)
      Me.rdbParidadMark.TabIndex = 18
      Me.rdbParidadMark.Text = "Mark"
      Me.rdbParidadMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidadMark.UseVisualStyleBackColor = True
      '
      'rdbParidadEven
      '
      Me.rdbParidadEven.Enabled = False
      Me.rdbParidadEven.Location = New System.Drawing.Point(6, 33)
      Me.rdbParidadEven.Name = "rdbParidadEven"
      Me.rdbParidadEven.Size = New System.Drawing.Size(71, 17)
      Me.rdbParidadEven.TabIndex = 17
      Me.rdbParidadEven.Text = "Even"
      Me.rdbParidadEven.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidadEven.UseVisualStyleBackColor = True
      '
      'gpbBPS
      '
      Me.gpbBPS.BackColor = System.Drawing.Color.Transparent
      Me.gpbBPS.Controls.Add(Me.rdbBPS19200)
      Me.gpbBPS.Controls.Add(Me.rdbBPS9600)
      Me.gpbBPS.Controls.Add(Me.rdbBPS4800)
      Me.gpbBPS.Controls.Add(Me.rdbBPS2400)
      Me.gpbBPS.Controls.Add(Me.rdbBPS1200)
      Me.gpbBPS.Controls.Add(Me.rdbBPS600)
      Me.gpbBPS.Controls.Add(Me.rdbBPS300)
      Me.gpbBPS.Controls.Add(Me.rdbBPS110)
      Me.gpbBPS.Enabled = False
      Me.gpbBPS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gpbBPS.ForeColor = System.Drawing.Color.MidnightBlue
      Me.gpbBPS.Location = New System.Drawing.Point(67, 12)
      Me.gpbBPS.Name = "gpbBPS"
      Me.gpbBPS.Size = New System.Drawing.Size(150, 181)
      Me.gpbBPS.TabIndex = 0
      Me.gpbBPS.TabStop = False
      Me.gpbBPS.Text = "Baudios por Segundo"
      '
      'rdbBPS19200
      '
      Me.rdbBPS19200.Location = New System.Drawing.Point(81, 121)
      Me.rdbBPS19200.Name = "rdbBPS19200"
      Me.rdbBPS19200.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS19200.TabIndex = 11
      Me.rdbBPS19200.Text = "19200"
      Me.rdbBPS19200.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS19200.UseVisualStyleBackColor = True
      '
      'rdbBPS9600
      '
      Me.rdbBPS9600.Checked = True
      Me.rdbBPS9600.Location = New System.Drawing.Point(81, 90)
      Me.rdbBPS9600.Name = "rdbBPS9600"
      Me.rdbBPS9600.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS9600.TabIndex = 10
      Me.rdbBPS9600.TabStop = True
      Me.rdbBPS9600.Text = "9600"
      Me.rdbBPS9600.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS9600.UseVisualStyleBackColor = True
      '
      'rdbBPS4800
      '
      Me.rdbBPS4800.Location = New System.Drawing.Point(81, 59)
      Me.rdbBPS4800.Name = "rdbBPS4800"
      Me.rdbBPS4800.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS4800.TabIndex = 9
      Me.rdbBPS4800.Text = "4800"
      Me.rdbBPS4800.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS4800.UseVisualStyleBackColor = True
      '
      'rdbBPS2400
      '
      Me.rdbBPS2400.Location = New System.Drawing.Point(81, 28)
      Me.rdbBPS2400.Name = "rdbBPS2400"
      Me.rdbBPS2400.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS2400.TabIndex = 8
      Me.rdbBPS2400.Text = "2400"
      Me.rdbBPS2400.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS2400.UseVisualStyleBackColor = True
      '
      'rdbBPS1200
      '
      Me.rdbBPS1200.Location = New System.Drawing.Point(15, 121)
      Me.rdbBPS1200.Name = "rdbBPS1200"
      Me.rdbBPS1200.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS1200.TabIndex = 7
      Me.rdbBPS1200.Text = "1200"
      Me.rdbBPS1200.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS1200.UseVisualStyleBackColor = True
      '
      'rdbBPS600
      '
      Me.rdbBPS600.Location = New System.Drawing.Point(15, 90)
      Me.rdbBPS600.Name = "rdbBPS600"
      Me.rdbBPS600.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS600.TabIndex = 6
      Me.rdbBPS600.Text = "600"
      Me.rdbBPS600.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS600.UseVisualStyleBackColor = True
      '
      'rdbBPS300
      '
      Me.rdbBPS300.Location = New System.Drawing.Point(15, 59)
      Me.rdbBPS300.Name = "rdbBPS300"
      Me.rdbBPS300.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS300.TabIndex = 5
      Me.rdbBPS300.Text = "300"
      Me.rdbBPS300.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS300.UseVisualStyleBackColor = True
      '
      'rdbBPS110
      '
      Me.rdbBPS110.Location = New System.Drawing.Point(15, 28)
      Me.rdbBPS110.Name = "rdbBPS110"
      Me.rdbBPS110.Size = New System.Drawing.Size(57, 25)
      Me.rdbBPS110.TabIndex = 4
      Me.rdbBPS110.Text = "110"
      Me.rdbBPS110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS110.UseVisualStyleBackColor = True
      '
      'btnAceptarCL
      '
      Me.btnAceptarCL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarCL.Location = New System.Drawing.Point(468, 317)
      Me.btnAceptarCL.Name = "btnAceptarCL"
      Me.btnAceptarCL.Size = New System.Drawing.Size(75, 23)
      Me.btnAceptarCL.TabIndex = 2
      Me.btnAceptarCL.Text = "Aceptar"
      Me.btnAceptarCL.UseVisualStyleBackColor = True
      '
      'btnCancelaCL
      '
      Me.btnCancelaCL.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelaCL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelaCL.Location = New System.Drawing.Point(549, 317)
      Me.btnCancelaCL.Name = "btnCancelaCL"
      Me.btnCancelaCL.Size = New System.Drawing.Size(75, 23)
      Me.btnCancelaCL.TabIndex = 3
      Me.btnCancelaCL.Text = "Cancelar"
      Me.btnCancelaCL.UseVisualStyleBackColor = True
      '
      'btnInsertar
      '
      Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
      Me.btnInsertar.Location = New System.Drawing.Point(331, 8)
      Me.btnInsertar.Name = "btnInsertar"
      Me.btnInsertar.Size = New System.Drawing.Size(37, 23)
      Me.btnInsertar.TabIndex = 75
      Me.btnInsertar.Tag = ""
      Me.btnInsertar.UseVisualStyleBackColor = True
      '
      'btnActualizar
      '
      Me.btnActualizar.Enabled = False
      Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
      Me.btnActualizar.Location = New System.Drawing.Point(418, 8)
      Me.btnActualizar.Name = "btnActualizar"
      Me.btnActualizar.Size = New System.Drawing.Size(37, 23)
      Me.btnActualizar.TabIndex = 77
      Me.btnActualizar.UseVisualStyleBackColor = True
      '
      'btnGuardar
      '
      Me.btnGuardar.Enabled = False
      Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
      Me.btnGuardar.Location = New System.Drawing.Point(461, 8)
      Me.btnGuardar.Name = "btnGuardar"
      Me.btnGuardar.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardar.TabIndex = 78
      Me.btnGuardar.UseVisualStyleBackColor = True
      '
      'btnInicio
      '
      Me.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnInicio.Location = New System.Drawing.Point(66, 8)
      Me.btnInicio.Name = "btnInicio"
      Me.btnInicio.Size = New System.Drawing.Size(37, 23)
      Me.btnInicio.TabIndex = 71
      Me.btnInicio.Text = "<<"
      Me.btnInicio.UseVisualStyleBackColor = True
      '
      'btnHaciaAtras
      '
      Me.btnHaciaAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAtras.Location = New System.Drawing.Point(109, 8)
      Me.btnHaciaAtras.Name = "btnHaciaAtras"
      Me.btnHaciaAtras.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAtras.TabIndex = 72
      Me.btnHaciaAtras.Text = "<"
      Me.btnHaciaAtras.UseVisualStyleBackColor = True
      '
      'lblNRLector
      '
      Me.lblNRLector.AutoSize = True
      Me.lblNRLector.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNRLector.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.lblNRLector.Location = New System.Drawing.Point(151, 12)
      Me.lblNRLector.Name = "lblNRLector"
      Me.lblNRLector.Size = New System.Drawing.Size(89, 15)
      Me.lblNRLector.TabIndex = 80
      Me.lblNRLector.Text = "Registro: 96 de 96"
      '
      'btnHaciaAdelante
      '
      Me.btnHaciaAdelante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAdelante.Location = New System.Drawing.Point(245, 8)
      Me.btnHaciaAdelante.Name = "btnHaciaAdelante"
      Me.btnHaciaAdelante.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAdelante.TabIndex = 73
      Me.btnHaciaAdelante.Text = ">"
      Me.btnHaciaAdelante.UseVisualStyleBackColor = True
      '
      'btnFin
      '
      Me.btnFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnFin.Location = New System.Drawing.Point(288, 8)
      Me.btnFin.Name = "btnFin"
      Me.btnFin.Size = New System.Drawing.Size(37, 23)
      Me.btnFin.TabIndex = 74
      Me.btnFin.Text = ">>"
      Me.btnFin.UseVisualStyleBackColor = True
      '
      'btnEditar
      '
      Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
      Me.btnEditar.Location = New System.Drawing.Point(374, 8)
      Me.btnEditar.Name = "btnEditar"
      Me.btnEditar.Size = New System.Drawing.Size(38, 23)
      Me.btnEditar.TabIndex = 76
      Me.btnEditar.UseVisualStyleBackColor = True
      '
      'btnBorrar
      '
      Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
      Me.btnBorrar.Location = New System.Drawing.Point(505, 8)
      Me.btnBorrar.Name = "btnBorrar"
      Me.btnBorrar.Size = New System.Drawing.Size(38, 23)
      Me.btnBorrar.TabIndex = 79
      Me.btnBorrar.UseVisualStyleBackColor = True
      '
      'Panel4
      '
      Me.Panel4.BackColor = System.Drawing.SystemColors.Control
      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel4.Controls.Add(Me.btnInsertar)
      Me.Panel4.Controls.Add(Me.btnBorrar)
      Me.Panel4.Controls.Add(Me.btnActualizar)
      Me.Panel4.Controls.Add(Me.btnEditar)
      Me.Panel4.Controls.Add(Me.btnGuardar)
      Me.Panel4.Controls.Add(Me.btnFin)
      Me.Panel4.Controls.Add(Me.btnInicio)
      Me.Panel4.Controls.Add(Me.btnHaciaAdelante)
      Me.Panel4.Controls.Add(Me.btnHaciaAtras)
      Me.Panel4.Controls.Add(Me.lblNRLector)
      Me.Panel4.Location = New System.Drawing.Point(8, 67)
      Me.Panel4.Name = "Panel4"
      Me.Panel4.Size = New System.Drawing.Size(616, 38)
      Me.Panel4.TabIndex = 2
      '
      'lblMensajeAnalisis
      '
      Me.lblMensajeAnalisis.AutoSize = True
      Me.lblMensajeAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeAnalisis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.lblMensajeAnalisis.Location = New System.Drawing.Point(3, 9)
      Me.lblMensajeAnalisis.Name = "lblMensajeAnalisis"
      Me.lblMensajeAnalisis.Size = New System.Drawing.Size(58, 13)
      Me.lblMensajeAnalisis.TabIndex = 71
      Me.lblMensajeAnalisis.Text = "Mensaje:"
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(143, 12)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(311, 20)
      Me.TextBox1.TabIndex = 3
      '
      'frmConfiguraLector
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(632, 343)
      Me.Controls.Add(Me.btnCancelaCL)
      Me.Controls.Add(Me.btnAceptarCL)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel4)
      Me.Controls.Add(Me.Panel1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmConfiguraLector"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Configura Lector"
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.gpbSB.ResumeLayout(False)
      Me.gpbBDD.ResumeLayout(False)
      Me.gpbParidad.ResumeLayout(False)
      Me.gpbBPS.ResumeLayout(False)
      Me.Panel4.ResumeLayout(False)
      Me.Panel4.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents lblNombreLector As System.Windows.Forms.Label
   Friend WithEvents chkLectorDefault As System.Windows.Forms.CheckBox
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents gpbSB As System.Windows.Forms.GroupBox
   Friend WithEvents gpbBDD As System.Windows.Forms.GroupBox
   Friend WithEvents gpbParidad As System.Windows.Forms.GroupBox
   Friend WithEvents gpbBPS As System.Windows.Forms.GroupBox
   Friend WithEvents btnAceptarCL As System.Windows.Forms.Button
   Friend WithEvents btnCancelaCL As System.Windows.Forms.Button
   Friend WithEvents btnInsertar As System.Windows.Forms.Button
   Friend WithEvents btnActualizar As System.Windows.Forms.Button
   Friend WithEvents btnGuardar As System.Windows.Forms.Button
   Friend WithEvents btnInicio As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAtras As System.Windows.Forms.Button
   Friend WithEvents lblNRLector As System.Windows.Forms.Label
   Friend WithEvents btnHaciaAdelante As System.Windows.Forms.Button
   Friend WithEvents btnFin As System.Windows.Forms.Button
   Friend WithEvents btnEditar As System.Windows.Forms.Button
   Friend WithEvents btnBorrar As System.Windows.Forms.Button
   Friend WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents rdbStopB15 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbStopB1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD8 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD7 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD6 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD5 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD4 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidadSpace As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidadOdd As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidadNone As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidadMark As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidadEven As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS19200 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS9600 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS4800 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS2400 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS1200 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS600 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS300 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS110 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbStopB2 As System.Windows.Forms.RadioButton
   Friend WithEvents lblMensajeAnalisis As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreLector As System.Windows.Forms.TextBox
End Class
