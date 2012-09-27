<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultadosAnemia
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
      Me.btnCancelar = New System.Windows.Forms.Button()
      Me.btnGuardaResultados = New System.Windows.Forms.Button()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.cmbCasosResPrel = New System.Windows.Forms.ComboBox()
      Me.lblAnalisis = New System.Windows.Forms.Label()
      Me.txtInmunoEnsayo = New System.Windows.Forms.TextBox()
      Me.txtFechaElaboracion = New System.Windows.Forms.TextBox()
      Me.txtVarianza2 = New System.Windows.Forms.TextBox()
      Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
      Me.txtNombreCliente = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.lblELISA = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblObservaciones = New System.Windows.Forms.Label()
      Me.Panel3 = New System.Windows.Forms.Panel()
      Me.txtDesvEstandar = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.lblNosubcasos = New System.Windows.Forms.Label()
      Me.lblConsecutivo = New System.Windows.Forms.Label()
      Me.txtCoefVariacion2 = New System.Windows.Forms.TextBox()
      Me.lblCoefVariacionDNA = New System.Windows.Forms.Label()
      Me.txtTotalDatosCalculados = New System.Windows.Forms.TextBox()
      Me.lblMediaGeometrica = New System.Windows.Forms.Label()
      Me.txtMediaGeometrica = New System.Windows.Forms.TextBox()
      Me.lblMediaPromedio = New System.Windows.Forms.Label()
      Me.txtMediaAritmetica2 = New System.Windows.Forms.TextBox()
      Me.lblTotalDatosCalculados = New System.Windows.Forms.Label()
      Me.Panel4 = New System.Windows.Forms.Panel()
      Me.Panel2.SuspendLayout()
      Me.Panel3.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnCancelar
      '
      Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnCancelar.Location = New System.Drawing.Point(501, 346)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
      Me.btnCancelar.TabIndex = 64
      Me.btnCancelar.Text = "Finalizar"
      Me.btnCancelar.UseVisualStyleBackColor = True
      '
      'btnGuardaResultados
      '
      Me.btnGuardaResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.btnGuardaResultados.Location = New System.Drawing.Point(321, 346)
      Me.btnGuardaResultados.Name = "btnGuardaResultados"
      Me.btnGuardaResultados.Size = New System.Drawing.Size(174, 23)
      Me.btnGuardaResultados.TabIndex = 63
      Me.btnGuardaResultados.Text = "Guardar Resultados en Excel"
      Me.btnGuardaResultados.UseVisualStyleBackColor = True
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel2.Controls.Add(Me.cmbCasosResPrel)
      Me.Panel2.Controls.Add(Me.lblAnalisis)
      Me.Panel2.Controls.Add(Me.txtInmunoEnsayo)
      Me.Panel2.Controls.Add(Me.txtFechaElaboracion)
      Me.Panel2.Controls.Add(Me.txtVarianza2)
      Me.Panel2.Controls.Add(Me.txtNombreEnfermedad)
      Me.Panel2.Controls.Add(Me.txtNombreCliente)
      Me.Panel2.Controls.Add(Me.Label3)
      Me.Panel2.Controls.Add(Me.Label2)
      Me.Panel2.Controls.Add(Me.lblELISA)
      Me.Panel2.Controls.Add(Me.Label1)
      Me.Panel2.Controls.Add(Me.lblObservaciones)
      Me.Panel2.Location = New System.Drawing.Point(9, 6)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(583, 95)
      Me.Panel2.TabIndex = 66
      '
      'cmbCasosResPrel
      '
      Me.cmbCasosResPrel.FormattingEnabled = True
      Me.cmbCasosResPrel.Location = New System.Drawing.Point(76, 13)
      Me.cmbCasosResPrel.Name = "cmbCasosResPrel"
      Me.cmbCasosResPrel.Size = New System.Drawing.Size(221, 21)
      Me.cmbCasosResPrel.TabIndex = 104
      Me.cmbCasosResPrel.TabStop = False
      '
      'lblAnalisis
      '
      Me.lblAnalisis.AutoSize = True
      Me.lblAnalisis.Location = New System.Drawing.Point(531, 72)
      Me.lblAnalisis.Name = "lblAnalisis"
      Me.lblAnalisis.Size = New System.Drawing.Size(39, 13)
      Me.lblAnalisis.TabIndex = 62
      Me.lblAnalisis.Text = "Label4"
      Me.lblAnalisis.Visible = False
      '
      'txtInmunoEnsayo
      '
      Me.txtInmunoEnsayo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtInmunoEnsayo.Location = New System.Drawing.Point(76, 67)
      Me.txtInmunoEnsayo.Name = "txtInmunoEnsayo"
      Me.txtInmunoEnsayo.ReadOnly = True
      Me.txtInmunoEnsayo.Size = New System.Drawing.Size(167, 20)
      Me.txtInmunoEnsayo.TabIndex = 61
      Me.txtInmunoEnsayo.Text = "INMUNOENSAYO ENZIMATICO"
      '
      'txtFechaElaboracion
      '
      Me.txtFechaElaboracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtFechaElaboracion.Location = New System.Drawing.Point(432, 13)
      Me.txtFechaElaboracion.Name = "txtFechaElaboracion"
      Me.txtFechaElaboracion.ReadOnly = True
      Me.txtFechaElaboracion.Size = New System.Drawing.Size(93, 20)
      Me.txtFechaElaboracion.TabIndex = 60
      '
      'txtVarianza2
      '
      Me.txtVarianza2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtVarianza2.ForeColor = System.Drawing.Color.DarkGoldenrod
      Me.txtVarianza2.Location = New System.Drawing.Point(536, 9)
      Me.txtVarianza2.Name = "txtVarianza2"
      Me.txtVarianza2.ReadOnly = True
      Me.txtVarianza2.Size = New System.Drawing.Size(34, 21)
      Me.txtVarianza2.TabIndex = 51
      Me.txtVarianza2.TabStop = False
      Me.txtVarianza2.Visible = False
      '
      'txtNombreEnfermedad
      '
      Me.txtNombreEnfermedad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNombreEnfermedad.Location = New System.Drawing.Point(248, 67)
      Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
      Me.txtNombreEnfermedad.ReadOnly = True
      Me.txtNombreEnfermedad.Size = New System.Drawing.Size(157, 20)
      Me.txtNombreEnfermedad.TabIndex = 59
      '
      'txtNombreCliente
      '
      Me.txtNombreCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtNombreCliente.Location = New System.Drawing.Point(76, 41)
      Me.txtNombreCliente.Name = "txtNombreCliente"
      Me.txtNombreCliente.ReadOnly = True
      Me.txtNombreCliente.Size = New System.Drawing.Size(449, 20)
      Me.txtNombreCliente.TabIndex = 58
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
      Me.Label3.Location = New System.Drawing.Point(318, 14)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(113, 16)
      Me.Label3.TabIndex = 56
      Me.Label3.Text = "Fecha de Análisis:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
      Me.Label2.Location = New System.Drawing.Point(6, 41)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(52, 16)
      Me.Label2.TabIndex = 53
      Me.Label2.Text = "Cliente:"
      '
      'lblELISA
      '
      Me.lblELISA.AutoSize = True
      Me.lblELISA.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblELISA.ForeColor = System.Drawing.Color.MidnightBlue
      Me.lblELISA.Location = New System.Drawing.Point(6, 68)
      Me.lblELISA.Name = "lblELISA"
      Me.lblELISA.Size = New System.Drawing.Size(44, 16)
      Me.lblELISA.TabIndex = 48
      Me.lblELISA.Text = "ELISA: "
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
      Me.Label1.Location = New System.Drawing.Point(6, 14)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 16)
      Me.Label1.TabIndex = 52
      Me.Label1.Text = "No.Caso:"
      '
      'lblObservaciones
      '
      Me.lblObservaciones.AutoSize = True
      Me.lblObservaciones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblObservaciones.Location = New System.Drawing.Point(424, 70)
      Me.lblObservaciones.Name = "lblObservaciones"
      Me.lblObservaciones.Size = New System.Drawing.Size(101, 17)
      Me.lblObservaciones.TabIndex = 51
      Me.lblObservaciones.Text = "Observaciones:"
      Me.lblObservaciones.Visible = False
      '
      'Panel3
      '
      Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel3.Controls.Add(Me.txtDesvEstandar)
      Me.Panel3.Controls.Add(Me.Label7)
      Me.Panel3.Controls.Add(Me.lblNosubcasos)
      Me.Panel3.Controls.Add(Me.lblConsecutivo)
      Me.Panel3.Controls.Add(Me.txtCoefVariacion2)
      Me.Panel3.Controls.Add(Me.lblCoefVariacionDNA)
      Me.Panel3.Controls.Add(Me.txtTotalDatosCalculados)
      Me.Panel3.Controls.Add(Me.lblMediaGeometrica)
      Me.Panel3.Controls.Add(Me.txtMediaGeometrica)
      Me.Panel3.Controls.Add(Me.lblMediaPromedio)
      Me.Panel3.Controls.Add(Me.txtMediaAritmetica2)
      Me.Panel3.Controls.Add(Me.lblTotalDatosCalculados)
      Me.Panel3.Location = New System.Drawing.Point(7, 285)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(583, 55)
      Me.Panel3.TabIndex = 67
      '
      'txtDesvEstandar
      '
      Me.txtDesvEstandar.BackColor = System.Drawing.Color.White
      Me.txtDesvEstandar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDesvEstandar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtDesvEstandar.Location = New System.Drawing.Point(387, 23)
      Me.txtDesvEstandar.Name = "txtDesvEstandar"
      Me.txtDesvEstandar.ReadOnly = True
      Me.txtDesvEstandar.Size = New System.Drawing.Size(58, 21)
      Me.txtDesvEstandar.TabIndex = 68
      Me.txtDesvEstandar.TabStop = False
      Me.txtDesvEstandar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
      Me.Label7.Location = New System.Drawing.Point(389, 5)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(56, 15)
      Me.Label7.TabIndex = 67
      Me.Label7.Text = "Desv. Est."
      '
      'lblNosubcasos
      '
      Me.lblNosubcasos.AutoSize = True
      Me.lblNosubcasos.Location = New System.Drawing.Point(337, 27)
      Me.lblNosubcasos.Name = "lblNosubcasos"
      Me.lblNosubcasos.Size = New System.Drawing.Size(38, 13)
      Me.lblNosubcasos.TabIndex = 65
      Me.lblNosubcasos.Text = "noSub"
      Me.lblNosubcasos.Visible = False
      '
      'lblConsecutivo
      '
      Me.lblConsecutivo.AutoSize = True
      Me.lblConsecutivo.Location = New System.Drawing.Point(195, 27)
      Me.lblConsecutivo.Name = "lblConsecutivo"
      Me.lblConsecutivo.Size = New System.Drawing.Size(65, 13)
      Me.lblConsecutivo.TabIndex = 64
      Me.lblConsecutivo.Text = "consecutivo"
      Me.lblConsecutivo.Visible = False
      '
      'txtCoefVariacion2
      '
      Me.txtCoefVariacion2.BackColor = System.Drawing.Color.White
      Me.txtCoefVariacion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCoefVariacion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtCoefVariacion2.Location = New System.Drawing.Point(488, 23)
      Me.txtCoefVariacion2.Name = "txtCoefVariacion2"
      Me.txtCoefVariacion2.ReadOnly = True
      Me.txtCoefVariacion2.Size = New System.Drawing.Size(58, 21)
      Me.txtCoefVariacion2.TabIndex = 16
      Me.txtCoefVariacion2.TabStop = False
      Me.txtCoefVariacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblCoefVariacionDNA
      '
      Me.lblCoefVariacionDNA.AutoSize = True
      Me.lblCoefVariacionDNA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCoefVariacionDNA.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblCoefVariacionDNA.Location = New System.Drawing.Point(494, 4)
      Me.lblCoefVariacionDNA.Name = "lblCoefVariacionDNA"
      Me.lblCoefVariacionDNA.Size = New System.Drawing.Size(41, 15)
      Me.lblCoefVariacionDNA.TabIndex = 18
      Me.lblCoefVariacionDNA.Text = "C.V. %"
      '
      'txtTotalDatosCalculados
      '
      Me.txtTotalDatosCalculados.BackColor = System.Drawing.Color.White
      Me.txtTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotalDatosCalculados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtTotalDatosCalculados.Location = New System.Drawing.Point(17, 23)
      Me.txtTotalDatosCalculados.Name = "txtTotalDatosCalculados"
      Me.txtTotalDatosCalculados.ReadOnly = True
      Me.txtTotalDatosCalculados.Size = New System.Drawing.Size(58, 21)
      Me.txtTotalDatosCalculados.TabIndex = 11
      Me.txtTotalDatosCalculados.TabStop = False
      Me.txtTotalDatosCalculados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblMediaGeometrica
      '
      Me.lblMediaGeometrica.AutoSize = True
      Me.lblMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaGeometrica.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblMediaGeometrica.Location = New System.Drawing.Point(247, 4)
      Me.lblMediaGeometrica.Name = "lblMediaGeometrica"
      Me.lblMediaGeometrica.Size = New System.Drawing.Size(107, 15)
      Me.lblMediaGeometrica.TabIndex = 5
      Me.lblMediaGeometrica.Text = "Media Geometrica"
      '
      'txtMediaGeometrica
      '
      Me.txtMediaGeometrica.BackColor = System.Drawing.Color.White
      Me.txtMediaGeometrica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMediaGeometrica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.txtMediaGeometrica.Location = New System.Drawing.Point(266, 23)
      Me.txtMediaGeometrica.Name = "txtMediaGeometrica"
      Me.txtMediaGeometrica.ReadOnly = True
      Me.txtMediaGeometrica.Size = New System.Drawing.Size(58, 21)
      Me.txtMediaGeometrica.TabIndex = 2
      Me.txtMediaGeometrica.TabStop = False
      Me.txtMediaGeometrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblMediaPromedio
      '
      Me.lblMediaPromedio.AutoSize = True
      Me.lblMediaPromedio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMediaPromedio.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblMediaPromedio.Location = New System.Drawing.Point(116, 4)
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
      Me.txtMediaAritmetica2.Location = New System.Drawing.Point(131, 23)
      Me.txtMediaAritmetica2.Name = "txtMediaAritmetica2"
      Me.txtMediaAritmetica2.ReadOnly = True
      Me.txtMediaAritmetica2.Size = New System.Drawing.Size(58, 21)
      Me.txtMediaAritmetica2.TabIndex = 13
      Me.txtMediaAritmetica2.TabStop = False
      Me.txtMediaAritmetica2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblTotalDatosCalculados
      '
      Me.lblTotalDatosCalculados.AutoSize = True
      Me.lblTotalDatosCalculados.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTotalDatosCalculados.ForeColor = System.Drawing.Color.DarkBlue
      Me.lblTotalDatosCalculados.Location = New System.Drawing.Point(4, 5)
      Me.lblTotalDatosCalculados.Name = "lblTotalDatosCalculados"
      Me.lblTotalDatosCalculados.Size = New System.Drawing.Size(82, 15)
      Me.lblTotalDatosCalculados.TabIndex = 12
      Me.lblTotalDatosCalculados.Text = "No. de Sueros"
      '
      'Panel4
      '
      Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.Panel4.Location = New System.Drawing.Point(9, 107)
      Me.Panel4.Name = "Panel4"
      Me.Panel4.Size = New System.Drawing.Size(583, 172)
      Me.Panel4.TabIndex = 68
      '
      'frmResultadosAnemia
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(601, 373)
      Me.Controls.Add(Me.btnCancelar)
      Me.Controls.Add(Me.btnGuardaResultados)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel3)
      Me.Controls.Add(Me.Panel4)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.Name = "frmResultadosAnemia"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Resultados Preliminares de Anemia Infecciosa"
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnCancelar As System.Windows.Forms.Button
   Friend WithEvents btnGuardaResultados As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents lblAnalisis As System.Windows.Forms.Label
   Friend WithEvents txtInmunoEnsayo As System.Windows.Forms.TextBox
   Friend WithEvents txtFechaElaboracion As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreEnfermedad As System.Windows.Forms.TextBox
   Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblELISA As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblObservaciones As System.Windows.Forms.Label
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents lblNosubcasos As System.Windows.Forms.Label
   Friend WithEvents lblConsecutivo As System.Windows.Forms.Label
   Friend WithEvents txtVarianza2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCoefVariacion2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCoefVariacionDNA As System.Windows.Forms.Label
   Friend WithEvents txtTotalDatosCalculados As System.Windows.Forms.TextBox
   Friend WithEvents lblMediaGeometrica As System.Windows.Forms.Label
   Friend WithEvents txtMediaGeometrica As System.Windows.Forms.TextBox
   Friend WithEvents lblMediaPromedio As System.Windows.Forms.Label
   Friend WithEvents txtMediaAritmetica2 As System.Windows.Forms.TextBox
   Friend WithEvents lblTotalDatosCalculados As System.Windows.Forms.Label
   Friend WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents cmbCasosResPrel As System.Windows.Forms.ComboBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtDesvEstandar As System.Windows.Forms.TextBox
End Class

