Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Dock = DockStyle.Top
        TextBox1.Anchor = AnchorStyles.Bottom Or _
        AnchorStyles.Left Or AnchorStyles.Right Or _
        AnchorStyles.Top
        Button1.Anchor = AnchorStyles.Bottom Or _
        AnchorStyles.Right
    End Sub
End Class
