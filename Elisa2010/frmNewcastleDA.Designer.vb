﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewcastleDA
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewcastleDA))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.ofdSelArchivo = New System.Windows.Forms.OpenFileDialog()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.txtMensajeSobreGrafica = New System.Windows.Forms.TextBox()
      Me.txtNombreSobreGrafica = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.btnCapturaTerminada = New System.Windows.Forms.Button()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.pnlRegistraNuevoAnalisis = New System.Windows.Forms.Panel()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.btnBuscaCaso = New System.Windows.Forms.Button()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.lblNombreAnalisis = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.btnCancelarDA = New System.Windows.Forms.Button()
      Me.btnLeerArchivoExistente = New System.Windows.Forms.Button()
      Me.btnObtenResultadosDA = New System.Windows.Forms.Button()
      Me.txtPlacaDesdeArchivo = New System.Windows.Forms.TextBox()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.txtDesdeLetra1 = New System.Windows.Forms.TextBox()
      Me.txtDesdeValor1 = New System.Windows.Forms.TextBox()
      Me.txtHastaLetra2 = New System.Windows.Forms.TextBox()
      Me.txtHastaValor2 = New System.Windows.Forms.TextBox()
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
      Me.Panel2.SuspendLayout()
      Me.pnlRegistraNuevoAnalisis.SuspendLayout()
      Me.Panel1.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbCNDesdeArchivo.SuspendLayout()
      Me.grbCPDesdeArchivo.SuspendLayout()
      Me.SuspendLayout()
      '
      'ofdSelArchivo
      '
      Me.ofdSelArchivo.Filter = "Archivos Excel(*.xls)|*.xls"
      Me.ofdSelArchivo.InitialDirectory = "c:\ELISA2010\Placa desde archivo"
      Me.ofdSelArchivo.Title = "Abrir archivo de datos"
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.txtMensajeSobreGrafica)
      Me.Panel2.Controls.Add(Me.txtNombreSobreGrafica)
      Me.Panel2.Controls.Add(Me.Label7)
      Me.Panel2.Controls.Add(Me.Label8)
      Me.Panel2.Location = New System.Drawing.Point(588, 4)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(288, 107)
      Me.Panel2.TabIndex = 121
      '
      'txtMensajeSobreGrafica
      '
      Me.txtMensajeSobreGrafica.Location = New System.Drawing.Point(17, 56)
      Me.txtMensajeSobreGrafica.Name = "txtMensajeSobreGrafica"
      Me.txtMensajeSobreGrafica.Size = New System.Drawing.Size(250, 20)
      Me.txtMensajeSobreGrafica.TabIndex = 10
      '
      'txtNombreSobreGrafica
      '
      Me.txtNombreSobreGrafica.Location = New System.Drawing.Point(157, 15)
      Me.txtNombreSobreGrafica.Name = "txtNombreSobreGrafica"
      Me.txtNombreSobreGrafica.Size = New System.Drawing.Size(110, 20)
      Me.txtNombreSobreGrafica.TabIndex = 9
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label7.Location = New System.Drawing.Point(47, 79)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(194, 15)
      Me.Label7.TabIndex = 7
      Me.Label7.Text = "Texto (como requiere en gráfica): "
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label8.Location = New System.Drawing.Point(12, 19)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(125, 16)
      Me.Label8.TabIndex = 8
      Me.Label8.Text = "Nombre Abreviado:"
      '
      'btnCapturaTerminada
      '
      Me.btnCapturaTerminada.Enabled = False
      Me.btnCapturaTerminada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCapturaTerminada.Location = New System.Drawing.Point(533, 408)
      Me.btnCapturaTerminada.Name = "btnCapturaTerminada"
      Me.btnCapturaTerminada.Size = New System.Drawing.Size(105, 23)
      Me.btnCapturaTerminada.TabIndex = 120
      Me.btnCapturaTerminada.Text = "Captura Terminada"
      Me.btnCapturaTerminada.UseVisualStyleBackColor = True
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Location = New System.Drawing.Point(123, 411)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(39, 13)
      Me.lblObservaciones.TabIndex = 119
      Me.lblObservaciones.Text = "Label7"
      Me.lblObservaciones.Visible = False
      '
      'pnlRegistraNuevoAnalisis
      '
      Me.pnlRegistraNuevoAnalisis.AutoSize = True
      Me.pnlRegistraNuevoAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.pnlRegistraNuevoAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.dtpFechaElaboracion)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.txtAnalisisSolicitado)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.btnBuscaCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.cmbNoCaso)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreAnalisis)
      Me.pnlRegistraNuevoAnalisis.Controls.Add(Me.lblNombreCliente)
      Me.pnlRegistraNuevoAnalisis.Location = New System.Drawing.Point(7, 4)
      Me.pnlRegistraNuevoAnalisis.Name = "pnlRegistraNuevoAnalisis"
      Me.pnlRegistraNuevoAnalisis.Size = New System.Drawing.Size(574, 107)
      Me.pnlRegistraNuevoAnalisis.TabIndex = 118
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.Location = New System.Drawing.Point(147, 75)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(411, 20)
      Me.txtNombreCliente.TabIndex = 2
      Me.txtNombreCliente.TabStop = False
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(455, 3)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 7
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(145, 43)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(413, 20)
      Me.txtAnalisisSolicitado.TabIndex = 3
      Me.txtAnalisisSolicitado.TabStop = False
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNoCaso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCaso.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCaso.Location = New System.Drawing.Point(16, 14)
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
      Me.btnBuscaCaso.Location = New System.Drawing.Point(328, 10)
      Me.btnBuscaCaso.Name = "btnBuscaCaso"
      Me.btnBuscaCaso.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaCaso.TabIndex = 1
      Me.btnBuscaCaso.UseVisualStyleBackColor = True
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Location = New System.Drawing.Point(147, 10)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(175, 21)
      Me.cmbNoCaso.TabIndex = 0
      '
      'lblNombreAnalisis
      '
      Me.lblNombreAnalisis.AutoSize = True
      Me.lblNombreAnalisis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.lblNombreAnalisis.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreAnalisis.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNombreAnalisis.Location = New System.Drawing.Point(16, 45)
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
      Me.lblNombreCliente.Location = New System.Drawing.Point(16, 76)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(125, 16)
      Me.lblNombreCliente.TabIndex = 2
      Me.lblNombreCliente.Text = "Nombre del Cliente:"
      '
      'btnCancelarDA
      '
      Me.btnCancelarDA.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelarDA.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btnCancelarDA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelarDA.Location = New System.Drawing.Point(763, 408)
      Me.btnCancelarDA.Name = "btnCancelarDA"
      Me.btnCancelarDA.Size = New System.Drawing.Size(113, 23)
      Me.btnCancelarDA.TabIndex = 115
      Me.btnCancelarDA.Text = "Cancelar"
      Me.btnCancelarDA.UseVisualStyleBackColor = True
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Enabled = False
      Me.btnLeerArchivoExistente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(763, 117)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(113, 23)
      Me.btnLeerArchivoExistente.TabIndex = 113
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
      '
      'btnObtenResultadosDA
      '
      Me.btnObtenResultadosDA.Enabled = False
      Me.btnObtenResultadosDA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnObtenResultadosDA.Location = New System.Drawing.Point(644, 408)
      Me.btnObtenResultadosDA.Name = "btnObtenResultadosDA"
      Me.btnObtenResultadosDA.Size = New System.Drawing.Size(113, 23)
      Me.btnObtenResultadosDA.TabIndex = 114
      Me.btnObtenResultadosDA.Text = "Obtener Resultados"
      Me.btnObtenResultadosDA.UseVisualStyleBackColor = True
      '
      'txtPlacaDesdeArchivo
      '
      Me.txtPlacaDesdeArchivo.BackColor = System.Drawing.Color.White
      Me.txtPlacaDesdeArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtPlacaDesdeArchivo.Location = New System.Drawing.Point(7, 408)
      Me.txtPlacaDesdeArchivo.Multiline = True
      Me.txtPlacaDesdeArchivo.Name = "txtPlacaDesdeArchivo"
      Me.txtPlacaDesdeArchivo.ReadOnly = True
      Me.txtPlacaDesdeArchivo.Size = New System.Drawing.Size(104, 23)
      Me.txtPlacaDesdeArchivo.TabIndex = 112
      Me.txtPlacaDesdeArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.txtPlacaDesdeArchivo.Visible = False
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.dgvPlacaLeida)
      Me.Panel1.Controls.Add(Me.Label19)
      Me.Panel1.Controls.Add(Me.Label20)
      Me.Panel1.Controls.Add(Me.txtDesdeLetra1)
      Me.Panel1.Controls.Add(Me.txtDesdeValor1)
      Me.Panel1.Controls.Add(Me.txtHastaLetra2)
      Me.Panel1.Controls.Add(Me.txtHastaValor2)
      Me.Panel1.Controls.Add(Me.lblLogTit2)
      Me.Panel1.Controls.Add(Me.grbCNDesdeArchivo)
      Me.Panel1.Controls.Add(Me.lblLogTit1)
      Me.Panel1.Controls.Add(Me.grbCPDesdeArchivo)
      Me.Panel1.Controls.Add(Me.lblLogSPS)
      Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Panel1.Location = New System.Drawing.Point(7, 146)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(869, 256)
      Me.Panel1.TabIndex = 116
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
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(8, 11)
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
      Me.dgvPlacaLeida.TabIndex = 93
      Me.dgvPlacaLeida.TabStop = False
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label19.Location = New System.Drawing.Point(368, 225)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(43, 16)
      Me.Label19.TabIndex = 92
      Me.Label19.Text = "Hasta:"
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label20.Location = New System.Drawing.Point(196, 224)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(48, 16)
      Me.Label20.TabIndex = 91
      Me.Label20.Text = "Desde:"
      '
      'txtDesdeLetra1
      '
      Me.txtDesdeLetra1.BackColor = System.Drawing.Color.White
      Me.txtDesdeLetra1.Enabled = False
      Me.txtDesdeLetra1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeLetra1.Location = New System.Drawing.Point(250, 223)
      Me.txtDesdeLetra1.MaxLength = 1
      Me.txtDesdeLetra1.Name = "txtDesdeLetra1"
      Me.txtDesdeLetra1.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeLetra1.TabIndex = 87
      '
      'txtDesdeValor1
      '
      Me.txtDesdeValor1.BackColor = System.Drawing.Color.White
      Me.txtDesdeValor1.Enabled = False
      Me.txtDesdeValor1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeValor1.Location = New System.Drawing.Point(282, 223)
      Me.txtDesdeValor1.MaxLength = 2
      Me.txtDesdeValor1.Name = "txtDesdeValor1"
      Me.txtDesdeValor1.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeValor1.TabIndex = 88
      '
      'txtHastaLetra2
      '
      Me.txtHastaLetra2.BackColor = System.Drawing.Color.White
      Me.txtHastaLetra2.Enabled = False
      Me.txtHastaLetra2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaLetra2.Location = New System.Drawing.Point(422, 224)
      Me.txtHastaLetra2.MaxLength = 1
      Me.txtHastaLetra2.Name = "txtHastaLetra2"
      Me.txtHastaLetra2.Size = New System.Drawing.Size(25, 20)
      Me.txtHastaLetra2.TabIndex = 89
      '
      'txtHastaValor2
      '
      Me.txtHastaValor2.BackColor = System.Drawing.Color.White
      Me.txtHastaValor2.Enabled = False
      Me.txtHastaValor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaValor2.Location = New System.Drawing.Point(455, 224)
      Me.txtHastaValor2.MaxLength = 2
      Me.txtHastaValor2.Name = "txtHastaValor2"
      Me.txtHastaValor2.Size = New System.Drawing.Size(24, 20)
      Me.txtHastaValor2.TabIndex = 90
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(114, 226)
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
      Me.grbCNDesdeArchivo.Location = New System.Drawing.Point(712, 111)
      Me.grbCNDesdeArchivo.Name = "grbCNDesdeArchivo"
      Me.grbCNDesdeArchivo.Size = New System.Drawing.Size(147, 99)
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
      Me.lblLogTit1.Location = New System.Drawing.Point(63, 228)
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
      Me.grbCPDesdeArchivo.Location = New System.Drawing.Point(712, 6)
      Me.grbCPDesdeArchivo.Name = "grbCPDesdeArchivo"
      Me.grbCPDesdeArchivo.Size = New System.Drawing.Size(147, 99)
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
      Me.lblLogSPS.Location = New System.Drawing.Point(4, 227)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(53, 13)
      Me.lblLogSPS.TabIndex = 7
      Me.lblLogSPS.Text = "logsSPS: "
      Me.lblLogSPS.Visible = False
      '
      'frmNewcastleDA
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(882, 471)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.btnCapturaTerminada)
      Me.Controls.Add(Me.lblObservaciones)
      Me.Controls.Add(Me.pnlRegistraNuevoAnalisis)
      Me.Controls.Add(Me.btnCancelarDA)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.Controls.Add(Me.btnObtenResultadosDA)
      Me.Controls.Add(Me.txtPlacaDesdeArchivo)
      Me.Controls.Add(Me.Panel1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmNewcastleDA"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Análisis de Enfermedad de Newcastle desde archivo"
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.pnlRegistraNuevoAnalisis.ResumeLayout(False)
      Me.pnlRegistraNuevoAnalisis.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbCNDesdeArchivo.ResumeLayout(False)
      Me.grbCNDesdeArchivo.PerformLayout()
      Me.grbCPDesdeArchivo.ResumeLayout(False)
      Me.grbCPDesdeArchivo.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ofdSelArchivo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents txtMensajeSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents btnCapturaTerminada As System.Windows.Forms.Button
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents pnlRegistraNuevoAnalisis As System.Windows.Forms.Panel
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents btnBuscaCaso As System.Windows.Forms.Button
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents lblNombreAnalisis As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents btnCancelarDA As System.Windows.Forms.Button
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
   Friend WithEvents btnObtenResultadosDA As System.Windows.Forms.Button
   Friend WithEvents txtPlacaDesdeArchivo As System.Windows.Forms.TextBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtDesdeLetra1 As System.Windows.Forms.TextBox
   Friend WithEvents txtDesdeValor1 As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaLetra2 As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaValor2 As System.Windows.Forms.TextBox
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents grbCNDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtCNDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCNDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
   Friend WithEvents grbCPDesdeArchivo As System.Windows.Forms.GroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCPDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
End Class
