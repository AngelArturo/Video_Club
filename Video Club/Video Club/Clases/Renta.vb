Imports MySql.Data.MySqlClient
Public Class Renta
    Private idRenta As Integer
    Private impRenta As Integer
    Private fechaRen As String
    Private fechaEnt As String
    Private idUsu As Integer
    Private idPel As Integer
    Private idSoc As Integer

    Public cnx As New conexion

    Public Sub New()
        idRenta = 0
        impRenta = 0
        fechaRen = ""
        fechaEnt = ""
        idUsu = 0
        idPel = 0
        idSoc = 0
    End Sub

    Public Sub New(ByVal idR As Integer, ByVal impR As Integer, ByVal feR As String, ByVal feE As String, ByVal idU As Integer, ByVal idP As Integer, ByVal idS As Integer)
        'Aqui recibimos los datos
        idRenta = idR
        impRenta = impR
        fechaRen = feR
        fechaEnt = feE
        idUsu = idU
        idPel = idP
        idSoc = idS
    End Sub

    Public Property getSetIdR() As Integer
        Get
            Return idRenta

        End Get
        Set(ByVal Value As Integer)
            idRenta = Value
        End Set
    End Property
    Public Property getSetImpR() As Integer
        Get
            Return impRenta

        End Get
        Set(ByVal Value As Integer)
            impRenta = Value
        End Set
    End Property
    Public Property getSetFeR() As String
        Get
            Return fechaEnt

        End Get
        Set(ByVal Value As String)
            fechaEnt = Value
        End Set
    End Property
    Public Property getSetFeE() As String
        Get
            Return fechaEnt
        End Get
        Set(ByVal Value As String)
            fechaEnt = Value
        End Set
    End Property
    Public Property getSetIdU() As Integer
        Get
            Return idUsu
        End Get
        Set(ByVal Value As Integer)
            idUsu = Value
        End Set
    End Property
    Public Property getSetIdS() As Integer
        Get
            Return idSoc
        End Get
        Set(ByVal Value As Integer)
            idSoc = Value
        End Set
    End Property

    Public Function consultaIdPel() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM  peliculas " &
                 "WHERE nombre='" & FrmPrincipal.Txt_Renta.Text & "'"

        consultaIdPel = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idPel = ""
            End If
            consultaIdPel = True
        End If
    End Function

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
        idUsu = idE

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idPel = ""
            End If
            consultaIdU = True
        End If

    End Function

    Public Sub addRenta(idPelicula As Integer)
        Dim strSql As String

        consultaIdU()
        idSoc = FrmPrincipal.Txt_idSocio.Text

        fechaRen = FrmPrincipal.Lbl_Fecha.Text

        If (FrmPrincipal.RB_Estreno.Checked = True) Then
            impRenta = 50
            fechaEnt = FrmPrincipal.DTP_Catalogo.Text
        End If
        If (FrmPrincipal.RB_Catalago.Checked = True) Then
            impRenta = 25
            fechaEnt = FrmPrincipal.DTP_Estreno.Text
        End If

        If impRenta <> 0 And fechaRen <> "" And fechaEnt <> "" And
            idUsu <> 0 And idPelicula <> 0 And idSoc <> 0 Then

            'Realiza inserción de datos
            strSql = "INSERT INTO renta  " &
                                "VALUES(0,'" & impRenta & "','" & fechaRen & "',
                              '" & fechaEnt & "','" & idUsu & "','" & idPelicula & "','" & idSoc & "' );"
            cnx.objetoCommand(strSql)
            MessageBox.Show("Agregado a la cuenta!")
        End If
        cnx.cerrar()
    End Sub

    Public Function consultaTodasPel() As Object
        Dim strSQL As String
        strSQL = "SELECT * from peliculas order by id asc"
        consultaTodasPel = cnx.objetoDataAdapter(strSQL)
    End Function

    'Poblar el DatagrindView Renta conlas peliculas
    Public Sub PoblarDataGridRenta(ByVal DGVrenta As DataGridView)
        DGVrenta.DataSource = consultaTodasPel()
        DGVrenta.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVrenta.Columns.Item(0).Width = 20 'id
        DGVrenta.Columns.Item(0).Width = 200 'nombre
        DGVrenta.Columns.Item(0).Width = 70 'genero
        DGVrenta.Columns.Item(0).Width = 50 'clasificacion
        DGVrenta.Columns.Item(0).Width = 70 'fehaadquisicion
        DGVrenta.Columns.Item(0).Width = 20 'id_dis
        DGVrenta.Columns.Item(0).Width = 30 'cantidad
        cnx.cerrar()

    End Sub

    Public Function consultaRentas() As Object
        Dim strSQL As String

        strSQL = "SELECT id,id_pelicula,fechaEntrega FROM renta WHERE id_socio=" & FrmPrincipal.Txt_idSocio.Text & ""
        consultaRentas = cnx.objetoDataAdapter(strSQL)
    End Function

    'Poblar el dataGridView con las rentas que ha hecho cada socio
    Public Sub PoblarDataGridSocioRenta(ByVal DGV_RentasSocio As DataGridView)
        DGV_RentasSocio.DataSource = consultaRentas()
        DGV_RentasSocio.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGV_RentasSocio.Columns.Item(0).Width = 50 'id
        DGV_RentasSocio.Columns.Item(1).Width = 0
        DGV_RentasSocio.Columns.Item(2).Width = 245
        cnx.cerrar()
    End Sub

    Public Sub Devolver(idRenta As Integer, idPelicula As Integer)
        Dim strSQL As String
        Dim strSQL2 As String

        strSQL = "DELETE FROM renta wHERE id=" & idRenta & ""
        strSQL2 = "UPDATE peliculas set cantidad=cantidad+1 where id=" & idPelicula & ""
        cnx.objetoCommand(strSQL2)
        cnx.objetoCommand(strSQL)
        cnx.cerrar()
        MsgBox("¡Pon la pelicula en los estantes!")
    End Sub
End Class
