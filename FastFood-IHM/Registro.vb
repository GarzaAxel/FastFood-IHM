Imports System.Data.SqlClient

Public Class frmRegistro
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=DESKTOP-R538THL;database=Restaurant;integrated security=true")

    End Sub
    Private Sub RegistrarRBtn_Click(sender As Object, e As EventArgs) Handles RegistrarRBtn.Click
        Dim _Usuario, _Contra As String
        _Usuario = UsuarioRtxt.Text
        _Contra = ContraseñaRtxt.Text
        Try
            cn.Open()
            Dim query As String = "INSERT INTO Usuario (Id_Usuario, Nombre_Usuario, Contraseña) VALUES (@Id_Usuario, @Nombre_Usuario, @Contraseña)"
            Dim cmd As New SqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@Apellido", Apellido)
            cmd.Parameters.AddWithValue("@Direccion", Direccion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente registrado con éxito.")
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cliente: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class