Imports System.IO

Public Class Extras

    Private Sub EXTRASBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXTRASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EXTRASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.EXTRAS' table. You can move, or remove it, as needed.
        Me.EXTRASTableAdapter.Fill(Me.Database1DataSet.EXTRAS)

    End Sub

    'Esta subrutina grava os dados do DataGridView do Extras para um ficheiro de texto localizado em C:\trabalho\extras.txt.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declarar variavel do tipo StreamWriter.
        Dim ts As New StreamWriter("C:\trabalho\extras.txt", False, System.Text.Encoding.UTF8)
        'Inicia o ciclo que vai percorrer o Datagrid.
        For Each row As DataGridViewRow In Me.EXTRASDataGridView.Rows
            'Declarar variavel com a ultima linha do DataGridView, para depois comparar e não guardar esta no ficheiro de texto.
            Dim ultima As DataGridViewRow = EXTRASDataGridView.Rows.Item(EXTRASDataGridView.Rows.GetLastRow(DataGridViewElementStates.Displayed))
            'Declara a String que vai armazenar a informação para depois ser colocada no ficheiro de texto.
            Dim linha As String = ""
            'Verificar se é a ultima linha do Datagrid.
            If (row Is ultima) Then
            Else
                'Inicia o ciclo para percorrer as celulas de uma linha.
                For Each cell As DataGridViewCell In row.Cells
                    'Concatnar informação da celula à string linha para depois gravar.
                    linha += CStr(cell.Value) + ";"
                Next
                'Escrever linha no ficheiro de texto.
                ts.WriteLine(linha)
            End If
        Next
        'Libertar o ficheiro texto para poder ser utilizado por outros programas.
        ts.Close()
    End Sub

    'Esta subrutina carrega os dados do ficheiro de texto localizado em C:\trabalho\extras.txt para o DataGridView do Extras.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rd As New StreamReader("C:\trabalho\extras.txt")
        Dim count As Integer = 0
        While Not rd.EndOfStream
            Dim parametros As Array = rd.ReadLine().Split(";")
            EXTRASDataGridView.Item(0, count).Value = parametros(1)
            count += 1
        End While
        rd.Close()
    End Sub
End Class