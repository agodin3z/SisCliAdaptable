Imports System.IO
Public Class medInfoGral

    Dim con As New cConexion
    Dim nomAnterior As String = ""

    Private Sub medInfoGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.consultaExistente("InfoClinica", "nombre LIKE '%" & txtNombre.Text & "%'") > 0 Then
            Dim dt As DataTable = con.consultaGeneral("InfoClinica")
            txtNombre.Text = dt.Rows(0)("nombre").ToString
            txtAmbito.Text = dt.Rows(0)("ambito").ToString
            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            txtTelefono.Text = dt.Rows(0)("telefono").ToString
            If con.consultaExistente("logo", "InfoClinica", "nombre LIKE '%" & txtNombre.Text & "%'").ToString.Length > 0 Then
                Dim ms As New MemoryStream(con.selectImg("InfoClinica", "TOP 1 logo", ""))
                picLogo.BackgroundImage = Image.FromStream(ms)
            End If
            nomAnterior = txtNombre.Text.Trim
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombre.Text = "" And picLogo.BackgroundImage Is Nothing Then
            MessageBox.Show("Debe introducir al menos un nombre y el logo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim nombre As String = txtNombre.Text.Trim
            Dim ambito As String = txtAmbito.Text.Trim
            Dim telefono As String = txtTelefono.Text.Trim
            Dim direccion As String = txtDireccion.Text.Trim

            Dim logo As New MemoryStream
            picLogo.BackgroundImage.Save(logo, picLogo.BackgroundImage.RawFormat)

            Dim imagen As Byte() = logo.GetBuffer
            Dim valores As String = "'" & nombre & "','" & ambito & "','" & telefono & "','" & direccion & "',''"
            Dim nValores As String = "nombre='" & nombre & "', ambito='" & ambito & "', telefono='" & telefono & "', direccion='" & direccion & "'"

            If con.consultaExistente("InfoClinica", "nombre='" & nomAnterior & "'") = 0 Then
                If con.insertar("InfoClinica", valores) > 0 Then
                    con.actualizar("InfoClinica", "logo", "nombre", nombre, imagen)
                    MessageBox.Show("Datos Actualizados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If con.actualizar("InfoClinica", nValores, "nombre='" & nomAnterior & "'") > 0 Then
                    con.actualizar("InfoClinica", "logo", "nombre", nombre, imagen)
                    MessageBox.Show("Datos Actualizados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub

    Private Sub btnCargarLogo_Click(sender As Object, e As EventArgs) Handles btnCargarLogo.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picLogo.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        cGenerica.Telefono(txtTelefono, e)
    End Sub
End Class