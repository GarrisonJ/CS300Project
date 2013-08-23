' Copyright (c) 2013 Garrison Jensen <garrison.jensen@gmail.com>
Public Class Map
    Dim Cell_Array(,) As Cell           ' Array of cells in map
    Dim Map_state As State              ' Current state of map
    Dim list_of_cells As List(Of Cell)  ' List of cells in map
    Dim list_of_mines As List(Of Mine)  ' List of mines in map

    ' INPUT:
    '   Cell_Map_X_dim - In pixels, width of the map.
    '   Cell_Map_Y_dim - In pixels, hight of the map.
    '   initial_state  - Initial state of map.
    Sub New(ByRef Cell_Map_X_dim As Integer, ByRef Cell_Map_Y_dim As Integer, ByRef initial_state As State)
        Dim Cell_Array(Cell_Map_X_dim, Cell_Map_Y_dim) As Cell
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

    ' INPUT:
    '   Cell_Map_X_dim - In pixels, width of the map.
    '   Cell_Map_Y_dim - In pixels, hight of the map.
    '   initial_state  - Initial state of map.
    '   cell_size      - Side length of cells in pixels.
    Sub New(ByRef Cell_Map_X_dim As Integer, ByRef Cell_Map_Y_dim As Integer, ByRef initial_state As State, ByRef cell_size As Integer)
        Dim Cell_Array(Cell_Map_X_dim, Cell_Map_Y_dim) As Cell
        list_of_cells = New List(Of Cell)
        Dim i As Integer
        Dim j As Integer
        i = 0
        While i < Cell_Map_X_dim
            j = 0
            While j < Cell_Map_Y_dim
                Cell_Array(i, j) = New Cell
                Cell_Array(i, j).Set_cell_point(i, j)
                Cell_Array(i, j).set_side_length(cell_size)
                Cell_Array(i, j).Set_cell_color(Color.Black)
                list_of_cells.Add(Cell_Array(i, j))
                j = j + 1
            End While
            i = i + 1
        End While
        Map_state = initial_state
    End Sub

    ' Change the size of the cell in map.
    ' Input:
    '   new_cell_size - New size of cell in pixels.
    Sub Change_cell_size(ByRef new_cell_size As Integer)
        For Each c In list_of_cells
            c.set_side_length(new_cell_size)
        Next
    End Sub

    ' Update the state of the map.
    ' INPUT:
    '   new_map_state - New state of map.
    Sub New_map_state(ByRef new_map_state As State)
        Map_state = new_map_state
        If Not IsNothing(list_of_mines) Then
            For Each m In list_of_mines
                m.set_toxicity(new_map_state.Env)
            Next
        End If
    End Sub

    ' Add a new mine to the map
    ' INPUT:
    '   location_of_new_mine - Location to place mine on map.
    Sub add_mine_to_map(ByRef location_of_new_mine As Point)
        Dim new_mine As New Mine
        new_mine.set_toxicity(Map_state.Env)
        new_mine.Set_cell_point(location_of_new_mine.X, location_of_new_mine.Y)
        If IsNothing(list_of_mines) Then
            list_of_mines = New List(Of Mine)
        End If
        list_of_mines.Add(new_mine)
    End Sub

    ' Decrement the number of mines on map.
    ' Will remove the last mine that was added.
    ' If no mines exist, then this function does nothing.
    Sub decrement_number_of_mines()
        If Not IsNothing(list_of_mines) Then
            list_of_mines.RemoveAt(list_of_mines.Count - 1)
        End If
    End Sub

    ' Recalculates cell colors based on current state and mine locations.
    Sub Update_map()
        For Each c In list_of_cells
            Dim total_toxicity_level As Double = 0
            If Not IsNothing(list_of_mines) Then
                For Each m In list_of_mines
                    total_toxicity_level += 100 * m.get_toxicity * Math.Pow(0.9, Distance(m.get_location, c.get_location))
                Next
            End If
            c.Set_cell_color(Color.FromArgb(total_toxicity_level Mod 255, Map_state.Food Mod 255, Map_state.Pop Mod 244))
        Next
    End Sub

    ' Draw map
    ' INPUT:
    '   graphic_to_display_graph - Graphics contex for map to display
    '   rectange_window          - This rectange defines where the map will be drawn.
    Sub Draw_map(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        graphic_to_display_graph.SetClip(rectange_window)
        For Each c In list_of_cells
            c.Draw_cell(graphic_to_display_graph)
        Next
    End Sub

    ' Returns a copy of the list of mines.
    Function return_list_of_mines() As List(Of Mine)
        Dim list_of_mines_to_be_returned As New List(Of Mine)
        If Not IsNothing(list_of_mines) Then
            For Each m In list_of_mines
                list_of_mines_to_be_returned.Add(m.Clone())
            Next
        End If
        Return list_of_mines_to_be_returned
    End Function

    ' Private: Calculate the distance between two points
    ' INPUT: 
    '   a - Point a
    '   b - Point b
    Private Function Distance(ByRef a As Point, ByRef b As Point) As Double
        Dim x, y As Double

        x = Math.Abs(a.X - b.X)
        y = Math.Abs(a.Y - b.Y)

        Distance = Math.Sqrt((x * x) + (y * y))
    End Function

End Class
