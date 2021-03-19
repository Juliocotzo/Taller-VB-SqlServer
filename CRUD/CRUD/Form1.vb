Public Class Form1

    Dim registrarUsuario As New RegistrarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        registrarUsuario.Show()
    End Sub
End Class
