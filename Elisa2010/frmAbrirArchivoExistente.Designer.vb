﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
      Me.lblMensajeAAE = New System.Windows.Forms.Label()
      Me.btnObtenResultadosDA = New System.Windows.Forms.Button()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.lblLogTit2 = New System.Windows.Forms.Label()
      Me.grbCNDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtCNDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCNDAValor1 = New System.Windows.Forms.TextBox()
      Me.lblLogTit1 = New System.Windows.Forms.Label()
      Me.grbCPDesdeArchivo = New System.Windows.Forms.GroupBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtCPDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor1 = New System.Windows.Forms.TextBox()
      Me.lblLogSPS = New System.Windows.Forms.Label()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.btnCancelarDA = New System.Windows.Forms.Button()
      Me.pnlRegistraNuevoAnalisis = New System.Windows.Forms.Panel()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.btnBuscaCaso = New System.Windows.Forms.Button()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.Panel1.SuspendLayout()
      Me.grbCNDesdeArchivo.SuspendLayout()
      Me.grbCPDesdeArchivo.SuspendLayout()
      Me.Panel3.SuspendLayout()
      Me.pnlRegistraNuevoAnalisis.SuspendLayout()
      Me.SuspendLayout()
      '
      'ofdSelArchivo
      '
      Me.ofdSelArchivo.Filter = "Archivos Excel(*.xls)|*.xlsx|*.XLS|*.XLSX"
      Me.ofdSelArchivo.Title = "Abrir archivo de datos"
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Enabled = False
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(274, 421)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerArchivoExistente.TabIndex = 0
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
      '
      'txtPlacaDesdeArchivo
      '
      Me.txtPlacaDesdeArchivo.BackColor = System.Drawing.Color.White
      Me.txtPlacaDesdeArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtPlacaDesdeArchivo.Location = New System.Drawing.Point(12, 13)
      Me.txtPlacaDesdeArchivo.Multiline = True
      Me.txtPlacaDesdeArchivo.Name = "txtPlacaDesdeArchivo"
      Me.txtPlacaDesdeArchivo.ReadOnly = True
      Me.txtPlacaDesdeArchivo.Size = New System.Drawing.Size(592, 121)
      Me.txtPlacaDesdeArchivo.TabIndex = 1
      Me.txtPlacaDesdeArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblMensajeAAE
      '
      Me.lblMensajeAAE.AutoSize = True
      Me.lblMensajeAAE.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeAAE.ForeColor = System.Drawing.Color.Green
      Me.lblMensajeAAE.Location = New System.Drawing.Point(5, 7)
      Me.lblMensajeAAE.Name = "lblMensajeAAE"
      Me.lblMensajeAAE.Size = New System.Drawing.Size(0, 15)
      Me.lblMensajeAAE.TabIndex = 2
      '
      'btnObtenResultadosDA
      '
      Me.btnObtenResultadosDA.Enabled = False
      Me.btnObtenResultadosDA.Location = New System.Drawing.Point(393, 421)
      Me.btnObtenResultadosDA.Name = "btnObtenResultadosDA"
      Me.btnObtenResultadosDA.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenResultadosDA.TabIndex = 1
      Me.btnObtenResultadosDA.Text = "Obtener Resultados"
      Me.btnObtenResultadosDA.UseVisualStyleBackColor = True
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.lblLogTit2)
      Me.Panel1.Controls.Add(Me.grbCNDesdeArchivo)
      Me.Panel1.Controls.Add(Me.lblLogTit1)
      Me.Panel1.Controls.Add(Me.grbCPDesdeArchivo)
      Me.Panel1.Controls.Add(Me.lblLogSPS)
      Me.Panel1.Controls.Add(Me.txtPlacaDesdeArchivo)
      Me.Panel1.Location = New System.Drawing.Point(4, 161)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(621, 254)
      Me.Panel1.TabIndex = 8
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(524, 173)
      Me.lblLogTit2.Name = "lblLogTit2"
      Me.lblLogTit2.Size = New System.Drawing.Size(53, 13)
      Me.lblLogTit2.TabIndex = 9
      Me.lblLogTit2.Text = "logsSPS: "
      Me.lblLogTit2.Visible = False
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
      Me.grbCNDesdeArchivo.Location = New System.Drawing.Point(326, 140)
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
      'lblLogTit1
      '
      Me.lblLogTit1.AutoSize = True
      Me.lblLogTit1.Location = New System.Drawing.Point(524, 156)
      Me.lblLogTit1.Name = "lblLogTit1"
      Me.lblLogTit1.Size = New System.Drawing.Size(45, 13)
      Me.lblLogTit1.TabIndex = 8
      Me.lblLogTit1.Text = "logTit1: "
      Me.lblLogTit1.Visible = False
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
      Me.grbCPDesdeArchivo.Location = New System.Drawing.Point(138, 140)
      Me.grbCPDesdeArchivo.Name = "grbCPDesdeArchivo"
      Me.grbCPDesdeArchivo.Size = New System.Drawing.Size(162, 99)
      Me.grbCPDesdeArchivo.TabIndex = 3
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
      'lblLogSPS
      '
      Me.lblLogSPS.AutoSize = True
      Me.lblLogSPS.Location = New System.Drawing.Point(524, 140)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(53, 13)
      Me.lblLogSPS.TabIndex = 7
      Me.lblLogSPS.Text = "logsSPS: "
      Me.lblLogSPS.Visible = False
      '
      'Panel3
      '
      Me.Panel3.BackColor = System.Drawing.SystemColors.Window
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel3.Controls.Add(Me.lblMensajeAAE)
      Me.Panel3.Location = New System.Drawing.Point(6, 450)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(621, 29)
      Me.Panel3.TabIndex = 10
      '
      'btnCancelarDA
      '
      Me.btnCancelarDA.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btnCancelarDA.Location = New System.Drawing.Point(512, 421)
      Me.btnCancelarDA.Name = "btnCancelarDA"
      Me.btnCancelarDA.Size = New System.Drawing.Size(113, 23)
      Me.btnCancelarDA.TabIndex = 7
      Me.btnCancelarDA.Text = "Cancelar"
      Me.btnCancelarDA.UseVisualStyleBackColor = True
      '
      'pnlRegistraNuevoAnalisis
      '
      Me.pnlRegistraNuevoAnalisis.AutoSize = True
      Me.pnlRegistraNuevoAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.pnlRegistraNuevoAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtAnalisisSolicitado)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.btnBuscaCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.cmbNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreAnalisis)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Location = New System.Drawing.Point(6, 8)
      Me.pnlRegistraNuevoAnalisis.Name = "pnlRegistraNuevoAnalisis"
      Me.pnlRegistraNuevoAnalisis.Size = New System.Drawing.Size(619, 142)
      Me.pnlRegistraNuevoAnalisis.TabIndex = 74
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.Location = New System.Drawing.Point(136, 59)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 2
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(136, 94)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 3
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNoCaso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCaso.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCaso.Location = New System.Drawing.Point(7, 23)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(109, 16)
      Me.lblNoCaso.TabIndex = 1
      Me.lblNoCaso.Text = "Número de caso:"
      '
      'btnBuscaCaso
      '
      Me.btnBuscaCaso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscaCaso.ForeColor = System.Drawing.Color.SteelBlue
      Me.btnBuscaCaso.Image = CType(resources.GetObject("btnBuscaCaso.Image"), System.Drawing.Image)
      Me.btnBuscaCaso.Location = New System.Drawing.Point(324, 21)
      Me.btnBuscaCaso.Name = "btnBuscaCaso"
      Me.btnBuscaCaso.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaCaso.TabIndex = 0
      Me.btnBuscaCaso.UseVisualStyleBackColor = True
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Location = New System.Drawing.Point(136, 22)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(182, 21)
      Me.cmbNoCaso.TabIndex = 1
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreAnalisis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreAnalisis.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(7, 96)
      Me.lblNombreAnalisis.Name = "lblNombreAnalisis"
      Me.lblNombreAnalisis.Size = New System.Drawing.Size(126, 16)
      Me.lblNombreAnalisis.TabIndex = 6
      Me.lblNombreAnalisis.Text = "Nombre del análisis:"
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreCliente.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreCliente.Location = New System.Drawing.Point(7, 60)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(125, 16)
      Me.lblNombreCliente.TabIndex = 2
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'frmAbrirArchivoExistente
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.Control
      Me.ClientSize = New System.Drawing.Size(633, 485)
      Me.Controls.Add(Me.pnlRegistraNuevoAnalisis)
      Me.Controls.Add(Me.Panel3)
      Me.Controls.Add(Me.btnCancelarDA)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.Controls.Add(Me.btnObtenResultadosDA)
      Me.Controls.Add(Me.Panel1)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmAbrirArchivoExistente"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Abrir Archivo Existente"
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.grbCNDesdeArchivo.ResumeLayout(False)
      Me.grbCNDesdeArchivo.PerformLayout()
      Me.grbCPDesdeArchivo.ResumeLayout(False)
      Me.grbCPDesdeArchivo.PerformLayout()
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      Me.pnlRegistraNuevoAnalisis.ResumeLayout(False)
      Me.pnlRegistraNuevoAnalisis.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ofdSelArchivo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
   Friend WithEvents txtPlacaDesdeArchivo As System.Windows.Forms.TextBox
   Friend WithEvents lblMensajeAAE As System.Windows.Forms.Label
   Friend WithEvents btnObtenResultadosDA As System.Windows.Forms.Button
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
   Friend WithEvents btnCancelarDA As System.Windows.Forms.Button
   Friend WithEvents pnlRegistraNuevoAnalisis As System.Windows.Forms.Panel
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents btnBuscaCaso As System.Windows.Forms.Button
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
End Class