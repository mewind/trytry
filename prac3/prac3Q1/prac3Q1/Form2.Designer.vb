<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblNameVol = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prac3Q1.My.Resources.Resources.P3Q1_Line
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 144)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(114, 121)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(153, 34)
        Me.txtHeight.TabIndex = 6
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(114, 81)
        Me.txtWidth.Multiline = True
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(153, 30)
        Me.txtWidth.TabIndex = 5
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(114, 42)
        Me.txtLength.Multiline = True
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(153, 28)
        Me.txtLength.TabIndex = 4
        '
        'lblNameVol
        '
        Me.lblNameVol.AutoSize = True
        Me.lblNameVol.Location = New System.Drawing.Point(13, 172)
        Me.lblNameVol.Name = "lblNameVol"
        Me.lblNameVol.Size = New System.Drawing.Size(59, 17)
        Me.lblNameVol.TabIndex = 3
        Me.lblNameVol.Text = "Volume:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(16, 127)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(53, 17)
        Me.lblHeight.TabIndex = 2
        Me.lblHeight.Text = "&Height:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(16, 84)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(48, 17)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "&Width:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(16, 42)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(56, 17)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "&Length:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(355, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 40)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(201, 295)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 40)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lblVolume)
        Me.GroupBox.Controls.Add(Me.txtHeight)
        Me.GroupBox.Controls.Add(Me.txtWidth)
        Me.GroupBox.Controls.Add(Me.txtLength)
        Me.GroupBox.Controls.Add(Me.lblNameVol)
        Me.GroupBox.Controls.Add(Me.lblHeight)
        Me.GroupBox.Controls.Add(Me.lblWidth)
        Me.GroupBox.Controls.Add(Me.lblLength)
        Me.GroupBox.Location = New System.Drawing.Point(201, 49)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(354, 218)
        Me.GroupBox.TabIndex = 11
        Me.GroupBox.TabStop = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(114, 172)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(0, 17)
        Me.lblVolume.TabIndex = 7
        '
        'Form2
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(567, 356)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblNameVol As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents lblVolume As Label
End Class
