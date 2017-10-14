Public Class vetUpdtPaciente
    Dim connection As New cConexion
    Dim tabla As String = "Paciente"
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del paciente', Paciente.nombre AS 'Nombre del paciente'," &
        "Especie.nombre As 'Especie', Paciente.sexo AS 'Sexo' , Paciente.Raza AS Raza, Paciente.rasgoDist AS Rasgos," &
        "Paciente.fechaNac AS 'Fecha de Nacimiento', Propietario.idPropietario AS 'Codigo del propietario', " &
        "Propietario.priNombre AS 'Nombre del propietario', Propietario.priApellido AS 'Nombre del propietario'"
    Dim join As String = "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie " &
        "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim condicion As String
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub vetUpdtPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim condicion As String
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub
End Class