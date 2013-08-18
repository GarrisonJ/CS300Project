Public Class MenuForm
    Dim Path As String
    Dim InGame As Boolean = False

    Private Function ShowContinue() As Boolean
        If InGame Then
            ContinueButton.Show()
        Else
            ContinueButton.Hide()
        End If
        Return True
    End Function

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        Dim Resp As Integer
        LoadDialog.InitialDirectory = ""
        LoadDialog.Filter = "txt files (*.txt)|*.txt"
        LoadDialog.RestoreDirectory = True
        Resp = LoadDialog.ShowDialog()

    End Sub

    Private Sub ContinueButton_Click(sender As System.Object, e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
        GameForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowContinue()
    End Sub

    Private Sub NewGameButton_Click(sender As System.Object, e As System.EventArgs) Handles NewGameButton.Click
        InGame = True
        Me.Hide()
        GameForm.Dispose()
        BudgetForm.Dispose()
        GameForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MenuForm_Activated(sender As Object, e As System.EventArgs) Handles MyBase.Activated
        ShowContinue()
    End Sub

End Class