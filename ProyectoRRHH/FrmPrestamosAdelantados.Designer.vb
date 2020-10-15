<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrestamosAdelantados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrestamosAdelantados))
        Dim IdPrestamoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MontoPrestamoLabel As System.Windows.Forms.Label
        Dim FechaPrestamoLabel As System.Windows.Forms.Label
        Dim IdContratoLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.PRESTAMO_ADELANTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESTAMO_ADELANTOSTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.PRESTAMO_ADELANTOSTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.PRESTAMO_ADELANTOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPrestamoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MontoPrestamoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaPrestamoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdContratoTextBox = New System.Windows.Forms.TextBox()
        Me.PRESTAMO_ADELANTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPrestamoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MontoPrestamoLabel = New System.Windows.Forms.Label()
        FechaPrestamoLabel = New System.Windows.Forms.Label()
        IdContratoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMO_ADELANTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMO_ADELANTOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRESTAMO_ADELANTOSBindingNavigator.SuspendLayout()
        CType(Me.PRESTAMO_ADELANTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRESTAMO_ADELANTOSBindingSource
        '
        Me.PRESTAMO_ADELANTOSBindingSource.DataMember = "PRESTAMO_ADELANTOS"
        Me.PRESTAMO_ADELANTOSBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'PRESTAMO_ADELANTOSTableAdapter
        '
        Me.PRESTAMO_ADELANTOSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PAGO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PERIODO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMO_ADELANTOSTableAdapter = Me.PRESTAMO_ADELANTOSTableAdapter
        Me.TableAdapterManager.REGIMEN_PENSIONARIOTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'PRESTAMO_ADELANTOSBindingNavigator
        '
        Me.PRESTAMO_ADELANTOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.BindingSource = Me.PRESTAMO_ADELANTOSBindingSource
        Me.PRESTAMO_ADELANTOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PRESTAMO_ADELANTOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem})
        Me.PRESTAMO_ADELANTOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRESTAMO_ADELANTOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.Name = "PRESTAMO_ADELANTOSBindingNavigator"
        Me.PRESTAMO_ADELANTOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRESTAMO_ADELANTOSBindingNavigator.Size = New System.Drawing.Size(850, 27)
        Me.PRESTAMO_ADELANTOSBindingNavigator.TabIndex = 0
        Me.PRESTAMO_ADELANTOSBindingNavigator.Text = "BindingNavigator1"
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
        'PRESTAMO_ADELANTOSBindingNavigatorSaveItem
        '
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Name = "PRESTAMO_ADELANTOSBindingNavigatorSaveItem"
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPrestamoLabel
        '
        IdPrestamoLabel.AutoSize = True
        IdPrestamoLabel.Location = New System.Drawing.Point(12, 54)
        IdPrestamoLabel.Name = "IdPrestamoLabel"
        IdPrestamoLabel.Size = New System.Drawing.Size(87, 17)
        IdPrestamoLabel.TabIndex = 1
        IdPrestamoLabel.Text = "Id Prestamo:"
        '
        'IdPrestamoTextBox
        '
        Me.IdPrestamoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdPrestamoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMO_ADELANTOSBindingSource, "IdPrestamo", True))
        Me.IdPrestamoTextBox.Location = New System.Drawing.Point(133, 51)
        Me.IdPrestamoTextBox.Name = "IdPrestamoTextBox"
        Me.IdPrestamoTextBox.Size = New System.Drawing.Size(254, 22)
        Me.IdPrestamoTextBox.TabIndex = 2
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 82)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMO_ADELANTOSBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(133, 79)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(254, 22)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'MontoPrestamoLabel
        '
        MontoPrestamoLabel.AutoSize = True
        MontoPrestamoLabel.Location = New System.Drawing.Point(12, 110)
        MontoPrestamoLabel.Name = "MontoPrestamoLabel"
        MontoPrestamoLabel.Size = New System.Drawing.Size(115, 17)
        MontoPrestamoLabel.TabIndex = 5
        MontoPrestamoLabel.Text = "Monto Prestamo:"
        '
        'MontoPrestamoTextBox
        '
        Me.MontoPrestamoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.MontoPrestamoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMO_ADELANTOSBindingSource, "montoPrestamo", True))
        Me.MontoPrestamoTextBox.Location = New System.Drawing.Point(133, 107)
        Me.MontoPrestamoTextBox.Name = "MontoPrestamoTextBox"
        Me.MontoPrestamoTextBox.Size = New System.Drawing.Size(254, 22)
        Me.MontoPrestamoTextBox.TabIndex = 6
        '
        'FechaPrestamoLabel
        '
        FechaPrestamoLabel.AutoSize = True
        FechaPrestamoLabel.Location = New System.Drawing.Point(404, 56)
        FechaPrestamoLabel.Name = "FechaPrestamoLabel"
        FechaPrestamoLabel.Size = New System.Drawing.Size(115, 17)
        FechaPrestamoLabel.TabIndex = 7
        FechaPrestamoLabel.Text = "Fecha Prestamo:"
        '
        'FechaPrestamoDateTimePicker
        '
        Me.FechaPrestamoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRESTAMO_ADELANTOSBindingSource, "fechaPrestamo", True))
        Me.FechaPrestamoDateTimePicker.Location = New System.Drawing.Point(525, 52)
        Me.FechaPrestamoDateTimePicker.Name = "FechaPrestamoDateTimePicker"
        Me.FechaPrestamoDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.FechaPrestamoDateTimePicker.TabIndex = 8
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(404, 83)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(81, 17)
        IdContratoLabel.TabIndex = 9
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMO_ADELANTOSBindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(525, 80)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.IdContratoTextBox.TabIndex = 10
        '
        'PRESTAMO_ADELANTOSDataGridView
        '
        Me.PRESTAMO_ADELANTOSDataGridView.AutoGenerateColumns = False
        Me.PRESTAMO_ADELANTOSDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PRESTAMO_ADELANTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRESTAMO_ADELANTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PRESTAMO_ADELANTOSDataGridView.DataSource = Me.PRESTAMO_ADELANTOSBindingSource
        Me.PRESTAMO_ADELANTOSDataGridView.Location = New System.Drawing.Point(47, 151)
        Me.PRESTAMO_ADELANTOSDataGridView.Name = "PRESTAMO_ADELANTOSDataGridView"
        Me.PRESTAMO_ADELANTOSDataGridView.RowTemplate.Height = 24
        Me.PRESTAMO_ADELANTOSDataGridView.Size = New System.Drawing.Size(703, 220)
        Me.PRESTAMO_ADELANTOSDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPrestamo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPrestamo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "montoPrestamo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MontoPrestamo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaPrestamo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaPrestamo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'FrmPrestamosAdelantados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 441)
        Me.Controls.Add(Me.PRESTAMO_ADELANTOSDataGridView)
        Me.Controls.Add(IdPrestamoLabel)
        Me.Controls.Add(Me.IdPrestamoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MontoPrestamoLabel)
        Me.Controls.Add(Me.MontoPrestamoTextBox)
        Me.Controls.Add(FechaPrestamoLabel)
        Me.Controls.Add(Me.FechaPrestamoDateTimePicker)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(Me.PRESTAMO_ADELANTOSBindingNavigator)
        Me.Name = "FrmPrestamosAdelantados"
        Me.Text = "PrestamosAdelantados"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMO_ADELANTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMO_ADELANTOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRESTAMO_ADELANTOSBindingNavigator.ResumeLayout(False)
        Me.PRESTAMO_ADELANTOSBindingNavigator.PerformLayout()
        CType(Me.PRESTAMO_ADELANTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents PRESTAMO_ADELANTOSBindingSource As BindingSource
    Friend WithEvents PRESTAMO_ADELANTOSTableAdapter As BD_RecursosHumanosDataSetTableAdapters.PRESTAMO_ADELANTOSTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRESTAMO_ADELANTOSBindingNavigator As BindingNavigator
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
    Friend WithEvents PRESTAMO_ADELANTOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPrestamoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MontoPrestamoTextBox As TextBox
    Friend WithEvents FechaPrestamoDateTimePicker As DateTimePicker
    Friend WithEvents IdContratoTextBox As TextBox
    Friend WithEvents PRESTAMO_ADELANTOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
