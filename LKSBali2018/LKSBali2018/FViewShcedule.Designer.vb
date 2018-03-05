<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FViewShcedule
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
        Me.cday = New System.Windows.Forms.ComboBox()
        Me.dgvschedule = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lclass = New System.Windows.Forms.Label()
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cday
        '
        Me.cday.FormattingEnabled = True
        Me.cday.Location = New System.Drawing.Point(41, 30)
        Me.cday.Name = "cday"
        Me.cday.Size = New System.Drawing.Size(121, 21)
        Me.cday.TabIndex = 0
        '
        'dgvschedule
        '
        Me.dgvschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvschedule.Location = New System.Drawing.Point(12, 86)
        Me.dgvschedule.Name = "dgvschedule"
        Me.dgvschedule.Size = New System.Drawing.Size(368, 150)
        Me.dgvschedule.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Schedule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Class Name :"
        '
        'lclass
        '
        Me.lclass.AutoSize = True
        Me.lclass.Location = New System.Drawing.Point(243, 33)
        Me.lclass.Name = "lclass"
        Me.lclass.Size = New System.Drawing.Size(41, 13)
        Me.lclass.TabIndex = 4
        Me.lclass.Text = "[ Class]"
        '
        'FViewShcedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 262)
        Me.Controls.Add(Me.lclass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvschedule)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cday)
        Me.Name = "FViewShcedule"
        Me.Text = "FViewSchedule"
        CType(Me.dgvschedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cday As System.Windows.Forms.ComboBox
    Friend WithEvents dgvschedule As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lclass As System.Windows.Forms.Label
End Class
