Public Class FChangePassword

    Function validpwd(pwd As String, Optional minlen As Integer = 6, Optional maxlen As Integer = 9)
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Check the length.
        If Len(pwd) < minlen Then Return False
        If Len(pwd) > maxlen Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count = 0 Then Return False
        If lower.Matches(pwd).Count = 0 Then Return False
        If number.Matches(pwd).Count = 0 Then Return False

        Return True
    End Function

    Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
        Dim dt As New DataTable
        dt = sqlcek("select [Role] from [User] where Username = '" & FLogin.tuname.Text & "' and [Password] = '" & told.Text & "'")

        If dt.Rows.Count = 0 Then
            MsgBox("Old password is wrong")
            Exit Sub
        End If

        If validpwd(tnew.Text) = False Then
            MsgBox("Password must contains upper case,lower case, number with total 6-9 character")
            Exit Sub
        End If

        If tnew.Text <> tconfirm.Text Then
            MsgBox("Confirm error")
            Exit Sub
        End If

        sqlcmd("update [User] set [Password] = '" & tnew.Text & "' where Username = '" & FLogin.tuname.Text & "'")
        MsgBox("Sucess update password")

        Me.Close()
    End Sub
End Class