Public Class Pedido

    Private Sub PEDIDOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEDIDOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PEDIDOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.PEDIDO' table. You can move, or remove it, as needed.
        Me.PEDIDOTableAdapter.Fill(Me.Database1DataSet.PEDIDO)

    End Sub
End Class