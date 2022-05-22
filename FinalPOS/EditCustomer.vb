Public Class EditCustomer
    Public Property eID As String
    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = loadingData("SELECT * FROM customer WHERE cus_id = '" + eID + "'")

        If dt.Rows.Count <> 0 Then
            txtName.Text = dt.Rows(0)(1)
            txtDate.Value = dt.Rows(0)(3)
            txtGender.SelectedItem = dt.Rows(0)(2)
            txtAddress.Text = dt.Rows(0)(4)
            txtTel.Text = dt.Rows(0)(5)
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
        Else

            Dim sql As String = "UPDATE customer SET cus_name=@name,cus_dob=@date,cus_gender=@gender,cus_address=@address,cus_tel=@tel WHERE cus_id = '" + eID + "'"
            Dim val() As Object = {txtName.Text, txtDate.Value, txtGender.SelectedItem, txtAddress.Text, txtTel.Text}
            Dim pr() As String = {"@name", "@date", "@gender", "@address", "@tel"}
            UpdateData(sql, pr, val)
            Customer.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class