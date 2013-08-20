Imports System.Drawing

Public Class GameForm
    Dim Budgets() As Integer = {0, 0, 0, 0, 0}
    Dim PState As State

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
    End Sub

    'Go back to the main menu
    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        Me.Hide()
        MenuForm.Show()
        MenuForm.Activate()
    End Sub

    Private Sub GameForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PState.Env = 100
        PState.Food = 100
        PState.Inc = 100
        PState.Pop = 100
    End Sub
End Class
