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
      Me.DesdeLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmBronquitisInfecciosa = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviarPROAN = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmGumboro = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLaringotraqueitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEnfermedadDeNewcaste = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmReovirus = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmAbrirDesdeArchivoExistent = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDABronquitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDAEncefalomielitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDAEncefalomielitisAviarPROAN = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDAEnfermedadDeNewcastle = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDAGumboro = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDALaringotraqueitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmDAReovirus = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfigurarLector = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfirmarSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLeerYGuardar = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuResultados = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmGenerarArchivoDeResultados = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.tsbConfigurarLector = New System.Windows.Forms.ToolStripButton()
      Me.tsbReporte = New System.Windows.Forms.ToolStripButton()
      Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
      Me.lblMensajeAplicacion = New System.Windows.Forms.ToolStripStatusLabel()
      Me.mnuMainMenu.SuspendLayout()
      Me.ToolStrip1.SuspendLayout()
      Me.StatusStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'mnuMainMenu
      '
      Me.mnuMainMenu.BackColor = System.Drawing.Color.LightSteelBlue
      Me.mnuMainMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainAnalisis, Me.mnuArchivo, Me.mnuOpciones, Me.mnuImprimir, Me.mnuResultados, Me.mnuAcercaDe, Me.mnuSalir})
      Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
      Me.mnuMainMenu.Name = "mnuMainMenu"
      Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 24)
      Me.mnuMainMenu.TabIndex = 0
      Me.mnuMainMenu.Text = "MenuStrip1"
      '
      'mnuMainAnalisis
      '
      Me.mnuMainAnalisis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesdeLectorToolStripMenuItem})
      Me.mnuMainAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuMainAnalisis.Name = "mnuMainAnalisis"
      Me.mnuMainAnalisis.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
      Me.mnuMainAnalisis.Size = New System.Drawing.Size(59, 20)
      Me.mnuMainAnalisis.Text = "&Análisis"
      '
      'DesdeLectorToolStripMenuItem
      '
      Me.DesdeLectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBronquitisInfecciosa, Me.tsmEncefalomielitisAviar, Me.tsmEncefalomielitisAviarPROAN, Me.tsmGumboro, Me.tsmLaringotraqueitisAviar, Me.tsmEnfermedadDeNewcaste, Me.tsmReovirus})
      Me.DesdeLectorToolStripMenuItem.Name = "DesdeLectorToolStripMenuItem"
      Me.DesdeLectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.DesdeLectorToolStripMenuItem.Text = "Nuevo Análisis"
      '
      'tsmBronquitisInfecciosa
      '
      Me.tsmBronquitisInfecciosa.Name = "tsmBronquitisInfecciosa"
      Me.tsmBronquitisInfecciosa.Size = New System.Drawing.Size(230, 22)
      Me.tsmBronquitisInfecciosa.Text = "Bronquitis Infecciosa"
      '
      'tsmEncefalomielitisAviar
      '
      Me.tsmEncefalomielitisAviar.Name = "tsmEncefalomielitisAviar"
      Me.tsmEncefalomielitisAviar.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisAviar.Text = "Encefalomielitis Aviar"
      '
      'tsmEncefalomielitisAviarPROAN
      '
      Me.tsmEncefalomielitisAviarPROAN.Name = "tsmEncefalomielitisAviarPROAN"
      Me.tsmEncefalomielitisAviarPROAN.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisAviarPROAN.Text = "Encefalomielitis Aviar PROAN"
      '
      'tsmGumboro
      '
      Me.tsmGumboro.Name = "tsmGumboro"
      Me.tsmGumboro.Size = New System.Drawing.Size(230, 22)
      Me.tsmGumboro.Text = "Gumboro"
      '
      'tsmLaringotraqueitisAviar
      '
      Me.tsmLaringotraqueitisAviar.Name = "tsmLaringotraqueitisAviar"
      Me.tsmLaringotraqueitisAviar.Size = New System.Drawing.Size(230, 22)
      Me.tsmLaringotraqueitisAviar.Text = "Laringotraqueitis Aviar"
      '
      'tsmEnfermedadDeNewcaste
      '
      Me.tsmEnfermedadDeNewcaste.Name = "tsmEnfermedadDeNewcaste"
      Me.tsmEnfermedadDeNewcaste.Size = New System.Drawing.Size(230, 22)
      Me.tsmEnfermedadDeNewcaste.Text = "Enfermedad de Newcastle"
      '
      'tsmReovirus
      '
      Me.tsmReovirus.Name = "tsmReovirus"
      Me.tsmReovirus.Size = New System.Drawing.Size(230, 22)
      Me.tsmReovirus.Text = "Reovirus"
      '
      'mnuArchivo
      '
      Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbrirDesdeArchivoExistent})
      Me.mnuArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuArchivo.Name = "mnuArchivo"
      Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
      Me.mnuArchivo.Text = "Ar&chivo"
      '
      'tsmAbrirDesdeArchivoExistent
      '
      Me.tsmAbrirDesdeArchivoExistent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmDABronquitisAviar, Me.tsmDAEncefalomielitisAviar, Me.tsmDAEncefalomielitisAviarPROAN, Me.tsmDAEnfermedadDeNewcastle, Me.tsmDAGumboro, Me.tsmDALaringotraqueitisAviar, Me.tsmDAReovirus})
      Me.tsmAbrirDesdeArchivoExistent.Name = "tsmAbrirDesdeArchivoExistent"
      Me.tsmAbrirDesdeArchivoExistent.Size = New System.Drawing.Size(193, 22)
      Me.tsmAbrirDesdeArchivoExistent.Text = "Abrir Archivo Existente"
      '
      'tsmDABronquitisAviar
      '
      Me.tsmDABronquitisAviar.Name = "tsmDABronquitisAviar"
      Me.tsmDABronquitisAviar.Size = New System.Drawing.Size(230, 22)
      Me.tsmDABronquitisAviar.Text = "Bronquitis Aviar"
      '
      'tsmDAEncefalomielitisAviar
      '
      Me.tsmDAEncefalomielitisAviar.Name = "tsmDAEncefalomielitisAviar"
      Me.tsmDAEncefalomielitisAviar.Size = New System.Drawing.Size(230, 22)
      Me.tsmDAEncefalomielitisAviar.Text = "Encefalomielitis Aviar"
      '
      'tsmDAEncefalomielitisAviarPROAN
      '
      Me.tsmDAEncefalomielitisAviarPROAN.Name = "tsmDAEncefalomielitisAviarPROAN"
      Me.tsmDAEncefalomielitisAviarPROAN.Size = New System.Drawing.Size(230, 22)
      Me.tsmDAEncefalomielitisAviarPROAN.Text = "Encefalomielitis Aviar PROAN"
      '
      'tsmDAEnfermedadDeNewcastle
      '
      Me.tsmDAEnfermedadDeNewcastle.Name = "tsmDAEnfermedadDeNewcastle"
      Me.tsmDAEnfermedadDeNewcastle.Size = New System.Drawing.Size(230, 22)
      Me.tsmDAEnfermedadDeNewcastle.Text = "Enfermedad de Newcastle"
      '
      'tsmDAGumboro
      '
      Me.tsmDAGumboro.Name = "tsmDAGumboro"
      Me.tsmDAGumboro.Size = New System.Drawing.Size(230, 22)
      Me.tsmDAGumboro.Text = "Gumboro"
      '
      'tsmDALaringotraqueitisAviar
      '
      Me.tsmDALaringotraqueitisAviar.Name = "tsmDALaringotraqueitisAviar"
      Me.tsmDALaringotraqueitisAviar.Size = New System.Drawing.Size(230, 22)
      Me.tsmDALaringotraqueitisAviar.Text = "Laringotraqueitis Aviar"
      '
      'tsmDAReovirus
      '
      Me.tsmDAReovirus.Name = "tsmDAReovirus"
      Me.tsmDAReovirus.Size = New System.Drawing.Size(230, 22)
      Me.tsmDAReovirus.Text = "Reovirus"
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
      Me.mnuImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmLeerYGuardar})
      Me.mnuImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuImprimir.Name = "mnuImprimir"
      Me.mnuImprimir.Size = New System.Drawing.Size(47, 20)
      Me.mnuImprimir.Text = "&Placa"
      '
      'tsmLeerYGuardar
      '
      Me.tsmLeerYGuardar.Name = "tsmLeerYGuardar"
      Me.tsmLeerYGuardar.Size = New System.Drawing.Size(238, 22)
      Me.tsmLeerYGuardar.Text = "Obtener desde lector y Guardar"
      '
      'mnuResultados
      '
      Me.mnuResultados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmGenerarArchivoDeResultados})
      Me.mnuResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuResultados.Name = "mnuResultados"
      Me.mnuResultados.Size = New System.Drawing.Size(76, 20)
      Me.mnuResultados.Text = "&Resultados"
      '
      'tsmGenerarArchivoDeResultados
      '
      Me.tsmGenerarArchivoDeResultados.Name = "tsmGenerarArchivoDeResultados"
      Me.tsmGenerarArchivoDeResultados.Size = New System.Drawing.Size(233, 22)
      Me.tsmGenerarArchivoDeResultados.Text = "Generar archivo de resultados "
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
      'ToolStrip1
      '
      Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConfigurarLector, Me.tsbReporte})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
      Me.ToolStrip1.TabIndex = 4
      Me.ToolStrip1.Text = "ToolStrip1"
      '
      'tsbConfigurarLector
      '
      Me.tsbConfigurarLector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbConfigurarLector.Image = CType(resources.GetObject("tsbConfigurarLector.Image"), System.Drawing.Image)
      Me.tsbConfigurarLector.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbConfigurarLector.Name = "tsbConfigurarLector"
      Me.tsbConfigurarLector.Size = New System.Drawing.Size(23, 22)
      '
      'tsbReporte
      '
      Me.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbReporte.Image = CType(resources.GetObject("tsbReporte.Image"), System.Drawing.Image)
      Me.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbReporte.Name = "tsbReporte"
      Me.tsbReporte.Size = New System.Drawing.Size(23, 22)
      '
      'StatusStrip1
      '
      Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMensajeAplicacion})
      Me.StatusStrip1.Location = New System.Drawing.Point(0, 307)
      Me.StatusStrip1.Name = "StatusStrip1"
      Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
      Me.StatusStrip1.TabIndex = 6
      Me.StatusStrip1.Text = "StatusStrip1"
      '
      'lblMensajeAplicacion
      '
      Me.lblMensajeAplicacion.BackColor = System.Drawing.SystemColors.Control
      Me.lblMensajeAplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.lblMensajeAplicacion.Name = "lblMensajeAplicacion"
      Me.lblMensajeAplicacion.Size = New System.Drawing.Size(63, 17)
      Me.lblMensajeAplicacion.Text = "MENSAJE: "
      '
      'frmElisaBiovetsa
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(1008, 329)
      Me.Controls.Add(Me.StatusStrip1)
      Me.Controls.Add(Me.ToolStrip1)
      Me.Controls.Add(Me.mnuMainMenu)
      Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.IsMdiContainer = True
      Me.MainMenuStrip = Me.mnuMainMenu
      Me.Name = "frmElisaBiovetsa"
      Me.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ELISA Aves BioVetSA"
      Me.TransparencyKey = System.Drawing.Color.White
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.mnuMainMenu.ResumeLayout(False)
      Me.mnuMainMenu.PerformLayout()
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      Me.StatusStrip1.ResumeLayout(False)
      Me.StatusStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
   Friend WithEvents mnuMainAnalisis As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuOpciones As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmConfigurarLector As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmConfirmarSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Friend WithEvents tsbConfigurarLector As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbReporte As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsmLeerYGuardar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
   Friend WithEvents lblMensajeAplicacion As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents DesdeLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmBronquitisInfecciosa As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmGumboro As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmLaringotraqueitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEnfermedadDeNewcaste As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmReovirus As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviarPROAN As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuResultados As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmGenerarArchivoDeResultados As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmAbrirDesdeArchivoExistent As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDABronquitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDAEncefalomielitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDAEncefalomielitisAviarPROAN As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDAEnfermedadDeNewcastle As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDAGumboro As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDALaringotraqueitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmDAReovirus As System.Windows.Forms.ToolStripMenuItem

End Class
