<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla))
        Dim IdPlanillaLabel As System.Windows.Forms.Label
        Dim IdVariacionSueldoLabel As System.Windows.Forms.Label
        Dim IdContratoLabel As System.Windows.Forms.Label
        Dim IdTipoPlanillaLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.PLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANILLATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.PLANILLATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.PLANILLABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PLANILLABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.IdVariacionSueldoTextBox = New System.Windows.Forms.TextBox()
        Me.IdContratoTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.PLANILLADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPlanillaLabel = New System.Windows.Forms.Label()
        IdVariacionSueldoLabel = New System.Windows.Forms.Label()
        IdContratoLabel = New System.Windows.Forms.Label()
        IdTipoPlanillaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLANILLABindingNavigator.SuspendLayout()
        CType(Me.PLANILLADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLANILLABindingSource
        '
        Me.PLANILLABindingSource.DataMember = "PLANILLA"
        Me.PLANILLABindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'PLANILLATableAdapter
        '
        Me.PLANILLATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PLANILLATableAdapter = Me.PLANILLATableAdapter
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
        'PLANILLABindingNavigator
        '
        Me.PLANILLABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PLANILLABindingNavigator.BindingSource = Me.PLANILLABindingSource
        Me.PLANILLABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PLANILLABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PLANILLABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PLANILLABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PLANILLABindingNavigatorSaveItem})
        Me.PLANILLABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PLANILLABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PLANILLABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PLANILLABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PLANILLABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PLANILLABindingNavigator.Name = "PLANILLABindingNavigator"
        Me.PLANILLABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PLANILLABindingNavigator.Size = New System.Drawing.Size(1079, 27)
        Me.PLANILLABindingNavigator.TabIndex = 0
        Me.PLANILLABindingNavigator.Text = "BindingNavigator1"
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
        'PLANILLABindingNavigatorSaveItem
        '
        Me.PLANILLABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PLANILLABindingNavigatorSaveItem.Image = CType(resources.GetObject("PLANILLABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PLANILLABindingNavigatorSaveItem.Name = "PLANILLABindingNavigatorSaveItem"
        Me.PLANILLABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PLANILLABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPlanillaLabel
        '
        IdPlanillaLabel.AutoSize = True
        IdPlanillaLabel.Location = New System.Drawing.Point(22, 84)
        IdPlanillaLabel.Name = "IdPlanillaLabel"
        IdPlanillaLabel.Size = New System.Drawing.Size(72, 17)
        IdPlanillaLabel.TabIndex = 1
        IdPlanillaLabel.Text = "Id Planilla:"
        '
        'IdPlanillaTextBox
        '
        Me.IdPlanillaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdPlanilla", True))
        Me.IdPlanillaTextBox.Location = New System.Drawing.Point(162, 81)
        Me.IdPlanillaTextBox.Name = "IdPlanillaTextBox"
        Me.IdPlanillaTextBox.Size = New System.Drawing.Size(155, 22)
        Me.IdPlanillaTextBox.TabIndex = 2
        '
        'IdVariacionSueldoLabel
        '
        IdVariacionSueldoLabel.AutoSize = True
        IdVariacionSueldoLabel.Location = New System.Drawing.Point(22, 112)
        IdVariacionSueldoLabel.Name = "IdVariacionSueldoLabel"
        IdVariacionSueldoLabel.Size = New System.Drawing.Size(134, 17)
        IdVariacionSueldoLabel.TabIndex = 3
        IdVariacionSueldoLabel.Text = "Id Variacion Sueldo:"
        '
        'IdVariacionSueldoTextBox
        '
        Me.IdVariacionSueldoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdVariacionSueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdVariacionSueldo", True))
        Me.IdVariacionSueldoTextBox.Location = New System.Drawing.Point(162, 109)
        Me.IdVariacionSueldoTextBox.Name = "IdVariacionSueldoTextBox"
        Me.IdVariacionSueldoTextBox.Size = New System.Drawing.Size(155, 22)
        Me.IdVariacionSueldoTextBox.TabIndex = 4
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(22, 140)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(81, 17)
        IdContratoLabel.TabIndex = 5
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(162, 137)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(155, 22)
        Me.IdContratoTextBox.TabIndex = 6
        '
        'IdTipoPlanillaLabel
        '
        IdTipoPlanillaLabel.AutoSize = True
        IdTipoPlanillaLabel.Location = New System.Drawing.Point(22, 168)
        IdTipoPlanillaLabel.Name = "IdTipoPlanillaLabel"
        IdTipoPlanillaLabel.Size = New System.Drawing.Size(104, 17)
        IdTipoPlanillaLabel.TabIndex = 7
        IdTipoPlanillaLabel.Text = "Id Tipo Planilla:"
        '
        'IdTipoPlanillaTextBox
        '
        Me.IdTipoPlanillaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdTipoPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdTipoPlanilla", True))
        Me.IdTipoPlanillaTextBox.Location = New System.Drawing.Point(162, 165)
        Me.IdTipoPlanillaTextBox.Name = "IdTipoPlanillaTextBox"
        Me.IdTipoPlanillaTextBox.Size = New System.Drawing.Size(155, 22)
        Me.IdTipoPlanillaTextBox.TabIndex = 8
        '
        'PLANILLADataGridView
        '
        Me.PLANILLADataGridView.AutoGenerateColumns = False
        Me.PLANILLADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PLANILLADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PLANILLADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PLANILLADataGridView.DataSource = Me.PLANILLABindingSource
        Me.PLANILLADataGridView.Location = New System.Drawing.Point(357, 81)
        Me.PLANILLADataGridView.Name = "PLANILLADataGridView"
        Me.PLANILLADataGridView.RowTemplate.Height = 24
        Me.PLANILLADataGridView.Size = New System.Drawing.Size(540, 228)
        Me.PLANILLADataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdVariacionSueldo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdVariacionSueldo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdTipoPlanilla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdTipoPlanilla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 456)
        Me.Controls.Add(Me.PLANILLADataGridView)
        Me.Controls.Add(IdPlanillaLabel)
        Me.Controls.Add(Me.IdPlanillaTextBox)
        Me.Controls.Add(IdVariacionSueldoLabel)
        Me.Controls.Add(Me.IdVariacionSueldoTextBox)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(IdTipoPlanillaLabel)
        Me.Controls.Add(Me.IdTipoPlanillaTextBox)
        Me.Controls.Add(Me.PLANILLABindingNavigator)
        Me.Name = "FrmPlanilla"
        Me.Text = "Planilla"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLANILLABindingNavigator.ResumeLayout(False)
        Me.PLANILLABindingNavigator.PerformLayout()
        CType(Me.PLANILLADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents PLANILLABindingSource As BindingSource
    Friend WithEvents PLANILLATableAdapter As BD_RecursosHumanosDataSetTableAdapters.PLANILLATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PLANILLABindingNavigator As BindingNavigator
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
    Friend WithEvents PLANILLABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPlanillaTextBox As TextBox
    Friend WithEvents IdVariacionSueldoTextBox As TextBox
    Friend WithEvents IdContratoTextBox As TextBox
    Friend WithEvents IdTipoPlanillaTextBox As TextBox
    Friend WithEvents PLANILLADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
