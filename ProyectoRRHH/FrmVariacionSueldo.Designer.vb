<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVariacionSueldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVariacionSueldo))
        Dim IdVariacionSueldoLabel As System.Windows.Forms.Label
        Dim AFPLabel As System.Windows.Forms.Label
        Dim CTSLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.VARIACION_SUELDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VARIACION_SUELDOTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.VARIACION_SUELDOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.VARIACION_SUELDOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VARIACION_SUELDOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdVariacionSueldoTextBox = New System.Windows.Forms.TextBox()
        Me.AFPTextBox = New System.Windows.Forms.TextBox()
        Me.CTSTextBox = New System.Windows.Forms.TextBox()
        Me.VARIACION_SUELDODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdVariacionSueldoLabel = New System.Windows.Forms.Label()
        AFPLabel = New System.Windows.Forms.Label()
        CTSLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VARIACION_SUELDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VARIACION_SUELDOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VARIACION_SUELDOBindingNavigator.SuspendLayout()
        CType(Me.VARIACION_SUELDODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VARIACION_SUELDOBindingSource
        '
        Me.VARIACION_SUELDOBindingSource.DataMember = "VARIACION_SUELDO"
        Me.VARIACION_SUELDOBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'VARIACION_SUELDOTableAdapter
        '
        Me.VARIACION_SUELDOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Me.VARIACION_SUELDOTableAdapter
        '
        'VARIACION_SUELDOBindingNavigator
        '
        Me.VARIACION_SUELDOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VARIACION_SUELDOBindingNavigator.BindingSource = Me.VARIACION_SUELDOBindingSource
        Me.VARIACION_SUELDOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VARIACION_SUELDOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VARIACION_SUELDOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VARIACION_SUELDOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VARIACION_SUELDOBindingNavigatorSaveItem})
        Me.VARIACION_SUELDOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VARIACION_SUELDOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VARIACION_SUELDOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VARIACION_SUELDOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VARIACION_SUELDOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VARIACION_SUELDOBindingNavigator.Name = "VARIACION_SUELDOBindingNavigator"
        Me.VARIACION_SUELDOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VARIACION_SUELDOBindingNavigator.Size = New System.Drawing.Size(860, 27)
        Me.VARIACION_SUELDOBindingNavigator.TabIndex = 0
        Me.VARIACION_SUELDOBindingNavigator.Text = "BindingNavigator1"
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
        'VARIACION_SUELDOBindingNavigatorSaveItem
        '
        Me.VARIACION_SUELDOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VARIACION_SUELDOBindingNavigatorSaveItem.Image = CType(resources.GetObject("VARIACION_SUELDOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VARIACION_SUELDOBindingNavigatorSaveItem.Name = "VARIACION_SUELDOBindingNavigatorSaveItem"
        Me.VARIACION_SUELDOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VARIACION_SUELDOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdVariacionSueldoLabel
        '
        IdVariacionSueldoLabel.AutoSize = True
        IdVariacionSueldoLabel.Location = New System.Drawing.Point(23, 49)
        IdVariacionSueldoLabel.Name = "IdVariacionSueldoLabel"
        IdVariacionSueldoLabel.Size = New System.Drawing.Size(134, 17)
        IdVariacionSueldoLabel.TabIndex = 1
        IdVariacionSueldoLabel.Text = "Id Variacion Sueldo:"
        '
        'IdVariacionSueldoTextBox
        '
        Me.IdVariacionSueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VARIACION_SUELDOBindingSource, "IdVariacionSueldo", True))
        Me.IdVariacionSueldoTextBox.Location = New System.Drawing.Point(163, 46)
        Me.IdVariacionSueldoTextBox.Name = "IdVariacionSueldoTextBox"
        Me.IdVariacionSueldoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdVariacionSueldoTextBox.TabIndex = 2
        '
        'AFPLabel
        '
        AFPLabel.AutoSize = True
        AFPLabel.Location = New System.Drawing.Point(23, 77)
        AFPLabel.Name = "AFPLabel"
        AFPLabel.Size = New System.Drawing.Size(38, 17)
        AFPLabel.TabIndex = 3
        AFPLabel.Text = "AFP:"
        '
        'AFPTextBox
        '
        Me.AFPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VARIACION_SUELDOBindingSource, "AFP", True))
        Me.AFPTextBox.Location = New System.Drawing.Point(163, 74)
        Me.AFPTextBox.Name = "AFPTextBox"
        Me.AFPTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AFPTextBox.TabIndex = 4
        '
        'CTSLabel
        '
        CTSLabel.AutoSize = True
        CTSLabel.Location = New System.Drawing.Point(23, 105)
        CTSLabel.Name = "CTSLabel"
        CTSLabel.Size = New System.Drawing.Size(39, 17)
        CTSLabel.TabIndex = 5
        CTSLabel.Text = "CTS:"
        '
        'CTSTextBox
        '
        Me.CTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VARIACION_SUELDOBindingSource, "CTS", True))
        Me.CTSTextBox.Location = New System.Drawing.Point(163, 102)
        Me.CTSTextBox.Name = "CTSTextBox"
        Me.CTSTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CTSTextBox.TabIndex = 6
        '
        'VARIACION_SUELDODataGridView
        '
        Me.VARIACION_SUELDODataGridView.AutoGenerateColumns = False
        Me.VARIACION_SUELDODataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.VARIACION_SUELDODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VARIACION_SUELDODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VARIACION_SUELDODataGridView.DataSource = Me.VARIACION_SUELDOBindingSource
        Me.VARIACION_SUELDODataGridView.Location = New System.Drawing.Point(328, 46)
        Me.VARIACION_SUELDODataGridView.Name = "VARIACION_SUELDODataGridView"
        Me.VARIACION_SUELDODataGridView.RowTemplate.Height = 24
        Me.VARIACION_SUELDODataGridView.Size = New System.Drawing.Size(431, 220)
        Me.VARIACION_SUELDODataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdVariacionSueldo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdVariacionSueldo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AFP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AFP"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CTS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CTS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FrmVariacionSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 440)
        Me.Controls.Add(Me.VARIACION_SUELDODataGridView)
        Me.Controls.Add(IdVariacionSueldoLabel)
        Me.Controls.Add(Me.IdVariacionSueldoTextBox)
        Me.Controls.Add(AFPLabel)
        Me.Controls.Add(Me.AFPTextBox)
        Me.Controls.Add(CTSLabel)
        Me.Controls.Add(Me.CTSTextBox)
        Me.Controls.Add(Me.VARIACION_SUELDOBindingNavigator)
        Me.Name = "FrmVariacionSueldo"
        Me.Text = "VariacionSueldo"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VARIACION_SUELDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VARIACION_SUELDOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VARIACION_SUELDOBindingNavigator.ResumeLayout(False)
        Me.VARIACION_SUELDOBindingNavigator.PerformLayout()
        CType(Me.VARIACION_SUELDODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents VARIACION_SUELDOBindingSource As BindingSource
    Friend WithEvents VARIACION_SUELDOTableAdapter As BD_RecursosHumanosDataSetTableAdapters.VARIACION_SUELDOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VARIACION_SUELDOBindingNavigator As BindingNavigator
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
    Friend WithEvents VARIACION_SUELDOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdVariacionSueldoTextBox As TextBox
    Friend WithEvents AFPTextBox As TextBox
    Friend WithEvents CTSTextBox As TextBox
    Friend WithEvents VARIACION_SUELDODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
