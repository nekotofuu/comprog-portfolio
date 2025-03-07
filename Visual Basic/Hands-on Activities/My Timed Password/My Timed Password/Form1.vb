Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox("Sorry, your time is up.")
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "secret") Then
            Timer1.Enabled = False
            MsgBox("Welcome to the system!")
            End
        Else
            MsgBox("Sorry, friend. I don't know you.")
        End If
    End Sub
End Class
