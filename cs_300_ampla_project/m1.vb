
Public Class Model


    Dim Alloc As Allocations

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

    Private Function Evaluate(ByRef Cur As State, ByVal Last As State, ByVal C As Dictionary(Of String, Connected), ByVal B As Allocations)
        With Cur
            .Env = StateVal(Last.Env, C("Environment"), B)
            .Food = StateVal(Last.Food, C("Food"), B)
            .Inc = StateVal(Last.Inc, C("Income"), B)
            .Pop = StateVal(Last.Pop, C("Population"), B)
        End With
        Return Cur
    End Function

    Public Sub Update()
        With Last
            .Env = Values.Env
            .Food = Values.Food
            .Inc = Values.Inc
            .Pop = Values.Pop
        End With
    End Sub

    Public Sub Iterate(ByVal B As Budget)
        With Alloc
            .cultivation = B.Env_Allocations
            .system = B.Public_Ed_Allocations
            .Industrial = B.Industrial_Allocations
            .Education = B.Pollution_Control_Allocations
            .Pollution = B.Science_Allocations
        End With
        Evaluate(Values, Last, Coeffs, Alloc)

    End Sub






End Class
