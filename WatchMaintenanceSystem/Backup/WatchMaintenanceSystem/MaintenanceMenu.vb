Public Class MaintenanceMenu

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        defaultSystemForm.Show()
        Me.Dispose()

    End Sub

    Private Sub btnCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCondition.Click
        MsgBox("Implement Soon")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Implement Soon")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AdminMaintain.Show()
        Me.Close()

        ' MsgBox("Implement Soon")

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Homepage.Show()
        Me.Close()

    End Sub
End Class