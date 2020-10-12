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
        Dim DescripcionPlanillaLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.PLANILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLANILLATableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.PLANILLATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
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
        Me.DescripcionPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.PLANILLADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdPlanillaLabel = New System.Windows.Forms.Label()
        IdVariacionSueldoLabel = New System.Windows.Forms.Label()
        IdContratoLabel = New System.Windows.Forms.Label()
        DescripcionPlanillaLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLANILLABindingNavigator.SuspendLayout()
        CType(Me.PLANILLADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLANILLABindingSource
        '
        Me.PLANILLABindingSource.DataMember = "PLANILLA"
        Me.PLANILLABindingSource.DataSource = Me.DB_RRHHDataSet
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
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'PLANILLABindingNavigator
        '
        Me.PLANILLABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PLANILLABindingNavigator.BindingSource = Me.PLANILLABindingSource
        Me.PLANILLABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PLANILLABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PLANILLABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PLANILLABindingNavigatorSaveItem})
        Me.PLANILLABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PLANILLABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PLANILLABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PLANILLABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PLANILLABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PLANILLABindingNavigator.Name = "PLANILLABindingNavigator"
        Me.PLANILLABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PLANILLABindingNavigator.Size = New System.Drawing.Size(468, 25)
        Me.PLANILLABindingNavigator.TabIndex = 0
        Me.PLANILLABindingNavigator.Text = "BindingNavigator1"
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
        IdPlanillaLabel.Location = New System.Drawing.Point(25, 41)
        IdPlanillaLabel.Name = "IdPlanillaLabel"
        IdPlanillaLabel.Size = New System.Drawing.Size(55, 13)
        IdPlanillaLabel.TabIndex = 1
        IdPlanillaLabel.Text = "Id Planilla:"
        '
        'IdPlanillaTextBox
        '
        Me.IdPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdPlanilla", True))
        Me.IdPlanillaTextBox.Location = New System.Drawing.Point(133, 38)
        Me.IdPlanillaTextBox.Name = "IdPlanillaTextBox"
        Me.IdPlanillaTextBox.Size = New System.Drawing.Size(30, 20)
        Me.IdPlanillaTextBox.TabIndex = 2
        '
        'IdVariacionSueldoLabel
        '
        IdVariacionSueldoLabel.AutoSize = True
        IdVariacionSueldoLabel.Location = New System.Drawing.Point(25, 67)
        IdVariacionSueldoLabel.Name = "IdVariacionSueldoLabel"
        IdVariacionSueldoLabel.Size = New System.Drawing.Size(102, 13)
        IdVariacionSueldoLabel.TabIndex = 3
        IdVariacionSueldoLabel.Text = "Id Variacion Sueldo:"
        '
        'IdVariacionSueldoTextBox
        '
        Me.IdVariacionSueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdVariacionSueldo", True))
        Me.IdVariacionSueldoTextBox.Location = New System.Drawing.Point(133, 64)
        Me.IdVariacionSueldoTextBox.Name = "IdVariacionSueldoTextBox"
        Me.IdVariacionSueldoTextBox.Size = New System.Drawing.Size(30, 20)
        Me.IdVariacionSueldoTextBox.TabIndex = 4
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(25, 93)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(62, 13)
        IdContratoLabel.TabIndex = 5
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(133, 90)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(30, 20)
        Me.IdContratoTextBox.TabIndex = 6
        '
        'DescripcionPlanillaLabel
        '
        DescripcionPlanillaLabel.AutoSize = True
        DescripcionPlanillaLabel.Location = New System.Drawing.Point(25, 119)
        DescripcionPlanillaLabel.Name = "DescripcionPlanillaLabel"
        DescripcionPlanillaLabel.Size = New System.Drawing.Size(100, 13)
        DescripcionPlanillaLabel.TabIndex = 7
        DescripcionPlanillaLabel.Text = "descripcion Planilla:"
        '
        'DescripcionPlanillaTextBox
        '
        Me.DescripcionPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANILLABindingSource, "descripcionPlanilla", True))
        Me.DescripcionPlanillaTextBox.Location = New System.Drawing.Point(133, 116)
        Me.DescripcionPlanillaTextBox.Name = "DescripcionPlanillaTextBox"
        Me.DescripcionPlanillaTextBox.Size = New System.Drawing.Size(290, 20)
        Me.DescripcionPlanillaTextBox.TabIndex = 8
        '
        'PLANILLADataGridView
        '
        Me.PLANILLADataGridView.AutoGenerateColumns = False
        Me.PLANILLADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PLANILLADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PLANILLADataGridView.DataSource = Me.PLANILLABindingSource
        Me.PLANILLADataGridView.Location = New System.Drawing.Point(12, 155)
        Me.PLANILLADataGridView.Name = "PLANILLADataGridView"
        Me.PLANILLADataGridView.Size = New System.Drawing.Size(441, 160)
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
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descripcionPlanilla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "descripcionPlanilla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 354)
        Me.Controls.Add(Me.PLANILLADataGridView)
        Me.Controls.Add(IdPlanillaLabel)
        Me.Controls.Add(Me.IdPlanillaTextBox)
        Me.Controls.Add(IdVariacionSueldoLabel)
        Me.Controls.Add(Me.IdVariacionSueldoTextBox)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(DescripcionPlanillaLabel)
        Me.Controls.Add(Me.DescripcionPlanillaTextBox)
        Me.Controls.Add(Me.PLANILLABindingNavigator)
        Me.Name = "FrmPlanilla"
        Me.Text = "FrmPlanilla"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANILLABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLANILLABindingNavigator.ResumeLayout(False)
        Me.PLANILLABindingNavigator.PerformLayout()
        CType(Me.PLANILLADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents PLANILLABindingSource As BindingSource
    Friend WithEvents PLANILLATableAdapter As DB_RRHHDataSetTableAdapters.PLANILLATableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents DescripcionPlanillaTextBox As TextBox
    Friend WithEvents PLANILLADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
