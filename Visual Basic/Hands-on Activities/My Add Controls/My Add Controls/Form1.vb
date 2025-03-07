Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declare new form and control objects
        Dim form2 As New Form
        Dim lblDate As New Label
        Dim btnCancel As New Button

        'Set label properties
        lblDate.Text = "Current date is: " & DateString
        lblDate.Size = New Size(150, 50)
        lblDate.Location = New Point(80, 50)

        'Set button properties 
        btnCancel.Text = "Cancel"
        btnCancel.Location = New Point(110, 100)
        'Set form properties
        form2.Text = "Current Date"
        form2.CancelButton = btnCancel
        form2.StartPosition = FormStartPosition.CenterScreen

        'Add new objects to Controls collection
        form2.Controls.Add(lblDate)
        form2.Controls.Add(btnCancel)

        'Display form as a dialog box     
        form2.ShowDialog()

    End Sub
End Class
