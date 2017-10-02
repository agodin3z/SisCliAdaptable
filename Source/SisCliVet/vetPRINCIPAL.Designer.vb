<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vetPRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vetPRINCIPAL))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.stUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesconectarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeCitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarInformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeVacunasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDePropietariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaDeConsentimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stFechaHora, Me.ToolStripSeparator2, Me.stUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 624)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 23)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stFechaHora
        '
        Me.stFechaHora.Name = "stFechaHora"
        Me.stFechaHora.Size = New System.Drawing.Size(113, 18)
        Me.stFechaHora.Text = "Fecha y Hora Actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'stUsuario
        '
        Me.stUsuario.Name = "stUsuario"
        Me.stUsuario.Size = New System.Drawing.Size(103, 18)
        Me.stUsuario.Text = "Usuario registrado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarseToolStripMenuItem, Me.DesconectarseToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConectarseToolStripMenuItem
        '
        Me.ConectarseToolStripMenuItem.Name = "ConectarseToolStripMenuItem"
        Me.ConectarseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ConectarseToolStripMenuItem.Text = "Conectarse"
        '
        'DesconectarseToolStripMenuItem
        '
        Me.DesconectarseToolStripMenuItem.Enabled = False
        Me.DesconectarseToolStripMenuItem.Name = "DesconectarseToolStripMenuItem"
        Me.DesconectarseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DesconectarseToolStripMenuItem.Text = "Desconectarse"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformaciónGeneralToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Enabled = False
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(104, 21)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'InformaciónGeneralToolStripMenuItem
        '
        Me.InformaciónGeneralToolStripMenuItem.Name = "InformaciónGeneralToolStripMenuItem"
        Me.InformaciónGeneralToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.InformaciónGeneralToolStripMenuItem.Text = "Información General"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarPacientesToolStripMenuItem, Me.GestionDeCitasToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.ActualizarInformaciónToolStripMenuItem, Me.HojaDeConsentimientoToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Enabled = False
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'GestionarPacientesToolStripMenuItem
        '
        Me.GestionarPacientesToolStripMenuItem.Name = "GestionarPacientesToolStripMenuItem"
        Me.GestionarPacientesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.GestionarPacientesToolStripMenuItem.Text = "Registro de Pacientes"
        '
        'GestionDeCitasToolStripMenuItem
        '
        Me.GestionDeCitasToolStripMenuItem.Name = "GestionDeCitasToolStripMenuItem"
        Me.GestionDeCitasToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.GestionDeCitasToolStripMenuItem.Text = "Gestion de Citas"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'ActualizarInformaciónToolStripMenuItem
        '
        Me.ActualizarInformaciónToolStripMenuItem.Name = "ActualizarInformaciónToolStripMenuItem"
        Me.ActualizarInformaciónToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ActualizarInformaciónToolStripMenuItem.Text = "Actualizar Información"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeneralToolStripMenuItem, Me.ControlDeVacunasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Enabled = False
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaGeneralToolStripMenuItem
        '
        Me.ConsultaGeneralToolStripMenuItem.Name = "ConsultaGeneralToolStripMenuItem"
        Me.ConsultaGeneralToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConsultaGeneralToolStripMenuItem.Text = "Consulta general"
        '
        'ControlDeVacunasToolStripMenuItem
        '
        Me.ControlDeVacunasToolStripMenuItem.Name = "ControlDeVacunasToolStripMenuItem"
        Me.ControlDeVacunasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ControlDeVacunasToolStripMenuItem.Text = "Control de Vacunas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialConsultasToolStripMenuItem, Me.ReportesPacienteToolStripMenuItem, Me.ReportesDePropietariosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Enabled = False
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'HistorialConsultasToolStripMenuItem
        '
        Me.HistorialConsultasToolStripMenuItem.Name = "HistorialConsultasToolStripMenuItem"
        Me.HistorialConsultasToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.HistorialConsultasToolStripMenuItem.Text = "Historial de Consultas"
        '
        'ReportesPacienteToolStripMenuItem
        '
        Me.ReportesPacienteToolStripMenuItem.Name = "ReportesPacienteToolStripMenuItem"
        Me.ReportesPacienteToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReportesPacienteToolStripMenuItem.Text = "Reportes de Pacientes"
        '
        'ReportesDePropietariosToolStripMenuItem
        '
        Me.ReportesDePropietariosToolStripMenuItem.Name = "ReportesDePropietariosToolStripMenuItem"
        Me.ReportesDePropietariosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReportesDePropietariosToolStripMenuItem.Text = "Reportes de Propietarios"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'HojaDeConsentimientoToolStripMenuItem
        '
        Me.HojaDeConsentimientoToolStripMenuItem.Name = "HojaDeConsentimientoToolStripMenuItem"
        Me.HojaDeConsentimientoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HojaDeConsentimientoToolStripMenuItem.Text = "Hoja de Consentimiento"
        '
        'vetPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SisCliVet.My.Resources.Resources.wall_vet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1008, 647)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "vetPRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISCLIAD | Sistema Clínico Veterinario"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stFechaHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesconectarseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesDePropietariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeCitasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarInformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeVacunasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaDeConsentimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
