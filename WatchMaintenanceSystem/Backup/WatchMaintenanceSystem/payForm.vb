Public Class payForm

    Dim watchCondition As String
    Dim watchService As String
    Dim quotationPrice As String
    Dim confirmation As Boolean = False
    Dim NIL As Integer = 0
    Public Sub GetData(ByVal watchCon As String, ByVal watchSer As String, ByVal quotePrice As String)

        watchCondition = ""
        watchService = ""
        quotationPrice = ""
        lbCondition.Items.Clear()

        watchCondition = watchCon
        watchService = watchSer
        quotationPrice = quotePrice
    End Sub
    Private Sub payForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'watch condition

        For Each strLine As String In watchCondition.Split("_*_")
            If Not (strLine = "") And Not strLine = "*" Then
                lbCondition.Items.Add(strLine)
            End If

        Next

        txtService.Text = watchService
        txtPrice.Text = quotationPrice
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim proceed As Boolean = doChecking()

        If proceed Then
            confirmation = True
            Me.Hide()
        End If

    End Sub
    Public Function getConfirmatin() As Boolean
        Return confirmation
    End Function
    Public Function getNIL() As Integer
        Return NIL
    End Function
    Public Function doChecking() As Boolean
        Dim errCount As Integer = 0

        If rbNo.Checked Or rbSix.Checked Or rbThree.Checked Or rbTwelve.Checked Then
            errNIL.SetError(rbTwelve, "")

            If rbNo.Checked Then
                NIL = 0
            ElseIf rbSix.Checked Then
                NIL = 6
            ElseIf rbThree.Checked Then
                NIL = 3
            ElseIf rbTwelve.Checked Then
                NIL = 12
            End If
        Else
            errNIL.SetError(rbTwelve, "Please choose one NIL")
            errCount += 1
        End If


        If errCount > 0 Then
            Return False
        Else
            Return True
        End If

    End Function
End Class