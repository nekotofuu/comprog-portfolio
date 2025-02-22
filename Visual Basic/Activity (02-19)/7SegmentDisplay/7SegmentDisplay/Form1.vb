Public Class Form1

    Dim colorDisabled As Color = Color.LightGray
    Dim colorEnabled As Color = Color.Black

    Sub reset()
        lLine.BorderColor = colorDisabled
        llLine.BorderColor = colorDisabled
        lrLine.BorderColor = colorDisabled
        mLine.BorderColor = colorDisabled
        uLine.BorderColor = colorDisabled
        ulLine.BorderColor = colorDisabled
        urLine.BorderColor = colorDisabled
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reset()
        urLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reset()
        uLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        llLine.BorderColor = colorEnabled
        lLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        reset()
        uLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        lLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        reset()
        ulLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        reset()
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        lLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        reset()
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        llLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        lLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        reset()
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        reset()
        lLine.BorderColor = colorEnabled
        llLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        reset()
        lLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        mLine.BorderColor = colorEnabled
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        reset()
        lLine.BorderColor = colorEnabled
        llLine.BorderColor = colorEnabled
        lrLine.BorderColor = colorEnabled
        uLine.BorderColor = colorEnabled
        ulLine.BorderColor = colorEnabled
        urLine.BorderColor = colorEnabled
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        reset()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        End
    End Sub
End Class
