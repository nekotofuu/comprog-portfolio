Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.CheckState = 1) Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.CheckState = 1) Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
    End Sub
End Class
