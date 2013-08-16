<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetForm
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
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RedBudget = New System.Windows.Forms.TextBox()
        Me.RedProjects = New System.Windows.Forms.Label()
        Me.BlueBudget = New System.Windows.Forms.TextBox()
        Me.BlueProjects = New System.Windows.Forms.Label()
        Me.OrangeProjects = New System.Windows.Forms.Label()
        Me.YellowProjects = New System.Windows.Forms.Label()
        Me.GreenProjects = New System.Windows.Forms.Label()
        Me.OrangeBudget = New System.Windows.Forms.TextBox()
        Me.YellowBudget = New System.Windows.Forms.TextBox()
        Me.GreenBudget = New System.Windows.Forms.TextBox()
        Me.SaveBudgetButton = New System.Windows.Forms.Button()
        Me.BudgetTitle = New System.Windows.Forms.Label()
        Me.RemainingBudget = New System.Windows.Forms.Label()
        Me.BuxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(21, 217)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(81, 23)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "Reset Values"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'RedBudget
        '
        Me.RedBudget.Location = New System.Drawing.Point(152, 12)
        Me.RedBudget.Name = "RedBudget"
        Me.RedBudget.Size = New System.Drawing.Size(100, 20)
        Me.RedBudget.TabIndex = 1
        '
        'RedProjects
        '
        Me.RedProjects.AutoSize = True
        Me.RedProjects.Location = New System.Drawing.Point(18, 12)
        Me.RedProjects.Name = "RedProjects"
        Me.RedProjects.Size = New System.Drawing.Size(57, 13)
        Me.RedProjects.TabIndex = 2
        Me.RedProjects.Text = "Agriculture"
        '
        'BlueBudget
        '
        Me.BlueBudget.Location = New System.Drawing.Point(152, 42)
        Me.BlueBudget.Name = "BlueBudget"
        Me.BlueBudget.Size = New System.Drawing.Size(100, 20)
        Me.BlueBudget.TabIndex = 3
        '
        'BlueProjects
        '
        Me.BlueProjects.AutoSize = True
        Me.BlueProjects.Location = New System.Drawing.Point(18, 42)
        Me.BlueProjects.Name = "BlueProjects"
        Me.BlueProjects.Size = New System.Drawing.Size(46, 13)
        Me.BlueProjects.TabIndex = 4
        Me.BlueProjects.Text = "Science"
        '
        'OrangeProjects
        '
        Me.OrangeProjects.AutoSize = True
        Me.OrangeProjects.Location = New System.Drawing.Point(18, 72)
        Me.OrangeProjects.Name = "OrangeProjects"
        Me.OrangeProjects.Size = New System.Drawing.Size(44, 13)
        Me.OrangeProjects.TabIndex = 5
        Me.OrangeProjects.Text = "Industry"
        '
        'YellowProjects
        '
        Me.YellowProjects.AutoSize = True
        Me.YellowProjects.Location = New System.Drawing.Point(18, 103)
        Me.YellowProjects.Name = "YellowProjects"
        Me.YellowProjects.Size = New System.Drawing.Size(55, 13)
        Me.YellowProjects.TabIndex = 6
        Me.YellowProjects.Text = "Education"
        '
        'GreenProjects
        '
        Me.GreenProjects.AutoSize = True
        Me.GreenProjects.Location = New System.Drawing.Point(19, 134)
        Me.GreenProjects.Name = "GreenProjects"
        Me.GreenProjects.Size = New System.Drawing.Size(83, 13)
        Me.GreenProjects.TabIndex = 7
        Me.GreenProjects.Text = "Pollution Control"
        '
        'OrangeBudget
        '
        Me.OrangeBudget.Location = New System.Drawing.Point(152, 72)
        Me.OrangeBudget.Name = "OrangeBudget"
        Me.OrangeBudget.Size = New System.Drawing.Size(100, 20)
        Me.OrangeBudget.TabIndex = 8
        '
        'YellowBudget
        '
        Me.YellowBudget.Location = New System.Drawing.Point(152, 103)
        Me.YellowBudget.Name = "YellowBudget"
        Me.YellowBudget.Size = New System.Drawing.Size(100, 20)
        Me.YellowBudget.TabIndex = 9
        '
        'GreenBudget
        '
        Me.GreenBudget.Location = New System.Drawing.Point(152, 134)
        Me.GreenBudget.Name = "GreenBudget"
        Me.GreenBudget.Size = New System.Drawing.Size(100, 20)
        Me.GreenBudget.TabIndex = 10
        '
        'SaveBudgetButton
        '
        Me.SaveBudgetButton.Location = New System.Drawing.Point(152, 217)
        Me.SaveBudgetButton.Name = "SaveBudgetButton"
        Me.SaveBudgetButton.Size = New System.Drawing.Size(83, 23)
        Me.SaveBudgetButton.TabIndex = 11
        Me.SaveBudgetButton.Text = "Save Budget"
        Me.SaveBudgetButton.UseVisualStyleBackColor = True
        '
        'BudgetTitle
        '
        Me.BudgetTitle.AutoSize = True
        Me.BudgetTitle.Location = New System.Drawing.Point(22, 175)
        Me.BudgetTitle.Name = "BudgetTitle"
        Me.BudgetTitle.Size = New System.Drawing.Size(97, 13)
        Me.BudgetTitle.TabIndex = 12
        Me.BudgetTitle.Text = "Remaining Budget:"
        '
        'RemainingBudget
        '
        Me.RemainingBudget.AutoSize = True
        Me.RemainingBudget.Location = New System.Drawing.Point(167, 175)
        Me.RemainingBudget.Name = "RemainingBudget"
        Me.RemainingBudget.Size = New System.Drawing.Size(25, 13)
        Me.RemainingBudget.TabIndex = 13
        Me.RemainingBudget.Text = "100"
        '
        'BuxLabel
        '
        Me.BuxLabel.AutoSize = True
        Me.BuxLabel.Location = New System.Drawing.Point(198, 175)
        Me.BuxLabel.Name = "BuxLabel"
        Me.BuxLabel.Size = New System.Drawing.Size(30, 13)
        Me.BuxLabel.TabIndex = 14
        Me.BuxLabel.Text = "Buxs"
        '
        'BudgetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BuxLabel)
        Me.Controls.Add(Me.RemainingBudget)
        Me.Controls.Add(Me.BudgetTitle)
        Me.Controls.Add(Me.SaveBudgetButton)
        Me.Controls.Add(Me.GreenBudget)
        Me.Controls.Add(Me.YellowBudget)
        Me.Controls.Add(Me.OrangeBudget)
        Me.Controls.Add(Me.GreenProjects)
        Me.Controls.Add(Me.YellowProjects)
        Me.Controls.Add(Me.OrangeProjects)
        Me.Controls.Add(Me.BlueProjects)
        Me.Controls.Add(Me.BlueBudget)
        Me.Controls.Add(Me.RedProjects)
        Me.Controls.Add(Me.RedBudget)
        Me.Controls.Add(Me.ResetButton)
        Me.Name = "BudgetForm"
        Me.Text = "Set Budget"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents RedBudget As System.Windows.Forms.TextBox
    Friend WithEvents RedProjects As System.Windows.Forms.Label
    Friend WithEvents BlueBudget As System.Windows.Forms.TextBox
    Friend WithEvents BlueProjects As System.Windows.Forms.Label
    Friend WithEvents OrangeProjects As System.Windows.Forms.Label
    Friend WithEvents YellowProjects As System.Windows.Forms.Label
    Friend WithEvents GreenProjects As System.Windows.Forms.Label
    Friend WithEvents OrangeBudget As System.Windows.Forms.TextBox
    Friend WithEvents YellowBudget As System.Windows.Forms.TextBox
    Friend WithEvents GreenBudget As System.Windows.Forms.TextBox
    Friend WithEvents SaveBudgetButton As System.Windows.Forms.Button
    Friend WithEvents BudgetTitle As System.Windows.Forms.Label
    Friend WithEvents RemainingBudget As System.Windows.Forms.Label
    Friend WithEvents BuxLabel As System.Windows.Forms.Label
End Class
