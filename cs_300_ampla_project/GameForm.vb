Public Class GameForm

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Budget.Click
        BudgetForm.ShowDialog()
    End Sub

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        MenuForm.ShowDialog()
    End Sub
End Class
