Public Class FEditProfile
    Dim status As String

    Friend Sub loadprofile(str As String, statusx As String)
        Dim dt As New DataTable
        dt = sqlcek(str)

        tid.Text = dt.Rows(0).Item(0).ToString
        tname.Text = dt.Rows(0).Item(1).ToString
        tbphone.Text = dt.Rows(0).Item(2).ToString
        taddress.Text = dt.Rows(0).Item(3).ToString

        If dt.Rows(0).Item(4).ToString = "" Then
            pb.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\UserImage\Default.jpg")
        Else
            pb.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\UserImage\" & dt.Rows(0).Item(4).ToString)
        End If
        pb.Tag = "False"

        status = statusx
    End Sub

    Private Sub bcancel_Click(sender As Object, e As EventArgs) Handles bcancel.Click
        Me.Close()
    End Sub

    Private Sub bup_Click(sender As Object, e As EventArgs) Handles bup.Click
        Dim op As New OpenFileDialog
        op.Filter = "Image File (.*jpg or .*png)|*.jpg;*.png"
        op.Title = "Search Image"

        If op.ShowDialog = Windows.Forms.DialogResult.OK Then
            pb.Image = Image.FromFile(op.FileName.ToString)
            pb.Tag = op.FileName.ToString
        End If
    End Sub

    Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
        If taddress.Text = "" Then
            MsgBox("Address must be filled")
            Exit Sub
        End If

        If tname.Text.Length < 3 Or tname.Text.Length > 20 Then
            MsgBox("Name have between 3 and 20 character")
            Exit Sub
        End If

        If tbphone.Text.Length > 12 Or tbphone.Text.Length < 11 Or (tbphone.Text(0) <> "0" Or tbphone.Text(1) <> "8") Then
            MsgBox("Phone number must be 11 – 12 Digit and start with 08")
            Exit Sub
        End If

        Dim photo As String
        If pb.Tag = "False" Then
            sqlcmd("update " & status & " set Name = '" & tname.Text & "', PhoneNumber = '" & tbphone.Text & "', [Address] = '" & taddress.Text & "' where " & status & "ID = '" & FLogin.tuname.Text & "'")
        Else
            photo = Now.ToString("ddMMyyHHmmss") & IO.Path.GetExtension(pb.Tag)
            FileCopy(pb.Tag, IO.Directory.GetCurrentDirectory & "\UserImage\" & photo)

            sqlcmd("update " & status & " set Name = '" & tname.Text & "', PhoneNumber = '" & tbphone.Text & "', [Address] = '" & taddress.Text & "', Photo = '" & photo & "' where " & status & "ID = '" & FLogin.tuname.Text & "'")
        End If

        MsgBox("Data has been updated")
    End Sub

    Private Sub bchangepwd_Click(sender As Object, e As EventArgs) Handles bchangepwd.Click
        FChangePassword.Show()
    End Sub

    Private Sub FEditProfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FChangePassword.Close()
    End Sub
End Class