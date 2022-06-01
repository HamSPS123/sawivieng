Public Class viewMedicine
    Dim dt As New DataTable
    Dim type As String
    Private Sub viewMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBindingData(cmbSelect, "type", "type_name", "type_id")

        showData("")

        Dim strh() As String = {"ລະຫັດ", "ຊື່ຢາ", "ປະເພດຢາ", "ສະຕ໋ອກ", "ຫົວໜ່ວຍ", "ວັນໝົດອາຍຸ", "ລາຄາ", "ລາຍລະອຽດ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(type As String)
        Dim sql As String

        If type = "" Then
            sql = "SELECT mdc_id,mdc_name,type_id,mdc_stock,unit_id,expired_date,mdc_price,mdc_detail FROM medicine;"
        Else
            sql = "SELECT mdc_id,mdc_name,type_id,mdc_stock,unit_id,expired_date,mdc_price,mdc_detail FROM medicine WHERE type_id='" + type + "';"
        End If

        dt = loadingData(sql)

        dgvshow.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        type = cmbSelect.SelectedValue

        showData(type)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        type = ""

        showData("")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim report As New rptMedicine
        report.SetDataSource(dt)

        frmViewReport.crvShow.ReportSource = report
        frmViewReport.Refresh()
        frmViewReport.Show()
    End Sub
End Class