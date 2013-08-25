Imports System.Drawing

Public Class GameForm
    Dim BudgWindow As BudgetForm
    Dim Budgets As Budget
    Dim PState As State
    Dim PlanetMap As Planet_state
    Dim GameModel As Model
    Dim Graph As Graphics
    Dim Rect As Rectangle
    Dim RoundNum As Integer

    'Constructor for when the form is created, initialize values.
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Graph = Me.CreateGraphics
        Rect = New Rectangle(24, 24, 500, 400)
        GameModel = New Model()
        PlanetMap = New Planet_state(PState, 500, 400)
        BudgWindow = New BudgetForm(Me)
        RoundNum = 1
    End Sub

    'Sets the number of mines to draw
    Public Sub SetMines(ByRef NumMines As Integer)
        For I As Integer = 1 To NumMines
            PlanetMap.increment_number_of_mines()
        Next
    End Sub

    'Checks the 3 data sets given for valid data, then sets each Class's values.
    Public Function LoadGame(ByRef ViewData As String(), ByRef ModelData As String(), ByRef ControllerData As String()) As Boolean
        'Check if valid number of entries
        If ViewData.GetLength(0) Mod 2 <> 0 Then
            MsgBox("You have an invalid number of coordinates. Please try again.")
            Return False
        ElseIf ModelData.GetLength(0) <> 4 Then
            MsgBox("You Have an invalid number of states. Please try again.")
            Return False
        ElseIf ControllerData.GetLength(0) <> 5 Then
            MsgBox("You have an invalid number of budgets. Please try again.")
            Return False
        End If

        'Loop through each coordinate
        For I As Integer = ViewData.GetLowerBound(0) To ViewData.GetUpperBound(0) Step 2
            Dim XValStr As String = ViewData(I)
            Dim YValStr As String = ViewData(I + 1)
            If Not IsNumeric(XValStr) And IsNumeric(YValStr) Then
                MsgBox("The file you loaded as invalid values. Please try again.")
                Return False
            End If
            If CDbl(XValStr) < 0 Or CDbl(YValStr) < 0 Then
                MsgBox("The file you loaded as invalid values. Please try again.")
                Return False
            End If
            Dim Temp = New Point(CDbl(XValStr), CDbl(YValStr))
            PlanetMap.increment_number_of_mines(Temp)
        Next

        'check each state value
        For I As Integer = 0 To 3
            If Not IsNumeric(ModelData(I)) Then
                MsgBox("You have invalid state values. Please try again.")
                Return False
            End If
            If CDbl(ModelData(I)) < 0 Then
                MsgBox("You have invalid state values. Please try again.")
                Return False
            End If
        Next
        PState.Env = CDbl(ModelData(0))
        PState.Food = CDbl(ModelData(1))
        PState.Inc = CDbl(ModelData(2))
        PState.Pop = CDbl(ModelData(3))

        'check each budget value
        For I As Integer = 0 To 4
            If Not IsNumeric(ControllerData(I)) Then
                MsgBox("You have invalid budget values. Please try again")
                Return False
            End If
            If CDbl(ControllerData(I)) < 0 Then
                MsgBox("You have invalid budget values. Please try again")
                Return False
            End If
        Next
        Budgets.Agriculture = CDbl(ControllerData(0))
        Budgets.Education = CDbl(ControllerData(1))
        Budgets.Industry = CDbl(ControllerData(2))
        Budgets.Pollution = CDbl(ControllerData(3))
        Budgets.Science = CDbl(ControllerData(4))
        Return True
    End Function

    'Gets the initial state, current state, budget, and mine locations and formats into string
    Public Function GetSave() As String
        Dim Temp As String = ""
        Temp += PlanetMap.location_of_mines_as_a_string() + ";"
        Temp += CStr(PState.Env) + "," + CStr(PState.Food) + "," + CStr(PState.Inc) + "," + CStr(PState.Pop) + ";"
        Temp += CStr(Budgets.Agriculture) + "," + CStr(Budgets.Education) + "," + CStr(Budgets.Industry) + "," + CStr(Budgets.Pollution) + "," + CStr(Budgets.Science)
        Return Temp
    End Function

    'Given a state structure, the old state will be overwritten
    Public Sub SetState(ByVal newState As State)
        PState = newState
    End Sub

    'Functions
    'function takes in an array of integers and copies to the local budget
    Public Sub SetBudget(ByRef Values() As Integer)
        Budgets.Agriculture = Values(0)
        Budgets.Education = Values(1)
        Budgets.Industry = Values(2)
        Budgets.Pollution = Values(3)
        Budgets.Science = Values(4)
    End Sub

    'get function for getting the currently set budget
    Public Function GetBudget() As Array
        Dim Temp() As Integer = {Budgets.Agriculture, Budgets.Education, Budgets.Industry, Budgets.Pollution, Budgets.Science}
        Return Temp
    End Function

    'Events
    'Show the budget form
    Private Sub BudgetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Budget.Click
        BudgWindow.ShowDialog()
    End Sub

    'Go back to the main menu
    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        Me.Hide()
        MenuForm.Show()
        MenuForm.Activate()
    End Sub

    'initialize variables while the form loads
    Private Sub GameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GameModel.Values.Env = PState.Env
        GameModel.Values.Food = PState.Food
        GameModel.Values.Inc = PState.Inc
        GameModel.Values.Pop = PState.Pop
        GameModel.Update()

        EnvNum.Text = PState.Env
        FoodNum.Text = PState.Food
        IncNum.Text = PState.Inc
        PopNum.Text = PState.Pop

        RoundLabel.Text = RoundNum
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        GameModel.Iterate(Budgets)
        RoundNum += 1
        RoundLabel.Text = RoundNum
        If RoundNum = 5 Then

        End If
    End Sub

    'Kept the draw button since could not figure out how to make the map load when the form loaded.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PlanetMap.update_state(PState)
        PlanetMap.Display_current_state(Graph, Rect)
    End Sub
End Class
