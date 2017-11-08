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
    Private celular As Integer
    Private codigoP As Integer
    Private correo As String
    Private nombreUs As String
    Private conU As String
    Private tipoE As String

    Public cnx As New conexion

    Public Sub New()


        idEmpleado = ""
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
        celular = 0
        codigoP = 0
        correo = ""
        nombreUs = ""
        conU = ""
        tipoE = ""

    End Sub

    Public Sub New(ByVal idE As Integer, ByVal pat As String, ByVal mat As String, ByVal nombr As String, ByVal curp As String, ByVal rfc As String, ByVal dia As Integer,
                 ByVal mes As String, ByVal ano As Integer, ByVal genero As String, ByVal lugar As String, ByVal calle As String, ByVal numero As Integer,
                   ByVal col As Integer, ByVal tel As Integer, ByVal cel As Integer, ByVal codigoP As Integer, ByVal correo As String, ByVal nombreUsu As String, ByVal conE As String,
                    ByVal tipoEm As String)
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
    Public Property getSetCelular() As Integer
        Get
            Return celular
        End Get
        Set(ByVal Value As Integer)
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
    Public Property getSetTipoE() As String
        Get
            Return tipoE
        End Get
        Set(ByVal Value As String)
            tipoE = ""
        End Set
    End Property

    Public Sub insertaSocio()
        Dim strSql As String
        Dim diaN As Integer
        Dim anoE As Integer
        Dim num As Integer
        Dim cel As Integer
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

        If (FrmEmpleado.celular.Text.Length <> 0) Then
            cel = Integer.Parse(FrmEmpleado.celular.Text)
        End If
        If (FrmEmpleado.codigoP.Text.Length <> 0) Then
            codi = Integer.Parse(FrmEmpleado.codigoP.Text)
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




End Class
