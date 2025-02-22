Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 4
            PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\..\..\Resources\face" & i & ".png")
            MsgBox("Click here for next face.")
        Next i
    End Sub
End Class
