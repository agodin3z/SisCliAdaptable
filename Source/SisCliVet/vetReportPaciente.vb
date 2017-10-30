Public Class vetReportPaciente
    Dim con As New cConexion

    Private Sub llenarVacunas(ByVal Ctrl As Windows.Forms.ListBox, ByVal tabla As String, ByVal condicion As String, ByVal identificacion As String, ByVal nombre As String)
        Ctrl.DataSource = con.consultaCondicionada(tabla, condicion)
        Ctrl.ValueMember = identificacion
        Ctrl.DisplayMember = nombre
    End Sub

    Private Sub cargar(ByVal sql As String)
        Dim campos As String = "Paciente.idPaciente AS 'Codigo del paciente', Paciente.nombre AS 'Nombre del paciente'," &
        "Especie.nombre As 'Especie', Paciente.sexo AS 'Sexo' , Paciente.Raza AS Raza, " &
        " Propietario.idPropietario AS 'Codigo del propietario', " &
        "(Propietario.priNombre + ' ' + Propietario.priApellido) AS 'Nombre del propietario'"

        Dim join As String = "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie " &
            "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario"

        dgvPacientes.DataSource = con.consultaCondicionada(campos, "Paciente", join, sql)
        dgvPacientes.Refresh()
    End Sub

    Private Sub llenarTabla(ByVal ctrl As DataGridView, ByVal campos As String, ByVal tabla As String, ByVal join As String, ByVal condicion As String)
        ctrl.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        ctrl.Refresh()
    End Sub

    Private Sub vetReportPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Tomando el dato de la fila seleccionada para llenar los otros tab
        TabControl1.SelectTab(1)
        TabControl2.SelectTab(0)

        Dim dt As DataTable = con.consultaCondicionada("Paciente", " idPaciente='" & dgvPacientes.SelectedRows().Item(0).Cells(0).Value & "'")
        txtCodPaciente.Text = dt.Rows(0)("idPaciente").ToString
        txtNombre.Text = dt.Rows(0)("nombre").ToString
        txtEspecie.Text = con.consultaExistente("nombre", "Especie", "idEspecie=" & dt.Rows(0)("idEspecie").ToString)
        llenarVacunas(lstVacunas, "Vacuna_Paciente", "idPaciente = '" & dt.Rows(0)("idPaciente").ToString & "'", "idVacuna", "nombre")
        txtSexo.Text = dt.Rows(0)("sexo")
        txtRaza.Text = dt.Rows(0)("raza").ToString
        txtColor.Text = dt.Rows(0)("color").ToString
        txtFechaNac.Text = dt.Rows(0)("fechaNac").ToString
        txtPeso.Text = dt.Rows(0)("peso").ToString
        txtEstadoRep.Text = dt.Rows(0)("estadoRep").ToString
        txtRasgos.Text = dt.Rows(0)("rasgoDist").ToString
        Dim ms As New System.IO.MemoryStream(con.selectImg("Paciente", "fotografia", "WHERE idPaciente='" & txtCodPaciente.Text & "'"))
        picFoto.BackgroundImage = Image.FromStream(ms)

        Dim campo = "fecha AS 'Fecha', razonConsulta AS 'Razon de la Consulta', sintomas AS 'Síntomas', diagnostico AS 'Diagnóstico', " &
                    "observaciones AS 'Observaciones', tratamiento AS 'Tratamiento', (titulo + ' ' + nombre) AS 'Atendido por'"
        Dim innerjoin = "INNER JOIN Usuario ON ConsultaGral.username = Usuario.username"
        Dim where = "WHERE idPaciente ='" & txtCodPaciente.Text & "'"
        llenarTabla(dgvConsultas, campo, "ConsultaGral", innerjoin, where)

        Dim campo2 = "fecha AS 'Fecha', Vacuna.nombre AS 'Vacuna'"
        Dim innerjoin2 = "INNER JOIN Vacuna ON Vacuna_Paciente.idVacuna = Vacuna.idVacuna"
        Dim where2 = "WHERE idPaciente ='" & txtCodPaciente.Text & "'"

        llenarTabla(dgvVacunas, campo2, "Vacuna_Paciente", innerjoin2, where2)
        
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%' OR Paciente.idPaciente LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        cGenerica.limpiarTextbox(GroupBox2)
        lstVacunas.DataSource = Nothing
        dgvConsultas.DataSource = Nothing
        dgvVacunas.DataSource = Nothing
        picFoto.BackgroundImage = Nothing
    End Sub
End Class