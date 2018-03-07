Public Class FViewScore

    Private Sub FViewScore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FStudentNavigation.Show()
    End Sub

    Private Sub FViewScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtdgv As New DataTable
        dtdgv = sqlcek("select DetailSchedule.SubjectID, [Subject].Name, DetailScore.Assignment, DetailScore.MidExam, DetailScore.FinalExam from DetailScore inner join DetailSchedule on DetailSchedule.DetailID = DetailScore.DetailID inner join [Subject] on [Subject].SubjectID = DetailSchedule.SubjectID where DetailScore.StudentID = '" & FLogin.tuname.Text & "'")

        dtdgv.Columns.Add("Final")

        For i As Integer = 0 To dtdgv.Rows.Count - 1
            dtdgv.Rows(i).Item("Final") = (20 / 100 * dtdgv.Rows(i).Item("Assignment")) + (30 / 100 * dtdgv.Rows(i).Item("MidExam")) + (50 / 100 * dtdgv.Rows(i).Item("FinalExam"))
        Next

        dgv.DataSource = dtdgv
    End Sub
End Class