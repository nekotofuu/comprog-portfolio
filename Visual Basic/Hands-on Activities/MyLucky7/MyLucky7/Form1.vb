Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))

        Spins += 1 ' Added as part of HOA #18

        If ( _
            Label1.Text = "7" Or _
            Label2.Text = "7" Or _
            Label3.Text = "7" _
            ) Then
            PictureBox1.Visible = True
            Beep()

            ' Added as part of HOA #18
            Wins += 1
            Label5.Text = "Wins: " & Wins
        End If

        Label6.Text = HitRate(Wins, Spins) ' Added as part of HOA #18

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
