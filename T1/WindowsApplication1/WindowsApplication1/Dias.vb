Public Class Dias

    Private Sub DIABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DIABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.DIA' table. You can move, or remove it, as needed.
        Me.DIATableAdapter.Fill(Me.Database1DataSet.DIA)

    End Sub
End Class