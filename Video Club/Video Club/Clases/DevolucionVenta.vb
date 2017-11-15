Imports MySql.Data.MySqlClient
Public Class DevolucionVenta

    Private idDevo As Integer
    Private idPelicula As Integer
    Private estado As String

    Public cnx As New conexion

    Public Sub New()
        idDevo = 0
        idPelicula = 0
        estado = ""
    End Sub

    Public Sub New(ByVal idD As Integer, ByVal idP As Integer, ByVal edo As String)
        'Aquí recibimos los datos
        idDevo = idD
        idPelicula = idP
        estado = edo
    End Sub

    Public Property getSetIdDevolucion() As Integer
        Get
            Return idDevo

        End Get
        Set(ByVal Value As Integer)
            idDevo = Value
        End Set
    End Property
    Public Property getSetIdPelicula() As Integer
        Get
            Return idPelicula

        End Get
        Set(ByVal Value As Integer)
            idPelicula = Value
        End Set

    End Property
    Public Property getSetEstado() As String
        Get
            Return estado
        End Get

        Set(ByVal Value As String)
            estado = Value
        End Set

    End Property

    Public Function consultaIdPelicula() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM peliculas " &
                 "WHERE nombre= '" & FrmDevolucionVenta.com_pelicula.Text & "'"

        consultaIdPelicula = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idPelicula = ""
            Else
                idPelicula = CStr(xDT.Rows(0)("id"))
                FrmDevolucionVenta.com_pelicula.SelectedValue = idPelicula
            End If
            consultaIdPelicula = True
        End If
    End Function

    Public Sub insertaDev()
        Dim strSql As String
        consultaIdPelicula()

        If idPelicula <> 0 And estado <> "" Then


            'Realiza inserción de datos
            strSql = "INSERT INTO devoluciones  " &
                            "VALUES(0,'" & idPelicula & "','" & estado & "');"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If
    End Sub

    Public Function consultaTodasDevoluciones() As Object
        Dim strSQL As String

        strSQL = "SELECT * from devoluciones order by id asc"
        consultaTodasDevoluciones = cnx.objetoDataAdapter(strSQL)


    End Function

    Public Sub poblarComboPeliculas(ByVal objeto As ComboBox)
        Dim Lista As MySqlDataReader
        Dim strSql As String

        strSql = "SELECT nombre FROM peliculas Order By id asc"
        Lista = cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()

    End Sub
    Public Sub PoblarDataGridDevol(ByVal DGVdevo As DataGridView)
        DGVdevo.DataSource = consultaTodasDevoluciones()
        DGVdevo.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVdevo.Columns.Item(0).Width = 50
        DGVdevo.Columns.Item(1).Width = 200
        DGVdevo.Columns.Item(2).Width = 200
        cnx.cerrar()

    End Sub



End Class
