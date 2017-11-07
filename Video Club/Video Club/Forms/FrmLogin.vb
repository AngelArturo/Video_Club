Public Class FrmLogin

    Private Sub BtnIngresark(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM usuarios WHERE nombre = '" & TxtNombre.Text & "' && password = '" & TxtContraseña.Text & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            TxtNombre.Text = ""
            TxtContraseña.Text = ""
            session = xDT.Rows(0)
            MessageBox.Show("Bienvenido " & session.Item(1))
            FrmPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("!Usuario o contraseña incorrecto!")
        End If
        cnx.Close()
    End Sub


End Class