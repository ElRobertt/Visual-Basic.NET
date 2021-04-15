Imports System.Console
Module Module1
    Public Class votos
        Dim Opc, opf
        Dim Cand1 As Integer
        Dim Cand2 As Integer
        Dim Cand3 As Integer
        Dim Cand4 As Integer

        Public Sub info()
            Do

                WriteLine("Elecciones Conalep")
                WriteLine("Por que candidato desea votar?")
                WriteLine("1.Antonio Meade")
                WriteLine("2.Ricardo Anaya")
                WriteLine("3.Margarita")
                WriteLine("4.AMLO")
                WriteLine("Escribe el numero del candidato elegido:")
                Opc = ReadLine()
                Select Case Opc
                    Case 1
                        Cand1 = Cand1 + 1
                        Exit Select
                    Case 2
                        Cand2 = Cand2 + 1
                        Exit Select
                    Case 3
                        Cand3 = Cand3 + 1
                        Exit Select
                    Case 4
                        Cand4 = Cand4 + 1
                        Exit Select
                    Case 5 To 9
                        WriteLine("OPCION INCORRECTA ")
                        Exit Select
                End Select
                WriteLine("¿CONTINUAR CON OTRO VOTANTE?")
                WriteLine("1.SI ")
                WriteLine("2.NO")
                opf = ReadLine()
            Loop While (opf <> 1)
        End Sub
        Public Sub Final()
            If ((Cand1 > Cand2) & (Cand1 > Cand3) & (Cand1 > Cand4)) Then
                WriteLine("Total de votos por Antonio Meade es:" & Cand1)
                WriteLine("Total de votos por Ricardo Anaya es:" & Cand2)
                WriteLine("Total de votos por Margarita es:" & Cand3)
                WriteLine("Total de votos por AMLO es:" & Cand4)
                WriteLine("El ganador fue: Antonio Meade")

            ElseIf ((Cand1 > Cand2) & (Cand1 > Cand3) & (Cand1 > Cand4)) Then

                WriteLine("Total de votos por Antonio Meade es:" & Cand1)
                WriteLine("Total de votos por Ricardo Anaya es:" & Cand2)
                WriteLine("Total de votos por Margarita es:" & Cand3)
                WriteLine("Total de votos por AMLO es:" & Cand4)
                WriteLine("El ganador fue: Ricardo Anaya")
            ElseIf ((Cand1 > Cand2) & (Cand1 > Cand3) & (Cand1 > Cand4)) Then

                WriteLine("Total de votos por Antonio Meade es:" & Cand1)
                WriteLine("Total de votos por Ricardo Anaya es:" & Cand2)
                WriteLine("Total de votos por Margarita es:" & Cand3)
                WriteLine("Total de votos por AMLO es:" & Cand4)
                WriteLine("El ganador fue: Margarita Zavala")
            ElseIf ((Cand1 > Cand2) & (Cand1 > Cand3) & (Cand1 > Cand4)) Then

                WriteLine("Total de votos por Antonio Meade es:" & Cand1)
                WriteLine("Total de votos por Ricardo Anaya es:" & Cand2)
                WriteLine("Total de votos por Margarita es:" & Cand3)
                WriteLine("Total de votos por AMLO es:" & Cand4)
                WriteLine("El ganador fue: AMLO")
            Else
                WriteLine("HAY UN EMPATE")
            End If
        End Sub
    End Class
    Sub Main()
        Dim vt As New votos
        vt.info()
        vt.Final()
        ReadKey()
    End Sub
End Module