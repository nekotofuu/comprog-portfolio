Public Class Form1
    Dim temperatures(0 To 6) As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim prompt, title As String
        Dim i As Short
        prompt = "Enter the day's high temperature."
        For i = 0 To UBound(temperatures)
            title = "Day " & (i + 1)
            temperatures(i) = InputBox(prompt, title)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Result As String
        Dim i As Short
        Dim Total As Single = 0
        Result = "High temperatures for the week:" & vbCrLf & vbCrLf
        For i = 0 To UBound(temperatures)
            Result = Result & "Day " & (i + 1) & vbTab & _
                 temperatures(i) & vbCrLf
            Total = Total + temperatures(i)
        Next
        Result = Result & vbCrLf & _
              "Average temperature: " & Format(Total / 7, "0.0")
        TextBox1.Text = Result
    End Sub
End Class
