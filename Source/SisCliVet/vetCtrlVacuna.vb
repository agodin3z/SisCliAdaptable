Public Class vetCtrlVacuna
    Dim connection As New cConexion

    Private Sub LimpiarTextbox(ByVal grupo As Windows.Forms.GroupBox)
        For Each control As Control In grupo.Controls
            If TypeOf control Is Windows.Forms.TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Dim tabla As String = "Paciente"
    'Campos de Paciente: id, nombre y especie
    'Campos de Propietario: Primer nombre y apellido
    Dim campos As String = "Paciente.idPaciente AS 'Codigo del Paciente', Paciente.nombre AS 'Nombre del Paciente'," &
    "Especie.nombre AS 'Especie', Propietario.idPropietario AS 'Codigo del Propietario'," &
    "Propietario.priNombre AS 'Nombre del Propietario', Propietario.priApellido AS 'Apellido del Propietario'"
    'Uniendo la tabla de Propietario y la Especie
    Dim join As String = "INNER JOIN Propietario ON Propietario.idPropietario = Paciente.idPropietario " &
        "INNER JOIN Especie ON Especie.idEspecie = Paciente.idEspecie"
    Dim paciente As String
    Dim condicion As String
    Dim condicion2 As String
    Dim fila As String = ""
    Dim especie As String = ""

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
    End Sub

    Private Sub vetCtrlVacuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        condicion = "WHERE Paciente.nombre LIKE '" & txtBusqueda.Text.Trim & "%'"
        dgvPacientes.DataSource = connection.consultaCondicionadas(campos, tabla, join, condicion)
        dgvPacientes.Refresh()
        txtFecha.Text = Now.ToString("MM-dd-yyyy")
        txtHora.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'Llenando los campos de la siguiente tab
        For Each celda As DataGridViewRow In dgvPacientes.SelectedRows
            paciente = celda.Cells(0).Value.ToString
            txtPaciente.Text = celda.Cells(1).Value.ToString
            especie = celda.Cells(2).Value.ToString
        Next
        'Condicion para llenar el checkedListBox segun Especie
        condicion2 = "WHERE Vacuna.idEspecie = (SELECT Especie.idEspecie " &
        "FROM Especie WHERE Especie.nombre ='" & especie & "')"
        lstVacunas.DataSource = connection.consultaCondicionadas("*", "Vacuna", "", condicion2)
        lstVacunas.ValueMember = "idVacuna"
        lstVacunas.DisplayMember = "nombre"
        TabControl1.SelectTab(1)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        paciente = txtPaciente.Text.Trim
        Dim fecha As String = txtFecha.Text
        Dim hora As String = txtHora.Text
        Dim newVacunas() As String = txtOtraVacuna.Lines
        Dim contador As Integer = 0
        Dim ListaVacunas As New List(Of String)
        Dim vacunasAplicadas(lstVacunas.CheckedItems.Count) As String
        For Each aplicada As Object In lstVacunas.CheckedItems
            vacunasAplicadas(contador) = lstVacunas.GetItemText(lstVacunas.CheckedItems(contador))
            contador = contador + 1
        Next
        Dim valores As String
        Dim campos As String
        If paciente.Length = 0 Then
            MessageBox.Show("Seleccione un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        campos = "(idVacuna, idPaciente, fecha)"
        valores = "'" & fila & "','" & fila & "','" & fecha
        
    End Sub
End Class