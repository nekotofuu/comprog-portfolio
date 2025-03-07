Public Class Form1
    Dim GoingUp As Boolean 'GoingUp stores current direction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GoingUp = True
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GoingUp = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GoingUp = True Then
            'move picture box toward the top
            If PictureBox1.Top > 10 Then
                PictureBox1.Location = New Point _
                (PictureBox1.Location.X - 10, _
               PictureBox1.Location.Y - 10)
            End If
        Else
            'move picture box toward the bottom 
            If PictureBox1.Top < (Me.Size.Height - 75) Then
                PictureBox1.Location = New Point _
                (PictureBox1.Location.X + 10, _
               PictureBox1.Location.Y + 10)
            End If
        End If

    End Sub
End Class
