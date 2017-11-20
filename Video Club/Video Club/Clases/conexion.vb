Imports MySql.Data.MySqlClient

'" <summary>
'"En esta clase se puede crear una conexion con la base de datos de MySql para poder realizar operaciones en ella 
'" </summary>
'" <remarks>  Bastante util para poder abrir la conexion </remarks>
Public Class conexion


    '" <summary>
    '"En este metodo constructor se puede crear la conexion con los metodos de las clases que pertenecen a la libreria de 
    '" MySql.Data.MySqlClient 
    '" </summary>
    Public Sub New()
        cnx.ConnectionString = "server=localhost; user=root; password='arturo1996'; database=videoclub;"
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                'MsgBox("Sí")
            Catch ex As Exception
                MsgBox("No se pudo conectar a la base de datos")
                Throw New Exception("No se pudo establecer la conexión.", ex)
                'Finally
            End Try
        End If
    End Sub

    'SELECT

    '" <summary>
    '"En este metodo se puede utilizar para poder mandar los select que se lleguen a realizar en la base de datos 
    '"de mySql se le pasa por parametro como sigue 
    '" CONSULTA (String) y de esta manera enviarlo a la base de datos para devolver un DataTable
    '" </summary>
    Public Function objetoDataAdapter(ByVal query As String) As DataTable
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter(query, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
        End Try
        DT.Dispose()
    End Function

    'INSERT - UPDATE - DELETE
    '" <summary>
    '"En este metodo se puede utilizar para hacer operaciones de insert, update , delete abre la conexion a la BD 
    '"y manda estas operaciones por medio de su parametro que indica una de estas funciones bien escrita para ser reconocida por la BD
    '" </summary>
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim query As New MySqlCommand(strcmd, cnx)
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            query.Dispose()
        End Try
    End Sub

    Function objetoDataReader(ByVal comando As String) As MySqlDataReader
        Dim cmd As New MySqlCommand(comando, cnx)
        Dim resultadoSQL As MySqlDataReader = cmd.ExecuteReader()

        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            cmd.Dispose()
        End Try
    End Function

    Public Function cerrar()
        cnx.Close()
    End Function

End Class
