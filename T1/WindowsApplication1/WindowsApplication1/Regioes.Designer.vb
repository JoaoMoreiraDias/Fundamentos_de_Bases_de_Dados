<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regioes
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
        Dim R_DESTRITOLabel As System.Windows.Forms.Label
        Dim R_NOMELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Regioes))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.R_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.REGIOESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.R_DESTRITOTextBox = New System.Windows.Forms.TextBox()
        Me.REGIOESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGIOESTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.REGIOESTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.REGIOESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REGIOESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        R_DESTRITOLabel = New System.Windows.Forms.Label()
        R_NOMELabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.REGIOESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIOESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIOESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REGIOESBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'R_DESTRITOLabel
        '
        R_DESTRITOLabel.AutoSize = True
        R_DESTRITOLabel.Location = New System.Drawing.Point(5, 83)
        R_DESTRITOLabel.Name = "R_DESTRITOLabel"
        R_DESTRITOLabel.Size = New System.Drawing.Size(76, 13)
        R_DESTRITOLabel.TabIndex = 4
        R_DESTRITOLabel.Text = "R DESTRITO:"
        '
        'R_NOMELabel
        '
        R_NOMELabel.AutoSize = True
        R_NOMELabel.Location = New System.Drawing.Point(5, 57)
        R_NOMELabel.Name = "R_NOMELabel"
        R_NOMELabel.Size = New System.Drawing.Size(53, 13)
        R_NOMELabel.TabIndex = 2
        R_NOMELabel.Text = "R NOME:"
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
        Me.SplitContainer1.Panel1.Controls.Add(R_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.R_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(R_DESTRITOLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.R_DESTRITOTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.REGIOESDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(835, 345)
        Me.SplitContainer1.SplitterDistance = 278
        Me.SplitContainer1.TabIndex = 0
        '
        'R_NOMETextBox
        '
        Me.R_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIOESBindingSource, "R_NOME", True))
        Me.R_NOMETextBox.Location = New System.Drawing.Point(87, 54)
        Me.R_NOMETextBox.Name = "R_NOMETextBox"
        Me.R_NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_NOMETextBox.TabIndex = 3
        '
        'REGIOESBindingSource
        '
        Me.REGIOESBindingSource.DataMember = "REGIOES"
        Me.REGIOESBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'R_DESTRITOTextBox
        '
        Me.R_DESTRITOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REGIOESBindingSource, "R_DESTRITO", True))
        Me.R_DESTRITOTextBox.Location = New System.Drawing.Point(87, 80)
        Me.R_DESTRITOTextBox.Name = "R_DESTRITOTextBox"
        Me.R_DESTRITOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.R_DESTRITOTextBox.TabIndex = 5
        '
        'REGIOESDataGridView
        '
        Me.REGIOESDataGridView.AutoGenerateColumns = False
        Me.REGIOESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REGIOESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.REGIOESDataGridView.DataSource = Me.REGIOESBindingSource
        Me.REGIOESDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.REGIOESDataGridView.Name = "REGIOESDataGridView"
        Me.REGIOESDataGridView.Size = New System.Drawing.Size(538, 305)
        Me.REGIOESDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "R_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "R_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "R_NOME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "R_NOME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "R_DESTRITO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "R_DESTRITO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'REGIOESTableAdapter
        '
        Me.REGIOESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.HOTELTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDO_A_TTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDOTableAdapter = Nothing
        Me.TableAdapterManager.PRECO_ETableAdapter = Nothing
        Me.TableAdapterManager.REGIOESTableAdapter = Me.REGIOESTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'REGIOESBindingNavigator
        '
        Me.REGIOESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REGIOESBindingNavigator.BindingSource = Me.REGIOESBindingSource
        Me.REGIOESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REGIOESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REGIOESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REGIOESBindingNavigatorSaveItem})
        Me.REGIOESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REGIOESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REGIOESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REGIOESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REGIOESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REGIOESBindingNavigator.Name = "REGIOESBindingNavigator"
        Me.REGIOESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REGIOESBindingNavigator.Size = New System.Drawing.Size(835, 25)
        Me.REGIOESBindingNavigator.TabIndex = 1
        Me.REGIOESBindingNavigator.Text = "BindingNavigator1"
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
        'REGIOESBindingNavigatorSaveItem
        '
        Me.REGIOESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REGIOESBindingNavigatorSaveItem.Image = CType(resources.GetObject("REGIOESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REGIOESBindingNavigatorSaveItem.Name = "REGIOESBindingNavigatorSaveItem"
        Me.REGIOESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.REGIOESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Regioes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 345)
        Me.Controls.Add(Me.REGIOESBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Regioes"
        Me.Text = "Gerir Regiões"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.REGIOESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIOESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIOESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REGIOESBindingNavigator.ResumeLayout(False)
        Me.REGIOESBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents REGIOESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGIOESTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.REGIOESTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents REGIOESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents REGIOESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents R_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_DESTRITOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REGIOESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
