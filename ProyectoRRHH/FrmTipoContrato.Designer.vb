<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoContrato
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
        Dim IdTipoContratoLabel As System.Windows.Forms.Label
        Dim TipoContratoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoContrato))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.TIPO_CONTRATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_CONTRATOTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TIPO_CONTRATOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_CONTRATOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TIPO_CONTRATOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoContratoTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_CONTRATODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdTipoContratoLabel = New System.Windows.Forms.Label()
        TipoContratoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPO_CONTRATOBindingNavigator.SuspendLayout()
        CType(Me.TIPO_CONTRATODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdTipoContratoLabel
        '
        IdTipoContratoLabel.AutoSize = True
        IdTipoContratoLabel.Location = New System.Drawing.Point(21, 121)
        IdTipoContratoLabel.Name = "IdTipoContratoLabel"
        IdTipoContratoLabel.Size = New System.Drawing.Size(113, 17)
        IdTipoContratoLabel.TabIndex = 1
        IdTipoContratoLabel.Text = "Id Tipo Contrato:"
        '
        'TipoContratoLabel
        '
        TipoContratoLabel.AutoSize = True
        TipoContratoLabel.Location = New System.Drawing.Point(21, 149)
        TipoContratoLabel.Name = "TipoContratoLabel"
        TipoContratoLabel.Size = New System.Drawing.Size(98, 17)
        TipoContratoLabel.TabIndex = 3
        TipoContratoLabel.Text = "Tipo Contrato:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPO_CONTRATOBindingSource
        '
        Me.TIPO_CONTRATOBindingSource.DataMember = "TIPO_CONTRATO"
        Me.TIPO_CONTRATOBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'TIPO_CONTRATOTableAdapter
        '
        Me.TIPO_CONTRATOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Me.TIPO_CONTRATOTableAdapter
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'TIPO_CONTRATOBindingNavigator
        '
        Me.TIPO_CONTRATOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPO_CONTRATOBindingNavigator.BindingSource = Me.TIPO_CONTRATOBindingSource
        Me.TIPO_CONTRATOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPO_CONTRATOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPO_CONTRATOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TIPO_CONTRATOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPO_CONTRATOBindingNavigatorSaveItem})
        Me.TIPO_CONTRATOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPO_CONTRATOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPO_CONTRATOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPO_CONTRATOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPO_CONTRATOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPO_CONTRATOBindingNavigator.Name = "TIPO_CONTRATOBindingNavigator"
        Me.TIPO_CONTRATOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPO_CONTRATOBindingNavigator.Size = New System.Drawing.Size(852, 27)
        Me.TIPO_CONTRATOBindingNavigator.TabIndex = 0
        Me.TIPO_CONTRATOBindingNavigator.Text = "BindingNavigator1"
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
        'TIPO_CONTRATOBindingNavigatorSaveItem
        '
        Me.TIPO_CONTRATOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPO_CONTRATOBindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPO_CONTRATOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPO_CONTRATOBindingNavigatorSaveItem.Name = "TIPO_CONTRATOBindingNavigatorSaveItem"
        Me.TIPO_CONTRATOBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.TIPO_CONTRATOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoContratoTextBox
        '
        Me.IdTipoContratoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdTipoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_CONTRATOBindingSource, "IdTipoContrato", True))
        Me.IdTipoContratoTextBox.Location = New System.Drawing.Point(140, 118)
        Me.IdTipoContratoTextBox.Name = "IdTipoContratoTextBox"
        Me.IdTipoContratoTextBox.Size = New System.Drawing.Size(188, 22)
        Me.IdTipoContratoTextBox.TabIndex = 2
        '
        'TipoContratoTextBox
        '
        Me.TipoContratoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TipoContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_CONTRATOBindingSource, "tipoContrato", True))
        Me.TipoContratoTextBox.Location = New System.Drawing.Point(140, 146)
        Me.TipoContratoTextBox.Name = "TipoContratoTextBox"
        Me.TipoContratoTextBox.Size = New System.Drawing.Size(188, 22)
        Me.TipoContratoTextBox.TabIndex = 4
        '
        'TIPO_CONTRATODataGridView
        '
        Me.TIPO_CONTRATODataGridView.AutoGenerateColumns = False
        Me.TIPO_CONTRATODataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TIPO_CONTRATODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TIPO_CONTRATODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TIPO_CONTRATODataGridView.DataSource = Me.TIPO_CONTRATOBindingSource
        Me.TIPO_CONTRATODataGridView.Location = New System.Drawing.Point(383, 62)
        Me.TIPO_CONTRATODataGridView.Name = "TIPO_CONTRATODataGridView"
        Me.TIPO_CONTRATODataGridView.RowTemplate.Height = 24
        Me.TIPO_CONTRATODataGridView.Size = New System.Drawing.Size(398, 206)
        Me.TIPO_CONTRATODataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTipoContrato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdTipoContrato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoContrato"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TipoContrato"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmTipoContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 413)
        Me.Controls.Add(Me.TIPO_CONTRATODataGridView)
        Me.Controls.Add(IdTipoContratoLabel)
        Me.Controls.Add(Me.IdTipoContratoTextBox)
        Me.Controls.Add(TipoContratoLabel)
        Me.Controls.Add(Me.TipoContratoTextBox)
        Me.Controls.Add(Me.TIPO_CONTRATOBindingNavigator)
        Me.Name = "FrmTipoContrato"
        Me.Text = "TipoContrato"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPO_CONTRATOBindingNavigator.ResumeLayout(False)
        Me.TIPO_CONTRATOBindingNavigator.PerformLayout()
        CType(Me.TIPO_CONTRATODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents TIPO_CONTRATOBindingSource As BindingSource
    Friend WithEvents TIPO_CONTRATOTableAdapter As BD_RecursosHumanosDataSetTableAdapters.TIPO_CONTRATOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_CONTRATOBindingNavigator As BindingNavigator
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
    Friend WithEvents TIPO_CONTRATOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoContratoTextBox As TextBox
    Friend WithEvents TipoContratoTextBox As TextBox
    Friend WithEvents TIPO_CONTRATODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
