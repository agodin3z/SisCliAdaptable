Public Class vetConsultaGral

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVacunas.Click
        cGenerica.ShowDlg(vetCtrlVacuna, Me) 'Deberia enviar datos a segunda pestaña
    End Sub
End Class