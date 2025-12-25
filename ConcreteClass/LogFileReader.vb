Namespace Patterns

    ''' <summary>
    ''' Прокси-класс инкапсулирует особенности работы с WCF-инфраструктурой.
    ''' </summary>
    Public Class LogFileReader
        Inherits LogReaderBase

        Protected Overrides Function ReadEntries(ByRef postion As Integer) As IEnumerable(Of String)
            Throw New NotImplementedException()
        End Function

        Protected Overrides Function ParseLogEntry(entry As String) As LogEntry
            Throw New NotImplementedException()
        End Function

    End Class

End Namespace