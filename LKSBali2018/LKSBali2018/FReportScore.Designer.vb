﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReportScore
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.csubject = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lpercentage = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject Name"
        '
        'csubject
        '
        Me.csubject.FormattingEnabled = True
        Me.csubject.Location = New System.Drawing.Point(124, 12)
        Me.csubject.Name = "csubject"
        Me.csubject.Size = New System.Drawing.Size(121, 21)
        Me.csubject.TabIndex = 1
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 39)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 194)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "chart"
        '
        'lpercentage
        '
        Me.lpercentage.AutoSize = True
        Me.lpercentage.Location = New System.Drawing.Point(12, 240)
        Me.lpercentage.Name = "lpercentage"
        Me.lpercentage.Size = New System.Drawing.Size(138, 13)
        Me.lpercentage.TabIndex = 0
        Me.lpercentage.Text = "Passed Percentage : 100 %"
        '
        'FReportScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 262)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.csubject)
        Me.Controls.Add(Me.lpercentage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FReportScore"
        Me.Text = "Subject Name"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents csubject As System.Windows.Forms.ComboBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lpercentage As System.Windows.Forms.Label
End Class
