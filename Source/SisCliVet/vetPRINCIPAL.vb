Public Class vetPRINCIPAL

    Private Sub Inicial()
        ConectarseToolStripMenuItem.Enabled = True
        DesconectarseToolStripMenuItem.Enabled = False
        AdministraciónToolStripMenuItem.Enabled = False
        PacientesToolStripMenuItem.Enabled = False
        ConsultasToolStripMenuItem.Enabled = False
        ReportesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Login()
        Do
            cGenerica.ShowDlg(vetLogin, Me)
            If cGenerica.uExit = 1 Then
                Me.Close()
                Exit Sub
            End If
        Loop While (cGenerica.uErr = 1)

        If cGenerica.vUser = 1 Then
            toolAdmin.Visible = True
            toolMed.Visible = False
            ConectarseToolStripMenuItem.Enabled = False
            DesconectarseToolStripMenuItem.Enabled = True
            AdministraciónToolStripMenuItem.Enabled = True
            PacientesToolStripMenuItem.Enabled = False
            ConsultasToolStripMenuItem.Enabled = False
            ReportesToolStripMenuItem.Enabled = True
        ElseIf cGenerica.vUser = 2 Then
            toolAdmin.Visible = False
            toolMed.Visible = True
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

    Private Sub ConectarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarseToolStripMenuItem.Click
        Login()
    End Sub

    Private Sub vetPRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login()
        Timer1.Start()
    End Sub

    Private Sub DesconectarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarseToolStripMenuItem.Click
        stUsuario.Text = ""
        cGenerica.usr = ""
        cGenerica.vUser = 0
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        toolAdmin.Visible = False
        toolMed.Visible = False
        Inicial()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click, ToolStripButton1.Click
        cGenerica.showFrm(vetUsuarios, Me)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click, ToolStripButton6.Click, ToolStripButton16.Click
        cGenerica.ShowDlg(vetAbout, Me)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GestionarPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarPacientesToolStripMenuItem.Click, ToolStripButton7.Click
        cGenerica.showFrm(vetPacientes, Me)
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaGeneralToolStripMenuItem.Click, ToolStripButton11.Click
        cGenerica.showFrm(vetConsultaGral, Me)
    End Sub

    Private Sub HistorialConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialConsultasToolStripMenuItem.Click, ToolStripButton3.Click, ToolStripButton13.Click
        cGenerica.showFrm(vetHistoConsultas, Me)
    End Sub

    Private Sub GestionDeCitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeCitasToolStripMenuItem.Click, ToolStripButton8.Click
        cGenerica.showFrm(vetCitas, Me)
    End Sub

    Private Sub ReportesPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesPacienteToolStripMenuItem.Click, ToolStripButton4.Click, ToolStripButton14.Click
        cGenerica.showFrm(vetReportPaciente, Me)
    End Sub

    Private Sub ReportesDePropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDePropietariosToolStripMenuItem.Click, ToolStripButton5.Click, ToolStripButton15.Click
        cGenerica.showFrm(vetReportPropietarios, Me)
    End Sub

    Private Sub ActualizarInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarInformaciónToolStripMenuItem.Click, ToolStripButton10.Click
        cGenerica.showFrm(vetUpdtPaciente, Me)
    End Sub

    Private Sub ControlDeVacunasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeVacunasToolStripMenuItem.Click, ToolStripButton12.Click
        cGenerica.showFrm(vetCtrlVacuna, Me)
    End Sub

    Private Sub InformaciónGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónGeneralToolStripMenuItem.Click, ToolStripButton2.Click
        cGenerica.showFrm(vetInfoGral, Me)
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click, ToolStripButton9.Click
        cGenerica.showFrm(vetAgenda, Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stFechaHora.Text = Date.Now.ToString
    End Sub

End Class
