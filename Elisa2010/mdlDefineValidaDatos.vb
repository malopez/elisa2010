Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Module mdlDefineValidaDatos


   Public Structure miRGB
      Dim R As Integer
      Dim G As Integer
      Dim B As Integer
   End Structure

   Public Structure listaCasos
      Dim noCaso As String
      Dim noSubcasos As Integer
      Dim subCaso As Integer
      Dim cliente As String
      Dim analisis As String
      Dim texto As String
      Dim obs As String
      Dim desdeLetra As Integer
      Dim desdeValor As Integer
      Dim hastaLetra As Integer
      Dim hastaValor As Integer
   End Structure



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

   Public Function queSeanDistintos(ByRef etiqueta As Label, ByVal mensaje As String, ByVal txtDesdeLetra1 As TextBox, _
                                    ByVal txtDesdeValor1 As TextBox, ByVal txtHastaLetra1 As TextBox, _
                                    ByVal txtHastaValor1 As TextBox) As Boolean

      Dim temporal As String = CStr(regresaValor(txtDesdeLetra1)) & txtDesdeValor1.Text.PadLeft(2, "0")
      Dim desde As Integer = CInt(temporal)
      Dim valido As Boolean
      temporal = CStr(regresaValor(txtHastaLetra1)) & txtHastaValor1.Text.PadLeft(2, "0")
      Dim hasta As Integer = CInt(temporal)

      If (desde <> hasta) Then
         valido = True
      Else
         valido = False
         mensajeRojo(etiqueta, "Los valores de " & mensaje & " no pueden ser iguales, verifíquelos.")
      End If
      Return valido
   End Function

   '####AGREGADOS EL 10-AGO-2012
   'Estas funcion se utilizan para el caso de 1 caso con n subcasos.
   Public Function validaTodosLosCPParaUnCaso(ByVal caso As String, ByVal nocp As Integer, _
                                               ByVal txtCP1Letra1 As TextBox, ByVal txtCP1Valor1 As TextBox, _
                                               ByVal txtCP2Letra2 As TextBox, ByVal txtCP2Valor2 As TextBox, _
                                               ByVal txtCP3Letra3 As TextBox, ByVal txtCP3Valor3 As TextBox, _
                                               ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                                               ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim ok As Boolean
      If (nocp = 2) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CP 1", caso, txtCP1Letra1, txtCP1Valor1, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 2", caso, txtCP2Letra2, txtCP2Valor2, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor)
      ElseIf (nocp = 3) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CP 1", caso, txtCP1Letra1, txtCP1Valor1, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 2", caso, txtCP2Letra2, txtCP2Valor2, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CP 3", caso, txtCP3Letra3, txtCP3Valor3, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor)
      End If
      Return ok
   End Function
   'Estas funcion se utilizan para el caso de 1 caso con n subcasos.
   Public Function validaTodosLosCNParaUnCaso(ByVal caso As String, ByVal nocp As Integer, _
                                               ByVal txtCN1Letra1 As TextBox, ByVal txtCN1Valor1 As TextBox, _
                                               ByVal txtCN2Letra2 As TextBox, ByVal txtCN2Valor2 As TextBox, _
                                               ByVal txtCN3Letra3 As TextBox, ByVal txtCN3Valor3 As TextBox, _
                                               ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                                               ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox) As Boolean
      Dim ok As Boolean
      If (nocp = 2) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CN 1", caso, txtCN1Letra1, txtCN1Valor1, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 2", caso, txtCN2Letra2, txtCN2Valor2, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor)
      ElseIf (nocp = 3) Then
         ok = validaSiControlPNEstaEnRangoDeCaso("CN 1", caso, txtCN1Letra1, txtCN1Valor1, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 2", caso, txtCN2Letra2, txtCN2Valor2, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor) AndAlso _
              validaSiControlPNEstaEnRangoDeCaso("CN 3", caso, txtCN3Letra3, txtCN3Valor3, txtDesdeLetra, txtDesdeValor, txtHastaLetra, txtHastaValor)
      End If
      Return ok
   End Function

   'Valida dos casos en distinto rango tomando valores desde un textbox y un arreglo, 
   'se inserta primero el nuevo valor del textbox vs. el ya existente en el arreglo
   Public Function validaSiDosCasosEstanEnDistintoRangoArreglo( _
                              ByVal mensaje As String, _
                              ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                              ByVal txtHastaLetra As TextBox, ByVal txtHastaValor As TextBox, _
                              ByVal letraRango1 As Integer, ByVal valorRango1 As Integer, _
                              ByVal letraRango2 As Integer, ByVal valorRango2 As Integer) As Boolean
      Dim mismoDesde As Boolean
      Dim mismoHasta As Boolean

      Dim valorDesde As String = CStr(valorRango1)
      Dim valorHasta As String = CStr(valorRango2)
      Dim td As Integer = siValorEsLetra(txtDesdeLetra)

      Dim temporal As String = td & txtDesdeValor.Text.PadLeft(2, "0")
      Dim desde As Integer = CInt(temporal)

      Dim th As Integer = siValorEsLetra(txtHastaLetra)
      temporal = th & txtHastaValor.Text.PadLeft(2, "0")
      Dim hasta As Integer = CInt(temporal)

      temporal = CStr(letraRango1) & valorDesde.PadLeft(2, "0")
      Dim rango1 As Integer = CInt(temporal)

      temporal = CStr(letraRango2) & valorHasta.PadLeft(2, "0")
      Dim rango2 As Integer = CInt(temporal)

      'MessageBox.Show("Valores desde: " & desde & vbCrLf & " hasta: " & hasta & vbCrLf _
      '                & " letraRango1: " & letraRango1 & vbCrLf & " letraRango2: " & letraRango2 & vbCrLf _
      '                & " rango1: " & rango1 & vbCrLf & " rango2 :" & rango2)

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
         'MessageBox.Show("El " & mensaje & ", se encuentran en el mismo rango de valores.")
         Return False
      Else
         Return True
      End If
   End Function


   '10-AGO-2012 #######



   Public Function validaSiControlPNEstaEnRangoDeCaso(ByVal mensaje As String, ByVal caso As String, _
                                                      ByVal txtDesdeLetra As TextBox, ByVal txtDesdeValor As TextBox, _
                                                      ByVal txtDesdeLetraRango1 As TextBox, ByVal txtDesdeValorRango1 As TextBox, _
                                                      ByVal txtHastaLetraRango2 As TextBox, ByVal txtHastaValorRango2 As TextBox) As Boolean
      Dim igualDesde As Boolean

      Dim temporal As String = CStr(regresaValor(txtDesdeLetra)) & txtDesdeValor.Text.PadLeft(2, "0")
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
         MessageBox.Show("ERROR: El " & mensaje & ", se encuentra en el rango de valores del " & caso & ".")
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

   Public Sub defineBotonesNegativos(ByVal nocn As Integer, ByRef lblCNNo1 As Label, _
                                      ByRef lblCNNo2 As Label, ByRef lblCNNo3 As Label, _
                                      ByRef txtCN1Letra1 As TextBox, ByRef txtCN1Valor1 As TextBox, _
                                      ByRef txtCN2Letra2 As TextBox, ByRef txtCN2Valor2 As TextBox, _
                                      ByRef txtCN3Letra3 As TextBox, ByRef txtCN3Valor3 As TextBox)
      Select Case nocn
         Case 2
            'Hace visible las etiquetas para dos controles negativos
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = False
            'Hace visible controles negativos para dos controles
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = False
            txtCN3Valor3.Visible = False
         Case 3
            'Hace visible las etiquetas para ontrolesnegativos
            lblCNNo1.Visible = True
            lblCNNo2.Visible = True
            lblCNNo3.Visible = True
            'Hace visible controles negativos 
            txtCN1Letra1.Visible = True
            txtCN1Valor1.Visible = True
            txtCN2Letra2.Visible = True
            txtCN2Valor2.Visible = True
            txtCN3Letra3.Visible = True
            txtCN3Valor3.Visible = True
      End Select
   End Sub


   Public Sub defineBotonesPositivos(ByVal nocp As Integer, ByRef lblCPNo1 As Label, _
                                      ByRef lblCPNo2 As Label, ByRef lblCPNo3 As Label, _
                                      ByRef txtCP1Letra1 As TextBox, ByRef txtCP1Valor1 As TextBox, _
                                      ByRef txtCP2Letra2 As TextBox, ByRef txtCP2Valor2 As TextBox, _
                                      ByRef txtCP3Letra3 As TextBox, ByRef txtCP3Valor3 As TextBox)
      Select Case nocp
         Case 2
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = False
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = False
            txtCP3Valor3.Visible = False
         Case 3
            'Hace visible las etiquetas para dos controles positivos y negativos
            lblCPNo1.Visible = True
            lblCPNo2.Visible = True
            lblCPNo3.Visible = True
            'Hace visible controles positivos para dos controles
            txtCP1Letra1.Visible = True
            txtCP1Valor1.Visible = True
            txtCP2Letra2.Visible = True
            txtCP2Valor2.Visible = True
            txtCP3Letra3.Visible = True
            txtCP3Valor3.Visible = True
      End Select
   End Sub

   Public Sub defineValoresDefaultPositivos(ByVal nocp As Integer, ByRef txtCP1Letra1 As TextBox, ByRef txtCP1Valor1 As TextBox, _
                                            ByRef txtCP2Letra2 As TextBox, ByRef txtCP2Valor2 As TextBox, _
                                            ByRef txtCP3Letra3 As TextBox, ByRef txtCP3Valor3 As TextBox)
      If (nocp = 2) Then
         txtCP1Letra1.Text = "A"
         txtCP1Valor1.Text = "1"
         txtCP2Letra2.Text = "A"
         txtCP2Valor2.Text = "3"
      ElseIf (nocp = 3) Then
         txtCP1Letra1.Text = "A"
         txtCP1Valor1.Text = "1"
         txtCP2Letra2.Text = "A"
         txtCP2Valor2.Text = "3"
         txtCP3Letra3.Text = "H"
         txtCP3Valor3.Text = "11"
      End If
   End Sub

   Public Sub defineValoresDefaultNegativos(ByVal nocn As Integer, ByRef txtCN1Letra1 As TextBox, ByRef txtCN1Valor1 As TextBox, _
                                            ByRef txtCN2Letra2 As TextBox, ByRef txtCN2Valor2 As TextBox, _
                                            ByRef txtCN3Letra3 As TextBox, ByRef txtCN3Valor3 As TextBox)
      If (nocn = 2) Then
         txtCN1Letra1.Text = "A"
         txtCN1Valor1.Text = "2"
         txtCN2Letra2.Text = "H"
         txtCN2Valor2.Text = "10"
      ElseIf (nocn = 3) Then
         txtCN1Letra1.Text = "A"
         txtCN1Valor1.Text = "2"
         txtCN2Letra2.Text = "H"
         txtCN2Valor2.Text = "10"
         txtCN3Letra3.Text = "H"
         txtCN3Valor3.Text = "12"
      End If
   End Sub


   'PUEDE BORRARSE POR CAMBIOS AL 18-08-2012
   'Public Function revisaQueCasosNoSeanIguales(ByVal combo As ComboBox,ByVal totalCasos() As listaCasos) As Boolean
   '   Dim i As Integer = 0
   '   Dim largo As Integer = UBound(totalCasos) - 1
   '   Dim b As Boolean = True
   '   For i = 0 To largo
   '      If (combo.Text = totalCasos(i).noCaso) Then
   '         MessageBox.Show("ERROR: Este No. de Caso es igual que el análisis No." & (i + 1) & ", Verifique y corrija.")
   '         b = False
   '         Exit For
   '      Else
   '         b = True
   '      End If
   '   Next
   '   Return b
   'End Function


End Module
