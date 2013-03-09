Public Class Hotel

    Private Sub HOTELBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOTELBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HOTELBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.HOTEL' table. You can move, or remove it, as needed.
        Me.HOTELTableAdapter.Fill(Me.Database1DataSet.HOTEL)

    End Sub
End Class