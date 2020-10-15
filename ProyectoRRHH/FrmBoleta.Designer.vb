<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBoleta))
        Dim IdBoletaLabel As System.Windows.Forms.Label
        Dim IdPagoPlanillaLabel As System.Windows.Forms.Label
        Dim FechaBoletaLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.BOLETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOLETATableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.BOLETATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.BOLETABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BOLETABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdBoletaTextBox = New System.Windows.Forms.TextBox()
        Me.IdPagoPlanillaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaBoletaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BOLETADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdBoletaLabel = New System.Windows.Forms.Label()
        IdPagoPlanillaLabel = New System.Windows.Forms.Label()
        FechaBoletaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOLETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOLETABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOLETABindingNavigator.SuspendLayout()
        CType(Me.BOLETADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOLETABindingSource
        '
        Me.BOLETABindingSource.DataMember = "BOLETA"
        Me.BOLETABindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'BOLETATableAdapter
        '
        Me.BOLETATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BENEFICIO_LABORALTableAdapter = Nothing
        Me.TableAdapterManager.BOLETATableAdapter = Me.BOLETATableAdapter
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
        Me.TableAdapterManager.TIPO_PLANILLATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'BOLETABindingNavigator
        '
        Me.BOLETABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BOLETABindingNavigator.BindingSource = Me.BOLETABindingSource
        Me.BOLETABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BOLETABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BOLETABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BOLETABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BOLETABindingNavigatorSaveItem})
        Me.BOLETABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BOLETABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BOLETABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BOLETABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BOLETABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BOLETABindingNavigator.Name = "BOLETABindingNavigator"
        Me.BOLETABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BOLETABindingNavigator.Size = New System.Drawing.Size(915, 27)
        Me.BOLETABindingNavigator.TabIndex = 0
        Me.BOLETABindingNavigator.Text = "BindingNavigator1"
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
        'BOLETABindingNavigatorSaveItem
        '
        Me.BOLETABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BOLETABindingNavigatorSaveItem.Image = CType(resources.GetObject("BOLETABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BOLETABindingNavigatorSaveItem.Name = "BOLETABindingNavigatorSaveItem"
        Me.BOLETABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BOLETABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdBoletaLabel
        '
        IdBoletaLabel.AutoSize = True
        IdBoletaLabel.Location = New System.Drawing.Point(240, 48)
        IdBoletaLabel.Name = "IdBoletaLabel"
        IdBoletaLabel.Size = New System.Drawing.Size(67, 17)
        IdBoletaLabel.TabIndex = 1
        IdBoletaLabel.Text = "Id Boleta:"
        '
        'IdBoletaTextBox
        '
        Me.IdBoletaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdBoletaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOLETABindingSource, "IdBoleta", True))
        Me.IdBoletaTextBox.Location = New System.Drawing.Point(355, 45)
        Me.IdBoletaTextBox.Name = "IdBoletaTextBox"
        Me.IdBoletaTextBox.Size = New System.Drawing.Size(268, 22)
        Me.IdBoletaTextBox.TabIndex = 2
        '
        'IdPagoPlanillaLabel
        '
        IdPagoPlanillaLabel.AutoSize = True
        IdPagoPlanillaLabel.Location = New System.Drawing.Point(240, 76)
        IdPagoPlanillaLabel.Name = "IdPagoPlanillaLabel"
        IdPagoPlanillaLabel.Size = New System.Drawing.Size(109, 17)
        IdPagoPlanillaLabel.TabIndex = 3
        IdPagoPlanillaLabel.Text = "Id Pago Planilla:"
        '
        'IdPagoPlanillaTextBox
        '
        Me.IdPagoPlanillaTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdPagoPlanillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOLETABindingSource, "IdPagoPlanilla", True))
        Me.IdPagoPlanillaTextBox.Location = New System.Drawing.Point(355, 73)
        Me.IdPagoPlanillaTextBox.Name = "IdPagoPlanillaTextBox"
        Me.IdPagoPlanillaTextBox.Size = New System.Drawing.Size(268, 22)
        Me.IdPagoPlanillaTextBox.TabIndex = 4
        '
        'FechaBoletaLabel
        '
        FechaBoletaLabel.AutoSize = True
        FechaBoletaLabel.Location = New System.Drawing.Point(240, 105)
        FechaBoletaLabel.Name = "FechaBoletaLabel"
        FechaBoletaLabel.Size = New System.Drawing.Size(95, 17)
        FechaBoletaLabel.TabIndex = 5
        FechaBoletaLabel.Text = "Fecha Boleta:"
        '
        'FechaBoletaDateTimePicker
        '
        Me.FechaBoletaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOLETABindingSource, "fechaBoleta", True))
        Me.FechaBoletaDateTimePicker.Location = New System.Drawing.Point(355, 101)
        Me.FechaBoletaDateTimePicker.Name = "FechaBoletaDateTimePicker"
        Me.FechaBoletaDateTimePicker.Size = New System.Drawing.Size(268, 22)
        Me.FechaBoletaDateTimePicker.TabIndex = 6
        '
        'BOLETADataGridView
        '
        Me.BOLETADataGridView.AutoGenerateColumns = False
        Me.BOLETADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.BOLETADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BOLETADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BOLETADataGridView.DataSource = Me.BOLETABindingSource
        Me.BOLETADataGridView.Location = New System.Drawing.Point(184, 153)
        Me.BOLETADataGridView.Name = "BOLETADataGridView"
        Me.BOLETADataGridView.RowTemplate.Height = 24
        Me.BOLETADataGridView.Size = New System.Drawing.Size(554, 220)
        Me.BOLETADataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdBoleta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdBoleta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdPagoPlanilla"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdPagoPlanilla"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fechaBoleta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaBoleta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'FrmBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(915, 510)
        Me.Controls.Add(Me.BOLETADataGridView)
        Me.Controls.Add(IdBoletaLabel)
        Me.Controls.Add(Me.IdBoletaTextBox)
        Me.Controls.Add(IdPagoPlanillaLabel)
        Me.Controls.Add(Me.IdPagoPlanillaTextBox)
        Me.Controls.Add(FechaBoletaLabel)
        Me.Controls.Add(Me.FechaBoletaDateTimePicker)
        Me.Controls.Add(Me.BOLETABindingNavigator)
        Me.Name = "FrmBoleta"
        Me.Text = "Boleta"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOLETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOLETABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOLETABindingNavigator.ResumeLayout(False)
        Me.BOLETABindingNavigator.PerformLayout()
        CType(Me.BOLETADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents BOLETABindingSource As BindingSource
    Friend WithEvents BOLETATableAdapter As BD_RecursosHumanosDataSetTableAdapters.BOLETATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BOLETABindingNavigator As BindingNavigator
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
    Friend WithEvents BOLETABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdBoletaTextBox As TextBox
    Friend WithEvents IdPagoPlanillaTextBox As TextBox
    Friend WithEvents FechaBoletaDateTimePicker As DateTimePicker
    Friend WithEvents BOLETADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
