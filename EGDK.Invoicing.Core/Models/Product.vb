Namespace Models
    Public Class Product
        Public Property Id As Integer
        'name, description, price, quantity, and category
        Public Property Name As String
        Public Property Description As String
        Public Property Price As Double
        Public Property Quantity As Integer

        Public Property CategoryId As Integer

        Public Property Category As Category

    End Class
End Namespace

