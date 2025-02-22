Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim wrap As String = Chr(13) & Chr(10)

        For i = 1 To 10
            TextBox1.Text = TextBox1.Text & "Line " & i & wrap
        Next i
    End Sub
End Class
