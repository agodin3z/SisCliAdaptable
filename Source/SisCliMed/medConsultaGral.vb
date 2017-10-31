Public Class medConsultaGral
    Dim con As New cConexion
    Dim tabla As String = "Cita"

    Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', (Paciente.priNombre + ' ' + Paciente.priApellido) AS 'Nombre del Paciente'," &
    "Cita.fechaCrea AS 'Fecha de Creacion', Cita.fecha AS 'Hora de la cita'," & "Cita.motivo AS 'Motivo de la cita'," &
    "(Usuario.titulo + ' ' + Usuario.nombre) AS 'Encargado'"

    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
        "INNER JOIN Usuario ON Usuario.username = Cita.username"

    Dim paciente As String = ""
    Dim cita As DateTime

    Private Sub cargar(ByVal condicion As String)
        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub inicio()
        cargar("WHERE estado=1")
        TabPage3.Parent = Nothing
        TabPage1.Parent = Me.TabControl1
    End Sub

    Private Sub medConsultaGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.priNombre LIKE '" & txtBusqueda.Text.Trim & "%' OR Paciente.priApellido LIKE '" & txtBusqueda.Text.Trim & "%' OR Paciente.idPaciente LIKE '" & txtBusqueda.Text.Trim & "%' AND estado=1")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            txtPacienteReceta.Text = celda.Cells(1).Value.ToString
            cita = celda.Cells(3).Value
            txtMotivo.Text = celda.Cells(4).Value
            txtMedicoReceta.Text = celda.Cells(5).Value
        Next
        txtFecha.Text = Now.ToString("dd-MM-yyyy")
        txtFechaReceta.Text = Now.ToString("dd-MM-yyyy")
        TabPage3.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        TabControl2.SelectTab(0)
        TabPage1.Parent = Nothing
    End Sub

    Private Sub txtTratamiento_TextChanged(sender As Object, e As EventArgs) Handles txtTratamiento.TextChanged
        txtMedicamentoReceta.Text = txtTratamiento.Text
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtDiagnostico.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe de registrar el diagnostico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDiagnostico.Focus()
            Exit Sub
        ElseIf DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpFechaSiguiente.Focus()
            Exit Sub
        ElseIf txtMotivo.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe de ingresar el motivo de la consula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMotivo.Focus()
            Exit Sub
        End If

        Dim valores = "'" & paciente & "','" & cGenerica.usr & "','" & txtMotivo.Text.Trim & "','" & txtSintomas.Text.Trim & "','" &
                txtDiagnostico.Text.Trim & "','" & txtObservaciones.Text.Trim & "','" & txtTratamiento.Text.Trim & "','" &
                Now.ToString("dd-MM-yyyy") & "','" & Now.ToString("HH:mm:ss") & "','" & nudPresionMax.Value & "','" &
                nudPresionMin.Value & "','" & nudTemp.Value & "','" & nudEstatura.Value & "','" & nudPeso.Value & "','" &
                nudPulso.Value & "','" & nudRespiracion.Value & "','" & txtObservacionesSignos.Text.Trim & "'"

        If con.insertar("ConsultaGral", valores) > 0 Then
            MessageBox.Show("Consulta registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.actualizar("Cita", "estado=2", "idPaciente='" & paciente & "' AND fecha='" & cita.ToString("dd-MM-yyyy HH:mm:ss") & "'")

            Dim vals = "'" & Now.ToString("dd-MM-yyyy") & "','" & Now.ToString("HH:mm:ss") & "',' Seguimiento: " &
                        txtMotivo.Text.Trim & "','" & dtpFechaSiguiente.Value.ToString("dd-MM-yyyy HH:mm:ss") &
                        "','" & paciente & "','" & cGenerica.usr & "',1"
            con.insertar("Cita", vals)
            inicio()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Desea cancelar la consulta del paciente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = 6 Then
            inicio()
        End If
    End Sub

    Private Sub btnImprimirReceta_Click(sender As Object, e As EventArgs) Handles btnImprimirReceta.Click
        cGenerica.ShowDlg(medReporteReceta, Me)
    End Sub
End Class