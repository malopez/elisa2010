Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel




Public Class frmResultadosPrelim
   Dim indice As Integer = 0
   Private nombreEnfermedad As String
   Private analisis As String
   Private totalCasos() As listaCasos
   Private laFecha As String
   Private titulosObtenidos As String
   Private nombreSobreGrafica As String

   Public Property Nombre() As String
      Get
         Return nombreEnfermedad
      End Get
      Set(ByVal value As String)
         nombreEnfermedad = value
      End Set
   End Property

   Public Property NombreAnalisis() As String
      Get
         Return analisis
      End Get
      Set(ByVal value As String)
         analisis = value
      End Set
   End Property

   Public Property ArregloCasos() As Array
      Get
         Return totalCasos
      End Get
      Set(ByVal value As Array)
         totalCasos = value
      End Set
   End Property

   Public Property Fecha() As String
      Get
         Return laFecha
      End Get
      Set(ByVal value As String)
         laFecha = value
      End Set
   End Property

   Public Property Titulos() As String
      Get
         Return titulosObtenidos
      End Get
      Set(ByVal value As String)
         titulosObtenidos = value
      End Set
   End Property

   Public Property NombreGrafica() As String
      Get
         Return nombreSobreGrafica
      End Get
      Set(ByVal value As String)
         nombreSobreGrafica = value
      End Set
   End Property

   Private Sub btnGuardaResutados_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaResultados.Click
      'Try
      'Obtener el nombre del análisis para colocar la cabecera de la gráfica
      Dim cadena As String
      Dim tabla() As String
      cadena = cmbCasosResPrel.Text
      tabla = Split(cadena, " ")
      guardarResultadosExcel(tabla(0), CInt(Me.lblNosubcasos.Text), CInt(Me.lblConsecutivo.Text), Me.lblAnalisis.Text, txtFechaElaboracion.Text, _
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

   Private Sub cmbCasosResPrel_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cmbCasosResPrel.SelectionChangeCommitted
      indice = cmbCasosResPrel.SelectedIndex
   End Sub


   Private Sub cmbCasosResPrel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCasosResPrel.SelectedIndexChanged

      presentaResultadosEnPantalla(Me.lblAnalisis, analisis, _
                                    Me.txtFechaElaboracion, laFecha, _
                                    Me.txtNombreEnfermedad, nombreEnfermedad, _
                                    Me.txtNombreCliente, totalCasos(indice).cliente, _
                                    Me.lblObservaciones, totalCasos(indice).obs, _
                                    Me.txtVarianza2, totalCasos(indice).varianza, _
                                    Me.txtTotalDatosCalculados, totalCasos(indice).sueros, _
                                    Me.txtMediaAritmetica2, totalCasos(indice).medArit, _
                                    Me.txtMediaGeometrica, totalCasos(indice).medGeom, _
                                    Me.txtCoefVariacion2, totalCasos(indice).coefVar, _
                                    Me.txtDesvEstandar2, totalCasos(indice).desvEst, _
                                    Me.lblNosubcasos, totalCasos(indice).noSubcasos, _
                                    Me.lblConsecutivo, totalCasos(indice).subCaso, _
                                    Me.txtTitulosObtenidos, totalCasos(indice).titulosObtenidos, _
                                    Me.lblNombreSobreGrafica, nombreSobreGrafica, _
                                    Me.lblMensajeSobreGrafica, totalCasos(indice).texto, _
                                    Me.imagenGrafica, totalCasos(indice).nombreArchivoImagen, _
                                    Me.lblNombreArchivo)
   End Sub
End Class