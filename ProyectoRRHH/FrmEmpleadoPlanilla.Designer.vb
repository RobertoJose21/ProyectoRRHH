<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleadoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleadoPlanilla))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TIPOPLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_RecursosHumanosDataSet1 = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.PLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANILLATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.PLANILLATableAdapter()
        Me.TIPO_PLANILLATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TIPO_PLANILLATableAdapter()
        CType(Me.TIPOPLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_RecursosHumanosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿ESTA EN PLANILLA?"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TIPOPLANILLABindingSource, "tipoPlanilla", True))
        Me.ComboBox1.DataSource = Me.TIPOPLANILLABindingSource
        Me.ComboBox1.DisplayMember = "tipoPlanilla"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(370, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 24)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "tipoPlanilla"
        '
        'TIPOPLANILLABindingSource
        '
        Me.TIPOPLANILLABindingSource.DataMember = "TIPO_PLANILLA"
        Me.TIPOPLANILLABindingSource.DataSource = Me.BD_RecursosHumanosDataSet1
        '
        'BD_RecursosHumanosDataSet1
        '
        Me.BD_RecursosHumanosDataSet1.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(175, 106)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(408, 247)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DESCRIPCION PLANILLA"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE EMPLEADO"
        Me.ColumnHeader2.Width = 250
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLANILLABindingSource
        '
        Me.PLANILLABindingSource.DataMember = "PLANILLA"
        Me.PLANILLABindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'PLANILLATableAdapter
        '
        Me.PLANILLATableAdapter.ClearBeforeFill = True
        '
        'TIPO_PLANILLATableAdapter
        '
        Me.TIPO_PLANILLATableAdapter.ClearBeforeFill = True
        '
        'FrmEmpleadoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 377)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEmpleadoPlanilla"
        Me.Text = "EmpleadoPlanilla"
        CType(Me.TIPOPLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_RecursosHumanosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents PLANILLABindingSource As BindingSource
    Friend WithEvents PLANILLATableAdapter As BD_RecursosHumanosDataSetTableAdapters.PLANILLATableAdapter
    Friend WithEvents BD_RecursosHumanosDataSet1 As BD_RecursosHumanosDataSet
    Friend WithEvents TIPOPLANILLABindingSource As BindingSource
    Friend WithEvents TIPO_PLANILLATableAdapter As BD_RecursosHumanosDataSetTableAdapters.TIPO_PLANILLATableAdapter
End Class
