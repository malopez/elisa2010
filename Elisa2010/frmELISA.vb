﻿Public Class frmElisaBiovetsa

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

   'Private Sub tsmAbrirArchivoExistente_Click(sender As System.Object, e As System.EventArgs) Handles tsmAbrirArchivoExistente.Click
   '   frmAbrirArchivoExistente.MdiParent = Me
   '   frmAbrirArchivoExistente.Show()
   '   frmSalidaDatos.MdiParent = Me
   'End Sub

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
   'Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs)
   '   lblClock.Text = CStr(TimeOfDay)
   'End Sub

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

   Private Sub tsmBronquitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmBronquitisAviar.Click
      frmBronquitisAviar.MdiParent = Me
      frmBronquitisAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub


   Private Sub tsmLaringotraqueitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmLaringotraqueitisAviar.Click
      frmLaringotraqueitisAviar.MdiParent = Me
      frmLaringotraqueitisAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   Private Sub tsmEnfermedadDeNewcastle_Click(sender As System.Object, e As System.EventArgs) Handles tsmEnfermedadDeNewcastle.Click
      frmNewcastle.MdiParent = Me
      frmNewcastle.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   Private Sub tsmReovirus_Click(sender As System.Object, e As System.EventArgs) Handles tsmReovirus.Click
      frmReovirusAviar.MdiParent = Me
      frmReovirusAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   Private Sub tsmEncefalomielitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisAviar.Click
      frmEncefalomielitisAviar.MdiParent = Me
      frmEncefalomielitisAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   Private Sub tsmGumboro_Click(sender As System.Object, e As System.EventArgs) Handles tsmGumboro.Click
      frmGumboroAviar.MdiParent = Me
      frmGumboroAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   Private Sub tsmAnemiaInfecciosa_Click(sender As System.Object, e As System.EventArgs) Handles tsmAnemiaInfecciosa.Click
      frmPasteurellaHaemAviar.MdiParent = Me
      frmPasteurellaHaemAviar.Show()
      frmSalidaDatos.MdiParent = Me
      frmSalidaCaso2.MdiParent = Me
      frmSalidaCaso3.MdiParent = Me
      frmSalidaCaso4.MdiParent = Me
      frmSalidaCaso5.MdiParent = Me
      frmSalidaCaso6.MdiParent = Me
      frmSalidaCaso7.MdiParent = Me
      frmSalidaCaso8.MdiParent = Me
   End Sub

   
   Private Sub tsmPasteurellaHaemolytica_Click(sender As System.Object, e As System.EventArgs) Handles tsmPasteurellaHaemolytica.Click
      frmPasteuHaemDA.MdiParent = Me
      frmPasteuHaemDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmBronquitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmBronquitisDA.Click
      frmBronquitisInfDA.MdiParent = Me
      frmBronquitisInfDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmLaringotraqueitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmLaringotraqueitisDA.Click
      frmLaringotraqueitisDA.MdiParent = Me
      frmLaringotraqueitisDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmNewcastleDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmNewcastleDA.Click
      frmNewcastleDA.MdiParent = Me
      frmNewcastleDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmReovirusDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmReovirusDA.Click
      frmReovirusDA.MdiParent = Me
      frmReovirusDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmGumboroDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmGumboroDA.Click
      frmGumboroDA.MdiParent = Me
      frmGumboroDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub

   Private Sub tsmEncefalomielitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisDA.Click
      frmEncefalomielitisDA.MdiParent = Me
      frmEncefalomielitisDA.Show()
      frmSalidaDatos.MdiParent = Me
   End Sub
End Class
