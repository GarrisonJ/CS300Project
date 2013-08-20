Public Class MenuForm
    Dim Path As String
    Dim Fn As String
    Dim InGame As Boolean = False
    Dim GameSaved As Boolean = True

    'save the game using the open file dialog
    Private Function SaveGame() As Boolean
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
            Return False
        End If
        'Get associative array from Model
        'Loop to format
        'Save(File)
        GameSaved = True
        Return True
    End Function

    'If the player is in a game, have the continue button show up
    Private Function ShowContinue() As Boolean
        If InGame Then
            ContinueButton.Show()
        Else
            ContinueButton.Hide()
        End If
        Return True
    End Function

    'Wrapper for the save function, handles the user event.
    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If Not SaveGame() Then
            Exit Sub
        End If
    End Sub

    'Loads the game and goes to the game menu
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

    'When the continue button is clicked, the Main Menu is hidden and the Game form is reloaded
    Private Sub ContinueButton_Click(sender As System.Object, e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
        GameForm.Show()
        GameForm.Activate()
    End Sub

    'functions to run when the game first starts.
    Private Sub MenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowContinue()
    End Sub

    'Creates a new game, disposing of the previous game values
    Private Sub NewGameButton_Click(sender As System.Object, e As System.EventArgs) Handles NewGameButton.Click
        Dim Resp As Integer
        If Not GameSaved Then
            Resp = MsgBox("Do you want to save your game first?", MsgBoxStyle.YesNo)
        End If
        If Resp = MsgBoxResult.Yes Then
            SaveGame()
            Exit Sub
        End If
        InGame = True
        Me.Hide()
        GameForm.Dispose()
        BudgetForm.Dispose()
        GameForm.Show()
        Me.Hide()
        GameSaved = False
        GameForm.Activate()
    End Sub

    'Runs these functions when a form becomes the active form.
    Private Sub MenuForm_Activated(sender As Object, e As System.EventArgs) Handles MyBase.Activated
        ShowContinue()
    End Sub

    'Asks if the player wants to save before quitting, then quit.
    Private Sub QuitButton_Click(sender As System.Object, e As System.EventArgs) Handles QuitButton.Click
        Dim Resp As Integer
        If Not GameSaved Then
            Resp = MsgBox("Do you want to save your game first?", MsgBoxStyle.YesNo)
        End If
        If Resp = MsgBoxResult.Yes Then
            SaveGame()
        End If
        GameForm.Dispose()
        BudgetForm.Dispose()
        Me.Close()
    End Sub
End Class