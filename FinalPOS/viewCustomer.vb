Public Class viewCustomer

    Dim dt As New DataTable
    Private Sub viewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        showData("")
        Dim strh() As String = {"ລະຫັດ", "ຊື່ ແລະ ນາມສະກຸນ", "ເພດ", "ວັນເດືອນປີເກີດ", "ທີ່ຢູ່", "ເບີໂທ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(search As String)
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM customer"
        Else
            sql = "SELECT * FROM customer WHERE concat(cus_id,cus_name,cus_gender) LIKE '%" + search + "%'"
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
        Dim report As New rptCustomer
        report.SetDataSource(dt)

        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()

    End Sub
End Class