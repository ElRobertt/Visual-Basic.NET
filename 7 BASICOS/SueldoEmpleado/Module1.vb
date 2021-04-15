Imports System.Console
Module Module1
    Public Class Sueldo
        Dim nom, suel, st, hi, ht, Hort
        Public Sub Datos()
            WriteLine("DIME TU NOMBRE")
            nom = ReadLine()
            WriteLine("CUANTO PAGAN POR UNA HORA DE TRABAJO? ")
            hi = ReadLine()
            WriteLine("CUANTAS HORAS TRABAJAS AL DIA? ")
            st = ReadLine()

        End Sub
        Public Sub Formulas()
            ht = hi * st
            Hort = ht * 30
        End Sub
        Public Sub Total()
            WriteLine("EL NOMBRE DEL TRABAJADOR ES:" & nom)
            WriteLine("HORAS TRABAJADAS AL DIA: " & st)
            WriteLine("SALARIO AL DIA: " & ht)
            WriteLine("SALARIO AL MES: " & Hort)
        End Sub
    End Class
    Sub Main()
        Dim sl As New Sueldo
        sl.Datos()
        sl.Formulas()
        sl.Total()
        ReadKey()
    End Sub
End Module
