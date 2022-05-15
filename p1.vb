Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, aux As Integer
        n1 = Convert.ToInt32(TextBox1.Text)
        n2 = Convert.ToInt32(TextBox2.Text)
        n3 = Convert.ToInt32(TextBox3.Text)
        aux = 0
        If n2 < n3 Then GoTo ope1
ope1:
        aux = n3
        n3 = n2
        n2 = aux


        If n1 < n2 Then GoTo ope2
ope2:
        aux = n2
        n2 = n1
        n1 = aux

        If n2 < n3 Then GoTo ope3
ope3:
        aux = n3
        n3 = n2
        n2 = aux
        TextBox4.Text = n1.ToString() + "; " + n2.ToString() + "; " + n3.ToString()
        GoTo final
final:

    End Sub
End Class
