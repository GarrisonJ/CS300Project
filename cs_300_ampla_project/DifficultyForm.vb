Public Class DifficultyForm
    Dim DiffState As State
    Dim GameWindow As GameForm
    Dim CustomWin As CustomForm

    Sub New(ByRef temp As GameForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GameWindow = temp
        CustomWin = New CustomForm(GameWindow)
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub EasyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyButton.Click
        DiffState.Env = 150
        DiffState.Food = 150
        DiffState.Inc = 150
        DiffState.Pop = 150
        GameWindow.SetState(DiffState)
        GameWindow.SetInitialState(DiffState)
        GameWindow.CreatePlanetMap()
        GameWindow.SetMines(8)
        Me.Close()
    End Sub

    Private Sub MediumButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumButton.Click
        DiffState.Env = 100
        DiffState.Food = 100
        DiffState.Inc = 100
        DiffState.Pop = 100
        GameWindow.SetState(DiffState)
        GameWindow.SetInitialState(DiffState)
        GameWindow.CreatePlanetMap()
        GameWindow.SetMines(4)
        Me.Close()
    End Sub

    Private Sub HardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardButton.Click
        DiffState.Env = 50
        DiffState.Food = 50
        DiffState.Inc = 50
        DiffState.Pop = 50
        GameWindow.SetState(DiffState)
        GameWindow.SetInitialState(DiffState)
        GameWindow.CreatePlanetMap()
        GameWindow.SetMines(2)
        Me.Close()
    End Sub

    Private Sub CustomButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomButton.Click
        CustomWin.ShowDialog()
        Me.Close()
    End Sub
End Class