Imports System.Threading
Public Structure State
    Dim Food As Double
    Dim Inc As Double
    Dim Pop As Double
    Dim Env As Double
End Structure

Public Class Planet_state
    Dim initial_state As Map
    Dim current_state As Map
    Dim planet_size_x As Integer
    Dim planet_size_y As Integer

    Sub New(ByVal initial_planet_state As State, ByVal planet_pixel_size_x As Integer, ByVal planet_pixel_size_y As Integer)
        Me.initial_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        Me.current_state = New Map(planet_pixel_size_x, planet_pixel_size_y, initial_planet_state)
        planet_size_x = planet_pixel_size_x
        planet_size_y = planet_pixel_size_y
        current_state.Update_map()
    End Sub

    Sub update_state(ByRef new_state As State)
        current_state.New_map_state(new_state)
        current_state.Update_map()
    End Sub

    Sub Display_current_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        current_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub

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
