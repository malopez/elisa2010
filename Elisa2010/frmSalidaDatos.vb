Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSalidaDatos

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      'Try
      guardarResultadosExcel(Me.txtNoCaso.Text, CInt(Me.lblNosubcasos.Text), CInt(Me.lblConsecutivo.Text), Me.lblAnalisis.Text, txtFechaElaboracion.Text, _
                            Me.txtNombreCliente.Text, Me.txtNombreEnfermedad.Text, Me.lblObservaciones.Text, "Resultados", _
                            Me.lblMensajeSobreGrafica.Text, Me.lblNombreSobreGrafica.Text, _
                            txtTitulosObtenidos.Text, _
                            Convert.ToDouble(txtMediaAritmetica2.Text), _
                            Convert.ToDouble(txtMediaGeometrica.Text), _
                            Convert.ToInt32(txtTotalDatosCalculados.Text), _
                            Convert.ToDouble(txtDesvEstandar2.Text), _
                            Convert.ToDouble(txtCoefVariacion2.Text), _
                            Convert.ToDouble(txtVarianza2.Text), lblNombreArchivo.Text)
      
      mensajeVerde(Me.lblSalidaDatos, "El archivo de resultados para el caso se ha guardado exitosamente en excel.")
      'Catch ex As Exception
      '   mensajeException(Me.lblSalidaDatos, ex)
      'End Try

   End Sub

   Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
      imagenGrafica.Image.Dispose()
      releaseObject(imagenGrafica)
      'ATENCIÓN:!!NO Descomentar las siguientes dos líneas a menos que se requiera borrar desde disco el archivo de la imagen.
      'Application.DoEvents()
      'Kill(lblNombreArchivo.Text)
      Me.Close()
   End Sub

   Private Sub frmSalidaDatos_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
      imagenGrafica.Image.Dispose()
      releaseObject(imagenGrafica)
      Application.DoEvents()
      Kill(lblNombreArchivo.Text)
   End Sub


End Class