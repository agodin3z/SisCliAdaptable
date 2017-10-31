Public Class medReporteReceta

    Private Sub medReporteReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reporte As New medReceta
        reporte.Refresh()
        reporte.SetParameterValue("Paciente", medConsultaGral.txtPacienteReceta.Text)
        reporte.SetParameterValue("FechaConsulta", medConsultaGral.txtFechaReceta.Text)
        reporte.SetParameterValue("Doctor", medConsultaGral.txtMedicoReceta.Text)
        reporte.SetParameterValue("Medicamento", medConsultaGral.txtMedicamentoReceta.Text)
        CrystalReportViewer1.ReportSource = reporte

    End Sub
End Class