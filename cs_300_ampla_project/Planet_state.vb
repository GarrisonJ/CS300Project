Structure State
    Dim Food As Double
    Dim Inc As Double
    Dim Pop As Double
    Dim Env As Double
End Structure

Public Class Planet_state
    Dim initial_state As Map
    Dim current_state As Map

    Sub Display_current_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        current_state.Draw(graphic_to_display_graph, rectange_window)
    End Sub

    Sub Display_initial_state(ByRef graphic_to_display_graph As Graphics, ByRef rectange_window As Rectangle)
        initial_state.Draw(graphic_to_display_graph, rectange_window)
    End Sub






End Class
