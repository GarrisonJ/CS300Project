Public Class MenuForm

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        LoadDialog.InitialDirectory = ""
        LoadDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        LoadDialog.FilterIndex = 2
        LoadDialog.RestoreDirectory = True
        LoadDialog.ShowDialog()
    End Sub
End Class