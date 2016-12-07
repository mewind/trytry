Option Explicit On  ' Option Explicit is turned ON
Option Strict On   ' Option Strict is turned ON

Public Class FrmDebug
    ' Initialise counters
    Dim add As Integer = 0
    Dim minus As Integer = 0
    Dim multiply As Integer = 0
    Dim divide As Integer = 0

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0

        ' Obtain inputs
        num1 = Integer.Parse(txtNum1.Text)
        num2 = Integer.Parse(txtNum2.Text)

        ' Perform calculation
        If radAdd.Checked Then
            lblAns.Text = FormatNumber(num1 + num2)
            add += 1
        ElseIf radMinus.Checked Then
            lblAns.Text = FormatNumber(num1 - num2)
            minus += 1
        ElseIf radMultiply.Checked Then
            lblAns.Text = FormatNumber(num1 * num2)
            multiply += 1
        Else
            lblAns.Text = FormatNumber(num1 / num2)
            divide += 1
        End If

        ' Display counters
        lblAdd.Text = add.ToString("")
        lblMinus.Text = minus.ToString("")
        lblMultiply.Text = multiply.ToString("")
        lblDivide.Text = divide.ToString("")


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
