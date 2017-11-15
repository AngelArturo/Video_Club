Public Class FrmAdeudos
    Dim cambio As Boolean
    Private Sub FrmAdeudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adeudos As New Adeudos
        adeudos.poblarComboRenta(renta)
        adeudos.PoblarDataGridAdeudo(DGVadeudos)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If cantidad.Text = "" Then
            MessageBox.Show("captura la cantidad del adeudo")
        ElseIf estatus.Text = "" Then
            MessageBox.Show("selecciona el estatus del Adeudo")
        ElseIf renta.Text = "" Then
            MessageBox.Show("selecciona la renta del Adeudo")
        End If

        Dim adeudo As New Adeudos()
        If adeudo.consultaUnAdeudo() = False And cambio = False Then


            adeudo.getSetCantidad = Convert.ToInt32(cantidad.Text)
            adeudo.getSetEstatus = estatus.Text
            adeudo.getSetIdRenta = renta.SelectedValue
            adeudo.insertaAdeudo()


        Else

            adeudo.getSetIdAdeudo = claveAdeudo.Text
            adeudo.getSetEstatus = estatus.Text


            'Si la carrera se encuentra registrada, se modifica la información
            adeudo.actualizaAduedo() 'ACTUALIZA LA CARRERA
            MsgBox("Registro modificado ...")
        End If
        adeudo.PoblarDataGridAdeudo(DGVadeudos)
        cambio = False




        'Limpiamos el contenido de las cajas de texto 
        claveAdeudo.Text = ""
        cantidad.Text = vbNullString
        estatus.Text = ""
        renta.Text = ""


        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        cantidad.Focus()
    End Sub

    Private Sub DGVadeudos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVadeudos.CellContentClick
        Dim renglon As Integer
        cambio = True

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVadeudos.CurrentCellAddress.Y
        claveAdeudo.Text = DGVadeudos.Rows(renglon).Cells(0).Value
        cantidad.Text = DGVadeudos.Rows(renglon).Cells(1).Value
        estatus.Text = DGVadeudos.Rows(renglon).Cells(2).Value
        renta.SelectedIndex = Convert.ToInt32(DGVadeudos.Rows(renglon).Cells(3).Value) - 1


    End Sub
End Class