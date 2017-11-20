Public Class FrmLogin
    'Funcionalidaes del boton cerrar X'
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    'Funcionalidades del boton minimizar'
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Funcionalidades del boton Ingresar'

    Private Sub BtnIngresark(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim strSQL As String
        Dim strSQL2 As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM empleados WHERE nombreUsuario = '" & TxtNombre.Text & "' && contrasena = '" & TxtContraseña.Text & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            empleadonombre = TxtNombre.Text
            TxtNombre.Text = ""
            TxtContraseña.Text = ""
            MessageBox.Show("Bienvenido ")
            FrmPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("!Usuario o contraseña incorrecto!")
        End If
        xCnx.cerrar()
    End Sub
End Class