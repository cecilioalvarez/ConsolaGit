Imports System

Module Program
    Sub Main(args As String())


        Dim lista(4) As Integer

        lista(0) = 2
        lista(1) = 25
        lista(2) = 20
        lista(3) = 10
        lista(4) = 3
        Dim total As Decimal

        For i = 0 To lista.Length - 1
            total = total + lista(i)
        Next
        Dim media = total / lista.Length
        Console.WriteLine(media)




    End Sub
End Module
