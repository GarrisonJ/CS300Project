Public Class GameForm
    Dim Budgets() As Integer = {0, 0, 0, 0, 0}

    'Functions
    Public Function SetBudget(ByRef Values() As Integer) As Integer
        For I = LBound(Values) To UBound(Values)
            Budgets(I) = Values(I)
        Next I
        Return 0
    End Function

    Public Function GetBudget() As Array
        Return Budgets
    End Function

    'Events
    Private Sub BudgetButton_Click(sender As System.Object, e As System.EventArgs) Handles Budget.Click
        BudgetForm.ShowDialog()
    End Sub

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        Me.Close()
    End Sub
End Class
