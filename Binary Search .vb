Module Module1
    Dim StNames() = {"Ali", "Babar", "Cellin", "Drake", "Esha", "Fahad", "Gabriel", "Hassan", "Iman", "Jake"}
   
   Sub Main()
        Dim Choice As String
        Dim SearchName As String
        Choice = "Y"
        While Choice = "Y" Or Choice = "y"
            Console.Write("Enter The Name to Search: ")
            SearchName = Console.ReadLine()
            BSearch(SearchName)
            Console.Write("Press Y to Continue, N to Exit:")
            Choice = Console.ReadLine()
        End While
    End Sub
   
   Sub BSearch(ByVal SN As String)
        Dim Middle, C As Integer
        Dim LowerBound, UpperBound As Integer
        Dim Found As Boolean
        Found = False
        Middle = 0
        LowerBound = 0
        UpperBound = 9
        C = LowerBound
        While Found = False And C <= UpperBound
            Middle = C
            If StNames(Middle) = SN Then
                Found = True
            End If
            C = C + 1
        End While
        If Found = True Then
            Console.WriteLine("Name Found at Position " & Middle)
        Else
            Console.WriteLine("Name not Found")
        End If
        End Sub
End Module
