Public Class vetHistoConsultas
    Dim con As New cConexion
    Dim tabla As String = "Cita"
    'Cita: idPaciente, motivo, fecha
    'Paciente: Nombre
    'Propietario: Primer nombre, Primer Apellido
    'Usuario: Nombre
    Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Propietario.priNombre AS 'Nombre del propietario', Propietario.priApellido AS 'Apellido del propietario'," &
    "Cita.motivo AS 'Motivo de la consulta'," & "Cita.fecha AS 'Fecha de la cita'," & "Usuario.nombre AS 'Encargado'"
    'Uniendo las tablas de Paciente y Usuario para llamar los datos del nombre del paciente y el usuario
    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
        "INNER JOIN Usuario ON Usuario.username = Cita.username " &
        "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"
    Dim condicion As String
    Dim paciente As String
    Dim datos As New DataTable
    Dim fecha As Date
    Dim fila As String

    Private Sub limpiar()
        txtBusqueda.Clear()
        dtpInicio.Value = Now.ToString("dd-MM-yyyy 00:00:00")
        dtpFin.Value = Now.ToString("dd-MM-yyyy 23:59:59")
        cGenerica.limpiarTextbox(GroupBox3)
    End Sub
    Private Sub Consulta()
        Dim fechaInicio As String = dtpInicio.Value.ToString("dd-MM-yyyy")
        Dim fechaFin As String = dtpFin.Value.ToString("dd-MM-yyyy")
        paciente = txtBusqueda.Text.Trim
        condicion = "WHERE Cita.fecha BETWEEN '" & fechaInicio & "' AND '" & fechaFin & "' AND Paciente.nombre LIKE '" &
            paciente & "%' AND Cita.estado=2"
        dgvConsultas.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
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
                MessageBox.Show("No ha seleccionado una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim campos2 As String
                Dim join2 As String
                For Each celda As DataGridViewRow In dgvConsultas.SelectedRows
                    fila = celda.Cells(0).Value.ToString
                    txtPropietario.Text = celda.Cells(2).Value.ToString & " " & celda.Cells(3).Value.ToString
                    txtPaciente.Text = celda.Cells(1).Value.ToString
                    txtMedico.Text = celda.Cells(6).Value.ToString
                    fecha = celda.Cells(5).Value.ToString
                    txtFecha.Text = fecha.ToString("dd-MM-yyyy")
                Next

                'Creando una consulta condicionada para poder buscar por la fecha de la cita
                campos2 = "ConsultaGral.razonConsulta, ConsultaGral.sintomas, ConsultaGral.diagnostico," &
                    "ConsultaGral.observaciones, ConsultaGral.tratamiento, Cita.fecha"
                'Uniendo la tabla cita con la que se buscara en la condicion
                join2 = "INNER JOIN Cita ON Cita.idPaciente = ConsultaGral.idPaciente"
                'Dim h = con.consultaExistente("hora", "Cita", "idPaciente='" & fila & "' AND fecha='" & fecha.ToString("dd-MM-yyyy") & "'")
                Dim condicion2 As String = "WHERE ConsultaGral.idPaciente='" & fila & "' AND Cita.fecha='" & fecha.ToString("dd-MM-yyyy HH:mm:ss") & "'" ' AND Cita.hora='" & h & "'"
                'Usando un DataTable con los datos de la bd y llenando campos por el orden del select 
                datos = con.consultaCondicionada(campos2, "ConsultaGral", join2, condicion2)
                txtRazon.Text = datos.Rows(0).Item(0).ToString
                txtSintomas.Text = datos.Rows(0).Item(1).ToString
                txtDiagnostico.Text = datos.Rows(0).Item(2).ToString
                txtObservaciones.Text = datos.Rows(0).Item(3).ToString
                txtTratamiento.Text = datos.Rows(0).Item(4).ToString
                TabControl1.SelectTab(1)
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

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        cGenerica.limpiarTextbox(GroupBox3)
    End Sub

End Class