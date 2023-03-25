Module Module1

    Sub Main()
        Dim Num, Count As Integer
        Dim Fact As Integer
        Fact = 1
        Console.Write("Enter A Number To Factorise: ")
        Num = Console.ReadLine()
        For Count = 1 To Num
            Fact = Fact * Count
        Next
        Console.WriteLine("The Factorial is: " & Fact)
        Console.ReadKey()
    End Sub

End Module
