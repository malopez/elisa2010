<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesAnalisis
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperacionesAnalisis))
      Me.btnBuscaAnalisis = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtNombreAnalisis = New System.Windows.Forms.TextBox()
      Me.txtClaveAnalisis = New System.Windows.Forms.TextBox()
      Me.lblMensajeAnalisis = New System.Windows.Forms.Label()
      Me.btnCancelarAnalisis = New System.Windows.Forms.Button()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.btnInsAnalisis = New System.Windows.Forms.Button()
      Me.btnUpdAnalisis = New System.Windows.Forms.Button()
      Me.btnGuardaAnalisis = New System.Windows.Forms.Button()
      Me.btnInicio = New System.Windows.Forms.Button()
      Me.btnHaciaAtras = New System.Windows.Forms.Button()
      Me.lblNRAnalisis = New System.Windows.Forms.Label()
      Me.btnHaciaAdelante = New System.Windows.Forms.Button()
      Me.btnFin = New System.Windows.Forms.Button()
      Me.btnEditarAnalisis = New System.Windows.Forms.Button()
      Me.btnDelAnalisis = New System.Windows.Forms.Button()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.Panel2.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.Panel3.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnBuscaAnalisis
      '
      Me.btnBuscaAnalisis.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscaAnalisis.ForeColor = System.Drawing.Color.SteelBlue
      Me.btnBuscaAnalisis.Image = CType(resources.GetObject("btnBuscaAnalisis.Image"), System.Drawing.Image)
      Me.btnBuscaAnalisis.Location = New System.Drawing.Point(304, 25)
      Me.btnBuscaAnalisis.Name = "btnBuscaAnalisis"
      Me.btnBuscaAnalisis.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaAnalisis.TabIndex = 1
      Me.btnBuscaAnalisis.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label2.Location = New System.Drawing.Point(15, 70)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(126, 16)
      Me.Label2.TabIndex = 68
      Me.Label2.Text = "Nombre del análisis:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label1.Location = New System.Drawing.Point(15, 27)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(113, 16)
      Me.Label1.TabIndex = 67
      Me.Label1.Text = "Clave del análisis:"
      '
      'txtNombreAnalisis
      '
      Me.txtNombreAnalisis.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNombreAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNombreAnalisis.Location = New System.Drawing.Point(147, 68)
      Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
      Me.txtNombreAnalisis.ReadOnly = True
      Me.txtNombreAnalisis.Size = New System.Drawing.Size(456, 21)
      Me.txtNombreAnalisis.TabIndex = 2
      '
      'txtClaveAnalisis
      '
      Me.txtClaveAnalisis.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtClaveAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtClaveAnalisis.Location = New System.Drawing.Point(147, 25)
      Me.txtClaveAnalisis.Name = "txtClaveAnalisis"
      Me.txtClaveAnalisis.ReadOnly = True
      Me.txtClaveAnalisis.Size = New System.Drawing.Size(125, 21)
      Me.txtClaveAnalisis.TabIndex = 0
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
      'btnCancelarAnalisis
      '
      Me.btnCancelarAnalisis.BackColor = System.Drawing.SystemColors.Control
      Me.btnCancelarAnalisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.btnCancelarAnalisis.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelarAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btnCancelarAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelarAnalisis.Location = New System.Drawing.Point(537, 173)
      Me.btnCancelarAnalisis.Name = "btnCancelarAnalisis"
      Me.btnCancelarAnalisis.Size = New System.Drawing.Size(91, 23)
      Me.btnCancelarAnalisis.TabIndex = 12
      Me.btnCancelarAnalisis.Text = "Cancelar"
      Me.btnCancelarAnalisis.UseVisualStyleBackColor = False
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.Window
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.lblMensajeAnalisis)
      Me.Panel2.Location = New System.Drawing.Point(7, 202)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(621, 33)
      Me.Panel2.TabIndex = 73
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.Label2)
      Me.Panel1.Controls.Add(Me.btnBuscaAnalisis)
      Me.Panel1.Controls.Add(Me.txtNombreAnalisis)
      Me.Panel1.Controls.Add(Me.Label1)
      Me.Panel1.Controls.Add(Me.txtClaveAnalisis)
      Me.Panel1.Location = New System.Drawing.Point(7, 8)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(621, 113)
      Me.Panel1.TabIndex = 72
      '
      'btnInsAnalisis
      '
      Me.btnInsAnalisis.Image = CType(resources.GetObject("btnInsAnalisis.Image"), System.Drawing.Image)
      Me.btnInsAnalisis.Location = New System.Drawing.Point(342, 7)
      Me.btnInsAnalisis.Name = "btnInsAnalisis"
      Me.btnInsAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnInsAnalisis.TabIndex = 78
      Me.btnInsAnalisis.Tag = ""
      Me.btnInsAnalisis.UseVisualStyleBackColor = True
      '
      'btnUpdAnalisis
      '
      Me.btnUpdAnalisis.Enabled = False
      Me.btnUpdAnalisis.Image = CType(resources.GetObject("btnUpdAnalisis.Image"), System.Drawing.Image)
      Me.btnUpdAnalisis.Location = New System.Drawing.Point(429, 7)
      Me.btnUpdAnalisis.Name = "btnUpdAnalisis"
      Me.btnUpdAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnUpdAnalisis.TabIndex = 80
      Me.btnUpdAnalisis.UseVisualStyleBackColor = True
      '
      'btnGuardaAnalisis
      '
      Me.btnGuardaAnalisis.Enabled = False
      Me.btnGuardaAnalisis.Image = CType(resources.GetObject("btnGuardaAnalisis.Image"), System.Drawing.Image)
      Me.btnGuardaAnalisis.Location = New System.Drawing.Point(472, 7)
      Me.btnGuardaAnalisis.Name = "btnGuardaAnalisis"
      Me.btnGuardaAnalisis.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardaAnalisis.TabIndex = 81
      Me.btnGuardaAnalisis.UseVisualStyleBackColor = True
      '
      'btnInicio
      '
      Me.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnInicio.Location = New System.Drawing.Point(66, 7)
      Me.btnInicio.Name = "btnInicio"
      Me.btnInicio.Size = New System.Drawing.Size(37, 23)
      Me.btnInicio.TabIndex = 74
      Me.btnInicio.Text = "<<"
      Me.btnInicio.UseVisualStyleBackColor = True
      '
      'btnHaciaAtras
      '
      Me.btnHaciaAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAtras.Location = New System.Drawing.Point(109, 7)
      Me.btnHaciaAtras.Name = "btnHaciaAtras"
      Me.btnHaciaAtras.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAtras.TabIndex = 75
      Me.btnHaciaAtras.Text = "<"
      Me.btnHaciaAtras.UseVisualStyleBackColor = True
      '
      'lblNRAnalisis
      '
      Me.lblNRAnalisis.AutoSize = True
      Me.lblNRAnalisis.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNRAnalisis.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.lblNRAnalisis.Location = New System.Drawing.Point(151, 11)
      Me.lblNRAnalisis.Name = "lblNRAnalisis"
      Me.lblNRAnalisis.Size = New System.Drawing.Size(99, 15)
      Me.lblNRAnalisis.TabIndex = 83
      Me.lblNRAnalisis.Text = "Registro: 296 de 296"
      '
      'btnHaciaAdelante
      '
      Me.btnHaciaAdelante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAdelante.Location = New System.Drawing.Point(256, 7)
      Me.btnHaciaAdelante.Name = "btnHaciaAdelante"
      Me.btnHaciaAdelante.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAdelante.TabIndex = 76
      Me.btnHaciaAdelante.Text = ">"
      Me.btnHaciaAdelante.UseVisualStyleBackColor = True
      '
      'btnFin
      '
      Me.btnFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnFin.Location = New System.Drawing.Point(299, 7)
      Me.btnFin.Name = "btnFin"
      Me.btnFin.Size = New System.Drawing.Size(37, 23)
      Me.btnFin.TabIndex = 77
      Me.btnFin.Text = ">>"
      Me.btnFin.UseVisualStyleBackColor = True
      '
      'btnEditarAnalisis
      '
      Me.btnEditarAnalisis.Image = CType(resources.GetObject("btnEditarAnalisis.Image"), System.Drawing.Image)
      Me.btnEditarAnalisis.Location = New System.Drawing.Point(385, 7)
      Me.btnEditarAnalisis.Name = "btnEditarAnalisis"
      Me.btnEditarAnalisis.Size = New System.Drawing.Size(38, 23)
      Me.btnEditarAnalisis.TabIndex = 79
      Me.btnEditarAnalisis.UseVisualStyleBackColor = True
      '
      'btnDelAnalisis
      '
      Me.btnDelAnalisis.Image = CType(resources.GetObject("btnDelAnalisis.Image"), System.Drawing.Image)
      Me.btnDelAnalisis.Location = New System.Drawing.Point(516, 7)
      Me.btnDelAnalisis.Name = "btnDelAnalisis"
      Me.btnDelAnalisis.Size = New System.Drawing.Size(38, 23)
      Me.btnDelAnalisis.TabIndex = 82
      Me.btnDelAnalisis.UseVisualStyleBackColor = True
      '
      'Panel3
      '
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel3.Controls.Add(Me.btnInsAnalisis)
      Me.Panel3.Controls.Add(Me.btnHaciaAdelante)
      Me.Panel3.Controls.Add(Me.btnUpdAnalisis)
      Me.Panel3.Controls.Add(Me.btnDelAnalisis)
      Me.Panel3.Controls.Add(Me.btnGuardaAnalisis)
      Me.Panel3.Controls.Add(Me.btnEditarAnalisis)
      Me.Panel3.Controls.Add(Me.btnInicio)
      Me.Panel3.Controls.Add(Me.btnFin)
      Me.Panel3.Controls.Add(Me.btnHaciaAtras)
      Me.Panel3.Controls.Add(Me.lblNRAnalisis)
      Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel3.Location = New System.Drawing.Point(7, 129)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(621, 38)
      Me.Panel3.TabIndex = 72
      '
      'frmOperacionesAnalisis
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(635, 244)
      Me.Controls.Add(Me.btnCancelarAnalisis)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.Panel3)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmOperacionesAnalisis"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Operaciones sobre análisis"
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnBuscaAnalisis As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNombreAnalisis As System.Windows.Forms.TextBox
   Friend WithEvents txtClaveAnalisis As System.Windows.Forms.TextBox
   Friend WithEvents lblMensajeAnalisis As System.Windows.Forms.Label
   Friend WithEvents btnCancelarAnalisis As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents btnInsAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnUpdAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnGuardaAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnInicio As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAtras As System.Windows.Forms.Button
   Friend WithEvents lblNRAnalisis As System.Windows.Forms.Label
   Friend WithEvents btnHaciaAdelante As System.Windows.Forms.Button
   Friend WithEvents btnFin As System.Windows.Forms.Button
   Friend WithEvents btnEditarAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnDelAnalisis As System.Windows.Forms.Button
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
