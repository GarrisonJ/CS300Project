<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(523, 386)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(75, 23)
        Me.MenuButton.TabIndex = 1
        Me.MenuButton.Text = "Main Menu"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'Budget
        '
        Me.Budget.Location = New System.Drawing.Point(523, 49)
        Me.Budget.Name = "Budget"
        Me.Budget.Size = New System.Drawing.Size(75, 23)
        Me.Budget.TabIndex = 2
        Me.Budget.Text = "Set Budget"
        Me.Budget.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(523, 93)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start Round"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 436)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Budget)
        Me.Controls.Add(Me.MenuButton)
        Me.Name = "GameForm"
        Me.Text = "Ampla"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents Budget As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button

End Class
