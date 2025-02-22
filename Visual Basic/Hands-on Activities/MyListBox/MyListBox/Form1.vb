Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Extra hard disk")
        ListBox1.Items.Add("Printer")
        ListBox1.Items.Add("Satellite dish")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\..\..\Resources\image-removebg-preview (11).png")
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\..\..\Resources\image-removebg-preview (12).png")
            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\..\..\Resources\image-removebg-preview (13).png")
        End Select
    End Sub
End Class
