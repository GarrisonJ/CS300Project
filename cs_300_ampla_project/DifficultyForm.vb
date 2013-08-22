Public Class DifficultyForm
    Dim DiffState As State

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub EasyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyButton.Click
        DiffState.Env = 150
        DiffState.Food = 150
        DiffState.Inc = 150
        DiffState.Pop = 150
        GameForm.SetState(DiffState)
        Me.Close()
    End Sub

    Private Sub MediumButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumButton.Click
        DiffState.Env = 100
        DiffState.Food = 100
        DiffState.Inc = 100
        DiffState.Pop = 100
        GameForm.SetState(DiffState)
        Me.Close()
    End Sub

    Private Sub HardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardButton.Click
        DiffState.Env = 50
        DiffState.Food = 50
        DiffState.Inc = 50
        DiffState.Pop = 50
        GameForm.SetState(DiffState)
        Me.Close()
    End Sub
End Class