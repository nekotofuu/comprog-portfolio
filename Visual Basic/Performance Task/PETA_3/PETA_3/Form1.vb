Public Class Form1

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        ' Base Computation
        Dim baseCost As Double

        If rb16.Checked Then
            baseCost = 5.99
        Else
            baseCost = 9.99
        End If

        ' Quantity Discount
        Dim qty As Integer = CDbl(tbQuantity.Text)
        Dim qtyPercentDiscount As Double = 0

        If (qty >= 25 And qty < 50) Then
            qtyPercentDiscount = 0.1
        ElseIf (qty >= 50 And qty < 100) Then
            qtyPercentDiscount = 0.15
        ElseIf (qty >= 100) Then
            qtyPercentDiscount = 0.2
        End If

        ' Compute Total Cost
        Dim netCost As Double = baseCost * qty
        Dim totalCost As Double = netCost - (netCost * qtyPercentDiscount)
        tbCost.Text = FormatCurrency(totalCost)
    End Sub
End Class
