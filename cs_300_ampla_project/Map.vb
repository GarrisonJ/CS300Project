Public Class Map
    Dim Cell_Array(,) As Cell
    Dim Graph_Window As Graphics
    Dim Graph_Rectangle As Rectangle
    Dim Map_state As State

    Sub New(ByRef Cell_Map_X_dim As Integer, ByRef Cell_Map_Y_dim As Integer, ByRef initial_state As State)
        Dim Cell_Array(Cell_Map_X_dim, Cell_Map_Y_dim) As Cell
        Map_state = initial_state
    End Sub

    Sub Draw(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)

    End Sub

End Class
