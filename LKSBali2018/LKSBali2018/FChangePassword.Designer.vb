<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FChangePassword
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
        Me.bsave = New System.Windows.Forms.Button()
        Me.tconfirm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tnew = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.told = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(98, 155)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 47
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'tconfirm
        '
        Me.tconfirm.Location = New System.Drawing.Point(122, 108)
        Me.tconfirm.Name = "tconfirm"
        Me.tconfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tconfirm.Size = New System.Drawing.Size(150, 20)
        Me.tconfirm.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Conform Password"
        '
        'tnew
        '
        Me.tnew.Location = New System.Drawing.Point(122, 82)
        Me.tnew.Name = "tnew"
        Me.tnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tnew.Size = New System.Drawing.Size(150, 20)
        Me.tnew.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "New Password"
        '
        'told
        '
        Me.told.Location = New System.Drawing.Point(122, 56)
        Me.told.Name = "told"
        Me.told.Size = New System.Drawing.Size(150, 20)
        Me.told.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Change Password"
        '
        'FChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 201)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.tconfirm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tnew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.told)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FChangePassword"
        Me.Text = "FChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents tconfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tnew As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents told As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
