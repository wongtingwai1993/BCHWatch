Public Class AdminMaintain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddOutsource.Click
        AddCompany.ShowDialog()
    End Sub
End Class