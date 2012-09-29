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
      Me.tsmAbrirArchivoExistente = New System.Windows.Forms.ToolStripMenuItem()
      Me.AnemiaInfecciosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmBronquitisDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviarPROANDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmNewcastleDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmGumboroDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLaringotraqueitisDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmPasteurellaHaemolytica = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmReovirusDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmVariosCasosDesdeArchivo = New System.Windows.Forms.ToolStripMenuItem()
      Me.AnemiaInfecciosaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmBronquitisVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviarVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviarPROANVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEnfermedadDeNewcastleVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmGumboroVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLaringotraqueitisVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmReovirusVCDA = New System.Windows.Forms.ToolStripMenuItem()
      Me.DesdeLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmAnemiaInfecciosa = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmBronquitisInfecciosa = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEncefalomielitisAviarPROAN = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmGumboro = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLaringotraqueitisAviar = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmEnfermedadDeNewcaste = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmReovirus = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmOperacionesAnalisis = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfigurarLector = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmConfirmarSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
      Me.tsmLeerYGuardar = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.tsbConfigurarLector = New System.Windows.Forms.ToolStripButton()
      Me.tsbReporte = New System.Windows.Forms.ToolStripButton()
      Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
      Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
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
      Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainAnalisis, Me.mnuOpciones, Me.mnuImprimir, Me.mnuAcercaDe, Me.mnuSalir})
      Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
      Me.mnuMainMenu.Name = "mnuMainMenu"
      Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 24)
      Me.mnuMainMenu.TabIndex = 0
      Me.mnuMainMenu.Text = "MenuStrip1"
      '
      'mnuMainAnalisis
      '
      Me.mnuMainAnalisis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbrirArchivoExistente, Me.tsmVariosCasosDesdeArchivo, Me.DesdeLectorToolStripMenuItem, Me.tsmOperacionesAnalisis, Me.tsmSalir})
      Me.mnuMainAnalisis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuMainAnalisis.Name = "mnuMainAnalisis"
      Me.mnuMainAnalisis.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
      Me.mnuMainAnalisis.Size = New System.Drawing.Size(59, 20)
      Me.mnuMainAnalisis.Text = "&Analisis"
      '
      'tsmAbrirArchivoExistente
      '
      Me.tsmAbrirArchivoExistente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnemiaInfecciosaToolStripMenuItem, Me.tsmBronquitisDA, Me.tsmEncefalomielitisDA, Me.tsmEncefalomielitisAviarPROANDA, Me.tsmNewcastleDA, Me.tsmGumboroDA, Me.tsmLaringotraqueitisDA, Me.tsmPasteurellaHaemolytica, Me.tsmReovirusDA})
      Me.tsmAbrirArchivoExistente.Name = "tsmAbrirArchivoExistente"
      Me.tsmAbrirArchivoExistente.Size = New System.Drawing.Size(216, 22)
      Me.tsmAbrirArchivoExistente.Text = "Un caso desde Archivo"
      '
      'AnemiaInfecciosaToolStripMenuItem
      '
      Me.AnemiaInfecciosaToolStripMenuItem.Name = "AnemiaInfecciosaToolStripMenuItem"
      Me.AnemiaInfecciosaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
      Me.AnemiaInfecciosaToolStripMenuItem.Text = "Anemia Infecciosa"
      '
      'tsmBronquitisDA
      '
      Me.tsmBronquitisDA.Name = "tsmBronquitisDA"
      Me.tsmBronquitisDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmBronquitisDA.Text = "Bronquitis Infecciosa"
      '
      'tsmEncefalomielitisDA
      '
      Me.tsmEncefalomielitisDA.Name = "tsmEncefalomielitisDA"
      Me.tsmEncefalomielitisDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisDA.Text = "Encefalomielitis Aviar"
      '
      'tsmEncefalomielitisAviarPROANDA
      '
      Me.tsmEncefalomielitisAviarPROANDA.Name = "tsmEncefalomielitisAviarPROANDA"
      Me.tsmEncefalomielitisAviarPROANDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisAviarPROANDA.Text = "Encefalomielitis Aviar PROAN"
      '
      'tsmNewcastleDA
      '
      Me.tsmNewcastleDA.Name = "tsmNewcastleDA"
      Me.tsmNewcastleDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmNewcastleDA.Text = "Enfermedad de Newcastle"
      '
      'tsmGumboroDA
      '
      Me.tsmGumboroDA.Name = "tsmGumboroDA"
      Me.tsmGumboroDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmGumboroDA.Text = "Gumboro"
      '
      'tsmLaringotraqueitisDA
      '
      Me.tsmLaringotraqueitisDA.Name = "tsmLaringotraqueitisDA"
      Me.tsmLaringotraqueitisDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmLaringotraqueitisDA.Text = "Laringotraqueitis Aviar"
      '
      'tsmPasteurellaHaemolytica
      '
      Me.tsmPasteurellaHaemolytica.Name = "tsmPasteurellaHaemolytica"
      Me.tsmPasteurellaHaemolytica.Size = New System.Drawing.Size(230, 22)
      Me.tsmPasteurellaHaemolytica.Text = "Pasteurella Haemolytica"
      Me.tsmPasteurellaHaemolytica.Visible = False
      '
      'tsmReovirusDA
      '
      Me.tsmReovirusDA.Name = "tsmReovirusDA"
      Me.tsmReovirusDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmReovirusDA.Text = "Reovirus"
      '
      'tsmVariosCasosDesdeArchivo
      '
      Me.tsmVariosCasosDesdeArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnemiaInfecciosaToolStripMenuItem1, Me.tsmBronquitisVCDA, Me.tsmEncefalomielitisAviarVCDA, Me.tsmEncefalomielitisAviarPROANVCDA, Me.tsmEnfermedadDeNewcastleVCDA, Me.tsmGumboroVCDA, Me.tsmLaringotraqueitisVCDA, Me.tsmReovirusVCDA})
      Me.tsmVariosCasosDesdeArchivo.Name = "tsmVariosCasosDesdeArchivo"
      Me.tsmVariosCasosDesdeArchivo.Size = New System.Drawing.Size(216, 22)
      Me.tsmVariosCasosDesdeArchivo.Text = "Varios casos desde Archivo"
      '
      'AnemiaInfecciosaToolStripMenuItem1
      '
      Me.AnemiaInfecciosaToolStripMenuItem1.Name = "AnemiaInfecciosaToolStripMenuItem1"
      Me.AnemiaInfecciosaToolStripMenuItem1.Size = New System.Drawing.Size(230, 22)
      Me.AnemiaInfecciosaToolStripMenuItem1.Text = "Anemia Infecciosa"
      '
      'tsmBronquitisVCDA
      '
      Me.tsmBronquitisVCDA.Name = "tsmBronquitisVCDA"
      Me.tsmBronquitisVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmBronquitisVCDA.Text = "Bronquitis Infecciosa"
      '
      'tsmEncefalomielitisAviarVCDA
      '
      Me.tsmEncefalomielitisAviarVCDA.Name = "tsmEncefalomielitisAviarVCDA"
      Me.tsmEncefalomielitisAviarVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisAviarVCDA.Text = "Encefalomielitis Aviar"
      '
      'tsmEncefalomielitisAviarPROANVCDA
      '
      Me.tsmEncefalomielitisAviarPROANVCDA.Name = "tsmEncefalomielitisAviarPROANVCDA"
      Me.tsmEncefalomielitisAviarPROANVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmEncefalomielitisAviarPROANVCDA.Text = "Encefalomielitis Aviar PROAN"
      '
      'tsmEnfermedadDeNewcastleVCDA
      '
      Me.tsmEnfermedadDeNewcastleVCDA.Name = "tsmEnfermedadDeNewcastleVCDA"
      Me.tsmEnfermedadDeNewcastleVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmEnfermedadDeNewcastleVCDA.Text = "Enfermedad de Newcastle"
      '
      'tsmGumboroVCDA
      '
      Me.tsmGumboroVCDA.Name = "tsmGumboroVCDA"
      Me.tsmGumboroVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmGumboroVCDA.Text = "Gumboro"
      '
      'tsmLaringotraqueitisVCDA
      '
      Me.tsmLaringotraqueitisVCDA.Name = "tsmLaringotraqueitisVCDA"
      Me.tsmLaringotraqueitisVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmLaringotraqueitisVCDA.Text = "Laringotraqueitis Aviar"
      '
      'tsmReovirusVCDA
      '
      Me.tsmReovirusVCDA.Name = "tsmReovirusVCDA"
      Me.tsmReovirusVCDA.Size = New System.Drawing.Size(230, 22)
      Me.tsmReovirusVCDA.Text = "Reovirus"
      '
      'DesdeLectorToolStripMenuItem
      '
      Me.DesdeLectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAnemiaInfecciosa, Me.tsmBronquitisInfecciosa, Me.tsmEncefalomielitisAviar, Me.tsmEncefalomielitisAviarPROAN, Me.tsmGumboro, Me.tsmLaringotraqueitisAviar, Me.tsmEnfermedadDeNewcaste, Me.tsmReovirus})
      Me.DesdeLectorToolStripMenuItem.Name = "DesdeLectorToolStripMenuItem"
      Me.DesdeLectorToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
      Me.DesdeLectorToolStripMenuItem.Text = "Varios casos desde Lector"
      '
      'tsmAnemiaInfecciosa
      '
      Me.tsmAnemiaInfecciosa.Name = "tsmAnemiaInfecciosa"
      Me.tsmAnemiaInfecciosa.Size = New System.Drawing.Size(230, 22)
      Me.tsmAnemiaInfecciosa.Text = "Anemia Infecciosa"
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
      'tsmOperacionesAnalisis
      '
      Me.tsmOperacionesAnalisis.Name = "tsmOperacionesAnalisis"
      Me.tsmOperacionesAnalisis.Size = New System.Drawing.Size(216, 22)
      Me.tsmOperacionesAnalisis.Text = "&Operaciones sobre análisis"
      '
      'tsmSalir
      '
      Me.tsmSalir.Name = "tsmSalir"
      Me.tsmSalir.Size = New System.Drawing.Size(216, 22)
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
      Me.mnuImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmLeerYGuardar})
      Me.mnuImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.mnuImprimir.Name = "mnuImprimir"
      Me.mnuImprimir.Size = New System.Drawing.Size(47, 20)
      Me.mnuImprimir.Text = "&Placa"
      '
      'tsmLeerYGuardar
      '
      Me.tsmLeerYGuardar.Name = "tsmLeerYGuardar"
      Me.tsmLeerYGuardar.Size = New System.Drawing.Size(150, 22)
      Me.tsmLeerYGuardar.Text = "Leer y Guardar"
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
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbConfigurarLector, Me.tsbReporte, Me.tsbImprimir, Me.tsbSalir})
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
      'tsbImprimir
      '
      Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
      Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbImprimir.Name = "tsbImprimir"
      Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
      Me.tsbImprimir.Text = "ToolStripButton1"
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
   Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuOpciones As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmConfigurarLector As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmConfirmarSalir As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmOperacionesAnalisis As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmAbrirArchivoExistente As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Friend WithEvents tsbConfigurarLector As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbReporte As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsmPasteurellaHaemolytica As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmBronquitisDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmLaringotraqueitisDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmNewcastleDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmReovirusDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmGumboroDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmLeerYGuardar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
   Friend WithEvents lblMensajeAplicacion As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents AnemiaInfecciosaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents DesdeLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmAnemiaInfecciosa As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmBronquitisInfecciosa As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmGumboro As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmLaringotraqueitisAviar As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEnfermedadDeNewcaste As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmReovirus As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviarPROAN As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviarPROANDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmVariosCasosDesdeArchivo As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AnemiaInfecciosaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmBronquitisVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviarVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEncefalomielitisAviarPROANVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmEnfermedadDeNewcastleVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmGumboroVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmLaringotraqueitisVCDA As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tsmReovirusVCDA As System.Windows.Forms.ToolStripMenuItem

End Class
