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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbrirArchivoExistente))
      Me.ofdSelArchivo = New System.Windows.Forms.OpenFileDialog()
      Me.btnLeerArchivoExistente = New System.Windows.Forms.Button()
      Me.txtPlacaDesdeArchivo = New System.Windows.Forms.TextBox()
      Me.lblNombrePlacaDesdeArchivo = New System.Windows.Forms.Label()
      Me.grbCPDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.txtCPDAValor1 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor3 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.grbCNDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtCNDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor1 = New System.Windows.Forms.TextBox()
      Me.btnObtenResultadosDA = New System.Windows.Forms.Button()
      Me.grbCPDesdeArchivo.SuspendLayout()
      Me.grbCNDesdeArchivo.SuspendLayout()
      Me.SuspendLayout()
      '
      'ofdSelArchivo
      '
      Me.ofdSelArchivo.Filter = "Archivos Excel(*.xls)|*.xlsx|*.XLS|*.XLSX"
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(491, 213)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerArchivoExistente.TabIndex = 0
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
      '
      'txtPlacaDesdeArchivo
      '
      Me.txtPlacaDesdeArchivo.Location = New System.Drawing.Point(12, 66)
      Me.txtPlacaDesdeArchivo.Multiline = True
      Me.txtPlacaDesdeArchivo.Name = "txtPlacaDesdeArchivo"
      Me.txtPlacaDesdeArchivo.ReadOnly = True
      Me.txtPlacaDesdeArchivo.Size = New System.Drawing.Size(592, 129)
      Me.txtPlacaDesdeArchivo.TabIndex = 1
      '
      'lblNombrePlacaDesdeArchivo
      '
      Me.lblNombrePlacaDesdeArchivo.AutoSize = True
      Me.lblNombrePlacaDesdeArchivo.Location = New System.Drawing.Point(12, 27)
      Me.lblNombrePlacaDesdeArchivo.Name = "lblNombrePlacaDesdeArchivo"
      Me.lblNombrePlacaDesdeArchivo.Size = New System.Drawing.Size(0, 13)
      Me.lblNombrePlacaDesdeArchivo.TabIndex = 2
      '
      'grbCPDesdeArchivo
      '
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label3)
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label2)
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label1)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor3)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor2)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor1)
      Me.grbCPDesdeArchivo.Enabled = False
      Me.grbCPDesdeArchivo.Location = New System.Drawing.Point(15, 213)
      Me.grbCPDesdeArchivo.Name = "grbCPDesdeArchivo"
      Me.grbCPDesdeArchivo.Size = New System.Drawing.Size(162, 99)
      Me.grbCPDesdeArchivo.TabIndex = 3
      Me.grbCPDesdeArchivo.TabStop = False
      Me.grbCPDesdeArchivo.Text = "Controles Positivos"
      '
      'txtCPDAValor1
      '
      Me.txtCPDAValor1.Location = New System.Drawing.Point(51, 18)
      Me.txtCPDAValor1.Name = "txtCPDAValor1"
      Me.txtCPDAValor1.Size = New System.Drawing.Size(85, 20)
      Me.txtCPDAValor1.TabIndex = 0
      '
      'txtCPDAValor2
      '
      Me.txtCPDAValor2.Location = New System.Drawing.Point(51, 44)
      Me.txtCPDAValor2.Name = "txtCPDAValor2"
      Me.txtCPDAValor2.Size = New System.Drawing.Size(85, 20)
      Me.txtCPDAValor2.TabIndex = 1
      '
      'txtCPDAValor3
      '
      Me.txtCPDAValor3.Location = New System.Drawing.Point(51, 70)
      Me.txtCPDAValor3.Name = "txtCPDAValor3"
      Me.txtCPDAValor3.Size = New System.Drawing.Size(85, 20)
      Me.txtCPDAValor3.TabIndex = 2
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(7, 21)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(30, 13)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "CP1:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(7, 47)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(30, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "CP2:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(7, 73)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(30, 13)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "CP3:"
      '
      'grbCNDesdeArchivo
      '
      Me.grbCNDesdeArchivo.Controls.Add(Me.Label4)
      Me.grbCNDesdeArchivo.Controls.Add(Me.Label5)
      Me.grbCNDesdeArchivo.Controls.Add(Me.Label6)
      Me.grbCNDesdeArchivo.Controls.Add(Me.txtCNDAValor3)
      Me.grbCNDesdeArchivo.Controls.Add(Me.txtCNDAValor2)
      Me.grbCNDesdeArchivo.Controls.Add(Me.txtCNDAValor1)
      Me.grbCNDesdeArchivo.Enabled = False
      Me.grbCNDesdeArchivo.Location = New System.Drawing.Point(193, 213)
      Me.grbCNDesdeArchivo.Name = "grbCNDesdeArchivo"
      Me.grbCNDesdeArchivo.Size = New System.Drawing.Size(162, 99)
      Me.grbCNDesdeArchivo.TabIndex = 6
      Me.grbCNDesdeArchivo.TabStop = False
      Me.grbCNDesdeArchivo.Text = "Controles Negativos"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(7, 73)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(30, 13)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "CP3:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(7, 47)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(30, 13)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "CP2:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(7, 21)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(30, 13)
      Me.Label6.TabIndex = 3
      Me.Label6.Text = "CP1:"
      '
      'txtCNDAValor3
      '
      Me.txtCNDAValor3.Location = New System.Drawing.Point(51, 70)
      Me.txtCNDAValor3.Name = "txtCNDAValor3"
      Me.txtCNDAValor3.Size = New System.Drawing.Size(85, 20)
      Me.txtCNDAValor3.TabIndex = 2
      '
      'txtCNDAValor2
      '
      Me.txtCNDAValor2.Location = New System.Drawing.Point(51, 44)
      Me.txtCNDAValor2.Name = "txtCNDAValor2"
      Me.txtCNDAValor2.Size = New System.Drawing.Size(85, 20)
      Me.txtCNDAValor2.TabIndex = 1
      '
      'txtCNDAValor1
      '
      Me.txtCNDAValor1.Location = New System.Drawing.Point(51, 18)
      Me.txtCNDAValor1.Name = "txtCNDAValor1"
      Me.txtCNDAValor1.Size = New System.Drawing.Size(85, 20)
      Me.txtCNDAValor1.TabIndex = 0
      '
      'btnObtenResultadosDA
      '
      Me.btnObtenResultadosDA.Location = New System.Drawing.Point(491, 289)
      Me.btnObtenResultadosDA.Name = "btnObtenResultadosDA"
      Me.btnObtenResultadosDA.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenResultadosDA.TabIndex = 7
      Me.btnObtenResultadosDA.Text = "Obtener Resultados"
      Me.btnObtenResultadosDA.UseVisualStyleBackColor = True
      '
      'frmAbrirArchivoExistente
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(616, 342)
      Me.Controls.Add(Me.btnObtenResultadosDA)
      Me.Controls.Add(Me.grbCNDesdeArchivo)
      Me.Controls.Add(Me.grbCPDesdeArchivo)
      Me.Controls.Add(Me.lblNombrePlacaDesdeArchivo)
      Me.Controls.Add(Me.txtPlacaDesdeArchivo)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmAbrirArchivoExistente"
      Me.Text = "AbrirArchivoExistente"
      Me.grbCPDesdeArchivo.ResumeLayout(False)
      Me.grbCPDesdeArchivo.PerformLayout()
      Me.grbCNDesdeArchivo.ResumeLayout(False)
      Me.grbCNDesdeArchivo.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ofdSelArchivo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
   Friend WithEvents txtPlacaDesdeArchivo As System.Windows.Forms.TextBox
   Friend WithEvents lblNombrePlacaDesdeArchivo As System.Windows.Forms.Label
   Friend WithEvents grbCPDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCPDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents grbCNDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtCNDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents btnObtenResultadosDA As System.Windows.Forms.Button
End Class
