<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNivelEducacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNivelEducacion))
        Dim IdNivelEducacionLabel As System.Windows.Forms.Label
        Dim NivelEducacionLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.NIVEL_EDUCACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NIVEL_EDUCACIONTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.NIVEL_EDUCACIONTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.NIVEL_EDUCACIONBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdNivelEducacionTextBox = New System.Windows.Forms.TextBox()
        Me.NivelEducacionTextBox = New System.Windows.Forms.TextBox()
        Me.NIVEL_EDUCACIONDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdNivelEducacionLabel = New System.Windows.Forms.Label()
        NivelEducacionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIVEL_EDUCACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIVEL_EDUCACIONBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NIVEL_EDUCACIONBindingNavigator.SuspendLayout()
        CType(Me.NIVEL_EDUCACIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NIVEL_EDUCACIONBindingSource
        '
        Me.NIVEL_EDUCACIONBindingSource.DataMember = "NIVEL_EDUCACION"
        Me.NIVEL_EDUCACIONBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'NIVEL_EDUCACIONTableAdapter
        '
        Me.NIVEL_EDUCACIONTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.NIVEL_EDUCACIONTableAdapter = Me.NIVEL_EDUCACIONTableAdapter
        Me.TableAdapterManager.PAGO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PERIODO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMO_ADELANTOSTableAdapter = Nothing
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
        'NIVEL_EDUCACIONBindingNavigator
        '
        Me.NIVEL_EDUCACIONBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NIVEL_EDUCACIONBindingNavigator.BindingSource = Me.NIVEL_EDUCACIONBindingSource
        Me.NIVEL_EDUCACIONBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NIVEL_EDUCACIONBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NIVEL_EDUCACIONBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NIVEL_EDUCACIONBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NIVEL_EDUCACIONBindingNavigatorSaveItem})
        Me.NIVEL_EDUCACIONBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NIVEL_EDUCACIONBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NIVEL_EDUCACIONBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NIVEL_EDUCACIONBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NIVEL_EDUCACIONBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NIVEL_EDUCACIONBindingNavigator.Name = "NIVEL_EDUCACIONBindingNavigator"
        Me.NIVEL_EDUCACIONBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NIVEL_EDUCACIONBindingNavigator.Size = New System.Drawing.Size(1091, 27)
        Me.NIVEL_EDUCACIONBindingNavigator.TabIndex = 0
        Me.NIVEL_EDUCACIONBindingNavigator.Text = "BindingNavigator1"
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
        'NIVEL_EDUCACIONBindingNavigatorSaveItem
        '
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem.Image = CType(resources.GetObject("NIVEL_EDUCACIONBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem.Name = "NIVEL_EDUCACIONBindingNavigatorSaveItem"
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.NIVEL_EDUCACIONBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdNivelEducacionLabel
        '
        IdNivelEducacionLabel.AutoSize = True
        IdNivelEducacionLabel.Location = New System.Drawing.Point(28, 140)
        IdNivelEducacionLabel.Name = "IdNivelEducacionLabel"
        IdNivelEducacionLabel.Size = New System.Drawing.Size(128, 17)
        IdNivelEducacionLabel.TabIndex = 1
        IdNivelEducacionLabel.Text = "Id Nivel Educacion:"
        '
        'IdNivelEducacionTextBox
        '
        Me.IdNivelEducacionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdNivelEducacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NIVEL_EDUCACIONBindingSource, "IdNivelEducacion", True))
        Me.IdNivelEducacionTextBox.Location = New System.Drawing.Point(162, 137)
        Me.IdNivelEducacionTextBox.Name = "IdNivelEducacionTextBox"
        Me.IdNivelEducacionTextBox.Size = New System.Drawing.Size(182, 22)
        Me.IdNivelEducacionTextBox.TabIndex = 2
        '
        'NivelEducacionLabel
        '
        NivelEducacionLabel.AutoSize = True
        NivelEducacionLabel.Location = New System.Drawing.Point(28, 168)
        NivelEducacionLabel.Name = "NivelEducacionLabel"
        NivelEducacionLabel.Size = New System.Drawing.Size(113, 17)
        NivelEducacionLabel.TabIndex = 3
        NivelEducacionLabel.Text = "Nivel Educacion:"
        '
        'NivelEducacionTextBox
        '
        Me.NivelEducacionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NivelEducacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NIVEL_EDUCACIONBindingSource, "nivelEducacion", True))
        Me.NivelEducacionTextBox.Location = New System.Drawing.Point(162, 165)
        Me.NivelEducacionTextBox.Name = "NivelEducacionTextBox"
        Me.NivelEducacionTextBox.Size = New System.Drawing.Size(182, 22)
        Me.NivelEducacionTextBox.TabIndex = 4
        '
        'NIVEL_EDUCACIONDataGridView
        '
        Me.NIVEL_EDUCACIONDataGridView.AutoGenerateColumns = False
        Me.NIVEL_EDUCACIONDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.NIVEL_EDUCACIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NIVEL_EDUCACIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.NIVEL_EDUCACIONDataGridView.DataSource = Me.NIVEL_EDUCACIONBindingSource
        Me.NIVEL_EDUCACIONDataGridView.Location = New System.Drawing.Point(429, 100)
        Me.NIVEL_EDUCACIONDataGridView.Name = "NIVEL_EDUCACIONDataGridView"
        Me.NIVEL_EDUCACIONDataGridView.RowTemplate.Height = 24
        Me.NIVEL_EDUCACIONDataGridView.Size = New System.Drawing.Size(355, 220)
        Me.NIVEL_EDUCACIONDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdNivelEducacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdNivelEducacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nivelEducacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NivelEducacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmNivelEducacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1091, 465)
        Me.Controls.Add(Me.NIVEL_EDUCACIONDataGridView)
        Me.Controls.Add(IdNivelEducacionLabel)
        Me.Controls.Add(Me.IdNivelEducacionTextBox)
        Me.Controls.Add(NivelEducacionLabel)
        Me.Controls.Add(Me.NivelEducacionTextBox)
        Me.Controls.Add(Me.NIVEL_EDUCACIONBindingNavigator)
        Me.Name = "FrmNivelEducacion"
        Me.Text = "NivelEducacion"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIVEL_EDUCACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIVEL_EDUCACIONBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NIVEL_EDUCACIONBindingNavigator.ResumeLayout(False)
        Me.NIVEL_EDUCACIONBindingNavigator.PerformLayout()
        CType(Me.NIVEL_EDUCACIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents NIVEL_EDUCACIONBindingSource As BindingSource
    Friend WithEvents NIVEL_EDUCACIONTableAdapter As BD_RecursosHumanosDataSetTableAdapters.NIVEL_EDUCACIONTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NIVEL_EDUCACIONBindingNavigator As BindingNavigator
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
    Friend WithEvents NIVEL_EDUCACIONBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdNivelEducacionTextBox As TextBox
    Friend WithEvents NivelEducacionTextBox As TextBox
    Friend WithEvents NIVEL_EDUCACIONDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
