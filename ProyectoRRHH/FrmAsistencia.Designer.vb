<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsistencia))
        Dim IdAsistenciaLabel As System.Windows.Forms.Label
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdTipoAsistenciaLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.ASISTENCIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASISTENCIATableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.ASISTENCIATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.ASISTENCIABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ASISTENCIABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.ASISTENCIABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASISTENCIATableAdapter1 = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.ASISTENCIATableAdapter()
        Me.TableAdapterManager1 = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.IdAsistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipoAsistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.ASISTENCIADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdAsistenciaLabel = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdTipoAsistenciaLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASISTENCIABindingNavigator.SuspendLayout()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASISTENCIADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASISTENCIABindingSource
        '
        Me.ASISTENCIABindingSource.DataMember = "ASISTENCIA"
        Me.ASISTENCIABindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'ASISTENCIATableAdapter
        '
        Me.ASISTENCIATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Me.ASISTENCIATableAdapter
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
        'ASISTENCIABindingNavigator
        '
        Me.ASISTENCIABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ASISTENCIABindingNavigator.BindingSource = Me.ASISTENCIABindingSource
        Me.ASISTENCIABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ASISTENCIABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ASISTENCIABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ASISTENCIABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ASISTENCIABindingNavigatorSaveItem})
        Me.ASISTENCIABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ASISTENCIABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ASISTENCIABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ASISTENCIABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ASISTENCIABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ASISTENCIABindingNavigator.Name = "ASISTENCIABindingNavigator"
        Me.ASISTENCIABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ASISTENCIABindingNavigator.Size = New System.Drawing.Size(996, 27)
        Me.ASISTENCIABindingNavigator.TabIndex = 0
        Me.ASISTENCIABindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ASISTENCIABindingNavigatorSaveItem
        '
        Me.ASISTENCIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ASISTENCIABindingNavigatorSaveItem.Image = CType(resources.GetObject("ASISTENCIABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ASISTENCIABindingNavigatorSaveItem.Name = "ASISTENCIABindingNavigatorSaveItem"
        Me.ASISTENCIABindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.ASISTENCIABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASISTENCIABindingSource1
        '
        Me.ASISTENCIABindingSource1.DataMember = "ASISTENCIA"
        Me.ASISTENCIABindingSource1.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'ASISTENCIATableAdapter1
        '
        Me.ASISTENCIATableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AREATableAdapter = Nothing
        Me.TableAdapterManager1.ASISTENCIATableAdapter = Me.ASISTENCIATableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BENEFICIO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager1.BOLETATableAdapter = Nothing
        Me.TableAdapterManager1.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager1.DATOS_TRIBUTARIOSTableAdapter = Nothing
        Me.TableAdapterManager1.DETALLE_BENEFICIOTableAdapter = Nothing
        Me.TableAdapterManager1.DISTRITOTableAdapter = Nothing
        Me.TableAdapterManager1.EMPLEADOTableAdapter = Nothing
        Me.TableAdapterManager1.EXPERIENCIA_LABORALTableAdapter = Nothing
        Me.TableAdapterManager1.GERENTETableAdapter = Nothing
        Me.TableAdapterManager1.MEMORANDUMSTableAdapter = Nothing
        Me.TableAdapterManager1.NIVEL_EDUCACIONTableAdapter = Nothing
        Me.TableAdapterManager1.PAGO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager1.PERIODO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager1.PLANILLATableAdapter = Nothing
        Me.TableAdapterManager1.PRESTAMO_ADELANTOSTableAdapter = Nothing
        Me.TableAdapterManager1.REGIMEN_PENSIONARIOTableAdapter = Nothing
        Me.TableAdapterManager1.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager1.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager1.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager1.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager1.VARIACION_SUELDOTableAdapter = Nothing
        '
        'IdAsistenciaLabel
        '
        IdAsistenciaLabel.AutoSize = True
        IdAsistenciaLabel.Location = New System.Drawing.Point(22, 49)
        IdAsistenciaLabel.Name = "IdAsistenciaLabel"
        IdAsistenciaLabel.Size = New System.Drawing.Size(91, 17)
        IdAsistenciaLabel.TabIndex = 1
        IdAsistenciaLabel.Text = "Id Asistencia:"
        '
        'IdAsistenciaTextBox
        '
        Me.IdAsistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ASISTENCIABindingSource1, "IdAsistencia", True))
        Me.IdAsistenciaTextBox.Location = New System.Drawing.Point(151, 46)
        Me.IdAsistenciaTextBox.Name = "IdAsistenciaTextBox"
        Me.IdAsistenciaTextBox.Size = New System.Drawing.Size(276, 22)
        Me.IdAsistenciaTextBox.TabIndex = 2
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(22, 77)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(90, 17)
        IdEmpleadoLabel.TabIndex = 3
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ASISTENCIABindingSource1, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(151, 74)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(276, 22)
        Me.IdEmpleadoTextBox.TabIndex = 4
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(22, 106)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(47, 17)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ASISTENCIABindingSource1, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(151, 102)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(276, 22)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'IdTipoAsistenciaLabel
        '
        IdTipoAsistenciaLabel.AutoSize = True
        IdTipoAsistenciaLabel.Location = New System.Drawing.Point(22, 133)
        IdTipoAsistenciaLabel.Name = "IdTipoAsistenciaLabel"
        IdTipoAsistenciaLabel.Size = New System.Drawing.Size(123, 17)
        IdTipoAsistenciaLabel.TabIndex = 7
        IdTipoAsistenciaLabel.Text = "Id Tipo Asistencia:"
        '
        'IdTipoAsistenciaTextBox
        '
        Me.IdTipoAsistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ASISTENCIABindingSource1, "IdTipoAsistencia", True))
        Me.IdTipoAsistenciaTextBox.Location = New System.Drawing.Point(151, 130)
        Me.IdTipoAsistenciaTextBox.Name = "IdTipoAsistenciaTextBox"
        Me.IdTipoAsistenciaTextBox.Size = New System.Drawing.Size(276, 22)
        Me.IdTipoAsistenciaTextBox.TabIndex = 8
        '
        'ASISTENCIADataGridView
        '
        Me.ASISTENCIADataGridView.AutoGenerateColumns = False
        Me.ASISTENCIADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ASISTENCIADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASISTENCIADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ASISTENCIADataGridView.DataSource = Me.ASISTENCIABindingSource1
        Me.ASISTENCIADataGridView.Location = New System.Drawing.Point(465, 46)
        Me.ASISTENCIADataGridView.Name = "ASISTENCIADataGridView"
        Me.ASISTENCIADataGridView.RowTemplate.Height = 24
        Me.ASISTENCIADataGridView.Size = New System.Drawing.Size(489, 231)
        Me.ASISTENCIADataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdAsistencia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdAsistencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdTipoAsistencia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdTipoAsistencia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'FrmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 358)
        Me.Controls.Add(Me.ASISTENCIADataGridView)
        Me.Controls.Add(IdAsistenciaLabel)
        Me.Controls.Add(Me.IdAsistenciaTextBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(IdTipoAsistenciaLabel)
        Me.Controls.Add(Me.IdTipoAsistenciaTextBox)
        Me.Controls.Add(Me.ASISTENCIABindingNavigator)
        Me.Name = "FrmAsistencia"
        Me.Text = "Asistencia"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASISTENCIABindingNavigator.ResumeLayout(False)
        Me.ASISTENCIABindingNavigator.PerformLayout()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASISTENCIADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents ASISTENCIABindingSource As BindingSource
    Friend WithEvents ASISTENCIATableAdapter As DB_RRHHDataSetTableAdapters.ASISTENCIATableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ASISTENCIABindingNavigator As BindingNavigator
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
    Friend WithEvents ASISTENCIABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents ASISTENCIABindingSource1 As BindingSource
    Friend WithEvents ASISTENCIATableAdapter1 As BD_RecursosHumanosDataSetTableAdapters.ASISTENCIATableAdapter
    Friend WithEvents TableAdapterManager1 As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdAsistenciaTextBox As TextBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdTipoAsistenciaTextBox As TextBox
    Friend WithEvents ASISTENCIADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
