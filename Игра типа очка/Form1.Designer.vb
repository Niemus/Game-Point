<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_изменить = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Имя2 = New System.Windows.Forms.Label
        Me.lbl_Имя1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_ИтогПартии = New System.Windows.Forms.Label
        Me.btn_Беру = New System.Windows.Forms.Button
        Me.btn_Хватит = New System.Windows.Forms.Button
        Me.lbl_Играет = New System.Windows.Forms.Label
        Me.lbl_Победитель = New System.Windows.Forms.Label
        Me.btn_Начать = New System.Windows.Forms.Button
        Me.btn_Закончить = New System.Windows.Forms.Button
        Me.txt_Ставка = New System.Windows.Forms.TextBox
        Me.txt_Выигрыш1 = New System.Windows.Forms.TextBox
        Me.txt_Выигрыш2 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Play in OCHKO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ставка:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_изменить
        '
        Me.btn_изменить.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_изменить.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_изменить.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_изменить.Location = New System.Drawing.Point(422, 61)
        Me.btn_изменить.Name = "btn_изменить"
        Me.btn_изменить.Size = New System.Drawing.Size(138, 33)
        Me.btn_изменить.TabIndex = 3
        Me.btn_изменить.Text = "Изменить"
        Me.btn_изменить.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(443, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Выигрыш:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Имя2
        '
        Me.lbl_Имя2.BackColor = System.Drawing.Color.Silver
        Me.lbl_Имя2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Имя2.Location = New System.Drawing.Point(334, 160)
        Me.lbl_Имя2.Name = "lbl_Имя2"
        Me.lbl_Имя2.Size = New System.Drawing.Size(226, 33)
        Me.lbl_Имя2.TabIndex = 8
        Me.lbl_Имя2.Text = "Имя участника"
        Me.lbl_Имя2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Имя1
        '
        Me.lbl_Имя1.BackColor = System.Drawing.Color.Silver
        Me.lbl_Имя1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Имя1.Location = New System.Drawing.Point(117, 160)
        Me.lbl_Имя1.Name = "lbl_Имя1"
        Me.lbl_Имя1.Size = New System.Drawing.Size(220, 33)
        Me.lbl_Имя1.TabIndex = 7
        Me.lbl_Имя1.Text = "Имя участника"
        Me.lbl_Имя1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(117, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 33)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Счет:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ИтогПартии
        '
        Me.lbl_ИтогПартии.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_ИтогПартии.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_ИтогПартии.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ИтогПартии.Location = New System.Drawing.Point(241, 193)
        Me.lbl_ИтогПартии.Name = "lbl_ИтогПартии"
        Me.lbl_ИтогПартии.Size = New System.Drawing.Size(124, 33)
        Me.lbl_ИтогПартии.TabIndex = 10
        Me.lbl_ИтогПартии.Text = "0"
        Me.lbl_ИтогПартии.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Беру
        '
        Me.btn_Беру.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Беру.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Беру.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Беру.Location = New System.Drawing.Point(365, 193)
        Me.btn_Беру.Name = "btn_Беру"
        Me.btn_Беру.Size = New System.Drawing.Size(100, 33)
        Me.btn_Беру.TabIndex = 11
        Me.btn_Беру.Text = "Беру"
        Me.btn_Беру.UseVisualStyleBackColor = False
        '
        'btn_Хватит
        '
        Me.btn_Хватит.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Хватит.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Хватит.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Хватит.Location = New System.Drawing.Point(460, 193)
        Me.btn_Хватит.Name = "btn_Хватит"
        Me.btn_Хватит.Size = New System.Drawing.Size(100, 33)
        Me.btn_Хватит.TabIndex = 12
        Me.btn_Хватит.Text = "Хватит"
        Me.btn_Хватит.UseVisualStyleBackColor = False
        '
        'lbl_Играет
        '
        Me.lbl_Играет.BackColor = System.Drawing.Color.White
        Me.lbl_Играет.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Играет.Location = New System.Drawing.Point(117, 229)
        Me.lbl_Играет.Name = "lbl_Играет"
        Me.lbl_Играет.Size = New System.Drawing.Size(443, 33)
        Me.lbl_Играет.TabIndex = 13
        Me.lbl_Играет.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Победитель
        '
        Me.lbl_Победитель.BackColor = System.Drawing.Color.White
        Me.lbl_Победитель.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Победитель.Location = New System.Drawing.Point(117, 262)
        Me.lbl_Победитель.Name = "lbl_Победитель"
        Me.lbl_Победитель.Size = New System.Drawing.Size(443, 33)
        Me.lbl_Победитель.TabIndex = 14
        Me.lbl_Победитель.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Начать
        '
        Me.btn_Начать.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Начать.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Начать.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Начать.ForeColor = System.Drawing.Color.Black
        Me.btn_Начать.Location = New System.Drawing.Point(117, 295)
        Me.btn_Начать.Name = "btn_Начать"
        Me.btn_Начать.Size = New System.Drawing.Size(220, 33)
        Me.btn_Начать.TabIndex = 15
        Me.btn_Начать.Text = "Начать партию"
        Me.btn_Начать.UseVisualStyleBackColor = False
        '
        'btn_Закончить
        '
        Me.btn_Закончить.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Закончить.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Закончить.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Закончить.Location = New System.Drawing.Point(336, 295)
        Me.btn_Закончить.Name = "btn_Закончить"
        Me.btn_Закончить.Size = New System.Drawing.Size(224, 33)
        Me.btn_Закончить.TabIndex = 16
        Me.btn_Закончить.Text = "Закончить игру"
        Me.btn_Закончить.UseVisualStyleBackColor = False
        '
        'txt_Ставка
        '
        Me.txt_Ставка.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Ставка.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Ставка.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Ставка.Location = New System.Drawing.Point(299, 61)
        Me.txt_Ставка.Multiline = True
        Me.txt_Ставка.Name = "txt_Ставка"
        Me.txt_Ставка.Size = New System.Drawing.Size(125, 33)
        Me.txt_Ставка.TabIndex = 18
        Me.txt_Ставка.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Выигрыш1
        '
        Me.txt_Выигрыш1.BackColor = System.Drawing.Color.Silver
        Me.txt_Выигрыш1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Выигрыш1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Выигрыш1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Выигрыш1.Location = New System.Drawing.Point(117, 127)
        Me.txt_Выигрыш1.Multiline = True
        Me.txt_Выигрыш1.Name = "txt_Выигрыш1"
        Me.txt_Выигрыш1.Size = New System.Drawing.Size(220, 33)
        Me.txt_Выигрыш1.TabIndex = 19
        Me.txt_Выигрыш1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Выигрыш2
        '
        Me.txt_Выигрыш2.BackColor = System.Drawing.Color.Silver
        Me.txt_Выигрыш2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Выигрыш2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Выигрыш2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Выигрыш2.Location = New System.Drawing.Point(336, 127)
        Me.txt_Выигрыш2.Multiline = True
        Me.txt_Выигрыш2.Name = "txt_Выигрыш2"
        Me.txt_Выигрыш2.Size = New System.Drawing.Size(224, 33)
        Me.txt_Выигрыш2.TabIndex = 20
        Me.txt_Выигрыш2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(565, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 54)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Последняя выпавшая карта"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Ваш счёт"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(565, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(12, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(97, 131)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 353)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_Выигрыш2)
        Me.Controls.Add(Me.txt_Выигрыш1)
        Me.Controls.Add(Me.btn_изменить)
        Me.Controls.Add(Me.txt_Ставка)
        Me.Controls.Add(Me.btn_Закончить)
        Me.Controls.Add(Me.btn_Начать)
        Me.Controls.Add(Me.btn_Хватит)
        Me.Controls.Add(Me.btn_Беру)
        Me.Controls.Add(Me.lbl_ИтогПартии)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_Имя2)
        Me.Controls.Add(Me.lbl_Имя1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Играет)
        Me.Controls.Add(Me.lbl_Победитель)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Game 21"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_изменить As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Имя2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Имя1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_ИтогПартии As System.Windows.Forms.Label
    Friend WithEvents btn_Беру As System.Windows.Forms.Button
    Friend WithEvents btn_Хватит As System.Windows.Forms.Button
    Friend WithEvents lbl_Играет As System.Windows.Forms.Label
    Friend WithEvents lbl_Победитель As System.Windows.Forms.Label
    Friend WithEvents btn_Начать As System.Windows.Forms.Button
    Friend WithEvents btn_Закончить As System.Windows.Forms.Button
    Friend WithEvents txt_Ставка As System.Windows.Forms.TextBox
    Friend WithEvents txt_Выигрыш1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Выигрыш2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
