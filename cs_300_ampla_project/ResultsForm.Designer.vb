<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(514, 473)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishButton.TabIndex = 0
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(433, 473)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(75, 23)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "Draw States"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 508)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.FinishButton)
        Me.Name = "ResultsForm"
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinishButton As System.Windows.Forms.Button
    Friend WithEvents DrawButton As System.Windows.Forms.Button
End Class
