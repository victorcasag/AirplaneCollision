Imports System.Drawing.Drawing2D
Imports System.Reflection

Public Class Form1

    Dim flag As Boolean
    Dim count = 1

    Dim listAviao As New List(Of aviao.Aviao)

    'Functions

    Private Function CalcularRaio(x As Integer, y As Integer)
        Dim raio As Double

        raio = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))

        Return Math.Round(raio, 2)

    End Function

    Private Function CalcularAngulo(x As Integer, y As Integer)
        Dim angulo As Double

        angulo = Math.Atan2(x, y) * 180 / Math.PI

        Return Math.Round(angulo, 2)
    End Function

    Private Function CalcularValorX(r As Double, o As Double)
        Dim x As Integer

        x = r * Math.Cos(o)

        Return Math.Round(x, 2)

    End Function

    Private Function CalcularValorY(r As Double, o As Double)
        Dim y As Integer

        y = r * Math.Sin(o)

        MsgBox(Math.Sin(o))

        Return Math.Round(y, 2)
    End Function

    Private Function CalcularCoeficienteAngular(ByVal direcao As Double)

        Return Math.Round(Math.Tan(direcao), 2)

    End Function

    Private Sub ValidForm()

        If TextBoxAngulo.Text = "" And TextBoxRaio.Text = "" And TextBoxX.Text = "" And TextBoxY.Text = "" Then
            Throw New Exception("Nenhum campo esta preenchido para inserir o voo")
        End If

        If TextBoxY.Text = "" And TextBoxX.Text = "" Then
            TextBoxX.Text = CalcularValorX(TextBoxRaio.Text, TextBoxAngulo.Text)
            TextBoxY.Text = CalcularValorY(TextBoxRaio.Text, TextBoxAngulo.Text)
        End If

        If TextBoxRaio.Text = "" And TextBoxAngulo.Text = "" Then
            TextBoxAngulo.Text = CalcularAngulo(TextBoxX.Text, TextBoxY.Text)
            TextBoxRaio.Text = CalcularRaio(TextBoxX.Text, TextBoxY.Text)
        End If

    End Sub

    Private Sub RotateImage(b As Bitmap, angle As Double)





    End Sub

    Private Sub CleanForm()
        TextBoxX.Text = ""
        TextBoxY.Text = ""
        TextBoxRaio.Text = ""
        TextBoxAngulo.Text = ""
        TextBoxVelocidade.Text = ""
        TextBoxDirecao.Text = ""
        TextBoxXEscalonar.Text = ""
        TextBoxYEscalonar.Text = ""
        TextBoxXTranslandar.Text = ""
        TextBoxYTranslandar.Text = ""
    End Sub

    Private Sub CalcularEquaçãoY(ByVal x As Double, ByVal y As Double, ByVal direcao As Double)

        Dim y1 As Double = 0

        Dim x1 As Double = 1

        Dim m As Double = CalcularCoeficienteAngular(direcao)

        Dim resultY As Double = 0

        Dim resultX As Double = 0

        Dim resultTotal As Double = 0

        '(yi-Y) = m(xi-X)

        'yi = m (xi - x + y)

        'y1 = m * x

        'y1 = m * (x1 - x)


    End Sub

    'End Functions

    Private Sub ButtonInsertPlane_Click(sender As Object, e As EventArgs) Handles ButtonInsertPlane.Click
        Dim objAviao As New aviao.Aviao

        Try

            flag = False
            ValidForm()
            flag = True
            With objAviao
                .ID = count
                .X = TextBoxX.Text
                .Y = TextBoxY.Text
                .Raio = TextBoxRaio.Text
                .Angulo = TextBoxAngulo.Text
                .Velocidade = TextBoxVelocidade.Text
                .Direcao = TextBoxDirecao.Text
                .ImageAviao = Image.FromFile("C:\Users\victo\Downloads\sdad-removebg-preview.png")
            End With

            listAviao.Add(objAviao)

            'RotateImage(objAviao.ImageAviao, objAviao.Direcao)

            BindingSourceAviao.DataSource = Nothing
            BindingSourceAviao.DataSource = listAviao

            Panel1.Invalidate()

            DataGridViewDadosAviao.Refresh()
            Panel1.Refresh()

            CleanForm()
            count += 1

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        Dim m As New Matrix()
        Dim image As Image = Image.FromFile("C:\Users\victo\Downloads\ponto (1).png")

        e.Graphics.DrawImage(image, 248, 186)

        If flag Then

            For Each objAviao In listAviao

                ' m.Rotate(objAviao.Direcao)

                'e.Graphics.Transform = m



                e.Graphics.DrawImage(objAviao.ImageAviao, objAviao.X, objAviao.Y)

                'e.Graphics.ResetTransform()

            Next

        End If
    End Sub

    Private Sub ButtonTranslandar_Click(sender As Object, e As EventArgs) Handles ButtonTranslandar.Click

        Dim listLocalAviao As New List(Of aviao.Aviao)

        listLocalAviao.AddRange(listAviao)

        For Each objAviao In listAviao
            If objAviao.IsValid Then

                With objAviao
                    .ID = count
                    .X = TextBoxXTranslandar.Text + objAviao.X
                    .Y = TextBoxYTranslandar.Text + objAviao.Y
                    .Raio = CalcularRaio(objAviao.X, objAviao.Y)
                    .Angulo = CalcularAngulo(objAviao.X, objAviao.Y)
                    .Velocidade = objAviao.Velocidade
                    .ImageAviao = objAviao.ImageAviao
                    .IsValid = False
                End With


                listLocalAviao.Add(objAviao)


                listLocalAviao.RemoveAll(Function(x) x.IsValid = True)


                BindingSourceAviao.DataSource = Nothing
                BindingSourceAviao.DataSource = listLocalAviao

                Panel1.Invalidate()

                DataGridViewDadosAviao.Refresh()
                Panel1.Refresh()
                CleanForm()
                count += 1
            End If
        Next
    End Sub

    Private Sub ButtonEscalonar_Click(sender As Object, e As EventArgs) Handles ButtonEscalonar.Click
        Dim listLocalAviao As New List(Of aviao.Aviao)

        listLocalAviao.AddRange(listAviao)

        For Each objAviao In listAviao
            If objAviao.IsValid Then

                With objAviao
                    .ID = count
                    .X = (TextBoxXEscalonar.Text / 100) + objAviao.X
                    .Y = (TextBoxYEscalonar.Text / 100) + objAviao.Y
                    .Raio = CalcularRaio(objAviao.X, objAviao.Y)
                    .Angulo = CalcularAngulo(objAviao.X, objAviao.Y)
                    .Velocidade = objAviao.Velocidade
                    .ImageAviao = objAviao.ImageAviao
                    .IsValid = False
                End With


                listLocalAviao.Add(objAviao)


                listLocalAviao.RemoveAll(Function(x) x.IsValid = True)


                BindingSourceAviao.DataSource = Nothing
                BindingSourceAviao.DataSource = listLocalAviao

                Panel1.Invalidate()

                DataGridViewDadosAviao.Refresh()
                Panel1.Refresh()
                CleanForm()
                count += 1
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Invalidate()
        CalcularEquaçãoY(1, 2, 45)
        'Panel1.SetBounds(0, 0, 248, 186)

        'Panel1.Location = New Point((Me.Width / 2) - (Panel1.Width / 2), (Me.Height / 2) - (Panel1.Height / 2))

    End Sub

    Private Sub ButtonRotaColisão_Click(sender As Object, e As EventArgs) Handles ButtonRotaColisão.Click

        Dim list As New List(Of String)
        Dim count As Double = 0

        'For Each objAviao In listAviao
        '    If objAviao.IsValid and count <= 10 Then
        '        count += count
        '        list.Add(CalcularEquaçãoY(objAviao.x,objAviao.y,objAviao.direcao))   
        '    End If
        'Next

    End Sub
End Class
