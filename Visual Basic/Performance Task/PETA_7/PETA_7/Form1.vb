Public Class Menu

    Private Sub chkBurgers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBurgers.CheckedChanged
        If chkBurgers.Checked Then
            grpBurgers.Enabled = True
        Else
            grpBurgers.Enabled = False
        End If
    End Sub

    Private Sub chkFries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            grpFries.Enabled = True
        Else
            grpFries.Enabled = False
        End If
    End Sub

    Private Sub chkDrinks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDrinks.CheckedChanged
        If chkDrinks.Checked Then
            grpDrinks.Enabled = True
        Else
            grpDrinks.Enabled = False
        End If
    End Sub


    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim burger As Double = 0
        Dim fries As Double = 0
        Dim drinks As Double = 0

        If (grpBurgers.Enabled) Then
            If (radBurger1.Checked) Then
                burger = 4.19
            ElseIf (radBurger2.Checked Or radBurger3.Checked) Then
                burger = 4.79
            ElseIf (radBurger4.Checked) Then
                burger = 5.39
            End If
        End If

        If (grpFries.Enabled) Then
            If (radFries1.Checked) Then
                fries = 2.39
            ElseIf (radFries2.Checked) Then
                fries = 3.09
            ElseIf (radFries3.Checked) Then
                fries = 4.99
            End If
        End If

        If (grpDrinks.Enabled) Then
            If (radDrinks1.Checked) Then
                drinks = 1.69
            ElseIf (radDrinks2.Checked) Then
                drinks = 1.49
            End If
        End If

        txtCost.Text = FormatCurrency(burger + drinks + fries)
    End Sub
End Class
