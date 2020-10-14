<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDistrito
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
        Dim IdDistritoLabel As System.Windows.Forms.Label
        Dim NombreDistritoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDistrito))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.DISTRITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DISTRITOTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.DISTRITOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.DISTRITOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DISTRITOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdDistritoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreDistritoTextBox = New System.Windows.Forms.TextBox()
        Me.DISTRITODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdDistritoLabel = New System.Windows.Forms.Label()
        NombreDistritoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISTRITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISTRITOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DISTRITOBindingNavigator.SuspendLayout()
        CType(Me.DISTRITODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdDistritoLabel
        '
        IdDistritoLabel.AutoSize = True
        IdDistritoLabel.Location = New System.Drawing.Point(169, 55)
        IdDistritoLabel.Name = "IdDistritoLabel"
        IdDistritoLabel.Size = New System.Drawing.Size(71, 17)
        IdDistritoLabel.TabIndex = 1
        IdDistritoLabel.Text = "Id Distrito:"
        '
        'NombreDistritoLabel
        '
        NombreDistritoLabel.AutoSize = True
        NombreDistritoLabel.Location = New System.Drawing.Point(169, 83)
        NombreDistritoLabel.Name = "NombreDistritoLabel"
        NombreDistritoLabel.Size = New System.Drawing.Size(110, 17)
        NombreDistritoLabel.TabIndex = 3
        NombreDistritoLabel.Text = "Nombre Distrito:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DISTRITOBindingSource
        '
        Me.DISTRITOBindingSource.DataMember = "DISTRITO"
        Me.DISTRITOBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'DISTRITOTableAdapter
        '
        Me.DISTRITOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DISTRITOTableAdapter = Me.DISTRITOTableAdapter
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
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'DISTRITOBindingNavigator
        '
        Me.DISTRITOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DISTRITOBindingNavigator.BindingSource = Me.DISTRITOBindingSource
        Me.DISTRITOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DISTRITOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DISTRITOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DISTRITOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DISTRITOBindingNavigatorSaveItem})
        Me.DISTRITOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DISTRITOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DISTRITOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DISTRITOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DISTRITOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DISTRITOBindingNavigator.Name = "DISTRITOBindingNavigator"
        Me.DISTRITOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DISTRITOBindingNavigator.Size = New System.Drawing.Size(766, 27)
        Me.DISTRITOBindingNavigator.TabIndex = 0
        Me.DISTRITOBindingNavigator.Text = "BindingNavigator1"
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
        'DISTRITOBindingNavigatorSaveItem
        '
        Me.DISTRITOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DISTRITOBindingNavigatorSaveItem.Image = CType(resources.GetObject("DISTRITOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DISTRITOBindingNavigatorSaveItem.Name = "DISTRITOBindingNavigatorSaveItem"
        Me.DISTRITOBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.DISTRITOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdDistritoTextBox
        '
        Me.IdDistritoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdDistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DISTRITOBindingSource, "IdDistrito", True))
        Me.IdDistritoTextBox.Location = New System.Drawing.Point(285, 52)
        Me.IdDistritoTextBox.Name = "IdDistritoTextBox"
        Me.IdDistritoTextBox.Size = New System.Drawing.Size(201, 22)
        Me.IdDistritoTextBox.TabIndex = 2
        '
        'NombreDistritoTextBox
        '
        Me.NombreDistritoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NombreDistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DISTRITOBindingSource, "NombreDistrito", True))
        Me.NombreDistritoTextBox.Location = New System.Drawing.Point(285, 80)
        Me.NombreDistritoTextBox.Name = "NombreDistritoTextBox"
        Me.NombreDistritoTextBox.Size = New System.Drawing.Size(201, 22)
        Me.NombreDistritoTextBox.TabIndex = 4
        '
        'DISTRITODataGridView
        '
        Me.DISTRITODataGridView.AutoGenerateColumns = False
        Me.DISTRITODataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DISTRITODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DISTRITODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DISTRITODataGridView.DataSource = Me.DISTRITOBindingSource
        Me.DISTRITODataGridView.Location = New System.Drawing.Point(163, 120)
        Me.DISTRITODataGridView.Name = "DISTRITODataGridView"
        Me.DISTRITODataGridView.RowTemplate.Height = 24
        Me.DISTRITODataGridView.Size = New System.Drawing.Size(323, 220)
        Me.DISTRITODataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDistrito"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDistrito"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreDistrito"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreDistrito"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmDistrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 394)
        Me.Controls.Add(Me.DISTRITODataGridView)
        Me.Controls.Add(IdDistritoLabel)
        Me.Controls.Add(Me.IdDistritoTextBox)
        Me.Controls.Add(NombreDistritoLabel)
        Me.Controls.Add(Me.NombreDistritoTextBox)
        Me.Controls.Add(Me.DISTRITOBindingNavigator)
        Me.Name = "FrmDistrito"
        Me.Text = "Distrito"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISTRITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISTRITOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DISTRITOBindingNavigator.ResumeLayout(False)
        Me.DISTRITOBindingNavigator.PerformLayout()
        CType(Me.DISTRITODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents DISTRITOBindingSource As BindingSource
    Friend WithEvents DISTRITOTableAdapter As BD_RecursosHumanosDataSetTableAdapters.DISTRITOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DISTRITOBindingNavigator As BindingNavigator
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
    Friend WithEvents DISTRITOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdDistritoTextBox As TextBox
    Friend WithEvents NombreDistritoTextBox As TextBox
    Friend WithEvents DISTRITODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
