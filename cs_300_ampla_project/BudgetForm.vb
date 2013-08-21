Public Class BudgetForm
    Dim RemBudget As Integer = 100
    Dim BudgetList() As Integer = {0, 0, 0, 0, 0}

    Private Function GetBudgetVals(ByRef List() As Integer) As Boolean
        Dim StringList() As String = {RedBudget.Text, BlueBudget.Text, OrangeBudget.Text, YellowBudget.Text, GreenBudget.Text}

        'Checks if the input values are Integer, adds them to the current budget list.
        'Returns True on success or False if values are not integers.
        For I As Integer = LBound(StringList) To UBound(StringList)
            If String.IsNullOrEmpty(StringList(I)) Then
                StringList(I) = "0"
            End If
            If Not IsNumeric(StringList(I)) Then
                Return False
            End If
        Next I
        For I As Integer = LBound(StringList) To UBound(StringList)
            List(I) = CInt(StringList(I))
        Next I
        Return True
    End Function

    'Only resets the current form's budget
    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        RedBudget.Text = "0"
        BlueBudget.Text = "0"
        OrangeBudget.Text = "0"
        YellowBudget.Text = "0"
        GreenBudget.Text = "0"
        RemainingBudget.Text = "100"
        GetBudgetVals(BudgetList)
    End Sub

    'This event will check the text boxes for integer, check if enough funds, set Budget.
    Private Sub SaveBudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveBudgetButton.Click
        If Not GetBudgetVals(BudgetList) Then
            MsgBox("The values you entered are invalid. Please try again.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'Check if the funds allocated is over max budget
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

    'When the exit button is clicked, this function will check if there are valid values, if player has any remaining budget,
    'and if the player wants to save changes to their budget.
    Private Sub ExitBudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitBudgetButton.Click
        Dim Res As Integer
        Dim Resp As Integer
        Dim SavedBudget() As Integer
        Dim TempList() As Integer = {0, 0, 0, 0, 0}

        'Grab current budget values, exit if invalid values
        If Not GetBudgetVals(TempList) Then
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
        GetBudgetVals(TempList)
        For I As Integer = LBound(SavedBudget) To UBound(SavedBudget)
            If SavedBudget(I) <> TempList(I) Then
                Resp = MsgBox("You have unsaved budget changes, do you want to save first? (Unsaved changes will be lost).", MsgBoxStyle.YesNo)
                If Resp = MsgBoxResult.Yes Then
                    GameForm.SetBudget(TempList)
                End If
                Me.Hide()
                GameForm.Show()
            End If
        Next I
        'Close window if all above satisfied
        Me.Hide()
        GameForm.Show()
    End Sub

    'Initialize values for the budget form based on most recently saved values. Calculate Remaining Budget
    Private Sub BudgetForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RedBudget.Text = BudgetList(0)
        BlueBudget.Text = BudgetList(1)
        OrangeBudget.Text = BudgetList(2)
        YellowBudget.Text = BudgetList(3)
        GreenBudget.Text = BudgetList(4)
        GetBudgetVals(BudgetList)
    End Sub
End Class