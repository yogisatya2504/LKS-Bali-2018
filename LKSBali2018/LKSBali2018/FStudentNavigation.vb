Public Class FStudentNavigation

    Private Sub FStudentNavigation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FLogin.tuname.Text = ""
        FLogin.tpwd.Text = ""
        FLogin.Show()
        FEditProfile.Close()
    End Sub

    Private Sub FStudentNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = sqlcek("select Name from Student where StudentID = '" & FLogin.tuname.Text & "'")
        lwelcome.Text = "Welcome, " & dt.Rows(0).Item(0).ToString
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        If MsgBox("Logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        FEditProfile.Show()
        FEditProfile.loadprofile("select StudentID, Name, PhoneNumber, [Address], Photo from Student where StudentID = '" & FLogin.tuname.Text & "'", "Student")
    End Sub

    Private Sub bschedule_Click(sender As Object, e As EventArgs) Handles bschedule.Click
        FViewShcedule.Show()
        Me.Hide()
    End Sub
End Class