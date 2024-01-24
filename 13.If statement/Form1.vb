Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber As Double
        Dim secondNumber As Double

        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        If firstNumber > secondNumber Then
            TextBox3.Text = firstNumber
        Else
            TextBox3.Text = secondNumber
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
