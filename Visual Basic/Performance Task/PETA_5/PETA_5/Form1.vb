Public Class Form1
    ' 1st Num: State
    ' 2nd Num: Category (flower, nickname, motto)

    Dim StateLookup(0 To 3, 0 To 2) As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' California
        StateLookup(0, 0) = "Golden poppy"
        StateLookup(0, 1) = "Golden State"
        StateLookup(0, 2) = "Eureka"

        ' Indiana
        StateLookup(1, 0) = "Peony"
        StateLookup(1, 1) = "Hoosier State"
        StateLookup(1, 2) = "Crossroads of America"

        ' Mississippi
        StateLookup(2, 0) = "Magnolia"
        StateLookup(2, 1) = "Magnolia State"
        StateLookup(2, 2) = "By valor and arms"

        'New York
        StateLookup(3, 0) = "Rose"
        StateLookup(3, 1) = "Empire State"
        StateLookup(3, 2) = "Ever upward"
    End Sub

    Private Sub btnShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInfo.Click
        ' Declare variables for indices
        Dim stateType As Integer
        Dim categoryType As Integer

        If (rbCalifornia.Checked) Then
            stateType = 0
        ElseIf (rbIndiana.Checked) Then
            stateType = 1
        ElseIf (rbMississipi.Checked) Then
            stateType = 2
        ElseIf (rbNewYork.Checked) Then
            stateType = 3
        End If

        If (rbFlower.Checked) Then
            categoryType = 0
        ElseIf (rbNickname.Checked) Then
            categoryType = 1
        ElseIf (rbMotto.Checked) Then
            categoryType = 2
        End If

        txtInfo.Text = StateLookup(stateType, categoryType)
    End Sub
End Class
