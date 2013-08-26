Public Class BudgetForm
    Dim StartBudget As Integer = 100
    Dim RemBudget As Integer = 100
    Dim BudgetList() As Integer = {0, 0, 0, 0, 0}
    Dim PrevBudget() As Integer = {0, 0, 0, 0, 0}
    Dim GameWindow As GameForm

    Public Sub SetPrevBudget(ByVal Outside As Budget)
        PrevBudget(0) = Outside.Agriculture
        PrevBudget(1) = Outside.Science
        PrevBudget(2) = Outside.Industry
        PrevBudget(3) = Outside.Education
        PrevBudget(4) = Outside.Pollution
    End Sub

    Public Function GetPrevBudget() As Array
        Return BudgetList
    End Function

    'Initialize a new BudgetForm
    Sub New(ByRef GW As GameForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GameWindow = GW
    End Sub

    Sub New(ByRef GW As GameForm, ByVal OldFunds As Integer, ByVal OldBudget As Budget)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GameWindow = GW
        StartBudget = OldFunds
        RemBudget = StartBudget
        PrevBudget = {OldBudget.Agriculture, OldBudget.Science, OldBudget.Industry, OldBudget.Education, OldBudget.Pollution}
    End Sub

    Public Function GetPrevFunds() As Integer
        Return RemBudget
    End Function

    'This function takes an integer array and overwrites it with the current values in the text boxes
    Private Function SetBudgetVals(ByRef List() As Integer) As Boolean
        Dim StringList() As String = {RedBudget.Text, BlueBudget.Text, OrangeBudget.Text, YellowBudget.Text, GreenBudget.Text}
        'Checks if the input values are Integer, adds them to the current budget list.
        'Returns True on success or False if values are not integers.
        For I As Integer = LBound(StringList) To UBound(StringList)
            If String.IsNullOrEmpty(StringList(I)) Then
                StringList(I) = "0"
            End If
            If Not IsNumeric(StringList(I)) Then
                Return False
            End If
        Next I
        For I As Integer = LBound(StringList) To UBound(StringList)
            List(I) = CInt(StringList(I))
        Next
        Return True
    End Function

    'Only resets the current form's budget
    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        RedBudget.Text = "0"
        BlueBudget.Text = "0"
        OrangeBudget.Text = "0"
        YellowBudget.Text = "0"
        GreenBudget.Text = "0"
        RemainingBudget.Text = StartBudget
        SetBudgetVals(BudgetList)
    End Sub

    Public Sub CurrToPrev()
        PrevBudget = BudgetList
    End Sub

    'calculates the reamining budget
    Private Function CalcRem(ByRef List() As Integer) As Integer
        RemBudget = StartBudget
        For Each Budget In List
            RemBudget -= Budget
        Next Budget
        Return RemBudget
    End Function

    'This event will check the text boxes for integer, check if enough funds, set Budget.
    Private Sub SaveBudgetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBudgetButton.Click
        If Not SetBudgetVals(BudgetList) Then
            MsgBox("The values you entered are invalid. Please try again.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'Check if the funds allocated is over max budget
        CalcRem(BudgetList)

        If RemBudget < 0 Then
            MsgBox("The values you entered are greater than the allowed budget. Please try again.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        RemainingBudget.Text = Str(RemBudget)
        GameWindow.SetBudget(BudgetList)
    End Sub

    'When the exit button is clicked, this function will check if there are valid values, if player has any remaining budget,
    'and if the player wants to save changes to their budget.
    Private Sub ExitBudgetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBudgetButton.Click
        Dim Res As Integer
        Dim Resp As Integer
        Dim SavedBudget() As Integer
        Dim TempList() As Integer = {0, 0, 0, 0, 0}

        'Grab current budget values, exit if invalid values
        If Not SetBudgetVals(TempList) Then
            Exit Sub
        End If
        'Check if there is any remaining budget left
        RemBudget = CalcRem(TempList)
        If RemBudget > 0 Then
            Res = MsgBox("You still have some Budget to allocate, do you want to continue exiting?", MsgBoxStyle.YesNo)
            If Res <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        'Check if the current values are different from the last saved budget
        SavedBudget = GameWindow.GetBudget()
        For I As Integer = LBound(SavedBudget) To UBound(SavedBudget)
            If SavedBudget(I) <> TempList(I) Then
                Resp = MsgBox("You have unsaved budget changes, do you want to save first? (Unsaved changes will be lost).", MsgBoxStyle.YesNo)
                If Resp = MsgBoxResult.Yes Then
                    GameWindow.SetBudget(TempList)
                End If
                Exit For
            End If
        Next I
        'Close window if all above satisfied
        Me.Close()
    End Sub

    'Initialize values for the budget form based on most recently saved values. Calculate Remaining Budget
    Private Sub BudgetForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Temp() As Integer = GameWindow.GetBudget()
        For I As Integer = 0 To 4
            BudgetList(I) = Temp(I)
        Next
        RedBudget.Text = BudgetList(0)
        BlueBudget.Text = BudgetList(1)
        OrangeBudget.Text = BudgetList(2)
        YellowBudget.Text = BudgetList(3)
        GreenBudget.Text = BudgetList(4)
        SetBudgetVals(BudgetList)
        RemBudget = CalcRem(BudgetList)

        PrevAgri.Text = PrevBudget(0)
        PrevSci.Text = PrevBudget(1)
        PrevInd.Text = PrevBudget(2)
        PrevEdu.Text = PrevBudget(3)
        PrevPol.Text = PrevBudget(4)

        If RemBudget < 0 Then
            MsgBox("The values you entered are greater than the allowed budget. Please try again.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        RemainingBudget.Text = Str(RemBudget)
    End Sub
End Class