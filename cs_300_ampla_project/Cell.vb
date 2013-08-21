' Copyright (c) 2013 Garrison Jensen <garrison.jensen@gmail.com>
Public Class Cell
    Dim Cell_color As Color     ' Cell color
    Dim Cell_pen As Pen         ' Cell pen, should be same color as cell color
    Dim SideLength As Integer   ' Cell is a square, this is its side length
    Dim Location As Point       ' Location of cell

    ' Set side length
    ' INPUT:
    '   new_side_length - New side length of cell
    Sub set_side_length(ByRef new_side_length As Integer)
        SideLength = new_side_length
    End Sub

    ' Get location of cell
    ' OUTPUT:
    '   Point - Contains x and y location of cell
    Function get_location() As Point
        Return Me.Location
    End Function

    ' Set cell color.
    ' INPUT:
    '   new_cell_color - New color for cell.
    Sub Set_cell_color(ByRef new_cell_color As Color)
        Cell_color = new_cell_color
        If IsNothing(Cell_pen) Then
            Cell_pen = New Pen(Brushes.White)
        End If
        Cell_pen.Color = Cell_color
    End Sub

    ' Set cell point.
    ' INPUT:
    '   x_placement - x location of cell.
    '   y_placement - y location of cell.
    Sub Set_cell_point(ByRef x_placement As Integer, ByRef y_placement As Integer)
        Location.X = x_placement
        Location.Y = y_placement
    End Sub

    ' Renders the cell. Color and location must be defined.
    ' INPUT:
    '   graphic_contex - Graphic contex for pixel to draw itself.
    Sub Draw_cell(ByRef graphic_contex As Graphics)
        If Not IsNothing(Location) And Not IsNothing(SideLength) And Not IsNothing(Cell_pen) Then
            Dim rec As Rectangle = New Rectangle(Location.X, Location.Y, SideLength, SideLength)
            graphic_contex.DrawRectangle(Cell_pen, rec)
        End If
    End Sub
End Class
