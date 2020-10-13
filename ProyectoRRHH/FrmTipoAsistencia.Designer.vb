<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoAsistencia))
        Dim IdTipoAsistenciaLabel As System.Windows.Forms.Label
        Dim TipoAsistenciaLabel As System.Windows.Forms.Label
        Me.DB_RRHHDataSet = New ProyectoRRHH.DB_RRHHDataSet()
        Me.TIPO_ASISTENCIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_ASISTENCIATableAdapter = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TIPO_ASISTENCIATableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_ASISTENCIABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTipoAsistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoAsistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_ASISTENCIADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdTipoAsistenciaLabel = New System.Windows.Forms.Label()
        TipoAsistenciaLabel = New System.Windows.Forms.Label()
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_ASISTENCIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_ASISTENCIABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPO_ASISTENCIABindingNavigator.SuspendLayout()
        CType(Me.TIPO_ASISTENCIADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_RRHHDataSet
        '
        Me.DB_RRHHDataSet.DataSetName = "DB_RRHHDataSet"
        Me.DB_RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPO_ASISTENCIABindingSource
        '
        Me.TIPO_ASISTENCIABindingSource.DataMember = "TIPO_ASISTENCIA"
        Me.TIPO_ASISTENCIABindingSource.DataSource = Me.DB_RRHHDataSet
        '
        'TIPO_ASISTENCIATableAdapter
        '
        Me.TIPO_ASISTENCIATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TIPO_ASISTENCIATableAdapter = Me.TIPO_ASISTENCIATableAdapter
        Me.TableAdapterManager.TIPO_CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_TRABAJADORTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoRRHH.DB_RRHHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VACACIONESTableAdapter = Nothing
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'TIPO_ASISTENCIABindingNavigator
        '
        Me.TIPO_ASISTENCIABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPO_ASISTENCIABindingNavigator.BindingSource = Me.TIPO_ASISTENCIABindingSource
        Me.TIPO_ASISTENCIABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPO_ASISTENCIABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPO_ASISTENCIABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TIPO_ASISTENCIABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPO_ASISTENCIABindingNavigatorSaveItem})
        Me.TIPO_ASISTENCIABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPO_ASISTENCIABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPO_ASISTENCIABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPO_ASISTENCIABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPO_ASISTENCIABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPO_ASISTENCIABindingNavigator.Name = "TIPO_ASISTENCIABindingNavigator"
        Me.TIPO_ASISTENCIABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPO_ASISTENCIABindingNavigator.Size = New System.Drawing.Size(821, 27)
        Me.TIPO_ASISTENCIABindingNavigator.TabIndex = 0
        Me.TIPO_ASISTENCIABindingNavigator.Text = "BindingNavigator1"
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
        'TIPO_ASISTENCIABindingNavigatorSaveItem
        '
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPO_ASISTENCIABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem.Name = "TIPO_ASISTENCIABindingNavigatorSaveItem"
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TIPO_ASISTENCIABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTipoAsistenciaLabel
        '
        IdTipoAsistenciaLabel.AutoSize = True
        IdTipoAsistenciaLabel.Location = New System.Drawing.Point(77, 48)
        IdTipoAsistenciaLabel.Name = "IdTipoAsistenciaLabel"
        IdTipoAsistenciaLabel.Size = New System.Drawing.Size(123, 17)
        IdTipoAsistenciaLabel.TabIndex = 1
        IdTipoAsistenciaLabel.Text = "Id Tipo Asistencia:"
        '
        'IdTipoAsistenciaTextBox
        '
        Me.IdTipoAsistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_ASISTENCIABindingSource, "IdTipoAsistencia", True))
        Me.IdTipoAsistenciaTextBox.Location = New System.Drawing.Point(206, 45)
        Me.IdTipoAsistenciaTextBox.Name = "IdTipoAsistenciaTextBox"
        Me.IdTipoAsistenciaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdTipoAsistenciaTextBox.TabIndex = 2
        '
        'TipoAsistenciaLabel
        '
        TipoAsistenciaLabel.AutoSize = True
        TipoAsistenciaLabel.Location = New System.Drawing.Point(77, 76)
        TipoAsistenciaLabel.Name = "TipoAsistenciaLabel"
        TipoAsistenciaLabel.Size = New System.Drawing.Size(103, 17)
        TipoAsistenciaLabel.TabIndex = 3
        TipoAsistenciaLabel.Text = "tipo Asistencia:"
        '
        'TipoAsistenciaTextBox
        '
        Me.TipoAsistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPO_ASISTENCIABindingSource, "tipoAsistencia", True))
        Me.TipoAsistenciaTextBox.Location = New System.Drawing.Point(206, 73)
        Me.TipoAsistenciaTextBox.Name = "TipoAsistenciaTextBox"
        Me.TipoAsistenciaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TipoAsistenciaTextBox.TabIndex = 4
        '
        'TIPO_ASISTENCIADataGridView
        '
        Me.TIPO_ASISTENCIADataGridView.AutoGenerateColumns = False
        Me.TIPO_ASISTENCIADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TIPO_ASISTENCIADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TIPO_ASISTENCIADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TIPO_ASISTENCIADataGridView.DataSource = Me.TIPO_ASISTENCIABindingSource
        Me.TIPO_ASISTENCIADataGridView.Location = New System.Drawing.Point(361, 30)
        Me.TIPO_ASISTENCIADataGridView.Name = "TIPO_ASISTENCIADataGridView"
        Me.TIPO_ASISTENCIADataGridView.RowTemplate.Height = 24
        Me.TIPO_ASISTENCIADataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TIPO_ASISTENCIADataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTipoAsistencia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdTipoAsistencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoAsistencia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipoAsistencia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'FrmTipoAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 369)
        Me.Controls.Add(Me.TIPO_ASISTENCIADataGridView)
        Me.Controls.Add(IdTipoAsistenciaLabel)
        Me.Controls.Add(Me.IdTipoAsistenciaTextBox)
        Me.Controls.Add(TipoAsistenciaLabel)
        Me.Controls.Add(Me.TipoAsistenciaTextBox)
        Me.Controls.Add(Me.TIPO_ASISTENCIABindingNavigator)
        Me.Name = "FrmTipoAsistencia"
        Me.Text = "Tipo_Asistencia"
        CType(Me.DB_RRHHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_ASISTENCIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_ASISTENCIABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPO_ASISTENCIABindingNavigator.ResumeLayout(False)
        Me.TIPO_ASISTENCIABindingNavigator.PerformLayout()
        CType(Me.TIPO_ASISTENCIADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB_RRHHDataSet As DB_RRHHDataSet
    Friend WithEvents TIPO_ASISTENCIABindingSource As BindingSource
    Friend WithEvents TIPO_ASISTENCIATableAdapter As DB_RRHHDataSetTableAdapters.TIPO_ASISTENCIATableAdapter
    Friend WithEvents TableAdapterManager As DB_RRHHDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIPO_ASISTENCIABindingNavigator As BindingNavigator
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
    Friend WithEvents TIPO_ASISTENCIABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTipoAsistenciaTextBox As TextBox
    Friend WithEvents TipoAsistenciaTextBox As TextBox
    Friend WithEvents TIPO_ASISTENCIADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
