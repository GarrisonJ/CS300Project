﻿' Copyright (c) 2013 Garrison Jensen <garrison.jensen@gmail.com>
Imports System.Threading

Public Class Planet_state
    Dim initial_state As Map        ' Initial state of the map. 
    Dim current_state As Map        ' Current state of the map.
    Dim planet_size_x As Integer    ' Number of pixels x axis
    Dim planet_size_y As Integer    ' Number of pixels y axis

    ' INPUT:
    '   initial_planet_state - Initial state of the map.
    '   planet_pixel_size_x  - In pixels, width of the map.
    '   planet_pixel_size_y  - In pixels, length of the map
    Sub New(ByVal initial_planet_state As State, ByVal planet_pixel_size_x As Integer, ByVal planet_pixel_size_y As Integer)
        Me.initial_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        Me.current_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        planet_size_x = planet_pixel_size_x
        planet_size_y = planet_pixel_size_y
        current_state.Update_map()
    End Sub

    ' Will update the state of the map.
    ' INPUT:
    '   new_state - New state for the map.
    Sub update_state(ByRef new_state As State)
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
        initial_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub

    ' Increment the number of mines on current map by 1
    Sub increment_number_of_mines()
        Thread.Sleep(20) ' To get a new random number, the time seed must be significanty different 
        Dim rand As New Random(CInt(Date.Now.Ticks And &HFFFF))
        Dim RanXLoc As Integer = rand.Next Mod planet_size_x
        Dim RanYLoc As Integer = rand.Next Mod planet_size_y
        current_state.add_mine_to_map(New Point(RanXLoc, RanYLoc))
    End Sub

    ' Decrement the number of mines on current map by 1
    Sub decrement_number_of_mines()
        current_state.decrement_number_of_mines()
    End Sub

End Class
