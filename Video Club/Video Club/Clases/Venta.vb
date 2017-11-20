Public Class Venta
    Private idVenta As Integer
    Private idUsua As Integer
    Private idPel As Integer
    Private montoVenta As Integer

    Public cnx As New conexion

    Public Sub New()
        idVenta = 0
        idUsua = 0
        idPel = 0
        montoVenta = 0
    End Sub

    Public Sub New(ByVal idV As Integer, ByVal idU As Integer, ByVal idP As Integer, ByVal monV As Integer)
        'Recibimos los datos
        idVenta = idV
        idUsua = idU
        idPel = idP
        montoVenta = monV
    End Sub

    Public Property getSetidV() As Integer
        Get
            Return idVenta
        End Get
        Set(value As Integer)
            idVenta = value
        End Set
    End Property
    Public Property getSetidU() As Integer
        Get
            Return idUsua
        End Get
        Set(value As Integer)
            idUsua = value
        End Set
    End Property
    Public Property getSetidP() As Integer
        Get
            Return idPel
        End Get
        Set(value As Integer)
            idPel = value
        End Set
    End Property
    Public Property getSetmonV() As Integer
        Get
            Return montoVenta
        End Get
        Set(value As Integer)
            montoVenta = value
        End Set
    End Property

    Public Function consultaIdU() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable
        Dim row As DataRow
        Dim idE As Integer

        strSQL = "SELECT id FROM  empleados " &
                 "WHERE nombreUsuario='" & empleadonombre & "'"

        consultaIdU = False
        xDT = cnx.objetoDataAdapter(strSQL)

        idE = xDT.Rows(0)(0).ToString()
        idUsua = idE

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idPel = ""
            End If
            consultaIdU = True
        End If

    End Function

    Public Sub addVenta(idPelicula As Integer)
        Dim strSQL As String

        consultaIdU()
        montoVenta = CInt(FrmPrincipal.Txt_MontoVenta.Text.ToString)

        If idUsua <> 0 And idPel <> 0 And montoVenta <> 0 Then
            'Realiza inserción de datos
            strSQL = "INSERT INTO venta  " &
                                "VALUES(0,'" & idUsua & "','" & idPelicula & "',
                              '" & montoVenta & "');"
            cnx.objetoCommand(strSQL)
            MsgBox("¡Aregado a la cuenta!")
        End If
        cnx.cerrar()
    End Sub

    Public Function consultaTodasPel() As Object
        Dim strSQL As String
        strSQL = "SELECT * from peliculas order by id asc"
        consultaTodasPel = cnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridVenta(ByVal DGV_venta As DataGridView)
        DGV_venta.DataSource = consultaTodasPel()
        DGV_venta.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGV_venta.Columns.Item(0).Width = 20 'id
        DGV_venta.Columns.Item(0).Width = 200 'nombre
        DGV_venta.Columns.Item(0).Width = 70 'genero
        DGV_venta.Columns.Item(0).Width = 50 'clasificacion
        DGV_venta.Columns.Item(0).Width = 70 'fehaadquisicion
        DGV_venta.Columns.Item(0).Width = 20 'id_dis
        DGV_venta.Columns.Item(0).Width = 30 'cantidad
        cnx.cerrar()
    End Sub

End Class
