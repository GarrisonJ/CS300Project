Public Class CustomForm
    Dim GameWindow As GameForm
    Dim CustomState As State

    Sub New(ByRef OGameForm As GameForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GameWindow = OGameForm
    End Sub

    Private Sub AcceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptButton.Click
        Dim StringList() As String = {TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text}
        'Checks if the input values are Integer, adds them to the current budget list.
        'Returns True on success or False if values are not integers.
        For I As Integer = LBound(StringList) To UBound(StringList)
            If String.IsNullOrEmpty(StringList(I)) Then
                StringList(I) = "0"
            End If
            If Not IsNumeric(StringList(I)) Then
                MsgBox("Please Enter numeric values only.")
                Exit Sub
            End If
            If CDbl(StringList(I)) < 0 Then
                MsgBox("Negative values not allowed. Try Again.")
                Exit Sub
            End If
        Next I
        CustomState.Env = CDbl(StringList(0))
        CustomState.Pop = CDbl(StringList(1))
        CustomState.Food = CDbl(StringList(2))
        CustomState.Inc = CDbl(StringList(3))
        GameWindow.SetState(CustomState)
        GameWindow.SetInitialState(CustomState)
        GameWindow.CreatePlanetMap()
        GameWindow.SetMines(CInt(StringList(4)))
        Me.Close()
    End Sub
End Class