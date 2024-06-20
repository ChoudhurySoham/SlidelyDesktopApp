Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CODE TO FETCH THE FIRST RECORD BY DEFAULT
    End Sub
    Private Sub btnPrevious2_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click
        'CODE TO FETCH THE PREVIOUS RECORD
    End Sub

    Private Sub btnPrevious2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious2.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious2_Click(sender, e)
        End If
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        'CODE TO FETCH THE NEXT RECORD
    End Sub

    Private Sub btnNext2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext2.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.N Then
            btnNext2_Click(sender, e)
        End If
    End Sub
End Class