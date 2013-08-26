' Copyright (c) 2013 Garrison Jensen <garrison.jensen@gmail.com>
Imports System.Threading
Imports System.String
Public Class Planet_state
    Dim initial_state As Map        ' Initial state of the map. 
    Dim current_state As Map        ' Current state of the map.
    Dim planet_size_x As Integer    ' Number of pixels x axis
    Dim planet_size_y As Integer    ' Number of pixels y axis

    ' Constructor
    ' Default cell size is 1.
    ' INPUT:
    '   initial_planet_state - Initial state of the map.
    '   planet_pixel_size_x  - In pixels, width of the map.
    '   planet_pixel_size_y  - In pixels, hight of the map
    Sub New(ByVal initial_planet_state As State, ByVal planet_pixel_size_x As Integer, ByVal planet_pixel_size_y As Integer)
        Me.initial_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        Me.current_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        planet_size_x = planet_pixel_size_x
        planet_size_y = planet_pixel_size_y
        current_state.Update_map()
    End Sub

    ' INPUT:
    '   initial_planet_state - Initial state of the map.
    '   planet_pixel_size_x  - In pixels, width of the map.
    '   planet_pixel_size_y  - In pixels, hight of the map.
    '   cell_size            - Side length of cells in pixels.
    Sub New(ByVal initial_planet_state As State, ByVal planet_pixel_size_x As Integer, ByVal planet_pixel_size_y As Integer, ByRef cell_size As Integer)
        Me.initial_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state, cell_size)
        Me.current_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state, cell_size)
        planet_size_x = planet_pixel_size_x
        planet_size_y = planet_pixel_size_y
        current_state.Update_map()
    End Sub

    ' Will update the state of the map.
    ' INPUT:
    '   new_state - New state for the map.
    Sub update_state(ByVal new_state As State)
        current_state.New_map_state(new_state)
        current_state.Update_map()
    End Sub

    ' Renders the current map.
    ' INPUT:
    '   graphic_to_display_graph - Graphics contex for map to display.
    '   rectange_window          - This rectange defines where the map will be drawn.
    Sub Display_current_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        current_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub

    ' Renders the initial map.
    ' INPUT:
    '   graphic_to_display_graph - Graphics contex for map to display.
    '   rectange_window          - This rectange defines where the map will be drawn.
    Sub Display_initial_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        initial_state.Update_map()
        initial_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub


    ' Increment the number of mines on both maps by 1.
    ' Both mines will be placed at same locations.
    ' The mine will be added at the given point.
    ' INPUT:
    '   add_mine_at_this_point - The point were the mine will be added.
    Sub increment_number_of_mines_on_both_maps(ByRef add_mine_at_this_point As Point)
        current_state.add_mine_to_map(add_mine_at_this_point)
    End Sub

    ' Increment the number of mines on both maps by 1.
    ' Both mines will be placed at same locations.
    Sub increment_number_of_mines_on_both_maps()
        Thread.Sleep(20) ' To get a new random number, the time seed must be significanty different 
        Dim rand As New Random(CInt(Date.Now.Ticks And &HFFFF))
        Dim RanXLoc As Integer = rand.Next Mod planet_size_x
        Dim RanYLoc As Integer = rand.Next Mod planet_size_y
        initial_state.add_mine_to_map(New Point(RanXLoc, RanYLoc))
        current_state.add_mine_to_map(New Point(RanXLoc, RanYLoc))
    End Sub


    ' Increment the number of mines on initial map by 1
    Sub increment_number_of_mines_on_initial_map()
        Thread.Sleep(20) ' To get a new random number, the time seed must be significanty different 
        Dim rand As New Random(CInt(Date.Now.Ticks And &HFFFF))
        Dim RanXLoc As Integer = rand.Next Mod planet_size_x
        Dim RanYLoc As Integer = rand.Next Mod planet_size_y
        initial_state.add_mine_to_map(New Point(RanXLoc, RanYLoc))
    End Sub


    ' Increment the number of mines on current map by 1
    Sub increment_number_of_mines_on_current_map()
        Thread.Sleep(20) ' To get a new random number, the time seed must be significanty different 
        Dim rand As New Random(CInt(Date.Now.Ticks And &HFFFF))
        Dim RanXLoc As Integer = rand.Next Mod planet_size_x
        Dim RanYLoc As Integer = rand.Next Mod planet_size_y
        current_state.add_mine_to_map(New Point(RanXLoc, RanYLoc))
    End Sub

    ' Increment the number of mines on current map by 1.
    ' The mine will be added at the given point.
    ' INPUT:
    '   add_mine_at_this_point - The point were the mine will be added.
    Sub increment_number_of_mines_on_current_map(ByRef add_mine_at_this_point As Point)
        current_state.add_mine_to_map(add_mine_at_this_point)
    End Sub

    ' Increment the number of mines on initial map by 1.
    ' The mine will be added at the given point.
    ' INPUT:
    '   add_mine_at_this_point - The point were the mine will be added.
    Sub increment_number_of_mines_on_initial_map(ByRef add_mine_at_this_point As Point)
        initial_state.add_mine_to_map(add_mine_at_this_point)
    End Sub


    ' Decrement the number of mines on current map by 1
    Sub decrement_number_of_mines()
        current_state.decrement_number_of_mines()
    End Sub


    Sub Set_cell_size(ByRef cell_side_length_in_pixels As Integer)
        current_state.Change_cell_size(cell_side_length_in_pixels)
        initial_state.Change_cell_size(cell_side_length_in_pixels)
    End Sub


    ' Returns location of mines on current map as a string.
    ' Example:
    '   If there are three mines at the following locations: (34,1), (99,34), and (132, 54)
    '   then the following string will be returned: '34,1,99,34,132,54,'
    '   Will return a empty string if no mines exist
    Function location_of_current_mines_as_a_string() As String

        Dim list_of_mines As List(Of Mine) = current_state.return_list_of_mines()
        Dim string_to_return As New String("")

        If list_of_mines.Count <> 0 Then
            For Each m In list_of_mines
                string_to_return += CStr(m.get_location.X)
                string_to_return += ","
                string_to_return += CStr(m.get_location.Y)
                string_to_return += ","
            Next
        End If

        Return string_to_return
    End Function

    ' Returns location of mines on initial map as a string.
    ' Example:
    '   If there are three mines at the following locations: (34,1), (99,34), and (132, 54)
    '   then the following string will be returned: '34,1,99,34,132,54,'
    '   Will return a empty string if no mines exist
    Function location_of_initial_mines_as_a_string() As String

        Dim list_of_mines As List(Of Mine) = initial_state.return_list_of_mines()
        Dim string_to_return As New String("")

        If list_of_mines.Count <> 0 Then
            For Each m In list_of_mines
                string_to_return += CStr(m.get_location.X)
                string_to_return += ","
                string_to_return += CStr(m.get_location.Y)
                string_to_return += ","
            Next
        End If

        Return string_to_return
    End Function

End Class
