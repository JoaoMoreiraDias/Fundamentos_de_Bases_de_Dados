<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alojamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim A_H_HOTEL_IDLabel As System.Windows.Forms.Label
        Dim A_H_A_T_IDLabel As System.Windows.Forms.Label
        Dim A_H_TIPOLabel As System.Windows.Forms.Label
        Dim A_H_EstadoLabel As System.Windows.Forms.Label
        Dim A_H_EXTRALabel As System.Windows.Forms.Label
        Dim A_H_PRECOLabel As System.Windows.Forms.Label
        Dim A_H_OCUPALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alojamento))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.A_H_HOTEL_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ALOJAMENTO_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.A_H_A_T_IDTextBox = New System.Windows.Forms.TextBox()
        Me.A_H_TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.A_H_EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.A_H_EXTRATextBox = New System.Windows.Forms.TextBox()
        Me.A_H_PRECOTextBox = New System.Windows.Forms.TextBox()
        Me.A_H_OCUPATextBox = New System.Windows.Forms.TextBox()
        Me.ALOJAMENTO_HDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALOJAMENTO_HTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.ALOJAMENTO_HTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ALOJAMENTO_HBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ALOJAMENTO_HBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        A_H_HOTEL_IDLabel = New System.Windows.Forms.Label()
        A_H_A_T_IDLabel = New System.Windows.Forms.Label()
        A_H_TIPOLabel = New System.Windows.Forms.Label()
        A_H_EstadoLabel = New System.Windows.Forms.Label()
        A_H_EXTRALabel = New System.Windows.Forms.Label()
        A_H_PRECOLabel = New System.Windows.Forms.Label()
        A_H_OCUPALabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ALOJAMENTO_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALOJAMENTO_HDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALOJAMENTO_HBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALOJAMENTO_HBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'A_H_HOTEL_IDLabel
        '
        A_H_HOTEL_IDLabel.AutoSize = True
        A_H_HOTEL_IDLabel.Location = New System.Drawing.Point(12, 61)
        A_H_HOTEL_IDLabel.Name = "A_H_HOTEL_IDLabel"
        A_H_HOTEL_IDLabel.Size = New System.Drawing.Size(81, 13)
        A_H_HOTEL_IDLabel.TabIndex = 2
        A_H_HOTEL_IDLabel.Text = "A H HOTEL ID:"
        '
        'A_H_A_T_IDLabel
        '
        A_H_A_T_IDLabel.AutoSize = True
        A_H_A_T_IDLabel.Location = New System.Drawing.Point(12, 87)
        A_H_A_T_IDLabel.Name = "A_H_A_T_IDLabel"
        A_H_A_T_IDLabel.Size = New System.Drawing.Size(62, 13)
        A_H_A_T_IDLabel.TabIndex = 4
        A_H_A_T_IDLabel.Text = "A H A T ID:"
        '
        'A_H_TIPOLabel
        '
        A_H_TIPOLabel.AutoSize = True
        A_H_TIPOLabel.Location = New System.Drawing.Point(12, 113)
        A_H_TIPOLabel.Name = "A_H_TIPOLabel"
        A_H_TIPOLabel.Size = New System.Drawing.Size(56, 13)
        A_H_TIPOLabel.TabIndex = 6
        A_H_TIPOLabel.Text = "A H TIPO:"
        '
        'A_H_EstadoLabel
        '
        A_H_EstadoLabel.AutoSize = True
        A_H_EstadoLabel.Location = New System.Drawing.Point(12, 139)
        A_H_EstadoLabel.Name = "A_H_EstadoLabel"
        A_H_EstadoLabel.Size = New System.Drawing.Size(64, 13)
        A_H_EstadoLabel.TabIndex = 8
        A_H_EstadoLabel.Text = "A H Estado:"
        '
        'A_H_EXTRALabel
        '
        A_H_EXTRALabel.AutoSize = True
        A_H_EXTRALabel.Location = New System.Drawing.Point(12, 165)
        A_H_EXTRALabel.Name = "A_H_EXTRALabel"
        A_H_EXTRALabel.Size = New System.Drawing.Size(67, 13)
        A_H_EXTRALabel.TabIndex = 10
        A_H_EXTRALabel.Text = "A H EXTRA:"
        '
        'A_H_PRECOLabel
        '
        A_H_PRECOLabel.AutoSize = True
        A_H_PRECOLabel.Location = New System.Drawing.Point(12, 191)
        A_H_PRECOLabel.Name = "A_H_PRECOLabel"
        A_H_PRECOLabel.Size = New System.Drawing.Size(68, 13)
        A_H_PRECOLabel.TabIndex = 12
        A_H_PRECOLabel.Text = "A H PRECO:"
        '
        'A_H_OCUPALabel
        '
        A_H_OCUPALabel.AutoSize = True
        A_H_OCUPALabel.Location = New System.Drawing.Point(12, 217)
        A_H_OCUPALabel.Name = "A_H_OCUPALabel"
        A_H_OCUPALabel.Size = New System.Drawing.Size(68, 13)
        A_H_OCUPALabel.TabIndex = 14
        A_H_OCUPALabel.Text = "A H OCUPA:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(A_H_HOTEL_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_HOTEL_IDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_A_T_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_A_T_IDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_TIPOLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_TIPOTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_EstadoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_EstadoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_EXTRALabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_EXTRATextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_PRECOLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_PRECOTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(A_H_OCUPALabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A_H_OCUPATextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.ALOJAMENTO_HDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(850, 389)
        Me.SplitContainer1.SplitterDistance = 283
        Me.SplitContainer1.TabIndex = 0
        '
        'A_H_HOTEL_IDTextBox
        '
        Me.A_H_HOTEL_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_HOTEL_ID", True))
        Me.A_H_HOTEL_IDTextBox.Location = New System.Drawing.Point(99, 58)
        Me.A_H_HOTEL_IDTextBox.Name = "A_H_HOTEL_IDTextBox"
        Me.A_H_HOTEL_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_HOTEL_IDTextBox.TabIndex = 3
        '
        'ALOJAMENTO_HBindingSource
        '
        Me.ALOJAMENTO_HBindingSource.DataMember = "ALOJAMENTO_H"
        Me.ALOJAMENTO_HBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'A_H_A_T_IDTextBox
        '
        Me.A_H_A_T_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_A_T_ID", True))
        Me.A_H_A_T_IDTextBox.Location = New System.Drawing.Point(99, 84)
        Me.A_H_A_T_IDTextBox.Name = "A_H_A_T_IDTextBox"
        Me.A_H_A_T_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_A_T_IDTextBox.TabIndex = 5
        '
        'A_H_TIPOTextBox
        '
        Me.A_H_TIPOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_TIPO", True))
        Me.A_H_TIPOTextBox.Location = New System.Drawing.Point(99, 110)
        Me.A_H_TIPOTextBox.Name = "A_H_TIPOTextBox"
        Me.A_H_TIPOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_TIPOTextBox.TabIndex = 7
        '
        'A_H_EstadoTextBox
        '
        Me.A_H_EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_Estado", True))
        Me.A_H_EstadoTextBox.Location = New System.Drawing.Point(99, 136)
        Me.A_H_EstadoTextBox.Name = "A_H_EstadoTextBox"
        Me.A_H_EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_EstadoTextBox.TabIndex = 9
        '
        'A_H_EXTRATextBox
        '
        Me.A_H_EXTRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_EXTRA", True))
        Me.A_H_EXTRATextBox.Location = New System.Drawing.Point(99, 162)
        Me.A_H_EXTRATextBox.Name = "A_H_EXTRATextBox"
        Me.A_H_EXTRATextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_EXTRATextBox.TabIndex = 11
        '
        'A_H_PRECOTextBox
        '
        Me.A_H_PRECOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_PRECO", True))
        Me.A_H_PRECOTextBox.Location = New System.Drawing.Point(99, 188)
        Me.A_H_PRECOTextBox.Name = "A_H_PRECOTextBox"
        Me.A_H_PRECOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_PRECOTextBox.TabIndex = 13
        '
        'A_H_OCUPATextBox
        '
        Me.A_H_OCUPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALOJAMENTO_HBindingSource, "A_H_OCUPA", True))
        Me.A_H_OCUPATextBox.Location = New System.Drawing.Point(99, 214)
        Me.A_H_OCUPATextBox.Name = "A_H_OCUPATextBox"
        Me.A_H_OCUPATextBox.Size = New System.Drawing.Size(100, 20)
        Me.A_H_OCUPATextBox.TabIndex = 15
        '
        'ALOJAMENTO_HDataGridView
        '
        Me.ALOJAMENTO_HDataGridView.AutoGenerateColumns = False
        Me.ALOJAMENTO_HDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ALOJAMENTO_HDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ALOJAMENTO_HDataGridView.DataSource = Me.ALOJAMENTO_HBindingSource
        Me.ALOJAMENTO_HDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ALOJAMENTO_HDataGridView.Name = "ALOJAMENTO_HDataGridView"
        Me.ALOJAMENTO_HDataGridView.Size = New System.Drawing.Size(548, 349)
        Me.ALOJAMENTO_HDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "A_H_HOTEL_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "A_H_HOTEL_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "A_H_A_T_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "A_H_A_T_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "A_H_TIPO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "A_H_TIPO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "A_H_Estado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "A_H_Estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "A_H_EXTRA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "A_H_EXTRA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "A_H_PRECO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "A_H_PRECO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "A_H_OCUPA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "A_H_OCUPA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ALOJAMENTO_HTableAdapter
        '
        Me.ALOJAMENTO_HTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALOJAMENTO_DTableAdapter = Nothing
        Me.TableAdapterManager.ALOJAMENTO_HTableAdapter = Me.ALOJAMENTO_HTableAdapter
        Me.TableAdapterManager.ALOJAMENTOS_TTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.DIATableAdapter = Nothing
        Me.TableAdapterManager.EPOCASTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPAMENTO_HTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.ESTADO_PTableAdapter = Nothing
        Me.TableAdapterManager.ESTADOSTableAdapter = Nothing
        Me.TableAdapterManager.EXTRAS_ATableAdapter = Nothing
        Me.TableAdapterManager.EXTRASTableAdapter = Nothing
        Me.TableAdapterManager.FACILIDADES_ATableAdapter = Nothing
        Me.TableAdapterManager.FACILIDADESTableAdapter = Nothing
        Me.TableAdapterManager.HOTELTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDO_A_TTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDOTableAdapter = Nothing
        Me.TableAdapterManager.PRECO_ETableAdapter = Nothing
        Me.TableAdapterManager.REGIOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ALOJAMENTO_HBindingNavigator
        '
        Me.ALOJAMENTO_HBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALOJAMENTO_HBindingNavigator.BindingSource = Me.ALOJAMENTO_HBindingSource
        Me.ALOJAMENTO_HBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALOJAMENTO_HBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALOJAMENTO_HBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALOJAMENTO_HBindingNavigatorSaveItem})
        Me.ALOJAMENTO_HBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALOJAMENTO_HBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALOJAMENTO_HBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALOJAMENTO_HBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALOJAMENTO_HBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALOJAMENTO_HBindingNavigator.Name = "ALOJAMENTO_HBindingNavigator"
        Me.ALOJAMENTO_HBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALOJAMENTO_HBindingNavigator.Size = New System.Drawing.Size(850, 25)
        Me.ALOJAMENTO_HBindingNavigator.TabIndex = 1
        Me.ALOJAMENTO_HBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ALOJAMENTO_HBindingNavigatorSaveItem
        '
        Me.ALOJAMENTO_HBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALOJAMENTO_HBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALOJAMENTO_HBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALOJAMENTO_HBindingNavigatorSaveItem.Name = "ALOJAMENTO_HBindingNavigatorSaveItem"
        Me.ALOJAMENTO_HBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ALOJAMENTO_HBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Alojamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 389)
        Me.Controls.Add(Me.ALOJAMENTO_HBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Alojamento"
        Me.Text = "Gerir Alojamentos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ALOJAMENTO_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALOJAMENTO_HDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALOJAMENTO_HBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALOJAMENTO_HBindingNavigator.ResumeLayout(False)
        Me.ALOJAMENTO_HBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents ALOJAMENTO_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALOJAMENTO_HTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.ALOJAMENTO_HTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALOJAMENTO_HBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ALOJAMENTO_HBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents A_H_HOTEL_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_A_T_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_TIPOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_EXTRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_PRECOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents A_H_OCUPATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALOJAMENTO_HDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
