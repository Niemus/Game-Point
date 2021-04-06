Public Class Form1
    Dim Игрок1 As Boolean 'Играет первый игрок.
    Dim Ставка As Single ' Размер ставки в рублях.
    Dim Выигрыш1 As Single 'Выигрыш первого игрока.
    Dim Выигрыш2 As Single 'Выигрыш второго игрока.
    Dim ИтогПартии As Integer 'Итог партии игрока.
    Dim ПройПолПар As Boolean 'Первый из играющих
    'партию закончил, не перебрав 21 очко.
    Dim ИтогПартии1 As Integer 'Итог партии первого игрока.
    Dim ИтогПартии2 As Integer 'Итог партии второго игрока.    Dim iRand As Integer
    Dim oRand = New Random()
    Private Function Денежный(ByVal Сумма As Single) As String
        Денежный = Format(Сумма, "0.00 руб.")
    End Function

    Private Sub txt_Ставка_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ставка.TextChanged

    End Sub
    Private Sub txt_Выигрыш2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Выигрыш2.TextChanged

    End Sub
    Private Sub txt_Выигрыш1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Выигрыш1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Ставка = 100
        txt_Ставка.Text = Денежный(Ставка)
        txt_Выигрыш1.Text = Денежный(Выигрыш1)
        txt_Выигрыш2.Text = Денежный(Выигрыш2)
        btn_Беру.Enabled = False
        btn_Хватит.Enabled = False
        lbl_Играет.Visible = False
        lbl_Победитель.Visible = False
        lbl_Имя1.Text = InputBox("Введите имя первого участника игры")
        lbl_Имя2.Text = InputBox("Введите имя второго участника игры")
    End Sub

    Private Sub btn_изменить_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_изменить.Click
        Ставка = Math.Abs(CSng(InputBox("Задайте новое значение ставки.")))
        txt_Ставка.Text = Денежный(Ставка)
    End Sub

    Private Sub btn_Начать_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Начать.Click
        ИтогПартии = 0
        ИтогПартии1 = 0
        ИтогПартии2 = 0
        btn_изменить.Enabled = False
        btn_Беру.Enabled = True
        btn_Хватит.Enabled = True
        lbl_Победитель.Visible = False
        Игрок1 = False
        If Rnd() >= 0.5 Then Игрок1 = True
        If Игрок1 Then
            lbl_Играет.Text = "Играет " & lbl_Имя1.Text
        Else
            lbl_Играет.Text = "Играет " & lbl_Имя2.Text
        End If
        lbl_ИтогПартии.Text = 0
        lbl_Играет.Visible = True
        ПройПолПар = False
        btn_Начать.Enabled = False
    End Sub

    Private Sub lbl_Имя2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Имя2.Click

    End Sub

    Private Sub btn_Беру_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Беру.Click
        
        oRand = New Random(DateTime.Now.Millisecond)
        iRand = oRand.Next(1, 10)
        'ИтогПартии = ИтогПартии + Int(Rnd() * (10 - 1))
        ИтогПартии = ИтогПартии + iRand
        lbl_ИтогПартии.Text = ИтогПартии
        If ИтогПартии > 21 Then
            btn_Начать.Enabled = True
            btn_Беру.Enabled = False
            btn_Хватит.Enabled = False
            lbl_Играет.Visible = False
            MsgBox("Перебор! Итог= " & ИтогПартии)
            If Игрок1 Then
                Выигрыш2 = Выигрыш2 + Ставка
                txt_Выигрыш2.Text = Денежный(Выигрыш2)
                lbl_Победитель.Text = _
                "Победитель – " & lbl_Имя2.Text & "!"
                lbl_Победитель.Visible = True
            Else
                Выигрыш1 = Выигрыш1 + Ставка
                txt_Выигрыш1.Text = Денежный(Выигрыш1)
                lbl_Победитель.Text = _
                " Победитель – " & lbl_Имя1.Text & "!"
                lbl_Победитель.Visible = True
            End If
        End If
    End Sub

    Private Sub btn_Хватит_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Хватит.Click
        lbl_ИтогПартии.Text = 0
        If Игрок1 Then
            ИтогПартии1 = ИтогПартии
        Else
5:          ИтогПартии2 = ИтогПартии
        End If
        ИтогПартии = 0
        If ПройПолПар Then
            btn_Начать.Enabled = True
10:         btn_Беру.Enabled = False
            btn_Хватит.Enabled = False
            lbl_Играет.Visible = False
            If ИтогПартии1 > ИтогПартии2 Then
                Выигрыш1 = Выигрыш1 + Ставка
15:             txt_Выигрыш1.Text = Денежный(Выигрыш1)
                lbl_Победитель.Text = _
                " Победитель – " & lbl_Имя1.Text & "!"
                lbl_Победитель.Visible = True
            End If
            If ИтогПартии1 < ИтогПартии2 Then
