Public Class medCitas
    Dim con As New cConexion
    Dim tabla As String = "Paciente"
    Dim campos As String = "idPaciente AS 'Codigo del Paciente', (priNombre + ' ' + priApellido)  AS 'Nombre del Paciente'," &
                        "genero AS 'Genero', fechaNac AS 'Fecha de nacimiento'"
    Dim paciente As String

    Private Sub limpiar()
        txtPaciente.Clear()
        txtMotivo.Clear()
        dtpFechaSiguiente.Value = Now.ToString("MM-dd-yyyy HH:mm:ss")
        TabPage1.Parent = Me.TabControl1
        TabControl1.SelectTab(0)
        TabPage2.Parent = Nothing
    End Sub

    Private Sub cargar(ByVal condicion As String)
        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, "", condicion)
        dgvPacientes.Refresh()

        cmbMedico.DataSource = con.consultaCondicionada("*", "Usuario", "", "WHERE idRol=2")
        cmbMedico.Refresh()
        cmbMedico.ValueMember = "username"
        cmbMedico.DisplayMember = "nombre"
    End Sub

    Private Sub medCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
        TabPage2.Parent = Nothing
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE priNombre LIKE '" & txtBusqueda.Text.Trim & "%' OR priApellido LIKE '" & txtBusqueda.Text.Trim & "%' OR idPaciente LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub btnPosponer_Click(sender As Object, e As EventArgs) Handles btnPosponer.Click
        Dim f As New medPosponerCita
        f.ShowDialog()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            TabPage2.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            TabPage1.Parent = Nothing

            'Tomando el dato de la fila seleccionada para llenar el otro tab
            For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
                paciente = celda.Cells(0).Value.ToString
                txtPaciente.Text = celda.Cells(1).Value.ToString
            Next
            btnGuardar.Enabled = True
        Else
            MessageBox.Show("Debe de seleccionar a un paciente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fechaProx As String = dtpFechaSiguiente.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim fecha As String = Date.Now.ToString("yyyy-MM-dd")
        Dim hora As String = Date.Now.ToString("HH:mm:ss")
        Dim motivo As String = txtMotivo.Text.Trim
        Dim estado As String = "1"


        If motivo.Length = 0 Then
            MessageBox.Show("Ingrese el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim valores = "'" & fecha & "','" & hora & "','" & motivo & "','" & fechaProx & "','" & paciente & "','" & cmbMedico.SelectedValue & "'," & estado & ""

        If con.consultaExistente("Cita", "idPaciente <>'" & paciente & "' AND fecha='" & fechaProx & "'") > 0 Then
            MessageBox.Show("Ya existe una cita registrada para la hora que esta indicando", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If con.insertar("Cita", valores) > 0 Then
                MessageBox.Show("Cita creada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txtMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotivo.KeyPress
        cGenerica.SoloTexto(txtMotivo, e)
    End Sub
End Class