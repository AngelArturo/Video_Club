Imports MySql.Data.MySqlClient
Public Class Adeudos

    Private idA As Integer
    Private cantidadA As Integer
    Private estatusA As String
    Private idRenta As Integer


    Public cnx As New conexion

    Public Sub New()

        idA = 0
        cantidadA = 0
        estatusA = ""
        idRenta = 0

    End Sub



    Public Property getSetIdAdeudo() As Integer
        Get
            Return idA

        End Get
        Set(ByVal Value As Integer)
            idA = Value
        End Set
    End Property
    Public Property getSetCantidad As Integer
        Get
            Return cantidadA

        End Get
        Set(ByVal Value As Integer)
            cantidadA = Value
        End Set
    End Property

    Public Property getSetEstatus As String
        Get
            Return estatusA

        End Get
        Set(ByVal Value As String)
            estatusA = Value
        End Set
    End Property
    Public Property getSetIdRenta() As Integer
        Get
            Return idRenta

        End Get
        Set(ByVal Value As Integer)
            idRenta = Value
        End Set
    End Property

    Public Function consultaIdRenta() As Boolean
        Dim strSQL As String
        'Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id FROM renta " &
                 "WHERE id= '" & FrmAdeudos.renta.Text & "'"

        consultaIdRenta = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idRenta = ""
            Else
                idRenta = CStr(xDT.Rows(0)("id"))
                FrmAdeudos.renta.SelectedValue = idRenta
            End If
            consultaIdRenta = True
        End If
    End Function
    Public Function consultaId() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable

        strSQL = "SELECT id FROM  adeudos " &
                 "WHERE id ='" & FrmAdeudos.claveAdeudo.Text & "'"

        consultaId = False
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idA = ""
            End If
            consultaId = True
        End If

    End Function

    Public Sub insertaAdeudo()
        Dim strSql As String
        Dim cantidad As Integer



        consultaIdRenta()

        If (FrmAdeudos.cantidad.Text.Length <> 0) Then
            cantidad = Integer.Parse(FrmAdeudos.cantidad.Text)
        End If


        If cantidad > 0 And estatusA <> "" And idRenta Then

            MsgBox("ya llegue aqui tambien")
            'Realiza inserción de datos
            strSql = "INSERT INTO adeudos (`id`, `cantidad`, `estatus`,`id_renta`) " &
                                "VALUES(0,'" & cantidad & "','" & estatusA & "','" & idRenta & "');"

            cnx.objetoCommand(strSql)
            MessageBox.Show("Registro insertado!")
            cnx.cerrar()
        End If

    End Sub

    Public Sub actualizaAduedo()

        Dim strSql As String


        consultaId()

        strSql = "UPDATE adeudos set estatus= '" & estatusA & "'" &
                      "WHERE id=  '" & idA & "'"
        cnx.objetoCommand(strSql)
            MessageBox.Show("Registro Modificado!")





    End Sub

    Public Function consultaUnAdeudo() As Boolean
        Dim strSQL As String
        Dim xDT As DataTable


        strSQL = "SELECT id,cantidad,estatus,id_renta FROM adeudos where id = '" & idA & "'"


        consultaUnAdeudo = False

        xDT = cnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                idA = ""
            Else
                idA = CStr(xDT.Rows(0)("id"))
            End If
        End If
    End Function
    Public Function consultaTodosAdeudos() As Object
        Dim strSQL As String

        strSQL = "SELECT id,cantidad,estatus,id_renta from adeudos where estatus='Adeudo' order by id asc"

        consultaTodosAdeudos = cnx.objetoDataAdapter(strSQL)


    End Function

    Public Sub poblarComboRenta(ByVal objeto As ComboBox)
        Dim Lista As MySqlDataReader
        Dim strSql As String

        strSql = "SELECT id FROM renta Order By id asc"
        Lista = cnx.objetoDataReader(strSql)
        objeto.Items.Clear()
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()

    End Sub
    Public Sub PoblarDataGridAdeudo(ByVal DGVadeudos As DataGridView)
        DGVadeudos.DataSource = consultaTodosAdeudos()
        DGVadeudos.Refresh()
        'Establecer ancho de cada columna del DataGridView
        DGVadeudos.Columns.Item(0).Width = 50
        DGVadeudos.Columns.Item(1).Width = 50
        DGVadeudos.Columns.Item(2).Width = 50
        DGVadeudos.Columns.Item(3).Width = 50
        cnx.cerrar()

    End Sub





End Class
