Public Class vetReporteReceta
    Dim paciente As String
    Dim fecha As Date
    Dim doctor As String
    Private Sub vetReporteReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each celda As DataGridViewRow In vetConsultaGral.dgvPacientes.SelectedRows
            paciente = celda.Cells(1).Value.ToString
            fecha = celda.Cells(2).Value.ToString
            fecha = fecha.ToString("MM-dd-yyyy")
            doctor = celda.Cells(5).Value.ToString
        Next
        Dim reporte As New vetReceta
        reporte.Refresh()
        reporte.SetParameterValue("Paciente", paciente)
        reporte.SetParameterValue("FechaConsulta", fecha)
        reporte.SetParameterValue("Doctor", doctor)
        reporte.SetParameterValue("Medicamento", vetConsultaGral.txtTratamiento.Text)
        CrystalReportViewer1.ReportSource = reporte

    End Sub
End Class