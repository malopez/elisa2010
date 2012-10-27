<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntegrarResultados
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntegrarResultados))
      Me.btnIntegrarArchivos = New System.Windows.Forms.Button()
      Me.txtInformeFinal = New System.Windows.Forms.TextBox()
      Me.chbAnalisis = New System.Windows.Forms.CheckedListBox()
      Me.mnuPreverAnalisis = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.tsmPreverArchivo = New System.Windows.Forms.ToolStripMenuItem()
      Me.grbNoCaso = New System.Windows.Forms.GroupBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cmbCasos = New System.Windows.Forms.ComboBox()
      Me.grpAnalisis = New System.Windows.Forms.GroupBox()
      Me.chkMarcarTodo = New System.Windows.Forms.CheckBox()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.grpArchivoFinal = New System.Windows.Forms.GroupBox()
      Me.btnPreverInfome = New System.Windows.Forms.Button()
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.btnCopiarInforme = New System.Windows.Forms.Button()
      Me.grbCopiarParaImprimir = New System.Windows.Forms.GroupBox()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.mnuPreverAnalisis.SuspendLayout()
      Me.grbNoCaso.SuspendLayout()
      Me.grpAnalisis.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpArchivoFinal.SuspendLayout()
      Me.grbCopiarParaImprimir.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnIntegrarArchivos
      '
      Me.btnIntegrarArchivos.Enabled = False
      Me.btnIntegrarArchivos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnIntegrarArchivos.Location = New System.Drawing.Point(301, 203)
      Me.btnIntegrarArchivos.Name = "btnIntegrarArchivos"
      Me.btnIntegrarArchivos.Size = New System.Drawing.Size(117, 23)
      Me.btnIntegrarArchivos.TabIndex = 1
      Me.btnIntegrarArchivos.Text = "Integrar archivos"
      Me.ToolTip1.SetToolTip(Me.btnIntegrarArchivos, "Integrar Archivos seleccionados en uno solo.")
      Me.btnIntegrarArchivos.UseVisualStyleBackColor = True
      '
      'txtInformeFinal
      '
      Me.txtInformeFinal.BackColor = System.Drawing.Color.White
      Me.txtInformeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInformeFinal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
      Me.txtInformeFinal.Location = New System.Drawing.Point(15, 32)
      Me.txtInformeFinal.Name = "txtInformeFinal"
      Me.txtInformeFinal.ReadOnly = True
      Me.txtInformeFinal.Size = New System.Drawing.Size(343, 20)
      Me.txtInformeFinal.TabIndex = 5
      '
      'chbAnalisis
      '
      Me.chbAnalisis.ContextMenuStrip = Me.mnuPreverAnalisis
      Me.chbAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.chbAnalisis.FormattingEnabled = True
      Me.chbAnalisis.Location = New System.Drawing.Point(177, 19)
      Me.chbAnalisis.Name = "chbAnalisis"
      Me.chbAnalisis.ScrollAlwaysVisible = True
      Me.chbAnalisis.Size = New System.Drawing.Size(216, 79)
      Me.chbAnalisis.Sorted = True
      Me.chbAnalisis.TabIndex = 6
      '
      'mnuPreverAnalisis
      '
      Me.mnuPreverAnalisis.Enabled = False
      Me.mnuPreverAnalisis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPreverArchivo})
      Me.mnuPreverAnalisis.Name = "mnuPreverAnalisis"
      Me.mnuPreverAnalisis.Size = New System.Drawing.Size(152, 26)
      '
      'tsmPreverArchivo
      '
      Me.tsmPreverArchivo.Enabled = False
      Me.tsmPreverArchivo.Name = "tsmPreverArchivo"
      Me.tsmPreverArchivo.Size = New System.Drawing.Size(151, 22)
      Me.tsmPreverArchivo.Text = "Prever Archivo"
      '
      'grbNoCaso
      '
      Me.grbNoCaso.Controls.Add(Me.Label1)
      Me.grbNoCaso.Controls.Add(Me.cmbCasos)
      Me.grbNoCaso.Location = New System.Drawing.Point(4, 5)
      Me.grbNoCaso.Name = "grbNoCaso"
      Me.grbNoCaso.Size = New System.Drawing.Size(414, 69)
      Me.grbNoCaso.TabIndex = 8
      Me.grbNoCaso.TabStop = False
      Me.grbNoCaso.Text = "Seleccione el No. de Caso"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Label1.Location = New System.Drawing.Point(12, 32)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(89, 13)
      Me.Label1.TabIndex = 11
      Me.Label1.Text = "Número de Caso:"
      '
      'cmbCasos
      '
      Me.cmbCasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.cmbCasos.FormattingEnabled = True
      Me.cmbCasos.Location = New System.Drawing.Point(177, 29)
      Me.cmbCasos.Name = "cmbCasos"
      Me.cmbCasos.Size = New System.Drawing.Size(216, 21)
      Me.cmbCasos.TabIndex = 10
      '
      'grpAnalisis
      '
      Me.grpAnalisis.Controls.Add(Me.chkMarcarTodo)
      Me.grpAnalisis.Controls.Add(Me.PictureBox1)
      Me.grpAnalisis.Controls.Add(Me.chbAnalisis)
      Me.grpAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpAnalisis.Location = New System.Drawing.Point(4, 87)
      Me.grpAnalisis.Name = "grpAnalisis"
      Me.grpAnalisis.Size = New System.Drawing.Size(414, 110)
      Me.grpAnalisis.TabIndex = 9
      Me.grpAnalisis.TabStop = False
      Me.grpAnalisis.Text = "Información de los Análisis que contiene el caso"
      '
      'chkMarcarTodo
      '
      Me.chkMarcarTodo.AutoSize = True
      Me.chkMarcarTodo.Enabled = False
      Me.chkMarcarTodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.chkMarcarTodo.Location = New System.Drawing.Point(15, 81)
      Me.chkMarcarTodo.Name = "chkMarcarTodo"
      Me.chkMarcarTodo.Size = New System.Drawing.Size(92, 17)
      Me.chkMarcarTodo.TabIndex = 11
      Me.chkMarcarTodo.Text = "Marcar Todos"
      Me.ToolTip1.SetToolTip(Me.chkMarcarTodo, "Marcar todos los archivos de análisis existentes.")
      Me.chkMarcarTodo.UseVisualStyleBackColor = True
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 7
      Me.PictureBox1.TabStop = False
      '
      'grpArchivoFinal
      '
      Me.grpArchivoFinal.Controls.Add(Me.btnPreverInfome)
      Me.grpArchivoFinal.Controls.Add(Me.txtInformeFinal)
      Me.grpArchivoFinal.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpArchivoFinal.Location = New System.Drawing.Point(4, 235)
      Me.grpArchivoFinal.Name = "grpArchivoFinal"
      Me.grpArchivoFinal.Size = New System.Drawing.Size(414, 77)
      Me.grpArchivoFinal.TabIndex = 10
      Me.grpArchivoFinal.TabStop = False
      Me.grpArchivoFinal.Text = "Informe Final de Resultados"
      '
      'btnPreverInfome
      '
      Me.btnPreverInfome.Enabled = False
      Me.btnPreverInfome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnPreverInfome.Image = CType(resources.GetObject("btnPreverInfome.Image"), System.Drawing.Image)
      Me.btnPreverInfome.Location = New System.Drawing.Point(364, 26)
      Me.btnPreverInfome.Name = "btnPreverInfome"
      Me.btnPreverInfome.Size = New System.Drawing.Size(44, 30)
      Me.btnPreverInfome.TabIndex = 12
      Me.ToolTip1.SetToolTip(Me.btnPreverInfome, "Visualizar el archivo de resultados.")
      Me.btnPreverInfome.UseVisualStyleBackColor = True
      '
      'btnCopiarInforme
      '
      Me.btnCopiarInforme.Enabled = False
      Me.btnCopiarInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCopiarInforme.Location = New System.Drawing.Point(290, 30)
      Me.btnCopiarInforme.Name = "btnCopiarInforme"
      Me.btnCopiarInforme.Size = New System.Drawing.Size(117, 23)
      Me.btnCopiarInforme.TabIndex = 11
      Me.btnCopiarInforme.Text = "Copiar Informe"
      Me.ToolTip1.SetToolTip(Me.btnCopiarInforme, "Copiar Informe Final a la carpeta de ""Para Imprimir""")
      Me.btnCopiarInforme.UseVisualStyleBackColor = True
      '
      'grbCopiarParaImprimir
      '
      Me.grbCopiarParaImprimir.Controls.Add(Me.btnCopiarInforme)
      Me.grbCopiarParaImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.grbCopiarParaImprimir.Location = New System.Drawing.Point(4, 326)
      Me.grbCopiarParaImprimir.Name = "grbCopiarParaImprimir"
      Me.grbCopiarParaImprimir.Size = New System.Drawing.Size(414, 59)
      Me.grbCopiarParaImprimir.TabIndex = 12
      Me.grbCopiarParaImprimir.TabStop = False
      Me.grbCopiarParaImprimir.Text = "Copiar Infome Final en capeta ""Para Imprimir"""
      '
      'btnCancelar
      '
      Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(294, 391)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(117, 23)
      Me.btnCancelar.TabIndex = 13
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'frmIntegrarResultados
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(423, 415)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.grbCopiarParaImprimir)
      Me.Controls.Add(Me.btnIntegrarArchivos)
      Me.Controls.Add(Me.grpArchivoFinal)
      Me.Controls.Add(Me.grpAnalisis)
      Me.Controls.Add(Me.grbNoCaso)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmIntegrarResultados"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Integrar resultados en Informe Final"
      Me.mnuPreverAnalisis.ResumeLayout(False)
      Me.grbNoCaso.ResumeLayout(False)
      Me.grbNoCaso.PerformLayout()
      Me.grpAnalisis.ResumeLayout(False)
      Me.grpAnalisis.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpArchivoFinal.ResumeLayout(False)
      Me.grpArchivoFinal.PerformLayout()
      Me.grbCopiarParaImprimir.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnIntegrarArchivos As System.Windows.Forms.Button
   Friend WithEvents txtInformeFinal As System.Windows.Forms.TextBox
   Friend WithEvents chbAnalisis As System.Windows.Forms.CheckedListBox
   Friend WithEvents grbNoCaso As System.Windows.Forms.GroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmbCasos As System.Windows.Forms.ComboBox
   Friend WithEvents grpAnalisis As System.Windows.Forms.GroupBox
   Friend WithEvents grpArchivoFinal As System.Windows.Forms.GroupBox
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents chkMarcarTodo As System.Windows.Forms.CheckBox
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents btnCopiarInforme As System.Windows.Forms.Button
   Friend WithEvents mnuPreverAnalisis As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents tsmPreverArchivo As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents grbCopiarParaImprimir As System.Windows.Forms.GroupBox
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents btnPreverInfome As System.Windows.Forms.Button

End Class


