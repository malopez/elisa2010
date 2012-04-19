<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarListaAnalisis
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarListaAnalisis))
      Me.TblclienteTableAdapter = New Elisa2010.bvtselisaDataSetTableAdapters.tblclienteTableAdapter()
      Me.TblclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.Button1 = New System.Windows.Forms.Button()
      Me.btnEditAnalisis = New System.Windows.Forms.Button()
      Me.txtBuscaAnalisis = New System.Windows.Forms.Button()
      Me.lblNRAnalisis = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtNombreAnalisis = New System.Windows.Forms.TextBox()
      Me.txtClaveAnalisis = New System.Windows.Forms.TextBox()
      Me.btnUpdAnalisis = New System.Windows.Forms.Button()
      Me.btnDelAnalisis = New System.Windows.Forms.Button()
      Me.btnInsAnalisis = New System.Windows.Forms.Button()
      Me.btnFin = New System.Windows.Forms.Button()
      Me.btnHaciaAdelante = New System.Windows.Forms.Button()
      Me.btnHaciaAtras = New System.Windows.Forms.Button()
      Me.btnInicio = New System.Windows.Forms.Button()
      CType(Me.TblclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'TblclienteTableAdapter
      '
      Me.TblclienteTableAdapter.ClearBeforeFill = True
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(643, 234)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(91, 23)
      Me.Button1.TabIndex = 28
      Me.Button1.Text = "Cancelar"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'btnEditAnalisis
      '
      Me.btnEditAnalisis.Image = CType(resources.GetObject("btnEditAnalisis.Image"), System.Drawing.Image)
      Me.btnEditAnalisis.Location = New System.Drawing.Point(514, 191)
      Me.btnEditAnalisis.Name = "btnEditAnalisis"
      Me.btnEditAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnEditAnalisis.TabIndex = 22
      Me.btnEditAnalisis.UseVisualStyleBackColor = True
      '
      'txtBuscaAnalisis
      '
      Me.txtBuscaAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtBuscaAnalisis.ForeColor = System.Drawing.Color.SteelBlue
      Me.txtBuscaAnalisis.Image = CType(resources.GetObject("txtBuscaAnalisis.Image"), System.Drawing.Image)
      Me.txtBuscaAnalisis.Location = New System.Drawing.Point(357, 95)
      Me.txtBuscaAnalisis.Name = "txtBuscaAnalisis"
      Me.txtBuscaAnalisis.Size = New System.Drawing.Size(48, 23)
      Me.txtBuscaAnalisis.TabIndex = 15
      Me.txtBuscaAnalisis.UseVisualStyleBackColor = True
      '
      'lblNRAnalisis
      '
      Me.lblNRAnalisis.AutoSize = True
      Me.lblNRAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNRAnalisis.ForeColor = System.Drawing.Color.DimGray
      Me.lblNRAnalisis.Location = New System.Drawing.Point(269, 194)
      Me.lblNRAnalisis.Name = "lblNRAnalisis"
      Me.lblNRAnalisis.Size = New System.Drawing.Size(0, 15)
      Me.lblNRAnalisis.TabIndex = 27
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(119, 141)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(101, 13)
      Me.Label2.TabIndex = 25
      Me.Label2.Text = "Nombre del análisis:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Label1.Location = New System.Drawing.Point(119, 95)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(91, 13)
      Me.Label1.TabIndex = 24
      Me.Label1.Text = "Clave del análisis:"
      '
      'txtNombreAnalisis
      '
      Me.txtNombreAnalisis.Location = New System.Drawing.Point(226, 138)
      Me.txtNombreAnalisis.Name = "txtNombreAnalisis"
      Me.txtNombreAnalisis.Size = New System.Drawing.Size(508, 20)
      Me.txtNombreAnalisis.TabIndex = 16
      '
      'txtClaveAnalisis
      '
      Me.txtClaveAnalisis.Location = New System.Drawing.Point(226, 95)
      Me.txtClaveAnalisis.Name = "txtClaveAnalisis"
      Me.txtClaveAnalisis.Size = New System.Drawing.Size(125, 20)
      Me.txtClaveAnalisis.TabIndex = 14
      '
      'btnUpdAnalisis
      '
      Me.btnUpdAnalisis.Image = CType(resources.GetObject("btnUpdAnalisis.Image"), System.Drawing.Image)
      Me.btnUpdAnalisis.Location = New System.Drawing.Point(557, 191)
      Me.btnUpdAnalisis.Name = "btnUpdAnalisis"
      Me.btnUpdAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnUpdAnalisis.TabIndex = 23
      Me.btnUpdAnalisis.UseVisualStyleBackColor = True
      '
      'btnDelAnalisis
      '
      Me.btnDelAnalisis.Image = CType(resources.GetObject("btnDelAnalisis.Image"), System.Drawing.Image)
      Me.btnDelAnalisis.Location = New System.Drawing.Point(600, 191)
      Me.btnDelAnalisis.Name = "btnDelAnalisis"
      Me.btnDelAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnDelAnalisis.TabIndex = 26
      Me.btnDelAnalisis.UseVisualStyleBackColor = True
      '
      'btnInsAnalisis
      '
      Me.btnInsAnalisis.Image = CType(resources.GetObject("btnInsAnalisis.Image"), System.Drawing.Image)
      Me.btnInsAnalisis.Location = New System.Drawing.Point(471, 191)
      Me.btnInsAnalisis.Name = "btnInsAnalisis"
      Me.btnInsAnalisis.Size = New System.Drawing.Size(37, 23)
      Me.btnInsAnalisis.TabIndex = 21
      Me.btnInsAnalisis.UseVisualStyleBackColor = True
      '
      'btnFin
      '
      Me.btnFin.Location = New System.Drawing.Point(428, 191)
      Me.btnFin.Name = "btnFin"
      Me.btnFin.Size = New System.Drawing.Size(37, 23)
      Me.btnFin.TabIndex = 20
      Me.btnFin.Text = ">>"
      Me.btnFin.UseVisualStyleBackColor = True
      '
      'btnHaciaAdelante
      '
      Me.btnHaciaAdelante.Location = New System.Drawing.Point(385, 191)
      Me.btnHaciaAdelante.Name = "btnHaciaAdelante"
      Me.btnHaciaAdelante.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAdelante.TabIndex = 19
      Me.btnHaciaAdelante.Text = ">"
      Me.btnHaciaAdelante.UseVisualStyleBackColor = True
      '
      'btnHaciaAtras
      '
      Me.btnHaciaAtras.Location = New System.Drawing.Point(226, 191)
      Me.btnHaciaAtras.Name = "btnHaciaAtras"
      Me.btnHaciaAtras.Size = New System.Drawing.Size(37, 23)
      Me.btnHaciaAtras.TabIndex = 18
      Me.btnHaciaAtras.Text = "<"
      Me.btnHaciaAtras.UseVisualStyleBackColor = True
      '
      'btnInicio
      '
      Me.btnInicio.Location = New System.Drawing.Point(183, 191)
      Me.btnInicio.Name = "btnInicio"
      Me.btnInicio.Size = New System.Drawing.Size(37, 23)
      Me.btnInicio.TabIndex = 17
      Me.btnInicio.Text = "<<"
      Me.btnInicio.UseVisualStyleBackColor = True
      '
      'frmEditarListaAnalisis
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(746, 268)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.btnEditAnalisis)
      Me.Controls.Add(Me.txtBuscaAnalisis)
      Me.Controls.Add(Me.lblNRAnalisis)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.txtNombreAnalisis)
      Me.Controls.Add(Me.txtClaveAnalisis)
      Me.Controls.Add(Me.btnUpdAnalisis)
      Me.Controls.Add(Me.btnDelAnalisis)
      Me.Controls.Add(Me.btnInsAnalisis)
      Me.Controls.Add(Me.btnFin)
      Me.Controls.Add(Me.btnHaciaAdelante)
      Me.Controls.Add(Me.btnHaciaAtras)
      Me.Controls.Add(Me.btnInicio)
      Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmEditarListaAnalisis"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Operaciones sobre Análisis Disponibles"
      CType(Me.TblclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TblclienteTableAdapter As Elisa2010.bvtselisaDataSetTableAdapters.tblclienteTableAdapter
   Friend WithEvents TblclienteBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents btnEditAnalisis As System.Windows.Forms.Button
   Friend WithEvents txtBuscaAnalisis As System.Windows.Forms.Button
   Friend WithEvents lblNRAnalisis As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNombreAnalisis As System.Windows.Forms.TextBox
   Friend WithEvents txtClaveAnalisis As System.Windows.Forms.TextBox
   Friend WithEvents btnUpdAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnDelAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnInsAnalisis As System.Windows.Forms.Button
   Friend WithEvents btnFin As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAdelante As System.Windows.Forms.Button
   Friend WithEvents btnHaciaAtras As System.Windows.Forms.Button
   Friend WithEvents btnInicio As System.Windows.Forms.Button
End Class
