Imports System.Linq.Expressions

Namespace Repositories
    Public Interface IRepository(Of TEntity As Class)

        Sub Add(entity As TEntity)
        Sub AddRangeAsync(entities As IEnumerable(Of TEntity))
        Function GetById(id As Integer) As TEntity
        Function GetAll() As IEnumerable(Of TEntity)
        Function Find(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity)
        Function SingleOrDefault(predicate As Expression(Of Func(Of TEntity, Boolean))) As IEnumerable(Of TEntity)
        Sub Remove(entity As TEntity)
        Sub RemoveRangeAsync(entities As IEnumerable(Of TEntity))
    End Interface
End Namespace
