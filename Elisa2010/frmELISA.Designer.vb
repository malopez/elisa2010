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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElisaBiovetsa))
      Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
      Me.mnuMainAnalisis = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
      Me.ListarAnálisisDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuMainOpciones = New System.Windows.Forms.ToolStripMenuItem()
      Me.ConfigurarLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuConfirmarSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuMainImprimir = New System.Windows.Forms.ToolStripMenuItem()
      Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuMainSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.tbbToolMenu = New System.Windows.Forms.ToolStrip()
      Me.tbbAbrir = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.tbbOpciones = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.tbbConfiguraLector = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
      Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
      Me.lblClock = New System.Windows.Forms.Label()
      Me.AbrirArchivoExistenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuMainMenu.SuspendLayout()
      Me.tbbToolMenu.SuspendLayout()
      Me.SuspendLayout()
      '
      'mnuMainMenu
      '
      Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainAnalisis, Me.mnuMainOpciones, Me.mnuMainImprimir, Me.AcercaDeToolStripMenuItem, Me.mnuMainSalir})
      Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
      Me.mnuMainMenu.Name = "mnuMainMenu"
      Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 24)
      Me.mnuMainMenu.TabIndex = 0
      Me.mnuMainMenu.Text = "MenuStrip1"
      '
      'mnuMainAnalisis
      '
      Me.mnuMainAnalisis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.ListarAnálisisDisponiblesToolStripMenuItem, Me.mnuSalir, Me.AbrirArchivoExistenteToolStripMenuItem})
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
      'ListarAnálisisDisponiblesToolStripMenuItem
      '
      Me.ListarAnálisisDisponiblesToolStripMenuItem.Name = "ListarAnálisisDisponiblesToolStripMenuItem"
      Me.ListarAnálisisDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
      Me.ListarAnálisisDisponiblesToolStripMenuItem.Text = "&Operaciones sobre análisis"
      '
      'mnuSalir
      '
      Me.mnuSalir.Name = "mnuSalir"
      Me.mnuSalir.Size = New System.Drawing.Size(213, 22)
      Me.mnuSalir.Text = "&Salir"
      Me.mnuSalir.ToolTipText = "Abandone la aplicación"
      '
      'mnuMainOpciones
      '
      Me.mnuMainOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarLectorToolStripMenuItem, Me.mnuConfirmarSalir})
      Me.mnuMainOpciones.Name = "mnuMainOpciones"
      Me.mnuMainOpciones.Size = New System.Drawing.Size(69, 20)
      Me.mnuMainOpciones.Text = "&Opciones"
      '
      'ConfigurarLectorToolStripMenuItem
      '
      Me.ConfigurarLectorToolStripMenuItem.Name = "ConfigurarLectorToolStripMenuItem"
      Me.ConfigurarLectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
      Me.ConfigurarLectorToolStripMenuItem.Text = "&Configurar Lector"
      '
      'mnuConfirmarSalir
      '
      Me.mnuConfirmarSalir.Checked = True
      Me.mnuConfirmarSalir.CheckState = System.Windows.Forms.CheckState.Checked
      Me.mnuConfirmarSalir.Name = "mnuConfirmarSalir"
      Me.mnuConfirmarSalir.Size = New System.Drawing.Size(199, 22)
      Me.mnuConfirmarSalir.Text = "Co&nfirmar antes de salir"
      '
      'mnuMainImprimir
      '
      Me.mnuMainImprimir.Name = "mnuMainImprimir"
      Me.mnuMainImprimir.Size = New System.Drawing.Size(65, 20)
      Me.mnuMainImprimir.Text = "&Imprimir"
      '
      'AcercaDeToolStripMenuItem
      '
      Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
      Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
      Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
      '
      'mnuMainSalir
      '
      Me.mnuMainSalir.Name = "mnuMainSalir"
      Me.mnuMainSalir.Size = New System.Drawing.Size(41, 20)
      Me.mnuMainSalir.Text = "&Salir"
      Me.mnuMainSalir.ToolTipText = "Salir de la aplicación"
      '
      'tbbToolMenu
      '
      Me.tbbToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbAbrir, Me.ToolStripSeparator2, Me.tbbOpciones, Me.ToolStripSeparator3, Me.tbbConfiguraLector, Me.ToolStripSeparator4})
      Me.tbbToolMenu.Location = New System.Drawing.Point(0, 24)
      Me.tbbToolMenu.Name = "tbbToolMenu"
      Me.tbbToolMenu.Size = New System.Drawing.Size(1008, 25)
      Me.tbbToolMenu.TabIndex = 1
      Me.tbbToolMenu.Text = "ToolStrip1"
      '
      'tbbAbrir
      '
      Me.tbbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tbbAbrir.Image = CType(resources.GetObject("tbbAbrir.Image"), System.Drawing.Image)
      Me.tbbAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tbbAbrir.Name = "tbbAbrir"
      Me.tbbAbrir.Size = New System.Drawing.Size(23, 22)
      Me.tbbAbrir.Text = "Abrir "
      Me.tbbAbrir.ToolTipText = "Abrir análisis existente"
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'tbbOpciones
      '
      Me.tbbOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tbbOpciones.Image = CType(resources.GetObject("tbbOpciones.Image"), System.Drawing.Image)
      Me.tbbOpciones.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tbbOpciones.Name = "tbbOpciones"
      Me.tbbOpciones.Size = New System.Drawing.Size(23, 22)
      Me.tbbOpciones.Text = "Opciones"
      Me.tbbOpciones.ToolTipText = "Opciones de configuración"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'tbbConfiguraLector
      '
      Me.tbbConfiguraLector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tbbConfiguraLector.Image = CType(resources.GetObject("tbbConfiguraLector.Image"), System.Drawing.Image)
      Me.tbbConfiguraLector.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tbbConfiguraLector.Name = "tbbConfiguraLector"
      Me.tbbConfiguraLector.Size = New System.Drawing.Size(23, 22)
      Me.tbbConfiguraLector.Text = "Configurar el lector de ELISA"
      '
      'ToolStripSeparator4
      '
      Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
      Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
      '
      'tmrClock
      '
      Me.tmrClock.Enabled = True
      Me.tmrClock.Interval = 1000
      '
      'lblClock
      '
      Me.lblClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblClock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.lblClock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.lblClock.Location = New System.Drawing.Point(896, 710)
      Me.lblClock.Name = "lblClock"
      Me.lblClock.Size = New System.Drawing.Size(100, 23)
      Me.lblClock.TabIndex = 2
      Me.lblClock.Text = "Horario"
      Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'AbrirArchivoExistenteToolStripMenuItem
      '
      Me.AbrirArchivoExistenteToolStripMenuItem.Name = "AbrirArchivoExistenteToolStripMenuItem"
      Me.AbrirArchivoExistenteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
      Me.AbrirArchivoExistenteToolStripMenuItem.Text = "Abrir archivo existente"
      '
      'frmElisaBiovetsa
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.Window
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.ClientSize = New System.Drawing.Size(1008, 742)
      Me.Controls.Add(Me.lblClock)
      Me.Controls.Add(Me.tbbToolMenu)
      Me.Controls.Add(Me.mnuMainMenu)
      Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.IsMdiContainer = True
      Me.MainMenuStrip = Me.mnuMainMenu
      Me.Name = "frmElisaBiovetsa"
      Me.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Text = "ELISA BIOVETSA"
      Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
      Me.mnuMainMenu.ResumeLayout(False)
      Me.mnuMainMenu.PerformLayout()
      Me.tbbToolMenu.ResumeLayout(False)
      Me.tbbToolMenu.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
   Friend WithEvents mnuMainAnalisis As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuMainOpciones As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ConfigurarLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuMainImprimir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuMainSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tbbToolMenu As System.Windows.Forms.ToolStrip
   Friend WithEvents tbbAbrir As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tbbOpciones As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tmrClock As System.Windows.Forms.Timer
   Friend WithEvents lblClock As System.Windows.Forms.Label
   Friend WithEvents mnuConfirmarSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tbbConfiguraLector As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ListarAnálisisDisponiblesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AbrirArchivoExistenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
