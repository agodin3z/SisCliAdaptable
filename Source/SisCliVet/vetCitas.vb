Public Class vetCitas
    Dim connection As New cConexion
    Dim tabla As String = "Paciente"
    'Campos del dgv: Codigo del paciente, su nombre, codigo del propietario, primer nombre y apellido
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Propietario.idPropietario AS 'Codigo del Propietario', Propietario.priNombre AS 'Nombre del Propietario'," &
    "Propietario.priApellido AS 'Apellido del Propietario'"
    'Uniendo la tabla de Propietario para poder llamar el primer nombre y apellido
    Dim join As String = "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"
    Dim paciente As String
    Dim propietario As String
    Dim condicion As String

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

        TabControl1.SelectTab(1)
        'Tomando el dato de la fila seleccionada para llenar el otro tab
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            propietario = celda.Cells(2).Value.ToString
            txtPropietario.Text = celda.Cells(3).Value.ToString & " " & celda.Cells(4).Value.ToString
        Next
        btnGuardar.Enabled = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String = "(fechaCrea, horaCrea, motivo, fecha, hora, idPaciente, username, estado)"
        Dim fechaProx As String = dtpFechaSiguiente.Value.ToString("MM-dd-yyyy")
        Dim horaProx As String = dtpHoraSiguiente.Value.ToString("HH:mm:ss")
        Dim fecha As String = Now.ToString("MM-dd-yyyy")
        Dim hora As String = Now.ToString("HH:mm:ss")
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
        Dim estado As String = ""

        If rdbOtro.Checked And motivo.Length = 0 Then
            MessageBox.Show("No ha ingresado el otro motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf motivo.Length = 0 Then
            MessageBox.Show("Ingrese el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'No se que incluira estado pero ya esta una variable para que se pueda ingresar a la bd
        Dim valores = "'" & fecha & "','" & hora & "','" & motivo & "','" & fechaProx & "','" &
            horaProx & "','" & paciente & "','" & vetPRINCIPAL.stUsuario.Text & "','" & estado & "'"

        If connection.InsertarFila("Cita", "", valores) > 0 Then
            MessageBox.Show("Cita creada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub vetCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, "")
        dgvPacientes.Refresh()
    End Sub

    Private Sub rdbOtro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOtro.CheckedChanged
        If rdbOtro.Checked Then
            txtOtro.Enabled = True
        Else
            txtOtro.Enabled = False
        End If

    End Sub
End Class