Public Class Medicine
    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnEdit As New DataGridViewButtonColumn()
        AddButtonToGrid(btnEdit, dgvshow, "ແກ້ໄຂ", "btnEdit", "ແກ້ໄຂ")

        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")

        showData("")

        Dim strh() As String = {"", "", "ລະຫັດ", "ຊື່ຢາ", "ປະເພດຢາ", "ສະຕ໋ອກ", "ຫົວໜ່ວຍ", "ວັນໝົດອາຍຸ", "ລາຄາ", "ລາຍລະອຽດ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Public Sub showData(search As String)
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

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick
        If e.ColumnIndex = 0 Then

            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim eid = dgvshow.Item(2, cindex).Value.ToString

            Dim editForm As New EditMedicine

            editForm.eID = eid

            editForm.Show()
            Dashboard.Enabled = False
            'MessageBox.Show("Do you want to edit id " + eid)
        End If

        If e.ColumnIndex = 1 Then
            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim did = dgvshow.Item(2, cindex).Value.ToString

            DeleteData("medicine", "mdc_id", did)

            showData("")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMedicine.Show()
        Dashboard.Enabled = False
    End Sub
End Class