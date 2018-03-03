Public Class FLogin

    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        Dim dt As New DataTable
        dt = sqlcek("select [Role] from [User] where Username = '" & tuname.Text & "' and [Password] = '" & tpwd.Text & "'")

        If dt.Rows.Count > 0 Then
            Me.Hide()
            Select Case dt.Rows(0).Item(0).ToString
                Case "1"
                    ' Student
                    FStudentNavigation.Show()
                Case "2"
                    ' Teacher
                    FTeacherNavigation.Show()
                Case "3"
                    ' Admin
                    FAdminNavigation.Show()
                Case Else
                    MsgBox("Something went wrong!")
            End Select
        Else
            MsgBox("Username or password wrong!")
        End If
    End Sub
End Class
