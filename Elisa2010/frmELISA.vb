Public Class frmElisaBiovetsa
   'Para realizar los calculos de titulos
   'ENFERMEDAD       LOGSPS     LOGTIT1   LOGTIT2
   'Laringo           0.15       1.45        3.726
   'Bronquitis        0.15       1.642       3.568
   'Encefalomielitis  0.15       1.642       3.726
   'IBF               0.18       1.172       3.614
   'NC                0.15       1.464       3.74
   'Reovirus          0.15       1.077       3.46

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
   '##    Menu de Análisis          ###
   '###################################
   Private Sub tsmAnemiaInfecciosa_Click(sender As System.Object, e As System.EventArgs)
      Dim forma As frmAnemiaInfecciosa
      forma = New frmAnemiaInfecciosa
      forma.MdiParent = Me
      forma.Enfermedad = "E17/ELANEM | ANEMIA INFECCIOSA"
      forma.Text = "ANEMIA INFECCIOSA"
      forma.Show()
   End Sub

   Private Sub tsmBronquitisInfecciosa_Click(sender As System.Object, e As System.EventArgs) Handles tsmBronquitisInfecciosa.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E01/ELBI | BRONQUITIS INFECCIOSA"
      forma.Text = "BRONQUITIS INFECCIOSA"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.45
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmEncefalomielitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisAviar.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E08/ELEA | ENCEFALOMIELITIS AVIAR"
      forma.Text = "ENCEFALOMIELITIS AVIAR"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmEncefalomielitisAviarPROAN_Click(sender As System.Object, e As System.EventArgs) Handles tsmEncefalomielitisAviarPROAN.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E07/EAPROA | ENCEFALOMIELITIS AVIAR PROAN"
      forma.Text = "ENCEFALOMIELITIS AVIAR PROAN"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmEnfermedadDeNewcaste_Click(sender As System.Object, e As System.EventArgs) Handles tsmEnfermedadDeNewcaste.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E04/ELNC | ENFERMEDAD DE NEWCASTLE"
      forma.Text = "ENFERMEDAD DE NEWCASTLE"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.464
      forma.VTIT2 = 3.74
      forma.Show()
   End Sub

   Private Sub tsmGumboro_Click(sender As System.Object, e As System.EventArgs) Handles tsmGumboro.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E03/ELIBF | GUMBORO"
      forma.Text = "GUMBORO"
      forma.VLOGSPS = 0.18
      forma.VTIT1 = 1.172
      forma.VTIT2 = 3.614
      forma.Show()
   End Sub

   Private Sub tsmLaringotraqueitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmLaringotraqueitisAviar.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E06/ELLT | LARINGOTRAQUEITIS AVIAR"
      forma.Text = "LARINGOTRAQUEITIS AVIAR"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.568
      forma.Show()
   End Sub

   Private Sub tsmReovirus_Click(sender As System.Object, e As System.EventArgs) Handles tsmReovirus.Click
      Dim forma As frmCapturaCasos
      forma = New frmCapturaCasos
      forma.MdiParent = Me
      forma.Enfermedad = "E02/ELREO | REOVIRUS"
      forma.Text = "REOVIRUS"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.077
      forma.VTIT2 = 3.46
      forma.Show()
   End Sub

   '###################################
   '##    Menu de Archivo           ###
   '###################################

   Private Sub tsmDABronquitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmDABronquitisAviar.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E01/ELBI | BRONQUITIS INFECCIOSA"
      forma.Text = "BRONQUITIS INFECCIOSA"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.45
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmDAEncefalomielitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmDAEncefalomielitisAviar.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E08/ELEA | ENCEFALOMIELITIS AVIAR"
      forma.Text = "ENCEFALOMIELITIS AVIAR"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmDAEncefalomielitisAviarPROAN_Click(sender As System.Object, e As System.EventArgs) Handles tsmDAEncefalomielitisAviarPROAN.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E07/EAPROA | ENCEFALOMIELITIS AVIAR PROAN"
      forma.Text = "ENCEFALOMIELITIS AVIAR PROAN"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.726
      forma.Show()
   End Sub

   Private Sub tsmDAEnfermedadDeNewcastle_Click(sender As System.Object, e As System.EventArgs) Handles tsmDAEnfermedadDeNewcastle.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E04/ELNC | ENFERMEDAD DE NEWCASTLE"
      forma.Text = "ENFERMEDAD DE NEWCASTLE"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.464
      forma.VTIT2 = 3.74
      forma.Show()
   End Sub

   Private Sub tsmDAGumboro_Click(sender As System.Object, e As System.EventArgs) Handles tsmDAGumboro.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E03/ELIBF | GUMBORO"
      forma.Text = "GUMBORO"
      forma.VLOGSPS = 0.18
      forma.VTIT1 = 1.172
      forma.VTIT2 = 3.614
      forma.Show()
   End Sub

   Private Sub tsmDALaringotraqueitisAviar_Click(sender As System.Object, e As System.EventArgs) Handles tsmDALaringotraqueitisAviar.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E06/ELLT | LARINGOTRAQUEITIS AVIAR"
      forma.Text = "LARINGOTRAQUEITIS AVIAR"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.642
      forma.VTIT2 = 3.568
      forma.Show()
   End Sub

   Private Sub tsmDAReovirus_Click(sender As System.Object, e As System.EventArgs) Handles tsmDAReovirus.Click
      Dim forma As frmCapturaCasosDA
      forma = New frmCapturaCasosDA
      forma.MdiParent = Me
      forma.Enfermedad = "E02/ELREO | REOVIRUS"
      forma.Text = "REOVIRUS"
      forma.VLOGSPS = 0.15
      forma.VTIT1 = 1.077
      forma.VTIT2 = 3.46
      forma.Show()
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

   '###################################
   '##    Opcion de Placa           ###
   '###################################

   Private Sub tsmLeerYGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsmLeerYGuardar.Click
      frmLecturaDePlaca.MdiParent = Me
      frmLecturaDePlaca.Show()
   End Sub

   '###################################
   '##    Opcion de Resultados      ###
   '###################################


   Private Sub tsmGenerarArchivoDeResultados_Click(sender As System.Object, e As System.EventArgs) Handles tsmGenerarArchivoDeResultados.Click
      frmIntegrarResultados.MdiParent = Me
      frmIntegrarResultados.Show()
   End Sub


   '###################################
   '##    Opcion de Acerca de       ###
   '###################################

   Private Sub mnuAcercaDe_Click(sender As System.Object, e As System.EventArgs) Handles mnuAcercaDe.Click
      frmAcercaDe.MdiParent = Me
      frmAcercaDe.Show()
   End Sub

   'Coloca el timer clock indicando la hora en la ventana principal
   'Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs)
   '   lblClock.Text = CStr(TimeOfDay)
   'End Sub

   '###################################
   '##    Opcion de Salir           ###
   '###################################
   'Permite salir de la aplicacion haciendo click desde el menu principal
   Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
      Me.Close()
   End Sub

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

End Class
