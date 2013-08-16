Public Class Cell
    Dim Cell_color As Color
    Dim Cell_pen As Pen
    Dim SideLength As Integer
    Dim Location As Point


    Sub Set_cell_color(ByRef new_cell_color As Color)
        Cell_color = new_cell_color
        Cell_pen.Color = Cell_color
    End Sub

    Sub Draw_cell(ByRef graphic_contex As Graphics)
        Dim rec As Rectangle = New Rectangle(Location, New Size(Location))
        graphic_contex.DrawRectangle(Cell_pen, rec)
    End Sub
End Class
