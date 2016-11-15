Public Class form1
    Public a As Decimal = 0 ' valor 1
    Public b As Decimal = 0  ' valor 2
    Public resul As Decimal = 0 '  resultado del valor1 y valor 1
    

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            a = CDec(TextBox1.Text)
            b = CDec(TextBox2.Text)
            resul = a + b
            TextBox3.Text = CStr(resul)

        Catch ex As Exception
            MsgBox("Ingrese un Número")


        End Try
     

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            a = CDec(TextBox1.Text)
            b = CDec(TextBox2.Text)
            resul = a - b
            TextBox3.Text = CStr(resul)

        Catch ex As Exception

            MsgBox("Ingrese un Número")
        End Try

     


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = 0 ' inicio de la variable en cero
        b = 0 ' inicio de la variable en cero
        resul = 0 ' inicio de la variable en cero
        TextBox1.Text = "" ' limpiando el texbox1
        TextBox2.Text = "" ' limpiando el texbox2
        TextBox3.Text = "" ' limpiando el texbox3
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            a = CDec(TextBox1.Text)
            b = CDec(TextBox2.Text)

            resul = a * b
            TextBox3.Text = CStr(resul)
        Catch ex As Exception
            MsgBox("Ingrese un Número")


        End Try

       

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            a = CDec(TextBox1.Text)
            b = CDec(TextBox2.Text)
            resul = a / b
            TextBox3.Text = CStr(resul)
        Catch ex As Exception
            MsgBox("Ingrese un Número")


        End Try
      

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Try

            a = CDec(TextBox1.Text)

            If a > 0 Then

                resul = Math.Sqrt(a)

                TextBox2.Text = "Raiz Cuadrada de " + CStr(a) + " es"

                TextBox3.Text = CStr(resul)
            Else

                MsgBox("ingrese un numero mayor que cero")


            End If

        Catch ex As Exception
            MsgBox("Ingrese un Número")


        End Try
      
       

        



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            a = CDec(TextBox1.Text)
            b = CDec(TextBox2.Text)

            If b >= 0 Then

                resul = Math.Pow(a, b)


                TextBox3.Text = CStr(resul)
            Else

                MsgBox("La Potencia tiene que ser un numero natural:  0, 1 ")


            End If
        Catch ex As Exception
            MsgBox("Ingrese un Número")

        End Try

       



    End Sub
End Class
