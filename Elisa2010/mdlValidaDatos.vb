Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module mdlValidaDatos
   '##################################################
   '# SECCION VALIDACION DE FORMATOS                 #
   '##################################################
   'Utilizada para validación de datos, seleccionando solamente 10 posiciones contando de izquierda a derecha
   Public Function reduceDecimal(ByVal numero As Decimal) As Decimal
      Dim v As Decimal
      v = CDec(Microsoft.VisualBasic.Left(CStr(numero), 10))
      Return v
   End Function

   'Verifica que no sea blanco o de largo mayor a 1 lo escrito en el textbox
   Public Function siNoEsBlanco(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener un valor distinto a blanco.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsLargoUno(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener una letra solamente.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siNoEsBlancoMenorRango(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" Or (textBox.Text.Length >= 3) Then
         MessageBox.Show(nombre & "El control debe tener un valor numérico.")
         textBox.Select()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsEntero(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      Try
         Convert.ToInt32(textBox.Text)
         Return True
      Catch ex As Exception
         MessageBox.Show(nombre & "El valor debe ser un valor numérico.")
         textBox.Select()
         textBox.SelectAll()
         Return False
      End Try
   End Function

   Public Function siEstaEnRango(ByVal textbox As TextBox, ByVal nombre As String, ByVal min As Integer, ByVal max As Integer) As Boolean
      Dim numero As Integer = CInt(textbox.Text)
      If numero < min OrElse numero > max Then
         MessageBox.Show(" El valor " & nombre & "debe ser valor numérico entre " & min & " y " & max)
         textbox.Select()
         textbox.SelectAll()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siLetraEstaEnRango(ByVal textbox As TextBox, ByVal nombre As String, ByVal min As String, ByVal max As String) As Boolean
      Dim letra As String = textbox.Text.ToUpper
      If letra < min OrElse letra > max Then
         MessageBox.Show(" El valor " & nombre & "debe ser una letra entre A y H.")
         textbox.Select()
         textbox.SelectAll()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siValorEsLetra(ByVal textbox As TextBox) As Integer
      Dim letra As String = textbox.Text.ToUpper
      Dim retorno As Integer
      Select Case letra
         Case "A"
            retorno = 0
         Case "B"
            retorno = 1
         Case "C"
            retorno = 2
         Case "D"
            retorno = 3
         Case "E"
            retorno = 4
         Case "F"
            retorno = 5
         Case "G"
            retorno = 6
         Case "H"
            retorno = 7
         Case Else
            MessageBox.Show(" El valor debe ser una letra entre A y H, siValorEsLetra.")
            textbox.Select()
            textbox.SelectAll()
      End Select
      Return CInt(retorno)
   End Function



   'Se utiliza para regresar la letra que corresponde a una columna de excel donde se guardaran los datos de la placa original
   Public Function obtenLetra(ByVal i As Integer) As String
      Dim letra As String = ""
      Select Case i
         Case 0
            letra = "A"
         Case 1
            letra = "B"
         Case 2
            letra = "C"
         Case 3
            letra = "D"
         Case 4
            letra = "E"
         Case 5
            letra = "F"
         Case 6
            letra = "G"
         Case 7
            letra = "H"
         Case Else
            MessageBox.Show("El valor debe ser un número válido entre 1 y 8, obtenLetra.")
      End Select
      Return letra
   End Function

   Public Function controlesValidosLetra(ByVal textbox As TextBox, ByVal nombre As String, _
                                         ByVal min1 As String, ByVal max1 As String) As Boolean
      Return _
         siNoEsBlanco(textbox, nombre) AndAlso
         siEsLargoUno(textbox, nombre) AndAlso
         siLetraEstaEnRango(textbox, nombre, min1, max1)
   End Function

   Public Function controlesValidosNumero(ByVal textbox As TextBox, ByVal nombre As String, _
                                      ByVal min As Integer, ByVal max As Integer) As Boolean
      Return _
         siNoEsBlancoMenorRango(textbox, nombre) AndAlso
         siEsEntero(textbox, nombre) AndAlso
         siEstaEnRango(textbox, nombre, min, max)
   End Function

   Public Function desdeHastaValidos(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtHastaLetra As TextBox, _
                                     ByVal txtDesdeValor As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean = False
      Dim valor1 As Integer = siValorEsLetra(txtDesdeLetra)
      Dim valor2 As Integer = siValorEsLetra(txtHastaLetra)
      Dim valor3 As Integer = CInt(txtDesdeValor.Text)
      Dim valor4 As Integer = CInt(txtHastaValor.Text)
      If (valor1 <= valor2) Then
         If (valor1 = valor2) Then
            If (valor3 <= valor4) Then
               valido = True
            Else
               MessageBox.Show("Los valores introducidos para el rango de datos " & mensaje & " no son válidos, trate nuevamente.")
            End If
         Else
            valido = True
         End If
      Else
         MessageBox.Show("Los valores introducidos para el rango de datos " & mensaje & " no son válidos, trate nuevamente.")
      End If
      Return valido
   End Function


   Public Function validarRangoEntreValores(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
                                            ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean
      Dim valor1 As Integer = siValorEsLetra(txtDesdeLetra)
      Dim valor2 As Integer = siValorEsLetra(txtHastaLetra)
      Dim valor3 As Integer = CInt(txtDesdeValor.Text)
      Dim valor4 As Integer = CInt(txtHastaValor.Text)

      If (valor1 <= valor2) And (valor3 < valor4) Then
         valido = True
      Else
         valido = False
      End If
      'MessageBox.Show("Evaluando " & mensaje & ", con resultado:" & valido)
      Return valido
   End Function

   Public Function validarRangoEntreValores2(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
                                            ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean
      Dim valor1 As Integer = siValorEsLetra(txtDesdeLetra)
      Dim valor2 As Integer = siValorEsLetra(txtHastaLetra)
      Dim valor3 As Integer = CInt(txtDesdeValor.Text)
      Dim valor4 As Integer = CInt(txtHastaValor.Text)

      If (valor1 >= valor2) And (valor3 > valor4) Then
         valido = True
      Else
         valido = False
      End If
      'MessageBox.Show("Evaluando " & mensaje & ", con resultado:" & valido)
      Return valido
   End Function

   'valida que los controles positivos y negativos no sean los mismos valores que desdex-desdey hastax-hastay  de los casos.
   Public Function validarRangoEntreCasosyCPN(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
                                            ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean
      'Dim valor1 As Integer = siValorEsLetra(txtDesdeLetra)
      'Dim valor2 As Integer = siValorEsLetra(txtHastaLetra)
      'Dim valor3 As Integer = CInt(txtDesdeValor.Text)
      'Dim valor4 As Integer = CInt(txtHastaValor.Text)
      Dim valor1 As String = txtDesdeLetra.Text & txtDesdeValor.Text
      Dim valor2 As String = txtHastaLetra.Text & txtHastaValor.Text
      ' If (valor1 <= valor2) And (valor3 <> valor4) Then
      If (valor1.ToUpper = valor2.ToUpper) Then
         MessageBox.Show("El valor entre " & mensaje & " no puede ser igual.")
         valido = False
      Else
         'MessageBox.Show("Entre al else: " & valor1.ToUpper & " , " & valor2.ToUpper)
         valido = True
      End If
      Return valido
   End Function
   '######################################################################
   '# MENSAJES DEFAULT PARA ATRAPAR EXCEPCIONES, Y EN COLOR ROJO Y VERDE #
   '######################################################################

   Public Sub mensajeException(ByRef etiqueta As Label, ByRef ex As Exception)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeExceptionSQL(ByRef etiqueta As Label, ByRef ex As MySqlException)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = "ERROR: " & ex.Message & " " & ex.Number & " " & ex.GetType.ToString
   End Sub

   Public Sub mensajeVerde(ByRef etiqueta As Label, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Green
      etiqueta.Text = mensaje
   End Sub

   Public Sub mensajeRojo(ByRef etiqueta As Label, ByRef mensaje As String)
      etiqueta.ForeColor = System.Drawing.Color.Red
      etiqueta.Text = mensaje
   End Sub
End Module
