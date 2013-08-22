
Public Class Model




    Dim Last As State

    Public Values As State

    Dim Coeffs As Dictionary(Of String, Connected)

    Private Sub SetCoeff(ByVal Indicator As String, ByVal Agr As Double, ByVal Sci As Double, ByVal Ind As Double, ByVal Edu As Double, ByVal Pol As Double)
        Dim C As Connected
        With C
            .cultivation = Agr
            .system = Sci
            .Industrial = Ind
            .Education = Edu
            .Pollution = Pol
        End With
        Coeffs.Add(Indicator, C)
    End Sub


    Private Sub InitCoeff()
        Coeffs = New Dictionary(Of String, Connected)
        '   Indicator    Agr,      Sci,        Ind,       Edu,        Pol 
        '        Food   0.0001,   0.0001,    0.0,        0.0,        0.0
        '      Income   0.0,      0.0001,    0.0001,     0.0001,     0.0
        '  Population   0.0003,   0.0001,    0.0,       -0.00012,    0.0
        ' Environment  -0.0001,   0.0,      -0.0002,     0.0001,     0.0001
        '
        SetCoeff("Food", 0.0001, 0.0001, 0.0, 0.0, 0.0)             'indicator for food
        SetCoeff("Income", 0.0, 0.0001, 0.0001, 0.0001, 0.0)        'indicator for income
        SetCoeff("Population", 0.0003, 0.0001, 0.0, -0.00012, 0.0)    'indicator for population
        SetCoeff("Environment", -0.0001, 0.0, -0.0002, 0.0001, 0.0001) 'indicator for environment
    End Sub

    Public Sub New()
        InitCoeff()
    End Sub

    Private Function StateVal(ByVal LastVal As Double, ByVal C As Connected, ByVal B As Allocations) As Double
        Dim Sc As Double
        Sc = (C.cultivation * B.cultivation) +
              (C.Education * B.Education) +
              (C.Industrial * B.Industrial) +
              (C.Pollution * B.Pollution) +
              (C.system * B.system)
        StateVal = (Sc * LastVal) + LastVal
        Return StateVal
    End Function

    Private Sub Evaluate(ByRef Cur As State, ByVal Last As State, ByVal C As Dictionary(Of String, Connected), ByVal B As Allocations)
        With Cur
            .environment = StateVal(Last.environment, C("Environment"), B)
            .Food = StateVal(Last.Food, C("Food"), B)
            .Income = StateVal(Last.Income, C("Income"), B)
            .Population = StateVal(Last.Population, C("Population"), B)
        End With
    End Sub

    Public Sub Update()
        With Last
            .environment = Values.environment
            .Food = Values.Food
            .Income = Values.Income
            .Population = Values.Population
        End With
    End Sub

    '   Public Sub Iterate(ByVal B As Budget)
    '      With Alloc
    '         .Agr = B.Agriculture_Allocation
    '        .Edu = B.Public_Ed_Allocation
    '       .Ind = B.Industrial_Allocation
    '      .Pol = B.Pollution_Control_Allocation
    '      .Sci = B.Science_Allocation
    '  End With
    '  Evaluate(Values, Last_Values, Coeffs, Alloc)
    'End Sub






End Class
