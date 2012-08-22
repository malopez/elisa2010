<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaDatos
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalidaDatos))
      Me.txtMediaGeometrica = New System.Windows.Forms.TextBox()
      Me.lblMediaGeometrica = New System.Windows.Forms.Label()
      Me.txtTotalDatosCalculados = New System.Windows.Forms.TextBox()
      Me.lblTotalDatosCalculados = New System.Windows.Forms.Label()
      Me.lblMediaPromedio = New System.Windows.Forms.Label()
      Me.txtMediaAritmetica2 = New System.Windows.Forms.TextBox()
      Me.lblCoefVariacionDNA = New System.Windows.Forms.Label()
      Me.txtCoefVariacion2 = New System.Windows.Forms.TextBox()
      Me.btnGuardaResultados = New System.Windows.Forms.Button()
      Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
      Me.lblSalidaDatos = New System.Windows.Forms.Label()
      Me.lblELISA = New System.Windows.Forms.Label()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.lblAnalisis = New System.Windows.Forms.Label()
      Me.txtInmunoEnsayo = New System.Windows.Forms.TextBox()
      Me.txtFechaElaboracion = New System.Windows.Forms.TextBox()
      Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.txtNoCaso = New System.Windows.Forms.TextBox()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.lblConsecutivo = New System.Windows.Forms.Label()
      Me.txtVarianza2 = New System.Windows.Forms.TextBox()
      Me.txtDesvEstandar2 = New System.Windows.Forms.TextBox()
      Me.Panel4 = New System.Windows.Forms.Panel()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.lblMensajeSobreGrafica = New System.Windows.Forms.Label()
      Me.lblNombreSobreGrafica = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.imagenGrafica = New System.Windows.Forms.PictureBox()
      Me.txtTitulosObtenidos = New System.Windows.Forms.TextBox()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.Panel3.SuspendLayout()
      Me.Panel4.SuspendLayout()
      CType(Me.imagenGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.BackColor = System.Drawing.Color.White
      Me.txtMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaGeometrica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(312, 23)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.ReadOnly = True
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(58, 21)
      Me.txtMediaGeometrica.TabIndex = 2
      Me.txtMediaGeometrica.TabStop = False
      Me.txtMediaGeometrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaGeometrica.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(293, 4)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(107, 15)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.BackColor = System.Drawing.Color.White
      Me.txtTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotalDatosCalculados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(63, 23)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.ReadOnly = True
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(58, 21)
      Me.txtTotalDatosCalculados.TabIndex = 11
      Me.txtTotalDatosCalculados.TabStop = False
      Me.txtTotalDatosCalculados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTotalDatosCalculados.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(50, 5)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(82, 15)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "No. de Sueros"
      '
      'lblMediaPromedio
      '
      Me.lblMediaPromedio.AutoSize = True
      Me.lblMediaPromedio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaPromedio.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.lblMediaPromedio.Location = New System.Drawing.Point(162, 4)
      Me.lblMediaPromedio.Name = "lblMediaPromedio"
      Me.lblMediaPromedio.Size = New System.Drawing.Size(98, 15)
      Me.lblMediaPromedio.TabIndex = 14
      Me.lblMediaPromedio.Text = "Media Aritmética"
      '
      'txtMediaAritmetica2
      '
      Me.txtMediaAritmetica2.BackColor = System.Drawing.Color.White
      Me.txtMediaAritmetica2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaAritmetica2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(177, 23)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.ReadOnly = True
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(58, 21)
      Me.txtMediaAritmetica2.TabIndex = 13
      Me.txtMediaAritmetica2.TabStop = False
      Me.txtMediaAritmetica2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblCoefVariacionDNA
      '
      Me.lblCoefVariacionDNA.AutoSize = True
      Me.lblCoefVariacionDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCoefVariacionDNA.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.lblCoefVariacionDNA.Location = New System.Drawing.Point(435, 4)
      Me.lblCoefVariacionDNA.Name = "lblCoefVariacionDNA"
      Me.lblCoefVariacionDNA.Size = New System.Drawing.Size(63, 15)
      Me.lblCoefVariacionDNA.TabIndex = 18
      Me.lblCoefVariacionDNA.Text = "Coef.  Var."
      '
      'txtCoefVariacion2
      '
      Me.txtCoefVariacion2.BackColor = System.Drawing.Color.White
      Me.txtCoefVariacion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCoefVariacion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtCoefVariacion2.Location = New System.Drawing.Point(438, 23)
      Me.txtCoefVariacion2.Name = "txtCoefVariacion2"
      Me.txtCoefVariacion2.ReadOnly = True
      Me.txtCoefVariacion2.Size = New System.Drawing.Size(58, 21)
      Me.txtCoefVariacion2.TabIndex = 16
      Me.txtCoefVariacion2.TabStop = False
      Me.txtCoefVariacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'btnGuardaResultados
      '
      Me.btnGuardaResultados.Location = New System.Drawing.Point(360, 481)
      Me.btnGuardaResultados.Name = "btnGuardaResultados"
      Me.btnGuardaResultados.Size = New System.Drawing.Size(121, 23)
      Me.btnGuardaResultados.TabIndex = 0
      Me.btnGuardaResultados.Text = "Guardar Resultados"
      Me.btnGuardaResultados.UseVisualStyleBackColor = True
      '
      'HScrollBar1
      '
      Me.HScrollBar1.Location = New System.Drawing.Point(9, 727)
      Me.HScrollBar1.Name = "HScrollBar1"
      Me.HScrollBar1.Size = New System.Drawing.Size(999, 11)
      Me.HScrollBar1.TabIndex = 42
      '
      'lblSalidaDatos
      '
      Me.lblSalidaDatos.AutoSize = True
      Me.lblSalidaDatos.BackColor = System.Drawing.SystemColors.Window
      Me.lblSalidaDatos.Location = New System.Drawing.Point(5, 7)
      Me.lblSalidaDatos.Name = "lblSalidaDatos"
      Me.lblSalidaDatos.Size = New System.Drawing.Size(50, 13)
      Me.lblSalidaDatos.TabIndex = 45
      Me.lblSalidaDatos.Text = "Mensaje:"
      '
      'lblELISA
      '
      Me.lblELISA.AutoSize = True
      Me.lblELISA.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblELISA.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.lblELISA.Location = New System.Drawing.Point(22, 68)
      Me.lblELISA.Name = "lblELISA"
      Me.lblELISA.Size = New System.Drawing.Size(44, 16)
      Me.lblELISA.TabIndex = 48
      Me.lblELISA.Text = "ELISA: "
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblObservaciones.Location = New System.Drawing.Point(440, 70)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(101, 17)
      Me.lblObservaciones.TabIndex = 51
      Me.lblObservaciones.Text = "Observaciones:"
      Me.lblObservaciones.Visible = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.Label1.Location = New System.Drawing.Point(22, 14)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 16)
      Me.Label1.TabIndex = 52
      Me.Label1.Text = "No.Caso:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.Label2.Location = New System.Drawing.Point(22, 41)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(52, 16)
      Me.Label2.TabIndex = 53
      Me.Label2.Text = "Cliente:"
      '
      'btnCancelar
      '
      Me.btnCancelar.Location = New System.Drawing.Point(486, 481)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
      Me.btnCancelar.TabIndex = 1
      Me.btnCancelar.Text = "Finalizar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
      Me.Label3.Location = New System.Drawing.Point(334, 14)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(113, 16)
      Me.Label3.TabIndex = 56
      Me.Label3.Text = "Fecha de Análisis:"
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.SystemColors.Window
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel1.Controls.Add(Me.lblSalidaDatos)
      Me.Panel1.Location = New System.Drawing.Point(9, 510)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(569, 32)
      Me.Panel1.TabIndex = 57
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.lblAnalisis)
      Me.Panel2.Controls.Add(Me.txtInmunoEnsayo)
      Me.Panel2.Controls.Add(Me.txtFechaElaboracion)
      Me.Panel2.Controls.Add(Me.txtNombreEnfermedad)
      Me.Panel2.Controls.Add(Me.txtNombreCliente)
      Me.Panel2.Controls.Add(Me.txtNoCaso)
      Me.Panel2.Controls.Add(Me.Label3)
      Me.Panel2.Controls.Add(Me.Label2)
      Me.Panel2.Controls.Add(Me.lblELISA)
      Me.Panel2.Controls.Add(Me.Label1)
      Me.Panel2.Controls.Add(Me.lblObservaciones)
      Me.Panel2.Location = New System.Drawing.Point(9, 8)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(568, 95)
      Me.Panel2.TabIndex = 58
      '
      'lblAnalisis
      '
      Me.lblAnalisis.AutoSize = True
      Me.lblAnalisis.Location = New System.Drawing.Point(237, 16)
      Me.lblAnalisis.Name = "lblAnalisis"
      Me.lblAnalisis.Size = New System.Drawing.Size(39, 13)
      Me.lblAnalisis.TabIndex = 62
      Me.lblAnalisis.Text = "Label4"
      Me.lblAnalisis.Visible = False
      '
      'txtInmunoEnsayo
      '
      Me.txtInmunoEnsayo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtInmunoEnsayo.Location = New System.Drawing.Point(92, 67)
      Me.txtInmunoEnsayo.Name = "txtInmunoEnsayo"
      Me.txtInmunoEnsayo.ReadOnly = True
      Me.txtInmunoEnsayo.Size = New System.Drawing.Size(167, 20)
      Me.txtInmunoEnsayo.TabIndex = 61
      Me.txtInmunoEnsayo.Text = "INMUNOENSAYO ENZIMATICO"
      '
      'txtFechaElaboracion
      '
      Me.txtFechaElaboracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtFechaElaboracion.Location = New System.Drawing.Point(448, 13)
      Me.txtFechaElaboracion.Name = "txtFechaElaboracion"
      Me.txtFechaElaboracion.ReadOnly = True
      Me.txtFechaElaboracion.Size = New System.Drawing.Size(93, 20)
      Me.txtFechaElaboracion.TabIndex = 60
      '
      'txtNombreEnfermedad
      '
      Me.txtNombreEnfermedad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNombreEnfermedad.Location = New System.Drawing.Point(264, 67)
      Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
      Me.txtNombreEnfermedad.ReadOnly = True
      Me.txtNombreEnfermedad.Size = New System.Drawing.Size(157, 20)
      Me.txtNombreEnfermedad.TabIndex = 59
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNombreCliente.Location = New System.Drawing.Point(92, 41)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 58
      '
      'txtNoCaso
      '
      Me.txtNoCaso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNoCaso.Location = New System.Drawing.Point(92, 13)
      Me.txtNoCaso.Name = "txtNoCaso"
      Me.txtNoCaso.ReadOnly = True
      Me.txtNoCaso.Size = New System.Drawing.Size(138, 20)
      Me.txtNoCaso.TabIndex = 57
      '
      'Panel3
      '
      Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel3.Controls.Add(Me.lblConsecutivo)
      Me.Panel3.Controls.Add(Me.txtVarianza2)
      Me.Panel3.Controls.Add(Me.txtDesvEstandar2)
      Me.Panel3.Controls.Add(Me.txtCoefVariacion2)
      Me.Panel3.Controls.Add(Me.lblCoefVariacionDNA)
      Me.Panel3.Controls.Add(Me.txtTotalDatosCalculados)
      Me.Panel3.Controls.Add(Me.lblMediaGeometrica)
      Me.Panel3.Controls.Add(Me.txtMediaGeometrica)
      Me.Panel3.Controls.Add(Me.lblMediaPromedio)
      Me.Panel3.Controls.Add(Me.txtMediaAritmetica2)
      Me.Panel3.Controls.Add(Me.lblTotalDatosCalculados)
      Me.Panel3.Location = New System.Drawing.Point(9, 111)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(569, 55)
      Me.Panel3.TabIndex = 59
      '
      'lblConsecutivo
      '
      Me.lblConsecutivo.AutoSize = True
      Me.lblConsecutivo.Location = New System.Drawing.Point(241, 27)
      Me.lblConsecutivo.Name = "lblConsecutivo"
      Me.lblConsecutivo.Size = New System.Drawing.Size(65, 13)
      Me.lblConsecutivo.TabIndex = 64
      Me.lblConsecutivo.Text = "consecutivo"
      '
      'txtVarianza2
      '
      Me.txtVarianza2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtVarianza2.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.txtVarianza2.Location = New System.Drawing.Point(8, 23)
      Me.txtVarianza2.Name = "txtVarianza2"
      Me.txtVarianza2.ReadOnly = True
      Me.txtVarianza2.Size = New System.Drawing.Size(34, 21)
      Me.txtVarianza2.TabIndex = 51
      Me.txtVarianza2.TabStop = False
      Me.txtVarianza2.Visible = False
      '
      'txtDesvEstandar2
      '
      Me.txtDesvEstandar2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDesvEstandar2.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.txtDesvEstandar2.Location = New System.Drawing.Point(523, 23)
      Me.txtDesvEstandar2.Name = "txtDesvEstandar2"
      Me.txtDesvEstandar2.ReadOnly = True
      Me.txtDesvEstandar2.Size = New System.Drawing.Size(34, 21)
      Me.txtDesvEstandar2.TabIndex = 50
      Me.txtDesvEstandar2.TabStop = False
      Me.txtDesvEstandar2.Visible = False
      '
      'Panel4
      '
      Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel4.Controls.Add(Me.Label6)
      Me.Panel4.Controls.Add(Me.Label5)
      Me.Panel4.Controls.Add(Me.lblMensajeSobreGrafica)
      Me.Panel4.Controls.Add(Me.lblNombreSobreGrafica)
      Me.Panel4.Controls.Add(Me.Label4)
      Me.Panel4.Controls.Add(Me.imagenGrafica)
      Me.Panel4.Controls.Add(Me.txtTitulosObtenidos)
      Me.Panel4.Location = New System.Drawing.Point(9, 172)
      Me.Panel4.Name = "Panel4"
      Me.Panel4.Size = New System.Drawing.Size(569, 303)
      Me.Panel4.TabIndex = 62
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(5, 278)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(82, 16)
      Me.Label6.TabIndex = 67
      Me.Label6.Text = "Enfermedad:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(317, 278)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(43, 16)
      Me.Label5.TabIndex = 66
      Me.Label5.Text = "Texto:"
      '
      'lblMensajeSobreGrafica
      '
      Me.lblMensajeSobreGrafica.AutoSize = True
      Me.lblMensajeSobreGrafica.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.lblMensajeSobreGrafica.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMensajeSobreGrafica.ForeColor = System.Drawing.Color.Black
      Me.lblMensajeSobreGrafica.Location = New System.Drawing.Point(366, 278)
      Me.lblMensajeSobreGrafica.Name = "lblMensajeSobreGrafica"
      Me.lblMensajeSobreGrafica.Size = New System.Drawing.Size(0, 16)
      Me.lblMensajeSobreGrafica.TabIndex = 65
      '
      'lblNombreSobreGrafica
      '
      Me.lblNombreSobreGrafica.AutoSize = True
      Me.lblNombreSobreGrafica.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.lblNombreSobreGrafica.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreSobreGrafica.ForeColor = System.Drawing.Color.Black
      Me.lblNombreSobreGrafica.Location = New System.Drawing.Point(89, 278)
      Me.lblNombreSobreGrafica.Name = "lblNombreSobreGrafica"
      Me.lblNombreSobreGrafica.Size = New System.Drawing.Size(0, 16)
      Me.lblNombreSobreGrafica.TabIndex = 64
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
      Me.Label4.Location = New System.Drawing.Point(430, 17)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(122, 16)
      Me.Label4.TabIndex = 63
      Me.Label4.Text = "TITULOS OBTENIDOS"
      '
      'imagenGrafica
      '
      Me.imagenGrafica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.imagenGrafica.Location = New System.Drawing.Point(8, 4)
      Me.imagenGrafica.Name = "imagenGrafica"
      Me.imagenGrafica.Size = New System.Drawing.Size(401, 267)
      Me.imagenGrafica.TabIndex = 62
      Me.imagenGrafica.TabStop = False
      '
      'txtTitulosObtenidos
      '
      Me.txtTitulosObtenidos.BackColor = System.Drawing.Color.White
      Me.txtTitulosObtenidos.ForeColor = System.Drawing.Color.MidnightBlue
      Me.txtTitulosObtenidos.Location = New System.Drawing.Point(440, 35)
      Me.txtTitulosObtenidos.Multiline = True
      Me.txtTitulosObtenidos.Name = "txtTitulosObtenidos"
      Me.txtTitulosObtenidos.ReadOnly = True
      Me.txtTitulosObtenidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtTitulosObtenidos.Size = New System.Drawing.Size(105, 227)
      Me.txtTitulosObtenidos.TabIndex = 61
      Me.txtTitulosObtenidos.TabStop = False
      '
      'frmSalidaDatos
      '
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.BackColor = System.Drawing.SystemColors.Control
      Me.ClientSize = New System.Drawing.Size(586, 547)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.HScrollBar1)
      Me.Controls.Add(Me.btnGuardaResultados)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel3)
      Me.Controls.Add(Me.Panel4)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmSalidaDatos"
      Me.Text = "Resultado del Análisis Caso No. 1"
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      Me.Panel4.ResumeLayout(False)
      Me.Panel4.PerformLayout()
      CType(Me.imagenGrafica, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents txtMediaGeometrica As System.Windows.Forms.TextBox
   Friend WithEvents lblMediaGeometrica As System.Windows.Forms.Label
   Friend WithEvents txtTotalDatosCalculados As System.Windows.Forms.TextBox
   Friend WithEvents lblTotalDatosCalculados As System.Windows.Forms.Label
   Friend WithEvents lblMediaPromedio As System.Windows.Forms.Label
   Friend WithEvents txtMediaAritmetica2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCoefVariacionDNA As System.Windows.Forms.Label
   Friend WithEvents txtCoefVariacion2 As System.Windows.Forms.TextBox
   Friend WithEvents btnGuardaResultados As System.Windows.Forms.Button
   Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
   Friend WithEvents lblSalidaDatos As System.Windows.Forms.Label
   Friend WithEvents lblELISA As System.Windows.Forms.Label
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents txtFechaElaboracion As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreEnfermedad As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents txtNoCaso As System.Windows.Forms.TextBox
   Friend WithEvents txtInmunoEnsayo As System.Windows.Forms.TextBox
   Friend WithEvents lblAnalisis As System.Windows.Forms.Label
   Friend WithEvents txtVarianza2 As System.Windows.Forms.TextBox
   Friend WithEvents txtDesvEstandar2 As System.Windows.Forms.TextBox
   Friend WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents imagenGrafica As System.Windows.Forms.PictureBox
   Friend WithEvents txtTitulosObtenidos As System.Windows.Forms.TextBox
   Friend WithEvents lblMensajeSobreGrafica As System.Windows.Forms.Label
   Friend WithEvents lblNombreSobreGrafica As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents lblConsecutivo As System.Windows.Forms.Label
End Class
