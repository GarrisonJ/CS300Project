Public Class MenuForm

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        LoadDialog.InitialDirectory = ""
        LoadDialog.Filter = "txt files (*.txt)|*.txt"
        LoadDialog.RestoreDirectory = True
        LoadDialog.ShowDialog()
    End Sub

    Private Sub ContinueButton_Click(sender As System.Object, e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
        GameForm.ShowDialog()
        Me.Show()
    End Sub
End Class