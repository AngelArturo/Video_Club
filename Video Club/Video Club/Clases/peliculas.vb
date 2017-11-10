Imports MySql.Data.MySqlClient
Public Class Peliculas

    Private idPel As Integer
    Private nombreP As String
    Private genero As String
    Private cantidad As Integer
    Private clasificacion As String
    Private fechaAdq As String
    Private idDist As Integer
    Public cnx As New conexion

    Public Sub New()
        idPel = 0
        nombreP = ""
        genero = ""
        cantidad = 0
        clasificacion = ""
        fechaAdq = ""
        idDist = 0

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombr As String, ByVal genero As String, ByVal canti As Integer, ByVal clasif As String, ByVal fechaA As String, ByVal idDis As Integer)
        'Aquí recibimos los datos
        idPel = id
        nombreP = nombr
        genero = genero
        cantidad = canti
        clasificacion = clasif
        fechaAdq = fechaA
        idDist = idDis
    End Sub

    Public Property getSetIdP() As Integer
        Get
            Return idPel

        End Get
        Set(ByVal Value As Integer)
            idPel = Value
        End Set
    End Property


    Public Property getSetNombreP() As String
        Get
            Return nombreP
        End Get

        Set(ByVal Value As String)
            nombreP = ""
        End Set

    End Property

    Public Property getSetGenero() As String
        Get
            Return genero
        End Get

        Set(ByVal Value As String)
            genero = ""
        End Set

    End Property

    Public Property getSetCatidad() As Integer
        Get
            Return cantidad
        End Get
        Set(ByVal Value As Integer)
            cantidad = Value
        End Set
    End Property

    Public Property getSetClasificacion() As String
        Get
            Return clasificacion
        End Get

        Set(ByVal Value As String)
            clasificacion = ""
        End Set

    End Property
    Public Property getSetFechaAdq() As String
        Get
            Return fechaAdq
        End Get

        Set(ByVal Value As String)
            fechaAdq = ""
        End Set

    End Property
    Public Property getSetIdD() As Integer
        Get
            Return idDist

        End Get
        Set(ByVal Value As Integer)
            idDist = Value
        End Set
    End Property

    Public Function consultaIdDistriuidor() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM distribuidor " &
                 "WHERE nomre = '" & FrmAddPelicula.comb_distribuidor.Text & "'"

        consultaIdDistriuidor = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idDist = ""
            Else
                idDist = CStr(xDT.Rows(0)("id"))
                FrmAddPelicula.comb_distribuidor.SelectedValue = idDist
            End If
            consultaIdDistriuidor = True
            cnx.cerrar()
        End If
    End Function

    Public Sub insertaPelicula()
        Dim strSql As String
        Dim cant As Integer
        consultaIdDistriuidor()



        If (FrmAddPelicula.cantidad.Text.Length <> 0) Then
            cant = Integer.Parse(FrmAddPelicula.cantidad.Text)
        End If


        If FrmAddPelicula.nombrePelicula.Text <> "" And FrmAddPelicula.gnero.Text <> "" And cant > 0 And
              FrmAddPelicula.clasificacion.Text <> "" And FrmAddPelicula.fechaAd.Text <> "" And idDist > 0 Then

            MsgBox("ya llegue aqui tambien")
            'Realiza inserción de datos
            strSql = "INSERT INTO peliculas " &
                            "VALUES(0,'" & FrmAddPelicula.nombrePelicula.Text & "','" & FrmAddPelicula.gnero.Text & "',
                              ,'" & FrmAddPelicula.clasificacion.Text & "','" & FrmAddPelicula.fechaAd.Text & "','" & idDist & "','" & cant & "');"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If
    End Sub
    Public Sub poblarComboDistribuidor(ByVal objeto As ComboBox)
        Dim Lista As MySqlDataReader
        Dim strSql As String

        strSql = "SELECT nombre FROM distribuidor Order By nom asc"
        Lista = cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()

    End Sub

End Class
