Imports System

Module Program
    Sub Main(args As String())


        ' hay que sacar por la consola la tabla de multiplicar del 7
        Dim i = 1
        While i <= 10
            'Console.WriteLine(i)
            Dim multiplicacion = i * 7
            Console.WriteLine("7" & "x" & i & "=" & multiplicacion)
            ' incrementas el bucle en 1 y pasas a la siguiente iteracion
            i = i + 1

        End While



    End Sub
End Module
