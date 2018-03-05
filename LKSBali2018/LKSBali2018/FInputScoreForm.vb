Public Class FInputScoreForm

    Private Sub fload()
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
    End Sub

    Private Sub FInputScoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FTeacherNavigation.Show()
    End Sub

    Private Sub FInputScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fload()
    End Sub
End Class