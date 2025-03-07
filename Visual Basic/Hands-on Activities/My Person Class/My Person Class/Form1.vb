Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Employee As New Person
        Dim DOB As Date

        Employee.FirstName = TextBox1.Text
        Employee.LastName = TextBox2.Text
        DOB = DateTimePicker1.Value.Date

        MsgBox(Employee.FirstName & " " & Employee.LastName & " is " & Employee.Age(DOB) & " years old.")


    End Sub
End Class
