﻿Public Class vetHistoConsultas
    Dim connection As New cConexion
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
    Private Sub Consulta()
        Dim fechaInicio As String = dtpInicio.Value.ToString("MM-dd-yyyy")
        Dim fechaFin As String = dtpFin.Value.ToString("MM-dd-yyyy")
        paciente = txtBusqueda.Text.Trim
        condicion = "WHERE Cita.fecha BETWEEN '" & fechaInicio & "' AND '" & fechaFin & "' OR Paciente.nombre LIKE '" &
            paciente & "&'"
        dgvConsultas.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvConsultas.Refresh()
    End Sub

    Private Sub vetHistoConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consulta()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtBusqueda.Clear()
        dtpInicio.Value = Now
        dtpFin.Value = Now
        For Each control As Control In GroupBox3.Controls
            If TypeOf control Is Windows.Forms.TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

        If dgvConsultas.SelectedRows.Count <= 0 Then
            MessageBox.Show("No ha seleccionado una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim condicion2 As String
            Dim campos2 As String
            Dim join2 As String
            For Each celda As DataGridViewRow In dgvConsultas.SelectedRows
                fila = celda.Cells(0).Value.ToString
                txtPropietario.Text = celda.Cells(2).Value.ToString & " " & celda.Cells(3).Value.ToString
                txtPaciente.Text = celda.Cells(1).Value.ToString
                txtMedico.Text = celda.Cells(6).Value.ToString
                fecha = celda.Cells(5).Value.ToString
                txtFecha.Text = fecha.ToString("MM-dd-yyyy")
            Next

            'Creando una consulta condicionada para poder buscar por la fecha de la cita
            campos2 = "ConsultaGral.razonConsulta, ConsultaGral.sintomas, ConsultaGral.diagnostico," &
                "ConsultaGral.observaciones, ConsultaGral.tratamiento, Cita.fecha"
            'Uniendo la tabla cita con la que se buscara en la condicion
            join2 = "INNER JOIN Cita ON Cita.idPaciente = ConsultaGral.idPaciente"
            condicion2 = "WHERE ConsultaGral.idPaciente='" & fila & "' AND Cita.fecha='" & fecha.ToString("MM-dd-yyyy") & "'"
            'Usando un DataTable con los datos de la bd y llenando campos por el orden del select 
            datos = connection.consultaCondicionadas(campos2, "ConsultaGral", join2, condicion2)
            txtRazon.Text = datos.Rows(0).Item(0).ToString
            txtSintomas.Text = datos.Rows(0).Item(1).ToString
            txtDiagnostico.Text = datos.Rows(0).Item(2).ToString
            txtObservaciones.Text = datos.Rows(0).Item(3).ToString
            txtTratamiento.Text = datos.Rows(0).Item(4).ToString
            TabControl1.SelectTab(1)
        End If

       
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Consulta()
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicio.ValueChanged
        If dtpInicio.Value < dtpFin.Value Then
            Consulta()
        Else
            MessageBox.Show("La fecha de fin no puede ser menor que la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtpFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFin.ValueChanged
        If dtpInicio.Value < dtpFin.Value Then
            Consulta()
        Else
            MessageBox.Show("La fecha de fin no puede ser menor que la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class