Public Class Cell
    Dim Cell_Color As Color
    Dim Cell_pen As Pen
    Dim SideLength As Integer
    Dim Location As Point

    Sub Draw_cell(ByRef graphic_contex As Graphics)
        Dim rec As Rectangle = New Rectangle(Location, New Size(Location))
        graphic_contex.DrawRectangle(Cell_pen, rec)
    End Sub
End Class
