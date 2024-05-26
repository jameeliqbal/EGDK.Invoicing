Imports System.Linq.Expressions
Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Repositories

Namespace Repositories

    Public Class Repository(Of TEntity As Class)
        Implements IRepository(Of TEntity)

        Protected ReadOnly Context As IInMemDB

        Public Sub New(context As IInMemDB)
            Me.Context = context
        End Sub

        Public Sub Add(entity As TEntity) Implements IRepository(Of TEntity).Add
            Throw New NotImplementedException()
        End Sub

        Public Sub AddRangeAsync(entities As IEnumerable(Of TEntity)) Implements IRepository(Of TEntity).AddRangeAsync
            Throw New NotImplementedException()
        End Sub

        Public Sub Remove(entity As TEntity) Implements IRepository(Of TEntity).Remove
            Throw New NotImplementedException()
        End Sub

        Public Sub RemoveRangeAsync(entities As IEnumerable(Of TEntity)) Implements IRepository(Of TEntity).RemoveRangeAsync
            Throw New NotImplementedException()
        End Sub

        Public Function GetById(id As Integer) As TEntity Implements IRepository(Of TEntity).GetById
            Throw New NotImplementedException()
        End Function

        Public Function GetAll() As IEnumerable(Of TEntity) Implements IRepository(Of TEntity).GetAll
            Throw New NotImplementedException()
        End Function

        Public Function Find(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity) Implements IRepository(Of TEntity).Find
            Throw New NotImplementedException()
        End Function

        Public Function SingleOrDefault(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity) Implements IRepository(Of TEntity).SingleOrDefault
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace
