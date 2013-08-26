Public Class ResultsForm
    Dim Rect1 As Rectangle
    Dim Rect2 As Rectangle
    Dim Graph1 As Graphics
    Dim Graph2 As Graphics
    Dim PMap As Planet_state
    Sub New(ByRef PlanetMap As Planet_state)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PMap = PlanetMap
        Graph1 = Me.CreateGraphics
        Graph2 = Me.CreateGraphics
        Rect1 = New Rectangle(524, 24, 500, 400)
        Rect2 = New Rectangle(24, 24, 500, 400)
    End Sub

    Private Sub DrawButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawButton.Click
        PMap.Display_current_state(Graph2, Rect2)
        PMap.Display_initial_state(Graph1, Rect1)
    End Sub

    Private Sub FinishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishButton.Click
        Me.Close()
    End Sub
End Class