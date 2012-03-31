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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfLector))
      Me.rdbBPS1 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS2 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS3 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD1 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD3 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD2 = New System.Windows.Forms.RadioButton()
      Me.rdbParidad1 = New System.Windows.Forms.RadioButton()
      Me.rdbParidad2 = New System.Windows.Forms.RadioButton()
      Me.rdbBDP1 = New System.Windows.Forms.RadioButton()
      Me.rdbBDP2 = New System.Windows.Forms.RadioButton()
      Me.grbBaudiossPorSegundo = New System.Windows.Forms.GroupBox()
      Me.rdbBPS8 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS7 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS6 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS5 = New System.Windows.Forms.RadioButton()
      Me.rdbBPS4 = New System.Windows.Forms.RadioButton()
      Me.grbBitsDeDatos = New System.Windows.Forms.GroupBox()
      Me.rdbBDD8 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD7 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD6 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD5 = New System.Windows.Forms.RadioButton()
      Me.rdbBDD4 = New System.Windows.Forms.RadioButton()
      Me.grbParidad = New System.Windows.Forms.GroupBox()
      Me.grbBitsDeParada = New System.Windows.Forms.GroupBox()
      Me.rdbBDP3 = New System.Windows.Forms.RadioButton()
      Me.btnLectorAceptar = New System.Windows.Forms.Button()
      Me.btnLectorCancelar = New System.Windows.Forms.Button()
      Me.grbPuertoCom = New System.Windows.Forms.GroupBox()
      Me.rbtPuertoCom4 = New System.Windows.Forms.RadioButton()
      Me.rbtPuertoCom3 = New System.Windows.Forms.RadioButton()
      Me.rbtPuertoCom2 = New System.Windows.Forms.RadioButton()
      Me.rbtPuertoCom1 = New System.Windows.Forms.RadioButton()
      Me.lblmaxOdd = New System.Windows.Forms.Label()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.txtnomLector = New System.Windows.Forms.TextBox()
      Me.chkLectorDefault = New System.Windows.Forms.CheckBox()
      Me.lblNombreLector = New System.Windows.Forms.Label()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.grbBaudiossPorSegundo.SuspendLayout()
      Me.grbBitsDeDatos.SuspendLayout()
      Me.grbParidad.SuspendLayout()
      Me.grbBitsDeParada.SuspendLayout()
      Me.grbPuertoCom.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'rdbBPS1
      '
      Me.rdbBPS1.Location = New System.Drawing.Point(9, 31)
      Me.rdbBPS1.Name = "rdbBPS1"
      Me.rdbBPS1.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS1.TabIndex = 0
      Me.rdbBPS1.Text = "110"
      Me.rdbBPS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS1.UseVisualStyleBackColor = True
      '
      'rdbBPS2
      '
      Me.rdbBPS2.Location = New System.Drawing.Point(9, 54)
      Me.rdbBPS2.Name = "rdbBPS2"
      Me.rdbBPS2.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS2.TabIndex = 1
      Me.rdbBPS2.Text = "300"
      Me.rdbBPS2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS2.UseVisualStyleBackColor = True
      '
      'rdbBPS3
      '
      Me.rdbBPS3.Location = New System.Drawing.Point(9, 77)
      Me.rdbBPS3.Name = "rdbBPS3"
      Me.rdbBPS3.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS3.TabIndex = 2
      Me.rdbBPS3.Text = "600"
      Me.rdbBPS3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS3.UseVisualStyleBackColor = True
      '
      'rdbBDD1
      '
      Me.rdbBDD1.Checked = True
      Me.rdbBDD1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD1.Location = New System.Drawing.Point(11, 31)
      Me.rdbBDD1.Name = "rdbBDD1"
      Me.rdbBDD1.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD1.TabIndex = 4
      Me.rdbBDD1.TabStop = True
      Me.rdbBDD1.Text = "1 bits"
      Me.rdbBDD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD1.UseVisualStyleBackColor = True
      '
      'rdbBDD3
      '
      Me.rdbBDD3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD3.Location = New System.Drawing.Point(11, 77)
      Me.rdbBDD3.Name = "rdbBDD3"
      Me.rdbBDD3.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD3.TabIndex = 6
      Me.rdbBDD3.Text = "3 bits"
      Me.rdbBDD3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD3.UseVisualStyleBackColor = True
      '
      'rdbBDD2
      '
      Me.rdbBDD2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD2.Location = New System.Drawing.Point(11, 54)
      Me.rdbBDD2.Name = "rdbBDD2"
      Me.rdbBDD2.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD2.TabIndex = 7
      Me.rdbBDD2.Text = "2 bits"
      Me.rdbBDD2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD2.UseVisualStyleBackColor = True
      '
      'rdbParidad1
      '
      Me.rdbParidad1.Location = New System.Drawing.Point(6, 31)
      Me.rdbParidad1.Name = "rdbParidad1"
      Me.rdbParidad1.Size = New System.Drawing.Size(82, 17)
      Me.rdbParidad1.TabIndex = 8
      Me.rdbParidad1.Text = "Con paridad"
      Me.rdbParidad1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidad1.UseVisualStyleBackColor = True
      '
      'rdbParidad2
      '
      Me.rdbParidad2.Checked = True
      Me.rdbParidad2.Location = New System.Drawing.Point(6, 54)
      Me.rdbParidad2.Name = "rdbParidad2"
      Me.rdbParidad2.Size = New System.Drawing.Size(82, 17)
      Me.rdbParidad2.TabIndex = 9
      Me.rdbParidad2.TabStop = True
      Me.rdbParidad2.Text = "Sin paridad"
      Me.rdbParidad2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbParidad2.UseVisualStyleBackColor = True
      '
      'rdbBDP1
      '
      Me.rdbBDP1.Checked = True
      Me.rdbBDP1.Location = New System.Drawing.Point(6, 31)
      Me.rdbBDP1.Name = "rdbBDP1"
      Me.rdbBDP1.Size = New System.Drawing.Size(43, 17)
      Me.rdbBDP1.TabIndex = 10
      Me.rdbBDP1.TabStop = True
      Me.rdbBDP1.Text = "1"
      Me.rdbBDP1.UseVisualStyleBackColor = True
      '
      'rdbBDP2
      '
      Me.rdbBDP2.Location = New System.Drawing.Point(6, 54)
      Me.rdbBDP2.Name = "rdbBDP2"
      Me.rdbBDP2.Size = New System.Drawing.Size(43, 17)
      Me.rdbBDP2.TabIndex = 11
      Me.rdbBDP2.Text = "1.5 "
      Me.rdbBDP2.UseVisualStyleBackColor = True
      '
      'grbBaudiossPorSegundo
      '
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS8)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS7)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS6)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS5)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS4)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS3)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS2)
      Me.grbBaudiossPorSegundo.Controls.Add(Me.rdbBPS1)
      Me.grbBaudiossPorSegundo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.grbBaudiossPorSegundo.Location = New System.Drawing.Point(11, 66)
      Me.grbBaudiossPorSegundo.Name = "grbBaudiossPorSegundo"
      Me.grbBaudiossPorSegundo.Size = New System.Drawing.Size(92, 215)
      Me.grbBaudiossPorSegundo.TabIndex = 18
      Me.grbBaudiossPorSegundo.TabStop = False
      Me.grbBaudiossPorSegundo.Text = "Baudios por segundo"
      '
      'rdbBPS8
      '
      Me.rdbBPS8.Location = New System.Drawing.Point(9, 192)
      Me.rdbBPS8.Name = "rdbBPS8"
      Me.rdbBPS8.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS8.TabIndex = 7
      Me.rdbBPS8.Text = "19200"
      Me.rdbBPS8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS8.UseVisualStyleBackColor = True
      '
      'rdbBPS7
      '
      Me.rdbBPS7.Location = New System.Drawing.Point(9, 169)
      Me.rdbBPS7.Name = "rdbBPS7"
      Me.rdbBPS7.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS7.TabIndex = 6
      Me.rdbBPS7.Text = "9600"
      Me.rdbBPS7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS7.UseVisualStyleBackColor = True
      '
      'rdbBPS6
      '
      Me.rdbBPS6.Checked = True
      Me.rdbBPS6.Location = New System.Drawing.Point(9, 146)
      Me.rdbBPS6.Name = "rdbBPS6"
      Me.rdbBPS6.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS6.TabIndex = 5
      Me.rdbBPS6.TabStop = True
      Me.rdbBPS6.Text = "4800"
      Me.rdbBPS6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS6.UseVisualStyleBackColor = True
      '
      'rdbBPS5
      '
      Me.rdbBPS5.Location = New System.Drawing.Point(9, 123)
      Me.rdbBPS5.Name = "rdbBPS5"
      Me.rdbBPS5.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS5.TabIndex = 4
      Me.rdbBPS5.Text = "2400"
      Me.rdbBPS5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS5.UseVisualStyleBackColor = True
      '
      'rdbBPS4
      '
      Me.rdbBPS4.Location = New System.Drawing.Point(9, 100)
      Me.rdbBPS4.Name = "rdbBPS4"
      Me.rdbBPS4.Size = New System.Drawing.Size(55, 17)
      Me.rdbBPS4.TabIndex = 3
      Me.rdbBPS4.Text = "1200"
      Me.rdbBPS4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBPS4.UseVisualStyleBackColor = True
      '
      'grbBitsDeDatos
      '
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD8)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD7)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD6)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD5)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD4)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD2)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD3)
      Me.grbBitsDeDatos.Controls.Add(Me.rdbBDD1)
      Me.grbBitsDeDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.grbBitsDeDatos.Location = New System.Drawing.Point(112, 66)
      Me.grbBitsDeDatos.Name = "grbBitsDeDatos"
      Me.grbBitsDeDatos.Size = New System.Drawing.Size(96, 215)
      Me.grbBitsDeDatos.TabIndex = 19
      Me.grbBitsDeDatos.TabStop = False
      Me.grbBitsDeDatos.Text = "Bits de datos"
      '
      'rdbBDD8
      '
      Me.rdbBDD8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD8.Location = New System.Drawing.Point(11, 192)
      Me.rdbBDD8.Name = "rdbBDD8"
      Me.rdbBDD8.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD8.TabIndex = 12
      Me.rdbBDD8.Text = "8 bits"
      Me.rdbBDD8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD8.UseVisualStyleBackColor = True
      '
      'rdbBDD7
      '
      Me.rdbBDD7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD7.Location = New System.Drawing.Point(11, 169)
      Me.rdbBDD7.Name = "rdbBDD7"
      Me.rdbBDD7.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD7.TabIndex = 11
      Me.rdbBDD7.Text = "7 bits"
      Me.rdbBDD7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD7.UseVisualStyleBackColor = True
      '
      'rdbBDD6
      '
      Me.rdbBDD6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD6.Location = New System.Drawing.Point(11, 146)
      Me.rdbBDD6.Name = "rdbBDD6"
      Me.rdbBDD6.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD6.TabIndex = 10
      Me.rdbBDD6.Text = "6 bits"
      Me.rdbBDD6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD6.UseVisualStyleBackColor = True
      '
      'rdbBDD5
      '
      Me.rdbBDD5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD5.Location = New System.Drawing.Point(11, 123)
      Me.rdbBDD5.Name = "rdbBDD5"
      Me.rdbBDD5.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD5.TabIndex = 9
      Me.rdbBDD5.Text = "5 bits"
      Me.rdbBDD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD5.UseVisualStyleBackColor = True
      '
      'rdbBDD4
      '
      Me.rdbBDD4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD4.Location = New System.Drawing.Point(11, 100)
      Me.rdbBDD4.Name = "rdbBDD4"
      Me.rdbBDD4.Size = New System.Drawing.Size(50, 17)
      Me.rdbBDD4.TabIndex = 8
      Me.rdbBDD4.Text = "4 bits"
      Me.rdbBDD4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.rdbBDD4.UseVisualStyleBackColor = True
      '
      'grbParidad
      '
      Me.grbParidad.Controls.Add(Me.rdbParidad1)
      Me.grbParidad.Controls.Add(Me.rdbParidad2)
      Me.grbParidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.grbParidad.Location = New System.Drawing.Point(211, 66)
      Me.grbParidad.Name = "grbParidad"
      Me.grbParidad.Size = New System.Drawing.Size(102, 126)
      Me.grbParidad.TabIndex = 20
      Me.grbParidad.TabStop = False
      Me.grbParidad.Text = "Paridad"
      '
      'grbBitsDeParada
      '
      Me.grbBitsDeParada.Controls.Add(Me.rdbBDP3)
      Me.grbBitsDeParada.Controls.Add(Me.rdbBDP2)
      Me.grbBitsDeParada.Controls.Add(Me.rdbBDP1)
      Me.grbBitsDeParada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.grbBitsDeParada.Location = New System.Drawing.Point(319, 66)
      Me.grbBitsDeParada.Name = "grbBitsDeParada"
      Me.grbBitsDeParada.Size = New System.Drawing.Size(106, 126)
      Me.grbBitsDeParada.TabIndex = 21
      Me.grbBitsDeParada.TabStop = False
      Me.grbBitsDeParada.Text = "Bits de Parada"
      '
      'rdbBDP3
      '
      Me.rdbBDP3.Location = New System.Drawing.Point(6, 77)
      Me.rdbBDP3.Name = "rdbBDP3"
      Me.rdbBDP3.Size = New System.Drawing.Size(43, 17)
      Me.rdbBDP3.TabIndex = 12
      Me.rdbBDP3.Text = "2"
      Me.rdbBDP3.UseVisualStyleBackColor = True
      '
      'btnLectorAceptar
      '
      Me.btnLectorAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnLectorAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLectorAceptar.Location = New System.Drawing.Point(369, 258)
      Me.btnLectorAceptar.Name = "btnLectorAceptar"
      Me.btnLectorAceptar.Size = New System.Drawing.Size(75, 23)
      Me.btnLectorAceptar.TabIndex = 23
      Me.btnLectorAceptar.Text = "Aceptar"
      Me.btnLectorAceptar.UseVisualStyleBackColor = True
      '
      'btnLectorCancelar
      '
      Me.btnLectorCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnLectorCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnLectorCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLectorCancelar.Location = New System.Drawing.Point(450, 258)
      Me.btnLectorCancelar.Name = "btnLectorCancelar"
      Me.btnLectorCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnLectorCancelar.TabIndex = 24
      Me.btnLectorCancelar.Text = "Cancelar"
      Me.btnLectorCancelar.UseVisualStyleBackColor = True
      '
      'grbPuertoCom
      '
      Me.grbPuertoCom.Controls.Add(Me.rbtPuertoCom4)
      Me.grbPuertoCom.Controls.Add(Me.rbtPuertoCom3)
      Me.grbPuertoCom.Controls.Add(Me.rbtPuertoCom2)
      Me.grbPuertoCom.Controls.Add(Me.rbtPuertoCom1)
      Me.grbPuertoCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.grbPuertoCom.Location = New System.Drawing.Point(431, 66)
      Me.grbPuertoCom.Name = "grbPuertoCom"
      Me.grbPuertoCom.Size = New System.Drawing.Size(94, 126)
      Me.grbPuertoCom.TabIndex = 25
      Me.grbPuertoCom.TabStop = False
      Me.grbPuertoCom.Text = "Puerto Com"
      '
      'rbtPuertoCom4
      '
      Me.rbtPuertoCom4.AutoSize = True
      Me.rbtPuertoCom4.Location = New System.Drawing.Point(6, 100)
      Me.rbtPuertoCom4.Name = "rbtPuertoCom4"
      Me.rbtPuertoCom4.Size = New System.Drawing.Size(55, 17)
      Me.rbtPuertoCom4.TabIndex = 12
      Me.rbtPuertoCom4.Text = "COM4"
      Me.rbtPuertoCom4.UseVisualStyleBackColor = True
      '
      'rbtPuertoCom3
      '
      Me.rbtPuertoCom3.AutoSize = True
      Me.rbtPuertoCom3.Location = New System.Drawing.Point(6, 77)
      Me.rbtPuertoCom3.Name = "rbtPuertoCom3"
      Me.rbtPuertoCom3.Size = New System.Drawing.Size(55, 17)
      Me.rbtPuertoCom3.TabIndex = 11
      Me.rbtPuertoCom3.Text = "COM3"
      Me.rbtPuertoCom3.UseVisualStyleBackColor = True
      '
      'rbtPuertoCom2
      '
      Me.rbtPuertoCom2.AutoSize = True
      Me.rbtPuertoCom2.Location = New System.Drawing.Point(6, 54)
      Me.rbtPuertoCom2.Name = "rbtPuertoCom2"
      Me.rbtPuertoCom2.Size = New System.Drawing.Size(55, 17)
      Me.rbtPuertoCom2.TabIndex = 10
      Me.rbtPuertoCom2.Text = "COM2"
      Me.rbtPuertoCom2.UseVisualStyleBackColor = True
      '
      'rbtPuertoCom1
      '
      Me.rbtPuertoCom1.AutoSize = True
      Me.rbtPuertoCom1.Checked = True
      Me.rbtPuertoCom1.Location = New System.Drawing.Point(6, 31)
      Me.rbtPuertoCom1.Name = "rbtPuertoCom1"
      Me.rbtPuertoCom1.Size = New System.Drawing.Size(55, 17)
      Me.rbtPuertoCom1.TabIndex = 9
      Me.rbtPuertoCom1.TabStop = True
      Me.rbtPuertoCom1.Text = "COM1"
      Me.rbtPuertoCom1.UseVisualStyleBackColor = True
      '
      'lblmaxOdd
      '
      Me.lblmaxOdd.AutoSize = True
      Me.lblmaxOdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.lblmaxOdd.Location = New System.Drawing.Point(214, 212)
      Me.lblmaxOdd.Name = "lblmaxOdd"
      Me.lblmaxOdd.Size = New System.Drawing.Size(53, 13)
      Me.lblmaxOdd.TabIndex = 28
      Me.lblmaxOdd.Text = "Max Odd:"
      '
      'TextBox1
      '
      Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.TextBox1.Location = New System.Drawing.Point(274, 209)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(100, 20)
      Me.TextBox1.TabIndex = 29
      '
      'txtnomLector
      '
      Me.txtnomLector.Location = New System.Drawing.Point(109, 13)
      Me.txtnomLector.Name = "txtnomLector"
      Me.txtnomLector.Size = New System.Drawing.Size(277, 20)
      Me.txtnomLector.TabIndex = 31
      '
      'chkLectorDefault
      '
      Me.chkLectorDefault.AutoSize = True
      Me.chkLectorDefault.Checked = True
      Me.chkLectorDefault.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkLectorDefault.Location = New System.Drawing.Point(426, 16)
      Me.chkLectorDefault.Name = "chkLectorDefault"
      Me.chkLectorDefault.Size = New System.Drawing.Size(60, 17)
      Me.chkLectorDefault.TabIndex = 33
      Me.chkLectorDefault.Text = "Default"
      Me.chkLectorDefault.UseVisualStyleBackColor = True
      '
      'lblNombreLector
      '
      Me.lblNombreLector.AutoSize = True
      Me.lblNombreLector.Location = New System.Drawing.Point(6, 15)
      Me.lblNombreLector.Name = "lblNombreLector"
      Me.lblNombreLector.Size = New System.Drawing.Size(97, 13)
      Me.lblNombreLector.TabIndex = 32
      Me.lblNombreLector.Text = "Nombre del Lector:"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.lblNombreLector)
      Me.GroupBox1.Controls.Add(Me.txtnomLector)
      Me.GroupBox1.Controls.Add(Me.chkLectorDefault)
      Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(514, 40)
      Me.GroupBox1.TabIndex = 34
      Me.GroupBox1.TabStop = False
      '
      'frmConfLector
      '
      Me.AcceptButton = Me.btnLectorAceptar
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoScroll = True
      Me.CancelButton = Me.btnLectorCancelar
      Me.ClientSize = New System.Drawing.Size(536, 289)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.lblmaxOdd)
      Me.Controls.Add(Me.grbPuertoCom)
      Me.Controls.Add(Me.btnLectorCancelar)
      Me.Controls.Add(Me.btnLectorAceptar)
      Me.Controls.Add(Me.grbBitsDeParada)
      Me.Controls.Add(Me.grbParidad)
      Me.Controls.Add(Me.grbBitsDeDatos)
      Me.Controls.Add(Me.grbBaudiossPorSegundo)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmConfLector"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Configuración del Lector "
      Me.grbBaudiossPorSegundo.ResumeLayout(False)
      Me.grbBitsDeDatos.ResumeLayout(False)
      Me.grbParidad.ResumeLayout(False)
      Me.grbBitsDeParada.ResumeLayout(False)
      Me.grbPuertoCom.ResumeLayout(False)
      Me.grbPuertoCom.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents rdbBPS1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS2 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS3 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD3 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD2 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidad1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbParidad2 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDP1 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDP2 As System.Windows.Forms.RadioButton
   Friend WithEvents grbBaudiossPorSegundo As System.Windows.Forms.GroupBox
   Friend WithEvents rdbBPS8 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS7 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS6 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS5 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBPS4 As System.Windows.Forms.RadioButton
   Friend WithEvents grbBitsDeDatos As System.Windows.Forms.GroupBox
   Friend WithEvents rdbBDD8 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD7 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD6 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD5 As System.Windows.Forms.RadioButton
   Friend WithEvents rdbBDD4 As System.Windows.Forms.RadioButton
   Friend WithEvents grbParidad As System.Windows.Forms.GroupBox
   Friend WithEvents grbBitsDeParada As System.Windows.Forms.GroupBox
   Friend WithEvents rdbBDP3 As System.Windows.Forms.RadioButton
   Friend WithEvents btnLectorAceptar As System.Windows.Forms.Button
   Friend WithEvents btnLectorCancelar As System.Windows.Forms.Button
   Friend WithEvents grbPuertoCom As System.Windows.Forms.GroupBox
   Friend WithEvents lblmaxOdd As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents rbtPuertoCom4 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtPuertoCom3 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtPuertoCom2 As System.Windows.Forms.RadioButton
   Friend WithEvents rbtPuertoCom1 As System.Windows.Forms.RadioButton
   Friend WithEvents txtnomLector As System.Windows.Forms.TextBox
   Friend WithEvents chkLectorDefault As System.Windows.Forms.CheckBox
   Friend WithEvents lblNombreLector As System.Windows.Forms.Label
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

   Private Sub btnLectorCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnLectorCancelar.Click
      Me.Close()
   End Sub
End Class
