<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInputScoreForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.csubject = New System.Windows.Forms.ComboBox()
        Me.cclassname = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bentryscore = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 70)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(368, 150)
        Me.dgv.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Subject"
        '
        'csubject
        '
        Me.csubject.FormattingEnabled = True
        Me.csubject.Location = New System.Drawing.Point(58, 14)
        Me.csubject.Name = "csubject"
        Me.csubject.Size = New System.Drawing.Size(121, 21)
        Me.csubject.TabIndex = 5
        '
        'cclassname
        '
        Me.cclassname.FormattingEnabled = True
        Me.cclassname.Location = New System.Drawing.Point(259, 14)
        Me.cclassname.Name = "cclassname"
        Me.cclassname.Size = New System.Drawing.Size(121, 21)
        Me.cclassname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Class Name"
        '
        'bentryscore
        '
        Me.bentryscore.Location = New System.Drawing.Point(158, 227)
        Me.bentryscore.Name = "bentryscore"
        Me.bentryscore.Size = New System.Drawing.Size(75, 23)
        Me.bentryscore.TabIndex = 9
        Me.bentryscore.Text = "Entry Score"
        Me.bentryscore.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Assignment : 20%, Mid Exam : 30%, Final Exam : 50%"
        '
        'FInputScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 262)
        Me.Controls.Add(Me.bentryscore)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cclassname)
        Me.Controls.Add(Me.csubject)
        Me.Name = "FInputScoreForm"
        Me.Text = "FInputScoreForm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents csubject As System.Windows.Forms.ComboBox
    Friend WithEvents cclassname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bentryscore As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
