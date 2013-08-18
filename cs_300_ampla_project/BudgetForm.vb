Public Class BudgetForm
    Dim RemBudget As Integer = 100
    Dim BudgetList() As Integer = {0, 0, 0, 0, 0}

    Private Function GetBudgetVals() As Boolean
        Dim StringList() As String = {RedBudget.Text, BlueBudget.Text, OrangeBudget.Text, YellowBudget.Text, GreenBudget.Text}

        'Checks if the input values are Integer, adds them to an Integer list
        For I As Integer = LBound(StringList) To UBound(StringList)
            If String.IsNullOrEmpty(StringList(I)) Then
                StringList(I) = "0"
            End If
            If IsNumeric(StringList(I)) Then
                BudgetList(I) = CInt(StringList(I))
            Else
                MsgBox("The values you entered are invalid. Please try again.", MsgBoxStyle.OkOnly)
                Return False
            End If
        Next I
        Return True
    End Function

    'Only resets the current form's budgets
    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        RedBudget.Text = "0"
        BlueBudget.Text = "0"
        OrangeBudget.Text = "0"
        YellowBudget.Text = "0"
        GreenBudget.Text = "0"
        RemainingBudget.Text = "100"
    End Sub

    'This event will check the text boxes for integer
    Private Sub SaveBudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveBudgetButton.Click
        If Not GetBudgetVals() Then
            Exit Sub
        End If
        'Check if the funds allocated is over or under max budget
        RemBudget = 100
        For Each Budget In BudgetList
            RemBudget -= Budget
        Next Budget

        If RemBudget < 0 Then
            MsgBox("The values you entered are greater than the allowed budget. Please try again.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        RemainingBudget.Text = Str(RemBudget)
        GameForm.SetBudget(BudgetList)
    End Sub

    Private Sub ExitBudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitBudgetButton.Click
        Dim Res As Integer
        Dim SavedBudget() As Integer

        'Grab current budget values, exit if invalid values
        If Not GetBudgetVals() Then
            Exit Sub
        End If

        'Check if there is any remaining budget left
        If RemBudget > 0 Then
            Res = MsgBox("You still have some Budget to allocate, do you want to continue exiting?", MsgBoxStyle.YesNo)
            If Res <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        'Check if the current values are different from the last saved budget
        SavedBudget = GameForm.GetBudget()
        For I As Integer = LBound(SavedBudget) To UBound(SavedBudget)
            If SavedBudget(I) <> BudgetList(I) Then
                MsgBox("You have unsaved budget changes, do you want to save? (Unsaved changes will be lost).", MsgBoxStyle.YesNo)
                If Res = MsgBoxResult.Yes Then
                    GameForm.SetBudget(BudgetList)
                    Me.Close()
                Else
                    Me.Close()
                End If
            End If
        Next I
        'Close window otherwise
        Me.Close()
    End Sub
End Class