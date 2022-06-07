Public Class viewSale
    Dim dt As New DataTable
    Dim fdate As String
    Dim tdate As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        fdate = txtfdate.Text
        tdate = txttdate.Text

        showData(fdate, tdate)
    End Sub

    Private Sub viewSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("", "")

        Dim strh() As String = {"ລະຫັດ", "ວັນທີຂາຍ", "ຈຳນວນທີ່ຈ່າຍ", "ລະຫັດພະນັກງານ", "ລະຫັດລູກຄ້າ", "ສ່ວນລົດ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(fdate As String, tdate As String)
        Dim sql As String

        If fdate = "" And tdate = "" Then
            sql = "SELECT sale_id,date_format(sale_date,'%y-%m-%d') as sale_date,sale_pay,emp_id,cus_id,sale_discount FROM sale WHERE sale_date BETWEEN NOW() - INTERVAL 30 DAY AND NOW() ORDER by sale_date DESC;"
        Else
            sql = "SELECT sale_id,date_format(sale_date,'%y-%m-%d') as sale_date,sale_pay,emp_id,cus_id,sale_discount FROM sale WHERE sale_date BETWEEN '" + fdate + "' AND '" + tdate + "' ORDER by sale_date DESC;"
        End If

        dt = loadingData(sql)

        dgvshow.DataSource = dt
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        fdate = ""
        tdate = ""
        showData(fdate, tdate)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim report As New rptSale

        If fdate = "" And tdate = "" Then
            Dim today = Date.Now
            Dim lastday = today.AddDays(-30)

            fdate = lastday
            tdate = today
        End If


        report.SetDataSource(dt)
        report.SetParameterValue(0, fdate)
        report.SetParameterValue(1, tdate)
        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()
    End Sub
End Class