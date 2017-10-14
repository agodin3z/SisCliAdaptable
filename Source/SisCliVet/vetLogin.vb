Public Class vetLogin

    Dim connection As New cConexion

    Private Sub recordar()
        If Not chkRecordar.Checked Then
            txtUsr.Clear()
            txtPasswd.Clear()
        End If
    End Sub

    Dim usuario As String
    Dim passwd As String
    Dim condicion As String
    Dim datos As New DataTable

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        usuario = txtUsr.Text.Trim
        passwd = txtPasswd.Text.Trim
        condicion = "username ='" & usuario & "' AND passwd='" & passwd & "'"

        If usuario.Length = 0 Then
            MessageBox.Show("Ingrese el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf passwd.Length = 0 Then
            MessageBox.Show("Ingrese la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        datos = connection.ValidarDatos("*", "Usuario", condicion)

        If datos.Rows.Count > 0 Then
            If usuario = datos.Rows(0).Item(0) And passwd = datos.Rows(0).Item(1) Then
                If datos.Rows(0).Item(3) = 1 Then
                    cGenerica.vUser = 1
                    cGenerica.uErr = 0
                    recordar()
                    Me.Close()
                    vetPRINCIPAL.stUsuario.Text = datos.Rows(0).Item(0)
                ElseIf datos.Rows(0).Item(3) = 2 Then
                    cGenerica.vUser = 2
                    cGenerica.uErr = 0
                    recordar()
                    Me.Close()
                    vetPRINCIPAL.stUsuario.Text = datos.Rows(0).Item(0)
                End If
            End If
        Else
            MessageBox.Show("Datos erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cGenerica.vUser = 0
            cGenerica.uErr = 1
            txtPasswd.Clear()
            txtUsr.Clear()
        End If

        'Sistema Temporal de Login
        'If txtUsr.Text = "admin" Then
        'cGenerica.vUser = 1
        'cGenerica.uErr = 0
        'recordar()
        'Me.Close()
        ' ElseIf txtUsr.Text = "medico" Then
        'cGenerica.vUser = 2
        'cGenerica.uErr = 0
        'recordar()
        'Me.Close()
        'Else
        'MessageBox.Show("Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'cGenerica.vUser = 0
        'cGenerica.uErr = 1
        'End If
        'FIN Sistema Temporal de Login
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        cGenerica.uExit = 1
    End Sub
End Class