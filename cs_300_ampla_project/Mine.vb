Public Class Mine
    Dim Toxicity As Integer


    Sub set_toxicity(ByVal toxicity_level As Integer)
        Me.Toxicity = toxicity_level
    End Sub

    Function set_toxicity() As Integer
        Return Me.Toxicity
    End Function

End Class
