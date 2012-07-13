<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioPrograma
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioPrograma))
      Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.barraDeProgreso = New System.Windows.Forms.ProgressBar()
      Me.SuspendLayout()
      '
      'Timer1
      '
      Me.Timer1.Enabled = True
      '
      'Panel1
      '
      Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Location = New System.Drawing.Point(12, 10)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(469, 143)
      Me.Panel1.TabIndex = 11
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.Label2.Location = New System.Drawing.Point(408, 205)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(39, 13)
      Me.Label2.TabIndex = 10
      Me.Label2.Text = "Label2"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Label1.Location = New System.Drawing.Point(13, 160)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(39, 13)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "Label1"
      '
      'barraDeProgreso
      '
      Me.barraDeProgreso.Location = New System.Drawing.Point(12, 177)
      Me.barraDeProgreso.Name = "barraDeProgreso"
      Me.barraDeProgreso.Size = New System.Drawing.Size(469, 23)
      Me.barraDeProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee
      Me.barraDeProgreso.TabIndex = 8
      '
      'frmInicioPrograma
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Lavender
      Me.ClientSize = New System.Drawing.Size(493, 224)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.barraDeProgreso)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
      Me.Name = "frmInicioPrograma"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "frmInicioPrograma"
      Me.TopMost = True
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Timer1 As System.Windows.Forms.Timer
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents barraDeProgreso As System.Windows.Forms.ProgressBar
End Class
