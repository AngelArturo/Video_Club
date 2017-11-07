Public Class FrmSocio
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        If nombre.Text = "" Then
            MessageBox.Show(" captura el nombre del socio")
        ElseIf paterno.Text = "" Then
            MessageBox.Show("captura el apellido paterno")
        ElseIf materno.Text = "" Then
            MessageBox.Show("captura apellido materno")
        ElseIf sexo.Text = "" Then
            MessageBox.Show("selecciona el sexo")
        ElseIf calle.Text = "" Then
            MessageBox.Show("captura la calle del domicilio del socio")
        ElseIf colonia.Text = "" Then
            MessageBox.Show("captura la colonia del socio")
        ElseIf numEx.Text = "" Then
            MessageBox.Show("captura el numero Exterior del domicilio del socio")
        ElseIf telefono.Text = "" Then
            MessageBox.Show("capturar el telefono del socio ")
        ElseIf celular.Text = "" Then
            MessageBox.Show("capturar el celular del socio ")
        ElseIf radioDeselecion.Checked Then
            MessageBox.Show("selecciona el estado de la credencial vigente ")
        End If

        Dim socio As New Socio
        If socio.consultaUnSocio() = False Then

            socio.insertaSocio()
        Else

            socio.getSetNombre = nombre.Text()
            socio.getSetPaterno = paterno.Text()
            socio.getSetMaterno = materno.Text()
            socio.getSetGenero = sexo.Text()
            socio.getSetCalle = calle.Text()
            socio.getSetNumeroIn = numIn.Text()
            socio.getSetNumeroEx = numEx.Text()
            socio.getSetColonia = colonia.Text()
            socio.getSetTelefono = telefono.Text()
            socio.getSetCelular = celular.Text()
            socio.getSetCredencialVigente = Radio.Checked()
            'Si la carrera se encuentra registrada, se modifica la información
            socio.actualizaSocio() 'ACTUALIZA LA CARRERA
            MsgBox("Registro modificado ...")
        End If
        socio.PoblarDataGridSocios(DGV_socios)




        'Limpiamos el contenido de las cajas de texto 
        nombre.Text = ""
        paterno.Text = ""
        materno.Text = ""
        sexo.SelectedValue = 'Seleccionar'
        sexo.Text = ""
        calle.Text = ""
        colonia.Text = ""
        numEx.Text = vbNullString
        numIn.Text = vbNullString
        telefono.Text = vbNullString
        celular.Text = vbNullString
        radioDeselecion.Checked = True

        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        nombre.Focus()
    End Sub

    Private Sub FrmSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim socio As New Socio
        socio.PoblarDataGridSocios(DGV_socios)
        'cnx.Close()
    End Sub

    Private Sub TxtClaveCarrera_LostFocus(sender As Object, e As System.EventArgs) Handles nombre.LostFocus
        If nombre.Text <> "" Then
            'Busca  un país en particular
            Dim socio As New Socio
            'Llamamos al método que elimina el registro
            socio.consultaTodosSocios()
        End If
    End Sub
    Private Sub DGVsocios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_socios.CellContentClick
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGV_socios.CurrentCellAddress.Y
        nombre.Text = DGV_socios.Rows(renglon).Cells(0).Value
        paterno.Text = DGV_socios.Rows(renglon).Cells(1).Value
        materno.Text = DGV_socios.Rows(renglon).Cells(2).Value
        sexo.Text = DGV_socios.Rows(renglon).Cells(3).Value
        calle.Text = DGV_socios.Rows(renglon).Cells(4).Value
        numIn.Text = DGV_socios.Rows(renglon).Cells(5).Value
        numEx.Text = DGV_socios.Rows(renglon).Cells(6).Value
        colonia.Text = DGV_socios.Rows(renglon).Cells(7).Value
        telefono.Text = DGV_socios.Rows(renglon).Cells(8).Value
        celular.Text = DGV_socios.Rows(renglon).Cells(9).Value
        Radio.Checked = DGV_socios.Rows(renglon).Cells(10).Value


    End Sub

End Class