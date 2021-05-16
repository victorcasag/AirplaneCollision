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

        Return Math.Round(y, 2)
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

    'End Functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInsertPlane.Click
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

            RotateImage(objAviao.ImageAviao, objAviao.Direcao)

            BindingSourceAviao.DataSource = Nothing
            BindingSourceAviao.DataSource = listAviao

            Panel1.Invalidate()

            DataGridViewDadosAviao.Refresh()
            Panel1.Refresh()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        Dim m As New Matrix()

        If flag Then

            count += 1
            For Each objAviao In listAviao

                ' m.Rotate(objAviao.Direcao)

                'e.Graphics.Transform = m

                e.Graphics.DrawImage(objAviao.ImageAviao, objAviao.X, objAviao.Y)

                'e.Graphics.ResetTransform()

            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTranslandar.Click

        Dim row As DataGridViewRow

        row = DataGridViewDadosAviao.Rows

        'For Each row As DataGridViewRow In DataGridViewDadosAviao.Rows

        'Next

        Select Case row

            Case 



        End Select



    End Sub
End Class
