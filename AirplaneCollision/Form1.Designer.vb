<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonRemoveRow = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonInsertPlane = New System.Windows.Forms.Button()
        Me.TextBoxRaio = New System.Windows.Forms.TextBox()
        Me.TextBoxY = New System.Windows.Forms.TextBox()
        Me.TextBoxAngulo = New System.Windows.Forms.TextBox()
        Me.TextBoxDirecao = New System.Windows.Forms.TextBox()
        Me.TextBoxVelocidade = New System.Windows.Forms.TextBox()
        Me.TextBoxX = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonEscalonar = New System.Windows.Forms.Button()
        Me.TextBoxXEscalonar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxYEscalonar = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBoxXTranslandar = New System.Windows.Forms.TextBox()
        Me.ButtonTranslandar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxYTranslandar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonRotacionar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTimeColission = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ButtonRotaColisão = New System.Windows.Forms.Button()
        Me.ButtonAviõesProximos = New System.Windows.Forms.Button()
        Me.ButtonAviõesAeroportos = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxReport = New System.Windows.Forms.RichTextBox()
        Me.DataGridViewDadosAviao = New System.Windows.Forms.DataGridView()
        Me.IsValidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RaioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnguloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VelocidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceAviao = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewDadosAviao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceAviao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonRemoveRow)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonInsertPlane)
        Me.GroupBox1.Controls.Add(Me.TextBoxRaio)
        Me.GroupBox1.Controls.Add(Me.TextBoxY)
        Me.GroupBox1.Controls.Add(Me.TextBoxAngulo)
        Me.GroupBox1.Controls.Add(Me.TextBoxDirecao)
        Me.GroupBox1.Controls.Add(Me.TextBoxVelocidade)
        Me.GroupBox1.Controls.Add(Me.TextBoxX)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inserir Dados"
        '
        'ButtonRemoveRow
        '
        Me.ButtonRemoveRow.Location = New System.Drawing.Point(41, 133)
        Me.ButtonRemoveRow.Name = "ButtonRemoveRow"
        Me.ButtonRemoveRow.Size = New System.Drawing.Size(104, 35)
        Me.ButtonRemoveRow.TabIndex = 19
        Me.ButtonRemoveRow.Text = "Remove"
        Me.ButtonRemoveRow.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Direção:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Ângulo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Y:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Velocidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Raio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "X:"
        '
        'ButtonInsertPlane
        '
        Me.ButtonInsertPlane.Location = New System.Drawing.Point(240, 133)
        Me.ButtonInsertPlane.Name = "ButtonInsertPlane"
        Me.ButtonInsertPlane.Size = New System.Drawing.Size(104, 35)
        Me.ButtonInsertPlane.TabIndex = 6
        Me.ButtonInsertPlane.Text = "Inserir"
        Me.ButtonInsertPlane.UseVisualStyleBackColor = True
        '
        'TextBoxRaio
        '
        Me.TextBoxRaio.Location = New System.Drawing.Point(107, 56)
        Me.TextBoxRaio.Name = "TextBoxRaio"
        Me.TextBoxRaio.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxRaio.TabIndex = 2
        '
        'TextBoxY
        '
        Me.TextBoxY.Location = New System.Drawing.Point(299, 30)
        Me.TextBoxY.Name = "TextBoxY"
        Me.TextBoxY.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxY.TabIndex = 1
        '
        'TextBoxAngulo
        '
        Me.TextBoxAngulo.Location = New System.Drawing.Point(299, 56)
        Me.TextBoxAngulo.Name = "TextBoxAngulo"
        Me.TextBoxAngulo.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxAngulo.TabIndex = 3
        '
        'TextBoxDirecao
        '
        Me.TextBoxDirecao.Location = New System.Drawing.Point(299, 82)
        Me.TextBoxDirecao.Name = "TextBoxDirecao"
        Me.TextBoxDirecao.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxDirecao.TabIndex = 5
        '
        'TextBoxVelocidade
        '
        Me.TextBoxVelocidade.Location = New System.Drawing.Point(107, 82)
        Me.TextBoxVelocidade.Name = "TextBoxVelocidade"
        Me.TextBoxVelocidade.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxVelocidade.TabIndex = 4
        '
        'TextBoxX
        '
        Me.TextBoxX.Location = New System.Drawing.Point(107, 30)
        Me.TextBoxX.Name = "TextBoxX"
        Me.TextBoxX.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxX.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 217)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alterar Dados"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.ButtonEscalonar)
        Me.GroupBox5.Controls.Add(Me.TextBoxXEscalonar)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TextBoxYEscalonar)
        Me.GroupBox5.Location = New System.Drawing.Point(180, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(164, 93)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Escalonar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(2, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "UN %"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Y:"
        '
        'ButtonEscalonar
        '
        Me.ButtonEscalonar.Location = New System.Drawing.Point(37, 50)
        Me.ButtonEscalonar.Name = "ButtonEscalonar"
        Me.ButtonEscalonar.Size = New System.Drawing.Size(97, 31)
        Me.ButtonEscalonar.TabIndex = 2
        Me.ButtonEscalonar.Text = "Escalonar"
        Me.ButtonEscalonar.UseVisualStyleBackColor = True
        '
        'TextBoxXEscalonar
        '
        Me.TextBoxXEscalonar.Location = New System.Drawing.Point(35, 21)
        Me.TextBoxXEscalonar.Name = "TextBoxXEscalonar"
        Me.TextBoxXEscalonar.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxXEscalonar.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "X:"
        '
        'TextBoxYEscalonar
        '
        Me.TextBoxYEscalonar.Location = New System.Drawing.Point(108, 21)
        Me.TextBoxYEscalonar.Name = "TextBoxYEscalonar"
        Me.TextBoxYEscalonar.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxYEscalonar.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBoxXTranslandar)
        Me.GroupBox6.Controls.Add(Me.ButtonTranslandar)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.TextBoxYTranslandar)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(164, 91)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Traslacender"
        '
        'TextBoxXTranslandar
        '
        Me.TextBoxXTranslandar.Location = New System.Drawing.Point(32, 19)
        Me.TextBoxXTranslandar.Name = "TextBoxXTranslandar"
        Me.TextBoxXTranslandar.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxXTranslandar.TabIndex = 0
        '
        'ButtonTranslandar
        '
        Me.ButtonTranslandar.Location = New System.Drawing.Point(35, 48)
        Me.ButtonTranslandar.Name = "ButtonTranslandar"
        Me.ButtonTranslandar.Size = New System.Drawing.Size(97, 31)
        Me.ButtonTranslandar.TabIndex = 2
        Me.ButtonTranslandar.Text = "Translandar"
        Me.ButtonTranslandar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "X:"
        '
        'TextBoxYTranslandar
        '
        Me.TextBoxYTranslandar.Location = New System.Drawing.Point(107, 19)
        Me.TextBoxYTranslandar.Name = "TextBoxYTranslandar"
        Me.TextBoxYTranslandar.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxYTranslandar.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Y:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.TextBox13)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.ButtonRotacionar)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.TextBox11)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.TextBox12)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 120)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(338, 86)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Rotacionar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(174, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Centro de Rotação:"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(198, 43)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(45, 20)
        Me.TextBox13.TabIndex = 1
        Me.TextBox13.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Direção:"
        '
        'ButtonRotacionar
        '
        Me.ButtonRotacionar.Location = New System.Drawing.Point(32, 46)
        Me.ButtonRotacionar.Name = "ButtonRotacionar"
        Me.ButtonRotacionar.Size = New System.Drawing.Size(97, 31)
        Me.ButtonRotacionar.TabIndex = 3
        Me.ButtonRotacionar.Text = "Rotacionar"
        Me.ButtonRotacionar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(175, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "X:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(81, 16)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(45, 20)
        Me.TextBox11.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(249, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Y:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(273, 43)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(45, 20)
        Me.TextBox12.TabIndex = 2
        Me.TextBox12.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TextBoxTimeColission)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TextBox15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBox14)
        Me.GroupBox3.Controls.Add(Me.ButtonRotaColisão)
        Me.GroupBox3.Controls.Add(Me.ButtonAviõesProximos)
        Me.GroupBox3.Controls.Add(Me.ButtonAviõesAeroportos)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 427)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 143)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Distancias"
        '
        'TextBoxTimeColission
        '
        Me.TextBoxTimeColission.Location = New System.Drawing.Point(542, 44)
        Me.TextBoxTimeColission.Name = "TextBoxTimeColission"
        Me.TextBoxTimeColission.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxTimeColission.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(461, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Tempo Minimo:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(339, 44)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(45, 20)
        Me.TextBox15.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(246, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Distancia Minima:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Distancia Minima:"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(139, 44)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(45, 20)
        Me.TextBox14.TabIndex = 0
        '
        'ButtonRotaColisão
        '
        Me.ButtonRotaColisão.Location = New System.Drawing.Point(467, 97)
        Me.ButtonRotaColisão.Name = "ButtonRotaColisão"
        Me.ButtonRotaColisão.Size = New System.Drawing.Size(120, 31)
        Me.ButtonRotaColisão.TabIndex = 5
        Me.ButtonRotaColisão.Text = "Em Rota de Colisão"
        Me.ButtonRotaColisão.UseVisualStyleBackColor = True
        '
        'ButtonAviõesProximos
        '
        Me.ButtonAviõesProximos.Location = New System.Drawing.Point(288, 97)
        Me.ButtonAviõesProximos.Name = "ButtonAviõesProximos"
        Me.ButtonAviõesProximos.Size = New System.Drawing.Size(96, 31)
        Me.ButtonAviõesProximos.TabIndex = 4
        Me.ButtonAviõesProximos.Text = "Aviões Proximos"
        Me.ButtonAviõesProximos.UseVisualStyleBackColor = True
        '
        'ButtonAviõesAeroportos
        '
        Me.ButtonAviõesAeroportos.Location = New System.Drawing.Point(8, 97)
        Me.ButtonAviõesAeroportos.Name = "ButtonAviõesAeroportos"
        Me.ButtonAviõesAeroportos.Size = New System.Drawing.Size(176, 31)
        Me.ButtonAviõesAeroportos.TabIndex = 3
        Me.ButtonAviõesAeroportos.Text = "Aviões proximos ao Aeroporto"
        Me.ButtonAviõesAeroportos.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.RichTextBoxReport)
        Me.GroupBox4.Location = New System.Drawing.Point(910, 274)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(454, 296)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Relatório"
        '
        'RichTextBoxReport
        '
        Me.RichTextBoxReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxReport.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxReport.Name = "RichTextBoxReport"
        Me.RichTextBoxReport.Size = New System.Drawing.Size(437, 271)
        Me.RichTextBoxReport.TabIndex = 0
        Me.RichTextBoxReport.Text = ""
        '
        'DataGridViewDadosAviao
        '
        Me.DataGridViewDadosAviao.AllowUserToAddRows = False
        Me.DataGridViewDadosAviao.AllowUserToDeleteRows = False
        Me.DataGridViewDadosAviao.AllowUserToResizeColumns = False
        Me.DataGridViewDadosAviao.AllowUserToResizeRows = False
        Me.DataGridViewDadosAviao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDadosAviao.AutoGenerateColumns = False
        Me.DataGridViewDadosAviao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDadosAviao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsValidDataGridViewCheckBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.RaioDataGridViewTextBoxColumn, Me.AnguloDataGridViewTextBoxColumn, Me.VelocidadeDataGridViewTextBoxColumn, Me.DirecaoDataGridViewTextBoxColumn})
        Me.DataGridViewDadosAviao.DataSource = Me.BindingSourceAviao
        Me.DataGridViewDadosAviao.Location = New System.Drawing.Point(910, 18)
        Me.DataGridViewDadosAviao.MultiSelect = False
        Me.DataGridViewDadosAviao.Name = "DataGridViewDadosAviao"
        Me.DataGridViewDadosAviao.RowHeadersVisible = False
        Me.DataGridViewDadosAviao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDadosAviao.Size = New System.Drawing.Size(454, 250)
        Me.DataGridViewDadosAviao.TabIndex = 4
        '
        'IsValidDataGridViewCheckBoxColumn
        '
        Me.IsValidDataGridViewCheckBoxColumn.DataPropertyName = "IsValid"
        Me.IsValidDataGridViewCheckBoxColumn.HeaderText = "IsValid"
        Me.IsValidDataGridViewCheckBoxColumn.Name = "IsValidDataGridViewCheckBoxColumn"
        Me.IsValidDataGridViewCheckBoxColumn.Width = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'XDataGridViewTextBoxColumn
        '
        Me.XDataGridViewTextBoxColumn.DataPropertyName = "X"
        Me.XDataGridViewTextBoxColumn.HeaderText = "X"
        Me.XDataGridViewTextBoxColumn.Name = "XDataGridViewTextBoxColumn"
        Me.XDataGridViewTextBoxColumn.ReadOnly = True
        Me.XDataGridViewTextBoxColumn.Width = 50
        '
        'YDataGridViewTextBoxColumn
        '
        Me.YDataGridViewTextBoxColumn.DataPropertyName = "Y"
        Me.YDataGridViewTextBoxColumn.HeaderText = "Y"
        Me.YDataGridViewTextBoxColumn.Name = "YDataGridViewTextBoxColumn"
        Me.YDataGridViewTextBoxColumn.ReadOnly = True
        Me.YDataGridViewTextBoxColumn.Width = 50
        '
        'RaioDataGridViewTextBoxColumn
        '
        Me.RaioDataGridViewTextBoxColumn.DataPropertyName = "Raio"
        Me.RaioDataGridViewTextBoxColumn.HeaderText = "Raio"
        Me.RaioDataGridViewTextBoxColumn.Name = "RaioDataGridViewTextBoxColumn"
        Me.RaioDataGridViewTextBoxColumn.ReadOnly = True
        Me.RaioDataGridViewTextBoxColumn.Width = 50
        '
        'AnguloDataGridViewTextBoxColumn
        '
        Me.AnguloDataGridViewTextBoxColumn.DataPropertyName = "Angulo"
        Me.AnguloDataGridViewTextBoxColumn.HeaderText = "Angulo"
        Me.AnguloDataGridViewTextBoxColumn.Name = "AnguloDataGridViewTextBoxColumn"
        Me.AnguloDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnguloDataGridViewTextBoxColumn.Width = 50
        '
        'VelocidadeDataGridViewTextBoxColumn
        '
        Me.VelocidadeDataGridViewTextBoxColumn.DataPropertyName = "Velocidade"
        Me.VelocidadeDataGridViewTextBoxColumn.HeaderText = "Velocidade"
        Me.VelocidadeDataGridViewTextBoxColumn.Name = "VelocidadeDataGridViewTextBoxColumn"
        Me.VelocidadeDataGridViewTextBoxColumn.ReadOnly = True
        Me.VelocidadeDataGridViewTextBoxColumn.Width = 75
        '
        'DirecaoDataGridViewTextBoxColumn
        '
        Me.DirecaoDataGridViewTextBoxColumn.DataPropertyName = "Direcao"
        Me.DirecaoDataGridViewTextBoxColumn.HeaderText = "Direcao"
        Me.DirecaoDataGridViewTextBoxColumn.Name = "DirecaoDataGridViewTextBoxColumn"
        Me.DirecaoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DirecaoDataGridViewTextBoxColumn.Width = 75
        '
        'BindingSourceAviao
        '
        Me.BindingSourceAviao.DataSource = GetType(AirplaneCollision.aviao.Aviao)
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(371, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 403)
        Me.Panel1.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(473, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Segundos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewDadosAviao)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewDadosAviao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceAviao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewDadosAviao As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonInsertPlane As Button
    Friend WithEvents TextBoxRaio As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextBoxAngulo As TextBox
    Friend WithEvents TextBoxDirecao As TextBox
    Friend WithEvents TextBoxVelocidade As TextBox
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents RichTextBoxReport As RichTextBox
    Friend WithEvents ButtonEscalonar As Button
    Friend WithEvents ButtonTranslandar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxYEscalonar As TextBox
    Friend WithEvents TextBoxXEscalonar As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBoxXTranslandar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxYTranslandar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonRotacionar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents ButtonAviõesAeroportos As Button
    Friend WithEvents TextBoxTimeColission As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents ButtonRotaColisão As Button
    Friend WithEvents ButtonAviõesProximos As Button
    Friend WithEvents BindingSourceAviao As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonRemoveRow As Button
    Friend WithEvents IsValidDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RaioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnguloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VelocidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
