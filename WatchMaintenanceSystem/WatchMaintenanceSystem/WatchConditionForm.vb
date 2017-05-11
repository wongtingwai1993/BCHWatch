Public Class WatchConditionForm

    Private Sub chkCrown_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkCrown.ItemCheck
        If chkCrown.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkCrown.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkCrown.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkPusher_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkPusher.ItemCheck
        If chkPusher.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkPusher.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkPusher.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkDial_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkDial.ItemCheck
        If chkDial.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkDial.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkDial.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkCrystal_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkCrystal.ItemCheck
        If chkCrystal.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkCrystal.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkCrystal.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkBezel_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkBezel.ItemCheck
        If chkBezel.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkBezel.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkBezel.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkCase_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkCase.ItemCheck
        If chkCase.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkCase.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkCase.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub chkStrap_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkStrap.ItemCheck
        If chkStrap.GetItemChecked(e.Index) = False Then
            lbDetails.Items.Add(chkStrap.Items(e.Index).ToString)
        Else
            lbDetails.Items.Remove(chkStrap.Items(e.Index).ToString)
        End If
    End Sub

    Private Sub clearAllCheckbox()
        ' first for loop is to detech the 7 table layout
        For Each assignTbl As Control In tblParts.Controls

            If TypeOf assignTbl Is TableLayoutPanel Then
                ' when detect 1st table layout, search for inner condition table layout
                For Each assignedChecked As Control In assignTbl.Controls
                    'search for inner condition table layout
                    For Each tblCondition As Control In assignedChecked.Controls
                        ' search for condition panel
                        If TypeOf tblCondition Is Panel Then
                            ' search for the checkboxlist
                            For Each panelItems As Control In tblCondition.Controls
                                If TypeOf panelItems Is CheckedListBox Then
                                    Dim checkboxList As CheckedListBox = panelItems
                                    For index As Integer = 0 To checkboxList.Items.Count - 1
                                        checkboxList.SetItemCheckState(index, False)
                                    Next
                                End If
                            Next

                        End If
                    Next
                Next
            End If
        Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbDetails.Items.Clear()
        Me.clearAllCheckbox()
    End Sub
    Public Function getData() As ListBox
        Return lbDetails
    End Function

    Public Sub setData(conditionData As ListBox)
        If conditionData.Items.Count > 0 Then
            lbDetails.Items.Clear()
            ' retrigger condition will reset the checkbox, when items check, 
            ' ListBox also will add based on itemCheck event in each checkboxlist
            retriggerCondition(conditionData)
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
    End Sub

    Private Sub WatchConditionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lbDetails.Items.Clear()
    End Sub
    Private Sub retriggerCondition(ByVal condition As ListBox)
        Me.clearAllCheckbox()
        For Each value In condition.Items
            If chkStrap.Items.Contains(value) Then
                Dim index As Integer = chkStrap.Items.IndexOf(value)
                chkStrap.SetItemChecked(index, True)

            ElseIf chkPusher.Items.Contains(value) Then
                Dim index As Integer = chkPusher.Items.IndexOf(value)
                chkPusher.SetItemChecked(index, True)

            ElseIf chkCrystal.Items.Contains(value) Then
                Dim index As Integer = chkCrystal.Items.IndexOf(value)
                chkCrystal.SetItemChecked(index, True)

            ElseIf chkCrown.Items.Contains(value) Then
                Dim index As Integer = chkCrown.Items.IndexOf(value)
                chkCrown.SetItemChecked(index, True)

            ElseIf chkBezel.Items.Contains(value) Then
                Dim index As Integer = chkBezel.Items.IndexOf(value)
                chkBezel.SetItemChecked(index, True)

            ElseIf chkCase.Items.Contains(value) Then
                Dim index As Integer = chkCase.Items.IndexOf(value)
                chkCase.SetItemChecked(index, True)

            ElseIf chkDial.Items.Contains(value) Then
                Dim index As Integer = chkDial.Items.IndexOf(value)
                chkDial.SetItemChecked(index, True)
            End If
        Next

    End Sub
End Class