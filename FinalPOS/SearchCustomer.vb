Public Class SearchCustomer
    Private Sub SearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData("")

        Dim strh() As String = {"ລະຫັດ", "ຊື່ ແລະ ນາມສະກຸນ", "ເພດ", "ວັນເດືອນປີເກີດ", "ທີ່ຢູ່", "ເບີໂທ"}
        setHeaderText(dgvshow, strh)
    End Sub

    Private Sub showData(search As String)
        Dim dt As New DataTable
        Dim sql As String

        If search = "" Then
            sql = "SELECT * FROM customer"
        Else
            sql = "SELECT * FROM customer WHERE cusname LIKE '%" + search + "%'"
        End If

        dt = loadingData(sql)
        dgvshow.DataSource = dt

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim search As String
        search = txtSearch.Text
        showData(search)
    End Sub

    Private Sub dgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseClick
        Dim cindex As Integer = dgvshow.CurrentRow.Index

        Dim cusID As String = dgvshow.Item(0, cindex).Value.ToString

        Sale.txtCusID.Text = cusID

        Sale.addCus(cusID)
        Me.Close()
    End Sub
End Class