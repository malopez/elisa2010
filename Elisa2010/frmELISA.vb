Public Class frmElisaBiovetsa

   Const c_mnuConfirmarSalir As Boolean = False
   Private m_blnConfirmarSalir As Boolean

   Private Sub frmElisaBiovetsa_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      frmInicioPrograma.Close()
   End Sub

   Private Sub frmElisaBiovetsa_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      Dim ctl As Control
      Dim ctlMDI As MdiClient

      m_blnConfirmarSalir = c_mnuConfirmarSalir
      tsmConfirmarSalir.Checked = m_blnConfirmarSalir

      ' Loop through all of the form's controls looking
      ' for the control of type MdiClient.
      For Each ctl In Me.Controls
         Try
            ' Attempt to cast the control to type MdiClient.
            ctlMDI = CType(ctl, MdiClient)

            ' Set the BackColor of the MdiClient control.
            ctlMDI.BackColor = Me.BackColor

         Catch exc As InvalidCastException
            ' Catch and ignore the error if casting failed.
         End Try
      Next

   End Sub


   '###################################
   '##    Opcion de Analisis        ###
   '###################################

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

   Private Sub tsbConfigurarLector_Click(sender As System.Object, e As System.EventArgs) Handles tsbConfigurarLector.Click
      frmConfiguraLector.MdiParent = Me
      frmConfiguraLector.Show()
   End Sub

   Private Sub tsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsbSalir.Click
      Me.Close()
   End Sub

   Private Sub tsmBronquitisInfecciosa_Click(sender As System.Object, e As System.EventArgs) Handles tsmBronquitisInfecciosa.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E01/ELBI | BRONQUITIS INFECCIOSA"
      forma.Text = "BRONQUITIS INFECCIOSA"
      forma.Show()
   End Sub


   Private Sub tsmLaringotraqueitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmLaringotraqueitisAviar.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E06/ELLT | LARINGOTRAQUEITIS AVIAR"
      forma.Text = "LARINGOTRAQUEITIS AVIAR"
      forma.Show()
   End Sub

   Private Sub tsmEnfermedadDeNewcaste_Click(sender As System.Object, e As System.EventArgs) Handles tsmEnfermedadDeNewcaste.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E04/ELNC | ENFERMEDAD DE NEWCASTLE"
      forma.Text = "ENFERMEDAD DE NEWCASTLE"
      forma.Show()
   End Sub

   Private Sub tsmReovirus_Click(sender As System.Object, e As System.EventArgs) Handles tsmReovirus.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E02/ELREO | REOVIRUS"
      forma.Text = "REOVIRUS"
      forma.Show()
   End Sub

   Private Sub tsmEncefalomielitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisAviar.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E08/ELEA | ENCEFALOMIELITIS AVIAR"
      forma.Text = "ENCEFALOMIELITIS AVIAR"
      forma.Show()
   End Sub

   Private Sub tsmGumboro_Click(sender As System.Object, e As System.EventArgs) Handles tsmGumboro.Click
      Dim forma As frmCapturaCySC
      forma = New frmCapturaCySC
      forma.MdiParent = Me
      forma.Enfermedad = "E03/ELIBF | GUMBORO"
      forma.Text = "GUMBORO"
      forma.Show()
   End Sub

   Private Sub tsmAnemiaInfecciosa_Click(sender As System.Object, e As System.EventArgs) Handles tsmAnemiaInfecciosa.Click
      Dim forma As frmAnemiaInfecciosa
      forma = New frmAnemiaInfecciosa
      forma.MdiParent = Me
      forma.Enfermedad = "E17/ELANEM | ANEMIA INFECCIOSA"
      forma.Text = "ANEMIA INFECCIOSA"
      forma.Show()
   End Sub

   Private Sub tsmBronquitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmBronquitisDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E01/ELBI | BRONQUITIS INFECCIOSA"
      forma.Text = "BRONQUITIS INFECCIOSA"
      forma.Show()
   End Sub

   Private Sub tsmLaringotraqueitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmLaringotraqueitisDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E06/ELLT | LARINGOTRAQUEITIS AVIAR"
      forma.Text = "LARINGOTRAQUEITIS AVIAR"
      forma.Show()

   End Sub

   Private Sub tsmNewcastleDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmNewcastleDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E04/ELNC | ENFERMEDAD DE NEWCASTLE"
      forma.Text = "ENFERMEDAD DE NEWCASTLE"
      forma.Show()
   End Sub

   Private Sub tsmReovirusDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmReovirusDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E02/ELREO | REOVIRUS"
      forma.Text = "REOVIRUS"
      forma.Show()
   End Sub

   Private Sub tsmGumboroDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmGumboroDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E03/ELIBF | GUMBORO"
      forma.Text = "GUMBORO"
      forma.Show()
   End Sub

   Private Sub tsmEncefalomielitisDA_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisDA.Click
      Dim forma As frmAbrirArchivo
      forma = New frmAbrirArchivo
      forma.MdiParent = Me
      forma.Enfermedad = "E08/ELEA | ENCEFALOMIELITIS AVIAR"
      forma.Text = "ENCEFALOMIELITIS AVIAR"
      forma.Show()
   End Sub

   Private Sub tsmLeerYGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsmLeerYGuardar.Click
      frmLecturaDePlaca.MdiParent = Me
      frmLecturaDePlaca.Show()
   End Sub

End Class
