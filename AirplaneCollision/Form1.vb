Imports System.Drawing.Drawing2D
Imports System.Reflection

Public Class Form1

    Dim flag As Boolean
    Dim count = 1

    Dim listAviao As New List(Of aviao.Aviao)
    Dim listColisao As New List(Of aviao.Colisao)
    Dim listResultColisao As New List(Of aviao.ReuladoColisao)
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

        'Panel1.SetBounds(0, 0, 248, 186)

        'Panel1.Location = New Point((Me.Width / 2) - (Panel1.Width / 2), (Me.Height / 2) - (Panel1.Height / 2))

    End Sub

    Private Sub ButtonRotaColisão_Click(sender As Object, e As EventArgs) Handles ButtonRotaColisão.Click

        Dim objcolisao As New aviao.Colisao
        Dim objResultColisao As New aviao.ReuladoColisao
        Dim count As Double = 0
        Dim y2 As Double = 1
        Dim x2 As Double = 1
        Dim m As Double = 0
        Dim resultY As Double = 0
        Dim d As Double = 0
        Dim t As Double = 0
        Dim result As New List(Of Integer)
        Dim listD As New List(Of Double)
        Dim listT As New List(Of Double)


        For Each objAviao In listAviao
            If objAviao.IsValid And count <= 10 Then
                count += count
                m = CalcularCoeficienteAngular(objAviao.Direcao)
                '(y2 - y) = m(x2 - x)

                If objAviao.Y > 0 Then
                    y2 = m * (-objAviao.X) + objAviao.Y
                Else
                    y2 = m * (-objAviao.X) - objAviao.Y
                End If

                With objcolisao
                    .ID = objAviao.ID
                    .Y2 = y2
                    .X2 = m
                End With

                listColisao.Add(objcolisao)

                If listColisao.Count = 2 Then
                    For Each objColisionlist In listColisao

                        'x2 = x | o numero = Y2

                        result.Add(objColisionlist.X2 + objColisionlist.Y2)

                    Next
                    Dim totalResultX As Integer = result.Sum()
                    RichTextBoxReport.Text &= vbCrLf + totalResultX

                    resultY = totalResultX + objcolisao.Y2

                    With objResultColisao
                        .ID = objAviao.ID
                        .X = totalResultX
                        .Y = resultY
                    End With
                    listResultColisao.Add(objResultColisao)

                    For Each objResultColisao In listResultColisao
                        d = Math.Sqrt(Math.Pow(objResultColisao.X - objAviao.X, 2)) + (Math.Pow(objResultColisao.Y - objAviao.Y, 2))
                        t = d / objAviao.Velocidade
                        listD.Add(d)
                        listT.Add(t)

                        If listT.Count = 2 Then
                            Dim diferenceT As Double = 0
                            For Each objt In listT
                                diferenceT -= t
                            Next


                        End If

                        If TextBoxTimeColission.Text <= t Then

                        End If
                    Next






                    result.Remove(2)
                End If


            End If
        Next
    End Sub
End Class
