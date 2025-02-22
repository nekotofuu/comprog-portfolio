Public Class Form1

    Private Sub btnFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFee.Click
        ' Declare fee variables
        Dim baseFee As Double = 0
        Dim extraFee As Double = 0

        ' Declare radio activation variables
        Dim isAdult As Boolean = CBool(rbAdult.Checked)

        If isAdult Then
            baseFee = 100
        Else
            baseFee = 75
        End If

        If (cb1.Checked) Then
            extraFee += 25
        End If

        If (cb2.Checked) Then
            extraFee += 25
        End If

        If (cb3.Checked) Then
            extraFee += 25
        End If

        Dim totalFee As Double = baseFee + extraFee

        tbFee.Text = FormatCurrency(totalFee)

    End Sub
End Class
