<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipamento
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
        Dim E_IDLabel As System.Windows.Forms.Label
        Dim E_NOMELabel As System.Windows.Forms.Label
        Dim E_MARCALabel As System.Windows.Forms.Label
        Dim E_DESCLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipamento))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.E_IDTextBox = New System.Windows.Forms.TextBox()
        Me.EQUIPAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.E_NOMETextBox = New System.Windows.Forms.TextBox()
        Me.E_MARCATextBox = New System.Windows.Forms.TextBox()
        Me.E_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.EQUIPAMENTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EQUIPAMENTOTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.EQUIPAMENTOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.EQUIPAMENTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EQUIPAMENTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        E_IDLabel = New System.Windows.Forms.Label()
        E_NOMELabel = New System.Windows.Forms.Label()
        E_MARCALabel = New System.Windows.Forms.Label()
        E_DESCLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EQUIPAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPAMENTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EQUIPAMENTOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'E_IDLabel
        '
        E_IDLabel.AutoSize = True
        E_IDLabel.Location = New System.Drawing.Point(12, 28)
        E_IDLabel.Name = "E_IDLabel"
        E_IDLabel.Size = New System.Drawing.Size(31, 13)
        E_IDLabel.TabIndex = 0
        E_IDLabel.Text = "E ID:"
        '
        'E_NOMELabel
        '
        E_NOMELabel.AutoSize = True
        E_NOMELabel.Location = New System.Drawing.Point(12, 54)
        E_NOMELabel.Name = "E_NOMELabel"
        E_NOMELabel.Size = New System.Drawing.Size(52, 13)
        E_NOMELabel.TabIndex = 2
        E_NOMELabel.Text = "E NOME:"
        '
        'E_MARCALabel
        '
        E_MARCALabel.AutoSize = True
        E_MARCALabel.Location = New System.Drawing.Point(12, 80)
        E_MARCALabel.Name = "E_MARCALabel"
        E_MARCALabel.Size = New System.Drawing.Size(58, 13)
        E_MARCALabel.TabIndex = 4
        E_MARCALabel.Text = "E MARCA:"
        '
        'E_DESCLabel
        '
        E_DESCLabel.AutoSize = True
        E_DESCLabel.Location = New System.Drawing.Point(12, 106)
        E_DESCLabel.Name = "E_DESCLabel"
        E_DESCLabel.Size = New System.Drawing.Size(49, 13)
        E_DESCLabel.TabIndex = 6
        E_DESCLabel.Text = "E DESC:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(E_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_IDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(E_NOMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_NOMETextBox)
        Me.SplitContainer1.Panel1.Controls.Add(E_MARCALabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_MARCATextBox)
        Me.SplitContainer1.Panel1.Controls.Add(E_DESCLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.E_DESCTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EQUIPAMENTODataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(851, 334)
        Me.SplitContainer1.SplitterDistance = 283
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'E_IDTextBox
        '
        Me.E_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPAMENTOBindingSource, "E_ID", True))
        Me.E_IDTextBox.Location = New System.Drawing.Point(76, 25)
        Me.E_IDTextBox.Name = "E_IDTextBox"
        Me.E_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_IDTextBox.TabIndex = 1
        '
        'EQUIPAMENTOBindingSource
        '
        Me.EQUIPAMENTOBindingSource.DataMember = "EQUIPAMENTO"
        Me.EQUIPAMENTOBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'E_NOMETextBox
        '
        Me.E_NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPAMENTOBindingSource, "E_NOME", True))
        Me.E_NOMETextBox.Location = New System.Drawing.Point(76, 51)
        Me.E_NOMETextBox.Name = "E_NOMETextBox"
        Me.E_NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_NOMETextBox.TabIndex = 3
        '
        'E_MARCATextBox
        '
        Me.E_MARCATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPAMENTOBindingSource, "E_MARCA", True))
        Me.E_MARCATextBox.Location = New System.Drawing.Point(76, 77)
        Me.E_MARCATextBox.Name = "E_MARCATextBox"
        Me.E_MARCATextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_MARCATextBox.TabIndex = 5
        '
        'E_DESCTextBox
        '
        Me.E_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EQUIPAMENTOBindingSource, "E_DESC", True))
        Me.E_DESCTextBox.Location = New System.Drawing.Point(76, 103)
        Me.E_DESCTextBox.Name = "E_DESCTextBox"
        Me.E_DESCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.E_DESCTextBox.TabIndex = 7
        '
        'EQUIPAMENTODataGridView
        '
        Me.EQUIPAMENTODataGridView.AutoGenerateColumns = False
        Me.EQUIPAMENTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EQUIPAMENTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EQUIPAMENTODataGridView.DataSource = Me.EQUIPAMENTOBindingSource
        Me.EQUIPAMENTODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.EQUIPAMENTODataGridView.Name = "EQUIPAMENTODataGridView"
        Me.EQUIPAMENTODataGridView.Size = New System.Drawing.Size(549, 294)
        Me.EQUIPAMENTODataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "E_MARCA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "E_MARCA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "E_DESC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "E_DESC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'EQUIPAMENTOTableAdapter
        '
        Me.EQUIPAMENTOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EQUIPAMENTOTableAdapter = Me.EQUIPAMENTOTableAdapter
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
        'EQUIPAMENTOBindingNavigator
        '
        Me.EQUIPAMENTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EQUIPAMENTOBindingNavigator.BindingSource = Me.EQUIPAMENTOBindingSource
        Me.EQUIPAMENTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EQUIPAMENTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EQUIPAMENTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EQUIPAMENTOBindingNavigatorSaveItem})
        Me.EQUIPAMENTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EQUIPAMENTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EQUIPAMENTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EQUIPAMENTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EQUIPAMENTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EQUIPAMENTOBindingNavigator.Name = "EQUIPAMENTOBindingNavigator"
        Me.EQUIPAMENTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EQUIPAMENTOBindingNavigator.Size = New System.Drawing.Size(851, 25)
        Me.EQUIPAMENTOBindingNavigator.TabIndex = 1
        Me.EQUIPAMENTOBindingNavigator.Text = "BindingNavigator1"
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
        'EQUIPAMENTOBindingNavigatorSaveItem
        '
        Me.EQUIPAMENTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EQUIPAMENTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("EQUIPAMENTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EQUIPAMENTOBindingNavigatorSaveItem.Name = "EQUIPAMENTOBindingNavigatorSaveItem"
        Me.EQUIPAMENTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EQUIPAMENTOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Carregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 334)
        Me.Controls.Add(Me.EQUIPAMENTOBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Equipamento"
        Me.Text = "Gerir Equipamento"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EQUIPAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPAMENTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EQUIPAMENTOBindingNavigator.ResumeLayout(False)
        Me.EQUIPAMENTOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents EQUIPAMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPAMENTOTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.EQUIPAMENTOTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EQUIPAMENTOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EQUIPAMENTOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents E_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_MARCATextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EQUIPAMENTODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
