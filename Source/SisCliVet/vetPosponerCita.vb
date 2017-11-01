Public Class vetPosponerCita
    Dim con As New cConexion
    Dim paciente As String = ""
    Dim fecha As String, fec As Date
    Dim hora As String

    Private Sub limpiar()
        txtOtro.Clear()
        txtPaciente.Clear()
        txtPropietario.Clear()
        rdbConsulta.Checked = False
        rdbOtro.Checked = False
        rdbPeluqueria.Checked = False
        rdbRefuerzo.Checked = False
    End Sub

    Private Sub cargar()
        Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente', (Propietario.priNombre + ' ' +  Propietario.priApellido) AS 'Propietario'," &
                                "Cita.fecha AS 'Fecha de la Cita'," &
                                " Cita.motivo AS 'Motivo', Usuario.nombre AS 'Encargado', " &
                                "Cita.fechaCrea AS 'Fecha de Creación', Cita.horaCrea AS 'Hora de Creación'"

        Dim join As String = " INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
                            "INNER JOIN Usuario ON Usuario.username = Cita.username" &
                            " INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario "
        Dim condicion As String = "WHERE estado = 1"

        dgvCitas.DataSource = con.consultaCondicionada(campos, "Cita", join, condicion)
        dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvCitas.Refresh()
    End Sub

    Private Sub vetPosponerCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        TabPage2.Parent = Nothing
    End Sub

    Private Sub dgvCitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellDoubleClick
        Dim motivo As String
        TabPage2.Parent = Me.TabControl1
        TabControl1.SelectTab(1)
        'Tomando el dato de la fila seleccionada para llenar el otro tab
        For Each celda As DataGridViewRow In dgvCitas.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            txtPropietario.Text = celda.Cells(2).Value.ToString
            fec = DateTime.Parse(celda.Cells(3).Value).ToString("MM-dd-yyyy HH:mm:ss")
            dtpFechaSiguiente.Value = fec
            motivo = celda.Cells(4).Value.ToString
            fecha = CType(celda.Cells(6).Value, Date).ToString("MM-dd-yyyy")
            hora = DateTime.Parse(celda.Cells(7).Value.ToString()).ToString("HH:mm:ss")

            If motivo = "Consulta General" Then
                rdbConsulta.Checked = True
            ElseIf motivo = "Peluqueria" Then
                rdbPeluqueria.Checked = True
            ElseIf motivo = "Refuerzo" Then
                rdbRefuerzo.Checked = True
            Else
                rdbOtro.Checked = True
                txtOtro.Text = motivo
            End If
        Next
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fechaProx As String = dtpFechaSiguiente.Value.ToString("MM-dd-yyyy HH:mm:ss")
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
            MessageBox.Show("No ha ingresado el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf motivo.Length = 0 Then
            MessageBox.Show("Ingrese el motivo de la cita", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nVals = " motivo ='" & motivo & "', fecha='" & fechaProx & "', username='" & cGenerica.usr & "'"

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
        If dtpFechaSiguiente.Value < fec And dtpFechaSiguiente.Value < Date.Now Then
            MessageBox.Show("No puede crear una cita para tiempo pasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpFechaSiguiente.Value = fec.AddMinutes(1)
        End If
    End Sub

    Private Sub rdbOtro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOtro.CheckedChanged
        If rdbOtro.Checked Then
            txtOtro.Enabled = True
        Else
            txtOtro.Enabled = False
        End If
    End Sub

    'Validacion
    Private Sub txtOtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtro.KeyPress
        cGenerica.SoloTexto(txtOtro, e)
    End Sub
End Class