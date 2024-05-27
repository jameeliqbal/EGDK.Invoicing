Namespace Models
    Public Class Category
        Public Sub New()
            Products = New List(Of Product)
        End Sub
        Public Property Id As Integer
        Public Property Name As String
        Public Property Description As String

        Public Property Products As IEnumerable(Of Product)
    End Class

End Namespace

