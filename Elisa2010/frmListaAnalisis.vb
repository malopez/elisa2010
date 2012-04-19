Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmEditarListaAnalisis
   'Indica la posicion del registro de la fila actual
   Dim iposicFilaActual As Integer = 0
   Dim oDataAdapter As MySqlDataAdapter
   Dim oDataSet As DataSet

   Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Dim oConexion As MySqlConnection
      oConexion = New MySqlConnection
      oConexion.ConnectionString = "server=localhost;User Id=bvtselisa;password=password;Persist Security Info=True;database=bvtselisa"

      'Crear un adaptador, que permite a traves de un evento llamar una consulta que se guarda en un command builder
      Me.oDataAdapter = New MySqlDataAdapter("SELECT * FROM tblanalisis", oConexion)

      'Crear el command builder para ejecutar las consultas
      Dim oCommBuild As MySqlCommandBuilder = New MySqlCommandBuilder(oDataAdapter)

      'Crear dataset es un almacen de datos desconectado
      Me.oDataSet = New DataSet

      'Abrir la conexion a la BD MySQL
      oConexion.Open()

      'Llenar el adaptador con el conjunto de datos 

      Me.oDataAdapter.Fill(oDataSet, "tblanalisis")
      'Cerrar la conexion a la BD
      oConexion.Close()

      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0

      'Cargar columnas del registro en controles del formulario
      Me.cargarDatosAnalisis()
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

   Private Sub btnInsAnalisis_Click(sender As System.Object, e As System.EventArgs) Handles btnInsAnalisis.Click
      Me.txtClaveAnalisis.Text = ""
      Me.txtNombreAnalisis.Text = ""
      btnInicio.Enabled = False
      btnHaciaAtras.Enabled = False
      btnHaciaAdelante.Enabled = False
      btnFin.Enabled = False
      btnInsAnalisis.Enabled = False
      btnEditAnalisis.Enabled = True
      btnUpdAnalisis.Enabled = False
      btnDelAnalisis.Enabled = False

   End Sub
  
End Class