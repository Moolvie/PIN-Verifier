<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PinVerifier
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
        Me.pinInputBox_1 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_2 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_3 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_4 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_5 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_6 = New System.Windows.Forms.TextBox()
        Me.pinInputBox_7 = New System.Windows.Forms.TextBox()
        Me.PinGroup = New System.Windows.Forms.GroupBox()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PinGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'pinInputBox_1
        '
        Me.pinInputBox_1.Location = New System.Drawing.Point(22, 37)
        Me.pinInputBox_1.Name = "pinInputBox_1"
        Me.pinInputBox_1.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_1.TabIndex = 0
        '
        'pinInputBox_2
        '
        Me.pinInputBox_2.Location = New System.Drawing.Point(77, 37)
        Me.pinInputBox_2.Name = "pinInputBox_2"
        Me.pinInputBox_2.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_2.TabIndex = 1
        '
        'pinInputBox_3
        '
        Me.pinInputBox_3.Location = New System.Drawing.Point(132, 37)
        Me.pinInputBox_3.Name = "pinInputBox_3"
        Me.pinInputBox_3.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_3.TabIndex = 2
        '
        'pinInputBox_4
        '
        Me.pinInputBox_4.Location = New System.Drawing.Point(187, 37)
        Me.pinInputBox_4.Name = "pinInputBox_4"
        Me.pinInputBox_4.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_4.TabIndex = 3
        '
        'pinInputBox_5
        '
        Me.pinInputBox_5.Location = New System.Drawing.Point(242, 37)
        Me.pinInputBox_5.Name = "pinInputBox_5"
        Me.pinInputBox_5.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_5.TabIndex = 4
        '
        'pinInputBox_6
        '
        Me.pinInputBox_6.Location = New System.Drawing.Point(297, 37)
        Me.pinInputBox_6.Name = "pinInputBox_6"
        Me.pinInputBox_6.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_6.TabIndex = 5
        '
        'pinInputBox_7
        '
        Me.pinInputBox_7.Location = New System.Drawing.Point(352, 37)
        Me.pinInputBox_7.Name = "pinInputBox_7"
        Me.pinInputBox_7.Size = New System.Drawing.Size(27, 20)
        Me.pinInputBox_7.TabIndex = 6
        '
        'PinGroup
        '
        Me.PinGroup.Controls.Add(Me.pinInputBox_7)
        Me.PinGroup.Controls.Add(Me.pinInputBox_6)
        Me.PinGroup.Controls.Add(Me.pinInputBox_5)
        Me.PinGroup.Controls.Add(Me.pinInputBox_4)
        Me.PinGroup.Controls.Add(Me.pinInputBox_3)
        Me.PinGroup.Controls.Add(Me.pinInputBox_2)
        Me.PinGroup.Controls.Add(Me.pinInputBox_1)
        Me.PinGroup.Location = New System.Drawing.Point(18, 28)
        Me.PinGroup.Name = "PinGroup"
        Me.PinGroup.Size = New System.Drawing.Size(402, 98)
        Me.PinGroup.TabIndex = 7
        Me.PinGroup.TabStop = False
        Me.PinGroup.Text = "Enter the PIN"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(43, 151)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(92, 27)
        Me.VerifyButton.TabIndex = 8
        Me.VerifyButton.Text = "Verify"
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(168, 151)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(92, 27)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(293, 151)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(92, 27)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PinVerifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 207)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.PinGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "PinVerifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIN Verifier"
        Me.PinGroup.ResumeLayout(False)
        Me.PinGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pinInputBox_1 As TextBox
    Friend WithEvents pinInputBox_2 As TextBox
    Friend WithEvents pinInputBox_3 As TextBox
    Friend WithEvents pinInputBox_4 As TextBox
    Friend WithEvents pinInputBox_5 As TextBox
    Friend WithEvents pinInputBox_6 As TextBox
    Friend WithEvents pinInputBox_7 As TextBox
    Friend WithEvents PinGroup As GroupBox
    Friend WithEvents VerifyButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
