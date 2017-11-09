Imports MySql.Data.MySqlClient
Public Class Distribuidor
    Private idDist As Integer
    Private nombreDist As String
    Private encargado As String
    Private direccion As String
    Private telefono As Integer
    Private celular As Integer
    Private correo As String

    Public cnx As New conexion

    Public Sub New()
        idDist = 0
        nombreDist = ""
        encargado = ""
        direccion = ""
        telefono = 0
        celular = 0
        correo = ""
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombr As String, ByVal encarg As String, ByVal direccion As String, ByVal tel As Integer, ByVal cel As Integer, ByVal correoD As String)
        'Aquí recibimos los datos
        idDist = id
        nombreDist = nombr
        encargado = encarg
        direccion = direccion
        telefono = tel
        celular = cel
        correo = correoD
    End Sub
    Public Property getSetIdD() As Integer
        Get
            Return idDist

        End Get
        Set(ByVal Value As Integer)
            idDist = Value
        End Set
    End Property


    Public Property getSetNombreD() As String
        Get
            Return nombreDist
        End Get

        Set(ByVal Value As String)
            nombreDist = ""
        End Set

    End Property

    Public Property getSetEncargado() As String
        Get
            Return encargado
        End Get

        Set(ByVal Value As String)
            encargado = ""
        End Set

    End Property
    Public Property getSetDireccion() As String
        Get
            Return direccion
        End Get

        Set(ByVal Value As String)
            direccion = ""
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
    Public Property getSetCorreo() As String
        Get
            Return correo
        End Get

        Set(ByVal Value As String)
            correo = ""
        End Set

    End Property

    Public Sub insertaDis()
        Dim strSql As String
        Dim tel As Integer
        Dim cel As Integer


        If (FrmAddDistribuidor.Txt_Telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmAddDistribuidor.Txt_Telefono.Text)
        End If

        If (FrmAddDistribuidor.Txt_Celular.Text.Length <> 0) Then
            cel = Integer.Parse(FrmAddDistribuidor.Txt_Celular.Text)
        End If


        If FrmAddDistribuidor.Txt_NombreDistribuidor.Text <> "" And FrmAddDistribuidor.Txt_Encargado.Text <> "" And FrmAddDistribuidor.RichTxt_Direccion.Text <> "" And
             tel > 0 And cel > 0 And FrmAddDistribuidor.Txt_Correo.Text <> "" Then

            MsgBox("ya llegue aqui tambien")
            'Realiza inserción de datos
            strSql = "INSERT INTO distribuidor  " &
                            "VALUES(0,'" & FrmAddDistribuidor.Txt_NombreDistribuidor.Text & "','" & FrmAddDistribuidor.Txt_Encargado.Text & "','" & FrmAddDistribuidor.RichTxt_Direccion.Text & "'
                              ,'" & tel & "','" & cel & "','" & FrmAddDistribuidor.Txt_Correo.Text & "');"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If
    End Sub
    Public Function consultaId() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM distribuidor " &
                 "WHERE nombre='" & FrmAddDistribuidor.Txt_NombreDistribuidor.Text & "'"

        consultaId = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idDist = ""
            End If
            consultaId = True
        End If

    End Function
    Public Sub actualizaDist()
        Dim strSql As String
        Dim cel As Integer
        Dim tel As Integer



        If (FrmAddDistribuidor.Txt_Telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmAddDistribuidor.Txt_Telefono.Text)
        End If

        If (FrmAddDistribuidor.Txt_Celular.Text.Length <> 0) Then
            cel = Integer.Parse(FrmAddDistribuidor.Txt_Celular.Text)
        End If


        If FrmAddDistribuidor.Txt_NombreDistribuidor.Text <> "" And FrmAddDistribuidor.Txt_Encargado.Text <> "" And FrmAddDistribuidor.RichTxt_Direccion.Text <> "" And
             tel > 0 And cel > 0 And FrmAddDistribuidor.Txt_Correo.Text <> "" Then

            strSql = "UPDATE distribuidor set nombre= '" & FrmAddDistribuidor.Txt_NombreDistribuidor.Text & "',encargado= '" & FrmAddDistribuidor.Txt_Encargado.Text & "',direccion = '" & FrmAddDistribuidor.RichTxt_Direccion.Text & "',
                      telefono= " & tel & ",celular = " & cel & ",correo= '" & FrmAddDistribuidor.Txt_Correo.Text & "'" &
                      "WHERE nombre=  '" & FrmAddDistribuidor.Txt_NombreDistribuidor.Text & "'"

            MsgBox(strSql)


            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro Modificado!")

        Else
            MsgBox("Faltan datos del empleado!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If

    End Sub

    Public Function consultaUnDistribuidor() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable


        strSQL = "SELECT * FROM distribuidor where nombre = '" & FrmAddDistribuidor.Txt_NombreDistribuidor.Text & "'"


        consultaUnDistribuidor = False

        xDT = cnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombreDist = ""
            Else
                nombreDist = CStr(xDT.Rows(0)("nombre"))
            End If
        End If
    End Function
    Public Function consultaTodosDist() As Object
        Dim strSQL As String

        strSQL = "SELECT * from distribuidor order by id asc"
        consultaTodosDist = cnx.objetoDataAdapter(strSQL)

    End Function
    Public Sub PoblarDataGridDistr(ByVal DGVdistri As DataGridView)
        DGVdistri.DataSource = consultaTodosDist()
        DGVdistri.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVdistri.Columns.Item(0).Width = 50
        DGVdistri.Columns.Item(1).Width = 200
        DGVdistri.Columns.Item(2).Width = 200
        DGVdistri.Columns.Item(3).Width = 200
        DGVdistri.Columns.Item(4).Width = 200
        DGVdistri.Columns.Item(5).Width = 200
        DGVdistri.Columns.Item(6).Width = 200
        cnx.cerrar()

    End Sub


End Class
