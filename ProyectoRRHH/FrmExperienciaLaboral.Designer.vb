<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExperienciaLaboral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExperienciaLaboral))
        Dim IdExperienciaLaboralLabel As System.Windows.Forms.Label
        Dim NombreEmpresaLabel As System.Windows.Forms.Label
        Dim PeriodoInicioLabel As System.Windows.Forms.Label
        Dim PeriodoTerminoLabel As System.Windows.Forms.Label
        Dim CargoAnteriorLabel As System.Windows.Forms.Label
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim TiempoExperienciaLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.EXPERIENCIA_LABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EXPERIENCIA_LABORALTableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.EXPERIENCIA_LABORALTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.EXPERIENCIA_LABORALBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdExperienciaLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.NombreEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.PeriodoInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PeriodoTerminoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.TiempoExperienciaTextBox = New System.Windows.Forms.TextBox()
        Me.EXPERIENCIA_LABORALDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdExperienciaLaboralLabel = New System.Windows.Forms.Label()
        NombreEmpresaLabel = New System.Windows.Forms.Label()
        PeriodoInicioLabel = New System.Windows.Forms.Label()
        PeriodoTerminoLabel = New System.Windows.Forms.Label()
        CargoAnteriorLabel = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        TiempoExperienciaLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPERIENCIA_LABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPERIENCIA_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EXPERIENCIA_LABORALBindingNavigator.SuspendLayout()
        CType(Me.EXPERIENCIA_LABORALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EXPERIENCIA_LABORALBindingSource
        '
        Me.EXPERIENCIA_LABORALBindingSource.DataMember = "EXPERIENCIA_LABORAL"
        Me.EXPERIENCIA_LABORALBindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'EXPERIENCIA_LABORALTableAdapter
        '
        Me.EXPERIENCIA_LABORALTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BENEFICIO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.BOLETATableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.DATOS_TRIBUTARIOSTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_BENEFICIOTableAdapter = Nothing
        Me.TableAdapterManager.DISTRITOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.EXPERIENCIA_LABORALTableAdapter = Me.EXPERIENCIA_LABORALTableAdapter
        Me.TableAdapterManager.GERENTETableAdapter = Nothing
        Me.TableAdapterManager.MEMORANDUMSTableAdapter = Nothing
        Me.TableAdapterManager.NIVEL_EDUCACIONTableAdapter = Nothing
        Me.TableAdapterManager.PAGO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PERIODO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMO_ADELANTOSTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_PENSIONARIOTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'EXPERIENCIA_LABORALBindingNavigator
        '
        Me.EXPERIENCIA_LABORALBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EXPERIENCIA_LABORALBindingNavigator.BindingSource = Me.EXPERIENCIA_LABORALBindingSource
        Me.EXPERIENCIA_LABORALBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EXPERIENCIA_LABORALBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EXPERIENCIA_LABORALBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EXPERIENCIA_LABORALBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem})
        Me.EXPERIENCIA_LABORALBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EXPERIENCIA_LABORALBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EXPERIENCIA_LABORALBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EXPERIENCIA_LABORALBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EXPERIENCIA_LABORALBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EXPERIENCIA_LABORALBindingNavigator.Name = "EXPERIENCIA_LABORALBindingNavigator"
        Me.EXPERIENCIA_LABORALBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EXPERIENCIA_LABORALBindingNavigator.Size = New System.Drawing.Size(1339, 27)
        Me.EXPERIENCIA_LABORALBindingNavigator.TabIndex = 0
        Me.EXPERIENCIA_LABORALBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 20)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EXPERIENCIA_LABORALBindingNavigatorSaveItem
        '
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem.Image = CType(resources.GetObject("EXPERIENCIA_LABORALBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem.Name = "EXPERIENCIA_LABORALBindingNavigatorSaveItem"
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EXPERIENCIA_LABORALBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdExperienciaLaboralLabel
        '
        IdExperienciaLaboralLabel.AutoSize = True
        IdExperienciaLaboralLabel.Location = New System.Drawing.Point(12, 66)
        IdExperienciaLaboralLabel.Name = "IdExperienciaLaboralLabel"
        IdExperienciaLaboralLabel.Size = New System.Drawing.Size(152, 17)
        IdExperienciaLaboralLabel.TabIndex = 1
        IdExperienciaLaboralLabel.Text = "Id Experiencia Laboral:"
        '
        'IdExperienciaLaboralTextBox
        '
        Me.IdExperienciaLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EXPERIENCIA_LABORALBindingSource, "IdExperienciaLaboral", True))
        Me.IdExperienciaLaboralTextBox.Location = New System.Drawing.Point(170, 63)
        Me.IdExperienciaLaboralTextBox.Name = "IdExperienciaLaboralTextBox"
        Me.IdExperienciaLaboralTextBox.Size = New System.Drawing.Size(268, 22)
        Me.IdExperienciaLaboralTextBox.TabIndex = 2
        '
        'NombreEmpresaLabel
        '
        NombreEmpresaLabel.AutoSize = True
        NombreEmpresaLabel.Location = New System.Drawing.Point(12, 94)
        NombreEmpresaLabel.Name = "NombreEmpresaLabel"
        NombreEmpresaLabel.Size = New System.Drawing.Size(120, 17)
        NombreEmpresaLabel.TabIndex = 3
        NombreEmpresaLabel.Text = "nombre Empresa:"
        '
        'NombreEmpresaTextBox
        '
        Me.NombreEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EXPERIENCIA_LABORALBindingSource, "nombreEmpresa", True))
        Me.NombreEmpresaTextBox.Location = New System.Drawing.Point(170, 91)
        Me.NombreEmpresaTextBox.Name = "NombreEmpresaTextBox"
        Me.NombreEmpresaTextBox.Size = New System.Drawing.Size(268, 22)
        Me.NombreEmpresaTextBox.TabIndex = 4
        '
        'PeriodoInicioLabel
        '
        PeriodoInicioLabel.AutoSize = True
        PeriodoInicioLabel.Location = New System.Drawing.Point(12, 123)
        PeriodoInicioLabel.Name = "PeriodoInicioLabel"
        PeriodoInicioLabel.Size = New System.Drawing.Size(96, 17)
        PeriodoInicioLabel.TabIndex = 5
        PeriodoInicioLabel.Text = "periodo Inicio:"
        '
        'PeriodoInicioDateTimePicker
        '
        Me.PeriodoInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EXPERIENCIA_LABORALBindingSource, "periodoInicio", True))
        Me.PeriodoInicioDateTimePicker.Location = New System.Drawing.Point(170, 119)
        Me.PeriodoInicioDateTimePicker.Name = "PeriodoInicioDateTimePicker"
        Me.PeriodoInicioDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.PeriodoInicioDateTimePicker.TabIndex = 6
        '
        'PeriodoTerminoLabel
        '
        PeriodoTerminoLabel.AutoSize = True
        PeriodoTerminoLabel.Location = New System.Drawing.Point(12, 151)
        PeriodoTerminoLabel.Name = "PeriodoTerminoLabel"
        PeriodoTerminoLabel.Size = New System.Drawing.Size(116, 17)
        PeriodoTerminoLabel.TabIndex = 7
        PeriodoTerminoLabel.Text = "periodo Termino:"
        '
        'PeriodoTerminoDateTimePicker
        '
        Me.PeriodoTerminoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EXPERIENCIA_LABORALBindingSource, "periodoTermino", True))
        Me.PeriodoTerminoDateTimePicker.Location = New System.Drawing.Point(170, 147)
        Me.PeriodoTerminoDateTimePicker.Name = "PeriodoTerminoDateTimePicker"
        Me.PeriodoTerminoDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.PeriodoTerminoDateTimePicker.TabIndex = 8
        '
        'CargoAnteriorLabel
        '
        CargoAnteriorLabel.AutoSize = True
        CargoAnteriorLabel.Location = New System.Drawing.Point(12, 178)
        CargoAnteriorLabel.Name = "CargoAnteriorLabel"
        CargoAnteriorLabel.Size = New System.Drawing.Size(102, 17)
        CargoAnteriorLabel.TabIndex = 9
        CargoAnteriorLabel.Text = "cargo Anterior:"
        '
        'CargoAnteriorTextBox
        '
        Me.CargoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EXPERIENCIA_LABORALBindingSource, "cargoAnterior", True))
        Me.CargoAnteriorTextBox.Location = New System.Drawing.Point(170, 175)
        Me.CargoAnteriorTextBox.Name = "CargoAnteriorTextBox"
        Me.CargoAnteriorTextBox.Size = New System.Drawing.Size(268, 22)
        Me.CargoAnteriorTextBox.TabIndex = 10
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(12, 206)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(90, 17)
        IdEmpleadoLabel.TabIndex = 11
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EXPERIENCIA_LABORALBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(170, 203)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(268, 22)
        Me.IdEmpleadoTextBox.TabIndex = 12
        '
        'TiempoExperienciaLabel
        '
        TiempoExperienciaLabel.AutoSize = True
        TiempoExperienciaLabel.Location = New System.Drawing.Point(12, 234)
        TiempoExperienciaLabel.Name = "TiempoExperienciaLabel"
        TiempoExperienciaLabel.Size = New System.Drawing.Size(136, 17)
        TiempoExperienciaLabel.TabIndex = 13
        TiempoExperienciaLabel.Text = "Tiempo Experiencia:"
        '
        'TiempoExperienciaTextBox
        '
        Me.TiempoExperienciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EXPERIENCIA_LABORALBindingSource, "TiempoExperiencia", True))
        Me.TiempoExperienciaTextBox.Location = New System.Drawing.Point(170, 231)
        Me.TiempoExperienciaTextBox.Name = "TiempoExperienciaTextBox"
        Me.TiempoExperienciaTextBox.Size = New System.Drawing.Size(268, 22)
        Me.TiempoExperienciaTextBox.TabIndex = 14
        '
        'EXPERIENCIA_LABORALDataGridView
        '
        Me.EXPERIENCIA_LABORALDataGridView.AutoGenerateColumns = False
        Me.EXPERIENCIA_LABORALDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EXPERIENCIA_LABORALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EXPERIENCIA_LABORALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EXPERIENCIA_LABORALDataGridView.DataSource = Me.EXPERIENCIA_LABORALBindingSource
        Me.EXPERIENCIA_LABORALDataGridView.Location = New System.Drawing.Point(457, 66)
        Me.EXPERIENCIA_LABORALDataGridView.Name = "EXPERIENCIA_LABORALDataGridView"
        Me.EXPERIENCIA_LABORALDataGridView.RowTemplate.Height = 24
        Me.EXPERIENCIA_LABORALDataGridView.Size = New System.Drawing.Size(860, 259)
        Me.EXPERIENCIA_LABORALDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdExperienciaLaboral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdExperienciaLaboral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreEmpresa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreEmpresa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "periodoInicio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "periodoInicio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "periodoTermino"
        Me.DataGridViewTextBoxColumn4.HeaderText = "periodoTermino"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cargoAnterior"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cargoAnterior"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TiempoExperiencia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TiempoExperiencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'FrmExperienciaLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 432)
        Me.Controls.Add(Me.EXPERIENCIA_LABORALDataGridView)
        Me.Controls.Add(IdExperienciaLaboralLabel)
        Me.Controls.Add(Me.IdExperienciaLaboralTextBox)
        Me.Controls.Add(NombreEmpresaLabel)
        Me.Controls.Add(Me.NombreEmpresaTextBox)
        Me.Controls.Add(PeriodoInicioLabel)
        Me.Controls.Add(Me.PeriodoInicioDateTimePicker)
        Me.Controls.Add(PeriodoTerminoLabel)
        Me.Controls.Add(Me.PeriodoTerminoDateTimePicker)
        Me.Controls.Add(CargoAnteriorLabel)
        Me.Controls.Add(Me.CargoAnteriorTextBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(TiempoExperienciaLabel)
        Me.Controls.Add(Me.TiempoExperienciaTextBox)
        Me.Controls.Add(Me.EXPERIENCIA_LABORALBindingNavigator)
        Me.Name = "FrmExperienciaLaboral"
        Me.Text = "Experiencia_Laboral"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPERIENCIA_LABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPERIENCIA_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EXPERIENCIA_LABORALBindingNavigator.ResumeLayout(False)
        Me.EXPERIENCIA_LABORALBindingNavigator.PerformLayout()
        CType(Me.EXPERIENCIA_LABORALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents EXPERIENCIA_LABORALBindingSource As BindingSource
    Friend WithEvents EXPERIENCIA_LABORALTableAdapter As DB_RRHHDataSetTableAdapters.EXPERIENCIA_LABORALTableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EXPERIENCIA_LABORALBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EXPERIENCIA_LABORALBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdExperienciaLaboralTextBox As TextBox
    Friend WithEvents NombreEmpresaTextBox As TextBox
    Friend WithEvents PeriodoInicioDateTimePicker As DateTimePicker
    Friend WithEvents PeriodoTerminoDateTimePicker As DateTimePicker
    Friend WithEvents CargoAnteriorTextBox As TextBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents TiempoExperienciaTextBox As TextBox
    Friend WithEvents EXPERIENCIA_LABORALDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
