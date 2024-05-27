Namespace Models
    Public Class Customer
        Public Sub New()
            Invoices = New List(Of Invoice)
        End Sub

        Public Property Id As Integer

        Public Property Name As String
        Public Property Email As String
        Public Property Address As String
        Public Property Phone As String
        Public Property Invoices As IEnumerable(Of Invoice)
    End Class

End Namespace
