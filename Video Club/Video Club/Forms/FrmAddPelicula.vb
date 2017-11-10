Public Class FrmAddPelicula
    Dim cambio As Boolean
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmAddPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pelicula As New Pelicula
        pelicula.poblarComboDis(comb_distribuidor)
        pelicula.PoblarDataGridPel(DGVpeliculas)
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        If nombrePelicula.Text = "" Then
            MessageBox.Show(" captura el nombre de la pelicula")
        ElseIf gnero.Text = "" Then
            MessageBox.Show("Selecciona el genero de la pelicula")
        ElseIf cantidad.Text = "" Then
            MessageBox.Show("captura la cantidad de peliculas")
        ElseIf clasificacion.Text = "" Then
            MessageBox.Show("Selecciona la clasificacion de la pelicula")
        ElseIf fechaAd.Text = "" Then
            MessageBox.Show(" Registra la fecha de adquisicion de la pelicula ")
        ElseIf comb_distribuidor.Text = "" Then
            MessageBox.Show("selecciona el distribuidor")
        End If

        Dim pelicula As New Pelicula()
        If pelicula.consultaUnaPelicula() = False And cambio = False Then

            pelicula.getSetNombrePel = nombrePelicula.Text
            pelicula.getSetGenero = gnero.Text
            pelicula.getSetCantidad = Convert.ToInt32(cantidad.Text)
            pelicula.getSetClasif = clasificacion.Text
            pelicula.getSetFechaAd = Convert.ToDateTime(fechaAd.Text).ToShortDateString
            pelicula.getSetidDis = comb_distribuidor.SelectedValue
            pelicula.insertaPel()


        Else

            pelicula.getSetNombrePel = nombrePelicula.Text
            pelicula.getSetGenero = gnero.Text
            pelicula.getSetCantidad = cantidad.Text
            pelicula.getSetClasif = clasificacion.Text
            pelicula.getSetFechaAd = Convert.ToDateTime(fechaAd.Text).ToShortDateString
            pelicula.getSetidDis = comb_distribuidor.Text
            'Si la carrera se encuentra registrada, se modifica la información
            pelicula.actualizaPelicula() 'ACTUALIZA LA CARRERA
            MsgBox("Registro modificado ...")
        End If
        pelicula.PoblarDataGridPel(DGVpeliculas)
        cambio = False




        'Limpiamos el contenido de las cajas de texto 
        idP.Text = ""
        nombrePelicula.Text = ""
        gnero.Text = ""
        cantidad.Text = vbNullString
        clasificacion.Text = ""
        fechaAd.Text = ""
        comb_distribuidor.Text = ""


        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        nombrePelicula.Focus()

    End Sub

    Private Sub DGVpeliculas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVpeliculas.CellContentClick
        Dim renglon As Integer
        cambio = True

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVpeliculas.CurrentCellAddress.Y
        idP.Text = DGVpeliculas.Rows(renglon).Cells(0).Value
        nombrePelicula.Text = DGVpeliculas.Rows(renglon).Cells(1).Value
        gnero.Text = DGVpeliculas.Rows(renglon).Cells(2).Value
        clasificacion.Text = DGVpeliculas.Rows(renglon).Cells(3).Value
        fechaAd.Text = Convert.ToDateTime(DGVpeliculas.Rows(renglon).Cells(4).Value)
        comb_distribuidor.SelectedIndex = Convert.ToInt32(DGVpeliculas.Rows(renglon).Cells(5).Value) - 1
        cantidad.Text = DGVpeliculas.Rows(renglon).Cells(6).Value
    End Sub
End Class