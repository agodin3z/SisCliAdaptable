Public Class vetAgenda
    Dim connection As New cConexion
    Dim tabla As String = "Cita"
    'campos a llamar, idPaciente, Nombre del paciente, creacion de la cita, hora, motivo y usuario
    Dim campos As String = "Cita.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Cita.fechaCrea AS 'Fecha de Creacion', Cita.hora AS 'Hora de la cita'," & "Cita.motivo AS 'Motivo de la cita'," &
    "Usuario.nombre AS 'Encargado'"
    'Uniendo las tablas de Paciente y Usuario para llamar los datos del nombre del paciente y el usuario
    Dim join As String = "INNER JOIN Paciente ON Paciente.idPaciente = Cita.idPaciente " &
        "INNER JOIN Usuario ON Usuario.username = Cita.username"
    Dim condicion As String

    Private Sub vetAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condicion = "WHERE fecha ='" & dtpFecha.Value.ToString("MM-dd-yyyy") & "'"
        'El formato de la fecha ira en Meses/Dias/Años para no tener problemas con el tipo Date de la db
        dgvCitas.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvCitas.Refresh()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        condicion = "WHERE fecha ='" & dtpFecha.Value.ToString("MM-dd-yyyy") & "'"
        'El formato de la fecha ira en Meses/Dias/Años para no tener problemas con el tipo Date de la db
        dgvCitas.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvCitas.Refresh()
    End Sub
End Class