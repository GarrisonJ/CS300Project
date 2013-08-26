'Jonathan Hong
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class MenuForm
    Dim Pth As String
    Dim Fn As String
    Dim Fp As String
    Dim InGame As Boolean = False
    Dim GameSaved As Boolean = True
    Dim GameWindow As GameForm
    Dim DiffWindow As DifficultyForm
    Dim GameOver As Boolean = False

    'set a game over state
    Public Sub EndGame()
        GameOver = True
        GameWindow.Dispose()
    End Sub

    'Loads the game and goes to the game menu
    Private Sub LoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadButton.Click
        Dim MyReader As Microsoft.VisualBasic.FileIO.TextFieldParser
        Dim Resp As Integer
        Dim LoadString As String()
        Dim VData As String()
        Dim MData As String()
        Dim CData As String()

        'If game is not saved, prompt to save.
        If Not GameSaved Then
            Resp = MsgBox("Do you want to save your game first?", MsgBoxStyle.YesNo)
        End If
        If Resp = MsgBoxResult.Yes Then
            If Not SaveGame() Then
                Exit Sub
            End If
        End If
        If Not IsNothing(GameWindow) Then
            GameWindow.Dispose()
        End If

        'initialize load dialog params
        If Not (IsNothing(Pth)) Then
            LoadDialog.InitialDirectory = Pth
        Else
            LoadDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        End If
        If Not (IsNothing(Fn)) Then
            LoadDialog.FileName = Fn
        End If
        LoadDialog.Filter = "txt files (*.txt)|*.txt"
        LoadDialog.RestoreDirectory = True

        Resp = LoadDialog.ShowDialog()
        'If they cancel the load, don't do anything
        If Resp = DialogResult.Cancel Then
            Exit Sub
        End If
        GameWindow = New GameForm()
        'Parse the text file with semi-colon delimiter
        Fp = LoadDialog.FileName
        Fn = Path.GetFileName(Fp)
        Pth = Fp.Replace(Fn, "")
        MyReader = New TextFieldParser(Fp)
        MyReader.SetDelimiters(";")
        'group 0 is coordinates, group 1 is state, group 2 is budget
        LoadString = MyReader.ReadFields()
        If LoadString.GetLength(0) <> 3 Then
            MsgBox("The file you are trying to load is invalid. Please try again.")
            Exit Sub
        End If
        VData = Split(LoadString(0).Substring(0, LoadString(0).Length - 1), ",")
        MData = Split(LoadString(1), ",")
        CData = Split(LoadString(2), ",")
        If Not GameWindow.LoadGame(VData, MData, CData) Then
            Exit Sub
        End If
        Me.Hide()
        GameWindow.ShowDialog()
        GameSaved = False
        Me.Show()
    End Sub

    'save the game using the open file dialog
    Private Function SaveGame() As Boolean
        If GameWindow.IsDisposed() Or IsNothing(GameWindow) Then
            MsgBox("There is no current game to save. Please start a new game or load a game.")
            GameSaved = True
            Return False
        End If
        Dim Resp As Integer
        Dim FileContents As String
        'initialize save dialog params
        If Not (IsNothing(Pth)) Then
            SaveDialog.InitialDirectory = Pth
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
        Fp = SaveDialog.FileName
        Fn = Path.GetFileName(Fp)
        Pth = Fp.Replace("\" + Fn, "")

        'Save the file to the given text file
        FileContents = GameWindow.GetSave()
        My.Computer.FileSystem.WriteAllText(Fp, FileContents, False)
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
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If Not SaveGame() Then
            Exit Sub
        End If
    End Sub

    'When the continue button is clicked, the Main Menu is hidden and the Game form is reloaded
    Private Sub ContinueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueButton.Click
        Me.Hide()
        GameWindow.ShowDialog()
        Me.Show()
    End Sub

    'functions to run when the game first starts.
    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowContinue()
    End Sub

    'Creates a new game, disposing of the previous game values
    Private Sub NewGameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameButton.Click
        Dim Resp As Integer
        If Not GameSaved Then
            Resp = MsgBox("Do you want to save your game first?", MsgBoxStyle.YesNo)
        End If
        If Resp = MsgBoxResult.Yes Then
            If Not SaveGame() Then
                Exit Sub
            End If
        End If
        Me.Hide()
        If Not IsNothing(GameWindow) Then
            GameWindow.Dispose()
        End If
        GameWindow = New GameForm()
        DiffWindow = New DifficultyForm(GameWindow)
        DiffWindow.ShowDialog()
        If Not GameWindow.IsDisposed() Or IsNothing(GameWindow) Then
            GameWindow.ShowDialog()
            GameSaved = False
            InGame = True
        End If
        Me.Show()
    End Sub

    'This is getting activated many times for some reason.
    Private Sub MenuForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If GameOver Then
            InGame = False
        End If
        Me.ShowContinue()
    End Sub

    'Asks if the player wants to save before quitting, then quit.
    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Dim Resp As Integer
        If Not GameSaved Then
            Resp = MsgBox("Do you want to save your game first?", MsgBoxStyle.YesNo)
        End If
        If Resp = MsgBoxResult.Yes Then
            If Not SaveGame() Then
                Exit Sub
            End If
        End If
        GameWindow.Dispose()
        If Not IsNothing(DiffWindow) Then
            DiffWindow.Dispose()
        End If
        Me.Close()
    End Sub
End Class