<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegimenPensionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegimenPensionario))
        Dim InstitucionPensionarioLabel As System.Windows.Forms.Label
        Dim IdRegimenPensionarioLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.REGIMEN_PENSIONARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGIMEN_PENSIONARIOTableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.REGIMEN_PENSIONARIOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.REGIMEN_PENSIONARIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InstitucionPensionarioTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegimenPensionarioTextBox = New System.Windows.Forms.TextBox()
        Me.REGIMEN_PENSIONARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        InstitucionPensionarioLabel = New System.Windows.Forms.Label()
        IdRegimenPensionarioLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIMEN_PENSIONARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIMEN_PENSIONARIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REGIMEN_PENSIONARIOBindingNavigator.SuspendLayout()
        CType(Me.REGIMEN_PENSIONARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGIMEN_PENSIONARIOBindingSource
        '
        Me.REGIMEN_PENSIONARIOBindingSource.DataMember = "REGIMEN_PENSIONARIO"
        Me.REGIMEN_PENSIONARIOBindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'REGIMEN_PENSIONARIOTableAdapter
        '
        Me.REGIMEN_PENSIONARIOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.REGIMEN_PENSIONARIOTableAdapter = Me.REGIMEN_PENSIONARIOTableAdapter
        Me.TableAdapterManager.REGIMEN_SALUDTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'REGIMEN_PENSIONARIOBindingNavigator
        '
        Me.REGIMEN_PENSIONARIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.BindingSource = Me.REGIMEN_PENSIONARIOBindingSource
        Me.REGIMEN_PENSIONARIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.REGIMEN_PENSIONARIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem})
        Me.REGIMEN_PENSIONARIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REGIMEN_PENSIONARIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.Name = "REGIMEN_PENSIONARIOBindingNavigator"
        Me.REGIMEN_PENSIONARIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REGIMEN_PENSIONARIOBindingNavigator.Size = New System.Drawing.Size(773, 27)
        Me.REGIMEN_PENSIONARIOBindingNavigator.TabIndex = 0
        Me.REGIMEN_PENSIONARIOBindingNavigator.Text = "BindingNavigator1"
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
        'REGIMEN_PENSIONARIOBindingNavigatorSaveItem
        '
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Image = CType(resources.GetObject("REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Name = "REGIMEN_PENSIONARIOBindingNavigatorSaveItem"
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'InstitucionPensionarioLabel
        '
        InstitucionPensionarioLabel.AutoSize = True
        InstitucionPensionarioLabel.Location = New System.Drawing.Point(51, 55)
        InstitucionPensionarioLabel.Name = "InstitucionPensionarioLabel"
        InstitucionPensionarioLabel.Size = New System.Drawing.Size(154, 17)
        InstitucionPensionarioLabel.TabIndex = 1
        InstitucionPensionarioLabel.Text = "institucion Pensionario:"
        '
        'InstitucionPensionarioTextBox
        '
        Me.InstitucionPensionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIMEN_PENSIONARIOBindingSource, "institucionPensionario", True))
        Me.InstitucionPensionarioTextBox.Location = New System.Drawing.Point(219, 52)
        Me.InstitucionPensionarioTextBox.Name = "InstitucionPensionarioTextBox"
        Me.InstitucionPensionarioTextBox.Size = New System.Drawing.Size(100, 22)
        Me.InstitucionPensionarioTextBox.TabIndex = 2
        '
        'IdRegimenPensionarioLabel
        '
        IdRegimenPensionarioLabel.AutoSize = True
        IdRegimenPensionarioLabel.Location = New System.Drawing.Point(51, 83)
        IdRegimenPensionarioLabel.Name = "IdRegimenPensionarioLabel"
        IdRegimenPensionarioLabel.Size = New System.Drawing.Size(162, 17)
        IdRegimenPensionarioLabel.TabIndex = 3
        IdRegimenPensionarioLabel.Text = "Id Regimen Pensionario:"
        '
        'IdRegimenPensionarioTextBox
        '
        Me.IdRegimenPensionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIMEN_PENSIONARIOBindingSource, "IdRegimenPensionario", True))
        Me.IdRegimenPensionarioTextBox.Location = New System.Drawing.Point(219, 80)
        Me.IdRegimenPensionarioTextBox.Name = "IdRegimenPensionarioTextBox"
        Me.IdRegimenPensionarioTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdRegimenPensionarioTextBox.TabIndex = 4
        '
        'REGIMEN_PENSIONARIODataGridView
        '
        Me.REGIMEN_PENSIONARIODataGridView.AutoGenerateColumns = False
        Me.REGIMEN_PENSIONARIODataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.REGIMEN_PENSIONARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REGIMEN_PENSIONARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.REGIMEN_PENSIONARIODataGridView.DataSource = Me.REGIMEN_PENSIONARIOBindingSource
        Me.REGIMEN_PENSIONARIODataGridView.Location = New System.Drawing.Point(43, 129)
        Me.REGIMEN_PENSIONARIODataGridView.Name = "REGIMEN_PENSIONARIODataGridView"
        Me.REGIMEN_PENSIONARIODataGridView.RowTemplate.Height = 24
        Me.REGIMEN_PENSIONARIODataGridView.Size = New System.Drawing.Size(414, 220)
        Me.REGIMEN_PENSIONARIODataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "institucionPensionario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "institucionPensionario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdRegimenPensionario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdRegimenPensionario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 160
        '
        'FrmRegimenPensionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 447)
        Me.Controls.Add(Me.REGIMEN_PENSIONARIODataGridView)
        Me.Controls.Add(InstitucionPensionarioLabel)
        Me.Controls.Add(Me.InstitucionPensionarioTextBox)
        Me.Controls.Add(IdRegimenPensionarioLabel)
        Me.Controls.Add(Me.IdRegimenPensionarioTextBox)
        Me.Controls.Add(Me.REGIMEN_PENSIONARIOBindingNavigator)
        Me.Name = "FrmRegimenPensionario"
        Me.Text = "Regimen_Pensionario"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIMEN_PENSIONARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIMEN_PENSIONARIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REGIMEN_PENSIONARIOBindingNavigator.ResumeLayout(False)
        Me.REGIMEN_PENSIONARIOBindingNavigator.PerformLayout()
        CType(Me.REGIMEN_PENSIONARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents REGIMEN_PENSIONARIOBindingSource As BindingSource
    Friend WithEvents REGIMEN_PENSIONARIOTableAdapter As DB_RRHHDataSetTableAdapters.REGIMEN_PENSIONARIOTableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REGIMEN_PENSIONARIOBindingNavigator As BindingNavigator
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
    Friend WithEvents REGIMEN_PENSIONARIOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InstitucionPensionarioTextBox As TextBox
    Friend WithEvents IdRegimenPensionarioTextBox As TextBox
    Friend WithEvents REGIMEN_PENSIONARIODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
