﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.Budget = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.EnvLabel = New System.Windows.Forms.Label()
        Me.EnvNum = New System.Windows.Forms.Label()
        Me.FoodLabel = New System.Windows.Forms.Label()
        Me.FoodNum = New System.Windows.Forms.Label()
        Me.IncLabel = New System.Windows.Forms.Label()
        Me.IncNum = New System.Windows.Forms.Label()
        Me.PopLabel = New System.Windows.Forms.Label()
        Me.PopNum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(541, 450)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(75, 23)
        Me.MenuButton.TabIndex = 1
        Me.MenuButton.Text = "Main Menu"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'Budget
        '
        Me.Budget.Location = New System.Drawing.Point(541, 49)
        Me.Budget.Name = "Budget"
        Me.Budget.Size = New System.Drawing.Size(75, 23)
        Me.Budget.TabIndex = 2
        Me.Budget.Text = "Set Budget"
        Me.Budget.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(541, 95)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start Round"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'EnvLabel
        '
        Me.EnvLabel.AutoSize = True
        Me.EnvLabel.Location = New System.Drawing.Point(12, 450)
        Me.EnvLabel.Name = "EnvLabel"
        Me.EnvLabel.Size = New System.Drawing.Size(69, 13)
        Me.EnvLabel.TabIndex = 4
        Me.EnvLabel.Text = "Environment:"
        '
        'EnvNum
        '
        Me.EnvNum.AutoSize = True
        Me.EnvNum.Location = New System.Drawing.Point(83, 470)
        Me.EnvNum.Name = "EnvNum"
        Me.EnvNum.Size = New System.Drawing.Size(25, 13)
        Me.EnvNum.TabIndex = 5
        Me.EnvNum.Text = "100"
        '
        'FoodLabel
        '
        Me.FoodLabel.AutoSize = True
        Me.FoodLabel.Location = New System.Drawing.Point(120, 450)
        Me.FoodLabel.Name = "FoodLabel"
        Me.FoodLabel.Size = New System.Drawing.Size(34, 13)
        Me.FoodLabel.TabIndex = 6
        Me.FoodLabel.Text = "Food:"
        '
        'FoodNum
        '
        Me.FoodNum.AutoSize = True
        Me.FoodNum.Location = New System.Drawing.Point(152, 470)
        Me.FoodNum.Name = "FoodNum"
        Me.FoodNum.Size = New System.Drawing.Size(25, 13)
        Me.FoodNum.TabIndex = 7
        Me.FoodNum.Text = "100"
        '
        'IncLabel
        '
        Me.IncLabel.AutoSize = True
        Me.IncLabel.Location = New System.Drawing.Point(190, 450)
        Me.IncLabel.Name = "IncLabel"
        Me.IncLabel.Size = New System.Drawing.Size(45, 13)
        Me.IncLabel.TabIndex = 8
        Me.IncLabel.Text = "Income:"
        '
        'IncNum
        '
        Me.IncNum.AutoSize = True
        Me.IncNum.Location = New System.Drawing.Point(235, 470)
        Me.IncNum.Name = "IncNum"
        Me.IncNum.Size = New System.Drawing.Size(25, 13)
        Me.IncNum.TabIndex = 9
        Me.IncNum.Text = "100"
        '
        'PopLabel
        '
        Me.PopLabel.AutoSize = True
        Me.PopLabel.Location = New System.Drawing.Point(269, 450)
        Me.PopLabel.Name = "PopLabel"
        Me.PopLabel.Size = New System.Drawing.Size(60, 13)
        Me.PopLabel.TabIndex = 10
        Me.PopLabel.Text = "Population:"
        '
        'PopNum
        '
        Me.PopNum.AutoSize = True
        Me.PopNum.Location = New System.Drawing.Point(333, 470)
        Me.PopNum.Name = "PopNum"
        Me.PopNum.Size = New System.Drawing.Size(25, 13)
        Me.PopNum.TabIndex = 11
        Me.PopNum.Text = "100"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Draw"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(520, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Round: "
        '
        'RoundLabel
        '
        Me.RoundLabel.AutoSize = True
        Me.RoundLabel.Location = New System.Drawing.Point(559, 9)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(0, 13)
        Me.RoundLabel.TabIndex = 14
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 498)
        Me.Controls.Add(Me.RoundLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PopNum)
        Me.Controls.Add(Me.PopLabel)
        Me.Controls.Add(Me.IncNum)
        Me.Controls.Add(Me.IncLabel)
        Me.Controls.Add(Me.FoodNum)
        Me.Controls.Add(Me.FoodLabel)
        Me.Controls.Add(Me.EnvNum)
        Me.Controls.Add(Me.EnvLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Budget)
        Me.Controls.Add(Me.MenuButton)
        Me.Name = "GameForm"
        Me.Text = "Ampla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents Budget As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents EnvLabel As System.Windows.Forms.Label
    Friend WithEvents EnvNum As System.Windows.Forms.Label
    Friend WithEvents FoodLabel As System.Windows.Forms.Label
    Friend WithEvents FoodNum As System.Windows.Forms.Label
    Friend WithEvents IncLabel As System.Windows.Forms.Label
    Friend WithEvents IncNum As System.Windows.Forms.Label
    Friend WithEvents PopLabel As System.Windows.Forms.Label
    Friend WithEvents PopNum As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RoundLabel As System.Windows.Forms.Label

End Class
