Public Class vetAgenda
    Dim con As New cConexion
    Dim tabla As String = "Cita"
    Dim campos As String = "Cita.fechaCrea AS 'Fecha de Creacion', Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
                            "Cita.fecha AS 'Fecha de Realización'," &
                            " Cita.motivo AS 'Motivo de la cita', Usuario.nombre AS 'Encargado'"
    'Uniendo las tablas de Paciente y Usuario
    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
                        "INNER JOIN Usuario ON Usuario.username = Cita.username"
    Dim condicion As String

    Private Sub cargarFecha()
        Dim fecMin As DateTime = New DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, 0, 0, 0)
        Dim fecMax As DateTime = New DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, 23, 59, 59)

        condicion = "WHERE fecha BETWEEN '" & fecMin.ToString("dd-MM-yyyy HH:mm:ss") & "' AND '" & fecMax.ToString("dd-MM-yyyy HH:mm:ss") & "' AND estado = 1"
        cargar()
    End Sub
    Private Sub cargar()
        dgvCitas.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvCitas.Refresh()
    End Sub

    Private Sub vetAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarFecha()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        chkTodo.Checked = False
        chkCompletas.Checked = False
        cargarFecha()
    End Sub

    Private Sub dgvCitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellDoubleClick
        For Each celda As DataGridViewRow In dgvCitas.SelectedRows
            Dim paciente As String = con.consultaExistente("nombre", "Paciente", "idPaciente='" & celda.Cells(1).Value.ToString() & "'")
                Dim respuesta As Integer = MessageBox.Show("Desea cambiar el estado del la cita del paciente: " & paciente & "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuesta = 6 Then
                If con.actualizar("Cita", "estado = 2", "idPaciente='" & celda.Cells(1).Value.ToString() & "' AND fechaCrea='" & DateTime.Parse(celda.Cells(0).Value.ToString()).ToString("dd-MM-yyyy") & "' AND fecha='" & DateTime.Parse(celda.Cells(3).Value.ToString()).ToString("dd-MM-yyyy HH:mm:ss") & "'") > 0 Then
                    MessageBox.Show("Cita marcada como atendida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargar()
                End If
                End If
        Next
    End Sub

    Private Sub chkTodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodo.CheckedChanged
        If chkTodo.Checked Then
            chkCompletas.Checked = False
            condicion = "WHERE estado = 1"
            cargar()
        Else
            cargarFecha()
        End If
    End Sub

    Private Sub chkCompletas_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompletas.CheckedChanged
        If chkCompletas.Checked Then
            chkTodo.Checked = False
            condicion = "WHERE estado = 2"
            cargar()
        Else
            cargarFecha()
        End If
    End Sub
End Class