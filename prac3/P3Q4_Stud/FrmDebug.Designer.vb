<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDebug
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
        Me.grpOperators = New System.Windows.Forms.GroupBox()
        Me.radDivide = New System.Windows.Forms.RadioButton()
        Me.radMultiply = New System.Windows.Forms.RadioButton()
        Me.radMinus = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDivide = New System.Windows.Forms.Label()
        Me.lblMultiply = New System.Windows.Forms.Label()
        Me.lblMinus = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOperators.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOperators
        '
        Me.grpOperators.Controls.Add(Me.radDivide)
        Me.grpOperators.Controls.Add(Me.radMultiply)
        Me.grpOperators.Controls.Add(Me.radMinus)
        Me.grpOperators.Controls.Add(Me.radAdd)
        Me.grpOperators.ForeColor = System.Drawing.Color.Black
        Me.grpOperators.Location = New System.Drawing.Point(12, 12)
        Me.grpOperators.Name = "grpOperators"
        Me.grpOperators.Size = New System.Drawing.Size(86, 131)
        Me.grpOperators.TabIndex = 0
        Me.grpOperators.TabStop = False
        Me.grpOperators.Text = "Operators"
        '
        'radDivide
        '
        Me.radDivide.AutoSize = True
        Me.radDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radDivide.Location = New System.Drawing.Point(19, 88)
        Me.radDivide.Name = "radDivide"
        Me.radDivide.Size = New System.Drawing.Size(36, 30)
        Me.radDivide.TabIndex = 3
        Me.radDivide.TabStop = True
        Me.radDivide.Text = "/"
        Me.radDivide.UseVisualStyleBackColor = True
        '
        'radMultiply
        '
        Me.radMultiply.AutoSize = True
        Me.radMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radMultiply.Location = New System.Drawing.Point(19, 65)
        Me.radMultiply.Name = "radMultiply"
        Me.radMultiply.Size = New System.Drawing.Size(39, 30)
        Me.radMultiply.TabIndex = 2
        Me.radMultiply.TabStop = True
        Me.radMultiply.Text = "*"
        Me.radMultiply.UseVisualStyleBackColor = True
        '
        'radMinus
        '
        Me.radMinus.AutoSize = True
        Me.radMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radMinus.Location = New System.Drawing.Point(19, 42)
        Me.radMinus.Name = "radMinus"
        Me.radMinus.Size = New System.Drawing.Size(37, 30)
        Me.radMinus.TabIndex = 1
        Me.radMinus.TabStop = True
        Me.radMinus.Text = "-"
        Me.radMinus.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radAdd.Location = New System.Drawing.Point(19, 19)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(43, 30)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "+"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDivide)
        Me.GroupBox1.Controls.Add(Me.lblMultiply)
        Me.GroupBox1.Controls.Add(Me.lblMinus)
        Me.GroupBox1.Controls.Add(Me.lblAdd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 198)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblDivide
        '
        Me.lblDivide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivide.Location = New System.Drawing.Point(231, 144)
        Me.lblDivide.Name = "lblDivide"
        Me.lblDivide.Size = New System.Drawing.Size(100, 23)
        Me.lblDivide.TabIndex = 11
        Me.lblDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMultiply
        '
        Me.lblMultiply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMultiply.Location = New System.Drawing.Point(231, 110)
        Me.lblMultiply.Name = "lblMultiply"
        Me.lblMultiply.Size = New System.Drawing.Size(100, 23)
        Me.lblMultiply.TabIndex = 10
        Me.lblMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinus
        '
        Me.lblMinus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinus.Location = New System.Drawing.Point(231, 76)
        Me.lblMinus.Name = "lblMinus"
        Me.lblMinus.Size = New System.Drawing.Size(100, 23)
        Me.lblMinus.TabIndex = 9
        Me.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdd
        '
        Me.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdd.Location = New System.Drawing.Point(231, 36)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(100, 23)
        Me.lblAdd.TabIndex = 8
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(351, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Time(s)."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Time(s)."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Time(s)."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Time(s)."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "You had selected '/' for"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "You had selected '*' for"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "You had selected '-' for"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "You had selected '+' for"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnCalculate)
        Me.GroupBox2.Controls.Add(Me.lblAns)
        Me.GroupBox2.Controls.Add(Me.txtNum2)
        Me.GroupBox2.Controls.Add(Me.txtNum1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 131)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(236, 72)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(236, 42)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAns.Location = New System.Drawing.Point(113, 98)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(100, 23)
        Me.lblAns.TabIndex = 5
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(113, 59)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 23)
        Me.txtNum2.TabIndex = 4
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(113, 26)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 23)
        Me.txtNum1.TabIndex = 3
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Answer :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Integer 2 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integer 1 :"
        '
        'FrmDebug
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(513, 402)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpOperators)
        Me.Name = "FrmDebug"
        Me.Text = "Debugging"
        Me.grpOperators.ResumeLayout(False)
        Me.grpOperators.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOperators As System.Windows.Forms.GroupBox
    Friend WithEvents radDivide As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiply As System.Windows.Forms.RadioButton
    Friend WithEvents radMinus As System.Windows.Forms.RadioButton
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents lblDivide As System.Windows.Forms.Label
    Friend WithEvents lblMultiply As System.Windows.Forms.Label
    Friend WithEvents lblMinus As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
