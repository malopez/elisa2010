<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmbSalidaDatos
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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtMediaAritmetica2 = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'btnCalculaResultados
      '
      Me.btnCalculaResultados.Location = New System.Drawing.Point(168, 214)
      Me.btnCalculaResultados.Name = "btnCalculaResultados"
      Me.btnCalculaResultados.Size = New System.Drawing.Size(75, 23)
      Me.btnCalculaResultados.TabIndex = 0
      Me.btnCalculaResultados.Text = "Calcular Datos"
      Me.btnCalculaResultados.UseVisualStyleBackColor = True
      '
      'txtMediaAritmetica
      '
      Me.txtMediaAritmetica.Location = New System.Drawing.Point(22, 55)
      Me.txtMediaAritmetica.Name = "txtMediaAritmetica"
      Me.txtMediaAritmetica.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaAritmetica.TabIndex = 1
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(25, 217)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaGeometrica.TabIndex = 2
      '
      'txtCoefVariacion
      '
      Me.txtCoefVariacion.Location = New System.Drawing.Point(259, 55)
      Me.txtCoefVariacion.Name = "txtCoefVariacion"
      Me.txtCoefVariacion.Size = New System.Drawing.Size(100, 20)
      Me.txtCoefVariacion.TabIndex = 3
      '
      'lbMediaAritmetica
      '
      Me.lbMediaAritmetica.AutoSize = True
      Me.lbMediaAritmetica.Location = New System.Drawing.Point(22, 36)
      Me.lbMediaAritmetica.Name = "lbMediaAritmetica"
      Me.lbMediaAritmetica.Size = New System.Drawing.Size(84, 13)
      Me.lbMediaAritmetica.TabIndex = 4
      Me.lbMediaAritmetica.Text = "Media aritmetica"
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(32, 198)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(93, 13)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'lblCoefVariacion
      '
      Me.lblCoefVariacion.AutoSize = True
      Me.lblCoefVariacion.Location = New System.Drawing.Point(266, 36)
      Me.lblCoefVariacion.Name = "lblCoefVariacion"
      Me.lblCoefVariacion.Size = New System.Drawing.Size(122, 13)
      Me.lblCoefVariacion.TabIndex = 6
      Me.lblCoefVariacion.Text = "Coeficiente de Variacion"
      '
      'lblDesvEstandar
      '
      Me.lblDesvEstandar.AutoSize = True
      Me.lblDesvEstandar.Location = New System.Drawing.Point(138, 112)
      Me.lblDesvEstandar.Name = "lblDesvEstandar"
      Me.lblDesvEstandar.Size = New System.Drawing.Size(105, 13)
      Me.lblDesvEstandar.TabIndex = 10
      Me.lblDesvEstandar.Text = "Desviacion Estandar"
      '
      'lblVarianza
      '
      Me.lblVarianza.AutoSize = True
      Me.lblVarianza.Location = New System.Drawing.Point(25, 109)
      Me.lblVarianza.Name = "lblVarianza"
      Me.lblVarianza.Size = New System.Drawing.Size(48, 13)
      Me.lblVarianza.TabIndex = 9
      Me.lblVarianza.Text = "Varianza"
      '
      'txtDesvEstandar
      '
      Me.txtDesvEstandar.Location = New System.Drawing.Point(143, 128)
      Me.txtDesvEstandar.Name = "txtDesvEstandar"
      Me.txtDesvEstandar.Size = New System.Drawing.Size(100, 20)
      Me.txtDesvEstandar.TabIndex = 8
      '
      'txtVarianza
      '
      Me.txtVarianza.Location = New System.Drawing.Point(25, 128)
      Me.txtVarianza.Name = "txtVarianza"
      Me.txtVarianza.Size = New System.Drawing.Size(100, 20)
      Me.txtVarianza.TabIndex = 7
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(259, 128)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(100, 20)
      Me.txtTotalDatosCalculados.TabIndex = 11
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(256, 109)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(129, 13)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "Total de datos calculados"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(143, 36)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 13)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Media por promedio"
      '
      'txtMediaAritmetica2
      '
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(143, 55)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(100, 20)
      Me.txtMediaAritmetica2.TabIndex = 13
      '
      'fmbSalidaDatos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(434, 283)
      Me.Controls.Add(Me.Label1)
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
      Me.Name = "fmbSalidaDatos"
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtMediaAritmetica2 As System.Windows.Forms.TextBox
End Class
