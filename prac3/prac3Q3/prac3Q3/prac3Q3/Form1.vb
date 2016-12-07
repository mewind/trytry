Public Class Form1
    'Declare constant
    Const BasePay As Double = 900.0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblHiName.Text = "Hi " & txtName.Text

        'Declare variables
        Dim sales, commission, grosspay, dedeuctions, netpay As Double
        Dim housing, fnc, entertainment, miscellaneous As Double

        Try
            'PAY 
            sales = Double.Parse(txtSales.Text)
            commission = sales * 0.06
            grosspay = BasePay + commission
            dedeuctions = grosspay * 0.18
            netpay = grosspay - dedeuctions

            'Budget
            housing = netpay * 0.3
            fnc = netpay * 0.15
            entertainment = netpay * 0.5
            miscellaneous = netpay * 0.05

            lblBasepay.Text = BasePay.ToString("RM 0.00") ' hard coded RM into answers
            lblGrossPay.Text = grosspay.ToString("RM 0.00")
            lblCommission.Text = commission.ToString("RM 0.00")
            lblDeductions.Text = dedeuctions.ToString("RM 0.00")
            lblNetPay.Text = netpay.ToString("RM 0.00")

            lblHousing.Text = housing.ToString("RM 0.00")
            lblFNC.Text = fnc.ToString("RM 0.00")
            lblEntertainment.Text = entertainment.ToString("RM 0.00")
            lblMiscellaneous.Text = miscellaneous.ToString("RM 0.00")

        Catch ex As Exception
            MessageBox.Show("Only numbers are allowed!")

        End Try

        txtName.Focus()
        txtName.SelectAll()









    End Sub

    Private Sub lblSales_Click(sender As Object, e As EventArgs) Handles lblSales.Click

    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged

    End Sub

    Private Sub lblNameGross_Click(sender As Object, e As EventArgs) Handles lblNameGross.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = " "
        txtSales.Text = " "

        lblBasepay.Text = " "
        lblGrossPay.Text = " "
        lblCommission.Text = " "
        lblDeductions.Text = " "
        lblNetPay.Text = " "

        lblHousing.Text = " "
        lblFNC.Text = " "
        lblEntertainment.Text = " "
        lblMiscellaneous.Text = " "
        lblHiName.Text = " "

        txtName.Focus()



    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub GroupBoxPAY_Enter(sender As Object, e As EventArgs) Handles GroupBoxPAY.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hello
        'i'm trying this
    End Sub
End Class
