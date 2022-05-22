Public Class searchSale
    Private Sub searchSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("", "")

        Dim strh() As String = {"ລະຫັດ", "ວັນທີຂາຍ", "ພະນັກງານ", "ລູກຄ້າ", "ຈຳນວນທີ່ຈ່າຍ", "ສ່ວນຫຼຸດ"}
        setHeaderText(dgvshow, strh)
    End Sub


    Private Sub showData(fdate As String, tdate As String)
        Dim dt As New DataTable
        Dim sql As String

        Dim sqlBase = "SELECT sale_id,DATE_FORMAT(sale_date,'%m/%d/%Y'),emp_name,cus_name,sale_pay,sale_discount FROM sale s left JOIN employee e ON s.emp_id=e.emp_id left JOIN customer c ON s.cus_id=c.cus_id"

        'If search = "" Then
        '    sql = sqlBase
        'Else
        '    sql = sqlBase + "WHERE cusname LIKE '%" + search + "%'"
        'End If
        If fdate = "" And tdate = "" Then
            sql = sqlBase
        Else
            sql = sqlBase + "WHERE sale_date BETWEEN '" + fdate + "' AND '" + tdate + "';"
        End If


        dt = loadingData(sql)
        dgvshow.DataSource = dt

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        showData(txtFdate.Value, txtTdate.Value)
    End Sub
End Class