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
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupboxSummary = New System.Windows.Forms.GroupBox()
        Me.lblNameSum = New System.Windows.Forms.Label()
        Me.lblNameAvg = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.GroupboxSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(31, 44)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(86, 17)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Enter Value:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(155, 41)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(185, 31)
        Me.txtInput.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(370, 39)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 33)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupboxSummary
        '
        Me.GroupboxSummary.Controls.Add(Me.lblAverage)
        Me.GroupboxSummary.Controls.Add(Me.lblSum)
        Me.GroupboxSummary.Controls.Add(Me.lblNameAvg)
        Me.GroupboxSummary.Controls.Add(Me.lblNameSum)
        Me.GroupboxSummary.Location = New System.Drawing.Point(34, 91)
        Me.GroupboxSummary.Name = "GroupboxSummary"
        Me.GroupboxSummary.Size = New System.Drawing.Size(411, 172)
        Me.GroupboxSummary.TabIndex = 3
        Me.GroupboxSummary.TabStop = False
        Me.GroupboxSummary.Text = "Summary"
        '
        'lblNameSum
        '
        Me.lblNameSum.AutoSize = True
        Me.lblNameSum.Location = New System.Drawing.Point(43, 42)
        Me.lblNameSum.Name = "lblNameSum"
        Me.lblNameSum.Size = New System.Drawing.Size(40, 17)
        Me.lblNameSum.TabIndex = 0
        Me.lblNameSum.Text = "Sum:"
        '
        'lblNameAvg
        '
        Me.lblNameAvg.AutoSize = True
        Me.lblNameAvg.Location = New System.Drawing.Point(43, 85)
        Me.lblNameAvg.Name = "lblNameAvg"
        Me.lblNameAvg.Size = New System.Drawing.Size(65, 17)
        Me.lblNameAvg.TabIndex = 1
        Me.lblNameAvg.Text = "Average:"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(153, 42)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 17)
        Me.lblSum.TabIndex = 2
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(144, 85)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 17)
        Me.lblAverage.TabIndex = 3
        '
        'Form1
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 307)
        Me.Controls.Add(Me.GroupboxSummary)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupboxSummary.ResumeLayout(False)
        Me.GroupboxSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblValue As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupboxSummary As GroupBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents lblNameAvg As Label
    Friend WithEvents lblNameSum As Label
End Class
