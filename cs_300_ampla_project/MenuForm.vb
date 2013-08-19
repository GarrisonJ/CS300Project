Public Class MenuForm
    Dim Path As String
    Dim Fn As String
    Dim InGame As Boolean = False

    Private Function ShowContinue() As Boolean
        If InGame Then
            ContinueButton.Show()
        Else
            ContinueButton.Hide()
        End If
        Return True
    End Function

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Dim Resp As Integer
        'initialize save dialog params
        If Not (IsNothing(Path)) Then
            SaveDialog.InitialDirectory = Path
        End If
        If Not (IsNothing(Fn)) Then
            SaveDialog.FileName = Fn
        End If
        SaveDialog.Filter = "txt files (*.txt)|*.txt"
        SaveDialog.RestoreDirectory = True

        'Prompt user for save
        Resp = SaveDialog.ShowDialog()
        If Resp = DialogResult.Cancel Then
            Exit Sub
        End If
        'Get associative array from Model
        'Loop to format
        'Save(File)

    End Sub

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        Dim Resp As Integer

        'initialize load dialog params
        If Not (IsNothing(Path)) Then
            LoadDialog.InitialDirectory = Path
        End If
        If Not (IsNothing(Fn)) Then
            LoadDialog.FileName = Fn
        End If
        LoadDialog.InitialDirectory = ""
        LoadDialog.Filter = "txt files (*.txt)|*.txt"
        LoadDialog.RestoreDirectory = True

        Resp = LoadDialog.ShowDialog()
        If Resp = DialogResult.Cancel Then
            Exit Sub
        End If
        'Open File
        'Organize into associative array (Dictionary)
        'Give to Model
    End Sub

    Private Sub ContinueButton_Click(sender As System.Object, e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
        GameForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowContinue()
    End Sub

    'Creates a new game
    Private Sub NewGameButton_Click(sender As System.Object, e As System.EventArgs) Handles NewGameButton.Click
        InGame = True
        Me.Hide()
        GameForm.Dispose()
        BudgetForm.Dispose()
        GameForm.ShowDialog()
        Me.Show()
    End Sub

    'Runs these functions when a form becomes the active form.
    Private Sub MenuForm_Activated(sender As Object, e As System.EventArgs) Handles MyBase.Activated
        ShowContinue()
    End Sub
End Class