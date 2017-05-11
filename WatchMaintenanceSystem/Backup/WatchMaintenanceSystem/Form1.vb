Public Class Form1

    Dim timerStrap As Integer = 1
    Private Sub lblStrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbWatch.MouseMove
        trying.Text = String.Format("({0}, {1})", e.X, e.Y)

        Dim strapRange As Boolean = e.X > 70 And e.X < 103 And e.Y > 5 And e.Y < 20
        Dim dialRange As Boolean = e.X > 63 And e.X < 84 And e.Y > 74 And e.Y < 103
        Dim surfaceRange As Boolean = e.X > 44 And e.X < 128 And e.Y > 55 And e.Y < 136
        Dim crownRange As Boolean = e.X > 138 And e.X < 156 And e.Y > 81 And e.Y < 104
        Dim pusherRange As Boolean = e.X > 134 And e.X < 153 And e.Y > 51 And e.Y < 75
        Dim sideRange As Boolean = e.X > 49 And e.X < 74 And e.Y > 145 And e.Y < 173
        Dim circleRange As Boolean = e.X > 114 And e.X < 131 And e.Y > 135 And e.Y < 152

        If strapRange Then
            watchDesc.Text = "Strap"
            CheckedListBox1.Visible = True
            timerStrap = 0
        ElseIf dialRange Then
            watchDesc.Text = "Dial"
        ElseIf surfaceRange Then
            watchDesc.Text = "Surface"
        ElseIf crownRange Then
            watchDesc.Text = "Crown"
        ElseIf pusherRange Then
            watchDesc.Text = "Pusher"
        ElseIf sideRange Then
            watchDesc.Text = "Side"
        ElseIf circleRange Then
            watchDesc.Text = "Circle"
        Else
            watchDesc.Text = ""
        End If


        'make sure all the checkbox gone after 2 sec
        ' all use if statement, canot use if else
        If Not strapRange Then
            tFadeOut.Start()
        ElseIf dialRange Then
            watchDesc.Text = "Dial"
        ElseIf surfaceRange Then
            watchDesc.Text = "Surface"
        ElseIf crownRange Then
            watchDesc.Text = "Crown"
        ElseIf pusherRange Then
            watchDesc.Text = "Pusher"
        ElseIf sideRange Then
            watchDesc.Text = "Side"
        ElseIf circleRange Then
            watchDesc.Text = "Circle"
        Else
            watchDesc.Text = ""
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

    End Sub


    Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbWatch.MouseClick
        If e.X > 70 And e.X < 103 And e.Y > 5 And e.Y < 20 Then
            MsgBox("Strap")
        ElseIf e.X > 63 And e.X < 84 And e.Y > 74 And e.Y < 103 Then
            watchDesc.Text = "Dial"
            Panel1.Visible = True
            Label1.Text = "Dial"
        ElseIf e.X > 44 And e.X < 128 And e.Y > 55 And e.Y < 136 Then
            watchDesc.Text = "Surface"
        ElseIf e.X > 138 And e.X < 156 And e.Y > 81 And e.Y < 104 Then
            watchDesc.Text = "Crown"
        ElseIf e.X > 134 And e.X < 153 And e.Y > 51 And e.Y < 75 Then
            watchDesc.Text = "Pusher"
        ElseIf e.X > 49 And e.X < 74 And e.Y > 145 And e.Y < 173 Then
            watchDesc.Text = "Side"
        ElseIf e.X > 114 And e.X < 131 And e.Y > 135 And e.Y < 152 Then
            watchDesc.Text = "Circle"
        Else
            watchDesc.Text = ""
        End If
    End Sub

    Private Sub tFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFadeOut.Tick

        Label1.Text = timerStrap
        If timerStrap = 1 Then
            CheckedListBox1.Visible = False
            tFadeOut.Stop()
        End If
        timerStrap += 1
    End Sub

    Private Sub CheckedListBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CheckedListBox1.MouseMove
        CheckedListBox1.Visible = True
        timerStrap = 0
        Label1.Text = timerStrap
        tFadeOut.Stop()

    End Sub

    Private Sub CheckedListBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.MouseLeave
        tFadeOut.Start()
    End Sub
End Class