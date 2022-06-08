Public Class viewExpense

    Dim dt As New DataTable
    Dim keyval As String
    Private Sub viewExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub showData(keyval As String)
        Dim sql As String

        If keyval <> "" Then
            If keyval = "ລາຍງານປະຈຳວັນ" Then
                sql = "SELECT * FROM viewExpense"
            ElseIf keyval = "ລາຍງານປະຈຳເດືອນ" Then
                sql = "SELECT * FROM viewExpenseMonth"
            Else
                sql = "SELECT * FROM viewExpenseYear"
            End If

            dt = loadingData(sql)
            dgvshow.DataSource = dt
            Dim strh() As String = {"ວັນທີ", "ຈຳນວນ", "ຍອດນຳເຂົ້າ"}
            setHeaderText(dgvshow, strh)
        Else
            MessageBox.Show("ກະລຸນາເລືອກປະເພດທີ່ຕ້ອງການເບິ່ງ!!!!", "ເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        keyval = cbSelect.SelectedItem
        showData(keyval)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If keyval <> "" Then
            If keyval = "ລາຍງານປະຈຳວັນ" Then
                Dim report As New rptExpense
                loadReport(report)
            ElseIf keyval = "ລາຍງານປະຈຳເດືອນ" Then
                Dim report As New rptExpenseMonth
                loadReport(report)
            Else
                Dim report As New rptExpenseYear
                loadReport(report)
            End If


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
End Class