<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DifficultyForm
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
        Me.EasyButton = New System.Windows.Forms.Button()
        Me.MediumButton = New System.Windows.Forms.Button()
        Me.HardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EasyButton
        '
        Me.EasyButton.Location = New System.Drawing.Point(104, 31)
        Me.EasyButton.Name = "EasyButton"
        Me.EasyButton.Size = New System.Drawing.Size(75, 23)
        Me.EasyButton.TabIndex = 0
        Me.EasyButton.Text = "Easy"
        Me.EasyButton.UseVisualStyleBackColor = True
        '
        'MediumButton
        '
        Me.MediumButton.Location = New System.Drawing.Point(104, 78)
        Me.MediumButton.Name = "MediumButton"
        Me.MediumButton.Size = New System.Drawing.Size(75, 23)
        Me.MediumButton.TabIndex = 1
        Me.MediumButton.Text = "Medium"
        Me.MediumButton.UseVisualStyleBackColor = True
        '
        'HardButton
        '
        Me.HardButton.Location = New System.Drawing.Point(104, 131)
        Me.HardButton.Name = "HardButton"
        Me.HardButton.Size = New System.Drawing.Size(75, 23)
        Me.HardButton.TabIndex = 2
        Me.HardButton.Text = "Hard"
        Me.HardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(172, 207)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DifficultyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.HardButton)
        Me.Controls.Add(Me.MediumButton)
        Me.Controls.Add(Me.EasyButton)
        Me.Name = "DifficultyForm"
        Me.Text = "Difficulty Select"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EasyButton As System.Windows.Forms.Button
    Friend WithEvents MediumButton As System.Windows.Forms.Button
    Friend WithEvents HardButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
