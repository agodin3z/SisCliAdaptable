Public Class medLogin
    Private Sub recordar()
        If Not chkRecordar.Checked Then
            txtUsr.Clear()
            txtPasswd.Clear()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Sistema Temporal de Login
        If txtUsr.Text = "admin" Then
            cGenerica.mUser = 1
            cGenerica.uErr = 0
            recordar()
            Me.Close()
        ElseIf txtUsr.Text = "medico" Then
            cGenerica.mUser = 2
            cGenerica.uErr = 0
            recordar()
            Me.Close()
        Else
            MessageBox.Show("Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cGenerica.mUser = 0
            cGenerica.uErr = 1
        End If
        'FIN Sistema Temporal de Login
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        cGenerica.uExit = 1
    End Sub
End Class