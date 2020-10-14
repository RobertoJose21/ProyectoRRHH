<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodoLaboral
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
        Dim IdPeriodoLaboralLabel As System.Windows.Forms.Label
        Dim FechaIngresoLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodoLaboral))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.PERIODO_LABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERIODO_LABORALTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.PERIODO_LABORALTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.PERIODO_LABORALBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PERIODO_LABORALBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPeriodoLaboralTextBox = New System.Windows.Forms.TextBox()
        Me.FechaIngresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PERIODO_LABORALDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPeriodoLaboralLabel = New System.Windows.Forms.Label()
        FechaIngresoLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERIODO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERIODO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PERIODO_LABORALBindingNavigator.SuspendLayout()
        CType(Me.PERIODO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPeriodoLaboralLabel
        '
        IdPeriodoLaboralLabel.AutoSize = True
        IdPeriodoLaboralLabel.Location = New System.Drawing.Point(23, 41)
        IdPeriodoLaboralLabel.Name = "IdPeriodoLaboralLabel"
        IdPeriodoLaboralLabel.Size = New System.Drawing.Size(128, 17)
        IdPeriodoLaboralLabel.TabIndex = 1
        IdPeriodoLaboralLabel.Text = "Id Periodo Laboral:"
        '
        'FechaIngresoLabel
        '
        FechaIngresoLabel.AutoSize = True
        FechaIngresoLabel.Location = New System.Drawing.Point(23, 70)
        FechaIngresoLabel.Name = "FechaIngresoLabel"
        FechaIngresoLabel.Size = New System.Drawing.Size(102, 17)
        FechaIngresoLabel.TabIndex = 3
        FechaIngresoLabel.Text = "Fecha Ingreso:"
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(23, 98)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(85, 17)
        FechaFinalLabel.TabIndex = 5
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERIODO_LABORALBindingSource
        '
        Me.PERIODO_LABORALBindingSource.DataMember = "PERIODO_LABORAL"
        Me.PERIODO_LABORALBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'PERIODO_LABORALTableAdapter
        '
        Me.PERIODO_LABORALTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PERIODO_LABORALTableAdapter = Me.PERIODO_LABORALTableAdapter
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
        'PERIODO_LABORALBindingNavigator
        '
        Me.PERIODO_LABORALBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PERIODO_LABORALBindingNavigator.BindingSource = Me.PERIODO_LABORALBindingSource
        Me.PERIODO_LABORALBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PERIODO_LABORALBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PERIODO_LABORALBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PERIODO_LABORALBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PERIODO_LABORALBindingNavigatorSaveItem})
        Me.PERIODO_LABORALBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PERIODO_LABORALBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PERIODO_LABORALBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PERIODO_LABORALBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PERIODO_LABORALBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PERIODO_LABORALBindingNavigator.Name = "PERIODO_LABORALBindingNavigator"
        Me.PERIODO_LABORALBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PERIODO_LABORALBindingNavigator.Size = New System.Drawing.Size(980, 27)
        Me.PERIODO_LABORALBindingNavigator.TabIndex = 0
        Me.PERIODO_LABORALBindingNavigator.Text = "BindingNavigator1"
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
        'PERIODO_LABORALBindingNavigatorSaveItem
        '
        Me.PERIODO_LABORALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Image = CType(resources.GetObject("PERIODO_LABORALBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Name = "PERIODO_LABORALBindingNavigatorSaveItem"
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPeriodoLaboralTextBox
        '
        Me.IdPeriodoLaboralTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdPeriodoLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERIODO_LABORALBindingSource, "IdPeriodoLaboral", True))
        Me.IdPeriodoLaboralTextBox.Location = New System.Drawing.Point(157, 38)
        Me.IdPeriodoLaboralTextBox.Name = "IdPeriodoLaboralTextBox"
        Me.IdPeriodoLaboralTextBox.Size = New System.Drawing.Size(270, 22)
        Me.IdPeriodoLaboralTextBox.TabIndex = 2
        '
        'FechaIngresoDateTimePicker
        '
        Me.FechaIngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERIODO_LABORALBindingSource, "fechaIngreso", True))
        Me.FechaIngresoDateTimePicker.Location = New System.Drawing.Point(157, 66)
        Me.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker"
        Me.FechaIngresoDateTimePicker.Size = New System.Drawing.Size(270, 22)
        Me.FechaIngresoDateTimePicker.TabIndex = 4
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERIODO_LABORALBindingSource, "fechaFinal", True))
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(157, 94)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(270, 22)
        Me.FechaFinalDateTimePicker.TabIndex = 6
        '
        'PERIODO_LABORALDataGridView
        '
        Me.PERIODO_LABORALDataGridView.AutoGenerateColumns = False
        Me.PERIODO_LABORALDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PERIODO_LABORALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PERIODO_LABORALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PERIODO_LABORALDataGridView.DataSource = Me.PERIODO_LABORALBindingSource
        Me.PERIODO_LABORALDataGridView.Location = New System.Drawing.Point(26, 135)
        Me.PERIODO_LABORALDataGridView.Name = "PERIODO_LABORALDataGridView"
        Me.PERIODO_LABORALDataGridView.RowTemplate.Height = 24
        Me.PERIODO_LABORALDataGridView.Size = New System.Drawing.Size(557, 213)
        Me.PERIODO_LABORALDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaIngreso"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaIngreso"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaFinal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaFinal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'FrmPeriodoLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(980, 470)
        Me.Controls.Add(Me.PERIODO_LABORALDataGridView)
        Me.Controls.Add(IdPeriodoLaboralLabel)
        Me.Controls.Add(Me.IdPeriodoLaboralTextBox)
        Me.Controls.Add(FechaIngresoLabel)
        Me.Controls.Add(Me.FechaIngresoDateTimePicker)
        Me.Controls.Add(FechaFinalLabel)
        Me.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.Controls.Add(Me.PERIODO_LABORALBindingNavigator)
        Me.Name = "FrmPeriodoLaboral"
        Me.Text = "PeriodoLaboral"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERIODO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERIODO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PERIODO_LABORALBindingNavigator.ResumeLayout(False)
        Me.PERIODO_LABORALBindingNavigator.PerformLayout()
        CType(Me.PERIODO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents PERIODO_LABORALBindingSource As BindingSource
    Friend WithEvents PERIODO_LABORALTableAdapter As BD_RecursosHumanosDataSetTableAdapters.PERIODO_LABORALTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PERIODO_LABORALBindingNavigator As BindingNavigator
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
    Friend WithEvents PERIODO_LABORALBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPeriodoLaboralTextBox As TextBox
    Friend WithEvents FechaIngresoDateTimePicker As DateTimePicker
    Friend WithEvents FechaFinalDateTimePicker As DateTimePicker
    Friend WithEvents PERIODO_LABORALDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
