Imports MySql.Data.MySqlClient

Public Class frmIniciaPrograma
   'Este procedimiento revisa la existencia de las rutas necesarias para el funcionamiento del programa, si no las encuentra, crea el directorio.

   Private Function verificaExistenciaDeRuta(ByVal ruta As String, ByVal descripcion As String) As Boolean
      Dim existeruta As Boolean
      If verificarSiExisteArchivo(ruta) Then
         existeruta = True
      Else
         If MessageBox.Show("No existe la carpeta <<" & descripcion & ">>, ¿Desea Crearla?.", "ERROR: Mensaje del Sistema", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.CreateDirectory(ruta)
            existeruta = True
         Else
            existeruta = False
         End If
      End If
      Return existeruta
   End Function

   Private Function verificaConexionABD() As Boolean
      Dim oConexion = New MySqlConnection
      Dim conectado As Boolean
      oConexion.ConnectionString = cadenaConexion
      'Abrir la conexion a la base de datos
      Try
         oConexion.Open()
         oConexion.Close()
         oConexion.Dispose()
         conectado = True
      Catch ex As MySqlException
         conectado = False
      End Try
      Return conectado
   End Function

   Private Sub frmIniciaPrograma_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

      If verificaConexionABD() AndAlso verificaExistenciaDeRuta(rutaImagen, "Imagenes") AndAlso _
         verificaExistenciaDeRuta(rutaPlacas, "Placas Originales") AndAlso verificaExistenciaDeRuta(rutaInformeFinal, "Informe Final") AndAlso _
         verificaExistenciaDeRuta(rutaParaImprimir, "Para Imprimir") AndAlso verificaExistenciaDeRuta(rutaResutados, "Resultados") Then
         Me.Hide()
         frmCargaPrograma.ShowDialog()
      Else
         If MessageBox.Show("No se encuentra funcionando la BD o una de las rutas requeridas no existe, se cerrará el programa.", "ERROR: Mensaje del Sistema", _
                          MessageBoxButtons.OK, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.OK Then
            Me.Close()
         End If
      End If
   End Sub


End Class