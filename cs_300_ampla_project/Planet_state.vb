Public Structure State
    Dim Food As Double
    Dim Inc As Double
    Dim Pop As Double
    Dim Env As Double
End Structure

Public Class Planet_state
    Dim initial_state As Map
    Dim current_state As Map

    Sub New(ByVal initial_planet_state As State, ByVal planet_size_x As Integer, ByVal planet_size_y As Integer)
        Me.initial_state = New Map(planet_size_x, planet_size_y, initial_planet_state)
        Me.current_state = New Map(planet_size_x, planet_size_y, initial_planet_state)
        MessageBox.Show("Butts.")
    End Sub

    Sub update_state(ByRef new_state As State)
        current_state.New_map_state(new_state)
    End Sub

    Sub Display_current_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        current_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub

    Sub Display_initial_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        initial_state.Draw_map(graphic_to_display_graph, rectange_window)
    End Sub


End Class
