<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tuname = New System.Windows.Forms.TextBox()
        Me.tpwd = New System.Windows.Forms.TextBox()
        Me.blogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMK Nusantara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'tuname
        '
        Me.tuname.Location = New System.Drawing.Point(91, 86)
        Me.tuname.Name = "tuname"
        Me.tuname.Size = New System.Drawing.Size(167, 20)
        Me.tuname.TabIndex = 0
        '
        'tpwd
        '
        Me.tpwd.Location = New System.Drawing.Point(91, 123)
        Me.tpwd.Name = "tpwd"
        Me.tpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpwd.Size = New System.Drawing.Size(167, 20)
        Me.tpwd.TabIndex = 1
        '
        'blogin
        '
        Me.blogin.Location = New System.Drawing.Point(110, 173)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(75, 23)
        Me.blogin.TabIndex = 2
        Me.blogin.Text = "Login"
        Me.blogin.UseVisualStyleBackColor = True
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.blogin)
        Me.Controls.Add(Me.tpwd)
        Me.Controls.Add(Me.tuname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FLogin"
        Me.Text = "FLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tuname As System.Windows.Forms.TextBox
    Friend WithEvents tpwd As System.Windows.Forms.TextBox
    Friend WithEvents blogin As System.Windows.Forms.Button

End Class
