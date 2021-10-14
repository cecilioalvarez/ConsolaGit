Imports System

Module Program
    Sub Main(args As String())

        'mensajesHolas()

        'Console.WriteLine("adios")
        'Console.WriteLine("adios")

        'mensajesHolas()

        'Console.WriteLine("adios")

        'Dim suma As Integer = 0

        'sumarNumeros(5)

        'sumarNumeros(50)

        'Console.WriteLine(suma)

        imprimirNota(5)
        imprimirNota(9)


    End Sub


    Sub mensajesHolas()
        Console.WriteLine("hola")
        Console.WriteLine("hola")
        Console.WriteLine("hola")
    End Sub

    Sub sumarNumeros(tope As Integer)
        Dim suma As Integer

        For i = 0 To tope
            suma = suma + i
        Next
        Console.WriteLine(suma)

    End Sub


    Sub imprimirNota(nota As Integer)

        If nota >= 0 And nota < 3 Then
            Console.WriteLine("muy mal")
        ElseIf nota >= 3 And nota < 5 Then
            Console.WriteLine("flojo")
        ElseIf nota >= 5 And nota < 7 Then
            Console.WriteLine("bien hecho")
        Else
            Console.WriteLine("fenomenal")


        End If



    End Sub




End Module
