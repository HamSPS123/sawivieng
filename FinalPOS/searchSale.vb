Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class searchSale
    Private Sub searchSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("", "")

        Dim strh() As String = {"ລະຫັດ", "ວັນທີຂາຍ", "ພະນັກງານ", "ລູກຄ້າ", "ຈຳນວນທີ່ຈ່າຍ", "ສ່ວນຫຼຸດ"}
        setHeaderText(dgvshow, strh)
    End Sub


    Private Sub showData(fdate As String, tdate As String)
        Dim dt As New DataTable
        Dim sql As String

        Dim sqlBase = "SELECT sale_id,DATE_FORMAT(sale_date,'%d/%m/%Y'),emp_name,cus_name,sale_pay,sale_discount FROM sale s left JOIN employee e ON s.emp_id=e.emp_id left JOIN customer c ON s.cus_id=c.cus_id"

        If fdate = "" And tdate = "" Then
            sql = sqlBase

        Else
            sql = sqlBase + " WHERE sale_date BETWEEN '" + fdate + "' AND '" + tdate + "'"
        End If

        dt = loadingData(sql)


        dgvshow.DataSource = dt

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        showData(txtFdate.Text, txtTdate.Text)
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index

        Dim sale_id = dgvshow.Item(0, cindex).Value.ToString

        'Dim rpt As New ReportDocument
        Dim report As New rptBill
        'rpt.Load(report)
        report.SetParameterValue("sale_id", sale_id)

        frmBill.crvshow.ReportSource = report
        frmBill.crvshow.Refresh()
        frmBill.Show()

    End Sub
End Class