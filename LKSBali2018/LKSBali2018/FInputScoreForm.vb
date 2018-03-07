Public Class FInputScoreForm
    Dim isload As Boolean
    Friend studentid As String = ""
    Friend studentname As String = ""

    Private Sub dgvload()
        If isload = False Then
            Dim dtdgv As New DataTable
            dtdgv = sqlcek("select Student.StudentID, Student.Name, [Subject].Assignment, [Subject].MidExam, [Subject].FinalExam from Student inner join [Subject] on [Subject].SubjectID = '" & csubject.SelectedValue.ToString & "' where Student.StudentID in (select StudentID from DetailClass where ClassName in (select ClassName from HeaderSchedule where ScheduleID in (select ScheduleID from DetailSchedule where SubjectID = '" & csubject.SelectedValue.ToString & "' and TeacherID = '" & FLogin.tuname.Text & "') and Finalize = '1') and ClassName = '" & cclassname.SelectedValue.ToString & "')")

            dtdgv.Columns.Add("Final")

            For i As Integer = 0 To dtdgv.Rows.Count - 1
                dtdgv.Rows(i).Item("Final") = (20 / 100 * dtdgv.Rows(i).Item("Assignment")) + (30 / 100 * dtdgv.Rows(i).Item("MidExam")) + (50 / 100 * dtdgv.Rows(i).Item("FinalExam"))
            Next

            dgv.DataSource = dtdgv
        End If
    End Sub

    Private Sub fload()
        isload = True

        ' untuk subject
        Dim dts As New DataTable
        dts = sqlcek("select SubjectID, Name from [Subject] where SubjectID in (select SubjectID from DetailSchedule where ScheduleID in (select ScheduleID from HeaderSchedule where Finalize = '1') and TeacherID = '" & FLogin.tuname.Text & "')")

        Dim dtsx As New DataTable
        dtsx.Columns.Add("id")
        dtsx.Columns.Add("name")

        For i As Integer = 0 To dts.Rows.Count - 1
            dtsx.Rows.Add(dts.Rows(i).Item(0).ToString, dts.Rows(i).Item(0).ToString & " - " & dts.Rows(i).Item(1).ToString)
        Next

        csubject.DisplayMember = "name"
        csubject.ValueMember = "id"
        csubject.DataSource = dtsx

        ' untuk class name
        Dim dtc As New DataTable
        dtc = sqlcek("select ClassName from Class where ClassName in (select ClassName from HeaderSchedule where ScheduleID in (select ScheduleID from DetailSchedule where TeacherID = '" & FLogin.tuname.Text & "') and Finalize = '1')")

        cclassname.DisplayMember = "ClassName"
        cclassname.ValueMember = "ClassName"
        cclassname.DataSource = dtc

        isload = False

        dgvload()
    End Sub

    Private Sub FInputScoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FTeacherNavigation.Show()
    End Sub

    Private Sub FInputScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fload()
        bentryscore.Enabled = False
    End Sub

    Private Sub csubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles csubject.SelectedIndexChanged
        dgvload()
    End Sub

    Private Sub cclassname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cclassname.SelectedIndexChanged
        dgvload()
    End Sub

    Private Sub bentryscore_Click(sender As Object, e As EventArgs) Handles bentryscore.Click
        FEntryScore.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        studentid = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString
        studentname = dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value.ToString
        

        MsgBox(dgv.Rows(dgv.CurrentRow.Index).Cells(1).Value.ToString)

        bentryscore.Enabled = True
    End Sub
End Class