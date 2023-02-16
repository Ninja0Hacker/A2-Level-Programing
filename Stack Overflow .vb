Module Module1
    Structure node
        Dim name As String
        Dim Pointer As Integer
    End Structure
    Dim FreePointer As Integer
    Dim TopOfStackPointer As Integer
    Dim temp As Integer
    Dim x As Integer
    Dim Stack(10) As node

    Sub main()
        Stacklnit()
        push("John")
        push("James")
        push("Omer")
        Console.ReadKey()
    End Sub

    Sub Stacklnit()
        For y = 1 To 10
            Stack(x).name = ""
            Stack(x).Pointer = x + 1
        Next
        Stack(10).Pointer = 0
        FreePointer = 1
        TopOfStackPointer = 0
    End Sub

    Sub push(ByVal data As String)
        If FreePointer = 0 Then
            Console.WriteLine("Stack OverFlow")
        End If
        Stack(FreePointer).name = data
        temp = FreePointer
        FreePointer = Stack(temp).Pointer
        Stack(temp).Pointer = TopOfStackPointer
        TopOfStackPointer = temp
    End Sub
End Module
