<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estados
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
        Dim E_P_NOMELabel As System.Windows.Forms.Label
        Dim E_P_DESCLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estados))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.E_P_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.ESTADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.E_P_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.ESTADOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADOSTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.ESTADOSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ESTADOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ESTADOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        E_P_NOMELabel = New System.Windows.Forms.Label()
        E_P_DESCLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ESTADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ESTADOSBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'E_P_NOMELabel
        '
        E_P_NOMELabel.AutoSize = True
        E_P_NOMELabel.Location = New System.Drawing.Point(12, 62)
        E_P_NOMELabel.Name = "E_P_NOMELabel"
        E_P_NOMELabel.Size = New System.Drawing.Size(62, 13)
        E_P_NOMELabel.TabIndex = 2
        E_P_NOMELabel.Text = "E P NOME:"
        '
        'E_P_DESCLabel
        '
        E_P_DESCLabel.AutoSize = True
        E_P_DESCLabel.Location = New System.Drawing.Point(12, 88)
        E_P_DESCLabel.Name = "E_P_DESCLabel"
        E_P_DESCLabel.Size = New System.Drawing.Size(59, 13)
        E_P_DESCLabel.TabIndex = 4
        E_P_DESCLabel.Text = "E P DESC:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(E_P_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_P_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(E_P_DESCLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_P_DESCTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ESTADOSDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(851, 372)
        Me.SplitContainer1.SplitterDistance = 283
        Me.SplitContainer1.TabIndex = 0
        '
        'E_P_NOMETextBox
        '
        Me.E_P_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESTADOSBindingSource, "E_P_NOME", True))
        Me.E_P_NOMETextBox.Location = New System.Drawing.Point(80, 59)
        Me.E_P_NOMETextBox.Name = "E_P_NOMETextBox"
        Me.E_P_NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_P_NOMETextBox.TabIndex = 3
        '
        'ESTADOSBindingSource
        '
        Me.ESTADOSBindingSource.DataMember = "ESTADOS"
        Me.ESTADOSBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'E_P_DESCTextBox
        '
        Me.E_P_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESTADOSBindingSource, "E_P_DESC", True))
        Me.E_P_DESCTextBox.Location = New System.Drawing.Point(80, 85)
        Me.E_P_DESCTextBox.Name = "E_P_DESCTextBox"
        Me.E_P_DESCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_P_DESCTextBox.TabIndex = 5
        '
        'ESTADOSDataGridView
        '
        Me.ESTADOSDataGridView.AutoGenerateColumns = False
        Me.ESTADOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ESTADOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ESTADOSDataGridView.DataSource = Me.ESTADOSBindingSource
        Me.ESTADOSDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ESTADOSDataGridView.Name = "ESTADOSDataGridView"
        Me.ESTADOSDataGridView.Size = New System.Drawing.Size(549, 332)
        Me.ESTADOSDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "E_P_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "E_P_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "E_P_NOME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "E_P_NOME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "E_P_DESC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "E_P_DESC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'ESTADOSTableAdapter
        '
        Me.ESTADOSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ESTADOSTableAdapter = Me.ESTADOSTableAdapter
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
        'ESTADOSBindingNavigator
        '
        Me.ESTADOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ESTADOSBindingNavigator.BindingSource = Me.ESTADOSBindingSource
        Me.ESTADOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ESTADOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ESTADOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ESTADOSBindingNavigatorSaveItem})
        Me.ESTADOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ESTADOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ESTADOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ESTADOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ESTADOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ESTADOSBindingNavigator.Name = "ESTADOSBindingNavigator"
        Me.ESTADOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ESTADOSBindingNavigator.Size = New System.Drawing.Size(851, 25)
        Me.ESTADOSBindingNavigator.TabIndex = 1
        Me.ESTADOSBindingNavigator.Text = "BindingNavigator1"
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
        'ESTADOSBindingNavigatorSaveItem
        '
        Me.ESTADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ESTADOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("ESTADOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ESTADOSBindingNavigatorSaveItem.Name = "ESTADOSBindingNavigatorSaveItem"
        Me.ESTADOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ESTADOSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 372)
        Me.Controls.Add(Me.ESTADOSBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Estados"
        Me.Text = "Gerir Estados"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ESTADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ESTADOSBindingNavigator.ResumeLayout(False)
        Me.ESTADOSBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents ESTADOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ESTADOSTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.ESTADOSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ESTADOSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ESTADOSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents E_P_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_P_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
