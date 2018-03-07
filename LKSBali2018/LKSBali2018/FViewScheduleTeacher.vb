Public Class FViewScheduleTeacher

    Private Sub FViewScheduleTeacher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FTeacherNavigation.Show()
    End Sub

    Private Sub FViewScheduleTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Untuk schedule
        Dim dt1 As New DataTable
        dt1 = sqlcek("select [Subject].SubjectID, [Subject].Name, HeaderSchedule.ClassName, DetailSchedule.[Day], [Shift].[Time] from [Subject] inner join DetailSchedule on DetailSchedule.SubjectID = [Subject].SubjectID inner join HeaderSchedule on HeaderSchedule.ScheduleID = DetailSchedule.ScheduleID inner join [Shift] on [Shift].ShiftID = DetailSchedule.ShiftID where DetailSchedule.TeacherID = '" & FLogin.tuname.Text & "' and HeaderSchedule.Finalize = '1'")

        dgvschedule.DataSource = dt1

        
    End Sub

    Private Sub dgvschedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvschedule.CellContentClick
        Dim id As String = dgvschedule.Rows(dgvschedule.CurrentRow.Index).Cells(0).Value.ToString

        ' Untuk student list
        Dim dt2 As New DataTable
        dt2 = sqlcek("select * from Student where StudentID in (select StudentID from DetailClass where ClassName in (select ClassName from HeaderSchedule where ScheduleID in (select ScheduleID from DetailSchedule where TeacherID = '" & FLogin.tuname.Text & "' and SubjectID = '" & id & "') and Finalize = '1'))")

        dgvstudentlist.DataSource = dt2
    End Sub
End Class