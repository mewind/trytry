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
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnCaution = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(12, 494)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(89, 32)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "&Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnCaution
        '
        Me.btnCaution.Location = New System.Drawing.Point(107, 494)
        Me.btnCaution.Name = "btnCaution"
        Me.btnCaution.Size = New System.Drawing.Size(75, 32)
        Me.btnCaution.TabIndex = 1
        Me.btnCaution.Text = "&Caution"
        Me.btnCaution.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(188, 494)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 32)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(280, 494)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic.ErrorImage = Nothing
        Me.Pic.Image = Global.Prac2Q2.My.Resources.Resources.Red
        Me.Pic.InitialImage = Global.Prac2Q2.My.Resources.Resources.Red
        Me.Pic.Location = New System.Drawing.Point(29, 26)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(309, 387)
        Me.Pic.TabIndex = 0
        Me.Pic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(378, 538)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnCaution)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Pic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P2Q2"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pic As PictureBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnCaution As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnExit As Button
End Class
