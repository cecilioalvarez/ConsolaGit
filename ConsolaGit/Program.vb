Imports System

Module Program
    Sub Main(args As String())


        Dim lista(4) As Integer

        lista(0) = 2
        lista(1) = 25
        lista(2) = 20
        lista(3) = 10
        lista(4) = 3

        Dim numero As Integer
        Console.WriteLine("dame el numero")

        numero = Console.ReadLine()

        Dim esta As Boolean = False
        Dim posicion As Integer


        For i = 0 To lista.Length - 1

            If numero = lista(i) Then
                esta = True
                posicion = i
            End If
        Next



        If esta Then
            Console.WriteLine("encontrado")
            Console.WriteLine(posicion)


        End If



    End Sub
End Module
