Imports MySql.Data.MySqlClient

Public Class FrmPrincipal
    'Funciones del Form Principal'
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Lbl_Fecha.Text = Date.Now.ToLongDateString
        Lbl_Usuario.Text = empleadonombre
        SlidePanel.Height = BtnInicio.Height
        Panel_Inicio.BringToFront()
        DTP_Catalogo.Value = DateTime.Now.AddDays(5)
        DTP_Estreno.Value = DateTime.Now.AddDays(3)
    End Sub

    'Funcionalidaes del boton cerrar X'
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        'FrmLogin.ActiveForm.Close()
        Me.Close()
    End Sub

    'Funcionalidades del boton minimizar'
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Mostrar Menus del Usuario tipoADMINISTRADOR
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        SlidePanel.Height = BtnInicio.Height
        SlidePanel.Top = BtnInicio.Top
        Panel_Inicio.BringToFront()
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        SlidePanel.Height = BtnEmpleado.Height
        SlidePanel.Top = BtnEmpleado.Top
        Panel_Empleado.BringToFront()
        Dim empleado As New Empleado
        empleado.PoblarDataGridEmpleado(DGVempleados)
        'cnx.cerrar()
    End Sub

    Private Sub BtnPeliculas_Click(sender As Object, e As EventArgs) Handles BtnPeliculas.Click
        SlidePanel.Height = BtnPeliculas.Height
        SlidePanel.Top = BtnPeliculas.Top
        Panel_Peliculas.BringToFront()
    End Sub

    Private Sub BtnDistribuidor_Click(sender As Object, e As EventArgs) Handles BtnDistribuidor.Click
        SlidePanel.Height = BtnDistribuidor.Height
        SlidePanel.Top = BtnDistribuidor.Top
        Panel_Distribuidor.BringToFront()
    End Sub

    Private Sub BtnCortedeCaja_Click(sender As Object, e As EventArgs) Handles BtnCortedeCaja.Click
        SlidePanel.Height = BtnCortedeCaja.Height
        SlidePanel.Top = BtnCortedeCaja.Top
        FrmCortedeCaja.Show()
        FrmCortedeCaja.BringToFront()
    End Sub

    'Mostrar Forms del Usuario tipoEmpleado
    Private Sub Btn_Renta_Click(sender As Object, e As EventArgs) Handles Btn_Renta.Click
        Panel_Venta.Visible = False
        If Txt_idSocio.Text = "" Then
            MessageBox.Show("Ingresa el Socio a&c")
        Else
            Panel_Renta.Show()
        End If
        Dim ren As New Renta
        ren.PoblarDataGridRenta(DGVrenta)
        cnx.Close()
        'Timer1.Start()
    End Sub

    Private Sub Btn_Venta_Click(sender As Object, e As EventArgs) Handles Btn_Venta.Click
        Panel_Venta.Visible = True
        Panel_Renta.Visible = False
        Dim ven As New Venta
        ven.PoblarDataGridVenta(DGV_venta)
        cnx.Close()
    End Sub

    Private Sub Btn_Socio_Click(sender As Object, e As EventArgs) Handles Btn_Socio.Click
        FrmSocio.Show()
    End Sub

    Private Sub Btn_AddPelicula_Click(sender As Object, e As EventArgs) Handles Btn_AddPelicula.Click
        FrmAddPelicula.Show()
    End Sub

    Private Sub Btn_AddDistribuidor_Click(sender As Object, e As EventArgs) Handles Btn_AddDistribuidor.Click
        FrmAddDistribuidor.Show()
    End Sub

    Private Sub Btn_AddEmpleado_Click(sender As Object, e As EventArgs) Handles Btn_AddEmpleado.Click
        FrmEmpleado.Show()
    End Sub

    'VERIFICAR SOCIO Y MOSTRAR LAS RENTAS
    Private Sub Btn_BusquedaSocio_Click(sender As Object, e As EventArgs) Handles Btn_BusquedaSocio.Click
        Dim adaptador As New MySqlDataAdapter
        Dim datos As DataSet
        Dim strSQL As String
        Dim lista As Byte

        If Txt_idSocio.Text <> "" Then
            strSQL = "SELECT * FROM socio WHERE id='" & Txt_idSocio.Text & "'"
            adaptador = New MySqlDataAdapter(strSQL, cnx)
            datos = New DataSet
            adaptador.Fill(datos, "socio")
            lista = datos.Tables("socio").Rows.Count
        End If

        If lista <> 0 Then
            Txt_NombreSocio.Text = datos.Tables("socio").Rows(0).Item("nombre")
            Txt_ApPaternoSocio.Text = datos.Tables("socio").Rows(0).Item("apPaterno")
            Txt_ApMaternoSocio.Text = datos.Tables("socio").Rows(0).Item("apMaterno")
        Else
            Txt_idSocio.Text = ""
            Txt_NombreSocio.Text = ""
            Txt_ApPaternoSocio.Text = ""
            Txt_ApMaternoSocio.Text = ""
            MsgBox("El idSocio no es válido. ¡Ingresalo Correctamente!")
        End If
        Dim ren As New Renta
        ren.PoblarDataGridSocioRenta(DGV_RentasSocio)
        Btn_Devolver.Visible = True
        cnx.Close()
    End Sub


    'RENTA
    Private Sub Btn_CerrarRenta_Click(sender As Object, e As EventArgs) Handles Btn_CerrarRenta.Click
        Panel_Renta.Visible = False
    End Sub

    Private Function consultarPeliculaNombre() As DataTable
        Dim pel As New Pelicula
        Return pel.buscarPelicula(Txt_Renta.Text)
    End Function

    Private Sub BtnRenta_Click(sender As Object, e As EventArgs) Handles BtnRenta.Click
        For Each filaSeleccionada In DGVrenta.SelectedRows
            If RB_Catalago.Checked = False And RB_Estreno.Checked = False Then
                MessageBox.Show("Ingresa si la pelicula es Estreno o de Catálogo")
                Return
            End If
            Dim celdas As DataGridViewCellCollection = filaSeleccionada.cells
            Dim idPelicula As Integer = celdas(0).Value.ToString
            Dim cantidad As Integer = celdas(6).Value.ToString
            Dim rent As New Renta


            rent.getSetImpR = RB_Catalago.Checked
            rent.getSetImpR = RB_Estreno.Checked
            rent.getSetFeE = Convert.ToDateTime(DTP_Catalogo.Text).ToShortDateString
            rent.getSetFeE = Convert.ToDateTime(DTP_Estreno.Text).ToShortDateString
            rent.addRenta(idPelicula)

            cantidad = cantidad - 1
            Dim pel As New Pelicula
            pel.actualizapelicula2(idPelicula, cantidad)


            Dim lista As ListViewItem = New ListViewItem()
            Dim impR As Double

            If (RB_Estreno.Checked = True) Then
                impR = 50
            End If
            If (RB_Catalago.Checked = True) Then
                impR = 25
            End If
            lista.SubItems.Add("Renta")
            lista.SubItems.Add(celdas(1).Value.ToString)
            lista.SubItems.Add(impR)
            LV_Importe.Items.Add(lista)
        Next

        Me.calculaTotal()
        Panel_Renta.Visible = False
    End Sub

    Private Sub Btn_Busca_Click(sender As Object, e As EventArgs) Handles Btn_Busca.Click
        DGVrenta.DataSource = consultarPeliculaNombre()
    End Sub

    'DEVOLVER PELICULA RENTADA
    Private Sub Btn_Devolver_Click(sender As Object, e As EventArgs) Handles Btn_Devolver.Click
        Dim response As MsgBoxResult
        response = MsgBox("¿La pelicula ya fue devuelta?", MsgBoxStyle.YesNo, "Devolver")

        If response = MsgBoxResult.Yes Then
            Dim re As New Renta
            For Each filaSeleccionada In DGV_RentasSocio.SelectedRows
                Dim celdas As DataGridViewCellCollection = filaSeleccionada.cells
                Dim idRenta As Integer = celdas(0).Value.ToString
                Dim idPelicula As Integer = celdas(1).Value.ToString

                re.Devolver(idRenta, idPelicula)
            Next

            For Each filaSeleccionada In DGVrenta.SelectedRows
                Dim celdas As DataGridViewCellCollection = filaSeleccionada.cells
                Dim idPelicula As Integer = celdas(0).Value.ToString
                Dim cantidad As Integer = celdas(6).Value.ToString
                cantidad = cantidad + 1
            Next
            DGV_RentasSocio.Refresh()
        End If
    End Sub

    'VENTA
    Private Sub Btn_CerrarVenta_Click(sender As Object, e As EventArgs) Handles Btn_CerrarVenta.Click
        Panel_Venta.Visible = False
    End Sub

    Private Function consultarPeliculaNombreVenta() As DataTable
        Dim pel As New Pelicula
        Return pel.buscarPelicula(Txt_BscrPelVenta.Text)
    End Function

    Private Sub Btn_Comprar_Click(sender As Object, e As EventArgs) Handles Btn_Comprar.Click
        For Each filaSeleccionada In DGV_venta.SelectedRows
            If Txt_MontoVenta.Text = "" Then
                MsgBox("¡Falta agregar el monto de la venta!")
                Return
            End If
            Dim celdas As DataGridViewCellCollection = filaSeleccionada.cells
            Dim idPelicula As Integer = celdas(0).Value.ToString
            Dim cantidad As Integer = celdas(6).Value.ToString
            Dim venta As New Venta
            venta.addVenta(idPelicula)

            cantidad = cantidad - 1
            Dim pel As New Pelicula
            pel.actualizapelicula2(idPelicula, cantidad)

            Dim lista As ListViewItem = New ListViewItem()
            Dim montV As Double = CDbl(Txt_MontoVenta.Text)

            lista.SubItems.Add("Venta")
            lista.SubItems.Add(celdas(1).Value.ToString)
            lista.SubItems.Add(montV)
            LV_Importe.Items.Add(lista)
        Next

        Me.calculaTotal()
        Panel_Venta.Visible = False
    End Sub

    'PAGAR
    Private Sub calculaTotal()
        Dim total As Double
        For i = 0 To LV_Importe.Items.Count - 1
            total += CDbl(LV_Importe.Items(i).SubItems(3).Text)
        Next i
        Lbl_Total2.Text = "$" & total
        Lbl_Total2.Visible = True
    End Sub

    Private Sub Btn_Pagar_Click(sender As Object, e As EventArgs) Handles Btn_Pagar.Click
        Dim resta As Integer

        If Not IsNumeric(Txt_Pago.Text) Then
            MsgBox("!Cantidad Invalida!")
        Else
            resta = CInt(Txt_Pago.Text) - CInt(Lbl_Total2.Text)
            Lbl_Cambio2.Text = StrConv(resta, VbStrConv.ProperCase)
            Lbl_Cambio2.Visible = True
        End If
    End Sub

    Private Sub Txt_Pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pago.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class