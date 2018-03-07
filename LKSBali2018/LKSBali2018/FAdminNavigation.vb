Public Class FAdminNavigation

    Private Sub FAdminNavigation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FLogin.tuname.Text = ""
        FLogin.tpwd.Text = ""
        FLogin.Show()
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        If MsgBox("Logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        FManageStudent.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FReportScore.Show()
        Me.Hide()
    End Sub
End Class