<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
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
        Dim P_ESTADOLabel As System.Windows.Forms.Label
        Dim P_DATAILabel As System.Windows.Forms.Label
        Dim P_DATAFLabel As System.Windows.Forms.Label
        Dim P_CLIENTE_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedido))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.P_ESTADOTextBox = New System.Windows.Forms.TextBox()
        Me.PEDIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.P_DATAIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_DATAFDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_CLIENTE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PEDIDODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEDIDOTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.PEDIDOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.PEDIDOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PEDIDOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        P_ESTADOLabel = New System.Windows.Forms.Label()
        P_DATAILabel = New System.Windows.Forms.Label()
        P_DATAFLabel = New System.Windows.Forms.Label()
        P_CLIENTE_IDLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PEDIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PEDIDOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_ESTADOLabel
        '
        P_ESTADOLabel.AutoSize = True
        P_ESTADOLabel.Location = New System.Drawing.Point(8, 67)
        P_ESTADOLabel.Name = "P_ESTADOLabel"
        P_ESTADOLabel.Size = New System.Drawing.Size(64, 13)
        P_ESTADOLabel.TabIndex = 2
        P_ESTADOLabel.Text = "P ESTADO:"
        '
        'P_DATAILabel
        '
        P_DATAILabel.AutoSize = True
        P_DATAILabel.Location = New System.Drawing.Point(8, 94)
        P_DATAILabel.Name = "P_DATAILabel"
        P_DATAILabel.Size = New System.Drawing.Size(52, 13)
        P_DATAILabel.TabIndex = 4
        P_DATAILabel.Text = "P DATAI:"
        '
        'P_DATAFLabel
        '
        P_DATAFLabel.AutoSize = True
        P_DATAFLabel.Location = New System.Drawing.Point(8, 120)
        P_DATAFLabel.Name = "P_DATAFLabel"
        P_DATAFLabel.Size = New System.Drawing.Size(55, 13)
        P_DATAFLabel.TabIndex = 6
        P_DATAFLabel.Text = "P DATAF:"
        '
        'P_CLIENTE_IDLabel
        '
        P_CLIENTE_IDLabel.AutoSize = True
        P_CLIENTE_IDLabel.Location = New System.Drawing.Point(8, 145)
        P_CLIENTE_IDLabel.Name = "P_CLIENTE_IDLabel"
        P_CLIENTE_IDLabel.Size = New System.Drawing.Size(79, 13)
        P_CLIENTE_IDLabel.TabIndex = 8
        P_CLIENTE_IDLabel.Text = "P CLIENTE ID:"
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
        Me.SplitContainer1.Panel1.Controls.Add(P_ESTADOLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.P_ESTADOTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(P_DATAILabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.P_DATAIDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(P_DATAFLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.P_DATAFDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(P_CLIENTE_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.P_CLIENTE_IDTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.PEDIDODataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(846, 373)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 0
        '
        'P_ESTADOTextBox
        '
        Me.P_ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PEDIDOBindingSource, "P_ESTADO", True))
        Me.P_ESTADOTextBox.Location = New System.Drawing.Point(93, 64)
        Me.P_ESTADOTextBox.Name = "P_ESTADOTextBox"
        Me.P_ESTADOTextBox.Size = New System.Drawing.Size(187, 20)
        Me.P_ESTADOTextBox.TabIndex = 3
        '
        'PEDIDOBindingSource
        '
        Me.PEDIDOBindingSource.DataMember = "PEDIDO"
        Me.PEDIDOBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_DATAIDateTimePicker
        '
        Me.P_DATAIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PEDIDOBindingSource, "P_DATAI", True))
        Me.P_DATAIDateTimePicker.Location = New System.Drawing.Point(93, 90)
        Me.P_DATAIDateTimePicker.Name = "P_DATAIDateTimePicker"
        Me.P_DATAIDateTimePicker.Size = New System.Drawing.Size(187, 20)
        Me.P_DATAIDateTimePicker.TabIndex = 5
        '
        'P_DATAFDateTimePicker
        '
        Me.P_DATAFDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PEDIDOBindingSource, "P_DATAF", True))
        Me.P_DATAFDateTimePicker.Location = New System.Drawing.Point(93, 116)
        Me.P_DATAFDateTimePicker.Name = "P_DATAFDateTimePicker"
        Me.P_DATAFDateTimePicker.Size = New System.Drawing.Size(187, 20)
        Me.P_DATAFDateTimePicker.TabIndex = 7
        '
        'P_CLIENTE_IDTextBox
        '
        Me.P_CLIENTE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PEDIDOBindingSource, "P_CLIENTE_ID", True))
        Me.P_CLIENTE_IDTextBox.Location = New System.Drawing.Point(93, 142)
        Me.P_CLIENTE_IDTextBox.Name = "P_CLIENTE_IDTextBox"
        Me.P_CLIENTE_IDTextBox.Size = New System.Drawing.Size(187, 20)
        Me.P_CLIENTE_IDTextBox.TabIndex = 9
        '
        'PEDIDODataGridView
        '
        Me.PEDIDODataGridView.AutoGenerateColumns = False
        Me.PEDIDODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PEDIDODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PEDIDODataGridView.DataSource = Me.PEDIDOBindingSource
        Me.PEDIDODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.PEDIDODataGridView.Name = "PEDIDODataGridView"
        Me.PEDIDODataGridView.Size = New System.Drawing.Size(545, 342)
        Me.PEDIDODataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "P_ESTADO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_ESTADO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "P_DATAI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "P_DATAI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "P_DATAF"
        Me.DataGridViewTextBoxColumn4.HeaderText = "P_DATAF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "P_CLIENTE_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "P_CLIENTE_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PEDIDOTableAdapter
        '
        Me.PEDIDOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PEDIDOTableAdapter = Me.PEDIDOTableAdapter
        Me.TableAdapterManager.PRECO_ETableAdapter = Nothing
        Me.TableAdapterManager.REGIOESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PEDIDOBindingNavigator
        '
        Me.PEDIDOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PEDIDOBindingNavigator.BindingSource = Me.PEDIDOBindingSource
        Me.PEDIDOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PEDIDOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PEDIDOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PEDIDOBindingNavigatorSaveItem})
        Me.PEDIDOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PEDIDOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PEDIDOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PEDIDOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PEDIDOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PEDIDOBindingNavigator.Name = "PEDIDOBindingNavigator"
        Me.PEDIDOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PEDIDOBindingNavigator.Size = New System.Drawing.Size(846, 25)
        Me.PEDIDOBindingNavigator.TabIndex = 1
        Me.PEDIDOBindingNavigator.Text = "BindingNavigator1"
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
        'PEDIDOBindingNavigatorSaveItem
        '
        Me.PEDIDOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PEDIDOBindingNavigatorSaveItem.Image = CType(resources.GetObject("PEDIDOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PEDIDOBindingNavigatorSaveItem.Name = "PEDIDOBindingNavigatorSaveItem"
        Me.PEDIDOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PEDIDOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 373)
        Me.Controls.Add(Me.PEDIDOBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Pedido"
        Me.Text = "Gerir Pedidos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PEDIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PEDIDOBindingNavigator.ResumeLayout(False)
        Me.PEDIDOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents PEDIDOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.PEDIDOTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PEDIDOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PEDIDOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents P_ESTADOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P_DATAIDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents P_DATAFDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents P_CLIENTE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PEDIDODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
