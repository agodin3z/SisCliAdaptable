Public Class vetAbout

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        cGenerica.ShowDlg(vetCreditos, Me)
    End Sub
End Class