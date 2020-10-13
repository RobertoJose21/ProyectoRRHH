<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegimenSalud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegimenSalud))
        Dim InstitucionSaludLabel As System.Windows.Forms.Label
        Dim IdRegimenSaludLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.REGIMEN_SALUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGIMEN_SALUDTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.REGIMEN_SALUDTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.REGIMEN_SALUDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REGIMEN_SALUDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InstitucionSaludTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegimenSaludTextBox = New System.Windows.Forms.TextBox()
        Me.REGIMEN_SALUDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        InstitucionSaludLabel = New System.Windows.Forms.Label()
        IdRegimenSaludLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIMEN_SALUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIMEN_SALUDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REGIMEN_SALUDBindingNavigator.SuspendLayout()
        CType(Me.REGIMEN_SALUDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGIMEN_SALUDBindingSource
        '
        Me.REGIMEN_SALUDBindingSource.DataMember = "REGIMEN_SALUD"
        Me.REGIMEN_SALUDBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'REGIMEN_SALUDTableAdapter
        '
        Me.REGIMEN_SALUDTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Me.REGIMEN_SALUDTableAdapter
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'REGIMEN_SALUDBindingNavigator
        '
        Me.REGIMEN_SALUDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REGIMEN_SALUDBindingNavigator.BindingSource = Me.REGIMEN_SALUDBindingSource
        Me.REGIMEN_SALUDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REGIMEN_SALUDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REGIMEN_SALUDBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.REGIMEN_SALUDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REGIMEN_SALUDBindingNavigatorSaveItem})
        Me.REGIMEN_SALUDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REGIMEN_SALUDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REGIMEN_SALUDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REGIMEN_SALUDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REGIMEN_SALUDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REGIMEN_SALUDBindingNavigator.Name = "REGIMEN_SALUDBindingNavigator"
        Me.REGIMEN_SALUDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REGIMEN_SALUDBindingNavigator.Size = New System.Drawing.Size(812, 27)
        Me.REGIMEN_SALUDBindingNavigator.TabIndex = 0
        Me.REGIMEN_SALUDBindingNavigator.Text = "BindingNavigator1"
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
        'REGIMEN_SALUDBindingNavigatorSaveItem
        '
        Me.REGIMEN_SALUDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REGIMEN_SALUDBindingNavigatorSaveItem.Image = CType(resources.GetObject("REGIMEN_SALUDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REGIMEN_SALUDBindingNavigatorSaveItem.Name = "REGIMEN_SALUDBindingNavigatorSaveItem"
        Me.REGIMEN_SALUDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.REGIMEN_SALUDBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'InstitucionSaludLabel
        '
        InstitucionSaludLabel.AutoSize = True
        InstitucionSaludLabel.Location = New System.Drawing.Point(43, 125)
        InstitucionSaludLabel.Name = "InstitucionSaludLabel"
        InstitucionSaludLabel.Size = New System.Drawing.Size(115, 17)
        InstitucionSaludLabel.TabIndex = 1
        InstitucionSaludLabel.Text = "institucion Salud:"
        '
        'InstitucionSaludTextBox
        '
        Me.InstitucionSaludTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIMEN_SALUDBindingSource, "institucionSalud", True))
        Me.InstitucionSaludTextBox.Location = New System.Drawing.Point(172, 122)
        Me.InstitucionSaludTextBox.Name = "InstitucionSaludTextBox"
        Me.InstitucionSaludTextBox.Size = New System.Drawing.Size(100, 22)
        Me.InstitucionSaludTextBox.TabIndex = 2
        '
        'IdRegimenSaludLabel
        '
        IdRegimenSaludLabel.AutoSize = True
        IdRegimenSaludLabel.Location = New System.Drawing.Point(43, 153)
        IdRegimenSaludLabel.Name = "IdRegimenSaludLabel"
        IdRegimenSaludLabel.Size = New System.Drawing.Size(123, 17)
        IdRegimenSaludLabel.TabIndex = 3
        IdRegimenSaludLabel.Text = "Id Regimen Salud:"
        '
        'IdRegimenSaludTextBox
        '
        Me.IdRegimenSaludTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIMEN_SALUDBindingSource, "IdRegimenSalud", True))
        Me.IdRegimenSaludTextBox.Location = New System.Drawing.Point(172, 150)
        Me.IdRegimenSaludTextBox.Name = "IdRegimenSaludTextBox"
        Me.IdRegimenSaludTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdRegimenSaludTextBox.TabIndex = 4
        '
        'REGIMEN_SALUDDataGridView
        '
        Me.REGIMEN_SALUDDataGridView.AutoGenerateColumns = False
        Me.REGIMEN_SALUDDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.REGIMEN_SALUDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REGIMEN_SALUDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.REGIMEN_SALUDDataGridView.DataSource = Me.REGIMEN_SALUDBindingSource
        Me.REGIMEN_SALUDDataGridView.Location = New System.Drawing.Point(312, 55)
        Me.REGIMEN_SALUDDataGridView.Name = "REGIMEN_SALUDDataGridView"
        Me.REGIMEN_SALUDDataGridView.RowTemplate.Height = 24
        Me.REGIMEN_SALUDDataGridView.Size = New System.Drawing.Size(359, 204)
        Me.REGIMEN_SALUDDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "institucionSalud"
        Me.DataGridViewTextBoxColumn1.HeaderText = "institucionSalud"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdRegimenSalud"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdRegimenSalud"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmRegimenSalud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 383)
        Me.Controls.Add(Me.REGIMEN_SALUDDataGridView)
        Me.Controls.Add(InstitucionSaludLabel)
        Me.Controls.Add(Me.InstitucionSaludTextBox)
        Me.Controls.Add(IdRegimenSaludLabel)
        Me.Controls.Add(Me.IdRegimenSaludTextBox)
        Me.Controls.Add(Me.REGIMEN_SALUDBindingNavigator)
        Me.Name = "FrmRegimenSalud"
        Me.Text = "RegimenSalud"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIMEN_SALUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIMEN_SALUDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REGIMEN_SALUDBindingNavigator.ResumeLayout(False)
        Me.REGIMEN_SALUDBindingNavigator.PerformLayout()
        CType(Me.REGIMEN_SALUDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents REGIMEN_SALUDBindingSource As BindingSource
    Friend WithEvents REGIMEN_SALUDTableAdapter As BD_RecursosHumanosDataSetTableAdapters.REGIMEN_SALUDTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REGIMEN_SALUDBindingNavigator As BindingNavigator
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
    Friend WithEvents REGIMEN_SALUDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InstitucionSaludTextBox As TextBox
    Friend WithEvents IdRegimenSaludTextBox As TextBox
    Friend WithEvents REGIMEN_SALUDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
