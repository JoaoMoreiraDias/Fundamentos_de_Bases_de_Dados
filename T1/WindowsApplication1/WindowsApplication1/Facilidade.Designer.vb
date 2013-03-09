<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facilidade
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
        Dim F_NOMELabel As System.Windows.Forms.Label
        Dim F_DescLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facilidade))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.F_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.FACILIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.F_DescTextBox = New System.Windows.Forms.TextBox()
        Me.FACILIDADESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACILIDADESTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.FACILIDADESTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.FACILIDADESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FACILIDADESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        F_NOMELabel = New System.Windows.Forms.Label()
        F_DescLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FACILIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACILIDADESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACILIDADESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FACILIDADESBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'F_NOMELabel
        '
        F_NOMELabel.AutoSize = True
        F_NOMELabel.Location = New System.Drawing.Point(12, 54)
        F_NOMELabel.Name = "F_NOMELabel"
        F_NOMELabel.Size = New System.Drawing.Size(51, 13)
        F_NOMELabel.TabIndex = 2
        F_NOMELabel.Text = "F NOME:"
        '
        'F_DescLabel
        '
        F_DescLabel.AutoSize = True
        F_DescLabel.Location = New System.Drawing.Point(12, 80)
        F_DescLabel.Name = "F_DescLabel"
        F_DescLabel.Size = New System.Drawing.Size(44, 13)
        F_DescLabel.TabIndex = 4
        F_DescLabel.Text = "F Desc:"
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
        Me.SplitContainer1.Panel1.Controls.Add(F_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.F_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(F_DescLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.F_DescTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FACILIDADESDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(845, 367)
        Me.SplitContainer1.SplitterDistance = 281
        Me.SplitContainer1.TabIndex = 0
        '
        'F_NOMETextBox
        '
        Me.F_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACILIDADESBindingSource, "F_NOME", True))
        Me.F_NOMETextBox.Location = New System.Drawing.Point(69, 51)
        Me.F_NOMETextBox.Name = "F_NOMETextBox"
        Me.F_NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.F_NOMETextBox.TabIndex = 3
        '
        'FACILIDADESBindingSource
        '
        Me.FACILIDADESBindingSource.DataMember = "FACILIDADES"
        Me.FACILIDADESBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'F_DescTextBox
        '
        Me.F_DescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FACILIDADESBindingSource, "F_Desc", True))
        Me.F_DescTextBox.Location = New System.Drawing.Point(69, 77)
        Me.F_DescTextBox.Name = "F_DescTextBox"
        Me.F_DescTextBox.Size = New System.Drawing.Size(100, 20)
        Me.F_DescTextBox.TabIndex = 5
        '
        'FACILIDADESDataGridView
        '
        Me.FACILIDADESDataGridView.AutoGenerateColumns = False
        Me.FACILIDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FACILIDADESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.FACILIDADESDataGridView.DataSource = Me.FACILIDADESBindingSource
        Me.FACILIDADESDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.FACILIDADESDataGridView.Name = "FACILIDADESDataGridView"
        Me.FACILIDADESDataGridView.Size = New System.Drawing.Size(545, 327)
        Me.FACILIDADESDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "F_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "F_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "F_NOME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "F_NOME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "F_Desc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "F_Desc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FACILIDADESTableAdapter
        '
        Me.FACILIDADESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FACILIDADESTableAdapter = Me.FACILIDADESTableAdapter
        Me.TableAdapterManager.HOTELTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDO_A_TTableAdapter = Nothing
        Me.TableAdapterManager.PEDIDOTableAdapter = Nothing
        Me.TableAdapterManager.PRECO_ETableAdapter = Nothing
        Me.TableAdapterManager.REGIOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FACILIDADESBindingNavigator
        '
        Me.FACILIDADESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FACILIDADESBindingNavigator.BindingSource = Me.FACILIDADESBindingSource
        Me.FACILIDADESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FACILIDADESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FACILIDADESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FACILIDADESBindingNavigatorSaveItem})
        Me.FACILIDADESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FACILIDADESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FACILIDADESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FACILIDADESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FACILIDADESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FACILIDADESBindingNavigator.Name = "FACILIDADESBindingNavigator"
        Me.FACILIDADESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FACILIDADESBindingNavigator.Size = New System.Drawing.Size(845, 25)
        Me.FACILIDADESBindingNavigator.TabIndex = 1
        Me.FACILIDADESBindingNavigator.Text = "BindingNavigator1"
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
        'FACILIDADESBindingNavigatorSaveItem
        '
        Me.FACILIDADESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FACILIDADESBindingNavigatorSaveItem.Image = CType(resources.GetObject("FACILIDADESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FACILIDADESBindingNavigatorSaveItem.Name = "FACILIDADESBindingNavigatorSaveItem"
        Me.FACILIDADESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FACILIDADESBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Facilidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 367)
        Me.Controls.Add(Me.FACILIDADESBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Facilidade"
        Me.Text = "Gerir facilidades"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FACILIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACILIDADESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACILIDADESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FACILIDADESBindingNavigator.ResumeLayout(False)
        Me.FACILIDADESBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents FACILIDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACILIDADESTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.FACILIDADESTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FACILIDADESBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FACILIDADESBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents F_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents F_DescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FACILIDADESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
