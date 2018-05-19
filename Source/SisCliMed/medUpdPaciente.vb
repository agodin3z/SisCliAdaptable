Public Class medUpdPaciente
    Dim con As New cConexion

    Private Sub cargar(ByVal condicion As String)
        Dim campos As String = "idPaciente AS 'Codigo del Paciente', (priNombre + ' ' + priApellido)  AS 'Nombre del Paciente'," &
                        "genero AS 'Genero', fechaNac AS 'Fecha de nacimiento'"
        dgvPacientes.DataSource = con.consultaCondicionada(campos, "Paciente", "", condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub limpiar()
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox5)
    End Sub

    Private Sub inicio()
        limpiar()
        cargar("")
        TabPage1.Parent = TabControl1
        TabPage2.Parent = Nothing
        TabPage3.Parent = Nothing
    End Sub

    Private Sub medUpdPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE priNombre LIKE '" & txtBusqueda.Text.Trim & "%' OR priApellido LIKE '" & txtBusqueda.Text.Trim & "%' OR idPaciente LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            TabPage2.Parent = Me.TabControl1
            TabPage3.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            TabPage1.Parent = Nothing

            'Tomando el dato de la fila seleccionada para llenar los otros tab
            Dim dt As DataTable = con.consultaCondicionada("Paciente", " idPaciente='" & dgvPacientes.SelectedRows().Item(0).Cells(0).Value & "'")

            txtPriNombre.Text = dt.Rows(0)("priNombre").ToString
            txtSegNombre.Text = dt.Rows(0)("segNombre").ToString
            txtPriApellido.Text = dt.Rows(0)("priApellido").ToString
            txtSegApellido.Text = dt.Rows(0)("segApellido").ToString
            txtDui.Text = dt.Rows(0)("dui").ToString
            txtEstadoCivil.Text = dt.Rows(0)("estadoCivil").ToString
            cmbGenero.SelectedItem = dt.Rows(0)("genero").ToString
            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            dtpFechaNac.Value = dt.Rows(0)("fechaNac").ToString
            txtTelFijo.Text = dt.Rows(0)("telFijo").ToString
            txtTelMovil.Text = dt.Rows(0)("telMovil").ToString
            txtCodPaciente.Text = dt.Rows(0)("idPaciente").ToString
            txtAntecedentes.Text = dt.Rows(0)("antecedentes").ToString

            Dim dt2 As DataTable = con.consultaCondicionada("NumEmergencia", " idPaciente='" & dgvPacientes.SelectedRows().Item(0).Cells(0).Value & "'")
            If dt2.Rows.Count > 0 Then
                txtEmergencia1.Text = dt2.Rows(0)("nomEmergencia").ToString
                txtTelEmergencia1.Text = dt2.Rows(0)("telEmergencia").ToString
                If dt2.Rows.Count > 1 Then
                    txtEmergencia2.Text = dt2.Rows(1)("nomEmergencia").ToString
                    txtTelEmergencia2.Text = dt2.Rows(1)("telEmergencia").ToString
                End If
            End If
        Else
            MessageBox.Show("Debe de seleccionar a un paciente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea cancelar la actualizacion de información del paciente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = 6 Then
            inicio()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtPriNombre.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese el primer nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf txtPriApellido.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese el primer apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf cmbGenero.SelectedItem.ToString.Length = 0 Then
                MessageBox.Show("Ingrese el genero del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dtpFechaNac.Value.ToString("MM-dd-yyyy") = Now.ToString("MM-dd-yyyy") Then
                MessageBox.Show("Ingrese la fecha de nacimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim valores As String = "priNombre='" & txtPriNombre.Text.Trim & "', segNombre='" & txtSegNombre.Text.Trim & "', " &
                                    "priApellido='" & txtPriApellido.Text.Trim & "', segApellido='" & txtSegApellido.Text.Trim & "', " &
                                    "dui='" & txtDui.Text.Trim & "', estadoCivil='" & txtEstadoCivil.Text.Trim & "', " &
                                    "genero='" & cmbGenero.SelectedItem & "', fechaNac='" & dtpFechaNac.Value.ToString("yyyy-MM-dd") & "', " &
                                    "direccion='" & txtDireccion.Text.Trim & "', telFijo='" & txtTelFijo.Text.Trim & "', " &
                                    "telMovil='" & txtTelMovil.Text.Trim & "', antecedentes='" & txtAntecedentes.Text.Trim & "'"


            If con.actualizar("Paciente", valores, "idPaciente='" & txtCodPaciente.Text & "'") > 0 Then
                'Actualización de Numeros de Emergencia
                Dim dt3 As DataTable = con.consultaCondicionada("NumEmergencia", " idPaciente='" & txtCodPaciente.Text & "'")
                'Si no tienen registro y se quiere registrar un numero
                If dt3.Rows.Count = 0 And txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 And txtEmergencia2.Text.Trim.Length = 0 And txtTelEmergencia2.Text.Trim.Length = 0 Then
                    con.insertar("NumEmergencia", "'" & txtCodPaciente.Text & "','" & txtEmergencia1.Text.Trim & "','" & txtTelEmergencia1.Text.Trim & "'")
                ElseIf dt3.Rows.Count = 0 And txtEmergencia1.Text.Trim.Length = 0 And txtTelEmergencia1.Text.Trim.Length = 0 And txtEmergencia2.Text.Trim.Length > 0 And txtTelEmergencia2.Text.Trim.Length > 0 Then
                    con.insertar("NumEmergencia", "'" & txtCodPaciente.Text & "','" & txtEmergencia2.Text.Trim & "','" & txtTelEmergencia2.Text.Trim & "'")
                    'Si no tienen registro y se quiere registrar dos numeros
                ElseIf dt3.Rows.Count = 0 And txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 And txtEmergencia2.Text.Trim.Length > 0 And txtTelEmergencia2.Text.Trim.Length > 0 Then
                    con.insertar("NumEmergencia", "'" & txtCodPaciente.Text & "','" & txtEmergencia1.Text.Trim & "','" & txtTelEmergencia1.Text.Trim & "'")
                    con.insertar("NumEmergencia", "'" & txtCodPaciente.Text & "','" & txtEmergencia2.Text.Trim & "','" & txtTelEmergencia2.Text.Trim & "'")
                    'Si tiene un registro y se quiere actualizar un numero
                ElseIf dt3.Rows.Count = 1 And txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 And txtEmergencia2.Text.Trim.Length = 0 And txtTelEmergencia2.Text.Trim.Length = 0 Then
                    Dim nVal As String = "nomEmergencia='" & txtEmergencia1.Text.Trim & "', telEmergencia='" & txtTelEmergencia1.Text.Trim & "'"
                    con.actualizar("NumEmergencia", nVal, "correlativo=" & dt3.Rows(0)("correlativo").ToString)
                    'Si tiene un registro y se quiere agregar dos numeros
                ElseIf dt3.Rows.Count = 1 And txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 And txtEmergencia2.Text.Trim.Length > 0 And txtTelEmergencia2.Text.Trim.Length > 0 Then
                    Dim nVal As String = "nomEmergencia='" & txtEmergencia1.Text.Trim & "', telEmergencia='" & txtTelEmergencia1.Text.Trim & "'"
                    con.actualizar("NumEmergencia", nVal, "correlativo=" & dt3.Rows(0)("correlativo").ToString)
                    con.insertar("NumEmergencia", "'" & txtCodPaciente.Text & "','" & txtEmergencia2.Text.Trim & "','" & txtTelEmergencia2.Text.Trim & "'")
                    'Si se tienen dos registro y se quiere actualizar dos numeros
                ElseIf dt3.Rows.Count = 2 And txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 And txtEmergencia2.Text.Trim.Length > 0 And txtTelEmergencia2.Text.Trim.Length > 0 Then
                    Dim nVal As String = "nomEmergencia='" & txtEmergencia1.Text.Trim & "', telEmergencia='" & txtTelEmergencia1.Text.Trim & "'"
                    con.actualizar("NumEmergencia", nVal, "correlativo=" & dt3.Rows(0)("correlativo").ToString)
                    Dim nVal2 As String = "nomEmergencia='" & txtEmergencia2.Text.Trim & "', telEmergencia='" & txtTelEmergencia2.Text.Trim & "'"
                    con.actualizar("NumEmergencia", nVal2, "correlativo=" & dt3.Rows(1)("correlativo").ToString)
                End If
                MessageBox.Show("Datos del paciente actualizados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                inicio()
            Else
                MessageBox.Show("Error al actualizar datos del paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Validaciones
    Private Sub txtPriNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriNombre.KeyPress
        cGenerica.SoloTexto(txtPriNombre, e)
    End Sub
    Private Sub txtSegNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegNombre.KeyPress
        cGenerica.SoloTexto(txtSegNombre, e)
    End Sub
    Private Sub txtPriApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriApellido.KeyPress
        cGenerica.SoloTexto(txtPriApellido, e)
    End Sub
    Private Sub txtSegApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegApellido.KeyPress
        cGenerica.SoloTexto(txtSegApellido, e)
    End Sub
    Private Sub txtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelFijo.KeyPress
        cGenerica.Telefono(txtTelFijo, e)
    End Sub
    Private Sub txtTelMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelMovil.KeyPress
        cGenerica.Telefono(txtTelMovil, e)
    End Sub
    Private Sub txtDui_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDui.KeyPress
        cGenerica.SoloNumeros(txtDui, e)
    End Sub
    Private Sub txtEstadoCivil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoCivil.KeyPress
        cGenerica.SoloTexto(txtEstadoCivil, e)
    End Sub
    Private Sub txtAntecedentes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAntecedentes.KeyPress
        cGenerica.SoloTexto(txtAntecedentes, e)
    End Sub
    Private Sub txtEmergencia1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmergencia1.KeyPress
        cGenerica.SoloTexto(txtEmergencia1, e)
    End Sub
    Private Sub txtEmergencia2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmergencia2.KeyPress
        cGenerica.SoloTexto(txtEmergencia2, e)
    End Sub
    Private Sub txtTelEmergencia1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelEmergencia1.KeyPress
        cGenerica.Telefono(txtTelEmergencia1, e)
    End Sub
    Private Sub txtTelEmergencia2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelEmergencia2.KeyPress
        cGenerica.Telefono(txtTelEmergencia2, e)
    End Sub
End Class