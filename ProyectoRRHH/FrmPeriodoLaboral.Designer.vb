﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodoLaboral))
        Dim IdPeriodoLaboralLabel As System.Windows.Forms.Label
        Dim FechaIngresoLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.PERIODO_LABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERIODO_LABORALTableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.PERIODO_LABORALTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.PERIODO_LABORALBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERIODO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERIODO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PERIODO_LABORALBindingNavigator.SuspendLayout()
        CType(Me.PERIODO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERIODO_LABORALBindingSource
        '
        Me.PERIODO_LABORALBindingSource.DataMember = "PERIODO_LABORAL"
        Me.PERIODO_LABORALBindingSource.DataSource = Me.DB_RRHHDataSet
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
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'PERIODO_LABORALBindingNavigator
        '
        Me.PERIODO_LABORALBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PERIODO_LABORALBindingNavigator.BindingSource = Me.PERIODO_LABORALBindingSource
        Me.PERIODO_LABORALBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PERIODO_LABORALBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PERIODO_LABORALBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PERIODO_LABORALBindingNavigatorSaveItem})
        Me.PERIODO_LABORALBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PERIODO_LABORALBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PERIODO_LABORALBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PERIODO_LABORALBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PERIODO_LABORALBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PERIODO_LABORALBindingNavigator.Name = "PERIODO_LABORALBindingNavigator"
        Me.PERIODO_LABORALBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PERIODO_LABORALBindingNavigator.Size = New System.Drawing.Size(398, 25)
        Me.PERIODO_LABORALBindingNavigator.TabIndex = 0
        Me.PERIODO_LABORALBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PERIODO_LABORALBindingNavigatorSaveItem
        '
        Me.PERIODO_LABORALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Image = CType(resources.GetObject("PERIODO_LABORALBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Name = "PERIODO_LABORALBindingNavigatorSaveItem"
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PERIODO_LABORALBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPeriodoLaboralLabel
        '
        IdPeriodoLaboralLabel.AutoSize = True
        IdPeriodoLaboralLabel.Location = New System.Drawing.Point(41, 54)
        IdPeriodoLaboralLabel.Name = "IdPeriodoLaboralLabel"
        IdPeriodoLaboralLabel.Size = New System.Drawing.Size(96, 13)
        IdPeriodoLaboralLabel.TabIndex = 1
        IdPeriodoLaboralLabel.Text = "Id Periodo Laboral:"
        '
        'IdPeriodoLaboralTextBox
        '
        Me.IdPeriodoLaboralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERIODO_LABORALBindingSource, "IdPeriodoLaboral", True))
        Me.IdPeriodoLaboralTextBox.Location = New System.Drawing.Point(143, 51)
        Me.IdPeriodoLaboralTextBox.Name = "IdPeriodoLaboralTextBox"
        Me.IdPeriodoLaboralTextBox.Size = New System.Drawing.Size(32, 20)
        Me.IdPeriodoLaboralTextBox.TabIndex = 2
        '
        'FechaIngresoLabel
        '
        FechaIngresoLabel.AutoSize = True
        FechaIngresoLabel.Location = New System.Drawing.Point(41, 81)
        FechaIngresoLabel.Name = "FechaIngresoLabel"
        FechaIngresoLabel.Size = New System.Drawing.Size(75, 13)
        FechaIngresoLabel.TabIndex = 3
        FechaIngresoLabel.Text = "fecha Ingreso:"
        '
        'FechaIngresoDateTimePicker
        '
        Me.FechaIngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERIODO_LABORALBindingSource, "fechaIngreso", True))
        Me.FechaIngresoDateTimePicker.Location = New System.Drawing.Point(143, 77)
        Me.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker"
        Me.FechaIngresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaIngresoDateTimePicker.TabIndex = 4
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(41, 107)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(62, 13)
        FechaFinalLabel.TabIndex = 5
        FechaFinalLabel.Text = "fecha Final:"
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERIODO_LABORALBindingSource, "fechaFinal", True))
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(143, 103)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaFinalDateTimePicker.TabIndex = 6
        '
        'PERIODO_LABORALDataGridView
        '
        Me.PERIODO_LABORALDataGridView.AutoGenerateColumns = False
        Me.PERIODO_LABORALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PERIODO_LABORALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PERIODO_LABORALDataGridView.DataSource = Me.PERIODO_LABORALBindingSource
        Me.PERIODO_LABORALDataGridView.Location = New System.Drawing.Point(30, 144)
        Me.PERIODO_LABORALDataGridView.Name = "PERIODO_LABORALDataGridView"
        Me.PERIODO_LABORALDataGridView.Size = New System.Drawing.Size(341, 130)
        Me.PERIODO_LABORALDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPeriodoLaboral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaIngreso"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fechaIngreso"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaFinal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fechaFinal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FrmPeriodoLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 307)
        Me.Controls.Add(Me.PERIODO_LABORALDataGridView)
        Me.Controls.Add(IdPeriodoLaboralLabel)
        Me.Controls.Add(Me.IdPeriodoLaboralTextBox)
        Me.Controls.Add(FechaIngresoLabel)
        Me.Controls.Add(Me.FechaIngresoDateTimePicker)
        Me.Controls.Add(FechaFinalLabel)
        Me.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.Controls.Add(Me.PERIODO_LABORALBindingNavigator)
        Me.Name = "FrmPeriodoLaboral"
        Me.Text = "FrmPeriodoLaboral"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERIODO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERIODO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PERIODO_LABORALBindingNavigator.ResumeLayout(False)
        Me.PERIODO_LABORALBindingNavigator.PerformLayout()
        CType(Me.PERIODO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents PERIODO_LABORALBindingSource As BindingSource
    Friend WithEvents PERIODO_LABORALTableAdapter As DB_RRHHDataSetTableAdapters.PERIODO_LABORALTableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
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
