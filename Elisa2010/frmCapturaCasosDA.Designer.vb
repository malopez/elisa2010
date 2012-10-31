<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturaCasosDA
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapturaCasosDA))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.btnLeerArchivoExistente = New System.Windows.Forms.Button()
      Me.tbcDatosDelCaso = New System.Windows.Forms.TabControl()
      Me.tbpDatosDelCaso = New System.Windows.Forms.TabPage()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.Label41 = New System.Windows.Forms.Label()
      Me.txtNoControlesNegativos = New System.Windows.Forms.TextBox()
      Me.lblNoControles = New System.Windows.Forms.Label()
      Me.txtNoControlesPositivos = New System.Windows.Forms.TextBox()
      Me.btnAceptarNoCasos = New System.Windows.Forms.Button()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.txtPlacaDesdeArchivo = New System.Windows.Forms.TextBox()
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
      Me.Label9 = New System.Windows.Forms.Label()
      Me.txtCPDAValor3 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor2 = New System.Windows.Forms.TextBox()
      Me.txtCPDAValor1 = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtNombreSobreGrafica = New System.Windows.Forms.TextBox()
      Me.lblNoCasos = New System.Windows.Forms.Label()
      Me.txtNoDeCasos = New System.Windows.Forms.TextBox()
      Me.lblLogTit2 = New System.Windows.Forms.Label()
      Me.lblLogSPS = New System.Windows.Forms.Label()
      Me.lblLogTit1 = New System.Windows.Forms.Label()
      Me.lblIdAnalisis = New System.Windows.Forms.Label()
      Me.tbpInformacionCaso = New System.Windows.Forms.TabPage()
      Me.txtObservaciones = New System.Windows.Forms.TextBox()
      Me.btnAceptaSubCasos = New System.Windows.Forms.Button()
      Me.lblNoSubCaso = New System.Windows.Forms.Label()
      Me.txtNoSubcasos = New System.Windows.Forms.TextBox()
      Me.chkSubCasos = New System.Windows.Forms.CheckBox()
      Me.txtMensajeSobreGrafica = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.txtDesdeLetra = New System.Windows.Forms.TextBox()
      Me.txtDesdeValor = New System.Windows.Forms.TextBox()
      Me.txtHastaLetra = New System.Windows.Forms.TextBox()
      Me.txtHastaValor = New System.Windows.Forms.TextBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.txtAnalisisSolicitado = New System.Windows.Forms.TextBox()
      Me.Label33 = New System.Windows.Forms.Label()
      Me.btnBuscaCaso = New System.Windows.Forms.Button()
      Me.cmbNoCaso = New System.Windows.Forms.ComboBox()
      Me.Label34 = New System.Windows.Forms.Label()
      Me.Label35 = New System.Windows.Forms.Label()
      Me.Label43 = New System.Windows.Forms.Label()
      Me.dtpFechaElaboracion = New System.Windows.Forms.DateTimePicker()
      Me.dgvPlacaLeida = New System.Windows.Forms.DataGridView()
      Me.btnObtenerResultados = New System.Windows.Forms.Button()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.btnCapturaTerminada = New System.Windows.Forms.Button()
      Me.Panel5 = New System.Windows.Forms.Panel()
      Me.btnGuardarSubcaso = New System.Windows.Forms.Button()
      Me.btnNuevoSubcaso = New System.Windows.Forms.Button()
      Me.btnGuardarEditado = New System.Windows.Forms.Button()
      Me.btnInsertar = New System.Windows.Forms.Button()
      Me.btnGuardar = New System.Windows.Forms.Button()
      Me.btnEditar = New System.Windows.Forms.Button()
      Me.btnFin = New System.Windows.Forms.Button()
      Me.btnInicio = New System.Windows.Forms.Button()
      Me.btnHaciaAdelante = New System.Windows.Forms.Button()
      Me.btnHaciaAtras = New System.Windows.Forms.Button()
      Me.lblCasoDeCaso = New System.Windows.Forms.Label()
      Me.ofdSelArchivo = New System.Windows.Forms.OpenFileDialog()
      Me.tbcDatosDelCaso.SuspendLayout()
      Me.tbpDatosDelCaso.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbCNDesdeArchivo.SuspendLayout()
      Me.grbCPDesdeArchivo.SuspendLayout()
      Me.tbpInformacionCaso.SuspendLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel5.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnLeerArchivoExistente
      '
      Me.btnLeerArchivoExistente.Enabled = False
      Me.btnLeerArchivoExistente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnLeerArchivoExistente.Location = New System.Drawing.Point(566, 290)
      Me.btnLeerArchivoExistente.Name = "btnLeerArchivoExistente"
      Me.btnLeerArchivoExistente.Size = New System.Drawing.Size(131, 23)
      Me.btnLeerArchivoExistente.TabIndex = 112
      Me.btnLeerArchivoExistente.Text = "Leer Archivo"
      Me.btnLeerArchivoExistente.UseVisualStyleBackColor = True
      '
      'tbcDatosDelCaso
      '
      Me.tbcDatosDelCaso.Controls.Add(Me.tbpDatosDelCaso)
      Me.tbcDatosDelCaso.Controls.Add(Me.tbpInformacionCaso)
      Me.tbcDatosDelCaso.Location = New System.Drawing.Point(4, 7)
      Me.tbcDatosDelCaso.Name = "tbcDatosDelCaso"
      Me.tbcDatosDelCaso.SelectedIndex = 0
      Me.tbcDatosDelCaso.Size = New System.Drawing.Size(698, 241)
      Me.tbcDatosDelCaso.TabIndex = 141
      '
      'tbpDatosDelCaso
      '
      Me.tbpDatosDelCaso.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.tbpDatosDelCaso.Controls.Add(Me.PictureBox1)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label11)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label41)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoControlesNegativos)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblNoControles)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoControlesPositivos)
      Me.tbpDatosDelCaso.Controls.Add(Me.btnAceptarNoCasos)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label10)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtPlacaDesdeArchivo)
      Me.tbpDatosDelCaso.Controls.Add(Me.grbCNDesdeArchivo)
      Me.tbpDatosDelCaso.Controls.Add(Me.grbCPDesdeArchivo)
      Me.tbpDatosDelCaso.Controls.Add(Me.Label8)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNombreSobreGrafica)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblNoCasos)
      Me.tbpDatosDelCaso.Controls.Add(Me.txtNoDeCasos)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogTit2)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogSPS)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblLogTit1)
      Me.tbpDatosDelCaso.Controls.Add(Me.lblIdAnalisis)
      Me.tbpDatosDelCaso.Location = New System.Drawing.Point(4, 22)
      Me.tbpDatosDelCaso.Name = "tbpDatosDelCaso"
      Me.tbpDatosDelCaso.Padding = New System.Windows.Forms.Padding(3)
      Me.tbpDatosDelCaso.Size = New System.Drawing.Size(690, 215)
      Me.tbpDatosDelCaso.TabIndex = 0
      Me.tbpDatosDelCaso.Text = "Datos del caso y controles"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
      Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(18, 20)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(234, 179)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 175
      Me.PictureBox1.TabStop = False
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label11.Location = New System.Drawing.Point(265, 77)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(270, 16)
      Me.Label11.TabIndex = 174
      Me.Label11.Text = "Datos de los controles positivos y negativos:"
      '
      'Label41
      '
      Me.Label41.AutoSize = True
      Me.Label41.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label41.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label41.Location = New System.Drawing.Point(26, 183)
      Me.Label41.Name = "Label41"
      Me.Label41.Size = New System.Drawing.Size(100, 15)
      Me.Label41.TabIndex = 173
      Me.Label41.Text = "No. de Negativos"
      Me.Label41.Visible = False
      '
      'txtNoControlesNegativos
      '
      Me.txtNoControlesNegativos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesNegativos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesNegativos.Location = New System.Drawing.Point(132, 183)
      Me.txtNoControlesNegativos.MaxLength = 1
      Me.txtNoControlesNegativos.Name = "txtNoControlesNegativos"
      Me.txtNoControlesNegativos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesNegativos.TabIndex = 171
      Me.txtNoControlesNegativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.txtNoControlesNegativos.Visible = False
      '
      'lblNoControles
      '
      Me.lblNoControles.AutoSize = True
      Me.lblNoControles.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoControles.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoControles.Location = New System.Drawing.Point(26, 162)
      Me.lblNoControles.Name = "lblNoControles"
      Me.lblNoControles.Size = New System.Drawing.Size(92, 15)
      Me.lblNoControles.TabIndex = 172
      Me.lblNoControles.Text = "No. de Positivos"
      Me.lblNoControles.Visible = False
      '
      'txtNoControlesPositivos
      '
      Me.txtNoControlesPositivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.txtNoControlesPositivos.ForeColor = System.Drawing.Color.Yellow
      Me.txtNoControlesPositivos.Location = New System.Drawing.Point(132, 161)
      Me.txtNoControlesPositivos.MaxLength = 1
      Me.txtNoControlesPositivos.Name = "txtNoControlesPositivos"
      Me.txtNoControlesPositivos.Size = New System.Drawing.Size(25, 20)
      Me.txtNoControlesPositivos.TabIndex = 170
      Me.txtNoControlesPositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.txtNoControlesPositivos.Visible = False
      '
      'btnAceptarNoCasos
      '
      Me.btnAceptarNoCasos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAceptarNoCasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptarNoCasos.Location = New System.Drawing.Point(584, 60)
      Me.btnAceptarNoCasos.Name = "btnAceptarNoCasos"
      Me.btnAceptarNoCasos.Size = New System.Drawing.Size(48, 23)
      Me.btnAceptarNoCasos.TabIndex = 169
      Me.btnAceptarNoCasos.Text = "OK"
      Me.btnAceptarNoCasos.UseVisualStyleBackColor = True
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Location = New System.Drawing.Point(157, 154)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(39, 13)
      Me.Label10.TabIndex = 168
      Me.Label10.Text = "Label7"
      Me.Label10.Visible = False
      '
      'txtPlacaDesdeArchivo
      '
      Me.txtPlacaDesdeArchivo.BackColor = System.Drawing.Color.White
      Me.txtPlacaDesdeArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtPlacaDesdeArchivo.Location = New System.Drawing.Point(219, 147)
      Me.txtPlacaDesdeArchivo.Multiline = True
      Me.txtPlacaDesdeArchivo.Name = "txtPlacaDesdeArchivo"
      Me.txtPlacaDesdeArchivo.ReadOnly = True
      Me.txtPlacaDesdeArchivo.Size = New System.Drawing.Size(24, 23)
      Me.txtPlacaDesdeArchivo.TabIndex = 167
      Me.txtPlacaDesdeArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      Me.txtPlacaDesdeArchivo.Visible = False
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
      Me.grbCNDesdeArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
      Me.grbCNDesdeArchivo.Location = New System.Drawing.Point(460, 101)
      Me.grbCNDesdeArchivo.Name = "grbCNDesdeArchivo"
      Me.grbCNDesdeArchivo.Size = New System.Drawing.Size(172, 99)
      Me.grbCNDesdeArchivo.TabIndex = 166
      Me.grbCNDesdeArchivo.TabStop = False
      Me.grbCNDesdeArchivo.Text = "Controles Negativos"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(27, 73)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(34, 16)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "CP3:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(27, 47)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(34, 16)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "CP2:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(27, 21)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(34, 16)
      Me.Label6.TabIndex = 3
      Me.Label6.Text = "CP1:"
      '
      'txtCNDAValor3
      '
      Me.txtCNDAValor3.Location = New System.Drawing.Point(71, 70)
      Me.txtCNDAValor3.Name = "txtCNDAValor3"
      Me.txtCNDAValor3.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor3.TabIndex = 2
      '
      'txtCNDAValor2
      '
      Me.txtCNDAValor2.Location = New System.Drawing.Point(71, 44)
      Me.txtCNDAValor2.Name = "txtCNDAValor2"
      Me.txtCNDAValor2.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor2.TabIndex = 1
      '
      'txtCNDAValor1
      '
      Me.txtCNDAValor1.Location = New System.Drawing.Point(71, 18)
      Me.txtCNDAValor1.Name = "txtCNDAValor1"
      Me.txtCNDAValor1.Size = New System.Drawing.Size(71, 22)
      Me.txtCNDAValor1.TabIndex = 0
      '
      'grbCPDesdeArchivo
      '
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label3)
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label2)
      Me.grbCPDesdeArchivo.Controls.Add(Me.Label9)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor3)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor2)
      Me.grbCPDesdeArchivo.Controls.Add(Me.txtCPDAValor1)
      Me.grbCPDesdeArchivo.Enabled = False
      Me.grbCPDesdeArchivo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbCPDesdeArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
      Me.grbCPDesdeArchivo.Location = New System.Drawing.Point(268, 101)
      Me.grbCPDesdeArchivo.Name = "grbCPDesdeArchivo"
      Me.grbCPDesdeArchivo.Size = New System.Drawing.Size(163, 99)
      Me.grbCPDesdeArchivo.TabIndex = 165
      Me.grbCPDesdeArchivo.TabStop = False
      Me.grbCPDesdeArchivo.Text = "Controles Positivos"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(23, 73)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(34, 16)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "CP3:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(23, 47)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(34, 16)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "CP2:"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(23, 21)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(34, 16)
      Me.Label9.TabIndex = 3
      Me.Label9.Text = "CP1:"
      '
      'txtCPDAValor3
      '
      Me.txtCPDAValor3.Location = New System.Drawing.Point(67, 70)
      Me.txtCPDAValor3.Name = "txtCPDAValor3"
      Me.txtCPDAValor3.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor3.TabIndex = 2
      '
      'txtCPDAValor2
      '
      Me.txtCPDAValor2.Location = New System.Drawing.Point(67, 44)
      Me.txtCPDAValor2.Name = "txtCPDAValor2"
      Me.txtCPDAValor2.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor2.TabIndex = 1
      '
      'txtCPDAValor1
      '
      Me.txtCPDAValor1.Location = New System.Drawing.Point(67, 18)
      Me.txtCPDAValor1.Name = "txtCPDAValor1"
      Me.txtCPDAValor1.Size = New System.Drawing.Size(71, 22)
      Me.txtCPDAValor1.TabIndex = 0
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label8.Location = New System.Drawing.Point(265, 15)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(257, 16)
      Me.Label8.TabIndex = 164
      Me.Label8.Text = "Abreviatura del nombre de la enfermedad"
      '
      'txtNombreSobreGrafica
      '
      Me.txtNombreSobreGrafica.Location = New System.Drawing.Point(268, 34)
      Me.txtNombreSobreGrafica.Name = "txtNombreSobreGrafica"
      Me.txtNombreSobreGrafica.Size = New System.Drawing.Size(251, 20)
      Me.txtNombreSobreGrafica.TabIndex = 163
      '
      'lblNoCasos
      '
      Me.lblNoCasos.AutoSize = True
      Me.lblNoCasos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCasos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblNoCasos.Location = New System.Drawing.Point(556, 16)
      Me.lblNoCasos.Name = "lblNoCasos"
      Me.lblNoCasos.Size = New System.Drawing.Size(80, 15)
      Me.lblNoCasos.TabIndex = 162
      Me.lblNoCasos.Text = "No. de casos "
      '
      'txtNoDeCasos
      '
      Me.txtNoDeCasos.Location = New System.Drawing.Point(555, 34)
      Me.txtNoDeCasos.MaxLength = 2
      Me.txtNoDeCasos.Name = "txtNoDeCasos"
      Me.txtNoDeCasos.Size = New System.Drawing.Size(77, 20)
      Me.txtNoDeCasos.TabIndex = 157
      '
      'lblLogTit2
      '
      Me.lblLogTit2.AutoSize = True
      Me.lblLogTit2.Location = New System.Drawing.Point(216, 174)
      Me.lblLogTit2.Name = "lblLogTit2"
      Me.lblLogTit2.Size = New System.Drawing.Size(42, 13)
      Me.lblLogTit2.TabIndex = 160
      Me.lblLogTit2.Text = "logTit2:"
      Me.lblLogTit2.Visible = False
      '
      'lblLogSPS
      '
      Me.lblLogSPS.AutoSize = True
      Me.lblLogSPS.Location = New System.Drawing.Point(157, 171)
      Me.lblLogSPS.Name = "lblLogSPS"
      Me.lblLogSPS.Size = New System.Drawing.Size(53, 13)
      Me.lblLogSPS.TabIndex = 158
      Me.lblLogSPS.Text = "logsSPS: "
      Me.lblLogSPS.Visible = False
      '
      'lblLogTit1
      '
      Me.lblLogTit1.AutoSize = True
      Me.lblLogTit1.Location = New System.Drawing.Point(215, 190)
      Me.lblLogTit1.Name = "lblLogTit1"
      Me.lblLogTit1.Size = New System.Drawing.Size(45, 13)
      Me.lblLogTit1.TabIndex = 159
      Me.lblLogTit1.Text = "logTit1: "
      Me.lblLogTit1.Visible = False
      '
      'lblIdAnalisis
      '
      Me.lblIdAnalisis.AutoSize = True
      Me.lblIdAnalisis.Location = New System.Drawing.Point(157, 190)
      Me.lblIdAnalisis.Name = "lblIdAnalisis"
      Me.lblIdAnalisis.Size = New System.Drawing.Size(55, 13)
      Me.lblIdAnalisis.TabIndex = 161
      Me.lblIdAnalisis.Text = "id_analisis"
      Me.lblIdAnalisis.Visible = False
      '
      'tbpInformacionCaso
      '
      Me.tbpInformacionCaso.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.tbpInformacionCaso.Controls.Add(Me.txtObservaciones)
      Me.tbpInformacionCaso.Controls.Add(Me.btnAceptaSubCasos)
      Me.tbpInformacionCaso.Controls.Add(Me.lblNoSubCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.txtNoSubcasos)
      Me.tbpInformacionCaso.Controls.Add(Me.chkSubCasos)
      Me.tbpInformacionCaso.Controls.Add(Me.txtMensajeSobreGrafica)
      Me.tbpInformacionCaso.Controls.Add(Me.Label7)
      Me.tbpInformacionCaso.Controls.Add(Me.Label1)
      Me.tbpInformacionCaso.Controls.Add(Me.Label19)
      Me.tbpInformacionCaso.Controls.Add(Me.Label20)
      Me.tbpInformacionCaso.Controls.Add(Me.txtDesdeLetra)
      Me.tbpInformacionCaso.Controls.Add(Me.txtDesdeValor)
      Me.tbpInformacionCaso.Controls.Add(Me.txtHastaLetra)
      Me.tbpInformacionCaso.Controls.Add(Me.txtHastaValor)
      Me.tbpInformacionCaso.Controls.Add(Me.txtNombreCliente)
      Me.tbpInformacionCaso.Controls.Add(Me.txtAnalisisSolicitado)
      Me.tbpInformacionCaso.Controls.Add(Me.Label33)
      Me.tbpInformacionCaso.Controls.Add(Me.btnBuscaCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.cmbNoCaso)
      Me.tbpInformacionCaso.Controls.Add(Me.Label34)
      Me.tbpInformacionCaso.Controls.Add(Me.Label35)
      Me.tbpInformacionCaso.Location = New System.Drawing.Point(4, 22)
      Me.tbpInformacionCaso.Name = "tbpInformacionCaso"
      Me.tbpInformacionCaso.Padding = New System.Windows.Forms.Padding(3)
      Me.tbpInformacionCaso.Size = New System.Drawing.Size(690, 215)
      Me.tbpInformacionCaso.TabIndex = 1
      Me.tbpInformacionCaso.Text = "Información específica de los casos"
      '
      'txtObservaciones
      '
      Me.txtObservaciones.BackColor = System.Drawing.Color.White
      Me.txtObservaciones.Enabled = False
      Me.txtObservaciones.Location = New System.Drawing.Point(186, 104)
      Me.txtObservaciones.Name = "txtObservaciones"
      Me.txtObservaciones.ReadOnly = True
      Me.txtObservaciones.Size = New System.Drawing.Size(449, 20)
      Me.txtObservaciones.TabIndex = 185
      '
      'btnAceptaSubCasos
      '
      Me.btnAceptaSubCasos.Enabled = False
      Me.btnAceptaSubCasos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAceptaSubCasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnAceptaSubCasos.Location = New System.Drawing.Point(587, 13)
      Me.btnAceptaSubCasos.Name = "btnAceptaSubCasos"
      Me.btnAceptaSubCasos.Size = New System.Drawing.Size(48, 23)
      Me.btnAceptaSubCasos.TabIndex = 168
      Me.btnAceptaSubCasos.Text = "OK"
      Me.btnAceptaSubCasos.UseVisualStyleBackColor = True
      '
      'lblNoSubCaso
      '
      Me.lblNoSubCaso.AutoSize = True
      Me.lblNoSubCaso.Location = New System.Drawing.Point(641, 18)
      Me.lblNoSubCaso.Name = "lblNoSubCaso"
      Me.lblNoSubCaso.Size = New System.Drawing.Size(13, 13)
      Me.lblNoSubCaso.TabIndex = 174
      Me.lblNoSubCaso.Text = "1"
      Me.lblNoSubCaso.Visible = False
      '
      'txtNoSubcasos
      '
      Me.txtNoSubcasos.BackColor = System.Drawing.Color.White
      Me.txtNoSubcasos.Enabled = False
      Me.txtNoSubcasos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNoSubcasos.Location = New System.Drawing.Point(557, 14)
      Me.txtNoSubcasos.MaxLength = 2
      Me.txtNoSubcasos.Name = "txtNoSubcasos"
      Me.txtNoSubcasos.Size = New System.Drawing.Size(24, 20)
      Me.txtNoSubcasos.TabIndex = 167
      Me.txtNoSubcasos.Text = "2"
      Me.txtNoSubcasos.Visible = False
      '
      'chkSubCasos
      '
      Me.chkSubCasos.AutoSize = True
      Me.chkSubCasos.Enabled = False
      Me.chkSubCasos.ForeColor = System.Drawing.Color.DarkGreen
      Me.chkSubCasos.Location = New System.Drawing.Point(478, 17)
      Me.chkSubCasos.Name = "chkSubCasos"
      Me.chkSubCasos.Size = New System.Drawing.Size(73, 17)
      Me.chkSubCasos.TabIndex = 166
      Me.chkSubCasos.Text = "Subcasos"
      Me.chkSubCasos.UseVisualStyleBackColor = True
      '
      'txtMensajeSobreGrafica
      '
      Me.txtMensajeSobreGrafica.BackColor = System.Drawing.Color.White
      Me.txtMensajeSobreGrafica.Enabled = False
      Me.txtMensajeSobreGrafica.Location = New System.Drawing.Point(186, 134)
      Me.txtMensajeSobreGrafica.Name = "txtMensajeSobreGrafica"
      Me.txtMensajeSobreGrafica.Size = New System.Drawing.Size(449, 20)
      Me.txtMensajeSobreGrafica.TabIndex = 169
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label7.Location = New System.Drawing.Point(57, 134)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(38, 15)
      Me.Label7.TabIndex = 184
      Me.Label7.Text = "Texto:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label1.Location = New System.Drawing.Point(57, 104)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 16)
      Me.Label1.TabIndex = 183
      Me.Label1.Text = "Observaciones:"
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label19.Location = New System.Drawing.Point(57, 192)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(43, 16)
      Me.Label19.TabIndex = 181
      Me.Label19.Text = "Hasta:"
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label20.Location = New System.Drawing.Point(57, 164)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(48, 16)
      Me.Label20.TabIndex = 180
      Me.Label20.Text = "Desde:"
      '
      'txtDesdeLetra
      '
      Me.txtDesdeLetra.BackColor = System.Drawing.Color.White
      Me.txtDesdeLetra.Enabled = False
      Me.txtDesdeLetra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeLetra.Location = New System.Drawing.Point(186, 160)
      Me.txtDesdeLetra.MaxLength = 1
      Me.txtDesdeLetra.Name = "txtDesdeLetra"
      Me.txtDesdeLetra.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeLetra.TabIndex = 170
      '
      'txtDesdeValor
      '
      Me.txtDesdeValor.BackColor = System.Drawing.Color.White
      Me.txtDesdeValor.Enabled = False
      Me.txtDesdeValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesdeValor.Location = New System.Drawing.Point(217, 160)
      Me.txtDesdeValor.MaxLength = 2
      Me.txtDesdeValor.Name = "txtDesdeValor"
      Me.txtDesdeValor.Size = New System.Drawing.Size(25, 20)
      Me.txtDesdeValor.TabIndex = 171
      '
      'txtHastaLetra
      '
      Me.txtHastaLetra.BackColor = System.Drawing.Color.White
      Me.txtHastaLetra.Enabled = False
      Me.txtHastaLetra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaLetra.Location = New System.Drawing.Point(186, 187)
      Me.txtHastaLetra.MaxLength = 1
      Me.txtHastaLetra.Name = "txtHastaLetra"
      Me.txtHastaLetra.Size = New System.Drawing.Size(25, 20)
      Me.txtHastaLetra.TabIndex = 172
      '
      'txtHastaValor
      '
      Me.txtHastaValor.BackColor = System.Drawing.Color.White
      Me.txtHastaValor.Enabled = False
      Me.txtHastaValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtHastaValor.Location = New System.Drawing.Point(217, 187)
      Me.txtHastaValor.MaxLength = 2
      Me.txtHastaValor.Name = "txtHastaValor"
      Me.txtHastaValor.Size = New System.Drawing.Size(24, 20)
      Me.txtHastaValor.TabIndex = 173
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.BackColor = System.Drawing.Color.White
      Me.txtNombreCliente.Enabled = False
      Me.txtNombreCliente.Location = New System.Drawing.Point(186, 41)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 177
      Me.txtNombreCliente.TabStop = False
      '
      'txtAnalisisSolicitado
      '
      Me.txtAnalisisSolicitado.BackColor = System.Drawing.Color.White
      Me.txtAnalisisSolicitado.Enabled = False
      Me.txtAnalisisSolicitado.Location = New System.Drawing.Point(186, 71)
      Me.txtAnalisisSolicitado.Name = "txtAnalisisSolicitado"
      Me.txtAnalisisSolicitado.ReadOnly = True
      Me.txtAnalisisSolicitado.Size = New System.Drawing.Size(449, 20)
      Me.txtAnalisisSolicitado.TabIndex = 178
      Me.txtAnalisisSolicitado.TabStop = False
      '
      'Label33
      '
      Me.Label33.AutoSize = True
      Me.Label33.BackColor = System.Drawing.Color.Transparent
      Me.Label33.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label33.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label33.Location = New System.Drawing.Point(57, 14)
      Me.Label33.Name = "Label33"
      Me.Label33.Size = New System.Drawing.Size(109, 16)
      Me.Label33.TabIndex = 175
      Me.Label33.Text = "Número de caso:"
      '
      'btnBuscaCaso
      '
      Me.btnBuscaCaso.Enabled = False
      Me.btnBuscaCaso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscaCaso.ForeColor = System.Drawing.Color.SteelBlue
      Me.btnBuscaCaso.Image = CType(resources.GetObject("btnBuscaCaso.Image"), System.Drawing.Image)
      Me.btnBuscaCaso.Location = New System.Drawing.Point(374, 12)
      Me.btnBuscaCaso.Name = "btnBuscaCaso"
      Me.btnBuscaCaso.Size = New System.Drawing.Size(48, 23)
      Me.btnBuscaCaso.TabIndex = 165
      Me.btnBuscaCaso.UseVisualStyleBackColor = True
      '
      'cmbNoCaso
      '
      Me.cmbNoCaso.BackColor = System.Drawing.Color.White
      Me.cmbNoCaso.Enabled = False
      Me.cmbNoCaso.FormattingEnabled = True
      Me.cmbNoCaso.Location = New System.Drawing.Point(186, 13)
      Me.cmbNoCaso.Name = "cmbNoCaso"
      Me.cmbNoCaso.Size = New System.Drawing.Size(182, 21)
      Me.cmbNoCaso.TabIndex = 164
      '
      'Label34
      '
      Me.Label34.AutoSize = True
      Me.Label34.BackColor = System.Drawing.Color.Transparent
      Me.Label34.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label34.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label34.Location = New System.Drawing.Point(57, 74)
      Me.Label34.Name = "Label34"
      Me.Label34.Size = New System.Drawing.Size(126, 16)
      Me.Label34.TabIndex = 179
      Me.Label34.Text = "Nombre del análisis:"
      '
      'Label35
      '
      Me.Label35.AutoSize = True
      Me.Label35.BackColor = System.Drawing.Color.Transparent
      Me.Label35.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label35.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label35.Location = New System.Drawing.Point(57, 44)
      Me.Label35.Name = "Label35"
      Me.Label35.Size = New System.Drawing.Size(125, 16)
      Me.Label35.TabIndex = 176
      Me.Label35.Text = "Nombre del Cliente:"
      '
      'Label43
      '
      Me.Label43.AutoSize = True
      Me.Label43.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label43.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label43.Location = New System.Drawing.Point(542, 6)
      Me.Label43.Name = "Label43"
      Me.Label43.Size = New System.Drawing.Size(44, 15)
      Me.Label43.TabIndex = 143
      Me.Label43.Text = "Fecha:"
      '
      'dtpFechaElaboracion
      '
      Me.dtpFechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFechaElaboracion.Location = New System.Drawing.Point(592, 4)
      Me.dtpFechaElaboracion.Name = "dtpFechaElaboracion"
      Me.dtpFechaElaboracion.Size = New System.Drawing.Size(105, 20)
      Me.dtpFechaElaboracion.TabIndex = 142
      Me.dtpFechaElaboracion.TabStop = False
      Me.dtpFechaElaboracion.Value = New Date(2012, 5, 4, 0, 0, 0, 0)
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
      Me.dgvPlacaLeida.BackgroundColor = System.Drawing.Color.White
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
      Me.dgvPlacaLeida.Location = New System.Drawing.Point(2, 319)
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
      Me.dgvPlacaLeida.TabIndex = 147
      Me.dgvPlacaLeida.TabStop = False
      '
      'btnObtenerResultados
      '
      Me.btnObtenerResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnObtenerResultados.Location = New System.Drawing.Point(429, 525)
      Me.btnObtenerResultados.Name = "btnObtenerResultados"
      Me.btnObtenerResultados.Size = New System.Drawing.Size(131, 23)
      Me.btnObtenerResultados.TabIndex = 145
      Me.btnObtenerResultados.Text = "Previsualizar Resultados"
      Me.btnObtenerResultados.UseVisualStyleBackColor = True
      '
      'btnCancelar
      '
      Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(567, 525)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(131, 23)
      Me.btnCancelar.TabIndex = 146
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'btnCapturaTerminada
      '
      Me.btnCapturaTerminada.Enabled = False
      Me.btnCapturaTerminada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCapturaTerminada.Location = New System.Drawing.Point(429, 290)
      Me.btnCapturaTerminada.Name = "btnCapturaTerminada"
      Me.btnCapturaTerminada.Size = New System.Drawing.Size(131, 23)
      Me.btnCapturaTerminada.TabIndex = 169
      Me.btnCapturaTerminada.Text = "Aceptar Datos del caso "
      Me.btnCapturaTerminada.UseVisualStyleBackColor = True
      '
      'Panel5
      '
      Me.Panel5.BackColor = System.Drawing.SystemColors.Control
      Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel5.Controls.Add(Me.btnGuardarSubcaso)
      Me.Panel5.Controls.Add(Me.btnNuevoSubcaso)
      Me.Panel5.Controls.Add(Me.btnGuardarEditado)
      Me.Panel5.Controls.Add(Me.btnInsertar)
      Me.Panel5.Controls.Add(Me.btnGuardar)
      Me.Panel5.Controls.Add(Me.btnEditar)
      Me.Panel5.Controls.Add(Me.btnFin)
      Me.Panel5.Controls.Add(Me.btnInicio)
      Me.Panel5.Controls.Add(Me.btnHaciaAdelante)
      Me.Panel5.Controls.Add(Me.btnHaciaAtras)
      Me.Panel5.Controls.Add(Me.lblCasoDeCaso)
      Me.Panel5.Location = New System.Drawing.Point(86, 250)
      Me.Panel5.Name = "Panel5"
      Me.Panel5.Size = New System.Drawing.Size(535, 34)
      Me.Panel5.TabIndex = 148
      '
      'btnGuardarSubcaso
      '
      Me.btnGuardarSubcaso.Enabled = False
      Me.btnGuardarSubcaso.Image = CType(resources.GetObject("btnGuardarSubcaso.Image"), System.Drawing.Image)
      Me.btnGuardarSubcaso.Location = New System.Drawing.Point(489, 4)
      Me.btnGuardarSubcaso.Name = "btnGuardarSubcaso"
      Me.btnGuardarSubcaso.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardarSubcaso.TabIndex = 140
      Me.btnGuardarSubcaso.UseVisualStyleBackColor = True
      Me.btnGuardarSubcaso.Visible = False
      '
      'btnNuevoSubcaso
      '
      Me.btnNuevoSubcaso.Enabled = False
      Me.btnNuevoSubcaso.Image = CType(resources.GetObject("btnNuevoSubcaso.Image"), System.Drawing.Image)
      Me.btnNuevoSubcaso.Location = New System.Drawing.Point(445, 4)
      Me.btnNuevoSubcaso.Name = "btnNuevoSubcaso"
      Me.btnNuevoSubcaso.Size = New System.Drawing.Size(38, 23)
      Me.btnNuevoSubcaso.TabIndex = 139
      Me.btnNuevoSubcaso.UseVisualStyleBackColor = True
      Me.btnNuevoSubcaso.Visible = False
      '
      'btnGuardarEditado
      '
      Me.btnGuardarEditado.Enabled = False
      Me.btnGuardarEditado.Image = CType(resources.GetObject("btnGuardarEditado.Image"), System.Drawing.Image)
      Me.btnGuardarEditado.Location = New System.Drawing.Point(401, 4)
      Me.btnGuardarEditado.Name = "btnGuardarEditado"
      Me.btnGuardarEditado.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardarEditado.TabIndex = 138
      Me.btnGuardarEditado.UseVisualStyleBackColor = True
      '
      'btnInsertar
      '
      Me.btnInsertar.Enabled = False
      Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
      Me.btnInsertar.Location = New System.Drawing.Point(270, 4)
      Me.btnInsertar.Name = "btnInsertar"
      Me.btnInsertar.Size = New System.Drawing.Size(37, 23)
      Me.btnInsertar.TabIndex = 137
      Me.btnInsertar.Tag = ""
      Me.btnInsertar.UseVisualStyleBackColor = True
      '
      'btnGuardar
      '
      Me.btnGuardar.Enabled = False
      Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
      Me.btnGuardar.Location = New System.Drawing.Point(313, 4)
      Me.btnGuardar.Name = "btnGuardar"
      Me.btnGuardar.Size = New System.Drawing.Size(38, 23)
      Me.btnGuardar.TabIndex = 136
      Me.btnGuardar.UseVisualStyleBackColor = True
      '
      'btnEditar
      '
      Me.btnEditar.Enabled = False
      Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
      Me.btnEditar.Location = New System.Drawing.Point(357, 4)
      Me.btnEditar.Name = "btnEditar"
      Me.btnEditar.Size = New System.Drawing.Size(38, 23)
      Me.btnEditar.TabIndex = 76
      Me.btnEditar.UseVisualStyleBackColor = True
      '
      'btnFin
      '
      Me.btnFin.Enabled = False
      Me.btnFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnFin.Location = New System.Drawing.Point(227, 4)
      Me.btnFin.Name = "btnFin"
      Me.btnFin.Size = New System.Drawing.Size(37, 23)
      Me.btnFin.TabIndex = 74
      Me.btnFin.Text = ">>"
      Me.btnFin.UseVisualStyleBackColor = True
      '
      'btnInicio
      '
      Me.btnInicio.Enabled = False
      Me.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnInicio.Location = New System.Drawing.Point(5, 4)
      Me.btnInicio.Name = "btnInicio"
      Me.btnInicio.Size = New System.Drawing.Size(37, 23)
      Me.btnInicio.TabIndex = 71
      Me.btnInicio.Text = "<<"
      Me.btnInicio.UseVisualStyleBackColor = True
      '
      'btnHaciaAdelante
      '
      Me.btnHaciaAdelante.Enabled = False
      Me.btnHaciaAdelante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAdelante.Location = New System.Drawing.Point(184, 4)
      Me.btnHaciaAdelante.Name = "btnHaciaAdelante"
      Me.btnHaciaAdelante.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAdelante.TabIndex = 73
      Me.btnHaciaAdelante.Text = ">"
      Me.btnHaciaAdelante.UseVisualStyleBackColor = True
      '
      'btnHaciaAtras
      '
      Me.btnHaciaAtras.Enabled = False
      Me.btnHaciaAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnHaciaAtras.Location = New System.Drawing.Point(48, 4)
      Me.btnHaciaAtras.Name = "btnHaciaAtras"
      Me.btnHaciaAtras.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAtras.TabIndex = 72
      Me.btnHaciaAtras.Text = "<"
      Me.btnHaciaAtras.UseVisualStyleBackColor = True
      '
      'lblCasoDeCaso
      '
      Me.lblCasoDeCaso.AutoSize = True
      Me.lblCasoDeCaso.Enabled = False
      Me.lblCasoDeCaso.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCasoDeCaso.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.lblCasoDeCaso.Location = New System.Drawing.Point(90, 8)
      Me.lblCasoDeCaso.Name = "lblCasoDeCaso"
      Me.lblCasoDeCaso.Size = New System.Drawing.Size(49, 15)
      Me.lblCasoDeCaso.TabIndex = 80
      Me.lblCasoDeCaso.Text = "Caso No."
      '
      'ofdSelArchivo
      '
      Me.ofdSelArchivo.Filter = "Archivos Excel(*.xls)|*.xls"
      Me.ofdSelArchivo.InitialDirectory = "C:\ELISA2010\Placa desde archivo"
      Me.ofdSelArchivo.Title = "Abrir archivo de datos"
      '
      'frmCapturaCasosDA
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(703, 552)
      Me.Controls.Add(Me.btnCapturaTerminada)
      Me.Controls.Add(Me.Panel5)
      Me.Controls.Add(Me.Label43)
      Me.Controls.Add(Me.dtpFechaElaboracion)
      Me.Controls.Add(Me.dgvPlacaLeida)
      Me.Controls.Add(Me.btnObtenerResultados)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.tbcDatosDelCaso)
      Me.Controls.Add(Me.btnLeerArchivoExistente)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmCapturaCasosDA"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.tbcDatosDelCaso.ResumeLayout(False)
      Me.tbpDatosDelCaso.ResumeLayout(False)
      Me.tbpDatosDelCaso.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbCNDesdeArchivo.ResumeLayout(False)
      Me.grbCNDesdeArchivo.PerformLayout()
      Me.grbCPDesdeArchivo.ResumeLayout(False)
      Me.grbCPDesdeArchivo.PerformLayout()
      Me.tbpInformacionCaso.ResumeLayout(False)
      Me.tbpInformacionCaso.PerformLayout()
      CType(Me.dgvPlacaLeida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel5.ResumeLayout(False)
      Me.Panel5.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnLeerArchivoExistente As System.Windows.Forms.Button
   Friend WithEvents tbcDatosDelCaso As System.Windows.Forms.TabControl
   Friend WithEvents tbpDatosDelCaso As System.Windows.Forms.TabPage
   Friend WithEvents tbpInformacionCaso As System.Windows.Forms.TabPage
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtPlacaDesdeArchivo As System.Windows.Forms.TextBox
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
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtCPDAValor3 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCPDAValor1 As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtNombreSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents lblNoCasos As System.Windows.Forms.Label
   Friend WithEvents txtNoDeCasos As System.Windows.Forms.TextBox
   Friend WithEvents lblLogTit2 As System.Windows.Forms.Label
   Friend WithEvents lblLogSPS As System.Windows.Forms.Label
   Friend WithEvents lblLogTit1 As System.Windows.Forms.Label
   Friend WithEvents lblIdAnalisis As System.Windows.Forms.Label
   Friend WithEvents Label43 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaElaboracion As System.Windows.Forms.DateTimePicker
   Friend WithEvents btnAceptaSubCasos As System.Windows.Forms.Button
   Friend WithEvents lblNoSubCaso As System.Windows.Forms.Label
   Friend WithEvents txtNoSubcasos As System.Windows.Forms.TextBox
   Friend WithEvents chkSubCasos As System.Windows.Forms.CheckBox
   Friend WithEvents txtMensajeSobreGrafica As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtDesdeLetra As System.Windows.Forms.TextBox
   Friend WithEvents txtDesdeValor As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaLetra As System.Windows.Forms.TextBox
   Friend WithEvents txtHastaValor As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents txtAnalisisSolicitado As System.Windows.Forms.TextBox
   Friend WithEvents Label33 As System.Windows.Forms.Label
   Friend WithEvents btnBuscaCaso As System.Windows.Forms.Button
   Friend WithEvents cmbNoCaso As System.Windows.Forms.ComboBox
   Friend WithEvents Label34 As System.Windows.Forms.Label
   Friend WithEvents Label35 As System.Windows.Forms.Label
   Friend WithEvents dgvPlacaLeida As System.Windows.Forms.DataGridView
   Friend WithEvents btnObtenerResultados As System.Windows.Forms.Button
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents btnCapturaTerminada As System.Windows.Forms.Button
   Friend WithEvents Panel5 As System.Windows.Forms.Panel
   Friend WithEvents btnGuardarSubcaso As System.Windows.Forms.Button
   Friend WithEvents btnNuevoSubcaso As System.Windows.Forms.Button
   Friend WithEvents btnGuardarEditado As System.Windows.Forms.Button
   Friend WithEvents btnInsertar As System.Windows.Forms.Button
   Friend WithEvents btnGuardar As System.Windows.Forms.Button
   Friend WithEvents btnEditar As System.Windows.Forms.Button
   Friend WithEvents btnFin As System.Windows.Forms.Button
   Friend WithEvents btnInicio As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAdelante As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAtras As System.Windows.Forms.Button
   Friend WithEvents lblCasoDeCaso As System.Windows.Forms.Label
   Friend WithEvents btnAceptarNoCasos As System.Windows.Forms.Button
   Friend WithEvents Label41 As System.Windows.Forms.Label
   Friend WithEvents txtNoControlesNegativos As System.Windows.Forms.TextBox
   Friend WithEvents lblNoControles As System.Windows.Forms.Label
   Friend WithEvents txtNoControlesPositivos As System.Windows.Forms.TextBox
   Friend WithEvents ofdSelArchivo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
End Class
