Imports System.Console

Module modulo1
    Public Class pulsaciones
        Dim edad, np
        Public Sub leer()
            WriteLine("DAME TU EDAD")
            edad = ReadLine()

        End Sub
        Public Sub calcular()
            np = (220 - edad) / 10
        End Sub
        Public Sub imprimir()
            WriteLine("NUMERO DE PULSACIONES ES: " & np)
        End Sub
    End Class
    Sub Main()
        Dim pulsa As New pulsaciones
        pulsa.leer()
        pulsa.calcular()
        pulsa.imprimir()

        ReadKey()
    End Sub
End Module