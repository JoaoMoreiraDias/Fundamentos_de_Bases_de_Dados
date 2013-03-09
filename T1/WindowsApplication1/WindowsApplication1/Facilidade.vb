Public Class Facilidade

    Private Sub FACILIDADESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FACILIDADESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FACILIDADESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.FACILIDADES' table. You can move, or remove it, as needed.
        Me.FACILIDADESTableAdapter.Fill(Me.Database1DataSet.FACILIDADES)

    End Sub

End Class