Public Class AddEmployee
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
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນ Username", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນ Password", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else




            Dim sql As String = "INSERT INTO employee SET emp_name=@name,emp_dob=@date,emp_gender=@gender,emp_address=@address,emp_tel=@tel,emp_username=@username,emp_password=@password"
            Dim val() As Object = {txtName.Text, txtDate.Value, txtGender.SelectedItem, txtAddress.Text, txtTel.Text, txtUsername.Text, txtPassword.Text}
            Dim pr() As String = {"@name", "@date", "@gender", "@address", "@tel", "@username", "@password"}
            InsertData(sql, pr, val)
            Employee.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class