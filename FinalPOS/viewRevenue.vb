Public Class viewRevenue

    Dim dt As New DataTable
    Dim selectType As String
    Private Sub viewRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        selectType = cbSelect.SelectedItem
        showData(selectType)
    End Sub

    Private Sub showData(keyval As String)
        Dim sql As String

        If keyval <> "" Then
            If keyval = "ລາຍງານປະຈຳວັນ" Then
                sql = "SELECT * FROM viewRevenue"
            ElseIf keyval = "ລາຍງານປະຈຳເດືອນ" Then
                sql = "SELECT sale_date,sd_qty,sd_price FROM viewRevenueMonth"
            Else
                sql = "SELECT sale_date,sd_qty,sd_price FROM viewRevenueYear"
            End If

            dt = loadingData(sql)
            dgvshow.DataSource = dt
            Dim strh() As String = {"ວັນທີ", "ຈຳນວນ", "ຍອດຂາຍ"}
            setHeaderText(dgvshow, strh)
        Else
            MessageBox.Show("ກະລຸນາເລືອກປະເພດທີ່ຕ້ອງການເບິ່ງ!!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub loadReport(report As Object)
        report.SetDataSource(dt)
        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If selectType <> "" Then
            If selectType = "ລາຍງານປະຈຳວັນ" Then
                Dim report As New rptRevenue
                loadReport(report)
            ElseIf selectType = "ລາຍງານປະຈຳເດືອນ" Then
                Dim report As New rptRevenueMonth
                loadReport(report)
            Else
                Dim report As New rptRevenueYear
                loadReport(report)
            End If


        Else
            MessageBox.Show("ກະລຸນາເລືອກປະເພດທີ່ຕ້ອງການເບິ່ງ!!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class