Imports System.Data.SqlClient
Public Class frmAcceso
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=DESKTOP-R538THL;database=Restaurant;integrated security=true")
    End Sub

    Private Sub IngresarAbtn_Click(sender As Object, e As EventArgs) Handles IngresarAbtn.Click
        cn.Open()

        Dim query As String = "select * from Usuario where Nombre_Usuario= '" & UsuarioAtxt.Text & "'  and Contraseña= '" & ContraAtxt.Text & "'"
        cmd = New SqlCommand(query, cn)

        Dim lec As SqlDataReader
        lec = cmd.ExecuteReader

        If lec.HasRows Then
            frmCategoria.Show()
            Me.Close()
        Else
            MessageBox.Show("Este usuario no existe o los datos son incorrectos.")
        End If
        cn.Close()
    End Sub

    Private Sub RegistrarAbtn_Click(sender As Object, e As EventArgs) Handles RegistrarAbtn.Click
        frmRegistro.Show()

    End Sub
End Class
