Public Class vetCitas
    Dim con As New cConexion
    Dim paciente As String

    Private Sub limpiar()
        txtBusqueda.Clear()
        txtPaciente.Clear()
        txtOtro.Clear()
        txtPropietario.Clear()
        rdbConsulta.Checked = False
        rdbOtro.Checked = False
        rdbPeluqueria.Checked = False
        rdbRefuerzo.Checked = False
        TabPage2.Parent = Nothing
    End Sub

    Private Sub cargar(ByVal condicion As String)
        Dim campos As String = "Paciente.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
        "Propietario.idPropietario AS 'Codigo del Propietario', Propietario.priNombre AS 'Nombre del Propietario'," &
        "Propietario.priApellido AS 'Apellido del Propietario'"
        Dim join As String = "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

        dgvPacientes.DataSource = con.consultaCondicionada(campos, "Paciente", join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub vetCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
        TabPage2.Parent = Nothing
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            Dim propietario As String
            TabPage2.Parent = Me.TabControl1
            TabControl1.SelectTab(1)
            'Tomando el dato de la fila seleccionada para llenar el otro tab
            For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
                paciente = celda.Cells(0).Value.ToString
                txtPaciente.Text = celda.Cells(1).Value.ToString
                propietario = celda.Cells(2).Value.ToString
                txtPropietario.Text = celda.Cells(3).Value.ToString & " " & celda.Cells(4).Value.ToString
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
        Dim motivo As String = ""
        If rdbConsulta.Checked Then
            motivo = "Consulta General"
        ElseIf rdbPeluqueria.Checked Then
            motivo = "Peluqueria"
        ElseIf rdbRefuerzo.Checked Then
            motivo = "Refuerzo"
        ElseIf rdbOtro.Checked Then
            motivo = txtOtro.Text.Trim
        End If
        Dim estado As String = "1"

        If rdbOtro.Checked And motivo.Length = 0 Then
            MessageBox.Show("No ha ingresado el otro motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf motivo.Length = 0 Then
            MessageBox.Show("Ingrese el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim valores = "'" & fecha & "','" & hora & "','" & motivo & "','" & fechaProx & "','" & paciente & "','" & cGenerica.usr & "'," & estado & ""

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

    Private Sub rdbOtro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOtro.CheckedChanged
        If rdbOtro.Checked Then
            txtOtro.Enabled = True
        Else
            txtOtro.Enabled = False
        End If

    End Sub

    Private Sub dtpFechaSiguiente_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaSiguiente.ValueChanged
        If dtpFechaSiguiente.Value < Date.Now Then
            MessageBox.Show("No puede crear una cita para tiempo pasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpFechaSiguiente.Value = Date.Now.AddMinutes(1)
        End If
    End Sub

    Private Sub btnPosponer_Click(sender As Object, e As EventArgs) Handles btnPosponer.Click
        Dim f As New vetPosponerCita
        f.ShowDialog()
    End Sub

    'Validacion
    Private Sub txtOtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtro.KeyPress
        cGenerica.SoloTexto(txtOtro, e)
    End Sub
End Class