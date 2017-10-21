Public Class vetUpdtPaciente
    Dim con As New cConexion
    Dim tabla As String = "Paciente"
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del paciente', Paciente.nombre AS 'Nombre del paciente'," &
        "Especie.nombre As 'Especie', Paciente.sexo AS 'Sexo' , Paciente.Raza AS Raza, Paciente.rasgoDist AS Rasgos," &
        "Paciente.fechaNac AS 'Fecha de Nacimiento', Propietario.idPropietario AS 'Codigo del propietario', " &
        "Propietario.priNombre AS 'Nombre del propietario', Propietario.priApellido AS 'Nombre del propietario'"
    Dim join As String = "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie " &
        "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

    Private Sub cargar(ByVal sql As String)
        dgvPacientes.DataSource = con.consultaCondicionada(campos, tabla, join, sql)
        dgvPacientes.Refresh()
    End Sub

    Private Sub vetUpdtPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim condicion As String = ""
        cargar(condicion)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim condicion As String = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        cargar(condicion)
    End Sub
End Class