Imports System.IO
Public Class vetPacientes
    Dim con As New cConexion, strImg As String
    Dim tabla As String = "Propietario", tabla2 As String = "Paciente"
    Dim proPrimerNombre As String, proSegundoNombre As String, proPrimerApellido As String, proSegundoApellido As String
    Dim proDui As String, proEmail As String, proGenero As String = "", proDireccion As String, proTelFijo As String
    Dim proTelMovil As String, hora As String, fecha As String, codigo As String, priNomApe As String, valores As String
    Dim seleccionVac() As String

    Private Sub limpiar()
        cGenerica.limpiarTextbox(GroupBox1)
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox5)
        rdbFemenino.Checked = False
        rdbHembra.Checked = False
        rdbMacho.Checked = False
        rdbMasculino.Checked = False
        chkClinico.Checked = False
        chkPeluqueria.Checked = False
        For i = 0 To lstVacunas.Items.Count - 1
            lstVacunas.SetItemChecked(i, False)
        Next
        picFoto.BackgroundImage = Nothing
        TabPage2.Parent = Nothing
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

    Private Sub nuevaEspecie()
        Dim nuevo As String = cmbEspecie.Text
        If con.consultaExistente("Especie", "nombre='" & nuevo & "'") = 0 Then
            If con.insertar("Especie", "'" & nuevo & "'") > 0 Then
                MessageBox.Show("Agregado")
            End If
        End If
        llenarEspecie()
        cmbEspecie.SelectedValue = con.consultaExistente("idEspecie", "Especie", "nombre='" & nuevo & "'")
    End Sub

    Private Sub nuevaVacuna()
        Dim nuevo As String = con.consultaExistente("nombre", "Especie", "idEspecie='" & cmbEspecie.SelectedValue & "'")
        Dim x As Array = Split(txtOtraVacuna.Text, vbCrLf)
        Dim nom As String = Mid(nuevo, 1, 3).ToUpper
        Dim esp As Integer = con.consultaExistente("idEspecie", "Especie", "nombre='" & nuevo & "'")
        For Each i As String In x
            If i.Length > 0 Then
                Dim corr As Integer = con.consultaExistente("Vacuna", "idVacuna LIKE '" & nom & "%'")
                If corr < 10 Then
                    con.insertar("Vacuna", "'" & nom & "00" & corr & "'," & "'" & esp & "','" & i & "'")
                ElseIf corr < 100 Then
                    con.insertar("Vacuna", "'" & nom & "0" & corr & "'," & "'" & esp & "','" & i & "'")
                Else
                    con.insertar("Vacuna", "'" & nom & corr & "'," & "'" & esp & "','" & i & "'")
                End If
            End If
        Next
        txtOtraVacuna.Clear()
        llenarVacunas(lstVacunas, "idEspecie = " & esp, "Vacuna", "idVacuna", "nombre")
        llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = " & esp, "Vacuna", "idVacuna", "nombre")
    End Sub

    Private Sub vetPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHora.Text = Now.ToString("HH:mm:ss")
        txtFecha.Text = Today.ToString("MM-dd-yyyy")
        llenarEspecie()
        llenarVacunas(lstVacunas, "idEspecie = 1", "Vacuna", "idVacuna", "nombre")
        llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = 1", "Vacuna", "idVacuna", "nombre")
        TabPage2.Parent = Nothing
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            Dim condicion As String
            proPrimerNombre = txtPriNombre.Text.Trim
            proSegundoNombre = txtSegNombre.Text.Trim
            proPrimerApellido = txtPriApellido.Text.Trim
            proSegundoApellido = txtSegApellido.Text.Trim
            proDui = txtDui.Text.Trim
            proEmail = txtEmail.Text.Trim
            If rdbMasculino.Checked Then
                proGenero = "M"
            ElseIf rdbFemenino.Checked Then
                proGenero = "F"
            End If
            proDireccion = txtDireccion.Text.Trim
            proTelFijo = txtTelFijo.Text.Trim
            proTelMovil = txtTelMovil.Text.Trim
            hora = Date.Now.ToString("HH:mm:ss")
            fecha = Date.Now.ToString("dd-MM-yyyy")

            If proPrimerNombre.Length = 0 Then
                MessageBox.Show("Ingrese su Primer Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf proPrimerApellido.Length = 0 Then
                MessageBox.Show("Ingrese Apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf proEmail.Length = 0 Then
                MessageBox.Show("Ingrese su correo electronico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf proGenero.Length = 0 Then
                MessageBox.Show("Ingrese el genero del propietario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            priNomApe = Mid(proPrimerNombre, 1, 1).ToUpper + Mid(proPrimerApellido, 1, 1).ToUpper + Mid(fecha, 9, 2)
            condicion = "idPropietario LIKE '" & priNomApe & "%'"
            If con.correlativo("idPropietario", tabla, condicion) < 10 Then
                codigo = priNomApe & "00" & con.correlativo("idPropietario", tabla, condicion)
            ElseIf con.correlativo("idPropietario", tabla, condicion) < 100 Then
                codigo = priNomApe & "0" & con.correlativo("idPropietario", tabla, condicion)
            Else
                codigo = priNomApe & con.correlativo("idPropietario", tabla, condicion)
            End If
            txtCodPropietario.Text = codigo

            TabPage2.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            valores = "'" & codigo & "','" & proPrimerNombre & "','" & proSegundoNombre & "','" & proPrimerApellido & "','" &
            proSegundoApellido & "','" & proDui & "','" & proEmail & "','" & proGenero & "','" &
            proDireccion & "','" & proTelFijo & "','" & proTelMovil & "','" & fecha & "','" & hora & "'"

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim valores2 As String, codPac As String, proPac As String, condicion2 As String
            Dim pacId As String = txtCodPaciente.Text.Trim
            Dim pacNombre As String = txtNombrePaciente.Text.Trim
            Dim pacEspecie As Integer = cmbEspecie.SelectedValue.ToString
            Dim pacGenero As String = ""
            If rdbMacho.Checked Then
                pacGenero = "M"
            ElseIf rdbHembra.Checked Then
                pacGenero = "F"
            End If
            Dim pacRaza As String = txtRaza.Text.Trim
            Dim pacColor As String = txtColor.Text
            Dim pacFecha As String = dtpFechaNac.Value.ToString("dd-MM-yyyy")
            Dim peso As String = txtPeso.Text.Trim
            Dim estado As String = txtEstadoRep.Text.Trim
            Dim rasgos As String = txtRasgos.Text.Trim
            Dim vacunas As String = lstVacunas.SelectedItems.ToString
            Dim otravacuna As String = lstVacunas.SelectedItems.ToString
            Dim tipoRegistro As String = ""
            If chkClinico.Checked And chkPeluqueria.Checked = False Then
                tipoRegistro = "1"
            ElseIf chkPeluqueria.Checked And chkClinico.Checked = False Then
                tipoRegistro = "2"
            ElseIf chkClinico.Checked And chkPeluqueria.Checked Then
                tipoRegistro = "3"
            End If
            Dim ultimaVacuna As String = cmbUltiVacuna.SelectedValue.ToString
            Dim fechaUltimaVacuna As String = dtpUltiVacuna.Value.ToString("dd-MM-yyyy")

            If pacNombre.Length = 0 Then
                MessageBox.Show("Ingrese el nombre del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf pacGenero.Length = 0 Then
                MessageBox.Show("Ingrese el genero del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf pacRaza.Length = 0 Then
                MessageBox.Show("Ingrese la raza del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf pacColor.Length = 0 Then
                MessageBox.Show("Ingrese el color de pelaje o piel del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf tipoRegistro.Length = 0 Then
                MessageBox.Show("Ingrese el tipo de registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf ultimaVacuna.Length = 0 Then
                MessageBox.Show("Ingrese la ultima vacuna del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf fechaUltimaVacuna.Length = 0 Then
                MessageBox.Show("Ingrese la fecha de ultima vacuna", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            proPac = Mid(txtPriNombre.Text, 1, 1).ToUpper + Mid(txtPriApellido.Text, 1, 1).ToUpper + Mid(txtNombrePaciente.Text, 1, 2).ToUpper
            condicion2 = "idPaciente LIKE '" & proPac & "%'"
            If con.correlativo("idPaciente", tabla2, condicion2) < 10 Then
                codPac = proPac & "0" & con.correlativo("idPaciente", tabla2, condicion2)
            Else
                codPac = proPac & con.correlativo("idPaciente", tabla2, condicion2)
            End If

            txtCodPaciente.Text = codPac

            valores2 = "'" & codPac & "','" & codigo & "','" & pacNombre & "'," & pacEspecie & ",'" & pacGenero & "','" & pacRaza & "','" & pacColor & "','" & pacFecha &
                "','" & peso & "','" & estado & "','" & rasgos & "'," & tipoRegistro & ",'','','" & fecha & "','" & hora & "',''"

            If con.insertar(tabla, valores) > 0 Then
                'MessageBox.Show("Propietario ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If con.insertar(tabla2, valores2) > 0 Then
                    MessageBox.Show("Paciente ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If picFoto.BackgroundImage Is Nothing Then
                        'Nada
                    Else
                        Dim logo As New MemoryStream
                        picFoto.BackgroundImage.Save(logo, picFoto.BackgroundImage.RawFormat)
                        Dim imagen As Byte() = logo.GetBuffer

                        If con.actualizar("Paciente", "fotografia", "idPaciente", codPac, imagen) = 0 Then
                            MessageBox.Show("Error al cargar la foto del paciente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                    If lstVacunas.CheckedItems.Count > 0 Then
                        'Guardar Vacunas
                        For aa = 0 To lstVacunas.CheckedItems.Count - 1
                            Dim vac = lstVacunas.GetItemText(lstVacunas.CheckedItems(aa))
                            Dim vacuna As String = con.consultaExistente("idVacuna", "Vacuna", " nombre='" & vac & "'")
                            con.insertar("Vacuna_Paciente", "'" & vacuna & "','" & codPac & "','" & fecha & "'") 'XXX
                        Next

                        'Ultima Vacuna
                        con.actualizar("Paciente", "ultimaVacuna='" & ultimaVacuna & "', fechaUltiVac='" & fechaUltimaVacuna & "'", "idPaciente='" & codPac & "'")
                    End If

                    limpiar()
                Else
                    MessageBox.Show("No se pudo ingresar al paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("No se pudo ingresar al propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picFoto.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            strImg = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmbEspecie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEspecie.SelectionChangeCommitted
        llenarCmbUltiVacuna(cmbUltiVacuna, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")
        llenarVacunas(lstVacunas, "idEspecie = " & cmbEspecie.SelectedValue.ToString, "Vacuna", "idVacuna", "nombre")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub cmbEspecie_Leave(sender As Object, e As EventArgs) Handles cmbEspecie.Leave
        nuevaEspecie()
    End Sub

    Private Sub txtOtraVacuna_Leave(sender As Object, e As EventArgs) Handles txtOtraVacuna.Leave
        nuevaVacuna()
    End Sub

End Class