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
        If Not IsNothing(list_of_mines) Then
            For Each m In list_of_mines
                m.set_toxicity(new_map_state.Env)
            Next
        End If
    End Sub

    Sub add_mine_to_map(ByRef location_of_new_mine As Point)
        Dim new_mine As New Mine
        new_mine.set_toxicity(0)
        new_mine.Set_cell_point(location_of_new_mine.X, location_of_new_mine.Y)
        If IsNothing(list_of_mines) Then
            list_of_mines = New List(Of Mine)
        End If
        list_of_mines.Add(new_mine)
    End Sub

    ' Decrement the number of mines on map
    ' Will remove the last mine that was added
    ' If no mines exist, then this function does nothing
    Sub decrement_number_of_mines()
        If Not IsNothing(list_of_mines) Then
            list_of_mines.RemoveAt(list_of_mines.Count)
        End If
    End Sub

    Sub Update_map()
        For Each c In list_of_cells
            Dim total_toxicity_level As Double = 0
            If Not IsNothing(list_of_mines) Then
                For Each m In list_of_mines
                    total_toxicity_level += m.get_toxicity * Math.Pow(0.2, Distance(m.get_location, c.get_location))
                Next
            End If
            c.Set_cell_color(Color.FromArgb(total_toxicity_level Mod 255, Map_state.Food Mod 255, Map_state.Pop Mod 244))
        Next
    End Sub


    Sub Draw_map(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        Graph_Window = graphic_to_display_graph
        Graph_Window.SetClip(rectange_window)
        For Each c In list_of_cells
            c.Draw_cell(graphic_to_display_graph)
        Next
    End Sub

    Private Function Distance(ByRef a As Point, ByRef b As Point) As Double
        Dim x, y As Double

        x = Math.Abs(a.X - b.X)
        y = Math.Abs(a.Y - b.Y)

        Distance = Math.Sqrt((x * x) + (y * y))
    End Function

End Class
