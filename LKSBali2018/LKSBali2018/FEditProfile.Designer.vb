<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEditProfile
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.bup = New System.Windows.Forms.Button()
        Me.bchangepwd = New System.Windows.Forms.Button()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bcancel = New System.Windows.Forms.Button()
        Me.bsave = New System.Windows.Forms.Button()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Form Profile"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(75, 36)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(146, 143)
        Me.pb.TabIndex = 13
        Me.pb.TabStop = False
        '
        'bup
        '
        Me.bup.Location = New System.Drawing.Point(194, 156)
        Me.bup.Name = "bup"
        Me.bup.Size = New System.Drawing.Size(27, 23)
        Me.bup.TabIndex = 14
        Me.bup.Text = "U"
        Me.bup.UseVisualStyleBackColor = True
        '
        'bchangepwd
        '
        Me.bchangepwd.Location = New System.Drawing.Point(89, 185)
        Me.bchangepwd.Name = "bchangepwd"
        Me.bchangepwd.Size = New System.Drawing.Size(120, 23)
        Me.bchangepwd.TabIndex = 14
        Me.bchangepwd.Text = "Change Password"
        Me.bchangepwd.UseVisualStyleBackColor = True
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(110, 224)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(150, 20)
        Me.tid.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ID"
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(110, 302)
        Me.taddress.Multiline = True
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(150, 45)
        Me.taddress.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Address"
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(110, 276)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(150, 20)
        Me.tbphone.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Phone Number"
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(110, 250)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(150, 20)
        Me.tname.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Name"
        '
        'bcancel
        '
        Me.bcancel.Location = New System.Drawing.Point(153, 353)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 23)
        Me.bcancel.TabIndex = 32
        Me.bcancel.Text = "Cencel"
        Me.bcancel.UseVisualStyleBackColor = True
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(72, 353)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 33
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'FEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 412)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.taddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbphone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bchangepwd)
        Me.Controls.Add(Me.bup)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FEditProfile"
        Me.Text = "FEditProfile"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents bup As System.Windows.Forms.Button
    Friend WithEvents bchangepwd As System.Windows.Forms.Button
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents taddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
End Class
