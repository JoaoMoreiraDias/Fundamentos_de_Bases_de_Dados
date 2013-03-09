Public Class Epocas

    Private Sub EPOCASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EPOCASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EPOCASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.EPOCAS' table. You can move, or remove it, as needed.
        Me.EPOCASTableAdapter.Fill(Me.Database1DataSet.EPOCAS)

    End Sub
End Class