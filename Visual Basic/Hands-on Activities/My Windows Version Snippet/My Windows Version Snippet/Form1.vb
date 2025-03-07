Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim osVersion = My.Computer.Info.OSVersion
        Dim osName = My.Computer.Info.OSFullName
        MsgBox(osName & vbCr & osVersion)
    End Sub
End Class
