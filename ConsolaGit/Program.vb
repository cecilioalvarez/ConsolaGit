Imports System

Module Program
    Sub Main(args As String())


        Dim lista(4) As Integer

        lista(0) = 2
        lista(1) = 25
        lista(2) = 20
        lista(3) = 10
        lista(4) = 3


        ' una me va almacenando cual es el numero que por ahora 
        'es el mayor
        Dim mayor As Integer = 0
        'la otra me almacena la posicion en la que se encuentra
        Dim posicion = 0

        For i = 0 To lista.Length - 1

            If (lista(i) > mayor) Then
                mayor = lista(i)
                posicion = i

            End If

        Next

        Console.WriteLine(posicion)

    End Sub
End Module
