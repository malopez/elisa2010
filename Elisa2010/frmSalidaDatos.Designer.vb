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
      Me.lbDesviacionEstandarDNA = New System.Windows.Forms.Label()
      Me.lblVarianzaDNA = New System.Windows.Forms.Label()
      Me.txtDesvEstandar2 = New System.Windows.Forms.TextBox()
      Me.txtVarianza2 = New System.Windows.Forms.TextBox()
      Me.lblCoefVariacionDNA = New System.Windows.Forms.Label()
      Me.txtCoefVariacion2 = New System.Windows.Forms.TextBox()
      Me.btnGuardaResultados = New System.Windows.Forms.Button()
      Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
      Me.lblNombreEnfermedad = New System.Windows.Forms.Label()
      Me.lblSalidaDatos = New System.Windows.Forms.Label()
      Me.btnGeneraReporte = New System.Windows.Forms.Button()
      Me.lblNoCaso = New System.Windows.Forms.Label()
      Me.lblNombreCliente = New System.Windows.Forms.Label()
      Me.lblELISA = New System.Windows.Forms.Label()
      Me.txtCalculoTitulos1 = New System.Windows.Forms.TextBox()
      Me.txtCalculoTitulos2 = New System.Windows.Forms.TextBox()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaGeometrica.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(375, 221)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.ReadOnly = True
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(112, 21)
      Me.txtMediaGeometrica.TabIndex = 2
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaGeometrica.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(378, 202)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(112, 16)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotalDatosCalculados.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(376, 393)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.ReadOnly = True
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(114, 21)
      Me.txtTotalDatosCalculados.TabIndex = 11
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTotalDatosCalculados.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(393, 375)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(86, 16)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "Total de Datos"
      '
      'lblMediaPromedio
      '
      Me.lblMediaPromedio.AutoSize = True
      Me.lblMediaPromedio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaPromedio.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblMediaPromedio.Location = New System.Drawing.Point(378, 159)
      Me.lblMediaPromedio.Name = "lblMediaPromedio"
      Me.lblMediaPromedio.Size = New System.Drawing.Size(101, 16)
      Me.lblMediaPromedio.TabIndex = 14
      Me.lblMediaPromedio.Text = "Media Aritmética"
      '
      'txtMediaAritmetica2
      '
      Me.txtMediaAritmetica2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaAritmetica2.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(374, 178)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.ReadOnly = True
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(113, 21)
      Me.txtMediaAritmetica2.TabIndex = 13
      '
      'lbDesviacionEstandarDNA
      '
      Me.lbDesviacionEstandarDNA.AutoSize = True
      Me.lbDesviacionEstandarDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbDesviacionEstandarDNA.ForeColor = System.Drawing.Color.DarkBlue
      Me.lbDesviacionEstandarDNA.Location = New System.Drawing.Point(373, 288)
      Me.lbDesviacionEstandarDNA.Name = "lbDesviacionEstandarDNA"
      Me.lbDesviacionEstandarDNA.Size = New System.Drawing.Size(119, 16)
      Me.lbDesviacionEstandarDNA.TabIndex = 22
      Me.lbDesviacionEstandarDNA.Text = "Desviacion Estandar"
      '
      'lblVarianzaDNA
      '
      Me.lblVarianzaDNA.AutoSize = True
      Me.lblVarianzaDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblVarianzaDNA.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblVarianzaDNA.Location = New System.Drawing.Point(405, 331)
      Me.lblVarianzaDNA.Name = "lblVarianzaDNA"
      Me.lblVarianzaDNA.Size = New System.Drawing.Size(56, 16)
      Me.lblVarianzaDNA.TabIndex = 21
      Me.lblVarianzaDNA.Text = "Varianza"
      '
      'txtDesvEstandar2
      '
      Me.txtDesvEstandar2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDesvEstandar2.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtDesvEstandar2.Location = New System.Drawing.Point(374, 307)
      Me.txtDesvEstandar2.Name = "txtDesvEstandar2"
      Me.txtDesvEstandar2.ReadOnly = True
      Me.txtDesvEstandar2.Size = New System.Drawing.Size(115, 21)
      Me.txtDesvEstandar2.TabIndex = 20
      '
      'txtVarianza2
      '
      Me.txtVarianza2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtVarianza2.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtVarianza2.Location = New System.Drawing.Point(376, 350)
      Me.txtVarianza2.Name = "txtVarianza2"
      Me.txtVarianza2.ReadOnly = True
      Me.txtVarianza2.Size = New System.Drawing.Size(114, 21)
      Me.txtVarianza2.TabIndex = 19
      '
      'lblCoefVariacionDNA
      '
      Me.lblCoefVariacionDNA.AutoSize = True
      Me.lblCoefVariacionDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCoefVariacionDNA.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblCoefVariacionDNA.Location = New System.Drawing.Point(378, 245)
      Me.lblCoefVariacionDNA.Name = "lblCoefVariacionDNA"
      Me.lblCoefVariacionDNA.Size = New System.Drawing.Size(109, 16)
      Me.lblCoefVariacionDNA.TabIndex = 18
      Me.lblCoefVariacionDNA.Text = "Coef. de Variacion"
      '
      'txtCoefVariacion2
      '
      Me.txtCoefVariacion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCoefVariacion2.ForeColor = System.Drawing.Color.DarkBlue
      Me.txtCoefVariacion2.Location = New System.Drawing.Point(374, 264)
      Me.txtCoefVariacion2.Name = "txtCoefVariacion2"
      Me.txtCoefVariacion2.ReadOnly = True
      Me.txtCoefVariacion2.Size = New System.Drawing.Size(115, 21)
      Me.txtCoefVariacion2.TabIndex = 16
      '
      'btnGuardaResultados
      '
      Me.btnGuardaResultados.Location = New System.Drawing.Point(723, 368)
      Me.btnGuardaResultados.Name = "btnGuardaResultados"
      Me.btnGuardaResultados.Size = New System.Drawing.Size(121, 23)
      Me.btnGuardaResultados.TabIndex = 36
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
      'lblNombreEnfermedad
      '
      Me.lblNombreEnfermedad.AutoSize = True
      Me.lblNombreEnfermedad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreEnfermedad.Location = New System.Drawing.Point(49, 127)
      Me.lblNombreEnfermedad.Name = "lblNombreEnfermedad"
      Me.lblNombreEnfermedad.Size = New System.Drawing.Size(79, 17)
      Me.lblNombreEnfermedad.TabIndex = 43
      Me.lblNombreEnfermedad.Text = "ENFEMEDAD"
      '
      'lblSalidaDatos
      '
      Me.lblSalidaDatos.AutoSize = True
      Me.lblSalidaDatos.Location = New System.Drawing.Point(12, 404)
      Me.lblSalidaDatos.Name = "lblSalidaDatos"
      Me.lblSalidaDatos.Size = New System.Drawing.Size(50, 13)
      Me.lblSalidaDatos.TabIndex = 45
      Me.lblSalidaDatos.Text = "Mensaje:"
      '
      'btnGeneraReporte
      '
      Me.btnGeneraReporte.Location = New System.Drawing.Point(859, 368)
      Me.btnGeneraReporte.Name = "btnGeneraReporte"
      Me.btnGeneraReporte.Size = New System.Drawing.Size(121, 23)
      Me.btnGeneraReporte.TabIndex = 44
      Me.btnGeneraReporte.Text = "Genera Reporte"
      Me.btnGeneraReporte.UseVisualStyleBackColor = True
      '
      'lblNoCaso
      '
      Me.lblNoCaso.AutoSize = True
      Me.lblNoCaso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNoCaso.Location = New System.Drawing.Point(454, 25)
      Me.lblNoCaso.Name = "lblNoCaso"
      Me.lblNoCaso.Size = New System.Drawing.Size(0, 17)
      Me.lblNoCaso.TabIndex = 46
      '
      'lblNombreCliente
      '
      Me.lblNombreCliente.AutoSize = True
      Me.lblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNombreCliente.Location = New System.Drawing.Point(79, 25)
      Me.lblNombreCliente.Name = "lblNombreCliente"
      Me.lblNombreCliente.Size = New System.Drawing.Size(0, 17)
      Me.lblNombreCliente.TabIndex = 47
      '
      'lblELISA
      '
      Me.lblELISA.AutoSize = True
      Me.lblELISA.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblELISA.Location = New System.Drawing.Point(19, 98)
      Me.lblELISA.Name = "lblELISA"
      Me.lblELISA.Size = New System.Drawing.Size(217, 17)
      Me.lblELISA.TabIndex = 48
      Me.lblELISA.Text = "ELISA: INMUNOENSAYO ENZIMÁTICO"
      '
      'txtCalculoTitulos1
      '
      Me.txtCalculoTitulos1.Location = New System.Drawing.Point(22, 159)
      Me.txtCalculoTitulos1.Multiline = True
      Me.txtCalculoTitulos1.Name = "txtCalculoTitulos1"
      Me.txtCalculoTitulos1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtCalculoTitulos1.Size = New System.Drawing.Size(159, 232)
      Me.txtCalculoTitulos1.TabIndex = 49
      '
      'txtCalculoTitulos2
      '
      Me.txtCalculoTitulos2.Location = New System.Drawing.Point(187, 159)
      Me.txtCalculoTitulos2.Multiline = True
      Me.txtCalculoTitulos2.Name = "txtCalculoTitulos2"
      Me.txtCalculoTitulos2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtCalculoTitulos2.Size = New System.Drawing.Size(159, 232)
      Me.txtCalculoTitulos2.TabIndex = 50
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblObservaciones.Location = New System.Drawing.Point(19, 53)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(101, 17)
      Me.lblObservaciones.TabIndex = 51
      Me.lblObservaciones.Text = "Observaciones:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(387, 25)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 17)
      Me.Label1.TabIndex = 52
      Me.Label1.Text = "No.Caso:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(19, 25)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(54, 17)
      Me.Label2.TabIndex = 53
      Me.Label2.Text = "Cliente:"
      '
      'frmSalidaDatos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.ClientSize = New System.Drawing.Size(992, 426)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.lblObservaciones)
      Me.Controls.Add(Me.txtCalculoTitulos2)
      Me.Controls.Add(Me.txtCalculoTitulos1)
      Me.Controls.Add(Me.lblELISA)
      Me.Controls.Add(Me.lblNombreCliente)
      Me.Controls.Add(Me.lblNoCaso)
      Me.Controls.Add(Me.lblSalidaDatos)
      Me.Controls.Add(Me.btnGeneraReporte)
      Me.Controls.Add(Me.lblNombreEnfermedad)
      Me.Controls.Add(Me.HScrollBar1)
      Me.Controls.Add(Me.btnGuardaResultados)
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
      Me.Controls.Add(Me.lblMediaGeometrica)
      Me.Controls.Add(Me.txtMediaGeometrica)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "frmSalidaDatos"
      Me.Text = "Resultado del Análisis"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtMediaGeometrica As System.Windows.Forms.TextBox
   Friend WithEvents lblMediaGeometrica As System.Windows.Forms.Label
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
   Friend WithEvents btnGuardaResultados As System.Windows.Forms.Button
   Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
   Friend WithEvents lblNombreEnfermedad As System.Windows.Forms.Label
   Friend WithEvents lblSalidaDatos As System.Windows.Forms.Label
   Friend WithEvents btnGeneraReporte As System.Windows.Forms.Button
   Friend WithEvents lblNoCaso As System.Windows.Forms.Label
   Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
   Friend WithEvents lblELISA As System.Windows.Forms.Label
   Friend WithEvents txtCalculoTitulos1 As System.Windows.Forms.TextBox
   Friend WithEvents txtCalculoTitulos2 As System.Windows.Forms.TextBox
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
