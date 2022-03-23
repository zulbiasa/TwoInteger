Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no1 As Double = num1.Text
        Dim no2 As Double = num2.Text

        Dim add As String = no1 + no2
        Dim minus As String = no2 - no1
        Dim multiply As String = no1 * no2
        Dim divide As String = no1 / no2
        Dim modulus As String = no1 Mod no2

        Label3.Text = "Result : " + Environment.NewLine + Environment.NewLine +
            "Sum : " + add + Environment.NewLine +
            "Minus : " + minus + Environment.NewLine +
            "Multiply : " + multiply + Environment.NewLine +
            "Divide : " + divide + Environment.NewLine +
            "Modulus : " + modulus

    End Sub
End Class
