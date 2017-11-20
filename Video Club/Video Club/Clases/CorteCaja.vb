Imports MySql.Data.MySqlClient
Public Class CorteCaja


    Private efecivoEsp As Integer
    Private efectivoCaja As Integer
    Private diferencia As Integer


    Public cnx As New conexion

    Public Sub New()

        efecivoEsp = 0
        efectivoCaja = 0
        diferencia = 0
    End Sub

    Public Sub New(ByVal efectivoE As Integer, ByVal efectivoC As Integer, ByVal difer As Integer)
        'Aquí recibimos los datos

        efecivoEsp = efectivoE
        efectivoCaja = efectivoC
        diferencia = difer
    End Sub

    Public Property getSetEfecEsp() As Integer
        Get
            Return efecivoEsp

        End Get
        Set(ByVal Value As Integer)
            efecivoEsp = Value
        End Set
    End Property
    Public Property getSetEfecCaja As Integer
        Get
            Return efectivoCaja

        End Get
        Set(ByVal Value As Integer)
            efectivoCaja = Value
        End Set
    End Property

    Public Sub insertaCorteCaja()
        Dim strSql As String
        Dim fecha As String
        Dim eEsperado As Integer
        Dim eCaja As Integer
        Dim dif As Integer

        Dim xDT As DataTable


        fecha = System.DateTime.Today.ToShortDateString

        strSql = "SELECT 1 FROM `corteCaja` WHERE fechaCorte = '" & System.DateTime.Today.ToShortDateString & "'"

        xDT = cnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count < 1 Then
            Integer.Parse(FrmCortedeCaja.Txt_EfectivoEsperado.Text)


            If (FrmCortedeCaja.Txt_EfectivoEsperado.Text.Length <> 0) Then
                eEsperado = Integer.Parse(FrmCortedeCaja.Txt_EfectivoEsperado.Text)
            End If

            If (FrmCortedeCaja.Txt_Efectivo.Text.Length <> 0) Then
                eCaja = Integer.Parse(FrmCortedeCaja.Txt_Efectivo.Text)
            End If
            If (FrmCortedeCaja.Txt_Diferencia.Text.Length <> 0) Then
                dif = Integer.Parse(FrmCortedeCaja.Txt_Diferencia.Text)
            End If


            If eCaja > 0 Then

                MsgBox("ya llegue aqui tambien")
                'Realiza inserción de datos
                strSql = "INSERT INTO corteCaja  " &
                                "VALUES('" & fecha & "','" & eEsperado & "','" & eCaja & "','" & dif & "');"

                cnx.objetoCommand(strSql)
                MessageBox.Show("Registro insertado!")
                cnx.cerrar()
            End If
        Else
            MessageBox.Show("Ya se hizo el corte de caja del dia de hoy")
        End If
    End Sub


    Public Sub cargarCorteCaja()
        Dim qry As String
        Dim xDT As DataTable

        qry = "SELECT sum(monto_venta) as suma FROM `venta` WHERE fecha = '" & System.DateTime.Today.ToShortDateString & "'"

        xDT = cnx.objetoDataAdapter(qry)
        If xDT.Rows.Count = 1 Then
            If Not IsDBNull(xDT.Rows(0)("suma")) Then
                FrmCortedeCaja.Txt_EfectivoEsperado.Text = xDT.Rows(0)("suma")
            Else
                FrmCortedeCaja.Txt_EfectivoEsperado.Text = 0
            End If
        End If

    End Sub

End Class
