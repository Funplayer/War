' ********************* '
' Class mainForm        '
' By Philip Coelho      '
' ************************************************************************************************************* '
' Form coupled with the rules of Game.vb                                                                        '
' ************************************************************************************************************* '
' Written as a couple to the Game.vb class.  Requires Game.vb to function, Game.vb does not require mainForm.   '
' ************************************************************************************************************* '
' I did all of the visible coding in these files.                                                               '
' I found a card sheet for the card images.                                                                     '
' ************************************************************************************************************* '
Public Class mainForm
    Private _ImageDirectory As String = "\Deck-72x100x16.gif"
    Private _BaseImage As Image
    Private testString As String = ""
    Public game As Game = New Game()
    Private _handCounter As Integer = 0
    Private _WarCounter As Integer = 0
    Private _War2Counter As Integer = 0
    Private _War3Counter As Integer = 0
    Private _War3Fails As Integer = 0

    Private _GamesCounter As Integer = 0
    Private _GameReset As Boolean = False

    Private _p1HandWins As Integer = 0
    Private _p2HandWins As Integer = 0
    Private _p1GameWins As Integer = 0
    Private _p2GameWins As Integer = 0

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _BaseImage = New Bitmap(IO.Directory.GetCurrentDirectory + _ImageDirectory)
        Try
            _BaseImage = New Bitmap(IO.Directory.GetCurrentDirectory + _ImageDirectory)
            game.Setup(CType(_BaseImage, Bitmap))
            pic1pl1MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic1pl2MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic2pl1MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic2pl2MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic3pl1MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic3pl2MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic4pl1MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            pic4pl2MainCard.SizeMode = PictureBoxSizeMode.StretchImage
            lblPlayer1CardCount.Text = CStr(game.P1Hand._cards.Count())
            lblPlayer2CardCount.Text = CStr(game.P2Hand._cards.Count())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' This button was designed to sequence the game in one step intervals.
    ' Just hold enter.
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        game.play()
        _handCounter += 1
        If _handCounter Mod 25 = 0 Then ' Every 25 hands shuffle the decks.
            game.P1Hand.shuffle()
            game.P2Hand.shuffle()
        End If

        lblHands.Text = CStr(_handCounter)
        ' Forked form update.
        If game.IsOver And Not _GameReset Then ' The game is over, form declares winner.
            If game.Winner = 1 Then
                _p1GameWins += 1
                lblP1GameWins.Text = CStr(_p1GameWins)
            ElseIf game.Winner = 2 Then
                _p2GameWins += 1
                lblP2GameWins.Text = CStr(_p2GameWins)
            End If
            lblWinner.Text = "The game is over!  Player " + CStr(game.Winner) + " is victorious!  Praise his epic yolo swag."
            btnPlay.Text = "Restart game?"
            _GameReset = True
        ElseIf _GameReset Then ' Form's active reset button is running, and the game will reset itself if pressed.
            game.reset() ' Reset the entire game.
            lblPlayer1CardCount.Text = CStr(game.P1Hand._cards.Count())
            lblPlayer2CardCount.Text = CStr(game.P2Hand._cards.Count())
            lblWinner.Text = "New game."
            btnPlay.Text = "Play"
            pic1pl1MainCard.Image = Nothing
            pic1pl2MainCard.Image = Nothing
            pic2pl1MainCard.Image = Nothing
            pic2pl2MainCard.Image = Nothing
            pic3pl1MainCard.Image = Nothing
            pic3pl2MainCard.Image = Nothing
            pic4pl1MainCard.Image = Nothing
            pic4pl2MainCard.Image = Nothing
            _GamesCounter += 1
            lblGamesCounter.Text = CStr(_GamesCounter)
            _GameReset = False ' Reset the form's bool to break from normal game case.
        Else
            Select Case game.LastState
                Case 0  ' When game is not in war.
                    pic1pl1MainCard.Image = game.P1PlayCard.Image
                    pic1pl2MainCard.Image = game.P2PlayCard.Image
                    pic2pl1MainCard.Image = Nothing
                    pic2pl2MainCard.Image = Nothing
                    pic3pl1MainCard.Image = Nothing
                    pic3pl2MainCard.Image = Nothing
                    pic4pl1MainCard.Image = Nothing
                    pic4pl2MainCard.Image = Nothing
                    If game.Winner > 0 Then
                        setPlayerWins()
                        lblWinner.Text = "Player " + CStr(game.Winner) + " wins the hand."
                    Else
                        lblWinner.Text = "Dare I say, WAR!?"
                    End If
                Case 1  ' Level 1 war
                    _WarCounter += 1
                    pic2pl1MainCard.Image = game.P1PlayCard.Image
                    pic2pl2MainCard.Image = game.P2PlayCard.Image
                    lblWinner.Text = "War Level 1: Draw 3, Play one:  "
                    If game.Winner = 0 Then
                        lblWinner.Text += "NOBODY WINS!"
                    Else
                        setPlayerWins()
                        lblWinner.Text += "Player " + CStr(game.Winner) + " wins the war... but at what cost?"
                    End If
                Case 2  ' Level 2 war
                    _War2Counter += 1
                    pic3pl1MainCard.Image = game.P1PlayCard.Image
                    pic3pl2MainCard.Image = game.P2PlayCard.Image
                    lblWinner.Text = "War Level 2: Draw 3, Play one: "
                    If game.Winner = 0 Then
                        lblWinner.Text += "NOBODY WINS!"
                    Else
                        setPlayerWins()
                        lblWinner.Text += "Player " + CStr(game.Winner) + " wins the long war, many lives were lost."
                    End If
                Case 3  ' Level 3 war
                    _War3Counter += 1
                    pic4pl1MainCard.Image = game.P1PlayCard.Image
                    pic4pl2MainCard.Image = game.P2PlayCard.Image
                    lblWinner.Text = "War Level 3: Draw 3, Play one: "
                    If game.Winner = 0 Then
                        _War3Fails += 1
                        lblWinner.Text += " NOBODY WINS!!! ALL CARDS DESTROYED!!!!!!1"
                    Else
                        setPlayerWins()
                        lblWinner.Text += "Player " + CStr(game.Winner) + " wins the war to end war, few lives remain."
                    End If
                Case Else

            End Select
            lblPlayer1CardCount.Text = CStr(game.P1Hand._cards.Count())
            lblPlayer2CardCount.Text = CStr(game.P2Hand._cards.Count())
        End If
        lblGamesCounter.Text = CStr(_GamesCounter)
        lblWar1Count.Text = CStr(_WarCounter)
        lblWar2Count.Text = CStr(_War2Counter)
        lblWar3Count.Text = CStr(_War3Counter)
        lblWar3Fails.Text = CStr(_War3Fails)
    End Sub

    Private Sub setPlayerWins()
        If game.Winner = 0 Then

        ElseIf game.Winner = 1 Then
            _p1HandWins += 1
            lblp1HandWins.Text = CStr(_p1HandWins)
        ElseIf game.Winner = 2 Then
            _p2HandWins += 1
            lblP2HandWins.Text = CStr(_p2HandWins)
        End If
    End Sub
End Class
