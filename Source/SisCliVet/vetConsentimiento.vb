Public Class vetConsentimiento
    Dim connection As New cConexion
    Dim tabla As String = "Paciente"
    'Campos: Codigo de paciente, Nombre de paciente, Codigo de propietario, Primer nombre y apellido
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Propietario.idPropietario AS 'Codigo del Propietario', Propietario.priNombre AS 'Nombre del Propietario'," &
    "Propietario.priApellido AS 'Apellido del Propietario'"
    'Uniendo con la tabla de Propietario para el primer nombre y apellido
    Dim join As String = "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"
    Dim paciente As String
    Dim fila As String
    Dim condicion As String

    Private Sub cargar()
        dgvPacientes.DataSource = connection.consultaCondicionada(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        cargar()
    End Sub

    Private Sub vetConsentimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Now.ToString("MM-dd-yyyy")
        txtHora.Text = Now.ToString("HH:mm:ss")
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        cargar()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Sacando el id del paciente para luego poder usarlo en el insert
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            fila = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim paciente As String = txtPaciente.Text.Trim
        Dim carta As String = txtCarta.Text.Trim
        Dim tipoCarta As String = ""
        If rdbCirugia.Checked Then
            tipoCarta = "Cirugia"
        ElseIf rdbHospedaje.Checked Then
            tipoCarta = "Hospedaje"
        ElseIf rdbHospitalizacion.Checked Then
            tipoCarta = "Hospitalizacion"
        End If

        If paciente.Length = 0 Then
            MessageBox.Show("No ha seleccionado al paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf carta.Length = 0 Then
            MessageBox.Show("No ha seleccionado el archivo de la carta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf tipoCarta.Length = 0 Then
            MessageBox.Show("No se ha seleccionado el tipo de carta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
End Class