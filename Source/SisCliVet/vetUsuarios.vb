Public Class vetUsuarios
    Dim connection As New cConexion
    Dim tabla As String = "Usuario"
    Dim fila As String
    Dim user As String
    Dim contra As String
    Dim nombre As String
    Dim titulo As String
    Dim rol As String
    Dim campos As String = "Usuario.username AS 'Usuario', Usuario.passwd AS 'Contraseña', Usuario.nombre AS 'Nombre real del usuario'," &
        "Rol.nombre AS 'Rol/Funcion'"
    Dim join As String = "INNER JOIN Rol ON Rol.idRol = Usuario.idRol "
    Sub LimpiarDatos()
        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is Windows.Forms.TextBox Then
                control.Text = ""
            End If
        Next

        rdbDr.Checked = True
        rdbDra.Checked = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim campos As String = "(username,passwd,nombre,idRol)"
            Dim valores As String
            Dim condicion As String
            user = txtUsername.Text.Trim
            contra = txtPasswd.Text.Trim
            nombre = txtNombre.Text.Trim
            rol = cmbRol.SelectedValue
            If rdbDr.Checked Then
                titulo = "Dr."
            ElseIf rdbDra.Checked Then
                titulo = "Dra."
            End If
            valores = "'" & user & "','" & contra & "','" & titulo & " " & nombre & "','" & rol & "'"
            condicion = "username ='" & user & "'"

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

            If txtUsername.TextLength > 10 And txtUsername.TextLength < 1 Then
                MessageBox.Show("El usuario debe ser de 10 caracteres maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtPasswd.TextLength > 15 And txtPasswd.TextLength < 1 Then
                MessageBox.Show("La contraseña debe ser de 15 caracteres maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else

                If connection.consultaExistente(tabla, condicion) > 0 Then
                    MessageBox.Show("Nombre de usuario ya existe, intente con otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If connection.InsertarFila(tabla, campos, valores) > 0 Then
                        MessageBox.Show("Usuario ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim condicion2 As String
                        condicion2 = "WHERE username LIKE '" & txtBusqueda.Text & "'"
                        dgvUsuarios.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion2)
                        dgvUsuarios.Refresh()
                        LimpiarDatos()
                    Else
                        MessageBox.Show("Error no se pudieron ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub vetUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim condicion As String
        condicion = "WHERE username LIKE '" & txtBusqueda.Text & "%'"
        dgvUsuarios.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvUsuarios.Refresh()
        cmbRol.DataSource = connection.consultaGeneral("Rol")
        cmbRol.ValueMember = "idRol"
        cmbRol.DisplayMember = "nombre"
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            If txtUsername.Text = "" Or txtPasswd.Text = "" Or txtNombre.Text = "" Or cmbRol.SelectedIndex = -1 Then
                MessageBox.Show("Faltan datos a ingresar, revisar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtUsername.TextLength > 10 And txtUsername.TextLength < 1 Then
                MessageBox.Show("El usuario debe ser de 10 caracteres maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtPasswd.TextLength > 15 And txtPasswd.TextLength < 1 Then
                MessageBox.Show("La contraseña debe ser de 15 caracteres maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim respuesta As Integer
                Dim condicion As String
                Dim campos As String = "username,passwd,nombre,idRol"
                Dim valores As String
                user = txtUsername.Text.Trim
                contra = txtPasswd.Text.Trim
                nombre = txtNombre.Text.Trim
                rol = cmbRol.SelectedValue
                If rdbDr.Checked Then
                    titulo = "Dr."
                ElseIf rdbDra.Checked Then
                    titulo = "Dra."
                End If
                valores = "username = '" & user & "', passwd = '" & contra & "', nombre ='" &
                    titulo & " " & nombre & "', idRol ='" & rol & "'"

                condicion = "username = '" & user & "'"

                respuesta = MessageBox.Show("Desea modificar los datos del usuario: " & fila & " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = 6 Then
                    If connection.actualizar(tabla, valores, condicion) > 0 Then
                        MessageBox.Show("Usuario actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim condicion2 As String
                        condicion2 = "WHERE username LIKE '" & txtBusqueda.Text & "%'"
                        dgvUsuarios.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion2)
                        dgvUsuarios.Refresh()
                        txtUsername.Enabled = True
                        btnModificar.Enabled = False
                        btnEliminar.Enabled = False
                        btnGuardar.Enabled = True
                        LimpiarDatos()
                    Else
                        MessageBox.Show("Error no se pudieron actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error en el programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarDatos()
        txtBusqueda.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer
        Dim condicion As String = "username = '" & fila & "'"
        respuesta = MessageBox.Show("Desea eliminar el usuario: " & fila & " ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = 6 Then
            If connection.eliminar(tabla, condicion) > 0 Then
                MessageBox.Show("Usuario con sus datos eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim condicion2 As String
                condicion2 = "WHERE username LIKE '" & txtBusqueda.Text & "%'"
                dgvUsuarios.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion2)
                dgvUsuarios.Refresh()
                txtUsername.Enabled = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnGuardar.Enabled = True
                LimpiarDatos()
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        txtUsername.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGuardar.Enabled = True

        LimpiarDatos()
        
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim condicion As String
        condicion = "WHERE username LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvUsuarios.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvUsuarios.Refresh()

    End Sub


    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick

        txtUsername.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGuardar.Enabled = False

        For Each celda As DataGridViewRow In dgvUsuarios.SelectedRows
            fila = celda.Cells(0).Value.ToString
            txtUsername.Text = celda.Cells(0).Value.ToString
            txtPasswd.Text = celda.Cells(1).Value.ToString
            txtNombre.Text = celda.Cells(2).Value.ToString
            cmbRol.SelectedItem = celda.Cells(3).Value.ToString
        Next

    End Sub
End Class