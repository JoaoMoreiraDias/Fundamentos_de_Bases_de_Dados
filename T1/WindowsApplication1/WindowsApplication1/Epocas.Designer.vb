<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Epocas
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
        Dim E_NOMELabel As System.Windows.Forms.Label
        Dim E_ILabel As System.Windows.Forms.Label
        Dim E_FLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Epocas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.E_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.EPOCASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.E_IDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.E_FDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EPOCASDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPOCASTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.EPOCASTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.EPOCASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EPOCASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        E_NOMELabel = New System.Windows.Forms.Label()
        E_ILabel = New System.Windows.Forms.Label()
        E_FLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPOCASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPOCASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPOCASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPOCASBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'E_NOMELabel
        '
        E_NOMELabel.AutoSize = True
        E_NOMELabel.Location = New System.Drawing.Point(12, 61)
        E_NOMELabel.Name = "E_NOMELabel"
        E_NOMELabel.Size = New System.Drawing.Size(52, 13)
        E_NOMELabel.TabIndex = 2
        E_NOMELabel.Text = "E NOME:"
        '
        'E_ILabel
        '
        E_ILabel.AutoSize = True
        E_ILabel.Location = New System.Drawing.Point(12, 88)
        E_ILabel.Name = "E_ILabel"
        E_ILabel.Size = New System.Drawing.Size(23, 13)
        E_ILabel.TabIndex = 4
        E_ILabel.Text = "E I:"
        '
        'E_FLabel
        '
        E_FLabel.AutoSize = True
        E_FLabel.Location = New System.Drawing.Point(12, 114)
        E_FLabel.Name = "E_FLabel"
        E_FLabel.Size = New System.Drawing.Size(26, 13)
        E_FLabel.TabIndex = 6
        E_FLabel.Text = "E F:"
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
        Me.SplitContainer1.Panel1.Controls.Add(E_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(E_ILabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_IDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(E_FLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_FDateTimePicker)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPOCASDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(839, 360)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 0
        '
        'E_NOMETextBox
        '
        Me.E_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EPOCASBindingSource, "E_NOME", True))
        Me.E_NOMETextBox.Location = New System.Drawing.Point(70, 58)
        Me.E_NOMETextBox.Name = "E_NOMETextBox"
        Me.E_NOMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.E_NOMETextBox.TabIndex = 3
        '
        'EPOCASBindingSource
        '
        Me.EPOCASBindingSource.DataMember = "EPOCAS"
        Me.EPOCASBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'E_IDateTimePicker
        '
        Me.E_IDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EPOCASBindingSource, "E_I", True))
        Me.E_IDateTimePicker.Location = New System.Drawing.Point(70, 84)
        Me.E_IDateTimePicker.Name = "E_IDateTimePicker"
        Me.E_IDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.E_IDateTimePicker.TabIndex = 5
        '
        'E_FDateTimePicker
        '
        Me.E_FDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EPOCASBindingSource, "E_F", True))
        Me.E_FDateTimePicker.Location = New System.Drawing.Point(70, 110)
        Me.E_FDateTimePicker.Name = "E_FDateTimePicker"
        Me.E_FDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.E_FDateTimePicker.TabIndex = 7
        '
        'EPOCASDataGridView
        '
        Me.EPOCASDataGridView.AutoGenerateColumns = False
        Me.EPOCASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EPOCASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EPOCASDataGridView.DataSource = Me.EPOCASBindingSource
        Me.EPOCASDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.EPOCASDataGridView.Name = "EPOCASDataGridView"
        Me.EPOCASDataGridView.Size = New System.Drawing.Size(541, 320)
        Me.EPOCASDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "E_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "E_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "E_NOME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "E_NOME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "E_I"
        Me.DataGridViewTextBoxColumn3.HeaderText = "E_I"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "E_F"
        Me.DataGridViewTextBoxColumn4.HeaderText = "E_F"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'EPOCASTableAdapter
        '
        Me.EPOCASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALOJAMENTO_DTableAdapter = Nothing
        Me.TableAdapterManager.ALOJAMENTO_HTableAdapter = Nothing
        Me.TableAdapterManager.ALOJAMENTOS_TTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.DIATableAdapter = Nothing
        Me.TableAdapterManager.EPOCASTableAdapter = Me.EPOCASTableAdapter
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
        'EPOCASBindingNavigator
        '
        Me.EPOCASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EPOCASBindingNavigator.BindingSource = Me.EPOCASBindingSource
        Me.EPOCASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EPOCASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EPOCASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EPOCASBindingNavigatorSaveItem})
        Me.EPOCASBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EPOCASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EPOCASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EPOCASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EPOCASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EPOCASBindingNavigator.Name = "EPOCASBindingNavigator"
        Me.EPOCASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EPOCASBindingNavigator.Size = New System.Drawing.Size(839, 25)
        Me.EPOCASBindingNavigator.TabIndex = 1
        Me.EPOCASBindingNavigator.Text = "BindingNavigator1"
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
        'EPOCASBindingNavigatorSaveItem
        '
        Me.EPOCASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EPOCASBindingNavigatorSaveItem.Image = CType(resources.GetObject("EPOCASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EPOCASBindingNavigatorSaveItem.Name = "EPOCASBindingNavigatorSaveItem"
        Me.EPOCASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EPOCASBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Epocas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 360)
        Me.Controls.Add(Me.EPOCASBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Epocas"
        Me.Text = "Gerir Epocas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPOCASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPOCASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPOCASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPOCASBindingNavigator.ResumeLayout(False)
        Me.EPOCASBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents EPOCASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EPOCASTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.EPOCASTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EPOCASBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EPOCASBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents E_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_IDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents E_FDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EPOCASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
