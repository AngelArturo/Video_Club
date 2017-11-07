'" <summary>
'"Este es un modulo que se utiliza para poder manejar las vriables que se usaran en todo el proyecto
'"es muy util por que se declaran aqui como unicas para poder usarlas de forma GLOBAL
'" </summary>

Imports MySql.Data.MySqlClient
Module Globales
    Public cnx As New MySqlConnection
    Public session As Object
    Public EL_nombre As String
    Public empleados = "empleados", clientes = "clientes", cita = "citas", gastos = "gastos", productos = "productos", ventas = "ventas"
End Module