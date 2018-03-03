<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FManageScheduleForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cclass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cday = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.csubject = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cshifft = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cteacher = New System.Windows.Forms.ComboBox()
        Me.bcancel = New System.Windows.Forms.Button()
        Me.bsave = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bupdate = New System.Windows.Forms.Button()
        Me.binsert = New System.Windows.Forms.Button()
        Me.bviewsubject = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Manage Schedule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Class"
        '
        'cclass
        '
        Me.cclass.FormattingEnabled = True
        Me.cclass.Location = New System.Drawing.Point(57, 49)
        Me.cclass.Name = "cclass"
        Me.cclass.Size = New System.Drawing.Size(121, 21)
        Me.cclass.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Day"
        '
        'cday
        '
        Me.cday.FormattingEnabled = True
        Me.cday.Location = New System.Drawing.Point(234, 49)
        Me.cday.Name = "cday"
        Me.cday.Size = New System.Drawing.Size(121, 21)
        Me.cday.TabIndex = 38
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 76)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(383, 150)
        Me.dgv.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Subject"
        '
        'csubject
        '
        Me.csubject.FormattingEnabled = True
        Me.csubject.Location = New System.Drawing.Point(143, 232)
        Me.csubject.Name = "csubject"
        Me.csubject.Size = New System.Drawing.Size(141, 21)
        Me.csubject.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Shift"
        '
        'cshifft
        '
        Me.cshifft.FormattingEnabled = True
        Me.cshifft.Location = New System.Drawing.Point(143, 259)
        Me.cshifft.Name = "cshifft"
        Me.cshifft.Size = New System.Drawing.Size(141, 21)
        Me.cshifft.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Teacher"
        '
        'cteacher
        '
        Me.cteacher.FormattingEnabled = True
        Me.cteacher.Location = New System.Drawing.Point(143, 286)
        Me.cteacher.Name = "cteacher"
        Me.cteacher.Size = New System.Drawing.Size(141, 21)
        Me.cteacher.TabIndex = 38
        '
        'bcancel
        '
        Me.bcancel.Location = New System.Drawing.Point(184, 342)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 23)
        Me.bcancel.TabIndex = 43
        Me.bcancel.Text = "Cencel"
        Me.bcancel.UseVisualStyleBackColor = True
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(103, 342)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 44
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'bdelete
        '
        Me.bdelete.Location = New System.Drawing.Point(224, 313)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(75, 23)
        Me.bdelete.TabIndex = 42
        Me.bdelete.Text = "Delete"
        Me.bdelete.UseVisualStyleBackColor = True
        '
        'bupdate
        '
        Me.bupdate.Location = New System.Drawing.Point(143, 313)
        Me.bupdate.Name = "bupdate"
        Me.bupdate.Size = New System.Drawing.Size(75, 23)
        Me.bupdate.TabIndex = 41
        Me.bupdate.Text = "Update"
        Me.bupdate.UseVisualStyleBackColor = True
        '
        'binsert
        '
        Me.binsert.Location = New System.Drawing.Point(62, 313)
        Me.binsert.Name = "binsert"
        Me.binsert.Size = New System.Drawing.Size(75, 23)
        Me.binsert.TabIndex = 40
        Me.binsert.Text = "Insert"
        Me.binsert.UseVisualStyleBackColor = True
        '
        'bviewsubject
        '
        Me.bviewsubject.Location = New System.Drawing.Point(290, 235)
        Me.bviewsubject.Name = "bviewsubject"
        Me.bviewsubject.Size = New System.Drawing.Size(108, 23)
        Me.bviewsubject.TabIndex = 42
        Me.bviewsubject.Text = "View Subject Need"
        Me.bviewsubject.UseVisualStyleBackColor = True
        '
        'FManageScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 387)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.bviewsubject)
        Me.Controls.Add(Me.bdelete)
        Me.Controls.Add(Me.bupdate)
        Me.Controls.Add(Me.binsert)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cteacher)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cshifft)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.csubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cclass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FManageScheduleForm"
        Me.Text = "FManageScheduleForm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cday As System.Windows.Forms.ComboBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents csubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cshifft As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cteacher As System.Windows.Forms.ComboBox
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bupdate As System.Windows.Forms.Button
    Friend WithEvents binsert As System.Windows.Forms.Button
    Friend WithEvents bviewsubject As System.Windows.Forms.Button
End Class
