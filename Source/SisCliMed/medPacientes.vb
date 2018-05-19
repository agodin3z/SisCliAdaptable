Public Class medPacientes
    Dim con As New cConexion
    Dim tabla As String = "Paciente", condicion As String
    Dim pNombre As String, sNombre As String, pApellido As String, sApellido As String, fechaNac As String
    Dim dui As String, estado As String, genero As String = "", direccion As String, telFijo As String, antecedentes As String
    Dim telMovil As String, hora As String, fecha As String, codigo As String, priNomApe As String, valores As String

    Private Sub limpiar()
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox4)
        cGenerica.limpiarTextbox(GroupBox5)
        cmbGenero.SelectedIndex = 0
        TabPage1.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        TabPage2.Parent = Nothing
    End Sub

    Private Sub medPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHora.Text = Now.ToString("HH:mm:ss")
        txtFecha.Text = Today.ToString("MM-dd-yyyy")
        cmbGenero.SelectedIndex = 0
        TabPage2.Parent = Nothing
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            pNombre = txtPriNombre.Text.Trim
            sNombre = txtSegNombre.Text.Trim
            pApellido = txtPriApellido.Text.Trim
            sApellido = txtSegApellido.Text.Trim
            dui = txtDui.Text.Trim
            genero = cmbGenero.SelectedItem.ToString()
            estado = txtEstadoCivil.Text.Trim
            direccion = txtDireccion.Text.Trim
            telFijo = txtTelFijo.Text.Trim
            telMovil = txtTelMovil.Text.Trim
            fechaNac = dtpFechaNac.Value.ToString("yyyy-MM-dd")
            hora = Date.Now.ToString("HH:mm:ss")
            fecha = Date.Now.ToString("yyyy-MM-dd")

            If pNombre.Length = 0 Then
                MessageBox.Show("Ingrese el primer nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf pApellido.Length = 0 Then
                MessageBox.Show("Ingrese el primer apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf genero.Length = 0 Then
                MessageBox.Show("Ingrese el genero del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dtpFechaNac.Value.ToString("MM-dd-yyyy") = Now.ToString("MM-dd-yyyy") Then
                MessageBox.Show("Ingrese la fecha de nacimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            priNomApe = Mid(pNombre, 1, 1).ToUpper + Mid(pApellido, 1, 1).ToUpper + Mid(fecha, 3, 2)
            condicion = "idPaciente LIKE '" & priNomApe & "%'"
            If con.correlativo("idPaciente", tabla, condicion) < 10 Then
                codigo = priNomApe & "00" & con.correlativo("idPaciente", tabla, condicion)
            ElseIf con.correlativo("idPropietario", tabla, condicion) < 100 Then
                codigo = priNomApe & "0" & con.correlativo("idPaciente", tabla, condicion)
            Else
                codigo = priNomApe & con.correlativo("idPaciente", tabla, condicion)
            End If
            txtCodPaciente.Text = codigo

            TabPage2.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            TabPage1.Parent = Nothing
            
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        antecedentes = txtAntecedentes.Text.Trim

        valores = "'" & codigo & "','" & pNombre & "','" & sNombre & "','" & pApellido & "','" &
            sApellido & "','" & dui & "','" & estado & "','" & genero & "','" & fechaNac & "','" &
            direccion & "','" & telFijo & "','" & telMovil & "','" & antecedentes & "','" & fecha & "','" & hora & "'"

        If con.insertar(tabla, valores) > 0 Then
            MessageBox.Show("Paciente ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If txtEmergencia1.Text.Trim.Length > 0 And txtTelEmergencia1.Text.Trim.Length > 0 Then
                con.insertar("NumEmergencia", "'" & codigo & "','" & txtEmergencia1.Text.Trim & "','" & txtTelEmergencia1.Text.Trim & "'")
            End If
            If txtEmergencia2.Text.Trim.Length > 0 And txtTelEmergencia2.Text.Trim.Length > 0 Then
                con.insertar("NumEmergencia", "'" & codigo & "','" & txtEmergencia2.Text.Trim & "','" & txtTelEmergencia2.Text.Trim & "'")
            End If
            limpiar()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea cancelar el registro del paciente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = 6 Then
            Me.Close()
        End If
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