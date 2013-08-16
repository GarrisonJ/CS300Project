Public Class BudgetForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        RedBudget.Clear()
        BlueBudget.Clear()
        OrangeBudget.Clear()
        YellowBudget.Clear()
        GreenBudget.Clear()
    End Sub
End Class