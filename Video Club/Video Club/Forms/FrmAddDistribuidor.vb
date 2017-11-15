Public Class FrmAddDistribuidor
    Dim cambio As Boolean
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Minimizar1_Click(sender As Object, e As EventArgs) Handles Minimizar1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Txt_NombreDistribuidor.Text = "" Then
            MessageBox.Show(" captura el nombre del distribuidor")
        ElseIf Txt_Encargado.Text = "" Then
            MessageBox.Show("captura el encargado")
        ElseIf RichTxt_Direccion.Text = "" Then
            MessageBox.Show("captura la direccion")
        ElseIf Txt_Telefono.Text = "" Then
            MessageBox.Show("capturar el telefono")
        ElseIf Txt_Celular.Text = "" Then
            MessageBox.Show("capturar el numero de celular ")
        ElseIf Txt_Correo.Text = "" Then
            MessageBox.Show("captura el correo del distribuidor")
        End If

        Dim distri As New Distribuidor
        If distri.consultaUnDistribuidor() = False And cambio = False Then

            distri.insertaDis()


        Else

            distri.getSetNombreD = Txt_NombreDistribuidor.Text
            distri.getSetEncargado = Txt_Encargado.Text
            distri.getSetDireccion = RichTxt_Direccion.Text
            distri.getSetTelefono = Txt_Telefono.Text
            distri.getSetCelular = Txt_Celular.Text
            distri.getSetCorreo = Txt_Correo.Text
            'Si la carrera se encuentra registrada, se modifica la información
            distri.actualizaDist() 'ACTUALIZA LA CARRERA
            MsgBox("Registro modificado ...")
        End If
        distri.PoblarDataGridDistr(DGVdistri)
        cambio = False




        'Limpiamos el contenido de las cajas de texto 
        Txt_ID.Text = ""
        Txt_NombreDistribuidor.Text = ""
        Txt_Encargado.Text = ""
        RichTxt_Direccion.Text = ""
        Txt_Telefono.Text = vbNullString
        Txt_Celular.Text = vbNullString
        Txt_Correo.Text = ""


        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        Txt_NombreDistribuidor.Focus()


    End Sub

    Private Sub FrmAddDistribuidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim distri As New Distribuidor
        distri.PoblarDataGridDistr(DGVdistri)
        'cnx.cerrar()
    End Sub


    Private Sub DGVdistri_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdistri.CellContentClick
        Dim renglon As Integer
        cambio = True

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVdistri.CurrentCellAddress.Y
        Txt_ID.Text = DGVdistri.Rows(renglon).Cells(0).Value
        Txt_NombreDistribuidor.Text = DGVdistri.Rows(renglon).Cells(1).Value
        Txt_Encargado.Text = DGVdistri.Rows(renglon).Cells(2).Value
        RichTxt_Direccion.Text = DGVdistri.Rows(renglon).Cells(3).Value
        Txt_Telefono.Text = DGVdistri.Rows(renglon).Cells(4).Value
        Txt_Celular.Text = DGVdistri.Rows(renglon).Cells(5).Value
        Txt_Correo.Text = DGVdistri.Rows(renglon).Cells(6).Value

    End Sub

    Private Sub RichTxt_Direccion_Click(sender As Object, e As EventArgs) Handles RichTxt_Direccion.Click
        Text = ""
    End Sub

End Class