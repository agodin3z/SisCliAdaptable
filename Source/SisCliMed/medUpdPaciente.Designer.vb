﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medUpdPaciente
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSegNombre = New System.Windows.Forms.TextBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.txtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.txtSegApellido = New System.Windows.Forms.TextBox()
        Me.txtPriApellido = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTelEmergencia2 = New System.Windows.Forms.TextBox()
        Me.txtTelEmergencia1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmergencia2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmergencia1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 357)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pacientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.dgvPacientes)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 317)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Paciente"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(575, 265)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(108, 46)
        Me.btnSeleccionar.TabIndex = 23
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
        Me.dgvPacientes.Size = New System.Drawing.Size(661, 210)
        Me.dgvPacientes.TabIndex = 1
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(87, 21)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(526, 22)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 15)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Búsqueda:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(713, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Personales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodPaciente)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.dtpFechaNac)
        Me.GroupBox2.Controls.Add(Me.cmbGenero)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSegNombre)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtEstadoCivil)
        Me.GroupBox2.Controls.Add(Me.txtTelMovil)
        Me.GroupBox2.Controls.Add(Me.txtTelFijo)
        Me.GroupBox2.Controls.Add(Me.txtSegApellido)
        Me.GroupBox2.Controls.Add(Me.txtPriApellido)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPriNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 317)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Personales"
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(127, 241)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(133, 22)
        Me.txtCodPaciente.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(48, 244)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 15)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Registro No.:"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(581, 257)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(108, 46)
        Me.btnSiguiente.TabIndex = 15
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(456, 132)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(234, 22)
        Me.dtpFechaNac.TabIndex = 9
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbGenero.Location = New System.Drawing.Point(128, 133)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(132, 23)
        Me.cmbGenero.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(128, 171)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(562, 22)
        Me.txtDireccion.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(64, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Género:"
        '
        'txtSegNombre
        '
        Me.txtSegNombre.Location = New System.Drawing.Point(456, 26)
        Me.txtSegNombre.MaxLength = 25
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(194, 22)
        Me.txtSegNombre.TabIndex = 3
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(128, 98)
        Me.txtDui.MaxLength = 9
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(132, 22)
        Me.txtDui.TabIndex = 6
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Location = New System.Drawing.Point(456, 98)
        Me.txtEstadoCivil.MaxLength = 25
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(194, 22)
        Me.txtEstadoCivil.TabIndex = 7
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Location = New System.Drawing.Point(383, 208)
        Me.txtTelMovil.MaxLength = 8
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(133, 22)
        Me.txtTelMovil.TabIndex = 12
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Location = New System.Drawing.Point(127, 208)
        Me.txtTelFijo.MaxLength = 8
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(133, 22)
        Me.txtTelFijo.TabIndex = 11
        '
        'txtSegApellido
        '
        Me.txtSegApellido.Location = New System.Drawing.Point(456, 62)
        Me.txtSegApellido.MaxLength = 25
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(194, 22)
        Me.txtSegApellido.TabIndex = 5
        '
        'txtPriApellido
        '
        Me.txtPriApellido.Location = New System.Drawing.Point(128, 62)
        Me.txtPriApellido.MaxLength = 25
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(193, 22)
        Me.txtPriApellido.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(332, 136)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 15)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Fecha de Nacimiento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Estado Civil:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(282, 211)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Teléfono Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "DUI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Teléfono Fijo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Segundo Apellido:"
        '
        'txtPriNombre
        '
        Me.txtPriNombre.Location = New System.Drawing.Point(127, 26)
        Me.txtPriNombre.MaxLength = 25
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(194, 22)
        Me.txtPriNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Primer Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Segundo Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Primer Nombre:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.btnCancelar)
        Me.TabPage3.Controls.Add(Me.btnGuardar)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(713, 329)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Otros Datos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTelEmergencia2)
        Me.GroupBox5.Controls.Add(Me.txtTelEmergencia1)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtEmergencia2)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtEmergencia1)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 138)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(698, 123)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos de Emergencia"
        '
        'txtTelEmergencia2
        '
        Me.txtTelEmergencia2.Location = New System.Drawing.Point(506, 69)
        Me.txtTelEmergencia2.MaxLength = 8
        Me.txtTelEmergencia2.Name = "txtTelEmergencia2"
        Me.txtTelEmergencia2.Size = New System.Drawing.Size(171, 22)
        Me.txtTelEmergencia2.TabIndex = 5
        '
        'txtTelEmergencia1
        '
        Me.txtTelEmergencia1.Location = New System.Drawing.Point(506, 30)
        Me.txtTelEmergencia1.MaxLength = 8
        Me.txtTelEmergencia1.Name = "txtTelEmergencia1"
        Me.txtTelEmergencia1.Size = New System.Drawing.Size(171, 22)
        Me.txtTelEmergencia1.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(444, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Teléfono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(444, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Teléfono:"
        '
        'txtEmergencia2
        '
        Me.txtEmergencia2.Location = New System.Drawing.Point(191, 69)
        Me.txtEmergencia2.MaxLength = 75
        Me.txtEmergencia2.Name = "txtEmergencia2"
        Me.txtEmergencia2.Size = New System.Drawing.Size(223, 22)
        Me.txtEmergencia2.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "En caso de Emergencia llamar a:"
        '
        'txtEmergencia1
        '
        Me.txtEmergencia1.Location = New System.Drawing.Point(191, 30)
        Me.txtEmergencia1.MaxLength = 75
        Me.txtEmergencia1.Name = "txtEmergencia1"
        Me.txtEmergencia1.Size = New System.Drawing.Size(223, 22)
        Me.txtEmergencia1.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "En caso de Emergencia llamar a:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(374, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 46)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(243, 273)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 46)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAntecedentes)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(698, 103)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Adicionales"
        '
        'txtAntecedentes
        '
        Me.txtAntecedentes.Location = New System.Drawing.Point(102, 28)
        Me.txtAntecedentes.MaxLength = 200
        Me.txtAntecedentes.Multiline = True
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(575, 44)
        Me.txtAntecedentes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Antecedentes:"
        '
        'medUpdPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 380)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "medUpdPaciente"
        Me.Text = "Actualizar Información"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSegNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents txtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents txtSegApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPriApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPriNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelEmergencia2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelEmergencia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmergencia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmergencia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAntecedentes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtCodPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
