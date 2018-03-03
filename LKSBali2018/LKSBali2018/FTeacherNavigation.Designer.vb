<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTeacherNavigation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bedit = New System.Windows.Forms.Button()
        Me.bschedule = New System.Windows.Forms.Button()
        Me.bscore = New System.Windows.Forms.Button()
        Me.blogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, [ Nama Guru ]"
        '
        'bedit
        '
        Me.bedit.Location = New System.Drawing.Point(78, 72)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(131, 29)
        Me.bedit.TabIndex = 1
        Me.bedit.Text = "Edit Profile"
        Me.bedit.UseVisualStyleBackColor = True
        '
        'bschedule
        '
        Me.bschedule.Location = New System.Drawing.Point(78, 107)
        Me.bschedule.Name = "bschedule"
        Me.bschedule.Size = New System.Drawing.Size(131, 29)
        Me.bschedule.TabIndex = 1
        Me.bschedule.Text = "Teaching Schedule"
        Me.bschedule.UseVisualStyleBackColor = True
        '
        'bscore
        '
        Me.bscore.Location = New System.Drawing.Point(78, 142)
        Me.bscore.Name = "bscore"
        Me.bscore.Size = New System.Drawing.Size(131, 29)
        Me.bscore.TabIndex = 1
        Me.bscore.Text = "Input Score"
        Me.bscore.UseVisualStyleBackColor = True
        '
        'blogout
        '
        Me.blogout.Location = New System.Drawing.Point(78, 177)
        Me.blogout.Name = "blogout"
        Me.blogout.Size = New System.Drawing.Size(131, 29)
        Me.blogout.TabIndex = 1
        Me.blogout.Text = "Logout"
        Me.blogout.UseVisualStyleBackColor = True
        '
        'FTeacherNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.blogout)
        Me.Controls.Add(Me.bscore)
        Me.Controls.Add(Me.bschedule)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FTeacherNavigation"
        Me.Text = "FTeacherNavigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bedit As System.Windows.Forms.Button
    Friend WithEvents bschedule As System.Windows.Forms.Button
    Friend WithEvents bscore As System.Windows.Forms.Button
    Friend WithEvents blogout As System.Windows.Forms.Button
End Class
