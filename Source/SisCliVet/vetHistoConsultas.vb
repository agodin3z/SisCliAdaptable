Public Class vetHistoConsultas
    Dim con As New cConexion

    Private Sub limpiar()
        txtBusqueda.Clear()
        dtpInicio.Value = Now.ToString("dd-MM-yyyy 00:00:00")
        dtpFin.Value = Now.ToString("dd-MM-yyyy 23:59:59")
        cGenerica.limpiarTextbox(GroupBox3)
    End Sub

    Private Sub Consulta()
        Dim campos As String = "ConsultaGral.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
        "(Propietario.priNombre + ' ' + Propietario.priApellido) AS 'Nombre del propietario', ConsultaGral.fecha AS 'Hora de la cita'," &
        "ConsultaGral.razonConsulta AS 'Motivo de la Consulta', (Usuario.titulo + ' ' + Usuario.nombre) AS 'Encargado'"

        Dim join As String = " INNER JOIN Paciente ON Paciente.idPaciente = ConsultaGral.idPaciente " &
            " INNER JOIN Usuario ON Usuario.username = ConsultaGral.username" &
            " INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

        Dim condicion As String = "WHERE ConsultaGral.fecha BETWEEN '" & dtpInicio.Value.ToString("dd-MM-yyyy") & "' AND '" &
            dtpFin.Value.ToString("dd-MM-yyyy") & "' AND Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"

        dgvConsultas.DataSource = con.consultaCondicionada(campos, "ConsultaGral", join, condicion)
        dgvConsultas.Refresh()
    End Sub

    Private Sub vetHistoConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try

            If dgvConsultas.SelectedRows.Count <= 0 Then
                MessageBox.Show("No ha seleccionado una usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                TabControl1.SelectTab(1)
                Dim fecha As DateTime
                Dim paciente As String = ""

                For Each celda As DataGridViewRow In dgvConsultas.SelectedRows
                    paciente = celda.Cells(0).Value.ToString
                    txtPaciente.Text = celda.Cells(1).Value.ToString
                    txtPropietario.Text = celda.Cells(2).Value.ToString
                    txtMedico.Text = celda.Cells(5).Value.ToString
                    fecha = celda.Cells(3).Value.ToString
                    txtFecha.Text = fecha.ToString("dd-MM-yyyy HH:mm:ss")
                Next

                Dim dt As DataTable = con.consultaCondicionada("ConsultaGral", "idPaciente='" & paciente & "' AND fecha='" & fecha.ToString("dd-MM-yyyy HH:mm:ss") & "'")
                txtRazon.Text = dt.Rows(0)("razonConsulta").ToString
                txtSintomas.Text = dt.Rows(0)("sintomas").ToString
                txtDiagnostico.Text = dt.Rows(0)("diagnostico").ToString
                txtObservaciones.Text = dt.Rows(0)("observaciones").ToString
                txtTratamiento.Text = dt.Rows(0)("tratamiento").ToString

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Consulta()
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicio.ValueChanged, dtpFin.ValueChanged
        If dtpInicio.Value < dtpFin.Value Then
            Consulta()
        Else
            MessageBox.Show("La fecha de fin no puede ser menor que la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpFin.Value = Now
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        cGenerica.limpiarTextbox(GroupBox3)
    End Sub
End Class