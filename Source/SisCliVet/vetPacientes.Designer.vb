<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vetPacientes
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.txtCodPropietario = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSegNombre = New System.Windows.Forms.TextBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.txtSegApellido = New System.Windows.Forms.TextBox()
        Me.txtPriApellido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbUltiVacuna = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkPeluqueria = New System.Windows.Forms.CheckBox()
        Me.chkClinico = New System.Windows.Forms.CheckBox()
        Me.lstVacunas = New System.Windows.Forms.CheckedListBox()
        Me.txtOtraVacuna = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpUltiVacuna = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.txtRasgos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEstadoRep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCargarFoto = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbHembra = New System.Windows.Forms.RadioButton()
        Me.rdbMacho = New System.Windows.Forms.RadioButton()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 475)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Propietario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFecha)
        Me.GroupBox4.Controls.Add(Me.txtHora)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(701, 64)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hora y Fecha de Registro"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(356, 25)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(172, 22)
        Me.txtFecha.TabIndex = 1
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(100, 25)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(172, 22)
        Me.txtHora.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(59, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 15)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Hora:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(310, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.txtCodPropietario)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 75)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Otros datos"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(564, 18)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(108, 46)
        Me.btnSiguiente.TabIndex = 14
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'txtCodPropietario
        '
        Me.txtCodPropietario.Enabled = False
        Me.txtCodPropietario.Location = New System.Drawing.Point(191, 31)
        Me.txtCodPropietario.Name = "txtCodPropietario"
        Me.txtCodPropietario.Size = New System.Drawing.Size(133, 22)
        Me.txtCodPropietario.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(162, 15)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Código de Registro Generado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.rdbFemenino)
        Me.GroupBox2.Controls.Add(Me.rdbMasculino)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSegNombre)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtTelMovil)
        Me.GroupBox2.Controls.Add(Me.txtTelFijo)
        Me.GroupBox2.Controls.Add(Me.txtSegApellido)
        Me.GroupBox2.Controls.Add(Me.txtPriApellido)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPriNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 237)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(111, 154)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(564, 22)
        Me.txtDireccion.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(47, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dirección:"
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(152, 123)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(31, 19)
        Me.rdbFemenino.TabIndex = 9
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "F"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(111, 123)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(35, 19)
        Me.rdbMasculino.TabIndex = 8
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "M"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sexo:"
        '
        'txtSegNombre
        '
        Me.txtSegNombre.Location = New System.Drawing.Point(481, 26)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(194, 22)
        Me.txtSegNombre.TabIndex = 3
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(111, 90)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(133, 22)
        Me.txtDui.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(481, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(194, 22)
        Me.txtEmail.TabIndex = 7
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Location = New System.Drawing.Point(481, 186)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(133, 22)
        Me.txtTelMovil.TabIndex = 12
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Location = New System.Drawing.Point(110, 186)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(133, 22)
        Me.txtTelFijo.TabIndex = 11
        '
        'txtSegApellido
        '
        Me.txtSegApellido.Location = New System.Drawing.Point(481, 58)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(194, 22)
        Me.txtSegApellido.TabIndex = 5
        '
        'txtPriApellido
        '
        Me.txtPriApellido.Location = New System.Drawing.Point(111, 58)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(193, 22)
        Me.txtPriApellido.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Correo Electrónico:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(380, 189)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Teléfono Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "DUI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Teléfono Fijo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Segundo Apellido:"
        '
        'txtPriNombre
        '
        Me.txtPriNombre.Location = New System.Drawing.Point(110, 26)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(194, 22)
        Me.txtPriNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Primer Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Segundo Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Primer Nombre:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(713, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Paciente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtCodPaciente)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.btnCancelar)
        Me.GroupBox5.Controls.Add(Me.btnAgregar)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 366)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(698, 75)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(184, 31)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(133, 22)
        Me.txtCodPaciente.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 34)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(162, 15)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Código de Registro Generado:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(551, 18)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 46)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(420, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 46)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbUltiVacuna)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.lstVacunas)
        Me.GroupBox3.Controls.Add(Me.txtOtraVacuna)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.dtpUltiVacuna)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cmbEspecie)
        Me.GroupBox3.Controls.Add(Me.txtRasgos)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtEstadoRep)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btnCargarFoto)
        Me.GroupBox3.Controls.Add(Me.picFoto)
        Me.GroupBox3.Controls.Add(Me.dtpFechaNac)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.rdbHembra)
        Me.GroupBox3.Controls.Add(Me.rdbMacho)
        Me.GroupBox3.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox3.Controls.Add(Me.txtRaza)
        Me.GroupBox3.Controls.Add(Me.txtPeso)
        Me.GroupBox3.Controls.Add(Me.txtColor)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(698, 354)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'cmbUltiVacuna
        '
        Me.cmbUltiVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUltiVacuna.FormattingEnabled = True
        Me.cmbUltiVacuna.Items.AddRange(New Object() {"Perro", "Gato"})
        Me.cmbUltiVacuna.Location = New System.Drawing.Point(133, 314)
        Me.cmbUltiVacuna.Name = "cmbUltiVacuna"
        Me.cmbUltiVacuna.Size = New System.Drawing.Size(123, 23)
        Me.cmbUltiVacuna.TabIndex = 15
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkPeluqueria)
        Me.GroupBox6.Controls.Add(Me.chkClinico)
        Me.GroupBox6.Location = New System.Drawing.Point(377, 196)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(156, 107)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de Registro:"
        '
        'chkPeluqueria
        '
        Me.chkPeluqueria.AutoSize = True
        Me.chkPeluqueria.Location = New System.Drawing.Point(20, 65)
        Me.chkPeluqueria.Name = "chkPeluqueria"
        Me.chkPeluqueria.Size = New System.Drawing.Size(82, 19)
        Me.chkPeluqueria.TabIndex = 14
        Me.chkPeluqueria.Text = "Peluquería"
        Me.chkPeluqueria.UseVisualStyleBackColor = True
        '
        'chkClinico
        '
        Me.chkClinico.AutoSize = True
        Me.chkClinico.Location = New System.Drawing.Point(20, 30)
        Me.chkClinico.Name = "chkClinico"
        Me.chkClinico.Size = New System.Drawing.Size(61, 19)
        Me.chkClinico.TabIndex = 13
        Me.chkClinico.Text = "Clínico"
        Me.chkClinico.UseVisualStyleBackColor = True
        '
        'lstVacunas
        '
        Me.lstVacunas.FormattingEnabled = True
        Me.lstVacunas.Location = New System.Drawing.Point(27, 214)
        Me.lstVacunas.Name = "lstVacunas"
        Me.lstVacunas.Size = New System.Drawing.Size(142, 89)
        Me.lstVacunas.TabIndex = 10
        '
        'txtOtraVacuna
        '
        Me.txtOtraVacuna.Location = New System.Drawing.Point(193, 214)
        Me.txtOtraVacuna.Multiline = True
        Me.txtOtraVacuna.Name = "txtOtraVacuna"
        Me.txtOtraVacuna.Size = New System.Drawing.Size(164, 89)
        Me.txtOtraVacuna.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(190, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 15)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Otras Vacunas:"
        '
        'dtpUltiVacuna
        '
        Me.dtpUltiVacuna.Location = New System.Drawing.Point(262, 315)
        Me.dtpUltiVacuna.Name = "dtpUltiVacuna"
        Me.dtpUltiVacuna.Size = New System.Drawing.Size(222, 22)
        Me.dtpUltiVacuna.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 15)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Fecha última vacuna:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Vacunas:"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Items.AddRange(New Object() {"Perro", "Gato"})
        Me.cmbEspecie.Location = New System.Drawing.Point(471, 15)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(172, 23)
        Me.cmbEspecie.TabIndex = 1
        '
        'txtRasgos
        '
        Me.txtRasgos.Location = New System.Drawing.Point(125, 139)
        Me.txtRasgos.Multiline = True
        Me.txtRasgos.Name = "txtRasgos"
        Me.txtRasgos.Size = New System.Drawing.Size(408, 44)
        Me.txtRasgos.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Rasgos distintivos:"
        '
        'txtEstadoRep
        '
        Me.txtEstadoRep.Location = New System.Drawing.Point(471, 104)
        Me.txtEstadoRep.Name = "txtEstadoRep"
        Me.txtEstadoRep.Size = New System.Drawing.Size(172, 22)
        Me.txtEstadoRep.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(347, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 15)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Estado Reproductivo:"
        '
        'btnCargarFoto
        '
        Me.btnCargarFoto.Location = New System.Drawing.Point(551, 301)
        Me.btnCargarFoto.Name = "btnCargarFoto"
        Me.btnCargarFoto.Size = New System.Drawing.Size(141, 46)
        Me.btnCargarFoto.TabIndex = 17
        Me.btnCargarFoto.Text = "Cargar Foto..."
        Me.btnCargarFoto.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(551, 149)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(141, 144)
        Me.picFoto.TabIndex = 16
        Me.picFoto.TabStop = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(470, 75)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(222, 22)
        Me.dtpFechaNac.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(347, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'rdbHembra
        '
        Me.rdbHembra.AutoSize = True
        Me.rdbHembra.Location = New System.Drawing.Point(152, 46)
        Me.rdbHembra.Name = "rdbHembra"
        Me.rdbHembra.Size = New System.Drawing.Size(66, 19)
        Me.rdbHembra.TabIndex = 3
        Me.rdbHembra.TabStop = True
        Me.rdbHembra.Text = "Hembra"
        Me.rdbHembra.UseVisualStyleBackColor = True
        '
        'rdbMacho
        '
        Me.rdbMacho.AutoSize = True
        Me.rdbMacho.Location = New System.Drawing.Point(86, 46)
        Me.rdbMacho.Name = "rdbMacho"
        Me.rdbMacho.Size = New System.Drawing.Size(60, 19)
        Me.rdbMacho.TabIndex = 2
        Me.rdbMacho.TabStop = True
        Me.rdbMacho.Text = "Macho"
        Me.rdbMacho.UseVisualStyleBackColor = True
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(86, 15)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(171, 22)
        Me.txtNombrePaciente.TabIndex = 0
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(471, 45)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(172, 22)
        Me.txtRaza.TabIndex = 4
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(85, 104)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(171, 22)
        Me.txtPeso.TabIndex = 7
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(85, 75)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(171, 22)
        Me.txtColor.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Peso:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(424, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Raza:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Color:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(417, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 15)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Especie:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Sexo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Nombre:"
        '
        'vetPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "vetPacientes"
        Me.Text = "Registro de Paciente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rdbFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSegNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents txtSegApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPriApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPriNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstVacunas As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtOtraVacuna As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpUltiVacuna As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents txtRasgos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEstadoRep As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCargarFoto As System.Windows.Forms.Button
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdbHembra As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMacho As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPeluqueria As System.Windows.Forms.CheckBox
    Friend WithEvents chkClinico As System.Windows.Forms.CheckBox
    Friend WithEvents cmbUltiVacuna As System.Windows.Forms.ComboBox
End Class
