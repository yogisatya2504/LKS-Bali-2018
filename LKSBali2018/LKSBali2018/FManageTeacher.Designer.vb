<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FManageTeacher
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
        Me.bcancel = New System.Windows.Forms.Button()
        Me.bsave = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bupdate = New System.Windows.Forms.Button()
        Me.binsert = New System.Windows.Forms.Button()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.rfemale = New System.Windows.Forms.RadioButton()
        Me.rmale = New System.Windows.Forms.RadioButton()
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bcancel
        '
        Me.bcancel.Location = New System.Drawing.Point(196, 451)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 23)
        Me.bcancel.TabIndex = 30
        Me.bcancel.Text = "Cencel"
        Me.bcancel.UseVisualStyleBackColor = True
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(115, 451)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 31
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'bdelete
        '
        Me.bdelete.Location = New System.Drawing.Point(236, 422)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(75, 23)
        Me.bdelete.TabIndex = 29
        Me.bdelete.Text = "Delete"
        Me.bdelete.UseVisualStyleBackColor = True
        '
        'bupdate
        '
        Me.bupdate.Location = New System.Drawing.Point(155, 422)
        Me.bupdate.Name = "bupdate"
        Me.bupdate.Size = New System.Drawing.Size(75, 23)
        Me.bupdate.TabIndex = 28
        Me.bupdate.Text = "Update"
        Me.bupdate.UseVisualStyleBackColor = True
        '
        'binsert
        '
        Me.binsert.Location = New System.Drawing.Point(74, 422)
        Me.binsert.Name = "binsert"
        Me.binsert.Size = New System.Drawing.Size(75, 23)
        Me.binsert.TabIndex = 27
        Me.binsert.Text = "Insert"
        Me.binsert.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(155, 370)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(150, 20)
        Me.dtpdate.TabIndex = 26
        '
        'rfemale
        '
        Me.rfemale.AutoSize = True
        Me.rfemale.Location = New System.Drawing.Point(246, 347)
        Me.rfemale.Name = "rfemale"
        Me.rfemale.Size = New System.Drawing.Size(59, 17)
        Me.rfemale.TabIndex = 25
        Me.rfemale.TabStop = True
        Me.rfemale.Text = "Female"
        Me.rfemale.UseVisualStyleBackColor = True
        '
        'rmale
        '
        Me.rmale.AutoSize = True
        Me.rmale.Location = New System.Drawing.Point(155, 347)
        Me.rmale.Name = "rmale"
        Me.rmale.Size = New System.Drawing.Size(48, 17)
        Me.rmale.TabIndex = 24
        Me.rmale.TabStop = True
        Me.rmale.Text = "Male"
        Me.rmale.UseVisualStyleBackColor = True
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(155, 296)
        Me.taddress.Multiline = True
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(150, 45)
        Me.taddress.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Address"
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(155, 396)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(150, 20)
        Me.tbphone.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phone Number"
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(155, 270)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(150, 20)
        Me.tname.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Teacher Name"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(155, 244)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(150, 20)
        Me.tid.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Teacher ID"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(16, 88)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(327, 150)
        Me.dgv.TabIndex = 13
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(135, 62)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(145, 20)
        Me.tsearch.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Form Teacher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search"
        '
        'FManageTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 491)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.bsave)
        Me.Controls.Add(Me.bdelete)
        Me.Controls.Add(Me.bupdate)
        Me.Controls.Add(Me.binsert)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.rfemale)
        Me.Controls.Add(Me.rmale)
        Me.Controls.Add(Me.taddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbphone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FManageTeacher"
        Me.Text = "FManageTeacher"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bupdate As System.Windows.Forms.Button
    Friend WithEvents binsert As System.Windows.Forms.Button
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rmale As System.Windows.Forms.RadioButton
    Friend WithEvents taddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
