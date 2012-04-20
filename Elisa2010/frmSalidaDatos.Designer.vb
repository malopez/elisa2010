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
      Me.txtMediaAritmetica = New System.Windows.Forms.TextBox()
      Me.txtMediaGeometrica = New System.Windows.Forms.TextBox()
      Me.txtCoefVariacion = New System.Windows.Forms.TextBox()
      Me.lbMediaAritmetica = New System.Windows.Forms.Label()
      Me.lblMediaGeometrica = New System.Windows.Forms.Label()
      Me.lblCoefVariacion = New System.Windows.Forms.Label()
      Me.lblDesvEstandar = New System.Windows.Forms.Label()
      Me.lblVarianza = New System.Windows.Forms.Label()
      Me.txtDesvEstandar = New System.Windows.Forms.TextBox()
      Me.txtVarianza = New System.Windows.Forms.TextBox()
      Me.txtTotalDatosCalculados = New System.Windows.Forms.TextBox()
      Me.lblTotalDatosCalculados = New System.Windows.Forms.Label()
      Me.lblMediaPromedio = New System.Windows.Forms.Label()
      Me.txtMediaAritmetica2 = New System.Windows.Forms.TextBox()
      Me.lbDesviacionEstandarDNA = New System.Windows.Forms.Label()
      Me.lblVarianzaDNA = New System.Windows.Forms.Label()
      Me.txtDesvEstandar2 = New System.Windows.Forms.TextBox()
      Me.txtVarianza2 = New System.Windows.Forms.TextBox()
      Me.lblCoefVariacionDNA = New System.Windows.Forms.Label()
      Me.txtCoefVariacion2 = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtCalPlacaLector = New System.Windows.Forms.TextBox()
      Me.txtCalSPS = New System.Windows.Forms.TextBox()
      Me.txtCalLogSPS = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtCalLogTit = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtCalColL = New System.Windows.Forms.TextBox()
      Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
      Me.SuspendLayout()
      '
      'txtMediaAritmetica
      '
      Me.txtMediaAritmetica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaAritmetica.Location = New System.Drawing.Point(34, 98)
      Me.txtMediaAritmetica.Name = "txtMediaAritmetica"
      Me.txtMediaAritmetica.ReadOnly = True
      Me.txtMediaAritmetica.Size = New System.Drawing.Size(115, 21)
      Me.txtMediaAritmetica.TabIndex = 1
      Me.txtMediaAritmetica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(34, 465)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.ReadOnly = True
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(115, 21)
      Me.txtMediaGeometrica.TabIndex = 2
      '
      'txtCoefVariacion
      '
      Me.txtCoefVariacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCoefVariacion.Location = New System.Drawing.Point(163, 175)
      Me.txtCoefVariacion.Name = "txtCoefVariacion"
      Me.txtCoefVariacion.ReadOnly = True
      Me.txtCoefVariacion.Size = New System.Drawing.Size(122, 21)
      Me.txtCoefVariacion.TabIndex = 3
      Me.txtCoefVariacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'lbMediaAritmetica
      '
      Me.lbMediaAritmetica.AutoSize = True
      Me.lbMediaAritmetica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbMediaAritmetica.Location = New System.Drawing.Point(31, 68)
      Me.lbMediaAritmetica.Name = "lbMediaAritmetica"
      Me.lbMediaAritmetica.Size = New System.Drawing.Size(102, 16)
      Me.lbMediaAritmetica.TabIndex = 4
      Me.lbMediaAritmetica.Text = "Media aritmetica"
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(34, 427)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(112, 16)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'lblCoefVariacion
      '
      Me.lblCoefVariacion.AutoSize = True
      Me.lblCoefVariacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCoefVariacion.Location = New System.Drawing.Point(160, 145)
      Me.lblCoefVariacion.Name = "lblCoefVariacion"
      Me.lblCoefVariacion.Size = New System.Drawing.Size(142, 16)
      Me.lblCoefVariacion.TabIndex = 6
      Me.lblCoefVariacion.Text = "Coeficiente de Variacion"
      '
      'lblDesvEstandar
      '
      Me.lblDesvEstandar.AutoSize = True
      Me.lblDesvEstandar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDesvEstandar.Location = New System.Drawing.Point(30, 145)
      Me.lblDesvEstandar.Name = "lblDesvEstandar"
      Me.lblDesvEstandar.Size = New System.Drawing.Size(119, 16)
      Me.lblDesvEstandar.TabIndex = 10
      Me.lblDesvEstandar.Text = "Desviacion Estandar"
      '
      'lblVarianza
      '
      Me.lblVarianza.AutoSize = True
      Me.lblVarianza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblVarianza.Location = New System.Drawing.Point(197, 68)
      Me.lblVarianza.Name = "lblVarianza"
      Me.lblVarianza.Size = New System.Drawing.Size(56, 16)
      Me.lblVarianza.TabIndex = 9
      Me.lblVarianza.Text = "Varianza"
      '
      'txtDesvEstandar
      '
      Me.txtDesvEstandar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDesvEstandar.Location = New System.Drawing.Point(33, 175)
      Me.txtDesvEstandar.Name = "txtDesvEstandar"
      Me.txtDesvEstandar.ReadOnly = True
      Me.txtDesvEstandar.Size = New System.Drawing.Size(116, 21)
      Me.txtDesvEstandar.TabIndex = 8
      Me.txtDesvEstandar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtVarianza
      '
      Me.txtVarianza.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtVarianza.Location = New System.Drawing.Point(163, 98)
      Me.txtVarianza.Name = "txtVarianza"
      Me.txtVarianza.ReadOnly = True
      Me.txtVarianza.Size = New System.Drawing.Size(123, 21)
      Me.txtVarianza.TabIndex = 7
      Me.txtVarianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(163, 465)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.ReadOnly = True
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(122, 21)
      Me.txtTotalDatosCalculados.TabIndex = 11
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(155, 427)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(149, 16)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "Total de datos calculados"
      '
      'lblMediaPromedio
      '
      Me.lblMediaPromedio.AutoSize = True
      Me.lblMediaPromedio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaPromedio.Location = New System.Drawing.Point(29, 275)
      Me.lblMediaPromedio.Name = "lblMediaPromedio"
      Me.lblMediaPromedio.Size = New System.Drawing.Size(120, 16)
      Me.lblMediaPromedio.TabIndex = 14
      Me.lblMediaPromedio.Text = "Media por promedio"
      '
      'txtMediaAritmetica2
      '
      Me.txtMediaAritmetica2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(33, 303)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.ReadOnly = True
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(116, 21)
      Me.txtMediaAritmetica2.TabIndex = 13
      '
      'lbDesviacionEstandarDNA
      '
      Me.lbDesviacionEstandarDNA.AutoSize = True
      Me.lbDesviacionEstandarDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbDesviacionEstandarDNA.Location = New System.Drawing.Point(31, 344)
      Me.lbDesviacionEstandarDNA.Name = "lbDesviacionEstandarDNA"
      Me.lbDesviacionEstandarDNA.Size = New System.Drawing.Size(119, 16)
      Me.lbDesviacionEstandarDNA.TabIndex = 22
      Me.lbDesviacionEstandarDNA.Text = "Desviacion Estandar"
      '
      'lblVarianzaDNA
      '
      Me.lblVarianzaDNA.AutoSize = True
      Me.lblVarianzaDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblVarianzaDNA.Location = New System.Drawing.Point(188, 272)
      Me.lblVarianzaDNA.Name = "lblVarianzaDNA"
      Me.lblVarianzaDNA.Size = New System.Drawing.Size(56, 16)
      Me.lblVarianzaDNA.TabIndex = 21
      Me.lblVarianzaDNA.Text = "Varianza"
      '
      'txtDesvEstandar2
      '
      Me.txtDesvEstandar2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDesvEstandar2.Location = New System.Drawing.Point(34, 372)
      Me.txtDesvEstandar2.Name = "txtDesvEstandar2"
      Me.txtDesvEstandar2.ReadOnly = True
      Me.txtDesvEstandar2.Size = New System.Drawing.Size(115, 21)
      Me.txtDesvEstandar2.TabIndex = 20
      '
      'txtVarianza2
      '
      Me.txtVarianza2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtVarianza2.Location = New System.Drawing.Point(163, 303)
      Me.txtVarianza2.Name = "txtVarianza2"
      Me.txtVarianza2.ReadOnly = True
      Me.txtVarianza2.Size = New System.Drawing.Size(123, 21)
      Me.txtVarianza2.TabIndex = 19
      '
      'lblCoefVariacionDNA
      '
      Me.lblCoefVariacionDNA.AutoSize = True
      Me.lblCoefVariacionDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCoefVariacionDNA.Location = New System.Drawing.Point(162, 344)
      Me.lblCoefVariacionDNA.Name = "lblCoefVariacionDNA"
      Me.lblCoefVariacionDNA.Size = New System.Drawing.Size(142, 16)
      Me.lblCoefVariacionDNA.TabIndex = 18
      Me.lblCoefVariacionDNA.Text = "Coeficiente de Variacion"
      '
      'txtCoefVariacion2
      '
      Me.txtCoefVariacion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCoefVariacion2.Location = New System.Drawing.Point(163, 372)
      Me.txtCoefVariacion2.Name = "txtCoefVariacion2"
      Me.txtCoefVariacion2.ReadOnly = True
      Me.txtCoefVariacion2.Size = New System.Drawing.Size(123, 21)
      Me.txtCoefVariacion2.TabIndex = 16
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(12, 25)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(280, 18)
      Me.Label7.TabIndex = 24
      Me.Label7.Text = "Usando calculo de datos agrupados"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(12, 226)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(303, 18)
      Me.Label1.TabIndex = 25
      Me.Label1.Text = "Usando calculo de datos no agrupados"
      '
      'txtCalPlacaLector
      '
      Me.txtCalPlacaLector.BackColor = System.Drawing.Color.White
      Me.txtCalPlacaLector.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCalPlacaLector.Location = New System.Drawing.Point(321, 25)
      Me.txtCalPlacaLector.Multiline = True
      Me.txtCalPlacaLector.Name = "txtCalPlacaLector"
      Me.txtCalPlacaLector.ReadOnly = True
      Me.txtCalPlacaLector.Size = New System.Drawing.Size(676, 124)
      Me.txtCalPlacaLector.TabIndex = 26
      '
      'txtCalSPS
      '
      Me.txtCalSPS.BackColor = System.Drawing.Color.White
      Me.txtCalSPS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCalSPS.Location = New System.Drawing.Point(324, 172)
      Me.txtCalSPS.Multiline = True
      Me.txtCalSPS.Name = "txtCalSPS"
      Me.txtCalSPS.ReadOnly = True
      Me.txtCalSPS.Size = New System.Drawing.Size(673, 116)
      Me.txtCalSPS.TabIndex = 28
      '
      'txtCalLogSPS
      '
      Me.txtCalLogSPS.BackColor = System.Drawing.Color.White
      Me.txtCalLogSPS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCalLogSPS.Location = New System.Drawing.Point(321, 307)
      Me.txtCalLogSPS.Multiline = True
      Me.txtCalLogSPS.Name = "txtCalLogSPS"
      Me.txtCalLogSPS.ReadOnly = True
      Me.txtCalLogSPS.Size = New System.Drawing.Size(673, 126)
      Me.txtCalLogSPS.TabIndex = 29
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(318, 9)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(103, 13)
      Me.Label2.TabIndex = 30
      Me.Label2.Text = "Placa Lector original"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(318, 152)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(60, 13)
      Me.Label3.TabIndex = 31
      Me.Label3.Text = "calcula sps"
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(37, 526)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(121, 23)
      Me.Button1.TabIndex = 36
      Me.Button1.Text = "Guardar Resultados"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(320, 291)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(73, 13)
      Me.Label4.TabIndex = 37
      Me.Label4.Text = "logaritmos sps"
      '
      'txtCalLogTit
      '
      Me.txtCalLogTit.BackColor = System.Drawing.Color.White
      Me.txtCalLogTit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCalLogTit.Location = New System.Drawing.Point(321, 452)
      Me.txtCalLogTit.Multiline = True
      Me.txtCalLogTit.Name = "txtCalLogTit"
      Me.txtCalLogTit.ReadOnly = True
      Me.txtCalLogTit.Size = New System.Drawing.Size(673, 126)
      Me.txtCalLogTit.TabIndex = 38
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(321, 436)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(84, 13)
      Me.Label5.TabIndex = 39
      Me.Label5.Text = "logaritmos titulos"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(321, 582)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(75, 13)
      Me.Label6.TabIndex = 41
      Me.Label6.Text = "Cal Columna L"
      '
      'txtCalColL
      '
      Me.txtCalColL.BackColor = System.Drawing.Color.White
      Me.txtCalColL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCalColL.Location = New System.Drawing.Point(321, 598)
      Me.txtCalColL.Multiline = True
      Me.txtCalColL.Name = "txtCalColL"
      Me.txtCalColL.ReadOnly = True
      Me.txtCalColL.Size = New System.Drawing.Size(673, 126)
      Me.txtCalColL.TabIndex = 40
      '
      'HScrollBar1
      '
      Me.HScrollBar1.Location = New System.Drawing.Point(9, 727)
      Me.HScrollBar1.Name = "HScrollBar1"
      Me.HScrollBar1.Size = New System.Drawing.Size(999, 11)
      Me.HScrollBar1.TabIndex = 42
      '
      'frmSalidaDatos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoScroll = True
      Me.AutoSize = True
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(1023, 737)
      Me.Controls.Add(Me.HScrollBar1)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.txtCalColL)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.txtCalLogTit)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtCalLogSPS)
      Me.Controls.Add(Me.txtCalSPS)
      Me.Controls.Add(Me.txtCalPlacaLector)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.lbDesviacionEstandarDNA)
      Me.Controls.Add(Me.lblVarianzaDNA)
      Me.Controls.Add(Me.txtDesvEstandar2)
      Me.Controls.Add(Me.txtVarianza2)
      Me.Controls.Add(Me.lblCoefVariacionDNA)
      Me.Controls.Add(Me.txtCoefVariacion2)
      Me.Controls.Add(Me.lblMediaPromedio)
      Me.Controls.Add(Me.txtMediaAritmetica2)
      Me.Controls.Add(Me.lblTotalDatosCalculados)
      Me.Controls.Add(Me.txtTotalDatosCalculados)
      Me.Controls.Add(Me.lblDesvEstandar)
      Me.Controls.Add(Me.lblVarianza)
      Me.Controls.Add(Me.txtDesvEstandar)
      Me.Controls.Add(Me.txtVarianza)
      Me.Controls.Add(Me.lblCoefVariacion)
      Me.Controls.Add(Me.lblMediaGeometrica)
      Me.Controls.Add(Me.lbMediaAritmetica)
      Me.Controls.Add(Me.txtCoefVariacion)
      Me.Controls.Add(Me.txtMediaGeometrica)
      Me.Controls.Add(Me.txtMediaAritmetica)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmSalidaDatos"
      Me.Text = "Resultados del análisis"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtMediaAritmetica As System.Windows.Forms.TextBox
   Friend WithEvents txtMediaGeometrica As System.Windows.Forms.TextBox
   Friend WithEvents txtCoefVariacion As System.Windows.Forms.TextBox
   Friend WithEvents lbMediaAritmetica As System.Windows.Forms.Label
   Friend WithEvents lblMediaGeometrica As System.Windows.Forms.Label
   Friend WithEvents lblCoefVariacion As System.Windows.Forms.Label
   Friend WithEvents lblDesvEstandar As System.Windows.Forms.Label
   Friend WithEvents lblVarianza As System.Windows.Forms.Label
   Friend WithEvents txtDesvEstandar As System.Windows.Forms.TextBox
   Friend WithEvents txtVarianza As System.Windows.Forms.TextBox
   Friend WithEvents txtTotalDatosCalculados As System.Windows.Forms.TextBox
   Friend WithEvents lblTotalDatosCalculados As System.Windows.Forms.Label
   Friend WithEvents lblMediaPromedio As System.Windows.Forms.Label
   Friend WithEvents txtMediaAritmetica2 As System.Windows.Forms.TextBox
   Friend WithEvents lbDesviacionEstandarDNA As System.Windows.Forms.Label
   Friend WithEvents lblVarianzaDNA As System.Windows.Forms.Label
   Friend WithEvents txtDesvEstandar2 As System.Windows.Forms.TextBox
   Friend WithEvents txtVarianza2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCoefVariacionDNA As System.Windows.Forms.Label
   Friend WithEvents txtCoefVariacion2 As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCalPlacaLector As System.Windows.Forms.TextBox
   Friend WithEvents txtCalSPS As System.Windows.Forms.TextBox
   Friend WithEvents txtCalLogSPS As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtCalLogTit As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtCalColL As System.Windows.Forms.TextBox
   Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
End Class
