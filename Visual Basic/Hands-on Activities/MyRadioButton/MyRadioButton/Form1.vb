Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\image-removebg-preview (8).png")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\image-removebg-preview (9).png")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\image-removebg-preview (10).png")
    End Sub
End Class
