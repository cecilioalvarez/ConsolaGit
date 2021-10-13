Imports System

Module Program
    Sub Main(args As String())



        Dim numero1 As Integer = 2
        Dim numero2 As Integer = 3
        'invocacion del codigo de la funcion
        sumar(numero1, numero2)
        sumar(7, 4)
        sumar(10, 2)
        mayor(2, 4)


    End Sub
    ' que se reutiliza en otras secciones del programa
    Sub sumar(a As Integer, b As Integer)
        ' este es el codigo que tu necesitas
        ' y lo vas a reutilizar varias veces 
        Console.WriteLine("*****************")
        Console.WriteLine(a + b)
        Console.WriteLine("*******************")

    End Sub

    Sub mayor(a As Integer, b As Integer)

        If a > b Then
            Console.WriteLine("el mayor es " & a)
        Else
            Console.WriteLine("el mayor es " & b)

        End If


    End Sub
End Module
