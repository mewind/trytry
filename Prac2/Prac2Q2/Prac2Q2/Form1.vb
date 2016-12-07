Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pic.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Pic.Image = My.Resources.Red
    End Sub

    Private Sub btnCaution_Click(sender As Object, e As EventArgs) Handles btnCaution.Click
        Pic.Image = My.Resources.Yellow
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Pic.Image = My.Resources.Green
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'try team services
    End Sub
End Class
