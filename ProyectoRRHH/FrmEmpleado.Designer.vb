<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim IdNivelEducacionLabel As System.Windows.Forms.Label
        Dim IdDatoTributarioLabel As System.Windows.Forms.Label
        Dim IdVacacionesLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim IdRegimenSaludLabel As System.Windows.Forms.Label
        Dim IdRegimenPensionarioLabel As System.Windows.Forms.Label
        Dim IdDistritoLabel As System.Windows.Forms.Label
        Me.BD_RecursosHumanosDataSet = New ProyectoRRHH.BD_RecursosHumanosDataSet()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOTableAdapter = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.EMPLEADOTableAdapter()
        Me.TableAdapterManager = New ProyectoRRHH.BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager()
        Me.EMPLEADOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EMPLEADOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.IdNivelEducacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdDatoTributarioTextBox = New System.Windows.Forms.TextBox()
        Me.IdVacacionesTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegimenSaludTextBox = New System.Windows.Forms.TextBox()
        Me.IdRegimenPensionarioTextBox = New System.Windows.Forms.TextBox()
        Me.IdDistritoTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLEADODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        IdNivelEducacionLabel = New System.Windows.Forms.Label()
        IdDatoTributarioLabel = New System.Windows.Forms.Label()
        IdVacacionesLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        IdRegimenSaludLabel = New System.Windows.Forms.Label()
        IdRegimenPensionarioLabel = New System.Windows.Forms.Label()
        IdDistritoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPLEADOBindingNavigator.SuspendLayout()
        CType(Me.EMPLEADODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_RecursosHumanosDataSet
        '
        Me.BD_RecursosHumanosDataSet.DataSetName = "BD_RecursosHumanosDataSet"
        Me.BD_RecursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.BD_RecursosHumanosDataSet
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EMPLEADOTableAdapter = Me.EMPLEADOTableAdapter
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
        'EMPLEADOBindingNavigator
        '
        Me.EMPLEADOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPLEADOBindingNavigator.BindingSource = Me.EMPLEADOBindingSource
        Me.EMPLEADOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPLEADOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPLEADOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EMPLEADOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPLEADOBindingNavigatorSaveItem})
        Me.EMPLEADOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPLEADOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPLEADOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPLEADOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPLEADOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPLEADOBindingNavigator.Name = "EMPLEADOBindingNavigator"
        Me.EMPLEADOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPLEADOBindingNavigator.Size = New System.Drawing.Size(1924, 27)
        Me.EMPLEADOBindingNavigator.TabIndex = 0
        Me.EMPLEADOBindingNavigator.Text = "BindingNavigator1"
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
        'EMPLEADOBindingNavigatorSaveItem
        '
        Me.EMPLEADOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPLEADOBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPLEADOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPLEADOBindingNavigatorSaveItem.Name = "EMPLEADOBindingNavigatorSaveItem"
        Me.EMPLEADOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EMPLEADOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(84, 48)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(90, 17)
        IdEmpleadoLabel.TabIndex = 1
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(252, 45)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(236, 22)
        Me.IdEmpleadoTextBox.TabIndex = 2
        '
        'IdNivelEducacionLabel
        '
        IdNivelEducacionLabel.AutoSize = True
        IdNivelEducacionLabel.Location = New System.Drawing.Point(84, 76)
        IdNivelEducacionLabel.Name = "IdNivelEducacionLabel"
        IdNivelEducacionLabel.Size = New System.Drawing.Size(128, 17)
        IdNivelEducacionLabel.TabIndex = 3
        IdNivelEducacionLabel.Text = "Id Nivel Educacion:"
        '
        'IdNivelEducacionTextBox
        '
        Me.IdNivelEducacionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdNivelEducacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdNivelEducacion", True))
        Me.IdNivelEducacionTextBox.Location = New System.Drawing.Point(252, 73)
        Me.IdNivelEducacionTextBox.Name = "IdNivelEducacionTextBox"
        Me.IdNivelEducacionTextBox.Size = New System.Drawing.Size(236, 22)
        Me.IdNivelEducacionTextBox.TabIndex = 4
        '
        'IdDatoTributarioLabel
        '
        IdDatoTributarioLabel.AutoSize = True
        IdDatoTributarioLabel.Location = New System.Drawing.Point(84, 104)
        IdDatoTributarioLabel.Name = "IdDatoTributarioLabel"
        IdDatoTributarioLabel.Size = New System.Drawing.Size(122, 17)
        IdDatoTributarioLabel.TabIndex = 5
        IdDatoTributarioLabel.Text = "Id Dato Tributario:"
        '
        'IdDatoTributarioTextBox
        '
        Me.IdDatoTributarioTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdDatoTributarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdDatoTributario", True))
        Me.IdDatoTributarioTextBox.Location = New System.Drawing.Point(252, 101)
        Me.IdDatoTributarioTextBox.Name = "IdDatoTributarioTextBox"
        Me.IdDatoTributarioTextBox.Size = New System.Drawing.Size(236, 22)
        Me.IdDatoTributarioTextBox.TabIndex = 6
        '
        'IdVacacionesLabel
        '
        IdVacacionesLabel.AutoSize = True
        IdVacacionesLabel.Location = New System.Drawing.Point(84, 132)
        IdVacacionesLabel.Name = "IdVacacionesLabel"
        IdVacacionesLabel.Size = New System.Drawing.Size(100, 17)
        IdVacacionesLabel.TabIndex = 7
        IdVacacionesLabel.Text = "Id Vacaciones:"
        '
        'IdVacacionesTextBox
        '
        Me.IdVacacionesTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdVacacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdVacaciones", True))
        Me.IdVacacionesTextBox.Location = New System.Drawing.Point(252, 129)
        Me.IdVacacionesTextBox.Name = "IdVacacionesTextBox"
        Me.IdVacacionesTextBox.Size = New System.Drawing.Size(236, 22)
        Me.IdVacacionesTextBox.TabIndex = 8
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(84, 160)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(69, 17)
        NombresLabel.TabIndex = 9
        NombresLabel.Text = "Nombres:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(252, 157)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(236, 22)
        Me.NombresTextBox.TabIndex = 10
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(84, 195)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(35, 17)
        DNILabel.TabIndex = 11
        DNILabel.Text = "DNI:"
        '
        'DNITextBox
        '
        Me.DNITextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(252, 192)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(236, 22)
        Me.DNITextBox.TabIndex = 12
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(84, 223)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 13
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(252, 220)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(236, 22)
        Me.ApellidosTextBox.TabIndex = 14
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(639, 52)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(125, 17)
        FechaNacimientoLabel.TabIndex = 15
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPLEADOBindingSource, "fechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(807, 48)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(275, 22)
        Me.FechaNacimientoDateTimePicker.TabIndex = 16
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(639, 79)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 17
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(807, 76)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(275, 22)
        Me.DireccionTextBox.TabIndex = 18
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(639, 107)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(68, 17)
        TelefonoLabel.TabIndex = 19
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(807, 104)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(275, 22)
        Me.TelefonoTextBox.TabIndex = 20
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(639, 135)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(55, 17)
        CorreoLabel.TabIndex = 21
        CorreoLabel.Text = "Correo:"
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(807, 132)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(275, 22)
        Me.CorreoTextBox.TabIndex = 22
        '
        'IdRegimenSaludLabel
        '
        IdRegimenSaludLabel.AutoSize = True
        IdRegimenSaludLabel.Location = New System.Drawing.Point(639, 163)
        IdRegimenSaludLabel.Name = "IdRegimenSaludLabel"
        IdRegimenSaludLabel.Size = New System.Drawing.Size(123, 17)
        IdRegimenSaludLabel.TabIndex = 23
        IdRegimenSaludLabel.Text = "Id Regimen Salud:"
        '
        'IdRegimenSaludTextBox
        '
        Me.IdRegimenSaludTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdRegimenSaludTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdRegimenSalud", True))
        Me.IdRegimenSaludTextBox.Location = New System.Drawing.Point(807, 160)
        Me.IdRegimenSaludTextBox.Name = "IdRegimenSaludTextBox"
        Me.IdRegimenSaludTextBox.Size = New System.Drawing.Size(275, 22)
        Me.IdRegimenSaludTextBox.TabIndex = 24
        '
        'IdRegimenPensionarioLabel
        '
        IdRegimenPensionarioLabel.AutoSize = True
        IdRegimenPensionarioLabel.Location = New System.Drawing.Point(639, 191)
        IdRegimenPensionarioLabel.Name = "IdRegimenPensionarioLabel"
        IdRegimenPensionarioLabel.Size = New System.Drawing.Size(162, 17)
        IdRegimenPensionarioLabel.TabIndex = 25
        IdRegimenPensionarioLabel.Text = "Id Regimen Pensionario:"
        '
        'IdRegimenPensionarioTextBox
        '
        Me.IdRegimenPensionarioTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdRegimenPensionarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdRegimenPensionario", True))
        Me.IdRegimenPensionarioTextBox.Location = New System.Drawing.Point(807, 188)
        Me.IdRegimenPensionarioTextBox.Name = "IdRegimenPensionarioTextBox"
        Me.IdRegimenPensionarioTextBox.Size = New System.Drawing.Size(275, 22)
        Me.IdRegimenPensionarioTextBox.TabIndex = 26
        '
        'IdDistritoLabel
        '
        IdDistritoLabel.AutoSize = True
        IdDistritoLabel.Location = New System.Drawing.Point(639, 219)
        IdDistritoLabel.Name = "IdDistritoLabel"
        IdDistritoLabel.Size = New System.Drawing.Size(71, 17)
        IdDistritoLabel.TabIndex = 27
        IdDistritoLabel.Text = "Id Distrito:"
        '
        'IdDistritoTextBox
        '
        Me.IdDistritoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.IdDistritoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOBindingSource, "IdDistrito", True))
        Me.IdDistritoTextBox.Location = New System.Drawing.Point(807, 216)
        Me.IdDistritoTextBox.Name = "IdDistritoTextBox"
        Me.IdDistritoTextBox.Size = New System.Drawing.Size(275, 22)
        Me.IdDistritoTextBox.TabIndex = 28
        '
        'EMPLEADODataGridView
        '
        Me.EMPLEADODataGridView.AutoGenerateColumns = False
        Me.EMPLEADODataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EMPLEADODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPLEADODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EMPLEADODataGridView.DataSource = Me.EMPLEADOBindingSource
        Me.EMPLEADODataGridView.Location = New System.Drawing.Point(12, 276)
        Me.EMPLEADODataGridView.Name = "EMPLEADODataGridView"
        Me.EMPLEADODataGridView.RowTemplate.Height = 24
        Me.EMPLEADODataGridView.Size = New System.Drawing.Size(1763, 250)
        Me.EMPLEADODataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdNivelEducacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdNivelEducacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDatoTributario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdDatoTributario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdVacaciones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdVacaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fechaNacimiento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IdRegimenSalud"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IdRegimenSalud"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IdRegimenPensionario"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IdRegimenPensionario"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IdDistrito"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IdDistrito"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 593)
        Me.Controls.Add(Me.EMPLEADODataGridView)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(IdNivelEducacionLabel)
        Me.Controls.Add(Me.IdNivelEducacionTextBox)
        Me.Controls.Add(IdDatoTributarioLabel)
        Me.Controls.Add(Me.IdDatoTributarioTextBox)
        Me.Controls.Add(IdVacacionesLabel)
        Me.Controls.Add(Me.IdVacacionesTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(FechaNacimientoLabel)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(IdRegimenSaludLabel)
        Me.Controls.Add(Me.IdRegimenSaludTextBox)
        Me.Controls.Add(IdRegimenPensionarioLabel)
        Me.Controls.Add(Me.IdRegimenPensionarioTextBox)
        Me.Controls.Add(IdDistritoLabel)
        Me.Controls.Add(Me.IdDistritoTextBox)
        Me.Controls.Add(Me.EMPLEADOBindingNavigator)
        Me.Name = "FrmEmpleado"
        Me.Text = "Empleado"
        CType(Me.BD_RecursosHumanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPLEADOBindingNavigator.ResumeLayout(False)
        Me.EMPLEADOBindingNavigator.PerformLayout()
        CType(Me.EMPLEADODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecursosHumanosDataSet As BD_RecursosHumanosDataSet
    Friend WithEvents EMPLEADOBindingSource As BindingSource
    Friend WithEvents EMPLEADOTableAdapter As BD_RecursosHumanosDataSetTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecursosHumanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPLEADOBindingNavigator As BindingNavigator
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
    Friend WithEvents EMPLEADOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents IdNivelEducacionTextBox As TextBox
    Friend WithEvents IdDatoTributarioTextBox As TextBox
    Friend WithEvents IdVacacionesTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents IdRegimenSaludTextBox As TextBox
    Friend WithEvents IdRegimenPensionarioTextBox As TextBox
    Friend WithEvents IdDistritoTextBox As TextBox
    Friend WithEvents EMPLEADODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
