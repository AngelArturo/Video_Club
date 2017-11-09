Public Class FrmCortedeCaja
    Private Sub Txt_Diferencia_TextChanged(sender As Object, e As EventArgs) Handles Txt_Diferencia.TextChanged
        If Txt_Diferencia.Text Like 0 Then
            Btn_Bien.Show()
        Else
            Btn_Mal.Show()
        End If
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class