Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class frmOperacionesAnalisis
   Dim iposicFilaActual As Integer = 0
   Dim oDataAdapter As MySqlDataAdapter
   Dim oDataSet As DataSet
   Const cadenaConexion As String = "server=biobuntu;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"

   Private Sub habilitaBarra()
      btnInicio.Enabled = True
      btnHaciaAtras.Enabled = True
      btnHaciaAdelante.Enabled = True
      btnFin.Enabled = True
   End Sub

   Private Sub desHabilitaBarra()
      btnInicio.Enabled = False
      btnHaciaAtras.Enabled = False
      btnHaciaAdelante.Enabled = False
      btnFin.Enabled = False
   End Sub

   Private Sub frmOperacionesAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Try
         Dim oConexion As MySqlConnection
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         Dim dbConsulta As String = ""
         Dim nombreTabla As String = ""
         dbConsulta = "SELECT * FROM analisis"
         nombreTabla = "analisis"
         'EStablecer la posicion del registro a mostrar en la tabla
         Me.iposicFilaActual = 0
         'Cargar columnas del registro en controles del formulario
         llenaDataSet(dbConsulta, nombreTabla)
         Me.cargarDatosAnalisis()
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub llenaDataSet(ByRef dbConsulta As String, ByRef nombreTabla As String)
      Try
         Dim oConexion As New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         'Crear un adaptador, que permite a traves de un evento llamar una consulta que se guarda en un command builder
         Me.oDataAdapter = New MySqlDataAdapter(dbConsulta, oConexion)
         'Crear el command builder para ejecutar las consultas
         Dim oCommBuild As MySqlCommandBuilder = New MySqlCommandBuilder(oDataAdapter)
         'Crear dataset es un almacen de datos desconectado
         Me.oDataSet = New DataSet
         'Abrir la conexion a la BD MySQL
         oConexion.Open()
         'Llenar el adaptador con el conjunto de datos 
         Me.oDataAdapter.Fill(oDataSet, nombreTabla)
         'Cerrar la conexion a la BD
         oConexion.Close()
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try

   End Sub


   Private Sub cargarDatosAnalisis()
      Try
         Dim oDataRow As DataRow
         'Toma la primer fila de la tabla
         oDataRow = oDataSet.Tables("analisis").Rows(Me.iposicFilaActual)
         Me.txtClaveAnalisis.Text = oDataRow("id_analysis")
         Me.txtNombreAnalisis.Text = oDataRow("analysis_desc")
         'Mostrar la posicion actual del registro, los registros comienzan siempre en 0, por ello colocamos +1
         ' para el desplegado en la etiqueta
         lblNRAnalisis.Text = "Registro: " & Me.iposicFilaActual + 1 & " de " & Me.oDataSet.Tables("analisis").Rows.Count
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnHaciaAdelante_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAdelante.Click
      Try
         If Me.iposicFilaActual = (Me.oDataSet.Tables("analisis").Rows.Count - 1) Then
            mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Usted se encuentra en el último registro.")
         Else
            Me.iposicFilaActual += 1
            Me.cargarDatosAnalisis()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
      Try
         'Enviar la posicion del registro al 1er. elemento
         Me.iposicFilaActual = 0
         Me.cargarDatosAnalisis()
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnHaciaAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAtras.Click
      Try
         If Me.iposicFilaActual = 0 Then
            mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Usted se encuentra en el primer registro.")
         Else
            'Disminuir el marcador del registro y actualizar en pantalla con los datos del registro actual
            Me.iposicFilaActual -= 1
            Me.cargarDatosAnalisis()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnFin_Click(sender As System.Object, e As System.EventArgs) Handles btnFin.Click
      Try
         'Ira l ultimo registro colocando la variable al no. máximo de datos en la tabla menos 1 porque las posiciones comienzan en cero
         Me.iposicFilaActual = (Me.oDataSet.Tables("analisis").Rows.Count - 1)
         Me.cargarDatosAnalisis()
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub


   Private Sub btnGuardaAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaAnalisis.Click
      Try
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "INSERT INTO analisis (id_analysis,analysis_desc) VALUES ('" & txtClaveAnalisis.Text & "','" & txtNombreAnalisis.Text & "')"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()

      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
      mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Los datos se han guardado exitosamente.")
      'Recarga los datos
      Dim dbConsulta = "SELECT * FROM analisis"
      Dim nombreTabla = "analisis"
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      txtClaveAnalisis.ReadOnly = True
      txtNombreAnalisis.ReadOnly = True
      habilitaBarra()
      btnInsAnalisis.Enabled = True
      btnDelAnalisis.Enabled = True
      btnBuscaAnalisis.Enabled = True
      btnEditarAnalisis.Enabled = True
      btnGuardaAnalisis.Enabled = False
      btnUpdAnalisis.Enabled = False
      'Cargar columnas del registro en controles del formulario
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosAnalisis()
   End Sub

   Private Sub btnInsAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnInsAnalisis.Click
      txtClaveAnalisis.Text = ""
      txtNombreAnalisis.Text = ""
      frmElisaBiovetsa.lblMensajeAplicacion.Text = ""
      txtClaveAnalisis.ReadOnly = False
      txtNombreAnalisis.ReadOnly = False
      desHabilitaBarra()
      btnInsAnalisis.Enabled = False
      btnGuardaAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = False
      btnEditarAnalisis.Enabled = False
      btnDelAnalisis.Enabled = False
      btnBuscaAnalisis.Enabled = False
   End Sub


   Private Sub btnDelAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAnalisis.Click
      Try
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "DELETE FROM analisis WHERE id_analysis='" & txtClaveAnalisis.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()

      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
      mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: Los datos del análisis se han eliminado exitosamente.")
      habilitaBarra()
      btnInsAnalisis.Enabled = True
      btnGuardaAnalisis.Enabled = False
      btnDelAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = False
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Recarga los datos
      Dim dbConsulta = "SELECT * FROM analisis"
      Dim nombreTabla = "analisis"
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosAnalisis()
   End Sub

   Private Sub btnUpdAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdAnalisis.Click

      Dim resultado As Integer
      Try
         txtNombreAnalisis.ReadOnly = False
         txtClaveAnalisis.ReadOnly = True
         desHabilitaBarra()
         btnInsAnalisis.Enabled = False
         btnGuardaAnalisis.Enabled = False
         btnUpdAnalisis.Enabled = False
         btnDelAnalisis.Enabled = False
         btnBuscaAnalisis.Enabled = False
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "UPDATE analisis SET analysis_desc='" & txtNombreAnalisis.Text & "'" & " WHERE id_analysis='" & txtClaveAnalisis.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()
         mensajeVerde(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: El nombre del análisis se ha actualizado exitosamente.")
         habilitaBarra()
         btnInsAnalisis.Enabled = True
         btnDelAnalisis.Enabled = True
         btnBuscaAnalisis.Enabled = True
         txtNombreAnalisis.ReadOnly = True
         'Recarga los datos
         Dim dbConsulta = "SELECT * FROM analisis"
         Dim nombreTabla = "analisis"
         llenaDataSet(dbConsulta, nombreTabla)
         Me.cargarDatosAnalisis()
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub btnBuscaAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscaAnalisis.Click
      txtClaveAnalisis.ReadOnly = False
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim oDataReader As MySqlDataReader
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT * FROM analisis WHERE id_analysis like '" & txtClaveAnalisis.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         If txtClaveAnalisis.Text = "" Then
            txtNombreAnalisis.Text = ""
            mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje:Escriba un valor en la clave del análisis.")
         Else
            oConexion.Open()
            oDataReader = oComando.ExecuteReader()
            If oDataReader.HasRows Then
               While oDataReader.Read()
                  txtClaveAnalisis.Text = oDataReader("id_analysis")
                  txtNombreAnalisis.Text = oDataReader("analysis_desc")
               End While
               oDataReader.Close()
               'frmElisaBiovetsa.lblMensajeAplicacion.Text = ""
            Else
               mensajeRojo(frmElisaBiovetsa.lblMensajeAplicacion, "Mensaje: No existe un análisis con la clave indicada.")
            End If
            oConexion.Close()
            txtClaveAnalisis.Focus()
            'Verifica que no sea vacia la consulta
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As DataException
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      Catch ex As Exception
         mensajeException(frmElisaBiovetsa.lblMensajeAplicacion, ex)
      End Try
   End Sub

   Private Sub txtClaveAnalisis_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClaveAnalisis.TextChanged
      txtNombreAnalisis.Text = ""
      'frmElisaBiovetsa.lblMensajeAplicacion.Text = ""
   End Sub


   Private Sub btnEditarAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarAnalisis.Click
      'Deshabilitar todos los botones excepto editar y UpdateAnalisis
      desHabilitaBarra()
      btnInsAnalisis.Enabled = False
      btnGuardaAnalisis.Enabled = False
      btnUpdAnalisis.Enabled = True
      btnDelAnalisis.Enabled = False
      btnBuscaAnalisis.Enabled = False
      'Permito la escritura sobre los campos
      txtNombreAnalisis.ReadOnly = False
      txtClaveAnalisis.ReadOnly = True
   End Sub

   Private Sub btnCancelarAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarAnalisis.Click
      Me.Close()
   End Sub
End Class