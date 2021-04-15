Imports System.Console

Module Module1
    Public Class sueldo
        Dim a1, a2, a3, a4, a5, a6, at, op, opc2, vi
        Public Sub lectura()
            WriteLine("SUELDO INICIAL: $4,000           INCREMENTO:10%           A 6 AÑOS ")
            vi = 4000 * 0.1
            a1 = 4000 + vi
            a2 = a1 + vi
            a3 = a2 + vi
            a4 = a3 + vi
            a5 = a4 + vi
            a6 = a5 + vi

        End Sub
        Public Sub escritura()
            WriteLine("AÑO 1 4" & a1)
            WriteLine("AÑO 2 $" & a2)
            WriteLine("AÑO 3 $" & a3)
            WriteLine("AÑO 4 $" & a4)
            WriteLine("AÑO 5 $" & a5)
            WriteLine("AÑO 6 $" & a6)
            WriteLine("EN 6 AÑOS GANARA: $" & a6)
        End Sub
    End Class
    Sub Main()
        Dim sueldo As New sueldo
        sueldo.lectura()
        sueldo.escritura()
        ReadKey()
    End Sub

End Module
