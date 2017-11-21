Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class FrmEmpleado
    Dim cambio As Boolean
    Dim cnx2 As New MySqlConnection("server=localhost; user=root; password='arturo1996'; database=videoclub;")

    'VERIFICAR QUE LOS CAMPOS ESTEN LLENOS
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If paterno.Text = "" Then
            MessageBox.Show("Captura el apellido paterno del empleado")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Captura el apellido materno del empleado")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Captura el nombre del empleado")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Captura el CURP")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Captura el RFC")
        ElseIf dia.Text = "" Then
            MessageBox.Show("Captura el dia de nacimiento del empleado")
        ElseIf mes.Text = "" Then
            MessageBox.Show("Selecciona el mes de nacimiento del empleado")
        ElseIf ano.Text = "" Then
            MessageBox.Show("Capturar el año de nacimiento del empleado ")
        ElseIf genero.Text = "" Then
            MessageBox.Show("Selecciona el sexo del empleado ")
        ElseIf lugarN.Text = "" Then
            MessageBox.Show("Captura el lugar de nacimiento del empleado")
        ElseIf calle.Text = "" Then
            MessageBox.Show("Captura la calle del domicilo")
        ElseIf numero.Text = "" Then
            MessageBox.Show("Capturar el numero del domicilio ")
        ElseIf colonia.Text = "" Then
            MessageBox.Show("Captura la colonia del domicilio ")
        ElseIf telefono.Text = "" Then
            MessageBox.Show("Captura el telefono del empleado")
        ElseIf celular.Text = "" Then
            MessageBox.Show("Captura el numero de celular del empleado")
        ElseIf codigoP.Text = "" Then
            MessageBox.Show("Capturar el codigo postal del empleado ")
        ElseIf correo.Text = "" Then
            MessageBox.Show("Captura el correo del empleado ")
        ElseIf nombreUsuario.Text = "" Then
            MessageBox.Show("Captura el nombre del usuario")
        ElseIf contrasena.Text = "" Then
            MessageBox.Show("Captura la contraseña del usuario")
        ElseIf tipoU.Text = "" Then
            MessageBox.Show("Capturar el tipo de usuario ")
        End If

        Dim empleado As New Empleado
        If empleado.consultaUnEmpleado() = False And cambio = False Then

            empleado.insertaEmpleado()

        Else

            empleado.getSetPaterno = paterno.Text
            empleado.getSetMaterno = TextBox1.Text
            empleado.getSetNombres = TextBox2.Text
            empleado.getSetCurp = TextBox3.Text
            empleado.getSetRfc = TextBox4.Text
            empleado.getSetDia = dia.Text
            empleado.getSetMes = mes.Text
            empleado.getSetAno = ano.Text
            empleado.getSetGenero = genero.Text
            empleado.getSetLugarN = lugarN.Text
            empleado.getSetCalle = calle.Text
            empleado.getSetNumero = numero.Text
            empleado.getSetColonia = colonia.Text
            empleado.getSetTelefono = telefono.Text
            empleado.getSetCelular = celular.Text
            empleado.getSetCodigoP = codigoP.Text
            empleado.getSetCorreo = correo.Text
            empleado.getSetNombreU = nombreUsuario.Text
            empleado.getSetContrasena = contrasena.Text
            empleado.getSetTipoE = tipoU.Text

            'Si la carrera se encuentra registrada, se modifica la información
            empleado.actualizaEmpleado() 'ACTUALIZA LA CARRERA
            MsgBox("Registro modificado ...")
        End If

        empleado.PoblarDataGridEmpleado(DGVempleados)
        cambio = False

        'Limpiamos el contenido de las cajas de texto 
        paterno.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        dia.Text = vbNullString
        mes.SelectedValue = "mes"
        dia.Text = vbNullString
        ano.Text = ""
        genero.SelectedValue = "seleccionar"
        lugarN.Text = ""
        calle.Text = ""
        numero.Text = vbNullString
        colonia.Text = ""
        telefono.Text = vbNullString
        celular.Text = ""
        codigoP.Text = vbNullString
        correo.Text = ""
        nombreUsuario.Text = ""
        contrasena.Text = ""
        tipoU.Text = ""

        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        paterno.Focus()
    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Empleado
        empleado.PoblarDataGridEmpleado(DGVempleados)
        'cnx.cerrar()

        'HACER EL REPORTE DE DISTRIBUIDOR
        cnx2.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM distribuidor", cnx2)
        Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
        Dim bs As New BindingSource

        bs.DataSource = drd
        DGVempleados.DataSource = bs
        drd.Close()
        cnx2.Close()
    End Sub

    Public Function getColumnasSize(ByVal dg As DataGridView) As Single()
        'Funcion para obtener el tamaño de las culumnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable cone l numero de columnas del datagridview
        Dim datatable As New PdfPTable(DGVempleados.ColumnCount)
        'Se le asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = getColumnasSize(DGVempleados)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Reporte de EMPLEADOS", New Font(Font.Name = "Century Gothic", 18, Font.Bold))

        'Se crea el texto debajo del encabezado
        Dim texto As New Phrase("Realizado: " + Now.Date(), New Font(Font.Name = "Century Gothic", 12, Font.Bold))
        'Se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To DGVempleados.ColumnCount - 1
            datatable.AddCell(DGVempleados.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DATAGRIDVIEW
        For i As Integer = 0 To DGVempleados.RowCount - 1
            For j As Integer = 0 To DGVempleados.ColumnCount - 1
                datatable.AddCell(DGVempleados(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al docuemnto
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Try
            'Intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows(Desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Distribuidores a&c.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox
            MessageBox.Show("No se puede generar el documento PDF", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVempleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVempleados.CellContentClick

        Dim renglon As Integer
        cambio = True

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVempleados.CurrentCellAddress.Y
        claveEm.Text = DGVempleados.Rows(renglon).Cells(0).Value
        paterno.Text = DGVempleados.Rows(renglon).Cells(1).Value
        TextBox1.Text = DGVempleados.Rows(renglon).Cells(2).Value
        TextBox2.Text = DGVempleados.Rows(renglon).Cells(3).Value
        TextBox3.Text = DGVempleados.Rows(renglon).Cells(4).Value
        TextBox4.Text = DGVempleados.Rows(renglon).Cells(5).Value
        dia.Text = DGVempleados.Rows(renglon).Cells(6).Value
        mes.Text = DGVempleados.Rows(renglon).Cells(7).Value
        ano.Text = DGVempleados.Rows(renglon).Cells(8).Value
        genero.Text = DGVempleados.Rows(renglon).Cells(9).Value
        lugarN.Text = DGVempleados.Rows(renglon).Cells(10).Value
        calle.Text = DGVempleados.Rows(renglon).Cells(11).Value
        numero.Text = DGVempleados.Rows(renglon).Cells(12).Value
        colonia.Text = DGVempleados.Rows(renglon).Cells(13).Value
        telefono.Text = DGVempleados.Rows(renglon).Cells(14).Value
        celular.Text = DGVempleados.Rows(renglon).Cells(15).Value
        codigoP.Text = DGVempleados.Rows(renglon).Cells(16).Value
        correo.Text = DGVempleados.Rows(renglon).Cells(17).Value
        nombreUsuario.Text = DGVempleados.Rows(renglon).Cells(18).Value
        contrasena.Text = DGVempleados.Rows(renglon).Cells(19).Value
        tipoU.Text = DGVempleados.Rows(renglon).Cells(20).Value
    End Sub

    'Valida que solo se introduzcan números
    Private Sub numero_KPress(sender As Object, e As KeyPressEventArgs) Handles numero.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub telefono_kPress(sender As Object, e As KeyPressEventArgs) Handles telefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub celular_kPress(sender As Object, e As KeyPressEventArgs) Handles celular.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    Private Sub codigoP_kPress(sender As Object, e As KeyPressEventArgs) Handles codigoP.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class