Module Module1
    Dim numbers() = {25, 20, 19, 16, 44, 65, 78, 34, 2, 5}
   
   Sub Main()
        InsertSort()
        Console.WriteLine()
        DisplayArray()
        Console.ReadKey()
    End Sub
   
   Sub InsertSort()
        Dim maxsize As Integer
        Dim Insert As Integer
        Dim temp As Integer
        maxsize = 9

        For count = 0 To maxsize
            temp = numbers(count)
            Insert = count
            While Insert > 0 AndAlso numbers(Insert - 1) >= temp
                numbers(Insert) = numbers(Insert - 1)
                Insert = Insert - 1
            End While
            numbers(Insert) = temp
        Next
    End Sub
   
   Sub DisplayArray()
        For i = 0 To 9
            Console.WriteLine(numbers(i))
        Next
    End Sub
End Module
