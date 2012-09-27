Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmConfiguraLector
   Const cadenaConexion As String = "server=biobuntu;User Id=bvtselisa;password=password;Persist Security Info=True;database=elisasandbox"
   Dim iposicFilaActual As Integer = 0
   Dim oDataAdapter As MySqlDataAdapter
   Dim oDataSet As DataSet

   Private Sub btnCancelaCL_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelaCL.Click
      Me.Close()
   End Sub

   Private Sub frmConfiguraLector_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Dim oConexion As MySqlConnection
      oConexion = New MySqlConnection
      oConexion.ConnectionString = cadenaConexion
      Dim dbConsulta As String = ""
      Dim nombreTabla As String = ""
      dbConsulta = "SELECT * FROM tbllector;"
      nombreTabla = "tbllector"
      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Cargar columnas del registro en controles del formulario
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosLector()
   End Sub


   Private Sub llenaDataSet(ByRef dbConsulta As String, ByRef nombreTabla As String)
      Try
         Dim oConexion As New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
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
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
         'etiquetaMensaje.ForeColor = System.Drawing.Color.Red
         'etiquetaMensaje.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
      End Try
   End Sub

   Private Sub marcaParidad(ByVal paridadLector As Integer)
      Dim paridad As Integer = paridadLector
      Select Case paridad
         Case 0
            Me.rdbParidadNone.Checked = True
         Case 1
            Me.rdbParidadOdd.Checked = True
         Case 2
            Me.rdbParidadEven.Checked = True
         Case 3
            Me.rdbParidadMark.Checked = True
         Case 4
            Me.rdbParidadSpace.Checked = True
      End Select
   End Sub

   Private Function obtenParidad() As Integer
      Dim valorparidad As Integer
      If Me.rdbParidadNone.Checked = True Then
         valorparidad = 0
      End If
      If Me.rdbParidadOdd.Checked = True Then
         valorparidad = 1
      End If
      If Me.rdbParidadEven.Checked = True Then
         valorparidad = 2
      End If
      If Me.rdbParidadMark.Checked = True Then
         valorparidad = 3
      End If
      If Me.rdbParidadSpace.Checked = True Then
         valorparidad = 4
      End If
      Return (valorparidad)
   End Function


   Private Sub marcaBDD(ByVal bitsLector As Integer)
      Dim bits As Integer = bitsLector
      Select Case bits
         Case 4
            Me.rdbBDD4.Checked = True
         Case 5
            Me.rdbBDD5.Checked = True
         Case 6
            Me.rdbBDD6.Checked = True
         Case 7
            Me.rdbBDD7.Checked = True
         Case 8
            Me.rdbBDD8.Checked = True
      End Select
   End Sub

   Private Function obtenBDD() As Integer
      Dim bits As Integer
      If Me.rdbBDD4.Checked = True Then
         bits = 4
      End If
      If Me.rdbBDD5.Checked = True Then
         bits = 5
      End If
      If Me.rdbBDD6.Checked = True Then
         bits = 6
      End If
      If Me.rdbBDD7.Checked = True Then
         bits = 7
      End If
      If Me.rdbBDD8.Checked = True Then
         bits = 8
      End If
      Return (bits)
   End Function

   Private Sub marcaSB(ByVal stopBitsLector As Integer)
      Dim bits As Integer = stopBitsLector
      Select Case bits
         Case 1
            Me.rdbStopB1.Checked = True
         Case 2
            Me.rdbStopB2.Checked = True
      End Select
   End Sub

   Private Function obtenSB() As Integer
      Dim sblector As Integer
      If Me.rdbStopB1.Checked = True Then
         sblector = 1
      End If
      If Me.rdbStopB2.Checked = True Then
         sblector = 2
      End If
      Return (sblector)
   End Function

   Private Sub marcaBPS(ByVal bitsLector As Integer)
      Dim bits As Integer = bitsLector
      Select Case bits
         Case 110
            Me.rdbBPS110.Checked = True
         Case 300
            Me.rdbBPS300.Checked = True
         Case 600
            Me.rdbBPS600.Checked = True
         Case 1200
            Me.rdbBPS1200.Checked = True
         Case 2400
            Me.rdbBPS2400.Checked = True
         Case 4800
            Me.rdbBPS4800.Checked = True
         Case 9600
            Me.rdbBPS9600.Checked = True
         Case 19200
            Me.rdbBPS19200.Checked = True
      End Select
   End Sub

   Private Function obtenBPS() As Integer
      Dim bps As Integer
      If Me.rdbBPS110.Checked = True Then
         bps = 110
      End If
      If Me.rdbBPS300.Checked = True Then
         bps = 300
      End If
      If Me.rdbBPS600.Checked = True Then
         bps = 600
      End If
      If Me.rdbBPS1200.Checked = True Then
         bps = 1200
      End If
      If Me.rdbBPS2400.Checked = True Then
         bps = 2400
      End If
      If Me.rdbBPS4800.Checked = True Then
         bps = 4800
      End If
      If Me.rdbBPS9600.Checked = True Then
         bps = 9600
      End If
      If Me.rdbBPS19200.Checked = True Then
         bps = 19200
      End If
      Return (bps)
   End Function


   Private Sub marcaLectorDefault(ByVal lectorDefault As Integer)
      If lectorDefault = 1 Then
         chkLectorDefault.Checked = True
      Else
         chkLectorDefault.Checked = False
      End If
   End Sub

   Private Function obtenLectorDefault() As Integer
      Dim lectorDefault As Integer
      If chkLectorDefault.Checked = True Then
         lectorDefault = 1
      Else
         lectorDefault = 0
      End If
      Return (lectorDefault)
   End Function

   Private Sub desHabilitaBarra()
      btnInicio.Enabled = False
      btnHaciaAtras.Enabled = False
      btnHaciaAdelante.Enabled = False
      btnFin.Enabled = False
   End Sub

   Private Sub habilitaBarra()
      btnInicio.Enabled = True
      btnHaciaAtras.Enabled = True
      btnHaciaAdelante.Enabled = True
      btnFin.Enabled = True
   End Sub

   Private Sub habilitaGroupBox()
      gpbBPS.Enabled = True
      gpbBDD.Enabled = True
      gpbParidad.Enabled = True
      gpbSB.Enabled = True
   End Sub

   Private Sub deshabilitaGroupBox()
      gpbBPS.Enabled = False
      gpbBDD.Enabled = False
      gpbParidad.Enabled = False
      gpbSB.Enabled = False
   End Sub


   Private Sub cargarDatosLector()
      Try
         Dim nomLector As String
         Dim bpsLector As Integer
         Dim paridadLector As Integer
         Dim bitsLector As Integer
         Dim stopBitsLector As Integer
         Dim lectorDefault As Integer
         Dim oDataRow As DataRow
         'Toma la primer fila de la tabla
         oDataRow = oDataSet.Tables("tbllector").Rows(Me.iposicFilaActual)
         Me.txtNombreLector.Text = oDataRow("nomLector")
         nomLector = oDataRow("nomLector")
         bpsLector = oDataRow("bpsLector")
         marcaBPS(bpsLector)
         paridadLector = oDataRow("paridadLector")
         marcaParidad(paridadLector)
         bitsLector = oDataRow("bitsLector")
         marcaBDD(bitsLector)
         stopBitsLector = oDataRow("stopBitsLector")
         marcaSB(stopBitsLector)
         lectorDefault = oDataRow("lectorDefault")
         marcaLectorDefault(lectorDefault)
         'Mostrar la posicion actual del registro, los registros comienzan siempre en 0, por ello colocamos +1
         ' para el desplegado en la etiqueta
         Me.lblNRLector.Text = "Registro: " & Me.iposicFilaActual + 1 & " de " & Me.oDataSet.Tables("tbllector").Rows.Count
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try

   End Sub

   Private Sub btnHaciaAdelante_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAdelante.Click
      Try
         If Me.iposicFilaActual = (Me.oDataSet.Tables("tbllector").Rows.Count - 1) Then
            etiquetaMensaje.ForeColor = System.Drawing.Color.Red
            etiquetaMensaje.Text = "Mensaje: Usted se encuentra en el último registro."
         Else
            Me.iposicFilaActual += 1
            Me.cargarDatosLector()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
      Try
         'Enviar la posicion del registro al 1er. elemento
         etiquetaMensaje.Text = ""
         Me.iposicFilaActual = 0
         Me.cargarDatosLector()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnHaciaAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnHaciaAtras.Click
      Try
         etiquetaMensaje.Text = ""
         If Me.iposicFilaActual = 0 Then
            etiquetaMensaje.ForeColor = System.Drawing.Color.Red
            etiquetaMensaje.Text = "Mensaje: Usted se encuentra en el primer registro."
         Else
            'Disminuir el marcador del registro y actualizar en pantalla con los datos del registro actual
            Me.iposicFilaActual -= 1
            Me.cargarDatosLector()
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnFin_Click(sender As System.Object, e As System.EventArgs) Handles btnFin.Click
      Try
         'Ira al ultimo registro colocando la variable al no. máximo de datos en la tabla menos 1 porque las posiciones comienzan en cero
         Me.iposicFilaActual = (Me.oDataSet.Tables("tbllector").Rows.Count - 1)
         Me.cargarDatosLector()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnInsertar_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertar.Click
      Try
         txtNombreLector.Text = ""
         etiquetaMensaje.Text = ""
         txtNombreLector.ReadOnly = False
         desHabilitaBarra()
         btnInsertar.Enabled = False
         btnActualizar.Enabled = False
         btnEditar.Enabled = False
         btnBorrar.Enabled = False
         btnGuardar.Enabled = True
         chkLectorDefault.Enabled = True
         habilitaGroupBox()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
      Dim nomLector As String
      Dim bpsLector As Integer
      Dim paridadLector As Integer
      Dim bitsLector As Integer
      Dim stopBitsLector As Integer
      Dim lectorDefault As Integer
      Try
         bpsLector = obtenBPS()
         paridadLector = obtenParidad()
         bitsLector = obtenBDD()
         stopBitsLector = obtenSB()
         nomLector = txtNombreLector.Text
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim aConsulta1 As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         oComando.Connection = oConexion
         lectorDefault = obtenLectorDefault()
         If lectorDefault = 1 Then
            Try
               aConsulta = "UPDATE tbllector SET lectorDefault=0"
               oConexion.Open()
               oComando.CommandText = aConsulta
               resultado = oComando.ExecuteNonQuery()
               aConsulta1 = "INSERT INTO tbllector (nomLector,bpsLector,paridadLector,bitsLector,stopBitsLector,lectorDefault) VALUES ('" & nomLector & "'," & bpsLector & "," & paridadLector & "," & bitsLector & "," & stopBitsLector & "," & lectorDefault & ");"
               oComando.CommandText = aConsulta1
               resultado = oComando.ExecuteNonQuery()
               oConexion.Close()
               mensajeVerde(etiquetaMensaje, "Mensaje: Los datos se han guardado exitosamente.")
               'etiquetaMensaje.ForeColor = System.Drawing.Color.Green
               'etiquetaMensaje.Text = "Mensaje: Los datos se han guardado exitosamente."
            Catch ex As MySqlException
               mensajeExceptionSQL(etiquetaMensaje, ex)
            Catch ex As DataException
               mensajeException(etiquetaMensaje, ex)
            Catch ex As Exception
               mensajeException(etiquetaMensaje, ex)
            End Try
         Else
            Try
               lectorDefault = 0
               aConsulta1 = "INSERT INTO tbllector (nomLector,bpsLector,paridadLector,bitsLector,stopBitsLector,lectorDefault) VALUES ('" & nomLector & "'," & bpsLector & "," & paridadLector & "," & bitsLector & "," & stopBitsLector & "," & lectorDefault & ");"
               oComando.CommandText = aConsulta1
               oConexion.Open()
               resultado = oComando.ExecuteNonQuery()
               oConexion.Close()
               etiquetaMensaje.ForeColor = System.Drawing.Color.Green
               etiquetaMensaje.Text = "Mensaje: Los datos se han guardado exitosamente."
            Catch ex As MySqlException
               mensajeExceptionSQL(etiquetaMensaje, ex)
            Catch ex As DataException
               mensajeException(etiquetaMensaje, ex)
            Catch ex As Exception
               mensajeException(etiquetaMensaje, ex)
            End Try
         End If
         'Recarga los datos
         Dim dbConsulta = "SELECT * FROM tbllector"
         Dim nombreTabla = "tbllector"
         'EStablecer la posicion del registro a mostrar en la tabla
         Me.iposicFilaActual = 0
         txtNombreLector.ReadOnly = True
         habilitaBarra()
         btnInsertar.Enabled = True
         btnBorrar.Enabled = True
         btnEditar.Enabled = True
         btnGuardar.Enabled = False
         btnActualizar.Enabled = False
         'Cargar columnas del registro en controles del formulario
         llenaDataSet(dbConsulta, nombreTabla)
         Me.cargarDatosLector()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try

   End Sub

   Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
      Try
         'Crear la conexion a la BD
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim resultado As Integer
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "DELETE FROM tbllector WHERE nomLector='" & txtNombreLector.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()
         etiquetaMensaje.ForeColor = System.Drawing.Color.Green
         etiquetaMensaje.Text = "Mensaje: Los datos del lector se han eliminado exitosamente."
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
      habilitaBarra()
      btnInsertar.Enabled = True
      btnGuardar.Enabled = False
      btnBorrar.Enabled = True
      btnActualizar.Enabled = False
      chkLectorDefault.Enabled = False
      deshabilitaGroupBox()

      'EStablecer la posicion del registro a mostrar en la tabla
      Me.iposicFilaActual = 0
      'Recarga los datos
      Dim dbConsulta = "SELECT * FROM tbllector"
      Dim nombreTabla = "tbllector"
      llenaDataSet(dbConsulta, nombreTabla)
      Me.cargarDatosLector()
   End Sub

   Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
      Dim resultado As Integer
      Try
         txtNombreLector.ReadOnly = False
         desHabilitaBarra()
         btnInsertar.Enabled = False
         btnGuardar.Enabled = False
         btnActualizar.Enabled = False
         btnBorrar.Enabled = False
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "UPDATE tbllector SET analysis_desc='" & txtNombreLector.Text & "'" & " WHERE nomLector like '" & txtNombreLector.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         oConexion.Open()
         resultado = oComando.ExecuteNonQuery()
         oConexion.Close()
         etiquetaMensaje.ForeColor = System.Drawing.Color.Green
         etiquetaMensaje.Text = "Mensaje: El nombre del lector se ha actualizado exitosamente."
         habilitaBarra()
         btnInsertar.Enabled = True
         btnBorrar.Enabled = True
         'Recarga los datos
         Dim dbConsulta = "SELECT * FROM tbllector"
         Dim nombreTabla = "tbllector"
         llenaDataSet(dbConsulta, nombreTabla)
         Me.cargarDatosLector()
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs)
      txtNombreLector.ReadOnly = False
      Try
         Dim oConexion As MySqlConnection
         Dim aConsulta As String = ""
         Dim oComando As New MySqlCommand
         Dim oDataReader As MySqlDataReader
         oConexion = New MySqlConnection
         oConexion.ConnectionString = cadenaConexion
         aConsulta = "SELECT * FROM tbllector WHERE nomLector like '" & txtNombreLector.Text & "'" & ";"
         oComando.Connection = oConexion
         oComando.CommandText = aConsulta
         If txtNombreLector.Text = "" Then

            etiquetaMensaje.ForeColor = System.Drawing.Color.Red
            etiquetaMensaje.Text = "Mensaje: Escriba un nombre de Lector válido."
         Else
            oConexion.Open()
            oDataReader = oComando.ExecuteReader()
            If oDataReader.HasRows Then
               While oDataReader.Read()
                  txtNombreLector.Text = oDataReader("nomLector")

               End While
               oDataReader.Close()
               'etiquetaMensaje.Text = ""
            Else
               etiquetaMensaje.ForeColor = System.Drawing.Color.Red
               etiquetaMensaje.Text = "Mensaje: No existe un lector con el nombre indicado."
            End If
            oConexion.Close()
            txtNombreLector.Focus()
            'Verifica que no sea vacia la consulta
         End If
      Catch ex As MySqlException
         mensajeExceptionSQL(etiquetaMensaje, ex)
      Catch ex As DataException
         mensajeException(etiquetaMensaje, ex)
      Catch ex As Exception
         mensajeException(etiquetaMensaje, ex)
      End Try
   End Sub

   Private Sub txtNombreLector_TextChanged(sender As System.Object, e As System.EventArgs)
      txtNombreLector.Text = ""
   End Sub

   Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
      'Deshabilitar todos los botones excepto editar y Actualizar
      desHabilitaBarra()
      btnInsertar.Enabled = False
      btnGuardar.Enabled = False
      btnActualizar.Enabled = True
      btnBorrar.Enabled = False
      'Permito la escritura sobre los campos
      txtNombreLector.ReadOnly = False
   End Sub

End Class