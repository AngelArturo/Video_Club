Public Class FrmDevolucionVenta
    Private Sub FrmDevolucionVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim devoluciones As New DevolucionVenta
        devoluciones.poblarComboPeliculas(com_pelicula)
        devoluciones.PoblarDataGridDevol(DGVdevo)
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If com_pelicula.Text = "" Then
            MessageBox.Show(" Selecciona la pelicula ")
        ElseIf estado.Text = "" Then
            MessageBox.Show("Selecciona el estado de la pelicula")
        End If

        Dim devo As New DevolucionVenta()

        devo.getSetIdPelicula = com_pelicula.SelectedValue
        devo.getSetEstado = estado.Text
        devo.insertaDev()
        devo.PoblarDataGridDevol(DGVdevo)
        'Limpiamos el contenido de las cajas de texto 
        idD.Text = ""
        com_pelicula.Text = ""
        estado.Text = ""
        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        com_pelicula.Focus()
    End Sub

    Private Sub DGVdevo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdevo.CellContentClick
        Dim renglon As Integer

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVdevo.CurrentCellAddress.Y
        idD.Text = DGVdevo.Rows(renglon).Cells(0).Value
        com_pelicula.SelectedIndex = Convert.ToInt32(DGVdevo.Rows(renglon).Cells(1).Value) - 1
        estado.Text = DGVdevo.Rows(renglon).Cells(2).Value
    End Sub


End Class