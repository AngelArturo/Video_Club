Imports MySql.Data.MySqlClient
Public Class login

    Private contrasena As String
    Private usuario As String
    Dim cnx As New conexion


    Public Sub New()
        usuario = ""
        contrasena = ""
    End Sub


    Public Sub New(ByVal newusuario As String, ByVal newcontrasena As String)
        usuario = newusuario
        contrasena = newcontrasena
    End Sub

    Public Property getSetUsuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal value As String)
            usuario = value
        End Set
    End Property

    Public Property getSetContrasena() As String
        Get
            Return contrasena
        End Get
        Set(value As String)
            contrasena = value
        End Set
    End Property

    Public Function verContrasena() As Boolean
        Dim StrSql As String
        Dim xDT As DataTable
        Dim contra As String

        verContrasena = False

        If usuario <> "" And contrasena <> "" Then

            StrSql = "Select contrasena,tipoUsuario from  empleados where " &
            " nombreUsuario = '" & usuario & "'"
            xDT = cnx.objetoDataAdapter(StrSql)
            contra = xDT.Rows(0)("contrasena")
            If contra = contrasena Then
                verContrasena = True
                Globales.tipodeusuario = xDT.Rows(0)("tipoUsuario")
                cnx.cerrar()
            End If
        End If

    End Function



End Class
