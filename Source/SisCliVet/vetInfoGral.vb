Imports System.IO
Public Class vetInfoGral
    Dim connection As New cConexion
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombre.Text = "" And picLogo.Image Is Nothing Then
            MessageBox.Show("Debe introducir al menos un nombre y el logo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim nombre As String = txtNombre.Text.Trim
            Dim ambito As String = txtAmbito.Text.Trim
            Dim telefono As String = txtTelefono.Text.Trim
            Dim direccion As String = txtDireccion.Text.Trim
            Dim logo As New MemoryStream
            picLogo.BackgroundImage.Save(logo, picLogo.BackgroundImage.RawFormat)
            Dim imagen As Byte() = logo.GetBuffer


        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    Private Sub btnCargarLogo_Click(sender As Object, e As EventArgs) Handles btnCargarLogo.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picLogo.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub
End Class