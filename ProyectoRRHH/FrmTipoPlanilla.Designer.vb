<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoPlanilla))
        Dim IdTipoPlanillaLabel As System.Windows.Forms.Label
        Dim TipoPlanillaLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.TIPO_PLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_PLANILLATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TIPO_PLANILLATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_PLANILLABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TIPO_PLANILLABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_PLANILLADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdTipoPlanillaLabel = New System.Windows.Forms.Label()
        TipoPlanillaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_PLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPO_PLANILLABindingNavigator.SuspendLayout()
        CType(Me.TIPO_PLANILLADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPO_PLANILLABindingSource
        '
        Me.TIPO_PLANILLABindingSource.DataMember = "TIPO_PLANILLA"
        Me.TIPO_PLANILLABindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'TIPO_PLANILLATableAdapter
        '
        Me.TIPO_PLANILLATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_PLANILLATableAdapter = Me.TIPO_PLANILLATableAdapter
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'TIPO_PLANILLABindingNavigator
        '
        Me.TIPO_PLANILLABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPO_PLANILLABindingNavigator.BindingSource = Me.TIPO_PLANILLABindingSource
        Me.TIPO_PLANILLABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPO_PLANILLABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPO_PLANILLABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TIPO_PLANILLABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPO_PLANILLABindingNavigatorSaveItem})
        Me.TIPO_PLANILLABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPO_PLANILLABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPO_PLANILLABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPO_PLANILLABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPO_PLANILLABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPO_PLANILLABindingNavigator.Name = "TIPO_PLANILLABindingNavigator"
        Me.TIPO_PLANILLABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPO_PLANILLABindingNavigator.Size = New System.Drawing.Size(829, 27)
        Me.TIPO_PLANILLABindingNavigator.TabIndex = 0
        Me.TIPO_PLANILLABindingNavigator.Text = "BindingNavigator1"
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
        'TIPO_PLANILLABindingNavigatorSaveItem
        '
        Me.TIPO_PLANILLABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPO_PLANILLABindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPO_PLANILLABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPO_PLANILLABindingNavigatorSaveItem.Name = "TIPO_PLANILLABindingNavigatorSaveItem"
        Me.TIPO_PLANILLABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TIPO_PLANILLABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoPlanillaLabel
        '
        IdTipoPlanillaLabel.AutoSize = True
        IdTipoPlanillaLabel.Location = New System.Drawing.Point(275, 62)
        IdTipoPlanillaLabel.Name = "IdTipoPlanillaLabel"
        IdTipoPlanillaLabel.Size = New System.Drawing.Size(104, 17)
        IdTipoPlanillaLabel.TabIndex = 1
        IdTipoPlanillaLabel.Text = "Id Tipo Planilla:"
        '
        'IdTipoPlanillaTextBox
        '
        Me.IdTipoPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_PLANILLABindingSource, "IdTipoPlanilla", True))
        Me.IdTipoPlanillaTextBox.Location = New System.Drawing.Point(385, 59)
        Me.IdTipoPlanillaTextBox.Name = "IdTipoPlanillaTextBox"
        Me.IdTipoPlanillaTextBox.Size = New System.Drawing.Size(139, 22)
        Me.IdTipoPlanillaTextBox.TabIndex = 2
        '
        'TipoPlanillaLabel
        '
        TipoPlanillaLabel.AutoSize = True
        TipoPlanillaLabel.Location = New System.Drawing.Point(275, 90)
        TipoPlanillaLabel.Name = "TipoPlanillaLabel"
        TipoPlanillaLabel.Size = New System.Drawing.Size(89, 17)
        TipoPlanillaLabel.TabIndex = 3
        TipoPlanillaLabel.Text = "Tipo Planilla:"
        '
        'TipoPlanillaTextBox
        '
        Me.TipoPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_PLANILLABindingSource, "tipoPlanilla", True))
        Me.TipoPlanillaTextBox.Location = New System.Drawing.Point(385, 87)
        Me.TipoPlanillaTextBox.Name = "TipoPlanillaTextBox"
        Me.TipoPlanillaTextBox.Size = New System.Drawing.Size(139, 22)
        Me.TipoPlanillaTextBox.TabIndex = 4
        '
        'TIPO_PLANILLADataGridView
        '
        Me.TIPO_PLANILLADataGridView.AutoGenerateColumns = False
        Me.TIPO_PLANILLADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TIPO_PLANILLADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TIPO_PLANILLADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TIPO_PLANILLADataGridView.DataSource = Me.TIPO_PLANILLABindingSource
        Me.TIPO_PLANILLADataGridView.Location = New System.Drawing.Point(224, 129)
        Me.TIPO_PLANILLADataGridView.Name = "TIPO_PLANILLADataGridView"
        Me.TIPO_PLANILLADataGridView.RowTemplate.Height = 24
        Me.TIPO_PLANILLADataGridView.Size = New System.Drawing.Size(372, 212)
        Me.TIPO_PLANILLADataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTipoPlanilla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdTipoPlanilla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoPlanilla"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoPlanilla"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmTipoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 433)
        Me.Controls.Add(Me.TIPO_PLANILLADataGridView)
        Me.Controls.Add(IdTipoPlanillaLabel)
        Me.Controls.Add(Me.IdTipoPlanillaTextBox)
        Me.Controls.Add(TipoPlanillaLabel)
        Me.Controls.Add(Me.TipoPlanillaTextBox)
        Me.Controls.Add(Me.TIPO_PLANILLABindingNavigator)
        Me.Name = "FrmTipoPlanilla"
        Me.Text = "TipoPlanilla"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_PLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPO_PLANILLABindingNavigator.ResumeLayout(False)
        Me.TIPO_PLANILLABindingNavigator.PerformLayout()
        CType(Me.TIPO_PLANILLADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents TIPO_PLANILLABindingSource As BindingSource
    Friend WithEvents TIPO_PLANILLATableAdapter As BD_RecursosHumanosDataSetTableAdapters.TIPO_PLANILLATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_PLANILLABindingNavigator As BindingNavigator
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
    Friend WithEvents TIPO_PLANILLABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoPlanillaTextBox As TextBox
    Friend WithEvents TipoPlanillaTextBox As TextBox
    Friend WithEvents TIPO_PLANILLADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
