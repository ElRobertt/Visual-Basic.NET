Imports System.Console
Module module1
    Public Class optica
        Dim costo, visual, miopia, astigmatismo, ceguera, cataratas, contador, nombre, majo
        Public Sub leer()


            Console.Clear()
            WriteLine("¿CUAL ES TU NOMBRE?")
            nombre = ReadLine()
            WriteLine("¿CUAL ES TU PROBLEMA VISUAL?")
            WriteLine("1.-MIOPIA")
            WriteLine(" 2.-asrigmatismo")
            Wirteline("3.-ceguera")
            Wirteline("4.-cataratas")
            visual = ReadLine()


Switch:
            Select Case [visual]
                Case 1
                    costo = costo + 35
                Case 2
                    costo = costo + 35
                Case 3
                    costo = costo + 45
                Case 4
                    costo = costo + 50
                Case Else
                    WriteLine("OPCION INCORRECTO")
            End Select
            contador = contador + 1
        End Sub
        Public Sub imprimir()
            WriteLine("NOMBRE:" & nombre)
            WriteLine("EL COSTO DE LOS LENTES:" & costo)
            WriteLine("TOTAL DE CLIENTES ATENDIDOS:" & contador)
            ReadKey()
        End Sub

    End Class
    Sub main()
        Dim ojos As New optica
        Dim majo, contador
        Do
            ojos.leer()
            ojos.imprimir()
            WriteLine("QUIERES REPETIR EL PROCESO?")
            WriteLine("1-si")
            WriteLine("otro-no")
            majo = ReadLine()
        Loop While (majo = 1)
    End Sub
End Module
