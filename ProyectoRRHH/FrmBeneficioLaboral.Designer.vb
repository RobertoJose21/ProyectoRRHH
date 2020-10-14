<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeneficioLaboral
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
        Dim IdBeneficioLabel As System.Windows.Forms.Label
        Dim TipoBeneficioLabel As System.Windows.Forms.Label
        Dim MontoBeneficioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBeneficioLaboral))
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.BENEFICIO_LABORALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BENEFICIO_LABORALTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.BENEFICIO_LABORALTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.BENEFICIO_LABORALBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdBeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.TipoBeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.MontoBeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.BENEFICIO_LABORALDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdBeneficioLabel = New System.Windows.Forms.Label()
        TipoBeneficioLabel = New System.Windows.Forms.Label()
        MontoBeneficioLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BENEFICIO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BENEFICIO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BENEFICIO_LABORALBindingNavigator.SuspendLayout()
        CType(Me.BENEFICIO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdBeneficioLabel
        '
        IdBeneficioLabel.AutoSize = True
        IdBeneficioLabel.Location = New System.Drawing.Point(324, 42)
        IdBeneficioLabel.Name = "IdBeneficioLabel"
        IdBeneficioLabel.Size = New System.Drawing.Size(85, 17)
        IdBeneficioLabel.TabIndex = 1
        IdBeneficioLabel.Text = "Id Beneficio:"
        '
        'TipoBeneficioLabel
        '
        TipoBeneficioLabel.AutoSize = True
        TipoBeneficioLabel.Location = New System.Drawing.Point(324, 70)
        TipoBeneficioLabel.Name = "TipoBeneficioLabel"
        TipoBeneficioLabel.Size = New System.Drawing.Size(102, 17)
        TipoBeneficioLabel.TabIndex = 3
        TipoBeneficioLabel.Text = "Tipo Beneficio:"
        '
        'MontoBeneficioLabel
        '
        MontoBeneficioLabel.AutoSize = True
        MontoBeneficioLabel.Location = New System.Drawing.Point(324, 98)
        MontoBeneficioLabel.Name = "MontoBeneficioLabel"
        MontoBeneficioLabel.Size = New System.Drawing.Size(113, 17)
        MontoBeneficioLabel.TabIndex = 5
        MontoBeneficioLabel.Text = "Monto Beneficio:"
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BENEFICIO_LABORALBindingSource
        '
        Me.BENEFICIO_LABORALBindingSource.DataMember = "BENEFICIO_LABORAL"
        Me.BENEFICIO_LABORALBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'BENEFICIO_LABORALTableAdapter
        '
        Me.BENEFICIO_LABORALTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.ASISTENCIATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BENEFICIO_LABORALTableAdapter = Me.BENEFICIO_LABORALTableAdapter
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
        Me.TableAdapterManager.VARIACION_SUELDOTableAdapter = Nothing
        '
        'BENEFICIO_LABORALBindingNavigator
        '
        Me.BENEFICIO_LABORALBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BENEFICIO_LABORALBindingNavigator.BindingSource = Me.BENEFICIO_LABORALBindingSource
        Me.BENEFICIO_LABORALBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BENEFICIO_LABORALBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BENEFICIO_LABORALBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BENEFICIO_LABORALBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BENEFICIO_LABORALBindingNavigatorSaveItem})
        Me.BENEFICIO_LABORALBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BENEFICIO_LABORALBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BENEFICIO_LABORALBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BENEFICIO_LABORALBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BENEFICIO_LABORALBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BENEFICIO_LABORALBindingNavigator.Name = "BENEFICIO_LABORALBindingNavigator"
        Me.BENEFICIO_LABORALBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BENEFICIO_LABORALBindingNavigator.Size = New System.Drawing.Size(1075, 27)
        Me.BENEFICIO_LABORALBindingNavigator.TabIndex = 0
        Me.BENEFICIO_LABORALBindingNavigator.Text = "BindingNavigator1"
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
        'BENEFICIO_LABORALBindingNavigatorSaveItem
        '
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem.Image = CType(resources.GetObject("BENEFICIO_LABORALBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem.Name = "BENEFICIO_LABORALBindingNavigatorSaveItem"
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.BENEFICIO_LABORALBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdBeneficioTextBox
        '
        Me.IdBeneficioTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdBeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BENEFICIO_LABORALBindingSource, "IdBeneficio", True))
        Me.IdBeneficioTextBox.Location = New System.Drawing.Point(443, 39)
        Me.IdBeneficioTextBox.Name = "IdBeneficioTextBox"
        Me.IdBeneficioTextBox.Size = New System.Drawing.Size(230, 22)
        Me.IdBeneficioTextBox.TabIndex = 2
        '
        'TipoBeneficioTextBox
        '
        Me.TipoBeneficioTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TipoBeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BENEFICIO_LABORALBindingSource, "tipoBeneficio", True))
        Me.TipoBeneficioTextBox.Location = New System.Drawing.Point(443, 67)
        Me.TipoBeneficioTextBox.Name = "TipoBeneficioTextBox"
        Me.TipoBeneficioTextBox.Size = New System.Drawing.Size(230, 22)
        Me.TipoBeneficioTextBox.TabIndex = 4
        '
        'MontoBeneficioTextBox
        '
        Me.MontoBeneficioTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.MontoBeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BENEFICIO_LABORALBindingSource, "montoBeneficio", True))
        Me.MontoBeneficioTextBox.Location = New System.Drawing.Point(443, 95)
        Me.MontoBeneficioTextBox.Name = "MontoBeneficioTextBox"
        Me.MontoBeneficioTextBox.Size = New System.Drawing.Size(230, 22)
        Me.MontoBeneficioTextBox.TabIndex = 6
        '
        'BENEFICIO_LABORALDataGridView
        '
        Me.BENEFICIO_LABORALDataGridView.AutoGenerateColumns = False
        Me.BENEFICIO_LABORALDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.BENEFICIO_LABORALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BENEFICIO_LABORALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BENEFICIO_LABORALDataGridView.DataSource = Me.BENEFICIO_LABORALBindingSource
        Me.BENEFICIO_LABORALDataGridView.Location = New System.Drawing.Point(244, 132)
        Me.BENEFICIO_LABORALDataGridView.Name = "BENEFICIO_LABORALDataGridView"
        Me.BENEFICIO_LABORALDataGridView.RowTemplate.Height = 24
        Me.BENEFICIO_LABORALDataGridView.Size = New System.Drawing.Size(521, 228)
        Me.BENEFICIO_LABORALDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdBeneficio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdBeneficio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoBeneficio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tipoBeneficio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "montoBeneficio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "montoBeneficio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'FrmBeneficioLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 398)
        Me.Controls.Add(Me.BENEFICIO_LABORALDataGridView)
        Me.Controls.Add(IdBeneficioLabel)
        Me.Controls.Add(Me.IdBeneficioTextBox)
        Me.Controls.Add(TipoBeneficioLabel)
        Me.Controls.Add(Me.TipoBeneficioTextBox)
        Me.Controls.Add(MontoBeneficioLabel)
        Me.Controls.Add(Me.MontoBeneficioTextBox)
        Me.Controls.Add(Me.BENEFICIO_LABORALBindingNavigator)
        Me.Name = "FrmBeneficioLaboral"
        Me.Text = "BeneficioLaboral"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BENEFICIO_LABORALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BENEFICIO_LABORALBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BENEFICIO_LABORALBindingNavigator.ResumeLayout(False)
        Me.BENEFICIO_LABORALBindingNavigator.PerformLayout()
        CType(Me.BENEFICIO_LABORALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents BENEFICIO_LABORALBindingSource As BindingSource
    Friend WithEvents BENEFICIO_LABORALTableAdapter As BD_RecursosHumanosDataSetTableAdapters.BENEFICIO_LABORALTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BENEFICIO_LABORALBindingNavigator As BindingNavigator
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
    Friend WithEvents BENEFICIO_LABORALBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdBeneficioTextBox As TextBox
    Friend WithEvents TipoBeneficioTextBox As TextBox
    Friend WithEvents MontoBeneficioTextBox As TextBox
    Friend WithEvents BENEFICIO_LABORALDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
