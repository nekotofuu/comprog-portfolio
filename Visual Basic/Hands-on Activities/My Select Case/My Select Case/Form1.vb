Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCountry.Items.Add("England")
        lstCountry.Items.Add("Germany")
        lstCountry.Items.Add("Mexico")
        lstCountry.Items.Add("Italy")
    End Sub

    Private Sub lstCountry_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCountry.MouseHover
        If lstCountry.SelectedIndex < 0 Then
            Label4.Text = "Please click the country name"
        End If
    End Sub


    Private Sub lstCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCountry.SelectedIndexChanged
        Label3.Text = lstCountry.Text
        Select Case lstCountry.SelectedIndex
            Case 0
                Label4.Text = "Hello, programmer"
            Case 1
                Label4.Text = "Hallo, programmierer"
            Case 2
                Label4.Text = "Hola, programador"
            Case 3
                Label4.Text = "Ciao, programmatore"
        End Select
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
