Public Class Unit
    Private Sub Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnEdit As New DataGridViewButtonColumn()
        AddButtonToGrid(btnEdit, dgvshow, "ແກ້ໄຂ", "btnEdit", "ແກ້ໄຂ")

        Dim btnDel As New DataGridViewButtonColumn()
        AddButtonToGrid(btnDel, dgvshow, "ລົບ", "btnDel", "ລົບ")


        showData("")

        Dim strh() As String = {"", "", "ລະຫັດ", "ຊື່ຫົວໜ່ວຍຢາ"}
        setHeaderText(dgvshow, strh)

        btnAction(True)
    End Sub

    Sub btnAction(isAction As Boolean)
        If isAction = True Then
            btnAdd.Visible = True
            btnEdit.Visible = False
        Else
            btnAdd.Visible = False
            btnEdit.Visible = True
        End If
    End Sub

    Private Sub showData(search As String)
        Dim dt As New DataTable
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM unit"
        Else
            sql = "SELECT * FROM unit WHERE unit_name LIKE '%" + search + "%'"
        End If


        dt = loadingData(sql)
        dgvshow.DataSource = dt

        txtName.Clear()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ຫົວໜ່ວຍ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sql As String = "INSERT INTO unit SET unit_name=@name"
            Dim val() As Object = {txtName.Text}
            Dim pr() As String = {"@name"}
            InsertData(sql, pr, val)
            showData("")
        End If
    End Sub
    Dim eId As String

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ຫົວໜ່ວຍ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf eId = "" Then
            MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນທີ່ຕ້ອງການແກ້ໄຂ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim sql As String = "UPDATE unit SET unit_name=@name WHERE unit_id='" + eId + "'"
            Dim val() As Object = {txtName.Text}
            Dim pr() As String = {"@name"}
            UpdateData(sql, pr, val)
            showData("")

            btnAction(True)
        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Dim search As String

        search = txtSearch.Text

        showData(search)
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick
        If e.ColumnIndex = 0 Then

            Dim cindex As Integer = dgvshow.CurrentRow.Index

            eId = dgvshow.Item(2, cindex).Value.ToString
            txtName.Text = dgvshow.Item(3, cindex).Value.ToString

            btnAction(False)
            'MessageBox.Show("Do you want to edit id " + eid)
        End If

        If e.ColumnIndex = 1 Then
            Dim cindex As Integer = dgvshow.CurrentRow.Index

            Dim did = dgvshow.Item(2, cindex).Value.ToString

            DeleteData("unit", "unit_id", did)

            showData("")
        End If
    End Sub
End Class