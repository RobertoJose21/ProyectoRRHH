<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGERENTE
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
        Dim IdGerenteLabel As System.Windows.Forms.Label
        Dim NombregerenteLabel As System.Windows.Forms.Label
        Dim AreaGerenteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGERENTE))
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.GERENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GERENTETableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.GERENTETableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.GERENTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GERENTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdGerenteTextBox = New System.Windows.Forms.TextBox()
        Me.NombregerenteTextBox = New System.Windows.Forms.TextBox()
        Me.AreaGerenteTextBox = New System.Windows.Forms.TextBox()
        Me.GERENTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdGerenteLabel = New System.Windows.Forms.Label()
        NombregerenteLabel = New System.Windows.Forms.Label()
        AreaGerenteLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GERENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GERENTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GERENTEBindingNavigator.SuspendLayout()
        CType(Me.GERENTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdGerenteLabel
        '
        IdGerenteLabel.AutoSize = True
        IdGerenteLabel.Location = New System.Drawing.Point(261, 45)
        IdGerenteLabel.Name = "IdGerenteLabel"
        IdGerenteLabel.Size = New System.Drawing.Size(90, 20)
        IdGerenteLabel.TabIndex = 1
        IdGerenteLabel.Text = "Id Gerente:"
        '
        'NombregerenteLabel
        '
        NombregerenteLabel.AutoSize = True
        NombregerenteLabel.Location = New System.Drawing.Point(261, 105)
        NombregerenteLabel.Name = "NombregerenteLabel"
        NombregerenteLabel.Size = New System.Drawing.Size(122, 20)
        NombregerenteLabel.TabIndex = 3
        NombregerenteLabel.Text = "nombregerente:"
        '
        'AreaGerenteLabel
        '
        AreaGerenteLabel.AutoSize = True
        AreaGerenteLabel.Location = New System.Drawing.Point(261, 160)
        AreaGerenteLabel.Name = "AreaGerenteLabel"
        AreaGerenteLabel.Size = New System.Drawing.Size(108, 20)
        AreaGerenteLabel.TabIndex = 5
        AreaGerenteLabel.Text = "area Gerente:"
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GERENTEBindingSource
        '
        Me.GERENTEBindingSource.DataMember = "GERENTE"
        Me.GERENTEBindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'GERENTETableAdapter
        '
        Me.GERENTETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.GERENTETableAdapter = Me.GERENTETableAdapter
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
        'GERENTEBindingNavigator
        '
        Me.GERENTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GERENTEBindingNavigator.BindingSource = Me.GERENTEBindingSource
        Me.GERENTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GERENTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GERENTEBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GERENTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GERENTEBindingNavigatorSaveItem})
        Me.GERENTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GERENTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GERENTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GERENTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GERENTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GERENTEBindingNavigator.Name = "GERENTEBindingNavigator"
        Me.GERENTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GERENTEBindingNavigator.Size = New System.Drawing.Size(937, 31)
        Me.GERENTEBindingNavigator.TabIndex = 0
        Me.GERENTEBindingNavigator.Text = "BindingNavigator1"
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
        'GERENTEBindingNavigatorSaveItem
        '
        Me.GERENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GERENTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("GERENTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GERENTEBindingNavigatorSaveItem.Name = "GERENTEBindingNavigatorSaveItem"
        Me.GERENTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.GERENTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdGerenteTextBox
        '
        Me.IdGerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GERENTEBindingSource, "IdGerente", True))
        Me.IdGerenteTextBox.Location = New System.Drawing.Point(404, 42)
        Me.IdGerenteTextBox.Name = "IdGerenteTextBox"
        Me.IdGerenteTextBox.Size = New System.Drawing.Size(79, 26)
        Me.IdGerenteTextBox.TabIndex = 2
        '
        'NombregerenteTextBox
        '
        Me.NombregerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GERENTEBindingSource, "nombregerente", True))
        Me.NombregerenteTextBox.Location = New System.Drawing.Point(404, 102)
        Me.NombregerenteTextBox.Name = "NombregerenteTextBox"
        Me.NombregerenteTextBox.Size = New System.Drawing.Size(250, 26)
        Me.NombregerenteTextBox.TabIndex = 4
        '
        'AreaGerenteTextBox
        '
        Me.AreaGerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GERENTEBindingSource, "areaGerente", True))
        Me.AreaGerenteTextBox.Location = New System.Drawing.Point(404, 160)
        Me.AreaGerenteTextBox.Name = "AreaGerenteTextBox"
        Me.AreaGerenteTextBox.Size = New System.Drawing.Size(140, 26)
        Me.AreaGerenteTextBox.TabIndex = 6
        '
        'GERENTEDataGridView
        '
        Me.GERENTEDataGridView.AutoGenerateColumns = False
        Me.GERENTEDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GERENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GERENTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.GERENTEDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GERENTEDataGridView.DataSource = Me.GERENTEBindingSource
        Me.GERENTEDataGridView.EnableHeadersVisualStyles = False
        Me.GERENTEDataGridView.Location = New System.Drawing.Point(94, 216)
        Me.GERENTEDataGridView.Name = "GERENTEDataGridView"
        Me.GERENTEDataGridView.RowHeadersVisible = False
        Me.GERENTEDataGridView.RowTemplate.Height = 28
        Me.GERENTEDataGridView.Size = New System.Drawing.Size(733, 261)
        Me.GERENTEDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdGerente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdGerente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombregerente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombregerente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "areaGerente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "areaGerente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 240
        '
        'frmGERENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 489)
        Me.Controls.Add(Me.GERENTEDataGridView)
        Me.Controls.Add(IdGerenteLabel)
        Me.Controls.Add(Me.IdGerenteTextBox)
        Me.Controls.Add(NombregerenteLabel)
        Me.Controls.Add(Me.NombregerenteTextBox)
        Me.Controls.Add(AreaGerenteLabel)
        Me.Controls.Add(Me.AreaGerenteTextBox)
        Me.Controls.Add(Me.GERENTEBindingNavigator)
        Me.Name = "frmGERENTE"
        Me.Text = "MANTENEDOR GERENTE"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GERENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GERENTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GERENTEBindingNavigator.ResumeLayout(False)
        Me.GERENTEBindingNavigator.PerformLayout()
        CType(Me.GERENTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents GERENTEBindingSource As BindingSource
    Friend WithEvents GERENTETableAdapter As DB_RRHHDataSetTableAdapters.GERENTETableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GERENTEBindingNavigator As BindingNavigator
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
    Friend WithEvents GERENTEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdGerenteTextBox As TextBox
    Friend WithEvents NombregerenteTextBox As TextBox
    Friend WithEvents AreaGerenteTextBox As TextBox
    Friend WithEvents GERENTEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
