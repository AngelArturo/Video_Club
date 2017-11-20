Imports MySql.Data.MySqlClient
Public Class Empleado

    Private idEmpleado As Integer
    Private aPaterno As String
    Private aMaterno As String
    Private nombreEmpleado As String
    Private curpE As String
    Private rfcE As String
    Private dia As Integer
    Private mes As String
    Private ano As Integer
    Private generoE As String
    Private lugarNE As String
    Private calleE As String
    Private numeroE As Integer
    Private coloniaE As String
    Private telefono As Integer
    Private celular As String
    Private codigoP As Integer
    Private correo As String
    Private nombreUs As String
    Private conU As String
    Private tipoE As Integer

    Public cnx As New conexion

    Public Sub New()


        idEmpleado = 0
        aPaterno = ""
        aMaterno = ""
        nombreEmpleado = ""
        curpE = ""
        rfcE = ""
        dia = 0
        mes = ""
        ano = 0
        generoE = ""
        lugarNE = ""
        calleE = ""
        numeroE = 0
        coloniaE = ""
        telefono = 0
        celular = ""
        codigoP = 0
        correo = ""
        nombreUs = ""
        conU = ""
        tipoE = 0

    End Sub

    Public Sub New(ByVal idE As Integer, ByVal pat As String, ByVal mat As String, ByVal nombr As String, ByVal curp As String, ByVal rfc As String, ByVal dia As Integer,
                 ByVal mes As String, ByVal ano As Integer, ByVal genero As String, ByVal lugar As String, ByVal calle As String, ByVal numero As Integer,
                   ByVal col As Integer, ByVal tel As Integer, ByVal cel As String, ByVal codigoP As Integer, ByVal correo As String, ByVal nombreUsu As String, ByVal conE As String,
                    ByVal tipoEm As Integer)
        'Aquí recibimos los datos
        idEmpleado = idE
        aPaterno = pat
        aMaterno = mat
        nombreEmpleado = nombr
        curpE = curp
        rfcE = rfc
        dia = dia
        mes = mes
        ano = ano
        generoE = genero
        lugarNE = lugar
        calleE = calle
        numeroE = numero
        coloniaE = col
        telefono = tel
        celular = cel
        codigoP = codigoP
        correo = correo
        nombreUs = nombreUs
        conU = conE
        tipoE = tipoEm

    End Sub

    Public Property getSetId() As Integer
        Get
            Return idEmpleado

        End Get
        Set(ByVal Value As Integer)
            idEmpleado = Value
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

    Public Property getSetNombres() As String
        Get
            Return nombreEmpleado
        End Get

        Set(ByVal Value As String)
            nombreEmpleado = ""
        End Set

    End Property
    Public Property getSetCurp() As String
        Get
            Return curpE

        End Get

        Set(ByVal Value As String)
            curpE = ""
        End Set

    End Property
    Public Property getSetRfc() As String
        Get
            Return rfcE
        End Get

        Set(ByVal Value As String)
            rfcE = ""
        End Set

    End Property

    Public Property getSetDia() As Integer
        Get
            Return dia

        End Get
        Set(ByVal Value As Integer)
            dia = Value
        End Set
    End Property

    Public Property getSetMes() As String
        Get
            Return mes
        End Get
        Set(ByVal Value As String)
            mes = ""
        End Set
    End Property
    Public Property getSetAno() As Integer
        Get
            Return ano

        End Get
        Set(ByVal Value As Integer)
            ano = Value
        End Set
    End Property
    Public Property getSetGenero() As String
        Get
            Return generoE
        End Get
        Set(ByVal Value As String)
            generoE = ""
        End Set
    End Property
    Public Property getSetLugarN() As String
        Get
            Return lugarNE
        End Get
        Set(ByVal Value As String)
            lugarNE = ""
        End Set
    End Property
    Public Property getSetCalle() As String
        Get
            Return calleE
        End Get
        Set(ByVal Value As String)
            calleE = ""
        End Set
    End Property

    Public Property getSetNumero() As Integer
        Get
            Return numeroE
        End Get
        Set(ByVal Value As Integer)
            numeroE = Value
        End Set
    End Property
    Public Property getSetColonia() As String
        Get
            Return coloniaE
        End Get
        Set(ByVal Value As String)
            coloniaE = ""
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
    Public Property getSetCelular() As String
        Get
            Return celular
        End Get
        Set(ByVal Value As String)
            celular = Value
        End Set
    End Property
    Public Property getSetCodigoP() As Integer
        Get
            Return codigoP
        End Get
        Set(ByVal Value As Integer)
            codigoP = Value
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
    Public Property getSetNombreU() As String
        Get
            Return nombreUs
        End Get
        Set(ByVal Value As String)
            nombreUs = ""
        End Set
    End Property
    Public Property getSetContrasena() As String
        Get
            Return conU
        End Get
        Set(ByVal Value As String)
            conU = ""
        End Set
    End Property
    Public Property getSetTipoE() As Integer
        Get
            Return tipoE
        End Get
        Set(ByVal Value As Integer)
            tipoE = Value
        End Set
    End Property

    Public Sub insertaEmpleado()
        Dim strSql As String
        Dim diaN As Integer
        Dim anoE As Integer
        Dim num As Integer
        Dim tel As Integer
        Dim codi As Integer



        If (FrmEmpleado.dia.Text.Length <> 0) Then
            diaN = Integer.Parse(FrmEmpleado.dia.Text)
        End If

        If (FrmEmpleado.ano.Text.Length <> 0) Then
            anoE = Integer.Parse(FrmEmpleado.ano.Text)
        End If

        If (FrmEmpleado.numero.Text.Length <> 0) Then
            num = Integer.Parse(FrmEmpleado.numero.Text)
        End If

        If (FrmEmpleado.telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmEmpleado.telefono.Text)
        End If


        If (FrmEmpleado.codigoP.Text.Length <> 0) Then
            codi = Integer.Parse(FrmEmpleado.codigoP.Text)
        End If


        If FrmEmpleado.paterno.Text <> "" And FrmEmpleado.TextBox1.Text <> "" And FrmEmpleado.TextBox2.Text <> "" And FrmEmpleado.TextBox3.Text <> "" And
            FrmEmpleado.TextBox4.Text <> "" And diaN > 0 And FrmEmpleado.mes.Text <> "" And anoE > 0 And FrmEmpleado.genero.Text <> "" And FrmEmpleado.lugarN.Text <> "" And
            FrmEmpleado.calle.Text <> "" And num > 0 And FrmEmpleado.colonia.Text <> "" And tel > 0 And celular > "" And codi > 0 And FrmEmpleado.correo.Text <> "" And
            FrmEmpleado.nombreUsuario.Text <> "" And FrmEmpleado.contrasena.Text <> "" And FrmEmpleado.tipoU.Text <> "" Then



            'Realiza inserción de datos
            strSql = "INSERT INTO empleados  " &
                            "VALUES(0,'" & FrmEmpleado.paterno.Text & "','" & FrmEmpleado.TextBox1.Text & "','" & FrmEmpleado.TextBox2.Text & "','" & FrmEmpleado.TextBox3.Text & "',
                                    '" & FrmEmpleado.TextBox4.Text & "'," & diaN & ",'" & FrmEmpleado.mes.Text & "'," & anoE & ",'" & FrmEmpleado.genero.Text & "','" & FrmEmpleado.lugarN.Text & "',
                                    '" & FrmEmpleado.calle.Text & "'," & num & ", '" & FrmEmpleado.colonia.Text & "'," & tel & "," & celular & "," & codi & ",'" & FrmEmpleado.correo.Text & "',
                                    '" & FrmEmpleado.nombreUsuario.Text & "','" & FrmEmpleado.contrasena.Text & "','" & FrmEmpleado.tipoU.Text & "');"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If
    End Sub

    Public Function consultaId() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM empleados " &
                 "WHERE nombres='" & FrmEmpleado.TextBox2.Text & "'"

        consultaId = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idEmpleado = ""
            End If
            consultaId = True
        End If

    End Function

    Public Sub actualizaEmpleado()
        Dim strSql As String
        Dim diaN As Integer
        Dim anoE As Integer
        Dim num As Integer

        Dim tel As Integer
        Dim codi As Integer



        If (FrmEmpleado.dia.Text.Length <> 0) Then
            diaN = Integer.Parse(FrmEmpleado.dia.Text)
        End If

        If (FrmEmpleado.ano.Text.Length <> 0) Then
            anoE = Integer.Parse(FrmEmpleado.ano.Text)
        End If

        If (FrmEmpleado.numero.Text.Length <> 0) Then
            num = Integer.Parse(FrmEmpleado.numero.Text)
        End If

        If (FrmEmpleado.telefono.Text.Length <> 0) Then
            tel = Integer.Parse(FrmEmpleado.telefono.Text)
        End If


        If (FrmEmpleado.codigoP.Text.Length <> 0) Then
            codi = Integer.Parse(FrmEmpleado.codigoP.Text)
        End If


        If FrmEmpleado.paterno.Text <> "" And FrmEmpleado.TextBox1.Text <> "" And FrmEmpleado.TextBox2.Text <> "" And FrmEmpleado.TextBox3.Text <> "" And
            FrmEmpleado.TextBox4.Text <> "" And diaN > 0 And FrmEmpleado.mes.Text <> "" And anoE > 0 And FrmEmpleado.genero.Text <> "" And FrmEmpleado.lugarN.Text <> "" And
            FrmEmpleado.calle.Text <> "" And num > 0 And FrmEmpleado.colonia.Text <> "" And tel > 0 And celular > 0 And codi > 0 And FrmEmpleado.correo.Text <> "" And
            FrmEmpleado.nombreUsuario.Text <> "" And FrmEmpleado.contrasena.Text <> "" And FrmEmpleado.tipoU.Text <> "" Then

            strSql = "UPDATE empleados set apPaterno= '" & FrmEmpleado.paterno.Text & "',apMaterno= '" & FrmEmpleado.TextBox1.Text & "',nombres = '" & FrmEmpleado.TextBox2.Text & "',curp = '" & FrmEmpleado.TextBox3.Text & "',rfc = '" & FrmEmpleado.TextBox4.Text & "',
                      dia = '" & diaN & "',mes = '" & FrmEmpleado.mes.Text & "',ano = '" & FrmEmpleado.ano.Text & "',genero = '" & FrmEmpleado.genero.Text & "',lugarNacimiento = '" & FrmEmpleado.lugarN.Text & "',calle = '" & FrmEmpleado.calle.Text & "',
                      numero= " & num & ", colonia= '" & FrmEmpleado.colonia.Text & "',telefono= " & telefono & ",celular = " & celular & ",codigoP = " & codi & ",correo= '" & FrmEmpleado.correo.Text & "',nombreUsuario= '" & FrmEmpleado.nombreUsuario.Text & "',
                      contrasena= '" & FrmEmpleado.contrasena.Text & "',tipoUsuario= '" & FrmEmpleado.tipoU.Text & "'" &
                 "WHERE nombres=  '" & FrmEmpleado.TextBox2.Text & "'" &
                 "AND apPaterno = '" & FrmEmpleado.paterno.Text & "' " &
                 "AND apMaterno = '" & FrmEmpleado.TextBox1.Text & "'"
            MsgBox(strSql)


            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro Modificado!")

        Else
            MsgBox("Faltan datos del empleado!!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If

    End Sub

    Public Function consultaUnEmpleado() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable


        strSQL = "SELECT * FROM empleados where nombres = '" & FrmEmpleado.TextBox2.Text & "' AND apPaterno ='" & FrmEmpleado.paterno.Text & "' AND apMaterno = '" & FrmEmpleado.TextBox2.Text & "'"


        consultaUnEmpleado = False

        xDT = cnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombres")) Then
                nombreEmpleado = ""
            Else
                nombreEmpleado = CStr(xDT.Rows(0)("nombres"))
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


        End If

    End Function

    Public Function consultaTodosEmpleados() As Object
        Dim strSQL As String

        strSQL = "SELECT * from empleados order by id asc"
        consultaTodosEmpleados = cnx.objetoDataAdapter(strSQL)

    End Function

    Public Sub PoblarDataGridEmpleado(ByVal DGVempleados As DataGridView)
        DGVempleados.DataSource = consultaTodosEmpleados()
        DGVempleados.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVempleados.Columns.Item(0).Width = 50
        DGVempleados.Columns.Item(1).Width = 200
        DGVempleados.Columns.Item(2).Width = 200
        DGVempleados.Columns.Item(3).Width = 200
        DGVempleados.Columns.Item(4).Width = 200
        DGVempleados.Columns.Item(5).Width = 200
        DGVempleados.Columns.Item(6).Width = 200
        DGVempleados.Columns.Item(7).Width = 200
        DGVempleados.Columns.Item(8).Width = 200
        DGVempleados.Columns.Item(9).Width = 200
        DGVempleados.Columns.Item(10).Width = 200
        DGVempleados.Columns.Item(11).Width = 200
        DGVempleados.Columns.Item(12).Width = 200
        DGVempleados.Columns.Item(13).Width = 200
        DGVempleados.Columns.Item(14).Width = 200
        DGVempleados.Columns.Item(15).Width = 200
        DGVempleados.Columns.Item(16).Width = 200
        DGVempleados.Columns.Item(17).Width = 200
        DGVempleados.Columns.Item(18).Width = 200
        DGVempleados.Columns.Item(19).Width = 200
        DGVempleados.Columns.Item(20).Width = 200

        cnx.cerrar()

    End Sub

End Class
