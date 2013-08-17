Public Class Cell
    Dim Cell_color As Color
    Dim Cell_pen As Pen
    Dim SideLength As Integer
    Dim Location As Point

    Sub set_side_length(ByRef new_side_length As Integer)
        SideLength = new_side_length
    End Sub

    Sub Set_cell_color(ByRef new_cell_color As Color)
        Cell_color = new_cell_color
        If IsNothing(Cell_pen) Then
            Cell_pen = New Pen(Brushes.White)
        End If
        Cell_pen.Color = Cell_color
    End Sub

    Sub Set_cell_point(ByRef x_placement As Integer, ByRef y_placement As Integer)
        Location.X = x_placement
        Location.Y = y_placement
    End Sub

    Sub Draw_cell(ByRef graphic_contex As Graphics)
        Dim rec As Rectangle = New Rectangle(Location.X, Location.Y, SideLength, SideLength)
        graphic_contex.DrawRectangle(Cell_pen, rec)
    End Sub
End Class
