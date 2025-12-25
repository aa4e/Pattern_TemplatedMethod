Namespace Patterns

    ''' <summary>
    ''' Интерфейс сервиса сохранения записей.
    ''' </summary>
    Public MustInherit Class LogReaderBase

        Private CurrenPosition As Integer

        ''' <summary>
        ''' Невиртуальный метод импорта.
        ''' </summary>
        Public Function ReadLogEntry() As IEnumerable(Of LogEntry)
            Return ReadEntries(CurrenPosition).Select(Function(entry) ParseLogEntry(entry))
        End Function

        'Абстрактные методы, которые будут переопределены в конкретных реализациях классов.
        Protected MustOverride Function ReadEntries(ByRef postion As Integer) As IEnumerable(Of String)
        Protected MustOverride Function ParseLogEntry(entry As String) As LogEntry

    End Class

End Namespace