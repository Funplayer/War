' ************************ '
' Hand                     '
' Created by Philip Coelho '
' ****************************************************************************************** '
' Contains all of the encapsulated functionality of the deck, plus some extra functionality. '
' ****************************************************************************************** '
Public Class Hand : Inherits Deck

    ' Contains all of the cards in active play.
    Private _playCards As New LinkedList(Of Card)

    Public Overloads Sub setup(ByRef deckImage As Bitmap)
        _deckImage = deckImage
        _cards.Clear()
    End Sub

    ' Retrieves the first card played.
    Public ReadOnly Property TopCard As Card
        Get
            Try
                Return _playCards.ElementAt(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Get
    End Property

    ' Moves cards from deck to the play field.
    Public Sub play()
        _playCards.AddLast(Me.Draw)
    End Sub


End Class
