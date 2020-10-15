<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoTrabajo))
        Dim IdTipoTrabajadorLabel As System.Windows.Forms.Label
        Dim TipoTrabajadorLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.TIPO_TRABAJADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_TRABAJADORTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TIPO_TRABAJADORTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_TRABAJADORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoTrabajadorTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTrabajadorTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_TRABAJADORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdTipoTrabajadorLabel = New System.Windows.Forms.Label()
        TipoTrabajadorLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_TRABAJADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_TRABAJADORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPO_TRABAJADORBindingNavigator.SuspendLayout()
        CType(Me.TIPO_TRABAJADORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPO_TRABAJADORBindingSource
        '
        Me.TIPO_TRABAJADORBindingSource.DataMember = "TIPO_TRABAJADOR"
        Me.TIPO_TRABAJADORBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'TIPO_TRABAJADORTableAdapter
        '
        Me.TIPO_TRABAJADORTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Me.TIPO_TRABAJADORTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'TIPO_TRABAJADORBindingNavigator
        '
        Me.TIPO_TRABAJADORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPO_TRABAJADORBindingNavigator.BindingSource = Me.TIPO_TRABAJADORBindingSource
        Me.TIPO_TRABAJADORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPO_TRABAJADORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPO_TRABAJADORBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TIPO_TRABAJADORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPO_TRABAJADORBindingNavigatorSaveItem})
        Me.TIPO_TRABAJADORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPO_TRABAJADORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPO_TRABAJADORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPO_TRABAJADORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPO_TRABAJADORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPO_TRABAJADORBindingNavigator.Name = "TIPO_TRABAJADORBindingNavigator"
        Me.TIPO_TRABAJADORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPO_TRABAJADORBindingNavigator.Size = New System.Drawing.Size(843, 27)
        Me.TIPO_TRABAJADORBindingNavigator.TabIndex = 0
        Me.TIPO_TRABAJADORBindingNavigator.Text = "BindingNavigator1"
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
        'TIPO_TRABAJADORBindingNavigatorSaveItem
        '
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPO_TRABAJADORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem.Name = "TIPO_TRABAJADORBindingNavigatorSaveItem"
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TIPO_TRABAJADORBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoTrabajadorLabel
        '
        IdTipoTrabajadorLabel.AutoSize = True
        IdTipoTrabajadorLabel.Location = New System.Drawing.Point(282, 55)
        IdTipoTrabajadorLabel.Name = "IdTipoTrabajadorLabel"
        IdTipoTrabajadorLabel.Size = New System.Drawing.Size(129, 17)
        IdTipoTrabajadorLabel.TabIndex = 1
        IdTipoTrabajadorLabel.Text = "Id Tipo Trabajador:"
        '
        'IdTipoTrabajadorTextBox
        '
        Me.IdTipoTrabajadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_TRABAJADORBindingSource, "IdTipoTrabajador", True))
        Me.IdTipoTrabajadorTextBox.Location = New System.Drawing.Point(417, 52)
        Me.IdTipoTrabajadorTextBox.Name = "IdTipoTrabajadorTextBox"
        Me.IdTipoTrabajadorTextBox.Size = New System.Drawing.Size(148, 22)
        Me.IdTipoTrabajadorTextBox.TabIndex = 2
        '
        'TipoTrabajadorLabel
        '
        TipoTrabajadorLabel.AutoSize = True
        TipoTrabajadorLabel.Location = New System.Drawing.Point(282, 83)
        TipoTrabajadorLabel.Name = "TipoTrabajadorLabel"
        TipoTrabajadorLabel.Size = New System.Drawing.Size(114, 17)
        TipoTrabajadorLabel.TabIndex = 3
        TipoTrabajadorLabel.Text = "Tipo Trabajador:"
        '
        'TipoTrabajadorTextBox
        '
        Me.TipoTrabajadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_TRABAJADORBindingSource, "TipoTrabajador", True))
        Me.TipoTrabajadorTextBox.Location = New System.Drawing.Point(417, 80)
        Me.TipoTrabajadorTextBox.Name = "TipoTrabajadorTextBox"
        Me.TipoTrabajadorTextBox.Size = New System.Drawing.Size(148, 22)
        Me.TipoTrabajadorTextBox.TabIndex = 4
        '
        'TIPO_TRABAJADORDataGridView
        '
        Me.TIPO_TRABAJADORDataGridView.AutoGenerateColumns = False
        Me.TIPO_TRABAJADORDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TIPO_TRABAJADORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TIPO_TRABAJADORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TIPO_TRABAJADORDataGridView.DataSource = Me.TIPO_TRABAJADORBindingSource
        Me.TIPO_TRABAJADORDataGridView.Location = New System.Drawing.Point(259, 134)
        Me.TIPO_TRABAJADORDataGridView.Name = "TIPO_TRABAJADORDataGridView"
        Me.TIPO_TRABAJADORDataGridView.RowTemplate.Height = 24
        Me.TIPO_TRABAJADORDataGridView.Size = New System.Drawing.Size(351, 220)
        Me.TIPO_TRABAJADORDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTipoTrabajador"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdTipoTrabajador"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TipoTrabajador"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoTrabajador"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmTipoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 436)
        Me.Controls.Add(Me.TIPO_TRABAJADORDataGridView)
        Me.Controls.Add(IdTipoTrabajadorLabel)
        Me.Controls.Add(Me.IdTipoTrabajadorTextBox)
        Me.Controls.Add(TipoTrabajadorLabel)
        Me.Controls.Add(Me.TipoTrabajadorTextBox)
        Me.Controls.Add(Me.TIPO_TRABAJADORBindingNavigator)
        Me.Name = "FrmTipoTrabajo"
        Me.Text = "TipoTrabajo"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_TRABAJADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_TRABAJADORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPO_TRABAJADORBindingNavigator.ResumeLayout(False)
        Me.TIPO_TRABAJADORBindingNavigator.PerformLayout()
        CType(Me.TIPO_TRABAJADORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents TIPO_TRABAJADORBindingSource As BindingSource
    Friend WithEvents TIPO_TRABAJADORTableAdapter As BD_RecursosHumanosDataSetTableAdapters.TIPO_TRABAJADORTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_TRABAJADORBindingNavigator As BindingNavigator
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
    Friend WithEvents TIPO_TRABAJADORBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoTrabajadorTextBox As TextBox
    Friend WithEvents TipoTrabajadorTextBox As TextBox
    Friend WithEvents TIPO_TRABAJADORDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
