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
        Me.components = New System.ComponentModel.Container()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.toolAdmin = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.toolMed = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.toolAdmin.SuspendLayout()
        Me.toolMed.SuspendLayout()
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
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InformaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarseToolStripMenuItem, Me.DesconectarseToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConectarseToolStripMenuItem
        '
        Me.ConectarseToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_entrar
        Me.ConectarseToolStripMenuItem.Name = "ConectarseToolStripMenuItem"
        Me.ConectarseToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ConectarseToolStripMenuItem.Text = "Conectarse"
        '
        'DesconectarseToolStripMenuItem
        '
        Me.DesconectarseToolStripMenuItem.Enabled = False
        Me.DesconectarseToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_salir
        Me.DesconectarseToolStripMenuItem.Name = "DesconectarseToolStripMenuItem"
        Me.DesconectarseToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DesconectarseToolStripMenuItem.Text = "Desconectarse"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_cancel
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformaciónGeneralToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Enabled = False
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_med
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'InformaciónGeneralToolStripMenuItem
        '
        Me.InformaciónGeneralToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_hospital
        Me.InformaciónGeneralToolStripMenuItem.Name = "InformaciónGeneralToolStripMenuItem"
        Me.InformaciónGeneralToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.InformaciónGeneralToolStripMenuItem.Text = "Información General"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarPacientesToolStripMenuItem, Me.GestionDeCitasToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.ActualizarInformaciónToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Enabled = False
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'GestionarPacientesToolStripMenuItem
        '
        Me.GestionarPacientesToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_pet
        Me.GestionarPacientesToolStripMenuItem.Name = "GestionarPacientesToolStripMenuItem"
        Me.GestionarPacientesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionarPacientesToolStripMenuItem.Text = "Registro de Pacientes"
        '
        'GestionDeCitasToolStripMenuItem
        '
        Me.GestionDeCitasToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_check_cita
        Me.GestionDeCitasToolStripMenuItem.Name = "GestionDeCitasToolStripMenuItem"
        Me.GestionDeCitasToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GestionDeCitasToolStripMenuItem.Text = "Gestion de Citas"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_agenda
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'ActualizarInformaciónToolStripMenuItem
        '
        Me.ActualizarInformaciónToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_edit
        Me.ActualizarInformaciónToolStripMenuItem.Name = "ActualizarInformaciónToolStripMenuItem"
        Me.ActualizarInformaciónToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ActualizarInformaciónToolStripMenuItem.Text = "Actualizar Información"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeneralToolStripMenuItem, Me.ControlDeVacunasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Enabled = False
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaGeneralToolStripMenuItem
        '
        Me.ConsultaGeneralToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_icon
        Me.ConsultaGeneralToolStripMenuItem.Name = "ConsultaGeneralToolStripMenuItem"
        Me.ConsultaGeneralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaGeneralToolStripMenuItem.Text = "Consulta general"
        '
        'ControlDeVacunasToolStripMenuItem
        '
        Me.ControlDeVacunasToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_chart
        Me.ControlDeVacunasToolStripMenuItem.Name = "ControlDeVacunasToolStripMenuItem"
        Me.ControlDeVacunasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ControlDeVacunasToolStripMenuItem.Text = "Control de Vacunas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialConsultasToolStripMenuItem, Me.ReportesPacienteToolStripMenuItem, Me.ReportesDePropietariosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Enabled = False
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'HistorialConsultasToolStripMenuItem
        '
        Me.HistorialConsultasToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_history
        Me.HistorialConsultasToolStripMenuItem.Name = "HistorialConsultasToolStripMenuItem"
        Me.HistorialConsultasToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HistorialConsultasToolStripMenuItem.Text = "Historial de Consultas"
        '
        'ReportesPacienteToolStripMenuItem
        '
        Me.ReportesPacienteToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ReportesPacienteToolStripMenuItem.Name = "ReportesPacienteToolStripMenuItem"
        Me.ReportesPacienteToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ReportesPacienteToolStripMenuItem.Text = "Reportes de Pacientes"
        '
        'ReportesDePropietariosToolStripMenuItem
        '
        Me.ReportesDePropietariosToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ReportesDePropietariosToolStripMenuItem.Name = "ReportesDePropietariosToolStripMenuItem"
        Me.ReportesDePropietariosToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ReportesDePropietariosToolStripMenuItem.Text = "Reportes de Propietarios"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = Global.SisCliVet.My.Resources.Resources.vet_info
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Timer1
        '
        '
        'toolAdmin
        '
        Me.toolAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator4, Me.ToolStripButton6})
        Me.toolAdmin.Location = New System.Drawing.Point(0, 24)
        Me.toolAdmin.Name = "toolAdmin"
        Me.toolAdmin.Size = New System.Drawing.Size(1008, 38)
        Me.toolAdmin.TabIndex = 4
        Me.toolAdmin.Text = "ToolStrip1"
        Me.toolAdmin.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.SisCliVet.My.Resources.Resources.vet_med
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 35)
        Me.ToolStripButton1.Text = "Usuarios"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.SisCliVet.My.Resources.Resources.vet_hospital
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(47, 35)
        Me.ToolStripButton2.Text = "Clínica"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.SisCliVet.My.Resources.Resources.vet_history
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(63, 35)
        Me.ToolStripButton3.Text = "Consultas"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(61, 35)
        Me.ToolStripButton4.Text = "Pacientes"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(74, 35)
        Me.ToolStripButton5.Text = "Propietarios"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.SisCliVet.My.Resources.Resources.vet_info
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(76, 35)
        Me.ToolStripButton6.Text = "Información"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolMed
        '
        Me.toolMed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripButton15, Me.ToolStripSeparator7, Me.ToolStripButton16})
        Me.toolMed.Location = New System.Drawing.Point(0, 24)
        Me.toolMed.Name = "toolMed"
        Me.toolMed.Size = New System.Drawing.Size(1008, 38)
        Me.toolMed.TabIndex = 5
        Me.toolMed.Text = "ToolStrip2"
        Me.toolMed.Visible = False
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.SisCliVet.My.Resources.Resources.vet_pet
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(110, 35)
        Me.ToolStripButton7.Text = "Registrar Pacientes"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Image = Global.SisCliVet.My.Resources.Resources.vet_check_cita
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(37, 35)
        Me.ToolStripButton8.Text = "Citas"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Image = Global.SisCliVet.My.Resources.Resources.vet_agenda
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(52, 35)
        Me.ToolStripButton9.Text = "Agenda"
        Me.ToolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Image = Global.SisCliVet.My.Resources.Resources.vet_edit
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(131, 35)
        Me.ToolStripButton10.Text = "Actualizar Información"
        Me.ToolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Image = Global.SisCliVet.My.Resources.Resources.vet_icon
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(101, 35)
        Me.ToolStripButton11.Text = "Consulta General"
        Me.ToolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.Image = Global.SisCliVet.My.Resources.Resources.vet_chart
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(113, 35)
        Me.ToolStripButton12.Text = "Control de Vacunas"
        Me.ToolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.Image = Global.SisCliVet.My.Resources.Resources.vet_history
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(63, 35)
        Me.ToolStripButton13.Text = "Consultas"
        Me.ToolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(61, 35)
        Me.ToolStripButton14.Text = "Pacientes"
        Me.ToolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.Image = Global.SisCliVet.My.Resources.Resources.vet_list
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(74, 35)
        Me.ToolStripButton15.Text = "Propietarios"
        Me.ToolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.Image = Global.SisCliVet.My.Resources.Resources.vet_info
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(76, 35)
        Me.ToolStripButton16.Text = "Información"
        Me.ToolStripButton16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'vetPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SisCliVet.My.Resources.Resources.wall_vet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1008, 647)
        Me.Controls.Add(Me.toolMed)
        Me.Controls.Add(Me.toolAdmin)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.toolAdmin.ResumeLayout(False)
        Me.toolAdmin.PerformLayout()
        Me.toolMed.ResumeLayout(False)
        Me.toolMed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stFechaHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents stUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolAdmin As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolMed As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton

End Class
