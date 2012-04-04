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
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.cbbNombreCliente = New System.Windows.Forms.ComboBox()
      Me.lblFechaRecepcion = New System.Windows.Forms.Label()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.cbbNombreAnalisis = New System.Windows.Forms.ComboBox()
      Me.btnLeerDatosPlaca = New System.Windows.Forms.Button()
      Me.btnCambiarLector = New System.Windows.Forms.Button()
      Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
      Me.btnNuevoAnalisisCancelar = New System.Windows.Forms.Button()
      Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
      Me.cmbComboPorts = New System.Windows.Forms.ComboBox()
      Me.txtDatosRecibidos = New System.Windows.Forms.TextBox()
      Me.btnGuardarDatos = New System.Windows.Forms.Button()
      Me.sfdGuardarPlaca = New System.Windows.Forms.SaveFileDialog()
      Me.SuspendLayout()
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(123, 57)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(149, 20)
      Me.TextBox1.TabIndex = 0
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.Location = New System.Drawing.Point(19, 57)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(88, 13)
      Me.lblNoCaso.TabIndex = 1
      Me.lblNoCaso.Text = "Número de caso:"
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.Location = New System.Drawing.Point(19, 109)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(99, 13)
      Me.lblNombreCliente.TabIndex = 2
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'cbbNombreCliente
      '
      Me.cbbNombreCliente.FormattingEnabled = True
      Me.cbbNombreCliente.Location = New System.Drawing.Point(124, 106)
      Me.cbbNombreCliente.Name = "cbbNombreCliente"
      Me.cbbNombreCliente.Size = New System.Drawing.Size(466, 21)
      Me.cbbNombreCliente.TabIndex = 3
      '
      'lblFechaRecepcion
      '
      Me.lblFechaRecepcion.AutoSize = True
      Me.lblFechaRecepcion.Location = New System.Drawing.Point(278, 60)
      Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
      Me.lblFechaRecepcion.Size = New System.Drawing.Size(105, 13)
      Me.lblFechaRecepcion.TabIndex = 4
      Me.lblFechaRecepcion.Text = "Fecha de recepción:"
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(19, 160)
      Me.lblNombreAnalisis.Name = "lblNombreAnalisis"
      Me.lblNombreAnalisis.Size = New System.Drawing.Size(101, 13)
      Me.lblNombreAnalisis.TabIndex = 6
      Me.lblNombreAnalisis.Text = "Nombre del análisis:"
      '
      'cbbNombreAnalisis
      '
      Me.cbbNombreAnalisis.FormattingEnabled = True
      Me.cbbNombreAnalisis.Location = New System.Drawing.Point(123, 157)
      Me.cbbNombreAnalisis.Name = "cbbNombreAnalisis"
      Me.cbbNombreAnalisis.Size = New System.Drawing.Size(467, 21)
      Me.cbbNombreAnalisis.TabIndex = 7
      '
      'btnLeerDatosPlaca
      '
      Me.btnLeerDatosPlaca.Location = New System.Drawing.Point(324, 184)
      Me.btnLeerDatosPlaca.Name = "btnLeerDatosPlaca"
      Me.btnLeerDatosPlaca.Size = New System.Drawing.Size(75, 23)
      Me.btnLeerDatosPlaca.TabIndex = 9
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
      'DateTimePicker1
      '
      Me.DateTimePicker1.Location = New System.Drawing.Point(390, 57)
      Me.DateTimePicker1.Name = "DateTimePicker1"
      Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
      Me.DateTimePicker1.TabIndex = 11
      '
      'btnNuevoAnalisisCancelar
      '
      Me.btnNuevoAnalisisCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnNuevoAnalisisCancelar.Location = New System.Drawing.Point(513, 184)
      Me.btnNuevoAnalisisCancelar.Name = "btnNuevoAnalisisCancelar"
      Me.btnNuevoAnalisisCancelar.Size = New System.Drawing.Size(75, 23)
      Me.btnNuevoAnalisisCancelar.TabIndex = 12
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
      Me.cmbComboPorts.TabIndex = 13
      '
      'txtDatosRecibidos
      '
      Me.txtDatosRecibidos.Location = New System.Drawing.Point(22, 213)
      Me.txtDatosRecibidos.Multiline = True
      Me.txtDatosRecibidos.Name = "txtDatosRecibidos"
      Me.txtDatosRecibidos.Size = New System.Drawing.Size(568, 139)
      Me.txtDatosRecibidos.TabIndex = 14
      Me.txtDatosRecibidos.Text = resources.GetString("txtDatosRecibidos.Text")
      '
      'btnGuardarDatos
      '
      Me.btnGuardarDatos.Location = New System.Drawing.Point(503, 358)
      Me.btnGuardarDatos.Name = "btnGuardarDatos"
      Me.btnGuardarDatos.Size = New System.Drawing.Size(87, 23)
      Me.btnGuardarDatos.TabIndex = 15
      Me.btnGuardarDatos.Text = "Guardar Datos"
      Me.btnGuardarDatos.UseVisualStyleBackColor = True
      '
      'frmRegistraNuevoAnalisis
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(864, 412)
      Me.Controls.Add(Me.btnGuardarDatos)
      Me.Controls.Add(Me.txtDatosRecibidos)
      Me.Controls.Add(Me.cmbComboPorts)
      Me.Controls.Add(Me.btnNuevoAnalisisCancelar)
      Me.Controls.Add(Me.DateTimePicker1)
      Me.Controls.Add(Me.btnCambiarLector)
      Me.Controls.Add(Me.btnLeerDatosPlaca)
      Me.Controls.Add(Me.cbbNombreAnalisis)
      Me.Controls.Add(Me.lblNombreAnalisis)
      Me.Controls.Add(Me.lblFechaRecepcion)
      Me.Controls.Add(Me.cbbNombreCliente)
      Me.Controls.Add(Me.lblNombreCliente)
      Me.Controls.Add(Me.lblNoCaso)
      Me.Controls.Add(Me.TextBox1)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmRegistraNuevoAnalisis"
      Me.Text = "Registra Nuevo Análisis"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents cbbNombreCliente As System.Windows.Forms.ComboBox
   Friend WithEvents lblFechaRecepcion As System.Windows.Forms.Label
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents cbbNombreAnalisis As System.Windows.Forms.ComboBox
   Friend WithEvents btnLeerDatosPlaca As System.Windows.Forms.Button
   Friend WithEvents btnCambiarLector As System.Windows.Forms.Button
   Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
   Friend WithEvents btnNuevoAnalisisCancelar As System.Windows.Forms.Button
   Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
   Friend WithEvents cmbComboPorts As System.Windows.Forms.ComboBox
   Friend WithEvents txtDatosRecibidos As System.Windows.Forms.TextBox
   Friend WithEvents btnGuardarDatos As System.Windows.Forms.Button
   Friend WithEvents sfdGuardarPlaca As System.Windows.Forms.SaveFileDialog
End Class
