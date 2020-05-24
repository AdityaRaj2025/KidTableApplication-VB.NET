Public Class KidTableApplication
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GenerateTable(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click
        Dim b As Button = sender
        Dim prod As Integer
        txtNumberDisplay.Clear()

        For i As Integer = 1 To 10
            prod = b.Text * i
            txtNumberDisplay.Text = txtNumberDisplay.Text & b.Text & " × " & i & " = " & prod & vbCrLf
        Next
    End Sub


    Private Sub KidTableApplication_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Width = Me.Width - 15
        Panel1.Height = Me.Height - 15
        txtNumberDisplay.Width = Me.Width - 70
    End Sub
End Class
