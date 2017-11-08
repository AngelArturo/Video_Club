Public Class FrmPrincipal
    'Funciones del Form Principal'
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SlidePanel.Height = BtnInicio.Height
        CuInicio1.BringToFront()
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

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        SlidePanel.Height = BtnInicio.Height
        SlidePanel.Top = BtnInicio.Top
        CuInicio1.BringToFront()
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        SlidePanel.Height = BtnEmpleado.Height
        SlidePanel.Top = BtnEmpleado.Top
        CuEmpleado1.BringToFront()
    End Sub

    Private Sub BtnSocio_Click(sender As Object, e As EventArgs) Handles BtnSocio.Click
        SlidePanel.Height = BtnSocio.Height
        SlidePanel.Top = BtnSocio.Top
        'CuEmpleado1.BringToFront()
    End Sub

    Private Sub BtnPeliculas_Click(sender As Object, e As EventArgs) Handles BtnPeliculas.Click
        SlidePanel.Height = BtnPeliculas.Height
        SlidePanel.Top = BtnPeliculas.Top
        CuPelicula1.BringToFront()
    End Sub

    Private Sub BtnDistribuidor_Click(sender As Object, e As EventArgs) Handles BtnDistribuidor.Click
        SlidePanel.Height = BtnDistribuidor.Height
        SlidePanel.Top = BtnDistribuidor.Top
        CuDistribuidor1.BringToFront()
    End Sub
End Class