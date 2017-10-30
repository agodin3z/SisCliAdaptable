<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vetPosponerCita
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
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaSiguiente = New System.Windows.Forms.DateTimePicker()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbOtro = New System.Windows.Forms.RadioButton()
        Me.rdbPeluqueria = New System.Windows.Forms.RadioButton()
        Me.rdbRefuerzo = New System.Windows.Forms.RadioButton()
        Me.rdbConsulta = New System.Windows.Forms.RadioButton()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 331)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Citas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCitas)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 294)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AllowUserToDeleteRows = False
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCitas.Location = New System.Drawing.Point(3, 18)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.ReadOnly = True
        Me.dgvCitas.Size = New System.Drawing.Size(609, 273)
        Me.dgvCitas.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btnCancelar)
        Me.TabPage2.Controls.Add(Me.btnGuardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actualizar Cita"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaSiguiente)
        Me.GroupBox2.Controls.Add(Me.txtOtro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbOtro)
        Me.GroupBox2.Controls.Add(Me.rdbPeluqueria)
        Me.GroupBox2.Controls.Add(Me.rdbRefuerzo)
        Me.GroupBox2.Controls.Add(Me.rdbConsulta)
        Me.GroupBox2.Controls.Add(Me.txtPropietario)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPaciente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 190)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'dtpFechaSiguiente
        '
        Me.dtpFechaSiguiente.CustomFormat = "dddd, dd 'de' MMMM 'del'  yyyy  '|  Hora:' hh:mm:s tt"
        Me.dtpFechaSiguiente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSiguiente.Location = New System.Drawing.Point(107, 71)
        Me.dtpFechaSiguiente.Name = "dtpFechaSiguiente"
        Me.dtpFechaSiguiente.Size = New System.Drawing.Size(354, 22)
        Me.dtpFechaSiguiente.TabIndex = 58
        '
        'txtOtro
        '
        Me.txtOtro.Enabled = False
        Me.txtOtro.Location = New System.Drawing.Point(285, 141)
        Me.txtOtro.MaxLength = 100
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(191, 22)
        Me.txtOtro.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Programar Cita:"
        '
        'rdbOtro
        '
        Me.rdbOtro.AutoSize = True
        Me.rdbOtro.Location = New System.Drawing.Point(227, 142)
        Me.rdbOtro.Name = "rdbOtro"
        Me.rdbOtro.Size = New System.Drawing.Size(52, 19)
        Me.rdbOtro.TabIndex = 7
        Me.rdbOtro.TabStop = True
        Me.rdbOtro.Text = "Otro:"
        Me.rdbOtro.UseVisualStyleBackColor = True
        '
        'rdbPeluqueria
        '
        Me.rdbPeluqueria.AutoSize = True
        Me.rdbPeluqueria.Location = New System.Drawing.Point(227, 114)
        Me.rdbPeluqueria.Name = "rdbPeluqueria"
        Me.rdbPeluqueria.Size = New System.Drawing.Size(81, 19)
        Me.rdbPeluqueria.TabIndex = 5
        Me.rdbPeluqueria.TabStop = True
        Me.rdbPeluqueria.Text = "Peluquería"
        Me.rdbPeluqueria.UseVisualStyleBackColor = True
        '
        'rdbRefuerzo
        '
        Me.rdbRefuerzo.AutoSize = True
        Me.rdbRefuerzo.Location = New System.Drawing.Point(107, 142)
        Me.rdbRefuerzo.Name = "rdbRefuerzo"
        Me.rdbRefuerzo.Size = New System.Drawing.Size(71, 19)
        Me.rdbRefuerzo.TabIndex = 6
        Me.rdbRefuerzo.TabStop = True
        Me.rdbRefuerzo.Text = "Refuerzo"
        Me.rdbRefuerzo.UseVisualStyleBackColor = True
        '
        'rdbConsulta
        '
        Me.rdbConsulta.AutoSize = True
        Me.rdbConsulta.Location = New System.Drawing.Point(107, 112)
        Me.rdbConsulta.Name = "rdbConsulta"
        Me.rdbConsulta.Size = New System.Drawing.Size(114, 19)
        Me.rdbConsulta.TabIndex = 4
        Me.rdbConsulta.TabStop = True
        Me.rdbConsulta.Text = "Consulta General"
        Me.rdbConsulta.UseVisualStyleBackColor = True
        '
        'txtPropietario
        '
        Me.txtPropietario.Enabled = False
        Me.txtPropietario.Location = New System.Drawing.Point(377, 33)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(171, 22)
        Me.txtPropietario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Propietario:"
        '
        'txtPaciente
        '
        Me.txtPaciente.Enabled = False
        Me.txtPaciente.Location = New System.Drawing.Point(107, 33)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(171, 22)
        Me.txtPaciente.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Motivo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(41, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 15)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Paciente:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(291, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 46)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(154, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 46)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'vetPosponerCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 353)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "vetPosponerCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posponer Citas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPeluqueria As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRefuerzo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbConsulta As System.Windows.Forms.RadioButton
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCitas As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaSiguiente As System.Windows.Forms.DateTimePicker
End Class
