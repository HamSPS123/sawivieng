Public Class EditEmployee

    Public Property eID As String
    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        dt = loadingData("SELECT * FROM employee WHERE emp_id = '" + eID + "'")

        If dt.Rows.Count <> 0 Then
            txtName.Text = dt.Rows(0)(1).ToString
            txtDate.Value = dt.Rows(0)(2)
            txtGender.SelectedItem = dt.Rows(0)(3)
            txtAddress.Text = dt.Rows(0)(4)
            txtTel.Text = dt.Rows(0)(5)
            txtUsername.Text = dt.Rows(0)(6)
            txtPassword.Text = dt.Rows(0)(7)
        End If
    End Sub

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

            Dim sql As String = "UPDATE employee SET emp_name=@name,emp_dob=@date,emp_gender=@gender,emp_address=@address,emp_tel=@tel,emp_username=@username,emp_password=@password WHERE emp_id = '" + eID + "'"
            Dim val() As Object = {txtName.Text, txtDate.Value, txtGender.SelectedItem, txtAddress.Text, txtTel.Text, txtUsername.Text, txtPassword.Text}
            Dim pr() As String = {"@name", "@date", "@gender", "@address", "@tel", "@username", "@password"}
            UpdateData(sql, pr, val)
            Employee.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class