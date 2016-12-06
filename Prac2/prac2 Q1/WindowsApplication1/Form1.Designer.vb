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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.rbtnBlue = New System.Windows.Forms.RadioButton()
        Me.rbtnGreen = New System.Windows.Forms.RadioButton()
        Me.rbtnRed = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 13)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 22)
        Me.txtName.TabIndex = 0
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.rbtnBlue)
        Me.grpColor.Controls.Add(Me.rbtnGreen)
        Me.grpColor.Controls.Add(Me.rbtnRed)
        Me.grpColor.Location = New System.Drawing.Point(16, 69)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(178, 112)
        Me.grpColor.TabIndex = 1
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'rbtnBlue
        '
        Me.rbtnBlue.AutoSize = True
        Me.rbtnBlue.Location = New System.Drawing.Point(7, 78)
        Me.rbtnBlue.Name = "rbtnBlue"
        Me.rbtnBlue.Size = New System.Drawing.Size(57, 21)
        Me.rbtnBlue.TabIndex = 2
        Me.rbtnBlue.TabStop = True
        Me.rbtnBlue.Text = "&Blue"
        Me.rbtnBlue.UseVisualStyleBackColor = True
        '
        'rbtnGreen
        '
        Me.rbtnGreen.AutoSize = True
        Me.rbtnGreen.Location = New System.Drawing.Point(7, 50)
        Me.rbtnGreen.Name = "rbtnGreen"
        Me.rbtnGreen.Size = New System.Drawing.Size(69, 21)
        Me.rbtnGreen.TabIndex = 1
        Me.rbtnGreen.TabStop = True
        Me.rbtnGreen.Text = "&Green"
        Me.rbtnGreen.UseVisualStyleBackColor = True
        '
        'rbtnRed
        '
        Me.rbtnRed.AutoSize = True
        Me.rbtnRed.Location = New System.Drawing.Point(7, 22)
        Me.rbtnRed.Name = "rbtnRed"
        Me.rbtnRed.Size = New System.Drawing.Size(55, 21)
        Me.rbtnRed.TabIndex = 0
        Me.rbtnRed.TabStop = True
        Me.rbtnRed.Text = "&Red"
        Me.rbtnRed.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(210, 71)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(81, 34)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(210, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(210, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(23, 194)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 32)
        Me.lblMsg.TabIndex = 7
        '
        'Form1
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(313, 253)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents rbtnRed As RadioButton
    Friend WithEvents rbtnBlue As RadioButton
    Friend WithEvents rbtnGreen As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMsg As Label
End Class
