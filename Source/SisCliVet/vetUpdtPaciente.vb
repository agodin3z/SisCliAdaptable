Public Class vetUpdtPaciente
    Dim con As New cConexion
    Dim strImg As String
    Dim foto As Integer, boton As Integer

    Private Sub limpiar()
        foto = 0
        boton = 0
        cGenerica.limpiarTextbox(GroupBox1)
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox5)
        rdbFemenino.Checked = False
        rdbHembra.Checked = False
        rdbMacho.Checked = False
        rdbMasculino.Checked = False
        For i = 0 To lstVacunas.Items.Count - 1
            lstVacunas.SetItemChecked(i, False)
        Next
        chkClinico.Checked = False
        chkPeluqueria.Checked = False
        picFoto.BackgroundImage = Nothing
    End Sub

    Private Sub inicio()
        limpiar()
        cargar("")
        TabPage1.Parent = TabControl1
        TabPage2.Parent = Nothing
        TabPage3.Parent = Nothing
        llenarEspecie()
        lstVacunas.DataSource = Nothing
    End Sub

    Private Sub cargar(ByVal sql As String)
        Dim campos As String = "Paciente.idPaciente AS 'Codigo del paciente', Paciente.nombre AS 'Nombre del paciente'," &
        "Especie.nombre As 'Especie', Paciente.sexo AS 'Sexo' , Paciente.Raza AS Raza, Paciente.rasgoDist AS Rasgos," &
        "Paciente.fechaNac AS 'Fecha de Nacimiento', Propietario.idPropietario AS 'Codigo del propietario', " &
        "Propietario.priNombre AS 'Nombre del propietario', Propietario.priApellido AS 'Nombre del propietario'"

        Dim join As String = "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie " &
        "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

        dgvPacientes.DataSource = con.consultaCondicionada(campos, "Paciente", join, sql)
        dgvPacientes.Refresh()
    End Sub

    Private Sub llenarVacunas(ByVal Ctrl As Windows.Forms.ListBox, ByVal condicion As String, ByVal tabla As String, ByVal identificacion As String, ByVal nombre As String)
        Ctrl.DataSource = con.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identificacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub llenarCmbUltiVacuna(ByVal Ctrl As Windows.Forms.ComboBox, ByVal condicion As String, ByVal tabla As String, ByVal identifacion As String, ByVal nombre As String)
        Ctrl.DataSource = con.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identifacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub llenarEspecie()
        cmbEspecie.DataSource = con.consultaGeneral("Especie")
        cmbEspecie.ValueMember = "idEspecie"
        cmbEspecie.DisplayMember = "nombre"
    End Sub

    Private Sub vetUpdtPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub btnActualizarPro_Click(sender As Object, e As EventArgs) Handles btnActualizarPro.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            TabPage2.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            TabPage1.Parent = Nothing

            'Tomando el dato de la fila seleccionada para llenar los otros tab
            Dim dt As DataTable = con.consultaCondicionada("Propietario", " idPropietario='" & dgvPacientes.SelectedRows().Item(0).Cells(7).Value & "'")

            txtPriNombre.Text = dt.Rows(0)("priNombre").ToString
            txtSegNombre.Text = dt.Rows(0)("segNombre").ToString
            txtPriApellido.Text = dt.Rows(0)("priApellido").ToString
            txtSegApellido.Text = dt.Rows(0)("segApellido").ToString
            txtDui.Text = dt.Rows(0)("dui").ToString
            txtEmail.Text = dt.Rows(0)("email").ToString
            If dt.Rows(0)("sexo").ToString = "F" Then
                rdbFemenino.Checked = True
            End If
            If dt.Rows(0)("sexo").ToString = "M" Then
                rdbMasculino.Checked = True
            End If

            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            txtTelFijo.Text = dt.Rows(0)("telFijo").ToString
            txtTelMovil.Text = dt.Rows(0)("telMovil").ToString
            txtCodPropietario.Text = dt.Rows(0)("idPropietario").ToString

        Else
            MessageBox.Show("Debe de seleccionar a un paciente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnGuardarPro_Click(sender As Object, e As EventArgs) Handles btnGuardarPro.Click
        Try
            If txtPriNombre.TextLength = 0 Then
                MessageBox.Show("Ingrese el Primer Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPriNombre.Focus()
                Exit Sub
            ElseIf txtPriApellido.TextLength = 0 Then
                MessageBox.Show("Ingrese Apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPriApellido.Focus()
                Exit Sub
            ElseIf txtEmail.TextLength = 0 Then
                MessageBox.Show("Ingrese el correo electronico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Exit Sub
            ElseIf Not rdbFemenino.Checked And Not rdbMasculino.Checked Then
                MessageBox.Show("Ingrese el genero del propietario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sexo As String = ""
            If rdbFemenino.Checked = True Then
                sexo = "F"
            End If
            If rdbMasculino.Checked = True Then
                sexo = "M"
            End If
            Dim valores = "priNombre='" & txtPriNombre.Text & "', segNombre='" & txtSegNombre.Text & "', priApellido='" & txtPriApellido.Text & "', segApellido='" &
            txtSegApellido.Text & "', dui='" & txtDui.Text & "', email='" & txtEmail.Text & "', sexo='" & sexo & "', direccion='" &
            txtDireccion.Text & "', telFijo='" & txtTelFijo.Text & "', telMovil='" & txtTelMovil.Text & "'"

            If con.actualizar("Propietario", valores, "idPropietario='" & txtCodPropietario.Text & "'") > 0 Then
                MessageBox.Show("Datos del Propietario actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                inicio()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelarP_Click(sender As Object, e As EventArgs) Handles btnCancelarP.Click, btnCancelar.Click
        inicio()
    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            foto = 1
            picFoto.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            strImg = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmbEspecie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEspecie.SelectionChangeCommitted
        llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")
    End Sub

    Private Sub btnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        boton = 1
        TabPage3.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        TabPage1.Parent = Nothing
    End Sub

    Private Sub btnGuardarPac_Click(sender As Object, e As EventArgs) Handles btnGuardarPac.Click
        Try
            Dim sexo = ""
            If rdbHembra.Checked Then
                sexo = "H"
            End If
            If rdbMacho.Checked Then
                sexo = "M"
            End If

            Dim tipoRegistro As String = ""
            If chkClinico.Checked And chkPeluqueria.Checked = False Then
                tipoRegistro = "1"
            ElseIf chkPeluqueria.Checked And chkClinico.Checked = False Then
                tipoRegistro = "2"
            ElseIf chkClinico.Checked And chkPeluqueria.Checked Then
                tipoRegistro = "3"
            End If

            If boton = 0 Then
                If txtNombrePaciente.TextLength = 0 Then
                    MessageBox.Show("Ingrese el Nombre del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNombrePaciente.Focus()
                    Exit Sub
                ElseIf txtRaza.TextLength = 0 Then
                    MessageBox.Show("Ingrese la raza del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtRaza.Focus()
                    Exit Sub
                ElseIf txtColor.TextLength = 0 Then
                    MessageBox.Show("Ingrese el color", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtColor.Focus()
                    Exit Sub
                ElseIf Not chkClinico.Checked And Not chkPeluqueria.Checked Then
                    MessageBox.Show("Ingrese el tipo de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim valores2 = "nombre='" & txtNombrePaciente.Text & "', idEspecie=" & cmbEspecie.SelectedValue & ", sexo='" & sexo & "', raza='" & txtRaza.Text & "', color='" & txtColor.Text & "', fechaNac='" & dtpFechaNac.Value.ToString("MM-dd-yyyy") &
                    "', peso='" & txtPeso.Text & "', estadoRep='" & txtEstadoRep.Text & "', rasgoDist='" & txtRasgos.Text & "', idTipoReg=" & tipoRegistro & ", ultimaVacuna='" & cmbUltiVacuna.SelectedValue & "', fechaUltiVac='" & dtpUltiVacuna.Value.ToString("MM-dd-yyyy") & "'"
                If con.actualizar("Paciente", valores2, "idPaciente='" & txtCodPaciente.Text & "'") Then
                    If foto = 1 Then
                        If picFoto.BackgroundImage Is Nothing Then
                            'Nada
                        Else
                            Dim logo As New System.IO.MemoryStream
                            picFoto.BackgroundImage.Save(logo, picFoto.BackgroundImage.RawFormat)
                            Dim imagen As Byte() = logo.GetBuffer

                            If con.actualizar("Paciente", "fotografia", "idPaciente", txtCodPaciente.Text, imagen) = 0 Then
                                MessageBox.Show("Error al cargar la foto del paciente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If

                    inicio()
                End If

            ElseIf boton = 1 Then
                Dim propietario = dgvPacientes.SelectedRows().Item(0).Cells(7).Value
                If txtNombrePaciente.TextLength = 0 Then
                    MessageBox.Show("Ingrese el nombre del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf sexo.Length = 0 Then
                    MessageBox.Show("Ingrese el genero del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf txtRaza.TextLength = 0 Then
                    MessageBox.Show("Ingrese la raza del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf txtColor.TextLength = 0 Then
                    MessageBox.Show("Ingrese el color de pelaje o piel del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                ElseIf tipoRegistro.Length = 0 Then
                    MessageBox.Show("Ingrese el tipo de registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim codigo = Mid(propietario, 1, 2).ToUpper + Mid(txtNombrePaciente.Text, 1, 2).ToUpper
                Dim condicion2 = "idPaciente LIKE '" & codigo & "%'"
                If con.correlativo("idPaciente", "Paciente", condicion2) < 10 Then
                    txtCodPaciente.Text = codigo & "0" & con.correlativo("idPaciente", "Paciente", condicion2)
                Else
                    txtCodPaciente.Text = codigo & con.correlativo("idPaciente", "Paciente", condicion2)
                End If

                Dim valores2 = "'" & txtCodPaciente.Text & "','" & propietario & "','" & txtNombrePaciente.Text & "'," & cmbEspecie.SelectedValue & ",'" & sexo & "','" & txtRaza.Text & "','" & txtColor.Text & "','" & dtpFechaNac.Value.ToString("MM-dd-yyyy") &
                    "','" & txtPeso.Text & "','" & txtEstadoRep.Text & "','" & txtRasgos.Text & "'," & tipoRegistro & ",'','','" & Now.ToString("MM-dd-yyyy") & "','" & Now.ToString("HH:mm:ss") & "',''"

                If con.insertar("Paciente", valores2) > 0 Then
                    MessageBox.Show("Paciente ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If picFoto.BackgroundImage Is Nothing Then
                        'Nada
                    Else
                        Dim logo As New System.IO.MemoryStream
                        picFoto.BackgroundImage.Save(logo, picFoto.BackgroundImage.RawFormat)
                        Dim imagen As Byte() = logo.GetBuffer

                        If con.actualizar("Paciente", "fotografia", "idPaciente", txtCodPaciente.Text, imagen) = 0 Then
                            MessageBox.Show("Error al cargar la foto del paciente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                    If lstVacunas.CheckedItems.Count > 0 Then
                        'Guardar Vacunas
                        For aa = 0 To lstVacunas.CheckedItems.Count - 1
                            Dim vac = lstVacunas.GetItemText(lstVacunas.CheckedItems(aa))
                            Dim vacuna As String = con.consultaExistente("idVacuna", "Vacuna", " nombre='" & vac & "'")
                            If con.consultaExistente("Vacuna_Paciente", "idVacuna = '" & vacuna & "' AND idPaciente='" & txtCodPaciente.Text & "'") = 0 Then
                                con.insertar("Vacuna_Paciente", "'" & vacuna & "','" & txtCodPaciente.Text & "','" & Now.ToString("MM-dd-yyyy") & "'") 'XXX
                            End If

                        Next

                        'Ultima Vacuna
                        con.actualizar("Paciente", "ultimaVacuna='" & cmbUltiVacuna.SelectedValue & "', fechaUltiVac='" & dtpUltiVacuna.Value.ToString("MM-dd-yyyy") & "'", "idPaciente='" & txtCodPaciente.Text & "'")
                    End If

                    inicio()
                Else
                    MessageBox.Show("No se pudo ingresar al paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnActualizarPac_Click(sender As Object, e As EventArgs) Handles btnActualizarPac.Click

        boton = 0
        TabPage3.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        TabPage1.Parent = Nothing

        'Tomando el dato de la fila seleccionada para llenar los otros tab
        Dim dt As DataTable = con.consultaCondicionada("Paciente", " idPaciente='" & dgvPacientes.SelectedRows().Item(0).Cells(0).Value & "'")
        txtCodPaciente.Text = dt.Rows(0)("idPaciente").ToString
        txtNombrePaciente.Text = dt.Rows(0)("nombre").ToString
        cmbEspecie.SelectedValue = dt.Rows(0)("idEspecie").ToString

        llenarVacunas(lstVacunas, "idPaciente = '" & txtCodPaciente.Text & "'", "Vacuna_Paciente", "idVacuna", "nombre")
        llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")

        If dt.Rows(0)("sexo").ToString = "H" Then
            rdbHembra.Checked = True
        End If
        If dt.Rows(0)("sexo").ToString = "M" Then
            rdbMacho.Checked = True
        End If
        txtRaza.Text = dt.Rows(0)("raza").ToString
        txtColor.Text = dt.Rows(0)("color").ToString
        dtpFechaNac.Value = dt.Rows(0)("fechaNac").ToString
        txtPeso.Text = dt.Rows(0)("peso").ToString
        txtEstadoRep.Text = dt.Rows(0)("estadoRep").ToString
        txtRasgos.Text = dt.Rows(0)("rasgoDist").ToString

        cmbUltiVacuna.SelectedValue = dt.Rows(0)("ultimaVacuna").ToString
        dtpUltiVacuna.Value = dt.Rows(0)("fechaUltiVac").ToString

        If dt.Rows(0)("idTipoReg").ToString = 1 Then
            chkClinico.Checked = True
        ElseIf dt.Rows(0)("idTipoReg").ToString = 2 Then
            chkPeluqueria.Checked = True
        ElseIf dt.Rows(0)("idTipoReg").ToString = 3 Then
            chkClinico.Checked = True
            chkPeluqueria.Checked = True
        End If

        Dim ms As New System.IO.MemoryStream(con.selectImg("Paciente", "fotografia", "WHERE idPaciente='" & txtCodPaciente.Text & "'"))
        picFoto.BackgroundImage = Image.FromStream(ms)

        
    End Sub

    Private Sub cmbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecie.SelectedIndexChanged
        If boton = 1 Then
            llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")
            llenarVacunas(lstVacunas, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")
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
    Private Sub txtNombrePaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombrePaciente.KeyPress
        cGenerica.SoloTexto(txtNombrePaciente, e)
    End Sub
    Private Sub txtRaza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRaza.KeyPress
        cGenerica.SoloTexto(txtRaza, e)
    End Sub
    Private Sub txtRasgos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRasgos.KeyPress
        cGenerica.SoloTexto(txtRasgos, e)
    End Sub
    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress
        cGenerica.SoloTexto(txtColor, e)
    End Sub
    Private Sub txtEstadoRep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoRep.KeyPress
        cGenerica.SoloTexto(txtEstadoRep, e)
    End Sub
    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        cGenerica.DosDecimales(txtPeso, e)
    End Sub
End Class