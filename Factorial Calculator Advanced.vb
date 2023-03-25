Module Module1

    Sub Main()
        Console.WriteLine("The Factorial: " & Factorial(5))
        Console.ReadKey()
    End Sub
    Function Factorial(ByVal n As Integer) As Integer
        Dim x, y As Integer
        If n <= 1 Then
            Return 1
        End If
        x = Factorial(n - 1)
        y = x * n
        Return y
    End Function

End Module
