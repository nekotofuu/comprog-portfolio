Public Class Form2


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblEName.Text = "Employee Name: " & EmployeeName
        lblENumber.Text = "Employee Number: " & EmployeeNum
        lblDept.Text = "Department: " & Department
        lblDate.Text = "Date: " & PayDate

        lblSSS.Text = "SSS: " & sssDeduct
        lblphilhealth.Text = "PhilHealth: " & philhealthDeduct
        lblPagibig.Text = "PAG-IBIG: " & pagibigDeduct
        lblTax.Text = "Tax: " & taxDeduct
        lbldeductions.Text = "Total: " & totalDeduct

        lblhours.Text = "Working Hours: " & workHours & " hours"
        lblrate.Text = "Pay Rate: " & payRate & "/hr"
        lblbasicpay.Text = "Basic Pay: " & basicPay
        lblnetpay.Text = "Net Pay: " & netPay
    End Sub
End Class