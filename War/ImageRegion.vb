Public Class ImageRegion

    ' This took a little while to debug.
    Public Function Create(ByVal inputImage As Bitmap,
                              xInt As Integer, yInt As Integer,
                              xWidth As Integer, yHeight As Integer) As Image
        Dim tempImage As Bitmap = New Bitmap(xWidth, yHeight)
        ' For the row, get columns of pixel.
        For row As Integer = 0 To yHeight - 1
            ' For the columns get pixel, and set to current place in row.
            For column As Integer = 0 To xWidth - 1
                tempImage.SetPixel(column, row, inputImage.GetPixel(column + xInt, row + yInt))
            Next
        Next
        Return CType(tempImage, Image).Clone()
    End Function

End Class
