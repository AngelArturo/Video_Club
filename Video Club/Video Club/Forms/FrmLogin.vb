Public Class FrmLogin
    'Funcionalidaes del boton cerrar X'
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
    End Sub

    Private Sub X_MouseHover(sender As Object, e As EventArgs) Handles X.MouseHover
        X.Image = (My.Resources.ResX)
    End Sub

    Private Sub X_MouseLeave(sender As Object, e As EventArgs) Handles X.MouseLeave
        X.Image = (My.Resources.x)
    End Sub

    'Funcionalidades del boton minimizar'
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizar_MouseHover(sender As Object, e As EventArgs) Handles Minimizar.MouseHover
        Minimizar.Image = (My.Resources.Res_)
    End Sub

    Private Sub Minimizar_MouseLeave(sender As Object, e As EventArgs) Handles Minimizar.MouseLeave
        Minimizar.Image = (My.Resources.__)
    End Sub

    'Funcionalidades del boton Ingresar'
    Private Sub BtnIngresar_MouseHover(sender As Object, e As EventArgs) Handles BtnIngresar.MouseHover
        BtnIngresar.Image = (My.Resources.BtnIngresar2)
    End Sub

    Private Sub BtnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        BtnIngresar.Image = (My.Resources.Ingresar)
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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