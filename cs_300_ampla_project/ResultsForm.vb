'Jonathan Hong
Public Class ResultsForm
    Dim Rect1 As Rectangle
    Dim Rect2 As Rectangle
    Dim Graph1 As Graphics
    Dim Graph2 As Graphics
    Dim PMap As Planet_state

    'Create a new results window that shows the initial state and ending state
    Sub New(ByRef PlanetMap As Planet_state, ByRef CurrState As State, ByRef InitState As State)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PMap = PlanetMap
        Graph1 = Me.CreateGraphics
        Graph2 = Me.CreateGraphics
        Rect1 = New Rectangle(24, 24, 500, 400)
        Rect2 = New Rectangle(529, 24, 500, 400)
        IEnv.Text = InitState.Env
        IFood.Text = InitState.Food
        IInc.Text = InitState.Inc
        IPop.Text = InitState.Pop
        CEnv.Text = CurrState.Env
        CFood.Text = CurrState.Food
        CInc.Text = CurrState.Inc
        CPop.Text = CurrState.Pop

    End Sub
    'To show the map of initial and ending, press the button
    Private Sub DrawButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawButton.Click
        PMap.Display_current_state(Graph2, Rect2)
        PMap.Display_initial_state(Graph1, Rect1)
    End Sub

    'go back to the menu after finished reviewing.
    Private Sub FinishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishButton.Click
        Me.Close()
    End Sub
End Class