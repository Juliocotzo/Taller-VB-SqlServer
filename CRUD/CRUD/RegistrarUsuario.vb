Imports System.Data.SqlClient

Public Class RegistrarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-6FU2AFU;Initial Catalog=Prueba;Integrated Security=True")

        Try
            Dim command As New SqlCommand("INSERT INTO USUARIO (nombre,apellido,edad,direccion,telefono) VALUES(@nombre,@apellido,@edad,@direccion,@telefono)", connection)
            command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@apellido", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@edad", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text)
            command.Parameters.Add("@direccion", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@telefono", SqlDbType.VarChar).Value = TextBox6.Text
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Nuevo Usuario Registrado")
            Else
                MessageBox.Show("No se pudo agregar al usuario")
            End If
            connection.Close()
            Recargar()
        Catch ex As Exception
            MsgBox("REVISE LOS DATOS")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-6FU2AFU;Initial Catalog=Prueba;Integrated Security=True")

        Try
            Dim command As New SqlCommand("UPDATE USUARIO SET nombre = @nombre, apellido = @apellido,edad = @edad, direccion = @direccion, telefono = @telefono WHERE id = @id", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text)
            command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@apellido", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@edad", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text)
            command.Parameters.Add("@direccion", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@telefono", SqlDbType.VarChar).Value = TextBox6.Text
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Usuario Actualizado")
            Else
                MessageBox.Show("No se pudo actuzalizar al usuario")
            End If
            connection.Close()
            Recargar()
        Catch ex As Exception
            MsgBox("REVISE LOS DATOS")

        End Try
    End Sub

    Private Sub RegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Data Source=DESKTOP-6FU2AFU;Initial Catalog=Prueba;Integrated Security=True")


        Try
            Dim command As New SqlCommand("SELECT * FROM USUARIO", connection)
            Dim dataAdapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "USUARIO")
            Me.DataGridView1.DataSource = dataSet.Tables("USUARIO")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-6FU2AFU;Initial Catalog=Prueba;Integrated Security=True")

        Try
            Dim command As New SqlCommand("DELETE FROM USUARIO WHERE id = @id", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text)
            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Usuario Eliminado")
            Else
                MessageBox.Show("No se pudo eliminar al usuario")
            End If
            connection.Close()
            Recargar()
        Catch ex As Exception
            MsgBox("REVISE LOS DATOS")

        End Try
    End Sub


    Private Sub Recargar()
        Dim connection As New SqlConnection("Data Source=DESKTOP-6FU2AFU;Initial Catalog=Prueba;Integrated Security=True")


        Try
            Dim command As New SqlCommand("SELECT * FROM USUARIO", connection)
            Dim dataAdapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "USUARIO")
            Me.DataGridView1.DataSource = dataSet.Tables("USUARIO")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class