Imports System.Console

Module Module1
    Public Class papeleria
        Dim nom, art, com, c, f, c1
        Dim opcit, opci As Integer

        Public Sub leer()
            WriteLine("--------------PAPELERIA MILTONS-----------")
            WriteLine("NOMBRE DEL CLIENTE")
            nom = ReadLine()
            Do
                WriteLine("DIME EL NOMBRE DE TU PRODUCTO")
                art = ReadLine()
                WriteLine("CUAL ES EL PRECIO DE TU ARTICULO?")
                com = ReadLine()
                WriteLine("CUANTOS VAS A COMPRAR?")
                opci = ReadLine()
                opcit = opci + opcit
                c1 = opci * com
                c = c + c1
                Console.Clear()
                WriteLine("DESEA AGREGAR OTRO ARTUCULO A SU COMPRA? ")
                WriteLine("1. SI")
                WriteLine("2.NO")
                f = ReadLine()
                If (f >= 3) Then
                    WriteLine("OPCION INCORRECTA ")
                    WriteLine("TOTAL FINAL")

                    Exit Sub
                End If
            Loop While (f <> 2)

        End Sub
        Public Sub Imprimir()
            WriteLine("EL NOMBRE DEL CLIENTE ES: " & nom)
            WriteLine("LA COMPRA TOTAL ES DE: " & c)
            WriteLine("CANTIDAD TOTAL: " & opcit)
        End Sub
    End Class
    Sub Main()
        Dim pape As New papeleria
        pape.leer()
        pape.Imprimir()
        ReadKey()
    End Sub
End Module