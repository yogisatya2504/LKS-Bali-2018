Imports System.Data.SqlClient

Module ModulDB
    Dim str As String = "Data Source=YOGI-PC\SQLEXPRESS;Initial Catalog=LKS2018;Integrated Security=True"
    'Public conn As New SqlConnection(str)

    Public Function sqlcek(qstr As String)
        Dim dt As New DataTable

        Try
            Using conn As New SqlConnection(str)
                conn.Open()
                Dim dtad As New SqlDataAdapter(qstr, conn)
                dtad.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong - Modulsqlcek")
        End Try

        Return dt
    End Function

    Public Sub sqlcmd(qstr As String)
        Try
            Using conn As New SqlConnection(str)
                conn.Open()
                Dim cmd As New SqlCommand(qstr, conn)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong - Modulsqlcmd")
        End Try
    End Sub
End Module
