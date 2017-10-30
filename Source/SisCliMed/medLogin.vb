Public Class medLogin
    Dim con As New cConexion

    Private Sub recordar()
        If Not chkRecordar.Checked Then
            txtUsr.Clear()
            txtPasswd.Clear()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim datos As New DataTable
        Dim usuario As String = txtUsr.Text.Trim
        Dim passwd As String = txtPasswd.Text.Trim
        Dim condicion As String = "username ='" & usuario & "' AND passwd='" & passwd & "'"

        If usuario.Length = 0 Then
            MessageBox.Show("Debe de Ingresar un nombre usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf passwd.Length = 0 Then
            MessageBox.Show("Debe de Ingresar la contraseña del usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        datos = con.validarDatos("*", "Usuario", condicion)

        If datos.Rows.Count > 0 Then
            If usuario = datos.Rows(0).Item(0) And passwd = datos.Rows(0).Item(1) Then
                If datos.Rows(0).Item(4) = 1 Then
                    cGenerica.mUser = 1
                    cGenerica.uErr = 0
                    recordar()
                    Me.Close()
                ElseIf datos.Rows(0).Item(4) = 2 Then
                    cGenerica.mUser = 2
                    cGenerica.uErr = 0
                    recordar()
                    Me.Close()

                End If
                medPRINCIPAL.stUsuario.Text = "Hola, " & datos.Rows(0).Item(2) & " " & datos.Rows(0).Item(3)
                cGenerica.usr = usuario
            End If
        Else
            MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cGenerica.mUser = 0
            cGenerica.uErr = 1
            txtPasswd.Clear()
            txtUsr.Clear()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        cGenerica.uExit = 1
    End Sub
End Class