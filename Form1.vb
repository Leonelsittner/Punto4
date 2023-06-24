Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Matriz(10, 8), vector(10), Menor, F, C, M As Integer
        For F = 1 To 10
            For C = 1 To 8
                Matriz(F, C) = Rnd() * 100
            Next
        Next
        For F = 1 To 8
            dtvMatriz.Columns.Add("", "")
        Next
        dtvMatriz.Rows.Add(9)
        For F = 1 To 10
            Menor = Matriz(F, 1)
            M = M + 1
            For C = 1 To 8
                If Matriz(F, C) <= Menor Then
                    Menor = Matriz(F, C)
                    vector(M) = Matriz(F, C)
                End If
            Next
        Next
        For F = 1 To 10
            For C = 1 To 8
                dtvMatriz.Item(C - 1, F - 1).Value = Matriz(F, C)
            Next
        Next
        For M = 1 To 10
            lblVector.Items.Add(vector(M))
        Next
    End Sub
End Class
