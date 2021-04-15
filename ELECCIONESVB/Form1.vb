Public Class Form1
    Dim val As Integer
    Dim vl = 0
    Dim A = 0
    Dim B = 0
    Dim C = 0
    Dim D = 0
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = A + 1
        TextBox1.Text = A
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (A > B And A > C And A > D) Then
            TextBox5.BackColor = Color.Red
        Else
            If (B > A And B > C And B > D) Then
                TextBox5.BackColor = Color.Yellow
            Else
                If (C > A And C > B And C > D) Then
                    TextBox5.BackColor = Color.Blue
                Else
                    If (D > A And D > B And D > C) Then
                        TextBox5.BackColor = Color.White
                    Else
                        If (A = B And B = C And C = D) Then
                            TextBox5.Text = "Empate"
                        End If

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        B = B + 1
        TextBox2.Text = B
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        C = C + 1
        TextBox3.Text = C
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        D = D + 1
        TextBox4.Text = D
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox5.BackColor = Color.White
        A = 0
        B = 0
        C = 0
        D = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("DESEAS SALIR DE LA APP?", MsgBoxStyle.Question + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
