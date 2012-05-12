Public Class frmElisaBiovetsa

   Const c_mnuConfirmarSalir As Boolean = False
   Private m_blnConfirmarSalir As Boolean

   Private Sub frmElisaBiovetsa_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      m_blnConfirmarSalir = c_mnuConfirmarSalir
      tsmConfirmarSalir.Checked = m_blnConfirmarSalir
   End Sub


   '###################################
   '##    Opcion de Analisis        ###
   '###################################
   Private Sub mnuNuevo_Click(sender As System.Object, e As System.EventArgs) Handles mnuNuevo.Click
      frmRegistraNuevoAnalisis.MdiParent = Me
      frmRegistraNuevoAnalisis.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmAbrirArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles tsmAbrirArchivoExistente.Click
      frmAbrirArchivoExistente.MdiParent = Me
      frmAbrirArchivoExistente.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmOperacionesAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles tsmOperacionesAnalisis.Click
      frmOperacionesAnalisis.MdiParent = Me
      frmOperacionesAnalisis.Show()
   End Sub

   'Permite salir de la aplicacion haciendo clik desde el menu de Analisis
   Private Sub tsmSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsmSalir.Click
      Me.Close()
   End Sub

   '###################################
   '##    Opcion de Acerca de       ###
   '###################################

   Private Sub mnuAcercaDe_Click(sender As System.Object, e As System.EventArgs) Handles mnuAcercaDe.Click
      frmAcercaDe.MdiParent = Me
      frmAcercaDe.Show()
   End Sub

   '###################################
   '##    Opcion de Salir           ###
   '###################################
   'Permite salir de la aplicacion haciendo click desde el menu principal
   Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
      Me.Close()
   End Sub

   '###################################
   '##    Opcion de Opciones        ###
   '###################################

   Private Sub tsmConfigurarLector_Click(sender As System.Object, e As System.EventArgs) Handles tsmConfigurarLector.Click
      frmConfiguraLector.MdiParent = Me
      frmConfiguraLector.Show()
   End Sub

   'En el menu de Opciones configura el check de salir confirmando la acción o solo abandonar el programa
   Private Sub tsmConfirmarSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsmConfirmarSalir.Click
      tsmConfirmarSalir.Checked = Not (tsmConfirmarSalir.Checked)
      m_blnConfirmarSalir = tsmConfirmarSalir.Checked
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

   'Coloca el timer clock indicando la hora en la ventana principal
   Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs)
      lblClock.Text = CStr(TimeOfDay)
   End Sub

   '###################################
   '##    Menu de iconitos          ###
   '###################################
   Private Sub tsbAbrirExcel_Click(sender As System.Object, e As System.EventArgs) Handles tsbAbrirExcel.Click
      frmAbrirArchivoExistente.MdiParent = Me
      frmAbrirArchivoExistente.Show()
   End Sub

   Private Sub tsbConfigurarLector_Click(sender As System.Object, e As System.EventArgs) Handles tsbConfigurarLector.Click
      frmConfiguraLector.MdiParent = Me
      frmConfiguraLector.Show()
   End Sub

   Private Sub tsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsbSalir.Click
      Me.Close()
   End Sub

   Private Sub MultipleCasoPorPlacaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MultipleCasoPorPlacaToolStripMenuItem.Click
      frmMultipleCaso.MdiParent = Me
      frmMultipleCaso.Show()
   End Sub
End Class
