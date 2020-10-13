<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoPlanilla))
        Dim IdPagoPlanillaLabel As System.Windows.Forms.Label
        Dim IdPlanillaLabel As System.Windows.Forms.Label
        Dim DiasHabilesLabel As System.Windows.Forms.Label
        Dim BeneficioTotalLabel As System.Windows.Forms.Label
        Dim PrestamoLabel As System.Windows.Forms.Label
        Dim SueldoTotalLabel As System.Windows.Forms.Label
        Dim MontoAFPLabel As System.Windows.Forms.Label
        Dim MontoCTSLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.PAGO_PLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAGO_PLANILLATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.PAGO_PLANILLATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.PAGO_PLANILLABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PAGO_PLANILLABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPagoPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.IdPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.DiasHabilesTextBox = New System.Windows.Forms.TextBox()
        Me.BeneficioTotalTextBox = New System.Windows.Forms.TextBox()
        Me.PrestamoTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoTotalTextBox = New System.Windows.Forms.TextBox()
        Me.MontoAFPTextBox = New System.Windows.Forms.TextBox()
        Me.MontoCTSTextBox = New System.Windows.Forms.TextBox()
        Me.PAGO_PLANILLADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPagoPlanillaLabel = New System.Windows.Forms.Label()
        IdPlanillaLabel = New System.Windows.Forms.Label()
        DiasHabilesLabel = New System.Windows.Forms.Label()
        BeneficioTotalLabel = New System.Windows.Forms.Label()
        PrestamoLabel = New System.Windows.Forms.Label()
        SueldoTotalLabel = New System.Windows.Forms.Label()
        MontoAFPLabel = New System.Windows.Forms.Label()
        MontoCTSLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAGO_PLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAGO_PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAGO_PLANILLABindingNavigator.SuspendLayout()
        CType(Me.PAGO_PLANILLADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAGO_PLANILLABindingSource
        '
        Me.PAGO_PLANILLABindingSource.DataMember = "PAGO_PLANILLA"
        Me.PAGO_PLANILLABindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'PAGO_PLANILLATableAdapter
        '
        Me.PAGO_PLANILLATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EXPERIENCIA_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.GERENTETableAdapter = Nothing
        Me.TableAdapterManager.MEMORANDUMSTableAdapter = Nothing
        Me.TableAdapterManager.NIVEL_EDUCACIONTableAdapter = Nothing
        Me.TableAdapterManager.PAGO_PLANILLATableAdapter = Me.PAGO_PLANILLATableAdapter
        Me.TableAdapterManager.PERIODO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMO_ADELANTOSTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_PENSIONARIOTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'PAGO_PLANILLABindingNavigator
        '
        Me.PAGO_PLANILLABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PAGO_PLANILLABindingNavigator.BindingSource = Me.PAGO_PLANILLABindingSource
        Me.PAGO_PLANILLABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PAGO_PLANILLABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PAGO_PLANILLABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PAGO_PLANILLABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PAGO_PLANILLABindingNavigatorSaveItem})
        Me.PAGO_PLANILLABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PAGO_PLANILLABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PAGO_PLANILLABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PAGO_PLANILLABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PAGO_PLANILLABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PAGO_PLANILLABindingNavigator.Name = "PAGO_PLANILLABindingNavigator"
        Me.PAGO_PLANILLABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PAGO_PLANILLABindingNavigator.Size = New System.Drawing.Size(990, 27)
        Me.PAGO_PLANILLABindingNavigator.TabIndex = 0
        Me.PAGO_PLANILLABindingNavigator.Text = "BindingNavigator1"
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
        'PAGO_PLANILLABindingNavigatorSaveItem
        '
        Me.PAGO_PLANILLABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PAGO_PLANILLABindingNavigatorSaveItem.Image = CType(resources.GetObject("PAGO_PLANILLABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PAGO_PLANILLABindingNavigatorSaveItem.Name = "PAGO_PLANILLABindingNavigatorSaveItem"
        Me.PAGO_PLANILLABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PAGO_PLANILLABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPagoPlanillaLabel
        '
        IdPagoPlanillaLabel.AutoSize = True
        IdPagoPlanillaLabel.Location = New System.Drawing.Point(23, 43)
        IdPagoPlanillaLabel.Name = "IdPagoPlanillaLabel"
        IdPagoPlanillaLabel.Size = New System.Drawing.Size(109, 17)
        IdPagoPlanillaLabel.TabIndex = 1
        IdPagoPlanillaLabel.Text = "Id Pago Planilla:"
        '
        'IdPagoPlanillaTextBox
        '
        Me.IdPagoPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "IdPagoPlanilla", True))
        Me.IdPagoPlanillaTextBox.Location = New System.Drawing.Point(138, 40)
        Me.IdPagoPlanillaTextBox.Name = "IdPagoPlanillaTextBox"
        Me.IdPagoPlanillaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdPagoPlanillaTextBox.TabIndex = 2
        '
        'IdPlanillaLabel
        '
        IdPlanillaLabel.AutoSize = True
        IdPlanillaLabel.Location = New System.Drawing.Point(23, 71)
        IdPlanillaLabel.Name = "IdPlanillaLabel"
        IdPlanillaLabel.Size = New System.Drawing.Size(72, 17)
        IdPlanillaLabel.TabIndex = 3
        IdPlanillaLabel.Text = "Id Planilla:"
        '
        'IdPlanillaTextBox
        '
        Me.IdPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "IdPlanilla", True))
        Me.IdPlanillaTextBox.Location = New System.Drawing.Point(138, 68)
        Me.IdPlanillaTextBox.Name = "IdPlanillaTextBox"
        Me.IdPlanillaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdPlanillaTextBox.TabIndex = 4
        '
        'DiasHabilesLabel
        '
        DiasHabilesLabel.AutoSize = True
        DiasHabilesLabel.Location = New System.Drawing.Point(23, 99)
        DiasHabilesLabel.Name = "DiasHabilesLabel"
        DiasHabilesLabel.Size = New System.Drawing.Size(91, 17)
        DiasHabilesLabel.TabIndex = 5
        DiasHabilesLabel.Text = "Dias Habiles:"
        '
        'DiasHabilesTextBox
        '
        Me.DiasHabilesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "DiasHabiles", True))
        Me.DiasHabilesTextBox.Location = New System.Drawing.Point(138, 96)
        Me.DiasHabilesTextBox.Name = "DiasHabilesTextBox"
        Me.DiasHabilesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DiasHabilesTextBox.TabIndex = 6
        '
        'BeneficioTotalLabel
        '
        BeneficioTotalLabel.AutoSize = True
        BeneficioTotalLabel.Location = New System.Drawing.Point(23, 127)
        BeneficioTotalLabel.Name = "BeneficioTotalLabel"
        BeneficioTotalLabel.Size = New System.Drawing.Size(105, 17)
        BeneficioTotalLabel.TabIndex = 7
        BeneficioTotalLabel.Text = "beneficio Total:"
        '
        'BeneficioTotalTextBox
        '
        Me.BeneficioTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "beneficioTotal", True))
        Me.BeneficioTotalTextBox.Location = New System.Drawing.Point(138, 124)
        Me.BeneficioTotalTextBox.Name = "BeneficioTotalTextBox"
        Me.BeneficioTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BeneficioTotalTextBox.TabIndex = 8
        '
        'PrestamoLabel
        '
        PrestamoLabel.AutoSize = True
        PrestamoLabel.Location = New System.Drawing.Point(331, 40)
        PrestamoLabel.Name = "PrestamoLabel"
        PrestamoLabel.Size = New System.Drawing.Size(72, 17)
        PrestamoLabel.TabIndex = 9
        PrestamoLabel.Text = "Prestamo:"
        '
        'PrestamoTextBox
        '
        Me.PrestamoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "Prestamo", True))
        Me.PrestamoTextBox.Location = New System.Drawing.Point(446, 37)
        Me.PrestamoTextBox.Name = "PrestamoTextBox"
        Me.PrestamoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PrestamoTextBox.TabIndex = 10
        '
        'SueldoTotalLabel
        '
        SueldoTotalLabel.AutoSize = True
        SueldoTotalLabel.Location = New System.Drawing.Point(331, 68)
        SueldoTotalLabel.Name = "SueldoTotalLabel"
        SueldoTotalLabel.Size = New System.Drawing.Size(90, 17)
        SueldoTotalLabel.TabIndex = 11
        SueldoTotalLabel.Text = "sueldo Total:"
        '
        'SueldoTotalTextBox
        '
        Me.SueldoTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "sueldoTotal", True))
        Me.SueldoTotalTextBox.Location = New System.Drawing.Point(446, 65)
        Me.SueldoTotalTextBox.Name = "SueldoTotalTextBox"
        Me.SueldoTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SueldoTotalTextBox.TabIndex = 12
        '
        'MontoAFPLabel
        '
        MontoAFPLabel.AutoSize = True
        MontoAFPLabel.Location = New System.Drawing.Point(331, 96)
        MontoAFPLabel.Name = "MontoAFPLabel"
        MontoAFPLabel.Size = New System.Drawing.Size(81, 17)
        MontoAFPLabel.TabIndex = 13
        MontoAFPLabel.Text = "monto AFP:"
        '
        'MontoAFPTextBox
        '
        Me.MontoAFPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "montoAFP", True))
        Me.MontoAFPTextBox.Location = New System.Drawing.Point(446, 93)
        Me.MontoAFPTextBox.Name = "MontoAFPTextBox"
        Me.MontoAFPTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MontoAFPTextBox.TabIndex = 14
        '
        'MontoCTSLabel
        '
        MontoCTSLabel.AutoSize = True
        MontoCTSLabel.Location = New System.Drawing.Point(331, 124)
        MontoCTSLabel.Name = "MontoCTSLabel"
        MontoCTSLabel.Size = New System.Drawing.Size(82, 17)
        MontoCTSLabel.TabIndex = 15
        MontoCTSLabel.Text = "monto CTS:"
        '
        'MontoCTSTextBox
        '
        Me.MontoCTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAGO_PLANILLABindingSource, "montoCTS", True))
        Me.MontoCTSTextBox.Location = New System.Drawing.Point(446, 121)
        Me.MontoCTSTextBox.Name = "MontoCTSTextBox"
        Me.MontoCTSTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MontoCTSTextBox.TabIndex = 16
        '
        'PAGO_PLANILLADataGridView
        '
        Me.PAGO_PLANILLADataGridView.AutoGenerateColumns = False
        Me.PAGO_PLANILLADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PAGO_PLANILLADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PAGO_PLANILLADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PAGO_PLANILLADataGridView.DataSource = Me.PAGO_PLANILLABindingSource
        Me.PAGO_PLANILLADataGridView.Location = New System.Drawing.Point(12, 167)
        Me.PAGO_PLANILLADataGridView.Name = "PAGO_PLANILLADataGridView"
        Me.PAGO_PLANILLADataGridView.RowTemplate.Height = 24
        Me.PAGO_PLANILLADataGridView.Size = New System.Drawing.Size(892, 220)
        Me.PAGO_PLANILLADataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPagoPlanilla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPagoPlanilla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdPlanilla"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdPlanilla"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DiasHabiles"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DiasHabiles"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "beneficioTotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "beneficioTotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Prestamo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prestamo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sueldoTotal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "sueldoTotal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "montoAFP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "montoAFP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "montoCTS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "montoCTS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'FrmPagoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 491)
        Me.Controls.Add(Me.PAGO_PLANILLADataGridView)
        Me.Controls.Add(IdPagoPlanillaLabel)
        Me.Controls.Add(Me.IdPagoPlanillaTextBox)
        Me.Controls.Add(IdPlanillaLabel)
        Me.Controls.Add(Me.IdPlanillaTextBox)
        Me.Controls.Add(DiasHabilesLabel)
        Me.Controls.Add(Me.DiasHabilesTextBox)
        Me.Controls.Add(BeneficioTotalLabel)
        Me.Controls.Add(Me.BeneficioTotalTextBox)
        Me.Controls.Add(PrestamoLabel)
        Me.Controls.Add(Me.PrestamoTextBox)
        Me.Controls.Add(SueldoTotalLabel)
        Me.Controls.Add(Me.SueldoTotalTextBox)
        Me.Controls.Add(MontoAFPLabel)
        Me.Controls.Add(Me.MontoAFPTextBox)
        Me.Controls.Add(MontoCTSLabel)
        Me.Controls.Add(Me.MontoCTSTextBox)
        Me.Controls.Add(Me.PAGO_PLANILLABindingNavigator)
        Me.Name = "FrmPagoPlanilla"
        Me.Text = "PagoPlanilla"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAGO_PLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAGO_PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAGO_PLANILLABindingNavigator.ResumeLayout(False)
        Me.PAGO_PLANILLABindingNavigator.PerformLayout()
        CType(Me.PAGO_PLANILLADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents PAGO_PLANILLABindingSource As BindingSource
    Friend WithEvents PAGO_PLANILLATableAdapter As BD_RecursosHumanosDataSetTableAdapters.PAGO_PLANILLATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PAGO_PLANILLABindingNavigator As BindingNavigator
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
    Friend WithEvents PAGO_PLANILLABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPagoPlanillaTextBox As TextBox
    Friend WithEvents IdPlanillaTextBox As TextBox
    Friend WithEvents DiasHabilesTextBox As TextBox
    Friend WithEvents BeneficioTotalTextBox As TextBox
    Friend WithEvents PrestamoTextBox As TextBox
    Friend WithEvents SueldoTotalTextBox As TextBox
    Friend WithEvents MontoAFPTextBox As TextBox
    Friend WithEvents MontoCTSTextBox As TextBox
    Friend WithEvents PAGO_PLANILLADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
