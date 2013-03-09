<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel
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
        Dim H_IDLabel As System.Windows.Forms.Label
        Dim H_NOMELabel As System.Windows.Forms.Label
        Dim H_CATEGORIALabel As System.Windows.Forms.Label
        Dim H_EQUIPAMENTOSLabel As System.Windows.Forms.Label
        Dim H_ALOJAMENTOSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.H_IDTextBox = New System.Windows.Forms.TextBox()
        Me.HOTELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.H_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.H_CATEGORIATextBox = New System.Windows.Forms.TextBox()
        Me.H_EQUIPAMENTOSTextBox = New System.Windows.Forms.TextBox()
        Me.H_ALOJAMENTOSTextBox = New System.Windows.Forms.TextBox()
        Me.HOTELDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOTELTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.HOTELTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.HOTELBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HOTELBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        H_IDLabel = New System.Windows.Forms.Label()
        H_NOMELabel = New System.Windows.Forms.Label()
        H_CATEGORIALabel = New System.Windows.Forms.Label()
        H_EQUIPAMENTOSLabel = New System.Windows.Forms.Label()
        H_ALOJAMENTOSLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.HOTELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HOTELBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'H_IDLabel
        '
        H_IDLabel.AutoSize = True
        H_IDLabel.Location = New System.Drawing.Point(6, 57)
        H_IDLabel.Name = "H_IDLabel"
        H_IDLabel.Size = New System.Drawing.Size(32, 13)
        H_IDLabel.TabIndex = 2
        H_IDLabel.Text = "H ID:"
        '
        'H_NOMELabel
        '
        H_NOMELabel.AutoSize = True
        H_NOMELabel.Location = New System.Drawing.Point(6, 83)
        H_NOMELabel.Name = "H_NOMELabel"
        H_NOMELabel.Size = New System.Drawing.Size(53, 13)
        H_NOMELabel.TabIndex = 4
        H_NOMELabel.Text = "H NOME:"
        '
        'H_CATEGORIALabel
        '
        H_CATEGORIALabel.AutoSize = True
        H_CATEGORIALabel.Location = New System.Drawing.Point(6, 109)
        H_CATEGORIALabel.Name = "H_CATEGORIALabel"
        H_CATEGORIALabel.Size = New System.Drawing.Size(83, 13)
        H_CATEGORIALabel.TabIndex = 6
        H_CATEGORIALabel.Text = "H CATEGORIA:"
        '
        'H_EQUIPAMENTOSLabel
        '
        H_EQUIPAMENTOSLabel.AutoSize = True
        H_EQUIPAMENTOSLabel.Location = New System.Drawing.Point(6, 135)
        H_EQUIPAMENTOSLabel.Name = "H_EQUIPAMENTOSLabel"
        H_EQUIPAMENTOSLabel.Size = New System.Drawing.Size(107, 13)
        H_EQUIPAMENTOSLabel.TabIndex = 8
        H_EQUIPAMENTOSLabel.Text = "H EQUIPAMENTOS:"
        '
        'H_ALOJAMENTOSLabel
        '
        H_ALOJAMENTOSLabel.AutoSize = True
        H_ALOJAMENTOSLabel.Location = New System.Drawing.Point(6, 161)
        H_ALOJAMENTOSLabel.Name = "H_ALOJAMENTOSLabel"
        H_ALOJAMENTOSLabel.Size = New System.Drawing.Size(100, 13)
        H_ALOJAMENTOSLabel.TabIndex = 10
        H_ALOJAMENTOSLabel.Text = "H ALOJAMENTOS:"
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
        Me.SplitContainer1.Panel1.Controls.Add(H_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.H_IDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(H_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.H_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(H_CATEGORIALabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.H_CATEGORIATextBox)
        Me.SplitContainer1.Panel1.Controls.Add(H_EQUIPAMENTOSLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.H_EQUIPAMENTOSTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(H_ALOJAMENTOSLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.H_ALOJAMENTOSTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.HOTELDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 329)
        Me.SplitContainer1.SplitterDistance = 278
        Me.SplitContainer1.TabIndex = 0
        '
        'H_IDTextBox
        '
        Me.H_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOTELBindingSource, "H_ID", True))
        Me.H_IDTextBox.Location = New System.Drawing.Point(119, 54)
        Me.H_IDTextBox.Name = "H_IDTextBox"
        Me.H_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.H_IDTextBox.TabIndex = 3
        '
        'HOTELBindingSource
        '
        Me.HOTELBindingSource.DataMember = "HOTEL"
        Me.HOTELBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'H_NOMETextBox
        '
        Me.H_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOTELBindingSource, "H_NOME", True))
        Me.H_NOMETextBox.Location = New System.Drawing.Point(119, 80)
        Me.H_NOMETextBox.Name = "H_NOMETextBox"
        Me.H_NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.H_NOMETextBox.TabIndex = 5
        '
        'H_CATEGORIATextBox
        '
        Me.H_CATEGORIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOTELBindingSource, "H_CATEGORIA", True))
        Me.H_CATEGORIATextBox.Location = New System.Drawing.Point(119, 106)
        Me.H_CATEGORIATextBox.Name = "H_CATEGORIATextBox"
        Me.H_CATEGORIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.H_CATEGORIATextBox.TabIndex = 7
        '
        'H_EQUIPAMENTOSTextBox
        '
        Me.H_EQUIPAMENTOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOTELBindingSource, "H_EQUIPAMENTOS", True))
        Me.H_EQUIPAMENTOSTextBox.Location = New System.Drawing.Point(119, 132)
        Me.H_EQUIPAMENTOSTextBox.Name = "H_EQUIPAMENTOSTextBox"
        Me.H_EQUIPAMENTOSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.H_EQUIPAMENTOSTextBox.TabIndex = 9
        '
        'H_ALOJAMENTOSTextBox
        '
        Me.H_ALOJAMENTOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HOTELBindingSource, "H_ALOJAMENTOS", True))
        Me.H_ALOJAMENTOSTextBox.Location = New System.Drawing.Point(119, 158)
        Me.H_ALOJAMENTOSTextBox.Name = "H_ALOJAMENTOSTextBox"
        Me.H_ALOJAMENTOSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.H_ALOJAMENTOSTextBox.TabIndex = 11
        '
        'HOTELDataGridView
        '
        Me.HOTELDataGridView.AutoGenerateColumns = False
        Me.HOTELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HOTELDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.HOTELDataGridView.DataSource = Me.HOTELBindingSource
        Me.HOTELDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.HOTELDataGridView.Name = "HOTELDataGridView"
        Me.HOTELDataGridView.Size = New System.Drawing.Size(537, 289)
        Me.HOTELDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "H_R_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "H_R_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "H_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "H_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "H_NOME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "H_NOME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "H_CATEGORIA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "H_CATEGORIA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "H_EQUIPAMENTOS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "H_EQUIPAMENTOS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "H_ALOJAMENTOS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "H_ALOJAMENTOS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'HOTELTableAdapter
        '
        Me.HOTELTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALOJAMENTO_DTableAdapter = Nothing
        Me.TableAdapterManager.ALOJAMENTO_HTableAdapter = Nothing
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
        Me.TableAdapterManager.HOTELTableAdapter = Me.HOTELTableAdapter
        Me.TableAdapterManager.PEDIDO_A_TTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDOTableAdapter = Nothing
        Me.TableAdapterManager.PRECO_ETableAdapter = Nothing
        Me.TableAdapterManager.REGIOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HOTELBindingNavigator
        '
        Me.HOTELBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HOTELBindingNavigator.BindingSource = Me.HOTELBindingSource
        Me.HOTELBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HOTELBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HOTELBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HOTELBindingNavigatorSaveItem})
        Me.HOTELBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HOTELBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HOTELBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HOTELBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HOTELBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HOTELBindingNavigator.Name = "HOTELBindingNavigator"
        Me.HOTELBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HOTELBindingNavigator.Size = New System.Drawing.Size(834, 25)
        Me.HOTELBindingNavigator.TabIndex = 1
        Me.HOTELBindingNavigator.Text = "BindingNavigator1"
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
        'HOTELBindingNavigatorSaveItem
        '
        Me.HOTELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HOTELBindingNavigatorSaveItem.Image = CType(resources.GetObject("HOTELBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HOTELBindingNavigatorSaveItem.Name = "HOTELBindingNavigatorSaveItem"
        Me.HOTELBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HOTELBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 329)
        Me.Controls.Add(Me.HOTELBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Hotel"
        Me.Text = "Gerir Hoteis"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.HOTELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HOTELBindingNavigator.ResumeLayout(False)
        Me.HOTELBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents HOTELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HOTELTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.HOTELTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents HOTELBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HOTELBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HOTELDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_CATEGORIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_EQUIPAMENTOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_ALOJAMENTOSTextBox As System.Windows.Forms.TextBox
End Class
