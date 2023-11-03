Imports System.Data.SqlClient

Public Class frmRegistro
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=DESKTOP-R538THL;database=Restaurant;integrated security=true")

    End Sub
    Private Sub RegistrarRBtn_Click(sender As Object, e As EventArgs) Handles RegistrarRBtn.Click
        Dim _ID, _Usuario, _Contra As String

        _ID = CrearID()
        _Usuario = UsuarioRtxt.Text
        _Contra = ContraseñaRtxt.Text
        Try
            cn.Open()
            Dim query As String = "INSERT INTO Usuario (Id_Usuario, Nombre_Usuario, Contraseña) VALUES (@Id_Usuario, @Nombre_Usuario, @Contraseña)"
            Dim cmd As New SqlCommand(query, cn)

            cmd.Parameters.AddWithValue("@Id_Usuario", _ID)
            cmd.Parameters.AddWithValue("@Nombre_Usuario", _Usuario)
            cmd.Parameters.AddWithValue("@Contraseña", _Contra)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente registrado con éxito.")
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cliente: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Public Function CrearID()
        Dim username As String = UsuarioRtxt.Text
        Dim random As New Random()

        ' Obtén los primeros tres caracteres del nombre de usuario (asegúrate de que el nombre de usuario tenga al menos 4 caracteres).
        Dim shortUsername As String = username.Substring(0, Math.Min(3, username.Length))

        ' Genera un número aleatorio de 1 dígito.
        Dim randomNumber As Integer = random.Next(0, 99)

        ' Combina los primeros cuatro caracteres del nombre de usuario y el número aleatorio.
        Dim uniqueID As String = $"{shortUsername}_{randomNumber}"

        Return uniqueID
    End Function

    Private Sub RegresarRBtn_Click(sender As Object, e As EventArgs) Handles RegresarRBtn.Click
        Me.Close()
    End Sub
End Class