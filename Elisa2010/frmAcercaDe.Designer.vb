<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercaDe))
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.lblAcercaDe = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(181, 84)
      Me.PictureBox1.TabIndex = 1
      Me.PictureBox1.TabStop = False
      '
      'lblAcercaDe
      '
      Me.lblAcercaDe.AutoSize = True
      Me.lblAcercaDe.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAcercaDe.ForeColor = System.Drawing.Color.SteelBlue
      Me.lblAcercaDe.Location = New System.Drawing.Point(140, 26)
      Me.lblAcercaDe.Name = "lblAcercaDe"
      Me.lblAcercaDe.Size = New System.Drawing.Size(395, 23)
      Me.lblAcercaDe.TabIndex = 2
      Me.lblAcercaDe.Text = "Biotecnología Veterinaria de Puebla S.A. de C.V."
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
      Me.Label1.Location = New System.Drawing.Point(12, 105)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(515, 47)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "Software  propiedad de Biotecnología Veterinaria de Puebla S. A. de C. V. No pued" & _
    "e ser distribuido externamente sin la autorización escrita de la empresa a travé" & _
    "s del Director General"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label2.Location = New System.Drawing.Point(213, 58)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(322, 16)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Laboratorio de Diagnóstico y Patobiología Aviar"
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Label3.Location = New System.Drawing.Point(161, 152)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(220, 23)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "Todos los Derechos Reservados. 2012."
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      '
      'frmAcercaDe
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
      Me.ClientSize = New System.Drawing.Size(539, 184)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.lblAcercaDe)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Label3)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmAcercaDe"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Acerca De"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents lblAcercaDe As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
