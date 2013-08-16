Public Class Map
    Dim Cell_Array(,) As Cell
    Dim Graph_Window As Graphics
    Dim Graph_Rectangle As Rectangle
    Dim Map_state As State
    Dim list_of_cells As List(Of Cell)
    Dim num_of_cells As Integer

    Sub New(ByRef Cell_Map_X_dim As Integer, ByRef Cell_Map_Y_dim As Integer, ByRef initial_state As State)
        Dim Cell_Array(Cell_Map_X_dim, Cell_Map_Y_dim) As Cell
        num_of_cells = Cell_Map_X_dim * Cell_Map_Y_dim
        Dim i As Integer
        Dim j As Integer
        While i < Cell_Map_X_dim
            While j < Cell_Map_Y_dim
                list_of_cells.Add(Cell_Array(i, j))
                j = j + 1
            End While
            i = i + 1
        End While
        Map_state = initial_state
    End Sub

    Sub New_map_state(ByRef new_map_state As State)
        Map_state = new_map_state
    End Sub

    Sub Draw_map(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)

    End Sub

End Class
