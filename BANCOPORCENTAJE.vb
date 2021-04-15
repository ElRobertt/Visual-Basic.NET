Imports System.Console

Module Module1q
    Public Class mensual
        Dim cap, inte, tf, inte1
        Public Sub leer()
            WriteLine("TU CAPITAL ACTUAL ES")
            cap = ReadLine()
        End Sub
        Public Sub calcular()
            inte = cap * 0.98
            inte1 = cap - inte
            tf = cap + inte + 1
        End Sub
        Public Sub imprimir()
            WriteLine("EL INTERES GANADO ES: " & inte1)
            WriteLine("EL SALDO FINAL ES:" & tf)
        End Sub
    End Class
    Sub Main()
        Dim banco As New mensual
        banco.leer()
        banco.calcular()
        banco.imprimir()
        ReadKey()
    End Sub
End Module
