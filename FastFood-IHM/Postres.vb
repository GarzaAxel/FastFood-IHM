Imports System.Data.SqlClient

Public Class Postres
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Postres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=DESKTOP-R538THL;database=Restaurant;integrated security=true")
    End Sub

    Private Sub btnPastelFresa_Click(sender As Object, e As EventArgs) Handles btnPastelFresa.Click
        cn.Open()

        Dim query As String = "select * from Productos where Descripcion= 'Pastel Fresa' "
        cmd = New SqlCommand(query, cn)

        Dim lec As SqlDataReader
        lec = cmd.ExecuteReader

        If lec.HasRows Then

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            dt = frmCarrito.dgvProductos.DataSource

        Else
            MessageBox.Show("Este producto no existe.")
        End If



    End Sub

    Private Sub btnVerCarritoPostres_Click(sender As Object, e As EventArgs) Handles btnVerCarritoPostres.Click
        frmCarrito.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmCategoria.Show()
        frmCarrito.Hide()
    End Sub
End Class