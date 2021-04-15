Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button5.Text = "GREEN"
        Button5.BackColor = Color.Green

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button5.Text = "YELLOW"
        Button5.BackColor = Color.Yellow

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button5.Text = "BLUE"
        Button5.BackColor = Color.Blue

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button5.Text = "PURPLE"
        Button5.BackColor = Color.Purple
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("DESEAS SALIR DE LA APP?", MsgBoxStyle.Question + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class