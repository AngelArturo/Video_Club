Public Class CUEmpleado
    Public Property textboxValuePaterno As String
        Get
            Return Txt_ApPaterno.Text
        End Get
        Set(value As String)
            Txt_ApPaterno.Text = value
        End Set
    End Property

    Private Sub CUEmpleado_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox(textboxValuePaterno)
        textboxValuePaterno = "hols"
        MsgBox(textboxValuePaterno)
    End Sub
End Class
