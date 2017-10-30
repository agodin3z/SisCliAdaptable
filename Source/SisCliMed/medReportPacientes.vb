Public Class medReportPacientes
    Dim con As New cConexion

    Private Sub cargar(ByVal condicion As String)
        Dim campos As String = "idPaciente AS 'Codigo del Paciente', (priNombre + ' ' + priApellido)  AS 'Nombre del Paciente'," &
                        "genero AS 'Genero', fechaNac AS 'Fecha de nacimiento'"
        dgvPacientes.DataSource = con.consultaCondicionada(campos, "Paciente", "", condicion)
        dgvPacientes.Refresh()
    End Sub
    Private Sub medReportPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE priNombre LIKE '" & txtBusqueda.Text.Trim & "%' OR priApellido LIKE '" & txtBusqueda.Text.Trim & "%' OR idPaciente LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            Dim paciente As String = ""
            TabControl1.SelectTab(1)

            'Tomando el dato de la fila seleccionada para llenar el otro tab
            For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
                paciente = celda.Cells(0).Value.ToString
            Next

            Dim dt As DataTable = con.consultaCondicionada("Paciente", "idPaciente='" & paciente & "'")

            txtNombre.Text = dt.Rows(0)("priNombre").ToString & " " & dt.Rows(0)("segNombre").ToString & " " & dt.Rows(0)("priApellido").ToString & " " & dt.Rows(0)("segApellido").ToString
            txtDui.Text = dt.Rows(0)("dui").ToString
            txtEstadoCivil.Text = dt.Rows(0)("estadoCivil").ToString
            txtGenero.Text = dt.Rows(0)("genero").ToString
            txtFechaNac.Text = dt.Rows(0)("fechaNac").ToString
            txtDireccion.Text = dt.Rows(0)("direccion").ToString
            txtTelFijo.Text = dt.Rows(0)("telFijo").ToString
            txtTelMovil.Text = dt.Rows(0)("telMovil").ToString

            Dim dt2 As DataTable = con.consultaCondicionada("NumEmergencia", "idPaciente='" & paciente & "'")
            If dt2.Rows.Count > 0 Then
                txtEmergencia1.Text = dt2.Rows(0)("nomEmergencia").ToString
                txtTelEmergencia1.Text = dt2.Rows(0)("telEmergencia").ToString
                If dt2.Rows.Count > 1 Then
                    txtEmergencia2.Text = dt2.Rows(1)("nomEmergencia").ToString
                    txtTelEmergencia2.Text = dt2.Rows(1)("telEmergencia").ToString
                End If
            End If

            Dim camps As String = "ConsultaGral.idPaciente AS 'Codigo del Paciente', (Paciente.priNombre + ' ' + Paciente.priApellido) AS 'Nombre del Paciente'," &
                    "ConsultaGral.fecha AS 'Día de la cita'," & "ConsultaGral.motivoConsulta AS 'Motivo de la Consulta'," &
                    "(Usuario.titulo + ' ' + Usuario.nombre) AS 'Encargado'"
            'Uniendo las tablas de Paciente para el id y Usuario para el nombre de usuario
            Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = ConsultaGral.idPaciente " &
                "INNER JOIN Usuario ON Usuario.username = ConsultaGral.username"
            dgvConsultas.DataSource = con.consultaCondicionada(camps, "ConsultaGral", join, "WHERE ConsultaGral.idPaciente='" & paciente & "'")
            dgvConsultas.Refresh()

        Else
            MessageBox.Show("Debe de seleccionar a un paciente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        cGenerica.limpiarTextbox(GroupBox2)
        cGenerica.limpiarTextbox(GroupBox5)
        dgvConsultas.DataSource = Nothing
    End Sub
End Class