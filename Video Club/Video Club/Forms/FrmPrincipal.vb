﻿Imports MySql.Data.MySqlClient

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

    'VERIFICAR SOCIO
    Private Sub Btn_BusquedaSocio_Click(sender As Object, e As EventArgs) Handles Btn_BusquedaSocio.Click


        Dim strSQL As String
        Dim lista As Byte
        Dim cnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM socio WHERE id='" & Txt_idSocio.Text & "'"
        xDT = cnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            lista = xDT.Rows.Count

        End If

        If lista <> 0 Then
            Txt_NombreSocio.Text = xDT.Rows(0)("nombre")
            Txt_ApPaternoSocio.Text = xDT.Rows(0)("apPaterno")
            Txt_ApMaternoSocio.Text = xDT.Rows(0)("apMaterno")
        Else
            Txt_idSocio.Text = ""
            Txt_NombreSocio.Text = ""
            Txt_ApPaternoSocio.Text = ""
            Txt_ApMaternoSocio.Text = ""
            MsgBox("El idSocio no es válido. ¡Ingresalo Correctamente!")
        End If
        cnx.cerrar()


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
        Next

        Panel_Renta.Visible = False

    End Sub

    Private Sub Btn_Busca_Click(sender As Object, e As EventArgs) Handles Btn_Busca.Click
        DGVrenta.DataSource = consultarPeliculaNombre()
    End Sub

    Private Sub Btn_Devoluciones_Click(sender As Object, e As EventArgs) Handles Btn_Devoluciones.Click

        FrmDevolucionVenta.Show()
        Me.Close()
    End Sub

    Private Sub LV_Importe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_Importe.SelectedIndexChanged

    End Sub


End Class