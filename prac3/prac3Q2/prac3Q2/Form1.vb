Public Class Form1
    'initiates sum and count
    'put at PUBLIC so that it won't reset everytime the program runs
    Dim sum As Integer = 0
    Dim count As Integer = 0

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Declare variable
        Dim textinput As Integer
        Dim average As Double

        Try
            textinput = Integer.Parse(txtInput.Text)

            count += 1 'make count
            sum += textinput
            average = sum / count

            lblSum.Text = sum.ToString()
            lblAverage.Text = average.ToString("0.00")

        Catch ex As Exception
            MessageBox.Show("Only numbers are allowed")

        End Try

        txtInput.Focus()
        txtInput.SelectAll()

    End Sub
End Class
