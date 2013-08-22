Imports System.Drawing

Public Class GameForm
    Dim Budgets As Budget
    Dim PState As State
    Dim PlanetMap As Planet_state
    Dim GameModel As Model
    Dim Graph As Graphics
    Dim Rect As Rectangle
    Dim Difficulty As Integer

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
        BudgetForm.ShowDialog()
    End Sub

    'Go back to the main menu
    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        Me.Hide()
        MenuForm.Show()
        MenuForm.Activate()
    End Sub

    'What is the point of New when the Form already exists?
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Graph = Me.CreateGraphics
        Rect = New Rectangle(24, 24, 500, 400)
        GameModel = New Model()
        PlanetMap = New Planet_state(PState, 500, 400)
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
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        'GameModel.Iterate(Budgets)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PlanetMap.increment_number_of_mines()
        PlanetMap.update_state(PState)
        PlanetMap.Display_current_state(Graph, Rect)
    End Sub
End Class
