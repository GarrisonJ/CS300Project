<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(93, 108)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(103, 23)
        Me.LoadButton.TabIndex = 0
        Me.LoadButton.Text = "Load Game"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(93, 160)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(103, 23)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save Game"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(93, 59)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(103, 23)
        Me.NewGameButton.TabIndex = 2
        Me.NewGameButton.Text = "Start New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(93, 211)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(103, 23)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit Game"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ContinueButton
        '
        Me.ContinueButton.Location = New System.Drawing.Point(93, 8)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(103, 23)
        Me.ContinueButton.TabIndex = 4
        Me.ContinueButton.Text = "Continue Game"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.NewGameButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Name = "MenuForm"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents NewGameButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents ContinueButton As System.Windows.Forms.Button
End Class
