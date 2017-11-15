'" <summary>
'"Este es un modulo que se utiliza para poder manejar las vriables que se usaran en todo el proyecto
'"es muy util por que se declaran aqui como unicas para poder usarlas de forma GLOBAL
'" </summary>

Imports MySql.Data.MySqlClient
Module Globales
    Public cnx As New MySqlConnection
    Public tipodeusuario As Integer
End Module