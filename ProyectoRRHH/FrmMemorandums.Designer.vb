<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemorandums
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
        Dim IdMemorandumLabel As System.Windows.Forms.Label
        Dim IdGerenteLabel As System.Windows.Forms.Label
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMemorandums))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.MEMORANDUMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMORANDUMSTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.MEMORANDUMSTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.MEMORANDUMSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MEMORANDUMSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdMemorandumTextBox = New System.Windows.Forms.TextBox()
        Me.IdGerenteTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MEMORANDUMSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdMemorandumLabel = New System.Windows.Forms.Label()
        IdGerenteLabel = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMORANDUMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMORANDUMSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEMORANDUMSBindingNavigator.SuspendLayout()
        CType(Me.MEMORANDUMSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdMemorandumLabel
        '
        IdMemorandumLabel.AutoSize = True
        IdMemorandumLabel.Location = New System.Drawing.Point(25, 92)
        IdMemorandumLabel.Name = "IdMemorandumLabel"
        IdMemorandumLabel.Size = New System.Drawing.Size(113, 17)
        IdMemorandumLabel.TabIndex = 1
        IdMemorandumLabel.Text = "Id Memorandum:"
        '
        'IdGerenteLabel
        '
        IdGerenteLabel.AutoSize = True
        IdGerenteLabel.Location = New System.Drawing.Point(25, 120)
        IdGerenteLabel.Name = "IdGerenteLabel"
        IdGerenteLabel.Size = New System.Drawing.Size(79, 17)
        IdGerenteLabel.TabIndex = 3
        IdGerenteLabel.Text = "Id Gerente:"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(25, 148)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(90, 17)
        IdEmpleadoLabel.TabIndex = 5
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(25, 176)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 7
        DescripcionLabel.Text = "Descripcion:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMORANDUMSBindingSource
        '
        Me.MEMORANDUMSBindingSource.DataMember = "MEMORANDUMS"
        Me.MEMORANDUMSBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'MEMORANDUMSTableAdapter
        '
        Me.MEMORANDUMSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MEMORANDUMSTableAdapter = Me.MEMORANDUMSTableAdapter
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
        'MEMORANDUMSBindingNavigator
        '
        Me.MEMORANDUMSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEMORANDUMSBindingNavigator.BindingSource = Me.MEMORANDUMSBindingSource
        Me.MEMORANDUMSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEMORANDUMSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEMORANDUMSBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MEMORANDUMSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEMORANDUMSBindingNavigatorSaveItem})
        Me.MEMORANDUMSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEMORANDUMSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEMORANDUMSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEMORANDUMSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEMORANDUMSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEMORANDUMSBindingNavigator.Name = "MEMORANDUMSBindingNavigator"
        Me.MEMORANDUMSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEMORANDUMSBindingNavigator.Size = New System.Drawing.Size(1188, 27)
        Me.MEMORANDUMSBindingNavigator.TabIndex = 0
        Me.MEMORANDUMSBindingNavigator.Text = "BindingNavigator1"
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
        'MEMORANDUMSBindingNavigatorSaveItem
        '
        Me.MEMORANDUMSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEMORANDUMSBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEMORANDUMSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEMORANDUMSBindingNavigatorSaveItem.Name = "MEMORANDUMSBindingNavigatorSaveItem"
        Me.MEMORANDUMSBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.MEMORANDUMSBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdMemorandumTextBox
        '
        Me.IdMemorandumTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdMemorandumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEMORANDUMSBindingSource, "IdMemorandum", True))
        Me.IdMemorandumTextBox.Location = New System.Drawing.Point(144, 89)
        Me.IdMemorandumTextBox.Name = "IdMemorandumTextBox"
        Me.IdMemorandumTextBox.Size = New System.Drawing.Size(219, 22)
        Me.IdMemorandumTextBox.TabIndex = 2
        '
        'IdGerenteTextBox
        '
        Me.IdGerenteTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdGerenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEMORANDUMSBindingSource, "IdGerente", True))
        Me.IdGerenteTextBox.Location = New System.Drawing.Point(144, 117)
        Me.IdGerenteTextBox.Name = "IdGerenteTextBox"
        Me.IdGerenteTextBox.Size = New System.Drawing.Size(219, 22)
        Me.IdGerenteTextBox.TabIndex = 4
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEMORANDUMSBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(144, 145)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(219, 22)
        Me.IdEmpleadoTextBox.TabIndex = 6
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEMORANDUMSBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(144, 173)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(219, 22)
        Me.DescripcionTextBox.TabIndex = 8
        '
        'MEMORANDUMSDataGridView
        '
        Me.MEMORANDUMSDataGridView.AutoGenerateColumns = False
        Me.MEMORANDUMSDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MEMORANDUMSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MEMORANDUMSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MEMORANDUMSDataGridView.DataSource = Me.MEMORANDUMSBindingSource
        Me.MEMORANDUMSDataGridView.Location = New System.Drawing.Point(399, 43)
        Me.MEMORANDUMSDataGridView.Name = "MEMORANDUMSDataGridView"
        Me.MEMORANDUMSDataGridView.RowTemplate.Height = 24
        Me.MEMORANDUMSDataGridView.Size = New System.Drawing.Size(598, 232)
        Me.MEMORANDUMSDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMemorandum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMemorandum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdGerente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdGerente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'FrmMemorandums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 392)
        Me.Controls.Add(Me.MEMORANDUMSDataGridView)
        Me.Controls.Add(IdMemorandumLabel)
        Me.Controls.Add(Me.IdMemorandumTextBox)
        Me.Controls.Add(IdGerenteLabel)
        Me.Controls.Add(Me.IdGerenteTextBox)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.MEMORANDUMSBindingNavigator)
        Me.Name = "FrmMemorandums"
        Me.Text = "Memorandums"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMORANDUMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMORANDUMSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEMORANDUMSBindingNavigator.ResumeLayout(False)
        Me.MEMORANDUMSBindingNavigator.PerformLayout()
        CType(Me.MEMORANDUMSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents MEMORANDUMSBindingSource As BindingSource
    Friend WithEvents MEMORANDUMSTableAdapter As BD_RecursosHumanosDataSetTableAdapters.MEMORANDUMSTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MEMORANDUMSBindingNavigator As BindingNavigator
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
    Friend WithEvents MEMORANDUMSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdMemorandumTextBox As TextBox
    Friend WithEvents IdGerenteTextBox As TextBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MEMORANDUMSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
