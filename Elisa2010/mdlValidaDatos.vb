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
         textBox.SelectAll()
         textBox.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siEsLargoUno(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & "El control debe tener una letra solamente.")
         textBox.Select()
         textBox.SelectAll()
         textBox.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siValorNoEsBlanco(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
      If textBox.Text = "" And textBox.Text.Length > 1 Then
         MessageBox.Show(nombre & ". El control debe tener un valor numérico.")
         textBox.Select()
         textBox.SelectAll()
         textBox.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   Public Function siComboNoEsBlanco(ByVal combo As ComboBox, ByVal nombre As String) As Boolean
      If combo.Text = "" Then
         MessageBox.Show(nombre & ". El No. de Caso debe tener un valor.")
         combo.Select()
         combo.SelectAll()
         combo.Focus()
         Return False
      Else
         Return True
      End If
   End Function

   'Public Function siMenorRango(ByVal textBox As TextBox, ByVal nombre As String) As Boolean
   '   If (textBox.Text.Length >= 3) Then
   '      MessageBox.Show(nombre & "El control debe tener un valor numérico.")
   '      textBox.Focus()
   '      Return False
   '   Else
   '      Return True
   '   End If
   'End Function


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

   Public Function validaSiDosCasosEstanEnDistintoRango(ByVal mensaje As String, ByVal txtDesdeLetra1 As TextBox, ByVal txtDesdeValor1 As TextBox, _
                              ByVal txtHastaLetra1 As TextBox, ByVal txtHastaValor1 As TextBox, _
                              ByVal txtDesdeLetraRango1 As TextBox, ByVal txtDesdeValorRango1 As TextBox, _
                              ByVal txtHastaLetraRango2 As TextBox, ByVal txtHastaValorRango2 As TextBox) As Boolean
      Dim mismoDesde As Boolean
      Dim mismoHasta As Boolean

      Dim temporal As String = CStr(regresaValor(txtDesdeLetra1)) & txtDesdeValor1.Text.PadLeft(2, "0")
      Dim desde As Integer = CInt(temporal)

      temporal = CStr(regresaValor(txtHastaLetra1)) & txtHastaValor1.Text.PadLeft(2, "0")
      Dim hasta As Integer = CInt(temporal)

      temporal = CStr(regresaValor(txtDesdeLetraRango1)) & txtDesdeValorRango1.Text.PadLeft(2, "0")
      Dim rango1 As Integer = CInt(temporal)

      temporal = CStr(regresaValor(txtHastaLetraRango2)) & txtHastaValorRango2.Text.PadLeft(2, "0")
      Dim rango2 As Integer = CInt(temporal)

      'MessageBox.Show(mensaje & ": El valor Desde:" & desde & ", hasta: " & hasta & ", rango1: " & rango1 & ",rango2:" & rango2)

      Select Case desde
         Case rango1 To rango2
            mismoDesde = True
            'MessageBox.Show("El " & mensaje & ", se encuentran en el mismo rango de valores.")
         Case Else
            mismoDesde = False
      End Select

      Select Case hasta
         Case rango1 To rango2
            mismoHasta = True
            'MessageBox.Show("El " & mensaje & ", se encuentran en el mismo rango de valores.")
         Case Else
            mismoHasta = False
      End Select
      'MessageBox.Show("Valor de mismoDesde:" & mismoDesde & ", valor de mismoHasta:" & mismoHasta)
      If (mismoDesde Or mismoHasta) Then
         MessageBox.Show("El " & mensaje & ", se encuentran en el mismo rango de valores.")
         Return False
      Else
         Return True
      End If
   End Function


   Public Function validaSiControlPNEstaEnRangoDeCaso(ByVal controlPN As String, ByVal caso As String, ByVal txtDesdeLetra1 As TextBox, ByVal txtDesdeValor1 As TextBox, _
                                     ByVal txtDesdeLetraRango1 As TextBox, ByVal txtDesdeValorRango1 As TextBox, _
                                     ByVal txtHastaLetraRango2 As TextBox, ByVal txtHastaValorRango2 As TextBox) As Boolean
      Dim igualDesde As Boolean

      Dim temporal As String = CStr(regresaValor(txtDesdeLetra1)) & txtDesdeValor1.Text.PadLeft(2, "0")
      Dim desde As Integer = CInt(temporal)

      temporal = CStr(regresaValor(txtDesdeLetraRango1)) & txtDesdeValorRango1.Text.PadLeft(2, "0")
      Dim rango1 As Integer = CInt(temporal)

      temporal = CStr(regresaValor(txtHastaLetraRango2)) & txtHastaValorRango2.Text.PadLeft(2, "0")
      Dim rango2 As Integer = CInt(temporal)

      ' MessageBox.Show(mensaje & ": El valor Desde:" & desde & ", hasta: " & hasta & ", rango1: " & rango1 & ",rango2:" & rango2)

      Select Case desde
         Case rango1 To rango2
            igualDesde = True
         Case Else
            igualDesde = False
      End Select

      If igualDesde Then
         MessageBox.Show("ERROR: El " & controlPN & ", se encuentra en el rango de valores del " & caso & ".")
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

   Public Function regresaValor(ByVal textbox As TextBox) As Integer
      Dim letra As String = textbox.Text.ToUpper
      Dim retorno As Integer
      Select Case letra
         Case "A"
            retorno = 1
         Case "B"
            retorno = 2
         Case "C"
            retorno = 3
         Case "D"
            retorno = 4
         Case "E"
            retorno = 5
         Case "F"
            retorno = 6
         Case "G"
            retorno = 7
         Case "H"
            retorno = 8
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
         siValorNoEsBlanco(textbox, nombre) AndAlso _
         siEsEntero(textbox, nombre) AndAlso _
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
   'Permite comprobar los valores de los controles positivos y negativos en base a la siguiente tabla
   'Utilizando  comprobarValoresCPN y comprobarValoresCPN2
   'Tabla de validación de los controles positivos y negativos.
   'cp1	cp2	cp3	cn1	cn2	cn3
   'cp1	-	<	<	<	<	<
   'cp2	>	-	<	>	<	<
   'cp3	>	>	-	>	>	<
   'cn1	>	<	<	-	<	<
   'cn2	>	>	<	>	-	<
   'cn3	>	>	>	>	>	-

   Public Function comprobarValoresCPN(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
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

   Public Function comprobarValoresCPN2(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
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
      Return valido
   End Function

   'valida que los controles positivos y negativos no sean los mismos valores que desdex-desdey hastax-hastay  de los casos.
   Public Function validarValorDistinto(ByVal mensaje As String, ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox,
                                            ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim valido As Boolean
      Dim valor1 As String = txtDesdeLetra.Text & txtDesdeValor.Text
      Dim valor2 As String = txtHastaLetra.Text & txtHastaValor.Text
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
