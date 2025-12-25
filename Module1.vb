Imports Orion.Patterns

Module Module1

    ''' <summary>
    ''' Шаблонный метод на основе наследования.
    ''' </summary>
    Sub Main()

        Dim saver As New LogFileReader()
        Dim log = saver.ReadLogEntry()

        Console.ReadKey()

    End Sub

End Module