Imports System.Console

Module module1
    Public Class finanzas
        Dim a, b, c, d, e
        Public Sub leer()
            WriteLine("cual es tu nombre")
            a = ReadLine()
            WriteLine("cuantas horas trabajas")
            b = ReadLine()
            WriteLine("cua es tu pago por hora")
            c = ReadLine()
        End Sub
        Public Sub calcular()
            d = b * c
            e = d * 30

        End Sub
        Public Sub imprimir()
            WriteLine("tu nombre es:" & a)
            WriteLine("el salario por dia  sera:" & d)
            WriteLine("el salario por mes sera:" & e)
        End Sub
    End Class

    Sub Main()
        Dim salario As New finanzas
        salario.leer()
        salario.calcular()
        salario.imprimir()
        ReadKey()
    End Sub
End Module
