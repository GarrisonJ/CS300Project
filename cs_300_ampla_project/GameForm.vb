Public Class GameForm
    Dim Budgets() As Integer = {0, 0, 0, 0, 0}

    'Functions
    'function takes in an array of integers and copies to the local budget
    Public Function SetBudget(ByRef Values() As Integer) As Integer
        For I = LBound(Values) To UBound(Values)
            Budgets(I) = Values(I)
        Next I
        Return 0
    End Function

    'get function for getting the currently set budget
    Public Function GetBudget() As Array
        Return Budgets
    End Function

    'Events
    'Show the budget form
    Private Sub BudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles Budget.Click
        BudgetForm.ShowDialog()
        BudgetForm.Dispose()
    End Sub

    'Go back to the main menu
    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        Me.Close()
    End Sub
End Class
