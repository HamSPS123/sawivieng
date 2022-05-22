Public Class EditMedicine
    Public Property eID As String
    Private Sub EditMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBindingData(txtType, "type", "type_name", "type_id")
        cboBindingData(txtUnit, "unit", "unit_name", "unit_id")

        Dim dt As New DataTable

        dt = loadingData("SELECT * FROM medicine WHERE mdc_id = '" + eID + "'")

        If dt.Rows.Count <> 0 Then
            txtName.Text = dt.Rows(0)(1)
            txtType.SelectedValue = dt.Rows(0)(2)
            txtUnit.SelectedValue = dt.Rows(0)(3)
            txtStock.Value = dt.Rows(0)(4)
            txtExpired.Value = dt.Rows(0)(5)
            txtPrice.Text = dt.Rows(0)(6)
            txtDetail.Text = dt.Rows(0)(7)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dashboard.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຊື່ຢາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStock.Value = 0 Then
            MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນຢາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນລາຄາ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else




            Dim sql As String = "UPDATE medicine SET mdc_name=@name,type_id=@type,unit_id=@unit,mdc_stock=@stock,expired_date=@date,mdc_price=@price,mdc_detail=@detail WHERE mdc_id='" + eID + "'"
            Dim val() As Object = {txtName.Text, txtType.SelectedValue, txtUnit.SelectedValue, txtStock.Value, txtExpired.Value, txtPrice.Text, txtDetail.Text}
            Dim pr() As String = {"@name", "@type", "@unit", "@stock", "@date", "@price", "@detail"}
            UpdateData(sql, pr, val)
            Medicine.showData("")
            Dashboard.Enabled = True

            Me.Close()
        End If
    End Sub
End Class