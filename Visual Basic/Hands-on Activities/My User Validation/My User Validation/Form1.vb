Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MaskedTextBox1.Text = "555-55-1212" _
            And MaskedTextBox2.Text = "54321") Then
            MsgBox("Welcome to the system!")
        Else
            MsgBox("I don't recognize this number")
        End If
    End Sub
End Class
