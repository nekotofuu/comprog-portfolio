Public Class Form1
    Private Sub DisplayRates()
        lstRates.Items.Add("Price of Equipment               Half-day   Full-day")
        lstRates.Items.Add("1. Rug cleaner                   $16.00     $24.00")
        lstRates.Items.Add("2. Lawn mower                    $12.00     $18.00")
        lstRates.Items.Add("3. Paint sprayer                 $20.00     $30.00")
    End Sub

    Private Sub DisplayBill(ByVal Item As Integer, ByVal Duration As Integer)

        Try
            Do
                lstReceipt.Items.RemoveAt(0)
            Loop
        Catch ex As Exception
        End Try
        

        Dim Equipment As String
        Dim TimePeriod As String
        Dim RentalPrice As Double

        If Item = 1 Then
            Equipment = "Rug cleaner"
            RentalPrice = 16
        ElseIf Item = 2 Then
            Equipment = "Lawn mower"
            RentalPrice = 12
        ElseIf Item = 3 Then
            Equipment = "Paint sprayer"
            RentalPrice = 20
        End If

        If Duration = 0 Then
            TimePeriod = "(Full day rental)"
        ElseIf Duration = 1 Then
            TimePeriod = "(Half-day rental)"
            RentalPrice *= 1.5
        End If

        lstReceipt.Items.Add("Receipt from Eddie's Equipment Rental")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add(Equipment & ": " & FormatCurrency(RentalPrice) & " " & TimePeriod)
        lstReceipt.Items.Add("Deposit: $30.00")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Total: " & FormatCurrency(30 + RentalPrice))
    End Sub


    Private Sub btnDisplayRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRate.Click
        DisplayRates()
    End Sub


    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click
        Dim item As Integer
        Dim duration As String = CChar(mtbDuration.Text)
        Try
            item = CInt(mtbItemNum.Text)
            duration = mtbDuration.Text

            If (item = 1 Or item = 2 Or item = 3) And (duration = "F" Or duration = "H") Then
                Select Case duration
                    Case "F"
                        DisplayBill(item, 0)
                    Case "H"
                        DisplayBill(item, 1)
                End Select
            Else
                MsgBox("Invalid item or duration!" & vbCrLf & "Please enter the desired input.")
            End If
        Catch ex As Exception
            MsgBox("Invalid item or duration!" & vbCrLf & "Please enter the desired input.")
        End Try

      
    End Sub
End Class
