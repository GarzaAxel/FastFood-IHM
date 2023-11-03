Public Class frmCategoria
    Private Sub btnPromociones_Click(sender As Object, e As EventArgs) Handles btnPromociones.Click
        Promociones.Show()
    End Sub

    Private Sub btnPostres_Click(sender As Object, e As EventArgs) Handles btnPostres.Click
        Postres.Show()
    End Sub

    Private Sub btnComida_Click(sender As Object, e As EventArgs) Handles btnComida.Click
        Comida.Show()
    End Sub

    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        Carrito.Show()
    End Sub

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        Bebidas.Show()
    End Sub

    Private Sub btnReservaciones_Click(sender As Object, e As EventArgs) Handles btnReservaciones.Click
        Reservaciones.Show()
    End Sub

    Private Sub ContactoCbtn_Click(sender As Object, e As EventArgs) Handles ContactoCbtn.Click
        Contacto.Show()
    End Sub
End Class