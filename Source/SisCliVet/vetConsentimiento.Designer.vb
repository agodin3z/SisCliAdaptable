﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vetConsentimiento
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbHospedaje = New System.Windows.Forms.RadioButton()
        Me.rdbHospitalizacion = New System.Windows.Forms.RadioButton()
        Me.rdbCirugia = New System.Windows.Forms.RadioButton()
        Me.btnCarta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCarta = New System.Windows.Forms.TextBox()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 398)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 372)
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Paciente"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(491, 294)
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
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(22, 57)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(577, 231)
        Me.dgvPacientes.TabIndex = 1
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(87, 24)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(512, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Búsqueda:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGuardar)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Subir Carta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(248, 288)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 46)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFecha)
        Me.GroupBox4.Controls.Add(Me.txtHora)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(615, 74)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hora y Fecha de Registro"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(356, 29)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(172, 20)
        Me.txtFecha.TabIndex = 1
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(100, 29)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(172, 20)
        Me.txtHora.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(59, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Hora:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(310, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Fecha:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbHospedaje)
        Me.GroupBox3.Controls.Add(Me.rdbHospitalizacion)
        Me.GroupBox3.Controls.Add(Me.rdbCirugia)
        Me.GroupBox3.Controls.Add(Me.btnCarta)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtCarta)
        Me.GroupBox3.Controls.Add(Me.txtPaciente)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 181)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'rdbHospedaje
        '
        Me.rdbHospedaje.AutoSize = True
        Me.rdbHospedaje.Location = New System.Drawing.Point(321, 117)
        Me.rdbHospedaje.Name = "rdbHospedaje"
        Me.rdbHospedaje.Size = New System.Drawing.Size(76, 17)
        Me.rdbHospedaje.TabIndex = 7
        Me.rdbHospedaje.TabStop = True
        Me.rdbHospedaje.Text = "Hospedaje"
        Me.rdbHospedaje.UseVisualStyleBackColor = True
        '
        'rdbHospitalizacion
        '
        Me.rdbHospitalizacion.AutoSize = True
        Me.rdbHospitalizacion.Location = New System.Drawing.Point(211, 117)
        Me.rdbHospitalizacion.Name = "rdbHospitalizacion"
        Me.rdbHospitalizacion.Size = New System.Drawing.Size(96, 17)
        Me.rdbHospitalizacion.TabIndex = 6
        Me.rdbHospitalizacion.TabStop = True
        Me.rdbHospitalizacion.Text = "Hospitalización"
        Me.rdbHospitalizacion.UseVisualStyleBackColor = True
        '
        'rdbCirugia
        '
        Me.rdbCirugia.AutoSize = True
        Me.rdbCirugia.Location = New System.Drawing.Point(140, 117)
        Me.rdbCirugia.Name = "rdbCirugia"
        Me.rdbCirugia.Size = New System.Drawing.Size(59, 17)
        Me.rdbCirugia.TabIndex = 5
        Me.rdbCirugia.TabStop = True
        Me.rdbCirugia.Text = "Cirugía"
        Me.rdbCirugia.UseVisualStyleBackColor = True
        '
        'btnCarta
        '
        Me.btnCarta.Location = New System.Drawing.Point(366, 65)
        Me.btnCarta.Name = "btnCarta"
        Me.btnCarta.Size = New System.Drawing.Size(108, 30)
        Me.btnCarta.TabIndex = 4
        Me.btnCarta.Text = "Subir Carta..."
        Me.btnCarta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Tipo de Carta:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(69, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Subir carta:"
        '
        'txtCarta
        '
        Me.txtCarta.Enabled = False
        Me.txtCarta.Location = New System.Drawing.Point(140, 70)
        Me.txtCarta.Name = "txtCarta"
        Me.txtCarta.Size = New System.Drawing.Size(217, 20)
        Me.txtCarta.TabIndex = 3
        '
        'txtPaciente
        '
        Me.txtPaciente.Enabled = False
        Me.txtPaciente.Location = New System.Drawing.Point(140, 30)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(217, 20)
        Me.txtPaciente.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nombre del Paciente:"
        '
        'vetConsentimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "vetConsentimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Cartas de Consentimiento"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHospedaje As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHospitalizacion As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCirugia As System.Windows.Forms.RadioButton
    Friend WithEvents btnCarta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCarta As System.Windows.Forms.TextBox
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
