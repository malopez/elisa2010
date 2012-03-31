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
      Me.btnCalculaResultados = New System.Windows.Forms.Button()
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
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'btnCalculaResultados
      '
      Me.btnCalculaResultados.Location = New System.Drawing.Point(585, 290)
      Me.btnCalculaResultados.Name = "btnCalculaResultados"
      Me.btnCalculaResultados.Size = New System.Drawing.Size(75, 23)
      Me.btnCalculaResultados.TabIndex = 0
      Me.btnCalculaResultados.Text = "Calcular Datos"
      Me.btnCalculaResultados.UseVisualStyleBackColor = True
      '
      'txtMediaAritmetica
      '
      Me.txtMediaAritmetica.Location = New System.Drawing.Point(34, 98)
      Me.txtMediaAritmetica.Name = "txtMediaAritmetica"
      Me.txtMediaAritmetica.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaAritmetica.TabIndex = 1
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(560, 101)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaGeometrica.TabIndex = 2
      '
      'txtCoefVariacion
      '
      Me.txtCoefVariacion.Location = New System.Drawing.Point(414, 101)
      Me.txtCoefVariacion.Name = "txtCoefVariacion"
      Me.txtCoefVariacion.Size = New System.Drawing.Size(100, 20)
      Me.txtCoefVariacion.TabIndex = 3
      '
      'lbMediaAritmetica
      '
      Me.lbMediaAritmetica.AutoSize = True
      Me.lbMediaAritmetica.Location = New System.Drawing.Point(34, 79)
      Me.lbMediaAritmetica.Name = "lbMediaAritmetica"
      Me.lbMediaAritmetica.Size = New System.Drawing.Size(84, 13)
      Me.lbMediaAritmetica.TabIndex = 4
      Me.lbMediaAritmetica.Text = "Media aritmetica"
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(560, 82)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(93, 13)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'lblCoefVariacion
      '
      Me.lblCoefVariacion.AutoSize = True
      Me.lblCoefVariacion.Location = New System.Drawing.Point(415, 82)
      Me.lblCoefVariacion.Name = "lblCoefVariacion"
      Me.lblCoefVariacion.Size = New System.Drawing.Size(122, 13)
      Me.lblCoefVariacion.TabIndex = 6
      Me.lblCoefVariacion.Text = "Coeficiente de Variacion"
      '
      'lblDesvEstandar
      '
      Me.lblDesvEstandar.AutoSize = True
      Me.lblDesvEstandar.Location = New System.Drawing.Point(279, 82)
      Me.lblDesvEstandar.Name = "lblDesvEstandar"
      Me.lblDesvEstandar.Size = New System.Drawing.Size(105, 13)
      Me.lblDesvEstandar.TabIndex = 10
      Me.lblDesvEstandar.Text = "Desviacion Estandar"
      '
      'lblVarianza
      '
      Me.lblVarianza.AutoSize = True
      Me.lblVarianza.Location = New System.Drawing.Point(166, 79)
      Me.lblVarianza.Name = "lblVarianza"
      Me.lblVarianza.Size = New System.Drawing.Size(48, 13)
      Me.lblVarianza.TabIndex = 9
      Me.lblVarianza.Text = "Varianza"
      '
      'txtDesvEstandar
      '
      Me.txtDesvEstandar.Location = New System.Drawing.Point(284, 98)
      Me.txtDesvEstandar.Name = "txtDesvEstandar"
      Me.txtDesvEstandar.Size = New System.Drawing.Size(100, 20)
      Me.txtDesvEstandar.TabIndex = 8
      '
      'txtVarianza
      '
      Me.txtVarianza.Location = New System.Drawing.Point(166, 98)
      Me.txtVarianza.Name = "txtVarianza"
      Me.txtVarianza.Size = New System.Drawing.Size(100, 20)
      Me.txtVarianza.TabIndex = 7
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(31, 309)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(100, 20)
      Me.txtTotalDatosCalculados.TabIndex = 11
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(28, 290)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(129, 13)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "Total de datos calculados"
      '
      'lblMediaPromedio
      '
      Me.lblMediaPromedio.AutoSize = True
      Me.lblMediaPromedio.Location = New System.Drawing.Point(34, 198)
      Me.lblMediaPromedio.Name = "lblMediaPromedio"
      Me.lblMediaPromedio.Size = New System.Drawing.Size(100, 13)
      Me.lblMediaPromedio.TabIndex = 14
      Me.lblMediaPromedio.Text = "Media por promedio"
      '
      'txtMediaAritmetica2
      '
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(34, 217)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaAritmetica2.TabIndex = 13
      '
      'lbDesviacionEstandarDNA
      '
      Me.lbDesviacionEstandarDNA.AutoSize = True
      Me.lbDesviacionEstandarDNA.Location = New System.Drawing.Point(276, 198)
      Me.lbDesviacionEstandarDNA.Name = "lbDesviacionEstandarDNA"
      Me.lbDesviacionEstandarDNA.Size = New System.Drawing.Size(105, 13)
      Me.lbDesviacionEstandarDNA.TabIndex = 22
      Me.lbDesviacionEstandarDNA.Text = "Desviacion Estandar"
      '
      'lblVarianzaDNA
      '
      Me.lblVarianzaDNA.AutoSize = True
      Me.lblVarianzaDNA.Location = New System.Drawing.Point(163, 195)
      Me.lblVarianzaDNA.Name = "lblVarianzaDNA"
      Me.lblVarianzaDNA.Size = New System.Drawing.Size(48, 13)
      Me.lblVarianzaDNA.TabIndex = 21
      Me.lblVarianzaDNA.Text = "Varianza"
      '
      'txtDesvEstandar2
      '
      Me.txtDesvEstandar2.Location = New System.Drawing.Point(281, 214)
      Me.txtDesvEstandar2.Name = "txtDesvEstandar2"
      Me.txtDesvEstandar2.Size = New System.Drawing.Size(100, 20)
      Me.txtDesvEstandar2.TabIndex = 20
      '
      'txtVarianza2
      '
      Me.txtVarianza2.Location = New System.Drawing.Point(163, 214)
      Me.txtVarianza2.Name = "txtVarianza2"
      Me.txtVarianza2.Size = New System.Drawing.Size(100, 20)
      Me.txtVarianza2.TabIndex = 19
      '
      'lblCoefVariacionDNA
      '
      Me.lblCoefVariacionDNA.AutoSize = True
      Me.lblCoefVariacionDNA.Location = New System.Drawing.Point(412, 198)
      Me.lblCoefVariacionDNA.Name = "lblCoefVariacionDNA"
      Me.lblCoefVariacionDNA.Size = New System.Drawing.Size(122, 13)
      Me.lblCoefVariacionDNA.TabIndex = 18
      Me.lblCoefVariacionDNA.Text = "Coeficiente de Variacion"
      '
      'txtCoefVariacion2
      '
      Me.txtCoefVariacion2.Location = New System.Drawing.Point(411, 217)
      Me.txtCoefVariacion2.Name = "txtCoefVariacion2"
      Me.txtCoefVariacion2.Size = New System.Drawing.Size(100, 20)
      Me.txtCoefVariacion2.TabIndex = 16
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(28, 152)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(136, 13)
      Me.Label6.TabIndex = 23
      Me.Label6.Text = "Sin utilizar datos agrupados"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(28, 28)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(178, 13)
      Me.Label7.TabIndex = 24
      Me.Label7.Text = "Usando calculo de datos agrupados"
      '
      'frmSalidaDatos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(859, 394)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.Label6)
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
      Me.Controls.Add(Me.btnCalculaResultados)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Name = "frmSalidaDatos"
      Me.Text = "fmbSalidaDatos"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnCalculaResultados As System.Windows.Forms.Button
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
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
