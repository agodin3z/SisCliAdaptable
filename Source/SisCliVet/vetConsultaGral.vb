Public Class vetConsultaGral
    Dim con As New cConexion
    Dim paciente As String = ""
    Dim cita As DateTime

    Private Sub cargar(ByVal condicion As String)
        Dim tabla As String = "Cita"
        Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
        "Cita.fechaCrea AS 'Fecha de Creacion', Cita.fecha AS 'Hora de la cita'," & "Cita.motivo AS 'Motivo de la cita'," &
        "Usuario.nombre AS 'Encargado'"
        Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
            "INNER JOIN Usuario ON Usuario.username = Cita.username"

        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, Join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub btnVacunas_Click(sender As Object, e As EventArgs) Handles btnVacunas.Click
        Dim f As New vetCtrlVacuna
        cGenerica.ShowDlg(f, Me)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Dato para usar luego en el insert'
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            cita = celda.Cells(3).Value
        Next
        TabControl1.SelectTab(1)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim razon As String = txtRazon.Text.Trim
        Dim sintomas As String = txtSintomas.Text.Trim
        Dim diagnostico As String = txtDiagnostico.Text.Trim
        Dim observacion As String = txtObservaciones.Text.Trim
        Dim tratamiento As String = txtTratamiento.Text.Trim
        Dim proxFecha As String = dtpFechaSiguiente.Value.ToString("dd-MM-yyyy HH:mm:ss")
        Dim valores As String = "'" & paciente & "','" & razon & "','" & sintomas & "','" & diagnostico & "','" & observacion & "','" &
            tratamiento & "','" & proxFecha & "','" & cGenerica.usr & "'"

        If DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If con.insertar("ConsultaGral", valores) > 0 Then
            MessageBox.Show("Consulta ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.actualizar("Cita", "estado=2", "idPaciente='" & paciente & "' AND fecha='" & cita.ToString("dd-MM-yyyy HH:mm:ss") & "'")
            con.insertar("Cita", "'" & Now.ToString("dd-MM-yyyy") & "','" & Now.ToString("HH:mm:ss") & "','" & "Consulta General" & "','" & dtpFechaSiguiente.Value.ToString("dd-MM-yyyy HH:mm:ss") & "','" & paciente & "','" & cGenerica.usr & "',1")
            cGenerica.limpiarTextbox(GroupBox1)
            cGenerica.limpiarTextbox(GroupBox3)
            cargar("WHERE estado=1")
            TabControl1.SelectTab(0)
        Else
            MessageBox.Show("Problema ingresando la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cGenerica.limpiarTextbox(GroupBox1)
        cGenerica.limpiarTextbox(GroupBox3)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub vetConsultaGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("WHERE estado=1")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        cGenerica.ShowDlg(vetReporteReceta, Me)
    End Sub
End Class