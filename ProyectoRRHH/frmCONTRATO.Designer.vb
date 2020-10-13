<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONTRATO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCONTRATO))
        Dim IdContratoLabel As System.Windows.Forms.Label
        Dim IdPeriodoLaboralLabel As System.Windows.Forms.Label
        Dim HorarioLaboralLabel As System.Windows.Forms.Label
        Dim IdTipoTrabajadorLabel As System.Windows.Forms.Label
        Dim IdAreaLabel As System.Windows.Forms.Label
        Dim RegimenLaboralLabel As System.Windows.Forms.Label
        Dim IdTipoContratoLabel As System.Windows.Forms.Label
        Dim SueldoContratoLabel As System.Windows.Forms.Label
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.CONTRATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRATOTableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.CONTRATOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.CONTRATOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CONTRATOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdContratoTextBox = New System.Windows.Forms.TextBox()
        Me.IdPeriodoLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.HorarioLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoTrabajadorTextBox = New System.Windows.Forms.TextBox()
        Me.IdAreaTextBox = New System.Windows.Forms.TextBox()
        Me.RegimenLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CONTRATODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdContratoLabel = New System.Windows.Forms.Label()
        IdPeriodoLaboralLabel = New System.Windows.Forms.Label()
        HorarioLaboralLabel = New System.Windows.Forms.Label()
        IdTipoTrabajadorLabel = New System.Windows.Forms.Label()
        IdAreaLabel = New System.Windows.Forms.Label()
        RegimenLaboralLabel = New System.Windows.Forms.Label()
        IdTipoContratoLabel = New System.Windows.Forms.Label()
        SueldoContratoLabel = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTRATOBindingNavigator.SuspendLayout()
        CType(Me.CONTRATODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRATOBindingSource
        '
        Me.CONTRATOBindingSource.DataMember = "CONTRATO"
        Me.CONTRATOBindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'CONTRATOTableAdapter
        '
        Me.CONTRATOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BENEFICIO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.BOLETATableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Me.CONTRATOTableAdapter
        Me.TableAdapterManager.DATOS_TRIBUTARIOSTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_BENEFICIOTableAdapter = Nothing
        Me.TableAdapterManager.DISTRITOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager.EXPERIENCIA_LABORALTableAdapter = Nothing
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
        'CONTRATOBindingNavigator
        '
        Me.CONTRATOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONTRATOBindingNavigator.BindingSource = Me.CONTRATOBindingSource
        Me.CONTRATOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONTRATOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONTRATOBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CONTRATOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONTRATOBindingNavigatorSaveItem})
        Me.CONTRATOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONTRATOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONTRATOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONTRATOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONTRATOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONTRATOBindingNavigator.Name = "CONTRATOBindingNavigator"
        Me.CONTRATOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONTRATOBindingNavigator.Size = New System.Drawing.Size(1030, 31)
        Me.CONTRATOBindingNavigator.TabIndex = 0
        Me.CONTRATOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 25)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CONTRATOBindingNavigatorSaveItem
        '
        Me.CONTRATOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONTRATOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONTRATOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONTRATOBindingNavigatorSaveItem.Name = "CONTRATOBindingNavigatorSaveItem"
        Me.CONTRATOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CONTRATOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(28, 74)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(93, 20)
        IdContratoLabel.TabIndex = 1
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(186, 71)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdContratoTextBox.TabIndex = 2
        '
        'IdPeriodoLaboralLabel
        '
        IdPeriodoLaboralLabel.AutoSize = True
        IdPeriodoLaboralLabel.Location = New System.Drawing.Point(339, 77)
        IdPeriodoLaboralLabel.Name = "IdPeriodoLaboralLabel"
        IdPeriodoLaboralLabel.Size = New System.Drawing.Size(142, 20)
        IdPeriodoLaboralLabel.TabIndex = 3
        IdPeriodoLaboralLabel.Text = "Id Periodo Laboral:"
        '
        'IdPeriodoLaboralTextBox
        '
        Me.IdPeriodoLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdPeriodoLaboral", True))
        Me.IdPeriodoLaboralTextBox.Location = New System.Drawing.Point(521, 74)
        Me.IdPeriodoLaboralTextBox.Name = "IdPeriodoLaboralTextBox"
        Me.IdPeriodoLaboralTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdPeriodoLaboralTextBox.TabIndex = 4
        '
        'HorarioLaboralLabel
        '
        HorarioLaboralLabel.AutoSize = True
        HorarioLaboralLabel.Location = New System.Drawing.Point(682, 80)
        HorarioLaboralLabel.Name = "HorarioLaboralLabel"
        HorarioLaboralLabel.Size = New System.Drawing.Size(119, 20)
        HorarioLaboralLabel.TabIndex = 5
        HorarioLaboralLabel.Text = "horario Laboral:"
        '
        'HorarioLaboralTextBox
        '
        Me.HorarioLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "horarioLaboral", True))
        Me.HorarioLaboralTextBox.Location = New System.Drawing.Point(830, 77)
        Me.HorarioLaboralTextBox.Name = "HorarioLaboralTextBox"
        Me.HorarioLaboralTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HorarioLaboralTextBox.TabIndex = 6
        '
        'IdTipoTrabajadorLabel
        '
        IdTipoTrabajadorLabel.AutoSize = True
        IdTipoTrabajadorLabel.Location = New System.Drawing.Point(28, 142)
        IdTipoTrabajadorLabel.Name = "IdTipoTrabajadorLabel"
        IdTipoTrabajadorLabel.Size = New System.Drawing.Size(141, 20)
        IdTipoTrabajadorLabel.TabIndex = 7
        IdTipoTrabajadorLabel.Text = "Id Tipo Trabajador:"
        '
        'IdTipoTrabajadorTextBox
        '
        Me.IdTipoTrabajadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdTipoTrabajador", True))
        Me.IdTipoTrabajadorTextBox.Location = New System.Drawing.Point(186, 139)
        Me.IdTipoTrabajadorTextBox.Name = "IdTipoTrabajadorTextBox"
        Me.IdTipoTrabajadorTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdTipoTrabajadorTextBox.TabIndex = 8
        '
        'IdAreaLabel
        '
        IdAreaLabel.AutoSize = True
        IdAreaLabel.Location = New System.Drawing.Point(339, 142)
        IdAreaLabel.Name = "IdAreaLabel"
        IdAreaLabel.Size = New System.Drawing.Size(65, 20)
        IdAreaLabel.TabIndex = 9
        IdAreaLabel.Text = "Id Area:"
        '
        'IdAreaTextBox
        '
        Me.IdAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdArea", True))
        Me.IdAreaTextBox.Location = New System.Drawing.Point(521, 139)
        Me.IdAreaTextBox.Name = "IdAreaTextBox"
        Me.IdAreaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdAreaTextBox.TabIndex = 10
        '
        'RegimenLaboralLabel
        '
        RegimenLaboralLabel.AutoSize = True
        RegimenLaboralLabel.Location = New System.Drawing.Point(682, 145)
        RegimenLaboralLabel.Name = "RegimenLaboralLabel"
        RegimenLaboralLabel.Size = New System.Drawing.Size(127, 20)
        RegimenLaboralLabel.TabIndex = 11
        RegimenLaboralLabel.Text = "regimen Laboral:"
        '
        'RegimenLaboralTextBox
        '
        Me.RegimenLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "regimenLaboral", True))
        Me.RegimenLaboralTextBox.Location = New System.Drawing.Point(830, 145)
        Me.RegimenLaboralTextBox.Name = "RegimenLaboralTextBox"
        Me.RegimenLaboralTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RegimenLaboralTextBox.TabIndex = 12
        '
        'IdTipoContratoLabel
        '
        IdTipoContratoLabel.AutoSize = True
        IdTipoContratoLabel.Location = New System.Drawing.Point(28, 213)
        IdTipoContratoLabel.Name = "IdTipoContratoLabel"
        IdTipoContratoLabel.Size = New System.Drawing.Size(127, 20)
        IdTipoContratoLabel.TabIndex = 13
        IdTipoContratoLabel.Text = "Id Tipo Contrato:"
        '
        'IdTipoContratoTextBox
        '
        Me.IdTipoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdTipoContrato", True))
        Me.IdTipoContratoTextBox.Location = New System.Drawing.Point(186, 213)
        Me.IdTipoContratoTextBox.Name = "IdTipoContratoTextBox"
        Me.IdTipoContratoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdTipoContratoTextBox.TabIndex = 14
        '
        'SueldoContratoLabel
        '
        SueldoContratoLabel.AutoSize = True
        SueldoContratoLabel.Location = New System.Drawing.Point(339, 216)
        SueldoContratoLabel.Name = "SueldoContratoLabel"
        SueldoContratoLabel.Size = New System.Drawing.Size(126, 20)
        SueldoContratoLabel.TabIndex = 15
        SueldoContratoLabel.Text = "sueldo Contrato:"
        '
        'SueldoContratoTextBox
        '
        Me.SueldoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "sueldoContrato", True))
        Me.SueldoContratoTextBox.Location = New System.Drawing.Point(521, 213)
        Me.SueldoContratoTextBox.Name = "SueldoContratoTextBox"
        Me.SueldoContratoTextBox.Size = New System.Drawing.Size(127, 26)
        Me.SueldoContratoTextBox.TabIndex = 16
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(682, 219)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(103, 20)
        IdEmpleadoLabel.TabIndex = 17
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(830, 213)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdEmpleadoTextBox.TabIndex = 18
        '
        'CONTRATODataGridView
        '
        Me.CONTRATODataGridView.AutoGenerateColumns = False
        Me.CONTRATODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CONTRATODataGridView.DataSource = Me.CONTRATOBindingSource
        Me.CONTRATODataGridView.Location = New System.Drawing.Point(12, 300)
        Me.CONTRATODataGridView.Name = "CONTRATODataGridView"
        Me.CONTRATODataGridView.RowTemplate.Height = 28
        Me.CONTRATODataGridView.Size = New System.Drawing.Size(1003, 220)
        Me.CONTRATODataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "horarioLaboral"
        Me.DataGridViewTextBoxColumn3.HeaderText = "horarioLaboral"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdTipoTrabajador"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdTipoTrabajador"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdArea"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdArea"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "regimenLaboral"
        Me.DataGridViewTextBoxColumn6.HeaderText = "regimenLaboral"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdTipoContrato"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdTipoContrato"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sueldoContrato"
        Me.DataGridViewTextBoxColumn8.HeaderText = "sueldoContrato"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frmCONTRATO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 626)
        Me.Controls.Add(Me.CONTRATODataGridView)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(IdPeriodoLaboralLabel)
        Me.Controls.Add(Me.IdPeriodoLaboralTextBox)
        Me.Controls.Add(HorarioLaboralLabel)
        Me.Controls.Add(Me.HorarioLaboralTextBox)
        Me.Controls.Add(IdTipoTrabajadorLabel)
        Me.Controls.Add(Me.IdTipoTrabajadorTextBox)
        Me.Controls.Add(IdAreaLabel)
        Me.Controls.Add(Me.IdAreaTextBox)
        Me.Controls.Add(RegimenLaboralLabel)
        Me.Controls.Add(Me.RegimenLaboralTextBox)
        Me.Controls.Add(IdTipoContratoLabel)
        Me.Controls.Add(Me.IdTipoContratoTextBox)
        Me.Controls.Add(SueldoContratoLabel)
        Me.Controls.Add(Me.SueldoContratoTextBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(Me.CONTRATOBindingNavigator)
        Me.Name = "frmCONTRATO"
        Me.Text = "MANTENEDOR DE CONTRATO"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTRATOBindingNavigator.ResumeLayout(False)
        Me.CONTRATOBindingNavigator.PerformLayout()
        CType(Me.CONTRATODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents CONTRATOBindingSource As BindingSource
    Friend WithEvents CONTRATOTableAdapter As DB_RRHHDataSetTableAdapters.CONTRATOTableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONTRATOBindingNavigator As BindingNavigator
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
    Friend WithEvents CONTRATOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdContratoTextBox As TextBox
    Friend WithEvents IdPeriodoLaboralTextBox As TextBox
    Friend WithEvents HorarioLaboralTextBox As TextBox
    Friend WithEvents IdTipoTrabajadorTextBox As TextBox
    Friend WithEvents IdAreaTextBox As TextBox
    Friend WithEvents RegimenLaboralTextBox As TextBox
    Friend WithEvents IdTipoContratoTextBox As TextBox
    Friend WithEvents SueldoContratoTextBox As TextBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents CONTRATODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
