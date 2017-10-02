Public Class medPRINCIPAL
    Private Sub Inicial()
        ConectarseToolStripMenuItem.Enabled = True
        DesconectarseToolStripMenuItem.Enabled = False
        AdministraciónToolStripMenuItem.Enabled = False
        PacientesToolStripMenuItem.Enabled = False
        ConsultasToolStripMenuItem.Enabled = False
        ReportesToolStripMenuItem.Enabled = False
    End Sub

    'Sistema Temporal de Login
    Private Sub Login()
        Do
            cGenerica.ShowDlg(medLogin, Me)
            If cGenerica.uExit = 1 Then
                Me.Close()
                Exit Sub
            End If
        Loop While (cGenerica.uErr = 1)

        If cGenerica.mUser = 1 Then
            ConectarseToolStripMenuItem.Enabled = False
            DesconectarseToolStripMenuItem.Enabled = True
            AdministraciónToolStripMenuItem.Enabled = True
            PacientesToolStripMenuItem.Enabled = False
            ConsultasToolStripMenuItem.Enabled = False
            ReportesToolStripMenuItem.Enabled = True
        ElseIf cGenerica.mUser = 2 Then
            ConectarseToolStripMenuItem.Enabled = False
            DesconectarseToolStripMenuItem.Enabled = True
            AdministraciónToolStripMenuItem.Enabled = False
            PacientesToolStripMenuItem.Enabled = True
            ConsultasToolStripMenuItem.Enabled = True
            ReportesToolStripMenuItem.Enabled = True
        Else
            MessageBox.Show("Error al iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'FIN Sistema Temporal de Login

    Private Sub medPRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login()
    End Sub

    Private Sub ConectarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarseToolStripMenuItem.Click
        Login()
    End Sub

    Private Sub DesconectarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarseToolStripMenuItem.Click
        cGenerica.mUser = 0
        Inicial()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        cGenerica.ShowDlg(medAbout, Me)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        cGenerica.showFrm(medUsuarios, Me)
    End Sub

    Private Sub InformaciónGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónGeneralToolStripMenuItem.Click
        cGenerica.showFrm(medInfoGral, Me)
    End Sub

    Private Sub GestionarPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPacientesToolStripMenuItem.Click
        cGenerica.showFrm(medPacientes, Me)
    End Sub

    Private Sub GestionDeCitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeCitasToolStripMenuItem.Click
        cGenerica.showFrm(medCitas, Me)
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        cGenerica.showFrm(medAgenda, Me)
    End Sub

    Private Sub ActualizarInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarInformaciónToolStripMenuItem.Click
        cGenerica.showFrm(medUpdPaciente, Me)
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaGeneralToolStripMenuItem.Click
        cGenerica.showFrm(medConsultaGral, Me)
    End Sub

    Private Sub HistorialConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialConsultasToolStripMenuItem.Click
        cGenerica.showFrm(medHistoConsulta, Me)
    End Sub

    Private Sub ReportesPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesPacienteToolStripMenuItem.Click
        cGenerica.showFrm(medReportPacientes, Me)
    End Sub

End Class
