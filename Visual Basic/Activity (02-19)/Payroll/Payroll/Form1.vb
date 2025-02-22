Public Class Form1

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim payPerHour As Double = CDbl(txtRate.Text)
        Dim hours As Double = CDbl(txtHours.Text)

        Dim basicPay As Double = payPerHour * hours

        ' Deductions
        Dim tax As Double = 0.12 * basicPay
        Dim sss As Double = 0.2 * basicPay
        Dim philhealth As Double = 0.05 * basicPay
        Dim pagibig As Double = 200
        Dim deductions As Double = tax + sss + philhealth + pagibig

        Dim netpay As Double = basicPay - deductions

        txtBPay.Text = FormatCurrency(basicPay)
        txtDeduct.Text = FormatCurrency(deductions)
        txtNetPay.Text = FormatCurrency(netpay)
        txtPAGIBIG.Text = FormatCurrency(pagibig)
        txtPhilhealth.Text = FormatCurrency(philhealth)
        txtSSS.Text = FormatCurrency(sss)
        txtTax.Text = FormatCurrency(tax)

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBPay.Text = ""
        txtDeduct.Text = ""
        txtECode.Text = ""
        txtEName.Text = ""
        txtHours.Text = ""
        txtNetPay.Text = ""
        txtPAGIBIG.Text = ""
        txtPhilhealth.Text = ""
        txtRate.Text = ""
        txtSSS.Text = ""
        txtTax.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If (MsgBox("Do you want to exit?", 1) = 1) Then
            End
        End If
    End Sub
End Class
