Public Class Map
    Dim Cell_Array(,) As Cell
    Dim Graph_Window As Graphics
    Dim Graph_Rectangle As Rectangle
    Dim Map_state As State
    Dim list_of_cells As List(Of Cell)
    Dim list_of_mines As List(Of Mine)
    Dim num_of_cells As Integer

    Sub New(ByRef Cell_Map_X_dim As Integer, ByRef Cell_Map_Y_dim As Integer, ByRef initial_state As State)
        Dim Cell_Array(Cell_Map_X_dim, Cell_Map_Y_dim) As Cell
        num_of_cells = Cell_Map_X_dim * Cell_Map_Y_dim
        list_of_cells = New List(Of Cell)
        Dim i As Integer
        Dim j As Integer
        i = 0
        While i < Cell_Map_X_dim
            j = 0
            While j < Cell_Map_Y_dim
                Cell_Array(i, j) = New Cell
                Cell_Array(i, j).Set_cell_point(i, j)
                Cell_Array(i, j).set_side_length(1)
                Cell_Array(i, j).Set_cell_color(Color.Black)
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

    Sub add_mine_to_map(ByRef location_of_new_mine As Point, ByRef toxicity_level As Integer)
        Dim new_mine As New Mine
        new_mine.set_toxicity(toxicity_level)
        new_mine.Set_cell_point(location_of_new_mine.X, location_of_new_mine.Y)
        If IsNothing(list_of_mines) Then
            list_of_mines = New List(Of Mine)
        End If
        list_of_mines.Add(new_mine)
    End Sub


    Sub Update_map()
        For Each c In list_of_cells
            c.Set_cell_color(Color.FromArgb(Map_state.Env Mod 255, Map_state.Food Mod 255, Map_state.Pop Mod 244))
        Next
    End Sub


    Sub Draw_map(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        Graph_Window = graphic_to_display_graph
        Graph_Window.SetClip(rectange_window)
        For Each c In list_of_cells
            c.Draw_cell(graphic_to_display_graph)
        Next
    End Sub

End Class
