Imports System

Module Program
    Sub Main(args As String())


        For i = 0 To 10 Step 2
            'incremento de 1 en 1 por defecto
            Console.WriteLine("hola")

        Next
        Dim j As Integer

        While j < 10
            Console.WriteLine(j)
            j = j + 1

        End While
        Dim k As Integer = 0

        k = 11
        ' el bucle do while 
        Do
            'bucle se ejecuta una vez al menos
            Console.WriteLine("hola do while")
            k = k + 1
        Loop Until k > 10


    End Sub
End Module
