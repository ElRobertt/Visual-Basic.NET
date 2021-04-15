Imports System.Console
Module EXAMEN
    Public Class Examen
        Dim resl, opc, tt, C2

        Dim a, b, cs As Double
        Dim cont, c As Integer
        Public Sub Oper()
            Do


                WriteLine("ELIGE LA OPCION QUE DESEES")
                WriteLine("1. SUMA")
                WriteLine("2. RESTA")
                WriteLine("3. MULTIPLICACION")
                opc = ReadLine()
                Console.Clear()
                WriteLine("DAME UN NUMERO")
                a = ReadLine()
                WriteLine("DAME OTRO NUMERO")
                b = ReadLine()
                Select Case opc
                    Case 1
                        cs = b + a
                        WriteLine("EL RESULTADO ES: " & cs)

                    Case 2
                        C2 = a - b
                        WriteLine("EL RESULTADO ES: " & C2)

                    Case 3
                        C2 = a * b
                        WriteLine("EL RESULTADO ES: " & C2)

                    Case 4 To 9
                        WriteLine("ERROR OPCION INCORRECTA")
                End Select
                WriteLine("DESEAS HACER OTRA OPERACION? ")
                WriteLine("1.SI")
                WriteLine("2.NO")
                tt = ReadLine()
                cont = cont + 1
            Loop While (tt <> 2)
        End Sub
        Public Sub Final()
            WriteLine("TOTAL DE OPERACIONES REALIZADAS " & cont)
        End Sub
    End Class
    Sub Main()
        Dim ex As New Examen
        ex.Oper()
        ex.Final()
        ReadKey()
    End Sub
End Module
