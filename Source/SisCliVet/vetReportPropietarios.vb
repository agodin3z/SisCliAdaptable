Public Class vetReportPropietarios
    Dim con As New cConexion
    Dim tabla As String = "Propietario"
    Dim campos As String = "idPropietario AS 'Codigo del propietario', priNombre AS 'Nombre', priApellido AS 'Apellido'," &
        "email As 'Email', telMovil AS 'Celular'"
    Dim join As String = ""

    Private Sub cargar(ByVal sql As String)
        dgvPropietarios.DataSource = con.consultaCondicionada(campos, tabla, join, sql)
        dgvPropietarios.Refresh()
    End Sub

    Private Sub llenarTabla(ByVal ctrl As DataGridView, ByVal campos As String, ByVal tabla As String, ByVal join As String, ByVal condicion As String)
        ctrl.DataSource = con.consultaCondicionada(campos, tabla, join, condicion)
        ctrl.Refresh()
    End Sub

    Private Sub vetReportPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar("")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Tomando el dato de la fila seleccionada para llenar los otros tab
        Dim dt As DataTable = con.consultaCondicionada("Propietario", " idPropietario='" & dgvPropietarios.SelectedRows().Item(0).Cells(0).Value & "'")
        txtCodPropietario.Text = dt.Rows(0)("idPropietario").ToString
        txtNombre.Text = dt.Rows(0)("priNombre").ToString & " " & dt.Rows(0)("segNombre").ToString & " " & dt.Rows(0)("priApellido").ToString & " " & dt.Rows(0)("segApellido").ToString
        'txtDui.Text = con.consultaExistente("nombre", "Especie", "idEspecie=" & dt.Rows(0)("idEspecie").ToString)
        txtDui.Text = dt.Rows(0)("dui")
        txtEmail.Text = dt.Rows(0)("email")
        txtSexo.Text = dt.Rows(0)("sexo").ToString
        txtDireccion.Text = dt.Rows(0)("direccion").ToString
        txtTelFijo.Text = dt.Rows(0)("telFijo").ToString
        txtTelMovil.Text = dt.Rows(0)("telMovil").ToString

        Dim campo = "idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre', Especie.nombre AS 'Especie', " &
                    "raza AS 'Raza', sexo AS 'Sexo', color AS 'Color'"
        Dim innerjoin = "INNER JOIN Especie ON Paciente.idEspecie = Especie.idEspecie"
        Dim where = "WHERE idPropietario ='" & txtCodPropietario.Text & "'"
        llenarTabla(dgvPacientes, campo, "Paciente", innerjoin, where)

        Dim campo2 = "fecha AS 'Fecha', razonConsulta AS 'Razon de Visita', nombre AS 'Paciente'"
        Dim innerjoin2 = "INNER JOIN Paciente ON ConsultaGral.idPaciente = Paciente.idPaciente"
        llenarTabla(dgvVisitas, campo2, "ConsultaGral", innerjoin2, where)
        TabControl1.SelectTab(1)
        TabControl2.SelectTab(0)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargar("WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%' OR Paciente.idPaciente LIKE '" & txtBusqueda.Text.Trim & "%'")
    End Sub
End Class