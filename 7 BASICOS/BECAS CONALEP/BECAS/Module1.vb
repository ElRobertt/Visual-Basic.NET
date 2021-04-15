Imports System.Console
Module Module1
    Public Class becas
        Dim nombre, prome1, prome2, bec, monto, opc
        Dim cont As Integer
        Public Sub Datos()
            Do
                WriteLine("DIME TU NOMBRE ")
                nombre = ReadLine()
                WriteLine("DIME TU PROMEDIO. 100% = 10")
                prome1 = ReadLine()
                Select Case prome1
                    Case 0 To 70
                        WriteLine("NOMBRE:  " & nombre & "PROMEDIO:  " & prome1)
                        WriteLine("LA BECA OBTENIDA ES: YO NO ABANDONO")
                        WriteLine("EL MONTO QUE TE CORRESPONDE ES: $1,000")
                    Case 70 To 90
                        WriteLine("NOMBRE:  " & nombre & "PROMEDIO:  " & prome1)
                        WriteLine("LA BECA OBTENIDA ES: ¡PERMANECE!")
                        WriteLine("EL MONTO QUE TE CORRESPONDE ES: $2,000")
                    Case 90 To 99
                        WriteLine("NOMBRE:  " & nombre & "PROMEDIO:  " & prome1)
                        WriteLine("LA BECA OBTENIDA ES: SUPERACION")
                        WriteLine("EL MONTO QUE TE CORRESPONDE ES: $5,000")
                    Case 100
                        WriteLine("NOMBRE:  " & nombre & "PROMEDIO:  " & prome1)
                        WriteLine("LA BECA OBTENIDA ES: EXECELINCIA ¡FELICIDADES!")
                        WriteLine("EL MONTO QUE TE CORRESPONDE ES: $7,000")
                End Select
                WriteLine("DESEA CONSULTAR OTRO ALUMNO")
                WriteLine("1. SI")
                WriteLine("2. NO")
                opc = ReadLine()
                cont = cont + 1
            Loop While (opc <> 2)
        End Sub
        Public Sub Final()

            WriteLine("TOTAL DE ALUMNOS BECADOS: " & opc)
        End Sub

    End Class
    Sub Main()
        Dim bec As New becas
        bec.Datos()
        bec.Final()
        ReadKey()
    End Sub
End Module
