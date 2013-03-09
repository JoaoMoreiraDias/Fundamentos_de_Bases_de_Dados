Public Class Estados

    Private Sub ESTADOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ESTADOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.ESTADOS' table. You can move, or remove it, as needed.
        Me.ESTADOSTableAdapter.Fill(Me.Database1DataSet.ESTADOS)

    End Sub
End Class