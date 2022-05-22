Public Class Supplier
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnEdit As New DataGridViewButtonColumn()
        AddButtonToGrid(btnEdit, dgvshow, "ແກ້ໄຂ", "btnEdit", "ແກ້ໄຂ")

        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")


        showData("")

        Dim strh() As String = {"", "", "ລະຫັດ", "ຊື່ຜູ້ສະໜອງ", "ບໍລິສັດ", "ເບີໂທຕິດຕໍ່", "ອີເມວ", "ທີ່ຢູ່"}
        setHeaderText(dgvshow, strh)
    End Sub

    Public Sub showData(search As String)
        Dim dt As New DataTable
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM supplier"
        Else
            sql = "SELECT * FROM supplier WHERE concat(sup_name,sup_company) LIKE '%" + search + "%'"
        End If


        dt = loadingData(sql)
        dgvshow.DataSource = dt

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSupplier.Show()
        Dashboard.Enabled = False
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

            Dim editForm As New EditSupplier

            editForm.eID = eid

            editForm.Show()
            Dashboard.Enabled = False
            'MessageBox.Show("Do you want to edit id " + eid)
        End If

        If e.ColumnIndex = 1 Then
            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim did = dgvshow.Item(2, cindex).Value.ToString

            DeleteData("supplier", "sup_id", did)

            showData("")
        End If
    End Sub
End Class