<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FViewScheduleTeacher
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
        Me.dgvstudentlist = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvschedule = New System.Windows.Forms.DataGridView()
        CType(Me.dgvstudentlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student List"
        '
        'dgvstudentlist
        '
        Me.dgvstudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstudentlist.Location = New System.Drawing.Point(15, 227)
        Me.dgvstudentlist.Name = "dgvstudentlist"
        Me.dgvstudentlist.Size = New System.Drawing.Size(368, 235)
        Me.dgvstudentlist.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Schedule"
        '
        'dgvschedule
        '
        Me.dgvschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvschedule.Location = New System.Drawing.Point(15, 35)
        Me.dgvschedule.Name = "dgvschedule"
        Me.dgvschedule.Size = New System.Drawing.Size(368, 150)
        Me.dgvschedule.TabIndex = 1
        '
        'FViewScheduleTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 474)
        Me.Controls.Add(Me.dgvschedule)
        Me.Controls.Add(Me.dgvstudentlist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FViewScheduleTeacher"
        Me.Text = "FViewScheduleTeacher"
        CType(Me.dgvstudentlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvstudentlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvschedule As System.Windows.Forms.DataGridView
End Class
