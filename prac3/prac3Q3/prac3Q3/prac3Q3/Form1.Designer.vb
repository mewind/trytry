<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblNameGross = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblNameDeductions = New System.Windows.Forms.Label()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.lblNameNetPay = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBoxPAY = New System.Windows.Forms.GroupBox()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblNameCommision = New System.Windows.Forms.Label()
        Me.lblBasepay = New System.Windows.Forms.Label()
        Me.lblNameBasepay = New System.Windows.Forms.Label()
        Me.GroupBoxBUDGET = New System.Windows.Forms.GroupBox()
        Me.lblMiscellaneous = New System.Windows.Forms.Label()
        Me.lblNameMiscellaneous = New System.Windows.Forms.Label()
        Me.lblEntertainment = New System.Windows.Forms.Label()
        Me.lblNameEntertainment = New System.Windows.Forms.Label()
        Me.lblFNC = New System.Windows.Forms.Label()
        Me.lblNameFNC = New System.Windows.Forms.Label()
        Me.lblHousing = New System.Windows.Forms.Label()
        Me.lblNameHousing = New System.Windows.Forms.Label()
        Me.lblHiName = New System.Windows.Forms.Label()
        Me.GroupBoxPAY.SuspendLayout()
        Me.GroupBoxBUDGET.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(32, 68)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(80, 17)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Sales :  RM"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(118, 65)
        Me.txtSales.Multiline = True
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(168, 32)
        Me.txtSales.TabIndex = 2
        '
        'lblNameGross
        '
        Me.lblNameGross.AutoSize = True
        Me.lblNameGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameGross.Location = New System.Drawing.Point(6, 88)
        Me.lblNameGross.Name = "lblNameGross"
        Me.lblNameGross.Size = New System.Drawing.Size(82, 17)
        Me.lblNameGross.TabIndex = 2
        Me.lblNameGross.Text = "Gross Pay :"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(116, 88)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(0, 17)
        Me.lblGrossPay.TabIndex = 3
        '
        'lblNameDeductions
        '
        Me.lblNameDeductions.AutoSize = True
        Me.lblNameDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameDeductions.Location = New System.Drawing.Point(9, 122)
        Me.lblNameDeductions.Name = "lblNameDeductions"
        Me.lblNameDeductions.Size = New System.Drawing.Size(83, 17)
        Me.lblNameDeductions.TabIndex = 4
        Me.lblNameDeductions.Text = "Deductions:"
        '
        'lblDeductions
        '
        Me.lblDeductions.AutoSize = True
        Me.lblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductions.Location = New System.Drawing.Point(116, 122)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(0, 17)
        Me.lblDeductions.TabIndex = 5
        '
        'lblNameNetPay
        '
        Me.lblNameNetPay.AutoSize = True
        Me.lblNameNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameNetPay.Location = New System.Drawing.Point(9, 155)
        Me.lblNameNetPay.Name = "lblNameNetPay"
        Me.lblNameNetPay.Size = New System.Drawing.Size(62, 17)
        Me.lblNameNetPay.TabIndex = 6
        Me.lblNameNetPay.Text = "Net Pay:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(116, 155)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(0, 17)
        Me.lblNetPay.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(23, 130)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(89, 40)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(136, 130)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(246, 130)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 17)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Name : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 12)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 35)
        Me.txtName.TabIndex = 1
        '
        'GroupBoxPAY
        '
        Me.GroupBoxPAY.Controls.Add(Me.lblCommission)
        Me.GroupBoxPAY.Controls.Add(Me.lblNameCommision)
        Me.GroupBoxPAY.Controls.Add(Me.lblBasepay)
        Me.GroupBoxPAY.Controls.Add(Me.lblNameBasepay)
        Me.GroupBoxPAY.Controls.Add(Me.lblNameGross)
        Me.GroupBoxPAY.Controls.Add(Me.lblGrossPay)
        Me.GroupBoxPAY.Controls.Add(Me.lblNameDeductions)
        Me.GroupBoxPAY.Controls.Add(Me.lblNameNetPay)
        Me.GroupBoxPAY.Controls.Add(Me.lblNetPay)
        Me.GroupBoxPAY.Controls.Add(Me.lblDeductions)
        Me.GroupBoxPAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPAY.Location = New System.Drawing.Point(23, 194)
        Me.GroupBoxPAY.Name = "GroupBoxPAY"
        Me.GroupBoxPAY.Size = New System.Drawing.Size(282, 194)
        Me.GroupBoxPAY.TabIndex = 15
        Me.GroupBoxPAY.TabStop = False
        Me.GroupBoxPAY.Text = "PAY"
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommission.Location = New System.Drawing.Point(116, 58)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(0, 17)
        Me.lblCommission.TabIndex = 11
        '
        'lblNameCommision
        '
        Me.lblNameCommision.AutoSize = True
        Me.lblNameCommision.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameCommision.Location = New System.Drawing.Point(4, 58)
        Me.lblNameCommision.Name = "lblNameCommision"
        Me.lblNameCommision.Size = New System.Drawing.Size(84, 17)
        Me.lblNameCommision.TabIndex = 10
        Me.lblNameCommision.Text = "Commision :"
        '
        'lblBasepay
        '
        Me.lblBasepay.AutoSize = True
        Me.lblBasepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasepay.Location = New System.Drawing.Point(116, 27)
        Me.lblBasepay.Name = "lblBasepay"
        Me.lblBasepay.Size = New System.Drawing.Size(0, 17)
        Me.lblBasepay.TabIndex = 9
        '
        'lblNameBasepay
        '
        Me.lblNameBasepay.AutoSize = True
        Me.lblNameBasepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameBasepay.Location = New System.Drawing.Point(7, 27)
        Me.lblNameBasepay.Name = "lblNameBasepay"
        Me.lblNameBasepay.Size = New System.Drawing.Size(76, 17)
        Me.lblNameBasepay.TabIndex = 8
        Me.lblNameBasepay.Text = "Base Pay :"
        '
        'GroupBoxBUDGET
        '
        Me.GroupBoxBUDGET.Controls.Add(Me.lblMiscellaneous)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblNameMiscellaneous)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblEntertainment)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblNameEntertainment)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblFNC)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblNameFNC)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblHousing)
        Me.GroupBoxBUDGET.Controls.Add(Me.lblNameHousing)
        Me.GroupBoxBUDGET.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBUDGET.Location = New System.Drawing.Point(311, 194)
        Me.GroupBoxBUDGET.Name = "GroupBoxBUDGET"
        Me.GroupBoxBUDGET.Size = New System.Drawing.Size(315, 179)
        Me.GroupBoxBUDGET.TabIndex = 16
        Me.GroupBoxBUDGET.TabStop = False
        Me.GroupBoxBUDGET.Text = "BUDGET"
        '
        'lblMiscellaneous
        '
        Me.lblMiscellaneous.AutoSize = True
        Me.lblMiscellaneous.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscellaneous.Location = New System.Drawing.Point(156, 122)
        Me.lblMiscellaneous.Name = "lblMiscellaneous"
        Me.lblMiscellaneous.Size = New System.Drawing.Size(0, 17)
        Me.lblMiscellaneous.TabIndex = 7
        '
        'lblNameMiscellaneous
        '
        Me.lblNameMiscellaneous.AutoSize = True
        Me.lblNameMiscellaneous.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameMiscellaneous.Location = New System.Drawing.Point(9, 122)
        Me.lblNameMiscellaneous.Name = "lblNameMiscellaneous"
        Me.lblNameMiscellaneous.Size = New System.Drawing.Size(105, 17)
        Me.lblNameMiscellaneous.TabIndex = 6
        Me.lblNameMiscellaneous.Text = "Miscellaneous :"
        '
        'lblEntertainment
        '
        Me.lblEntertainment.AutoSize = True
        Me.lblEntertainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntertainment.Location = New System.Drawing.Point(156, 92)
        Me.lblEntertainment.Name = "lblEntertainment"
        Me.lblEntertainment.Size = New System.Drawing.Size(0, 17)
        Me.lblEntertainment.TabIndex = 5
        '
        'lblNameEntertainment
        '
        Me.lblNameEntertainment.AutoSize = True
        Me.lblNameEntertainment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameEntertainment.Location = New System.Drawing.Point(9, 92)
        Me.lblNameEntertainment.Name = "lblNameEntertainment"
        Me.lblNameEntertainment.Size = New System.Drawing.Size(104, 17)
        Me.lblNameEntertainment.TabIndex = 4
        Me.lblNameEntertainment.Text = "Entertainment :"
        '
        'lblFNC
        '
        Me.lblFNC.AutoSize = True
        Me.lblFNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFNC.Location = New System.Drawing.Point(156, 58)
        Me.lblFNC.Name = "lblFNC"
        Me.lblFNC.Size = New System.Drawing.Size(0, 17)
        Me.lblFNC.TabIndex = 3
        '
        'lblNameFNC
        '
        Me.lblNameFNC.AutoSize = True
        Me.lblNameFNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameFNC.Location = New System.Drawing.Point(9, 58)
        Me.lblNameFNC.Name = "lblNameFNC"
        Me.lblNameFNC.Size = New System.Drawing.Size(131, 17)
        Me.lblNameFNC.TabIndex = 2
        Me.lblNameFNC.Text = "Food and Clothing :"
        '
        'lblHousing
        '
        Me.lblHousing.AutoSize = True
        Me.lblHousing.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHousing.Location = New System.Drawing.Point(156, 27)
        Me.lblHousing.Name = "lblHousing"
        Me.lblHousing.Size = New System.Drawing.Size(0, 17)
        Me.lblHousing.TabIndex = 1
        '
        'lblNameHousing
        '
        Me.lblNameHousing.AutoSize = True
        Me.lblNameHousing.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHousing.Location = New System.Drawing.Point(6, 27)
        Me.lblNameHousing.Name = "lblNameHousing"
        Me.lblNameHousing.Size = New System.Drawing.Size(68, 17)
        Me.lblNameHousing.TabIndex = 0
        Me.lblNameHousing.Text = "Housing :"
        '
        'lblHiName
        '
        Me.lblHiName.AutoSize = True
        Me.lblHiName.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiName.Location = New System.Drawing.Point(358, 54)
        Me.lblHiName.Name = "lblHiName"
        Me.lblHiName.Size = New System.Drawing.Size(0, 71)
        Me.lblHiName.TabIndex = 17
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(638, 425)
        Me.Controls.Add(Me.lblHiName)
        Me.Controls.Add(Me.GroupBoxBUDGET)
        Me.Controls.Add(Me.GroupBoxPAY)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblSales)
        Me.Name = "Form1"
        Me.Text = "Salary Counter"
        Me.GroupBoxPAY.ResumeLayout(False)
        Me.GroupBoxPAY.PerformLayout()
        Me.GroupBoxBUDGET.ResumeLayout(False)
        Me.GroupBoxBUDGET.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSales As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents lblNameGross As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblNameDeductions As Label
    Friend WithEvents lblDeductions As Label
    Friend WithEvents lblNameNetPay As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBoxPAY As GroupBox
    Friend WithEvents GroupBoxBUDGET As GroupBox
    Friend WithEvents lblFNC As Label
    Friend WithEvents lblNameFNC As Label
    Friend WithEvents lblHousing As Label
    Friend WithEvents lblNameHousing As Label
    Friend WithEvents lblMiscellaneous As Label
    Friend WithEvents lblNameMiscellaneous As Label
    Friend WithEvents lblEntertainment As Label
    Friend WithEvents lblNameEntertainment As Label
    Friend WithEvents lblBasepay As Label
    Friend WithEvents lblNameBasepay As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents lblNameCommision As Label
    Friend WithEvents lblHiName As Label
End Class
