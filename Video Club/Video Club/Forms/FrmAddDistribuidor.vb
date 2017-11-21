Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class FrmAddDistribuidor
    Dim cnx2 As New MySqlConnection("server=localhost; user=root; password='arturo1996'; database=videoclub;")
    Dim cambio As Boolean
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Minimizar1_Click(sender As Object, e As EventArgs) Handles Minimizar1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Txt_NombreDistribuidor.Text = "" Then
            MessageBox.Show(" captura el nombre del distribuidor")
        ElseIf Txt_Encargado.Text = "" Then
            MessageBox.Show("captura el encargado")
        ElseIf RichTxt_Direccion.Text = "" Then
            MessageBox.Show("captura la direccion")
        ElseIf Txt_Telefono.Text = "" Then
            MessageBox.Show("capturar el telefono")
        ElseIf Txt_Celular.Text = "" Then
            MessageBox.Show("capturar el numero de celular ")
        ElseIf Txt_Correo.Text = "" Then
            MessageBox.Show("captura el correo del distribuidor")
        End If

        Dim distri As New Distribuidor
        If distri.consultaUnDistribuidor() = False And cambio = False Then

            distri.insertaDis()


        Else

            distri.getSetNombreD = Txt_NombreDistribuidor.Text
            distri.getSetEncargado = Txt_Encargado.Text
            distri.getSetDireccion = RichTxt_Direccion.Text
            distri.getSetTelefono = Txt_Telefono.Text
            distri.getSetCelular = Txt_Celular.Text
            distri.getSetCorreo = Txt_Correo.Text
            'Si la carrera se encuentra registrada, se modifica la información
            distri.actualizaDist() 'ACTUALIZA LA CARRERA
        End If
        distri.PoblarDataGridDistr(DGVdistri)
        cambio = False




        'Limpiamos el contenido de las cajas de texto 
        Txt_ID.Text = ""
        Txt_NombreDistribuidor.Text = ""
        Txt_Encargado.Text = ""
        RichTxt_Direccion.Text = ""
        Txt_Telefono.Text = vbNullString
        Txt_Celular.Text = vbNullString
        Txt_Correo.Text = ""


        'Ponemos el cursor en la caja de textos TxtClaveCarrera
        Txt_NombreDistribuidor.Focus()


    End Sub

    Private Sub FrmAddDistribuidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim distri As New Distribuidor
        distri.PoblarDataGridDistr(DGVdistri)
        'cnx.Close()

        'HACER EL REPORTE DE DISTRIBUIDOR
        cnx2.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM distribuidor", cnx2)
        Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
        Dim bs As New BindingSource

        bs.DataSource = drd
        DGVdistri.DataSource = bs
        drd.Close()
        cnx2.Close()
    End Sub

    Public Function getColumnasSize(ByVal dg As DataGridView) As Single()
        'Funcion para obtener el tamaño de las culumnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable cone l numero de columnas del datagridview
        Dim datatable As New PdfPTable(DGVdistri.ColumnCount)
        'Se le asignan algunas propiedades para el diseño del PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = getColumnasSize(DGVdistri)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("Reporte de DISTRIBUIDORES", New Font(Font.Name = "Century Gothic", 18, Font.Bold))

        'Se crea el texto debajo del encabezado
        Dim texto As New Phrase("Realizado: " + Now.Date(), New Font(Font.Name = "Century Gothic", 12, Font.Bold))
        'Se capturan los nombres de las columnas del datagridview
        For i As Integer = 0 To DGVdistri.ColumnCount - 1
            datatable.AddCell(DGVdistri.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DATAGRIDVIEW
        For i As Integer = 0 To DGVdistri.RowCount - 1
            For j As Integer = 0 To DGVdistri.ColumnCount - 1
                datatable.AddCell(DGVdistri(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al docuemnto
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub


    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Try
            'Intentar generar el documento
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows(Desktop)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Distribuidores a&c.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox
            MessageBox.Show("No se puede generar el documento PDF", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVdistri_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdistri.CellContentClick
        Dim renglon As Integer
        cambio = True

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVdistri.CurrentCellAddress.Y
        Txt_ID.Text = DGVdistri.Rows(renglon).Cells(0).Value
        Txt_NombreDistribuidor.Text = DGVdistri.Rows(renglon).Cells(1).Value
        Txt_Encargado.Text = DGVdistri.Rows(renglon).Cells(2).Value
        RichTxt_Direccion.Text = DGVdistri.Rows(renglon).Cells(3).Value
        Txt_Telefono.Text = DGVdistri.Rows(renglon).Cells(4).Value
        Txt_Celular.Text = DGVdistri.Rows(renglon).Cells(5).Value
        Txt_Correo.Text = DGVdistri.Rows(renglon).Cells(6).Value
    End Sub

    Private Sub RichTxt_Direccion_Click(sender As Object, e As EventArgs) Handles RichTxt_Direccion.Click
        Text = ""
    End Sub


    'Hacer el reporte de distribuidor


End Class