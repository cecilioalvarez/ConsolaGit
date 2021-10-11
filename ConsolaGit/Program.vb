Imports System

Module Program
    Sub Main(args As String())

        Dim numero1 As Decimal
        Dim numero2 As Decimal
        Dim numero3 As Decimal
        Dim numero4 As Decimal

        Console.WriteLine("por favor introduce la nota1")

        numero1 = Console.ReadLine


        Console.WriteLine("por favor introduce la nota2")

        numero2 = Console.ReadLine

        Console.WriteLine("por favor introduce la nota3")

        numero3 = Console.ReadLine

        Console.WriteLine("por favor introduce la nota4")

        numero4 = Console.ReadLine

        Dim suma As Decimal

        suma = numero1 + numero2 + numero3 + numero4

        Console.WriteLine(suma / 4)



    End Sub
End Module
