Public Class FrmCortedeCaja

    Dim corteCaja As New CorteCaja

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmCortedeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        corteCaja.cargarCorteCaja()
    End Sub

    Private Sub Txt_Efectivo_Leave(sender As Object, e As EventArgs) Handles Txt_Efectivo.Leave
        Dim suma As Int32
        Dim efectivo As Int32

        suma = Convert.ToInt32(Txt_EfectivoEsperado.Text)
        efectivo = Convert.ToInt32(Txt_Efectivo.Text)

        Txt_Diferencia.Text = suma - efectivo

        If efectivo = suma Then
            Btn_Mal.Hide()
            Btn_Bien.Show()
        Else
            Btn_Bien.Hide()
            Btn_Mal.Show()
        End If
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        corteCaja.insertaCorteCaja()
    End Sub
End Class