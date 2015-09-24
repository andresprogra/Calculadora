Public Class Form1
    Dim off As Boolean = False
    Dim operacion As String

    Dim ban As Boolean = True

    Dim num1, num2, res As Double


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If off = True Then
            TextBox1.Enabled = True
            Button14.Text = "OFF"
            TextBox1.Text = ""
            off = False
        ElseIf off = False Then
            TextBox1.Enabled = False
            Button14.Text = "ON"
            TextBox1.Text = "APAGADO"
            off = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uno As Integer = 1
        If ban = True Then
            TextBox1.Text = uno
            ban = False

        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & uno
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dos As Integer = 2
        If ban = True Then
            TextBox1.Text = dos
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & dos
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tres As Integer = 3
        If ban = True Then
            TextBox1.Text = tres
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & tres
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cuatro As Integer = 4
        If ban = True Then
            TextBox1.Text = cuatro
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & cuatro
        End If
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = ""
        Button10.Enabled = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cinco As Integer = 5
        If ban = True Then
            TextBox1.Text = cinco
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & cinco
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim seis As Integer = 6
        If ban = True Then
            TextBox1.Text = seis
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & seis
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim siete As Integer = 7
        If ban = True Then
            TextBox1.Text = siete
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & siete
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ocho As Integer = 8
        If ban = True Then
            TextBox1.Text = ocho
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & ocho
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim nueve As Integer = 9
        If ban = True Then
            TextBox1.Text = nueve
            ban = False
        ElseIf ban = False Then
            TextBox1.Text = TextBox1.Text & nueve
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim cero As Integer = 0
        If TextBox1.Text = "0" Then
            Return
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text & cero



        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
            TextBox1.Text = TextBox1.Text & "."
        Button10.Enabled = False
        ban = False




    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        operacion = "+"
        num1 = TextBox1.Text
        Label1.Text = "Sumando..."
        ban = True

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        operacion = "-"
        num1 = TextBox1.Text
        Label1.Text = "Restando..."
        ban = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        operacion = "*"
        num1 = TextBox1.Text
        Label1.Text = "Multiplicando..."
        ban = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        operacion = "/"
        num1 = TextBox1.Text
        Label1.Text = "Diviendo..."
        ban = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click


        If operacion = "+" Then
            res = Val(num1) + Val(TextBox1.Text)
            TextBox1.Text = res
        ElseIf operacion = "-" Then
            res = Val(num1) - Val(TextBox1.Text)
            TextBox1.Text = res
        ElseIf operacion = "*" Then
            res = Val(num1) * Val(TextBox1.Text)
            TextBox1.Text = res
        ElseIf operacion = "/" Then
            res = Val(num1) / Val(TextBox1.Text)
            TextBox1.Text = res

        End If




    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim act As String
        act = TextBox1.Text.Length - 1

        TextBox1.Text = act

    End Sub
End Class
