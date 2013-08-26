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
        Me.ExitBudgetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrevAgri = New System.Windows.Forms.Label()
        Me.PrevSci = New System.Windows.Forms.Label()
        Me.PrevInd = New System.Windows.Forms.Label()
        Me.PrevEdu = New System.Windows.Forms.Label()
        Me.PrevPol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(12, 251)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(81, 23)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "Reset Values"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'RedBudget
        '
        Me.RedBudget.Location = New System.Drawing.Point(188, 29)
        Me.RedBudget.Name = "RedBudget"
        Me.RedBudget.Size = New System.Drawing.Size(82, 20)
        Me.RedBudget.TabIndex = 1
        '
        'RedProjects
        '
        Me.RedProjects.AutoSize = True
        Me.RedProjects.Location = New System.Drawing.Point(18, 32)
        Me.RedProjects.Name = "RedProjects"
        Me.RedProjects.Size = New System.Drawing.Size(57, 13)
        Me.RedProjects.TabIndex = 2
        Me.RedProjects.Text = "Agriculture"
        '
        'BlueBudget
        '
        Me.BlueBudget.Location = New System.Drawing.Point(188, 66)
        Me.BlueBudget.Name = "BlueBudget"
        Me.BlueBudget.Size = New System.Drawing.Size(82, 20)
        Me.BlueBudget.TabIndex = 3
        '
        'BlueProjects
        '
        Me.BlueProjects.AutoSize = True
        Me.BlueProjects.Location = New System.Drawing.Point(18, 69)
        Me.BlueProjects.Name = "BlueProjects"
        Me.BlueProjects.Size = New System.Drawing.Size(46, 13)
        Me.BlueProjects.TabIndex = 4
        Me.BlueProjects.Text = "Science"
        '
        'OrangeProjects
        '
        Me.OrangeProjects.AutoSize = True
        Me.OrangeProjects.Location = New System.Drawing.Point(20, 105)
        Me.OrangeProjects.Name = "OrangeProjects"
        Me.OrangeProjects.Size = New System.Drawing.Size(44, 13)
        Me.OrangeProjects.TabIndex = 5
        Me.OrangeProjects.Text = "Industry"
        '
        'YellowProjects
        '
        Me.YellowProjects.AutoSize = True
        Me.YellowProjects.Location = New System.Drawing.Point(20, 140)
        Me.YellowProjects.Name = "YellowProjects"
        Me.YellowProjects.Size = New System.Drawing.Size(55, 13)
        Me.YellowProjects.TabIndex = 6
        Me.YellowProjects.Text = "Education"
        '
        'GreenProjects
        '
        Me.GreenProjects.AutoSize = True
        Me.GreenProjects.Location = New System.Drawing.Point(18, 176)
        Me.GreenProjects.Name = "GreenProjects"
        Me.GreenProjects.Size = New System.Drawing.Size(83, 13)
        Me.GreenProjects.TabIndex = 7
        Me.GreenProjects.Text = "Pollution Control"
        '
        'OrangeBudget
        '
        Me.OrangeBudget.Location = New System.Drawing.Point(188, 102)
        Me.OrangeBudget.Name = "OrangeBudget"
        Me.OrangeBudget.Size = New System.Drawing.Size(82, 20)
        Me.OrangeBudget.TabIndex = 8
        '
        'YellowBudget
        '
        Me.YellowBudget.Location = New System.Drawing.Point(188, 137)
        Me.YellowBudget.Name = "YellowBudget"
        Me.YellowBudget.Size = New System.Drawing.Size(82, 20)
        Me.YellowBudget.TabIndex = 9
        '
        'GreenBudget
        '
        Me.GreenBudget.Location = New System.Drawing.Point(188, 173)
        Me.GreenBudget.Name = "GreenBudget"
        Me.GreenBudget.Size = New System.Drawing.Size(82, 20)
        Me.GreenBudget.TabIndex = 10
        '
        'SaveBudgetButton
        '
        Me.SaveBudgetButton.Location = New System.Drawing.Point(99, 251)
        Me.SaveBudgetButton.Name = "SaveBudgetButton"
        Me.SaveBudgetButton.Size = New System.Drawing.Size(83, 23)
        Me.SaveBudgetButton.TabIndex = 11
        Me.SaveBudgetButton.Text = "Save Budget"
        Me.SaveBudgetButton.UseVisualStyleBackColor = True
        '
        'BudgetTitle
        '
        Me.BudgetTitle.AutoSize = True
        Me.BudgetTitle.Location = New System.Drawing.Point(33, 218)
        Me.BudgetTitle.Name = "BudgetTitle"
        Me.BudgetTitle.Size = New System.Drawing.Size(97, 13)
        Me.BudgetTitle.TabIndex = 12
        Me.BudgetTitle.Text = "Remaining Budget:"
        '
        'RemainingBudget
        '
        Me.RemainingBudget.AutoSize = True
        Me.RemainingBudget.Location = New System.Drawing.Point(167, 218)
        Me.RemainingBudget.Name = "RemainingBudget"
        Me.RemainingBudget.Size = New System.Drawing.Size(25, 13)
        Me.RemainingBudget.TabIndex = 13
        Me.RemainingBudget.Text = "100"
        '
        'BuxLabel
        '
        Me.BuxLabel.AutoSize = True
        Me.BuxLabel.Location = New System.Drawing.Point(201, 218)
        Me.BuxLabel.Name = "BuxLabel"
        Me.BuxLabel.Size = New System.Drawing.Size(30, 13)
        Me.BuxLabel.TabIndex = 14
        Me.BuxLabel.Text = "Buxs"
        '
        'ExitBudgetButton
        '
        Me.ExitBudgetButton.Location = New System.Drawing.Point(188, 251)
        Me.ExitBudgetButton.Name = "ExitBudgetButton"
        Me.ExitBudgetButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitBudgetButton.TabIndex = 15
        Me.ExitBudgetButton.Text = "Exit"
        Me.ExitBudgetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Previous"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Current"
        '
        'PrevAgri
        '
        Me.PrevAgri.AutoSize = True
        Me.PrevAgri.Location = New System.Drawing.Point(133, 32)
        Me.PrevAgri.Name = "PrevAgri"
        Me.PrevAgri.Size = New System.Drawing.Size(13, 13)
        Me.PrevAgri.TabIndex = 18
        Me.PrevAgri.Text = "0"
        '
        'PrevSci
        '
        Me.PrevSci.AutoSize = True
        Me.PrevSci.Location = New System.Drawing.Point(133, 69)
        Me.PrevSci.Name = "PrevSci"
        Me.PrevSci.Size = New System.Drawing.Size(13, 13)
        Me.PrevSci.TabIndex = 19
        Me.PrevSci.Text = "0"
        '
        'PrevInd
        '
        Me.PrevInd.AutoSize = True
        Me.PrevInd.Location = New System.Drawing.Point(133, 105)
        Me.PrevInd.Name = "PrevInd"
        Me.PrevInd.Size = New System.Drawing.Size(13, 13)
        Me.PrevInd.TabIndex = 20
        Me.PrevInd.Text = "0"
        '
        'PrevEdu
        '
        Me.PrevEdu.AutoSize = True
        Me.PrevEdu.Location = New System.Drawing.Point(133, 140)
        Me.PrevEdu.Name = "PrevEdu"
        Me.PrevEdu.Size = New System.Drawing.Size(13, 13)
        Me.PrevEdu.TabIndex = 21
        Me.PrevEdu.Text = "0"
        '
        'PrevPol
        '
        Me.PrevPol.AutoSize = True
        Me.PrevPol.Location = New System.Drawing.Point(133, 176)
        Me.PrevPol.Name = "PrevPol"
        Me.PrevPol.Size = New System.Drawing.Size(13, 13)
        Me.PrevPol.TabIndex = 22
        Me.PrevPol.Text = "0"
        '
        'BudgetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 286)
        Me.Controls.Add(Me.PrevPol)
        Me.Controls.Add(Me.PrevEdu)
        Me.Controls.Add(Me.PrevInd)
        Me.Controls.Add(Me.PrevSci)
        Me.Controls.Add(Me.PrevAgri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBudgetButton)
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
    Friend WithEvents ExitBudgetButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrevAgri As System.Windows.Forms.Label
    Friend WithEvents PrevSci As System.Windows.Forms.Label
    Friend WithEvents PrevInd As System.Windows.Forms.Label
    Friend WithEvents PrevEdu As System.Windows.Forms.Label
    Friend WithEvents PrevPol As System.Windows.Forms.Label
End Class
