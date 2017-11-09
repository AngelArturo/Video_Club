Public Class FrmEmpleado
    Dim cambio As Boolean
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If paterno.Text = "" Then
            MessageBox.Show(" captura el apellido paterno del empleado")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("captura el apellido materno del empleado")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("captura el nombre del empleado")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("captura el curp")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("captura el rfc")
        ElseIf dia.Text = "" Then
            MessageBox.Show("captura el dia de nacimiento del empleado")
        ElseIf mes.Text = "" Then
            MessageBox.Show("selecciona el mes de nacimiento del empleado")
        ElseIf ano.Text = "" Then
            MessageBox.Show("capturar el año de nacimiento del empleado ")
        ElseIf genero.Text = "" Then
            MessageBox.Show("selecciona el sexo del empleado ")
        ElseIf lugarN.Text = "" Then
            MessageBox.Show("captura el lugar de nacimiento del empleado")
        ElseIf calle.Text = "" Then
            MessageBox.Show("captura la calle del domicilo")
        ElseIf numero.Text = "" Then
            MessageBox.Show("capturar el numero del domicilio ")
        ElseIf colonia.Text = "" Then
            MessageBox.Show("captura la colonia del domicilio ")
        ElseIf telefono.Text = "" Then
            MessageBox.Show("captura el telefono del empleado")
        ElseIf celular.Text = "" Then
            MessageBox.Show("captura el numero de celular del empleado")
        ElseIf codigoP.Text = "" Then
            MessageBox.Show("capturar el codigo postal del empleado ")
        ElseIf correo.Text = "" Then
            MessageBox.Show("captura el correo del empleado ")
        ElseIf nombreUsuario.Text = "" Then
            MessageBox.Show("captura el nombre del usuario")
        ElseIf contrasena.Text = "" Then
            MessageBox.Show("captura la contraseña del usuario")
        ElseIf tipoU.Text = "" Then
            MessageBox.Show("capturar el tipo de usuario ")
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
        celular.Text = vbNullString
        codigoP.Text = vbNullString
        correo.Text = ""
        nombreUsuario.Text = ""
        contrasena.Text = ""
        tipoU.Text = ""

        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        paterno.Focus()
    End Sub
    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Empleado
        empleado.PoblarDataGridEmpleado(DGVempleados)
        'cnx.cerrar()
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
End Class