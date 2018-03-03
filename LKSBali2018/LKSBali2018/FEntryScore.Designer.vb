<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEntryScore
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
        Me.lid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tassignment = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tmid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tfinal = New System.Windows.Forms.TextBox()
        Me.bsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lid
        '
        Me.lid.AutoSize = True
        Me.lid.Location = New System.Drawing.Point(98, 9)
        Me.lid.Name = "lid"
        Me.lid.Size = New System.Drawing.Size(98, 13)
        Me.lid.TabIndex = 7
        Me.lid.Text = "[StudentID - Name]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Assignment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mid Exam"
        '
        'tassignment
        '
        Me.tassignment.Location = New System.Drawing.Point(101, 45)
        Me.tassignment.Name = "tassignment"
        Me.tassignment.Size = New System.Drawing.Size(150, 20)
        Me.tassignment.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 20)
        Me.TextBox2.TabIndex = 9
        '
        'tmid
        '
        Me.tmid.Location = New System.Drawing.Point(101, 71)
        Me.tmid.Name = "tmid"
        Me.tmid.Size = New System.Drawing.Size(150, 20)
        Me.tmid.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Final Exam"
        '
        'tfinal
        '
        Me.tfinal.Location = New System.Drawing.Point(101, 95)
        Me.tfinal.Name = "tfinal"
        Me.tfinal.Size = New System.Drawing.Size(150, 20)
        Me.tfinal.TabIndex = 9
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(101, 121)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 10
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'FEntryScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.tfinal)
        Me.Controls.Add(Me.tmid)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tassignment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lid)
        Me.Name = "FEntryScore"
        Me.Text = "FEntryScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tassignment As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tmid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tfinal As System.Windows.Forms.TextBox
    Friend WithEvents bsave As System.Windows.Forms.Button
End Class
