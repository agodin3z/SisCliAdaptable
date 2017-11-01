<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medAgenda
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCompletas = New System.Windows.Forms.CheckBox()
        Me.chkTodo = New System.Windows.Forms.CheckBox()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCompletas)
        Me.GroupBox1.Controls.Add(Me.chkTodo)
        Me.GroupBox1.Controls.Add(Me.dgvCitas)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 344)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Citas"
        '
        'chkCompletas
        '
        Me.chkCompletas.AutoSize = True
        Me.chkCompletas.Location = New System.Drawing.Point(467, 23)
        Me.chkCompletas.Name = "chkCompletas"
        Me.chkCompletas.Size = New System.Drawing.Size(152, 19)
        Me.chkCompletas.TabIndex = 4
        Me.chkCompletas.Text = "Mostrar las completadas"
        Me.chkCompletas.UseVisualStyleBackColor = True
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Location = New System.Drawing.Point(285, 23)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(176, 19)
        Me.chkTodo.TabIndex = 3
        Me.chkTodo.Text = "Mostrar todas las pendientes"
        Me.chkTodo.UseVisualStyleBackColor = True
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AllowUserToDeleteRows = False
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Location = New System.Drawing.Point(6, 52)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.ReadOnly = True
        Me.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitas.Size = New System.Drawing.Size(947, 286)
        Me.dgvCitas.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MM-dd-yyyy"
        Me.dtpFecha.Location = New System.Drawing.Point(52, 21)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(215, 22)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'medAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 368)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "medAgenda"
        Me.Text = "Agenda del Día"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCompletas As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodo As System.Windows.Forms.CheckBox
    Friend WithEvents dgvCitas As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
