Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Set helloooooo
        lblMsg.Text = "Hello " & txtName.Text

        'Set the fore color when radio button is checked
        Dim fore As Color = Color.Black

        If rbtnRed.Checked Then
            fore = Color.Red
        ElseIf rbtnGreen.Checked Then
            fore = Color.Green
        ElseIf rbtnBlue.Checked Then
            fore = Color.Blue
        End If

        lblMsg.ForeColor = fore




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpColor_Enter(sender As Object, e As EventArgs) Handles grpColor.Enter

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Empty & focus
        lblMsg.Text = " "
        rbtnRed.Checked = True
        txtName.Text = " "
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rbtnRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRed.CheckedChanged
        'SET RED
        lblMsg.Text = "Hello " & txtName.Text

        Dim fore As Color = Color.Black
        If rbtnRed.Checked Then
            fore = Color.Red
        End If
        lblMsg.ForeColor = fore
    End Sub

    Private Sub rbtnGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGreen.CheckedChanged
        'SET GREEN
        lblMsg.Text = "Hello " & txtName.Text

        Dim fore As Color = Color.Black
        If rbtnGreen.Checked Then
            fore = Color.Green
        End If
        lblMsg.ForeColor = fore
    End Sub

    Private Sub rbtnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBlue.CheckedChanged
        'SET BLUE
        lblMsg.Text = "Hello " & txtName.Text

        Dim fore As Color = Color.Black
        If rbtnBlue.Checked Then
            fore = Color.Blue
        End If
        lblMsg.ForeColor = fore
    End Sub
End Class
