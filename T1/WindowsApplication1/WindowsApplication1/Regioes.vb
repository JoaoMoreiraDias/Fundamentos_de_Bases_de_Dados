Public Class Regioes

    Private Sub REGIOESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGIOESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REGIOESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.REGIOES' table. You can move, or remove it, as needed.
        Me.REGIOESTableAdapter.Fill(Me.Database1DataSet.REGIOES)

    End Sub
End Class