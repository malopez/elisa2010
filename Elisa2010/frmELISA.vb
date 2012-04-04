Public Class frmElisaBiovetsa

   Const c_mnuConfirmarSalir As Boolean = False
   Private m_blnConfirmarSalir As Boolean

   Private Sub frmElisaBiovetsa_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      m_blnConfirmarSalir = c_mnuConfirmarSalir
      mnuConfirmarSalir.Checked = m_blnConfirmarSalir
   End Sub

   'En el menu de Opciones configura el check de salir confirmando la acción o solo abandonar el programa
   Private Sub mnuConfirmarSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuConfirmarSalir.Click
      mnuConfirmarSalir.Checked = Not (mnuConfirmarSalir.Checked)
      m_blnConfirmarSalir = mnuConfirmarSalir.Checked
   End Sub

   'Permite salir de la aplicacion haciendo clik desde el menu de Analisis
   Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
      Me.Close()
   End Sub

   'Permite salir de la aplicacion haciendo click desde el menu principal
   Private Sub mnuMainSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuMainSalir.Click
      Me.Close()
   End Sub

   'Aparece la ventana de mensaje para preguntar si desea salir de la aplicación, solo se mostrará cuando se configura
   'en opciones con un check el confirmar antes de salir
   Private Sub frmElisaBiovetsa_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If m_blnConfirmarSalir Then
         Beep()
         If MessageBox.Show("¿Desea salir del programa ELISA?", "Elisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
         End If
      End If
   End Sub

   'Permite abrir en forma nomodal configurar lector del menu de Opciones
   Private Sub ConfigurarLectorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarLectorToolStripMenuItem.Click
      frmConfLector.MdiParent = Me
      frmConfLector.Show()
   End Sub

   'Coloca el timer clock indicando la hora en la ventana principal
   Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClock.Tick
      lblClock.Text = CStr(TimeOfDay)
   End Sub

   Private Sub mnuNuevo_Click(sender As System.Object, e As System.EventArgs) Handles mnuNuevo.Click
      frmRegistraNuevoAnalisis.MdiParent = Me
      frmSalidaDatos.MdiParent = Me
      frmSalidaDatos.Show()
      frmRegistraNuevoAnalisis.Show()
   End Sub

   Private Sub mnuMainImprimir_Click(sender As System.Object, e As System.EventArgs) Handles mnuMainImprimir.Click

   End Sub

   Private Sub tbbConfiguraLector_Click(sender As System.Object, e As System.EventArgs) Handles tbbConfiguraLector.Click
      frmConfLector.MdiParent = Me
      frmConfLector.Show()
   End Sub

   Private Sub ListarAnálisisDisponiblesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListarAnálisisDisponiblesToolStripMenuItem.Click
      frmEditarListaAnalisis.MdiParent = Me
      frmEditarListaAnalisis.Show()
   End Sub

   Private Sub tbbOpciones_Click(sender As System.Object, e As System.EventArgs) Handles tbbOpciones.Click
      frmEditarListaAnalisis.MdiParent = Me
      frmEditarListaAnalisis.Show()
   End Sub

   Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
      frmAcercaDe.MdiParent = Me
      frmAcercaDe.Show()
   End Sub

   Private Sub mnuMainAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles mnuMainAnalisis.Click

   End Sub
End Class
