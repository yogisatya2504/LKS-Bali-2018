Public Class FEntryScore

    Private Sub FEntryScore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FInputScoreForm.Show()
    End Sub

    Private Sub FEntryScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lid.Text = FInputScoreForm.studentid & " - " & FInputScoreForm.studentname

        Dim dtidschedule As New DataTable
        dtidschedule = sqlcek("select DetailID from DetailSchedule where SubjectID = '" & FInputScoreForm.csubject.SelectedValue.ToString & "' and TeacherID = '" & FLogin.tuname.Text & "' and ScheduleID in (select ScheduleID from HeaderSchedule where ClassName in (select ClassName from DetailClass where ClassName = '" & FInputScoreForm.cclassname.SelectedValue.ToString & "' and StudentID = '" & FInputScoreForm.studentid & "'))")

        Dim dtcek As New DataTable
        dtcek = sqlcek("select * from DetailScore where DetailID = '" & dtidschedule.Rows(0).Item(0) & "' and StudentID = '" & FInputScoreForm.studentid & "'")

        If dtcek.Rows.Count > 0 Then
            tassignment.Text = dtcek.Rows(0).Item(3).ToString
            tmid.Text = dtcek.Rows(0).Item(4).ToString
            tfinal.Text = dtcek.Rows(0).Item(5).ToString
        Else
            tassignment.Text = "0"
            tmid.Text = "0"
            tfinal.Text = "0"
        End If
    End Sub

    Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click

        If tassignment.Text = "" Or tmid.Text = "" Or tfinal.Text = "" Then
            Exit Sub
        End If

        If (tassignment.Text < 0 Or tassignment.Text > 100) Or (tmid.Text < 0 Or tassignment.Text > 100) Or (tfinal.Text < 0 Or tfinal.Text > 100) Then
            MsgBox("every score between 0 and 100")

            Exit Sub
        End If

        Dim dtidschedule As New DataTable
        dtidschedule = sqlcek("select DetailID from DetailSchedule where SubjectID = '" & FInputScoreForm.csubject.SelectedValue.ToString & "' and TeacherID = '" & FLogin.tuname.Text & "' and ScheduleID in (select ScheduleID from HeaderSchedule where ClassName in (select ClassName from DetailClass where ClassName = '" & FInputScoreForm.cclassname.SelectedValue.ToString & "' and StudentID = '" & FInputScoreForm.studentid & "'))")

        Dim idscore As String = ""

        Dim dtidscore As New DataTable
        dtidscore = sqlcek("select top 1 ScoreDetailID from DetailScore order by ScoreDetailID desc")

        If dtidscore.Rows.Count = 0 Then
            idscore = "1"
        Else
            idscore = (Convert.ToInt32(dtidscore.Rows(0).Item(0)) + 1).ToString
        End If

        Dim dtcekstudent As New DataTable
        dtcekstudent = sqlcek("select * from DetailScore where StudentID = '" & FInputScoreForm.studentid & "' and DetailID = '" & dtidschedule.Rows(0).Item(0).ToString & "'")

        If dtcekstudent.Rows.Count > 0 Then
            ' update
            sqlcmd("update DetailScore set Assignment = '" & tassignment.Text & "', MidExam = '" & tmid.Text & "', FinalExam = '" & tfinal.Text & "' where ScoreDetailID = '" & dtcekstudent.Rows(0).Item(0).ToString & "'")
        Else
            ' insert
            sqlcmd("insert into DetailScore values('" & idscore & "','" & dtidschedule.Rows(0).Item(0).ToString & "','" & FInputScoreForm.studentid & "','" & tassignment.Text & "','" & tmid.Text & "','" & tfinal.Text & "')")
        End If

        MsgBox("Save success")

        Me.Close()
    End Sub

    Private Sub tassignment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tassignment.KeyPress, tmid.KeyPress, tfinal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class