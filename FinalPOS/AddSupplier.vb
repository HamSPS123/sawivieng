Public Class AddSupplier
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




            Dim sql As String = "INSERT INTO supplier SET sup_name=@name,sup_company=@company,sup_contact=@tel,sup_email=@email,sup_address=@address"
            Dim val() As Object = {txtName.Text, txtCompany.Text, txtTel.Text, txtEmail.Text, txtAddress.Text}
            Dim pr() As String = {"@name", "@company", "@tel", "@email", "@address"}
            InsertData(sql, pr, val)
            Supplier.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class