Imports System

Module Program
    Sub Main(args As String())


        Dim lista(4) As Integer

        lista(0) = 2
        lista(1) = 25
        lista(2) = 20
        lista(3) = 10
        lista(4) = 3



        Dim suma As Integer = 0

        For i = 0 To lista.Length - 1

            If (lista(i) >= 10) Then
                suma = suma + lista(i)
            End If

        Next

        Console.WriteLine(suma)

    End Sub
End Module
