Imports System.IO
Public Class Alojamento

    Private Sub ALOJAMENTO_HBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALOJAMENTO_HBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALOJAMENTO_HBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.ALOJAMENTO_H' table. You can move, or remove it, as needed.
        Me.ALOJAMENTO_HTableAdapter.Fill(Me.Database1DataSet.ALOJAMENTO_H)

    End Sub
End Class