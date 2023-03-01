Module Module1
    Dim MyMemory(0 To 5) As Integer

    Sub Main()
        Dim Data, x As Integer
        InsertHash(1551)
        InsertHash(157)
        Console.Write("Enter Search Record Key:")
        Data = Console.ReadLine()
        x = SearchHash(Data)
        If x = 0 Then
            Console.WriteLine("Not Found")
        Else
            Console.WriteLine("Found")
        End If
        Console.ReadKey()

        For x = 0 To 5
            Console.WriteLine(MyMemory(x))
        Next
        Console.ReadKey()
    End Sub

    Sub InsertHash(ByVal RecKey As Integer)
        Dim HashKey As Integer
        HashKey = Hash(RecKey, 5)
        While MyMemory(HashKey) <> 0
            HashKey = HashKey + 1
            If HashKey > 5 Then HashKey = 0
        End While
        MyMemory(HashKey) = RecKey
    End Sub

    Function SearchHash(ByVal RecKey As Integer) As Integer
        Dim HashKey, totSearches As Integer
        HashKey = Hash(RecKey, 5)
        While MyMemory(HashKey) <> RecKey
            totSearches = totSearches + 1
            HashKey = HashKey + 1
            If HashKey > 5 Then HashKey = 0
            If totSearches > 5 Then
                Return 0
                Exit Function
            End If
        End While
        Return (RecKey)
    End Function

    Function Hash(ByVal KeyVal As Integer, ByVal MaxPos As Integer) As Integer
        Dim indexPos As Integer
        indexPos = KeyVal Mod (MaxPos + 1)
        Return indexPos
    End Function
End Module
