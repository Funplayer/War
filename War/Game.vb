' ************************ '
' Game of War              '
' Created by Philip Coelho '
' ******************************************************************* '
' Contains the functionality and rules of the game.                   '
' ******************************************************************* '
' Rules custom and adapted from childhood card game rules.            '
'                                                                     '
' Game rules:                                                         '
'   1. Both players place a card down from their individual hand.     '
'   2. Highest card wins, ace is lowest.                              '
'   3. Paired cards trigger war, 3 cards are placed face up,          '
'      one card is drawn as the play card. Rule 2 applies here again. '
'   4. War can continue for 3 turns, if the cards match after that,   '
'      the game automatically destroys all of the cards in play.      '
'   5. You lose the game when you cannot draw another card.           '
' ******************************************************************* '
Public Class Game
    ' DeckImage
    '   Contains the deck image.
    Private _DeckImage As Bitmap

    ' Scores
    '   Individual scores of who has taken more cards overall.
    Private _p1Score As Integer = 0
    Private _p2Score As Integer = 0

    ' Hand
    '   Contains functionality, and individual cards for hands.
    Private _p1Hand As Hand = New Hand()
    Private _p2Hand As Hand = New Hand()

    ' Active cards
    '   Lists containing all active cards for the current hand.
    Public P1ActiveCards As New LinkedList(Of Card)
    Public P2ActiveCards As New LinkedList(Of Card)

    ' Post cards
    '   After the hand is completed, the play card is displayed here.
    '   Used as a temp card for screen display.
    Public P1PlayCard As Card
    Public P2PlayCard As Card

    Public Winner As Integer = 0

    ' Deck
    '   Contains all functionality of the main deck, only used once to create the deck of cards.
    Private _MainDeck As Deck = New Deck()

    Public LastState As Integer = 0

    Public IsOver As Boolean = False

    ' State
    ' Abstract representation of the game's current state based on parameters.
    '   0 normal play
    '   1 war level 1
    '   2 war level 2
    '   3 war level 3 - Final state, when matched all cards discarded.
    Private _State As Integer = 0

    Private ReadOnly Property State As Integer
        Get
            Return _State
        End Get
    End Property

    Public Property P1Hand As Hand
        Get
            Return _p1Hand
        End Get
        Set(value As Hand)
            _p1Hand = value
        End Set
    End Property

    Public Property P2Hand As Hand
        Get
            Return _p2Hand
        End Get
        Set(value As Hand)
            _p2Hand = value
        End Set
    End Property

    ' This contains the functionality to progress the game by one step.
    Public Sub play()
        Try
            SetCards()      ' Set starting cards into play.
            CheckWar()      ' Determines war.
            FinishHand()    ' Complete the current hand.
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Step 1 Move one card from each hand, to active cards.
    Private Sub SetCards()
        ' Player 1 loses game.
        If (_p1Hand._cards.Count() - 1 > 0 And _p2Hand._cards.Count() - 1 > 0) Then
            ' Add to the persistant player card list.
            P1ActiveCards.AddLast(_p1Hand.Draw)
            P2ActiveCards.AddLast(_p2Hand.Draw)
            ' Set the temp cards
            P1PlayCard = P1ActiveCards.Last.Value
            P2PlayCard = P2ActiveCards.Last.Value
        Else ' One of the players have lost.
            IsOver = True
            Try ' Check player 1 deck, if cannot draw declare player 2 as winner of game.
                P1PlayCard = _p1Hand.Draw
                P1PlayCard = _p1Hand.Draw
                P1PlayCard = _p1Hand.Draw
                P1PlayCard = _p1Hand.Draw
            Catch ex As Exception
                Winner = 2
            End Try
            Try ' CHeck player 2 deck, if cannot draw declare player 1 as winner of game.
                P2PlayCard = _p2Hand.Draw
                P2PlayCard = _p2Hand.Draw
                P2PlayCard = _p2Hand.Draw
                P2PlayCard = _p2Hand.Draw
            Catch ex As Exception
                Winner = 1
            End Try
        End If
    End Sub

    ' Step 2 check the war status of the current hand
    Private Sub CheckWar()
        ' Set the state of the visible game to the state of the game before the hand.
        LastState = _State
        ' If numbers match, determine war.
        If Not IsOver Then
            If P1PlayCard.Number = P2PlayCard.Number And _State <= 3 Then
                _State += 1 ' Entered war state, or progressed war states.
                Winner = 0
            ElseIf _State > 3 Then
                _State = 9
            Else
                _State = 0 ' Restore the war state to 0
            End If
        Else
            _State = 0
        End If
    End Sub

    ' Step 3 finish the hand and reward cards if necessary
    Private Sub FinishHand()
        If Not IsOver Then
            Select Case Me.State
                ' War state reward checker.
                Case 0  ' No active war, winner collects.
                    ' Determine winner
                    'Dim p1Wins As Boolean = P1ActiveCards(_activePosition).Number > P2ActiveCards(_activePosition).Number
                    Dim p1wins As Boolean = P1PlayCard.Number > P2PlayCard.Number
                    If p1Wins Then
                        Winner = 1
                    Else
                        Winner = 2
                    End If
                    reward(p1Wins)
                Case 9 ' Game is over the counter for the state, all active cards must be sent to main deck discard.
                    destroy()
                Case Else  ' Active war, play 3 cards
                    For counter As Integer = 0 To 2
                        P1ActiveCards.AddLast(P1Hand.Draw)
                        P2ActiveCards.AddLast(P2Hand.Draw)
                    Next
            End Select
        End If
    End Sub

    ' Used to completely destroy the active cards from the playfield.
    Private Sub destroy()
        ' Get cards to player 1 and 2 hands from the gamplay field into the correct hand.
        While P1ActiveCards.Count > 0
            P1ActiveCards.RemoveLast()
        End While
        While P2ActiveCards.Count > 0
            P2ActiveCards.RemoveLast()
        End While
    End Sub

    Private Sub reward(p1wins As Boolean)
        ' Get cards to player 1 and 2 hands from the gamplay field into the correct hand.
        While P1ActiveCards.Count > 0
            If p1wins Then
                P1Hand.Grab = P1ActiveCards.Last.Value
            Else
                P2Hand.Grab = P1ActiveCards.Last.Value
            End If
            P1ActiveCards.RemoveLast()
        End While
        While P2ActiveCards.Count > 0
            If p1wins Then
                P1Hand.Grab = P2ActiveCards.Last.Value
            Else
                P2Hand.Grab = P2ActiveCards.Last.Value
            End If
            P2ActiveCards.RemoveLast()
        End While
    End Sub

    ' Required setup for graphic.
    Public Sub Setup(inputImage As Bitmap)
        DeckImage = inputImage
        MainDeck = New Deck()
        MainDeck.setup(inputImage)
        createPlayers()
    End Sub

    Private Sub createPlayers()
        'Todo Create Players
        P1Hand._cards.Clear()
        P2Hand._cards.Clear()
        For count As Integer = 0 To 51 Step 2
            P1Hand.Grab = MainDeck.Draw
            P2Hand.Grab = MainDeck.Draw
        Next
    End Sub

    Public Sub reset()
        P1PlayCard = Nothing
        P2PlayCard = Nothing
        P1ActiveCards.Clear()
        P2ActiveCards.Clear()
        Winner = 0
        _State = 0
        LastState = 0
        IsOver = False
        Setup(DeckImage)
    End Sub

    Private Property MainDeck As Deck
        Get
            Return _MainDeck
        End Get
        Set(value As Deck)
            _MainDeck = value
        End Set
    End Property

    Private Property DeckImage As Bitmap
        Get
            Return _DeckImage
        End Get
        Set(value As Bitmap)
            _DeckImage = value
        End Set
    End Property

    Sub New()
    End Sub

End Class
