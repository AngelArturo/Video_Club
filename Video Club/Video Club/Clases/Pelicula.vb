Imports MySql.Data.MySqlClient
Public Class Pelicula

    Private idPel As Integer
    Private nombrePel As String
    Private genero As String
    Private cantidad As Integer
    Private clasficacion As String
    Private fechaAd As String
    Private idDist As String

    Public cnx As New conexion

    Public Sub New()
        idPel = 0
        nombrePel = ""
        genero = ""
        cantidad = 0
        clasficacion = 0
        fechaAd = ""
        idDist = 0

    End Sub

    Public Sub New(ByVal idP As Integer, ByVal nombr As String, ByVal genero As String, ByVal cant As Integer, ByVal clasif As String, ByVal fecha As String, ByVal idD As Integer)
        'Aquí recibimos los datos
        idPel = idP
        nombrePel = nombr
        genero = genero
        cantidad = cant
        fechaAd = fecha
        idDist = idD
    End Sub
    Public Property getSetIdP() As Integer
        Get
            Return idPel

        End Get
        Set(ByVal Value As Integer)
            idPel = Value
        End Set
    End Property


    Public Property getSetNombrePel() As String
        Get
            Return nombrePel
        End Get

        Set(ByVal Value As String)
            nombrePel = Value
        End Set

    End Property

    Public Property getSetGenero() As String
        Get
            Return genero
        End Get

        Set(ByVal Value As String)
            genero = Value
        End Set

    End Property
    Public Property getSetCantidad() As Integer
        Get
            Return cantidad

        End Get
        Set(ByVal Value As Integer)
            cantidad = Value
        End Set
    End Property
    Public Property getSetClasif() As String
        Get
            Return clasficacion
        End Get

        Set(ByVal Value As String)
            clasficacion = Value
        End Set

    End Property

    Public Property getSetFechaAd() As String
        Get
            Return fechaAd
        End Get

        Set(ByVal Value As String)
            fechaAd = Value
        End Set

    End Property

    Public Property getSetidDis() As Integer
        Get
            Return idDist
        End Get
        Set(ByVal Value As Integer)
            idDist = Value
        End Set
    End Property

    Public Function consultaIdDis() As Boolean
        Dim strSQL As String
        'Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id FROM distribuidor " &
                 "WHERE nombre= '" & FrmAddPelicula.comb_distribuidor.Text & "'"

        consultaIdDis = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idDist = ""
            Else
                idDist = CStr(xDT.Rows(0)("id"))
                FrmAddPelicula.comb_distribuidor.SelectedValue = idDist
            End If
            consultaIdDis = True
        End If
    End Function

    Public Sub insertaPel()
        Dim strSql As String

        Dim cant As Integer

        consultaIdDis()

        If (FrmAddPelicula.cantidad.Text.Length <> 0) Then
            cant = Integer.Parse(FrmAddPelicula.cantidad.Text)
        End If

        If nombrePel <> "" And genero <> "" And cant > 0 And
           clasficacion <> "" And fechaAd <> "" And idDist <> 0 Then


            'Realiza inserción de datos
            strSql = "INSERT INTO peliculas  " &
                            "VALUES(0,'" & nombrePel & "','" & genero & "',
                              '" & clasficacion & "','" & fechaAd & "','" & idDist & "','" & cant & "' );"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If
    End Sub

    Public Function consultaId() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM  peliculas " &
                 "WHERE nombre='" & FrmAddPelicula.nombrePelicula.Text & "'"

        consultaId = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idPel = ""
            End If
            consultaId = True
        End If
        cnx.cerrar()
    End Function

    Public Sub actualizaPelicula()

        Dim strSql As String

        Dim cant As Integer

        consultaIdDis()

        If (FrmAddPelicula.cantidad.Text.Length <> 0) Then
            cant = Integer.Parse(FrmAddPelicula.cantidad.Text)
        End If


        If nombrePel <> "" And genero <> "" And cant > 0 And
           clasficacion <> "" And fechaAd <> "" And idDist > 0 Then


            strSql = "UPDATE peliculas set nombre= '" & nombrePel & "', genero = '" & genero & "',
                      clasificacion= '" & clasficacion & "',fechaAdqui='" & fechaAd & "',id_distribuidor = '" & idDist & "',cantidad = '" & cant & "'" &
                      "WHERE nombre=  '" & nombrePel & "'"

            MsgBox(strSql)


            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro Modificado!")

        Else
            MsgBox("Faltan datos del empleado!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If

    End Sub

    Public Sub actualizapelicula2(idPelicula As Integer, cantidad As Integer)
        Dim strSQL As String
        strSQL = "UPDATE peliculas set cantidad = " & cantidad & " " &
                    "WHERE id = " & idPelicula & " "

        cnx.objetoCommand(strSQL)
        cnx.cerrar()
    End Sub

    Public Function consultaUnaPelicula() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT * FROM peliculas where nombre = '" & nombrePel & "'"

        consultaUnaPelicula = False

        xDT = cnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombrePel = ""
            Else
                nombrePel = CStr(xDT.Rows(0)("nombre"))
            End If
        End If
    End Function

    Public Function consultaTodasPel() As Object
        Dim strSQL As String

        strSQL = "SELECT * from peliculas order by id asc"
        consultaTodasPel = cnx.objetoDataAdapter(strSQL)


    End Function

    Public Function buscarPelicula(nombre As String) As DataTable
        Dim strSQL As String

        Dim datos As DataTable

        strSQL = "SELECT * FROM peliculas WHERE nombre LIKE'%" & FrmPrincipal.Txt_Renta.Text & "%'"

        datos = cnx.objetoDataAdapter(strSQL)
        cnx.cerrar()
        Return datos
    End Function

    Public Sub poblarComboDis(ByVal objeto As ComboBox)
        Dim Lista As MySqlDataReader
        Dim strSql As String
        'Dim xCnx As New Oracle

        strSql = "SELECT nombre FROM distribuidor Order By id asc"
        Lista = cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub PoblarDataGridPel(ByVal DGVpeliculas As DataGridView)
        DGVpeliculas.DataSource = consultaTodasPel()
        DGVpeliculas.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVpeliculas.Columns.Item(0).Width = 50
        DGVpeliculas.Columns.Item(1).Width = 200
        DGVpeliculas.Columns.Item(2).Width = 200
        DGVpeliculas.Columns.Item(3).Width = 200
        DGVpeliculas.Columns.Item(4).Width = 200
        DGVpeliculas.Columns.Item(5).Width = 200
        DGVpeliculas.Columns.Item(6).Width = 200
        cnx.cerrar()

    End Sub


End Class
