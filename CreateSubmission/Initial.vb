Public Class Initial
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Form2.Show()
    End Sub
    Private Sub btnView_KeyDown(sender As Object, e As KeyEventArgs) Handles btnView.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            btnView_Click(sender, e)
        End If
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Form1.Show()
    End Sub

    Private Sub btnNew_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNew.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.N Then
            btnNew_Click(sender, e)
        End If
    End Sub

End Class