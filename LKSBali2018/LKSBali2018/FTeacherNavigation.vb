Public Class FTeacherNavigation

    Private Sub FTeacherNavigation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FLogin.tuname.Text = ""
        FLogin.tpwd.Text = ""
        FLogin.Show()
        FEditProfile.Close()
    End Sub

    Private Sub FTeacherNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = sqlcek("select Name from Teacher where TeacherID = '" & FLogin.tuname.Text & "'")
        lwelcome.Text = "Welcome, " & dt.Rows(0).Item(0).ToString
    End Sub

    Private Sub blogout_Click(sender As Object, e As EventArgs) Handles blogout.Click
        If MsgBox("Logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub bedit_Click(sender As Object, e As EventArgs) Handles bedit.Click
        FEditProfile.Show()
        FEditProfile.loadprofile("select TeacherID, Name, PhoneNumber, [Address], Photo from Teacher where TeacherID = '" & FLogin.tuname.Text & "'", "Teacher")
    End Sub
End Class