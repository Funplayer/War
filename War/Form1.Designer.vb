<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.pic1pl1MainCard = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.pic1pl2MainCard = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlayer1CardCount = New System.Windows.Forms.Label()
        Me.lblPlayer2CardCount = New System.Windows.Forms.Label()
        Me.pic2pl1MainCard = New System.Windows.Forms.PictureBox()
        Me.pic3pl1MainCard = New System.Windows.Forms.PictureBox()
        Me.pic4pl1MainCard = New System.Windows.Forms.PictureBox()
        Me.pic2pl2MainCard = New System.Windows.Forms.PictureBox()
        Me.pic3pl2MainCard = New System.Windows.Forms.PictureBox()
        Me.pic4pl2MainCard = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblHands = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWar1Count = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblWar2Count = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblWar3Count = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblWar3Fails = New System.Windows.Forms.Label()
        Me.lblGamesCounter = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblp1HandWins = New System.Windows.Forms.Label()
        Me.lblP1GameWins = New System.Windows.Forms.Label()
        Me.lblP2HandWins = New System.Windows.Forms.Label()
        Me.lblP2GameWins = New System.Windows.Forms.Label()
        CType(Me.pic1pl1MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1pl2MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2pl1MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3pl1MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4pl1MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2pl2MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3pl2MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4pl2MainCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1pl1MainCard
        '
        Me.pic1pl1MainCard.Location = New System.Drawing.Point(12, 12)
        Me.pic1pl1MainCard.Name = "pic1pl1MainCard"
        Me.pic1pl1MainCard.Size = New System.Drawing.Size(113, 148)
        Me.pic1pl1MainCard.TabIndex = 0
        Me.pic1pl1MainCard.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(12, 248)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(436, 23)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'pic1pl2MainCard
        '
        Me.pic1pl2MainCard.Location = New System.Drawing.Point(335, 12)
        Me.pic1pl2MainCard.Name = "pic1pl2MainCard"
        Me.pic1pl2MainCard.Size = New System.Drawing.Size(113, 148)
        Me.pic1pl2MainCard.TabIndex = 2
        Me.pic1pl2MainCard.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cards:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ":Cards"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ":Player 2"
        '
        'lblPlayer1CardCount
        '
        Me.lblPlayer1CardCount.AutoSize = True
        Me.lblPlayer1CardCount.Location = New System.Drawing.Point(106, 164)
        Me.lblPlayer1CardCount.Name = "lblPlayer1CardCount"
        Me.lblPlayer1CardCount.Size = New System.Drawing.Size(13, 13)
        Me.lblPlayer1CardCount.TabIndex = 7
        Me.lblPlayer1CardCount.Text = "0"
        '
        'lblPlayer2CardCount
        '
        Me.lblPlayer2CardCount.AutoSize = True
        Me.lblPlayer2CardCount.Location = New System.Drawing.Point(337, 164)
        Me.lblPlayer2CardCount.Name = "lblPlayer2CardCount"
        Me.lblPlayer2CardCount.Size = New System.Drawing.Size(13, 13)
        Me.lblPlayer2CardCount.TabIndex = 8
        Me.lblPlayer2CardCount.Text = "0"
        '
        'pic2pl1MainCard
        '
        Me.pic2pl1MainCard.Location = New System.Drawing.Point(131, 12)
        Me.pic2pl1MainCard.Name = "pic2pl1MainCard"
        Me.pic2pl1MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic2pl1MainCard.TabIndex = 9
        Me.pic2pl1MainCard.TabStop = False
        '
        'pic3pl1MainCard
        '
        Me.pic3pl1MainCard.Location = New System.Drawing.Point(131, 69)
        Me.pic3pl1MainCard.Name = "pic3pl1MainCard"
        Me.pic3pl1MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic3pl1MainCard.TabIndex = 10
        Me.pic3pl1MainCard.TabStop = False
        '
        'pic4pl1MainCard
        '
        Me.pic4pl1MainCard.Location = New System.Drawing.Point(131, 126)
        Me.pic4pl1MainCard.Name = "pic4pl1MainCard"
        Me.pic4pl1MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic4pl1MainCard.TabIndex = 11
        Me.pic4pl1MainCard.TabStop = False
        '
        'pic2pl2MainCard
        '
        Me.pic2pl2MainCard.Location = New System.Drawing.Point(287, 12)
        Me.pic2pl2MainCard.Name = "pic2pl2MainCard"
        Me.pic2pl2MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic2pl2MainCard.TabIndex = 12
        Me.pic2pl2MainCard.TabStop = False
        '
        'pic3pl2MainCard
        '
        Me.pic3pl2MainCard.Location = New System.Drawing.Point(287, 69)
        Me.pic3pl2MainCard.Name = "pic3pl2MainCard"
        Me.pic3pl2MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic3pl2MainCard.TabIndex = 13
        Me.pic3pl2MainCard.TabStop = False
        '
        'pic4pl2MainCard
        '
        Me.pic4pl2MainCard.Location = New System.Drawing.Point(287, 125)
        Me.pic4pl2MainCard.Name = "pic4pl2MainCard"
        Me.pic4pl2MainCard.Size = New System.Drawing.Size(42, 51)
        Me.pic4pl2MainCard.TabIndex = 14
        Me.pic4pl2MainCard.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total Hands:"
        '
        'lblHands
        '
        Me.lblHands.AutoSize = True
        Me.lblHands.Location = New System.Drawing.Point(253, 125)
        Me.lblHands.Name = "lblHands"
        Me.lblHands.Size = New System.Drawing.Size(13, 13)
        Me.lblHands.TabIndex = 16
        Me.lblHands.Text = "0"
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(12, 232)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(256, 13)
        Me.lblWinner.TabIndex = 17
        Me.lblWinner.Text = "The field where information is stored about the game."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "War Count:"
        '
        'lblWar1Count
        '
        Me.lblWar1Count.AutoSize = True
        Me.lblWar1Count.Location = New System.Drawing.Point(253, 138)
        Me.lblWar1Count.Name = "lblWar1Count"
        Me.lblWar1Count.Size = New System.Drawing.Size(13, 13)
        Me.lblWar1Count.TabIndex = 16
        Me.lblWar1Count.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "War2 Count:"
        '
        'lblWar2Count
        '
        Me.lblWar2Count.AutoSize = True
        Me.lblWar2Count.Location = New System.Drawing.Point(253, 151)
        Me.lblWar2Count.Name = "lblWar2Count"
        Me.lblWar2Count.Size = New System.Drawing.Size(13, 13)
        Me.lblWar2Count.TabIndex = 16
        Me.lblWar2Count.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "War3 Count:"
        '
        'lblWar3Count
        '
        Me.lblWar3Count.AutoSize = True
        Me.lblWar3Count.Location = New System.Drawing.Point(253, 164)
        Me.lblWar3Count.Name = "lblWar3Count"
        Me.lblWar3Count.Size = New System.Drawing.Size(13, 13)
        Me.lblWar3Count.TabIndex = 16
        Me.lblWar3Count.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(187, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "War3 Fails:"
        '
        'lblWar3Fails
        '
        Me.lblWar3Fails.AutoSize = True
        Me.lblWar3Fails.Location = New System.Drawing.Point(253, 177)
        Me.lblWar3Fails.Name = "lblWar3Fails"
        Me.lblWar3Fails.Size = New System.Drawing.Size(13, 13)
        Me.lblWar3Fails.TabIndex = 16
        Me.lblWar3Fails.Text = "0"
        '
        'lblGamesCounter
        '
        Me.lblGamesCounter.AutoSize = True
        Me.lblGamesCounter.Location = New System.Drawing.Point(255, 9)
        Me.lblGamesCounter.Name = "lblGamesCounter"
        Me.lblGamesCounter.Size = New System.Drawing.Size(13, 13)
        Me.lblGamesCounter.TabIndex = 19
        Me.lblGamesCounter.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(177, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Games:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Hand Wins:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(362, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = ":Hand Wins"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Game Wins:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(362, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = ":Game Wins"
        '
        'lblp1HandWins
        '
        Me.lblp1HandWins.AutoSize = True
        Me.lblp1HandWins.Location = New System.Drawing.Point(106, 177)
        Me.lblp1HandWins.Name = "lblp1HandWins"
        Me.lblp1HandWins.Size = New System.Drawing.Size(13, 13)
        Me.lblp1HandWins.TabIndex = 7
        Me.lblp1HandWins.Text = "0"
        '
        'lblP1GameWins
        '
        Me.lblP1GameWins.AutoSize = True
        Me.lblP1GameWins.Location = New System.Drawing.Point(106, 190)
        Me.lblP1GameWins.Name = "lblP1GameWins"
        Me.lblP1GameWins.Size = New System.Drawing.Size(13, 13)
        Me.lblP1GameWins.TabIndex = 7
        Me.lblP1GameWins.Text = "0"
        '
        'lblP2HandWins
        '
        Me.lblP2HandWins.AutoSize = True
        Me.lblP2HandWins.Location = New System.Drawing.Point(337, 177)
        Me.lblP2HandWins.Name = "lblP2HandWins"
        Me.lblP2HandWins.Size = New System.Drawing.Size(13, 13)
        Me.lblP2HandWins.TabIndex = 8
        Me.lblP2HandWins.Text = "0"
        '
        'lblP2GameWins
        '
        Me.lblP2GameWins.AutoSize = True
        Me.lblP2GameWins.Location = New System.Drawing.Point(337, 190)
        Me.lblP2GameWins.Name = "lblP2GameWins"
        Me.lblP2GameWins.Size = New System.Drawing.Size(13, 13)
        Me.lblP2GameWins.TabIndex = 8
        Me.lblP2GameWins.Text = "0"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 284)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGamesCounter)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblWar3Fails)
        Me.Controls.Add(Me.lblWar3Count)
        Me.Controls.Add(Me.lblWar2Count)
        Me.Controls.Add(Me.lblWar1Count)
        Me.Controls.Add(Me.lblHands)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pic4pl2MainCard)
        Me.Controls.Add(Me.pic3pl2MainCard)
        Me.Controls.Add(Me.pic2pl2MainCard)
        Me.Controls.Add(Me.pic4pl1MainCard)
        Me.Controls.Add(Me.pic3pl1MainCard)
        Me.Controls.Add(Me.pic2pl1MainCard)
        Me.Controls.Add(Me.lblP2GameWins)
        Me.Controls.Add(Me.lblP2HandWins)
        Me.Controls.Add(Me.lblPlayer2CardCount)
        Me.Controls.Add(Me.lblP1GameWins)
        Me.Controls.Add(Me.lblp1HandWins)
        Me.Controls.Add(Me.lblPlayer1CardCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic1pl2MainCard)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.pic1pl1MainCard)
        Me.Name = "mainForm"
        Me.Text = "War"
        CType(Me.pic1pl1MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1pl2MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2pl1MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3pl1MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4pl1MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2pl2MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3pl2MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4pl2MainCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1pl1MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents pic1pl2MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1CardCount As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2CardCount As System.Windows.Forms.Label
    Friend WithEvents pic2pl1MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents pic3pl1MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents pic4pl1MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents pic2pl2MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents pic3pl2MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents pic4pl2MainCard As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblHands As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblWar1Count As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblWar2Count As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblWar3Count As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblWar3Fails As System.Windows.Forms.Label
    Friend WithEvents lblGamesCounter As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblp1HandWins As System.Windows.Forms.Label
    Friend WithEvents lblP1GameWins As System.Windows.Forms.Label
    Friend WithEvents lblP2HandWins As System.Windows.Forms.Label
    Friend WithEvents lblP2GameWins As System.Windows.Forms.Label

End Class
