Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form2 As New Form

        form2.Text = "My New Form"
        form2.FormBorderStyle = FormBorderStyle.FixedDialog
        form2.StartPosition = FormStartPosition.Manual

        Dim form2Rect As New Rectangle(200, 100, 300, 250)
        form2.DesktopBounds = form2Rect

        form2.ShowDialog()
    End Sub
End Class
