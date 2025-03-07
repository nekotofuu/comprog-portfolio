Public Class Form1

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Prepare GraphicsFun variable for graphics calls
        Dim GraphicsFun As Graphics
        GraphicsFun = Me.CreateGraphics

        'Use a red pen color to draw a line and an ellipse 
        Dim PenColor As New Pen(Color.Red)
        GraphicsFun.DrawLine(PenColor, 20, 30, 100, 80)
        GraphicsFun.DrawEllipse(PenColor, 10, 120, 200, 160)

        'Use a green brush color to create a filled rectangle
        Dim BrushColor As New SolidBrush(Color.Green)
        GraphicsFun.FillRectangle(BrushColor, 150, 10, 250, 100)

        'Create a blue cardinal spline curve with four points 
        Dim Points() As Point = {New Point(358, 280), _
         New Point(300, 320), New Point(275, 155), New Point(350, 180)}
        For tension As Single = 0 To 2.5 Step 0.5
            GraphicsFun.DrawCurve(Pens.DodgerBlue, Points, tension)
        Next

    End Sub
End Class
