Public Class FManageStudent
    Dim isinsert As Boolean

    Private Sub disbutton()
        tid.Text = ""
        tname.Text = ""
        taddress.Text = ""
        tbphone.Text = ""
        rmale.Checked = False
        rfemale.Checked = False

        tid.Enabled = False
        tname.Enabled = False
        rmale.Enabled = False
        rfemale.Enabled = False
        taddress.Enabled = False
        tbphone.Enabled = False

        bsave.Enabled = False
        bcancel.Enabled = False

        binsert.Enabled = True
        bupdate.Enabled = True
        bdelete.Enabled = True

        Dim dt As New DataTable
        dt = sqlcek("select * from Student")
        dgv.DataSource = dt
    End Sub

    Private Sub enbutton()
        tname.Enabled = True
        rmale.Enabled = True
        rfemale.Enabled = True
        taddress.Enabled = True
        tbphone.Enabled = True

        bsave.Enabled = True
        bcancel.Enabled = True

        binsert.Enabled = False
        bupdate.Enabled = False
        bdelete.Enabled = False
    End Sub

    Private Sub FManageStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FAdminNavigation.Show()
    End Sub

    Private Sub FManageStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disbutton()
    End Sub

    Private Sub tsearch_TextChanged(sender As Object, e As EventArgs) Handles tsearch.TextChanged
        Dim dt As New DataTable
        dt = sqlcek("select * from Student where StudentID like '" & tsearch.Text & "%' or Name like '" & tsearch.Text & "%' or [Address] like '" & tsearch.Text & "%' or PhoneNumber like '" & tsearch.Text & "%'")
        dgv.DataSource = dt
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim id As String = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString

        Dim dt As New DataTable
        dt = sqlcek("select * from Student where StudentID = '" & id & "'")

        tid.Text = dt.Rows(0).Item(0).ToString
        tname.Text = dt.Rows(0).Item(1).ToString
        taddress.Text = dt.Rows(0).Item(2).ToString
        Select Case dt.Rows(0).Item(3).ToString
            Case "L"
                rmale.Checked = True
            Case "P"
                rfemale.Checked = True
        End Select
        dtpdate.Value = dt.Rows(0).Item(4)
        tbphone.Text = dt.Rows(0).Item(5).ToString
    End Sub

    Private Sub binsert_Click(sender As Object, e As EventArgs) Handles binsert.Click
        isinsert = True

        enbutton()

        tname.Text = ""
        tsearch.Text = ""
        taddress.Text = ""
        tbphone.Text = ""
        rmale.Checked = False
        rfemale.Checked = False

        Dim dt As New DataTable
        dt = sqlcek("select top 1 StudentID from Student order by StudentID desc")
        Dim id() As String = Split(dt.Rows(0).Item(0).ToString, Now.Year.ToString)
        If id(0) = "" Then

        End If
        Dim idx As Integer = Convert.ToInt32(id(1)) + 1
        id(0) = idx.ToString
        id(1) = ""
        For i As Integer = id(0).Length To 3
            id(1) &= "0"
        Next
        id(1) &= id(0)
        tid.Text = Now.Year & id(1)
    End Sub

    Private Sub bupdate_Click(sender As Object, e As EventArgs) Handles bupdate.Click
        isinsert = False

        enbutton()
    End Sub

    Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
        If taddress.Text = "" Or (rmale.Checked = False And rfemale.Checked = False) Then
            MsgBox("address and gender must be filled")
            Exit Sub
        End If

        If tname.Text.Length < 3 Or tname.Text.Length > 20 Then
            MsgBox("name have between 3 and 20 character")
            Exit Sub
        End If

        If tbphone.Text.Length > 12 Or tbphone.Text.Length < 11 Or (tbphone.Text(0) <> "0" Or tbphone.Text(1) <> "8") Then
            MsgBox("Phone number must be 11 – 12 Digit and start with 08")
            Exit Sub
        End If

        If Now.AddYears(-15) < dtpdate.Value Or Now.AddYears(-21) > dtpdate.Value Then
            MsgBox("age student must be between 15 and 21 years")
            Exit Sub
        End If

        Dim gender As Char
        If rmale.Checked = True Then
            gender = "L"
        Else
            gender = "P"
        End If

        If isinsert = True Then
            Dim islower As String = tname.Text.ToLower()
            Dim isupper As String = tname.Text.ToUpper()
            Dim defpwd As String = isupper(0) & islower(islower.Length - 1) & dtpdate.Value.Year.ToString

            sqlcmd("insert into Student values('" & tid.Text & "','" & tname.Text & "','" & taddress.Text & "','" & gender & "','" & dtpdate.Value.Month & "-" & dtpdate.Value.Day & "-" & dtpdate.Value.Year & "','" & tbphone.Text & "','')")

            MsgBox("Save success")
        Else
            sqlcmd("update Student set Name = '" & tname.Text & "', [Address] = '" & taddress.Text & "', Gender = '" & gender & "', DateofBirth = '" & dtpdate.Value.Month & "-" & dtpdate.Value.Day & "-" & dtpdate.Value.Year & "', PhoneNumber = '" & tbphone.Text & "' where StudentID = '" & tid.Text & "'")

            MsgBox("Update success")
        End If

        disbutton()
    End Sub

    Private Sub bcancel_Click(sender As Object, e As EventArgs) Handles bcancel.Click
        disbutton()
    End Sub

    Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
        sqlcmd("delete from Student where StudentID = '" & tid.Text & "'")

        MsgBox("Delete success")

        disbutton()
    End Sub
End Class