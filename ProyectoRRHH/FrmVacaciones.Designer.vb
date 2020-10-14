<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVacaciones
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
        Dim IdVacacionesLabel As System.Windows.Forms.Label
        Dim TiempoLaborandoLabel As System.Windows.Forms.Label
        Dim FechaComienzoLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVacaciones))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.VACACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VACACIONESTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.VACACIONESTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.VACACIONESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VACACIONESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdVacacionesTextBox = New System.Windows.Forms.TextBox()
        Me.TiempoLaborandoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaComienzoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VACACIONESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdVacacionesLabel = New System.Windows.Forms.Label()
        TiempoLaborandoLabel = New System.Windows.Forms.Label()
        FechaComienzoLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VACACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VACACIONESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VACACIONESBindingNavigator.SuspendLayout()
        CType(Me.VACACIONESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdVacacionesLabel
        '
        IdVacacionesLabel.AutoSize = True
        IdVacacionesLabel.Location = New System.Drawing.Point(104, 43)
        IdVacacionesLabel.Name = "IdVacacionesLabel"
        IdVacacionesLabel.Size = New System.Drawing.Size(100, 17)
        IdVacacionesLabel.TabIndex = 1
        IdVacacionesLabel.Text = "Id Vacaciones:"
        '
        'TiempoLaborandoLabel
        '
        TiempoLaborandoLabel.AutoSize = True
        TiempoLaborandoLabel.Location = New System.Drawing.Point(104, 71)
        TiempoLaborandoLabel.Name = "TiempoLaborandoLabel"
        TiempoLaborandoLabel.Size = New System.Drawing.Size(132, 17)
        TiempoLaborandoLabel.TabIndex = 3
        TiempoLaborandoLabel.Text = "Tiempo Laborando:"
        '
        'FechaComienzoLabel
        '
        FechaComienzoLabel.AutoSize = True
        FechaComienzoLabel.Location = New System.Drawing.Point(104, 100)
        FechaComienzoLabel.Name = "FechaComienzoLabel"
        FechaComienzoLabel.Size = New System.Drawing.Size(117, 17)
        FechaComienzoLabel.TabIndex = 5
        FechaComienzoLabel.Text = "Fecha Comienzo:"
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(104, 128)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(85, 17)
        FechaFinalLabel.TabIndex = 7
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VACACIONESBindingSource
        '
        Me.VACACIONESBindingSource.DataMember = "VACACIONES"
        Me.VACACIONESBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'VACACIONESTableAdapter
        '
        Me.VACACIONESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PRESTAMO_ADELANTOSTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_PENSIONARIOTableAdapter = Nothing
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Me.VACACIONESTableAdapter
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'VACACIONESBindingNavigator
        '
        Me.VACACIONESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VACACIONESBindingNavigator.BindingSource = Me.VACACIONESBindingSource
        Me.VACACIONESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VACACIONESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VACACIONESBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VACACIONESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VACACIONESBindingNavigatorSaveItem})
        Me.VACACIONESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VACACIONESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VACACIONESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VACACIONESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VACACIONESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VACACIONESBindingNavigator.Name = "VACACIONESBindingNavigator"
        Me.VACACIONESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VACACIONESBindingNavigator.Size = New System.Drawing.Size(873, 27)
        Me.VACACIONESBindingNavigator.TabIndex = 0
        Me.VACACIONESBindingNavigator.Text = "BindingNavigator1"
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
        'VACACIONESBindingNavigatorSaveItem
        '
        Me.VACACIONESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VACACIONESBindingNavigatorSaveItem.Image = CType(resources.GetObject("VACACIONESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VACACIONESBindingNavigatorSaveItem.Name = "VACACIONESBindingNavigatorSaveItem"
        Me.VACACIONESBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.VACACIONESBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdVacacionesTextBox
        '
        Me.IdVacacionesTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdVacacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VACACIONESBindingSource, "IdVacaciones", True))
        Me.IdVacacionesTextBox.Location = New System.Drawing.Point(237, 40)
        Me.IdVacacionesTextBox.Name = "IdVacacionesTextBox"
        Me.IdVacacionesTextBox.Size = New System.Drawing.Size(256, 22)
        Me.IdVacacionesTextBox.TabIndex = 2
        '
        'TiempoLaborandoTextBox
        '
        Me.TiempoLaborandoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TiempoLaborandoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VACACIONESBindingSource, "tiempoLaborando", True))
        Me.TiempoLaborandoTextBox.Location = New System.Drawing.Point(237, 68)
        Me.TiempoLaborandoTextBox.Name = "TiempoLaborandoTextBox"
        Me.TiempoLaborandoTextBox.Size = New System.Drawing.Size(256, 22)
        Me.TiempoLaborandoTextBox.TabIndex = 4
        '
        'FechaComienzoDateTimePicker
        '
        Me.FechaComienzoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VACACIONESBindingSource, "fechaComienzo", True))
        Me.FechaComienzoDateTimePicker.Location = New System.Drawing.Point(237, 96)
        Me.FechaComienzoDateTimePicker.Name = "FechaComienzoDateTimePicker"
        Me.FechaComienzoDateTimePicker.Size = New System.Drawing.Size(256, 22)
        Me.FechaComienzoDateTimePicker.TabIndex = 6
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VACACIONESBindingSource, "fechaFinal", True))
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(237, 124)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(256, 22)
        Me.FechaFinalDateTimePicker.TabIndex = 8
        '
        'VACACIONESDataGridView
        '
        Me.VACACIONESDataGridView.AutoGenerateColumns = False
        Me.VACACIONESDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.VACACIONESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VACACIONESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VACACIONESDataGridView.DataSource = Me.VACACIONESBindingSource
        Me.VACACIONESDataGridView.Location = New System.Drawing.Point(43, 164)
        Me.VACACIONESDataGridView.Name = "VACACIONESDataGridView"
        Me.VACACIONESDataGridView.RowTemplate.Height = 24
        Me.VACACIONESDataGridView.Size = New System.Drawing.Size(621, 201)
        Me.VACACIONESDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdVacaciones"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdVacaciones"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tiempoLaborando"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TiempoLaborando"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaComienzo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaComienzo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fechaFinal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaFinal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'FrmVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 449)
        Me.Controls.Add(Me.VACACIONESDataGridView)
        Me.Controls.Add(IdVacacionesLabel)
        Me.Controls.Add(Me.IdVacacionesTextBox)
        Me.Controls.Add(TiempoLaborandoLabel)
        Me.Controls.Add(Me.TiempoLaborandoTextBox)
        Me.Controls.Add(FechaComienzoLabel)
        Me.Controls.Add(Me.FechaComienzoDateTimePicker)
        Me.Controls.Add(FechaFinalLabel)
        Me.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.Controls.Add(Me.VACACIONESBindingNavigator)
        Me.Name = "FrmVacaciones"
        Me.Text = "Vacaciones"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VACACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VACACIONESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VACACIONESBindingNavigator.ResumeLayout(False)
        Me.VACACIONESBindingNavigator.PerformLayout()
        CType(Me.VACACIONESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents VACACIONESBindingSource As BindingSource
    Friend WithEvents VACACIONESTableAdapter As BD_RecursosHumanosDataSetTableAdapters.VACACIONESTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VACACIONESBindingNavigator As BindingNavigator
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
    Friend WithEvents VACACIONESBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdVacacionesTextBox As TextBox
    Friend WithEvents TiempoLaborandoTextBox As TextBox
    Friend WithEvents FechaComienzoDateTimePicker As DateTimePicker
    Friend WithEvents FechaFinalDateTimePicker As DateTimePicker
    Friend WithEvents VACACIONESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
