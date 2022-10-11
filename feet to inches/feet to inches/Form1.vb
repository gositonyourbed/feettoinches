Public Class Form1
    Dim inches As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inches = TextBox1.Text
        Label2.Text = "Feet: " & Math.Round(inches / 12, 2)
    End Sub
End Class
