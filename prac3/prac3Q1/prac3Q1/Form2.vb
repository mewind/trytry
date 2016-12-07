Public Class Form2
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare Variable
        Dim length, width, height, volume As Double

        'Use Try Function- detect error
        Try
            length = Double.Parse(txtLength.Text) 'convert string into double
            width = Double.Parse(txtWidth.Text)
            height = Double.Parse(txtHeight.Text)
            volume = length * width * height
            lblVolume.Text = volume.ToString("0.00") 'Convert into string back
        Catch ex As Exception 'if you type a invalid data type
            lblVolume.Text = "N/A"
            MessageBox.Show("Only numbers are accepted")

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class