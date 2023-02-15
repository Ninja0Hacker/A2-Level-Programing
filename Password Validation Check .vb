Module Module1

    Sub Main()
        Dim Pass As String
        Console.WriteLine(" Enter You New Password: ")
        Pass = Console.ReadLine
        If ValidatePassword(Pass) = True Then
            Console.WriteLine(" Valid ")
        Else
            Console.WriteLine(" InValid ")
        End If
        Console.ReadKey()

    End Sub

    Function ValidatePassword(ByVal pass As String) As Boolean
        Dim nxtch As Char
        Dim cap, sm, num, sp As Integer
        Dim i As Integer
        For i = 1 To Len(pass)
            nxtch = Mid(pass, i, 1)
            If nxtch >= "A" And nxtch <= "Z" Then
                cap = cap + 1
            ElseIf nxtch >= "a" And nxtch <= "z" Then
                sm = sm + 1
            ElseIf nxtch >= "0" And nxtch <= "9" Then
                num = num + 1
            Else
                sp = sp + 1
            End If
        Next
        If cap >= 2 And sm >= 2 And num >= 3 And sp = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
