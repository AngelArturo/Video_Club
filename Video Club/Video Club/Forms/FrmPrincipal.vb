Public Class FrmPrincipal
    'Funciones del Form Principal'
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

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
End Class