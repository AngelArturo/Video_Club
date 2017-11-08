Public Class Empleados


    Private idEmpleado As Integer
    Private aPaterno As String
    Private aMaterno As String
    Private nombres As String
    Private curp As String
    Private rfc As String
    Private dia As Integer
    Private mes As String
    Private ano As Integer
    Private genero As String
    Private lugarN As String
    Private calle As String
    Private numero As Integer
    Private colonia As String
    Private telefono As Integer
    Private celular As Integer
    Private codigoP As Integer
    Private correo As String
    Private nombreU As String
    Private contrasenaU As String
    Private tipoU As String

    Public cnx As New conexion

    Public Sub New()
        idEmpleado = 0
        aPaterno = ""
        aMaterno = ""
        nombres = ""
        curp = ""
        rfc = ""
        dia = 0
        mes = ""
        ano = 0
        genero = ""
        lugarN = ""
        calle = ""
        numero = 0
        colonia = ""
        telefono = 0
        celular = 0
        codigoP = 0
        correo = ""
        nombreU = ""
        contrasenaU = ""
        tipoU = ""
    End Sub

    Public Sub New(ByVal id As Integer, ByVal pat As String, ByVal mat As String, ByVal nombresE As String, ByVal curp As String, ByVal rfc As String,
                 ByVal dia As Integer, ByVal mes As String, ByVal ano As Integer, ByVal genero As String, ByVal lugar As Integer, ByVal calle As String,
                   ByVal numero As Integer, ByVal col As String, ByVal tel As Integer, ByVal cel As Integer, ByVal codigo As Integer, ByVal correoE As String,
                   ByVal nombreUs As String, ByVal con As String, ByVal tipo As String)
        'Aquí recibimos los datos

        idEmpleado = id
        aPaterno = pat
        aMaterno = mat
        nombres = nombresE
        curp = curp
        rfc = rfc
        dia = dia
        mes = mes
        ano = ano
        genero = genero
        lugarN = lugar
        calle = calle
        numero = numero
        colonia = col
        telefono = tel
        celular = cel
        codigoP = codigo
        correo = correoE
        nombreU = nombreUs
        contrasenaU = con
        tipoU = tipo

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
            Return nombres
        End Get

        Set(ByVal Value As String)
            nombres = ""
        End Set

    End Property
    Public Property getSetCurp() As String
        Get
            Return curp

        End Get

        Set(ByVal Value As String)
            curp = ""
        End Set

    End Property
    Public Property getSetRfc() As String
        Get
            Return rfc
        End Get

        Set(ByVal Value As String)
            rfc = ""
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
            Return genero
        End Get
        Set(ByVal Value As String)
            genero = ""
        End Set
    End Property
    Public Property getSetLugarN() As String
        Get
            Return lugarN
        End Get
        Set(ByVal Value As String)
            lugarN = ""
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
    Public Property getSetNumero() As Integer
        Get
            Return numero

        End Get
        Set(ByVal Value As Integer)
            numero = Value
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
            Return nombreU
        End Get
        Set(ByVal Value As String)
            nombreU = ""
        End Set
    End Property
    Public Property getSetContrasena() As String
        Get
            Return contrasenaU
        End Get
        Set(ByVal Value As String)
            contrasenaU = ""
        End Set
    End Property
    Public Property getSetTipoU() As String
        Get
            Return tipoU
        End Get
        Set(ByVal Value As String)
            tipoU = ""
        End Set
    End Property

    Public Sub insertaSocio()
        Dim strSql As String
        Dim diaN As Integer
        Dim anoN As Integer
        Dim num As Integer
        Dim tel As Integer
        Dim cel As Integer
        Dim codigo As Integer

        If (FormEmpleado.dia.Text.Length <> 0) Then
            diaN = Integer.Parse(FormEmpleado.dia.Text)
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





End Class
