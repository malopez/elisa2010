<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElisaBiovetsa
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElisaBiovetsa))
      Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
      Me.mnuMainAnalisis = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmAbrirArchivoExistente = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmOperacionesAnalisis = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfigurarLector = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfirmarSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.lblClock = New System.Windows.Forms.Label()
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.tsbAbrirExcel = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.tsbConfigurarLector = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.tsbReporte = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
      Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
      Me.MultipleCasoPorPlacaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuMainMenu.SuspendLayout()
      Me.ToolStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'mnuMainMenu
      '
      Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainAnalisis, Me.mnuOpciones, Me.mnuImprimir, Me.mnuAcercaDe, Me.mnuSalir})
      Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
      Me.mnuMainMenu.Name = "mnuMainMenu"
      Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 24)
      Me.mnuMainMenu.TabIndex = 0
      Me.mnuMainMenu.Text = "MenuStrip1"
      '
      'mnuMainAnalisis
      '
      Me.mnuMainAnalisis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.tsmAbrirArchivoExistente, Me.tsmOperacionesAnalisis, Me.MultipleCasoPorPlacaToolStripMenuItem, Me.tsmSalir})
      Me.mnuMainAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuMainAnalisis.Name = "mnuMainAnalisis"
      Me.mnuMainAnalisis.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
      Me.mnuMainAnalisis.Size = New System.Drawing.Size(59, 20)
      Me.mnuMainAnalisis.Text = "&Analisis"
      '
      'mnuNuevo
      '
      Me.mnuNuevo.Name = "mnuNuevo"
      Me.mnuNuevo.Size = New System.Drawing.Size(213, 22)
      Me.mnuNuevo.Text = "&Nuevo"
      Me.mnuNuevo.ToolTipText = "Realice nuevo análisis"
      '
      'tsmAbrirArchivoExistente
      '
      Me.tsmAbrirArchivoExistente.Name = "tsmAbrirArchivoExistente"
      Me.tsmAbrirArchivoExistente.Size = New System.Drawing.Size(213, 22)
      Me.tsmAbrirArchivoExistente.Text = "Abrir archivo existente"
      '
      'tsmOperacionesAnalisis
      '
      Me.tsmOperacionesAnalisis.Name = "tsmOperacionesAnalisis"
      Me.tsmOperacionesAnalisis.Size = New System.Drawing.Size(213, 22)
      Me.tsmOperacionesAnalisis.Text = "&Operaciones sobre análisis"
      '
      'tsmSalir
      '
      Me.tsmSalir.Name = "tsmSalir"
      Me.tsmSalir.Size = New System.Drawing.Size(213, 22)
      Me.tsmSalir.Text = "&Salir"
      Me.tsmSalir.ToolTipText = "Abandone la aplicación"
      '
      'mnuOpciones
      '
      Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmConfigurarLector, Me.tsmConfirmarSalir})
      Me.mnuOpciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuOpciones.Name = "mnuOpciones"
      Me.mnuOpciones.Size = New System.Drawing.Size(69, 20)
      Me.mnuOpciones.Text = "&Opciones"
      '
      'tsmConfigurarLector
      '
      Me.tsmConfigurarLector.Name = "tsmConfigurarLector"
      Me.tsmConfigurarLector.Size = New System.Drawing.Size(199, 22)
      Me.tsmConfigurarLector.Text = "&Configurar Lector"
      '
      'tsmConfirmarSalir
      '
      Me.tsmConfirmarSalir.Checked = True
      Me.tsmConfirmarSalir.CheckState = System.Windows.Forms.CheckState.Checked
      Me.tsmConfirmarSalir.Name = "tsmConfirmarSalir"
      Me.tsmConfirmarSalir.Size = New System.Drawing.Size(199, 22)
      Me.tsmConfirmarSalir.Text = "Co&nfirmar antes de salir"
      '
      'mnuImprimir
      '
      Me.mnuImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuImprimir.Name = "mnuImprimir"
      Me.mnuImprimir.Size = New System.Drawing.Size(65, 20)
      Me.mnuImprimir.Text = "&Imprimir"
      '
      'mnuAcercaDe
      '
      Me.mnuAcercaDe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuAcercaDe.Name = "mnuAcercaDe"
      Me.mnuAcercaDe.Size = New System.Drawing.Size(71, 20)
      Me.mnuAcercaDe.Text = "Acerca de"
      '
      'mnuSalir
      '
      Me.mnuSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuSalir.Name = "mnuSalir"
      Me.mnuSalir.Size = New System.Drawing.Size(41, 20)
      Me.mnuSalir.Text = "&Salir"
      Me.mnuSalir.ToolTipText = "Salir de la aplicación"
      '
      'lblClock
      '
      Me.lblClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblClock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.lblClock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.lblClock.Location = New System.Drawing.Point(896, 297)
      Me.lblClock.Name = "lblClock"
      Me.lblClock.Size = New System.Drawing.Size(100, 23)
      Me.lblClock.TabIndex = 2
      Me.lblClock.Text = "Horario"
      Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ToolStrip1
      '
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAbrirExcel, Me.ToolStripSeparator1, Me.tsbConfigurarLector, Me.ToolStripSeparator2, Me.tsbReporte, Me.ToolStripSeparator3, Me.tsbImprimir, Me.ToolStripSeparator4, Me.tsbSalir, Me.ToolStripSeparator5})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
      Me.ToolStrip1.TabIndex = 4
      Me.ToolStrip1.Text = "ToolStrip1"
      '
      'tsbAbrirExcel
      '
      Me.tsbAbrirExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbAbrirExcel.Image = CType(resources.GetObject("tsbAbrirExcel.Image"), System.Drawing.Image)
      Me.tsbAbrirExcel.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbAbrirExcel.Name = "tsbAbrirExcel"
      Me.tsbAbrirExcel.Size = New System.Drawing.Size(23, 22)
      Me.tsbAbrirExcel.ToolTipText = "Abrir datos desde excel"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'tsbConfigurarLector
      '
      Me.tsbConfigurarLector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbConfigurarLector.Image = CType(resources.GetObject("tsbConfigurarLector.Image"), System.Drawing.Image)
      Me.tsbConfigurarLector.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbConfigurarLector.Name = "tsbConfigurarLector"
      Me.tsbConfigurarLector.Size = New System.Drawing.Size(23, 22)
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'tsbReporte
      '
      Me.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbReporte.Image = CType(resources.GetObject("tsbReporte.Image"), System.Drawing.Image)
      Me.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbReporte.Name = "tsbReporte"
      Me.tsbReporte.Size = New System.Drawing.Size(23, 22)
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'tsbImprimir
      '
      Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
      Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbImprimir.Name = "tsbImprimir"
      Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
      Me.tsbImprimir.Text = "ToolStripButton1"
      '
      'ToolStripSeparator4
      '
      Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
      Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
      '
      'tsbSalir
      '
      Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
      Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbSalir.Name = "tsbSalir"
      Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
      Me.tsbSalir.ToolTipText = "Salir de la aplicación"
      '
      'ToolStripSeparator5
      '
      Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
      Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
      '
      'MultipleCasoPorPlacaToolStripMenuItem
      '
      Me.MultipleCasoPorPlacaToolStripMenuItem.Name = "MultipleCasoPorPlacaToolStripMenuItem"
      Me.MultipleCasoPorPlacaToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
      Me.MultipleCasoPorPlacaToolStripMenuItem.Text = "Multiple Caso por placa"
      '
      'frmElisaBiovetsa
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.Window
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.ClientSize = New System.Drawing.Size(1008, 329)
      Me.Controls.Add(Me.ToolStrip1)
      Me.Controls.Add(Me.lblClock)
      Me.Controls.Add(Me.mnuMainMenu)
      Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.IsMdiContainer = True
      Me.MainMenuStrip = Me.mnuMainMenu
      Me.Name = "frmElisaBiovetsa"
      Me.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Text = "ELISA BIOVETSA"
      Me.TransparencyKey = System.Drawing.SystemColors.ControlLightLight
      Me.mnuMainMenu.ResumeLayout(False)
      Me.mnuMainMenu.PerformLayout()
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
   Friend WithEvents mnuMainAnalisis As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuOpciones As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmConfigurarLector As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents lblClock As System.Windows.Forms.Label
   Friend WithEvents tsmConfirmarSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmOperacionesAnalisis As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmAbrirArchivoExistente As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Friend WithEvents tsbAbrirExcel As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tsbConfigurarLector As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbReporte As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents MultipleCasoPorPlacaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
