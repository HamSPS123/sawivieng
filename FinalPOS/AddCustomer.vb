Public Class AddCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dashboard.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ ແລະ ນາມສະກຸນ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtGender.SelectedItem = "" Then
            MessageBox.Show("ກະລຸນາເລືອກເພດ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນທີ່ຢູ່", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtTel.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນເບີໂທ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else




            Dim sql As String = "INSERT INTO customer SET cus_name=@name,cus_dob=@date,cus_gender=@gender,cus_address=@address,cus_tel=@tel"
            Dim val() As Object = {txtName.Text, txtDate.Value, txtGender.SelectedItem, txtAddress.Text, txtTel.Text}
            Dim pr() As String = {"@name", "@date", "@gender", "@address", "@tel"}
            InsertData(sql, pr, val)
            Customer.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class