<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirDesdeArchivo
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.lblLogTit1 = New System.Windows.Forms.Label()
      Me.lblLogSPS = New System.Windows.Forms.Label()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.lblLogTit2 = New System.Windows.Forms.Label()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.btnLeerArchivoExistente = New System.Windows.Forms.Button()
      Me.grbCNDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtCNDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor1 = New System.Windows.Forms.TextBox()
      Me.grbCPDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtCPDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor1 = New System.Windows.Forms.TextBox()
      Me.lblMensajeAAE = New System.Windows.Forms.Label()
      Me.btnObtenResultadosDA = New System.Windows.Forms.Button()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.grbCNDesdeArchivo.SuspendLayout()
      Me.grbCPDesdeArchivo.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'btnCancelar
      '
      Me.btnCancelar.Location = New System.Drawing.Point(605, 434)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(107, 23)
      Me.btnCancelar.TabIndex = 3
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'lblLogTit1
      '
      Me.lblLogTit1.AutoSize = True
      Me.lblLogTit1.Location = New System.Drawing.Point(661, 36)
      Me.lblLogTit1.Name = "lblLogTit1"
      Me.lblLogTit1.Size = New System.Drawing.Size(28, 13)
      Me.lblLogTit1.TabIndex = 36
      Me.lblLogTit1.Text = "1.45"
      Me.lblLogTit1.Visible = False
      '
      'lblLogSPS
      '
      Me.lblLogSPS.AutoSize = True
      Me.lblLogSPS.Location = New System.Drawing.Point(661, 20)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(28, 13)
      Me.lblLogSPS.TabIndex = 35
      Me.lblLogSPS.Text = "0.15"
      Me.lblLogSPS.Visible = False
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNoCaso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCaso.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCaso.Location = New System.Drawing.Point(30, 10)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(109, 16)
      Me.lblNoCaso.TabIndex = 30
      Me.lblNoCaso.Text = "Número de caso:"
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(159, 81)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 33
      Me.txtAnalisisSolicitado.TabStop = False
      Me.txtAnalisisSolicitado.Text = "Inmunoensayo/Laringotraqueitis"
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreCliente.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreCliente.Location = New System.Drawing.Point(30, 47)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(125, 16)
      Me.lblNombreCliente.TabIndex = 32
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Items.AddRange(New Object() {"110420-1734 | E06/ELLT"})
      Me.cmbNoCaso.Location = New System.Drawing.Point(159, 9)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(182, 21)
      Me.cmbNoCaso.TabIndex = 0
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.Location = New System.Drawing.Point(159, 46)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 31
      Me.txtNombreCliente.TabStop = False
      Me.txtNombreCliente.Text = "Proteina Animal"
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreAnalisis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreAnalisis.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(30, 83)
      Me.lblNombreAnalisis.Name = "lblNombreAnalisis"
      Me.lblNombreAnalisis.Size = New System.Drawing.Size(126, 16)
      Me.lblNombreAnalisis.TabIndex = 34
      Me.lblNombreAnalisis.Text = "Nombre del análisis:"
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(661, 53)
      Me.lblLogTit2.Name = "lblLogTit2"
      Me.lblLogTit2.Size = New System.Drawing.Size(37, 13)
      Me.lblLogTit2.TabIndex = 37
      Me.lblLogTit2.Text = "3.726 "
      Me.lblLogTit2.Visible = False
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Location = New System.Drawing.Point(640, 88)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
      Me.lblObservaciones.TabIndex = 40
      Me.lblObservaciones.Text = "Observaciones:"
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(503, 12)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 41
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(367, 434)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerArchivoExistente.TabIndex = 1
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
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
      Me.grbCNDesdeArchivo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbCNDesdeArchivo.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbCNDesdeArchivo.Location = New System.Drawing.Point(243, 331)
      Me.grbCNDesdeArchivo.Name = "grbCNDesdeArchivo"
      Me.grbCNDesdeArchivo.Size = New System.Drawing.Size(162, 99)
      Me.grbCNDesdeArchivo.TabIndex = 44
      Me.grbCNDesdeArchivo.TabStop = False
      Me.grbCNDesdeArchivo.Text = "Controles Negativos"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(7, 73)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(34, 16)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "CP3:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(7, 47)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(34, 16)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "CP2:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(7, 21)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(34, 16)
      Me.Label6.TabIndex = 3
      Me.Label6.Text = "CP1:"
      '
      'txtCNDAValor3
      '
      Me.txtCNDAValor3.Location = New System.Drawing.Point(51, 70)
      Me.txtCNDAValor3.Name = "txtCNDAValor3"
      Me.txtCNDAValor3.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor3.TabIndex = 2
      '
      'txtCNDAValor2
      '
      Me.txtCNDAValor2.Location = New System.Drawing.Point(51, 44)
      Me.txtCNDAValor2.Name = "txtCNDAValor2"
      Me.txtCNDAValor2.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor2.TabIndex = 1
      '
      'txtCNDAValor1
      '
      Me.txtCNDAValor1.Location = New System.Drawing.Point(51, 18)
      Me.txtCNDAValor1.Name = "txtCNDAValor1"
      Me.txtCNDAValor1.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor1.TabIndex = 0
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
      Me.grbCPDesdeArchivo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbCPDesdeArchivo.ForeColor = System.Drawing.Color.MidnightBlue
      Me.grbCPDesdeArchivo.Location = New System.Drawing.Point(55, 331)
      Me.grbCPDesdeArchivo.Name = "grbCPDesdeArchivo"
      Me.grbCPDesdeArchivo.Size = New System.Drawing.Size(162, 99)
      Me.grbCPDesdeArchivo.TabIndex = 43
      Me.grbCPDesdeArchivo.TabStop = False
      Me.grbCPDesdeArchivo.Text = "Controles Positivos"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(7, 73)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(34, 16)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "CP3:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(7, 47)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(34, 16)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "CP2:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(7, 21)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(34, 16)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "CP1:"
      '
      'txtCPDAValor3
      '
      Me.txtCPDAValor3.Location = New System.Drawing.Point(51, 70)
      Me.txtCPDAValor3.Name = "txtCPDAValor3"
      Me.txtCPDAValor3.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor3.TabIndex = 2
      '
      'txtCPDAValor2
      '
      Me.txtCPDAValor2.Location = New System.Drawing.Point(51, 44)
      Me.txtCPDAValor2.Name = "txtCPDAValor2"
      Me.txtCPDAValor2.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor2.TabIndex = 1
      '
      'txtCPDAValor1
      '
      Me.txtCPDAValor1.Location = New System.Drawing.Point(51, 18)
      Me.txtCPDAValor1.Name = "txtCPDAValor1"
      Me.txtCPDAValor1.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor1.TabIndex = 0
      '
      'lblMensajeAAE
      '
      Me.lblMensajeAAE.AutoSize = True
      Me.lblMensajeAAE.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeAAE.ForeColor = System.Drawing.Color.Green
      Me.lblMensajeAAE.Location = New System.Drawing.Point(21, 438)
      Me.lblMensajeAAE.Name = "lblMensajeAAE"
      Me.lblMensajeAAE.Size = New System.Drawing.Size(56, 15)
      Me.lblMensajeAAE.TabIndex = 45
      Me.lblMensajeAAE.Text = "Mensaje:"
      '
      'btnObtenResultadosDA
      '
      Me.btnObtenResultadosDA.Location = New System.Drawing.Point(486, 434)
      Me.btnObtenResultadosDA.Name = "btnObtenResultadosDA"
      Me.btnObtenResultadosDA.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenResultadosDA.TabIndex = 2
      Me.btnObtenResultadosDA.Text = "Obtener Resultados"
      Me.btnObtenResultadosDA.UseVisualStyleBackColor = True
      '
      'dgvPlacaLeida
      '
      Me.dgvPlacaLeida.AllowUserToAddRows = False
      Me.dgvPlacaLeida.AllowUserToDeleteRows = False
      Me.dgvPlacaLeida.AllowUserToResizeColumns = False
      Me.dgvPlacaLeida.AllowUserToResizeRows = False
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.dgvPlacaLeida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.dgvPlacaLeida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.dgvPlacaLeida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.dgvPlacaLeida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvPlacaLeida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.dgvPlacaLeida.GridColor = System.Drawing.Color.Gray
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(10, 113)
      Me.dgvPlacaLeida.Name = "dgvPlacaLeida"
      Me.dgvPlacaLeida.ReadOnly = True
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue
      Me.dgvPlacaLeida.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.dgvPlacaLeida.RowsDefaultCellStyle = DataGridViewCellStyle4
      Me.dgvPlacaLeida.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.dgvPlacaLeida.Size = New System.Drawing.Size(698, 200)
      Me.dgvPlacaLeida.TabIndex = 81
      Me.dgvPlacaLeida.TabStop = False
      '
      'frmAbrirDesdeArchivo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(733, 462)
      Me.Controls.Add(Me.dgvPlacaLeida)
      Me.Controls.Add(Me.btnObtenResultadosDA)
      Me.Controls.Add(Me.lblMensajeAAE)
      Me.Controls.Add(Me.grbCNDesdeArchivo)
      Me.Controls.Add(Me.grbCPDesdeArchivo)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.Controls.Add(Me.dtpFechaElaboracion)
      Me.Controls.Add(Me.lblObservaciones)
      Me.Controls.Add(Me.lblLogTit1)
      Me.Controls.Add(Me.lblLogSPS)
      Me.Controls.Add(Me.lblNoCaso)
      Me.Controls.Add(Me.txtAnalisisSolicitado)
      Me.Controls.Add(Me.lblNombreCliente)
      Me.Controls.Add(Me.cmbNoCaso)
      Me.Controls.Add(Me.txtNombreCliente)
      Me.Controls.Add(Me.lblNombreAnalisis)
      Me.Controls.Add(Me.lblLogTit2)
      Me.Controls.Add(Me.btnCancelar)
      Me.Name = "frmAbrirDesdeArchivo"
      Me.Text = "Abrir Desde  Archivo Existente"
      Me.grbCNDesdeArchivo.ResumeLayout(False)
      Me.grbCNDesdeArchivo.PerformLayout()
      Me.grbCPDesdeArchivo.ResumeLayout(False)
      Me.grbCPDesdeArchivo.PerformLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
   Friend WithEvents grbCNDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtCNDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents grbCPDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCPDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents lblMensajeAAE As System.Windows.Forms.Label
   Friend WithEvents btnObtenResultadosDA As System.Windows.Forms.Button
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
End Class
