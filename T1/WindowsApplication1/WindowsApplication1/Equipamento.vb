Imports System.IO
Public Class Equipamento

    Private Sub EQUIPAMENTOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQUIPAMENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EQUIPAMENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.EQUIPAMENTO' table. You can move, or remove it, as needed.
        Me.EQUIPAMENTOTableAdapter.Fill(Me.Database1DataSet.EQUIPAMENTO)

    End Sub

    'Esta subrutina grava os dados do DataGridView do Equipamento para um ficheiro de texto localizado em C:\trabalho\equipamento.txt.
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Declarar variavel do tipo StreamWriter.
        Dim ts As New StreamWriter("C:\trabalho\equipamento.txt", False, System.Text.Encoding.UTF8)
        'Inicia o ciclo que vai percorrer o Datagrid.
        For Each row As DataGridViewRow In Me.EQUIPAMENTODataGridView.Rows
            'Declarar variavel com a ultima linha do DataGridView, para depois comparar e não guardar esta no ficheiro de texto.
            Dim ultima As DataGridViewRow = EQUIPAMENTODataGridView.Rows.Item(EQUIPAMENTODataGridView.Rows.GetLastRow(DataGridViewElementStates.Displayed))
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

    'Esta subrutina carrega os dados do ficheiro de texto localizado em C:\trabalho\equipamento.txt para o DataGridView do Equipamento.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rd As New StreamReader("C:\trabalho\equipamento.txt")
        Dim count As Integer = 0
        While Not rd.EndOfStream
            Dim parametros As Array = rd.ReadLine().Split(";")
            EQUIPAMENTODataGridView.Item(0, count).Value = parametros(1)
            count += 1
        End While
        rd.Close()
    End Sub
End Class