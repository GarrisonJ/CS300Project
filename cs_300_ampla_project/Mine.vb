' Copyright (c) 2013 Garrison Jensen <garrison.jensen@gmail.com>

' A mine is a cell with a toxicity level
Public Class Mine
    Inherits Cell

    Dim Toxicity As Double ' Toxicity level of cell

    ' Set toxicity level.
    ' INPUT:
    '   toxicity_level - Toxicity level of mine
    Sub set_toxicity(ByVal toxicity_level As Double)
        Me.Toxicity = toxicity_level
    End Sub

    ' Get toxicity level.
    ' OUTPUT:
    '   Double - Toxicity level
    Function get_toxicity() As Integer
        Return Me.Toxicity
    End Function

End Class
