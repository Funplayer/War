' ************************ '
' Deck                     '
' Created by Philip Coelho '
' ****************************************************************** '
' Contains all of the encapsulated functionality of the deck.        '
' ****************************************************************** '
Public Class Deck
    Public _cards As New LinkedList(Of Card)
    Protected _Image As Image
    Protected _deckImage As Bitmap
    Protected _randomSeed As Random = New Random()
    Protected _random As Random = New Random(_randomSeed.Next(123455656, 999999999))

    Public Function Count() As Integer
        Return _cards.Count
    End Function

    Public Function Empty() As Boolean
        If _cards.Count = 0 Then
            Return True
        End If
        Return False
    End Function

    ' Destructively removes a card from the deck, and returns it.
    Public Property Draw As Card
        Get
            Dim _tempCard As Card = _cards.First.Value
            _cards.Remove(_tempCard)
            Return _tempCard
        End Get
        Set(value As Card)
            Try
                _cards.AddLast(value)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Set
    End Property

    ' Adds a card to the bottom of the deck.
    Public WriteOnly Property Grab As Card
        Set(value As Card)
            _cards.AddLast(value)
        End Set
    End Property

    ' Shuffle is the ability to sort the cards over 9000 times.
    Public Sub shuffle()
        ' Moves nth amount of cards to the bottom of the deck
        If _cards.Count > 1 Then
            For count As Integer = 0 To _random.Next(4000, 16000)
                ' get a random card from the deck
                Dim tempCard As Card = _cards.ElementAt(_random.Next(0, _cards.Count - 1))
                ' destroy card in the deck
                _cards.Remove(tempCard)
                ' add card at the end of the deck 
                Me.Grab = tempCard
            Next
        End If
    End Sub

    ' Setup the deck with an image for the deck:
    ' Required parameters
    '       72x100x16
    Public Sub setup(ByRef deckImage As Bitmap)
        _deckImage = deckImage
        _cards.Clear()
        For suitInt As Integer = 0 To 3
            For cardValue As Integer = 1 To 13
                _cards.AddLast(createCard(suitInt, cardValue))
            Next
        Next
        shuffle()
    End Sub

    ' Creates a card from a set of parameters.
    Protected Function createCard(suitInt As Integer, cardValue As Integer) As Card
        Dim currentCard As New Card()
        currentCard.Number = cardValue
        currentCard.Suit = getSuit(suitInt)
        currentCard.Title = modifyCard(cardValue) + " of " + currentCard.Suit
        currentCard.Image = createImage(currentCard, suitInt)
        Return currentCard
    End Function

    ' Uses custom ImageRegion class to create an image based on the parameters of the image sheet.
    Protected Function createImage(ByRef tempCard As Card, ByVal suitInt As Integer) As Image
        Return New ImageRegion().Create(_deckImage, 72 * (tempCard.Number - 1), 100 * suitInt, 72, 100)
    End Function

    Protected Function getSuit(suitInt As Integer) As String
        Select Case suitInt
            Case 0
                Return "Heart"
            Case 1
                Return "Diamond"
            Case 2
                Return "Club"
            Case 3
                Return "Spade"
        End Select
        Return "Failed"
    End Function

    Protected Function modifyCard(inputValue As Integer) As String
        Select Case inputValue
            Case 1
                Return "Ace"
            Case 2
                Return "Two"
            Case 3
                Return "Three"
            Case 4
                Return "Four"
            Case 5
                Return "Five"
            Case 6
                Return "Six"
            Case 7
                Return "Seven"
            Case 8
                Return "Eight"
            Case 9
                Return "Nine"
            Case 10
                Return "Ten"
            Case 11
                Return "Jack"
            Case 12
                Return "Queen"
            Case 13
                Return "King"
        End Select
        Return "Broken"
    End Function

    ' Automatically creates a new deck typed object
    Sub New()
    End Sub

End Class

Public Class Card
    Private _number As Integer
    Private _title As String
    Private _suit As String
    Private _image As Image

    ' Contains the numeric value for the card.
    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    ' Contains the string title for the card.
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    ' Contains the suit of the card.
    Public Property Suit As String
        Get
            Return _suit
        End Get
        Set(value As String)
            _suit = value
        End Set
    End Property

    ' Contains the bitmap value for the card.
    Public Property Image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
        End Set
    End Property

    Sub New(inNumber As Integer, inTitle As String, inSuit As String, inImage As Bitmap)
        Number = inNumber
        Title = inTitle
        Suit = inSuit
        Image = inImage
    End Sub

    Sub New()
    End Sub

End Class
