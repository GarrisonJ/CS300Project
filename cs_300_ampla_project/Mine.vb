﻿Public Class Mine
    Inherits Cell

    Dim Toxicity As Integer

    Sub set_toxicity(ByVal toxicity_level As Integer)
        Me.Toxicity = toxicity_level
    End Sub

    Function get_toxicity() As Integer
        Return Me.Toxicity
    End Function

End Class
