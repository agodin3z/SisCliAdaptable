Public Class vetConsultaGral
    Dim connection As New cConexion
    Dim tabla As String = "Cita"
    'Campos: Codigo del Paciente y su nombre, fecha y hora de creacion de la cita, el motivo y el usuario que la creo 
    Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Cita.fechaCrea AS 'Fecha de Creacion', Cita.fecha AS 'Hora de la cita'," & "Cita.motivo AS 'Motivo de la cita'," &
    "Usuario.nombre AS 'Encargado'"
    'Uniendo las tablas de Paciente para el id y Usuario para el nombre de usuario
    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
        "INNER JOIN Usuario ON Usuario.username = Cita.username"
    Dim condicion As String
    Dim fila As String = ""
    Dim usuario As String = vetPRINCIPAL.stUsuario.Text

    Private Sub cargar()
        dgvPacientes.DataSource = connection.consultaCondicionada(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub btnVacunas_Click(sender As Object, e As EventArgs) Handles btnVacunas.Click
        cGenerica.ShowDlg(vetCtrlVacuna, Me) 'Deberia enviar datos a segunda pestaña
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        cargar()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Dato para usar luego en el insert'
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            fila = celda.Cells(0).Value.ToString
        Next
        TabControl1.SelectTab(1)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim razon As String = txtRazon.Text.Trim
        Dim sintomas As String = txtSintomas.Text.Trim
        Dim diagnostico As String = txtDiagnostico.Text.Trim
        Dim observacion As String = txtObservaciones.Text.Trim
        Dim tratamiento As String = txtTratamiento.Text.Trim
        Dim procedimiento As String = txtProcedimiento.Text.Trim
        Dim proxFecha As String = dtpFechaSiguiente.Value.ToString("MM-dd-yyyy")
        Dim proxHora As String = dtpHoraSiguiente.Value.ToString("HH:mm:ss")
        Dim campos As String = "(idPaciente, razonConsulta, sintomas, diagnostico, observaciones, tratamiento, fecha, hora, username)"
        Dim valores As String
        valores = "'" & fila & "','" & razon & "','" & sintomas & "','" & diagnostico & "','" & observacion & "','" &
            tratamiento & "','" & proxFecha & "','" & proxHora & "','" & usuario & "'"
        MessageBox.Show(valores)
        If DateDiff(DateInterval.Day, Date.Now, dtpFechaSiguiente.Value) <= 0 Then
            MessageBox.Show("Ingrese una fecha con al menos 1 dia de anticipacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If connection.insertar("ConsultaGral", campos, valores) > 0 Then
            MessageBox.Show("Consulta ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cGenerica.limpiarTextbox(GroupBox1)
            cGenerica.limpiarTextbox(GroupBox3)
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
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        cargar()
    End Sub
End Class