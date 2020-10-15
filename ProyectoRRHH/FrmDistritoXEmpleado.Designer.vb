<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDistritoXEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDistritoXEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DISTRITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VApellidosyNombresEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_ApellidosyNombresEmpleadosTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.V_ApellidosyNombresEmpleadosTableAdapter()
        Me.DISTRITOTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.DISTRITOTableAdapter()
        CType(Me.DISTRITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VApellidosyNombresEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL DISTRITO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DISTRITOBindingSource, "NombreDistrito", True))
        Me.ComboBox1.DataSource = Me.DISTRITOBindingSource
        Me.ComboBox1.DisplayMember = "NombreDistrito"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(315, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(369, 24)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "NombreDistrito"
        '
        'DISTRITOBindingSource
        '
        Me.DISTRITOBindingSource.DataMember = "DISTRITO"
        Me.DISTRITOBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(67, 109)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(805, 237)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DISTRITO"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PERIODO DE CONTRATACION"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "NOMBRE DEL EMPLEADO"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SUELDO"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "AREA"
        Me.ColumnHeader5.Width = 150
        '
        'VApellidosyNombresEmpleadosBindingSource
        '
        Me.VApellidosyNombresEmpleadosBindingSource.DataMember = "V_ApellidosyNombresEmpleados"
        Me.VApellidosyNombresEmpleadosBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'V_ApellidosyNombresEmpleadosTableAdapter
        '
        Me.V_ApellidosyNombresEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'DISTRITOTableAdapter
        '
        Me.DISTRITOTableAdapter.ClearBeforeFill = True
        '
        'FrmDistritoXEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 423)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDistritoXEmpleado"
        Me.Text = "DistritoXEmpleado"
        CType(Me.DISTRITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VApellidosyNombresEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents VApellidosyNombresEmpleadosBindingSource As BindingSource
    Friend WithEvents V_ApellidosyNombresEmpleadosTableAdapter As BD_RecursosHumanosDataSetTableAdapters.V_ApellidosyNombresEmpleadosTableAdapter
    Friend WithEvents DISTRITOBindingSource As BindingSource
    Friend WithEvents DISTRITOTableAdapter As BD_RecursosHumanosDataSetTableAdapters.DISTRITOTableAdapter
End Class
