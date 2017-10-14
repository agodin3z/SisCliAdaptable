Public Class vetPacientes
    Dim connection As New cConexion

    Private Sub LlenarListbox(ByVal Ctrl As Windows.Forms.ListBox, ByVal condicion As String, ByVal tabla As String, ByVal identificacion As String, ByVal nombre As String)
        Ctrl.DataSource = connection.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identificacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub LlenarCmbUltiVacuna(ByVal Ctrl As Windows.Forms.ComboBox, ByVal condicion As String, ByVal tabla As String, ByVal identifacion As String, ByVal nombre As String)
        Ctrl.DataSource = connection.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identifacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub LimpiarTextbox(ByVal grupo As Windows.Forms.GroupBox)
        For Each control As Control In grupo.Controls
            If TypeOf control Is Windows.Forms.TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Dim ProPrimerNombre As String
    Dim ProSegundoNombre As String
    Dim ProPrimerApellido As String
    Dim ProSegundoApellido As String
    Dim ProDui As String
    Dim ProEmail As String
    Dim ProGenero As String = ""
    Dim ProDireccion As String
    Dim ProTelFijo As String
    Dim ProTelMovil As String
    Dim hora As String
    Dim fecha As String
    Dim tabla As String = "Propietario"
    Dim codigo As String
    Dim condicion As String
    Dim PriNomApe As String
    Dim valores As String

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        

        ProPrimerNombre = txtPriNombre.Text.Trim
        ProSegundoNombre = txtSegNombre.Text.Trim
        ProPrimerApellido = txtPriApellido.Text.Trim
        ProSegundoApellido = txtSegApellido.Text.Trim
        ProDui = txtDui.Text.Trim
        ProEmail = txtEmail.Text.Trim
        If rdbMasculino.Checked Then
            ProGenero = "M"
        ElseIf rdbFemenino.Checked Then
            ProGenero = "F"
        End If
        ProDireccion = txtDireccion.Text.Trim
        ProTelFijo = txtTelFijo.Text.Trim
        ProTelMovil = txtTelMovil.Text.Trim
        hora = txtHora.Text.Trim
        fecha = txtFecha.Text.Trim

        If ProPrimerNombre.Length = 0 Then
            MessageBox.Show("Ingrese su Primer Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf ProPrimerApellido.Length = 0 Then
            MessageBox.Show("Ingrese Apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf ProEmail.Length = 0 Then
            MessageBox.Show("Ingrese su correo electronico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf ProGenero.Length = 0 Then
            MessageBox.Show("Ingrese el genero del propietario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            PriNomApe = Mid(ProPrimerNombre, 1, 1).ToUpper + Mid(ProPrimerApellido, 1, 1).ToUpper + Mid(fecha, 9, 2)
            condicion = "WHERE idPropietario LIKE '" & PriNomApe & "%'"
            codigo = PriNomApe & connection.Correlativo("idPropietario", tabla, condicion)
            txtCodPropietario.Text = codigo

            TabControl1.SelectTab(1)
            valores = "'" & codigo & "','" & ProPrimerNombre & "','" & ProSegundoNombre & "','" & ProPrimerApellido & "','" &
            ProSegundoApellido & "','" & ProDui & "','" & ProEmail & "','" & ProGenero & "','" &
            ProDireccion & "','" & ProTelFijo & "','" & ProTelMovil & "','" & fecha & "','" & hora & "'"

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub vetPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As String = "idEspecie = 1"
        txtHora.Text = Now.ToString("HH:mm:ss")
        txtFecha.Text = Today.ToString("MM-dd-yyyy")
        cmbEspecie.DataSource = connection.consultaGeneral("Especie")
        cmbEspecie.ValueMember = "idEspecie"
        cmbEspecie.DisplayMember = "nombre"
        LlenarListbox(lstVacunas, con, "Vacuna", "idVacuna", "nombre")
        LlenarCmbUltiVacuna(cmbUltiVacuna, con, "Vacuna", "idEspecie", "nombre")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim valores2 As String
        Dim tabla2 As String = "Paciente"

        Dim codPac As String
        Dim Pro_Pac As String
        Dim condicion2 As String
        Dim PacId As String = txtCodPaciente.Text.Trim
        Dim PacNombre As String = txtNombrePaciente.Text.Trim
        Dim PacEspecie As String = cmbEspecie.SelectedValue.ToString
        Dim PacGenero As String = ""
        If rdbMacho.Checked Then
            PacGenero = "M"
        ElseIf rdbHembra.Checked Then
            PacGenero = "F"
        End If
        Dim PacRaza As String = txtRaza.Text.Trim
        Dim PacColor As String = txtColor.Text
        Dim PacFecha As String = dtpFechaNac.Value.ToString("MM-dd-yyyy")
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
            tipoRegistro = "1"
        End If
        Dim ultimaVacuna As String = cmbUltiVacuna.SelectedValue.ToString
        Dim fechaUltimaVacuna As String = dtpUltiVacuna.Value.ToString("MM-dd-yyyy")

        If PacNombre.Length = 0 Then
            MessageBox.Show("Ingrese el nombre del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf PacEspecie.Length = 0 Then
            MessageBox.Show("Ingrese la especie del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf PacGenero.Length = 0 Then
            MessageBox.Show("Ingrese el genero del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf PacRaza.Length = 0 Then
            MessageBox.Show("Ingrese la raza del paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf PacColor.Length = 0 Then
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
        ElseIf hora.Length = 0 Then
            MessageBox.Show("Hora no registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf fecha.Length = 0 Then
            MessageBox.Show("Fecha no registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Pro_Pac = Mid(txtPriNombre.Text, 1, 1).ToUpper + Mid(txtPriApellido.Text, 1, 1).ToUpper + Mid(txtNombrePaciente.Text, 1, 1).ToUpper
        condicion2 = "WHERE idPaciente LIKE '" & Pro_Pac & "'"
        codPac = Pro_Pac & connection.Correlativo("idPaciente", tabla2, condicion2)
        txtCodPaciente.Text = codPac
        valores2 = "'" & codPac & "','" & codigo & "','" & PacNombre & "','" & PacEspecie & "','" & PacGenero & "','" & PacRaza & "','" & PacColor & "','" & PacFecha &
            "','" & peso & "','" & estado & "','" & rasgos & "','" & tipoRegistro & "','" & ultimaVacuna & "','" & fechaUltimaVacuna &
            "','" & fecha & "','" & hora & "'"

        If connection.InsertarFila(tabla, "", valores) > 0 Then
            MessageBox.Show("Propietario ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pudo ingresar al propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If connection.InsertarFila(tabla2, "", valores2) > 0 Then
            MessageBox.Show("Paciente ingresado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarTextbox(GroupBox2)
            LimpiarTextbox(GroupBox3)
            LimpiarTextbox(GroupBox1)
            LimpiarTextbox(GroupBox5)
        Else
            MessageBox.Show("No se pudo ingresar al paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click

    End Sub

    Private Sub cmbEspecie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEspecie.SelectionChangeCommitted
        Dim numEspecie As String = cmbEspecie.SelectedValue.ToString
        Dim condition As String
        condition = "idEspecie = " & numEspecie
        LlenarCmbUltiVacuna(cmbUltiVacuna, condition, "Vacuna", "idEspecie", "nombre")
        LlenarListbox(lstVacunas, condition, "Vacuna", "idVacuna", "nombre")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarTextbox(GroupBox2)
        LimpiarTextbox(GroupBox3)
    End Sub

End Class