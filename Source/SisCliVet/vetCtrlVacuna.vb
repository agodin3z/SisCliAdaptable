Public Class vetCtrlVacuna
    Dim con As New cConexion
    Dim tabla As String = "Paciente"
    
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Especie.nombre AS 'Especie', Propietario.idPropietario AS 'Codigo del Propietario'," &
    "Propietario.priNombre AS 'Nombre del Propietario', Propietario.priApellido AS 'Apellido del Propietario'"

    Dim join As String = "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario " &
                        "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie"
    Dim paciente As String
    Dim condicion As String
    Dim condicion2 As String
    Dim especie As String = ""

    Private Sub llenarVacunas(ByVal Ctrl As Windows.Forms.ListBox, ByVal condicion As String, ByVal tabla As String, ByVal identificacion As String, ByVal nombre As String)
        Ctrl.DataSource = con.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identificacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub nuevaVacuna()
        Dim x As Array = Split(txtOtraVacuna.Text, vbCrLf)
        Dim nom As String = Mid(especie, 1, 3).ToUpper
        Dim esp As Integer = con.consultaExistente("idEspecie", "Especie", "nombre='" & especie & "'")
        For Each i As String In x
            If i.Length > 0 Then
                Dim corr As Integer = con.consultaExistente("Vacuna", "idVacuna LIKE '" & nom & "%'")
                If con.consultaExistente("Vacuna", "nombre = '" & i & "'") = 0 Then
                    If corr < 10 Then
                        con.insertar("Vacuna", "'" & nom & "00" & corr & "'," & "'" & esp & "','" & i & "'")
                    ElseIf corr < 100 Then
                        con.insertar("Vacuna", "'" & nom & "0" & corr & "'," & "'" & esp & "','" & i & "'")
                    Else
                        con.insertar("Vacuna", "'" & nom & corr & "'," & "'" & esp & "','" & i & "'")
                    End If
                End If                
            End If
        Next
        txtOtraVacuna.Clear()
        llenarVacunas(lstAplicar, "idEspecie = " & esp, "Vacuna", "idVacuna", "nombre")
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub vetCtrlVacuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
        txtFecha.Text = Now.ToString("MM-dd-yyyy")
        txtHora.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        TabControl1.SelectTab(1)
        'Llenando los campos de la siguiente tab
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            especie = celda.Cells(2).Value.ToString
        Next

        txtFecha.Text = Now.ToString("MM-dd-yyyy")
        txtHora.Text = Now.ToString("HH:mm:ss")
        'Condicion para llenar el checkedListBox segun Especie
        condicion2 = "Vacuna.idEspecie = (SELECT Especie.idEspecie " &
        "FROM Especie WHERE Especie.nombre ='" & especie & "')"
        Dim condicion3 As String = "WHERE idPaciente = '" & paciente & "'"
        Dim inner As String = "INNER JOIN Vacuna ON Vacuna_Paciente.idVacuna = Vacuna.idVacuna"
        llenarVacunas(lstAplicar, condicion2, "Vacuna", "idVacuna", "nombre")

        lstVacunas.DataSource = con.consultaCondicionada("*", "Vacuna_Paciente", inner, condicion3)
        lstVacunas.ValueMember = "idVacuna"
        lstVacunas.DisplayMember = "nombre"

        For i = 0 To lstVacunas.Items.Count - 1
            lstVacunas.SetItemChecked(i, True)
        Next


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim fecha As DateTime = txtFecha.Text

        If paciente.Length = 0 Then
            MessageBox.Show("Seleccione un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If lstAplicar.CheckedItems.Count > 0 Then
            'Guardar Vacunas
            Dim cont = 0
            For aa = 0 To lstAplicar.CheckedItems.Count - 1
                Dim vac = lstAplicar.GetItemText(lstAplicar.CheckedItems(aa))
                Dim vacuna As String = con.consultaExistente("idVacuna", "Vacuna", " nombre='" & vac & "'")
                If con.consultaExistente("Vacuna_Paciente", "idVacuna = '" & vacuna & "' AND idPaciente='" & paciente & "'") = 0 Then
                    cont += con.insertar("Vacuna_Paciente", "'" & vacuna & "','" & paciente & "','" & fecha.ToString("yyyy-MM-dd") & "'") 'XXX
                    con.actualizar("Paciente", "ultimaVacuna='" & vacuna & "', fechaUltiVac='" & fecha.ToString("yyyy-MM-dd") & "'", "idPaciente='" & paciente & "'")
                End If
            Next
            If cont > 0 Then
                MessageBox.Show("Se han registrado " & cont & " Vacunas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.insertar("Cita", "'" & fecha & "','" & txtHora.Text & "','" & "Refuerzo" & "','" & dtpFechaSiguiente.Value.ToString("yyyy-MM-dd HH:mm:ss") & "','" & paciente & "','" & cGenerica.usr & "',1")
            Else
                MessageBox.Show("No se han registrado Vacunas nuevas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            For i = 0 To lstVacunas.Items.Count - 1
                lstVacunas.SetItemChecked(i, False)
            Next
            For i = 0 To lstAplicar.Items.Count - 1
                lstAplicar.SetItemChecked(i, False)
            Next
            txtFecha.Clear()
            txtHora.Clear()
            txtOtraVacuna.Clear()
            txtPaciente.Clear()
            TabControl1.SelectTab(0)
        End If

    End Sub

    Private Sub txtOtraVacuna_Leave(sender As Object, e As EventArgs) Handles txtOtraVacuna.Leave
        nuevaVacuna()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox4)
        lstVacunas.DataSource = Nothing
        lstAplicar.DataSource = Nothing
    End Sub
End Class