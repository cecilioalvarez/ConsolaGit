Imports System

Module Program
    Sub Main(args As String())


        Dim lista(4) As Integer

        lista(0) = 2
        lista(1) = 25
        lista(2) = 20
        lista(3) = 10
        lista(4) = 3



        Dim numero As Integer = 0

        For i = 0 To lista.Length - 1

            If (numero < lista(i)) Then

                numero = lista(i)
            End If

        Next

        Console.WriteLine(numero)

    End Sub
End Module
