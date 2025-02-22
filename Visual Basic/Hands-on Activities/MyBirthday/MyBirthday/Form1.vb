Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Your birthdate was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & DateTimePicker1.Value.DayOfYear.ToString())
    End Sub
End Class
