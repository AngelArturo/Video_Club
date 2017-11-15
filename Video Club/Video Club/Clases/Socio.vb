Imports MySql.Data.MySqlClient
Public Class Socio
    Private idSocio As Integer
    Private nombreSocio As String
    Private aPaterno As String
    Private aMaterno As String
    Private genero As String
    Private calle As String
    Private colonia As String
    Private numeroEx As Integer
    Private numeroIn As Integer
    Private telefono As Integer
    Private celular As Integer
    Private credVig As Integer


    Public cnx As New conexion

    Public Sub New()
        idSocio = 0
        nombreSocio = ""
        aPaterno = ""
        aMaterno = ""
        genero = ""
        calle = ""
        colonia = ""
        numeroEx = 0
        numeroIn = 0
        telefono = 0
        celular = 0
        credVig = 0
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombr As String, ByVal pat As String, ByVal mat As String, ByVal genero As String, ByVal calleSocio As String, ByVal coloniaSocio As String,
                  ByVal numEx As Integer, ByVal numIn As Integer, ByVal tel As Integer, ByVal cel As Integer, ByVal credencialV As Integer)
        'Aquí recibimos los datos
        idSocio = id
        nombreSocio = nombr
        aPaterno = pat
        aMaterno = mat
        genero = genero
        calle = calleSocio
        colonia = coloniaSocio
        numeroEx = numEx
        numeroIn = numIn
        telefono = tel
        celular = cel
        credVig = credencialV
    End Sub

    Public Property getSetId() As Integer
        Get
            Return idSocio

        End Get
        Set(ByVal Value As Integer)
            idSocio = Value
        End Set
    End Property


    Public Property getSetNombre() As String
        Get
            Return nombreSocio
        End Get

        Set(ByVal Value As String)
            nombreSocio = ""
        End Set

    End Property

    Public Property getSetPaterno() As String
        Get
            Return aPaterno
        End Get

        Set(ByVal Value As String)
            aPaterno = ""
        End Set

    End Property
    Public Property getSetMaterno() As String
        Get
            Return aMaterno
        End Get

        Set(ByVal Value As String)
            aMaterno = ""
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
    Public Property getSetCalle() As String
        Get
            Return calle
        End Get

        Set(ByVal Value As String)
            calle = ""
        End Set

    End Property

    Public Property getSetColonia() As String
        Get
            Return colonia
        End Get
        Set(ByVal Value As String)
            colonia = ""
        End Set
    End Property
    Public Property getSetNumeroEx() As Integer
        Get
            Return numeroEx

        End Get
        Set(ByVal Value As Integer)
            numeroEx = Value
        End Set
    End Property
    Public Property getSetNumeroIn() As Integer
        Get
            Return numeroIn
        End Get
        Set(ByVal Value As Integer)
            numeroIn = Value
        End Set
    End Property
    Public Property getSetTelefono() As Integer
        Get
            Return telefono
        End Get
        Set(ByVal Value As Integer)
            telefono = Value
        End Set
    End Property
    Public Property getSetCelular() As Integer
        Get
            Return celular
        End Get
        Set(ByVal Value As Integer)
            celular = Value
        End Set
    End Property
    Public Property getSetCredencialVigente() As Integer
        Get
            Return credVig
        End Get
        Set(ByVal Value As Integer)
            credVig = Value
        End Set
    End Property



    Public Sub insertaSocio()
        Dim strSql As String
        Dim numExt As Integer
        Dim numInt As Integer
        Dim tel As Integer
        Dim cel As Integer

        If (FrmSocio.numIn.Text.Length <> 0) Then
            numInt = Integer.Parse(FrmSocio.numIn.Text)
        End If

        If (FrmSocio.numEx.Text.Length <> 0) Then
            numExt = Integer.Parse(FrmSocio.numEx.Text)
        End If

        If (FrmSocio.telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmSocio.telefono.Text)
        End If

        If (FrmSocio.celular.Text.Length <> 0) Then
            cel = Integer.Parse(FrmSocio.celular.Text)
        End If


        If FrmSocio.nombre.Text <> "" And FrmSocio.paterno.Text <> "" And FrmSocio.materno.Text <> "" And FrmSocio.sexo.Text <> "" And
            FrmSocio.calle.Text <> "" And numExt > 0 And FrmSocio.colonia.Text <> "" And tel > 0 And cel > 0 And Not FrmSocio.radioDeselecion.Checked Then

            'Realiza inserción de datos
            strSql = "INSERT INTO socio  " &
                            "VALUES(0,'" & FrmSocio.nombre.Text & "','" & FrmSocio.paterno.Text & "','" & FrmSocio.materno.Text & "','" & FrmSocio.sexo.Text & "','" & FrmSocio.calle.Text & "','" & FrmSocio.colonia.Text & "'," & numInt & "," & numExt & "," & tel & "," & cel & "," & FrmSocio.Radio.Checked & ");"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()



        End If
    End Sub

    Public Function consultaId() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM socio " &
                 "WHERE nombre='" & FrmSocio.nombre.Text & "'"

        consultaId = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idSocio = ""
            End If
            consultaId = True
        End If

    End Function

    Public Sub actualizaSocio()
        Dim strSql As String
        Dim numExt As Integer
        Dim numInt As Integer
        Dim tel As Integer
        Dim cel As Integer

        consultaId()


        numInt = Integer.Parse(FrmSocio.numIn.Text)
        MsgBox("llegue aqui")

        If (FrmSocio.numEx.Text.Length <> 0) Then
            numExt = Integer.Parse(FrmSocio.numEx.Text)
        End If
        MsgBox("llegue aqui 1")


        If (FrmSocio.telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmSocio.telefono.Text)
        End If
        MsgBox("llegue aqui 2")


        If (FrmSocio.celular.Text.Length <> 0) Then
            cel = Integer.Parse(FrmSocio.celular.Text)
        End If
        MsgBox("llegue aqui 3")



        If FrmSocio.nombre.Text <> "" And FrmSocio.paterno.Text <> "" And FrmSocio.materno.Text <> "" And FrmSocio.sexo.Text <> "" And
            FrmSocio.calle.Text <> "" And numInt > 0 And numExt > 0 And FrmSocio.colonia.Text <> "" And tel > 0 And cel > 0 And Not FrmSocio.radioDeselecion.Checked Then

            MsgBox("llegue aqui 4")
            strSql = "UPDATE socio set nombre ='" & FrmSocio.nombre.Text & "',apPaterno= '" & FrmSocio.paterno.Text & "',apMaterno= '" & FrmSocio.materno.Text & "',genero = '" & FrmSocio.sexo.Text & "',calle = '" & FrmSocio.calle.Text & "',colonia = '" & FrmSocio.colonia.Text & "',numeroInterior = '" & numeroIn & "',numeroExterior = '" & numeroEx & "',telefono= " & telefono & ",celular = " & celular & ",credencialVigenta = '" & FrmSocio.Radio.Checked & "' " &
                     "WHERE nombre =  '" & FrmSocio.nombre.Text & "'" &
                     "AND apPaterno = '" & FrmSocio.paterno.Text & "' " &
                     "AND apMaterno = '" & FrmSocio.materno.Text & "'"
            MsgBox(strSql)


            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro Modificado!")

        Else
            MsgBox("Faltan datos del Socio!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If

    End Sub

    Public Function consultaUnSocio() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT * FROM socio where nombre = '" & FrmSocio.nombre.Text & "' AND apPaterno ='" & FrmSocio.paterno.Text & "' AND apMaterno = '" & FrmSocio.materno.Text & "'"

        consultaUnSocio = False

        xDT = cnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombreSocio = ""
            Else
                nombreSocio = CStr(xDT.Rows(0)("nombre"))
            End If

            If IsDBNull(xDT.Rows(0)("apPaterno")) Then
                aPaterno = ""
            Else
                aPaterno = CStr(xDT.Rows(0)("apPaterno"))
            End If

            If IsDBNull(xDT.Rows(0)("apMaterno")) Then
                aMaterno = ""
            Else
                aMaterno = CStr(xDT.Rows(0)("apMaterno"))

            End If

            MsgBox("llegue")
        End If

    End Function

    Public Function consultaTodosSocios() As Object
        Dim strSQL As String

        strSQL = "SELECT * from socio order by id asc"
        consultaTodosSocios = cnx.objetoDataAdapter(strSQL)

    End Function

    Public Sub PoblarDataGridSocios(ByVal DGV_socios As DataGridView)
        DGV_socios.DataSource = consultaTodosSocios()
        DGV_socios.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGV_socios.Columns.Item(0).Width = 50
        DGV_socios.Columns.Item(1).Width = 200
        DGV_socios.Columns.Item(2).Width = 200
        DGV_socios.Columns.Item(3).Width = 200
        DGV_socios.Columns.Item(4).Width = 200
        DGV_socios.Columns.Item(5).Width = 200
        DGV_socios.Columns.Item(6).Width = 200
        DGV_socios.Columns.Item(7).Width = 200
        DGV_socios.Columns.Item(8).Width = 200
        DGV_socios.Columns.Item(9).Width = 200
        DGV_socios.Columns.Item(10).Width = 200

        cnx.cerrar()

    End Sub

End Class
