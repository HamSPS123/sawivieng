Public Class Employee
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim btnEdit As New DataGridViewButtonColumn()
        AddButtonToGrid(btnEdit, dgvshow, "ແກ້ໄຂ", "btnEdit", "ແກ້ໄຂ")

        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")

        showData("")

        Dim strh() As String = {"", "", "ລະຫັດ", "ຊື່ ແລະ ນາມສະກຸນ", "ວັນເດືອນປີເກີດ", "ເພດ", "ທີ່ຢູ່", "ເບີໂທ", "Username", "Password"}
        setHeaderText(dgvshow, strh)
    End Sub

    Public Sub showData(search As String)
        Dim dt As New DataTable
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM employee"
        Else
            sql = "SELECT * FROM employee WHERE concat(emp_name,emp_username) LIKE '%" + search + "%'"
        End If


        dt = loadingData(sql)
        dgvshow.DataSource = dt




    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dashboard.Enabled = False
        AddEmployee.Show()
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick
        If e.ColumnIndex = 0 Then

            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim eid = dgvshow.Item(2, cindex).Value.ToString

            Dim editForm As New EditEmployee

            editForm.eID = eid

            editForm.Show()
            Dashboard.Enabled = False
            'MessageBox.Show("Do you want to edit id " + eid)
        End If

        If e.ColumnIndex = 1 Then
            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim did = dgvshow.Item(2, cindex).Value.ToString

            DeleteData("employee", "emp_id", did)

            showData("")
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        showData(txtSearch.Text)
    End Sub
End Class