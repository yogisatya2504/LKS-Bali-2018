<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FManageClass
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
        Me.dgvstudentlist = New System.Windows.Forms.DataGridView()
        Me.dgvparticipatestudent = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cclass = New System.Windows.Forms.ComboBox()
        Me.btoparticipatte = New System.Windows.Forms.Button()
        Me.btostudentlist = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvstudentlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvparticipatestudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Manage Class"
        '
        'dgvstudentlist
        '
        Me.dgvstudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstudentlist.Location = New System.Drawing.Point(12, 91)
        Me.dgvstudentlist.Name = "dgvstudentlist"
        Me.dgvstudentlist.Size = New System.Drawing.Size(197, 294)
        Me.dgvstudentlist.TabIndex = 36
        '
        'dgvparticipatestudent
        '
        Me.dgvparticipatestudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvparticipatestudent.Location = New System.Drawing.Point(256, 91)
        Me.dgvparticipatestudent.Name = "dgvparticipatestudent"
        Me.dgvparticipatestudent.Size = New System.Drawing.Size(197, 294)
        Me.dgvparticipatestudent.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Class Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Student List"
        '
        'cclass
        '
        Me.cclass.FormattingEnabled = True
        Me.cclass.Location = New System.Drawing.Point(85, 39)
        Me.cclass.Name = "cclass"
        Me.cclass.Size = New System.Drawing.Size(121, 21)
        Me.cclass.TabIndex = 38
        '
        'btoparticipatte
        '
        Me.btoparticipatte.Location = New System.Drawing.Point(215, 155)
        Me.btoparticipatte.Name = "btoparticipatte"
        Me.btoparticipatte.Size = New System.Drawing.Size(35, 23)
        Me.btoparticipatte.TabIndex = 39
        Me.btoparticipatte.Text = ">>"
        Me.btoparticipatte.UseVisualStyleBackColor = True
        '
        'btostudentlist
        '
        Me.btostudentlist.Location = New System.Drawing.Point(215, 184)
        Me.btostudentlist.Name = "btostudentlist"
        Me.btostudentlist.Size = New System.Drawing.Size(35, 23)
        Me.btostudentlist.TabIndex = 39
        Me.btostudentlist.Text = "<<"
        Me.btostudentlist.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Participate Student"
        '
        'FManageClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 397)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btostudentlist)
        Me.Controls.Add(Me.btoparticipatte)
        Me.Controls.Add(Me.cclass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvparticipatestudent)
        Me.Controls.Add(Me.dgvstudentlist)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FManageClass"
        Me.Text = "FManageClass"
        CType(Me.dgvstudentlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvparticipatestudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvstudentlist As System.Windows.Forms.DataGridView
    Friend WithEvents dgvparticipatestudent As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cclass As System.Windows.Forms.ComboBox
    Friend WithEvents btoparticipatte As System.Windows.Forms.Button
    Friend WithEvents btostudentlist As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
