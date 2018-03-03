<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FManageStudent
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
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.rmale = New System.Windows.Forms.RadioButton()
        Me.rfemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.binsert = New System.Windows.Forms.Button()
        Me.bupdate = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bcancel = New System.Windows.Forms.Button()
        Me.bsave = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Form Student"
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(131, 54)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(145, 20)
        Me.tsearch.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 80)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(327, 150)
        Me.dgv.TabIndex = 2
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(151, 236)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(150, 20)
        Me.tid.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Student Name"
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(151, 262)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(150, 20)
        Me.tname.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address"
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(151, 288)
        Me.taddress.Multiline = True
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(150, 45)
        Me.taddress.TabIndex = 4
        '
        'rmale
        '
        Me.rmale.AutoSize = True
        Me.rmale.Location = New System.Drawing.Point(151, 339)
        Me.rmale.Name = "rmale"
        Me.rmale.Size = New System.Drawing.Size(48, 17)
        Me.rmale.TabIndex = 5
        Me.rmale.TabStop = True
        Me.rmale.Text = "Male"
        Me.rmale.UseVisualStyleBackColor = True
        '
        'rfemale
        '
        Me.rfemale.AutoSize = True
        Me.rfemale.Location = New System.Drawing.Point(242, 339)
        Me.rfemale.Name = "rfemale"
        Me.rfemale.Size = New System.Drawing.Size(59, 17)
        Me.rfemale.TabIndex = 5
        Me.rfemale.TabStop = True
        Me.rfemale.Text = "Female"
        Me.rfemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gender"
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(151, 362)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(150, 20)
        Me.dtpdate.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Phone Number"
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(151, 388)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(150, 20)
        Me.tbphone.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Date Of Birth"
        '
        'binsert
        '
        Me.binsert.Location = New System.Drawing.Point(70, 414)
        Me.binsert.Name = "binsert"
        Me.binsert.Size = New System.Drawing.Size(75, 23)
        Me.binsert.TabIndex = 7
        Me.binsert.Text = "Insert"
        Me.binsert.UseVisualStyleBackColor = True
        '
        'bupdate
        '
        Me.bupdate.Location = New System.Drawing.Point(151, 414)
        Me.bupdate.Name = "bupdate"
        Me.bupdate.Size = New System.Drawing.Size(75, 23)
        Me.bupdate.TabIndex = 7
        Me.bupdate.Text = "Update"
        Me.bupdate.UseVisualStyleBackColor = True
        '
        'bdelete
        '
        Me.bdelete.Location = New System.Drawing.Point(232, 414)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(75, 23)
        Me.bdelete.TabIndex = 7
        Me.bdelete.Text = "Delete"
        Me.bdelete.UseVisualStyleBackColor = True
        '
        'bcancel
        '
        Me.bcancel.Location = New System.Drawing.Point(192, 443)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 23)
        Me.bcancel.TabIndex = 8
        Me.bcancel.Text = "Cencel"
        Me.bcancel.UseVisualStyleBackColor = True
        '
        'bsave
        '
        Me.bsave.Location = New System.Drawing.Point(111, 443)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(75, 23)
        Me.bsave.TabIndex = 9
        Me.bsave.Text = "Save"
        Me.bsave.UseVisualStyleBackColor = True
        '
        'FManageStudent
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
        Me.Name = "FManageStudent"
        Me.Text = "FManageStudent"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents taddress As System.Windows.Forms.TextBox
    Friend WithEvents rmale As System.Windows.Forms.RadioButton
    Friend WithEvents rfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbphone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents binsert As System.Windows.Forms.Button
    Friend WithEvents bupdate As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents bsave As System.Windows.Forms.Button
End Class
