Public Class medUsuarios
    Dim con As New cConexion
    Dim tabla As String = "Usuario"
    Dim usuario As String, user As String, contra As String, nombre As String, titulo As String, rol As String
    Dim campos As String = "Usuario.username AS 'Usuario', Usuario.passwd AS 'Contraseña', Usuario.titulo AS 'Titulo', Usuario.nombre AS 'Nombre Real', Rol.nombre AS 'Rol/Funcion'"
    Dim join As String = "INNER JOIN Rol ON Usuario.idRol = Rol.idRol"

    Private Sub limpiarDatos()
        cGenerica.limpiarTextbox(GroupBox1)
        rdbDr.Checked = False
        rdbDra.Checked = False
    End Sub

    Private Sub refrescar()
        limpiarDatos()
        dgvUsuarios.DataSource = con.consultaCondicionada(campos, tabla, join)
        dgvUsuarios.Refresh()
        cmbRol.DataSource = con.consultaGeneral("Rol")
        cmbRol.ValueMember = "idRol"
        cmbRol.DisplayMember = "nombre"
    End Sub

    Private Sub medUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            user = txtUsername.Text.Trim
            contra = txtPasswd.Text.Trim
            nombre = LTrim(txtNombre.Text)
            rol = cmbRol.SelectedValue

            If rdbDr.Checked Then
                titulo = "Dr."
            ElseIf rdbDra.Checked Then
                titulo = "Dra."
            End If

            Dim valores As String = "'" & user & "','" & contra & "','" & titulo & "','" & nombre & "','" & rol & "'"
            Dim condicion As String = " username ='" & user & "'"

            If user.Length = 0 Then
                MessageBox.Show("No ha ingresado nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf contra.Length = 0 Then
                MessageBox.Show("No ha ingresado contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf nombre.Length = 0 Then
                MessageBox.Show("No ha ingresado su nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf titulo.Length = 0 Then
                MessageBox.Show("No ha ingresado su titulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtUsername.TextLength < 5 Then
                MessageBox.Show("El usuario debe ser de al menos 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf txtPasswd.TextLength < 6 Then
                MessageBox.Show("La contraseña debe ser de al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If con.consultaExistente(tabla, condicion) > 0 Then
                    MessageBox.Show("Nombre de usuario ya existe, intente con otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If con.insertar(tabla, valores) > 0 Then
                        MessageBox.Show("Usuario ingresado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        refrescar()
                    Else
                        MessageBox.Show("Error no se pudieron ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtUsername.Text = "" Or txtPasswd.Text = "" Or txtNombre.Text = "" Or cmbRol.SelectedIndex = -1 Then
                MessageBox.Show("Faltan datos a ingresar, revisar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtUsername.TextLength < 5 Then
                MessageBox.Show("El usuario debe ser de al menos 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf txtPasswd.TextLength < 6 Then
                MessageBox.Show("La contraseña debe ser de al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim campos As String = "username,passwd,nombre,idRol"
                user = txtUsername.Text.Trim
                contra = txtPasswd.Text.Trim
                nombre = txtNombre.Text.Trim
                rol = cmbRol.SelectedValue
                If rdbDr.Checked Then
                    titulo = "Dr."
                ElseIf rdbDra.Checked Then
                    titulo = "Dra."
                End If
                Dim valores As String = "username = '" & user & "', passwd = '" & contra & "', titulo ='" &
                    titulo & "', nombre ='" & nombre & "', idRol ='" & rol & "'"

                Dim condicion As String = "username = '" & user & "'"

                Dim respuesta As Integer = MessageBox.Show("Desea modificar los datos del usuario: " & usuario & " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = 6 Then
                    If con.actualizar(tabla, valores, condicion) > 0 Then
                        MessageBox.Show("Usuario actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsername.Enabled = True
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = False
                        btnGuardar.Enabled = True
                        refrescar()
                    Else
                        MessageBox.Show("Error no se pudieron actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error en el programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim condicion As String = "username = '" & usuario & "'"
        Dim respuesta As Integer = MessageBox.Show("Desea eliminar el usuario: " & usuario & " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = 6 Then
            If con.eliminar(tabla, condicion) > 0 Then
                MessageBox.Show("Usuario con sus datos eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsername.Enabled = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnGuardar.Enabled = True
                refrescar()
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtUsername.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = True
        refrescar()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim condicion As String = "WHERE username LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvUsuarios.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvUsuarios.Refresh()
    End Sub


    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        txtUsername.Enabled = False
        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        For Each celda As DataGridViewRow In dgvUsuarios.SelectedRows
            usuario = celda.Cells(0).Value.ToString
            txtUsername.Text = celda.Cells(0).Value.ToString
            txtPasswd.Text = celda.Cells(1).Value.ToString
            If celda.Cells(2).Value.ToString = "Dr." Then
                rdbDr.Checked = True
            ElseIf celda.Cells(2).Value.ToString = "Dra." Then
                rdbDra.Checked = True
            End If
            txtNombre.Text = celda.Cells(3).Value.ToString
            cmbRol.SelectedValue = con.consultaExistente("idRol", "Rol", "nombre = '" & celda.Cells(4).Value.ToString & "'")
            If cGenerica.usr <> celda.Cells(0).Value.ToString Then
                btnEliminar.Enabled = True
            Else
                btnEliminar.Enabled = False
            End If
        Next
    End Sub

    'Ocultar contraseña en DataGridView
    Private Sub dgvUsuarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsuarios.CellFormatting
        If (e.ColumnIndex = 1 And e.Value <> Nothing) Then
            e.Value = New String("*", e.Value.ToString().Length)
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        cGenerica.SoloTexto(txtNombre, e)
    End Sub
End Class