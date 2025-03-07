Public Class Form1

    Private PizzaQty As Integer
    Private FriesQty As Integer
    Private DrinksQty As Integer


    Sub InputData()
        PizzaQty = CInt(txtPizza.Text)
        FriesQty = CInt(txtFries.Text)
        DrinksQty = CInt(txtDrinks.Text)
    End Sub

    Function TotalCost() As Double
        Dim cost As Double = (PizzaQty * 1.75) + (FriesQty * 2.0) + (DrinksQty * 1.25)
        Return cost
    End Function

    Sub DisplayBill()
        lstReceipt.Items.Add("ITEMS               QUANTITY     PRICE")
        lstReceipt.Items.Add("Pizza Slices           " & PizzaQty & "         " & FormatCurrency(PizzaQty * 1.75))
        lstReceipt.Items.Add("Fries                  " & FriesQty & "         " & FormatCurrency(FriesQty * 2.0))
        lstReceipt.Items.Add("Sodas                  " & DrinksQty & "         " & FormatCurrency(DrinksQty * 1.25))
        lstReceipt.Items.Add("Total                            " & FormatCurrency(TotalCost))
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Try
            Do
                lstReceipt.Items.RemoveAt(0)
            Loop
        Catch ex As Exception
        End Try

        InputData()
        TotalCost()
        DisplayBill()
    End Sub
End Class
