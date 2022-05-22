Public Class EditSupplier
    Public Property eID As String
    Private Sub EditSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        dt = loadingData("SELECT * FROM supplier WHERE sup_id = '" + eID + "'")

        If dt.Rows.Count <> 0 Then
            txtName.Text = dt.Rows(0)(1)
            txtCompany.Text = dt.Rows(0)(2)
            txtTel.Text = dt.Rows(0)(3)
            txtEmail.Text = dt.Rows(0)(4)
            txtAddress.Text = dt.Rows(0)(5)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dashboard.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ຜູ້ສະໜອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtCompany.Text = "" Then
            MessageBox.Show("ກະລຸນາເລືອກເພດ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນທີ່ຢູ່", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtTel.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນເບີໂທ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນອີເມວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else




            Dim sql As String = "UPDATE supplier SET sup_name=@name,sup_company=@company,sup_contact=@tel,sup_email=@email,sup_address=@address WHERE sup_id='" + eID + "'"
            Dim val() As Object = {txtName.Text, txtCompany.Text, txtTel.Text, txtEmail.Text, txtAddress.Text}
            Dim pr() As String = {"@name", "@company", "@tel", "@email", "@address"}
            UpdateData(sql, pr, val)
            Supplier.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class