Public Class viewEmployee

    Dim dt As New DataTable
    Private Sub viewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("")

        Dim strh() As String = {"ລະຫັດ", "ຊື່ ແລະ ນາມສະກຸນ", "ວັນເດືອນປີເກີດ", "ເພດ", "ທີ່ຢູ່", "ເບີໂທ", "Username", "Password", "stt"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(search As String)

        Dim sql As String
        If search = "" Then
            sql = "SELECT * FROM employee"
        Else
            sql = "SELECT * FROM employee WHERE CONCAT(emp_id,emp_name,emp_gender,emp_username) LIKE '%" + search + "%'"
        End If
        dt = loadingData(sql)

        dgvshow.DataSource = dt
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Dim search As String

        search = txtSearch.Text
        showData(search)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim report As New rptEmployees

        report.SetDataSource(dt)
        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()
    End Sub
End Class