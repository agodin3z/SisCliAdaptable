Public Class medHistoConsulta
    Dim con As New cConexion
    Dim tabla As String = "ConsultaGral"

    Dim campos As String = "ConsultaGral.idPaciente AS 'Codigo del Paciente', (Paciente.priNombre + ' ' + Paciente.priApellido) AS 'Nombre del Paciente'," &
    "ConsultaGral.fecha AS 'Fecha de Creacion', ConsultaGral.hora AS 'Hora de la cita'," & "ConsultaGral.motivoConsulta AS 'Motivo de la Consulta'," &
    "(Usuario.titulo + ' ' + Usuario.nombre) AS 'Encargado'"

    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = ConsultaGral.idPaciente " &
        "INNER JOIN Usuario ON Usuario.username = ConsultaGral.username"

    Private Sub cargar(ByVal condicion As String)
        dgvConsultas.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvConsultas.Refresh()
    End Sub

    Private Sub inicio()
        limpiar()
        consulta()
    End Sub
    Private Sub consulta()
        Dim condicion As String = "WHERE ConsultaGral.fecha BETWEEN '" & dtpFechaInicio.Value.ToString("dd-MM-yyyy") & "' AND '" & dtpFechaFin.Value.ToString("dd-MM-yyyy") & "' AND Paciente.idPaciente LIKE '" &
            txtBusqueda.Text.Trim & "%'"
        cargar(condicion)
    End Sub

    Private Sub limpiar()
        txtBusqueda.Clear()
        dtpFechaInicio.Value = Now.ToString("dd-MM-yyyy 00:00:00")
        dtpFechaFin.Value = Now.ToString("dd-MM-yyyy 23:59:59")
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox4)
    End Sub

    Private Sub medHistoConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try

            If dgvConsultas.SelectedRows.Count <= 0 Then
                MessageBox.Show("No ha seleccionado una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else

                TabControl1.SelectTab(1)
                TabControl2.SelectTab(0)

                Dim paciente As String = ""
                For Each celda As DataGridViewRow In dgvConsultas.SelectedRows
                    paciente = celda.Cells(0).Value.ToString
                    txtPaciente.Text = celda.Cells(1).Value.ToString
                    txtMedico.Text = celda.Cells(5).Value.ToString
                    txtFecha.Text = celda.Cells(2).Value.ToString
                    txtHora.Text = celda.Cells(3).Value.ToString
                Next

                Dim dt As DataTable = con.consultaCondicionada("ConsultaGral", "idPaciente='" & paciente & "' AND fecha='" & DateTime.Parse(txtFecha.Text).ToString("dd-MM-yyyy") & "' AND hora='" & DateTime.Parse(txtHora.Text).ToString("HH:mm:ss") & "'")

                txtRazon.Text = dt.Rows(0)("motivoConsulta").ToString
                txtSintomas.Text = dt.Rows(0)("sintomas").ToString
                txtDiagnostico.Text = dt.Rows(0)("diagnostico").ToString
                txtObservaciones.Text = dt.Rows(0)("observaciones").ToString
                txtTratamiento.Text = dt.Rows(0)("tratamiento").ToString
                txtPresionMax.Text = dt.Rows(0)("presionMax").ToString
                txtPresionMin.Text = dt.Rows(0)("presionMin").ToString
                txtTemp.Text = dt.Rows(0)("temp").ToString
                txtPesoKg.Text = dt.Rows(0)("peso").ToString
                txtPulso.Text = dt.Rows(0)("pulso").ToString
                txtEstatura.Text = dt.Rows(0)("estatura").ToString
                txtResp.Text = dt.Rows(0)("respiracion").ToString
                txtObservacionesSignos.Text = dt.Rows(0)("observacionSignos").ToString

                txtIMC.Text = Double.Parse(txtPesoKg.Text) / Math.Pow(Double.Parse(txtEstatura.Text), 2)
                txtPeso.Text = Double.Parse(txtPesoKg.Text) / 0.453592
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Consulta()
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged, dtpFechaFin.ValueChanged
        If dtpFechaInicio.Value < dtpFechaFin.Value Then
            consulta()
        Else
            MessageBox.Show("La fecha de fin no puede ser menor que la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpFechaFin.Value = Now
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        cGenerica.limpiarTextbox(GroupBox3)
        cGenerica.limpiarTextbox(GroupBox4)
        cGenerica.limpiarTextbox(GroupBox2)
    End Sub
End Class