20:             Выигрыш2 = Выигрыш2 + Ставка
                txt_Выигрыш2.Text = Денежный(Выигрыш2)
                lbl_Победитель.Text = _
                " Победитель – " & lbl_Имя2.Text & "!"
                lbl_Победитель.Visible = True
            End If
25:         If ИтогПартии1 = ИтогПартии2 Then
                Выигрыш1 = Выигрыш1 + Ставка / 2
                txt_Выигрыш1.Text = Денежный(Выигрыш1)
                Выигрыш2 = Выигрыш2 + Ставка / 2
                txt_Выигрыш2.Text = Денежный(Выигрыш2)
30:             lbl_Победитель.Text = "Ничья!"
                lbl_Победитель.Visible = True
            End If
            MsgBox("Итог партии: " & lbl_Имя1.Text & _
            " - " & ИтогПартии1 & "; " _
            & lbl_Имя2.Text & " - " & ИтогПартии2)
        Else
35:         Игрок1 = Not Игрок1
            If Игрок1 Then
                lbl_Играет.Text = "Играет " & lbl_Имя1.Text
            Else
                lbl_Играет.Text = "Играет " & lbl_Имя2.Text
40:         End If
            lbl_ИтогПартии.Text = 0
            lbl_Играет.Visible = True
        End If
        ПройПолПар = True
    End Sub

    Private Sub btn_Закончить_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Закончить.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If iRand = 1 Then
            PictureBox1.Image = My.Resources.Card_1
        ElseIf iRand = 2 Then
            PictureBox1.Image = My.Resources.Card_2
        ElseIf iRand = 3 Then
            PictureBox1.Image = My.Resources.Card_3
        ElseIf iRand = 4 Then
            PictureBox1.Image = My.Resources.Card_4
        ElseIf iRand = 5 Then
            PictureBox1.Image = My.Resources.Card_5
        ElseIf iRand = 6 Then
            PictureBox1.Image = My.Resources.Card_6
        ElseIf iRand = 7 Then
            PictureBox1.Image = My.Resources.Card_7
        ElseIf iRand = 8 Then
            PictureBox1.Image = My.Resources.Card_8
        ElseIf iRand = 9 Then
            PictureBox1.Image = My.Resources.Card_9
        End If

        If lbl_ИтогПартии.Text = 1 Then
            PictureBox2.Image = My.Resources.Card_1
        ElseIf lbl_ИтогПартии.Text = 2 Then
            PictureBox2.Image = My.Resources.Card_2
        ElseIf lbl_ИтогПартии.Text = 3 Then
            PictureBox2.Image = My.Resources.Card_3
        ElseIf lbl_ИтогПартии.Text = 4 Then
            PictureBox2.Image = My.Resources.Card_4
        ElseIf lbl_ИтогПартии.Text = 5 Then
            PictureBox2.Image = My.Resources.Card_5
        ElseIf lbl_ИтогПартии.Text = 6 Then
            PictureBox2.Image = My.Resources.Card_6
        ElseIf lbl_ИтогПартии.Text = 7 Then
            PictureBox2.Image = My.Resources.Card_7
        ElseIf lbl_ИтогПартии.Text = 8 Then
            PictureBox2.Image = My.Resources.Card_8
        ElseIf lbl_ИтогПартии.Text = 9 Then
            PictureBox2.Image = My.Resources.Card_9
        ElseIf lbl_ИтогПартии.Text = 10 Then
            PictureBox2.Image = My.Resources.Card_10
        ElseIf lbl_ИтогПартии.Text = 11 Then
            PictureBox2.Image = My.Resources.Card_11
        ElseIf lbl_ИтогПартии.Text = 12 Then
            PictureBox2.Image = My.Resources.Card_12
        ElseIf lbl_ИтогПартии.Text = 13 Then
            PictureBox2.Image = My.Resources.Card_13
        ElseIf lbl_ИтогПартии.Text = 14 Then
            PictureBox2.Image = My.Resources.Card_14
        ElseIf lbl_ИтогПартии.Text = 15 Then
            PictureBox2.Image = My.Resources.Card_15
        ElseIf lbl_ИтогПартии.Text = 16 Then
            PictureBox2.Image = My.Resources.Card_16
        ElseIf lbl_ИтогПартии.Text = 17 Then
            PictureBox2.Image = My.Resources.Card_17
        ElseIf lbl_ИтогПартии.Text = 18 Then
            PictureBox2.Image = My.Resources.Card_18
        ElseIf lbl_ИтогПартии.Text = 19 Then
            PictureBox2.Image = My.Resources.Card_19
        ElseIf lbl_ИтогПартии.Text = 20 Then
            PictureBox2.Image = My.Resources.Card_20
        ElseIf lbl_ИтогПартии.Text = 21 Then
            PictureBox2.Image = My.Resources.Card_21

        End If
    End Sub
End Class
