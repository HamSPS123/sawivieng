Public Class viewSupplier
    Dim dt As New DataTable
    Private Sub viewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("")

        Dim strh() As String = {"ລະຫັດ", "ຊື່ຜູ້ສະໜອງ", "ບໍລິສັດ", "ເບີໂທຕິດຕໍ່", "ອີເມວ", "ທີ່ຢູ່"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(search As String)
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM supplier"
        Else
            sql = "SELECT * FROM supplier WHERE concat(sup_name,sup_company,sup_contact) LIKE '%" + search + "%'"
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
        Dim report As New rptSupplier
        report.SetDataSource(dt)

        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()
    End Sub
End Class