﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDATOS_TRIBUTARIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDATOS_TRIBUTARIOS))
        Dim IdDatoTributarioLabel As System.Windows.Forms.Label
        Dim RentaLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.DATOS_TRIBUTARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATOS_TRIBUTARIOSTableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.DATOS_TRIBUTARIOSTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.DATOS_TRIBUTARIOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdDatoTributarioTextBox = New System.Windows.Forms.TextBox()
        Me.RentaTextBox = New System.Windows.Forms.TextBox()
        Me.DATOS_TRIBUTARIOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdDatoTributarioLabel = New System.Windows.Forms.Label()
        RentaLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOS_TRIBUTARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOS_TRIBUTARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DATOS_TRIBUTARIOSBindingNavigator.SuspendLayout()
        CType(Me.DATOS_TRIBUTARIOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DATOS_TRIBUTARIOSBindingSource
        '
        Me.DATOS_TRIBUTARIOSBindingSource.DataMember = "DATOS_TRIBUTARIOS"
        Me.DATOS_TRIBUTARIOSBindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'DATOS_TRIBUTARIOSTableAdapter
        '
        Me.DATOS_TRIBUTARIOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BENEFICIO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.BOLETATableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.DATOS_TRIBUTARIOSTableAdapter = Me.DATOS_TRIBUTARIOSTableAdapter
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
        'DATOS_TRIBUTARIOSBindingNavigator
        '
        Me.DATOS_TRIBUTARIOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.BindingSource = Me.DATOS_TRIBUTARIOSBindingSource
        Me.DATOS_TRIBUTARIOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.DATOS_TRIBUTARIOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem})
        Me.DATOS_TRIBUTARIOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DATOS_TRIBUTARIOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.Name = "DATOS_TRIBUTARIOSBindingNavigator"
        Me.DATOS_TRIBUTARIOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DATOS_TRIBUTARIOSBindingNavigator.Size = New System.Drawing.Size(954, 31)
        Me.DATOS_TRIBUTARIOSBindingNavigator.TabIndex = 0
        Me.DATOS_TRIBUTARIOSBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'DATOS_TRIBUTARIOSBindingNavigatorSaveItem
        '
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Name = "DATOS_TRIBUTARIOSBindingNavigatorSaveItem"
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdDatoTributarioLabel
        '
        IdDatoTributarioLabel.AutoSize = True
        IdDatoTributarioLabel.Location = New System.Drawing.Point(224, 81)
        IdDatoTributarioLabel.Name = "IdDatoTributarioLabel"
        IdDatoTributarioLabel.Size = New System.Drawing.Size(136, 20)
        IdDatoTributarioLabel.TabIndex = 1
        IdDatoTributarioLabel.Text = "Id Dato Tributario:"
        '
        'IdDatoTributarioTextBox
        '
        Me.IdDatoTributarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATOS_TRIBUTARIOSBindingSource, "IdDatoTributario", True))
        Me.IdDatoTributarioTextBox.Location = New System.Drawing.Point(406, 75)
        Me.IdDatoTributarioTextBox.Name = "IdDatoTributarioTextBox"
        Me.IdDatoTributarioTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdDatoTributarioTextBox.TabIndex = 2
        '
        'RentaLabel
        '
        RentaLabel.AutoSize = True
        RentaLabel.Location = New System.Drawing.Point(224, 142)
        RentaLabel.Name = "RentaLabel"
        RentaLabel.Size = New System.Drawing.Size(50, 20)
        RentaLabel.TabIndex = 3
        RentaLabel.Text = "renta:"
        '
        'RentaTextBox
        '
        Me.RentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DATOS_TRIBUTARIOSBindingSource, "renta", True))
        Me.RentaTextBox.Location = New System.Drawing.Point(406, 139)
        Me.RentaTextBox.Name = "RentaTextBox"
        Me.RentaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RentaTextBox.TabIndex = 4
        '
        'DATOS_TRIBUTARIOSDataGridView
        '
        Me.DATOS_TRIBUTARIOSDataGridView.AutoGenerateColumns = False
        Me.DATOS_TRIBUTARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATOS_TRIBUTARIOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DATOS_TRIBUTARIOSDataGridView.DataSource = Me.DATOS_TRIBUTARIOSBindingSource
        Me.DATOS_TRIBUTARIOSDataGridView.Location = New System.Drawing.Point(164, 205)
        Me.DATOS_TRIBUTARIOSDataGridView.Name = "DATOS_TRIBUTARIOSDataGridView"
        Me.DATOS_TRIBUTARIOSDataGridView.RowTemplate.Height = 28
        Me.DATOS_TRIBUTARIOSDataGridView.Size = New System.Drawing.Size(424, 226)
        Me.DATOS_TRIBUTARIOSDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDatoTributario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDatoTributario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "renta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "renta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmDATOS_TRIBUTARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 559)
        Me.Controls.Add(Me.DATOS_TRIBUTARIOSDataGridView)
        Me.Controls.Add(IdDatoTributarioLabel)
        Me.Controls.Add(Me.IdDatoTributarioTextBox)
        Me.Controls.Add(RentaLabel)
        Me.Controls.Add(Me.RentaTextBox)
        Me.Controls.Add(Me.DATOS_TRIBUTARIOSBindingNavigator)
        Me.Name = "frmDATOS_TRIBUTARIOS"
        Me.Text = "DATOS TRIBUTARIOS "
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOS_TRIBUTARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOS_TRIBUTARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DATOS_TRIBUTARIOSBindingNavigator.ResumeLayout(False)
        Me.DATOS_TRIBUTARIOSBindingNavigator.PerformLayout()
        CType(Me.DATOS_TRIBUTARIOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents DATOS_TRIBUTARIOSBindingSource As BindingSource
    Friend WithEvents DATOS_TRIBUTARIOSTableAdapter As DB_RRHHDataSetTableAdapters.DATOS_TRIBUTARIOSTableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DATOS_TRIBUTARIOSBindingNavigator As BindingNavigator
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
    Friend WithEvents DATOS_TRIBUTARIOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdDatoTributarioTextBox As TextBox
    Friend WithEvents RentaTextBox As TextBox
    Friend WithEvents DATOS_TRIBUTARIOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
