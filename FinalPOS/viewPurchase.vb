Public Class viewPurchase

    Dim dt As New DataTable
    Dim fdate As String
    Dim tdate As String
    Private Sub viewPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("", "")

        Dim strh() As String = {"ລະຫັດ", "ວັນທີສັ່ງຊື້", "ຊື່ພະນັກງານ", "ຊື່ຜູ້ສະໜອງ", "ຊື່ບໍລິສັດ ຫຼື ຮ້ານຄ້າ", "ຈຳນວນ", "ລາຄາ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(fdate As String, tdate As String)
        Dim sql As String

        If fdate = "" And tdate = "" Then
            sql = "SELECT pch_id,pch_date,emp_name,sup_name,sup_company,pd_qty,total FROM viewPurchase WHERE pch_date BETWEEN NOW() - INTERVAL 30 DAY AND NOW() ORDER by pch_id DESC"
        Else
            sql = "SELECT pch_id,pch_date,emp_name,sup_name,sup_company,pd_qty,total FROM viewPurchase WHERE pch_date BETWEEN '" + fdate + "' AND '" + tdate + "' ORDER by pch_id DESC"
        End If

        dt = loadingData(sql)

        dgvshow.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        fdate = txtfdate.Text
        tdate = txttdate.Text

        showData(fdate, tdate)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        fdate = ""
        tdate = ""
        showData("", "")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim report As New rptcPurchase

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