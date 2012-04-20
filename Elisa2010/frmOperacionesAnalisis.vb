Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmOperacionesAnalisis



   Dim iposicFilaActual As Integer = 0
   Dim oDataAdapter As MySqlDataAdapter
   Dim oDataSet As DataSet
   Private Sub frmOperacionesAnalisis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Dim oConexion As MySqlConnection
      oConexion = New MySqlConnection
      oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
      Dim dbConsulta As String = ""
      Dim nombreTabla As String = ""
      dbConsulta = "SELECT * FROM tblanalisis"
      nombreTabla = "tblanalisis"
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Cargar columnas del registro en controles del formulario
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosAnalisis()
   End Sub

   Private Sub llenaDataSet(ByRef dbConsulta As String, ByRef nombreTabla As String)
      Dim oConexion As New MySqlConnection
      oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
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
   End Sub


   Private Sub cargarDatosAnalisis()
      Dim oDataRow As DataRow
      'Toma la primer fila de la tabla
      oDataRow = oDataSet.Tables("tblanalisis").Rows(Me.iposicFilaActual)
      Me.txtClaveAnalisis.Text = oDataRow("idAnalisis")
      Me.txtNombreAnalisis.Text = oDataRow("nombreAnalisis")
      'Mostrar la posicion actual del registro, los registros comienzan siempre en 0, por ello colocamos +1
      ' para el desplegado en la etiqueta
      Me.lblNRAnalisis.Text = "Registro: " & Me.iposicFilaActual + 1 & " de " & Me.oDataSet.Tables("tblanalisis").Rows.Count
   End Sub

   Private Sub btnHaciaAdelante_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAdelante.Click
      If Me.iposicFilaActual = (Me.oDataSet.Tables("tblanalisis").Rows.Count - 1) Then
         MessageBox.Show("Usted se encuentra en el último registro.")
      Else
         Me.iposicFilaActual += 1
         Me.cargarDatosAnalisis()
      End If
   End Sub

   Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
      'Enviar la posicion del registro al 1er. elemento
      Me.iposicFilaActual = 0
      Me.cargarDatosAnalisis()
   End Sub

   Private Sub btnHaciaAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAtras.Click
      If Me.iposicFilaActual = 0 Then
         MessageBox.Show("Usted se encuentra en el primer registro.")
      Else
         'Disminuir el marcador del registro y actualizar en pantalla con los datos del registro actual
         Me.iposicFilaActual -= 1
         Me.cargarDatosAnalisis()
      End If
   End Sub

   Private Sub btnFin_Click(sender As System.Object, e As System.EventArgs) Handles btnFin.Click
      'Ira l ultimo registro colocando la variable al no. máximo de datos en la tabla menos 1 porque las posiciones comienzan en cero
      Me.iposicFilaActual = (Me.oDataSet.Tables("tblanalisis").Rows.Count - 1)
      Me.cargarDatosAnalisis()
   End Sub


   Private Sub btnGuardaAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaAnalisis.Click
      Try
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
         aConsulta = "INSERT INTO tblanalisis (tblanalisis.idAnalisis,tblanalisis.nombreAnalisis) VALUES ('" & txtClaveAnalisis.Text & "','" & txtNombreAnalisis.Text & "')"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Green
         lblMensajeAnalisis.Text = "Mensaje: Los datos se han guardado exitosamente."
      Catch ex As MySqlException
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Red
         lblMensajeAnalisis.Text = "ERROR:: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
      Catch ex As DataException
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Red
         lblMensajeAnalisis.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      End Try
      btnInicio.Enabled = True
      btnHaciaAtras.Enabled = True
      btnHaciaAdelante.Enabled = True
      btnFin.Enabled = True
      btnInsAnalisis.Enabled = True
      btnGuardaAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = True
      btnDelAnalisis.Enabled = True
      'Recarga los datos
      Dim dbConsulta = "SELECT * FROM tblanalisis"
      Dim nombreTabla = "tblanalisis"
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Cargar columnas del registro en controles del formulario
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosAnalisis()
   End Sub

   Private Sub btnInsAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnInsAnalisis.Click
      txtClaveAnalisis.Text = ""
      txtNombreAnalisis.Text = ""
      txtClaveAnalisis.ReadOnly = False
      txtNombreAnalisis.ReadOnly = False
      btnInicio.Enabled = False
      btnHaciaAtras.Enabled = False
      btnHaciaAdelante.Enabled = False
      btnFin.Enabled = False
      btnInsAnalisis.Enabled = False
      btnGuardaAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = False
      btnDelAnalisis.Enabled = False
   End Sub


   Private Sub btnDelAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnDelAnalisis.Click
      Try
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"
         aConsulta = "DELETE FROM tblanalisis WHERE idAnalisis='" & txtClaveAnalisis.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Green
         lblMensajeAnalisis.Text = "Mensaje: Los datos del análisis se han eliminado exitosamente."
      Catch ex As MySqlException
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Red
         lblMensajeAnalisis.Text = "ERROR:: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
      Catch ex As DataException
         lblMensajeAnalisis.ForeColor = System.Drawing.Color.Red
         lblMensajeAnalisis.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      End Try
      btnInicio.Enabled = True
      btnHaciaAtras.Enabled = True
      btnHaciaAdelante.Enabled = True
      btnFin.Enabled = True
      btnInsAnalisis.Enabled = True
      btnGuardaAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = True
      btnDelAnalisis.Enabled = True
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Recarga los datos
      Dim dbConsulta = "SELECT * FROM tblanalisis"
      Dim nombreTabla = "tblanalisis"
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosAnalisis()
   End Sub



   Private Sub btnCancelarAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarAnalisis.Click
      Me.Close()
   End Sub

End Class