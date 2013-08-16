Public Class Cell
    Dim Cell_color As Color
    Dim Cell_pen As Pen
    Dim SideLength As Integer
    Dim Location As Point


    Sub Set_cell_color(ByRef new_cell_color As Color)
        Cell_color = new_cell_color
<<<<<<< HEAD
        Cell_pen.Color = Cell_color
    End Sub

    Sub Set_cell_point(ByRef x_placement As Integer, ByRef y_placement As Integer)
        Location.X = x_placement
        Location.Y = y_placement
=======
>>>>>>> 371d889e4c43a3c39014f85c651b667a62b61a32
    End Sub

    Sub Draw_cell(ByRef graphic_contex As Graphics)
        Dim rec As Rectangle = New Rectangle(Location, New Size(Location))
        graphic_contex.DrawRectangle(Cell_pen, rec)
    End Sub
End Class
