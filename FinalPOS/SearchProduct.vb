Public Class SearchProduct

    Public Property check As String
    Private Sub SearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("")

        Dim strh() As String = {"ລະຫັດ", "ຊື່ຢາ", "ປະເພດຢາ", "ສະຕ໋ອກ", "ຫົວໜ່ວຍ", "ວັນໝົດອາຍຸ", "ລາຄາ", "ລາຍລະອຽດ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(search As String)
        Dim dt As New DataTable
        Dim sql As String

        If search = "" Then
            sql = "SELECT mdc_id,mdc_name,type_name,mdc_stock,unit_name,expired_date,mdc_price,mdc_detail FROM medicine m left join type t ON m.type_id=t.type_id left JOIN unit u ON m.unit_id=u.unit_id;"
        Else
            sql = "SELECT mdc_id,mdc_name,type_name,mdc_stock,unit_name,expired_date,mdc_price,mdc_detail FROM medicine m left join type t ON m.type_id=t.type_id left JOIN unit u ON m.unit_id=u.unit_id WHERE concat(mdc_name,type_name,unit_name) LIKE '%" + search + "%'"
        End If


        dt = loadingData(sql)
        dgvshow.DataSource = dt

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Dim search As String

        search = txtSearch.Text

        showData(search)
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index

        txtProID.Text = dgvshow.Item(0, cindex).Value.ToString
        'txtQty.Value = dgvshow.Item(3, cindex).Value

        txtProID.Enabled = True
        txtQty.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If check = "Sale" Then
            Sale.addCart(txtProID.Text, txtQty.Value)
        Else
            frmPurchase.addCart(txtProID.Text, txtQty.Value)
        End If
        Me.Close()
    End Sub
End Class