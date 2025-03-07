Public Class Form1

    
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim daysElapsed As Integer = DateDiff(DateInterval.Day, CDate(mtbDate.Text), CDate(DateString))
        Dim convFactor As Double
        Dim term As String

        If (rbMercury.Checked) Then
            convFactor = 88
            term = "Mercurian"
        ElseIf (rbVenus.Checked) Then
            convFactor = 224.7
            term = "Venusian"
        ElseIf (rbEarth.Checked) Then
            convFactor = 365.26
            term = "Earth"
        ElseIf (rbMars.Checked) Then
            convFactor = 687
            term = "Martian"
        ElseIf (rbJupiter.Checked) Then
            convFactor = 365.26 * 11.86
            term = "Jupiter"
        ElseIf (rbSaturn.Checked) Then
            convFactor = 365.26 * 29.46
            term = "Saturian"
        ElseIf (rbUranus.Checked) Then
            convFactor = 365.26 * 84.07
            term = "Uranian"
        ElseIf (rbNeptune.Checked) Then
            convFactor = 365.26 * 164.8
            term = "Neptunian"
        End If

        Dim age As Double = Math.Round((daysElapsed / convFactor) * 100) / 100
        txtAge.Text = CStr(age) & " " & term & " years"


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDateNow.Text = FormatDateTime(CDate(DateString), DateFormat.LongDate)
    End Sub
End Class
