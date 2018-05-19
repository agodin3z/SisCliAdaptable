Public Class medPosponerCita
    Dim con As New cConexion
    Dim tabla As String = "Cita"
    Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', (Paciente.priNombre + ' ' + Paciente.priApellido) AS 'Nombre del Paciente'," &
                            "Cita.fecha AS 'Fecha de Realización'," &
                            " Cita.motivo AS 'Motivo de la cita', Usuario.nombre AS 'Encargado', Cita.fechaCrea AS 'Fecha de Creación', Cita.horaCrea AS 'Hora de Creación'"
    'Uniendo las tablas de Paciente y Usuario
    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
                        "INNER JOIN Usuario ON Usuario.username = Cita.username"
    Dim condicion As String = "WHERE estado = 1"
    Dim paciente As String
    Dim fecha As DateTime
    Dim hora As String

    Private Sub limpiar()
        txtPaciente.Clear()
        txtMotivo.Clear()
        dtpFechaSiguiente.Value = Now.ToString("MM-dd-yyyy HH:mm:ss")
        TabPage1.Parent = Me.TabControl1
        TabControl1.SelectTab(0)
        TabPage2.Parent = Nothing
    End Sub

    Private Sub cargar()
        dgvCitas.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvCitas.Refresh()

        cmbMedico.DataSource = con.consultaCondicionada("*", "Usuario", "", "WHERE idRol=2")
        cmbMedico.Refresh()
        cmbMedico.ValueMember = "username"
        cmbMedico.DisplayMember = "nombre"
    End Sub

    Private Sub medPosponerCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        TabPage2.Parent = Nothing
    End Sub

    Private Sub dgvCitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellDoubleClick
        TabPage2.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        'Tomando el dato de la fila seleccionada para llenar el otro tab
        For Each celda As DataGridViewRow In dgvCitas.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            dtpFechaSiguiente.Value = DateTime.Parse(celda.Cells(2).Value).ToString("MM-dd-yyyy HH:mm:ss")
            txtMotivo.Text = celda.Cells(3).Value.ToString
            cmbMedico.SelectedValue = con.consultaExistente("username", "Usuario", "nombre='" & celda.Cells(4).Value.ToString & "'")
            fecha = DateTime.Parse(celda.Cells(5).Value).ToString("yyyy-MM-dd")
            hora = DateTime.Parse(celda.Cells(6).Value.ToString()).ToString("HH:mm:ss")
        Next

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fechaProx As String = dtpFechaSiguiente.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim motivo As String = txtMotivo.Text.Trim
        Dim estado As String = "1"

        If motivo.Length = 0 Then
            MessageBox.Show("Ingrese el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nVals = " motivo ='" & motivo & "', fecha='" & fechaProx & "', username='" & cmbMedico.SelectedValue & "'"

        If con.consultaExistente("Cita", "idPaciente <>'" & paciente & "' AND fecha='" & fechaProx & "'") > 0 Then
            MessageBox.Show("Ya existe una cita registrada para la hora que esta indicando", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If con.actualizar("Cita", nVals, "idPaciente='" & paciente & "' AND fechaCrea='" & fecha & "' AND horaCrea='" & hora & "'") > 0 Then
                MessageBox.Show("Cita Actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub dtpFechaSiguiente_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpFechaSiguiente.ValueChanged
        If dtpFechaSiguiente.Value < fecha And dtpFechaSiguiente.Value < Date.Now Then
            MessageBox.Show("No puede crear una cita para tiempo pasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpFechaSiguiente.Value = fecha.AddMinutes(1)
        End If
    End Sub

    Private Sub txtMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotivo.KeyPress
        cGenerica.SoloTexto(txtMotivo, e)
    End Sub
End Class