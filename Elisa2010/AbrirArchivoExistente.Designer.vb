<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirArchivoExistente
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
      Me.ofdSelArchivo = New System.Windows.Forms.OpenFileDialog()
      Me.btnLeerArchivoExistente = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'ofdSelArchivo
      '
      Me.ofdSelArchivo.Filter = "Archivos Excel(*.xls)|*.xlsx|*.XLS|*.XLSX"
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(520, 12)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(75, 23)
      Me.btnLeerArchivoExistente.TabIndex = 0
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
      '
      'frmAbrirArchivoExistente
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(944, 332)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.Name = "frmAbrirArchivoExistente"
      Me.Text = "AbrirArchivoExistente"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents ofdSelArchivo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
End Class
