Public Class Map
    Dim Cell_Array(,) As Cell
    Dim Graph_Window As Graphics
    Dim Graph_Rectangle As Rectangle

    Sub New(ByRef Cell_Map_x As Integer, ByRef Cell_Map_y As Integer, ByRef WindowGraph As Graphics, ByRef Rectangle_for_map As Rectangle)
        Dim Cell_Array(Cell_Map_x, Cell_Map_y) As Cell
        Graph_Window = WindowGraph
        Graph_Rectangle = Rectangle_for_map
    End Sub

    Sub Draw()

    End Sub

End Class
