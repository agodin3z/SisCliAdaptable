<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medConsultaGral
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dtpFechaSiguiente = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.nudRespiracion = New System.Windows.Forms.NumericUpDown()
        Me.nudPulso = New System.Windows.Forms.NumericUpDown()
        Me.txtObservacionesSignos = New System.Windows.Forms.TextBox()
        Me.nudPeso = New System.Windows.Forms.NumericUpDown()
        Me.nudEstatura = New System.Windows.Forms.NumericUpDown()
        Me.txtIMC = New System.Windows.Forms.TextBox()
        Me.nudTemp = New System.Windows.Forms.NumericUpDown()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.nudPresionMin = New System.Windows.Forms.NumericUpDown()
        Me.nudPresionMax = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txtMedicoReceta = New System.Windows.Forms.TextBox()
        Me.btnImprimirReceta = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtMedicamentoReceta = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtPacienteReceta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtFechaReceta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.nudRespiracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPulso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEstatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPresionMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPresionMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 481)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 455)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Paciente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.dgvPacientes)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 435)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Paciente"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(563, 364)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(108, 46)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(22, 49)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(649, 297)
        Me.dgvPacientes.TabIndex = 1
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(87, 21)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(526, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Búsqueda:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnCancelar)
        Me.TabPage3.Controls.Add(Me.btnGuardar)
        Me.TabPage3.Controls.Add(Me.txtMotivo)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtPaciente)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.txtFecha)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(713, 455)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Consulta"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(373, 395)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 46)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(235, 395)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 46)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(137, 34)
        Me.txtMotivo.MaxLength = 250
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(566, 20)
        Me.txtMotivo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Motivo de la Consulta:"
        '
        'txtPaciente
        '
        Me.txtPaciente.Enabled = False
        Me.txtPaciente.Location = New System.Drawing.Point(137, 6)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(302, 20)
        Me.txtPaciente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre del Paciente:"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(586, 6)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(117, 20)
        Me.txtFecha.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha de la Consulta:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(6, 62)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(701, 327)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dtpFechaSiguiente)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.txtTratamiento)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.txtObservaciones)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.txtDiagnostico)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtSintomas)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(693, 301)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Diágnostico Médico"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dtpFechaSiguiente
        '
        Me.dtpFechaSiguiente.CustomFormat = "dddd, dd 'de' MMMM 'del'  yyyy  '|  Hora:' hh:mm:s tt"
        Me.dtpFechaSiguiente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSiguiente.Location = New System.Drawing.Point(111, 245)
        Me.dtpFechaSiguiente.Name = "dtpFechaSiguiente"
        Me.dtpFechaSiguiente.Size = New System.Drawing.Size(351, 20)
        Me.dtpFechaSiguiente.TabIndex = 59
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(29, 249)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 13)
        Me.Label33.TabIndex = 48
        Me.Label33.Text = "Próxima Cita:"
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Location = New System.Drawing.Point(111, 188)
        Me.txtTratamiento.MaxLength = 500
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(526, 44)
        Me.txtTratamiento.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Tratamiento:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(111, 130)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(526, 44)
        Me.txtObservaciones.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Observaciones:"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(111, 72)
        Me.txtDiagnostico.MaxLength = 250
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(526, 44)
        Me.txtDiagnostico.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Diagnóstico:"
        '
        'txtSintomas
        '
        Me.txtSintomas.Location = New System.Drawing.Point(111, 15)
        Me.txtSintomas.MaxLength = 250
        Me.txtSintomas.Multiline = True
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(526, 44)
        Me.txtSintomas.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Síntomas:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.nudRespiracion)
        Me.TabPage5.Controls.Add(Me.nudPulso)
        Me.TabPage5.Controls.Add(Me.txtObservacionesSignos)
        Me.TabPage5.Controls.Add(Me.nudPeso)
        Me.TabPage5.Controls.Add(Me.nudEstatura)
        Me.TabPage5.Controls.Add(Me.txtIMC)
        Me.TabPage5.Controls.Add(Me.nudTemp)
        Me.TabPage5.Controls.Add(Me.txtPeso)
        Me.TabPage5.Controls.Add(Me.nudPresionMin)
        Me.TabPage5.Controls.Add(Me.nudPresionMax)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.Label26)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(693, 301)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Signos Vitales"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'nudRespiracion
        '
        Me.nudRespiracion.Location = New System.Drawing.Point(519, 138)
        Me.nudRespiracion.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudRespiracion.Name = "nudRespiracion"
        Me.nudRespiracion.Size = New System.Drawing.Size(120, 20)
        Me.nudRespiracion.TabIndex = 8
        '
        'nudPulso
        '
        Me.nudPulso.Location = New System.Drawing.Point(199, 138)
        Me.nudPulso.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudPulso.Name = "nudPulso"
        Me.nudPulso.Size = New System.Drawing.Size(120, 20)
        Me.nudPulso.TabIndex = 7
        '
        'txtObservacionesSignos
        '
        Me.txtObservacionesSignos.Location = New System.Drawing.Point(199, 209)
        Me.txtObservacionesSignos.MaxLength = 250
        Me.txtObservacionesSignos.Multiline = True
        Me.txtObservacionesSignos.Name = "txtObservacionesSignos"
        Me.txtObservacionesSignos.Size = New System.Drawing.Size(440, 40)
        Me.txtObservacionesSignos.TabIndex = 10
        '
        'nudPeso
        '
        Me.nudPeso.DecimalPlaces = 2
        Me.nudPeso.Location = New System.Drawing.Point(199, 101)
        Me.nudPeso.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudPeso.Name = "nudPeso"
        Me.nudPeso.Size = New System.Drawing.Size(120, 20)
        Me.nudPeso.TabIndex = 5
        '
        'nudEstatura
        '
        Me.nudEstatura.DecimalPlaces = 2
        Me.nudEstatura.Location = New System.Drawing.Point(519, 63)
        Me.nudEstatura.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudEstatura.Name = "nudEstatura"
        Me.nudEstatura.Size = New System.Drawing.Size(120, 20)
        Me.nudEstatura.TabIndex = 4
        '
        'txtIMC
        '
        Me.txtIMC.Enabled = False
        Me.txtIMC.Location = New System.Drawing.Point(199, 174)
        Me.txtIMC.Name = "txtIMC"
        Me.txtIMC.Size = New System.Drawing.Size(120, 20)
        Me.txtIMC.TabIndex = 9
        '
        'nudTemp
        '
        Me.nudTemp.DecimalPlaces = 2
        Me.nudTemp.Location = New System.Drawing.Point(199, 63)
        Me.nudTemp.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTemp.Name = "nudTemp"
        Me.nudTemp.Size = New System.Drawing.Size(120, 20)
        Me.nudTemp.TabIndex = 3
        '
        'txtPeso
        '
        Me.txtPeso.Enabled = False
        Me.txtPeso.Location = New System.Drawing.Point(519, 100)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(120, 20)
        Me.txtPeso.TabIndex = 6
        '
        'nudPresionMin
        '
        Me.nudPresionMin.DecimalPlaces = 2
        Me.nudPresionMin.Location = New System.Drawing.Point(519, 26)
        Me.nudPresionMin.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudPresionMin.Name = "nudPresionMin"
        Me.nudPresionMin.Size = New System.Drawing.Size(120, 20)
        Me.nudPresionMin.TabIndex = 2
        '
        'nudPresionMax
        '
        Me.nudPresionMax.DecimalPlaces = 2
        Me.nudPresionMax.Location = New System.Drawing.Point(199, 26)
        Me.nudPresionMax.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudPresionMax.Name = "nudPresionMax"
        Me.nudPresionMax.Size = New System.Drawing.Size(120, 20)
        Me.nudPresionMax.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(107, 212)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Observaciones:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(163, 177)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "IMC:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(410, 140)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Respiración (/min):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(122, 140)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Pulso (LPM):"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(451, 103)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Peso (Lbs):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(136, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Peso (Kg):"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(437, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Estatura (cm):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(96, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Temperatura (°C):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(339, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(157, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Presión Arterial Mínima (mmHg):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Presión Arterial Máxima (mmHg):"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtMedicoReceta)
        Me.TabPage6.Controls.Add(Me.btnImprimirReceta)
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.txtMedicamentoReceta)
        Me.TabPage6.Controls.Add(Me.Label31)
        Me.TabPage6.Controls.Add(Me.txtPacienteReceta)
        Me.TabPage6.Controls.Add(Me.Label28)
        Me.TabPage6.Controls.Add(Me.txtFechaReceta)
        Me.TabPage6.Controls.Add(Me.Label29)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(693, 301)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Receta Médica"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txtMedicoReceta
        '
        Me.txtMedicoReceta.Enabled = False
        Me.txtMedicoReceta.Location = New System.Drawing.Point(147, 91)
        Me.txtMedicoReceta.Name = "txtMedicoReceta"
        Me.txtMedicoReceta.Size = New System.Drawing.Size(302, 20)
        Me.txtMedicoReceta.TabIndex = 1
        '
        'btnImprimirReceta
        '
        Me.btnImprimirReceta.Location = New System.Drawing.Point(294, 236)
        Me.btnImprimirReceta.Name = "btnImprimirReceta"
        Me.btnImprimirReceta.Size = New System.Drawing.Size(108, 46)
        Me.btnImprimirReceta.TabIndex = 11
        Me.btnImprimirReceta.Text = "Imprimir"
        Me.btnImprimirReceta.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 94)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Médico Responsable:"
        '
        'txtMedicamentoReceta
        '
        Me.txtMedicamentoReceta.Enabled = False
        Me.txtMedicamentoReceta.Location = New System.Drawing.Point(147, 126)
        Me.txtMedicamentoReceta.Multiline = True
        Me.txtMedicamentoReceta.Name = "txtMedicamentoReceta"
        Me.txtMedicamentoReceta.Size = New System.Drawing.Size(506, 100)
        Me.txtMedicamentoReceta.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(60, 129)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(74, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Medicamento:"
        '
        'txtPacienteReceta
        '
        Me.txtPacienteReceta.Enabled = False
        Me.txtPacienteReceta.Location = New System.Drawing.Point(147, 57)
        Me.txtPacienteReceta.Name = "txtPacienteReceta"
        Me.txtPacienteReceta.Size = New System.Drawing.Size(302, 20)
        Me.txtPacienteReceta.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(23, 60)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(109, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nombre del Paciente:"
        '
        'txtFechaReceta
        '
        Me.txtFechaReceta.Enabled = False
        Me.txtFechaReceta.Location = New System.Drawing.Point(147, 23)
        Me.txtFechaReceta.Name = "txtFechaReceta"
        Me.txtFechaReceta.Size = New System.Drawing.Size(117, 20)
        Me.txtFechaReceta.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(24, 26)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Fecha de la Consulta:"
        '
        'medConsultaGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 504)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "medConsultaGral"
        Me.Text = "Consulta General"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.nudRespiracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPulso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEstatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPresionMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPresionMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTratamiento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSintomas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudRespiracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPulso As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtObservacionesSignos As System.Windows.Forms.TextBox
    Friend WithEvents nudPeso As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudEstatura As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtIMC As System.Windows.Forms.TextBox
    Friend WithEvents nudTemp As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents nudPresionMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPresionMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents txtMedicoReceta As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimirReceta As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtMedicamentoReceta As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtPacienteReceta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtFechaReceta As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSiguiente As System.Windows.Forms.DateTimePicker
End Class
